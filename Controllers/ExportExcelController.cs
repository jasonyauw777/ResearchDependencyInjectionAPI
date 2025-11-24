using DependencyInjection.Enums;
using DependencyInjectionAPI.Factory;
using DependencyInjectionAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportExcelController : ControllerBase
    {
        private readonly IExportFileService _exportFileService; 
        public ExportExcelController(ExportFileServiceFactory exportFileServiceFactory) 
        {
            _exportFileService = exportFileServiceFactory(nameof(ExportType.EXCEL));
        }

        [HttpGet()]
        public string ExportExcel()
        {
            return _exportFileService.ExportFile("Excel File");
        }
    }
}
