<UserControl x:Class="$rootnamespace$.IvCustomControl.IvCustomMeter"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
             xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
             xmlns:Controls="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
             mc:Ignorable="d" 
            x:Name="rootMeter"
             >
            <Controls:IvMeter 
             ReadExpression="{Binding ElementName=rootMeter,Path=IvTagMeter}" 
             IvUnitVisibility="False" 
             IvArgDecimals="1"
             Style="{DynamicResource IvMeter}" 
             Width="{Binding ElementName=rootMeter,Path=ActualWidth}" 
             Height="{Binding ElementName=rootMeter,Path=ActualHeight}" />
      
</UserControl>
