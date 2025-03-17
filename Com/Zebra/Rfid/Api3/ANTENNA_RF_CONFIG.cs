// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ANTENNA_RF_CONFIG
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
  [Register("com/zebra/rfid/api3/ANTENNA_RF_CONFIG", DoNotGenerateAcw = true)]
  public class ANTENNA_RF_CONFIG : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ANTENNA_RF_CONFIG", typeof (ANTENNA_RF_CONFIG));

    [Register("antennaStopTrigger")]
    public ANTENNA_STOP_TRIGGER? AntennaStopTrigger
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_RF_CONFIG._members.InstanceFields.GetObjectValue("antennaStopTrigger.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER;", (IJavaPeerable) this);
        return Object.GetObject<ANTENNA_STOP_TRIGGER>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("antennaStopTrigger.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("environment_mode")]
    public ENVIRONMENT_MODE? EnvironmentMode
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_RF_CONFIG._members.InstanceFields.GetObjectValue("environment_mode.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", (IJavaPeerable) this);
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("environment_mode.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("receivePort")]
    public int ReceivePort
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("receivePort.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("receivePort.I", (IJavaPeerable) this, value);
      }
    }

    [Register("receiveSensitivityIndex")]
    public int ReceiveSensitivityIndex
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("receiveSensitivityIndex.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("receiveSensitivityIndex.I", (IJavaPeerable) this, value);
      }
    }

    [Register("reserved")]
    public int Reserved
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("reserved.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("reserved.I", (IJavaPeerable) this, value);
      }
    }

    [Register("rfModeTableIndex")]
    public long RfModeTableIndex
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt64Value("rfModeTableIndex.J", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("rfModeTableIndex.J", (IJavaPeerable) this, value);
      }
    }

    [Register("tari")]
    public long Tari
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt64Value("tari.J", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("tari.J", (IJavaPeerable) this, value);
      }
    }

    [Register("transmitFrequencyIndex")]
    public int TransmitFrequencyIndex
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("transmitFrequencyIndex.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("transmitFrequencyIndex.I", (IJavaPeerable) this, value);
      }
    }

    [Register("transmitPort")]
    public int TransmitPort
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("transmitPort.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("transmitPort.I", (IJavaPeerable) this, value);
      }
    }

    [Register("transmitPowerIndex")]
    public int TransmitPowerIndex
    {
      get
      {
        return ANTENNA_RF_CONFIG._members.InstanceFields.GetInt32Value("transmitPowerIndex.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_RF_CONFIG._members.InstanceFields.SetValue("transmitPowerIndex.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_RF_CONFIG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ANTENNA_RF_CONFIG._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_RF_CONFIG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ANTENNA_RF_CONFIG._members.ManagedPeerType;

    protected ANTENNA_RF_CONFIG(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ANTENNA_RF_CONFIG()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ANTENNA_RF_CONFIG._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ANTENNA_RF_CONFIG._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
