using App.Rive.Runtime.Kotlin.Controllers;
using App.Rive.Runtime.Kotlin.Core;
using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Enums;
using Object = Java.Lang.Object;

namespace RiveRuntime.Maui;

public class EventListener : Object, RiveFileController.IRiveEventListener
{
    public WeakReference<CustomRiveView?> RiveViewReference { get; set; } = new(null);

    public void NotifyEvent(RiveEvent evt)
    {
        if (!RiveViewReference.TryGetTarget(out var handler) || !handler.VirtualView.TryGetTarget(out var virtualView))
            return;

        var type = RiveSpriteViewEvent.GeneralEvent;
        if (evt.Type == EventType.OpenURLEvent)
        {
            type = RiveSpriteViewEvent.OpenURLEvent;
        }

        var properties = evt.Properties
            .ToDictionary<KeyValuePair<string, Object>, string, object>(k => k.Key, k => k.Value);
        var args = new StateMachineEventReceivedArgs(evt.Name, type, properties);

        virtualView.EventReceivedManager.HandleEvent(this, args, nameof(RiveSpriteView.EventReceived));
        virtualView.EventReceivedCommand?.Execute(args);
    }
}