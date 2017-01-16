using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    /// <summary>
    /// Singleton is a class of which only a single instance can exists.
    /// Defines an Instance property that lets clients access its unique instance.
    /// It's responsible for creating and maintaining its own unique instance.
    /// </summary>
    public class Singleton
    {
        protected static Singleton _instance = null;
        protected static object syncLock = new object();
        protected readonly Guid _identifier;

        /// <summary>
        /// Singleton constructor is protected
        /// so that no new instances can be created.
        /// </summary>
        protected Singleton()
        {
            this._identifier = Guid.NewGuid();
        }

        public static bool InstanceInitialized
        {
            get
            {
                return _instance != null;
            }
        }

        /// <summary>
        /// Gets unique class instance.
        /// </summary>
        /// <remarks>
        /// Supports multithreaded applications through
        /// 'double checked locking' pattern which
        /// (once the instance exists) avoids locking each time 
        /// the method is invoked.
        /// </remarks>
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }

        public string Identifier
        {
            get
            {
                return this._identifier.ToString();
            }
        }

        public void DoSomething()
        {
            // Do something here...
        }
    }
}
