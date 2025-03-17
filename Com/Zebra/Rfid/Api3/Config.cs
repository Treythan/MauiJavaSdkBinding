// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Config
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Logging;
using Org.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/Config", DoNotGenerateAcw = true)]
  public class Config : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Config", typeof (Config));
    private static Delegate? cb_getBatchModeConfig;
    private static Delegate? cb_getBatteryHealth;
    private static Delegate? cb_getBatteryStats;
    private static Delegate? cb_getBeeperVolume;
    private static Delegate? cb_setBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_;
    private static Delegate? cb_getBluetoothMode;
    private static Delegate? cb_getChargeTerminalState;
    private static Delegate? cb_getCradleStatus;
    private static Delegate? cb_getDPOState;
    private static Delegate? cb_setDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_;
    private static Delegate? cb_getDefaultProfile;
    private static Delegate? cb_getDutyCycleIndex;
    private static Delegate? cb_setDutyCycleIndex_S;
    private static Delegate? cb_getFriendlyName;
    private static Delegate? cb_getKeylayoutType;
    private static Delegate? cb_GetLogBuffer;
    private static Delegate? cb_getLowerTriggerValue;
    private static Delegate? cb_getMode;
    private static Delegate? cb_getRFIDProfile;
    private static Delegate? cb_getRadioPowerState;
    private static Delegate? cb_setRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_;
    private static Delegate? cb_getReaderPowerState;
    private static Delegate? cb_setReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_;
    private static Delegate? cb_getRegulatoryConfig;
    private static Delegate? cb_setRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_;
    private static Delegate? cb_getScanBatchModeConfig;
    private static Delegate? cb_getStartTrigger;
    private static Delegate? cb_setStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_;
    private static Delegate? cb_getStopTrigger;
    private static Delegate? cb_setStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_;
    private static Delegate? cb_getTagStorageSettings;
    private static Delegate? cb_setTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_;
    private static Delegate? cb_getUniqueTagReport;
    private static Delegate? cb_getUpperTriggerValue;
    private static Delegate? cb_getUsbBatchModeConfig;
    private static Delegate? cb_getWifiState;
    private static Delegate? cb_GetSaveLlrpConfigStatus_Z;
    private static Delegate? cb_Nw_getDhcpStatus;
    private static Delegate? cb_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_;
    private static Delegate? cb_Nw_setDhcpEnable;
    private static Delegate? cb_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_;
    private static Delegate? cb_SaveLlrpConfig;
    private static Delegate? cb_getAttribute_ILcom_zebra_rfid_api3_AttributeInfo_;
    private static Delegate? cb_getCableLossCompensation_I;
    private static Delegate? cb_getDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_;
    private static Delegate? cb_getDeviceStatus_ZZZ;
    private static Delegate? cb_getDeviceStatus_ZZZZ;
    private static Delegate? cb_getDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_;
    private static Delegate? cb_getDeviceVersionInfo_Ljava_util_HashMap_;
    private static Delegate? cb_getLowerTriggerValue_Ljava_lang_String_;
    private static Delegate? cb_getRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_;
    private static Delegate? cb_getTraceLevel;
    private static Delegate? cb_getTriggerStatus;
    private static Delegate? cb_getUpperTriggerValue_Ljava_lang_String_;
    private static Delegate? cb_getreaderlog_Ljava_lang_String_Z;
    private static Delegate? cb_isUsbMiFiEnabled;
    private static Delegate? cb_resetFactoryDefaults;
    private static Delegate? cb_saveConfig;
    private static Delegate? cb_setAccessOperationWaitTimeout_I;
    private static Delegate? cb_setAttribute_Lcom_zebra_rfid_api3_SetAttribute_;
    private static Delegate? cb_setBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_;
    private static Delegate? cb_setBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_;
    private static Delegate? cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_;
    private static Delegate? cb_setChargeTerminalEnable_Z;
    private static Delegate? cb_setDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_;
    private static Delegate? cb_setDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_;
    private static Delegate? cb_setFriendlyName_Ljava_lang_String_;
    private static Delegate? cb_setInventoryModeSettings_Ljava_lang_String_I;
    private static Delegate? cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_;
    private static Delegate? cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_;
    private static Delegate? cb_setLedBlinkEnable_Z;
    private static Delegate? cb_setLogLevel_Ljava_util_logging_Level_;
    private static Delegate? cb_setOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_;
    private static Delegate? cb_setRFIDProfile_Ljava_lang_String_;
    private static Delegate? cb_setScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_;
    private static Delegate? cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_;
    private static Delegate? cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_;
    private static Delegate? cb_setTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z;
    private static Delegate? cb_setUniqueTagReport_Z;
    private static Delegate? cb_setUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_;
    private static Delegate? cb_setUsbMiFiEnable_Z;
    private static Delegate? cb_setUserFeedback_Ljava_lang_Integer_;
    private static Delegate? cb_setportalModeSettings_ILjava_lang_String_I;
    private static Delegate? cb_setreaderlog_Ljava_lang_String_Z;
    private static Delegate? cb_updateFirmware_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_wifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_;
    private static Delegate? cb_wifiConnectNonRoaming_Ljava_lang_String_;
    private static Delegate? cb_wifiConnectRoaming;
    private static Delegate? cb_wifiDeleteProfile_Ljava_lang_String_;
    private static Delegate? cb_wifiDisable;
    private static Delegate? cb_wifiDisconnect;
    private static Delegate? cb_wifiEnable;
    private static Delegate? cb_wifiGetCertificates;
    private static Delegate? cb_wifiGetStatus_Ljava_util_HashMap_;
    private static Delegate? cb_wifiListProfile;
    private static Delegate? cb_wifiSaveProfile;
    private static Delegate? cb_wifiScan;
    private static Delegate? cb_wifi_poweron_Z;

    [Register("Antennas")]
    public Antennas? Antennas
    {
      get
      {
        JniObjectReference objectValue = Config._members.InstanceFields.GetObjectValue("Antennas.Lcom/zebra/rfid/api3/Antennas;", (IJavaPeerable) this);
        return Object.GetObject<Antennas>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Config._members.InstanceFields.SetValue("Antennas.Lcom/zebra/rfid/api3/Antennas;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Config._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Config._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Config._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Config._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Config._members.ManagedPeerType;

    protected Config(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetBatchModeConfigHandler()
    {
      if ((object) Config.cb_getBatchModeConfig == null)
        Config.cb_getBatchModeConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetBatchModeConfig));
      return Config.cb_getBatchModeConfig;
    }

    private static IntPtr n_GetBatchModeConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BatchModeConfig);
    }

    public virtual unsafe BATCH_MODE? BatchModeConfig
    {
      [Register("getBatchModeConfig", "()Lcom/zebra/rfid/api3/BATCH_MODE;", "GetGetBatchModeConfigHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getBatchModeConfig.()Lcom/zebra/rfid/api3/BATCH_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetBatteryHealthHandler()
    {
      if ((object) Config.cb_getBatteryHealth == null)
        Config.cb_getBatteryHealth = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetBatteryHealth));
      return Config.cb_getBatteryHealth;
    }

    private static IntPtr n_GetBatteryHealth(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BatteryHealth);
    }

    public virtual unsafe Integer? BatteryHealth
    {
      [Register("getBatteryHealth", "()Ljava/lang/Integer;", "GetGetBatteryHealthHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getBatteryHealth.()Ljava/lang/Integer;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Integer>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetBatteryStatsHandler()
    {
      if ((object) Config.cb_getBatteryStats == null)
        Config.cb_getBatteryStats = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetBatteryStats));
      return Config.cb_getBatteryStats;
    }

    private static IntPtr n_GetBatteryStats(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BatteryStats);
    }

    public virtual unsafe BatteryStatistics? BatteryStats
    {
      [Register("getBatteryStats", "()Lcom/zebra/rfid/api3/BatteryStatistics;", "GetGetBatteryStatsHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getBatteryStats.()Lcom/zebra/rfid/api3/BatteryStatistics;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<BatteryStatistics>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetBeeperVolumeHandler()
    {
      if ((object) Config.cb_getBeeperVolume == null)
        Config.cb_getBeeperVolume = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetBeeperVolume));
      return Config.cb_getBeeperVolume;
    }

    private static IntPtr n_GetBeeperVolume(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BeeperVolume);
    }

    private static Delegate GetSetBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_Handler()
    {
      if ((object) Config.cb_setBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_ == null)
        Config.cb_setBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_));
      return Config.cb_setBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_;
    }

    private static void n_SetBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_beeperVolume)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BeeperVolume = Object.GetObject<BEEPER_VOLUME>(native_beeperVolume, (JniHandleOwnership) 0);
    }

    public virtual unsafe BEEPER_VOLUME? BeeperVolume
    {
      [Register("getBeeperVolume", "()Lcom/zebra/rfid/api3/BEEPER_VOLUME;", "GetGetBeeperVolumeHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getBeeperVolume.()Lcom/zebra/rfid/api3/BEEPER_VOLUME;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<BEEPER_VOLUME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setBeeperVolume", "(Lcom/zebra/rfid/api3/BEEPER_VOLUME;)V", "GetSetBeeperVolume_Lcom_zebra_rfid_api3_BEEPER_VOLUME_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setBeeperVolume.(Lcom/zebra/rfid/api3/BEEPER_VOLUME;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetBluetoothModeHandler()
    {
      if ((object) Config.cb_getBluetoothMode == null)
        Config.cb_getBluetoothMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetBluetoothMode));
      return Config.cb_getBluetoothMode;
    }

    private static IntPtr n_GetBluetoothMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).BluetoothMode);
    }

    public virtual unsafe ENUM_BLUETOOTH_MODE? BluetoothMode
    {
      [Register("getBluetoothMode", "()Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", "GetGetBluetoothModeHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getBluetoothMode.()Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_BLUETOOTH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetChargeTerminalStateHandler()
    {
      if ((object) Config.cb_getChargeTerminalState == null)
        Config.cb_getChargeTerminalState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Config.n_GetChargeTerminalState));
      return Config.cb_getChargeTerminalState;
    }

    private static bool n_GetChargeTerminalState(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).ChargeTerminalState;
    }

    public virtual unsafe bool ChargeTerminalState
    {
      [Register("getChargeTerminalState", "()Z", "GetGetChargeTerminalStateHandler")] get
      {
        return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("getChargeTerminalState.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetCradleStatusHandler()
    {
      if ((object) Config.cb_getCradleStatus == null)
        Config.cb_getCradleStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Config.n_GetCradleStatus));
      return Config.cb_getCradleStatus;
    }

    private static bool n_GetCradleStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).CradleStatus;
    }

    public virtual unsafe bool CradleStatus
    {
      [Register("getCradleStatus", "()Z", "GetGetCradleStatusHandler")] get
      {
        return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("getCradleStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetDPOStateHandler()
    {
      if ((object) Config.cb_getDPOState == null)
        Config.cb_getDPOState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetDPOState));
      return Config.cb_getDPOState;
    }

    private static IntPtr n_GetDPOState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).DPOState);
    }

    private static Delegate GetSetDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_Handler()
    {
      if ((object) Config.cb_setDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_ == null)
        Config.cb_setDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_));
      return Config.cb_setDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_;
    }

    private static void n_SetDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_dpoState)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).DPOState = Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(native_dpoState, (JniHandleOwnership) 0);
    }

    public virtual unsafe DYNAMIC_POWER_OPTIMIZATION? DPOState
    {
      [Register("getDPOState", "()Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;", "GetGetDPOStateHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getDPOState.()Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setDPOState", "(Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;)V", "GetSetDPOState_Lcom_zebra_rfid_api3_DYNAMIC_POWER_OPTIMIZATION_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setDPOState.(Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetDefaultProfileHandler()
    {
      if ((object) Config.cb_getDefaultProfile == null)
        Config.cb_getDefaultProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetDefaultProfile));
      return Config.cb_getDefaultProfile;
    }

    private static IntPtr n_GetDefaultProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).DefaultProfile);
    }

    public virtual unsafe string? DefaultProfile
    {
      [Register("getDefaultProfile", "()Ljava/lang/String;", "GetGetDefaultProfileHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultProfile.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDutyCycleIndexHandler()
    {
      if ((object) Config.cb_getDutyCycleIndex == null)
        Config.cb_getDutyCycleIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Config.n_GetDutyCycleIndex));
      return Config.cb_getDutyCycleIndex;
    }

    private static short n_GetDutyCycleIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).DutyCycleIndex;
    }

    private static Delegate GetSetDutyCycleIndex_SHandler()
    {
      if ((object) Config.cb_setDutyCycleIndex_S == null)
        Config.cb_setDutyCycleIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Config.n_SetDutyCycleIndex_S));
      return Config.cb_setDutyCycleIndex_S;
    }

    private static void n_SetDutyCycleIndex_S(
      IntPtr jnienv,
      IntPtr native__this,
      short dutyCycleIndex)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).DutyCycleIndex = dutyCycleIndex;
    }

    public virtual unsafe short DutyCycleIndex
    {
      [Register("getDutyCycleIndex", "()S", "GetGetDutyCycleIndexHandler")] get
      {
        return Config._members.InstanceMethods.InvokeVirtualInt16Method("getDutyCycleIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDutyCycleIndex", "(S)V", "GetSetDutyCycleIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setDutyCycleIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetFriendlyNameHandler()
    {
      if ((object) Config.cb_getFriendlyName == null)
        Config.cb_getFriendlyName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetFriendlyName));
      return Config.cb_getFriendlyName;
    }

    private static IntPtr n_GetFriendlyName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).FriendlyName);
    }

    public virtual unsafe string? FriendlyName
    {
      [Register("getFriendlyName", "()Ljava/lang/String;", "GetGetFriendlyNameHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getFriendlyName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetKeylayoutTypeHandler()
    {
      if ((object) Config.cb_getKeylayoutType == null)
        Config.cb_getKeylayoutType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetKeylayoutType));
      return Config.cb_getKeylayoutType;
    }

    private static IntPtr n_GetKeylayoutType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).KeylayoutType);
    }

    public virtual unsafe string? KeylayoutType
    {
      [Register("getKeylayoutType", "()Ljava/lang/String;", "GetGetKeylayoutTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getKeylayoutType.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetLogBufferHandler()
    {
      if ((object) Config.cb_GetLogBuffer == null)
        Config.cb_GetLogBuffer = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetLogBuffer));
      return Config.cb_GetLogBuffer;
    }

    private static IntPtr n_GetLogBuffer(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).LogBuffer);
    }

    public virtual unsafe string? LogBuffer
    {
      [Register("GetLogBuffer", "()Ljava/lang/String;", "GetGetLogBufferHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("GetLogBuffer.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetLowerTriggerValueHandler()
    {
      if ((object) Config.cb_getLowerTriggerValue == null)
        Config.cb_getLowerTriggerValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetLowerTriggerValue));
      return Config.cb_getLowerTriggerValue;
    }

    private static IntPtr n_GetLowerTriggerValue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).LowerTriggerValue);
    }

    public virtual unsafe ENUM_NEW_KEYLAYOUT_TYPE? LowerTriggerValue
    {
      [Register("getLowerTriggerValue", "()Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", "GetGetLowerTriggerValueHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getLowerTriggerValue.()Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetModeHandler()
    {
      if ((object) Config.cb_getMode == null)
        Config.cb_getMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetMode));
      return Config.cb_getMode;
    }

    private static IntPtr n_GetMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Mode);
    }

    public virtual unsafe JSONObject? Mode
    {
      [Register("getMode", "()Lorg/json/JSONObject;", "GetGetModeHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getMode.()Lorg/json/JSONObject;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<JSONObject>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRFIDProfileHandler()
    {
      if ((object) Config.cb_getRFIDProfile == null)
        Config.cb_getRFIDProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetRFIDProfile));
      return Config.cb_getRFIDProfile;
    }

    private static IntPtr n_GetRFIDProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).RFIDProfile);
    }

    public virtual unsafe string? RFIDProfile
    {
      [Register("getRFIDProfile", "()Ljava/lang/String;", "GetGetRFIDProfileHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getRFIDProfile.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioPowerStateHandler()
    {
      if ((object) Config.cb_getRadioPowerState == null)
        Config.cb_getRadioPowerState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetRadioPowerState));
      return Config.cb_getRadioPowerState;
    }

    private static IntPtr n_GetRadioPowerState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).RadioPowerState);
    }

    private static Delegate GetSetRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_Handler()
    {
      if ((object) Config.cb_setRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_ == null)
        Config.cb_setRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_));
      return Config.cb_setRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_;
    }

    private static void n_SetRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_radioPowerState)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).RadioPowerState = Object.GetObject<RADIO_POWER_STATE>(native_radioPowerState, (JniHandleOwnership) 0);
    }

    public virtual unsafe RADIO_POWER_STATE? RadioPowerState
    {
      [Register("getRadioPowerState", "()Lcom/zebra/rfid/api3/RADIO_POWER_STATE;", "GetGetRadioPowerStateHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioPowerState.()Lcom/zebra/rfid/api3/RADIO_POWER_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RADIO_POWER_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setRadioPowerState", "(Lcom/zebra/rfid/api3/RADIO_POWER_STATE;)V", "GetSetRadioPowerState_Lcom_zebra_rfid_api3_RADIO_POWER_STATE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setRadioPowerState.(Lcom/zebra/rfid/api3/RADIO_POWER_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetReaderPowerStateHandler()
    {
      if ((object) Config.cb_getReaderPowerState == null)
        Config.cb_getReaderPowerState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetReaderPowerState));
      return Config.cb_getReaderPowerState;
    }

    private static IntPtr n_GetReaderPowerState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).ReaderPowerState);
    }

    private static Delegate GetSetReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_Handler()
    {
      if ((object) Config.cb_setReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_ == null)
        Config.cb_setReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_));
      return Config.cb_setReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_;
    }

    private static void n_SetReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerPowerState)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).ReaderPowerState = Object.GetObject<READER_POWER_STATE>(native_readerPowerState, (JniHandleOwnership) 0);
    }

    public virtual unsafe READER_POWER_STATE? ReaderPowerState
    {
      [Register("getReaderPowerState", "()Lcom/zebra/rfid/api3/READER_POWER_STATE;", "GetGetReaderPowerStateHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderPowerState.()Lcom/zebra/rfid/api3/READER_POWER_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setReaderPowerState", "(Lcom/zebra/rfid/api3/READER_POWER_STATE;)V", "GetSetReaderPowerState_Lcom_zebra_rfid_api3_READER_POWER_STATE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderPowerState.(Lcom/zebra/rfid/api3/READER_POWER_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetRegulatoryConfigHandler()
    {
      if ((object) Config.cb_getRegulatoryConfig == null)
        Config.cb_getRegulatoryConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetRegulatoryConfig));
      return Config.cb_getRegulatoryConfig;
    }

    private static IntPtr n_GetRegulatoryConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).RegulatoryConfig);
    }

    private static Delegate GetSetRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_Handler()
    {
      if ((object) Config.cb_setRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_ == null)
        Config.cb_setRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_));
      return Config.cb_setRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_;
    }

    private static void n_SetRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_regulatoryConfig)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).RegulatoryConfig = Object.GetObject<RegulatoryConfig>(native_regulatoryConfig, (JniHandleOwnership) 0);
    }

    public virtual unsafe RegulatoryConfig? RegulatoryConfig
    {
      [Register("getRegulatoryConfig", "()Lcom/zebra/rfid/api3/RegulatoryConfig;", "GetGetRegulatoryConfigHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getRegulatoryConfig.()Lcom/zebra/rfid/api3/RegulatoryConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RegulatoryConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setRegulatoryConfig", "(Lcom/zebra/rfid/api3/RegulatoryConfig;)V", "GetSetRegulatoryConfig_Lcom_zebra_rfid_api3_RegulatoryConfig_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setRegulatoryConfig.(Lcom/zebra/rfid/api3/RegulatoryConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetScanBatchModeConfigHandler()
    {
      if ((object) Config.cb_getScanBatchModeConfig == null)
        Config.cb_getScanBatchModeConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetScanBatchModeConfig));
      return Config.cb_getScanBatchModeConfig;
    }

    private static IntPtr n_GetScanBatchModeConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).ScanBatchModeConfig);
    }

    public virtual unsafe SCAN_BATCH_MODE? ScanBatchModeConfig
    {
      [Register("getScanBatchModeConfig", "()Lcom/zebra/rfid/api3/SCAN_BATCH_MODE;", "GetGetScanBatchModeConfigHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getScanBatchModeConfig.()Lcom/zebra/rfid/api3/SCAN_BATCH_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SCAN_BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStartTriggerHandler()
    {
      if ((object) Config.cb_getStartTrigger == null)
        Config.cb_getStartTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetStartTrigger));
      return Config.cb_getStartTrigger;
    }

    private static IntPtr n_GetStartTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).StartTrigger);
    }

    private static Delegate GetSetStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_Handler()
    {
      if ((object) Config.cb_setStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_ == null)
        Config.cb_setStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_));
      return Config.cb_setStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_;
    }

    private static void n_SetStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_startTrigger)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).StartTrigger = Object.GetObject<StartTrigger>(native_startTrigger, (JniHandleOwnership) 0);
    }

    public virtual unsafe StartTrigger? StartTrigger
    {
      [Register("getStartTrigger", "()Lcom/zebra/rfid/api3/StartTrigger;", "GetGetStartTriggerHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getStartTrigger.()Lcom/zebra/rfid/api3/StartTrigger;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<StartTrigger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setStartTrigger", "(Lcom/zebra/rfid/api3/StartTrigger;)V", "GetSetStartTrigger_Lcom_zebra_rfid_api3_StartTrigger_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setStartTrigger.(Lcom/zebra/rfid/api3/StartTrigger;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetStopTriggerHandler()
    {
      if ((object) Config.cb_getStopTrigger == null)
        Config.cb_getStopTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetStopTrigger));
      return Config.cb_getStopTrigger;
    }

    private static IntPtr n_GetStopTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).StopTrigger);
    }

    private static Delegate GetSetStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_Handler()
    {
      if ((object) Config.cb_setStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_ == null)
        Config.cb_setStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_));
      return Config.cb_setStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_;
    }

    private static void n_SetStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_stopTrigger)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).StopTrigger = Object.GetObject<StopTrigger>(native_stopTrigger, (JniHandleOwnership) 0);
    }

    public virtual unsafe StopTrigger? StopTrigger
    {
      [Register("getStopTrigger", "()Lcom/zebra/rfid/api3/StopTrigger;", "GetGetStopTriggerHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getStopTrigger.()Lcom/zebra/rfid/api3/StopTrigger;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<StopTrigger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setStopTrigger", "(Lcom/zebra/rfid/api3/StopTrigger;)V", "GetSetStopTrigger_Lcom_zebra_rfid_api3_StopTrigger_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setStopTrigger.(Lcom/zebra/rfid/api3/StopTrigger;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetTagStorageSettingsHandler()
    {
      if ((object) Config.cb_getTagStorageSettings == null)
        Config.cb_getTagStorageSettings = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetTagStorageSettings));
      return Config.cb_getTagStorageSettings;
    }

    private static IntPtr n_GetTagStorageSettings(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).TagStorageSettings);
    }

    private static Delegate GetSetTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_Handler()
    {
      if ((object) Config.cb_setTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_ == null)
        Config.cb_setTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_));
      return Config.cb_setTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_;
    }

    private static void n_SetTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagStorageSettings)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).TagStorageSettings = Object.GetObject<TagStorageSettings>(native_tagStorageSettings, (JniHandleOwnership) 0);
    }

    public virtual unsafe TagStorageSettings? TagStorageSettings
    {
      [Register("getTagStorageSettings", "()Lcom/zebra/rfid/api3/TagStorageSettings;", "GetGetTagStorageSettingsHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getTagStorageSettings.()Lcom/zebra/rfid/api3/TagStorageSettings;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<TagStorageSettings>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTagStorageSettings", "(Lcom/zebra/rfid/api3/TagStorageSettings;)V", "GetSetTagStorageSettings_Lcom_zebra_rfid_api3_TagStorageSettings_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          Config._members.InstanceMethods.InvokeVirtualVoidMethod("setTagStorageSettings.(Lcom/zebra/rfid/api3/TagStorageSettings;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetUniqueTagReportHandler()
    {
      if ((object) Config.cb_getUniqueTagReport == null)
        Config.cb_getUniqueTagReport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetUniqueTagReport));
      return Config.cb_getUniqueTagReport;
    }

    private static IntPtr n_GetUniqueTagReport(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).UniqueTagReport);
    }

    public virtual unsafe UNIQUE_TAG_REPORT_SETTING? UniqueTagReport
    {
      [Register("getUniqueTagReport", "()Lcom/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING;", "GetGetUniqueTagReportHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getUniqueTagReport.()Lcom/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<UNIQUE_TAG_REPORT_SETTING>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUpperTriggerValueHandler()
    {
      if ((object) Config.cb_getUpperTriggerValue == null)
        Config.cb_getUpperTriggerValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetUpperTriggerValue));
      return Config.cb_getUpperTriggerValue;
    }

    private static IntPtr n_GetUpperTriggerValue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).UpperTriggerValue);
    }

    public virtual unsafe ENUM_NEW_KEYLAYOUT_TYPE? UpperTriggerValue
    {
      [Register("getUpperTriggerValue", "()Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", "GetGetUpperTriggerValueHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getUpperTriggerValue.()Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUsbBatchModeConfigHandler()
    {
      if ((object) Config.cb_getUsbBatchModeConfig == null)
        Config.cb_getUsbBatchModeConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetUsbBatchModeConfig));
      return Config.cb_getUsbBatchModeConfig;
    }

    private static IntPtr n_GetUsbBatchModeConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).UsbBatchModeConfig);
    }

    public virtual unsafe USB_BATCH_MODE? UsbBatchModeConfig
    {
      [Register("getUsbBatchModeConfig", "()Lcom/zebra/rfid/api3/USB_BATCH_MODE;", "GetGetUsbBatchModeConfigHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getUsbBatchModeConfig.()Lcom/zebra/rfid/api3/USB_BATCH_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<USB_BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetWifiStateHandler()
    {
      if ((object) Config.cb_getWifiState == null)
        Config.cb_getWifiState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetWifiState));
      return Config.cb_getWifiState;
    }

    private static IntPtr n_GetWifiState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiState);
    }

    public virtual unsafe ENUM_WIFI_STATE? WifiState
    {
      [Register("getWifiState", "()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", "GetGetWifiStateHandler")] get
      {
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getWifiState.()Lcom/zebra/rfid/api3/ENUM_WIFI_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_WIFI_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSaveLlrpConfigStatus_ZHandler()
    {
      if ((object) Config.cb_GetSaveLlrpConfigStatus_Z == null)
        Config.cb_GetSaveLlrpConfigStatus_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Config.n_GetSaveLlrpConfigStatus_Z));
      return Config.cb_GetSaveLlrpConfigStatus_Z;
    }

    private static void n_GetSaveLlrpConfigStatus_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool pSaveStatus)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetSaveLlrpConfigStatus(pSaveStatus);
    }

    [Register("GetSaveLlrpConfigStatus", "(Z)V", "GetGetSaveLlrpConfigStatus_ZHandler")]
    public virtual unsafe void GetSaveLlrpConfigStatus(bool pSaveStatus)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(pSaveStatus)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("GetSaveLlrpConfigStatus.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetNw_getDhcpStatusHandler()
    {
      if ((object) Config.cb_Nw_getDhcpStatus == null)
        Config.cb_Nw_getDhcpStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Config.n_Nw_getDhcpStatus));
      return Config.cb_Nw_getDhcpStatus;
    }

    private static bool n_Nw_getDhcpStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Nw_getDhcpStatus();
    }

    [Register("Nw_getDhcpStatus", "()Z", "GetNw_getDhcpStatusHandler")]
    public virtual unsafe bool Nw_getDhcpStatus()
    {
      return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("Nw_getDhcpStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetNw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_Handler()
    {
      if ((object) Config.cb_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_ == null)
        Config.cb_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_));
      return Config.cb_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_;
    }

    private static IntPtr n_Nw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_networkconfig)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Nw_getNetworkStatus(Object.GetObject<Network_IPConfig>(native_networkconfig, (JniHandleOwnership) 0)));
    }

    [Register("Nw_getNetworkStatus", "(Lcom/zebra/rfid/api3/Network_IPConfig;)Lcom/zebra/rfid/api3/RFIDResults;", "GetNw_getNetworkStatus_Lcom_zebra_rfid_api3_Network_IPConfig_Handler")]
    public virtual unsafe RFIDResults? Nw_getNetworkStatus(Network_IPConfig? networkconfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(networkconfig == null ? IntPtr.Zero : networkconfig.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("Nw_getNetworkStatus.(Lcom/zebra/rfid/api3/Network_IPConfig;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) networkconfig);
      }
    }

    private static Delegate GetNw_setDhcpEnableHandler()
    {
      if ((object) Config.cb_Nw_setDhcpEnable == null)
        Config.cb_Nw_setDhcpEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_Nw_setDhcpEnable));
      return Config.cb_Nw_setDhcpEnable;
    }

    private static IntPtr n_Nw_setDhcpEnable(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Nw_setDhcpEnable());
    }

    [Register("Nw_setDhcpEnable", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetNw_setDhcpEnableHandler")]
    public virtual unsafe RFIDResults? Nw_setDhcpEnable()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("Nw_setDhcpEnable.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetNw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_Handler()
    {
      if ((object) Config.cb_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_ == null)
        Config.cb_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_));
      return Config.cb_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_;
    }

    private static IntPtr n_Nw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_networkconfig)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Nw_setStaticIP(Object.GetObject<Network_IPConfig>(native_networkconfig, (JniHandleOwnership) 0)));
    }

    [Register("Nw_setStaticIP", "(Lcom/zebra/rfid/api3/Network_IPConfig;)Lcom/zebra/rfid/api3/RFIDResults;", "GetNw_setStaticIP_Lcom_zebra_rfid_api3_Network_IPConfig_Handler")]
    public virtual unsafe RFIDResults? Nw_setStaticIP(Network_IPConfig? networkconfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(networkconfig == null ? IntPtr.Zero : networkconfig.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("Nw_setStaticIP.(Lcom/zebra/rfid/api3/Network_IPConfig;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) networkconfig);
      }
    }

    private static Delegate GetSaveLlrpConfigHandler()
    {
      if ((object) Config.cb_SaveLlrpConfig == null)
        Config.cb_SaveLlrpConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Config.n_SaveLlrpConfig));
      return Config.cb_SaveLlrpConfig;
    }

    private static void n_SaveLlrpConfig(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SaveLlrpConfig();
    }

    [Register("SaveLlrpConfig", "()V", "GetSaveLlrpConfigHandler")]
    public virtual unsafe void SaveLlrpConfig()
    {
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("SaveLlrpConfig.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAttribute_ILcom_zebra_rfid_api3_AttributeInfo_Handler()
    {
      if ((object) Config.cb_getAttribute_ILcom_zebra_rfid_api3_AttributeInfo_ == null)
        Config.cb_getAttribute_ILcom_zebra_rfid_api3_AttributeInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIL_L(Config.n_GetAttribute_ILcom_zebra_rfid_api3_AttributeInfo_));
      return Config.cb_getAttribute_ILcom_zebra_rfid_api3_AttributeInfo_;
    }

    private static IntPtr n_GetAttribute_ILcom_zebra_rfid_api3_AttributeInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      int attributeNumber,
      IntPtr native_attributeInfo)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      AttributeInfo attributeInfo1 = Object.GetObject<AttributeInfo>(native_attributeInfo, (JniHandleOwnership) 0);
      int attributeNumber1 = attributeNumber;
      AttributeInfo attributeInfo2 = attributeInfo1;
      return JNIEnv.ToLocalJniHandle((IJavaObject) config.GetAttribute(attributeNumber1, attributeInfo2));
    }

    [Register("getAttribute", "(ILcom/zebra/rfid/api3/AttributeInfo;)Lcom/zebra/rfid/api3/AttributeInfo;", "GetGetAttribute_ILcom_zebra_rfid_api3_AttributeInfo_Handler")]
    public virtual unsafe AttributeInfo? GetAttribute(
      int attributeNumber,
      AttributeInfo? attributeInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(attributeNumber),
          new JniArgumentValue(attributeInfo == null ? IntPtr.Zero : attributeInfo.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getAttribute.(ILcom/zebra/rfid/api3/AttributeInfo;)Lcom/zebra/rfid/api3/AttributeInfo;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<AttributeInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) attributeInfo);
      }
    }

    private static Delegate GetGetCableLossCompensation_IHandler()
    {
      if ((object) Config.cb_getCableLossCompensation_I == null)
        Config.cb_getCableLossCompensation_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Config.n_GetCableLossCompensation_I));
      return Config.cb_getCableLossCompensation_I;
    }

    private static IntPtr n_GetCableLossCompensation_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetCableLossCompensation(antennaID));
    }

    [Register("getCableLossCompensation", "(I)Lcom/zebra/rfid/api3/CableLossCompensation;", "GetGetCableLossCompensation_IHandler")]
    public virtual unsafe CableLossCompensation? GetCableLossCompensation(int antennaID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaID)
      };
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getCableLossCompensation.(I)Lcom/zebra/rfid/api3/CableLossCompensation;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<CableLossCompensation>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Handler()
    {
      if ((object) Config.cb_getDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_ == null)
        Config.cb_getDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_GetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_));
      return Config.cb_getDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_;
    }

    private static IntPtr n_GetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_deviceProperty)
    {
      return JNIEnv.NewString(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceProperty(Object.GetObject<ENUM_DEVICE_PROPERTY>(native_deviceProperty, (JniHandleOwnership) 0)));
    }

    [Register("getDeviceProperty", "(Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;)Ljava/lang/String;", "GetGetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Handler")]
    public virtual unsafe string? GetDeviceProperty(ENUM_DEVICE_PROPERTY? deviceProperty)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(deviceProperty == null ? IntPtr.Zero : ((Object) deviceProperty).Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceProperty.(Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) deviceProperty);
      }
    }

    private static Delegate GetGetDeviceStatus_ZZZHandler()
    {
      if ((object) Config.cb_getDeviceStatus_ZZZ == null)
        Config.cb_getDeviceStatus_ZZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZZZ_V(Config.n_GetDeviceStatus_ZZZ));
      return Config.cb_getDeviceStatus_ZZZ;
    }

    private static void n_GetDeviceStatus_ZZZ(
      IntPtr jnienv,
      IntPtr native__this,
      bool battery,
      bool power,
      bool temperature)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceStatus(battery, power, temperature);
    }

    [Register("getDeviceStatus", "(ZZZ)V", "GetGetDeviceStatus_ZZZHandler")]
    public virtual unsafe void GetDeviceStatus(bool battery, bool power, bool temperature)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
      {
        new JniArgumentValue(battery),
        new JniArgumentValue(power),
        new JniArgumentValue(temperature)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("getDeviceStatus.(ZZZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetDeviceStatus_ZZZZHandler()
    {
      if ((object) Config.cb_getDeviceStatus_ZZZZ == null)
        Config.cb_getDeviceStatus_ZZZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZZZZ_V(Config.n_GetDeviceStatus_ZZZZ));
      return Config.cb_getDeviceStatus_ZZZZ;
    }

    private static void n_GetDeviceStatus_ZZZZ(
      IntPtr jnienv,
      IntPtr native__this,
      bool battery,
      bool power,
      bool temperature,
      bool onCradle)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceStatus(battery, power, temperature, onCradle);
    }

    [Register("getDeviceStatus", "(ZZZZ)V", "GetGetDeviceStatus_ZZZZHandler")]
    public virtual unsafe void GetDeviceStatus(
      bool battery,
      bool power,
      bool temperature,
      bool onCradle)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
      {
        new JniArgumentValue(battery),
        new JniArgumentValue(power),
        new JniArgumentValue(temperature),
        new JniArgumentValue(onCradle)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("getDeviceStatus.(ZZZZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_Handler()
    {
      if ((object) Config.cb_getDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_ == null)
        Config.cb_getDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_GetDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_));
      return Config.cb_getDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_;
    }

    private static IntPtr n_GetDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_deviceStatus)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceStatus(Object.GetObject<DeviceStatus>(native_deviceStatus, (JniHandleOwnership) 0)));
    }

    [Register("getDeviceStatus", "(Lcom/zebra/rfid/api3/DeviceStatus;)Lcom/zebra/rfid/api3/RFIDResults;", "GetGetDeviceStatus_Lcom_zebra_rfid_api3_DeviceStatus_Handler")]
    public virtual unsafe RFIDResults? GetDeviceStatus(DeviceStatus? deviceStatus)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(deviceStatus == null ? IntPtr.Zero : deviceStatus.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceStatus.(Lcom/zebra/rfid/api3/DeviceStatus;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) deviceStatus);
      }
    }

    private static Delegate GetGetDeviceVersionInfo_Ljava_util_HashMap_Handler()
    {
      if ((object) Config.cb_getDeviceVersionInfo_Ljava_util_HashMap_ == null)
        Config.cb_getDeviceVersionInfo_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_GetDeviceVersionInfo_Ljava_util_HashMap_));
      return Config.cb_getDeviceVersionInfo_Ljava_util_HashMap_;
    }

    private static void n_GetDeviceVersionInfo_Ljava_util_HashMap_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_deviceVersion)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceVersionInfo(JavaDictionary<string, string>.FromJniHandle(native_deviceVersion, (JniHandleOwnership) 0));
    }

    [Register("getDeviceVersionInfo", "(Ljava/util/HashMap;)V", "GetGetDeviceVersionInfo_Ljava_util_HashMap_Handler")]
    public virtual unsafe void GetDeviceVersionInfo(IDictionary<string, string>? deviceVersion)
    {
      IntPtr localJniHandle = JavaDictionary<string, string>.ToLocalJniHandle(deviceVersion);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(localJniHandle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("getDeviceVersionInfo.(Ljava/util/HashMap;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(localJniHandle);
        GC.KeepAlive((object) deviceVersion);
      }
    }

    private static Delegate GetGetLowerTriggerValue_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_getLowerTriggerValue_Ljava_lang_String_ == null)
        Config.cb_getLowerTriggerValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_GetLowerTriggerValue_Ljava_lang_String_));
      return Config.cb_getLowerTriggerValue_Ljava_lang_String_;
    }

    private static IntPtr n_GetLowerTriggerValue_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_klType)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetLowerTriggerValue(JNIEnv.GetString(native_klType, (JniHandleOwnership) 0)));
    }

    [Register("getLowerTriggerValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", "GetGetLowerTriggerValue_Ljava_lang_String_Handler")]
    public virtual unsafe ENUM_NEW_KEYLAYOUT_TYPE? GetLowerTriggerValue(string? klType)
    {
      IntPtr num = JNIEnv.NewString(klType);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getLowerTriggerValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_Handler()
    {
      if ((object) Config.cb_getRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_ == null)
        Config.cb_getRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_GetRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_));
      return Config.cb_getRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_;
    }

    private static IntPtr n_GetRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_regionInfo)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetRegionInfo(Object.GetObject<RegionInfo>(native_regionInfo, (JniHandleOwnership) 0)));
    }

    [Register("getRegionInfo", "(Lcom/zebra/rfid/api3/RegionInfo;)Lcom/zebra/rfid/api3/RegionInfo;", "GetGetRegionInfo_Lcom_zebra_rfid_api3_RegionInfo_Handler")]
    public virtual unsafe RegionInfo? GetRegionInfo(RegionInfo? regionInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(regionInfo == null ? IntPtr.Zero : regionInfo.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getRegionInfo.(Lcom/zebra/rfid/api3/RegionInfo;)Lcom/zebra/rfid/api3/RegionInfo;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RegionInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) regionInfo);
      }
    }

    private static Delegate GetGetTraceLevelHandler()
    {
      if ((object) Config.cb_getTraceLevel == null)
        Config.cb_getTraceLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_GetTraceLevel));
      return Config.cb_getTraceLevel;
    }

    private static IntPtr n_GetTraceLevel(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<TRACE_LEVEL>(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetTraceLevel());
    }

    [Register("getTraceLevel", "()[Lcom/zebra/rfid/api3/TRACE_LEVEL;", "GetGetTraceLevelHandler")]
    public virtual unsafe TRACE_LEVEL[]? GetTraceLevel()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getTraceLevel.()[Lcom/zebra/rfid/api3/TRACE_LEVEL;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (TRACE_LEVEL[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TRACE_LEVEL));
    }

    private static Delegate GetGetTriggerStatusHandler()
    {
      if ((object) Config.cb_getTriggerStatus == null)
        Config.cb_getTriggerStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Config.n_GetTriggerStatus));
      return Config.cb_getTriggerStatus;
    }

    private static void n_GetTriggerStatus(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetTriggerStatus();
    }

    [Register("getTriggerStatus", "()V", "GetGetTriggerStatusHandler")]
    public virtual unsafe void GetTriggerStatus()
    {
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("getTriggerStatus.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetUpperTriggerValue_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_getUpperTriggerValue_Ljava_lang_String_ == null)
        Config.cb_getUpperTriggerValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_GetUpperTriggerValue_Ljava_lang_String_));
      return Config.cb_getUpperTriggerValue_Ljava_lang_String_;
    }

    private static IntPtr n_GetUpperTriggerValue_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_klType)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).GetUpperTriggerValue(JNIEnv.GetString(native_klType, (JniHandleOwnership) 0)));
    }

    [Register("getUpperTriggerValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", "GetGetUpperTriggerValue_Ljava_lang_String_Handler")]
    public virtual unsafe ENUM_NEW_KEYLAYOUT_TYPE? GetUpperTriggerValue(string? klType)
    {
      IntPtr num = JNIEnv.NewString(klType);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("getUpperTriggerValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetreaderlog_Ljava_lang_String_ZHandler()
    {
      if ((object) Config.cb_getreaderlog_Ljava_lang_String_Z == null)
        Config.cb_getreaderlog_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(Config.n_Getreaderlog_Ljava_lang_String_Z));
      return Config.cb_getreaderlog_Ljava_lang_String_Z;
    }

    private static void n_Getreaderlog_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logtype,
      bool state)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Getreaderlog(JNIEnv.GetString(native_logtype, (JniHandleOwnership) 0), state);
    }

    [Register("getreaderlog", "(Ljava/lang/String;Z)V", "GetGetreaderlog_Ljava_lang_String_ZHandler")]
    public virtual unsafe void Getreaderlog(string? logtype, bool state)
    {
      IntPtr num = JNIEnv.NewString(logtype);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(state)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("getreaderlog.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetIsUsbMiFiEnabledHandler()
    {
      if ((object) Config.cb_isUsbMiFiEnabled == null)
        Config.cb_isUsbMiFiEnabled = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_IsUsbMiFiEnabled));
      return Config.cb_isUsbMiFiEnabled;
    }

    private static IntPtr n_IsUsbMiFiEnabled(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).IsUsbMiFiEnabled());
    }

    [Register("isUsbMiFiEnabled", "()Ljava/lang/Boolean;", "GetIsUsbMiFiEnabledHandler")]
    public virtual unsafe Boolean? IsUsbMiFiEnabled()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("isUsbMiFiEnabled.()Ljava/lang/Boolean;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<Boolean>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetResetFactoryDefaultsHandler()
    {
      if ((object) Config.cb_resetFactoryDefaults == null)
        Config.cb_resetFactoryDefaults = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Config.n_ResetFactoryDefaults));
      return Config.cb_resetFactoryDefaults;
    }

    private static void n_ResetFactoryDefaults(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).ResetFactoryDefaults();
    }

    [Register("resetFactoryDefaults", "()V", "GetResetFactoryDefaultsHandler")]
    public virtual unsafe void ResetFactoryDefaults()
    {
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("resetFactoryDefaults.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSaveConfigHandler()
    {
      if ((object) Config.cb_saveConfig == null)
        Config.cb_saveConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Config.n_SaveConfig));
      return Config.cb_saveConfig;
    }

    private static void n_SaveConfig(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SaveConfig();
    }

    [Register("saveConfig", "()V", "GetSaveConfigHandler")]
    public virtual unsafe void SaveConfig()
    {
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("saveConfig.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetAccessOperationWaitTimeout_IHandler()
    {
      if ((object) Config.cb_setAccessOperationWaitTimeout_I == null)
        Config.cb_setAccessOperationWaitTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Config.n_SetAccessOperationWaitTimeout_I));
      return Config.cb_setAccessOperationWaitTimeout_I;
    }

    private static void n_SetAccessOperationWaitTimeout_I(
      IntPtr jnienv,
      IntPtr native__this,
      int timeout)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetAccessOperationWaitTimeout(timeout);
    }

    [Register("setAccessOperationWaitTimeout", "(I)V", "GetSetAccessOperationWaitTimeout_IHandler")]
    public virtual unsafe void SetAccessOperationWaitTimeout(int timeout)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(timeout)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessOperationWaitTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetAttribute_Lcom_zebra_rfid_api3_SetAttribute_Handler()
    {
      if ((object) Config.cb_setAttribute_Lcom_zebra_rfid_api3_SetAttribute_ == null)
        Config.cb_setAttribute_Lcom_zebra_rfid_api3_SetAttribute_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetAttribute_Lcom_zebra_rfid_api3_SetAttribute_));
      return Config.cb_setAttribute_Lcom_zebra_rfid_api3_SetAttribute_;
    }

    private static void n_SetAttribute_Lcom_zebra_rfid_api3_SetAttribute_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_setAttributeInfo)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetAttribute(Object.GetObject<Com.Zebra.Rfid.Api3.SetAttribute>(native_setAttributeInfo, (JniHandleOwnership) 0));
    }

    [Register("setAttribute", "(Lcom/zebra/rfid/api3/SetAttribute;)V", "GetSetAttribute_Lcom_zebra_rfid_api3_SetAttribute_Handler")]
    public virtual unsafe void SetAttribute(Com.Zebra.Rfid.Api3.SetAttribute? setAttributeInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(setAttributeInfo == null ? IntPtr.Zero : setAttributeInfo.Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setAttribute.(Lcom/zebra/rfid/api3/SetAttribute;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) setAttributeInfo);
      }
    }

    private static Delegate GetSetBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_Handler()
    {
      if ((object) Config.cb_setBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_ == null)
        Config.cb_setBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_));
      return Config.cb_setBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_;
    }

    private static void n_SetBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_batchMode)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetBatchMode(Object.GetObject<BATCH_MODE>(native_batchMode, (JniHandleOwnership) 0));
    }

    [Register("setBatchMode", "(Lcom/zebra/rfid/api3/BATCH_MODE;)V", "GetSetBatchMode_Lcom_zebra_rfid_api3_BATCH_MODE_Handler")]
    public virtual unsafe void SetBatchMode(BATCH_MODE? batchMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(batchMode == null ? IntPtr.Zero : batchMode.Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setBatchMode.(Lcom/zebra/rfid/api3/BATCH_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) batchMode);
      }
    }

    private static Delegate GetSetBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_Handler()
    {
      if ((object) Config.cb_setBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_ == null)
        Config.cb_setBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_SetBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_));
      return Config.cb_setBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_;
    }

    private static IntPtr n_SetBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mode)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetBluetoothMode(Object.GetObject<ENUM_BLUETOOTH_MODE>(native_mode, (JniHandleOwnership) 0)));
    }

    [Register("setBluetoothMode", "(Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetBluetoothMode_Lcom_zebra_rfid_api3_ENUM_BLUETOOTH_MODE_Handler")]
    public virtual unsafe RFIDResults? SetBluetoothMode(ENUM_BLUETOOTH_MODE? mode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(mode == null ? IntPtr.Zero : ((Object) mode).Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setBluetoothMode.(Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) mode);
      }
    }

    private static Delegate GetSetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_Handler()
    {
      if ((object) Config.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_ == null)
        Config.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_SetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_));
      return Config.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_;
    }

    private static IntPtr n_SetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cableLossCompensationInfo)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      CableLossCompensation[] array = (CableLossCompensation[]) JNIEnv.GetArray(native_cableLossCompensationInfo, (JniHandleOwnership) 0, typeof (CableLossCompensation));
      CableLossCompensation[] cableLossCompensationInfo = array;
      IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) config.SetCableLossCompensation(cableLossCompensationInfo));
      if (array == null)
        return localJniHandle;
      JNIEnv.CopyArray<CableLossCompensation>(array, native_cableLossCompensationInfo);
      return localJniHandle;
    }

    [Register("setCableLossCompensation", "([Lcom/zebra/rfid/api3/CableLossCompensation;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_Handler")]
    public virtual unsafe RFIDResults? SetCableLossCompensation(
      CableLossCompensation[]? cableLossCompensationInfo)
    {
      IntPtr num = JNIEnv.NewArray<CableLossCompensation>(cableLossCompensationInfo);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setCableLossCompensation.([Lcom/zebra/rfid/api3/CableLossCompensation;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (cableLossCompensationInfo != null)
        {
          JNIEnv.CopyArray<CableLossCompensation>(num, cableLossCompensationInfo);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) cableLossCompensationInfo);
      }
    }

    private static Delegate GetSetChargeTerminalEnable_ZHandler()
    {
      if ((object) Config.cb_setChargeTerminalEnable_Z == null)
        Config.cb_setChargeTerminalEnable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(Config.n_SetChargeTerminalEnable_Z));
      return Config.cb_setChargeTerminalEnable_Z;
    }

    private static IntPtr n_SetChargeTerminalEnable_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enable)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetChargeTerminalEnable(enable));
    }

    [Register("setChargeTerminalEnable", "(Z)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetChargeTerminalEnable_ZHandler")]
    public virtual unsafe RFIDResults? SetChargeTerminalEnable(bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setChargeTerminalEnable.(Z)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_Handler()
    {
      if ((object) Config.cb_setDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_ == null)
        Config.cb_setDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZZL_Z(Config.n_SetDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_));
      return Config.cb_setDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_;
    }

    private static bool n_SetDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_antennaRfConfig,
      IntPtr native_singulationControl,
      IntPtr native_tagStorageSettings,
      bool deleteAllPrefilters,
      bool dpoEnable,
      IntPtr native_setAttributes)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      Antennas.AntennaRfConfig antennaRfConfig1 = Object.GetObject<Antennas.AntennaRfConfig>(native_antennaRfConfig, (JniHandleOwnership) 0);
      Antennas.SingulationControl singulationControl1 = Object.GetObject<Antennas.SingulationControl>(native_singulationControl, (JniHandleOwnership) 0);
      TagStorageSettings tagStorageSettings1 = Object.GetObject<TagStorageSettings>(native_tagStorageSettings, (JniHandleOwnership) 0);
      Com.Zebra.Rfid.Api3.SetAttribute[] array = (Com.Zebra.Rfid.Api3.SetAttribute[]) JNIEnv.GetArray(native_setAttributes, (JniHandleOwnership) 0, typeof (Com.Zebra.Rfid.Api3.SetAttribute));
      Antennas.AntennaRfConfig antennaRfConfig2 = antennaRfConfig1;
      Antennas.SingulationControl singulationControl2 = singulationControl1;
      TagStorageSettings tagStorageSettings2 = tagStorageSettings1;
      int num1 = deleteAllPrefilters ? 1 : 0;
      int num2 = dpoEnable ? 1 : 0;
      Com.Zebra.Rfid.Api3.SetAttribute[] setAttributes = array;
      int num3 = config.SetDefaultConfigurations(antennaRfConfig2, singulationControl2, tagStorageSettings2, num1 != 0, num2 != 0, setAttributes) ? 1 : 0;
      if (array == null)
        return num3 != 0;
      JNIEnv.CopyArray<Com.Zebra.Rfid.Api3.SetAttribute>(array, native_setAttributes);
      return num3 != 0;
    }

    [Register("setDefaultConfigurations", "(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;Lcom/zebra/rfid/api3/Antennas$SingulationControl;Lcom/zebra/rfid/api3/TagStorageSettings;ZZ[Lcom/zebra/rfid/api3/SetAttribute;)Z", "GetSetDefaultConfigurations_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Lcom_zebra_rfid_api3_TagStorageSettings_ZZarrayLcom_zebra_rfid_api3_SetAttribute_Handler")]
    public virtual unsafe bool SetDefaultConfigurations(
      Antennas.AntennaRfConfig? antennaRfConfig,
      Antennas.SingulationControl? singulationControl,
      TagStorageSettings? tagStorageSettings,
      bool deleteAllPrefilters,
      bool dpoEnable,
      Com.Zebra.Rfid.Api3.SetAttribute[]? setAttributes)
    {
      IntPtr num = JNIEnv.NewArray<Com.Zebra.Rfid.Api3.SetAttribute>(setAttributes);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[6]
        {
          new JniArgumentValue(antennaRfConfig == null ? IntPtr.Zero : antennaRfConfig.Handle),
          new JniArgumentValue(singulationControl == null ? IntPtr.Zero : singulationControl.Handle),
          new JniArgumentValue(tagStorageSettings == null ? IntPtr.Zero : tagStorageSettings.Handle),
          new JniArgumentValue(deleteAllPrefilters),
          new JniArgumentValue(dpoEnable),
          new JniArgumentValue(num)
        };
        return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("setDefaultConfigurations.(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;Lcom/zebra/rfid/api3/Antennas$SingulationControl;Lcom/zebra/rfid/api3/TagStorageSettings;ZZ[Lcom/zebra/rfid/api3/SetAttribute;)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (setAttributes != null)
        {
          JNIEnv.CopyArray<Com.Zebra.Rfid.Api3.SetAttribute>(num, setAttributes);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) antennaRfConfig);
        GC.KeepAlive((object) singulationControl);
        GC.KeepAlive((object) tagStorageSettings);
        GC.KeepAlive((object) setAttributes);
      }
    }

    private static Delegate GetSetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_setDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_ == null)
        Config.cb_setDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(Config.n_SetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_));
      return Config.cb_setDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_;
    }

    private static void n_SetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_deviceProperty,
      IntPtr native_value)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      ENUM_DEVICE_PROPERTY enumDeviceProperty = Object.GetObject<ENUM_DEVICE_PROPERTY>(native_deviceProperty, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
      ENUM_DEVICE_PROPERTY deviceProperty = enumDeviceProperty;
      string str2 = str1;
      config.SetDeviceProperty(deviceProperty, str2);
    }

    [Register("setDeviceProperty", "(Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;Ljava/lang/String;)V", "GetSetDeviceProperty_Lcom_zebra_rfid_api3_ENUM_DEVICE_PROPERTY_Ljava_lang_String_Handler")]
    public virtual unsafe void SetDeviceProperty(ENUM_DEVICE_PROPERTY? deviceProperty, string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(deviceProperty == null ? IntPtr.Zero : ((Object) deviceProperty).Handle),
          new JniArgumentValue(num)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setDeviceProperty.(Lcom/zebra/rfid/api3/ENUM_DEVICE_PROPERTY;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) deviceProperty);
      }
    }

    private static Delegate GetSetFriendlyName_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_setFriendlyName_Ljava_lang_String_ == null)
        Config.cb_setFriendlyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_SetFriendlyName_Ljava_lang_String_));
      return Config.cb_setFriendlyName_Ljava_lang_String_;
    }

    private static IntPtr n_SetFriendlyName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_friendlyName)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetFriendlyName(JNIEnv.GetString(native_friendlyName, (JniHandleOwnership) 0)));
    }

    [Register("setFriendlyName", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetFriendlyName_Ljava_lang_String_Handler")]
    public virtual unsafe RFIDResults? SetFriendlyName(string? friendlyName)
    {
      IntPtr num = JNIEnv.NewString(friendlyName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setFriendlyName.(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetInventoryModeSettings_Ljava_lang_String_IHandler()
    {
      if ((object) Config.cb_setInventoryModeSettings_Ljava_lang_String_I == null)
        Config.cb_setInventoryModeSettings_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(Config.n_SetInventoryModeSettings_Ljava_lang_String_I));
      return Config.cb_setInventoryModeSettings_Ljava_lang_String_I;
    }

    private static void n_SetInventoryModeSettings_Ljava_lang_String_I(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_unit,
      int value)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetInventoryModeSettings(JNIEnv.GetString(native_unit, (JniHandleOwnership) 0), value);
    }

    [Register("setInventoryModeSettings", "(Ljava/lang/String;I)V", "GetSetInventoryModeSettings_Ljava_lang_String_IHandler")]
    public virtual unsafe void SetInventoryModeSettings(string? unit, int value)
    {
      IntPtr num = JNIEnv.NewString(unit);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(value)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setInventoryModeSettings.(Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_Handler()
    {
      if ((object) Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_ == null)
        Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_SetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_));
      return Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_;
    }

    private static IntPtr n_SetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_keylayoutType)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetKeylayoutType(Object.GetObject<ENUM_KEYLAYOUT_TYPE>(native_keylayoutType, (JniHandleOwnership) 0)));
    }

    [Register("setKeylayoutType", "(Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_Handler")]
    public virtual unsafe RFIDResults? SetKeylayoutType(ENUM_KEYLAYOUT_TYPE? keylayoutType)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(keylayoutType == null ? IntPtr.Zero : ((Object) keylayoutType).Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setKeylayoutType.(Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) keylayoutType);
      }
    }

    private static Delegate GetSetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Handler()
    {
      if ((object) Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_ == null)
        Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(Config.n_SetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_));
      return Config.cb_setKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_;
    }

    private static IntPtr n_SetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_upperTriggerval,
      IntPtr native_lowerTriggerval)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      ENUM_NEW_KEYLAYOUT_TYPE newKeylayoutType1 = Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(native_upperTriggerval, (JniHandleOwnership) 0);
      ENUM_NEW_KEYLAYOUT_TYPE newKeylayoutType2 = Object.GetObject<ENUM_NEW_KEYLAYOUT_TYPE>(native_lowerTriggerval, (JniHandleOwnership) 0);
      ENUM_NEW_KEYLAYOUT_TYPE upperTriggerval = newKeylayoutType1;
      ENUM_NEW_KEYLAYOUT_TYPE lowerTriggerval = newKeylayoutType2;
      return JNIEnv.ToLocalJniHandle((IJavaObject) config.SetKeylayoutType(upperTriggerval, lowerTriggerval));
    }

    [Register("setKeylayoutType", "(Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetKeylayoutType_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Lcom_zebra_rfid_api3_ENUM_NEW_KEYLAYOUT_TYPE_Handler")]
    public virtual unsafe RFIDResults? SetKeylayoutType(
      ENUM_NEW_KEYLAYOUT_TYPE? upperTriggerval,
      ENUM_NEW_KEYLAYOUT_TYPE? lowerTriggerval)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(upperTriggerval == null ? IntPtr.Zero : ((Object) upperTriggerval).Handle),
          new JniArgumentValue(lowerTriggerval == null ? IntPtr.Zero : ((Object) lowerTriggerval).Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setKeylayoutType.(Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;Lcom/zebra/rfid/api3/ENUM_NEW_KEYLAYOUT_TYPE;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) upperTriggerval);
        GC.KeepAlive((object) lowerTriggerval);
      }
    }

    private static Delegate GetSetLedBlinkEnable_ZHandler()
    {
      if ((object) Config.cb_setLedBlinkEnable_Z == null)
        Config.cb_setLedBlinkEnable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Config.n_SetLedBlinkEnable_Z));
      return Config.cb_setLedBlinkEnable_Z;
    }

    private static void n_SetLedBlinkEnable_Z(IntPtr jnienv, IntPtr native__this, bool enable)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetLedBlinkEnable(enable);
    }

    [Register("setLedBlinkEnable", "(Z)V", "GetSetLedBlinkEnable_ZHandler")]
    public virtual unsafe void SetLedBlinkEnable(bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("setLedBlinkEnable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetLogLevel_Ljava_util_logging_Level_Handler()
    {
      if ((object) Config.cb_setLogLevel_Ljava_util_logging_Level_ == null)
        Config.cb_setLogLevel_Ljava_util_logging_Level_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetLogLevel_Ljava_util_logging_Level_));
      return Config.cb_setLogLevel_Ljava_util_logging_Level_;
    }

    private static void n_SetLogLevel_Ljava_util_logging_Level_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logLevel)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetLogLevel(Object.GetObject<Level>(native_logLevel, (JniHandleOwnership) 0));
    }

    [Register("setLogLevel", "(Ljava/util/logging/Level;)V", "GetSetLogLevel_Ljava_util_logging_Level_Handler")]
    public virtual unsafe void SetLogLevel(Level? logLevel)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(logLevel == null ? IntPtr.Zero : ((Object) logLevel).Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setLogLevel.(Ljava/util/logging/Level;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) logLevel);
      }
    }

    private static Delegate GetSetOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_Handler()
    {
      if ((object) Config.cb_setOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_ == null)
        Config.cb_setOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_));
      return Config.cb_setOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_;
    }

    private static void n_SetOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_operatingMode)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetOperatingMode(Object.GetObject<ENUM_OPERATING_MODE>(native_operatingMode, (JniHandleOwnership) 0));
    }

    [Register("setOperatingMode", "(Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;)V", "GetSetOperatingMode_Lcom_zebra_rfid_api3_ENUM_OPERATING_MODE_Handler")]
    public virtual unsafe void SetOperatingMode(ENUM_OPERATING_MODE? operatingMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(operatingMode == null ? IntPtr.Zero : ((Object) operatingMode).Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setOperatingMode.(Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) operatingMode);
      }
    }

    private static Delegate GetSetRFIDProfile_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_setRFIDProfile_Ljava_lang_String_ == null)
        Config.cb_setRFIDProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_Z(Config.n_SetRFIDProfile_Ljava_lang_String_));
      return Config.cb_setRFIDProfile_Ljava_lang_String_;
    }

    private static bool n_SetRFIDProfile_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetRFIDProfile(JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0));
    }

    [Register("setRFIDProfile", "(Ljava/lang/String;)Z", "GetSetRFIDProfile_Ljava_lang_String_Handler")]
    public virtual unsafe bool SetRFIDProfile(string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("setRFIDProfile.(Ljava/lang/String;)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_Handler()
    {
      if ((object) Config.cb_setScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_ == null)
        Config.cb_setScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_SetScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_));
      return Config.cb_setScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_;
    }

    private static IntPtr n_SetScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_scanBatchMode)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetScanBatchMode(Object.GetObject<SCAN_BATCH_MODE>(native_scanBatchMode, (JniHandleOwnership) 0)));
    }

    [Register("setScanBatchMode", "(Lcom/zebra/rfid/api3/SCAN_BATCH_MODE;)Lcom/zebra/rfid/api3/RFIDResults;", "GetSetScanBatchMode_Lcom_zebra_rfid_api3_SCAN_BATCH_MODE_Handler")]
    public virtual unsafe RFIDResults? SetScanBatchMode(SCAN_BATCH_MODE? scanBatchMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(scanBatchMode == null ? IntPtr.Zero : scanBatchMode.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("setScanBatchMode.(Lcom/zebra/rfid/api3/SCAN_BATCH_MODE;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) scanBatchMode);
      }
    }

    private static Delegate GetSetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_Handler()
    {
      if ((object) Config.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_ == null)
        Config.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_));
      return Config.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_;
    }

    private static void n_SetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_traceLevel)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetTraceLevel(Object.GetObject<TRACE_LEVEL>(native_traceLevel, (JniHandleOwnership) 0));
    }

    [Register("setTraceLevel", "(Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", "GetSetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_Handler")]
    public virtual unsafe void SetTraceLevel(TRACE_LEVEL? traceLevel)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(traceLevel == null ? IntPtr.Zero : traceLevel.Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setTraceLevel.(Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) traceLevel);
      }
    }

    private static Delegate GetSetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_Handler()
    {
      if ((object) Config.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_ == null)
        Config.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_));
      return Config.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_;
    }

    private static void n_SetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_arrTraceLevel)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      TRACE_LEVEL[] array = (TRACE_LEVEL[]) JNIEnv.GetArray(native_arrTraceLevel, (JniHandleOwnership) 0, typeof (TRACE_LEVEL));
      TRACE_LEVEL[] arrTraceLevel = array;
      config.SetTraceLevel(arrTraceLevel);
      if (array == null)
        return;
      JNIEnv.CopyArray<TRACE_LEVEL>(array, native_arrTraceLevel);
    }

    [Register("setTraceLevel", "([Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", "GetSetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_Handler")]
    public virtual unsafe void SetTraceLevel(TRACE_LEVEL[]? arrTraceLevel)
    {
      IntPtr num = JNIEnv.NewArray<TRACE_LEVEL>(arrTraceLevel);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setTraceLevel.([Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (arrTraceLevel != null)
        {
          JNIEnv.CopyArray<TRACE_LEVEL>(num, arrTraceLevel);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) arrTraceLevel);
      }
    }

    private static Delegate GetSetTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_ZHandler()
    {
      if ((object) Config.cb_setTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z == null)
        Config.cb_setTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_Z(Config.n_SetTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z));
      return Config.cb_setTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z;
    }

    private static bool n_SetTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_trigger_mode,
      bool updateScannerPlugin)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetTriggerMode(Object.GetObject<ENUM_TRIGGER_MODE>(native_trigger_mode, (JniHandleOwnership) 0), updateScannerPlugin);
    }

    [Register("setTriggerMode", "(Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;Z)Z", "GetSetTriggerMode_Lcom_zebra_rfid_api3_ENUM_TRIGGER_MODE_ZHandler")]
    public virtual unsafe bool SetTriggerMode(
      ENUM_TRIGGER_MODE? trigger_mode,
      bool updateScannerPlugin)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(trigger_mode == null ? IntPtr.Zero : ((Object) trigger_mode).Handle),
          new JniArgumentValue(updateScannerPlugin)
        };
        return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("setTriggerMode.(Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;Z)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) trigger_mode);
      }
    }

    private static Delegate GetSetUniqueTagReport_ZHandler()
    {
      if ((object) Config.cb_setUniqueTagReport_Z == null)
        Config.cb_setUniqueTagReport_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_Z(Config.n_SetUniqueTagReport_Z));
      return Config.cb_setUniqueTagReport_Z;
    }

    private static bool n_SetUniqueTagReport_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool uniqueTagReport)
    {
      return Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetUniqueTagReport(uniqueTagReport);
    }

    [Register("setUniqueTagReport", "(Z)Z", "GetSetUniqueTagReport_ZHandler")]
    public virtual unsafe bool SetUniqueTagReport(bool uniqueTagReport)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(uniqueTagReport)
      };
      return Config._members.InstanceMethods.InvokeVirtualBooleanMethod("setUniqueTagReport.(Z)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_Handler()
    {
      if ((object) Config.cb_setUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_ == null)
        Config.cb_setUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_));
      return Config.cb_setUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_;
    }

    private static void n_SetUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_usbBatchMode)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetUsbBatchMode(Object.GetObject<USB_BATCH_MODE>(native_usbBatchMode, (JniHandleOwnership) 0));
    }

    [Register("setUsbBatchMode", "(Lcom/zebra/rfid/api3/USB_BATCH_MODE;)V", "GetSetUsbBatchMode_Lcom_zebra_rfid_api3_USB_BATCH_MODE_Handler")]
    public virtual unsafe void SetUsbBatchMode(USB_BATCH_MODE? usbBatchMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(usbBatchMode == null ? IntPtr.Zero : usbBatchMode.Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setUsbBatchMode.(Lcom/zebra/rfid/api3/USB_BATCH_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) usbBatchMode);
      }
    }

    private static Delegate GetSetUsbMiFiEnable_ZHandler()
    {
      if ((object) Config.cb_setUsbMiFiEnable_Z == null)
        Config.cb_setUsbMiFiEnable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Config.n_SetUsbMiFiEnable_Z));
      return Config.cb_setUsbMiFiEnable_Z;
    }

    private static void n_SetUsbMiFiEnable_Z(IntPtr jnienv, IntPtr native__this, bool enable)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetUsbMiFiEnable(enable);
    }

    [Register("setUsbMiFiEnable", "(Z)V", "GetSetUsbMiFiEnable_ZHandler")]
    public virtual unsafe void SetUsbMiFiEnable(bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      Config._members.InstanceMethods.InvokeVirtualVoidMethod("setUsbMiFiEnable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetUserFeedback_Ljava_lang_Integer_Handler()
    {
      if ((object) Config.cb_setUserFeedback_Ljava_lang_Integer_ == null)
        Config.cb_setUserFeedback_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Config.n_SetUserFeedback_Ljava_lang_Integer_));
      return Config.cb_setUserFeedback_Ljava_lang_Integer_;
    }

    private static void n_SetUserFeedback_Ljava_lang_Integer_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profile)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).SetUserFeedback(Object.GetObject<Integer>(native_profile, (JniHandleOwnership) 0));
    }

    [Register("setUserFeedback", "(Ljava/lang/Integer;)V", "GetSetUserFeedback_Ljava_lang_Integer_Handler")]
    public virtual unsafe void SetUserFeedback(Integer? profile)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(profile == null ? IntPtr.Zero : ((Object) profile).Handle)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setUserFeedback.(Ljava/lang/Integer;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) profile);
      }
    }

    private static Delegate GetSetportalModeSettings_ILjava_lang_String_IHandler()
    {
      if ((object) Config.cb_setportalModeSettings_ILjava_lang_String_I == null)
        Config.cb_setportalModeSettings_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPILI_V(Config.n_SetportalModeSettings_ILjava_lang_String_I));
      return Config.cb_setportalModeSettings_ILjava_lang_String_I;
    }

    private static void n_SetportalModeSettings_ILjava_lang_String_I(
      IntPtr jnienv,
      IntPtr native__this,
      int port,
      IntPtr native_signal,
      int stopInterval)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_signal, (JniHandleOwnership) 0);
      int port1 = port;
      string signal = str;
      int stopInterval1 = stopInterval;
      config.SetportalModeSettings(port1, signal, stopInterval1);
    }

    [Register("setportalModeSettings", "(ILjava/lang/String;I)V", "GetSetportalModeSettings_ILjava_lang_String_IHandler")]
    public virtual unsafe void SetportalModeSettings(int port, string? signal, int stopInterval)
    {
      IntPtr num = JNIEnv.NewString(signal);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(port),
          new JniArgumentValue(num),
          new JniArgumentValue(stopInterval)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setportalModeSettings.(ILjava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetreaderlog_Ljava_lang_String_ZHandler()
    {
      if ((object) Config.cb_setreaderlog_Ljava_lang_String_Z == null)
        Config.cb_setreaderlog_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(Config.n_Setreaderlog_Ljava_lang_String_Z));
      return Config.cb_setreaderlog_Ljava_lang_String_Z;
    }

    private static void n_Setreaderlog_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logtype,
      bool state)
    {
      Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Setreaderlog(JNIEnv.GetString(native_logtype, (JniHandleOwnership) 0), state);
    }

    [Register("setreaderlog", "(Ljava/lang/String;Z)V", "GetSetreaderlog_Ljava_lang_String_ZHandler")]
    public virtual unsafe void Setreaderlog(string? logtype, bool state)
    {
      IntPtr num = JNIEnv.NewString(logtype);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(state)
        };
        Config._members.InstanceMethods.InvokeVirtualVoidMethod("setreaderlog.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetUpdateFirmware_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_updateFirmware_Ljava_lang_String_Ljava_lang_String_ == null)
        Config.cb_updateFirmware_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(Config.n_UpdateFirmware_Ljava_lang_String_Ljava_lang_String_));
      return Config.cb_updateFirmware_Ljava_lang_String_Ljava_lang_String_;
    }

    private static IntPtr n_UpdateFirmware_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_path,
      IntPtr native_ip)
    {
      Config config = Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_path, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_ip, (JniHandleOwnership) 0);
      string path = str1;
      string ip = str2;
      return JNIEnv.ToLocalJniHandle((IJavaObject) config.UpdateFirmware(path, ip));
    }

    [Register("updateFirmware", "(Ljava/lang/String;Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", "GetUpdateFirmware_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe RFIDResults? UpdateFirmware(string? path, string? ip)
    {
      IntPtr num1 = JNIEnv.NewString(path);
      IntPtr num2 = JNIEnv.NewString(ip);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("updateFirmware.(Ljava/lang/String;Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetWifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_Handler()
    {
      if ((object) Config.cb_wifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_ == null)
        Config.cb_wifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_WifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_));
      return Config.cb_wifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_;
    }

    private static IntPtr n_WifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_wifiprofile)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiAddProfile(Object.GetObject<WifiProfile>(native_wifiprofile, (JniHandleOwnership) 0)));
    }

    [Register("wifiAddProfile", "(Lcom/zebra/rfid/api3/WifiProfile;)Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiAddProfile_Lcom_zebra_rfid_api3_WifiProfile_Handler")]
    public virtual unsafe RFIDResults? WifiAddProfile(WifiProfile? wifiprofile)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(wifiprofile == null ? IntPtr.Zero : wifiprofile.Handle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiAddProfile.(Lcom/zebra/rfid/api3/WifiProfile;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) wifiprofile);
      }
    }

    private static Delegate GetWifiConnectNonRoaming_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_wifiConnectNonRoaming_Ljava_lang_String_ == null)
        Config.cb_wifiConnectNonRoaming_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_WifiConnectNonRoaming_Ljava_lang_String_));
      return Config.cb_wifiConnectNonRoaming_Ljava_lang_String_;
    }

    private static IntPtr n_WifiConnectNonRoaming_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_ssid)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiConnectNonRoaming(JNIEnv.GetString(native_ssid, (JniHandleOwnership) 0)));
    }

    [Register("wifiConnectNonRoaming", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiConnectNonRoaming_Ljava_lang_String_Handler")]
    public virtual unsafe RFIDResults? WifiConnectNonRoaming(string? ssid)
    {
      IntPtr num = JNIEnv.NewString(ssid);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiConnectNonRoaming.(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetWifiConnectRoamingHandler()
    {
      if ((object) Config.cb_wifiConnectRoaming == null)
        Config.cb_wifiConnectRoaming = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiConnectRoaming));
      return Config.cb_wifiConnectRoaming;
    }

    private static IntPtr n_WifiConnectRoaming(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiConnectRoaming());
    }

    [Register("wifiConnectRoaming", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiConnectRoamingHandler")]
    public virtual unsafe RFIDResults? WifiConnectRoaming()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiConnectRoaming.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiDeleteProfile_Ljava_lang_String_Handler()
    {
      if ((object) Config.cb_wifiDeleteProfile_Ljava_lang_String_ == null)
        Config.cb_wifiDeleteProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_WifiDeleteProfile_Ljava_lang_String_));
      return Config.cb_wifiDeleteProfile_Ljava_lang_String_;
    }

    private static IntPtr n_WifiDeleteProfile_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_ssid)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiDeleteProfile(JNIEnv.GetString(native_ssid, (JniHandleOwnership) 0)));
    }

    [Register("wifiDeleteProfile", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiDeleteProfile_Ljava_lang_String_Handler")]
    public virtual unsafe RFIDResults? WifiDeleteProfile(string? ssid)
    {
      IntPtr num = JNIEnv.NewString(ssid);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiDeleteProfile.(Ljava/lang/String;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetWifiDisableHandler()
    {
      if ((object) Config.cb_wifiDisable == null)
        Config.cb_wifiDisable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiDisable));
      return Config.cb_wifiDisable;
    }

    private static IntPtr n_WifiDisable(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiDisable());
    }

    [Register("wifiDisable", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiDisableHandler")]
    public virtual unsafe RFIDResults? WifiDisable()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiDisable.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiDisconnectHandler()
    {
      if ((object) Config.cb_wifiDisconnect == null)
        Config.cb_wifiDisconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiDisconnect));
      return Config.cb_wifiDisconnect;
    }

    private static IntPtr n_WifiDisconnect(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiDisconnect());
    }

    [Register("wifiDisconnect", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiDisconnectHandler")]
    public virtual unsafe RFIDResults? WifiDisconnect()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiDisconnect.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiEnableHandler()
    {
      if ((object) Config.cb_wifiEnable == null)
        Config.cb_wifiEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiEnable));
      return Config.cb_wifiEnable;
    }

    private static IntPtr n_WifiEnable(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiEnable());
    }

    [Register("wifiEnable", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiEnableHandler")]
    public virtual unsafe RFIDResults? WifiEnable()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiEnable.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiGetCertificatesHandler()
    {
      if ((object) Config.cb_wifiGetCertificates == null)
        Config.cb_wifiGetCertificates = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiGetCertificates));
      return Config.cb_wifiGetCertificates;
    }

    private static IntPtr n_WifiGetCertificates(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<string>.ToLocalJniHandle(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiGetCertificates());
    }

    [Register("wifiGetCertificates", "()Ljava/util/ArrayList;", "GetWifiGetCertificatesHandler")]
    public virtual unsafe IList<string>? WifiGetCertificates()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiGetCertificates.()Ljava/util/ArrayList;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JavaList<string>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiGetStatus_Ljava_util_HashMap_Handler()
    {
      if ((object) Config.cb_wifiGetStatus_Ljava_util_HashMap_ == null)
        Config.cb_wifiGetStatus_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Config.n_WifiGetStatus_Ljava_util_HashMap_));
      return Config.cb_wifiGetStatus_Ljava_util_HashMap_;
    }

    private static IntPtr n_WifiGetStatus_Ljava_util_HashMap_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_status)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiGetStatus(JavaDictionary<string, string>.FromJniHandle(native_status, (JniHandleOwnership) 0)));
    }

    [Register("wifiGetStatus", "(Ljava/util/HashMap;)Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiGetStatus_Ljava_util_HashMap_Handler")]
    public virtual unsafe RFIDResults? WifiGetStatus(IDictionary<string, string>? status)
    {
      IntPtr localJniHandle = JavaDictionary<string, string>.ToLocalJniHandle(status);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(localJniHandle)
        };
        JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiGetStatus.(Ljava/util/HashMap;)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(localJniHandle);
        GC.KeepAlive((object) status);
      }
    }

    private static Delegate GetWifiListProfileHandler()
    {
      if ((object) Config.cb_wifiListProfile == null)
        Config.cb_wifiListProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiListProfile));
      return Config.cb_wifiListProfile;
    }

    private static IntPtr n_WifiListProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<WifiProfile>.ToLocalJniHandle(Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiListProfile());
    }

    [Register("wifiListProfile", "()Ljava/util/ArrayList;", "GetWifiListProfileHandler")]
    public virtual unsafe IList<WifiProfile>? WifiListProfile()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiListProfile.()Ljava/util/ArrayList;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JavaList<WifiProfile>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiSaveProfileHandler()
    {
      if ((object) Config.cb_wifiSaveProfile == null)
        Config.cb_wifiSaveProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiSaveProfile));
      return Config.cb_wifiSaveProfile;
    }

    private static IntPtr n_WifiSaveProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiSaveProfile());
    }

    [Register("wifiSaveProfile", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiSaveProfileHandler")]
    public virtual unsafe RFIDResults? WifiSaveProfile()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiSaveProfile.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifiScanHandler()
    {
      if ((object) Config.cb_wifiScan == null)
        Config.cb_wifiScan = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Config.n_WifiScan));
      return Config.cb_wifiScan;
    }

    private static IntPtr n_WifiScan(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).WifiScan());
    }

    [Register("wifiScan", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetWifiScanHandler")]
    public virtual unsafe RFIDResults? WifiScan()
    {
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifiScan.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetWifi_poweron_ZHandler()
    {
      if ((object) Config.cb_wifi_poweron_Z == null)
        Config.cb_wifi_poweron_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(Config.n_Wifi_poweron_Z));
      return Config.cb_wifi_poweron_Z;
    }

    private static IntPtr n_Wifi_poweron_Z(IntPtr jnienv, IntPtr native__this, bool poweron)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Config>(jnienv, native__this, (JniHandleOwnership) 0).Wifi_poweron(poweron));
    }

    [Register("wifi_poweron", "(Z)Lcom/zebra/rfid/api3/RFIDResults;", "GetWifi_poweron_ZHandler")]
    public virtual unsafe RFIDResults? Wifi_poweron(bool poweron)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(poweron)
      };
      JniObjectReference jniObjectReference = Config._members.InstanceMethods.InvokeVirtualObjectMethod("wifi_poweron.(Z)Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
