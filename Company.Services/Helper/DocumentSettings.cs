using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Helper
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file,String FolderPath) {
            var folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", FolderPath);
            var fileName=$"{Guid.NewGuid()}-{file.FileName}";
            var filepath=Path.Combine(folderpath, fileName);

            using var FileStream = new FileStream(filepath, FileMode.Create);

            file.CopyTo(FileStream);
            return filepath;
        }
    }
}
