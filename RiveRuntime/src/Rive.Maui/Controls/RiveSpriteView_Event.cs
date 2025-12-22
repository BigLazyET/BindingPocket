using Foundation;

namespace Rive.Maui.Controls;

public partial class RiveSpriteView
{
    internal readonly WeakEventManager RiveFileDidErrorManager = new();
    internal readonly WeakEventManager RiveFileDidLoadManager = new();
    // internal readonly WeakEventManager TouchBeganOnArtboardManager = new();
    // internal readonly WeakEventManager TouchMovedOnArtboardManager = new();
    // internal readonly WeakEventManager TouchEndedOnArtboardManager = new();
    // internal readonly WeakEventManager TouchCancelledOnArtboardManager = new();
    // internal readonly WeakEventManager TouchExitedOnArtboardManager = new();
    
    public event EventHandler RiveFileDidError
    {
        add => RiveFileDidErrorManager.AddEventHandler(value);
        remove => RiveFileDidErrorManager.RemoveEventHandler(value);
    }
    
    public event EventHandler RiveFileDidLoad
    {
        add => RiveFileDidLoadManager.AddEventHandler(value);
        remove => RiveFileDidLoadManager.RemoveEventHandler(value);
    }
}