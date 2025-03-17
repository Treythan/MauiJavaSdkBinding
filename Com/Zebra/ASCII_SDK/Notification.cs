// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification
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
  [Register("com/zebra/ASCII_SDK/Notification", DoNotGenerateAcw = true)]
  public abstract class Notification : Object, IMsg, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification", typeof (Notification));
    private static Delegate? cb_getMsgType;
    private static Delegate? cb_getNotificationType;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Notification._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Notification._members.ManagedPeerType;

    protected Notification(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetMsgTypeHandler()
    {
      if ((object) Notification.cb_getMsgType == null)
        Notification.cb_getMsgType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification.n_GetMsgType));
      return Notification.cb_getMsgType;
    }

    private static IntPtr n_GetMsgType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification>(jnienv, native__this, (JniHandleOwnership) 0).MsgType);
    }

    public virtual unsafe MSG_TYPE? MsgType
    {
      [Register("getMsgType", "()Lcom/zebra/ASCII_SDK/MSG_TYPE;", "GetGetMsgTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getMsgType.()Lcom/zebra/ASCII_SDK/MSG_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification.cb_getNotificationType == null)
        Notification.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification.n_GetNotificationType));
      return Notification.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public abstract NOTIFICATION_TYPE? NotificationType { [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get; }
  }
}
