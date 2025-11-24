using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Services
{
    public class ImportPDFService : IImportFileService
    {
        public string ImportFile()
        {
            string ImportOutput = $"Importing PDF File";

            return ImportOutput;
        }
    }
}
