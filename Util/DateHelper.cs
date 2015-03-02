using System;
using System.Globalization;
namespace SquareSharp.Util
{
    internal static class DateHelper
    {
        public static string ToISO(DateTime dateTime)
        {
            return dateTime.ToString("o");
        }

        public static DateTime FromISO(string isoTime)
        {
            return DateTime.Parse(isoTime, null, DateTimeStyles.RoundtripKind);
        }
    }
}
