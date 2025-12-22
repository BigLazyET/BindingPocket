using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using App.Rive;
using App.Rive.Core;
using App.Rive.Runtime.Kotlin;
using App.Rive.Runtime.Kotlin.Controllers;
using App.Rive.Runtime.Kotlin.Core;
using App.Rive.Runtime.Kotlin.Core.Errors;
using App.Rive.Runtime.Kotlin.Fonts;
using App.Rive.Runtime.Kotlin.Renderers;
using Rive.Droid;
using Rive.Maui.Controls;
using Rive.Maui.Enums;
using Rive.Maui.Extensions;
using File = App.Rive.Runtime.Kotlin.Core.File;

namespace Rive.Maui;

// https://rive.app/docs/runtimes/android/android
public partial class RiveSpriteViewHandler: ViewHandler<RiveSpriteView, RiveAnimationView>
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
    
    public RiveSpriteViewHandler(CommandMapper? commandMapper = null) : base(PropertyMapper, commandMapper)
    {
    }

    protected override RiveAnimationView CreatePlatformView()
    {
        var platformView = new RiveAnimationView(Context, null);
        return platformView;
    }

    protected override void ConnectHandler(RiveAnimationView platformView)
    {
        base.ConnectHandler(platformView);
        
        if (string.IsNullOrWhiteSpace(VirtualView.ResourceName))
            throw new Exception("Resource name not specified");
        
        // TODO DO we really need to get resource identifier with android api or just get resource bytes with maui api
        var resourceIdentifier = Context.Resources?.GetIdentifier(VirtualView.ResourceName, "drawable", Context.PackageName) ?? 0;
        if (resourceIdentifier == 0)
            throw new Exception("Resource not found");
        
        platformView.SetRiveResource(0, VirtualView.ArtboardName, VirtualView.AnimationName, VirtualView.StateMachineName,
            VirtualView.AutoPlay, false, VirtualView.Fit.AsRive(), VirtualView.Alignment.AsRive(), VirtualView.Loop.AsRive());
        
        // TODO Use this maybe we can use MAUI api to load 
        // var sm = FileSystem.OpenAppPackageFileAsync("");
        // platformView.SetRiveBytes();
    }
}