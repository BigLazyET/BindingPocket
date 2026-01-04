using RiveRuntime.Maui.Enums;
using App.Rive.Runtime.Kotlin.Core;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewAlignmentExtension
{

    public static Alignment AsRive(this RiveSpriteViewAlignment alignment)
    {
        return alignment switch
        {
            RiveSpriteViewAlignment.TopLeft => Alignment.TopLeft!,
            RiveSpriteViewAlignment.TopCenter => Alignment.TopCenter!,
            RiveSpriteViewAlignment.TopRight => Alignment.TopRight!,
            RiveSpriteViewAlignment.CenterLeft => Alignment.CenterLeft!,
            RiveSpriteViewAlignment.Center => Alignment.Center!,
            RiveSpriteViewAlignment.CenterRight => Alignment.CenterRight!,
            RiveSpriteViewAlignment.BottomLeft => Alignment.BottomLeft!,
            RiveSpriteViewAlignment.BottomCenter => Alignment.BottomCenter!,
            RiveSpriteViewAlignment.BottomRight => Alignment.BottomRight!,
            _ => Alignment.Center!,
        };
    }
}