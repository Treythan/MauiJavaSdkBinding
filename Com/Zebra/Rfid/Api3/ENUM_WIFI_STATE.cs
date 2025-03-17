// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_WIFI_STATE
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
  [Register("com/zebra/rfid/api3/ENUM_WIFI_STATE", DoNotGenerateAcw = true)]
  public sealed class ENUM_WIFI_STATE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_WIFI_STATE", typeof (ENUM_WIFI_STATE));

    [Register("STATE_CONNECTED")]
    public static ENUM_WIFI_STATE? StateConnected
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_STATE._members.StaticFields.GetObjectValue("STATE_CONNECTED.Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;");
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_DISCONNECTED")]
    public static ENUM_WIFI_STATE? StateDisconnected
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_STATE._members.StaticFields.GetObjectValue("STATE_DISCONNECTED.Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;");
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_OFF")]
    public static ENUM_WIFI_STATE? StateOff
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_STATE._members.StaticFields.GetObjectValue("STATE_OFF.Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;");
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_ON")]
    public static ENUM_WIFI_STATE? StateOn
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_STATE._members.StaticFields.GetObjectValue("STATE_ON.Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;");
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_WIFI_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_WIFI_STATE._members.ManagedPeerType;

    internal ENUM_WIFI_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_WIFI_STATE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "")]
    public static unsafe ENUM_WIFI_STATE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_STATE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "")]
    public static unsafe ENUM_WIFI_STATE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_STATE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "")]
    public static unsafe ENUM_WIFI_STATE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_WIFI_STATE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", (JniArgumentValue*) null);
      return (ENUM_WIFI_STATE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_WIFI_STATE));
    }
  }
}
