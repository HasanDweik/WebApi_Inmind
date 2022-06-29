using Microsoft.AspNetCore.Mvc;
using WebApi0.Models;

namespace WebApi0.Interfaces;

public interface IUploadFileHelper
{
   public Boolean UploadImage(UploadImage uploadImage);
}