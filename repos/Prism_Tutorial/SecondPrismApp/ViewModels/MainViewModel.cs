using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondPrismApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string displayName;
        public string DisplayName
        {
            get => displayName;
            set => SetProperty(ref displayName, value);
        }
        public MainViewModel() //생성자
        {
            DisplayName = "Prism App";
        }
    }
}
