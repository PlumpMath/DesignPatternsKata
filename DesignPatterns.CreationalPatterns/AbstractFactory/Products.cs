using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Defines a product object to be created by the corresponding concrete factory.
    /// Implements abstract product interface.
    /// </summary>
    public class ProductAlphaOne : AbstractProductOne
    {

    }

    public class ProductAlphaTwo : AbstractProductTwo
    {
        public override void DoSomethingWith(AbstractProductOne one)
        {
            
        }
    }

    public class ProductBetaOne : AbstractProductOne
    {

    }

    public class ProductBetaTwo : AbstractProductTwo
    {
        public override void DoSomethingWith(AbstractProductOne one)
        {

        }
    }
}
