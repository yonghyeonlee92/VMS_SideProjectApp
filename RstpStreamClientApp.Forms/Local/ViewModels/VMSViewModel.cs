using RstpStreamClientApp.Main.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RstpStreamClientApp.Forms.Local.ViewModels
{
    public class VMSViewModel
    {
        private RegionManager _regionManager;
        private IContainerProvider _containerProvider;
        public VMSViewModel(RegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            // ViewModel이 생성될 때 자동으로 View를 Region에 활성화
            ActivateViewInRegion();
        }

        private void ActivateViewInRegion()
        {
            var view = _containerProvider.Resolve<MainContentView>();
            _regionManager.Regions["MainRegion"].Activate(view);
        }
    }
}
