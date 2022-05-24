﻿namespace Interfaces.Plugin;

public interface IPlugin
{
    /// <summary>
    /// true : The Searchstring will be passed to the Plugin as long as no Validator from any other plugin matches
    /// false : default behaviour
    /// </summary>
    public bool AcceptNonMatchingSearchString { get; }

    /// <summary>
    ///     <value>A list of Validators</value>
    ///     <remarks>
    ///             The Search string will be passed to the Plugin if at least one of the Validators returns true with the Searchstring as Input
    ///             If empty: The Searchstring will allways be passed to the Plugin
    ///             Can be overriden by <see cref="AcceptNonMatchingSearchString">AcceptNonMatchingSearchString</see>
    ///     </remarks>
    /// </summary>
    public bool Validator(string seachString);
    
    public List<ISearchResult> GetResults(string searchString);
    public void Execute(ISearchResult searchResult);
}