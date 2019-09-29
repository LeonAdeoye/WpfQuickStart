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
            this._messageService = messageService ?? throw new ArgumentNullException("messageService");
            this._loggingService = loggingService ?? throw new ArgumentNullException("loggingService");
            this._configurationService = configurationService ?? throw new ArgumentNullException("configurationService");
        }
    }
}
