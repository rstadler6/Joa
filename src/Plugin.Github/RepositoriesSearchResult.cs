﻿using JoaPluginsPackage;

namespace Github;

public class RepositoriesSearchResult : ISearchResult
{
    public string Caption { get; init; }
    public string Description { get; init; }
    public string Icon { get; init; }
    public List<ContextAction>? Actions { get; init; }
    public List<ISearchResult> Execute(IExecutionContext executionContext)
    {
        return new List<ISearchResult>
        {
            new RepositorySearchResult
            {
                Caption = "Joa",
                Description = "Joa the best",
                Icon = ""
            }
        };
    }
}