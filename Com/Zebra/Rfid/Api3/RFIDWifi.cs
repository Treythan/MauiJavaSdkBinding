// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFIDWifi
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
  [Register("com/zebra/rfid/api3/RFIDWifi", DoNotGenerateAcw = true)]
  public class RFIDWifi : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDWifi", typeof (RFIDWifi));
    private static Delegate? cb_getKeyMgmt;
    private static Delegate? cb_setKeyMgmt_Ljava_lang_String_;
    private static Delegate? cb_getWifiState;
    private static Delegate? cb_setWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_;
    private static Delegate? cb_getWifiStatus;
    private static Delegate? cb_setWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_;
    private static Delegate? cb_getWifimac;
    private static Delegate? cb_setWifimac_Ljava_lang_String_;
    private static Delegate? cb_getsecureconfig;
    private static Delegate? cb_getssid;
    private static Delegate? cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_;
    private static Delegate? cb_setssid_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFIDWifi._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFIDWifi._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFIDWifi._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFIDWifi._members.ManagedPeerType;

    protected RFIDWifi(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RFIDWifi()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RFIDWifi._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RFIDWifi._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetKeyMgmtHandler()
    {
      if ((object) RFIDWifi.cb_getKeyMgmt == null)
        RFIDWifi.cb_getKeyMgmt = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_GetKeyMgmt));
      return RFIDWifi.cb_getKeyMgmt;
    }

    private static IntPtr n_GetKeyMgmt(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).KeyMgmt);
    }

    private static Delegate GetSetKeyMgmt_Ljava_lang_String_Handler()
    {
      if ((object) RFIDWifi.cb_setKeyMgmt_Ljava_lang_String_ == null)
        RFIDWifi.cb_setKeyMgmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_SetKeyMgmt_Ljava_lang_String_));
      return RFIDWifi.cb_setKeyMgmt_Ljava_lang_String_;
    }

    private static void n_SetKeyMgmt_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).KeyMgmt = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? KeyMgmt
    {
      [Register("getKeyMgmt", "()Ljava/lang/String;", "GetGetKeyMgmtHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getKeyMgmt.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setKeyMgmt", "(Ljava/lang/String;)V", "GetSetKeyMgmt_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setKeyMgmt.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetWifiStateHandler()
    {
      if ((object) RFIDWifi.cb_getWifiState == null)
        RFIDWifi.cb_getWifiState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_GetWifiState));
      return RFIDWifi.cb_getWifiState;
    }

    private static IntPtr n_GetWifiState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).WifiState);
    }

    private static Delegate GetSetWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_Handler()
    {
      if ((object) RFIDWifi.cb_setWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_ == null)
        RFIDWifi.cb_setWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_SetWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_));
      return RFIDWifi.cb_setWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_;
    }

    private static void n_SetWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).WifiState = Object.GetObject<ENUM_WIFI_STATE>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_WIFI_STATE? WifiState
    {
      [Register("getWifiState", "()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "GetGetWifiStateHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getWifiState.()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setWifiState", "(Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;)V", "GetSetWifiState_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setWifiState.(Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetWifiStatusHandler()
    {
      if ((object) RFIDWifi.cb_getWifiStatus == null)
        RFIDWifi.cb_getWifiStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_GetWifiStatus));
      return RFIDWifi.cb_getWifiStatus;
    }

    private static IntPtr n_GetWifiStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).WifiStatus);
    }

    private static Delegate GetSetWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_Handler()
    {
      if ((object) RFIDWifi.cb_setWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_ == null)
        RFIDWifi.cb_setWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_SetWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_));
      return RFIDWifi.cb_setWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_;
    }

    private static void n_SetWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).WifiStatus = Object.GetObject<ENUM_WIFI_STATUS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_WIFI_STATUS? WifiStatus
    {
      [Register("getWifiStatus", "()Lcom/zebra/rfid/api3/ENUM_WIFI_STATUS;", "GetGetWifiStatusHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getWifiStatus.()Lcom/zebra/rfid/api3/ENUM_WIFI_STATUS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_WIFI_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setWifiStatus", "(Lcom/zebra/rfid/api3/ENUM_WIFI_STATUS;)V", "GetSetWifiStatus_Lcom_zebra_rfid_api3_ENUM_WIFI_STATUS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setWifiStatus.(Lcom/zebra/rfid/api3/ENUM_WIFI_STATUS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetWifimacHandler()
    {
      if ((object) RFIDWifi.cb_getWifimac == null)
        RFIDWifi.cb_getWifimac = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_GetWifimac));
      return RFIDWifi.cb_getWifimac;
    }

    private static IntPtr n_GetWifimac(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Wifimac);
    }

    private static Delegate GetSetWifimac_Ljava_lang_String_Handler()
    {
      if ((object) RFIDWifi.cb_setWifimac_Ljava_lang_String_ == null)
        RFIDWifi.cb_setWifimac_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_SetWifimac_Ljava_lang_String_));
      return RFIDWifi.cb_setWifimac_Ljava_lang_String_;
    }

    private static void n_SetWifimac_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Wifimac = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Wifimac
    {
      [Register("getWifimac", "()Ljava/lang/String;", "GetGetWifimacHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getWifimac.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setWifimac", "(Ljava/lang/String;)V", "GetSetWifimac_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setWifimac.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetsecureconfigHandler()
    {
      if ((object) RFIDWifi.cb_getsecureconfig == null)
        RFIDWifi.cb_getsecureconfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_Getsecureconfig));
      return RFIDWifi.cb_getsecureconfig;
    }

    private static IntPtr n_Getsecureconfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Getsecureconfig());
    }

    [Register("getsecureconfig", "()Lcom/zebra/rfid/api3/WifiSecureConfig;", "GetGetsecureconfigHandler")]
    public virtual unsafe WifiSecureConfig? Getsecureconfig()
    {
      JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getsecureconfig.()Lcom/zebra/rfid/api3/WifiSecureConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<WifiSecureConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetssidHandler()
    {
      if ((object) RFIDWifi.cb_getssid == null)
        RFIDWifi.cb_getssid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDWifi.n_Getssid));
      return RFIDWifi.cb_getssid;
    }

    private static IntPtr n_Getssid(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Getssid());
    }

    [Register("getssid", "()Ljava/lang/String;", "GetGetssidHandler")]
    public virtual unsafe string? Getssid()
    {
      JniObjectReference jniObjectReference = RFIDWifi._members.InstanceMethods.InvokeVirtualObjectMethod("getssid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_Handler()
    {
      if ((object) RFIDWifi.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_ == null)
        RFIDWifi.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_Setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_));
      return RFIDWifi.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_;
    }

    private static void n_Setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_secureconfig)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Setconfig(Object.GetObject<WifiSecureConfig>(native_secureconfig, (JniHandleOwnership) 0));
    }

    [Register("setconfig", "(Lcom/zebra/rfid/api3/WifiSecureConfig;)V", "GetSetconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_Handler")]
    public virtual unsafe void Setconfig(WifiSecureConfig? secureconfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(secureconfig == null ? IntPtr.Zero : secureconfig.Handle)
        };
        RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setconfig.(Lcom/zebra/rfid/api3/WifiSecureConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) secureconfig);
      }
    }

    private static Delegate GetSetssid_Ljava_lang_String_Handler()
    {
      if ((object) RFIDWifi.cb_setssid_Ljava_lang_String_ == null)
        RFIDWifi.cb_setssid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDWifi.n_Setssid_Ljava_lang_String_));
      return RFIDWifi.cb_setssid_Ljava_lang_String_;
    }

    private static void n_Setssid_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<RFIDWifi>(jnienv, native__this, (JniHandleOwnership) 0).Setssid(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setssid", "(Ljava/lang/String;)V", "GetSetssid_Ljava_lang_String_Handler")]
    public virtual unsafe void Setssid(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        RFIDWifi._members.InstanceMethods.InvokeVirtualVoidMethod("setssid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
