using RiveRuntime.Maui.Extensions;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler
{
    public static void MapPlay(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        var loop = view.Loop.AsRive();
        var direction = view.Direction.AsRive();

        if (!string.IsNullOrWhiteSpace(view.AnimationName))
        {
            handler.PlatformView.Play(loop, direction, true);
            return;
        }
        
        var stateMachineName = string.IsNullOrWhiteSpace(view.StateMachineName) ? handler.PlatformView.Controller.ActiveArtboard?.FirstStateMachine.Name
            : view.StateMachineName;
        if (!string.IsNullOrWhiteSpace(stateMachineName))
        {
            handler.PlatformView.Play(stateMachineName, loop, direction, true, true);
            return;
        }

        var animationName = handler.PlatformView.Controller.ActiveArtboard?.FirstAnimation.Name;
        if (!string.IsNullOrWhiteSpace(animationName))
        {
            handler.PlatformView.Play(animationName, loop, direction, false, true);
        }
    }

    public static void MapPause(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView?.Pause();

    public static void MapStop(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView?.Stop();

    public static void MapReset(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView?.Reset();

    public static void MapSetInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
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
                    handler.PlatformView?.SetNumberState(inputArgs.StateMachineName, inputArgs.InputName, (float)doubleValue);
                    break;
                case float floatValue:
                    handler.PlatformView?.SetNumberState(inputArgs.StateMachineName, inputArgs.InputName, floatValue);
                    break;
                case bool boolValue:
                    handler.PlatformView?.SetBooleanState(inputArgs.StateMachineName, inputArgs.InputName, boolValue);
                    break;
            }
        }
        else
        {
            switch (inputArgs.Value)
            {
                case double doubleValue:
                    handler.PlatformView?.SetNumberStateAtPath(inputArgs.InputName, (float)doubleValue, inputArgs.Path);
                    break;
                case float floatValue:
                    handler.PlatformView?.SetNumberStateAtPath(inputArgs.InputName, floatValue, inputArgs.Path);
                    break;
                case bool boolValue:
                    handler.PlatformView?.SetBooleanStateAtPath(inputArgs.InputName, boolValue, inputArgs.Path);
                    break;
            }
        }
    }
    
    public static void MapTriggerInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (args is not StateMachineTriggerInputArgs triggerInputArgs)
            return;

        if (string.IsNullOrWhiteSpace(triggerInputArgs.Path))
        {
            if (string.IsNullOrWhiteSpace(triggerInputArgs.StateMachineName))
                return;

            handler.PlatformView?.FireState(triggerInputArgs.StateMachineName, triggerInputArgs.InputName);
        }
        else
        {
            handler.PlatformView?.FireStateAtPath(triggerInputArgs.InputName, triggerInputArgs.Path);
        }
    }
    
    public static void MapSetTextRun(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (args is not TextRunArgs setTextRun)
            return;

        if (string.IsNullOrWhiteSpace(setTextRun.Path))
        {
            handler.PlatformView?.SetTextRunValue(setTextRun.TextRunName, setTextRun.Value);
        }
        else
        {
            handler.PlatformView?.SetTextRunValue(setTextRun.TextRunName, setTextRun.Value, setTextRun.Path);
        }
    }
}