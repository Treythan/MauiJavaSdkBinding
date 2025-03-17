// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification_BatteryEvent
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
  [Register("com/zebra/ASCII_SDK/Notification_BatteryEvent", DoNotGenerateAcw = true)]
  public class Notification_BatteryEvent : Notification
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification_BatteryEvent", typeof (Notification_BatteryEvent));
    private static Delegate? cb_getNotificationType;

    [Register("Cause")]
    public string? Cause
    {
      get
      {
        JniObjectReference objectValue = Notification_BatteryEvent._members.InstanceFields.GetObjectValue("Cause.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Notification_BatteryEvent._members.InstanceFields.SetValue("Cause.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("Charging")]
    public bool Charging
    {
      get
      {
        return Notification_BatteryEvent._members.InstanceFields.GetBooleanValue("Charging.Z", (IJavaPeerable) this);
      }
      set
      {
        Notification_BatteryEvent._members.InstanceFields.SetValue("Charging.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("Level")]
    public int Level
    {
      get
      {
        return Notification_BatteryEvent._members.InstanceFields.GetInt32Value("Level.I", (IJavaPeerable) this);
      }
      set
      {
        Notification_BatteryEvent._members.InstanceFields.SetValue("Level.I", (IJavaPeerable) this, value);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification_BatteryEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Notification_BatteryEvent._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification_BatteryEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Notification_BatteryEvent._members.ManagedPeerType;

    protected Notification_BatteryEvent(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification_BatteryEvent()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification_BatteryEvent._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification_BatteryEvent._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification_BatteryEvent.cb_getNotificationType == null)
        Notification_BatteryEvent.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification_BatteryEvent.n_GetNotificationType));
      return Notification_BatteryEvent.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification_BatteryEvent>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public override unsafe NOTIFICATION_TYPE? NotificationType
    {
      [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification_BatteryEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationType.()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_BatteryEvent;", "")]
    public static unsafe Notification_BatteryEvent? FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Notification_BatteryEvent._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_BatteryEvent;", jniArgumentValuePtr);
        return Object.GetObject<Notification_BatteryEvent>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
