// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_WIFI_PROTOCOL_TYPE
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
  [Register("com/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE", DoNotGenerateAcw = true)]
  public sealed class ENUM_WIFI_PROTOCOL_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE", typeof (ENUM_WIFI_PROTOCOL_TYPE));

    [Register("IEEE8021X")]
    public static ENUM_WIFI_PROTOCOL_TYPE? Ieee8021x
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("IEEE8021X.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("No_Encryption")]
    public static ENUM_WIFI_PROTOCOL_TYPE? NoEncryption
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("No_Encryption.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UNSUPPORTED")]
    public static ENUM_WIFI_PROTOCOL_TYPE? Unsupported
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("UNSUPPORTED.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA2_Enterprise_CCMP")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA2EnterpriseCCMP
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA2_Enterprise_CCMP.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA2_Personal_CCMP")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA2PersonalCCMP
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA2_Personal_CCMP.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Enterprise_CCMP")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3EnterpriseCCMP
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Enterprise_CCMP.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Enterprise_CCMP_256")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3EnterpriseCCMP256
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Enterprise_CCMP_256.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Enterprise_GCMP_128")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3EnterpriseGCMP128
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Enterprise_GCMP_128.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Enterprise_GCMP_256_SHA256")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3EnterpriseGCMP256SHA256
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Enterprise_GCMP_256_SHA256.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Enterprise_GCMP_256_SUITEB_192")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3EnterpriseGCMP256SUITEB192
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Enterprise_GCMP_256_SUITEB_192.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA3_Personal_SAE")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPA3PersonalSAE
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA3_Personal_SAE.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPAPSK")]
    public static ENUM_WIFI_PROTOCOL_TYPE? Wpapsk
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPAPSK.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA_Personal_TKIP")]
    public static ENUM_WIFI_PROTOCOL_TYPE? WPAPersonalTKIP
    {
      get
      {
        JniObjectReference objectValue = ENUM_WIFI_PROTOCOL_TYPE._members.StaticFields.GetObjectValue("WPA_Personal_TKIP.Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;");
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_PROTOCOL_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_WIFI_PROTOCOL_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_WIFI_PROTOCOL_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_WIFI_PROTOCOL_TYPE._members.ManagedPeerType;

    internal ENUM_WIFI_PROTOCOL_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_WIFI_PROTOCOL_TYPE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", "")]
    public static unsafe ENUM_WIFI_PROTOCOL_TYPE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_PROTOCOL_TYPE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", "")]
    public static unsafe ENUM_WIFI_PROTOCOL_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_WIFI_PROTOCOL_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", "")]
    public static unsafe ENUM_WIFI_PROTOCOL_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_WIFI_PROTOCOL_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", (JniArgumentValue*) null);
      return (ENUM_WIFI_PROTOCOL_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_WIFI_PROTOCOL_TYPE));
    }
  }
}
