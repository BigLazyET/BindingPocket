using RiveRuntime.iOS;
using RiveRuntime.Maui.Controls;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler
{
    public static void MapPlay(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.riveViewModel?.PlayWithAnimationName(null, RiveLoop.autoLoop, RiveDirection.autoDirection);

    public static void MapPause(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.riveViewModel?.Pause();

    public static void MapStop(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.riveViewModel?.Stop();

    public static void MapReset(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.riveViewModel?.Reset();

    public static void MapSetInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (handler.riveViewModel == null) return;
        
        if (args is not StateMachineInputArgs inputArgs)
            return;

        switch (inputArgs.Value)
        {
            case double doubleValue:
                if (string.IsNullOrEmpty(inputArgs.Path))
                    handler.riveViewModel.SetDoubleInput(inputArgs.InputName, (float)doubleValue);
                else
                    handler.riveViewModel.SetDoubleInput(inputArgs.InputName, doubleValue, inputArgs.Path);
                break;
            case float floatValue:
                if (string.IsNullOrEmpty(inputArgs.Path))
                    handler.riveViewModel.SetDoubleInput(inputArgs.InputName, floatValue);
                else
                    handler.riveViewModel.SetDoubleInput(inputArgs.InputName, floatValue, inputArgs.Path);
                break;
            case bool boolValue:
                if (string.IsNullOrEmpty(inputArgs.Path))
                    handler.riveViewModel.SetBooleanInput(inputArgs.InputName, boolValue);
                else
                    handler.riveViewModel.SetBooleanInput(inputArgs.InputName, boolValue, inputArgs.Path);
                break;
        }
    }
    
    public static void MapTriggerInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (handler.riveViewModel == null) return;
        if (args is not StateMachineTriggerInputArgs triggerInputArgs) return;
        
        if (string.IsNullOrEmpty(triggerInputArgs.Path))
            handler.riveViewModel.TriggerInput(triggerInputArgs.InputName);
        else
            handler.riveViewModel.TriggerInput(triggerInputArgs.InputName, triggerInputArgs.Path);
    }
    
    public static void MapSetTextRun(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
    {
        if (handler.riveViewModel == null) return;
        if (args is not TextRunArgs textRunArgs) return;
        
        if (string.IsNullOrEmpty(textRunArgs.Path))
            handler.riveViewModel.SetTextRunValue(textRunArgs.TextRunName, textRunArgs.Value, out _);
        else
            handler.riveViewModel.SetTextRunValue(textRunArgs.TextRunName, textRunArgs.Path, textRunArgs.Value, out _);
    }
}