using System;
using static System.String;

namespace Utils.Utilities
{
    public static class StringUtilities
    {
        public static bool StringsDiffer(string value1, string value2)
        {
            if (IsNullOrEmpty(value1) || IsNullOrEmpty(value2))
            {
                return false;
            }

            return !string.Equals(value1, value2, StringComparison.InvariantCulture);
        }
    }
}