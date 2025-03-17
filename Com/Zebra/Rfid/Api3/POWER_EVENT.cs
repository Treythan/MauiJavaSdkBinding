// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.POWER_EVENT
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
  [Register("com/zebra/rfid/api3/POWER_EVENT", DoNotGenerateAcw = true)]
  public class POWER_EVENT : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/POWER_EVENT", typeof (POWER_EVENT));
    private static Delegate? cb_getCause;
    private static Delegate? cb_setCause_Ljava_lang_String_;
    private static Delegate? cb_getCurrent;
    private static Delegate? cb_setCurrent_F;
    private static Delegate? cb_getPower;
    private static Delegate? cb_setPower_F;
    private static Delegate? cb_getVoltage;
    private static Delegate? cb_setVoltage_F;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = POWER_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => POWER_EVENT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = POWER_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => POWER_EVENT._members.ManagedPeerType;

    protected POWER_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe POWER_EVENT()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = POWER_EVENT._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      POWER_EVENT._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCauseHandler()
    {
      if ((object) POWER_EVENT.cb_getCause == null)
        POWER_EVENT.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(POWER_EVENT.n_GetCause));
      return POWER_EVENT.cb_getCause;
    }

    private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
    }

    private static Delegate GetSetCause_Ljava_lang_String_Handler()
    {
      if ((object) POWER_EVENT.cb_setCause_Ljava_lang_String_ == null)
        POWER_EVENT.cb_setCause_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(POWER_EVENT.n_SetCause_Ljava_lang_String_));
      return POWER_EVENT.cb_setCause_Ljava_lang_String_;
    }

    private static void n_SetCause_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cause)
    {
      Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Cause = JNIEnv.GetString(native_cause, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Cause
    {
      [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
      {
        JniObjectReference jniObjectReference = POWER_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setCause", "(Ljava/lang/String;)V", "GetSetCause_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          POWER_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setCause.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetCurrentHandler()
    {
      if ((object) POWER_EVENT.cb_getCurrent == null)
        POWER_EVENT.cb_getCurrent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(POWER_EVENT.n_GetCurrent));
      return POWER_EVENT.cb_getCurrent;
    }

    private static float n_GetCurrent(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Current;
    }

    private static Delegate GetSetCurrent_FHandler()
    {
      if ((object) POWER_EVENT.cb_setCurrent_F == null)
        POWER_EVENT.cb_setCurrent_F = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPF_V(POWER_EVENT.n_SetCurrent_F));
      return POWER_EVENT.cb_setCurrent_F;
    }

    private static void n_SetCurrent_F(IntPtr jnienv, IntPtr native__this, float current)
    {
      Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Current = current;
    }

    public virtual unsafe float Current
    {
      [Register("getCurrent", "()F", "GetGetCurrentHandler")] get
      {
        return POWER_EVENT._members.InstanceMethods.InvokeVirtualSingleMethod("getCurrent.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCurrent", "(F)V", "GetSetCurrent_FHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        POWER_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrent.(F)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerHandler()
    {
      if ((object) POWER_EVENT.cb_getPower == null)
        POWER_EVENT.cb_getPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(POWER_EVENT.n_GetPower));
      return POWER_EVENT.cb_getPower;
    }

    private static float n_GetPower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Power;
    }

    private static Delegate GetSetPower_FHandler()
    {
      if ((object) POWER_EVENT.cb_setPower_F == null)
        POWER_EVENT.cb_setPower_F = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPF_V(POWER_EVENT.n_SetPower_F));
      return POWER_EVENT.cb_setPower_F;
    }

    private static void n_SetPower_F(IntPtr jnienv, IntPtr native__this, float power)
    {
      Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Power = power;
    }

    public virtual unsafe float Power
    {
      [Register("getPower", "()F", "GetGetPowerHandler")] get
      {
        return POWER_EVENT._members.InstanceMethods.InvokeVirtualSingleMethod("getPower.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPower", "(F)V", "GetSetPower_FHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        POWER_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setPower.(F)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetVoltageHandler()
    {
      if ((object) POWER_EVENT.cb_getVoltage == null)
        POWER_EVENT.cb_getVoltage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(POWER_EVENT.n_GetVoltage));
      return POWER_EVENT.cb_getVoltage;
    }

    private static float n_GetVoltage(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Voltage;
    }

    private static Delegate GetSetVoltage_FHandler()
    {
      if ((object) POWER_EVENT.cb_setVoltage_F == null)
        POWER_EVENT.cb_setVoltage_F = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPF_V(POWER_EVENT.n_SetVoltage_F));
      return POWER_EVENT.cb_setVoltage_F;
    }

    private static void n_SetVoltage_F(IntPtr jnienv, IntPtr native__this, float voltage)
    {
      Object.GetObject<POWER_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Voltage = voltage;
    }

    public virtual unsafe float Voltage
    {
      [Register("getVoltage", "()F", "GetGetVoltageHandler")] get
      {
        return POWER_EVENT._members.InstanceMethods.InvokeVirtualSingleMethod("getVoltage.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setVoltage", "(F)V", "GetSetVoltage_FHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        POWER_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setVoltage.(F)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
