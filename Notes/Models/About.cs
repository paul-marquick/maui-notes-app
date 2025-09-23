﻿namespace Notes.Models;

internal record About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://dawlish.com";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
}
