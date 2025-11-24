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
            services.AddTransient<ExportFileServiceFactory>(serviceProvider => key =>
            { 
                switch (key)
                {
                    case nameof(ExportType.PDF):
                        return serviceProvider.GetRequiredService<ExportPDFService>();
                    case nameof(ExportType.WORD):
                        return serviceProvider.GetRequiredService<ExportWordService>();
                    case nameof(ExportType.EXCEL):
                        return serviceProvider.GetRequiredService<ExportExcelService>();
                    default:
                        throw new KeyNotFoundException();
                }
            });
            #endregion
        }
    }
}
