using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;
using QIQO.Prism.Views;
using System.Windows;
using ModuleA.Modules;

namespace QIQO.Prism
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            // return base.CreateModuleCatalog();
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof(ModuleAModule));
            return catalog;
        }

        protected override void ConfigureContainer()
        {
            // RegisterTypeIfMissing(typeof(ILRPService), typeof(LRPProxy), true);

            base.ConfigureContainer();

            //InitContainer();
        }


        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow.Show();
        }

        //protected override ILoggerFacade CreateLogger()
        //{
        //    return new LoggerAdapter();
        //}
    }
}
