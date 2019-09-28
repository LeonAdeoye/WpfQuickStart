using CommonServiceLocator;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;
using Unity;

namespace WpfQuickStart
{
    sealed class RequestForQuoteBootstrapper : UnityBootstrapper
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
                RegisterAllPopups();
            }
            catch (ModuleInitializeException)
            {
                MessageBox.Show("Failed to initialize modules needed by RequestForQuote application. Catastrophic failure. Shutting down now!");
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Registers the various window popups used by the application usig the unity container.
        /// </summary>
        private void RegisterAllPopups()
        {
            //Container.RegisterType<IWindowPopup, RequestForQuoteDetailsWindow>(WindowPopupNames.REQUEST_DETAIL_WINDOW_POPUP);
        }
    }
}
