// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification_PowerEvent
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
  [Register("com/zebra/ASCII_SDK/Notification_PowerEvent", DoNotGenerateAcw = true)]
  public class Notification_PowerEvent : Notification
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification_PowerEvent", typeof (Notification_PowerEvent));
    private static Delegate? cb_getNotificationType;

    [Register("Cause")]
    public string? Cause
    {
      get
      {
        JniObjectReference objectValue = Notification_PowerEvent._members.InstanceFields.GetObjectValue("Cause.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Notification_PowerEvent._members.InstanceFields.SetValue("Cause.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("Current")]
    public float Current
    {
      get
      {
        return Notification_PowerEvent._members.InstanceFields.GetSingleValue("Current.F", (IJavaPeerable) this);
      }
      set
      {
        Notification_PowerEvent._members.InstanceFields.SetValue("Current.F", (IJavaPeerable) this, value);
      }
    }

    [Register("Power")]
    public float Power
    {
      get
      {
        return Notification_PowerEvent._members.InstanceFields.GetSingleValue("Power.F", (IJavaPeerable) this);
      }
      set
      {
        Notification_PowerEvent._members.InstanceFields.SetValue("Power.F", (IJavaPeerable) this, value);
      }
    }

    [Register("Voltage")]
    public float Voltage
    {
      get
      {
        return Notification_PowerEvent._members.InstanceFields.GetSingleValue("Voltage.F", (IJavaPeerable) this);
      }
      set
      {
        Notification_PowerEvent._members.InstanceFields.SetValue("Voltage.F", (IJavaPeerable) this, value);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification_PowerEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Notification_PowerEvent._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification_PowerEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Notification_PowerEvent._members.ManagedPeerType;

    protected Notification_PowerEvent(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification_PowerEvent()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification_PowerEvent._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification_PowerEvent._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification_PowerEvent.cb_getNotificationType == null)
        Notification_PowerEvent.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification_PowerEvent.n_GetNotificationType));
      return Notification_PowerEvent.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification_PowerEvent>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public override unsafe NOTIFICATION_TYPE? NotificationType
    {
      [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification_PowerEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationType.()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_PowerEvent;", "")]
    public static unsafe Notification_PowerEvent? FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Notification_PowerEvent._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_PowerEvent;", jniArgumentValuePtr);
        return Object.GetObject<Notification_PowerEvent>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
