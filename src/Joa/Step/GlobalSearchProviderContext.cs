﻿using JoaLauncher.Api;

namespace JoaInterface.Step;

public class GlobalSearchProviderContext : ISearchProviderContext
{
    public string? SearchString { get; set; }
}