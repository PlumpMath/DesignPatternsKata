using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    public class Client
    {
        private readonly Factory _factory;

        public Client()
        {
            _factory = new Factory();

            _factory.RegisterProductOne("alpha", () => new ProductOneAlpha() );
            _factory.RegisterProductOne("beta", () => new ProductOneBeta() );
            _factory.RegisterProductOne("delta", () => new ProductOneDelta() );

        }

        public void DoSomething()
        {
            AbstractProductOne alpha = _factory.CreateProductOne("alpha");
            AbstractProductOne beta = _factory.CreateProductOne("beta");
            AbstractProductOne delta = _factory.CreateProductOne("delta");

            alpha.DoSomething();
            beta.DoSomething();
            delta.DoSomething();
        }
    }
}
