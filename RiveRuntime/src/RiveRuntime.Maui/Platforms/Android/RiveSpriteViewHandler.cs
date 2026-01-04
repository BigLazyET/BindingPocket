using System;
using Microsoft.Maui.Handlers;
using App.Rive.Runtime.Kotlin;
using Microsoft.Maui;
using RiveRuntime.Maui.Extensions;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

// https://rive.app/docs/runtimes/android/android
public partial class RiveSpriteViewHandler(): ViewHandler<RiveSpriteView, RiveAnimationView>(PropertyMapper, CommandMapper)
{
    internal RiveAnimationView? riveAnimationView;
    private RiveSpriteViewListener? riveSpriteViewListener;
    
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

    protected override RiveAnimationView CreatePlatformView()
    {
        if (string.IsNullOrWhiteSpace(VirtualView.ResourceName))
            throw new Exception("Resource name not specified");
        
        // TODO DO we really need to get resource identifier with android api or just get resource bytes with maui api
        var resourceIdentifier = Context.Resources?.GetIdentifier(VirtualView.ResourceName, "drawable", Context.PackageName) ?? 0;
        if (resourceIdentifier == 0)
            throw new Exception("Resource not found");
        
        riveAnimationView = new RiveAnimationView(Context, null);
        riveAnimationView.SetRiveResource(resourceIdentifier, VirtualView.ArtboardName, VirtualView.AnimationName, VirtualView.StateMachineName,
            VirtualView.AutoPlay, false, VirtualView.Fit.AsRive(), VirtualView.Alignment.AsRive(), VirtualView.Loop.AsRive());
        
        return riveAnimationView;
    }

    protected override void ConnectHandler(RiveAnimationView platformView)
    {
        base.ConnectHandler(platformView);
        
        riveSpriteViewListener = new RiveSpriteViewListener();
        riveSpriteViewListener.VirtualView.SetTarget(VirtualView);
        platformView.RegisterListener(riveSpriteViewListener);
    }

    protected override void DisconnectHandler(RiveAnimationView platformView)
    {
        base.DisconnectHandler(platformView);
        
        riveSpriteViewListener?.Dispose();
        riveSpriteViewListener = null;
        
        riveAnimationView?.Dispose();
        riveAnimationView = null;
    }
}