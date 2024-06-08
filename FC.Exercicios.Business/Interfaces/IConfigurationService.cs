using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.Exercicios.Business.Interfaces
{
    public interface IConfigurationService
    {
        Dictionary<string, string> GetSettings();
        void UpdateSettings(Dictionary<string, string> newSettings);
    }
}
