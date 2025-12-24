using RiveRuntime.Maui.Enums;
using App.Rive.Runtime.Kotlin.Core;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewFitExtension
{
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
}