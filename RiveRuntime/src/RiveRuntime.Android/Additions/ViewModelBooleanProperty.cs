using System;
using Android.Runtime;
using Java.Lang;
using App.Rive.Runtime.Kotlin.Core;
using Kotlin;
using Object = Java.Lang.Object;

namespace App.Rive.Runtime.Kotlin.Core
{
    public sealed partial class ViewModelBooleanProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            bool boolValue = value is Java.Lang.Boolean b && b.BooleanValue();
            NativeSetValue(boolValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetBooleanValue();
        }
    }
    
    public sealed partial class ViewModelArtboardProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var unitValue = value as Unit;
            NativeSetValue(unitValue);
        }
        
        protected override Object? NativeGetValue()
        {
            NativeGetArtboardValue();
            return null;
        }
    }
    
    public sealed partial class ViewModelColorProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var intValue = value is Java.Lang.Integer i ? i.IntValue() : 0;
            NativeSetValue(intValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetColorValue();
        }
    }
    
    public sealed partial class ViewModelNumberProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var intValue = value is Java.Lang.Float i ? i.FloatValue() : 0;
            NativeSetValue(intValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetNumberValue();
        }
    }
    
    public sealed partial class ViewModelListProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var unitValue = value as Unit;
            NativeSetValue(unitValue);
        }
        
        protected override Object? NativeGetValue()
        {
            NativeGetListValue();
            return null;
        }
    }
    
    public sealed partial class ViewModelStringProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var stringValue = value is Java.Lang.String i ? i.ToString() : string.Empty;
            NativeSetValue(stringValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetStringValue();
        }
    }
    
    public sealed partial class ViewModelTriggerProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var unitValue = value as global::App.Rive.Runtime.Kotlin.Core.ViewModelTriggerProperty.TriggerUnit;
            NativeSetValue(unitValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetTriggerValue();
        }
    }
    
    public sealed partial class ViewModelEnumProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var stringValue = value is Java.Lang.String i ? i.ToString() : string.Empty;
            NativeSetValue(stringValue);
        }
        
        protected override Object? NativeGetValue()
        {
            return NativeGetEnumValue();
        }
    }
    
    public sealed partial class ViewModelImageProperty
    {
        protected override void NativeSetValue(Object? value)
        {
            var unitValue = value as Unit;
            NativeSetValue(unitValue);
        }
        
        protected override Object? NativeGetValue()
        {
            NativeGetImageValue();
            return null;
        }
    }

    public sealed partial class BytesRequest
    {
        protected override void DeliverResponse(global::Java.Lang.Object? p0)
        {
            DeliverResponse(p0);
        }
    }
}