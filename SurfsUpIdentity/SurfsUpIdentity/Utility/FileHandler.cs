using Microsoft.AspNetCore.Hosting;
using SurfsUpIdentity.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Utility
{
    public static class FileHandler
    {
        public static async Task<LendOutEquipmentViewModel> SaveFile(IWebHostEnvironment _hostingEnvironment, LendOutEquipmentViewModel model)
        {
            foreach (var picture in model.Picture)
            {
                if (picture.Length > 0)
                {
                    var uniqueFileName = GetUniqueFileName(picture.FileName);
                    var uploadFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Upload");
                    var filePath = Path.Combine(uploadFolderPath, uniqueFileName);

                    using (var stream = File.Create(filePath))
                    {
                        await picture.CopyToAsync(stream);
                    }
                    model.NewFileName.Add(uniqueFileName);
                }
            }
            return model;
        }

        public static async Task<SurfSpotViewModel> SaveFile(IWebHostEnvironment _hostingEnvironment, SurfSpotViewModel model)
        {
            if (model.Image.Length > 0)
            {
                var uniqueFileName = GetUniqueFileName(model.Image.FileName);
                var uploadFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Upload");
                var filePath = Path.Combine(uploadFolderPath, uniqueFileName);
                model.ImagePath = uniqueFileName;

                using (var stream = File.Create(filePath))
                {
                    await model.Image.CopyToAsync(stream);
                }
            }
            
            return model;
        }

        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                    + "_"
                    + Guid.NewGuid().ToString().Substring(0, 4)
                    + Path.GetExtension(fileName);
        }
    }
}
