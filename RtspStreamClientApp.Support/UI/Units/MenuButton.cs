using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RtspStreamClientApp.Support.UI.Units
{
    public class MenuButton : Button
    {
        static MenuButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuButton), new FrameworkPropertyMetadata(typeof(MenuButton)));
        }

        public MenuButton()
        {
            Click += MenuButton_Click;
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var mousePosition = this.PointToScreen(Mouse.GetPosition(this));
            SystemCommands.ShowSystemMenu(Window.GetWindow(this), mousePosition);
        }
    }
}
