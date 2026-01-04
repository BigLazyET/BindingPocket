using Microsoft.Extensions.Logging;
using RiveRuntime.Maui;
using RiveRuntime.Maui.Enums;

namespace Rive.Demo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseRiveRuntime(options =>
            {
                options.AndroidRendererType = RiveAndroidRendererType.Canvas;
                options.AppleRendererType = RiveAppleRendererType.CoreGraphics;
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}