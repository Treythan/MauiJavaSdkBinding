// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.GPITrigger
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
  [Register("com/zebra/rfid/api3/GPITrigger", DoNotGenerateAcw = true)]
  public class GPITrigger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/GPITrigger", typeof (GPITrigger));
    private static Delegate? cb_getDebounceTime;
    private static Delegate? cb_setDebounceTime_I;
    private static Delegate? cb_isGPIEvent;
    private static Delegate? cb_setGPIEvent_Z;
    private static Delegate? cb_getGpi_signal;
    private static Delegate? cb_setGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_;
    private static Delegate? cb_getPortNumber;
    private static Delegate? cb_setPortNumber_I;
    private static Delegate? cb_getSinal;
    private static Delegate? cb_getTimeout;
    private static Delegate? cb_setTimeout_I;
    private static Delegate? cb_setSignal_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = GPITrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => GPITrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = GPITrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => GPITrigger._members.ManagedPeerType;

    protected GPITrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe GPITrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = GPITrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      GPITrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetDebounceTimeHandler()
    {
      if ((object) GPITrigger.cb_getDebounceTime == null)
        GPITrigger.cb_getDebounceTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GPITrigger.n_GetDebounceTime));
      return GPITrigger.cb_getDebounceTime;
    }

    private static int n_GetDebounceTime(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).DebounceTime;
    }

    private static Delegate GetSetDebounceTime_IHandler()
    {
      if ((object) GPITrigger.cb_setDebounceTime_I == null)
        GPITrigger.cb_setDebounceTime_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(GPITrigger.n_SetDebounceTime_I));
      return GPITrigger.cb_setDebounceTime_I;
    }

    private static void n_SetDebounceTime_I(IntPtr jnienv, IntPtr native__this, int debounceTime)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).DebounceTime = debounceTime;
    }

    public virtual unsafe int DebounceTime
    {
      [Register("getDebounceTime", "()I", "GetGetDebounceTimeHandler")] get
      {
        return GPITrigger._members.InstanceMethods.InvokeVirtualInt32Method("getDebounceTime.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDebounceTime", "(I)V", "GetSetDebounceTime_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDebounceTime.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsGPIEventHandler()
    {
      if ((object) GPITrigger.cb_isGPIEvent == null)
        GPITrigger.cb_isGPIEvent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(GPITrigger.n_IsGPIEvent));
      return GPITrigger.cb_isGPIEvent;
    }

    private static bool n_IsGPIEvent(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).GPIEvent;
    }

    private static Delegate GetSetGPIEvent_ZHandler()
    {
      if ((object) GPITrigger.cb_setGPIEvent_Z == null)
        GPITrigger.cb_setGPIEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(GPITrigger.n_SetGPIEvent_Z));
      return GPITrigger.cb_setGPIEvent_Z;
    }

    private static void n_SetGPIEvent_Z(IntPtr jnienv, IntPtr native__this, bool m_bGPIEvent)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).GPIEvent = m_bGPIEvent;
    }

    public virtual unsafe bool GPIEvent
    {
      [Register("isGPIEvent", "()Z", "GetIsGPIEventHandler")] get
      {
        return GPITrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("isGPIEvent.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setGPIEvent", "(Z)V", "GetSetGPIEvent_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setGPIEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetGpi_signalHandler()
    {
      if ((object) GPITrigger.cb_getGpi_signal == null)
        GPITrigger.cb_getGpi_signal = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(GPITrigger.n_GetGpi_signal));
      return GPITrigger.cb_getGpi_signal;
    }

    private static IntPtr n_GetGpi_signal(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).Gpi_signal);
    }

    private static Delegate GetSetGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_Handler()
    {
      if ((object) GPITrigger.cb_setGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_ == null)
        GPITrigger.cb_setGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(GPITrigger.n_SetGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_));
      return GPITrigger.cb_setGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_;
    }

    private static void n_SetGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_gpi_signal)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).Gpi_signal = Object.GetObject<GPITrigger.GPI_SIGNAL>(native_gpi_signal, (JniHandleOwnership) 0);
    }

    public virtual unsafe GPITrigger.GPI_SIGNAL? Gpi_signal
    {
      [Register("getGpi_signal", "()Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;", "GetGetGpi_signalHandler")] get
      {
        JniObjectReference jniObjectReference = GPITrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getGpi_signal.()Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<GPITrigger.GPI_SIGNAL>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setGpi_signal", "(Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;)V", "GetSetGpi_signal_Lcom_zebra_rfid_api3_GPITrigger_GPI_SIGNAL_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setGpi_signal.(Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetPortNumberHandler()
    {
      if ((object) GPITrigger.cb_getPortNumber == null)
        GPITrigger.cb_getPortNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GPITrigger.n_GetPortNumber));
      return GPITrigger.cb_getPortNumber;
    }

    private static int n_GetPortNumber(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).PortNumber;
    }

    private static Delegate GetSetPortNumber_IHandler()
    {
      if ((object) GPITrigger.cb_setPortNumber_I == null)
        GPITrigger.cb_setPortNumber_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(GPITrigger.n_SetPortNumber_I));
      return GPITrigger.cb_setPortNumber_I;
    }

    private static void n_SetPortNumber_I(IntPtr jnienv, IntPtr native__this, int gpiPortNumber)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).PortNumber = gpiPortNumber;
    }

    public virtual unsafe int PortNumber
    {
      [Register("getPortNumber", "()I", "GetGetPortNumberHandler")] get
      {
        return GPITrigger._members.InstanceMethods.InvokeVirtualInt32Method("getPortNumber.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPortNumber", "(I)V", "GetSetPortNumber_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setPortNumber.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetSinalHandler()
    {
      if ((object) GPITrigger.cb_getSinal == null)
        GPITrigger.cb_getSinal = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(GPITrigger.n_GetSinal));
      return GPITrigger.cb_getSinal;
    }

    private static bool n_GetSinal(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).Sinal;
    }

    public virtual unsafe bool Sinal
    {
      [Register("getSinal", "()Z", "GetGetSinalHandler")] get
      {
        return GPITrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getSinal.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTimeoutHandler()
    {
      if ((object) GPITrigger.cb_getTimeout == null)
        GPITrigger.cb_getTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GPITrigger.n_GetTimeout));
      return GPITrigger.cb_getTimeout;
    }

    private static int n_GetTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).Timeout;
    }

    private static Delegate GetSetTimeout_IHandler()
    {
      if ((object) GPITrigger.cb_setTimeout_I == null)
        GPITrigger.cb_setTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(GPITrigger.n_SetTimeout_I));
      return GPITrigger.cb_setTimeout_I;
    }

    private static void n_SetTimeout_I(IntPtr jnienv, IntPtr native__this, int m_nGPITimeout)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).Timeout = m_nGPITimeout;
    }

    public virtual unsafe int Timeout
    {
      [Register("getTimeout", "()I", "GetGetTimeoutHandler")] get
      {
        return GPITrigger._members.InstanceMethods.InvokeVirtualInt32Method("getTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTimeout", "(I)V", "GetSetTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetSetSignal_ZHandler()
    {
      if ((object) GPITrigger.cb_setSignal_Z == null)
        GPITrigger.cb_setSignal_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(GPITrigger.n_SetSignal_Z));
      return GPITrigger.cb_setSignal_Z;
    }

    private static void n_SetSignal_Z(IntPtr jnienv, IntPtr native__this, bool signal)
    {
      Object.GetObject<GPITrigger>(jnienv, native__this, (JniHandleOwnership) 0).SetSignal(signal);
    }

    [Register("setSignal", "(Z)V", "GetSetSignal_ZHandler")]
    public virtual unsafe void SetSignal(bool signal)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(signal)
      };
      GPITrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setSignal.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("com/zebra/rfid/api3/GPITrigger$GPI_SIGNAL", DoNotGenerateAcw = true)]
    public class GPI_SIGNAL : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/GPITrigger$GPI_SIGNAL", typeof (GPITrigger.GPI_SIGNAL));
      private static Delegate? cb_getValue;
      private static Delegate? cb_equals_I;

      [Register("GPI_SIGNAL_HIGH")]
      public static GPITrigger.GPI_SIGNAL? GpiSignalHigh
      {
        get
        {
          JniObjectReference objectValue = GPITrigger.GPI_SIGNAL._members.StaticFields.GetObjectValue("GPI_SIGNAL_HIGH.Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;");
          return Object.GetObject<GPITrigger.GPI_SIGNAL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("GPI_SIGNAL_LOW")]
      public static GPITrigger.GPI_SIGNAL? GpiSignalLow
      {
        get
        {
          JniObjectReference objectValue = GPITrigger.GPI_SIGNAL._members.StaticFields.GetObjectValue("GPI_SIGNAL_LOW.Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;");
          return Object.GetObject<GPITrigger.GPI_SIGNAL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("ordinal")]
      public int Ordinal
      {
        get
        {
          return GPITrigger.GPI_SIGNAL._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
        }
        set
        {
          GPITrigger.GPI_SIGNAL._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = GPITrigger.GPI_SIGNAL._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => GPITrigger.GPI_SIGNAL._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = GPITrigger.GPI_SIGNAL._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => GPITrigger.GPI_SIGNAL._members.ManagedPeerType;

      protected GPI_SIGNAL(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetValueHandler()
      {
        if ((object) GPITrigger.GPI_SIGNAL.cb_getValue == null)
          GPITrigger.GPI_SIGNAL.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GPITrigger.GPI_SIGNAL.n_GetValue));
        return GPITrigger.GPI_SIGNAL.cb_getValue;
      }

      private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<GPITrigger.GPI_SIGNAL>(jnienv, native__this, (JniHandleOwnership) 0).Value;
      }

      public virtual unsafe int Value
      {
        [Register("getValue", "()I", "GetGetValueHandler")] get
        {
          return GPITrigger.GPI_SIGNAL._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      [Register("GetGPISignalTypeValue", "(I)Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;", "")]
      public static unsafe GPITrigger.GPI_SIGNAL? GetGPISignalTypeValue(int value)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        JniObjectReference jniObjectReference = GPITrigger.GPI_SIGNAL._members.StaticMethods.InvokeObjectMethod("GetGPISignalTypeValue.(I)Lcom/zebra/rfid/api3/GPITrigger$GPI_SIGNAL;", jniArgumentValuePtr);
        return Object.GetObject<GPITrigger.GPI_SIGNAL>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }

      private static Delegate GetEquals_IHandler()
      {
        if ((object) GPITrigger.GPI_SIGNAL.cb_equals_I == null)
          GPITrigger.GPI_SIGNAL.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(GPITrigger.GPI_SIGNAL.n_Equals_I));
        return GPITrigger.GPI_SIGNAL.cb_equals_I;
      }

      private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
      {
        return Object.GetObject<GPITrigger.GPI_SIGNAL>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
      }

      [Register("equals", "(I)Z", "GetEquals_IHandler")]
      public virtual unsafe bool Equals(int val)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(val)
        };
        return GPITrigger.GPI_SIGNAL._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
