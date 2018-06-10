using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Utilities;

namespace Utils.Tests.Utilities
{
    [TestClass]
    public class NumericUtilitiesTests
    {
        [TestMethod]
        public void NumericUtilities_IsNumeric_Returns_True()
        {
            const string s = "1";
            Assert.IsTrue(NumericUtilities.IsNumeric(s));
        }

        [TestMethod]
        public void NumericUtilities_IsNumeric_Returns_False()
        {
            const string s = "1a";
            Assert.IsFalse(NumericUtilities.IsNumeric(s));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NumericUtilities_IsNumeric_With_Null_String_Throws_Exception()
        {
            const string s = "";
            Assert.IsFalse(NumericUtilities.IsNumeric(s));
        }
    }
}