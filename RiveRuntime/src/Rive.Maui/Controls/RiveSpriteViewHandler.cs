using Rive.Maui.Controls;

namespace Rive.Maui;

public partial class RiveSpriteViewHandler
{
    private static readonly IPropertyMapper<RiveSpriteView, RiveSpriteViewHandler> PropertyMapper =
        new PropertyMapper<RiveSpriteView, RiveSpriteViewHandler>(ViewMapper)
        {
            [nameof(RiveSpriteView.ArtboardName)] = MapArtboardName,
            [nameof(RiveSpriteView.AnimationName)] = MapAnimationName,
            [nameof(RiveSpriteView.StateMachineName)] = MapStateMachineName,
            [nameof(RiveSpriteView.AutoPlay)] = MapAutoPlay,
            [nameof(RiveSpriteView.Fit)] = MapFit,
            [nameof(RiveSpriteView.Alignment)] = MapAlignment,
            [nameof(RiveSpriteView.Loop)] = MapLoop,
            [nameof(RiveSpriteView.Direction)] = MapDirection
        };
}