using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Threading.Tasks;
using Unity;

namespace SharedServicesModuleLibrary
{
    public class SharedServicesModule : IModule
    {
        private readonly IEventAggregator eventAggregator;

        public SharedServicesModule(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator ?? throw new ArgumentNullException("eventAggregator");
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var configurationService = new ConfigurationService();
            containerRegistry.RegisterInstance<IConfigurationService>(configurationService);
            configurationService.Initialize();

            var tasks = new Task[2];

            var loggingService = new LoggingService(configurationService);
            containerRegistry.RegisterInstance<ILoggingService>(loggingService);
            tasks[0] = Task.Factory.StartNew(() => loggingService.Initialize());

            var messageService = new MessageService(configurationService, loggingService);
            containerRegistry.RegisterInstance<IMessageService>(messageService);
            tasks[1] = Task.Factory.StartNew(() => messageService.Initialize());

            // Exceptions thrown by tasks will be propagated to the main thread 
            // while it waits for the tasks. The actual exceptions will be wrapped in AggregateException. 
            try
            {
                // Wait for all the tasks to finish.
                Task.WaitAll(tasks);

                loggingService.LogMessage(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.ToString(), "Successfully completed initialization of all service implementations", LOG_LEVEL.INFO);

            }
            catch (AggregateException e)
            {
                foreach (var exception in e.InnerExceptions)
                {
                    throw new ModuleInitializeException("Catastrophic failure! Exception thrown: " + exception);
                }
            }
        }
    }
}
