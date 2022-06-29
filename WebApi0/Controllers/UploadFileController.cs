using Microsoft.AspNetCore.Mvc;
using WebApi0.Interfaces;
using WebApi0.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApi0.Controllers;

[ApiController]
[Route("[controller]")]


public class UploadFileController : Controller
{

    private readonly IUploadFileHelper _uploadFileHelper;

    public UploadFileController(IUploadFileHelper uploadFileHelper)
    {
        _uploadFileHelper = uploadFileHelper;
    }

    [HttpPost("UploadImage")]
    public IActionResult UploadImage([FromQuery]UploadImage uploadImage)
    {
        if (_uploadFileHelper.UploadImage(uploadImage))
        {
            return Ok();
        }

        return BadRequest();

    }
}
