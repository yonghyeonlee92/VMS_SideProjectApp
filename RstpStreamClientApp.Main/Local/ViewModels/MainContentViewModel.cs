using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Windows;

namespace RstpStreamClientApp.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableObject
    {
        public ObservableCollection<StreamViewModel> Streams { get; set; }
        
        [ObservableProperty]
        private BitmapImage _cameraFrame;

        [RelayCommand]
        public void OnStartStreaming()
        {
            MessageBox.Show("OnStartStreaming");
        }

        public MainContentViewModel()
        {
            // 스트림 초기화 (4개, 16개, 32개 등)
            Streams = new ObservableCollection<StreamViewModel>
            {
                new StreamViewModel(@"rtsp://211.226.17.176:8554/stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv001.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv002.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv003.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv004.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv005.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv006.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv007.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv008.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv009.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv010.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv011.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv012.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv013.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv014.stream"),
                new StreamViewModel(@"rtsp://210.99.70.120:1935/live/cctv015.stream")
            };
        }
    }
}
