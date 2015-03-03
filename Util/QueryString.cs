using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace SquareSharp.Util
{
    internal static class QueryString
    {
        // Why is there not a built-in to do this???
        public static string Encode(NameValueCollection args)
        {
            if (args == null) return "";

            var result = new StringBuilder("?");
            foreach (string key in args)
            {
                var values = args.GetValues(key);
                if (values == null) continue;
                foreach (string val in values)
                {
                    // I've decided to just ignore keys mapped to null values,
                    // as this makes the other code cleaner.
                    if (val == null) continue;

                    result.Append(HttpUtility.UrlEncode(key));
                    result.Append('=');
                    result.Append(HttpUtility.UrlEncode(val));
                    result.Append('&');
                    // NOTE: We leave a trailing &, but that's fine
                }
            }

            return result.ToString();
        }
    }
}
