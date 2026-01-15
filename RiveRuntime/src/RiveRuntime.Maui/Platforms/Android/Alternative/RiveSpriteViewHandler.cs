using Microsoft.Maui.Handlers;
using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Extensions;

namespace RiveRuntime.Maui;

public partial class RiveSpriteViewHandler() : ViewHandler<RiveSpriteView, CustomRiveView>(PropertyMapper, CommandMapper)
{
    private static readonly IPropertyMapper<RiveSpriteView, RiveSpriteViewHandler> PropertyMapper =
        new PropertyMapper<RiveSpriteView, RiveSpriteViewHandler>(ViewMapper)
        {
            [nameof(RiveSpriteView.ArtboardName)] = MapArtboardName,
            [nameof(RiveSpriteView.AnimationName)] = MapAnimationName,
            [nameof(RiveSpriteView.StateMachineName)] = MapStateMachineName,
            [nameof(RiveSpriteView.AutoPlay)] = MapAutoPlay,
            [nameof(RiveSpriteView.Fit)] = MapFit,
            [nameof(RiveSpriteView.Alignment)] = MapAlignment,
            [nameof(RiveSpriteView.Loop)] = MapLoop,
            [nameof(RiveSpriteView.Direction)] = MapDirection
        };

    private static readonly CommandMapper<RiveSpriteView, RiveSpriteViewHandler> CommandMapper = new(ViewCommandMapper)
    {
        [nameof(RiveSpriteView.Play)] = MapPlay,
        [nameof(RiveSpriteView.Pause)] = MapPause,
        [nameof(RiveSpriteView.Stop)] = MapStop,
        [nameof(RiveSpriteView.Reset)] = MapReset,
        [nameof(RiveSpriteView.SetInput)] = MapSetInput,
        [nameof(RiveSpriteView.TriggerInput)] = MapTriggerInput,
        [nameof(RiveSpriteView.SetTextRun)] = MapSetTextRun,
    };
    
    protected override CustomRiveView CreatePlatformView()
    {
        var platformView = new CustomRiveView(Context);
        platformView.VirtualView.SetTarget(VirtualView);

        return platformView;
    }

    protected override void ConnectHandler(CustomRiveView platformView)
    {
        platformView.CreateAnimationView();
    }

    protected override void DisconnectHandler(CustomRiveView platformView)
    {
        platformView.Dispose();
    }

    public static void MapArtboardName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null &&
            !string.Equals(handler.PlatformView.AnimationView.ArtboardName, view.ArtboardName, StringComparison.OrdinalIgnoreCase))
            handler.PlatformView.AnimationView.ArtboardName = view.ArtboardName;
    }

    public static void MapAnimationName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView == null || string.IsNullOrWhiteSpace(view.AnimationName))
            return;

        var riveLoop = view.Loop.AsRive();
        var riveDirection = view.Direction.AsRive();

        if (view.AutoPlay)
        {
            handler.PlatformView.AnimationView.Stop();
            handler.PlatformView.AnimationView.Play(view.AnimationName, riveLoop, riveDirection, false, true);
        }
    }

    public static void MapStateMachineName(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView == null)
            return;

        var rendererAttributes = handler.PlatformView.AnimationView.GetRendererAttributes();

        if (!string.Equals(rendererAttributes.StateMachineName, view.StateMachineName, StringComparison.OrdinalIgnoreCase))
            rendererAttributes.StateMachineName = view.StateMachineName;
    }

    public static void MapAutoPlay(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Autoplay != view.AutoPlay)
            handler.PlatformView.AnimationView.Autoplay = view.AutoPlay;
    }

    public static void MapFit(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var riveFit = view.Fit.AsRive();
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Fit != riveFit)
            handler.PlatformView.AnimationView.Fit = riveFit;
    }

    public static void MapAlignment(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        var riveAlignment = view.Alignment.AsRive();
        if (handler.PlatformView.AnimationView != null && handler.PlatformView.AnimationView.Alignment != riveAlignment)
            handler.PlatformView.AnimationView.Alignment = riveAlignment;
    }

    public static void MapLoop(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        if (handler.PlatformView.AnimationView != null)
        {
            var rendererAttributes = handler.PlatformView.AnimationView.GetRendererAttributes();
            rendererAttributes.Loop = view.Loop.AsRive();
        }
    }

    public static void MapDirection(RiveSpriteViewHandler handler, RiveSpriteView view)
    {
        //
    }

    public static void MapPlay(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
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

    public static void MapPause(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Pause();

    public static void MapStop(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Stop();

    public static void MapReset(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
        => handler.PlatformView.AnimationView?.Reset();

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

    public static void MapTriggerInput(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
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

    public static void MapSetTextRun(RiveSpriteViewHandler handler, RiveSpriteView view, object? args)
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