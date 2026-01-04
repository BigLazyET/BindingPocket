using System;
using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using RiveRuntime.iOS;
using RiveRuntime.Maui.Controls;


namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler() : ViewHandler<RiveSpriteView, RiveView>(PropertyMapper, CommandMapper)
{
    private RiveView? riveView;
    private RiveViewModel? riveViewModel;
    
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

    protected override RiveView CreatePlatformView()
    {
        if (string.IsNullOrWhiteSpace(VirtualView.ResourceName))
            throw new Exception("Resource name not specified");
        
        // DEPRECATED: animation playback: https://rive.app/docs/runtimes/animation-playback#apple
        // Priority: machine playback: https://rive.app/docs/runtimes/state-machines
        
        riveViewModel = new RiveViewModel(fileName: VirtualView.ResourceName, extension: ".riv", bundle: NSBundle.MainBundle,
            stateMachineName: VirtualView.StateMachineName, fit: RiveFit.contain, alignment: RiveAlignment.center, autoPlay: true,
            artboardName: null, loadCdn: true, customLoader: null);
        if (!string.IsNullOrWhiteSpace(VirtualView.AnimationName))
            riveViewModel.RiveModel?.SetAnimation(VirtualView.AnimationName, out _);
        
        // riveViewModel.VirtualView.SetTarget(VirtualView);
        riveView = riveViewModel.CreateRiveView;
        return  riveView;
    }
    
    protected override void DisconnectHandler(RiveView platformView)
    {
        base.DisconnectHandler(platformView);
        
        riveView?.Dispose();
        riveViewModel?.Dispose();
    }
}