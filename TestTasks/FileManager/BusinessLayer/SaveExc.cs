using System;

namespace FileManager.BusinessLayer
{
    public static class SaveExc
    {
        public static void Save(Exception ex)
        {
            string innerError = string.Empty;
            if (ex.InnerException != null)
                innerError = ex.InnerException.Message;
            
             Console.WriteLine("Message = " + ex.Message,
                 "\nStackTrace = " + ex.StackTrace,
                 "\nInnerError = " + innerError);
          
        }
    }
}