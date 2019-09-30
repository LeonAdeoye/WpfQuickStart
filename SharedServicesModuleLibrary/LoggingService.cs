using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharedServicesModuleLibrary
{
    public class LoggingService : ILoggingService
    {
        private readonly IConfigurationService _configurationService;
        private String _logURL;
        private IMessageService _messagingService;

        public LoggingService(IConfigurationService configurationService)
        {
            this._configurationService = configurationService;
        }

        IMessageService MessagingService
        {
            get
            {
                return this._messagingService;
            }

            set
            {
                this._messagingService = value;
            }

        }

        public void LogMessage(string component, string message, LOG_LEVEL logLevel)
        {
            var logEntry = String.Format("{0}-{1}-{2}", logLevel, DateTime.Now.ToString(), message);
            Console.WriteLine(logEntry);

            if (this._messagingService != null)
                this._messagingService.SendMessage(this._logURL, logEntry, "POST");
        }

        public void LogMetric(string component, string metricKey, long metricValue)
        {
            throw new NotImplementedException();
        }

        internal void Initialize()
        {
            if(this._messagingService == null)
            {
                throw new NullReferenceException();
            }

            this._logURL = this._configurationService.getConfigurationValue("LOG_URL");
        }
    }
}
