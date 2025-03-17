// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Notification_DatabaseEvent
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
  [Register("com/zebra/ASCII_SDK/Notification_DatabaseEvent", DoNotGenerateAcw = true)]
  public class Notification_DatabaseEvent : Notification
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Notification_DatabaseEvent", typeof (Notification_DatabaseEvent));
    private static Delegate? cb_getNotificationType;

    [Register("DatabaseEvent")]
    public string? DatabaseEvent
    {
      get
      {
        JniObjectReference objectValue = Notification_DatabaseEvent._members.InstanceFields.GetObjectValue("DatabaseEvent.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Notification_DatabaseEvent._members.InstanceFields.SetValue("DatabaseEvent.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("EntriesRemaining")]
    public int EntriesRemaining
    {
      get
      {
        return Notification_DatabaseEvent._members.InstanceFields.GetInt32Value("EntriesRemaining.I", (IJavaPeerable) this);
      }
      set
      {
        Notification_DatabaseEvent._members.InstanceFields.SetValue("EntriesRemaining.I", (IJavaPeerable) this, value);
      }
    }

    [Register("EntriesUsed")]
    public int EntriesUsed
    {
      get
      {
        return Notification_DatabaseEvent._members.InstanceFields.GetInt32Value("EntriesUsed.I", (IJavaPeerable) this);
      }
      set
      {
        Notification_DatabaseEvent._members.InstanceFields.SetValue("EntriesUsed.I", (IJavaPeerable) this, value);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Notification_DatabaseEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Notification_DatabaseEvent._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Notification_DatabaseEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Notification_DatabaseEvent._members.ManagedPeerType;

    protected Notification_DatabaseEvent(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Notification_DatabaseEvent()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Notification_DatabaseEvent._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Notification_DatabaseEvent._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNotificationTypeHandler()
    {
      if ((object) Notification_DatabaseEvent.cb_getNotificationType == null)
        Notification_DatabaseEvent.cb_getNotificationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Notification_DatabaseEvent.n_GetNotificationType));
      return Notification_DatabaseEvent.cb_getNotificationType;
    }

    private static IntPtr n_GetNotificationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Notification_DatabaseEvent>(jnienv, native__this, (JniHandleOwnership) 0).NotificationType);
    }

    public override unsafe NOTIFICATION_TYPE? NotificationType
    {
      [Register("getNotificationType", "()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "GetGetNotificationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Notification_DatabaseEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationType.()Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_DatabaseEvent;", "")]
    public static unsafe Notification_DatabaseEvent? FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Notification_DatabaseEvent._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/Notification_DatabaseEvent;", jniArgumentValuePtr);
        return Object.GetObject<Notification_DatabaseEvent>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
