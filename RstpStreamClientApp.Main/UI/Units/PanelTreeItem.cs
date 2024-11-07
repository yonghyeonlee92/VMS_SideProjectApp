using System.Windows;
using System.Windows.Controls;

namespace RstpStreamClientApp.Main.UI.Units
{

    public class PanelTreeItem : TreeViewItem
    {
        static PanelTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PanelTreeItem), new FrameworkPropertyMetadata(typeof(PanelTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PanelTreeItem();
        }
    }
}
