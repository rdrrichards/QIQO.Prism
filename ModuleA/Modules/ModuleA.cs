using ModuleA.Views;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA.Modules
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("LeftRegion", typeof(ModuleAListView));
        }
    }
}
