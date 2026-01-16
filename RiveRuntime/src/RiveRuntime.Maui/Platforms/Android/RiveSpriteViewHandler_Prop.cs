using System;
using RiveRuntime.Maui.Extensions;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler
{
    private static void MapArtboardName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null &&
            !string.Equals(handler.PlatformView.AnimationView.ArtboardName, view.ArtboardName, StringComparison.OrdinalIgnoreCase))
            handler.PlatformView.AnimationView.ArtboardName = view.ArtboardName;
    }

    private static void MapAnimationName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView == null || string.IsNullOrWhiteSpace(view.AnimationName))
            return;

        var riveLoop = view.Loop.AsRive();
        var riveDirection = view.Direction.AsRive();

        if (view.AutoPlay)
        {
            handler.PlatformView.AnimationView.Stop();
            handler.PlatformView.AnimationView.Play(view.AnimationName, riveLoop, riveDirection, false, true);
        }
    }

    private static void MapStateMachineName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView == null)
            return;

        var rendererAttributes = handler.PlatformView.AnimationView.GetRendererAttributes();

        if (!string.Equals(rendererAttributes.StateMachineName, view.StateMachineName, StringComparison.OrdinalIgnoreCase))
            rendererAttributes.StateMachineName = view.StateMachineName;
    }

    private static void MapAutoPlay(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Autoplay != view.AutoPlay)
            handler.PlatformView.AnimationView.Autoplay = view.AutoPlay;
    }

    private static void MapFit(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var riveFit = view.Fit.AsRive();
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Fit != riveFit)
            handler.PlatformView.AnimationView.Fit = riveFit;
    }

    private static void MapAlignment(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var riveAlignment = view.Alignment.AsRive();
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Alignment != riveAlignment)
            handler.PlatformView.AnimationView.Alignment = riveAlignment;
    }

    private static void MapLoop(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null)
        {
            var rendererAttributes = handler.PlatformView.AnimationView.GetRendererAttributes();
            rendererAttributes.Loop = view.Loop.AsRive();
        }
    }

    private static void MapDirection(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        //
    }
}