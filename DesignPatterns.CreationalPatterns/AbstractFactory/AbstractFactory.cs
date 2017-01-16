using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Declares an interface for operations that create abstract products.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductOne CreateProductOne();
        public abstract AbstractProductTwo CreateProductTwo();
    }
}
