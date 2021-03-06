﻿namespace Utils.Extensions
{
    public static class BooleanExtensions
    {
        public static bool ConvertStringToBool(this string s)
        {
            return s.ToLower() == "true";
        }

        public static bool ConvertNullableBool(this bool? b)
        {
            return b == true;
        }
    }
}