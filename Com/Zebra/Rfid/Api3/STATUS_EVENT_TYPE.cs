// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.STATUS_EVENT_TYPE
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
  [Register("com/zebra/rfid/api3/STATUS_EVENT_TYPE", DoNotGenerateAcw = true)]
  public class STATUS_EVENT_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/STATUS_EVENT_TYPE", typeof (STATUS_EVENT_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ACCESS_START_EVENT")]
    public static STATUS_EVENT_TYPE? AccessStartEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("ACCESS_START_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_STOP_EVENT")]
    public static STATUS_EVENT_TYPE? AccessStopEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("ACCESS_STOP_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ANTENNA_EVENT")]
    public static STATUS_EVENT_TYPE? AntennaEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("ANTENNA_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BATCH_MODE_EVENT")]
    public static STATUS_EVENT_TYPE? BatchModeEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("BATCH_MODE_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BATTERY_EVENT")]
    public static STATUS_EVENT_TYPE? BatteryEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("BATTERY_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BUFFER_FULL_EVENT")]
    public static STATUS_EVENT_TYPE? BufferFullEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("BUFFER_FULL_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BUFFER_FULL_WARNING_EVENT")]
    public static STATUS_EVENT_TYPE? BufferFullWarningEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("BUFFER_FULL_WARNING_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CRADLE_EVENT")]
    public static STATUS_EVENT_TYPE? CradleEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("CRADLE_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DEBUG_INFO_EVENT")]
    public static STATUS_EVENT_TYPE? DebugInfoEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("DEBUG_INFO_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DISCONNECTION_EVENT")]
    public static STATUS_EVENT_TYPE? DisconnectionEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("DISCONNECTION_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FIRMWARE_UPDATE_EVENT")]
    public static STATUS_EVENT_TYPE? FirmwareUpdateEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("GPI_EVENT")]
    public static STATUS_EVENT_TYPE? GpiEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("GPI_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HANDHELD_TRIGGER_EVENT")]
    public static STATUS_EVENT_TYPE? HandheldTriggerEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("HANDHELD_TRIGGER_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INFO_EVENT")]
    public static STATUS_EVENT_TYPE? InfoEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("INFO_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INVENTORY_START_EVENT")]
    public static STATUS_EVENT_TYPE? InventoryStartEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("INVENTORY_START_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INVENTORY_STOP_EVENT")]
    public static STATUS_EVENT_TYPE? InventoryStopEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("INVENTORY_STOP_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NXP_EAS_ALARM_EVENT")]
    public static STATUS_EVENT_TYPE? NxpEasAlarmEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("NXP_EAS_ALARM_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("OPERATION_END_SUMMARY_EVENT")]
    public static STATUS_EVENT_TYPE? OperationEndSummaryEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("OPERATION_END_SUMMARY_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return STATUS_EVENT_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        STATUS_EVENT_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("POWER_EVENT")]
    public static STATUS_EVENT_TYPE? PowerEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("POWER_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READER_EXCEPTION_EVENT")]
    public static STATUS_EVENT_TYPE? ReaderExceptionEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("READER_EXCEPTION_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TEMPERATURE_ALARM_EVENT")]
    public static STATUS_EVENT_TYPE? TemperatureAlarmEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("TEMPERATURE_ALARM_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPA_EVENT")]
    public static STATUS_EVENT_TYPE? WpaEvent
    {
      get
      {
        JniObjectReference objectValue = STATUS_EVENT_TYPE._members.StaticFields.GetObjectValue("WPA_EVENT.Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;");
        return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = STATUS_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => STATUS_EVENT_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = STATUS_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => STATUS_EVENT_TYPE._members.ManagedPeerType;

    protected STATUS_EVENT_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) STATUS_EVENT_TYPE.cb_getValue == null)
        STATUS_EVENT_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(STATUS_EVENT_TYPE.n_GetValue));
      return STATUS_EVENT_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<STATUS_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return STATUS_EVENT_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) STATUS_EVENT_TYPE.cb_equals_I == null)
        STATUS_EVENT_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(STATUS_EVENT_TYPE.n_Equals_I));
      return STATUS_EVENT_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<STATUS_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return STATUS_EVENT_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
