internal static class DateHelper
{
    public string ToISO(DateTime dateTime)
    {
        return dateTime.ToString("o");
    }
}
