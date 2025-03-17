// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.StopTrigger
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
  [Register("com/zebra/rfid/api3/StopTrigger", DoNotGenerateAcw = true)]
  public class StopTrigger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/StopTrigger", typeof (StopTrigger));
    private static Delegate? cb_getDurationMilliSeconds;
    private static Delegate? cb_setDurationMilliSeconds_I;
    private static Delegate? cb_getTriggerType;
    private static Delegate? cb_setTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_;

    [Register("AccessCount")]
    public TriggerWithTimeout? AccessCount
    {
      get
      {
        JniObjectReference objectValue = StopTrigger._members.InstanceFields.GetObjectValue("AccessCount.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this);
        return Object.GetObject<TriggerWithTimeout>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StopTrigger._members.InstanceFields.SetValue("AccessCount.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("GPI")]
    public IList<GPITrigger>? Gpi
    {
      get
      {
        JniObjectReference objectValue = StopTrigger._members.InstanceFields.GetObjectValue("GPI.[Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this);
        return (IList<GPITrigger>) JavaArray<GPITrigger>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<GPITrigger>.ToLocalJniHandle(value);
        try
        {
          StopTrigger._members.InstanceFields.SetValue("GPI.[Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = StopTrigger._members.InstanceFields.GetObjectValue("Handheld.Lcom/zebra/rfid/api3/HandheldTrigger;", (IJavaPeerable) this);
        return Object.GetObject<HandheldTrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StopTrigger._members.InstanceFields.SetValue("Handheld.Lcom/zebra/rfid/api3/HandheldTrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("NumAttempts")]
    public TriggerWithTimeout? NumAttempts
    {
      get
      {
        JniObjectReference objectValue = StopTrigger._members.InstanceFields.GetObjectValue("NumAttempts.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this);
        return Object.GetObject<TriggerWithTimeout>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StopTrigger._members.InstanceFields.SetValue("NumAttempts.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TagObservation")]
    public TriggerWithTimeout? TagObservation
    {
      get
      {
        JniObjectReference objectValue = StopTrigger._members.InstanceFields.GetObjectValue("TagObservation.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this);
        return Object.GetObject<TriggerWithTimeout>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          StopTrigger._members.InstanceFields.SetValue("TagObservation.Lcom/zebra/rfid/api3/TriggerWithTimeout;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = StopTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => StopTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = StopTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => StopTrigger._members.ManagedPeerType;

    protected StopTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe StopTrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = StopTrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      StopTrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetDurationMilliSecondsHandler()
    {
      if ((object) StopTrigger.cb_getDurationMilliSeconds == null)
        StopTrigger.cb_getDurationMilliSeconds = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(StopTrigger.n_GetDurationMilliSeconds));
      return StopTrigger.cb_getDurationMilliSeconds;
    }

    private static int n_GetDurationMilliSeconds(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<StopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DurationMilliSeconds;
    }

    private static Delegate GetSetDurationMilliSeconds_IHandler()
    {
      if ((object) StopTrigger.cb_setDurationMilliSeconds_I == null)
        StopTrigger.cb_setDurationMilliSeconds_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(StopTrigger.n_SetDurationMilliSeconds_I));
      return StopTrigger.cb_setDurationMilliSeconds_I;
    }

    private static void n_SetDurationMilliSeconds_I(
      IntPtr jnienv,
      IntPtr native__this,
      int duration)
    {
      Object.GetObject<StopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DurationMilliSeconds = duration;
    }

    public virtual unsafe int DurationMilliSeconds
    {
      [Register("getDurationMilliSeconds", "()I", "GetGetDurationMilliSecondsHandler")] get
      {
        return StopTrigger._members.InstanceMethods.InvokeVirtualInt32Method("getDurationMilliSeconds.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDurationMilliSeconds", "(I)V", "GetSetDurationMilliSeconds_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        StopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDurationMilliSeconds.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTriggerTypeHandler()
    {
      if ((object) StopTrigger.cb_getTriggerType == null)
        StopTrigger.cb_getTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(StopTrigger.n_GetTriggerType));
      return StopTrigger.cb_getTriggerType;
    }

    private static IntPtr n_GetTriggerType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<StopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType);
    }

    private static Delegate GetSetTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_Handler()
    {
      if ((object) StopTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_ == null)
        StopTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(StopTrigger.n_SetTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_));
      return StopTrigger.cb_setTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_;
    }

    private static void n_SetTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_triggerType)
    {
      Object.GetObject<StopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType = Object.GetObject<STOP_TRIGGER_TYPE>(native_triggerType, (JniHandleOwnership) 0);
    }

    public virtual unsafe STOP_TRIGGER_TYPE? TriggerType
    {
      [Register("getTriggerType", "()Lcom/zebra/rfid/api3/STOP_TRIGGER_TYPE;", "GetGetTriggerTypeHandler")] get
      {
        JniObjectReference jniObjectReference = StopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getTriggerType.()Lcom/zebra/rfid/api3/STOP_TRIGGER_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<STOP_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTriggerType", "(Lcom/zebra/rfid/api3/STOP_TRIGGER_TYPE;)V", "GetSetTriggerType_Lcom_zebra_rfid_api3_STOP_TRIGGER_TYPE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          StopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setTriggerType.(Lcom/zebra/rfid/api3/STOP_TRIGGER_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }
  }
}
