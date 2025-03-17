// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WifiSecureConfig
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
  [Register("com/zebra/rfid/api3/WifiSecureConfig", DoNotGenerateAcw = true)]
  public class WifiSecureConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WifiSecureConfig", typeof (WifiSecureConfig));
    private static Delegate? cb_getAnonymousIdentity;
    private static Delegate? cb_setAnonymousIdentity_Ljava_lang_String_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getPrivateKey;
    private static Delegate? cb_setPrivateKey_Ljava_lang_String_;
    private static Delegate? cb_getPrivatePassword;
    private static Delegate? cb_setPrivatePassword_Ljava_lang_String_;
    private static Delegate? cb_getcacert;
    private static Delegate? cb_getclientcert;
    private static Delegate? cb_geteap;
    private static Delegate? cb_geteapolflag;
    private static Delegate? cb_getgroup;
    private static Delegate? cb_getidentity;
    private static Delegate? cb_getpairwise;
    private static Delegate? cb_setcacert_Ljava_lang_String_;
    private static Delegate? cb_setclientcert_Ljava_lang_String_;
    private static Delegate? cb_seteap_Ljava_lang_String_;
    private static Delegate? cb_seteapolflag_Ljava_lang_String_;
    private static Delegate? cb_setgroup_Ljava_lang_String_;
    private static Delegate? cb_setidentity_Ljava_lang_String_;
    private static Delegate? cb_setpairwise_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WifiSecureConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WifiSecureConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WifiSecureConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => WifiSecureConfig._members.ManagedPeerType;

    protected WifiSecureConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe WifiSecureConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = WifiSecureConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      WifiSecureConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAnonymousIdentityHandler()
    {
      if ((object) WifiSecureConfig.cb_getAnonymousIdentity == null)
        WifiSecureConfig.cb_getAnonymousIdentity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_GetAnonymousIdentity));
      return WifiSecureConfig.cb_getAnonymousIdentity;
    }

    private static IntPtr n_GetAnonymousIdentity(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).AnonymousIdentity);
    }

    private static Delegate GetSetAnonymousIdentity_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setAnonymousIdentity_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setAnonymousIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_SetAnonymousIdentity_Ljava_lang_String_));
      return WifiSecureConfig.cb_setAnonymousIdentity_Ljava_lang_String_;
    }

    private static void n_SetAnonymousIdentity_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_anonymous_identity)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).AnonymousIdentity = JNIEnv.GetString(native_anonymous_identity, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? AnonymousIdentity
    {
      [Register("getAnonymousIdentity", "()Ljava/lang/String;", "GetGetAnonymousIdentityHandler")] get
      {
        JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getAnonymousIdentity.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setAnonymousIdentity.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) WifiSecureConfig.cb_getPassword == null)
        WifiSecureConfig.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_GetPassword));
      return WifiSecureConfig.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setPassword_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_SetPassword_Ljava_lang_String_));
      return WifiSecureConfig.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPrivateKeyHandler()
    {
      if ((object) WifiSecureConfig.cb_getPrivateKey == null)
        WifiSecureConfig.cb_getPrivateKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_GetPrivateKey));
      return WifiSecureConfig.cb_getPrivateKey;
    }

    private static IntPtr n_GetPrivateKey(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivateKey);
    }

    private static Delegate GetSetPrivateKey_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setPrivateKey_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setPrivateKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_SetPrivateKey_Ljava_lang_String_));
      return WifiSecureConfig.cb_setPrivateKey_Ljava_lang_String_;
    }

    private static void n_SetPrivateKey_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivateKey = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? PrivateKey
    {
      [Register("getPrivateKey", "()Ljava/lang/String;", "GetGetPrivateKeyHandler")] get
      {
        JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivateKey.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivateKey.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPrivatePasswordHandler()
    {
      if ((object) WifiSecureConfig.cb_getPrivatePassword == null)
        WifiSecureConfig.cb_getPrivatePassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_GetPrivatePassword));
      return WifiSecureConfig.cb_getPrivatePassword;
    }

    private static IntPtr n_GetPrivatePassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivatePassword);
    }

    private static Delegate GetSetPrivatePassword_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setPrivatePassword_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setPrivatePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_SetPrivatePassword_Ljava_lang_String_));
      return WifiSecureConfig.cb_setPrivatePassword_Ljava_lang_String_;
    }

    private static void n_SetPrivatePassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_privatePassword)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrivatePassword = JNIEnv.GetString(native_privatePassword, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? PrivatePassword
    {
      [Register("getPrivatePassword", "()Ljava/lang/String;", "GetGetPrivatePasswordHandler")] get
      {
        JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivatePassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivatePassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetcacertHandler()
    {
      if ((object) WifiSecureConfig.cb_getcacert == null)
        WifiSecureConfig.cb_getcacert = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Getcacert));
      return WifiSecureConfig.cb_getcacert;
    }

    private static IntPtr n_Getcacert(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getcacert());
    }

    [Register("getcacert", "()Ljava/lang/String;", "GetGetcacertHandler")]
    public virtual unsafe string? Getcacert()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getcacert.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetclientcertHandler()
    {
      if ((object) WifiSecureConfig.cb_getclientcert == null)
        WifiSecureConfig.cb_getclientcert = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Getclientcert));
      return WifiSecureConfig.cb_getclientcert;
    }

    private static IntPtr n_Getclientcert(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getclientcert());
    }

    [Register("getclientcert", "()Ljava/lang/String;", "GetGetclientcertHandler")]
    public virtual unsafe string? Getclientcert()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getclientcert.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGeteapHandler()
    {
      if ((object) WifiSecureConfig.cb_geteap == null)
        WifiSecureConfig.cb_geteap = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Geteap));
      return WifiSecureConfig.cb_geteap;
    }

    private static IntPtr n_Geteap(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Geteap());
    }

    [Register("geteap", "()Ljava/lang/String;", "GetGeteapHandler")]
    public virtual unsafe string? Geteap()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("geteap.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGeteapolflagHandler()
    {
      if ((object) WifiSecureConfig.cb_geteapolflag == null)
        WifiSecureConfig.cb_geteapolflag = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Geteapolflag));
      return WifiSecureConfig.cb_geteapolflag;
    }

    private static IntPtr n_Geteapolflag(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Geteapolflag());
    }

    [Register("geteapolflag", "()Ljava/lang/String;", "GetGeteapolflagHandler")]
    public virtual unsafe string? Geteapolflag()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("geteapolflag.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetgroupHandler()
    {
      if ((object) WifiSecureConfig.cb_getgroup == null)
        WifiSecureConfig.cb_getgroup = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Getgroup));
      return WifiSecureConfig.cb_getgroup;
    }

    private static IntPtr n_Getgroup(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getgroup());
    }

    [Register("getgroup", "()Ljava/lang/String;", "GetGetgroupHandler")]
    public virtual unsafe string? Getgroup()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getgroup.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetidentityHandler()
    {
      if ((object) WifiSecureConfig.cb_getidentity == null)
        WifiSecureConfig.cb_getidentity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Getidentity));
      return WifiSecureConfig.cb_getidentity;
    }

    private static IntPtr n_Getidentity(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getidentity());
    }

    [Register("getidentity", "()Ljava/lang/String;", "GetGetidentityHandler")]
    public virtual unsafe string? Getidentity()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getidentity.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpairwiseHandler()
    {
      if ((object) WifiSecureConfig.cb_getpairwise == null)
        WifiSecureConfig.cb_getpairwise = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiSecureConfig.n_Getpairwise));
      return WifiSecureConfig.cb_getpairwise;
    }

    private static IntPtr n_Getpairwise(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getpairwise());
    }

    [Register("getpairwise", "()Ljava/lang/String;", "GetGetpairwiseHandler")]
    public virtual unsafe string? Getpairwise()
    {
      JniObjectReference jniObjectReference = WifiSecureConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getpairwise.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetcacert_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setcacert_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setcacert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Setcacert_Ljava_lang_String_));
      return WifiSecureConfig.cb_setcacert_Ljava_lang_String_;
    }

    private static void n_Setcacert_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setcacert(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setcacert", "(Ljava/lang/String;)V", "GetSetcacert_Ljava_lang_String_Handler")]
    public virtual unsafe void Setcacert(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setcacert.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetclientcert_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setclientcert_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setclientcert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Setclientcert_Ljava_lang_String_));
      return WifiSecureConfig.cb_setclientcert_Ljava_lang_String_;
    }

    private static void n_Setclientcert_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setclientcert(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setclientcert", "(Ljava/lang/String;)V", "GetSetclientcert_Ljava_lang_String_Handler")]
    public virtual unsafe void Setclientcert(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setclientcert.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSeteap_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_seteap_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_seteap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Seteap_Ljava_lang_String_));
      return WifiSecureConfig.cb_seteap_Ljava_lang_String_;
    }

    private static void n_Seteap_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Seteap(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("seteap", "(Ljava/lang/String;)V", "GetSeteap_Ljava_lang_String_Handler")]
    public virtual unsafe void Seteap(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("seteap.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSeteapolflag_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_seteapolflag_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_seteapolflag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Seteapolflag_Ljava_lang_String_));
      return WifiSecureConfig.cb_seteapolflag_Ljava_lang_String_;
    }

    private static void n_Seteapolflag_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Seteapolflag(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("seteapolflag", "(Ljava/lang/String;)V", "GetSeteapolflag_Ljava_lang_String_Handler")]
    public virtual unsafe void Seteapolflag(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("seteapolflag.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetgroup_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setgroup_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setgroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Setgroup_Ljava_lang_String_));
      return WifiSecureConfig.cb_setgroup_Ljava_lang_String_;
    }

    private static void n_Setgroup_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setgroup(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
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
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setgroup.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetidentity_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setidentity_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setidentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Setidentity_Ljava_lang_String_));
      return WifiSecureConfig.cb_setidentity_Ljava_lang_String_;
    }

    private static void n_Setidentity_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setidentity(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setidentity", "(Ljava/lang/String;)V", "GetSetidentity_Ljava_lang_String_Handler")]
    public virtual unsafe void Setidentity(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setidentity.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetpairwise_Ljava_lang_String_Handler()
    {
      if ((object) WifiSecureConfig.cb_setpairwise_Ljava_lang_String_ == null)
        WifiSecureConfig.cb_setpairwise_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiSecureConfig.n_Setpairwise_Ljava_lang_String_));
      return WifiSecureConfig.cb_setpairwise_Ljava_lang_String_;
    }

    private static void n_Setpairwise_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiSecureConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setpairwise(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
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
        WifiSecureConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setpairwise.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
