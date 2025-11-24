using DependencyInjection.Enums;
using DependencyInjectionAPI.Factory;
using DependencyInjectionAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportFileController : ControllerBase
    {
        private readonly ServicesFactory.ImportFileServiceFactory _importFileServiceFactory;

        public ImportFileController(ServicesFactory.ImportFileServiceFactory importFileServiceFactory) 
        {
            _importFileServiceFactory = importFileServiceFactory;
        }

        [HttpGet("{fileType}")]
        public string Import(int fileType)
        {
            Enum EnumFileType = (FileType)fileType;
            IImportFileService _importFileService = _importFileServiceFactory(EnumFileType);
            return _importFileService.ImportFile();
        }
    }
}
