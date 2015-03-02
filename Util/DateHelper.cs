using System;
using System.Globalization;
namespace SquareSharp.Util
{
    internal static class DateHelper
    {
        public string ToISO(DateTime dateTime)
        {
            return dateTime.ToString("o");
        }

        public DateTime FromISO(string isoTime)
        {
            return DateTime.Parse(isoTime, null, DateTimeStyles.RoundtripKind);
        }
    }
}