using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Allup.Extentions
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static async Task<string> SaveImageF2(this IFormFile file, IWebHostEnvironment env,  string folder1, string folder2)
        {
            string filename = DateTime.Now + file.FileName;
            
            string path = Path.Combine(env.WebRootPath, folder1, folder2, filename);

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }

            return filename;
        }

        public static async Task<string> SaveImageF3(this IFormFile file, IWebHostEnvironment env, string folder1, string folder2, string folder3)
        {
            string filename = DateTime.Now + file.FileName;

            string path = Path.Combine(env.WebRootPath, folder1, folder2, folder3, filename);

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }

            return filename;
        }
    }
}