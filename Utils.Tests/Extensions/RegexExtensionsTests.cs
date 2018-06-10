using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class RegexExtensionsTests
    {
        [TestMethod]
        public void RegexExtensions_IsValidEmailAddress_Returns_True()
        {
            const string email = "test@test.com";
            Assert.IsTrue(email.IsValidEmailAddress());
        }

        [TestMethod]
        public void RegexExtensions_IsValidEmailAddress_Returns_False()
        {
            const string email = "@@@@";
            Assert.IsFalse(email.IsValidEmailAddress());
        }
    }
}