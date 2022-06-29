using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WebApi0.Interfaces;

namespace WebApi0.Controllers;

[ApiController]
[Route("[controller]")]

public class DateTimeController : Controller
{
    private readonly IDateTimeHelper _dateTimeHelper;

    public DateTimeController(IDateTimeHelper dateTimeHelper)
    {
        _dateTimeHelper = dateTimeHelper;
    }

    [HttpGet("GetCurrentDateTime")]
    public string GetCurrentDateTime(string s)
    {
        return _dateTimeHelper.GetCurrentDateTime(s);
    }
  
}