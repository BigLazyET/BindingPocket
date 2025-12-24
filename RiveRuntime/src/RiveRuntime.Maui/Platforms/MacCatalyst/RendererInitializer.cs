using System;
using RiveRuntime.iOS;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui;

public static class RendererInitializer
{
    public static void Init(RenderOptions renderOptions)
    {
        var renderer = renderOptions.AppleRendererType switch
        {
            RiveAppleRendererType.Rive => RendererType.riveRenderer,
            RiveAppleRendererType.CoreGraphics => RendererType.cgRenderer,
            _ => throw new ArgumentOutOfRangeException(nameof(renderOptions), renderOptions, null)
        };

        RenderContextManager.Shared.DefaultRenderer = renderer;
    }
}