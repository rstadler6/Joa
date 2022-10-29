﻿using Github.Providers;
using JoaPluginsPackage;

namespace Github.SearchResults;

public class RepositoriesSearchResult : ISearchResult
{
    public string Caption { get; init; }
    public string Description { get; init; }
    public string Icon { get; init; }
    public List<ContextAction>? Actions { get; init; }
    public void Execute(IExecutionContext executionContext)
    {
        executionContext.AddStepBuilder().AddProvider<RepositoriesProvider>();
    }
}