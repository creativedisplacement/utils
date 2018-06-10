using System;
using System.Globalization;

namespace Utils.Extensions
{
    public static class DateExtensions
    {
        public static bool DatesDiffer(DateTime value1, DateTime value2)
        {
            return !DateTime.Equals(value1, value2);
        }

        public static DateTime ToDateTime(this string s)
        {
            return DateTime.ParseExact(s, "yyyy-MM-dd-HH-mm-ss", CultureInfo.InvariantCulture);
        }
    }
}