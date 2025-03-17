// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SoftwareUpdateInfo
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
  [Register("com/zebra/rfid/api3/SoftwareUpdateInfo", DoNotGenerateAcw = true)]
  public class SoftwareUpdateInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SoftwareUpdateInfo", typeof (SoftwareUpdateInfo));
    private static Delegate? cb_getHostName;
    private static Delegate? cb_setHostName_Ljava_lang_String_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getUserName;
    private static Delegate? cb_setUserName_Ljava_lang_String_;
    private static Delegate? cb_getfactoryResetFlag;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SoftwareUpdateInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SoftwareUpdateInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SoftwareUpdateInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SoftwareUpdateInfo._members.ManagedPeerType;

    protected SoftwareUpdateInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SoftwareUpdateInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SoftwareUpdateInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SoftwareUpdateInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
    public unsafe SoftwareUpdateInfo(
      string? hostName,
      string? userName,
      string? password,
      bool factoryReset)
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
          new JniArgumentValue(factoryReset)
        };
        JniObjectReference instance = SoftwareUpdateInfo._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        SoftwareUpdateInfo._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
      }
    }

    private static Delegate GetGetHostNameHandler()
    {
      if ((object) SoftwareUpdateInfo.cb_getHostName == null)
        SoftwareUpdateInfo.cb_getHostName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SoftwareUpdateInfo.n_GetHostName));
      return SoftwareUpdateInfo.cb_getHostName;
    }

    private static IntPtr n_GetHostName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).HostName);
    }

    private static Delegate GetSetHostName_Ljava_lang_String_Handler()
    {
      if ((object) SoftwareUpdateInfo.cb_setHostName_Ljava_lang_String_ == null)
        SoftwareUpdateInfo.cb_setHostName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SoftwareUpdateInfo.n_SetHostName_Ljava_lang_String_));
      return SoftwareUpdateInfo.cb_setHostName_Ljava_lang_String_;
    }

    private static void n_SetHostName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sHostName)
    {
      Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).HostName = JNIEnv.GetString(native_m_sHostName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? HostName
    {
      [Register("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")] get
      {
        JniObjectReference jniObjectReference = SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getHostName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setHostName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) SoftwareUpdateInfo.cb_getPassword == null)
        SoftwareUpdateInfo.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SoftwareUpdateInfo.n_GetPassword));
      return SoftwareUpdateInfo.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) SoftwareUpdateInfo.cb_setPassword_Ljava_lang_String_ == null)
        SoftwareUpdateInfo.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SoftwareUpdateInfo.n_SetPassword_Ljava_lang_String_));
      return SoftwareUpdateInfo.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetUserNameHandler()
    {
      if ((object) SoftwareUpdateInfo.cb_getUserName == null)
        SoftwareUpdateInfo.cb_getUserName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SoftwareUpdateInfo.n_GetUserName));
      return SoftwareUpdateInfo.cb_getUserName;
    }

    private static IntPtr n_GetUserName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).UserName);
    }

    private static Delegate GetSetUserName_Ljava_lang_String_Handler()
    {
      if ((object) SoftwareUpdateInfo.cb_setUserName_Ljava_lang_String_ == null)
        SoftwareUpdateInfo.cb_setUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SoftwareUpdateInfo.n_SetUserName_Ljava_lang_String_));
      return SoftwareUpdateInfo.cb_setUserName_Ljava_lang_String_;
    }

    private static void n_SetUserName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_userName)
    {
      Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).UserName = JNIEnv.GetString(native_userName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? UserName
    {
      [Register("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")] get
      {
        JniObjectReference jniObjectReference = SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getUserName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setUserName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetfactoryResetFlagHandler()
    {
      if ((object) SoftwareUpdateInfo.cb_getfactoryResetFlag == null)
        SoftwareUpdateInfo.cb_getfactoryResetFlag = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(SoftwareUpdateInfo.n_GetfactoryResetFlag));
      return SoftwareUpdateInfo.cb_getfactoryResetFlag;
    }

    private static bool n_GetfactoryResetFlag(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SoftwareUpdateInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetfactoryResetFlag();
    }

    [Register("getfactoryResetFlag", "()Z", "GetGetfactoryResetFlagHandler")]
    public virtual unsafe bool GetfactoryResetFlag()
    {
      return SoftwareUpdateInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getfactoryResetFlag.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
