using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServicesModuleLibrary
{
    public class ConfigurationService : IConfigurationService
    {
        public ConfigurationService()
        {

        }

        public bool Load()
        {
            throw new NotImplementedException();
        }

        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public void setConfigurationValue(string key, string value)
        {
            throw new NotImplementedException();
        }

        public string getConfigurationValue(string key)
        {
            throw new NotImplementedException();
        }
    }
}
