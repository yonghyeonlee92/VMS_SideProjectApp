using RstpStreamClientApp.Forms.Local.ViewModels;
using RstpStreamClientApp.Main.UI.Views;
using RtspStreamClientApp.Support.UI.Views;
using System.Windows;

namespace RstpStreamClientApp.Forms.UI.Views
{

    public class VMSWindow : DarkWindow
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        static VMSWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VMSWindow), new FrameworkPropertyMetadata(typeof(VMSWindow)));
        }

        public VMSWindow(IContainerExtension container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;

            Loaded += VMSWindow_Loaded;

        }

        private void VMSWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewMain = _container.Resolve<MainContentView>();
            var viewPanel = _container.Resolve<PanelContentView>();


            IRegion regionMain = _regionManager.Regions["MainRegion"];
            regionMain.Add(viewMain);

            IRegion regionPanel = _regionManager.Regions["PanelRegion"];
            regionPanel.Add(viewPanel);
        }
    }
}
