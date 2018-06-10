using System.Linq;

namespace Utils.Extensions
{
    public static class NumericExtensions
    {
        public static short ToInt16(this string s)
        {
            short.TryParse(s, out var i);
            return i;
        }

        public static int ToInt32(this string s)
        {
            int.TryParse(s, out var i);
            return i;
        }

        public static long ToInt64(this string s)
        {
            long.TryParse(s, out var i);
            return i;
        }

        public static int? ConvertStringIdToNullableIntId(this string s)
        {
            int? i;

            if (!string.IsNullOrEmpty(s))
            {
                i = s.ToInt32();
            }
            else
            {
                i = null;
            }
            return i;
        }

        public static decimal ConvertStringToDecimal(this string s)
        {
            decimal.TryParse(s, out var number);
            return number;
        }

        public static bool IsNumeric(string s)
        {
            return s.All(char.IsDigit);
        }
    }
}