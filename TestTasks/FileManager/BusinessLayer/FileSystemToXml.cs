using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FileManager.DataAccessLayer;

namespace FileManager.BusinessLayer
{
    public class FileSystemToXml
    {
        private string _fileName;
        private int _pathLength;
        private XElement _doc;

        public void Init(string file, string dir)
        {
            _fileName = file;
            _pathLength = dir.Length; 
            _doc = new XElement("dir", new XAttribute("fullname", dir));
        }

        public void MakeXml(PropertyInfo fileInfo)
        {
            try
            {
                GetDirectoryXml(_doc, fileInfo);
            }
            catch (Exception ex)
            {
                SaveExc.Save(ex);
            }
        }

        public void SaveXml()
        {
            try
            {
                _doc.Save(_fileName);
            }
            catch (UnauthorizedAccessException ex)
            {
                SaveExc.Save(ex);
            }
            catch (Exception ex)
            {
                SaveExc.Save(ex);
            }
        }

        private void GetDirectoryXml(XElement elem, PropertyInfo fileInfo)
        {
            var xName = "dir";
            XElement find = elem;
            var nameDirs = fileInfo.FullName.Remove(0, _pathLength).TrimStart('\\', '/').Split('\\', '/');
            if (string.IsNullOrEmpty(nameDirs[0]))
            {
                // Игнорируем дерикторию укзанную для перебора поддиректорий
                return;
            }
            
            for (var i = 0; i < nameDirs.Length; i++)
            {
                // Полное имя файла "FullName" состоит из последовательности директорий и последним идет имя файла (dir\dir\dir\file)
                if (i == nameDirs.Length - 1 && fileInfo.IsFile)
                {
                    xName = "file";
                }
                var name = nameDirs[i];
                IEnumerable<XElement> findElements =
                    from el in find.Descendants(xName)
                    where (string)el.Attribute("name") == name
                    select el;
                
                // Если узел с заданными параметрами не существует - создаем
                if (!findElements.Any())
                {
                    find.Add(new XElement(xName
                        , new XAttribute("name", fileInfo.Name)
                        , new XAttribute("creationtime", fileInfo.CreationTime)
                        , new XAttribute("lastaccesstime", fileInfo.LastAccessTime)
                        , new XAttribute("lastwritetime", fileInfo.LastWriteTime)
                        ));
                }
                else
                {
                    find = findElements.First();
                }
            }
        }
    }
}
