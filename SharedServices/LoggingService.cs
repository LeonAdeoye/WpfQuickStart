using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuickStart.SharedServices
{
    class LoggingService : ILoggingService
    {
        // TODO inject message service
        public void log(string component, string message, LOG_LEVEL logLevl, string key = "")
        {
            // call message service send
            throw new NotImplementedException();
        }
    }
}
