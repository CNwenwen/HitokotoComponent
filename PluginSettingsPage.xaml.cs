using System.Windows.Controls;
using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Enums.SettingsWindow;
using MaterialDesignThemes.Wpf;

namespace HitokotoComponent;

[SettingsPageInfo(
    "HitokotoComponent.PluginSettingsPage",   // 设置页面 id
    "一言 设置",  // 设置页面名称
    PackIconKind.CogOutline,   // 未选中时设置页面图标
    PackIconKind.Cog,  // 选中时设置页面图标
    SettingsPageCategory.External  // 设置页面类别
)]
public partial class PluginSettingsPage : SettingsPageBase
{
    public static int Mode { get; set; }
    public static int MaxLength { get; set; }
    public PluginSettingsPage()
    {
        InitializeComponent();
    }

    private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var cb = sender as ComboBox;
        Mode = cb.SelectedIndex;
    }
}