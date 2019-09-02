<UserControl x:Class="$rootnamespace$.IvCustomControl.IvCustomPanelAutoManual"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
             xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
             xmlns:Controls="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
             mc:Ignorable="d" 
             d:DesignHeight="230" d:DesignWidth="280"   MinWidth="280" MinHeight="230" 
            x:Name="rootPanelAutoManual"
             >
 
    <Grid>
        <Border Style="{DynamicResource IvBorderContainer}" Width="280" Height="230" Canvas.Left="20" Canvas.Top="20">
            <Canvas>
                <Label Style="{DynamicResource IvTitle}" Content="{Binding ElementName=rootPanelAutoManual,Path=IvPanelAutoManualViewModel.IvTitle}" Width="280"  />
                <Controls:IvSign  ReadExpression="{Binding ElementName=rootPanelAutoManual,Path=IvPanelAutoManualViewModel.IvTagStatus}" 
                    TextListW="{DynamicResource PanelAutoManualMode}" 
                    BackgroundColorListW="#FFFF00,#0D1082,#F98609,BLACK"
                    ForegroundColorListW="BLACK,White,BLACK,YELLOW"                                    
                    ValueList="0,1,2,3" 
                    Width="240" 
                    Height="35" 
                    Canvas.Top="35" 
                    Canvas.Left="20" 
                    FontFamily="Calibri" 
                    FontSize="16"                                
                    />
                <Controls:IvCommand ReleaseWriteTag="{Binding ElementName=rootPanelAutoManual,Path=IvPanelAutoManualViewModel.IvTagAuto}"
                    ValueTagWriteRelease ="1"
                    AutoSendLeft="True"
                    ConfirmMessageLeft="True"
                    IvConfirmTextLeft="{DynamicResource PanelAutoManualConfirmMessageAuto}"
                    LabelType="Image"
                    DefaultImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonazul.bmp"
                    DisarmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonazul.bmp"
                    ArmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\BotonAzul_presionado.bmp"
                    Cursor="Hand"
                    Width="90"
                    Height="80" 
                    Canvas.Top="110"
                    Canvas.Left="30"/>
                <Controls:IvCommand ReleaseWriteTag="{Binding ElementName=rootPanelAutoManual,Path=IvPanelAutoManualViewModel.IvTagManual}"
                    ValueTagWriteRelease ="1"
                    AutoSendLeft="True"
                    ConfirmMessageLeft="True"
                    IvConfirmTextLeft="{DynamicResource PanelAutoManualConfirmMessageManual}"
                    LabelType="Image"
                    DefaultImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonamarillo.bmp"
                    DisarmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonamarillo.bmp"
                    ArmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\BotonAmarillo_presionado.bmp"
                    Cursor="Hand"
                    Width="90" 
                    Height="80" 
                    Canvas.Top="110"
                    Canvas.Left="160"/>

                <Label Content="{DynamicResource PanelAutoManualLabelAuto}" 
                       HorizontalContentAlignment="Center" 
                       VerticalContentAlignment="Center" 
                       Style="{DynamicResource IvLabel}"
                       Canvas.Top="190" 
                       Canvas.Left="20" 
                       Width="110"/>
                <Label Content="{DynamicResource PanelAutoManualLabelManual}" 
                       HorizontalContentAlignment="Center" 
                       VerticalContentAlignment="Center"
                       Style="{DynamicResource IvLabel}"
                       Canvas.Top="190"
                       Canvas.Left="150" 
                       Width="110"/>
                </Canvas>
        </Border>

    </Grid>
</UserControl>
