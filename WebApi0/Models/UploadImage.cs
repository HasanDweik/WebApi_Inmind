namespace WebApi0.Models;
using WebApi0.Validations;
public class UploadImage
{
    [AllowedExtensions(new string[] { ".jpg", ".png" })]
    public IFormFile _formFile { get; set; }
}