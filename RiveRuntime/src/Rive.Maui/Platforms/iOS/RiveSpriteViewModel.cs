using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Rive.Maui.Controls;
using RiveRuntime.iOS;

namespace Rive.Maui;

public class RiveSpriteViewModel : RiveViewModel
{
    private RiveSpriteViewHandler _handler;
    
    protected RiveSpriteViewModel(NSObjectFlag t) : base(t)
    {
    }

    protected internal RiveSpriteViewModel(NativeHandle handle) : base(handle)
    {
    }

    public RiveSpriteViewModel(RiveModel model, string? stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, string? artboardName) : base(model, stateMachineName, fit, alignment, autoPlay, artboardName)
    {
    }

    public RiveSpriteViewModel(RiveModel model, NSString? animationName, RiveFit fit, RiveAlignment alignment, bool autoPlay, string? artboardName) : base(model, animationName, fit, alignment, autoPlay, artboardName)
    {
    }

    public RiveSpriteViewModel(string fileName, string extension, NSBundle bundle, string? stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, string? artboardName, bool loadCdn, LoadAsset? customLoader) : base(fileName, extension, bundle, stateMachineName, fit, alignment, autoPlay, artboardName, loadCdn, customLoader)
    {
    }

    public RiveSpriteViewModel(string webURL, string? stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, bool loadCdn, string? artboardName) : base(webURL, stateMachineName, fit, alignment, autoPlay, loadCdn, artboardName)
    {
    }

    public RiveSpriteViewModel(string webURL, NSString? animationName, RiveFit fit, RiveAlignment alignment, bool autoPlay, bool loadCdn, string? artboardName) : base(webURL, animationName, fit, alignment, autoPlay, loadCdn, artboardName)
    {
    }
    
    public void SetHandler(RiveSpriteViewHandler handler) => _handler = handler;

    public override void RiveFileDidError(NSError error)
    {
        base.RiveFileDidError(error);
        _handler.VirtualView.RiveFileDidErrorManager.HandleEvent(this, error, nameof(RiveSpriteView.RiveFileDidError));
    }

    public override bool RiveFileDidLoad(RiveFile riveFile, out NSError? error)
    {
        var result = base.RiveFileDidLoad(riveFile, out error);
        _handler.VirtualView.RiveFileDidLoadManager.HandleEvent(this, error, nameof(RiveSpriteView.RiveFileDidLoad));
        return result;
    }
    
    public override void TouchBeganOnArtboard(RiveArtboard? artboard, CGPoint location)
    {
        base.TouchBeganOnArtboard(artboard, location);
    }

    public override void TouchMovedOnArtboard(RiveArtboard? artboard, CGPoint location)
    {
        base.TouchMovedOnArtboard(artboard, location);
    }

    public override void TouchEndedOnArtboard(RiveArtboard? artboard, CGPoint location)
    {
        base.TouchEndedOnArtboard(artboard, location);
    }

    public override void TouchCancelledOnArtboard(RiveArtboard? artboard, CGPoint location)
    {
        base.TouchCancelledOnArtboard(artboard, location);
    }

    public override void TouchExitedOnArtboard(RiveArtboard? artboard, CGPoint location)
    {
        base.TouchExitedOnArtboard(artboard, location);
    }
}