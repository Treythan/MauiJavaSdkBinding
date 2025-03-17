// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.NETWORK_CONFIG
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
  [Register("com/zebra/rfid/api3/NETWORK_CONFIG", DoNotGenerateAcw = true)]
  public sealed class NETWORK_CONFIG : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/NETWORK_CONFIG", typeof (NETWORK_CONFIG));

    [Register("ENET")]
    public static NETWORK_CONFIG? Enet
    {
      get
      {
        JniObjectReference objectValue = NETWORK_CONFIG._members.StaticFields.GetObjectValue("ENET.Lcom/zebra/rfid/api3/NETWORK_CONFIG;");
        return Object.GetObject<NETWORK_CONFIG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI")]
    public static NETWORK_CONFIG? Wifi
    {
      get
      {
        JniObjectReference objectValue = NETWORK_CONFIG._members.StaticFields.GetObjectValue("WIFI.Lcom/zebra/rfid/api3/NETWORK_CONFIG;");
        return Object.GetObject<NETWORK_CONFIG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = NETWORK_CONFIG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => NETWORK_CONFIG._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = NETWORK_CONFIG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => NETWORK_CONFIG._members.ManagedPeerType;

    internal NETWORK_CONFIG(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/NETWORK_CONFIG;", "")]
    public static unsafe NETWORK_CONFIG? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = NETWORK_CONFIG._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/NETWORK_CONFIG;", jniArgumentValuePtr);
        return Object.GetObject<NETWORK_CONFIG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/NETWORK_CONFIG;", "")]
    public static unsafe NETWORK_CONFIG[]? Values()
    {
      JniObjectReference jniObjectReference = NETWORK_CONFIG._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/NETWORK_CONFIG;", (JniArgumentValue*) null);
      return (NETWORK_CONFIG[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (NETWORK_CONFIG));
    }
  }
}
