using RstpStreamClientApp.Forms.UI.Views;
using RstpStreamClientApp.Forms.Local.ViewModels;
using System.Windows;
using RstpStreamClientApp.Main.Local.ViewModels;

namespace RstpStreamClientApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<VMSWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainContentViewModel>();
            containerRegistry.Register<PanelContentViewModel>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
        }
    }

}
