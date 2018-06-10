using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Extensions;

namespace Utils.Tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void StringExtensions_To_Title_Case()
        {
            const string s = "Something";
            Assert.AreEqual(s.ToLower().ToTitleCase(), s);
        }

        [TestMethod]
        public void StringExtensions_Starts_With_Any_Returns_True()
        {
            const string s = "Something, else";
            Assert.IsTrue(s.ToLower().StartsWithAny(new List<string>{ "Som"}));
        }

        [TestMethod]
        public void StringExtensions_Starts_With_Any_Returns_False()
        {
            const string s = "Something";
            Assert.IsFalse(s.ToLower().StartsWithAny(new List<string> { "Else" }));
        }

        [TestMethod]
        public void StringExtensions_Contains_Any_Returns_True()
        {
            const string s = "Something, nothing, everything";
            Assert.IsTrue(s.ToLower().ContainsAny(new List<string> { "Someone", "nothing", "Everyone" }));
        }

        [TestMethod]
        public void StringExtensions_Contains_Any_Returns_False()
        {
            const string s = "Something, nothing, everything";
            Assert.IsFalse(s.ToLower().ContainsAny(new List<string> { "John" }));
        }

        [TestMethod]
        public void StringExtensions_Equals_Or_Starts_With_Any_Returns_True()
        {
            const string s = "Something, nothing, everything";
            Assert.IsTrue(s.ToLower().EqualsOrStartsWithAny(new List<string> { "Some", "thing", "one" }));
        }

        [TestMethod]
        public void StringExtensions_Equals_Or_Starts_With_Any_Returns_False()
        {
            const string s = "Something, nothing, everything";
            Assert.IsFalse(s.ToLower().EqualsOrStartsWithAny(new List<string> { "John" }));
        }

        [TestMethod]
        public void StringExtensions_RemoveDigits()
        {
            const string s = "Something";
            Assert.AreEqual($"{s}111".RemoveDigits(), s);
        }
    }
}