using Foundation;
using Microsoft.Maui.Handlers;
using Rive.DemoUp.Controls;
using RiveRuntime.iOS;

namespace Rive.DemoUp.Handlers;

public class CustomRIveViewHanlder : ViewHandler<CustomRiveView, RiveView>
{
    private static readonly IPropertyMapper<CustomRiveView, CustomRIveViewHanlder> PropertyMapper =
        new PropertyMapper<CustomRiveView, CustomRIveViewHanlder>(ViewMapper) { };
    
    public CustomRIveViewHanlder() : base(PropertyMapper)
    {
    }

    protected override RiveView CreatePlatformView()
    {
        var riveModel = new RiveModel("animatedloginscreen", ".riv", Foundation.NSBundle.MainBundle, true, out _, null);
        var riveViewModel = new RiveViewModel(riveModel, "Login Machine", RiveFit.contain, RiveAlignment.center, true, null);
        var riveView = riveViewModel.CreateRiveView;
        riveView.stateMachineDelegate = new CustomStateMachineDelegate();
        
        return riveView;
    }
}