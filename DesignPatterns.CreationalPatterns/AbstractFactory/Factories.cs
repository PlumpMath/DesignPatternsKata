using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Implements operations to create concrete product objects
    /// </summary>
    public class FactoryAlpha : AbstractFactory
    {
        public override AbstractProductOne CreateProductOne()
        {
            return new ProductAlphaOne();
        }

        public override AbstractProductTwo CreateProductTwo()
        {
            return new ProductAlphaTwo();
        }
    }

    /// <summary>
    /// Implements operations to create concrete product objects
    /// </summary>
    public class FactoryBeta : AbstractFactory
    {
        public override AbstractProductOne CreateProductOne()
        {
            return new ProductBetaOne();
        }

        public override AbstractProductTwo CreateProductTwo()
        {
            return new ProductBetaTwo();
        }
    }
}
