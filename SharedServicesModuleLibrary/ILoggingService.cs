using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServicesModuleLibrary
{
    public enum LOG_LEVEL
    {
        TRACE = 0,
        DEBUG = 1,
        INFO = 3,
        WARN = 4,
        ERROR = 5
    }
    public interface ILoggingService
    {
        void LogMessage(string component, string message, LOG_LEVEL logLevel);
        void LogMetric(string component, string metricKey, long metricValue);
    }
}
