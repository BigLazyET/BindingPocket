using App.Rive.Runtime.Kotlin.Core;
using Rive.Maui.Enums;

namespace Rive.Maui.Extensions;

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