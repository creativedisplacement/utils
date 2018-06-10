using System.Text.RegularExpressions;

namespace Utils.Extensions
{
    public static class RegexExtensions
    {

        public static bool IsValidEmailAddress(this string s)
        {
            var regex = new Regex("\\A[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*@\r\n(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\z");
            return regex.IsMatch(s);
        }
    }
}