﻿namespace JoaPluginsPackage.Settings.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class SettingPropertyAttribute : Attribute
{
    public string Name { get; set; }
    public string Description { get; set; }

    public SettingPropertyAttribute()
    {
        Name = "";
        Description = "";
    }
}