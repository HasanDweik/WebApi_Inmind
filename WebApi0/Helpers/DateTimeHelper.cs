using System.Globalization;
using WebApi0.Interfaces;

namespace WebApi0.Helpers;

public class DateTimeHelper:IDateTimeHelper
{
    public string GetCurrentDateTime(string s)
    {
        CultureInfo cultureInfo = new CultureInfo(s);
        return DateTime.Now.ToString(cultureInfo);
    }
}