// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification_OperEndSummary
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
  [Register("com/zebra/ASCII_SDK/Notification_OperEndSummary", DoNotGenerateAcw = true)]
  public class Notification_OperEndSummary : Notification
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification_OperEndSummary", typeof (Notification_OperEndSummary));
    private static Delegate? cb_getNotificationType;

    [Register("TotalRounds")]
    public int TotalRounds
    {
      get
      {
        return Notification_OperEndSummary._members.InstanceFields.GetInt32Value("TotalRounds.I", (IJavaPeerable) this);
      }
      set
      {
        Notification_OperEndSummary._members.InstanceFields.SetValue("TotalRounds.I", (IJavaPeerable) this, value);
      }
    }

    [Register("TotalTags")]
    public int TotalTags
    {
      get
      {
        return Notification_OperEndSummary._members.InstanceFields.GetInt32Value("TotalTags.I", (IJavaPeerable) this);
      }
      set
      {
        Notification_OperEndSummary._members.InstanceFields.SetValue("TotalTags.I", (IJavaPeerable) this, value);
      }
    }

    [Register("TotalTimeuS")]
    public long TotalTimeuS
    {
      get
      {
        return Notification_OperEndSummary._members.InstanceFields.GetInt64Value("TotalTimeuS.J", (IJavaPeerable) this);
      }
      set
      {
        Notification_OperEndSummary._members.InstanceFields.SetValue("TotalTimeuS.J", (IJavaPeerable) this, value);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification_OperEndSummary._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Notification_OperEndSummary._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification_OperEndSummary._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Notification_OperEndSummary._members.ManagedPeerType;

    protected Notification_OperEndSummary(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification_OperEndSummary()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification_OperEndSummary._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification_OperEndSummary._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification_OperEndSummary.cb_getNotificationType == null)
        Notification_OperEndSummary.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification_OperEndSummary.n_GetNotificationType));
      return Notification_OperEndSummary.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification_OperEndSummary>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public override unsafe NOTIFICATION_TYPE? NotificationType
    {
      [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification_OperEndSummary._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationType.()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_OperEndSummary;", "")]
    public static unsafe Notification_OperEndSummary? FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Notification_OperEndSummary._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_OperEndSummary;", jniArgumentValuePtr);
        return Object.GetObject<Notification_OperEndSummary>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
