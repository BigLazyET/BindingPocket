using Android.Content;
using Android.Views;
using Android.Widget;
using App.Rive.Runtime.Kotlin;
using RiveRuntime.Maui.Controls;
using RiveRuntime.Maui.Extensions;

namespace RiveRuntime.Maui;

/// <summary>
/// Thanks to matmork
/// https://github.com/matmork/rive-maui
/// </summary>
public sealed class CustomRiveView : LinearLayout
{
    internal RiveAnimationView? AnimationView;
    internal WeakReference<RiveSpriteView?> VirtualView = new(null);
    
    private RiveSpriteViewListener? _riveSpriteViewListener;
    private readonly Context _context;

    public CustomRiveView(Context context) : base(context)
    {
        _context = context;
        LayoutParameters = new LayoutParams(
            ViewGroup.LayoutParams.MatchParent,
            ViewGroup.LayoutParams.MatchParent
        );
    }

    public void CreateAnimationView()
    {
        if (!VirtualView.TryGetTarget(out var virtualView) || string.IsNullOrWhiteSpace(virtualView.ResourceName))
            throw new Exception("Invalid ResourceName");

        var resourceIdentifier = _context.Resources?.GetIdentifier(virtualView.ResourceName, "drawable", _context.PackageName) ?? 0;
        if (resourceIdentifier == 0)
            throw new Exception("Resource not found");

        var animationView = new RiveAnimationView(_context, null);

        // if (virtualView.DynamicAssets?.Count > 0)
        // {
        //     animationView.SetAssetLoader(new AssetLoader(_context, virtualView.DynamicAssets));
        // }
        
        animationView.SetRiveResource(resourceIdentifier, virtualView.ArtboardName, virtualView.AnimationName, virtualView.StateMachineName,
            virtualView.AutoPlay, false, virtualView.Fit.AsRive(), virtualView.Alignment.AsRive(), virtualView.Loop.AsRive());

        _riveSpriteViewListener = new RiveSpriteViewListener();
        _riveSpriteViewListener.RiveViewReference.SetTarget(this);
        animationView.RegisterListener(_riveSpriteViewListener);

        // if (virtualView.TextRuns != null)
        // {
        //     foreach (var textRun in virtualView.TextRuns)
        //     {
        //         animationView.SetTextRunValue(textRun.TextRunName, textRun.Value);
        //     }
        // }

        AnimationView = animationView;
    }

    public void RemoveAnimationView()
    {
        if (AnimationView == null)
            return;

        RemoveView(AnimationView);
        
        if (_riveSpriteViewListener != null)
        {
            AnimationView.RemoveEventListener(_riveSpriteViewListener);
        }

        AnimationView.Dispose();
        AnimationView = null;
    }

    protected override void OnLayout(bool changed, int l, int t, int r, int b)
    {
        AnimationView?.Layout(0, 0, r - l, b - t);
    }

    protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
    {
        if (AnimationView != null)
        {
            AnimationView.Measure(widthMeasureSpec, heightMeasureSpec);
            SetMeasuredDimension(AnimationView.MeasuredWidth, AnimationView.MeasuredHeight);
            return;
        }

        SetMeasuredDimension(0, 0);
    }

    protected override void OnAttachedToWindow()
    {
        if (AnimationView == null)
            CreateAnimationView();

        AddView(AnimationView, ViewGroup.LayoutParams.MatchParent);

        base.OnAttachedToWindow();
    }

    protected override void OnDetachedFromWindow()
    {
        RemoveAnimationView();

        base.OnDetachedFromWindow();
    }

    public new void Dispose()
    {
        RemoveAnimationView();
        
        if (_riveSpriteViewListener != null)
        {
            _riveSpriteViewListener.RiveViewReference.SetTarget(null);
            _riveSpriteViewListener.Dispose();
            _riveSpriteViewListener = null;
        }

        // if (VirtualView.TryGetTarget(out var control))
        //     control.StateMachineInputs.Dispose();

        VirtualView.SetTarget(null);

        base.Dispose();
    }
}