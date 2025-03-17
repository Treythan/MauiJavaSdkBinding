// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UNTRACEABLE_RANGE
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/UNTRACEABLE_RANGE", DoNotGenerateAcw = true)]
  public class UNTRACEABLE_RANGE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UNTRACEABLE_RANGE", typeof (UNTRACEABLE_RANGE));

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return UNTRACEABLE_RANGE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        UNTRACEABLE_RANGE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("REDUCE_RANGE")]
    public static UNTRACEABLE_RANGE? ReduceRange
    {
      get
      {
        JniObjectReference objectValue = UNTRACEABLE_RANGE._members.StaticFields.GetObjectValue("REDUCE_RANGE.Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;");
        return Object.GetObject<UNTRACEABLE_RANGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TOGGLE_RANGE")]
    public static UNTRACEABLE_RANGE? ToggleRange
    {
      get
      {
        JniObjectReference objectValue = UNTRACEABLE_RANGE._members.StaticFields.GetObjectValue("TOGGLE_RANGE.Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;");
        return Object.GetObject<UNTRACEABLE_RANGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UNTRACEABLE_RANGE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UNTRACEABLE_RANGE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UNTRACEABLE_RANGE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UNTRACEABLE_RANGE._members.ManagedPeerType;

    protected UNTRACEABLE_RANGE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("GetUntraceableRangeValue", "(I)Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", "")]
    public static unsafe UNTRACEABLE_RANGE? GetUntraceableRangeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = UNTRACEABLE_RANGE._members.StaticMethods.InvokeObjectMethod("GetUntraceableRangeValue.(I)Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", jniArgumentValuePtr);
      return Object.GetObject<UNTRACEABLE_RANGE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetUntraceableRangeValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", "")]
    public static unsafe UNTRACEABLE_RANGE? GetUntraceableRangeValue(string? untraceableRange)
    {
      IntPtr num = JNIEnv.NewString(untraceableRange);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = UNTRACEABLE_RANGE._members.StaticMethods.InvokeObjectMethod("GetUntraceableRangeValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", jniArgumentValuePtr);
        return Object.GetObject<UNTRACEABLE_RANGE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
