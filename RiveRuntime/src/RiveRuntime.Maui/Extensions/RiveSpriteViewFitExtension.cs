using RiveRuntime.Maui.Enums;
#if ANDROID
using App.Rive.Runtime.Kotlin.Core;
#elif IOS || MACCATALYST
using RiveRuntime.iOS;
#endif

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewFitExtension
{
#if ANDROID
public static Fit AsRive(this RiveSpriteViewFit fit)
    {
        return fit switch
        {
            RiveSpriteViewFit.Fill => Fit.Fill!,
            RiveSpriteViewFit.Contain => Fit.Contain!,
            RiveSpriteViewFit.Cover => Fit.Cover!,
            RiveSpriteViewFit.FitWidth => Fit.FitWidth!,
            RiveSpriteViewFit.FitHeight => Fit.FitHeight!,
            RiveSpriteViewFit.ScaleDown => Fit.ScaleDown!,
            RiveSpriteViewFit.NoFit => Fit.None!,
            _ => Fit.Contain!,
        };
    }
#elif IOS || MACCATALYST
    public static RiveFit AsRive(this RiveSpriteViewFit fit)
    {
        return fit switch
        {
            RiveSpriteViewFit.Fill => RiveFit.fill!,
            RiveSpriteViewFit.Contain => RiveFit.contain!,
            RiveSpriteViewFit.Cover => RiveFit.cover!,
            RiveSpriteViewFit.FitWidth => RiveFit.fitWidth!,
            RiveSpriteViewFit.FitHeight => RiveFit.fitHeight!,
            RiveSpriteViewFit.ScaleDown => RiveFit.scaleDown!,
            RiveSpriteViewFit.NoFit => RiveFit.noFit!,
            _ => RiveFit.contain!,
        };
    }
    #endif
}