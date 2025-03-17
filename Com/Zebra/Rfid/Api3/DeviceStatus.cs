// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.DeviceStatus
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
  [Register("com/zebra/rfid/api3/DeviceStatus", DoNotGenerateAcw = true)]
  public class DeviceStatus : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DeviceStatus", typeof (DeviceStatus));
    private static Delegate? cb_getNumOfAntennas;
    private static Delegate? cb_getPowerNegotiation;
    private static Delegate? cb_getPowerSource;
    private static Delegate? cb_getRadioActivity;
    private static Delegate? cb_getRadioConnection;
    private static Delegate? cb_getSystemTime;
    private static Delegate? cb_getTemperature;
    private static Delegate? cb_getUptime;
    private static Delegate? cb_getAntennaStatus;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DeviceStatus._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DeviceStatus._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DeviceStatus._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DeviceStatus._members.ManagedPeerType;

    protected DeviceStatus(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe DeviceStatus()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = DeviceStatus._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      DeviceStatus._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetNumOfAntennasHandler()
    {
      if ((object) DeviceStatus.cb_getNumOfAntennas == null)
        DeviceStatus.cb_getNumOfAntennas = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(DeviceStatus.n_GetNumOfAntennas));
      return DeviceStatus.cb_getNumOfAntennas;
    }

    private static int n_GetNumOfAntennas(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).NumOfAntennas;
    }

    public virtual unsafe int NumOfAntennas
    {
      [Register("getNumOfAntennas", "()I", "GetGetNumOfAntennasHandler")] get
      {
        return DeviceStatus._members.InstanceMethods.InvokeVirtualInt32Method("getNumOfAntennas.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetPowerNegotiationHandler()
    {
      if ((object) DeviceStatus.cb_getPowerNegotiation == null)
        DeviceStatus.cb_getPowerNegotiation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetPowerNegotiation));
      return DeviceStatus.cb_getPowerNegotiation;
    }

    private static IntPtr n_GetPowerNegotiation(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).PowerNegotiation);
    }

    public virtual unsafe string? PowerNegotiation
    {
      [Register("getPowerNegotiation", "()Ljava/lang/String;", "GetGetPowerNegotiationHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getPowerNegotiation.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPowerSourceHandler()
    {
      if ((object) DeviceStatus.cb_getPowerSource == null)
        DeviceStatus.cb_getPowerSource = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetPowerSource));
      return DeviceStatus.cb_getPowerSource;
    }

    private static IntPtr n_GetPowerSource(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).PowerSource);
    }

    public virtual unsafe string? PowerSource
    {
      [Register("getPowerSource", "()Ljava/lang/String;", "GetGetPowerSourceHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getPowerSource.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioActivityHandler()
    {
      if ((object) DeviceStatus.cb_getRadioActivity == null)
        DeviceStatus.cb_getRadioActivity = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetRadioActivity));
      return DeviceStatus.cb_getRadioActivity;
    }

    private static IntPtr n_GetRadioActivity(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).RadioActivity);
    }

    public virtual unsafe string? RadioActivity
    {
      [Register("getRadioActivity", "()Ljava/lang/String;", "GetGetRadioActivityHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioActivity.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioConnectionHandler()
    {
      if ((object) DeviceStatus.cb_getRadioConnection == null)
        DeviceStatus.cb_getRadioConnection = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetRadioConnection));
      return DeviceStatus.cb_getRadioConnection;
    }

    private static IntPtr n_GetRadioConnection(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).RadioConnection);
    }

    public virtual unsafe string? RadioConnection
    {
      [Register("getRadioConnection", "()Ljava/lang/String;", "GetGetRadioConnectionHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioConnection.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSystemTimeHandler()
    {
      if ((object) DeviceStatus.cb_getSystemTime == null)
        DeviceStatus.cb_getSystemTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetSystemTime));
      return DeviceStatus.cb_getSystemTime;
    }

    private static IntPtr n_GetSystemTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).SystemTime);
    }

    public virtual unsafe string? SystemTime
    {
      [Register("getSystemTime", "()Ljava/lang/String;", "GetGetSystemTimeHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getSystemTime.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTemperatureHandler()
    {
      if ((object) DeviceStatus.cb_getTemperature == null)
        DeviceStatus.cb_getTemperature = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetTemperature));
      return DeviceStatus.cb_getTemperature;
    }

    private static IntPtr n_GetTemperature(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).Temperature);
    }

    public virtual unsafe string? Temperature
    {
      [Register("getTemperature", "()Ljava/lang/String;", "GetGetTemperatureHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getTemperature.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUptimeHandler()
    {
      if ((object) DeviceStatus.cb_getUptime == null)
        DeviceStatus.cb_getUptime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetUptime));
      return DeviceStatus.cb_getUptime;
    }

    private static IntPtr n_GetUptime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).Uptime);
    }

    public virtual unsafe string? Uptime
    {
      [Register("getUptime", "()Ljava/lang/String;", "GetGetUptimeHandler")] get
      {
        JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getUptime.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetAntennaStatusHandler()
    {
      if ((object) DeviceStatus.cb_getAntennaStatus == null)
        DeviceStatus.cb_getAntennaStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.n_GetAntennaStatus));
      return DeviceStatus.cb_getAntennaStatus;
    }

    private static IntPtr n_GetAntennaStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JavaDictionary<Integer, string>.ToLocalJniHandle(Object.GetObject<DeviceStatus>(jnienv, native__this, (JniHandleOwnership) 0).GetAntennaStatus());
    }

    [Register("getAntennaStatus", "()Ljava/util/HashMap;", "GetGetAntennaStatusHandler")]
    public virtual unsafe IDictionary<Integer, string>? GetAntennaStatus()
    {
      JniObjectReference jniObjectReference = DeviceStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaStatus.()Ljava/util/HashMap;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JavaDictionary<Integer, string>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("com/zebra/rfid/api3/DeviceStatus$AntennaStatus", DoNotGenerateAcw = true)]
    public class AntennaStatus : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DeviceStatus$AntennaStatus", typeof (DeviceStatus.AntennaStatus));
      private static Delegate? cb_getAntennaID;
      private static Delegate? cb_getStatus;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DeviceStatus.AntennaStatus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DeviceStatus.AntennaStatus._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DeviceStatus.AntennaStatus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DeviceStatus.AntennaStatus._members.ManagedPeerType;

      protected AntennaStatus(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
      public unsafe AntennaStatus(string? antennaID, string? status)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num1 = JNIEnv.NewString(antennaID);
        IntPtr num2 = JNIEnv.NewString(status);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
          {
            new JniArgumentValue(num1),
            new JniArgumentValue(num2)
          };
          JniObjectReference instance = DeviceStatus.AntennaStatus._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          DeviceStatus.AntennaStatus._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num1);
          JNIEnv.DeleteLocalRef(num2);
        }
      }

      private static Delegate GetGetAntennaIDHandler()
      {
        if ((object) DeviceStatus.AntennaStatus.cb_getAntennaID == null)
          DeviceStatus.AntennaStatus.cb_getAntennaID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.AntennaStatus.n_GetAntennaID));
        return DeviceStatus.AntennaStatus.cb_getAntennaID;
      }

      private static IntPtr n_GetAntennaID(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<DeviceStatus.AntennaStatus>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID);
      }

      public virtual unsafe string? AntennaID
      {
        [Register("getAntennaID", "()Ljava/lang/String;", "GetGetAntennaIDHandler")] get
        {
          JniObjectReference jniObjectReference = DeviceStatus.AntennaStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaID.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetStatusHandler()
      {
        if ((object) DeviceStatus.AntennaStatus.cb_getStatus == null)
          DeviceStatus.AntennaStatus.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DeviceStatus.AntennaStatus.n_GetStatus));
        return DeviceStatus.AntennaStatus.cb_getStatus;
      }

      private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<DeviceStatus.AntennaStatus>(jnienv, native__this, (JniHandleOwnership) 0).Status);
      }

      public virtual unsafe string? Status
      {
        [Register("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")] get
        {
          JniObjectReference jniObjectReference = DeviceStatus.AntennaStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getStatus.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }
  }
}
