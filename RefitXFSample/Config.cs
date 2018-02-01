using System;
using System.Text.RegularExpressions;

namespace RefitXFSample
{
    public static class Config
    {
        public static string ApiUrl = "http://makeup-api.herokuapp.com";

        public static string ApiHostName
        {
            get
            {
                var apiHostName = Regex.Replace(ApiUrl, @"^(?:http(?:s)?://)?(?:www(?:[0-9]+)?\.)?", string.Empty, RegexOptions.IgnoreCase)
                                   .Replace("/", string.Empty);
                return apiHostName;
            }
        }
    }
}
