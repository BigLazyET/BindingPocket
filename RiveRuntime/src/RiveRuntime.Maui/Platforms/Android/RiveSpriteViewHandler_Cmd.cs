using RiveRuntime.Maui.Extensions;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler
{
    private static void MapPlay(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (handler.PlatformView.AnimationView == null)
            return;

        var riveLoop = view.Loop.AsRive();
        var riveDirection = view.Direction.AsRive();

        if (!string.IsNullOrWhiteSpace(view.AnimationName))
        {
            handler.PlatformView.AnimationView.Play(riveLoop, riveDirection, true);
            return;
        }

        var stateMachineName = !string.IsNullOrWhiteSpace(view.StateMachineName)
            ? view.StateMachineName
            : handler.PlatformView.AnimationView.Controller.ActiveArtboard?.StateMachineNames.FirstOrDefault();

        if (!string.IsNullOrWhiteSpace(stateMachineName))
        {
            handler.PlatformView.AnimationView.Play(stateMachineName, riveLoop, riveDirection, true, true);
            return;
        }

        var firstAnimationName = handler.PlatformView.AnimationView.Controller.ActiveArtboard?.AnimationNames.FirstOrDefault();
        if (!string.IsNullOrWhiteSpace(firstAnimationName))
        {
            handler.PlatformView.AnimationView.Play(firstAnimationName, riveLoop, riveDirection, false, true);
        }
    }

    private static void MapPause(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Pause();

    private static void MapStop(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Stop();

    private static void MapReset(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Reset();

    private static void MapSetInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (args is not StateMachineInputArgs inputArgs)
            return;

        if (string.IsNullOrWhiteSpace(inputArgs.Path))
        {
            if (string.IsNullOrWhiteSpace(inputArgs.StateMachineName))
                return;

            switch (inputArgs.Value)
            {
                case double doubleValue:
                    handler.PlatformView.AnimationView?.SetNumberState(inputArgs.StateMachineName, inputArgs.InputName, (float)doubleValue);
                    break;
                case float floatValue:
                    handler.PlatformView.AnimationView?.SetNumberState(inputArgs.StateMachineName, inputArgs.InputName, floatValue);
                    break;
                case bool boolValue:
                    handler.PlatformView.AnimationView?.SetBooleanState(inputArgs.StateMachineName, inputArgs.InputName, boolValue);
                    break;
            }
        }
        else
        {
            switch (inputArgs.Value)
            {
                case double doubleValue:
                    handler.PlatformView.AnimationView?.SetNumberStateAtPath(inputArgs.InputName, (float)doubleValue, inputArgs.Path);
                    break;
                case float floatValue:
                    handler.PlatformView.AnimationView?.SetNumberStateAtPath(inputArgs.InputName, floatValue, inputArgs.Path);
                    break;
                case bool boolValue:
                    handler.PlatformView.AnimationView?.SetBooleanStateAtPath(inputArgs.InputName, boolValue, inputArgs.Path);
                    break;
            }
        }
    }

    private static void MapTriggerInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (args is not StateMachineTriggerInputArgs triggerInputArgs)
            return;

        if (string.IsNullOrWhiteSpace(triggerInputArgs.Path))
        {
            if (string.IsNullOrWhiteSpace(triggerInputArgs.StateMachineName))
                return;

            handler.PlatformView.AnimationView?.FireState(triggerInputArgs.StateMachineName, triggerInputArgs.InputName);
        }
        else
        {
            handler.PlatformView.AnimationView?.FireStateAtPath(triggerInputArgs.InputName, triggerInputArgs.Path);
        }
    }

    private static void MapSetTextRun(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (args is not TextRunArgs setTextRun)
            return;

        if (string.IsNullOrWhiteSpace(setTextRun.Path))
        {
            handler.PlatformView.AnimationView?.SetTextRunValue(setTextRun.TextRunName, setTextRun.Value);
        }
        else
        {
            handler.PlatformView.AnimationView?.SetTextRunValue(setTextRun.TextRunName, setTextRun.Value, setTextRun.Path);
        }
    }
}