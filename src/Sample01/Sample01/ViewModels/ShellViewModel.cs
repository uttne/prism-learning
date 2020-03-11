using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Sample01.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Sample01 Title";

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public ShellViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }
    }
}