using RstpStreamClientApp.Main.Local.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace RstpStreamClientApp.Main.UI.Views
{
    public class PanelContentView : ContentControl
    {
        static PanelContentView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PanelContentView), new FrameworkPropertyMetadata(typeof(PanelContentView)));
        }

        public PanelContentView(PanelContentViewModel panelContentViewModel)
        {
            DataContext = panelContentViewModel;
        }
    }
}
