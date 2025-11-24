using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Services
{
    public class ExportExcelService : IExportFileService
    {
        public string ExportFile(string message)
        {
            Console.WriteLine($"Exporting Excel Document : {message}");

            string ExportOutput = $"Exporting Excel Document : {message}";

            return ExportOutput;
        }
    }
}
