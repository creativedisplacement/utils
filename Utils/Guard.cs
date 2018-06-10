using System;
using System.Collections.Generic;

namespace Utils
{
    public static class Guard
    {
        public static void AgainstEmptyString(string obj, string message = "")
        {
            if (string.IsNullOrEmpty(obj))
            {
                throw new ArgumentNullException(message ?? nameof(obj));
            }
        }

        public static void AgainstDefaultInteger(int obj, string message = "")
        {
            if (obj == 0)
            {
                throw new ArgumentNullException(message ?? nameof(obj));
            }
        }

        public static void AgainstInvalidOperationException(object obj, string message = "")
        {
            if (obj == null)
            {
                throw new InvalidOperationException(message ?? nameof(obj));
            }
        }

        public static void AgainstNullReferenceException(object obj, string message = "")
        {
            if (obj == null)
            {
                throw new NullReferenceException(message ?? nameof(obj));
            }
        }

        public static void AgainstArgumentNullException(object obj, string message = "")
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message ?? nameof(obj));
            }
        }

        public static void AgainstArgumentException(bool condition, string message = "")
        {
            if (condition)
            {
                throw new ArgumentException(message ?? nameof(condition));
            }
        }

        public static void AgainstKeyNotFoundException<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key,
            string message = "")
        {
            if (!dictionary.ContainsKey(key))
            {
                throw new KeyNotFoundException(message ?? nameof(dictionary));
            }
        }

        public static void AgainstDefaultGuidException(object obj, string message = "")
        {
            if ((Guid)obj == default(Guid))
            {
                throw new ArgumentException(message ?? nameof(obj));
            }
        }

        public static void AgainstDefaultGuidInListException(object obj, string message = "")
        {
            if (((List<Guid>)obj).Contains(default(Guid)))
            {
                throw new ArgumentException(message ?? nameof(obj));
            }
        }
    }
}