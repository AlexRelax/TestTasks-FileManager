using System;
using System.Threading;
using System.Windows.Forms;
using FileManager.BusinessLayer;

namespace FileManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Commander());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ExceptionHandler(e.ExceptionObject as Exception, sender);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ExceptionHandler(e.Exception, sender);
        }

        static void ExceptionHandler(Exception exception, object sender)
        {
            if (exception == null)
            {
                MessageBox.Show("Unknown exception");
                ThreadAbort(sender);
                return;
            }

            SaveExc.Save(exception);
            MessageBox.Show(string.Format("Message: {0}"
                            , exception.Message)
                            , "Error"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);

            ThreadAbort(sender);
            Application.Exit();
        }

        public static void ThreadAbort(object sender)
        {
            try
            {
                var thread = sender as Thread;
                if (thread == null)
                    return;
                thread.Abort();
                thread.Join();
            }
            catch (ThreadAbortException)
            {
                //Do nothing
            }
        }
    }
}
