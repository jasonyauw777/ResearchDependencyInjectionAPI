using DependencyInjectionAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAPI.Services
{
    public class ExportWordService : IExportFileService
    {
        public string ExportFile(string message)
        {

            string ExportOutput = $"Exporting Word Document : {message}";

            return ExportOutput;
        }
    }
}
