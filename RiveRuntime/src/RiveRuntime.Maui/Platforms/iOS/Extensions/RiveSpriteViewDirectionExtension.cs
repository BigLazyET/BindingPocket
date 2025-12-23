using RiveRuntime.iOS;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewDirectionExtension
{
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
}