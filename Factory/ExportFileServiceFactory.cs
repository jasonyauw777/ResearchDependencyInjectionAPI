using DependencyInjectionAPI.Interfaces;

namespace DependencyInjectionAPI.Factory
{
    public delegate IExportFileService ExportFileServiceFactory(string key);
}
