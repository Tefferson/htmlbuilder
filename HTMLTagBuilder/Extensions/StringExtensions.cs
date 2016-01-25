using System;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string IfValid(this string value, Func<string, string> func)
        {
            if (value != null)
            {
                return func(value);
            }

            return "";
        }
    }
}
