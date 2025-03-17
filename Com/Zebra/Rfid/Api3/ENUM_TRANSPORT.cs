// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_TRANSPORT
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
  [Register("com/zebra/rfid/api3/ENUM_TRANSPORT", DoNotGenerateAcw = true)]
  public sealed class ENUM_TRANSPORT : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_TRANSPORT", typeof (ENUM_TRANSPORT));

    [Register("ALL")]
    public static ENUM_TRANSPORT? All
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("ALL.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BLUETOOTH")]
    public static ENUM_TRANSPORT? Bluetooth
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("BLUETOOTH.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RE_SERIAL")]
    public static ENUM_TRANSPORT? ReSerial
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("RE_SERIAL.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RE_USB")]
    public static ENUM_TRANSPORT? ReUsb
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("RE_USB.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SERVICE_SERIAL")]
    public static ENUM_TRANSPORT? ServiceSerial
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("SERVICE_SERIAL.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SERVICE_USB")]
    public static ENUM_TRANSPORT? ServiceUsb
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("SERVICE_USB.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ZIOTC")]
    public static ENUM_TRANSPORT? Ziotc
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRANSPORT._members.StaticFields.GetObjectValue("ZIOTC.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRANSPORT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_TRANSPORT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRANSPORT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_TRANSPORT._members.ManagedPeerType;

    internal ENUM_TRANSPORT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_TRANSPORT;", "")]
    public static unsafe ENUM_TRANSPORT? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRANSPORT._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_TRANSPORT;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_TRANSPORT;", "")]
    public static unsafe ENUM_TRANSPORT[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_TRANSPORT._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_TRANSPORT;", (JniArgumentValue*) null);
      return (ENUM_TRANSPORT[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_TRANSPORT));
    }
  }
}
