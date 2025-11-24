using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Factory
{
    public class ServicesFactory
    {
        public delegate IExportFileService ExportFileServiceFactory(Enum key);

        public delegate IImportFileService ImportFileServiceFactory(Enum key);
    }
}
