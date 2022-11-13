﻿using JoaPluginsPackage;
using JoaPluginsPackage.Injectables;

namespace BookmarksSearch;

public class SerachResult : ISearchResult
{
    public string Caption { get; init; }
    public string Description { get; init; }
    public string Icon { get; init; }
    public List<ContextAction>? Actions { get; init; }
    public void Execute(IExecutionContext executionContext)
    {
        var browserHelper = executionContext.ServiceProvider.GetService(typeof(IBrowserHelper)) as IBrowserHelper;

        browserHelper?.OpenWebsite(Description);
    }
}