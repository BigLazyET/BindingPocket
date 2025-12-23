using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui;

/// <summary>
/// https://rive.app/docs/runtimes/choose-a-renderer/overview
/// </summary>
public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseRiveRuntime(
        this MauiAppBuilder builder,
        RiveAndroidRendererType riveAndroidRendererType = RiveAndroidRendererType.Rive,
        RiveAppleRendererType riveIosRendererType = RiveAppleRendererType.Rive)
    {
#if ANDROID
        var renderer = riveAndroidRendererType switch
        {
            RiveAndroidRendererType.Rive => App.Rive.Runtime.Kotlin.Core.RendererType.Rive!,
            RiveAndroidRendererType.Canvas => App.Rive.Runtime.Kotlin.Core.RendererType.Canvas!,
            _ => throw new ArgumentOutOfRangeException(nameof(riveAndroidRendererType), riveAndroidRendererType, null)
        };

        App.Rive.Runtime.Kotlin.Core.Rive.Instance.Init(Platform.AppContext, renderer);
#elif IOS || MACCATALYST
        var renderer = riveIosRendererType switch
        {
            RiveAppleRendererType.Rive => RiveRuntime.iOS.RendererType.riveRenderer,
            RiveAppleRendererType.CoreGraphics => RiveRuntime.iOS.RendererType.cgRenderer,
            _ => throw new ArgumentOutOfRangeException(nameof(riveIosRendererType), riveIosRendererType, null)
        };

        RiveRuntime.iOS.RenderContextManager.Shared.DefaultRenderer = renderer;
#endif

        builder.ConfigureMauiHandlers(handlers => handlers.AddHandler<RiveSpriteView, RiveSpriteViewHandler>());

        return builder;
    }
}