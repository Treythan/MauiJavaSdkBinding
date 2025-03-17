// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_DEVICE_PROPERTY
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
  [Register("com/zebra/rfid/api3/ENUM_DEVICE_PROPERTY", DoNotGenerateAcw = true)]
  public sealed class ENUM_DEVICE_PROPERTY : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_DEVICE_PROPERTY", typeof (ENUM_DEVICE_PROPERTY));

    [Register("IDLE_POWER_OFF_TIMEOUT")]
    public static ENUM_DEVICE_PROPERTY? IdlePowerOffTimeout
    {
      get
      {
        JniObjectReference objectValue = ENUM_DEVICE_PROPERTY._members.StaticFields.GetObjectValue("IDLE_POWER_OFF_TIMEOUT.Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;");
        return Object.GetObject<ENUM_DEVICE_PROPERTY>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_DEVICE_PROPERTY._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_DEVICE_PROPERTY._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_DEVICE_PROPERTY._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_DEVICE_PROPERTY._members.ManagedPeerType;

    internal ENUM_DEVICE_PROPERTY(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;", "")]
    public static unsafe ENUM_DEVICE_PROPERTY? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_DEVICE_PROPERTY._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_DEVICE_PROPERTY>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;", "")]
    public static unsafe ENUM_DEVICE_PROPERTY[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_DEVICE_PROPERTY._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;", (JniArgumentValue*) null);
      return (ENUM_DEVICE_PROPERTY[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_DEVICE_PROPERTY));
    }
  }
}
