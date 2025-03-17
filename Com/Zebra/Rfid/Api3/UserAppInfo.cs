// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UserAppInfo
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
  [Register("com/zebra/rfid/api3/UserAppInfo", DoNotGenerateAcw = true)]
  public class UserAppInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UserAppInfo", typeof (UserAppInfo));
    private static Delegate? cb_getAppName;
    private static Delegate? cb_getAutoStart;
    private static Delegate? cb_getMetaData;
    private static Delegate? cb_getRunStatus;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UserAppInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UserAppInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UserAppInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UserAppInfo._members.ManagedPeerType;

    protected UserAppInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe UserAppInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = UserAppInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      UserAppInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAppNameHandler()
    {
      if ((object) UserAppInfo.cb_getAppName == null)
        UserAppInfo.cb_getAppName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UserAppInfo.n_GetAppName));
      return UserAppInfo.cb_getAppName;
    }

    private static IntPtr n_GetAppName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<UserAppInfo>(jnienv, native__this, (JniHandleOwnership) 0).AppName);
    }

    public virtual unsafe string? AppName
    {
      [Register("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")] get
      {
        JniObjectReference jniObjectReference = UserAppInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getAppName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetAutoStartHandler()
    {
      if ((object) UserAppInfo.cb_getAutoStart == null)
        UserAppInfo.cb_getAutoStart = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(UserAppInfo.n_GetAutoStart));
      return UserAppInfo.cb_getAutoStart;
    }

    private static bool n_GetAutoStart(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UserAppInfo>(jnienv, native__this, (JniHandleOwnership) 0).AutoStart;
    }

    public virtual unsafe bool AutoStart
    {
      [Register("getAutoStart", "()Z", "GetGetAutoStartHandler")] get
      {
        return UserAppInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getAutoStart.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMetaDataHandler()
    {
      if ((object) UserAppInfo.cb_getMetaData == null)
        UserAppInfo.cb_getMetaData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UserAppInfo.n_GetMetaData));
      return UserAppInfo.cb_getMetaData;
    }

    private static IntPtr n_GetMetaData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<UserAppInfo>(jnienv, native__this, (JniHandleOwnership) 0).MetaData);
    }

    public virtual unsafe string? MetaData
    {
      [Register("getMetaData", "()Ljava/lang/String;", "GetGetMetaDataHandler")] get
      {
        JniObjectReference jniObjectReference = UserAppInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getMetaData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRunStatusHandler()
    {
      if ((object) UserAppInfo.cb_getRunStatus == null)
        UserAppInfo.cb_getRunStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(UserAppInfo.n_GetRunStatus));
      return UserAppInfo.cb_getRunStatus;
    }

    private static bool n_GetRunStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UserAppInfo>(jnienv, native__this, (JniHandleOwnership) 0).RunStatus;
    }

    public virtual unsafe bool RunStatus
    {
      [Register("getRunStatus", "()Z", "GetGetRunStatusHandler")] get
      {
        return UserAppInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getRunStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
