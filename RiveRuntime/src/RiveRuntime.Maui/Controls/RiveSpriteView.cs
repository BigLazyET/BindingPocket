using Microsoft.Maui.Controls;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui.Controls;

public partial class RiveSpriteView : View
{
    public string? ArtboardName
    {
        get => (string?)GetValue(ArtboardNameProperty);
        set => SetValue(ArtboardNameProperty, value);
    }

    public string? AnimationName
    {
        get => (string?)GetValue(AnimationNameProperty);
        set => SetValue(AnimationNameProperty, value);
    }

    public string? StateMachineName
    {
        get => (string?)GetValue(StateMachineNameProperty);
        set => SetValue(StateMachineNameProperty, value);
    }

    public string? ResourceName
    {
        get => (string?)GetValue(ResourceNameProperty);
        set => SetValue(ResourceNameProperty, value);
    }

    public bool AutoPlay
    {
        get => (bool)GetValue(AutoPlayProperty);
        set => SetValue(AutoPlayProperty, value);
    }

    public RiveSpriteViewFit Fit
    {
        get => (RiveSpriteViewFit)GetValue(FitProperty);
        set => SetValue(FitProperty, value);
    }

    public RiveSpriteViewAlignment Alignment
    {
        get => (RiveSpriteViewAlignment)GetValue(AlignmentProperty);
        set => SetValue(AlignmentProperty, value);
    }

    public RiveSpriteViewLoop Loop
    {
        get => (RiveSpriteViewLoop)GetValue(LoopProperty);
        set => SetValue(LoopProperty, value);
    }

    public RiveSpriteViewDirection Direction
    {
        get => (RiveSpriteViewDirection)GetValue(DirectionProperty);
        set => SetValue(DirectionProperty, value);
    }
    
    public static readonly BindableProperty ArtboardNameProperty = BindableProperty.Create(
        nameof(ArtboardName),
        typeof(string),
        typeof(RiveSpriteView),
        defaultValue: null
    );

    public static readonly BindableProperty AnimationNameProperty = BindableProperty.Create(
        nameof(AnimationName),
        typeof(string),
        typeof(RiveSpriteView),
        defaultValue: null
    );

    public static readonly BindableProperty StateMachineNameProperty = BindableProperty.Create(
        nameof(StateMachineName),
        typeof(string),
        typeof(RiveSpriteView),
        defaultValue: null
    );
    
    public static readonly BindableProperty ResourceNameProperty = BindableProperty.Create(
        nameof(ResourceName),
        typeof(string),
        typeof(RiveSpriteView),
        defaultValue: null
    );

    public static readonly BindableProperty AutoPlayProperty = BindableProperty.Create(
        nameof(AutoPlay),
        typeof(bool),
        typeof(RiveSpriteView),
        defaultValue: true
    );

    public static readonly BindableProperty FitProperty = BindableProperty.Create(
        nameof(Fit),
        typeof(RiveSpriteViewFit),
        typeof(RiveSpriteView),
        defaultValue: RiveSpriteViewFit.Contain
    );

    public static readonly BindableProperty AlignmentProperty = BindableProperty.Create(
        nameof(Alignment),
        typeof(RiveSpriteViewAlignment),
        typeof(RiveSpriteView),
        defaultValue: RiveSpriteViewAlignment.Center
    );

    public static readonly BindableProperty LoopProperty = BindableProperty.Create(
        nameof(Loop),
        typeof(RiveSpriteViewLoop),
        typeof(RiveSpriteView),
        defaultValue: RiveSpriteViewLoop.AutoLoop
    );

    public static readonly BindableProperty DirectionProperty = BindableProperty.Create(
        nameof(Direction),
        typeof(RiveSpriteViewDirection),
        typeof(RiveSpriteView),
        defaultValue: RiveSpriteViewDirection.AutoDirection
    );
}