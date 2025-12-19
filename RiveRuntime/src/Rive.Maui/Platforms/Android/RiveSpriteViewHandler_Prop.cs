using Rive.Maui.Controls;
using Rive.Maui.Extensions;

namespace Rive.Maui;

public partial class RiveSpriteViewHandler
{
    public static void MapArtboardName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView == null || string.IsNullOrWhiteSpace(view.ArtboardName)) return;
        handler.PlatformView.ArtboardName = view.ArtboardName;
    }
    
    public static void MapAnimationName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView == null || string.IsNullOrWhiteSpace(view.AnimationName)) return;
        
        // Different AnimationName requires to stop current and play the new one
        if (!view.AutoPlay) return;
        handler.PlatformView.Stop();
        handler.PlatformView.Play(view.AnimationName, view.Loop.AsRive(), view.Direction.AsRive(), false, true);
    }
    
    public static void MapStateMachineName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView == null || string.IsNullOrWhiteSpace(view.StateMachineName)) return;
        var attributes = handler.PlatformView.GetRendererAttributes();
        if (!string.Equals(attributes.StateMachineName, view.StateMachineName, StringComparison.OrdinalIgnoreCase))
            attributes.StateMachineName = view.StateMachineName;
    }
    
    public static void MapAutoPlay(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView == null || handler.PlatformView.Autoplay == view.AutoPlay) return;
        handler.PlatformView.Autoplay = view.AutoPlay;
    }
    
    public static void MapFit(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var fit = view.Fit.AsRive();
        if (handler.PlatformView == null || handler.PlatformView.Fit == fit) return;
        handler.PlatformView.Fit = fit;
    }
    
    public static void MapAlignment(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var alignment = view.Alignment.AsRive();
        if (handler.PlatformView == null || handler.PlatformView.Alignment == alignment) return;
        handler.PlatformView.Alignment = alignment;
    }
    
    public static void MapLoop(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView == null) return;
        var attributes = handler.PlatformView.GetRendererAttributes();
        attributes.Loop = view.Loop.AsRive();
    }
    
    public static void MapDirection(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        
    }
}