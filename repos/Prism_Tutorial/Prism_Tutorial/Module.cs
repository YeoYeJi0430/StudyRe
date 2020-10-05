using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_Tutorial.Views;
using SubModule.Views;

namespace Prism_Tutorial
{
    public class Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("SubRegion", typeof(SubView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
