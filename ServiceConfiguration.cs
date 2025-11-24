using DependencyInjectionAPI.Services;
using DependencyInjectionAPI.Factory;
using DependencyInjection.Enums;

namespace DependencyInjectionAPI
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Factory Pattern DI
            services.AddScoped<ExportPDFService>();
            services.AddScoped<ExportWordService>();
            services.AddScoped<ExportExcelService>();
            services.AddTransient<ServicesFactory.ExportFileServiceFactory>(serviceProvider => key =>
            { 
                switch ((Enum)key)
                {
                    case FileType.PDF:
                        return serviceProvider.GetRequiredService<ExportPDFService>();
                    case FileType.WORD:
                        return serviceProvider.GetRequiredService<ExportWordService>();
                    case FileType.EXCEL:
                        return serviceProvider.GetRequiredService<ExportExcelService>();
                    default:
                        throw new KeyNotFoundException();
                }
            });

            services.AddScoped<ImportPDFService>();
            services.AddScoped<ImportWordService>();
            services.AddScoped<ImportExcelService>();
            services.AddTransient<ServicesFactory.ImportFileServiceFactory>(serviceProvider => key =>
            {
                switch ((Enum)key)
                {
                    case FileType.PDF:
                        return serviceProvider.GetRequiredService<ImportPDFService>();
                    case FileType.WORD:
                        return serviceProvider.GetRequiredService<ImportWordService>();
                    case FileType.EXCEL:
                        return serviceProvider.GetRequiredService<ImportExcelService>();
                    default:
                        throw new KeyNotFoundException();
                }
            });
            #endregion
        }
    }
}
