using FileManager.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FileManager.BusinessLayer
{
    public class FileSystemEnumerate
    {
        private readonly List<PropertyInfo> _directoryTree;

        private readonly object _lock = new object();
        private readonly MonitorWrapper _monitor;

        public FileSystemEnumerate()
        {
            _directoryTree = new List<PropertyInfo>();
            _monitor = new MonitorWrapper(ref _lock);
        }

        public int GetDirectoryTreeCount()
        {
            return _directoryTree.Count;
        }

        public PropertyInfo GetDirectory(int i)
        {
            return _monitor.TryLock(() =>
            {
                if (i < _directoryTree.Count)
                {
                    var propertyInfo = _directoryTree[i];
                    return propertyInfo;
                }
                return default(PropertyInfo);
            });
        }

        public void WalkDirectoryTree(string path)
        {
            var dirInfo = new DirectoryInfo(path);
            var di = new DriveInfo(dirInfo.Root.Name);

            if (!di.IsReady)
            {
                Console.WriteLine("The drive [{0}] could not be read.", di.Name);
                return;
            } 
            if (!dirInfo.Exists)
            {
                Console.WriteLine("Directory [{0}] does not exist.", dirInfo.FullName);
                return;
            }
            _directoryTree.Clear();

            WalkDirectoryTree(dirInfo);
        }
        private void WalkDirectoryTree(DirectoryInfo dir)
        {
            long sizeDir = 0;
            DirectoryInfo[] subDirs = null;

            _monitor.Lock(() => _directoryTree.Add(FillPropertyInfo(false, dir)));
            try
            {
                subDirs = dir.GetDirectories();
            }
            catch (UnauthorizedAccessException ex)
            {
                // This code just writes out the message and continues to recurse. 
                // You may decide to do something different here. For example, you 
                // can try to elevate your privileges and access the file again. 
                SaveExc.Save(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                SaveExc.Save(ex);
            }

            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                   WalkDirectoryTree(dirInfo);
                }

                foreach (FileInfo fi in dir.GetFiles("*.*"))
                {
                    _monitor.Lock(() => _directoryTree.Add(FillPropertyInfo(true, fi)));
                }
            }
        }

        private PropertyInfo FillPropertyInfo(bool isFile, DirectoryInfo info) {
            var file = FillPropertyInfo(isFile, (FileSystemInfo)info);
           
            GetAccessRules(info.GetAccessControl(AccessControlSections.Access), file);
            
            return file;
        }

        private PropertyInfo FillPropertyInfo(bool isFile, FileInfo info)
        {
            var file = FillPropertyInfo(isFile, (FileSystemInfo) info);
            file.Size = info.Length;
            GetAccessRules(info.GetAccessControl(AccessControlSections.Access), file);

            return file;
        }

        private PropertyInfo FillPropertyInfo(bool isFile, FileSystemInfo info)
        {
            var file = new PropertyInfo
            {
                IsFile = isFile,
                Name = info.Name,
                FullName = info.FullName,
                CreationTime = info.CreationTime,
                LastAccessTime = info.LastAccessTime,
                LastWriteTime = info.LastWriteTime,
                ReadOnly = false,
                Hidden = false,
                Archive = false,
                NotContentIndexed = false,
                Compressed = false,
                Encrypted = false,
                Owner = string.Empty
            };
            FileAttributes attr = info.Attributes;
            if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                file.ReadOnly = true;
            }
            if ((attr & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                file.Hidden = true;
            }
            if ((attr & FileAttributes.Archive) == FileAttributes.Archive)
            {
                file.Archive = true;
            }
            if ((attr & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
            {
                file.NotContentIndexed = true;
            }
            if ((attr & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                file.Compressed = true;
            }
            if ((attr & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            {
                file.Encrypted = true;
            }
            return file;
        }

        private void GetAccessRules(FileSystemSecurity fsSecurity, PropertyInfo file)
        {
            try
            {
                var getOwner = fsSecurity.GetOwner(typeof (SecurityIdentifier));
                if (getOwner != null)
                {
                    string ownerIdentifier = fsSecurity.GetOwner(typeof(SecurityIdentifier)).Value;
                    //var owner = fsSecurity.GetOwner(typeof(SecurityIdentifier));
                    //var nameOwner = owner.Translate(typeof(NTAccount)).Value;
                    file.Owner = ownerIdentifier;
                }
            }
            catch(Exception ex){
                 /* 
                   System.Security.Principal.IdentityNotMappedException was unhandled
                   Message="Some or all identity references could not be translated."
                 */
                SaveExc.Save(ex);
            }
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            AuthorizationRuleCollection rules = fsSecurity.GetAccessRules(true, true, typeof(SecurityIdentifier));
            foreach (FileSystemAccessRule rl in rules)
            {
                GetAccessRules(wi, rl, FileSystemRights.FullControl, file);
                GetAccessRules(wi, rl, FileSystemRights.Modify, file);
                GetAccessRules(wi, rl, FileSystemRights.Read, file);
                GetAccessRules(wi, rl, FileSystemRights.ReadAndExecute, file);
                GetAccessRules(wi, rl, FileSystemRights.Write, file);
            }
        }

        private void GetAccessRules(WindowsIdentity wi, FileSystemAccessRule fsAccessRule, FileSystemRights fsRight, PropertyInfo file)
        {
            SecurityIdentifier sid = (SecurityIdentifier)fsAccessRule.IdentityReference;
            if (((fsAccessRule.FileSystemRights & fsRight) == fsRight))
            {
                if (wi != null &&
                    ((sid.IsAccountSid() && wi.User == sid)
                    || (wi.Groups != null && (!sid.IsAccountSid() && wi.Groups.Contains(sid)))))
                {
                    var isAllow = fsAccessRule.AccessControlType == AccessControlType.Allow;
                    switch (fsRight)
                    {
                        case FileSystemRights.FullControl:
                            file.FullControl = isAllow;
                            break;
                        case FileSystemRights.Modify:
                            file.Modify = isAllow;
                            break;
                        case FileSystemRights.Read:
                            file.Read = isAllow;
                            break;
                        case FileSystemRights.ReadAndExecute:
                            file.ReadAndExecute = isAllow;
                            break;
                        case FileSystemRights.Write:
                            file.Write = isAllow;
                            break;
                    }
                }
            }
        }
    }
}
