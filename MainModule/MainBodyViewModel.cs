using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfQuickStart.SharedServices;

namespace WpfQuickStart.MainModule
{
    class MainBodyViewModel
    {
        private readonly IMessageService _messageService;
        private readonly ILoggingService _loggingService;
        private readonly IConfigurationService _configurationService;
        public MainBodyViewModel(IMessageService messageService, ILoggingService loggingService, IConfigurationService configurationService)
        {
            if (messageService == null)
                throw new ArgumentNullException("messageService");

            if (loggingService == null)
                throw new ArgumentNullException("loggingService");

            if (configurationService == null)
                throw new ArgumentNullException("configurationService");

            this._messageService = messageService;
            this._loggingService = loggingService;
            this._configurationService = configurationService;
        }
    }
}
