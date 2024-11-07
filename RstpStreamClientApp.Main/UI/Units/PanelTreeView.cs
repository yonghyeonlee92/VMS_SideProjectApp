using System.Windows;
using System.Windows.Controls;

namespace RstpStreamClientApp.Main.UI.Units
{

    public class PanelTreeView : TreeView
    {
        static PanelTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PanelTreeView), new FrameworkPropertyMetadata(typeof(PanelTreeView)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PanelTreeItem();
        }
    }
}
