using RiveRuntime.Maui.Extensions;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler
{
    public static void MapArtboardName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (string.IsNullOrWhiteSpace(view.ArtboardName) || handler.riveViewModel?.RiveModel == null) return;
        handler.riveViewModel?.RiveModel.SetArtboard(view.ArtboardName, out _);
        handler.riveViewModel?.Reset();
        handler.riveViewModel?.PlayWithAnimationName(null, view.Loop.AsRive(), view.Direction.AsRive());
    }
    
    public static void MapAnimationName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (string.IsNullOrWhiteSpace(view.AnimationName) || handler.riveViewModel?.RiveModel == null) return;
        handler.riveViewModel?.RiveModel.SetAnimation(view.AnimationName, out _);    // actually we don't need to set animation here
        handler.riveViewModel?.Reset();
        handler.riveViewModel?.PlayWithAnimationName(view.AnimationName, view.Loop.AsRive(), view.Direction.AsRive());
    }
    
    public static void MapStateMachineName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (string.IsNullOrWhiteSpace(view.StateMachineName) || handler.riveViewModel?.RiveModel == null) return;
        handler.riveViewModel?.RiveModel.SetStateMachine(view.StateMachineName, out _);
        handler.riveViewModel?.Reset();
        handler.riveViewModel?.PlayWithAnimationName(null, view.Loop.AsRive(), view.Direction.AsRive());
    }
    
    public static void MapAutoPlay(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.riveViewModel == null || handler.riveViewModel.AutoPlay == view.AutoPlay) return;
        handler.riveViewModel.AutoPlay = view.AutoPlay;
    }
    
    public static void MapFit(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var fit = view.Fit.AsRive();
        if (handler.riveViewModel == null || handler.riveViewModel.Fit == fit) return;
        handler.riveViewModel.Fit = fit;
    }
    
    public static void MapAlignment(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var alignment = view.Alignment.AsRive();
        if (handler.riveViewModel == null || handler.riveViewModel.Alignment == alignment) return;
        handler.riveViewModel.Alignment = alignment;
    }
    
    public static void MapLoop(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var loop = view.Loop.AsRive();
        var direction = view.Direction.AsRive();
        handler.riveViewModel?.PlayWithAnimationName(null, loop, direction);
    }
    
    public static void MapDirection(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var loop = view.Loop.AsRive();
        var direction = view.Direction.AsRive();
        handler.riveViewModel?.PlayWithAnimationName(null, loop, direction);
    }
}