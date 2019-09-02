<Window x:Class="$rootnamespace$.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ui="clr-namespace:Ternium.Ivision.UI.Library.ControlsUI.UIControls;assembly=Ternium.Ivision.UI.Library.ControlsUI"
        xmlns:panel="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Panels;assembly=Ternium.Ivision.UI.Library.Widgets"
        xmlns:widgets="clr-namespace:Ternium.Ivision.UI.Library.Widgets.Widgets.Controls;assembly=Ternium.Ivision.UI.Library.Widgets"
        xmlns:viewModel="clr-namespace:$rootnamespace$.ViewModel"
        xmlns:IvCustomControl="clr-namespace:$rootnamespace$.IvCustomControl"
        Title="MainWindow"  Style="{DynamicResource IvMainWindow}"  Height="961" Width="1920"
        x:Name="MainWidow">

    <Border Style="{DynamicResource BorderApp}">

        <DockPanel LastChildFill="True">
            <ui:BarClose  TitleBar="{DynamicResource AppTitle}" DockPanel.Dock="Top" Style="{DynamicResource IvBarCloseStyle}" />
            <Viewbox Stretch="Fill">
                <Canvas  Height="921" Width="1920">
                    <TextBox  Width="200" Height="30" Margin="400,160"
                          Text="{Binding ElementName=MainWidow, Path=DataContext.IvMeterValue, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"></TextBox>
                    <Label Width="200" Height="30" Content="{Binding Title}" Canvas.Left="634" Canvas.Top="160"/>
                    <widgets:IvMeter  ReadExpression="{Binding ElementName=MainWidow, Path=DataContext.IvMeterValue}" Width="200" Height="30" Margin="400,200"></widgets:IvMeter>
                    <Button Command="{Binding ChangeIsland}" Content="Salir" Width="200" Height="30" Margin="400,260"></Button>

                    <IvCustomControl:IvCustomPanelStartStop Canvas.Top="50" Canvas.Left="50" Height="710"  >
                        <IvCustomControl:IvCustomPanelStartStop.IvPanelStartStopViewModel>
                            <viewModel:IvCustomPanelStartStopViewModel   IvTitle="Prueba 0" IvTagStatus="=0" IvRow="0" IvColumn="0"/>
                            <viewModel:IvCustomPanelStartStopViewModel   IvTitle="Prueba 1" IvTagStatus="=1" IvRow="1" IvColumn="0"/>
                            <viewModel:IvCustomPanelStartStopViewModel   IvTitle="Prueba 2" IvTagStatus="=2" IvRow="2" IvColumn="0"/>

                            <viewModel:IvCustomPanelStartStopViewModel   IvTitle="Prueba 2" IvTagStatus="=3" IvRow="2" IvColumn="1"/>
                        </IvCustomControl:IvCustomPanelStartStop.IvPanelStartStopViewModel>
                    </IvCustomControl:IvCustomPanelStartStop>

                    <IvCustomControl:IvCustomPanelAutoManual Canvas.Top="50" Canvas.Left="1603" DataContext="{Binding Demo,Mode=TwoWay}">
                        <IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                            <viewModel:IvCustomPanelAutoManualViewModel IvTitle="Prueba 4" IvTagStatus="=1"/>
                        </IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                    </IvCustomControl:IvCustomPanelAutoManual>
                    <IvCustomControl:IvCustomPanelAutoManual Canvas.Top="288" Canvas.Left="1603">
                        <IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                            <viewModel:IvCustomPanelAutoManualViewModel IvTitle="Prueba 5" IvTagStatus="=1"/>
                        </IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                    </IvCustomControl:IvCustomPanelAutoManual>
                    <IvCustomControl:IvCustomPanelAutoManual Canvas.Top="546" Canvas.Left="1603">
                        <IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                            <viewModel:IvCustomPanelAutoManualViewModel IvTitle="Prueba 6" IvTagStatus="=2"/>
                        </IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                    </IvCustomControl:IvCustomPanelAutoManual>
                    <IvCustomControl:IvCustomPanelAutoManual Canvas.Top="546" Canvas.Left="1271">
                        <IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                            <viewModel:IvCustomPanelAutoManualViewModel IvTitle="Prueba 7" IvTagStatus="=3"/>
                        </IvCustomControl:IvCustomPanelAutoManual.IvPanelAutoManualViewModel>
                    </IvCustomControl:IvCustomPanelAutoManual>


                    <Grid  
                	Canvas.Left="888" 
                	Canvas.Top="60" Height="209" Width="520">

                        <Grid.RowDefinitions>
                            <RowDefinition Height="35"/>
                            <RowDefinition Height="35"/>
                            <RowDefinition Height="35"/>
                            <RowDefinition Height="35"/>
                            <RowDefinition Height="35"/>
                            <RowDefinition Height="35"/>
                        </Grid.RowDefinitions>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="130"/>
                            <ColumnDefinition Width="130"/>
                            <ColumnDefinition Width="130"/>
                            <ColumnDefinition Width="130"/>

                        </Grid.ColumnDefinitions>
                        <IvCustomControl:IvCustomTitle IvTitle="Corriente" Grid.Row="0" Grid.Column="1"/>
                        <IvCustomControl:IvCustomTitle IvTitle="Tension" Grid.Row="0" Grid.Column="2"/>
                        <IvCustomControl:IvCustomSubTitle IvSubTitle="Motor 1" Grid.Row="1" Grid.Column="0"/>
                        <IvCustomControl:IvCustomSubTitle IvSubTitle="Motor 2"  Grid.Row="2" Grid.Column="0"/>
                        <IvCustomControl:IvCustomSubTitle IvSubTitle="Motor 3" Grid.Row="3" Grid.Column="0"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="=110" Grid.Row="1" Grid.Column="1"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="=100" Grid.Row="1" Grid.Column="2"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="=115" Grid.Row="2" Grid.Column="1"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="=1.2" Grid.Row="2" Grid.Column="2"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="=1.3" Grid.Row="3" Grid.Column="1"/>
                        <IvCustomControl:IvCustomMeter IvTagMeter="{Binding ElementName=MainWidow, Path=DataContext.IvMeterValue}" Grid.Row="3" Grid.Column="2"/>
                    </Grid>




                </Canvas>
            </Viewbox>
        </DockPanel>

    </Border>
</Window>
