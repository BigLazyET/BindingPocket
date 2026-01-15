using Foundation;

namespace Rive.DemoUp.Handlers;
using RiveRuntime.iOS;

public class CustomStateMachineDelegate : RiveStateMachineDelegate
{
    public override void StateMachine(RiveStateMachineInstance stateMachine, string stateName)
    {
        // var inputs = new Dictionary<string, object>();
        // for (var i = 0; i < stateMachine.InputCount; i++)
        // {
        //     var input = stateMachine.InputFromIndex(i, out _);
        //     switch (input)
        //     {
        //         case RiveSMINumber smiNumber:
        //             inputs.Add(smiNumber.Name, smiNumber.Value);
        //             break;
        //         case RiveSMIBool smiBool:
        //             inputs.Add(smiBool.Name, smiBool.Value);
        //             break;
        //     }
        // }
    }

    public override void OnRiveEventReceivedOnRiveEvent(RiveEvent riveEvent)
    {
        // var properties = riveEvent.Properties
        //     ?.ToDictionary<KeyValuePair<NSString, NSObject>, string, object>(k => k.Key, k => k.Value);
    }
}