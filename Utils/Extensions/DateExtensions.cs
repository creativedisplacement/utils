using System;
using System.Globalization;

namespace Utils.Extensions
{
    public static class DateExtensions
    {
        public static DateTime ToDateTime(this string s)
        {
            return DateTime.ParseExact(s, "yyyy-MM-dd-HH-mm-ss", CultureInfo.InvariantCulture);
        }
    }
}