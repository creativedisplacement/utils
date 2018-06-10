using System;

namespace Utils.Utilities
{
    public static class DateUtilities
    {
        public static bool DatesDiffer(DateTime value1, DateTime value2)
        {
            return !DateTime.Equals(value1, value2);
        }
    }
}