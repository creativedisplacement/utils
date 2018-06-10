using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class NumericExtensionsTests
    {
        [TestMethod]
        public void NumericExtensions_ToInt16()
        {
            const string s = "1";
            Assert.AreEqual(s.ToInt16(), 1);
        }

        [TestMethod]
        public void NumericExtensions_ToInt16_With_Empty_String_Returns_Zero()
        {
            var s = string.Empty;
            Assert.AreEqual(s.ToInt16(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt16_With_Null_Returns_Zero()
        {
            const string s = null;
            Assert.AreEqual(s.ToInt16(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt16_With_Alphanumeric_Characters_Returns_Zero()
        {
            const string s = "A2";
            Assert.AreEqual(s.ToInt16(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt32()
        {
            const string s = "1";
            Assert.AreEqual(s.ToInt32(), 1);
        }

        [TestMethod]
        public void NumericExtensions_ToInt32_With_Empty_String_Returns_Zero()
        {
            var s = string.Empty;
            Assert.AreEqual(s.ToInt32(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt32_With_Null_Returns_Zero()
        {
            const string s = null;
            Assert.AreEqual(s.ToInt32(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt32_With_Alphanumeric_Characters_Returns_Zero()
        {
            const string s = "A2";
            Assert.AreEqual(s.ToInt32(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt64()
        {
            const string s = "1";
            Assert.AreEqual(s.ToInt64(), 1);
        }

        [TestMethod]
        public void NumericExtensions_ToInt64_With_Empty_String_Returns_Zero()
        {
            var s = string.Empty;
            Assert.AreEqual(s.ToInt64(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt64_With_Null_Returns_Zero()
        {
            const string s = null;
            Assert.AreEqual(s.ToInt64(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ToInt64_With_Alphanumeric_Characters_Returns_Zero()
        {
            const string s = "A2";
            Assert.AreEqual(s.ToInt64(), 0);
        }

        [TestMethod]
        public void NumericExtensions_ConvertStringIdToNullableIntId_Returns_Integer()
        {
            const string s = "2";
            Assert.AreEqual(s.ConvertStringIdToNullableIntId(), 2);
        }

        [TestMethod]
        public void NumericExtensions_ConvertStringIdToNullableIntId_Returns_Null()
        {
            const string s = null;
            Assert.AreEqual(s.ConvertStringIdToNullableIntId(), null);
        }

        [TestMethod]
        public void NumericExtensions_ConvertStringToDecimal_Returns_Decimal()
        {
            const string s = "1.2";
            Assert.AreEqual(s.ConvertStringToDecimal(), (decimal)1.2);
        }

        [TestMethod]
        public void NumericExtensions_ConvertStringToDecimal_With_Alphanumeric_Characters_Returns_Null()
        {
            const string s = "A.B";
            Assert.AreEqual(s.ConvertStringIdToNullableIntId(), 0);
        }
    }
}