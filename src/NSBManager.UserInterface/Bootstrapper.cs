using System;
using System.Windows;
using Microsoft.Practices.Composite.Modularity;
using StructureMap;

namespace NSBManager.UserInterface
{
    public class Bootstrapper : StructureMapBootstrapper
    {
        protected override IModuleCatalog GetModuleCatalog()
        {
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof (PhysicalModule.PhysicalModule));

            return catalog;
        }

        protected override DependencyObject CreateShell()
        {
            var presenter = ObjectFactory.GetInstance<ShellPresenter>();
            IShellView view = presenter.View;

            view.ShowView();

            return view as DependencyObject;
        }
    }
}