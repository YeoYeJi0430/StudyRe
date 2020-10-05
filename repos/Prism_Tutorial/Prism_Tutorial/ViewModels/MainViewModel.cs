using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Prism_Tutorial.ViewModels
{
    public class MainViewModel : BindableBase
    {
        IRegionManager regionManager;
        private bool isDeny;
        public bool IsDeny
        {
            get => isDeny;
            set
            {
                SetProperty(ref isDeny, value);
            }
        }
        public DelegateCommand<string> SuperCommand { get; private set; }
        public MainViewModel(IRegionManager regionManager)
        {
            SuperCommand = new DelegateCommand<string>(Jebal);            
            IsDeny = false;
            this.regionManager = regionManager;
            this.regionManager.RequestNavigate("SubRegion", "SubView");
        }

        private void Jebal(string path)
        {
            if(path != null)
            {
                this.regionManager.RequestNavigate("SubRegion", path);
            }
            
        }
    }
}
