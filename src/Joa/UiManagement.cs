﻿using Joa.PluginCore;
using JoaLauncher.Api.Injectables;
using JoaLauncher.Api.Plugin;
using Microsoft.Extensions.Hosting;

namespace Joa;

public class UiManagement : IHostedService
{
    private readonly PluginManager _pluginManager;
    private readonly IJoaLogger _logger;

    public UiManagement(PluginManager pluginManager, IJoaLogger logger)
    {
        _pluginManager = pluginManager;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {

        _pluginManager.GetPluginsOfType<IUiPlugin>().ForEach(x =>
        {
            try
            {
                x.Start("");
            }
            catch (Exception)
            {
                _logger.Error($"Error while trying to start the following UI Plugin {x.GetType().Assembly.Location}");
            }
        });

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _pluginManager.GetPluginsOfType<IUiPlugin>().ForEach(x =>
        {
            try
            {
                x.Stop();
            }
            catch (Exception)
            {
                _logger.Error($"Error while trying to start the following UI Plugin {x.GetType().Assembly.Location}");
            }
        });

        return Task.CompletedTask;
    }
}