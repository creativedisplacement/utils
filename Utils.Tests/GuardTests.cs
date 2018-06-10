using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utils.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Against_Empty_String_Exception_Passing_Empty_String()
        {
            const string s = "";
            Guard.AgainstEmptyString(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Against_Empty_String_Exception_Passing_Null()
        {
            string s = null;
            Guard.AgainstEmptyString(s);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Against_Default_Integer_Exception()
        {
            const int i = 0;
            Guard.AgainstDefaultInteger(i);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Guard_Against_Invalid_Operation_Exception()
        {
            Guard.AgainstInvalidOperationException(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Guard_Against_Null_Reference_Exception()
        {
            Guard.AgainstNullReferenceException(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Guard_Against_Argument_Null_Exception()
        {
            Guard.AgainstArgumentNullException(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Guard_Against_Argument_Exception()
        {
            Guard.AgainstArgumentException(true);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Guard_Against_Key_Not_Found_Exception()
        {
            Guard.AgainstKeyNotFoundException(new Dictionary<string, string>(), "key");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Guard_Against_Default_Guid_Exception()
        {
            Guard.AgainstDefaultGuidException(default(Guid));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Guard_Against_Default_Guid_In_List_Exception()
        {
            Guard.AgainstDefaultGuidInListException(new List<Guid>{ default(Guid)});
        }
    }
}