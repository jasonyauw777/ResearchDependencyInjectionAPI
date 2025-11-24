using DependencyInjectionAPI.Factory;
using DependencyInjectionAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportFileController
    {
        private readonly ExportFileServiceFactory _exportFileServiceFactory;

        public ExportFileController(ExportFileServiceFactory exportFileServiceFactory)
        {
            _exportFileServiceFactory = exportFileServiceFactory;
        }

        [HttpGet("{fileType}")]
        public string Export(string fileType)
        {
            IExportFileService _exportFileService = _exportFileServiceFactory(fileType);
            return _exportFileService.ExportFile("Filename");
        }
    }
}
