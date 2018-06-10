using System;

namespace Utils.Extensions
{
    public static class SystemExtensions
    {
        public static Guid ToGuid(this string s)
        {
            Guid.TryParse(s, out var id);
            return id;
        } 
    }
}