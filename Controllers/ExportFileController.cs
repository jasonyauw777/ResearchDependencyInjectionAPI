using DependencyInjection.Enums;
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
        public string Export(int fileType)
        {
            Enum EnumFileType = (ExportType)fileType;
            IExportFileService _exportFileService = _exportFileServiceFactory(EnumFileType);
            return _exportFileService.ExportFile("Filename");
        }
    }
}
