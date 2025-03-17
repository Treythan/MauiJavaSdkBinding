// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_WIFI_COMMAND_TYPE
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
  [Register("com/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE", DoNotGenerateAcw = true)]
  public sealed class ENUM_WIFI_COMMAND_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE", typeof (ENUM_WIFI_COMMAND_TYPE));

    [Register("WIFI_ADDBSS")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiAddbss
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_ADDBSS.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_CONNECT")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiConnect
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_CONNECT.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_DELETEBSS")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiDeletebss
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_DELETEBSS.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_DISABLE")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiDisable
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_DISABLE.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_DISCONNECT")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiDisconnect
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_DISCONNECT.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_ENABLE")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiEnable
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_ENABLE.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_GETSTATUS")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiGetstatus
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_GETSTATUS.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_GET_CERTIFICATES")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiGetCertificates
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_GET_CERTIFICATES.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_lISTBSS")]
    public static ENUM_WIFI_COMMAND_TYPE? WIFILISTBSS
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_lISTBSS.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_SAVEBSS")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiSavebss
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_SAVEBSS.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_SCAN")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiScan
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_SCAN.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFI_SETCONFIG")]
    public static ENUM_WIFI_COMMAND_TYPE? WifiSetconfig
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_COMMAND_TYPE._members.StaticFields.GetObjectValue("WIFI_SETCONFIG.Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;");
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_COMMAND_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_WIFI_COMMAND_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_COMMAND_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_WIFI_COMMAND_TYPE._members.ManagedPeerType;

    internal ENUM_WIFI_COMMAND_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_WIFI_COMMAND_TYPE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", "")]
    public static unsafe ENUM_WIFI_COMMAND_TYPE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_COMMAND_TYPE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", "")]
    public static unsafe ENUM_WIFI_COMMAND_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_COMMAND_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", "")]
    public static unsafe ENUM_WIFI_COMMAND_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_WIFI_COMMAND_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;", (JniArgumentValue*) null);
      return (ENUM_WIFI_COMMAND_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_WIFI_COMMAND_TYPE));
    }
  }
}
