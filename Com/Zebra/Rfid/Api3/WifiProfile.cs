// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WifiProfile
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
  [Register("com/zebra/rfid/api3/WifiProfile", DoNotGenerateAcw = true)]
  public class WifiProfile : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WifiProfile", typeof (WifiProfile));
    private static Delegate? cb_getconfig;
    private static Delegate? cb_getpassword;
    private static Delegate? cb_getprotocol;
    private static Delegate? cb_getssid;
    private static Delegate? cb_getstate;
    private static Delegate? cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_;
    private static Delegate? cb_setpassword_Ljava_lang_String_;
    private static Delegate? cb_setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_;
    private static Delegate? cb_setssid_Ljava_lang_String_;
    private static Delegate? cb_setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WifiProfile._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WifiProfile._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WifiProfile._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => WifiProfile._members.ManagedPeerType;

    protected WifiProfile(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe WifiProfile()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = WifiProfile._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      WifiProfile._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetconfigHandler()
    {
      if ((object) WifiProfile.cb_getconfig == null)
        WifiProfile.cb_getconfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiProfile.n_Getconfig));
      return WifiProfile.cb_getconfig;
    }

    private static IntPtr n_Getconfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Getconfig());
    }

    [Register("getconfig", "()Lcom/zebra/rfid/api3/WifiSecureConfig;", "GetGetconfigHandler")]
    public virtual unsafe WifiSecureConfig? Getconfig()
    {
      JniObjectReference jniObjectReference = WifiProfile._members.InstanceMethods.InvokeVirtualObjectMethod("getconfig.()Lcom/zebra/rfid/api3/WifiSecureConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<WifiSecureConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpasswordHandler()
    {
      if ((object) WifiProfile.cb_getpassword == null)
        WifiProfile.cb_getpassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiProfile.n_Getpassword));
      return WifiProfile.cb_getpassword;
    }

    private static IntPtr n_Getpassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Getpassword());
    }

    [Register("getpassword", "()Ljava/lang/String;", "GetGetpasswordHandler")]
    public virtual unsafe string? Getpassword()
    {
      JniObjectReference jniObjectReference = WifiProfile._members.InstanceMethods.InvokeVirtualObjectMethod("getpassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetprotocolHandler()
    {
      if ((object) WifiProfile.cb_getprotocol == null)
        WifiProfile.cb_getprotocol = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiProfile.n_Getprotocol));
      return WifiProfile.cb_getprotocol;
    }

    private static IntPtr n_Getprotocol(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Getprotocol());
    }

    [Register("getprotocol", "()Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", "GetGetprotocolHandler")]
    public virtual unsafe ENUM_WIFI_PROTOCOL_TYPE? Getprotocol()
    {
      JniObjectReference jniObjectReference = WifiProfile._members.InstanceMethods.InvokeVirtualObjectMethod("getprotocol.()Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetssidHandler()
    {
      if ((object) WifiProfile.cb_getssid == null)
        WifiProfile.cb_getssid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiProfile.n_Getssid));
      return WifiProfile.cb_getssid;
    }

    private static IntPtr n_Getssid(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Getssid());
    }

    [Register("getssid", "()Ljava/lang/String;", "GetGetssidHandler")]
    public virtual unsafe string? Getssid()
    {
      JniObjectReference jniObjectReference = WifiProfile._members.InstanceMethods.InvokeVirtualObjectMethod("getssid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetstateHandler()
    {
      if ((object) WifiProfile.cb_getstate == null)
        WifiProfile.cb_getstate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiProfile.n_Getstate));
      return WifiProfile.cb_getstate;
    }

    private static IntPtr n_Getstate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Getstate());
    }

    [Register("getstate", "()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "GetGetstateHandler")]
    public virtual unsafe ENUM_WIFI_STATE? Getstate()
    {
      JniObjectReference jniObjectReference = WifiProfile._members.InstanceMethods.InvokeVirtualObjectMethod("getstate.()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_Handler()
    {
      if ((object) WifiProfile.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_ == null)
        WifiProfile.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiProfile.n_Setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_));
      return WifiProfile.cb_setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_;
    }

    private static void n_Setconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_configmap)
    {
      Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Setconfig(Object.GetObject<WifiSecureConfig>(native_configmap, (JniHandleOwnership) 0));
    }

    [Register("setconfig", "(Lcom/zebra/rfid/api3/WifiSecureConfig;)V", "GetSetconfig_Lcom_zebra_rfid_api3_WifiSecureConfig_Handler")]
    public virtual unsafe void Setconfig(WifiSecureConfig? configmap)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(configmap == null ? IntPtr.Zero : configmap.Handle)
        };
        WifiProfile._members.InstanceMethods.InvokeVirtualVoidMethod("setconfig.(Lcom/zebra/rfid/api3/WifiSecureConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) configmap);
      }
    }

    private static Delegate GetSetpassword_Ljava_lang_String_Handler()
    {
      if ((object) WifiProfile.cb_setpassword_Ljava_lang_String_ == null)
        WifiProfile.cb_setpassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiProfile.n_Setpassword_Ljava_lang_String_));
      return WifiProfile.cb_setpassword_Ljava_lang_String_;
    }

    private static void n_Setpassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Setpassword(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpassword", "(Ljava/lang/String;)V", "GetSetpassword_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpassword(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiProfile._members.InstanceMethods.InvokeVirtualVoidMethod("setpassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_Handler()
    {
      if ((object) WifiProfile.cb_setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_ == null)
        WifiProfile.cb_setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiProfile.n_Setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_));
      return WifiProfile.cb_setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_;
    }

    private static void n_Setprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Setprotocol(Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setprotocol", "(Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;)V", "GetSetprotocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_Handler")]
    public virtual unsafe void Setprotocol(ENUM_WIFI_PROTOCOL_TYPE? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        WifiProfile._members.InstanceMethods.InvokeVirtualVoidMethod("setprotocol.(Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }

    private static Delegate GetSetssid_Ljava_lang_String_Handler()
    {
      if ((object) WifiProfile.cb_setssid_Ljava_lang_String_ == null)
        WifiProfile.cb_setssid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiProfile.n_Setssid_Ljava_lang_String_));
      return WifiProfile.cb_setssid_Ljava_lang_String_;
    }

    private static void n_Setssid_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Setssid(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
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
        WifiProfile._members.InstanceMethods.InvokeVirtualVoidMethod("setssid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_Handler()
    {
      if ((object) WifiProfile.cb_setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_ == null)
        WifiProfile.cb_setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiProfile.n_Setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_));
      return WifiProfile.cb_setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_;
    }

    private static void n_Setstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiProfile>(jnienv, native__this, (JniHandleOwnership) 0).Setstate(Object.GetObject<ENUM_WIFI_STATE>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setstate", "(Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;)V", "GetSetstate_Lcom_zebra_rfid_api3_ENUM_WIFI_STATE_Handler")]
    public virtual unsafe void Setstate(ENUM_WIFI_STATE? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        WifiProfile._members.InstanceMethods.InvokeVirtualVoidMethod("setstate.(Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }
  }
}
