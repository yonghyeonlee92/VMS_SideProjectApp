using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media.Imaging;
using System.Windows;
using OpenCvSharp;
using RtspStreamClientApp.Support.Helpers;

namespace RstpStreamClientApp.Main.Local.ViewModels
{
    public partial class StreamViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _rtspUrl;

        [ObservableProperty]
        private BitmapImage _cameraFrame;

        VideoCapture _videoCapture;
        bool _isRunning = false;

        [RelayCommand]
        private void OnStartStreaming()
        {
            if (_isRunning)
            {
                MessageBox.Show("Already Started Streaming!");
                return;
            }

            if (RtspUrl == string.Empty)
            {
                MessageBox.Show("Please Set RTSP URL in Setting!");
                return;
            }

            _videoCapture = new VideoCapture(RtspUrl);
            if (!_videoCapture.IsOpened())
            {
                return;
            }

            _isRunning = true;
            Task.Run(GetFrame);
            MessageBox.Show("Task Run GetFrame");
        }

        [RelayCommand]
        private void OnSettingDialog()
        {
            MessageBox.Show("OnSettingDialog");
        }

        public StreamViewModel(string rtspUrl)
        {
            RtspUrl = rtspUrl;
        }

        private async Task GetFrame()
        {
            while (_isRunning)
            {
                using Mat frame = new Mat();
                if (!_videoCapture.Read(frame) || frame.Empty())
                {
                    continue; // 프레임을 읽지 못했을 경우 넘어갑니다.
                }

                using Mat dst = new Mat();
                //ImageProcess.ToGray(frame, dst);

                Application.Current.Dispatcher.Invoke(() =>
                {
                    CameraFrame = ImageConverter.MatToBitmapImage(frame);
                });
            }
        }
    }
}
