using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAPI.Interfaces
{
    public interface IExportFileService
    {
        string ExportFile(string message);
    }
}
