﻿using System;
using System.IO;
using System.Web;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public class ReadUploadedImageFileInfo : ReadImageFileInfo, IReadUploadedImageFileInfo
    {
        public override bool CheckIsFileExist(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                
                //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\";
                var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";

                //var appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"~\Images\Uploaded\");
                //var serverPath = HttpContext.Current.Server.MapPath(@"~/Images/Uploaded");

                return File.Exists(path + fileName) ? true : false;

            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public override string GetImageExtension(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                if (CheckIsFileExist(fileName))
                {
                    //var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";
                    var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\";
                    var extension = MimeMapping.GetMimeMapping(path + fileName);

                    if (!String.IsNullOrEmpty(extension))
                    {
                        return extension;
                    }
                    else
                    {
                        throw new ApplicationException();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}