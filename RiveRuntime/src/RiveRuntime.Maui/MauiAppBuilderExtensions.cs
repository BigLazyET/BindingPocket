using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui;

/// <summary>
/// https://rive.app/docs/runtimes/choose-a-renderer/overview
/// </summary>
public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseRiveRuntime(
        this MauiAppBuilder builder, Action<RenderOptions>? configure = null)
    {
        var renderOptions = new RenderOptions();
        configure?.Invoke(renderOptions);
        
        RendererInitializer.Init(renderOptions);

        builder.ConfigureMauiHandlers(handlers => handlers.AddHandler<RiveSpriteView, RiveSpriteViewHandler>());

        return builder;
    }
}

public class RenderOptions
{
    public RiveAndroidRendererType AndroidRendererType { get; set; } = RiveAndroidRendererType.Rive;
    public RiveAppleRendererType AppleRendererType { get; set; } = RiveAppleRendererType.Rive;
}

