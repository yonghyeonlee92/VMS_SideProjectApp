using System.Windows;
using System.Windows.Controls;

namespace RtspStreamClientApp.Support.UI.Units
{
    public class MinimizeButton : Button
    {
        static MinimizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizeButton), new FrameworkPropertyMetadata(typeof(MinimizeButton)));
        }

        public MinimizeButton()
        {
            Click += MinimizeButton_Click;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this).WindowState != WindowState.Minimized)
            {
                Window.GetWindow(this).WindowState = WindowState.Minimized;
            }
            else
            {
                Window.GetWindow(this).WindowState = WindowState.Normal;
            }
        }
    }
}
