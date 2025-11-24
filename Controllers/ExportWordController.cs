using DependencyInjection.Enums;
using DependencyInjectionAPI.Factory;
using DependencyInjectionAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportWordController : ControllerBase
    {
        private readonly IExportFileService _exportFileService;
        public ExportWordController(ExportFileServiceFactory exportFileServiceFactory)
        {
            _exportFileService = exportFileServiceFactory(nameof(ExportType.WORD));
        }

        [HttpGet()]
        public string ExportWord()
        {
            return _exportFileService.ExportFile("Word Document");
        }
    }
}
