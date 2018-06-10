using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Utilities;

namespace Utils.Tests.Utilities
{
    [TestClass]
    public class BooleanUtilitiesTests
    {

        [TestMethod]
        public void BooleanUtilities_Bools_Differ_Returning_False()
        {
            Assert.IsFalse(BooleanUtilities.BoolsDiffer(false, false));
        }

        [TestMethod]
        public void BooleanUtilities_Bools_Differ_Returning_True()
        {
            Assert.IsTrue(BooleanUtilities.BoolsDiffer(true, false));
        }
    }
}