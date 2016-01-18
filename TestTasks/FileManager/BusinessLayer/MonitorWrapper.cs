using System;
using System.Threading;

namespace FileManager.BusinessLayer
{
    public class MonitorWrapper
    {
        private readonly object _lock;

        //pass object by reference into constructor to have ability
        //to use MonitorWrapper in parallel with an other lock statements
        //and with common lock object
        public MonitorWrapper(ref object lockObj)
        {
            _lock = lockObj;
        }

        public TR TryLock<TAr, TR>(Func<TAr, TR> method, TAr ar)
        {
            if (Monitor.TryEnter(_lock))
            {
                try
                {
                    return method(ar);
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
            return default(TR);
        }

        public TR TryLock<TR>(Func<TR> method)
        {
            if (Monitor.TryEnter(_lock))
            {
                try
                {
                    return method();
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
            return default(TR);
        }

        public void TryLock(Action method)
        {
            if (Monitor.TryEnter(_lock))
            {
                try
                {
                    method();
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        public void Lock(Action method)
        {
            Monitor.Enter(_lock);
            try
            {
                method();
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
