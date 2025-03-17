// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.StartTrigger
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/StartTrigger", DoNotGenerateAcw = true)]
  public class StartTrigger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/StartTrigger", typeof (StartTrigger));
    private static Delegate? cb_getTriggerType;
    private static Delegate? cb_setTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_;

    [Register("GPI")]
    public IList<GPITrigger>? Gpi
    {
      get
      {
        JniObjectReference objectValue = StartTrigger._members.InstanceFields.GetObjectValue("GPI.[Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this);
        return (IList<GPITrigger>) JavaArray<GPITrigger>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<GPITrigger>.ToLocalJniHandle(value);
        try
        {
          StartTrigger._members.InstanceFields.SetValue("GPI.[Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Handheld")]
    public HandheldTrigger? Handheld
    {
      get
      {
        JniObjectReference objectValue = StartTrigger._members.InstanceFields.GetObjectValue("Handheld.Lcom/zebra/rfid/api3/HandheldTrigger;", (IJavaPeerable) this);
        return Object.GetObject<HandheldTrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StartTrigger._members.InstanceFields.SetValue("Handheld.Lcom/zebra/rfid/api3/HandheldTrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Periodic")]
    public PeriodicTrigger? Periodic
    {
      get
      {
        JniObjectReference objectValue = StartTrigger._members.InstanceFields.GetObjectValue("Periodic.Lcom/zebra/rfid/api3/PeriodicTrigger;", (IJavaPeerable) this);
        return Object.GetObject<PeriodicTrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StartTrigger._members.InstanceFields.SetValue("Periodic.Lcom/zebra/rfid/api3/PeriodicTrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = StartTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => StartTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = StartTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => StartTrigger._members.ManagedPeerType;

    protected StartTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe StartTrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = StartTrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      StartTrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetTriggerTypeHandler()
    {
      if ((object) StartTrigger.cb_getTriggerType == null)
        StartTrigger.cb_getTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(StartTrigger.n_GetTriggerType));
      return StartTrigger.cb_getTriggerType;
    }

    private static IntPtr n_GetTriggerType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<StartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType);
    }

    private static Delegate GetSetTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_Handler()
    {
      if ((object) StartTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_ == null)
        StartTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(StartTrigger.n_SetTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_));
      return StartTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_;
    }

    private static void n_SetTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_triggerType)
    {
      Object.GetObject<StartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType = Object.GetObject<START_TRIGGER_TYPE>(native_triggerType, (JniHandleOwnership) 0);
    }

    public virtual unsafe START_TRIGGER_TYPE? TriggerType
    {
      [Register("getTriggerType", "()Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;", "GetGetTriggerTypeHandler")] get
      {
        JniObjectReference jniObjectReference = StartTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getTriggerType.()Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTriggerType", "(Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;)V", "GetSetTriggerType_Lcom_zebra_rfid_api3_START_TRIGGER_TYPE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          StartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setTriggerType.(Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }
  }
}
