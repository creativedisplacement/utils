using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class BooleanExtensionsTests
    {
        [TestMethod]
        public void BooleanExtensions_ConvertStringToBool_Returns_True()
        {
            const string boolean = "True";
            Assert.IsTrue(boolean.ConvertStringToBool());
        }

        [TestMethod]
        public void BooleanExtensions_ConvertStringToBool_Returns_False()
        {
            const string boolean = "False";
            Assert.IsFalse(boolean.ConvertStringToBool());
        }

        [TestMethod]
        public void BooleanExtensions_ConvertStringToBool_Passing_Random_String_Returns_False()
        {
            const string boolean = "Random";
            Assert.IsFalse(boolean.ConvertStringToBool());
        }
    }
}