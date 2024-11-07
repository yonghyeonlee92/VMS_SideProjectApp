using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RstpStreamClientApp.Main.Local.ViewModels
{
    public partial class IPCameraInfo : ObservableObject
    {
        [ObservableProperty]
        string _iP;

        public IPCameraInfo(string ip)
        {
            IP = ip;
        }
    }
}
