namespace TweetSearch.CosmosDb.Util
{
    using System;

    public static class StringExtensions
    {
        public static string Enquote(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException(nameof(str));

            return string.Concat("\"", str, "\"");
        }
    }
}
