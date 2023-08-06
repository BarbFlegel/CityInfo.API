//using CityInfo.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;    

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider 
                ?? throw new System.ArgumentNullException(nameof(fileExtensionContentTypeProvider));   
        }   

        [HttpGet("{fieldId}")]
        public ActionResult GetFile (string fileId)
        {
            var pathToFile = "CV_2021-10-11_Barbora_Flegelova.pdf";

            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();  
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(
                pathToFile, out var contentType))
            {
                contentType = "application/octer-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes,contentType, Path.GetFileName(pathToFile)); 
        }
    }
}
