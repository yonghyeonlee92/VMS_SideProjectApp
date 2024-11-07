using CommunityToolkit.Mvvm.ComponentModel;
using RstpStreamClientApp.Main.UI.Units;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;

namespace RstpStreamClientApp.Main.Local.ViewModels
{
    public class PanelContentViewModel : ObservableObject
    {
        public ObservableCollection<IPCameraInfo> IPCameras { get; set; }

        public PanelContentViewModel()
        {
            IPCameras = new ObservableCollection<IPCameraInfo>
            {
                new(@"rtsp://211.226.17.176:8554/stream"),
                new(@"rtsp://211.226.17.176:8554/stream"),
                new(@"rtsp://211.226.17.176:8554/stream")
            };
        }
    }
}
