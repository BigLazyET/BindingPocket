using System;
using Microsoft.Maui.ApplicationModel;
using RiveRuntime.Maui.Enums;
using App.Rive.Runtime.Kotlin.Core;

namespace RiveRuntime.Maui;

public static class RendererInitializer
{
    public static void Init(RenderOptions renderOptions)
    {
        var renderer = renderOptions.AndroidRendererType switch
        {
            RiveAndroidRendererType.Rive => RendererType.Rive!,
            RiveAndroidRendererType.Canvas => RendererType.Canvas!,
            _ => throw new ArgumentOutOfRangeException(nameof(renderOptions), renderOptions, null)
        };
        App.Rive.Runtime.Kotlin.Core.Rive.Instance.Init(Platform.AppContext, renderer);
    }
}
