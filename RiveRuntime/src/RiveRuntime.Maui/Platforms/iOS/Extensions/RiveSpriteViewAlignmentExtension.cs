using RiveRuntime.Maui.Enums;
using RiveRuntime.iOS;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewAlignmentExtension
{
    public static RiveAlignment AsRive(this RiveSpriteViewAlignment alignment)
    {
        return alignment switch
        {
            RiveSpriteViewAlignment.TopLeft => RiveAlignment.topLeft!,
            RiveSpriteViewAlignment.TopCenter => RiveAlignment.topCenter!,
            RiveSpriteViewAlignment.TopRight => RiveAlignment.topRight!,
            RiveSpriteViewAlignment.CenterLeft => RiveAlignment.centerLeft!,
            RiveSpriteViewAlignment.Center => RiveAlignment.center!,
            RiveSpriteViewAlignment.CenterRight => RiveAlignment.centerRight!,
            RiveSpriteViewAlignment.BottomLeft => RiveAlignment.bottomLeft!,
            RiveSpriteViewAlignment.BottomCenter => RiveAlignment.bottomCenter!,
            RiveSpriteViewAlignment.BottomRight => RiveAlignment.bottomRight!,
            _ => RiveAlignment.center!,
        };
    }
}