// using System;
// using System.Collections.Generic;
// using CoreGraphics;
// using Foundation;
// using ObjCRuntime;
// using RiveRuntime.iOS;
// using RiveRuntime.Maui.Controls;
// using RiveRuntime.Maui.Enums;
//
// namespace RiveRuntime.Maui;
//
// public class AppleRiveViewModel : RiveViewModel
// {
//     public WeakReference<RiveSpriteView?> VirtualView { get; set; } = new(null);
//
//     protected AppleRiveViewModel(NSObjectFlag t) : base(t)
//     {
//     }
//
//     protected internal AppleRiveViewModel(NativeHandle handle) : base(handle)
//     {
//     }
//     
//     // NativeHandle Constructor (string fileName, string extension, NSBundle bundle, [NullAllowed] string stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, [NullAllowed] string artboardName, bool loadCdn, [NullAllowed] LoadAsset customLoader);
//     public AppleRiveViewModel(string fileName, string extension, NSBundle bundle, string? stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, string? artboardName, bool loadCdn, LoadAsset? customLoader) : base(fileName, extension, bundle, stateMachineName, fit, alignment, autoPlay, artboardName, loadCdn, customLoader)
//      {
//      }
//
//     public override void OnRiveEventReceivedOnRiveEvent(RiveEvent riveEvent)
//      {
//          if (!VirtualView.TryGetTarget(out var control)) return;
//
//          var properties = riveEvent.Properties
//              ?.ToDictionary<KeyValuePair<NSString, NSObject>, string, object>(k => k.Key, k => k.Value);
//          var args = new StateMachineEventReceivedArgs(riveEvent.Name, (RiveSpriteViewEvent)riveEvent.Type, properties);
//          control.EventReceivedManager.HandleEvent(this, args, nameof(RiveSpriteView.EventReceived));
//          control.EventReceivedCommand?.Execute(args);
//      }
//
//      public override void StateMachine(RiveStateMachineInstance stateMachine, string stateName)
//      {
//          if (!VirtualView.TryGetTarget(out var control)) return;
//
//          var inputs = new Dictionary<string, object>();
//          for (var i = 0; i < stateMachine.InputCount; i++)
//          {
//              var input = stateMachine.InputFromIndex(i, out _);
//              switch (input)
//              {
//                  case RiveSMINumber smiNumber:
//                      inputs.Add(smiNumber.Name, smiNumber.Value);
//                      break;
//                  case RiveSMIBool smiBool:
//                      inputs.Add(smiBool.Name, smiBool.Value);
//                      break;
//              }
//          }
//          var args = new StateMachineChangeArgs(stateMachine.Name, stateName, inputs);
//          control.StateChangedManager.HandleEvent(this, args, nameof(RiveSpriteView.StateChanged));
//          control.StateChangedCommand?.Execute(args);
//      }
// }