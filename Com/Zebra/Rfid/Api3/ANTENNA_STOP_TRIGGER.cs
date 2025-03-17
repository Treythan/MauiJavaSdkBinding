// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ANTENNA_STOP_TRIGGER
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
  [Register("com/zebra/rfid/api3/ANTENNA_STOP_TRIGGER", DoNotGenerateAcw = true)]
  public class ANTENNA_STOP_TRIGGER : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ANTENNA_STOP_TRIGGER", typeof (ANTENNA_STOP_TRIGGER));

    [Register("enumstopTriggerType")]
    public int EnumstopTriggerType
    {
      get
      {
        return ANTENNA_STOP_TRIGGER._members.InstanceFields.GetInt32Value("enumstopTriggerType.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_STOP_TRIGGER._members.InstanceFields.SetValue("enumstopTriggerType.I", (IJavaPeerable) this, value);
      }
    }

    [Register("gpiTrigger")]
    public GPITrigger? GpiTrigger
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER._members.InstanceFields.GetObjectValue("gpiTrigger.Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this);
        return Object.GetObject<GPITrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ANTENNA_STOP_TRIGGER._members.InstanceFields.SetValue("gpiTrigger.Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("reserved")]
    public int Reserved
    {
      get
      {
        return ANTENNA_STOP_TRIGGER._members.InstanceFields.GetInt32Value("reserved.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_STOP_TRIGGER._members.InstanceFields.SetValue("reserved.I", (IJavaPeerable) this, value);
      }
    }

    [Register("stopTriggerType")]
    public ANTENNA_STOP_TRIGGER_TYPE? StopTriggerType
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER._members.InstanceFields.GetObjectValue("stopTriggerType.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", (IJavaPeerable) this);
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ANTENNA_STOP_TRIGGER._members.InstanceFields.SetValue("stopTriggerType.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("stopTriggerValue")]
    public int StopTriggerValue
    {
      get
      {
        return ANTENNA_STOP_TRIGGER._members.InstanceFields.GetInt32Value("stopTriggerValue.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_STOP_TRIGGER._members.InstanceFields.SetValue("stopTriggerValue.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_STOP_TRIGGER._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ANTENNA_STOP_TRIGGER._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_STOP_TRIGGER._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ANTENNA_STOP_TRIGGER._members.ManagedPeerType;

    protected ANTENNA_STOP_TRIGGER(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ANTENNA_STOP_TRIGGER()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ANTENNA_STOP_TRIGGER._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ANTENNA_STOP_TRIGGER._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
