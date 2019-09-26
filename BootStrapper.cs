using Prism.Unity;
using System.Windows;
using Unity;
using WpfQuickStart.SharedServices;

namespace WpfQuickStart
{
    class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return null; // ServiceLocator.Current.GetInstance<Shell>();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterInstance(typeof(LoggingService), "LoggingService", new LoggingService());
        }
    }
}
