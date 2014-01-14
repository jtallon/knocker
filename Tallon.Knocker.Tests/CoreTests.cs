using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tallon.Knocker.Core;
using Tallon.Knocker.Core.Helpers;

namespace Tallon.Knocker.Tests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void PortNameTest()
        {
            var result = ConfigHelper.PortName;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public void BaudRateTest()
        {
            var result = ConfigHelper.BaudRate;
            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void FoundArduinoPortTest()
        {
            var result = ComReader.FoundPort();
            Assert.IsTrue(result);
        }
    }
}
