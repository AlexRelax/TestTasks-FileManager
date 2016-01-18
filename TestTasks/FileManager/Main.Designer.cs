using FileManager;

namespace FileManager
{
    partial class Commander
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commander));
            this.imageFolders = new System.Windows.Forms.ImageList(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewFiles = new FileManager.BufferedTreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBoxWrite = new System.Windows.Forms.CheckBox();
            this.cBoxModify = new System.Windows.Forms.CheckBox();
            this.cBoxReadAndExecute = new System.Windows.Forms.CheckBox();
            this.cBoxRead = new System.Windows.Forms.CheckBox();
            this.cBoxFullControl = new System.Windows.Forms.CheckBox();
            this.lblCurentUser = new System.Windows.Forms.Label();
            this.lCurentUser = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lOwner = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.cBoxHidden = new System.Windows.Forms.CheckBox();
            this.cBoxEncrypted = new System.Windows.Forms.CheckBox();
            this.cBoxArchive = new System.Windows.Forms.CheckBox();
            this.cBoxNotContentIndexed = new System.Windows.Forms.CheckBox();
            this.cBoxCompressed = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreat = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lCreat = new System.Windows.Forms.Label();
            this.lWrite = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lAccess = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grCooseFile = new System.Windows.Forms.GroupBox();
            this.txtFileSave = new System.Windows.Forms.TextBox();
            this.btnCooseFile = new System.Windows.Forms.Button();
            this.grShowСatalog = new System.Windows.Forms.GroupBox();
            this.btnCooseFileWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grCooseFile.SuspendLayout();
            this.grShowСatalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageFolders
            // 
            this.imageFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageFolders.ImageStream")));
            this.imageFolders.TransparentColor = System.Drawing.Color.Transparent;
            this.imageFolders.Images.SetKeyName(0, "Folder.png");
            this.imageFolders.Images.SetKeyName(1, "OpenFolder.png");
            this.imageFolders.Images.SetKeyName(2, "File.png");
            this.imageFolders.Images.SetKeyName(3, "FileFocus.png");
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(7, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(638, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplay.Location = new System.Drawing.Point(6, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(334, 30);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Отобразить";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(12, 105);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewFiles);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerMain.Panel2.Controls.Add(this.btnDisplay);
            this.splitContainerMain.Size = new System.Drawing.Size(770, 472);
            this.splitContainerMain.SplitterDistance = 420;
            this.splitContainerMain.SplitterIncrement = 3;
            this.splitContainerMain.TabIndex = 6;
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFiles.ImageIndex = 0;
            this.treeViewFiles.ImageList = this.imageFolders;
            this.treeViewFiles.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeViewFiles.Location = new System.Drawing.Point(3, 4);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.SelectedImageIndex = 0;
            this.treeViewFiles.Size = new System.Drawing.Size(414, 465);
            this.treeViewFiles.TabIndex = 4;
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            this.treeViewFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeViewFiles_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lblCurentUser);
            this.groupBox3.Controls.Add(this.lCurentUser);
            this.groupBox3.Controls.Add(this.lblOwner);
            this.groupBox3.Controls.Add(this.lOwner);
            this.groupBox3.Location = new System.Drawing.Point(6, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 218);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cBoxWrite);
            this.groupBox4.Controls.Add(this.cBoxModify);
            this.groupBox4.Controls.Add(this.cBoxReadAndExecute);
            this.groupBox4.Controls.Add(this.cBoxRead);
            this.groupBox4.Controls.Add(this.cBoxFullControl);
            this.groupBox4.Location = new System.Drawing.Point(6, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 133);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Права текущего пользователя";
            // 
            // cBoxWrite
            // 
            this.cBoxWrite.AutoCheck = false;
            this.cBoxWrite.AutoSize = true;
            this.cBoxWrite.Location = new System.Drawing.Point(6, 111);
            this.cBoxWrite.Name = "cBoxWrite";
            this.cBoxWrite.Size = new System.Drawing.Size(63, 17);
            this.cBoxWrite.TabIndex = 16;
            this.cBoxWrite.Text = "Запись";
            this.cBoxWrite.UseVisualStyleBackColor = true;
            // 
            // cBoxModify
            // 
            this.cBoxModify.AutoCheck = false;
            this.cBoxModify.AutoSize = true;
            this.cBoxModify.Location = new System.Drawing.Point(6, 42);
            this.cBoxModify.Name = "cBoxModify";
            this.cBoxModify.Size = new System.Drawing.Size(84, 17);
            this.cBoxModify.TabIndex = 15;
            this.cBoxModify.Text = "Изменение";
            this.cBoxModify.UseVisualStyleBackColor = true;
            // 
            // cBoxReadAndExecute
            // 
            this.cBoxReadAndExecute.AutoCheck = false;
            this.cBoxReadAndExecute.AutoSize = true;
            this.cBoxReadAndExecute.Location = new System.Drawing.Point(6, 89);
            this.cBoxReadAndExecute.Name = "cBoxReadAndExecute";
            this.cBoxReadAndExecute.Size = new System.Drawing.Size(137, 17);
            this.cBoxReadAndExecute.TabIndex = 14;
            this.cBoxReadAndExecute.Text = "Чтение и выполнение";
            this.cBoxReadAndExecute.UseVisualStyleBackColor = true;
            // 
            // cBoxRead
            // 
            this.cBoxRead.AutoCheck = false;
            this.cBoxRead.AutoSize = true;
            this.cBoxRead.Location = new System.Drawing.Point(6, 66);
            this.cBoxRead.Name = "cBoxRead";
            this.cBoxRead.Size = new System.Drawing.Size(63, 17);
            this.cBoxRead.TabIndex = 13;
            this.cBoxRead.Text = "Чтение";
            this.cBoxRead.UseVisualStyleBackColor = true;
            // 
            // cBoxFullControl
            // 
            this.cBoxFullControl.AutoCheck = false;
            this.cBoxFullControl.AutoSize = true;
            this.cBoxFullControl.Location = new System.Drawing.Point(6, 19);
            this.cBoxFullControl.Name = "cBoxFullControl";
            this.cBoxFullControl.Size = new System.Drawing.Size(103, 17);
            this.cBoxFullControl.TabIndex = 12;
            this.cBoxFullControl.Text = "Полный доступ";
            this.cBoxFullControl.UseVisualStyleBackColor = true;
            // 
            // lblCurentUser
            // 
            this.lblCurentUser.AutoSize = true;
            this.lblCurentUser.Location = new System.Drawing.Point(3, 39);
            this.lblCurentUser.Name = "lblCurentUser";
            this.lblCurentUser.Size = new System.Drawing.Size(135, 13);
            this.lblCurentUser.TabIndex = 7;
            this.lblCurentUser.Text = "Текущий пользователь : ";
            // 
            // lCurentUser
            // 
            this.lCurentUser.AutoSize = true;
            this.lCurentUser.Location = new System.Drawing.Point(138, 39);
            this.lCurentUser.Name = "lCurentUser";
            this.lCurentUser.Size = new System.Drawing.Size(0, 13);
            this.lCurentUser.TabIndex = 8;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(3, 16);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(65, 13);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Владелец : ";
            // 
            // lOwner
            // 
            this.lOwner.AutoSize = true;
            this.lOwner.Location = new System.Drawing.Point(64, 16);
            this.lOwner.Name = "lOwner";
            this.lOwner.Size = new System.Drawing.Size(0, 13);
            this.lOwner.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cBoxReadOnly);
            this.groupBox2.Controls.Add(this.cBoxHidden);
            this.groupBox2.Controls.Add(this.cBoxEncrypted);
            this.groupBox2.Controls.Add(this.cBoxArchive);
            this.groupBox2.Controls.Add(this.cBoxNotContentIndexed);
            this.groupBox2.Controls.Add(this.cBoxCompressed);
            this.groupBox2.Location = new System.Drawing.Point(6, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 78);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // cBoxReadOnly
            // 
            this.cBoxReadOnly.AutoCheck = false;
            this.cBoxReadOnly.AutoSize = true;
            this.cBoxReadOnly.Location = new System.Drawing.Point(6, 10);
            this.cBoxReadOnly.Name = "cBoxReadOnly";
            this.cBoxReadOnly.Size = new System.Drawing.Size(121, 17);
            this.cBoxReadOnly.TabIndex = 11;
            this.cBoxReadOnly.Text = "Только для чтения";
            this.cBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // cBoxHidden
            // 
            this.cBoxHidden.AutoCheck = false;
            this.cBoxHidden.AutoSize = true;
            this.cBoxHidden.Location = new System.Drawing.Point(136, 10);
            this.cBoxHidden.Name = "cBoxHidden";
            this.cBoxHidden.Size = new System.Drawing.Size(72, 17);
            this.cBoxHidden.TabIndex = 12;
            this.cBoxHidden.Text = "Скрытый";
            this.cBoxHidden.UseVisualStyleBackColor = true;
            // 
            // cBoxEncrypted
            // 
            this.cBoxEncrypted.AutoCheck = false;
            this.cBoxEncrypted.AutoSize = true;
            this.cBoxEncrypted.Location = new System.Drawing.Point(136, 58);
            this.cBoxEncrypted.Name = "cBoxEncrypted";
            this.cBoxEncrypted.Size = new System.Drawing.Size(84, 17);
            this.cBoxEncrypted.TabIndex = 16;
            this.cBoxEncrypted.Text = "Шифровать";
            this.cBoxEncrypted.UseVisualStyleBackColor = true;
            // 
            // cBoxArchive
            // 
            this.cBoxArchive.AutoCheck = false;
            this.cBoxArchive.AutoSize = true;
            this.cBoxArchive.Location = new System.Drawing.Point(6, 34);
            this.cBoxArchive.Name = "cBoxArchive";
            this.cBoxArchive.Size = new System.Drawing.Size(97, 17);
            this.cBoxArchive.TabIndex = 13;
            this.cBoxArchive.Text = "Архивировать";
            this.cBoxArchive.UseVisualStyleBackColor = true;
            // 
            // cBoxNotContentIndexed
            // 
            this.cBoxNotContentIndexed.AutoCheck = false;
            this.cBoxNotContentIndexed.AutoSize = true;
            this.cBoxNotContentIndexed.Location = new System.Drawing.Point(136, 34);
            this.cBoxNotContentIndexed.Name = "cBoxNotContentIndexed";
            this.cBoxNotContentIndexed.Size = new System.Drawing.Size(105, 17);
            this.cBoxNotContentIndexed.TabIndex = 14;
            this.cBoxNotContentIndexed.Text = "Индексировать";
            this.cBoxNotContentIndexed.UseVisualStyleBackColor = true;
            // 
            // cBoxCompressed
            // 
            this.cBoxCompressed.AutoCheck = false;
            this.cBoxCompressed.AutoSize = true;
            this.cBoxCompressed.Location = new System.Drawing.Point(6, 58);
            this.cBoxCompressed.Name = "cBoxCompressed";
            this.cBoxCompressed.Size = new System.Drawing.Size(72, 17);
            this.cBoxCompressed.TabIndex = 15;
            this.cBoxCompressed.Text = "Сжимать";
            this.cBoxCompressed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblWrite);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCreat);
            this.groupBox1.Controls.Add(this.lblAccess);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Controls.Add(this.lCreat);
            this.groupBox1.Controls.Add(this.lWrite);
            this.groupBox1.Controls.Add(this.lSize);
            this.groupBox1.Controls.Add(this.lAccess);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(6, 55);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(59, 13);
            this.lblWrite.TabIndex = 2;
            this.lblWrite.Text = "Изменен :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя : ";
            // 
            // lblCreat
            // 
            this.lblCreat.AutoSize = true;
            this.lblCreat.Location = new System.Drawing.Point(6, 31);
            this.lblCreat.Name = "lblCreat";
            this.lblCreat.Size = new System.Drawing.Size(50, 13);
            this.lblCreat.TabIndex = 1;
            this.lblCreat.Text = "Создан :";
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Location = new System.Drawing.Point(6, 79);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(51, 13);
            this.lblAccess.TabIndex = 3;
            this.lblAccess.Text = "Открыт :";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(67, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 13);
            this.lName.TabIndex = 4;
            // 
            // lCreat
            // 
            this.lCreat.AutoSize = true;
            this.lCreat.Location = new System.Drawing.Point(67, 29);
            this.lCreat.Name = "lCreat";
            this.lCreat.Size = new System.Drawing.Size(0, 13);
            this.lCreat.TabIndex = 5;
            // 
            // lWrite
            // 
            this.lWrite.AutoSize = true;
            this.lWrite.Location = new System.Drawing.Point(67, 55);
            this.lWrite.Name = "lWrite";
            this.lWrite.Size = new System.Drawing.Size(0, 13);
            this.lWrite.TabIndex = 6;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(70, 102);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(0, 13);
            this.lSize.TabIndex = 9;
            // 
            // lAccess
            // 
            this.lAccess.AutoSize = true;
            this.lAccess.Location = new System.Drawing.Point(67, 79);
            this.lAccess.Name = "lAccess";
            this.lAccess.Size = new System.Drawing.Size(0, 13);
            this.lAccess.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 102);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Размер :";
            // 
            // grCooseFile
            // 
            this.grCooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grCooseFile.Controls.Add(this.txtFileSave);
            this.grCooseFile.Controls.Add(this.btnCooseFile);
            this.grCooseFile.Location = new System.Drawing.Point(12, 4);
            this.grCooseFile.Name = "grCooseFile";
            this.grCooseFile.Size = new System.Drawing.Size(770, 47);
            this.grCooseFile.TabIndex = 8;
            this.grCooseFile.TabStop = false;
            this.grCooseFile.Text = "Файл для хранения ";
            // 
            // txtFileSave
            // 
            this.txtFileSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileSave.Location = new System.Drawing.Point(7, 20);
            this.txtFileSave.Name = "txtFileSave";
            this.txtFileSave.Size = new System.Drawing.Size(638, 20);
            this.txtFileSave.TabIndex = 1;
            // 
            // btnCooseFile
            // 
            this.btnCooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCooseFile.Location = new System.Drawing.Point(651, 21);
            this.btnCooseFile.Name = "btnCooseFile";
            this.btnCooseFile.Size = new System.Drawing.Size(113, 21);
            this.btnCooseFile.TabIndex = 0;
            this.btnCooseFile.Text = "Выбор файла";
            this.btnCooseFile.UseVisualStyleBackColor = true;
            this.btnCooseFile.Click += new System.EventHandler(this.btnCooseFile_Click);
            // 
            // grShowСatalog
            // 
            this.grShowСatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grShowСatalog.Controls.Add(this.btnCooseFileWork);
            this.grShowСatalog.Controls.Add(this.txtPath);
            this.grShowСatalog.Location = new System.Drawing.Point(12, 52);
            this.grShowСatalog.Name = "grShowСatalog";
            this.grShowСatalog.Size = new System.Drawing.Size(770, 46);
            this.grShowСatalog.TabIndex = 9;
            this.grShowСatalog.TabStop = false;
            this.grShowСatalog.Text = "Каталог для отображения";
            // 
            // btnCooseFileWork
            // 
            this.btnCooseFileWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCooseFileWork.Location = new System.Drawing.Point(651, 18);
            this.btnCooseFileWork.Name = "btnCooseFileWork";
            this.btnCooseFileWork.Size = new System.Drawing.Size(113, 21);
            this.btnCooseFileWork.TabIndex = 8;
            this.btnCooseFileWork.Text = "Выбор директории";
            this.btnCooseFileWork.UseVisualStyleBackColor = true;
            this.btnCooseFileWork.Click += new System.EventHandler(this.btnCooseFileWork_Click);
            // 
            // Commander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 591);
            this.Controls.Add(this.grShowСatalog);
            this.Controls.Add(this.grCooseFile);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "Commander";
            this.Text = "Commander";
            this.Load += new System.EventHandler(this.Commander_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grCooseFile.ResumeLayout(false);
            this.grCooseFile.PerformLayout();
            this.grShowСatalog.ResumeLayout(false);
            this.grShowСatalog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BufferedTreeView treeViewFiles;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ImageList imageFolders;
        private System.Windows.Forms.GroupBox grCooseFile;
        private System.Windows.Forms.TextBox txtFileSave;
        private System.Windows.Forms.Button btnCooseFile;
        private System.Windows.Forms.GroupBox grShowСatalog;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.Label lblCreat;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lCreat;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lAccess;
        private System.Windows.Forms.Label lWrite;
        private System.Windows.Forms.CheckBox cBoxEncrypted;
        private System.Windows.Forms.CheckBox cBoxCompressed;
        private System.Windows.Forms.CheckBox cBoxNotContentIndexed;
        private System.Windows.Forms.CheckBox cBoxArchive;
        private System.Windows.Forms.CheckBox cBoxHidden;
        private System.Windows.Forms.CheckBox cBoxReadOnly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCooseFileWork;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCurentUser;
        private System.Windows.Forms.Label lCurentUser;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lOwner;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cBoxWrite;
        private System.Windows.Forms.CheckBox cBoxModify;
        private System.Windows.Forms.CheckBox cBoxReadAndExecute;
        private System.Windows.Forms.CheckBox cBoxRead;
        private System.Windows.Forms.CheckBox cBoxFullControl;
    }
}

