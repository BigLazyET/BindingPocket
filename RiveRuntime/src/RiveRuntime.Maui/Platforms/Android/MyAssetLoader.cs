using Android.Content;
using App.Rive.Runtime.Kotlin.Core;

namespace RiveRuntime.Maui;

public class MyAssetLoader : FileAssetLoader
{
    public override bool LoadContents(FileAsset asset, byte[] inBandBytes)
    {
        // Custom logic to load asset contents
        // For example, you can load from a specific location or modify the bytes
        // Here, we simply use the inBandBytes provided
        return asset.Decode(inBandBytes);
    }
}