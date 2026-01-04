using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RiveRuntime.Maui;

namespace Rive.Demo.ViewModels;

public partial class TouchInputViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _currentStateName;

    [ObservableProperty]
    private double _numberInputValue;

    [RelayCommand]
    private Task StateChanged(StateMachineChangeArgs state)
    {
        CurrentStateName = state.StateName;
        if (state.Inputs.TryGetValue("Number 1", out var value)
            && value is float floatValue)
        {
            NumberInputValue = floatValue;
        }

        return Task.CompletedTask;
    }
}