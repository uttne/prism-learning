using Module.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Module
{
    public class ModuleModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<View1>();
            containerRegistry.RegisterForNavigation<View2>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}