using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Helpers
{
    public class UploadFile
    {
        public static string Upload(IFormFile file)
        {
            var savePath = "wwwroot/files";
            if (file.Length > 0)
            {
                var filePath = Path.Combine(savePath,
                    file.FileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
                return file.FileName;

            }
            return null;
        }
    }
}
