using DependencyInjection.Enums;
using DependencyInjectionAPI.Factory;
using DependencyInjectionAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportPDFController : ControllerBase
    {
        private readonly IExportFileService _exportFileService;
        public ExportPDFController(ExportFileServiceFactory exportFileServiceFactory)
        {
            _exportFileService = exportFileServiceFactory(nameof(ExportType.PDF));
        }

        [HttpGet]
        public string ExportPDF()
        {
            return _exportFileService.ExportFile("PDF File");
        }
    }
}
