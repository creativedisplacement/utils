using System.Linq;

namespace Utils.Utilities
{
    public static class NumericUtilities
    {
        public static bool IsNumeric(string s)
        {
            Guard.AgainstEmptyString(s);
            return s.All(char.IsDigit);
        }
    }
}