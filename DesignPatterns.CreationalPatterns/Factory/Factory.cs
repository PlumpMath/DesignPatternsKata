using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    /// <summary>
    /// Creates objects without exposing the instantiation logic to the client.
    /// Refers to the newly created object through a common interface.
    /// </summary>
    /// <remarks>
    /// This implementation doesn't violates Open Close principle
    /// </remarks>
    public class Factory
    {
        readonly Dictionary<string, Func<AbstractProductOne>> _mapProductOne;

        public Factory()
        {
            _mapProductOne = new Dictionary<string, Func<AbstractProductOne>>();
        }

        public AbstractProductOne CreateProductOne(string productKey)
        {
            if (_mapProductOne.ContainsKey(productKey))
            {
                return _mapProductOne[productKey].Invoke();
            }
            else
            {
                // product generator not found
                return null;
            }
        }

        public void RegisterProductOne(string productKey, Func<AbstractProductOne> creator)
        {
            if (_mapProductOne.ContainsKey(productKey))
            {
                _mapProductOne[productKey] = creator;
            }
            else
            {
                _mapProductOne.Add(productKey, creator);
            }
        }
    }
}
