using FileManager.BusinessLayer;
using System;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using FileManager.DataAccessLayer;

namespace FileManager
{
    public partial class Commander : Form
    {
        private string _workDir = string.Empty;
        private string _fileDefault = "index.xml";
        private string _pathDefault;
        private int _workDirLength;

        private Thread _threadEnumerate;
        private Thread _threadShow;
        private Thread _threadSave;

        private volatile bool _enumerationEnded;

        readonly FileSystemEnumerate _fsEnumerate = new FileSystemEnumerate();
        readonly FileSystemToXml _fsToXml = new FileSystemToXml();

        public Commander()
        {
            InitializeComponent();
            
            Init();
        }

        void Init()
        {
            EmptyCheckBox();

            txtPath.Text = _workDir;
            _workDirLength = _workDir.Length;

            _pathDefault = Path.Combine(Application.StartupPath, _fileDefault);
            txtFileSave.Text = Application.StartupPath;
        }
        
        void Start(bool isSave = true)
        {
            _workDir = txtPath.Text.Trim();
            _workDirLength = _workDir.Length;

            if (string.IsNullOrEmpty(_workDir))
            {
                MessageBox.Show("Укажите директорию для сканирования", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(_workDir))
            {
                MessageBox.Show(string.Format("Директория {0} не существует!", _workDir), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.ThreadAbort(_threadSave); 
            Program.ThreadAbort(_threadShow);
            Program.ThreadAbort(_threadEnumerate); 

            _enumerationEnded = false;

            _threadEnumerate = new Thread(EnumerateDirs) { IsBackground = true };
            _threadEnumerate.Start();

            treeViewFiles.Nodes.Clear();
            _threadShow = new Thread(ShowDirs) { IsBackground = true };
            _threadShow.Start(treeViewFiles.Nodes);

            if (isSave)
            {
                _threadSave = new Thread(SaveDirs) {IsBackground = true};
                _threadSave.Start();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var isSave = true;
            if (string.IsNullOrEmpty(txtFileSave.Text))
            {
                if (DialogResult.Yes != MessageBox.Show("Не выбран файл для занесения результатов. Продолжить?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                isSave = false;
            }
            Start(isSave);
        }

        private void btnCooseFileWork_Click(object sender, EventArgs e)
        {
            var chooseFolder = new FolderBrowserDialog ();
            if (chooseFolder.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = _workDir = chooseFolder.SelectedPath;
            }
        }

        private void btnCooseFile_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*",
                RestoreDirectory = true,
                FileName = _fileDefault
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtFileSave.Text = _pathDefault = saveFile.FileName;
            }
        }

        private void EmptyCheckBox()
        {
            cBoxArchive.Checked = false;
            cBoxCompressed.Checked = false;
            cBoxEncrypted.Checked = false;
            cBoxHidden.Checked = false;
            cBoxNotContentIndexed.Checked = false;
            cBoxReadOnly.Checked = false;
            cBoxFullControl.Checked = false;
            cBoxModify.Checked = false;
            cBoxRead.Checked = false;
            cBoxReadAndExecute.Checked = false;
            cBoxWrite.Checked = false;
            lCurentUser.Text = string.Empty;
            lOwner.Text = string.Empty;
        }

        private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e != null && e.Node != null)
            {
                var file = e.Node.Tag as PropertyInfo;
                if (file != null)
                {
                    lName.Text = file.Name;
                    lCreat.Text = file.CreationTime.ToString(CultureInfo.InvariantCulture);
                    lWrite.Text = file.LastWriteTime.ToString(CultureInfo.InvariantCulture);
                    lAccess.Text = file.LastAccessTime.ToString(CultureInfo.InvariantCulture);
                    lSize.Text = string.Format("{0} kb", file.Size.ToString("0,0", CultureInfo.InvariantCulture));
                    cBoxArchive.Checked = file.Archive;
                    cBoxCompressed.Checked = file.Compressed;
                    cBoxEncrypted.Checked = file.Encrypted;
                    cBoxHidden.Checked = file.Hidden;
                    cBoxNotContentIndexed.Checked = file.NotContentIndexed;
                    cBoxReadOnly.Checked = file.ReadOnly;
                    cBoxFullControl.Checked = file.FullControl;
                    cBoxModify.Checked = file.Modify;
                    cBoxRead.Checked = file.Read;
                    cBoxReadAndExecute.Checked = file.ReadAndExecute;
                    cBoxWrite.Checked = file.Write;
                    var windowsIdentity = WindowsIdentity.GetCurrent();
                    if (windowsIdentity != null)
                        lCurentUser.Text = windowsIdentity.Name;
                    lOwner.Text = file.Owner;
                }
            }
        }
        //--------------------------------------------------------
        private void EnumerateDirs()
        {
            try
            {
                _fsEnumerate.WalkDirectoryTree(_workDir);
                _enumerationEnded = true;
            }
            catch (Exception ex)
            {
                SaveExc.Save(ex);
            }
        }

        private void SaveDirs()
        {
            try
            {
                _fsToXml.Init(_pathDefault, _workDir);

                MakeWork(_fsToXml.MakeXml);

                _fsToXml.SaveXml();
            }
            catch (Exception ex)
            {
                SaveExc.Save(ex);
            }
        }

        private void ShowDirs(object o)
        {
            var nodes = o as TreeNodeCollection;
            if (nodes == null)
            {
                return;
            }

            int i = 0;
            
            while (!_enumerationEnded || i < _fsEnumerate.GetDirectoryTreeCount())
            {
                var dir = _fsEnumerate.GetDirectory(i);
                if (dir != default(PropertyInfo))
                {
                    InvokeInUIThread(treeViewFiles, () => FillSubNodes(nodes, dir));
                    i++;
                }
            }
        }

        private void MakeWork(Action<PropertyInfo> action)
        {
            int i = 0;
            // Пока выполняется сканирование указанной директории или не все элементы обработаны
            while (!_enumerationEnded || i < _fsEnumerate.GetDirectoryTreeCount())
            {
                var dir = _fsEnumerate.GetDirectory(i);
                if (dir != default(PropertyInfo))
                {
                    action(dir);
                    i++;
                }
            }
        }

        private void FillSubNodes(TreeNodeCollection nodes, PropertyInfo fileInfo)
        {
            // Удаляем из полного пути путь к указанной директории для перебора поддиректорий
            var nameDirs = fileInfo.FullName.Remove(0, _workDirLength).TrimStart('\\', '/').Split('\\', '/');
            if (string.IsNullOrEmpty(nameDirs[0]))
            {
                // Игнорируем дерикторию указанную для перебора поддиректорий
                return;
            }
            foreach (var name in nameDirs)
            {
                // Если в коллекции узлов нет указанного узла, то добавляем
                if (!nodes.ContainsKey(name))
                {
                    var indexImg = fileInfo.IsFile ? 2 : 0;
                    var indexSelectImg = fileInfo.IsFile ? 3 : 1;
                    TreeNode node = new TreeNode(name, indexImg, indexSelectImg)
                    {
                        Name = name,
                        Tag = fileInfo
                    };
                    
                    nodes.Add(node);
                }
                else // иначе - переходим на дочерний уровень
                {
                    nodes = nodes[name].Nodes;
                }
            }
        }

        private void InvokeInUIThread(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(() => { action(); }));
            }
            else
            {
                action();
            }
        }

        private void treeViewFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (treeViewFiles.SelectedNode != null)
            {
                if ((char)Keys.Return == e.KeyChar || (char)Keys.Space == e.KeyChar)
                {
                    if (treeViewFiles.SelectedNode.IsExpanded)
                    {
                        treeViewFiles.SelectedNode.Collapse();
                    }
                    else
                    {
                        treeViewFiles.SelectedNode.Expand();
                    }
                }
            }
        }

        private void Commander_Load(object sender, EventArgs e)
        {
            btnDisplay.Select();
        }
        //--------------------------------------------------------
    }
}
