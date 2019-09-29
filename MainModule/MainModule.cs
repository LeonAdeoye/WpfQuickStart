using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfQuickStart.Interfaces;

namespace WpfQuickStart.MainModule
{
    class MainModule : IModule
    {
        private readonly IRegionManager _regionManager; 
        public MainModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager ?? throw new ArgumentNullException("regionManager");
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            this._regionManager
                .RegisterViewWithRegion(RegionNames.MAIN_BODY_USER_CONTROL_REGION, typeof(MainBodyUserControl))
                .RegisterViewWithRegion(RegionNames.MAIN_HEADER_USER_CONTROL_REGION, typeof(HeaderUserControl));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
