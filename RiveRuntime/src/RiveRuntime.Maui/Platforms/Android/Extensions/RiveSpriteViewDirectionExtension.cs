using RiveRuntime.Maui.Enums;
using App.Rive.Runtime.Kotlin.Core;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewDirectionExtension
{
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
}