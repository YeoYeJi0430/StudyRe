using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Prism_Tutorial.Views;
using System.Windows;

namespace Prism_Tutorial
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {            
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<YediView>();
            //containerRegistry.RegisterForNavigation<SubView>();            
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //base.ConfigureModuleCatalog(moduleCatalog);
            //moduleCatalog.AddModule<Module>();
            moduleCatalog.AddModule<SubModule.ModuleLoader>();
        }

    }
}
