using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class imageController : Controller
    {

        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage()
        {
            var file = Request.Form.Files.FirstOrDefault();

            if (file == null || file.Length == 0)
                return BadRequest("No image uploaded.");
            
            var uploadFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                if (!Directory.Exists(uploadFolderPath))
                {
                    Directory.CreateDirectory(uploadFolderPath);
                }

            var fileName = file.FileName;

                //Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                var filePath = Path.Combine(uploadFolderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return Ok(new { path =  fileName });

            }  
    }
}