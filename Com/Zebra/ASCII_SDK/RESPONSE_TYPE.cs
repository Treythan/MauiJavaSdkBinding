// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.RESPONSE_TYPE
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
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/RESPONSE_TYPE", DoNotGenerateAcw = true)]
  public sealed class RESPONSE_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/RESPONSE_TYPE", typeof (RESPONSE_TYPE));

    [Register("ATTRIBUTEINFO")]
    public static RESPONSE_TYPE? Attributeinfo
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("ATTRIBUTEINFO.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BATTERYSTATS")]
    public static RESPONSE_TYPE? Batterystats
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("BATTERYSTATS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CAPABILITIES")]
    public static RESPONSE_TYPE? Capabilities
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("CAPABILITIES.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CHARGETERMINAL")]
    public static RESPONSE_TYPE? Chargeterminal
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("CHARGETERMINAL.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CRADLESTATUS")]
    public static RESPONSE_TYPE? Cradlestatus
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("CRADLESTATUS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LISTCONNECTIONSRESPONSE")]
    public static RESPONSE_TYPE? Listconnectionsresponse
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("LISTCONNECTIONSRESPONSE.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NETWORKSTATUS")]
    public static RESPONSE_TYPE? Networkstatus
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("NETWORKSTATUS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READERBATTERYHEALTH")]
    public static RESPONSE_TYPE? Readerbatteryhealth
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("READERBATTERYHEALTH.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READERFRIENDLYNAME")]
    public static RESPONSE_TYPE? Readerfriendlyname
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("READERFRIENDLYNAME.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READERPOWERSTATE")]
    public static RESPONSE_TYPE? Readerpowerstate
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("READERPOWERSTATE.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("REGULATORYCONFIG")]
    public static RESPONSE_TYPE? Regulatoryconfig
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("REGULATORYCONFIG.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATUS")]
    public static RESPONSE_TYPE? Status
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("STATUS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SUPPORTEDLINKPROFILES")]
    public static RESPONSE_TYPE? Supportedlinkprofiles
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("SUPPORTEDLINKPROFILES.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SUPPORTEDREGIONS")]
    public static RESPONSE_TYPE? Supportedregions
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("SUPPORTEDREGIONS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TAGDATA")]
    public static RESPONSE_TYPE? Tagdata
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("TAGDATA.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TAGPROXIMITYPERCENT")]
    public static RESPONSE_TYPE? Tagproximitypercent
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("TAGPROXIMITYPERCENT.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("VERSIONINFO")]
    public static RESPONSE_TYPE? Versioninfo
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("VERSIONINFO.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WIFICONFIG")]
    public static RESPONSE_TYPE? Wificonfig
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("WIFICONFIG.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPACONFIG_BSSLIST")]
    public static RESPONSE_TYPE? WpaconfigBsslist
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("WPACONFIG_BSSLIST.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPACONFIG_SCAN")]
    public static RESPONSE_TYPE? WpaconfigScan
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("WPACONFIG_SCAN.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPACONFIG_STATUS")]
    public static RESPONSE_TYPE? WpaconfigStatus
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("WPACONFIG_STATUS.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA_CERTIFICATES")]
    public static RESPONSE_TYPE? WpaCertificates
    {
      get
      {
        JniObjectReference objectValue = RESPONSE_TYPE._members.StaticFields.GetObjectValue("WPA_CERTIFICATES.Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;");
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RESPONSE_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RESPONSE_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RESPONSE_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RESPONSE_TYPE._members.ManagedPeerType;

    internal RESPONSE_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "")]
    public static unsafe RESPONSE_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = RESPONSE_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "")]
    public static unsafe RESPONSE_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = RESPONSE_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", (JniArgumentValue*) null);
      return (RESPONSE_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (RESPONSE_TYPE));
    }
  }
}
