﻿using JoaPluginsPackage.Attributes;
using JoaPluginsPackage;
using OperatingSystem = JoaPluginsPackage.Enums.OperatingSystem;

namespace ApplicationSearch;

public class ApplicationSearchSettings : ISetting
{
    [SettingProperty(Name = "Web Search Engines")]
    public List<ApplicationFolder> Folders { get; set; } = new()
    {
        new ApplicationFolder
        {
            Path = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData), 
                @"Microsoft\Windows\Start Menu\Programs"), 
            OperatingSystem = OperatingSystem.Windows
        },
        new ApplicationFolder
        {
            Path = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData), 
                @"Microsoft\Windows\Start Menu"), 
            OperatingSystem = OperatingSystem.Windows
        },
        new ApplicationFolder
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
            OperatingSystem = OperatingSystem.Windows
        },
    };

    [SettingProperty]
    public List<FileExtension> Extensions { get; set; } = new()
    {
        new FileExtension {Extension = ".lnk"},
        new FileExtension {Extension = ".appref-ms"},
        new FileExtension {Extension = ".url"},
        new FileExtension {Extension = ".exe"},
    };

    [SettingProperty] 
    public bool ShowFullFilePath { get; set; } = false;

    [SettingProperty] 
    public bool UseNativeIcons { get; set; } = true;
}