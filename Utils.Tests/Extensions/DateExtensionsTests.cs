using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class DateExtensionsTests
    {
        [TestMethod]
        public void DateExtensions_String_ToDateTime()
        {
            const string s = "2018-06-11-21-39-24";
            var convertedString = s.ToDateTime();
            Assert.AreEqual(convertedString.GetType(), typeof(DateTime));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void DateExtensions_Incorrectly_Formatted_String_ToDateTime()
        {
            const string s = "Hello!";
            var convertedString = s.ToDateTime();
            Assert.AreEqual(convertedString.GetType(), typeof(DateTime));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DateExtensions_Null_String_ToDateTime()
        {
            const string s = null;
            var convertedString = s.ToDateTime();
            Assert.AreEqual(convertedString.GetType(), typeof(DateTime));
        }
    }
}