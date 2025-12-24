using RiveRuntime.Maui.Enums;
using RiveRuntime.iOS;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewFitExtension
{
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
}