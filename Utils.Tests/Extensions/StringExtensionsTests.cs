using System;
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
        public void StringExtensions_To_Title_Case_With_Empty_String()
        {
            const string s = null;
            Assert.AreEqual(s.ToTitleCase(), s);
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
        [ExpectedException(typeof(NullReferenceException))]
        public void StringExtensions_Starts_With_Any_On_Empty_String_Returns_False()
        {
            const string s = null;
            Assert.IsFalse(s.StartsWithAny(new List<string> { "Else" }));
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
        [ExpectedException(typeof(NullReferenceException))]
        public void StringExtensions_Contains_Any_With_Empty_String_Returns_False()
        {
            const string s = null;
            Assert.IsFalse(s.ContainsAny(new List<string> { "John" }));
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
        [ExpectedException(typeof(NullReferenceException))]
        public void StringExtensions_Equals_Or_Starts_With_Any_On_Empty_StringReturns_False()
        {
            const string s = null;
            Assert.IsFalse(s.EqualsOrStartsWithAny(new List<string> { "John" }));
        }

        [TestMethod]
        public void StringExtensions_RemoveDigits()
        {
            const string s = "Something";
            Assert.AreEqual($"{s}111".RemoveDigits(), s);
        }

        [TestMethod]
        public void StringExtensions_RemoveDigits_When_String_Has_No_Digits()
        {
            const string s = "Something";
            Assert.AreEqual(s.RemoveDigits(), s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StringExtensions_RemoveDigits_When_String_Is_Empty()
        {
            const string s = null;
            Assert.AreEqual(s.RemoveDigits(), s);
        }

        [TestMethod]
        public void StringExtensions_Escape_Js_Chars()
        {
            const string s = "\"";
            Assert.AreEqual(s.EscapeJsChars(), "\\\"");
        }

        [TestMethod]
        public void StringExtensions_Escape_Js_Chars_When_String_Has_No_Js_Chars()
        {
            const string s = "123";
            Assert.AreEqual(s.EscapeJsChars(), s);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void StringExtensions_Escape_Js_Chars_When_String_Is_Null()
        {
            const string s = null;
            Assert.AreEqual(s.EscapeJsChars(), s);
        }

        [TestMethod]
        public void StringExtensions_Limit_Display_Characters()
        {
            const string s = "This is a long string";
            Assert.AreEqual(s.LimitDisplayCharacters(5), "This...");
        }

        [TestMethod]
        public void StringExtensions_Limit_Display_Characters_When_String_Has_No_Break_Tags()
        {
            const string s = "This is a long string";
            Assert.AreEqual(s.LimitDisplayCharacters(30), s);
        }

        [TestMethod]
        public void StringExtensions_Limit_Display_Characters_When_String_Is_Null()
        {
            const string s = null;
            Assert.AreEqual(s.LimitDisplayCharacters(30), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Break_Tags()
        {
            const string s = "<p></p>";
            Assert.AreEqual($"{s}<br /><br>".RemoveBreakTags(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Break_Tags_When_String_Has_No_Break_Tags()
        {
            const string s = "<p></p>";
            Assert.AreEqual(s.RemoveBreakTags(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Break_Tags_When_String_Is_Empty()
        {
            const string s = null;
            Assert.AreEqual(s.RemoveBreakTags(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Spaces()
        {
            const string s = "Testing This";
            Assert.AreEqual(s.ReplaceSpaces(), "Testing-This");
        }

        [TestMethod]
        public void StringExtensions_Remove_Spaces_When_String_Has_No_Spaces()
        {
            const string s = "Testing-This";
            Assert.AreEqual(s.ReplaceSpaces(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Spaces_When_String_Is_Empty()
        {
            const string s = null;
            Assert.AreEqual(s.ReplaceSpaces(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Hypens()
        {
            const string s = "Testing-This";
            Assert.AreEqual(s.ReplaceHyphens(), "Testing This");
        }

        [TestMethod]
        public void StringExtensions_Remove_Hypens_When_String_Has_No_Hypens()
        {
            const string s = "Testing This";
            Assert.AreEqual(s.ReplaceHyphens(), s);
        }

        [TestMethod]
        public void StringExtensions_Remove_Hypens_When_String_Is_Empty()
        {
            const string s = null;
            Assert.AreEqual(s.ReplaceHyphens(), s);
        }

        [TestMethod]
        public void StringExtensions_Strip_Html_Tags()
        {
            const string s = "<p>Test</p>";
            Assert.AreEqual(s.StripHtmlTags(), "Test");
        }

        [TestMethod]
        public void StringExtensions_Strip_Html_Tags_When_String_Has_No_Html_Tags()
        {
            const string s = "Testing This";
            Assert.AreEqual(s.StripHtmlTags(), s);
        }

        [TestMethod]
        public void StringExtensions_Strip_Html_Tags_When_String_Is_Empty()
        {
            const string s = null;
            Assert.AreEqual(s.StripHtmlTags(), string.Empty);
        }
    }
}