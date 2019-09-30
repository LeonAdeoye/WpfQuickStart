using CommonServiceLocator;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;
using Unity;

namespace WpfQuickStart
{
    sealed class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void InitializeModules()
        {
            try
            {
                base.InitializeModules();
            }
            catch (ModuleInitializeException)
            {
                // TODO: Rename app to something other than QuickStart.
                MessageBox.Show("Failed to initialize modules needed by {0} application. Catastrophic failure. Shutting down now!", "QuickStart");
                Environment.Exit(0);
            }
        }
    }
}
