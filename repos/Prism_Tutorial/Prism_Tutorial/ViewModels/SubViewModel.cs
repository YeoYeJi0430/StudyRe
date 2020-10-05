using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism_Tutorial.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism_Tutorial.ViewModels
{
    public class SubViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> ViewChangeCommand { get;set; }

        public SubViewModel() //생성자
        {
            
        }

        private void ViewChange(string uri)
        {
            _regionManager.RequestNavigate("YediRegion", uri);
        }
    }
}
