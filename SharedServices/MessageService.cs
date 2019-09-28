using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfQuickStart.SharedServices
{
    class MessageService : IMessageService
    {
        private readonly IConfigurationService configurationService;
        private readonly ILoggingService loggingService;

        public MessageService(IConfigurationService configurationService, ILoggingService loggingService)
        {
            this.configurationService = configurationService;
            this.loggingService = loggingService;
        }

        public bool SendMessage(string url, string payload, string method)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string url, string method = "GET")
        {
            throw new NotImplementedException();
        }

        internal void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
