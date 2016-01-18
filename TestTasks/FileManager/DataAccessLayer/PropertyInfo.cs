using System;

namespace FileManager.DataAccessLayer
{
    /*
    * имя, 
    * дата создания, 
    * дата модификации, 
    * дата последнего доступа, 
    * атрибуты, 
    * размер (только для файлов; 
    * реализация размера для директорий будет засчитана как плюс), 
     
    * владелец, а также допустимые права (
    * запись, 
    * чтение, 
    * удаление 
    * и т.п.) для текущего пользователя
    */
    public class PropertyInfo
    {
        public bool IsFile { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public long Size { get; set; }
        // Attributes
        public bool ReadOnly { get; set; }
        public bool Hidden { get; set; }
        public bool Archive { get; set; }
        public bool NotContentIndexed { get; set; }
        public bool Compressed { get; set; }
        public bool Encrypted { get; set; }
        // Owner
        public string Owner { get; set; }
        // Rules
        public bool FullControl { get; set; }
        public bool Modify { get; set; }
        public bool Read { get; set; }
        public bool ReadAndExecute { get; set; }
        public bool Write { get; set; }
    }
}
