﻿using Microsoft.AspNetCore.Mvc;
using WebApi0.Interfaces;
using WebApi0.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApi0.Helpers;


public class UploadFileHelper:IUploadFileHelper
{
    public UploadFileHelper(IHostingEnvironment environment)
    {
        Environment = environment;
    }

    private IHostingEnvironment Environment;
    
    public Boolean UploadImage(UploadImage uploadImage)
    {
        try
        {
            string path = Path.Combine(Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = Path.GetFileName(uploadImage._formFile.FileName);
            FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);
            uploadImage._formFile.CopyTo(stream);
        
            stream.Close();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
  
    }
}