// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UserApp
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
  [Register("com/zebra/rfid/api3/UserApp", DoNotGenerateAcw = true)]
  public class UserApp : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UserApp", typeof (UserApp));
    private static Delegate? cb_autoStart_Ljava_lang_String_Z;
    private static Delegate? cb_getRunStatus_Ljava_lang_String_;
    private static Delegate? cb_install_Ljava_lang_String_;
    private static Delegate? cb_list;
    private static Delegate? cb_start_Ljava_lang_String_;
    private static Delegate? cb_stop_Ljava_lang_String_;
    private static Delegate? cb_uninstall_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UserApp._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UserApp._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UserApp._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UserApp._members.ManagedPeerType;

    protected UserApp(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe UserApp()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = UserApp._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      UserApp._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetAutoStart_Ljava_lang_String_ZHandler()
    {
      if ((object) UserApp.cb_autoStart_Ljava_lang_String_Z == null)
        UserApp.cb_autoStart_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(UserApp.n_AutoStart_Ljava_lang_String_Z));
      return UserApp.cb_autoStart_Ljava_lang_String_Z;
    }

    private static void n_AutoStart_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_appName,
      bool enable)
    {
      Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).AutoStart(JNIEnv.GetString(native_appName, (JniHandleOwnership) 0), enable);
    }

    [Register("autoStart", "(Ljava/lang/String;Z)V", "GetAutoStart_Ljava_lang_String_ZHandler")]
    public virtual unsafe void AutoStart(string? appName, bool enable)
    {
      IntPtr num = JNIEnv.NewString(appName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(enable)
        };
        UserApp._members.InstanceMethods.InvokeVirtualVoidMethod("autoStart.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetRunStatus_Ljava_lang_String_Handler()
    {
      if ((object) UserApp.cb_getRunStatus_Ljava_lang_String_ == null)
        UserApp.cb_getRunStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_Z(UserApp.n_GetRunStatus_Ljava_lang_String_));
      return UserApp.cb_getRunStatus_Ljava_lang_String_;
    }

    private static bool n_GetRunStatus_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_appName)
    {
      return Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).GetRunStatus(JNIEnv.GetString(native_appName, (JniHandleOwnership) 0));
    }

    [Register("getRunStatus", "(Ljava/lang/String;)Z", "GetGetRunStatus_Ljava_lang_String_Handler")]
    public virtual unsafe bool GetRunStatus(string? appName)
    {
      IntPtr num = JNIEnv.NewString(appName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        return UserApp._members.InstanceMethods.InvokeVirtualBooleanMethod("getRunStatus.(Ljava/lang/String;)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetInstall_Ljava_lang_String_Handler()
    {
      if ((object) UserApp.cb_install_Ljava_lang_String_ == null)
        UserApp.cb_install_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UserApp.n_Install_Ljava_lang_String_));
      return UserApp.cb_install_Ljava_lang_String_;
    }

    private static void n_Install_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_localPath)
    {
      Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).Install(JNIEnv.GetString(native_localPath, (JniHandleOwnership) 0));
    }

    [Register("install", "(Ljava/lang/String;)V", "GetInstall_Ljava_lang_String_Handler")]
    public virtual unsafe void Install(string? localPath)
    {
      IntPtr num = JNIEnv.NewString(localPath);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        UserApp._members.InstanceMethods.InvokeVirtualVoidMethod("install.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetListHandler()
    {
      if ((object) UserApp.cb_list == null)
        UserApp.cb_list = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UserApp.n_List));
      return UserApp.cb_list;
    }

    private static IntPtr n_List(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<UserAppInfo>(Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).List());
    }

    [Register("list", "()[Lcom/zebra/rfid/api3/UserAppInfo;", "GetListHandler")]
    public virtual unsafe UserAppInfo[]? List()
    {
      JniObjectReference jniObjectReference = UserApp._members.InstanceMethods.InvokeVirtualObjectMethod("list.()[Lcom/zebra/rfid/api3/UserAppInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (UserAppInfo[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (UserAppInfo));
    }

    private static Delegate GetStart_Ljava_lang_String_Handler()
    {
      if ((object) UserApp.cb_start_Ljava_lang_String_ == null)
        UserApp.cb_start_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UserApp.n_Start_Ljava_lang_String_));
      return UserApp.cb_start_Ljava_lang_String_;
    }

    private static void n_Start_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_appName)
    {
      Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).Start(JNIEnv.GetString(native_appName, (JniHandleOwnership) 0));
    }

    [Register("start", "(Ljava/lang/String;)V", "GetStart_Ljava_lang_String_Handler")]
    public virtual unsafe void Start(string? appName)
    {
      IntPtr num = JNIEnv.NewString(appName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        UserApp._members.InstanceMethods.InvokeVirtualVoidMethod("start.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetStop_Ljava_lang_String_Handler()
    {
      if ((object) UserApp.cb_stop_Ljava_lang_String_ == null)
        UserApp.cb_stop_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UserApp.n_Stop_Ljava_lang_String_));
      return UserApp.cb_stop_Ljava_lang_String_;
    }

    private static void n_Stop_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_appName)
    {
      Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).Stop(JNIEnv.GetString(native_appName, (JniHandleOwnership) 0));
    }

    [Register("stop", "(Ljava/lang/String;)V", "GetStop_Ljava_lang_String_Handler")]
    public virtual unsafe void Stop(string? appName)
    {
      IntPtr num = JNIEnv.NewString(appName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        UserApp._members.InstanceMethods.InvokeVirtualVoidMethod("stop.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetUninstall_Ljava_lang_String_Handler()
    {
      if ((object) UserApp.cb_uninstall_Ljava_lang_String_ == null)
        UserApp.cb_uninstall_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UserApp.n_Uninstall_Ljava_lang_String_));
      return UserApp.cb_uninstall_Ljava_lang_String_;
    }

    private static void n_Uninstall_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_appName)
    {
      Object.GetObject<UserApp>(jnienv, native__this, (JniHandleOwnership) 0).Uninstall(JNIEnv.GetString(native_appName, (JniHandleOwnership) 0));
    }

    [Register("uninstall", "(Ljava/lang/String;)V", "GetUninstall_Ljava_lang_String_Handler")]
    public virtual unsafe void Uninstall(string? appName)
    {
      IntPtr num = JNIEnv.NewString(appName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        UserApp._members.InstanceMethods.InvokeVirtualVoidMethod("uninstall.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
