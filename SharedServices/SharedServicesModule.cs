using Prism.Ioc;
using Prism.Modularity;
using System;

namespace WpfQuickStart.SharedServices
{
    class SharedServicesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoggingService, LoggingService>();
            containerRegistry.RegisterSingleton<IConfigurationService, ConfigurationService>();
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }
    }
}
