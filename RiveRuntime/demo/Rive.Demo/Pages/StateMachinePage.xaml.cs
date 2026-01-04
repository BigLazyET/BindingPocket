using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiveRuntime.Maui;

namespace Rive.Demo.Pages;

public partial class StateMachinePage : ContentPage
{
    public StateMachinePage()
    {
        InitializeComponent();
    }

    private void LookSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        RsView.SetInput(new StateMachineInputArgs("Login Machine", "numLook", e.NewValue, null));
    }

    private void OnFailureClicked(object? sender, EventArgs e)
    {
        RsView.TriggerInput(new StateMachineTriggerInputArgs("Login Machine", "trigFail", null));
    }

    private void OnSuccessClicked(object? sender, EventArgs e)
    {
        RsView.TriggerInput(new StateMachineTriggerInputArgs("Login Machine", "trigSuccess", null));
    }

    private void IsHandsUpSwitch_OnToggled(object? sender, ToggledEventArgs e)
    {
        RsView.SetInput(new StateMachineInputArgs("Login Machine", "isHandsUp", e.Value, null));
    }

    private void IsCheckingSwitch_OnToggled(object? sender, ToggledEventArgs e)
    {
        RsView.SetInput(new StateMachineInputArgs("Login Machine", "isChecking", e.Value, null));
    }
}