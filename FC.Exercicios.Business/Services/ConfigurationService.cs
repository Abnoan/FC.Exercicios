using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FC.Exercicios.Business.Interfaces;

namespace FC.Exercicios.Business.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private Dictionary<string, string> _settings;

        public ConfigurationService()
        {
            _settings = new Dictionary<string, string>()
            {
                {"Theme", "Blue" },
                {"Language", "English" }
            };
        }

        public Dictionary<string, string> GetSettings()
        {
            return _settings;
        }

        public void UpdateSettings(Dictionary<string, string> newSettings)
        {
            foreach (var setting in newSettings)
            {
                _settings[setting.Key] = setting.Value;
            }
        }
    }
}
