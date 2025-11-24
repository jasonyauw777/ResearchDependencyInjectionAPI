using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Services
{
    public class ImportWordService : IImportFileService
    {
        public string ImportFile()
        {
            string ImportOutput = $"Importing Word File";

            return ImportOutput;
        }
    }
}
