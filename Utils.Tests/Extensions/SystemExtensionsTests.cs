using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class SystemExtensionsTests
    {
        [TestMethod]
        public void SystemExtensions_ToGuid()
        {
            var guid = Guid.NewGuid();
            Assert.AreEqual(guid.ToString().ToGuid(), guid);
        }

        [TestMethod]
        public void SystemExtensions_ToGuid_With_Invalid_Guid_String()
        {
            var guid = "Guid";
            Assert.AreEqual(guid.ToGuid(), default(Guid));
        }
    }
}