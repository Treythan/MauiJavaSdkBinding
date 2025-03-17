// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Events
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
  [Register("com/zebra/rfid/api3/Events", DoNotGenerateAcw = true)]
  public class Events : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Events", typeof (Events));
    private static Delegate? cb_getHostName;
    private static Delegate? cb_isAntennaEventSet;
    private static Delegate? cb_isAttachTagDataWithReadEventSet;
    private static Delegate? cb_isBatchModeEventSet;
    private static Delegate? cb_isBatterySet;
    private static Delegate? cb_isBufferFullEventSet;
    private static Delegate? cb_isBufferFullWarningEventSet;
    private static Delegate? cb_isCradleEventset;
    private static Delegate? cb_isGPIEventSet;
    private static Delegate? cb_isHandheldEventSet;
    private static Delegate? cb_isInfoEventSet;
    private static Delegate? cb_isInventoryStartEventSet;
    private static Delegate? cb_isInventoryStopEventSet;
    private static Delegate? cb_isOperationEndSummaryEvenSet;
    private static Delegate? cb_isPowerEventSet;
    private static Delegate? cb_isReaderDisconnectEventSet;
    private static Delegate? cb_isReaderExceptionEventSet;
    private static Delegate? cb_isScanDataEventSet;
    private static Delegate? cb_isTagReadEventSet;
    private static Delegate? cb_isTemperatureAlarmEventSet;
    private static Delegate? cb_isWPAEventSet;
    private static Delegate? cb_getRfidConnectionState;
    private static Delegate? cb_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_;
    private static Delegate? cb_addEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_;
    private static Delegate? cb_addWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_;
    private static Delegate? cb_notifyReadEventSchedule;
    private static Delegate? cb_notifyWifiScanEventSchedule;
    private static Delegate? cb_removeEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_;
    private static Delegate? cb_removeWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_;
    private static Delegate? cb_setAntennaEvent_Z;
    private static Delegate? cb_setAttachTagDataWithReadEvent_Z;
    private static Delegate? cb_setBatchModeEvent_Z;
    private static Delegate? cb_setBatteryEvent_Z;
    private static Delegate? cb_setBufferFullEvent_Z;
    private static Delegate? cb_setBufferFullWarningEvent_Z;
    private static Delegate? cb_setCradleEvent_Z;
    private static Delegate? cb_setFirmwareUpdateEvent_Z;
    private static Delegate? cb_setGPIEvent_Z;
    private static Delegate? cb_setHandheldEvent_Z;
    private static Delegate? cb_setHeartBeatEvent_Z;
    private static Delegate? cb_setInfoEvent_Z;
    private static Delegate? cb_setInventoryStartEvent_Z;
    private static Delegate? cb_setInventoryStopEvent_Z;
    private static Delegate? cb_setOperationEndSummaryEvent_Z;
    private static Delegate? cb_setPowerEvent_Z;
    private static Delegate? cb_setReaderDisconnectEvent_Z;
    private static Delegate? cb_setReaderExceptionEvent_Z;
    private static Delegate? cb_setRfidReConnectionStateEvents;
    private static Delegate? cb_setScanDataEvent_Z;
    private static Delegate? cb_setTagReadEvent_Z;
    private static Delegate? cb_setTemperatureAlarmEvent_Z;
    private static Delegate? cb_setWPAEvent_Z;
    private WeakReference? weak_implementor_AddEventsListener;
    private WeakReference? weak_implementor_AddWifiScanDataEventsListener;

    [Register("iEvents")]
    public IEvents? IEvents
    {
      get
      {
        JniObjectReference objectValue = Events._members.InstanceFields.GetObjectValue("iEvents.Lcom/zebra/rfid/api3/IEvents;", (IJavaPeerable) this);
        return Object.GetObject<IEvents>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Events._members.InstanceFields.SetValue("iEvents.Lcom/zebra/rfid/api3/IEvents;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = Events._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("m_Actions")]
    public Actions? MActions
    {
      get
      {
        JniObjectReference objectValue = Events._members.InstanceFields.GetObjectValue("m_Actions.Lcom/zebra/rfid/api3/Actions;", (IJavaPeerable) this);
        return Object.GetObject<Actions>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Events._members.InstanceFields.SetValue("m_Actions.Lcom/zebra/rfid/api3/Actions;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Events._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Events._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Events._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Events._members.ManagedPeerType;

    protected Events(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetHostNameHandler()
    {
      if ((object) Events.cb_getHostName == null)
        Events.cb_getHostName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Events.n_GetHostName));
      return Events.cb_getHostName;
    }

    private static IntPtr n_GetHostName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).HostName);
    }

    public virtual unsafe string? HostName
    {
      [Register("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")] get
      {
        JniObjectReference jniObjectReference = Events._members.InstanceMethods.InvokeVirtualObjectMethod("getHostName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsAntennaEventSetHandler()
    {
      if ((object) Events.cb_isAntennaEventSet == null)
        Events.cb_isAntennaEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsAntennaEventSet));
      return Events.cb_isAntennaEventSet;
    }

    private static bool n_IsAntennaEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsAntennaEventSet;
    }

    public virtual unsafe bool IsAntennaEventSet
    {
      [Register("isAntennaEventSet", "()Z", "GetIsAntennaEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isAntennaEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsAttachTagDataWithReadEventSetHandler()
    {
      if ((object) Events.cb_isAttachTagDataWithReadEventSet == null)
        Events.cb_isAttachTagDataWithReadEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsAttachTagDataWithReadEventSet));
      return Events.cb_isAttachTagDataWithReadEventSet;
    }

    private static bool n_IsAttachTagDataWithReadEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsAttachTagDataWithReadEventSet;
    }

    public virtual unsafe bool IsAttachTagDataWithReadEventSet
    {
      [Register("isAttachTagDataWithReadEventSet", "()Z", "GetIsAttachTagDataWithReadEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isAttachTagDataWithReadEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsBatchModeEventSetHandler()
    {
      if ((object) Events.cb_isBatchModeEventSet == null)
        Events.cb_isBatchModeEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsBatchModeEventSet));
      return Events.cb_isBatchModeEventSet;
    }

    private static bool n_IsBatchModeEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsBatchModeEventSet;
    }

    public virtual unsafe bool IsBatchModeEventSet
    {
      [Register("isBatchModeEventSet", "()Z", "GetIsBatchModeEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isBatchModeEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsBatterySetHandler()
    {
      if ((object) Events.cb_isBatterySet == null)
        Events.cb_isBatterySet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsBatterySet));
      return Events.cb_isBatterySet;
    }

    private static bool n_IsBatterySet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsBatterySet;
    }

    public virtual unsafe bool IsBatterySet
    {
      [Register("isBatterySet", "()Z", "GetIsBatterySetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isBatterySet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsBufferFullEventSetHandler()
    {
      if ((object) Events.cb_isBufferFullEventSet == null)
        Events.cb_isBufferFullEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsBufferFullEventSet));
      return Events.cb_isBufferFullEventSet;
    }

    private static bool n_IsBufferFullEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsBufferFullEventSet;
    }

    public virtual unsafe bool IsBufferFullEventSet
    {
      [Register("isBufferFullEventSet", "()Z", "GetIsBufferFullEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isBufferFullEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsBufferFullWarningEventSetHandler()
    {
      if ((object) Events.cb_isBufferFullWarningEventSet == null)
        Events.cb_isBufferFullWarningEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsBufferFullWarningEventSet));
      return Events.cb_isBufferFullWarningEventSet;
    }

    private static bool n_IsBufferFullWarningEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsBufferFullWarningEventSet;
    }

    public virtual unsafe bool IsBufferFullWarningEventSet
    {
      [Register("isBufferFullWarningEventSet", "()Z", "GetIsBufferFullWarningEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isBufferFullWarningEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsCradleEventsetHandler()
    {
      if ((object) Events.cb_isCradleEventset == null)
        Events.cb_isCradleEventset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsCradleEventset));
      return Events.cb_isCradleEventset;
    }

    private static bool n_IsCradleEventset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsCradleEventset;
    }

    public virtual unsafe bool IsCradleEventset
    {
      [Register("isCradleEventset", "()Z", "GetIsCradleEventsetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isCradleEventset.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsGPIEventSetHandler()
    {
      if ((object) Events.cb_isGPIEventSet == null)
        Events.cb_isGPIEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsGPIEventSet));
      return Events.cb_isGPIEventSet;
    }

    private static bool n_IsGPIEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsGPIEventSet;
    }

    public virtual unsafe bool IsGPIEventSet
    {
      [Register("isGPIEventSet", "()Z", "GetIsGPIEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isGPIEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsHandheldEventSetHandler()
    {
      if ((object) Events.cb_isHandheldEventSet == null)
        Events.cb_isHandheldEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsHandheldEventSet));
      return Events.cb_isHandheldEventSet;
    }

    private static bool n_IsHandheldEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsHandheldEventSet;
    }

    public virtual unsafe bool IsHandheldEventSet
    {
      [Register("isHandheldEventSet", "()Z", "GetIsHandheldEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isHandheldEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsInfoEventSetHandler()
    {
      if ((object) Events.cb_isInfoEventSet == null)
        Events.cb_isInfoEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsInfoEventSet));
      return Events.cb_isInfoEventSet;
    }

    private static bool n_IsInfoEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsInfoEventSet;
    }

    public virtual unsafe bool IsInfoEventSet
    {
      [Register("isInfoEventSet", "()Z", "GetIsInfoEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isInfoEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsInventoryStartEventSetHandler()
    {
      if ((object) Events.cb_isInventoryStartEventSet == null)
        Events.cb_isInventoryStartEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsInventoryStartEventSet));
      return Events.cb_isInventoryStartEventSet;
    }

    private static bool n_IsInventoryStartEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsInventoryStartEventSet;
    }

    public virtual unsafe bool IsInventoryStartEventSet
    {
      [Register("isInventoryStartEventSet", "()Z", "GetIsInventoryStartEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isInventoryStartEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsInventoryStopEventSetHandler()
    {
      if ((object) Events.cb_isInventoryStopEventSet == null)
        Events.cb_isInventoryStopEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsInventoryStopEventSet));
      return Events.cb_isInventoryStopEventSet;
    }

    private static bool n_IsInventoryStopEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsInventoryStopEventSet;
    }

    public virtual unsafe bool IsInventoryStopEventSet
    {
      [Register("isInventoryStopEventSet", "()Z", "GetIsInventoryStopEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isInventoryStopEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsOperationEndSummaryEvenSetHandler()
    {
      if ((object) Events.cb_isOperationEndSummaryEvenSet == null)
        Events.cb_isOperationEndSummaryEvenSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsOperationEndSummaryEvenSet));
      return Events.cb_isOperationEndSummaryEvenSet;
    }

    private static bool n_IsOperationEndSummaryEvenSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsOperationEndSummaryEvenSet;
    }

    public virtual unsafe bool IsOperationEndSummaryEvenSet
    {
      [Register("isOperationEndSummaryEvenSet", "()Z", "GetIsOperationEndSummaryEvenSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isOperationEndSummaryEvenSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsPowerEventSetHandler()
    {
      if ((object) Events.cb_isPowerEventSet == null)
        Events.cb_isPowerEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsPowerEventSet));
      return Events.cb_isPowerEventSet;
    }

    private static bool n_IsPowerEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsPowerEventSet;
    }

    public virtual unsafe bool IsPowerEventSet
    {
      [Register("isPowerEventSet", "()Z", "GetIsPowerEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isPowerEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsReaderDisconnectEventSetHandler()
    {
      if ((object) Events.cb_isReaderDisconnectEventSet == null)
        Events.cb_isReaderDisconnectEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsReaderDisconnectEventSet));
      return Events.cb_isReaderDisconnectEventSet;
    }

    private static bool n_IsReaderDisconnectEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsReaderDisconnectEventSet;
    }

    public virtual unsafe bool IsReaderDisconnectEventSet
    {
      [Register("isReaderDisconnectEventSet", "()Z", "GetIsReaderDisconnectEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isReaderDisconnectEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsReaderExceptionEventSetHandler()
    {
      if ((object) Events.cb_isReaderExceptionEventSet == null)
        Events.cb_isReaderExceptionEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsReaderExceptionEventSet));
      return Events.cb_isReaderExceptionEventSet;
    }

    private static bool n_IsReaderExceptionEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsReaderExceptionEventSet;
    }

    public virtual unsafe bool IsReaderExceptionEventSet
    {
      [Register("isReaderExceptionEventSet", "()Z", "GetIsReaderExceptionEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isReaderExceptionEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsScanDataEventSetHandler()
    {
      if ((object) Events.cb_isScanDataEventSet == null)
        Events.cb_isScanDataEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsScanDataEventSet));
      return Events.cb_isScanDataEventSet;
    }

    private static bool n_IsScanDataEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsScanDataEventSet;
    }

    public virtual unsafe bool IsScanDataEventSet
    {
      [Register("isScanDataEventSet", "()Z", "GetIsScanDataEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isScanDataEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsTagReadEventSetHandler()
    {
      if ((object) Events.cb_isTagReadEventSet == null)
        Events.cb_isTagReadEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsTagReadEventSet));
      return Events.cb_isTagReadEventSet;
    }

    private static bool n_IsTagReadEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsTagReadEventSet;
    }

    public virtual unsafe bool IsTagReadEventSet
    {
      [Register("isTagReadEventSet", "()Z", "GetIsTagReadEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagReadEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsTemperatureAlarmEventSetHandler()
    {
      if ((object) Events.cb_isTemperatureAlarmEventSet == null)
        Events.cb_isTemperatureAlarmEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsTemperatureAlarmEventSet));
      return Events.cb_isTemperatureAlarmEventSet;
    }

    private static bool n_IsTemperatureAlarmEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsTemperatureAlarmEventSet;
    }

    public virtual unsafe bool IsTemperatureAlarmEventSet
    {
      [Register("isTemperatureAlarmEventSet", "()Z", "GetIsTemperatureAlarmEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isTemperatureAlarmEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsWPAEventSetHandler()
    {
      if ((object) Events.cb_isWPAEventSet == null)
        Events.cb_isWPAEventSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Events.n_IsWPAEventSet));
      return Events.cb_isWPAEventSet;
    }

    private static bool n_IsWPAEventSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).IsWPAEventSet;
    }

    public virtual unsafe bool IsWPAEventSet
    {
      [Register("isWPAEventSet", "()Z", "GetIsWPAEventSetHandler")] get
      {
        return Events._members.InstanceMethods.InvokeVirtualBooleanMethod("isWPAEventSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRfidConnectionStateHandler()
    {
      if ((object) Events.cb_getRfidConnectionState == null)
        Events.cb_getRfidConnectionState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Events.n_GetRfidConnectionState));
      return Events.cb_getRfidConnectionState;
    }

    private static IntPtr n_GetRfidConnectionState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).RfidConnectionState);
    }

    public virtual unsafe Object? RfidConnectionState
    {
      [Register("getRfidConnectionState", "()Ljava/lang/Object;", "GetGetRfidConnectionStateHandler")] get
      {
        JniObjectReference jniObjectReference = Events._members.InstanceMethods.InvokeVirtualObjectMethod("getRfidConnectionState.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_Handler()
    {
      if ((object) Events.cb_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_ == null)
        Events.cb_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Events.n_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_));
      return Events.cb_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_;
    }

    private static IntPtr n_GetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_eventType)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).GetStatusEventData(Object.GetObject<RFID_EVENT_TYPE>(native_eventType, (JniHandleOwnership) 0)));
    }

    [Register("GetStatusEventData", "(Lcom/zebra/rfid/api3/RFID_EVENT_TYPE;)Lcom/zebra/rfid/api3/IEvents$StatusEventData;", "GetGetStatusEventData_Lcom_zebra_rfid_api3_RFID_EVENT_TYPE_Handler")]
    public virtual unsafe IEvents.StatusEventData? GetStatusEventData(RFID_EVENT_TYPE? eventType)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(eventType == null ? IntPtr.Zero : eventType.Handle)
        };
        JniObjectReference jniObjectReference = Events._members.InstanceMethods.InvokeVirtualObjectMethod("GetStatusEventData.(Lcom/zebra/rfid/api3/RFID_EVENT_TYPE;)Lcom/zebra/rfid/api3/IEvents$StatusEventData;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<IEvents.StatusEventData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) eventType);
      }
    }

    private static Delegate GetAddEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_Handler()
    {
      if ((object) Events.cb_addEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_ == null)
        Events.cb_addEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Events.n_AddEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_));
      return Events.cb_addEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_;
    }

    private static void n_AddEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_rfidEventListener)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).AddEventsListener(Object.GetObject<IRfidEventsListener>(native_rfidEventListener, (JniHandleOwnership) 0));
    }

    [Register("addEventsListener", "(Lcom/zebra/rfid/api3/RfidEventsListener;)V", "GetAddEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_Handler")]
    public virtual unsafe void AddEventsListener(IRfidEventsListener? rfidEventListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidEventListener == null ? IntPtr.Zero : ((Object) rfidEventListener).Handle)
        };
        Events._members.InstanceMethods.InvokeVirtualVoidMethod("addEventsListener.(Lcom/zebra/rfid/api3/RfidEventsListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidEventListener);
      }
    }

    private static Delegate GetAddWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_Handler()
    {
      if ((object) Events.cb_addWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_ == null)
        Events.cb_addWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Events.n_AddWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_));
      return Events.cb_addWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_;
    }

    private static void n_AddWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_wifiScanDataListener)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).AddWifiScanDataEventsListener(Object.GetObject<IWifiScanDataEventsListener>(native_wifiScanDataListener, (JniHandleOwnership) 0));
    }

    [Register("addWifiScanDataEventsListener", "(Lcom/zebra/rfid/api3/WifiScanDataEventsListener;)V", "GetAddWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_Handler")]
    public virtual unsafe void AddWifiScanDataEventsListener(
      IWifiScanDataEventsListener? wifiScanDataListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(wifiScanDataListener == null ? IntPtr.Zero : ((Object) wifiScanDataListener).Handle)
        };
        Events._members.InstanceMethods.InvokeVirtualVoidMethod("addWifiScanDataEventsListener.(Lcom/zebra/rfid/api3/WifiScanDataEventsListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) wifiScanDataListener);
      }
    }

    private static Delegate GetNotifyReadEventScheduleHandler()
    {
      if ((object) Events.cb_notifyReadEventSchedule == null)
        Events.cb_notifyReadEventSchedule = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Events.n_NotifyReadEventSchedule));
      return Events.cb_notifyReadEventSchedule;
    }

    private static void n_NotifyReadEventSchedule(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).NotifyReadEventSchedule();
    }

    [Register("notifyReadEventSchedule", "()V", "GetNotifyReadEventScheduleHandler")]
    protected virtual unsafe void NotifyReadEventSchedule()
    {
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("notifyReadEventSchedule.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetNotifyWifiScanEventScheduleHandler()
    {
      if ((object) Events.cb_notifyWifiScanEventSchedule == null)
        Events.cb_notifyWifiScanEventSchedule = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Events.n_NotifyWifiScanEventSchedule));
      return Events.cb_notifyWifiScanEventSchedule;
    }

    private static void n_NotifyWifiScanEventSchedule(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).NotifyWifiScanEventSchedule();
    }

    [Register("notifyWifiScanEventSchedule", "()V", "GetNotifyWifiScanEventScheduleHandler")]
    protected virtual unsafe void NotifyWifiScanEventSchedule()
    {
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("notifyWifiScanEventSchedule.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetRemoveEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_Handler()
    {
      if ((object) Events.cb_removeEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_ == null)
        Events.cb_removeEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Events.n_RemoveEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_));
      return Events.cb_removeEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_;
    }

    private static void n_RemoveEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_rfidEventListener)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).RemoveEventsListener(Object.GetObject<IRfidEventsListener>(native_rfidEventListener, (JniHandleOwnership) 0));
    }

    [Register("removeEventsListener", "(Lcom/zebra/rfid/api3/RfidEventsListener;)V", "GetRemoveEventsListener_Lcom_zebra_rfid_api3_RfidEventsListener_Handler")]
    public virtual unsafe void RemoveEventsListener(IRfidEventsListener? rfidEventListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidEventListener == null ? IntPtr.Zero : ((Object) rfidEventListener).Handle)
        };
        Events._members.InstanceMethods.InvokeVirtualVoidMethod("removeEventsListener.(Lcom/zebra/rfid/api3/RfidEventsListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidEventListener);
      }
    }

    private static Delegate GetRemoveWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_Handler()
    {
      if ((object) Events.cb_removeWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_ == null)
        Events.cb_removeWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Events.n_RemoveWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_));
      return Events.cb_removeWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_;
    }

    private static void n_RemoveWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_wifiScanDataListener)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).RemoveWifiScanDataEventsListener(Object.GetObject<IWifiScanDataEventsListener>(native_wifiScanDataListener, (JniHandleOwnership) 0));
    }

    [Register("removeWifiScanDataEventsListener", "(Lcom/zebra/rfid/api3/WifiScanDataEventsListener;)V", "GetRemoveWifiScanDataEventsListener_Lcom_zebra_rfid_api3_WifiScanDataEventsListener_Handler")]
    public virtual unsafe void RemoveWifiScanDataEventsListener(
      IWifiScanDataEventsListener? wifiScanDataListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(wifiScanDataListener == null ? IntPtr.Zero : ((Object) wifiScanDataListener).Handle)
        };
        Events._members.InstanceMethods.InvokeVirtualVoidMethod("removeWifiScanDataEventsListener.(Lcom/zebra/rfid/api3/WifiScanDataEventsListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) wifiScanDataListener);
      }
    }

    private static Delegate GetSetAntennaEvent_ZHandler()
    {
      if ((object) Events.cb_setAntennaEvent_Z == null)
        Events.cb_setAntennaEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetAntennaEvent_Z));
      return Events.cb_setAntennaEvent_Z;
    }

    private static void n_SetAntennaEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyAntennaEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetAntennaEvent(notifyAntennaEvent);
    }

    [Register("setAntennaEvent", "(Z)V", "GetSetAntennaEvent_ZHandler")]
    public virtual unsafe void SetAntennaEvent(bool notifyAntennaEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyAntennaEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetAttachTagDataWithReadEvent_ZHandler()
    {
      if ((object) Events.cb_setAttachTagDataWithReadEvent_Z == null)
        Events.cb_setAttachTagDataWithReadEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetAttachTagDataWithReadEvent_Z));
      return Events.cb_setAttachTagDataWithReadEvent_Z;
    }

    private static void n_SetAttachTagDataWithReadEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool attachTagDataWithReadEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetAttachTagDataWithReadEvent(attachTagDataWithReadEvent);
    }

    [Register("setAttachTagDataWithReadEvent", "(Z)V", "GetSetAttachTagDataWithReadEvent_ZHandler")]
    public virtual unsafe void SetAttachTagDataWithReadEvent(bool attachTagDataWithReadEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(attachTagDataWithReadEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setAttachTagDataWithReadEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetBatchModeEvent_ZHandler()
    {
      if ((object) Events.cb_setBatchModeEvent_Z == null)
        Events.cb_setBatchModeEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetBatchModeEvent_Z));
      return Events.cb_setBatchModeEvent_Z;
    }

    private static void n_SetBatchModeEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyBatchMode)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetBatchModeEvent(notifyBatchMode);
    }

    [Register("setBatchModeEvent", "(Z)V", "GetSetBatchModeEvent_ZHandler")]
    public virtual unsafe void SetBatchModeEvent(bool notifyBatchMode)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyBatchMode)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setBatchModeEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetBatteryEvent_ZHandler()
    {
      if ((object) Events.cb_setBatteryEvent_Z == null)
        Events.cb_setBatteryEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetBatteryEvent_Z));
      return Events.cb_setBatteryEvent_Z;
    }

    private static void n_SetBatteryEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyBatteryEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetBatteryEvent(notifyBatteryEvent);
    }

    [Register("setBatteryEvent", "(Z)V", "GetSetBatteryEvent_ZHandler")]
    public virtual unsafe void SetBatteryEvent(bool notifyBatteryEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyBatteryEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setBatteryEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetBufferFullEvent_ZHandler()
    {
      if ((object) Events.cb_setBufferFullEvent_Z == null)
        Events.cb_setBufferFullEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetBufferFullEvent_Z));
      return Events.cb_setBufferFullEvent_Z;
    }

    private static void n_SetBufferFullEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyBufferFullEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetBufferFullEvent(notifyBufferFullEvent);
    }

    [Register("setBufferFullEvent", "(Z)V", "GetSetBufferFullEvent_ZHandler")]
    public virtual unsafe void SetBufferFullEvent(bool notifyBufferFullEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyBufferFullEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setBufferFullEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetBufferFullWarningEvent_ZHandler()
    {
      if ((object) Events.cb_setBufferFullWarningEvent_Z == null)
        Events.cb_setBufferFullWarningEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetBufferFullWarningEvent_Z));
      return Events.cb_setBufferFullWarningEvent_Z;
    }

    private static void n_SetBufferFullWarningEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyBufferFullWarningEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetBufferFullWarningEvent(notifyBufferFullWarningEvent);
    }

    [Register("setBufferFullWarningEvent", "(Z)V", "GetSetBufferFullWarningEvent_ZHandler")]
    public virtual unsafe void SetBufferFullWarningEvent(bool notifyBufferFullWarningEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyBufferFullWarningEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setBufferFullWarningEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetCradleEvent_ZHandler()
    {
      if ((object) Events.cb_setCradleEvent_Z == null)
        Events.cb_setCradleEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetCradleEvent_Z));
      return Events.cb_setCradleEvent_Z;
    }

    private static void n_SetCradleEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyCradleEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetCradleEvent(notifyCradleEvent);
    }

    [Register("setCradleEvent", "(Z)V", "GetSetCradleEvent_ZHandler")]
    public virtual unsafe void SetCradleEvent(bool notifyCradleEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyCradleEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setCradleEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetFirmwareUpdateEvent_ZHandler()
    {
      if ((object) Events.cb_setFirmwareUpdateEvent_Z == null)
        Events.cb_setFirmwareUpdateEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetFirmwareUpdateEvent_Z));
      return Events.cb_setFirmwareUpdateEvent_Z;
    }

    private static void n_SetFirmwareUpdateEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyScanDataEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetFirmwareUpdateEvent(notifyScanDataEvent);
    }

    [Register("setFirmwareUpdateEvent", "(Z)V", "GetSetFirmwareUpdateEvent_ZHandler")]
    public virtual unsafe void SetFirmwareUpdateEvent(bool notifyScanDataEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyScanDataEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setFirmwareUpdateEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetGPIEvent_ZHandler()
    {
      if ((object) Events.cb_setGPIEvent_Z == null)
        Events.cb_setGPIEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetGPIEvent_Z));
      return Events.cb_setGPIEvent_Z;
    }

    private static void n_SetGPIEvent_Z(IntPtr jnienv, IntPtr native__this, bool notifyGPIEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetGPIEvent(notifyGPIEvent);
    }

    [Register("setGPIEvent", "(Z)V", "GetSetGPIEvent_ZHandler")]
    public virtual unsafe void SetGPIEvent(bool notifyGPIEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyGPIEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setGPIEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetHandheldEvent_ZHandler()
    {
      if ((object) Events.cb_setHandheldEvent_Z == null)
        Events.cb_setHandheldEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetHandheldEvent_Z));
      return Events.cb_setHandheldEvent_Z;
    }

    private static void n_SetHandheldEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyHandheldEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetHandheldEvent(notifyHandheldEvent);
    }

    [Register("setHandheldEvent", "(Z)V", "GetSetHandheldEvent_ZHandler")]
    public virtual unsafe void SetHandheldEvent(bool notifyHandheldEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyHandheldEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setHandheldEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetHeartBeatEvent_ZHandler()
    {
      if ((object) Events.cb_setHeartBeatEvent_Z == null)
        Events.cb_setHeartBeatEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetHeartBeatEvent_Z));
      return Events.cb_setHeartBeatEvent_Z;
    }

    private static void n_SetHeartBeatEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyHeartbeatDataEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetHeartBeatEvent(notifyHeartbeatDataEvent);
    }

    [Register("setHeartBeatEvent", "(Z)V", "GetSetHeartBeatEvent_ZHandler")]
    public virtual unsafe void SetHeartBeatEvent(bool notifyHeartbeatDataEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyHeartbeatDataEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setHeartBeatEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetInfoEvent_ZHandler()
    {
      if ((object) Events.cb_setInfoEvent_Z == null)
        Events.cb_setInfoEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetInfoEvent_Z));
      return Events.cb_setInfoEvent_Z;
    }

    private static void n_SetInfoEvent_Z(IntPtr jnienv, IntPtr native__this, bool notifyInfoEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetInfoEvent(notifyInfoEvent);
    }

    [Register("setInfoEvent", "(Z)V", "GetSetInfoEvent_ZHandler")]
    public virtual unsafe void SetInfoEvent(bool notifyInfoEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyInfoEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setInfoEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetInventoryStartEvent_ZHandler()
    {
      if ((object) Events.cb_setInventoryStartEvent_Z == null)
        Events.cb_setInventoryStartEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetInventoryStartEvent_Z));
      return Events.cb_setInventoryStartEvent_Z;
    }

    private static void n_SetInventoryStartEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyInventoryStartEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetInventoryStartEvent(notifyInventoryStartEvent);
    }

    [Register("setInventoryStartEvent", "(Z)V", "GetSetInventoryStartEvent_ZHandler")]
    public virtual unsafe void SetInventoryStartEvent(bool notifyInventoryStartEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyInventoryStartEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setInventoryStartEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetInventoryStopEvent_ZHandler()
    {
      if ((object) Events.cb_setInventoryStopEvent_Z == null)
        Events.cb_setInventoryStopEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetInventoryStopEvent_Z));
      return Events.cb_setInventoryStopEvent_Z;
    }

    private static void n_SetInventoryStopEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyInventoryStopEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetInventoryStopEvent(notifyInventoryStopEvent);
    }

    [Register("setInventoryStopEvent", "(Z)V", "GetSetInventoryStopEvent_ZHandler")]
    public virtual unsafe void SetInventoryStopEvent(bool notifyInventoryStopEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyInventoryStopEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setInventoryStopEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetOperationEndSummaryEvent_ZHandler()
    {
      if ((object) Events.cb_setOperationEndSummaryEvent_Z == null)
        Events.cb_setOperationEndSummaryEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetOperationEndSummaryEvent_Z));
      return Events.cb_setOperationEndSummaryEvent_Z;
    }

    private static void n_SetOperationEndSummaryEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyOperationEndSummary)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetOperationEndSummaryEvent(notifyOperationEndSummary);
    }

    [Register("setOperationEndSummaryEvent", "(Z)V", "GetSetOperationEndSummaryEvent_ZHandler")]
    public virtual unsafe void SetOperationEndSummaryEvent(bool notifyOperationEndSummary)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyOperationEndSummary)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setOperationEndSummaryEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetPowerEvent_ZHandler()
    {
      if ((object) Events.cb_setPowerEvent_Z == null)
        Events.cb_setPowerEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetPowerEvent_Z));
      return Events.cb_setPowerEvent_Z;
    }

    private static void n_SetPowerEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyPowerEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetPowerEvent(notifyPowerEvent);
    }

    [Register("setPowerEvent", "(Z)V", "GetSetPowerEvent_ZHandler")]
    public virtual unsafe void SetPowerEvent(bool notifyPowerEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyPowerEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setPowerEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetReaderDisconnectEvent_ZHandler()
    {
      if ((object) Events.cb_setReaderDisconnectEvent_Z == null)
        Events.cb_setReaderDisconnectEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetReaderDisconnectEvent_Z));
      return Events.cb_setReaderDisconnectEvent_Z;
    }

    private static void n_SetReaderDisconnectEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyReaderDisconnectEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetReaderDisconnectEvent(notifyReaderDisconnectEvent);
    }

    [Register("setReaderDisconnectEvent", "(Z)V", "GetSetReaderDisconnectEvent_ZHandler")]
    public virtual unsafe void SetReaderDisconnectEvent(bool notifyReaderDisconnectEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyReaderDisconnectEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderDisconnectEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetReaderExceptionEvent_ZHandler()
    {
      if ((object) Events.cb_setReaderExceptionEvent_Z == null)
        Events.cb_setReaderExceptionEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetReaderExceptionEvent_Z));
      return Events.cb_setReaderExceptionEvent_Z;
    }

    private static void n_SetReaderExceptionEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyReaderExceptionEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetReaderExceptionEvent(notifyReaderExceptionEvent);
    }

    [Register("setReaderExceptionEvent", "(Z)V", "GetSetReaderExceptionEvent_ZHandler")]
    public virtual unsafe void SetReaderExceptionEvent(bool notifyReaderExceptionEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyReaderExceptionEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderExceptionEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetRfidReConnectionStateEventsHandler()
    {
      if ((object) Events.cb_setRfidReConnectionStateEvents == null)
        Events.cb_setRfidReConnectionStateEvents = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Events.n_SetRfidReConnectionStateEvents));
      return Events.cb_setRfidReConnectionStateEvents;
    }

    private static IntPtr n_SetRfidReConnectionStateEvents(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetRfidReConnectionStateEvents());
    }

    [Register("setRfidReConnectionStateEvents", "()Ljava/lang/Boolean;", "GetSetRfidReConnectionStateEventsHandler")]
    protected virtual unsafe Boolean? SetRfidReConnectionStateEvents()
    {
      JniObjectReference jniObjectReference = Events._members.InstanceMethods.InvokeVirtualObjectMethod("setRfidReConnectionStateEvents.()Ljava/lang/Boolean;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<Boolean>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetScanDataEvent_ZHandler()
    {
      if ((object) Events.cb_setScanDataEvent_Z == null)
        Events.cb_setScanDataEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetScanDataEvent_Z));
      return Events.cb_setScanDataEvent_Z;
    }

    private static void n_SetScanDataEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyScanDataEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetScanDataEvent(notifyScanDataEvent);
    }

    [Register("setScanDataEvent", "(Z)V", "GetSetScanDataEvent_ZHandler")]
    public virtual unsafe void SetScanDataEvent(bool notifyScanDataEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyScanDataEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setScanDataEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetTagReadEvent_ZHandler()
    {
      if ((object) Events.cb_setTagReadEvent_Z == null)
        Events.cb_setTagReadEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetTagReadEvent_Z));
      return Events.cb_setTagReadEvent_Z;
    }

    private static void n_SetTagReadEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyTagReadEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetTagReadEvent(notifyTagReadEvent);
    }

    [Register("setTagReadEvent", "(Z)V", "GetSetTagReadEvent_ZHandler")]
    public virtual unsafe void SetTagReadEvent(bool notifyTagReadEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyTagReadEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setTagReadEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetTemperatureAlarmEvent_ZHandler()
    {
      if ((object) Events.cb_setTemperatureAlarmEvent_Z == null)
        Events.cb_setTemperatureAlarmEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetTemperatureAlarmEvent_Z));
      return Events.cb_setTemperatureAlarmEvent_Z;
    }

    private static void n_SetTemperatureAlarmEvent_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notifyTemperatureAlarmEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetTemperatureAlarmEvent(notifyTemperatureAlarmEvent);
    }

    [Register("setTemperatureAlarmEvent", "(Z)V", "GetSetTemperatureAlarmEvent_ZHandler")]
    public virtual unsafe void SetTemperatureAlarmEvent(bool notifyTemperatureAlarmEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyTemperatureAlarmEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setTemperatureAlarmEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetWPAEvent_ZHandler()
    {
      if ((object) Events.cb_setWPAEvent_Z == null)
        Events.cb_setWPAEvent_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Events.n_SetWPAEvent_Z));
      return Events.cb_setWPAEvent_Z;
    }

    private static void n_SetWPAEvent_Z(IntPtr jnienv, IntPtr native__this, bool notifyWPAEvent)
    {
      Object.GetObject<Events>(jnienv, native__this, (JniHandleOwnership) 0).SetWPAEvent(notifyWPAEvent);
    }

    [Register("setWPAEvent", "(Z)V", "GetSetWPAEvent_ZHandler")]
    public virtual unsafe void SetWPAEvent(bool notifyWPAEvent)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notifyWPAEvent)
      };
      Events._members.InstanceMethods.InvokeVirtualVoidMethod("setWPAEvent.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    public event EventHandler<EventReadNotifyEventArgs> EventReadNotify
    {
      add
      {
        EventHelper.AddEventHandler<IRfidEventsListener, IRfidEventsListenerImplementor>(ref this.weak_implementor_AddEventsListener, new Func<IRfidEventsListenerImplementor>(this.__CreateIRfidEventsListenerImplementor), new Action<IRfidEventsListener>(this.AddEventsListener), (Action<IRfidEventsListenerImplementor>) (__h => __h.EventReadNotifyHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IRfidEventsListener, IRfidEventsListenerImplementor>(ref this.weak_implementor_AddEventsListener, Events.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (Events.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IRfidEventsListenerImplementor, bool>(IRfidEventsListenerImplementor.__IsEmpty)), (Action<IRfidEventsListener>) (__v => this.RemoveEventsListener(__v)), (Action<IRfidEventsListenerImplementor>) (__h => __h.EventReadNotifyHandler -= value));
      }
    }

    public event EventHandler<EventStatusNotifyEventArgs> EventStatusNotify
    {
      add
      {
        EventHelper.AddEventHandler<IRfidEventsListener, IRfidEventsListenerImplementor>(ref this.weak_implementor_AddEventsListener, new Func<IRfidEventsListenerImplementor>(this.__CreateIRfidEventsListenerImplementor), new Action<IRfidEventsListener>(this.AddEventsListener), (Action<IRfidEventsListenerImplementor>) (__h => __h.EventStatusNotifyHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IRfidEventsListener, IRfidEventsListenerImplementor>(ref this.weak_implementor_AddEventsListener, Events.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (Events.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IRfidEventsListenerImplementor, bool>(IRfidEventsListenerImplementor.__IsEmpty)), (Action<IRfidEventsListener>) (__v => this.RemoveEventsListener(__v)), (Action<IRfidEventsListenerImplementor>) (__h => __h.EventStatusNotifyHandler -= value));
      }
    }

    private IRfidEventsListenerImplementor __CreateIRfidEventsListenerImplementor()
    {
      return new IRfidEventsListenerImplementor((object) this);
    }

    public event EventHandler<WifiScanDataEventsEventArgs> WifiScanDataEvents
    {
      add
      {
        EventHelper.AddEventHandler<IWifiScanDataEventsListener, IWifiScanDataEventsListenerImplementor>(ref this.weak_implementor_AddWifiScanDataEventsListener, new Func<IWifiScanDataEventsListenerImplementor>(this.__CreateIWifiScanDataEventsListenerImplementor), new Action<IWifiScanDataEventsListener>(this.AddWifiScanDataEventsListener), (Action<IWifiScanDataEventsListenerImplementor>) (__h => __h.Handler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IWifiScanDataEventsListener, IWifiScanDataEventsListenerImplementor>(ref this.weak_implementor_AddWifiScanDataEventsListener, Events.\u003C\u003EO.\u003C1\u003E____IsEmpty ?? (Events.\u003C\u003EO.\u003C1\u003E____IsEmpty = new Func<IWifiScanDataEventsListenerImplementor, bool>(IWifiScanDataEventsListenerImplementor.__IsEmpty)), (Action<IWifiScanDataEventsListener>) (__v => this.RemoveWifiScanDataEventsListener(__v)), (Action<IWifiScanDataEventsListenerImplementor>) (__h => __h.Handler -= value));
      }
    }

    private IWifiScanDataEventsListenerImplementor __CreateIWifiScanDataEventsListenerImplementor()
    {
      return new IWifiScanDataEventsListenerImplementor((object) this);
    }

    [Register("com/zebra/rfid/api3/Events$InfoData", DoNotGenerateAcw = true)]
    public class InfoData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Events$InfoData", typeof (Events.InfoData));
      private static Delegate? cb_getCause;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Events.InfoData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Events.InfoData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Events.InfoData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Events.InfoData._members.ManagedPeerType;

      protected InfoData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) Events.InfoData.cb_getCause == null)
          Events.InfoData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Events.InfoData.n_GetCause));
        return Events.InfoData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<Events.InfoData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = Events.InfoData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }
  }
}
