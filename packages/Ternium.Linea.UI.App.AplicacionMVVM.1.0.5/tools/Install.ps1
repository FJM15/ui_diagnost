param($installPath, $toolsPath, $package, $project)

[System.Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms")
$currentAssemblyName = $project.Properties.Item("AssemblyName").Value
$rootnamespace = $project.Properties.Item("RootNamespace").Value


$path = [System.IO.Path]
$oldFileName = $path::Combine($path::GetDirectoryName($project.FileName), "Resources\Languages\Ternium.Proyecto.ES-MX.xaml")
$newFileName = $path::GetDirectoryName($project.FileName) + "\Resources\Languages\" + $currentAssemblyName.ToString() +".ES-MX.xaml"


$tempDirectoryProjectItem = $project.ProjectItems.Item("Resources").ProjectItems.Item("Languages").ProjectItems.Item("Ternium.Proyecto.ES-MX.xaml")
$newName=$currentAssemblyName.ToString() + ".ES-MX.xaml"
$tempDirectoryProjectItem.Name=$newName


$tempDirectoryProjectItem = $project.ProjectItems.Item("Resources").ProjectItems.Item("Languages").ProjectItems.Item("Ternium.Proyecto.ES-AR.xaml")
$newName=$currentAssemblyName.ToString() + ".ES-AR.xaml"
$tempDirectoryProjectItem.Name=$newName

$tempDirectoryProjectItem = $project.ProjectItems.Item("Resources").ProjectItems.Item("Languages").ProjectItems.Item("Ternium.Proyecto.EN-US.xaml")
$newName=$currentAssemblyName.ToString() + ".EN-US.xaml"
$tempDirectoryProjectItem.Name=$newName
