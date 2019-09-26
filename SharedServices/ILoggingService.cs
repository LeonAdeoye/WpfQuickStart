using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuickStart.SharedServices
{
    public enum LOG_LEVEL
    {
        TRACE = 0,
        DEBUG = 1,
        METRIC = 2,
        INFO = 3,
        WARN = 4,
        ERROR = 5
    }
    interface ILoggingService
    {
        void log(string component, string message, LOG_LEVEL logLevl, string key = "");
    }
}
