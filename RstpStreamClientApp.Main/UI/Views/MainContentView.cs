using RstpStreamClientApp.Main.Local.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace RstpStreamClientApp.Main.UI.Views
{
    public class MainContentView : ContentControl
    {
        static MainContentView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContentView), new FrameworkPropertyMetadata(typeof(MainContentView)));
        }

        public MainContentView(MainContentViewModel viewModel)
        {
            DataContext = viewModel;
        }
    }
}
