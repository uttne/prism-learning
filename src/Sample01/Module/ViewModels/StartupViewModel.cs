using Module.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Module.ViewModels
{
    public class StartupViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IRegionNavigationJournal _jurJournal;

        public StartupViewModel(IRegionManager regionManager,IRegionNavigationJournal jurJournal)
        {
            _regionManager = regionManager;
            _jurJournal = jurJournal;

            GoNaviCommand = new DelegateCommand(GoNavi);
        }

        private void GoNavi()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(Navi));
            _jurJournal.GoForward();
        }

        public DelegateCommand GoNaviCommand { get; set; }
    }
}