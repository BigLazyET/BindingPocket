using Foundation;
using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Enums;
using RiveRuntime.iOS;

namespace RiveRuntime.Maui;

public class AppleRiveStateMachineDelegate : RiveStateMachineDelegate
{
    public WeakReference<RiveSpriteView?> VirtualView { get; set; } = new(null);
    
    public override void StateMachine(RiveStateMachineInstance stateMachine, string stateName)
    {
        if (!VirtualView.TryGetTarget(out var control)) return;

        var inputs = new Dictionary<string, object>();
        for (var i = 0; i < stateMachine.InputCount; i++)
        {
            var input = stateMachine.InputFromIndex(i, out _);
            switch (input)
            {
                case RiveSMINumber smiNumber:
                    inputs.Add(smiNumber.Name, smiNumber.Value);
                    break;
                case RiveSMIBool smiBool:
                    inputs.Add(smiBool.Name, smiBool.Value);
                    break;
            }
        }
        var args = new StateMachineChangeArgs(stateMachine.Name, stateName, inputs);
        control.StateChangedManager.HandleEvent(this, args, nameof(RiveSpriteView.StateChanged));
        control.StateChangedCommand?.Execute(args);
    }

    public override void OnRiveEventReceivedOnRiveEvent(RiveEvent riveEvent)
    {
        if (!VirtualView.TryGetTarget(out var control)) return;

        var properties = riveEvent.Properties
            ?.ToDictionary<KeyValuePair<NSString, NSObject>, string, object>(k => k.Key, k => k.Value);
        var args = new StateMachineEventReceivedArgs(riveEvent.Name, (RiveSpriteViewEvent)riveEvent.Type, properties);
        control.EventReceivedManager.HandleEvent(this, args, nameof(RiveSpriteView.EventReceived));
        control.EventReceivedCommand?.Execute(args);
    }
}