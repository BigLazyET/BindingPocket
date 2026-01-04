using System;
using System.Windows.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace RiveRuntime.Maui.Controls;

public partial class RiveSpriteView
{
    internal readonly WeakEventManager StateChangedManager = new();

    internal readonly WeakEventManager EventReceivedManager = new();

    public event EventHandler<string> StateChanged
    {
        add => StateChangedManager.AddEventHandler(value);
        remove => StateChangedManager.RemoveEventHandler(value);
    }

    public event EventHandler<string> EventReceived
    {
        add => EventReceivedManager.AddEventHandler(value);
        remove => EventReceivedManager.RemoveEventHandler(value);
    }
    
    public ICommand? StateChangedCommand
    {
        get => (ICommand?)GetValue(StateChangedCommandProperty);
        set => SetValue(StateChangedCommandProperty, value);
    }

    public ICommand? EventReceivedCommand
    {
        get => (ICommand?)GetValue(EventReceivedCommandProperty);
        set => SetValue(EventReceivedCommandProperty, value);
    }
    
    public static readonly BindableProperty StateChangedCommandProperty = BindableProperty.Create(
        nameof(StateChangedCommand),
        typeof(ICommand),
        typeof(RiveSpriteView)
    );

    public static readonly BindableProperty EventReceivedCommandProperty = BindableProperty.Create(
        nameof(EventReceivedCommand),
        typeof(ICommand),
        typeof(RiveSpriteView)
    );
}