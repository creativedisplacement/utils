using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class BooleanExtensionsTests
    {
        [TestMethod]
        public void BooleanExtensions_Convert_String_To_Bool_Returns_True()
        {
            const string boolean = "True";
            Assert.IsTrue(boolean.ConvertStringToBool());
        }

        [TestMethod]
        public void BooleanExtensions_Convert_String_To_Bool_Returns_False()
        {
            const string boolean = "False";
            Assert.IsFalse(boolean.ConvertStringToBool());
        }

        [TestMethod]
        public void BooleanExtensions_Convert_String_To_Bool_Passing_Random_String_Returns_False()
        {
            const string boolean = "Random";
            Assert.IsFalse(boolean.ConvertStringToBool());
        }

        [TestMethod]
        public void BooleanExtensions_Convert_Nullable_Bool_As_True_To_Bool_Returns_True()
        {
            var convertedBool = ((bool?)true).ConvertNullableBool();
            Assert.AreEqual(convertedBool.GetType(), typeof(bool));
            Assert.AreEqual(convertedBool, true);
        }

        [TestMethod]
        public void BooleanExtensions_Convert_Nullable_Bool_As_False_To_Bool_Returns_False()
        {
            var convertedBool = ((bool?)false).ConvertNullableBool();
            Assert.AreEqual(convertedBool.GetType(), typeof(bool));
            Assert.AreEqual(convertedBool, false);
        }

        [TestMethod]
        public void BooleanExtensions_Convert_Nullable_Bool_As_Null_To_Bool_Returns_False()
        {
            var convertedBool = ((bool?) null).ConvertNullableBool();
            Assert.AreEqual(convertedBool.GetType(), typeof(bool));
            Assert.AreEqual(convertedBool, false);
        }
    }
}