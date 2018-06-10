using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;
using static System.String;

namespace Utils.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string s)
        {
            if (IsNullOrEmpty(s))
            {
                return Empty;
            }
            return Char.ToUpper(s[0]) + s.Substring(1);
        }

        public static bool StartsWithAny(this string s, IEnumerable<string> items)
        {
            return items.Any(i => s.StartsWith(i.ToLower()));
        }

        public static bool EqualsAny(this string s, IEnumerable<string> items)
        {
            return items.Any(i => s.Equals(i.ToLower()));
        }

        public static bool ContainsAny(this string s, IEnumerable<string> items)
        {
            return items.Any(i => s.Contains(i.ToLower()));
        }

        public static bool EqualsOrStartsWithAny(this string s, IEnumerable<string> items)
        {
            var enumerable = items as string[] ?? items.ToArray();
            return s.StartsWithAny(enumerable) || s.EqualsAny(enumerable);
        }

        public static string RemoveDigits(this string s)
        {
            return Regex.Replace(s, @"\d", "");
        }

        public static string EscapeJsChars(this string s)
        {
            return s.Replace("\"", "\\\"");
        }

        public static string RemoveIllegalXmlCharacters(this string s)
        {
            s = s.Replace("&", "&amp;");
            s = s.Replace("\"", "&quot;");
            s = s.Replace("'", "&apos;");
            s = s.Replace("<", "&lt;");
            s = s.Replace(">", "&gt;");

            return s;
        }

        public static string LimitDisplayCharacters(this string s, int length)
        {
            if (IsNullOrEmpty(s))
            {
                return s;
            }

            if (s.Length < length)
            {
                return s;
            }

            var words = s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (words[0].Length > length)
                return words[0];

            var sb = new StringBuilder();

            foreach (var word in words)
            {
                if ((sb + word).Length > length)
                    return $"{sb.ToString().TrimEnd(' ')}...";
                sb.Append(word + " ");
            }

            return $"{sb.ToString().TrimEnd(' ')}...";
        }

        public static string RemoveBreakTags(this string s)
        {
            if (IsNullOrEmpty(s))
            {
                return s;
            }
            s = s.Replace("<br />", "").Replace("<br>", "");
            return s;
        }

        public static string ReplaceSpaces(this string s)
        {
            return !IsNullOrEmpty(s) ? s.Replace(" ", "-") : s;
        }

        public static string ReplaceHyphens(this string s)
        {
            if (IsNullOrEmpty(s))
            {
                return s;
            }
            var _string = s.Replace("-", " ");
            return _string;

        }

        public static string RemoveIllegalCharacters(this string s)
        {
            return s.Replace("'", "")
                .Replace(":", "")
                .Replace("~", "")
                .Replace("&", "and")
                .Replace(";", "");
        }

        public static string StripHtmlTags(this string html)
        {
            if (IsNullOrEmpty(html))
            {
                return Empty;
            }

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            return HttpUtility.HtmlDecode(doc.DocumentNode.InnerText);
        }

        public static string ConvertNullValueToString(this string s)
        {
            return s == "false" || s == null ? Empty : s;
        }
    }
}