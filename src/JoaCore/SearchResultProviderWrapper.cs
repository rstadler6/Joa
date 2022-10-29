﻿using JoaPluginsPackage;

namespace JoaCore;

public class SearchResultProviderWrapper
{
    public ISearchResultProvider Provider { get; set; } = null!;
    public Delegate? Condition { get; set; }
    public bool IsGlobal { get; set; }
    public List<PluginSearchResult>? LastSearchResults { get; set; }
}