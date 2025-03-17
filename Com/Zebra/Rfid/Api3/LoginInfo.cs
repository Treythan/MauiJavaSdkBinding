// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LoginInfo
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
  [Register("com/zebra/rfid/api3/LoginInfo", DoNotGenerateAcw = true)]
  public class LoginInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LoginInfo", typeof (LoginInfo));
    private static Delegate? cb_getForceLogin;
    private static Delegate? cb_setForceLogin_Z;
    private static Delegate? cb_getHostName;
    private static Delegate? cb_setHostName_Ljava_lang_String_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getSecureMode;
    private static Delegate? cb_setSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_;
    private static Delegate? cb_getUserName;
    private static Delegate? cb_setUserName_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LoginInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LoginInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LoginInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LoginInfo._members.ManagedPeerType;

    protected LoginInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe LoginInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = LoginInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      LoginInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;)V", "")]
    public unsafe LoginInfo(
      string? hostName,
      string? userName,
      string? password,
      SECURE_MODE? secureMode)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(hostName);
      IntPtr num2 = JNIEnv.NewString(userName);
      IntPtr num3 = JNIEnv.NewString(password);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3),
          new JniArgumentValue(secureMode == null ? IntPtr.Zero : secureMode.Handle)
        };
        JniObjectReference instance = LoginInfo._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        LoginInfo._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
        GC.KeepAlive((object) secureMode);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;Z)V", "")]
    public unsafe LoginInfo(
      string? hostName,
      string? userName,
      string? password,
      SECURE_MODE? secureMode,
      bool forceLogin)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(hostName);
      IntPtr num2 = JNIEnv.NewString(userName);
      IntPtr num3 = JNIEnv.NewString(password);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3),
          new JniArgumentValue(secureMode == null ? IntPtr.Zero : secureMode.Handle),
          new JniArgumentValue(forceLogin)
        };
        JniObjectReference instance = LoginInfo._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;Z)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        LoginInfo._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/SECURE_MODE;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
        GC.KeepAlive((object) secureMode);
      }
    }

    private static Delegate GetGetForceLoginHandler()
    {
      if ((object) LoginInfo.cb_getForceLogin == null)
        LoginInfo.cb_getForceLogin = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(LoginInfo.n_GetForceLogin));
      return LoginInfo.cb_getForceLogin;
    }

    private static bool n_GetForceLogin(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).ForceLogin;
    }

    private static Delegate GetSetForceLogin_ZHandler()
    {
      if ((object) LoginInfo.cb_setForceLogin_Z == null)
        LoginInfo.cb_setForceLogin_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(LoginInfo.n_SetForceLogin_Z));
      return LoginInfo.cb_setForceLogin_Z;
    }

    private static void n_SetForceLogin_Z(IntPtr jnienv, IntPtr native__this, bool forceLogin)
    {
      Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).ForceLogin = forceLogin;
    }

    public virtual unsafe bool ForceLogin
    {
      [Register("getForceLogin", "()Z", "GetGetForceLoginHandler")] get
      {
        return LoginInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getForceLogin.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setForceLogin", "(Z)V", "GetSetForceLogin_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LoginInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setForceLogin.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetHostNameHandler()
    {
      if ((object) LoginInfo.cb_getHostName == null)
        LoginInfo.cb_getHostName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LoginInfo.n_GetHostName));
      return LoginInfo.cb_getHostName;
    }

    private static IntPtr n_GetHostName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).HostName);
    }

    private static Delegate GetSetHostName_Ljava_lang_String_Handler()
    {
      if ((object) LoginInfo.cb_setHostName_Ljava_lang_String_ == null)
        LoginInfo.cb_setHostName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LoginInfo.n_SetHostName_Ljava_lang_String_));
      return LoginInfo.cb_setHostName_Ljava_lang_String_;
    }

    private static void n_SetHostName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_hostName)
    {
      Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).HostName = JNIEnv.GetString(native_hostName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? HostName
    {
      [Register("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")] get
      {
        JniObjectReference jniObjectReference = LoginInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getHostName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHostName", "(Ljava/lang/String;)V", "GetSetHostName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          LoginInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setHostName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) LoginInfo.cb_getPassword == null)
        LoginInfo.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LoginInfo.n_GetPassword));
      return LoginInfo.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) LoginInfo.cb_setPassword_Ljava_lang_String_ == null)
        LoginInfo.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LoginInfo.n_SetPassword_Ljava_lang_String_));
      return LoginInfo.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = LoginInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          LoginInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetSecureModeHandler()
    {
      if ((object) LoginInfo.cb_getSecureMode == null)
        LoginInfo.cb_getSecureMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LoginInfo.n_GetSecureMode));
      return LoginInfo.cb_getSecureMode;
    }

    private static IntPtr n_GetSecureMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).SecureMode);
    }

    private static Delegate GetSetSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_Handler()
    {
      if ((object) LoginInfo.cb_setSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_ == null)
        LoginInfo.cb_setSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LoginInfo.n_SetSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_));
      return LoginInfo.cb_setSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_;
    }

    private static void n_SetSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_eSecureMode)
    {
      Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).SecureMode = Object.GetObject<SECURE_MODE>(native_m_eSecureMode, (JniHandleOwnership) 0);
    }

    public virtual unsafe SECURE_MODE? SecureMode
    {
      [Register("getSecureMode", "()Lcom/zebra/rfid/api3/SECURE_MODE;", "GetGetSecureModeHandler")] get
      {
        JniObjectReference jniObjectReference = LoginInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getSecureMode.()Lcom/zebra/rfid/api3/SECURE_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SECURE_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setSecureMode", "(Lcom/zebra/rfid/api3/SECURE_MODE;)V", "GetSetSecureMode_Lcom_zebra_rfid_api3_SECURE_MODE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          LoginInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setSecureMode.(Lcom/zebra/rfid/api3/SECURE_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetUserNameHandler()
    {
      if ((object) LoginInfo.cb_getUserName == null)
        LoginInfo.cb_getUserName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LoginInfo.n_GetUserName));
      return LoginInfo.cb_getUserName;
    }

    private static IntPtr n_GetUserName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).UserName);
    }

    private static Delegate GetSetUserName_Ljava_lang_String_Handler()
    {
      if ((object) LoginInfo.cb_setUserName_Ljava_lang_String_ == null)
        LoginInfo.cb_setUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LoginInfo.n_SetUserName_Ljava_lang_String_));
      return LoginInfo.cb_setUserName_Ljava_lang_String_;
    }

    private static void n_SetUserName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_userName)
    {
      Object.GetObject<LoginInfo>(jnienv, native__this, (JniHandleOwnership) 0).UserName = JNIEnv.GetString(native_userName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? UserName
    {
      [Register("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")] get
      {
        JniObjectReference jniObjectReference = LoginInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getUserName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setUserName", "(Ljava/lang/String;)V", "GetSetUserName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          LoginInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setUserName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }
  }
}
