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
    public class SingletonEarlyInit
    {
        protected static readonly SingletonEarlyInit _instance = new SingletonEarlyInit();
        protected readonly Guid _identifier;
        /// <summary>
        /// Singleton constructor is protected
        /// so that no new instances can be created.
        /// </summary>
        protected SingletonEarlyInit()
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

        public static SingletonEarlyInit Instance
        {
            get
            {
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
