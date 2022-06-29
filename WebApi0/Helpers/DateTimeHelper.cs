using System.Globalization;
using WebApi0.Interfaces;

namespace WebApi0.Helpers;

public class DateTimeHelper:IDateTimeHelper
{
    public string GetCurrentDateTime(string s)
    {
        List<CultureInfo> allCultures = new List<CultureInfo>(CultureInfo.GetCultures(CultureTypes.AllCultures));
        try
        {
            CultureInfo cultureInfo = new CultureInfo(s);
            allCultures.Contains(cultureInfo);
            return DateTime.Now.ToString(cultureInfo);
        }
        catch (Exception e)
        {
            Console.WriteLine("Culture not found");
            throw;
        }
        
    }
}