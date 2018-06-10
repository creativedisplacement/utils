using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Utilities;

namespace Utils.Tests.Utilities
{
    [TestClass]
    public class StringUtilitiesTests
    {
        [TestMethod]
        public void StringUtilities_StringsDiffer_Returns_True()
        {
            Assert.IsTrue(StringUtilities.StringsDiffer("s", "t"));
        }

        [TestMethod]
        public void StringUtilities_StringsDiffer_Returns_False()
        {
            Assert.IsFalse(StringUtilities.StringsDiffer("s", "s"));
        }

        [TestMethod]
        public void StringUtilities_StringsDiffer_Passing_Empty_Strings_Returns_False()
        {
            Assert.IsFalse(StringUtilities.StringsDiffer("", ""));
        }

        [TestMethod]
        public void StringUtilities_StringsDiffer_Passing_Null_Strings_Returns_False()
        {
            Assert.IsFalse(StringUtilities.StringsDiffer(null, null));
        }
    }
}
