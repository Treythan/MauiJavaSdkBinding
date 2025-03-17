// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BatteryStatistics
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
  [Register("com/zebra/rfid/api3/BatteryStatistics", DoNotGenerateAcw = true)]
  public class BatteryStatistics : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BatteryStatistics", typeof (BatteryStatistics));
    private static Delegate? cb_getBatteryId;
    private static Delegate? cb_setBatteryId_Ljava_lang_String_;
    private static Delegate? cb_getChargeStatus;
    private static Delegate? cb_setChargeStatus_I;
    private static Delegate? cb_getCharging;
    private static Delegate? cb_setCharging_I;
    private static Delegate? cb_getCriticalLevel;
    private static Delegate? cb_setCriticalLevel_I;
    private static Delegate? cb_getCurrent;
    private static Delegate? cb_setCurrent_I;
    private static Delegate? cb_getCurrentState;
    private static Delegate? cb_setCurrentState_Ljava_lang_String_;
    private static Delegate? cb_getCycleCount;
    private static Delegate? cb_setCycleCount_I;
    private static Delegate? cb_getDesignCapacity;
    private static Delegate? cb_setDesignCapacity_I;
    private static Delegate? cb_getFullChargeCapacity;
    private static Delegate? cb_setFullChargeCapacity_I;
    private static Delegate? cb_getHealth;
    private static Delegate? cb_setHealth_I;
    private static Delegate? cb_getHealthState;
    private static Delegate? cb_setHealthState_Ljava_lang_String_;
    private static Delegate? cb_getManufactureDate;
    private static Delegate? cb_setManufactureDate_Ljava_lang_String_;
    private static Delegate? cb_getModelNumber;
    private static Delegate? cb_setModelNumber_Ljava_lang_String_;
    private static Delegate? cb_getPercentage;
    private static Delegate? cb_setPercentage_I;
    private static Delegate? cb_getPowerSourceType;
    private static Delegate? cb_setPowerSourceType_Ljava_lang_String_;
    private static Delegate? cb_getRemainingCapacity;
    private static Delegate? cb_setRemainingCapacity_I;
    private static Delegate? cb_getSerialNumber;
    private static Delegate? cb_setSerialNumber_I;
    private static Delegate? cb_getStatus;
    private static Delegate? cb_setStatus_I;
    private static Delegate? cb_getTemperature;
    private static Delegate? cb_setTemperature_I;
    private static Delegate? cb_getTimeToFullCharge;
    private static Delegate? cb_setTimeToFullCharge_I;
    private static Delegate? cb_getVoltage;
    private static Delegate? cb_setVoltage_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BatteryStatistics._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BatteryStatistics._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BatteryStatistics._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BatteryStatistics._members.ManagedPeerType;

    protected BatteryStatistics(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BatteryStatistics()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BatteryStatistics._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BatteryStatistics._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBatteryIdHandler()
    {
      if ((object) BatteryStatistics.cb_getBatteryId == null)
        BatteryStatistics.cb_getBatteryId = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetBatteryId));
      return BatteryStatistics.cb_getBatteryId;
    }

    private static IntPtr n_GetBatteryId(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BatteryId);
    }

    private static Delegate GetSetBatteryId_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setBatteryId_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setBatteryId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetBatteryId_Ljava_lang_String_));
      return BatteryStatistics.cb_setBatteryId_Ljava_lang_String_;
    }

    private static void n_SetBatteryId_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_batteryId)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BatteryId = JNIEnv.GetString(native_batteryId, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? BatteryId
    {
      [Register("getBatteryId", "()Ljava/lang/String;", "GetGetBatteryIdHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getBatteryId.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setBatteryId", "(Ljava/lang/String;)V", "GetSetBatteryId_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setBatteryId.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetChargeStatusHandler()
    {
      if ((object) BatteryStatistics.cb_getChargeStatus == null)
        BatteryStatistics.cb_getChargeStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetChargeStatus));
      return BatteryStatistics.cb_getChargeStatus;
    }

    private static int n_GetChargeStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ChargeStatus;
    }

    private static Delegate GetSetChargeStatus_IHandler()
    {
      if ((object) BatteryStatistics.cb_setChargeStatus_I == null)
        BatteryStatistics.cb_setChargeStatus_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetChargeStatus_I));
      return BatteryStatistics.cb_setChargeStatus_I;
    }

    private static void n_SetChargeStatus_I(IntPtr jnienv, IntPtr native__this, int chargeStatus)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ChargeStatus = chargeStatus;
    }

    public virtual unsafe int ChargeStatus
    {
      [Register("getChargeStatus", "()I", "GetGetChargeStatusHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getChargeStatus.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setChargeStatus", "(I)V", "GetSetChargeStatus_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setChargeStatus.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetChargingHandler()
    {
      if ((object) BatteryStatistics.cb_getCharging == null)
        BatteryStatistics.cb_getCharging = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetCharging));
      return BatteryStatistics.cb_getCharging;
    }

    private static int n_GetCharging(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Charging;
    }

    private static Delegate GetSetCharging_IHandler()
    {
      if ((object) BatteryStatistics.cb_setCharging_I == null)
        BatteryStatistics.cb_setCharging_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetCharging_I));
      return BatteryStatistics.cb_setCharging_I;
    }

    private static void n_SetCharging_I(IntPtr jnienv, IntPtr native__this, int charging)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Charging = charging;
    }

    public virtual unsafe int Charging
    {
      [Register("getCharging", "()I", "GetGetChargingHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getCharging.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCharging", "(I)V", "GetSetCharging_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setCharging.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCriticalLevelHandler()
    {
      if ((object) BatteryStatistics.cb_getCriticalLevel == null)
        BatteryStatistics.cb_getCriticalLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetCriticalLevel));
      return BatteryStatistics.cb_getCriticalLevel;
    }

    private static int n_GetCriticalLevel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CriticalLevel;
    }

    private static Delegate GetSetCriticalLevel_IHandler()
    {
      if ((object) BatteryStatistics.cb_setCriticalLevel_I == null)
        BatteryStatistics.cb_setCriticalLevel_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetCriticalLevel_I));
      return BatteryStatistics.cb_setCriticalLevel_I;
    }

    private static void n_SetCriticalLevel_I(IntPtr jnienv, IntPtr native__this, int criticalLevel)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CriticalLevel = criticalLevel;
    }

    public virtual unsafe int CriticalLevel
    {
      [Register("getCriticalLevel", "()I", "GetGetCriticalLevelHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getCriticalLevel.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriticalLevel", "(I)V", "GetSetCriticalLevel_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setCriticalLevel.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCurrentHandler()
    {
      if ((object) BatteryStatistics.cb_getCurrent == null)
        BatteryStatistics.cb_getCurrent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetCurrent));
      return BatteryStatistics.cb_getCurrent;
    }

    private static int n_GetCurrent(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Current;
    }

    private static Delegate GetSetCurrent_IHandler()
    {
      if ((object) BatteryStatistics.cb_setCurrent_I == null)
        BatteryStatistics.cb_setCurrent_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetCurrent_I));
      return BatteryStatistics.cb_setCurrent_I;
    }

    private static void n_SetCurrent_I(IntPtr jnienv, IntPtr native__this, int current)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Current = current;
    }

    public virtual unsafe int Current
    {
      [Register("getCurrent", "()I", "GetGetCurrentHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getCurrent.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCurrent", "(I)V", "GetSetCurrent_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrent.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCurrentStateHandler()
    {
      if ((object) BatteryStatistics.cb_getCurrentState == null)
        BatteryStatistics.cb_getCurrentState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetCurrentState));
      return BatteryStatistics.cb_getCurrentState;
    }

    private static IntPtr n_GetCurrentState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CurrentState);
    }

    private static Delegate GetSetCurrentState_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setCurrentState_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setCurrentState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetCurrentState_Ljava_lang_String_));
      return BatteryStatistics.cb_setCurrentState_Ljava_lang_String_;
    }

    private static void n_SetCurrentState_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_currentState)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CurrentState = JNIEnv.GetString(native_currentState, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? CurrentState
    {
      [Register("getCurrentState", "()Ljava/lang/String;", "GetGetCurrentStateHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentState.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setCurrentState", "(Ljava/lang/String;)V", "GetSetCurrentState_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrentState.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetCycleCountHandler()
    {
      if ((object) BatteryStatistics.cb_getCycleCount == null)
        BatteryStatistics.cb_getCycleCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetCycleCount));
      return BatteryStatistics.cb_getCycleCount;
    }

    private static int n_GetCycleCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CycleCount;
    }

    private static Delegate GetSetCycleCount_IHandler()
    {
      if ((object) BatteryStatistics.cb_setCycleCount_I == null)
        BatteryStatistics.cb_setCycleCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetCycleCount_I));
      return BatteryStatistics.cb_setCycleCount_I;
    }

    private static void n_SetCycleCount_I(IntPtr jnienv, IntPtr native__this, int cycleCount)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).CycleCount = cycleCount;
    }

    public virtual unsafe int CycleCount
    {
      [Register("getCycleCount", "()I", "GetGetCycleCountHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getCycleCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCycleCount", "(I)V", "GetSetCycleCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setCycleCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDesignCapacityHandler()
    {
      if ((object) BatteryStatistics.cb_getDesignCapacity == null)
        BatteryStatistics.cb_getDesignCapacity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetDesignCapacity));
      return BatteryStatistics.cb_getDesignCapacity;
    }

    private static int n_GetDesignCapacity(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).DesignCapacity;
    }

    private static Delegate GetSetDesignCapacity_IHandler()
    {
      if ((object) BatteryStatistics.cb_setDesignCapacity_I == null)
        BatteryStatistics.cb_setDesignCapacity_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetDesignCapacity_I));
      return BatteryStatistics.cb_setDesignCapacity_I;
    }

    private static void n_SetDesignCapacity_I(
      IntPtr jnienv,
      IntPtr native__this,
      int designCapacity)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).DesignCapacity = designCapacity;
    }

    public virtual unsafe int DesignCapacity
    {
      [Register("getDesignCapacity", "()I", "GetGetDesignCapacityHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getDesignCapacity.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDesignCapacity", "(I)V", "GetSetDesignCapacity_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setDesignCapacity.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetFullChargeCapacityHandler()
    {
      if ((object) BatteryStatistics.cb_getFullChargeCapacity == null)
        BatteryStatistics.cb_getFullChargeCapacity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetFullChargeCapacity));
      return BatteryStatistics.cb_getFullChargeCapacity;
    }

    private static int n_GetFullChargeCapacity(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).FullChargeCapacity;
    }

    private static Delegate GetSetFullChargeCapacity_IHandler()
    {
      if ((object) BatteryStatistics.cb_setFullChargeCapacity_I == null)
        BatteryStatistics.cb_setFullChargeCapacity_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetFullChargeCapacity_I));
      return BatteryStatistics.cb_setFullChargeCapacity_I;
    }

    private static void n_SetFullChargeCapacity_I(
      IntPtr jnienv,
      IntPtr native__this,
      int fullChargeCapacity)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).FullChargeCapacity = fullChargeCapacity;
    }

    public virtual unsafe int FullChargeCapacity
    {
      [Register("getFullChargeCapacity", "()I", "GetGetFullChargeCapacityHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getFullChargeCapacity.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setFullChargeCapacity", "(I)V", "GetSetFullChargeCapacity_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setFullChargeCapacity.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetHealthHandler()
    {
      if ((object) BatteryStatistics.cb_getHealth == null)
        BatteryStatistics.cb_getHealth = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetHealth));
      return BatteryStatistics.cb_getHealth;
    }

    private static int n_GetHealth(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Health;
    }

    private static Delegate GetSetHealth_IHandler()
    {
      if ((object) BatteryStatistics.cb_setHealth_I == null)
        BatteryStatistics.cb_setHealth_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetHealth_I));
      return BatteryStatistics.cb_setHealth_I;
    }

    private static void n_SetHealth_I(IntPtr jnienv, IntPtr native__this, int health)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Health = health;
    }

    public virtual unsafe int Health
    {
      [Register("getHealth", "()I", "GetGetHealthHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getHealth.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setHealth", "(I)V", "GetSetHealth_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setHealth.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetHealthStateHandler()
    {
      if ((object) BatteryStatistics.cb_getHealthState == null)
        BatteryStatistics.cb_getHealthState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetHealthState));
      return BatteryStatistics.cb_getHealthState;
    }

    private static IntPtr n_GetHealthState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).HealthState);
    }

    private static Delegate GetSetHealthState_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setHealthState_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setHealthState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetHealthState_Ljava_lang_String_));
      return BatteryStatistics.cb_setHealthState_Ljava_lang_String_;
    }

    private static void n_SetHealthState_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_healthState)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).HealthState = JNIEnv.GetString(native_healthState, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? HealthState
    {
      [Register("getHealthState", "()Ljava/lang/String;", "GetGetHealthStateHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getHealthState.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHealthState", "(Ljava/lang/String;)V", "GetSetHealthState_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setHealthState.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetManufactureDateHandler()
    {
      if ((object) BatteryStatistics.cb_getManufactureDate == null)
        BatteryStatistics.cb_getManufactureDate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetManufactureDate));
      return BatteryStatistics.cb_getManufactureDate;
    }

    private static IntPtr n_GetManufactureDate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ManufactureDate);
    }

    private static Delegate GetSetManufactureDate_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setManufactureDate_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setManufactureDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetManufactureDate_Ljava_lang_String_));
      return BatteryStatistics.cb_setManufactureDate_Ljava_lang_String_;
    }

    private static void n_SetManufactureDate_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_manufactureDate)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ManufactureDate = JNIEnv.GetString(native_manufactureDate, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? ManufactureDate
    {
      [Register("getManufactureDate", "()Ljava/lang/String;", "GetGetManufactureDateHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getManufactureDate.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setManufactureDate", "(Ljava/lang/String;)V", "GetSetManufactureDate_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setManufactureDate.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetModelNumberHandler()
    {
      if ((object) BatteryStatistics.cb_getModelNumber == null)
        BatteryStatistics.cb_getModelNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetModelNumber));
      return BatteryStatistics.cb_getModelNumber;
    }

    private static IntPtr n_GetModelNumber(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ModelNumber);
    }

    private static Delegate GetSetModelNumber_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setModelNumber_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setModelNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetModelNumber_Ljava_lang_String_));
      return BatteryStatistics.cb_setModelNumber_Ljava_lang_String_;
    }

    private static void n_SetModelNumber_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_modelNumber)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ModelNumber = JNIEnv.GetString(native_modelNumber, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? ModelNumber
    {
      [Register("getModelNumber", "()Ljava/lang/String;", "GetGetModelNumberHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getModelNumber.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setModelNumber", "(Ljava/lang/String;)V", "GetSetModelNumber_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setModelNumber.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPercentageHandler()
    {
      if ((object) BatteryStatistics.cb_getPercentage == null)
        BatteryStatistics.cb_getPercentage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetPercentage));
      return BatteryStatistics.cb_getPercentage;
    }

    private static int n_GetPercentage(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Percentage;
    }

    private static Delegate GetSetPercentage_IHandler()
    {
      if ((object) BatteryStatistics.cb_setPercentage_I == null)
        BatteryStatistics.cb_setPercentage_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetPercentage_I));
      return BatteryStatistics.cb_setPercentage_I;
    }

    private static void n_SetPercentage_I(IntPtr jnienv, IntPtr native__this, int percentage)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Percentage = percentage;
    }

    public virtual unsafe int Percentage
    {
      [Register("getPercentage", "()I", "GetGetPercentageHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getPercentage.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPercentage", "(I)V", "GetSetPercentage_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setPercentage.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerSourceTypeHandler()
    {
      if ((object) BatteryStatistics.cb_getPowerSourceType == null)
        BatteryStatistics.cb_getPowerSourceType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BatteryStatistics.n_GetPowerSourceType));
      return BatteryStatistics.cb_getPowerSourceType;
    }

    private static IntPtr n_GetPowerSourceType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).PowerSourceType);
    }

    private static Delegate GetSetPowerSourceType_Ljava_lang_String_Handler()
    {
      if ((object) BatteryStatistics.cb_setPowerSourceType_Ljava_lang_String_ == null)
        BatteryStatistics.cb_setPowerSourceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BatteryStatistics.n_SetPowerSourceType_Ljava_lang_String_));
      return BatteryStatistics.cb_setPowerSourceType_Ljava_lang_String_;
    }

    private static void n_SetPowerSourceType_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_powerSourceType)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).PowerSourceType = JNIEnv.GetString(native_powerSourceType, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? PowerSourceType
    {
      [Register("getPowerSourceType", "()Ljava/lang/String;", "GetGetPowerSourceTypeHandler")] get
      {
        JniObjectReference jniObjectReference = BatteryStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getPowerSourceType.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPowerSourceType", "(Ljava/lang/String;)V", "GetSetPowerSourceType_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setPowerSourceType.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetRemainingCapacityHandler()
    {
      if ((object) BatteryStatistics.cb_getRemainingCapacity == null)
        BatteryStatistics.cb_getRemainingCapacity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetRemainingCapacity));
      return BatteryStatistics.cb_getRemainingCapacity;
    }

    private static int n_GetRemainingCapacity(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).RemainingCapacity;
    }

    private static Delegate GetSetRemainingCapacity_IHandler()
    {
      if ((object) BatteryStatistics.cb_setRemainingCapacity_I == null)
        BatteryStatistics.cb_setRemainingCapacity_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetRemainingCapacity_I));
      return BatteryStatistics.cb_setRemainingCapacity_I;
    }

    private static void n_SetRemainingCapacity_I(
      IntPtr jnienv,
      IntPtr native__this,
      int remainingCapacity)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).RemainingCapacity = remainingCapacity;
    }

    public virtual unsafe int RemainingCapacity
    {
      [Register("getRemainingCapacity", "()I", "GetGetRemainingCapacityHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getRemainingCapacity.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRemainingCapacity", "(I)V", "GetSetRemainingCapacity_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setRemainingCapacity.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetSerialNumberHandler()
    {
      if ((object) BatteryStatistics.cb_getSerialNumber == null)
        BatteryStatistics.cb_getSerialNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetSerialNumber));
      return BatteryStatistics.cb_getSerialNumber;
    }

    private static int n_GetSerialNumber(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber;
    }

    private static Delegate GetSetSerialNumber_IHandler()
    {
      if ((object) BatteryStatistics.cb_setSerialNumber_I == null)
        BatteryStatistics.cb_setSerialNumber_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetSerialNumber_I));
      return BatteryStatistics.cb_setSerialNumber_I;
    }

    private static void n_SetSerialNumber_I(IntPtr jnienv, IntPtr native__this, int serialNumber)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber = serialNumber;
    }

    public virtual unsafe int SerialNumber
    {
      [Register("getSerialNumber", "()I", "GetGetSerialNumberHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getSerialNumber.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setSerialNumber", "(I)V", "GetSetSerialNumber_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setSerialNumber.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) BatteryStatistics.cb_getStatus == null)
        BatteryStatistics.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetStatus));
      return BatteryStatistics.cb_getStatus;
    }

    private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Status;
    }

    private static Delegate GetSetStatus_IHandler()
    {
      if ((object) BatteryStatistics.cb_setStatus_I == null)
        BatteryStatistics.cb_setStatus_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetStatus_I));
      return BatteryStatistics.cb_setStatus_I;
    }

    private static void n_SetStatus_I(IntPtr jnienv, IntPtr native__this, int status)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Status = status;
    }

    public virtual unsafe int Status
    {
      [Register("getStatus", "()I", "GetGetStatusHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getStatus.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStatus", "(I)V", "GetSetStatus_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setStatus.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTemperatureHandler()
    {
      if ((object) BatteryStatistics.cb_getTemperature == null)
        BatteryStatistics.cb_getTemperature = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetTemperature));
      return BatteryStatistics.cb_getTemperature;
    }

    private static int n_GetTemperature(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Temperature;
    }

    private static Delegate GetSetTemperature_IHandler()
    {
      if ((object) BatteryStatistics.cb_setTemperature_I == null)
        BatteryStatistics.cb_setTemperature_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetTemperature_I));
      return BatteryStatistics.cb_setTemperature_I;
    }

    private static void n_SetTemperature_I(IntPtr jnienv, IntPtr native__this, int temperature)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Temperature = temperature;
    }

    public virtual unsafe int Temperature
    {
      [Register("getTemperature", "()I", "GetGetTemperatureHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getTemperature.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTemperature", "(I)V", "GetSetTemperature_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setTemperature.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTimeToFullChargeHandler()
    {
      if ((object) BatteryStatistics.cb_getTimeToFullCharge == null)
        BatteryStatistics.cb_getTimeToFullCharge = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetTimeToFullCharge));
      return BatteryStatistics.cb_getTimeToFullCharge;
    }

    private static int n_GetTimeToFullCharge(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).TimeToFullCharge;
    }

    private static Delegate GetSetTimeToFullCharge_IHandler()
    {
      if ((object) BatteryStatistics.cb_setTimeToFullCharge_I == null)
        BatteryStatistics.cb_setTimeToFullCharge_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetTimeToFullCharge_I));
      return BatteryStatistics.cb_setTimeToFullCharge_I;
    }

    private static void n_SetTimeToFullCharge_I(
      IntPtr jnienv,
      IntPtr native__this,
      int timeToFullCharge)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).TimeToFullCharge = timeToFullCharge;
    }

    public virtual unsafe int TimeToFullCharge
    {
      [Register("getTimeToFullCharge", "()I", "GetGetTimeToFullChargeHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getTimeToFullCharge.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTimeToFullCharge", "(I)V", "GetSetTimeToFullCharge_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setTimeToFullCharge.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetVoltageHandler()
    {
      if ((object) BatteryStatistics.cb_getVoltage == null)
        BatteryStatistics.cb_getVoltage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BatteryStatistics.n_GetVoltage));
      return BatteryStatistics.cb_getVoltage;
    }

    private static int n_GetVoltage(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Voltage;
    }

    private static Delegate GetSetVoltage_IHandler()
    {
      if ((object) BatteryStatistics.cb_setVoltage_I == null)
        BatteryStatistics.cb_setVoltage_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BatteryStatistics.n_SetVoltage_I));
      return BatteryStatistics.cb_setVoltage_I;
    }

    private static void n_SetVoltage_I(IntPtr jnienv, IntPtr native__this, int voltage)
    {
      Object.GetObject<BatteryStatistics>(jnienv, native__this, (JniHandleOwnership) 0).Voltage = voltage;
    }

    public virtual unsafe int Voltage
    {
      [Register("getVoltage", "()I", "GetGetVoltageHandler")] get
      {
        return BatteryStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getVoltage.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setVoltage", "(I)V", "GetSetVoltage_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BatteryStatistics._members.InstanceMethods.InvokeVirtualVoidMethod("setVoltage.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
