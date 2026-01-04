using Java.Lang;
using App.Rive.Core;
using Object = Java.Lang.Object;

namespace App.Rive
{
    // 供自动生成的 FontAsset.Companion 显式实现使用的轻量接口
    public interface IAssetOps
    {
        Object Construct(Object? handle, CommandQueue queue);

        void Delete(CommandQueue queue, Object? handle);

        void Register(CommandQueue queue, string key, Object? handle);
    }
    
    // 与生成代码中的 nested type 完全同名、同命名空间
    public partial class FontAsset
    {
        public sealed partial class Companion : IAssetOps
        {
            public unsafe global::App.Rive.FontAsset Construct(App.Rive.Core.FontHandle handle,
                global::App.Rive.Core.CommandQueue queue)
            {
                return Construct(handle.GetHandle(), queue);
            }
            
            public unsafe void Delete (global::App.Rive.Core.CommandQueue queue, App.Rive.Core.FontHandle handle)
            {
                Delete(queue, handle.GetHandle());
            }

            public unsafe void Register(global::App.Rive.Core.CommandQueue queue, string key, FontHandle handle)
            {
                Register(queue, key, handle.GetHandle());
            }
        }
    }
    
    public partial class AudioAsset
    {
        public sealed partial class Companion : IAssetOps
        {
            public unsafe global::App.Rive.AudioAsset Construct(App.Rive.Core.AudioHandle handle,
                global::App.Rive.Core.CommandQueue queue)
            {
                return Construct(handle.GetHandle(), queue);
            }
            
            public unsafe void Delete (global::App.Rive.Core.CommandQueue queue, App.Rive.Core.AudioHandle handle)
            {
                Delete(queue, handle.GetHandle());
            }
            
            public unsafe void Register(global::App.Rive.Core.CommandQueue queue, string key, AudioHandle handle)
            {
                Register(queue, key, handle.GetHandle());
            }
        }
    }
    
    public partial class ImageAsset
    {
        public sealed partial class Companion : IAssetOps
        {
            public unsafe global::App.Rive.ImageAsset Construct(App.Rive.Core.ImageHandle handle,
                global::App.Rive.Core.CommandQueue queue)
            {
                return Construct(handle.GetHandle(), queue);
            }
            
            public unsafe void Delete (global::App.Rive.Core.CommandQueue queue, App.Rive.Core.ImageHandle handle)
            {
                Delete(queue, handle.GetHandle());
            }
            
            public unsafe void Register(global::App.Rive.Core.CommandQueue queue, string key, ImageHandle handle)
            {
                Register(queue, key, handle.GetHandle());
            }
        }
    }
}