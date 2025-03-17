// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification_TriggerEvent
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
  [Register("com/zebra/ASCII_SDK/Notification_TriggerEvent", DoNotGenerateAcw = true)]
  public class Notification_TriggerEvent : Notification
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification_TriggerEvent", typeof (Notification_TriggerEvent));
    private static Delegate? cb_getNotificationType;

    [Register("TriggerType")]
    public ENUM_TRIGGER_TYPE? TriggerType
    {
      get
      {
        JniObjectReference objectValue = Notification_TriggerEvent._members.InstanceFields.GetObjectValue("TriggerType.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Notification_TriggerEvent._members.InstanceFields.SetValue("TriggerType.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TriggerValue")]
    public ENUM_TRIGGER_ID? TriggerValue
    {
      get
      {
        JniObjectReference objectValue = Notification_TriggerEvent._members.InstanceFields.GetObjectValue("TriggerValue.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Notification_TriggerEvent._members.InstanceFields.SetValue("TriggerValue.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification_TriggerEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Notification_TriggerEvent._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification_TriggerEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Notification_TriggerEvent._members.ManagedPeerType;

    protected Notification_TriggerEvent(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification_TriggerEvent()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification_TriggerEvent._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification_TriggerEvent._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification_TriggerEvent.cb_getNotificationType == null)
        Notification_TriggerEvent.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification_TriggerEvent.n_GetNotificationType));
      return Notification_TriggerEvent.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification_TriggerEvent>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public override unsafe NOTIFICATION_TYPE? NotificationType
    {
      [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification_TriggerEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationType.()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_TriggerEvent;", "")]
    public static unsafe Notification_TriggerEvent? FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Notification_TriggerEvent._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_TriggerEvent;", jniArgumentValuePtr);
        return Object.GetObject<Notification_TriggerEvent>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
