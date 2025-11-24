using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Services
{
    public class ImportExcelService : IImportFileService
    {
        public string ImportFile()
        {
            string ImportOutput = $"Importing Excel File";

            return ImportOutput;
        }
    }
}
