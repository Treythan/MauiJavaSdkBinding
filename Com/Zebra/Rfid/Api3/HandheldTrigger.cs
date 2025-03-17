// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.HandheldTrigger
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
  [Register("com/zebra/rfid/api3/HandheldTrigger", DoNotGenerateAcw = true)]
  public class HandheldTrigger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/HandheldTrigger", typeof (HandheldTrigger));
    private static Delegate? cb_getHandheldTriggerEvent;
    private static Delegate? cb_setHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_;
    private static Delegate? cb_getHandheldTriggerTimeout;
    private static Delegate? cb_setHandheldTriggerTimeout_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = HandheldTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => HandheldTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = HandheldTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => HandheldTrigger._members.ManagedPeerType;

    protected HandheldTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe HandheldTrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = HandheldTrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      HandheldTrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetHandheldTriggerEventHandler()
    {
      if ((object) HandheldTrigger.cb_getHandheldTriggerEvent == null)
        HandheldTrigger.cb_getHandheldTriggerEvent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(HandheldTrigger.n_GetHandheldTriggerEvent));
      return HandheldTrigger.cb_getHandheldTriggerEvent;
    }

    private static IntPtr n_GetHandheldTriggerEvent(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<HandheldTrigger>(jnienv, native__this, (JniHandleOwnership) 0).HandheldTriggerEvent);
    }

    private static Delegate GetSetHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_Handler()
    {
      if ((object) HandheldTrigger.cb_setHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_ == null)
        HandheldTrigger.cb_setHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(HandheldTrigger.n_SetHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_));
      return HandheldTrigger.cb_setHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_;
    }

    private static void n_SetHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_handheldTriggerEvent)
    {
      Object.GetObject<HandheldTrigger>(jnienv, native__this, (JniHandleOwnership) 0).HandheldTriggerEvent = Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(native_handheldTriggerEvent, (JniHandleOwnership) 0);
    }

    public virtual unsafe HANDHELD_TRIGGER_EVENT_TYPE? HandheldTriggerEvent
    {
      [Register("getHandheldTriggerEvent", "()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", "GetGetHandheldTriggerEventHandler")] get
      {
        JniObjectReference jniObjectReference = HandheldTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getHandheldTriggerEvent.()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHandheldTriggerEvent", "(Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;)V", "GetSetHandheldTriggerEvent_Lcom_zebra_rfid_api3_HANDHELD_TRIGGER_EVENT_TYPE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          HandheldTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setHandheldTriggerEvent.(Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetHandheldTriggerTimeoutHandler()
    {
      if ((object) HandheldTrigger.cb_getHandheldTriggerTimeout == null)
        HandheldTrigger.cb_getHandheldTriggerTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(HandheldTrigger.n_GetHandheldTriggerTimeout));
      return HandheldTrigger.cb_getHandheldTriggerTimeout;
    }

    private static int n_GetHandheldTriggerTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<HandheldTrigger>(jnienv, native__this, (JniHandleOwnership) 0).HandheldTriggerTimeout;
    }

    private static Delegate GetSetHandheldTriggerTimeout_IHandler()
    {
      if ((object) HandheldTrigger.cb_setHandheldTriggerTimeout_I == null)
        HandheldTrigger.cb_setHandheldTriggerTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(HandheldTrigger.n_SetHandheldTriggerTimeout_I));
      return HandheldTrigger.cb_setHandheldTriggerTimeout_I;
    }

    private static void n_SetHandheldTriggerTimeout_I(
      IntPtr jnienv,
      IntPtr native__this,
      int handheldTriggerTimeout)
    {
      Object.GetObject<HandheldTrigger>(jnienv, native__this, (JniHandleOwnership) 0).HandheldTriggerTimeout = handheldTriggerTimeout;
    }

    public virtual unsafe int HandheldTriggerTimeout
    {
      [Register("getHandheldTriggerTimeout", "()I", "GetGetHandheldTriggerTimeoutHandler")] get
      {
        return HandheldTrigger._members.InstanceMethods.InvokeVirtualInt32Method("getHandheldTriggerTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setHandheldTriggerTimeout", "(I)V", "GetSetHandheldTriggerTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        HandheldTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setHandheldTriggerTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
