namespace RiveRuntime.Maui.Controls;

public partial class RiveSpriteView
{
    public void Play()
        => Handler?.Invoke(nameof(Play));

    public void Pause()
        => Handler?.Invoke(nameof(Pause));

    public void Stop()
        => Handler?.Invoke(nameof(Stop));

    public void Reset()
        => Handler?.Invoke(nameof(Reset));
    
    public void SetInput(StateMachineInputArgs args)
        => Handler?.Invoke(nameof(SetInput), args);

    public void TriggerInput(StateMachineTriggerInputArgs args)
        => Handler?.Invoke(nameof(TriggerInput), args);

    public void SetTextRun(TextRunArgs args)
        => Handler?.Invoke(nameof(SetTextRun), args);
}