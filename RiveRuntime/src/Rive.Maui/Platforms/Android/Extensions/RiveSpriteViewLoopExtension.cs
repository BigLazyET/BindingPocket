using App.Rive.Runtime.Kotlin.Core;
using Rive.Maui.Enums;

namespace Rive.Maui.Extensions;

public static class RiveSpriteViewLoopExtension
{
    public static Loop AsRive(this RiveSpriteViewLoop loop)
    {
        return loop switch
        {
            RiveSpriteViewLoop.OneShot => Loop.Oneshot!,
            RiveSpriteViewLoop.Loop => Loop.Loop2!,
            RiveSpriteViewLoop.PingPong => Loop.Pingpong!,
            RiveSpriteViewLoop.AutoLoop => Loop.Auto!,
            _ => Loop.Auto!,
        };
    }
}