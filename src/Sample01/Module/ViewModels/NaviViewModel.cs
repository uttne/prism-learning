using Module.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Module.ViewModels
{
    public class NaviViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IRegionNavigationJournal _journal;

        public NaviViewModel(IRegionManager regionManager, IRegionNavigationJournal journal)
        {
            _regionManager = regionManager;
            _journal = journal;

            GoView1Command = new DelegateCommand(GoView1);
            GoView2Command = new DelegateCommand(GoView2);
            GoView3Command = new DelegateCommand(GoView3);
            GoView4Command = new DelegateCommand(GoView4);
        }
        private void GoView4()
        {
            _regionManager.RequestNavigate(RegionName, nameof(View4));
            _journal.GoForward();
        }
        private void GoView3()
        {
            _regionManager.RequestNavigate(RegionName, nameof(View3));
            _journal.GoForward();
        }
        private void GoView2()
        {
            _regionManager.RequestNavigate(RegionName, nameof(View2));
            _journal.GoForward();
        }

        private void GoView1()
        {
            _regionManager.RequestNavigate(RegionName, nameof(View1));
            _journal.GoForward();
        }

        public string RegionName { get; set; } = "NaviRegionContent";
        public DelegateCommand GoView1Command { get; set; }
        public DelegateCommand GoView2Command { get; set; }
        public DelegateCommand GoView3Command { get; set; }
        public DelegateCommand GoView4Command { get; set; }
    }
}