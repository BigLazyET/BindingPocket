using Foundation;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Rive.Maui.Controls;
using RiveRuntime.iOS;

namespace Rive.Maui;

public partial class RiveSpriteViewHandler : ViewHandler<RiveSpriteView, RiveView>
{
    public RiveSpriteViewHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
    {
    }

    protected override RiveView CreatePlatformView()
    {
        var platformView = new RiveView();
        return platformView;
    }

    protected override void ConnectHandler(RiveView platformView)
    {
        base.ConnectHandler(platformView);
        
        // var riveVm = new RiveViewModel(platformView);
        // riveVm.SetView(platformView);
    }
}