using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Uses abstracts factories and products without need of knowing concrete
    /// objects.
    /// </summary>
    public sealed class Client
    {
        readonly AbstractFactory _factory;

        public Client(AbstractFactory factory)
        {
            _factory = factory;
        }

        public void DoSomething()
        {
            AbstractProductOne productOne = _factory.CreateProductOne();
            AbstractProductTwo productTwo = _factory.CreateProductTwo();

            productTwo.DoSomethingWith(productOne);
        }
    }
}
