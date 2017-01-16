using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.CreationalPatterns.Tests
{
    [TestClass]
    public class SingletonEarlyInitTests
    {
        [TestMethod]
        public void AssertInstanceIsCreatedOnLoadClass()
        {
            Assert.IsTrue(SingletonEarlyInit.InstanceInitialized, "Singleton instance is not initialized.");
        }

        [TestMethod]
        public void InstancesReturnsTheSameObject()
        {
            SingletonEarlyInit instance1 = SingletonEarlyInit.Instance;
            SingletonEarlyInit instance2 = SingletonEarlyInit.Instance;

            bool equals = instance1.Equals(instance2);

            Assert.IsTrue(instance1.Equals(instance2), "Singleton Instances are not equal");
        }
    }
}
