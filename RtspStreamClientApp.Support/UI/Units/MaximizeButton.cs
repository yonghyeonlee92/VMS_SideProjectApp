using System.Windows;
using System.Windows.Controls;

namespace RtspStreamClientApp.Support.UI.Units
{
    public class MaximizeButton : Button
    {   
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }

        public MaximizeButton()
        {
            Click += MaximizeButton_Click;
        }

        private void MaximizeButton_StateChanged(object? sender, EventArgs e)
        {
            if (Window.GetWindow(this).WindowState == WindowState.Maximized)
            {
                // 작업 표시줄의 크기를 고려하여 창 크기를 조정
                var screen = SystemParameters.WorkArea;
                this.MaxWidth = screen.Width;
                this.MaxHeight = screen.Height;
            }
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this).WindowState != WindowState.Maximized)
            {
                Window.GetWindow(this).WindowState = WindowState.Maximized;
            }
            else
            {
                Window.GetWindow(this).WindowState = WindowState.Normal;
            }
             
        }
    }
}
