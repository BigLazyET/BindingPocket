using RiveRuntime.Maui.Enums;
using RiveRuntime.iOS;

namespace RiveRuntime.Maui.Extensions;

public static class RiveSpriteViewLoopExtension
{
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
}