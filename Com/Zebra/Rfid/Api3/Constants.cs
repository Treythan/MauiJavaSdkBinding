// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Constants
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
  [Register("com/zebra/rfid/api3/Constants", DoNotGenerateAcw = true)]
  public class Constants : Object
  {
    [Register("ACTION_READER_AVAILABLE")]
    public const string ActionReaderAvailable = "available";
    [Register("ACTION_READER_BATTERY_CHARGING")]
    public const string ActionReaderBatteryCharging = "battery.charging";
    [Register("ACTION_READER_BATTERY_CRITICAL")]
    public const string ActionReaderBatteryCritical = "battery.critical";
    [Register("ACTION_READER_BATTERY_LOW")]
    public const string ActionReaderBatteryLow = "battery.low";
    [Register("ACTION_READER_CONNECTED")]
    public const string ActionReaderConnected = "connected";
    [Register("ACTION_READER_CONN_FAILED")]
    public const string ActionReaderConnFailed = "connection.failed";
    [Register("ACTION_READER_DISAPPERED")]
    public const string ActionReaderDisappered = "disappeared";
    [Register("ACTION_READER_DISCONNECTED")]
    public const string ActionReaderDisconnected = "disconnected";
    [Register("ACTION_READER_OFF")]
    public const string ActionReaderOff = "reader_off";
    [Register("ACTION_READER_ON")]
    public const string ActionReaderOn = "reader_on";
    [Register("ACTION_READER_STATUS_OBTAINED")]
    public const string ActionReaderStatusObtained = "status.received";
    [Register("ACTION_USB_DEVICE_ATTACHED")]
    public const string ActionUsbDeviceAttached = "attached";
    [Register("ACTION_USB_DEVICE_DEATTACHED")]
    public const string ActionUsbDeviceDeattached = "deattached";
    [Register("AUTO_DETECT_READERS")]
    public const string AutoDetectReaders = "AutoDetectReaders";
    [Register("AUTO_RECONNECTION_COUNT")]
    public const int AutoReconnectionCount = 5;
    [Register("AUTO_RECONNECT_READERS")]
    public const string AutoReconnectReaders = "AutoReconnectReaders";
    [Register("BATTERY_LEVEL_REQ_STRING")]
    public const string BatteryLevelReqString = "getdevicestatus .batterylevel";
    [Register("CONNECTION_SETTINGS_STATUS")]
    public const string ConnectionSettingsStatus = "ConnectionSettingStatus";
    [Register("DATA_BLUETOOTH_DEVICE")]
    public const string DataBluetoothDevice = "com.rfid.data.bluetooth.device";
    [Register("DEBUG")]
    public const bool Debug = false;
    [Register("DOMAIN_ETSI_302_208_STD_INDEX_HONG_KONG_1")]
    public const int DomainEtsi302208StdIndexHongKong1 = 6;
    [Register("DOMAIN_ETSI_302_208_STD_INDEX_NEWETSI_GENERIC")]
    public const int DomainEtsi302208StdIndexNewetsiGeneric = 2;
    [Register("DOMAIN_FCC_Part_15_STD_INDEX_KOREA_FHSS")]
    public const int DOMAINFCCPart15STDINDEXKOREAFHSS = 4;
    [Register("DOMAIN_STD_INDEX_CAMBODIA_ETSI")]
    public const int DomainStdIndexCambodiaEtsi = 31;
    [Register("DOMAIN_STD_INDEX_India")]
    public const int DOMAINSTDINDEXIndia = 25;
    [Register("DOMAIN_STD_INDEX_Israel")]
    public const int DOMAINSTDINDEXIsrael = 22;
    [Register("DOMAIN_STD_INDEX_Japan_Generic")]
    public const int DOMAINSTDINDEXJapanGeneric = 12;
    [Register("DOMAIN_STD_INDEX_Japan_LBT")]
    public const int DOMAINSTDINDEXJapanLBT = 18;
    [Register("DOMAIN_STD_INDEX_LAOS_ETSI")]
    public const int DomainStdIndexLaosEtsi = 28;
    [Register("DOMAIN_STD_INDEX_Vietnam_ETSI")]
    public const int DOMAINSTDINDEXVietnamETSI = 24;
    [Register("DURATION")]
    public const string Duration = "Duration";
    [Register("EPC_MEMORY")]
    public const string EpcMemory = "EPC MEMORY";
    [Register("FILTER_1_ACTION")]
    public const string Filter1Action = "Filter1Action";
    [Register("FILTER_1_ENABLED")]
    public const string Filter1Enabled = "Filter1Enabled";
    [Register("FILTER_1_MEMORY_BANK")]
    public const string Filter1MemoryBank = "Filter1MemoryBank";
    [Register("FILTER_1_OFFSET")]
    public const string Filter1Offset = "Filter1Offset";
    [Register("FILTER_1_STATUS")]
    public const string Filter1Status = "Filter1Status";
    [Register("FILTER_1_TAG_PATTERN")]
    public const string Filter1TagPattern = "Filter1TagPattern";
    [Register("FILTER_1_TARGET")]
    public const string Filter1Target = "Filter1Target";
    [Register("FILTER_2_ACTION")]
    public const string Filter2Action = "Filter2Action";
    [Register("FILTER_2_ENABLED")]
    public const string Filter2Enabled = "Filter2Enabled";
    [Register("FILTER_2_MEMORY_BANK")]
    public const string Filter2MemoryBank = "Filter2MemoryBank";
    [Register("FILTER_2_OFFSET")]
    public const string Filter2Offset = "Filter2Offset";
    [Register("FILTER_2_STATUS")]
    public const string Filter2Status = "Filter2Status";
    [Register("FILTER_2_TAG_PATTERN")]
    public const string Filter2TagPattern = "Filter2TagPattern";
    [Register("FILTER_2_TARGET")]
    public const string Filter2Target = "Filter2Target";
    [Register("GENX_DEVICE")]
    public const string GenxDevice = "RFID_DEVICE";
    [Register("HANDHELD")]
    public const string Handheld = "Handheld";
    [Register("IMMEDIATE")]
    public const string Immediate = "Immediate";
    [Register("INTENT_ACTION")]
    public const string IntentAction = "intent_action";
    [Register("INTENT_DATA")]
    public const string IntentData = "intent_data";
    [Register("LOCATE_TAG_EMPTY")]
    public const string LocateTagEmpty = "Please fill Tag Id";
    [Register("NGE")]
    public const string Nge = "NGE";
    [Register("NOTIFICATIONS_ID")]
    public const string NotificationsId = "notifications_id";
    [Register("NOTIFICATIONS_TEXT")]
    public const string NotificationsText = "notifications_text";
    [Register("NOTIFY_BATTERY_STATUS")]
    public const string NotifyBatteryStatus = "NotifyBatteryStatus";
    [Register("NOTIFY_READER_AVAILABLE")]
    public const string NotifyReaderAvailable = "NotifyReaderAvailable";
    [Register("NOTIFY_READER_CONNECTION")]
    public const string NotifyReaderConnection = "NotifyReaderConnection";
    [Register("N_ATTEMPTS")]
    public const string NAttempts = "N attempts";
    [Register("OFF")]
    public const string Off = "DISABLE";
    [Register("ON")]
    public const string On = "ENABLE";
    [Register("PERIODIC")]
    public const string Periodic = "Periodic";
    [Register("RESERVED_MEMORY")]
    public const string ReservedMemory = "RESERVED MEMORY";
    [Register("RESPONSE_TIMEOUT")]
    public const int ResponseTimeout = 6000;
    [Register("SAVE_CONFIG_COMMAND_STRING")]
    public const string SaveConfigCommandString = "saveconfig ";
    [Register("SETTING_ITEM_ID")]
    public const string SettingItemId = "settingItemId";
    [Register("START_TRIGGER_HANDHELD_PRESSED_CHECKED")]
    public const string StartTriggerHandheldPressedChecked = "StartTriggersHandheldPressed";
    [Register("START_TRIGGER_HANDHELD_RELEASED_CHECKED")]
    public const string StartTriggerHandheldReleasedChecked = "StartTriggersHandheldReleased";
    [Register("START_TRIGGER_PERIODIC_DURATION")]
    public const string StartTriggerPeriodicDuration = "StartTriggersPeriodicDuration";
    [Register("START_TRIGGER_PERIODIC_START_TIME")]
    public const string StartTriggerPeriodicStartTime = "StartTriggersPeriodicStartTime";
    [Register("START_TRIGGER_STATUS")]
    public const string StartTriggerStatus = "StartTriggersStatus";
    [Register("STOP_TRIGGER_DURATION")]
    public const string StopTriggerDuration = "StopTriggersDuration";
    [Register("STOP_TRIGGER_HANDHELD_PRESSED_CHECKED")]
    public const string StopTriggerHandheldPressedChecked = "StopTriggersHandheldPressed";
    [Register("STOP_TRIGGER_HANDHELD_RELEASED_CHECKED")]
    public const string StopTriggerHandheldReleasedChecked = "StopTriggersHandheldReleased";
    [Register("STOP_TRIGGER_HANDHELD_TIMEOUT")]
    public const string StopTriggerHandheldTimeout = "StopTriggersHandheldTimeout";
    [Register("STOP_TRIGGER_N_ATTEMPTS_NO_OF_ATTEMPTS")]
    public const string StopTriggerNAttemptsNoOfAttempts = "StopTriggersNAttemptsNoOfAttemps";
    [Register("STOP_TRIGGER_N_ATTEMPTS_TIMEOUT")]
    public const string StopTriggerNAttemptsTimeout = "StopTriggersNAttemptsTimeout";
    [Register("STOP_TRIGGER_STATUS")]
    public const string StopTriggerStatus = "StopTriggersStatus";
    [Register("STOP_TRIGGER_TAG_OBSERVE_NO_OF_TAGS")]
    public const string StopTriggerTagObserveNoOfTags = "StopTriggersTagObserveNoOfTags";
    [Register("STOP_TRIGGER_TAG_OBSERVE_TIMEOUT")]
    public const string StopTriggerTagObserveTimeout = "StopTriggersTagObserveTimeout";
    [Register("TAG_ID")]
    public const string TagId = "tagID";
    [Register("TAG_OBSERVATION")]
    public const string TagObservation = "Tag Observation";
    [Register("TAG_PREFS")]
    public const string TagPrefs = "TagPrefsFile";
    [Register("TAG_REPORT_CHANNEL_INDEX")]
    public const string TagReportChannelIndex = "TagReportChannelIndex";
    [Register("TAG_REPORT_FIRST_SEEN_TIME")]
    public const string TagReportFirstSeenTime = "TagReportFirstSeenTime";
    [Register("TAG_REPORT_LAST_SEEN_TIME")]
    public const string TagReportLastSeenTime = "TagReportLastSeenTime";
    [Register("TAG_REPORT_PC")]
    public const string TagReportPc = "TagReportPC";
    [Register("TAG_REPORT_PHASE")]
    public const string TagReportPhase = "TagReportPhase";
    [Register("TAG_REPORT_RSSI")]
    public const string TagReportRssi = "TagReportRSSI";
    [Register("TAG_REPORT_STATUS")]
    public const string TagReportStatus = "TagReportingStatus";
    [Register("TAG_REPORT_TAG_SEEN_COUNT")]
    public const string TagReportTagSeenCount = "TagReportTagSeen";
    [Register("TID_MEMORY")]
    public const string TidMemory = "TID MEMORY";
    [Register("TRIGGER_STATUS")]
    public const string TriggerStatus = "TriggersStatus";
    [Register("TYPE_DEBUG")]
    public const int TypeDebug = 60;
    [Register("TYPE_ERROR")]
    public const int TypeError = 61;
    [Register("UNIQUE_TAG_LIMIT")]
    public const int UniqueTagLimit = 30000;
    [Register("USER_MEMORY")]
    public const string UserMemory = "USER MEMORY";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Constants", typeof (Constants));

    [Register("COLLAPSED_HEIGHT")]
    public static int CollapsedHeight
    {
      get => Constants._members.StaticFields.GetInt32Value("COLLAPSED_HEIGHT.I");
      set => Constants._members.StaticFields.SetValue("COLLAPSED_HEIGHT.I", value);
    }

    [Register("EXTRA_DEVICE")]
    public static string? ExtraDevice
    {
      get
      {
        JniObjectReference objectValue = Constants._members.StaticFields.GetObjectValue("EXTRA_DEVICE.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Constants._members.StaticFields.SetValue("EXTRA_DEVICE.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("INVENTORY_LIST_FONT_SIZE")]
    public static int InventoryListFontSize
    {
      get => Constants._members.StaticFields.GetInt32Value("INVENTORY_LIST_FONT_SIZE.I");
      set => Constants._members.StaticFields.SetValue("INVENTORY_LIST_FONT_SIZE.I", value);
    }

    [Register("INVENTORY_LIST_MARGIN_SIZE")]
    public static int InventoryListMarginSize
    {
      get => Constants._members.StaticFields.GetInt32Value("INVENTORY_LIST_MARGIN_SIZE.I");
      set => Constants._members.StaticFields.SetValue("INVENTORY_LIST_MARGIN_SIZE.I", value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Constants._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Constants._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Constants._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Constants._members.ManagedPeerType;

    protected Constants(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Constants()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Constants._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Constants._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
