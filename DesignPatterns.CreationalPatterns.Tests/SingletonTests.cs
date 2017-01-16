using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.CreationalPatterns.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void CheckInstanceCreatedOnFirstUse()
        {
            Assert.IsFalse(Singleton.InstanceInitialized, "Instance must not be initialized.");

            Singleton instance = Singleton.Instance;
            instance.DoSomething();

            Assert.IsTrue(Singleton.InstanceInitialized, "Instance is not initialized");
        }

        [TestMethod]
        public void InstancesReturnsTheSameObject()
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            bool equals = instance1.Equals(instance2);

            Assert.IsTrue(instance1.Equals(instance2), "Singleton Instances are not equal");
        }
    }
}
