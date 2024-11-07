using System.Windows;
using System.Windows.Input;

namespace RtspStreamClientApp.Support.UI.Views
{
    public class DarkWindow : Window
    {
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }

        public DarkWindow()
        {
            this.WindowStyle = WindowStyle.None;
            this.AllowsTransparency = true;
            this.ResizeMode = ResizeMode.NoResize;

            //DataContext = new DarkViewModel();
        }

        // OnApplyTemplate 메서드에서 이벤트 연결
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // 템플릿에서 "DragArea"라는 이름의 Grid를 가져와 이벤트 연결
            var dragArea = GetTemplateChild("DragArea") as UIElement;
            if (dragArea != null)
            {
                dragArea.MouseLeftButtonDown += OnDragAreaMouseLeftButtonDown;
            }
        }

        // 마우스 왼쪽 버튼으로 창을 드래그하는 이벤트 핸들러
        private void OnDragAreaMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }

            // 더블 클릭 처리: 창 최대화 또는 복원
            if (e.ClickCount == 2)
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                }
            }
        }

    }
}
