<Application x:Class="$rootnamespace$.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:d ="http://schemas.microsoft.com/expression/blend/2008"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" mc:Ignorable="d"
             Startup="Application_Startup" 
             >
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>

                <!-- Diccionario de recursos local , esta linea debe comentarse cuando la aplicacion sea pasada a
                produccion-->
                <ResourceDictionary Source="/Resources\Styles\GlobalDictionary.xaml" />

                <!-- Diccionario de idiomas
                     * se debe de cambiar por el nombre final del proyecto -->
                <ResourceDictionary Source="/Resources\Languages\$assemblyname$.ES-MX.xaml" />               
                
                
                <!-- Estilos Generales -->              
                <ResourceDictionary Source="C:\Program Files\TerniumAuto\Ivision\Cfg\General\Styles/GlobalDictionary.xaml" />
                
                
                
                
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
