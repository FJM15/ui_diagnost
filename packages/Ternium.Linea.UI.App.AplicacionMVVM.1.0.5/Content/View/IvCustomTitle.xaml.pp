<UserControl x:Class="$rootnamespace$.IvCustomControl.IvCustomTitle"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
             xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
             xmlns:Controls="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
             mc:Ignorable="d" 
            x:Name="rootTitle"
             >
    <Label Width="{Binding ElementName=rootTitle,Path=ActualWidth}" 
           Height="{Binding ElementName=rootTitle,Path=ActualHeight}" 
           Style="{DynamicResource IvTitle}" 
           Margin="1" Content="{Binding ElementName=rootTitle,Path=IvTitle}"  />
      
 
      
</UserControl>
