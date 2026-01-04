namespace App.Rive.Runtime.Kotlin;

public partial class RiveFileRequest
{
    protected override void DeliverResponse(Java.Lang.Object? p0)
    {
        if (p0 is global::App.Rive.Runtime.Kotlin.Core.File file)
            DeliverResponse(file);
    }
}

public partial class RiveInitializer
{
    public global::Java.Lang.Object Create(global::Android.Content.Context p0)
    {
        CreateWithContext(p0);
        return null;
    }
}