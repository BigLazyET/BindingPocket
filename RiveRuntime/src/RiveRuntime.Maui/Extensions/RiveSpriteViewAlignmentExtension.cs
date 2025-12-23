using RiveRuntime.Maui.Enums;
#if ANDROID
using App.Rive.Runtime.Kotlin.Core;
#elif IOS || MACCATALYST
using RiveRuntime.iOS;
#endif

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewAlignmentExtension
{
#if ANDROID
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
#elif IOS || MACCATALYST
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
#endif
}