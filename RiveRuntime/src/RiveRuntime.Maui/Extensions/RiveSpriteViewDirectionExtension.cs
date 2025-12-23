using RiveRuntime.Maui.Enums;
#if ANDROID
using App.Rive.Runtime.Kotlin.Core;
#elif IOS || MACCATALYST
using RiveRuntime.iOS;
#endif

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewDirectionExtension
{
#if ANDROID
public static Direction AsRive(this RiveSpriteViewDirection direction)
    {
        return direction switch
        {
            RiveSpriteViewDirection.Forwards => Direction.Forwards!,
            RiveSpriteViewDirection.Backwards => Direction.Backwards!,
            RiveSpriteViewDirection.AutoDirection => Direction.Auto!,
            _ => Direction.Auto!,
        };
    }
#elif IOS || MACCATALYST
    public static RiveDirection AsRive(this RiveSpriteViewDirection direction)
    {
        return direction switch
        {
            RiveSpriteViewDirection.Forwards => RiveDirection.forwards!,
            RiveSpriteViewDirection.Backwards => RiveDirection.backwards!,
            RiveSpriteViewDirection.AutoDirection => RiveDirection.autoDirection!,
            _ => RiveDirection.autoDirection!,
        };
    }
#endif
}