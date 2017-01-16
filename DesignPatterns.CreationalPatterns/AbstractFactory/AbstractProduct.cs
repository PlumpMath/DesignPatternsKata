using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Declares and interface for a type of product object
    /// </summary>
    public abstract class AbstractProductOne
    {
    }

    public abstract class AbstractProductTwo
    {
        public abstract void DoSomethingWith(AbstractProductOne one);
    }

}
