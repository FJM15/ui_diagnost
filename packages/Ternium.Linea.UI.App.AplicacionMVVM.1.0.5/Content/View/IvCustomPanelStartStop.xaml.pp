<UserControl x:Class="$rootnamespace$.IvCustomControl.IvCustomPanelStartStop"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
             xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
             xmlns:Controls="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
             mc:Ignorable="d" 
             d:DesignHeight="230" d:DesignWidth="280"  
             x:Name="rootPanelStartStop"
             >

    <Grid>
        <Border >
            <ItemsControl ItemsSource="{Binding ElementName=rootPanelStartStop,Path=IvPanelStartStopViewModel}"> 
                <ItemsControl.ItemsPanel>
                    <ItemsPanelTemplate>
                        <Grid>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition/>
                                <ColumnDefinition/>
                                <ColumnDefinition/>
                                <ColumnDefinition/>
                            </Grid.ColumnDefinitions>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="235"/>
                                <RowDefinition Height="235"/>
                                <RowDefinition Height="235"/>
                                <RowDefinition Height="235"/>
                            </Grid.RowDefinitions>
                        </Grid>
                    </ItemsPanelTemplate>
                </ItemsControl.ItemsPanel>
                <ItemsControl.ItemContainerStyle>
                    <Style TargetType="ContentPresenter">
                        <Setter Property="Grid.Row" Value="{Binding IvRow}"/>
                        <Setter Property="Grid.Column" Value="{Binding IvColumn}"/>
                    </Style>
                </ItemsControl.ItemContainerStyle>
                <ItemsControl.ItemTemplate>
                    <DataTemplate>
                        <Border Height="230" Width="280" Margin="0,0,5,5" Style="{DynamicResource IvBorderContainer}">
                        <Canvas x:Name="canvas" DataContext="{Binding}">
                            <Label Style="{DynamicResource IvTitle}" Content="{Binding IvTitle}" Width="280"  />
                                <Controls:IvSign  ReadExpression="{Binding ElementName=canvas,Path=DataContext.IvTagStatus}" 
                    TextListW="{DynamicResource PanelStartStopMode}"
                    BackgroundColorListW="#909090,#00FF00,#FF0000,#FFFF00"
                    ForegroundColorListW="White,BLACK,BLACK,BLACK"                                    
                    ValueList="0,1,2,3" 
                    Width="240" 
                    Height="35" 
                    Canvas.Top="35" 
                    Canvas.Left="20" 
                    FontFamily="Calibri" 
                    FontSize="16"                                
                    />
                                <Controls:IvCommand ReleaseWriteTag="{Binding ElementName=canvas,Path=DataContext.IvTagStart}"
                    ValueTagWriteRelease="1"
                    AutoSendLeft="True"
                    ConfirmMessageLeft="True"
                    IvConfirmTextLeft="{DynamicResource PanelStartStopConfirmMessageStart}"
                    LabelType="Image"
                    DefaultImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonVerde.bmp" 
                	DisarmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonVerde.bmp"
                	ArmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvPlantillaEstandar\botonVerde_presionado.bmp"
                    Cursor="Hand"
                    Width="90"
                    Height="80" 
                    Canvas.Top="110"
                    Canvas.Left="30"/>
                                <Controls:IvCommand ReleaseWriteTag="{Binding ElementName=canvas,Path=DataContext.IvTagStop}"
                    ValueTagWriteRelease="1"
                    AutoSendLeft="True"
                    ConfirmMessageLeft="True"
                    IvConfirmTextLeft="{DynamicResource PanelStartStopConfirmMessageStop}"
                    LabelType="Image"
                    DefaultImage="C:\Program Files\TerniumAuto\Ivision\Images\IvDevicesControl\botonGris.bmp" 
                	DisarmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvDevicesControl\botonGris.bmp"
                	ArmImage="C:\Program Files\TerniumAuto\Ivision\Images\IvDevicesControl\botonGris_presionado.bmp"
                    Cursor="Hand"
                    Width="90" 
                    Height="80" 
                    Canvas.Top="110"
                    Canvas.Left="160"/>

                            <Label Content="{DynamicResource PanelStartStopLabelStart}" 
                       HorizontalContentAlignment="Center" 
                       VerticalContentAlignment="Center" 
                       Style="{DynamicResource IvLabel}"
                       Canvas.Top="190" 
                       Canvas.Left="20" 
                       Width="110"/>
                            <Label Content="{DynamicResource PanelStartStopLabelStop}"
                       HorizontalContentAlignment="Center" 
                       VerticalContentAlignment="Center"
                       Style="{DynamicResource IvLabel}"
                       Canvas.Top="190"
                       Canvas.Left="150" 
                       Width="110"/>
                        </Canvas>
                        </Border>
                    </DataTemplate>
                </ItemsControl.ItemTemplate>
            </ItemsControl>
            
        </Border>

    </Grid>
</UserControl>
