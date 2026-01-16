using Microsoft.Maui.Handlers;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler() : ViewHandler<RiveSpriteView, CustomRiveView>(PropertyMapper, CommandMapper)
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

    private static readonly CommandMapper<RiveSpriteView, RiveSpriteViewHandler> CommandMapper = new(ViewCommandMapper)
    {
        [nameof(RiveSpriteView.Play)] = MapPlay,
        [nameof(RiveSpriteView.Pause)] = MapPause,
        [nameof(RiveSpriteView.Stop)] = MapStop,
        [nameof(RiveSpriteView.Reset)] = MapReset,
        [nameof(RiveSpriteView.SetInput)] = MapSetInput,
        [nameof(RiveSpriteView.TriggerInput)] = MapTriggerInput,
        [nameof(RiveSpriteView.SetTextRun)] = MapSetTextRun,
    };
    
    protected override CustomRiveView CreatePlatformView()
    {
        var platformView = new CustomRiveView(Context);
        platformView.VirtualView.SetTarget(VirtualView);

        return platformView;
    }

    protected override void ConnectHandler(CustomRiveView platformView)
    {
        platformView.CreateAnimationView();
    }

    protected override void DisconnectHandler(CustomRiveView platformView)
    {
        platformView.Dispose();
    }
}