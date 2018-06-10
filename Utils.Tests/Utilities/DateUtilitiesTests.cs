using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Utils.Utilities;

namespace Utils.Tests.Utilities
{
    [TestClass]
    public class DateUtilitiesTests
    {
        [TestMethod]
        public void DateUtilities_DatesDiffer_Returns_True()
        {
            Assert.IsTrue(DateUtilities.DatesDiffer(DateTime.Now, DateTime.Now.AddDays(1)));
        }

        [TestMethod]
        public void DateUtilities_DatesDiffer_Returns_False()
        {
            Assert.IsTrue(DateUtilities.DatesDiffer(DateTime.Now, DateTime.Now));
        }
    }
}