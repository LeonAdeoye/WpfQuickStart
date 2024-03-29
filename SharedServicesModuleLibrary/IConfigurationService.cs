﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServicesModuleLibrary
{
    public interface IConfigurationService
    {
        bool Load();
        bool Initialize();
        string getConfigurationValue(string key);
        void setConfigurationValue(string key, string value);
    }
}
