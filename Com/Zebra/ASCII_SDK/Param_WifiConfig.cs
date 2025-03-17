// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_WifiConfig
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Com.Zebra.Rfid.Api3;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/Param_WifiConfig", DoNotGenerateAcw = true)]
  public class Param_WifiConfig : Object
  {
    [Register("commandName")]
    public const string CommandName = " .config";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_WifiConfig", typeof (Param_WifiConfig));
    private static Delegate? cb_getAnonymousIdentity;
    private static Delegate? cb_setAnonymousIdentity_Ljava_lang_String_;
    private static Delegate? cb_getCaCert;
    private static Delegate? cb_setCaCert_Ljava_lang_String_;
    private static Delegate? cb_getEap;
    private static Delegate? cb_setEap_Ljava_lang_String_;
    private static Delegate? cb_getIdentity;
    private static Delegate? cb_setIdentity_Ljava_lang_String_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getPrivateKey;
    private static Delegate? cb_setPrivateKey_Ljava_lang_String_;
    private static Delegate? cb_getPrivatePassword;
    private static Delegate? cb_setPrivatePassword_Ljava_lang_String_;
    private static Delegate? cb_getProtocol;
    private static Delegate? cb_setProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getgroup;
    private static Delegate? cb_getpairwise;
    private static Delegate? cb_getpsk;
    private static Delegate? cb_setClientCert_Ljava_lang_String_;
    private static Delegate? cb_setgroup_Ljava_lang_String_;
    private static Delegate? cb_setpairwise_Ljava_lang_String_;
    private static Delegate? cb_setpsk_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_WifiConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_WifiConfig._members.ManagedPeerType;

    protected Param_WifiConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_WifiConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_WifiConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_WifiConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAnonymousIdentityHandler()
    {
      if ((object) Param_WifiConfig.cb_getAnonymousIdentity == null)
        Param_WifiConfig.cb_getAnonymousIdentity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetAnonymousIdentity));
      return Param_WifiConfig.cb_getAnonymousIdentity;
    }

    private static IntPtr n_GetAnonymousIdentity(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).AnonymousIdentity);
    }

    private static Delegate GetSetAnonymousIdentity_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setAnonymousIdentity_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setAnonymousIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetAnonymousIdentity_Ljava_lang_String_));
      return Param_WifiConfig.cb_setAnonymousIdentity_Ljava_lang_String_;
    }

    private static void n_SetAnonymousIdentity_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_anonymousIdentity)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).AnonymousIdentity = JNIEnv.GetString(native_anonymousIdentity, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? AnonymousIdentity
    {
      [Register("getAnonymousIdentity", "()Ljava/lang/String;", "GetGetAnonymousIdentityHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getAnonymousIdentity.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAnonymousIdentity", "(Ljava/lang/String;)V", "GetSetAnonymousIdentity_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setAnonymousIdentity.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetCaCertHandler()
    {
      if ((object) Param_WifiConfig.cb_getCaCert == null)
        Param_WifiConfig.cb_getCaCert = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetCaCert));
      return Param_WifiConfig.cb_getCaCert;
    }

    private static IntPtr n_GetCaCert(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).CaCert);
    }

    private static Delegate GetSetCaCert_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setCaCert_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setCaCert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetCaCert_Ljava_lang_String_));
      return Param_WifiConfig.cb_setCaCert_Ljava_lang_String_;
    }

    private static void n_SetCaCert_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_caCert)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).CaCert = JNIEnv.GetString(native_caCert, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? CaCert
    {
      [Register("getCaCert", "()Ljava/lang/String;", "GetGetCaCertHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCaCert.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setCaCert", "(Ljava/lang/String;)V", "GetSetCaCert_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setCaCert.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetEapHandler()
    {
      if ((object) Param_WifiConfig.cb_getEap == null)
        Param_WifiConfig.cb_getEap = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetEap));
      return Param_WifiConfig.cb_getEap;
    }

    private static IntPtr n_GetEap(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Eap);
    }

    private static Delegate GetSetEap_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setEap_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setEap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetEap_Ljava_lang_String_));
      return Param_WifiConfig.cb_setEap_Ljava_lang_String_;
    }

    private static void n_SetEap_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_eap)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Eap = JNIEnv.GetString(native_eap, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Eap
    {
      [Register("getEap", "()Ljava/lang/String;", "GetGetEapHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getEap.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setEap", "(Ljava/lang/String;)V", "GetSetEap_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEap.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetIdentityHandler()
    {
      if ((object) Param_WifiConfig.cb_getIdentity == null)
        Param_WifiConfig.cb_getIdentity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetIdentity));
      return Param_WifiConfig.cb_getIdentity;
    }

    private static IntPtr n_GetIdentity(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Identity);
    }

    private static Delegate GetSetIdentity_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setIdentity_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetIdentity_Ljava_lang_String_));
      return Param_WifiConfig.cb_setIdentity_Ljava_lang_String_;
    }

    private static void n_SetIdentity_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_identity)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Identity = JNIEnv.GetString(native_identity, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Identity
    {
      [Register("getIdentity", "()Ljava/lang/String;", "GetGetIdentityHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getIdentity.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setIdentity", "(Ljava/lang/String;)V", "GetSetIdentity_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIdentity.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Param_WifiConfig.cb_getPassword == null)
        Param_WifiConfig.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetPassword));
      return Param_WifiConfig.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setPassword_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetPassword_Ljava_lang_String_));
      return Param_WifiConfig.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPrivateKeyHandler()
    {
      if ((object) Param_WifiConfig.cb_getPrivateKey == null)
        Param_WifiConfig.cb_getPrivateKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetPrivateKey));
      return Param_WifiConfig.cb_getPrivateKey;
    }

    private static IntPtr n_GetPrivateKey(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivateKey);
    }

    private static Delegate GetSetPrivateKey_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setPrivateKey_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setPrivateKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetPrivateKey_Ljava_lang_String_));
      return Param_WifiConfig.cb_setPrivateKey_Ljava_lang_String_;
    }

    private static void n_SetPrivateKey_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_privateKey)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivateKey = JNIEnv.GetString(native_privateKey, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? PrivateKey
    {
      [Register("getPrivateKey", "()Ljava/lang/String;", "GetGetPrivateKeyHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivateKey.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPrivateKey", "(Ljava/lang/String;)V", "GetSetPrivateKey_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivateKey.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPrivatePasswordHandler()
    {
      if ((object) Param_WifiConfig.cb_getPrivatePassword == null)
        Param_WifiConfig.cb_getPrivatePassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetPrivatePassword));
      return Param_WifiConfig.cb_getPrivatePassword;
    }

    private static IntPtr n_GetPrivatePassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivatePassword);
    }

    private static Delegate GetSetPrivatePassword_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setPrivatePassword_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setPrivatePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetPrivatePassword_Ljava_lang_String_));
      return Param_WifiConfig.cb_setPrivatePassword_Ljava_lang_String_;
    }

    private static void n_SetPrivatePassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_privatePassword)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivatePassword = JNIEnv.GetString(native_privatePassword, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? PrivatePassword
    {
      [Register("getPrivatePassword", "()Ljava/lang/String;", "GetGetPrivatePasswordHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivatePassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPrivatePassword", "(Ljava/lang/String;)V", "GetSetPrivatePassword_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivatePassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetProtocolHandler()
    {
      if ((object) Param_WifiConfig.cb_getProtocol == null)
        Param_WifiConfig.cb_getProtocol = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_GetProtocol));
      return Param_WifiConfig.cb_getProtocol;
    }

    private static IntPtr n_GetProtocol(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Protocol);
    }

    private static Delegate GetSetProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_Handler()
    {
      if ((object) Param_WifiConfig.cb_setProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_ == null)
        Param_WifiConfig.cb_setProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_));
      return Param_WifiConfig.cb_setProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_;
    }

    private static void n_SetProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_protocol)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Protocol = Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(native_protocol, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_WIFI_PROTOCOL_TYPE? Protocol
    {
      [Register("getProtocol", "()Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", "GetGetProtocolHandler")] get
      {
        JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getProtocol.()Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_WIFI_PROTOCOL_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setProtocol", "(Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;)V", "GetSetProtocol_Lcom_zebra_rfid_api3_ENUM_WIFI_PROTOCOL_TYPE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setProtocol.(Lcom/zebra/rfid/api3/ENUM_WIFI_PROTOCOL_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_WifiConfig.cb_ToString == null)
        Param_WifiConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_ToString));
      return Param_WifiConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetgroupHandler()
    {
      if ((object) Param_WifiConfig.cb_getgroup == null)
        Param_WifiConfig.cb_getgroup = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getgroup));
      return Param_WifiConfig.cb_getgroup;
    }

    private static IntPtr n_Getgroup(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getgroup());
    }

    [Register("getgroup", "()Ljava/lang/String;", "GetGetgroupHandler")]
    public virtual unsafe string? Getgroup()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getgroup.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpairwiseHandler()
    {
      if ((object) Param_WifiConfig.cb_getpairwise == null)
        Param_WifiConfig.cb_getpairwise = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getpairwise));
      return Param_WifiConfig.cb_getpairwise;
    }

    private static IntPtr n_Getpairwise(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getpairwise());
    }

    [Register("getpairwise", "()Ljava/lang/String;", "GetGetpairwiseHandler")]
    public virtual unsafe string? Getpairwise()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getpairwise.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpskHandler()
    {
      if ((object) Param_WifiConfig.cb_getpsk == null)
        Param_WifiConfig.cb_getpsk = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getpsk));
      return Param_WifiConfig.cb_getpsk;
    }

    private static IntPtr n_Getpsk(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getpsk());
    }

    [Register("getpsk", "()Ljava/lang/String;", "GetGetpskHandler")]
    public virtual unsafe string? Getpsk()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getpsk.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetClientCert_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setClientCert_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setClientCert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_SetClientCert_Ljava_lang_String_));
      return Param_WifiConfig.cb_setClientCert_Ljava_lang_String_;
    }

    private static void n_SetClientCert_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_clientCert)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetClientCert(JNIEnv.GetString(native_clientCert, (JniHandleOwnership) 0));
    }

    [Register("setClientCert", "(Ljava/lang/String;)V", "GetSetClientCert_Ljava_lang_String_Handler")]
    public virtual unsafe void SetClientCert(string? clientCert)
    {
      IntPtr num = JNIEnv.NewString(clientCert);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setClientCert.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetgroup_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setgroup_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setgroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setgroup_Ljava_lang_String_));
      return Param_WifiConfig.cb_setgroup_Ljava_lang_String_;
    }

    private static void n_Setgroup_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setgroup(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setgroup", "(Ljava/lang/String;)V", "GetSetgroup_Ljava_lang_String_Handler")]
    public virtual unsafe void Setgroup(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setgroup.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetpairwise_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setpairwise_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setpairwise_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setpairwise_Ljava_lang_String_));
      return Param_WifiConfig.cb_setpairwise_Ljava_lang_String_;
    }

    private static void n_Setpairwise_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setpairwise(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpairwise", "(Ljava/lang/String;)V", "GetSetpairwise_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpairwise(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setpairwise.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetpsk_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setpsk_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setpsk_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setpsk_Ljava_lang_String_));
      return Param_WifiConfig.cb_setpsk_Ljava_lang_String_;
    }

    private static void n_Setpsk_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setpsk(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpsk", "(Ljava/lang/String;)V", "GetSetpsk_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpsk(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setpsk.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
