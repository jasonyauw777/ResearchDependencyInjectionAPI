using DependencyInjectionAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAPI.Services
{
    public class ExportPDFService : IExportFileService
    {
        public string ExportFile(string message)
        {
            Console.WriteLine($"Exporting PDF Document : {message}");

            string ExportOutput = $"Exporting PDF Document : {message}";

            return ExportOutput;
        }
    }
}
