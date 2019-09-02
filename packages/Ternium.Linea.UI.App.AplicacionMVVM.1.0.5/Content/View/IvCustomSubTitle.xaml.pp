<UserControl x:Class="$rootnamespace$.IvCustomControl.IvCustomSubTitle"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
             xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
             xmlns:Controls="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
             mc:Ignorable="d" 
            x:Name="rootSubTitle"
             >
    <Label Width="{Binding ElementName=rootSubTitle,Path=ActualWidth}" 
           Height="{Binding ElementName=rootSubTitle,Path=ActualHeight}" 
           Style="{DynamicResource IvSubTitle}" 
           Margin="1" Content="{Binding ElementName=rootSubTitle,Path=IvSubTitle}" />
      
 
      
</UserControl>
