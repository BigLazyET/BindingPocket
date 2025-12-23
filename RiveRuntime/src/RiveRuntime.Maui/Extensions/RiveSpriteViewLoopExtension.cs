using RiveRuntime.Maui.Enums;
#if ANDROID
using App.Rive.Runtime.Kotlin.Core;
#elif IOS || MACCATALYST
using RiveRuntime.iOS;
#endif

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewLoopExtension
{
#if ANDROID
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
#elif IOS || MACCATALYST
    public static RiveLoop AsRive(this RiveSpriteViewLoop loop)
    {
        return loop switch
        {
            RiveSpriteViewLoop.OneShot => RiveLoop.oneShot!,
            RiveSpriteViewLoop.Loop => RiveLoop.loop!,
            RiveSpriteViewLoop.PingPong => RiveLoop.pingPong!,
            RiveSpriteViewLoop.AutoLoop => RiveLoop.autoLoop!,
            _ => RiveLoop.autoLoop!,
        };
    }
    #endif
}