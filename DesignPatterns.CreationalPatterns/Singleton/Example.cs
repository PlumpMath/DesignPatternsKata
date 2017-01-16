using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Examples
{
    /// <summary>
    /// In this case a singleton with synchronized methods could be used
    /// to manage all operations on a single resource.
    /// </summary>
    public sealed class SharedResourceManager
    {
        #region Singleton

        static SharedResourceManager _instance = null;
        static object _singletonSyncRoot = new object();

        SharedResourceManager()
        {
        }

        public static SharedResourceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_singletonSyncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new SharedResourceManager();
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion

        object _syncRoot = new object();

        public void DoSomethingSync()
        {
            lock(_syncRoot)
            {
                // Do something here...
            }
        }
    }
}
