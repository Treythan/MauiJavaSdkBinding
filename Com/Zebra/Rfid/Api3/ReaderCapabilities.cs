// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReaderCapabilities
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
  [Register("com/zebra/rfid/api3/ReaderCapabilities", DoNotGenerateAcw = true)]
  public class ReaderCapabilities : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderCapabilities", typeof (ReaderCapabilities));
    private static Delegate? cb_getAirProtocolVersion;
    private static Delegate? cb_isAntennaRFConfigSupported;
    private static Delegate? cb_setAntennaRFConfigSupported_Z;
    private static Delegate? cb_getAsciiVersion;
    private static Delegate? cb_getBDAddress;
    private static Delegate? cb_isBlockEraseSupported;
    private static Delegate? cb_setBlockEraseSupported_Z;
    private static Delegate? cb_isBlockPermalockSupported;
    private static Delegate? cb_setBlockPermalockSupported_Z;
    private static Delegate? cb_isBlockWriteSupported;
    private static Delegate? cb_setBlockWriteSupported_Z;
    private static Delegate? cb_getCommunicationStandard;
    private static Delegate? cb_setCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_;
    private static Delegate? cb_getCountryCode;
    private static Delegate? cb_setCountryCode_I;
    private static Delegate? cb_getFirwareVersion;
    private static Delegate? cb_setFirwareVersion_Ljava_lang_String_;
    private static Delegate? cb_isHoppingEnabled;
    private static Delegate? cb_setHoppingEnabled_Z;
    private static Delegate? cb_isFujitsuCommandSupported;
    private static Delegate? cb_isImpinjCommandSupported;
    private static Delegate? cb_isSledBatteryStatusSupported;
    private static Delegate? cb_isTagPhaseReportingSupported;
    private static Delegate? cb_getManufacturerName;
    private static Delegate? cb_getManufacturingDate;
    private static Delegate? cb_getMaxNumOperationsInAccessSequence;
    private static Delegate? cb_setMaxNumOperationsInAccessSequence_I;
    private static Delegate? cb_getMaxNumPreFilters;
    private static Delegate? cb_setMaxNumPreFilters_I;
    private static Delegate? cb_getModelName;
    private static Delegate? cb_setModelName_Ljava_lang_String_;
    private static Delegate? cb_isNXPCommandSupported;
    private static Delegate? cb_setNXPCommandSupported_Z;
    private static Delegate? cb_getNumAntennaSupported;
    private static Delegate? cb_setNumAntennaSupported_I;
    private static Delegate? cb_getNumGPIPorts;
    private static Delegate? cb_setNumGPIPorts_I;
    private static Delegate? cb_getNumGPOPorts;
    private static Delegate? cb_setNumGPOPorts_I;
    private static Delegate? cb_isPeriodicTagReportsSupported;
    private static Delegate? cb_setPeriodicTagReportsSupported_Z;
    private static Delegate? cb_isRSSIFilterSupported;
    private static Delegate? cb_setRSSIFilterSupported_Z;
    private static Delegate? cb_isRadioPowerControlSupported;
    private static Delegate? cb_setRadioPowerControlSupported_Z;
    private static Delegate? cb_isRecommisionSupported;
    private static Delegate? cb_setRecommisionSupported_Z;
    private static Delegate? cb_getScannerName;
    private static Delegate? cb_getSerialNumber;
    private static Delegate? cb_isTagEventReportingSupported;
    private static Delegate? cb_setTagEventReportingSupported_Z;
    private static Delegate? cb_isTagInventoryStateAwareSingulationSupported;
    private static Delegate? cb_setTagInventoryStateAwareSingulationSupported_Z;
    private static Delegate? cb_isTagLocationingSupported;
    private static Delegate? cb_setTagLocationingSupported_Z;
    private static Delegate? cb_isTagMovingStationarySupported;
    private static Delegate? cb_setTagMovingStationarySupported_Z;
    private static Delegate? cb_isUTCClockSupported;
    private static Delegate? cb_setUTCClockSupported_Z;
    private static Delegate? cb_isWriteUMISupported;
    private static Delegate? cb_setWriteUMISupported_Z;
    private static Delegate? cb_isZoneSuppported;
    private static Delegate? cb_setZoneSuppported_Z;
    private static Delegate? cb_getDutyCycleValues;
    private static Delegate? cb_getFixedFreqValues;
    private static Delegate? cb_getReaderCaps;
    private static Delegate? cb_getReceiveSensitivityValues;
    private static Delegate? cb_getTransmitPowerLevelValues;
    private static Delegate? cb_getIsTagPhaseReportingSupported;
    private static Delegate? cb_setDutyCycleValues_arrayS;
    private static Delegate? cb_setFixedFreqValues_arrayI;
    private static Delegate? cb_setReceiveSensitivityValues_arrayI;
    private static Delegate? cb_setTransmitPowerLevelValues_arrayI;
    private static Delegate? cb_updateReaderCaps;

    [Register("FrequencyHopInfo")]
    public FrequencyHopInfo? FrequencyHopInfo
    {
      get
      {
        JniObjectReference objectValue = ReaderCapabilities._members.InstanceFields.GetObjectValue("FrequencyHopInfo.Lcom/zebra/rfid/api3/FrequencyHopInfo;", (IJavaPeerable) this);
        return Object.GetObject<FrequencyHopInfo>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderCapabilities._members.InstanceFields.SetValue("FrequencyHopInfo.Lcom/zebra/rfid/api3/FrequencyHopInfo;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("m_bIsFujitsuCommandSupported")]
    public bool MBIsFujitsuCommandSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_bIsFujitsuCommandSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_bIsFujitsuCommandSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_bIsImpinjCommandSupported")]
    public bool MBIsImpinjCommandSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_bIsImpinjCommandSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_bIsImpinjCommandSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_bIsTagPhaseReportingSupported")]
    public bool MBIsTagPhaseReportingSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_bIsTagPhaseReportingSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_bIsTagPhaseReportingSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_IsAntennaRFConfigSupported")]
    public bool MIsAntennaRFConfigSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_IsAntennaRFConfigSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_IsAntennaRFConfigSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_IsPeriodicTagReportsSupported")]
    public bool MIsPeriodicTagReportsSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_IsPeriodicTagReportsSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_IsPeriodicTagReportsSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_IsTagMovingStationarySupported")]
    public bool MIsTagMovingStationarySupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_IsTagMovingStationarySupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_IsTagMovingStationarySupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_IsZoneSuppported")]
    public bool MIsZoneSuppported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_IsZoneSuppported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_IsZoneSuppported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_radioTransmitDelaySupported")]
    public bool MRadioTransmitDelaySupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_radioTransmitDelaySupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_radioTransmitDelaySupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_SledBatteryStatusSupported")]
    public bool MSledBatteryStatusSupported
    {
      get
      {
        return ReaderCapabilities._members.InstanceFields.GetBooleanValue("m_SledBatteryStatusSupported.Z", (IJavaPeerable) this);
      }
      set
      {
        ReaderCapabilities._members.InstanceFields.SetValue("m_SledBatteryStatusSupported.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("ReaderID")]
    public ReaderCapabilities.ReaderIdentification? ReaderID
    {
      get
      {
        JniObjectReference objectValue = ReaderCapabilities._members.InstanceFields.GetObjectValue("ReaderID.Lcom/zebra/rfid/api3/ReaderCapabilities$ReaderIdentification;", (IJavaPeerable) this);
        return Object.GetObject<ReaderCapabilities.ReaderIdentification>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderCapabilities._members.InstanceFields.SetValue("ReaderID.Lcom/zebra/rfid/api3/ReaderCapabilities$ReaderIdentification;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("RFModes")]
    public RFModes? RFModes
    {
      get
      {
        JniObjectReference objectValue = ReaderCapabilities._members.InstanceFields.GetObjectValue("RFModes.Lcom/zebra/rfid/api3/RFModes;", (IJavaPeerable) this);
        return Object.GetObject<RFModes>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderCapabilities._members.InstanceFields.SetValue("RFModes.Lcom/zebra/rfid/api3/RFModes;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("SupportedRegions")]
    public SupportedRegions? SupportedRegions
    {
      get
      {
        JniObjectReference objectValue = ReaderCapabilities._members.InstanceFields.GetObjectValue("SupportedRegions.Lcom/zebra/rfid/api3/SupportedRegions;", (IJavaPeerable) this);
        return Object.GetObject<SupportedRegions>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderCapabilities._members.InstanceFields.SetValue("SupportedRegions.Lcom/zebra/rfid/api3/SupportedRegions;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = ReaderCapabilities._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReaderCapabilities._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReaderCapabilities._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReaderCapabilities._members.ManagedPeerType;

    protected ReaderCapabilities(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetAirProtocolVersionHandler()
    {
      if ((object) ReaderCapabilities.cb_getAirProtocolVersion == null)
        ReaderCapabilities.cb_getAirProtocolVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetAirProtocolVersion));
      return ReaderCapabilities.cb_getAirProtocolVersion;
    }

    private static IntPtr n_GetAirProtocolVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).AirProtocolVersion);
    }

    public virtual unsafe string? AirProtocolVersion
    {
      [Register("getAirProtocolVersion", "()Ljava/lang/String;", "GetGetAirProtocolVersionHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getAirProtocolVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsAntennaRFConfigSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isAntennaRFConfigSupported == null)
        ReaderCapabilities.cb_isAntennaRFConfigSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsAntennaRFConfigSupported));
      return ReaderCapabilities.cb_isAntennaRFConfigSupported;
    }

    private static bool n_IsAntennaRFConfigSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).AntennaRFConfigSupported;
    }

    private static Delegate GetSetAntennaRFConfigSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setAntennaRFConfigSupported_Z == null)
        ReaderCapabilities.cb_setAntennaRFConfigSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetAntennaRFConfigSupported_Z));
      return ReaderCapabilities.cb_setAntennaRFConfigSupported_Z;
    }

    private static void n_SetAntennaRFConfigSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_IsAntennaRFConfigSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).AntennaRFConfigSupported = m_IsAntennaRFConfigSupported;
    }

    public virtual unsafe bool AntennaRFConfigSupported
    {
      [Register("isAntennaRFConfigSupported", "()Z", "GetIsAntennaRFConfigSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isAntennaRFConfigSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAntennaRFConfigSupported", "(Z)V", "GetSetAntennaRFConfigSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaRFConfigSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetAsciiVersionHandler()
    {
      if ((object) ReaderCapabilities.cb_getAsciiVersion == null)
        ReaderCapabilities.cb_getAsciiVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetAsciiVersion));
      return ReaderCapabilities.cb_getAsciiVersion;
    }

    private static IntPtr n_GetAsciiVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).AsciiVersion);
    }

    public virtual unsafe string? AsciiVersion
    {
      [Register("getAsciiVersion", "()Ljava/lang/String;", "GetGetAsciiVersionHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getAsciiVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetBDAddressHandler()
    {
      if ((object) ReaderCapabilities.cb_getBDAddress == null)
        ReaderCapabilities.cb_getBDAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetBDAddress));
      return ReaderCapabilities.cb_getBDAddress;
    }

    private static IntPtr n_GetBDAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BDAddress);
    }

    public virtual unsafe string? BDAddress
    {
      [Register("getBDAddress", "()Ljava/lang/String;", "GetGetBDAddressHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getBDAddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsBlockEraseSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isBlockEraseSupported == null)
        ReaderCapabilities.cb_isBlockEraseSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsBlockEraseSupported));
      return ReaderCapabilities.cb_isBlockEraseSupported;
    }

    private static bool n_IsBlockEraseSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockEraseSupported;
    }

    private static Delegate GetSetBlockEraseSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setBlockEraseSupported_Z == null)
        ReaderCapabilities.cb_setBlockEraseSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetBlockEraseSupported_Z));
      return ReaderCapabilities.cb_setBlockEraseSupported_Z;
    }

    private static void n_SetBlockEraseSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsBlockEraseSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockEraseSupported = m_bIsBlockEraseSupported;
    }

    public virtual unsafe bool BlockEraseSupported
    {
      [Register("isBlockEraseSupported", "()Z", "GetIsBlockEraseSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isBlockEraseSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlockEraseSupported", "(Z)V", "GetSetBlockEraseSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockEraseSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsBlockPermalockSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isBlockPermalockSupported == null)
        ReaderCapabilities.cb_isBlockPermalockSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsBlockPermalockSupported));
      return ReaderCapabilities.cb_isBlockPermalockSupported;
    }

    private static bool n_IsBlockPermalockSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockPermalockSupported;
    }

    private static Delegate GetSetBlockPermalockSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setBlockPermalockSupported_Z == null)
        ReaderCapabilities.cb_setBlockPermalockSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetBlockPermalockSupported_Z));
      return ReaderCapabilities.cb_setBlockPermalockSupported_Z;
    }

    private static void n_SetBlockPermalockSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsBlockPermalockSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockPermalockSupported = m_bIsBlockPermalockSupported;
    }

    public virtual unsafe bool BlockPermalockSupported
    {
      [Register("isBlockPermalockSupported", "()Z", "GetIsBlockPermalockSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isBlockPermalockSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlockPermalockSupported", "(Z)V", "GetSetBlockPermalockSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockPermalockSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsBlockWriteSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isBlockWriteSupported == null)
        ReaderCapabilities.cb_isBlockWriteSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsBlockWriteSupported));
      return ReaderCapabilities.cb_isBlockWriteSupported;
    }

    private static bool n_IsBlockWriteSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockWriteSupported;
    }

    private static Delegate GetSetBlockWriteSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setBlockWriteSupported_Z == null)
        ReaderCapabilities.cb_setBlockWriteSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetBlockWriteSupported_Z));
      return ReaderCapabilities.cb_setBlockWriteSupported_Z;
    }

    private static void n_SetBlockWriteSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsBlockWriteSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).BlockWriteSupported = m_bIsBlockWriteSupported;
    }

    public virtual unsafe bool BlockWriteSupported
    {
      [Register("isBlockWriteSupported", "()Z", "GetIsBlockWriteSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isBlockWriteSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlockWriteSupported", "(Z)V", "GetSetBlockWriteSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockWriteSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCommunicationStandardHandler()
    {
      if ((object) ReaderCapabilities.cb_getCommunicationStandard == null)
        ReaderCapabilities.cb_getCommunicationStandard = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetCommunicationStandard));
      return ReaderCapabilities.cb_getCommunicationStandard;
    }

    private static IntPtr n_GetCommunicationStandard(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).CommunicationStandard);
    }

    private static Delegate GetSetCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_Handler()
    {
      if ((object) ReaderCapabilities.cb_setCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_ == null)
        ReaderCapabilities.cb_setCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_));
      return ReaderCapabilities.cb_setCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_;
    }

    private static void n_SetCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_eCommunicationStandard)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).CommunicationStandard = Object.GetObject<COMMUNICATION_STANDARD>(native_m_eCommunicationStandard, (JniHandleOwnership) 0);
    }

    public virtual unsafe COMMUNICATION_STANDARD? CommunicationStandard
    {
      [Register("getCommunicationStandard", "()Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;", "GetGetCommunicationStandardHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getCommunicationStandard.()Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setCommunicationStandard", "(Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;)V", "GetSetCommunicationStandard_Lcom_zebra_rfid_api3_COMMUNICATION_STANDARD_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setCommunicationStandard.(Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetCountryCodeHandler()
    {
      if ((object) ReaderCapabilities.cb_getCountryCode == null)
        ReaderCapabilities.cb_getCountryCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetCountryCode));
      return ReaderCapabilities.cb_getCountryCode;
    }

    private static int n_GetCountryCode(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).CountryCode;
    }

    private static Delegate GetSetCountryCode_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setCountryCode_I == null)
        ReaderCapabilities.cb_setCountryCode_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetCountryCode_I));
      return ReaderCapabilities.cb_setCountryCode_I;
    }

    private static void n_SetCountryCode_I(IntPtr jnienv, IntPtr native__this, int m_nCountryCode)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).CountryCode = m_nCountryCode;
    }

    public virtual unsafe int CountryCode
    {
      [Register("getCountryCode", "()I", "GetGetCountryCodeHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getCountryCode.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCountryCode", "(I)V", "GetSetCountryCode_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setCountryCode.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetFirwareVersionHandler()
    {
      if ((object) ReaderCapabilities.cb_getFirwareVersion == null)
        ReaderCapabilities.cb_getFirwareVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetFirwareVersion));
      return ReaderCapabilities.cb_getFirwareVersion;
    }

    private static IntPtr n_GetFirwareVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).FirwareVersion);
    }

    private static Delegate GetSetFirwareVersion_Ljava_lang_String_Handler()
    {
      if ((object) ReaderCapabilities.cb_setFirwareVersion_Ljava_lang_String_ == null)
        ReaderCapabilities.cb_setFirwareVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetFirwareVersion_Ljava_lang_String_));
      return ReaderCapabilities.cb_setFirwareVersion_Ljava_lang_String_;
    }

    private static void n_SetFirwareVersion_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sFirwareVersion)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).FirwareVersion = JNIEnv.GetString(native_m_sFirwareVersion, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? FirwareVersion
    {
      [Register("getFirwareVersion", "()Ljava/lang/String;", "GetGetFirwareVersionHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getFirwareVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setFirwareVersion", "(Ljava/lang/String;)V", "GetSetFirwareVersion_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setFirwareVersion.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsHoppingEnabledHandler()
    {
      if ((object) ReaderCapabilities.cb_isHoppingEnabled == null)
        ReaderCapabilities.cb_isHoppingEnabled = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsHoppingEnabled));
      return ReaderCapabilities.cb_isHoppingEnabled;
    }

    private static bool n_IsHoppingEnabled(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).HoppingEnabled;
    }

    private static Delegate GetSetHoppingEnabled_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setHoppingEnabled_Z == null)
        ReaderCapabilities.cb_setHoppingEnabled_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetHoppingEnabled_Z));
      return ReaderCapabilities.cb_setHoppingEnabled_Z;
    }

    private static void n_SetHoppingEnabled_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsHoppingEnabled)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).HoppingEnabled = m_bIsHoppingEnabled;
    }

    public virtual unsafe bool HoppingEnabled
    {
      [Register("isHoppingEnabled", "()Z", "GetIsHoppingEnabledHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isHoppingEnabled.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setHoppingEnabled", "(Z)V", "GetSetHoppingEnabled_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setHoppingEnabled.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsFujitsuCommandSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isFujitsuCommandSupported == null)
        ReaderCapabilities.cb_isFujitsuCommandSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsFujitsuCommandSupported));
      return ReaderCapabilities.cb_isFujitsuCommandSupported;
    }

    private static bool n_IsFujitsuCommandSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).IsFujitsuCommandSupported;
    }

    public virtual unsafe bool IsFujitsuCommandSupported
    {
      [Register("isFujitsuCommandSupported", "()Z", "GetIsFujitsuCommandSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isFujitsuCommandSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsImpinjCommandSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isImpinjCommandSupported == null)
        ReaderCapabilities.cb_isImpinjCommandSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsImpinjCommandSupported));
      return ReaderCapabilities.cb_isImpinjCommandSupported;
    }

    private static bool n_IsImpinjCommandSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).IsImpinjCommandSupported;
    }

    public virtual unsafe bool IsImpinjCommandSupported
    {
      [Register("isImpinjCommandSupported", "()Z", "GetIsImpinjCommandSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isImpinjCommandSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsSledBatteryStatusSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isSledBatteryStatusSupported == null)
        ReaderCapabilities.cb_isSledBatteryStatusSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsSledBatteryStatusSupported));
      return ReaderCapabilities.cb_isSledBatteryStatusSupported;
    }

    private static bool n_IsSledBatteryStatusSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).IsSledBatteryStatusSupported;
    }

    public virtual unsafe bool IsSledBatteryStatusSupported
    {
      [Register("isSledBatteryStatusSupported", "()Z", "GetIsSledBatteryStatusSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isSledBatteryStatusSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsTagPhaseReportingSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isTagPhaseReportingSupported == null)
        ReaderCapabilities.cb_isTagPhaseReportingSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsTagPhaseReportingSupported));
      return ReaderCapabilities.cb_isTagPhaseReportingSupported;
    }

    private static bool n_IsTagPhaseReportingSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).IsTagPhaseReportingSupported;
    }

    public virtual unsafe bool IsTagPhaseReportingSupported
    {
      [Register("isTagPhaseReportingSupported", "()Z", "GetIsTagPhaseReportingSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagPhaseReportingSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetManufacturerNameHandler()
    {
      if ((object) ReaderCapabilities.cb_getManufacturerName == null)
        ReaderCapabilities.cb_getManufacturerName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetManufacturerName));
      return ReaderCapabilities.cb_getManufacturerName;
    }

    private static IntPtr n_GetManufacturerName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ManufacturerName);
    }

    public virtual unsafe string? ManufacturerName
    {
      [Register("getManufacturerName", "()Ljava/lang/String;", "GetGetManufacturerNameHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getManufacturerName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetManufacturingDateHandler()
    {
      if ((object) ReaderCapabilities.cb_getManufacturingDate == null)
        ReaderCapabilities.cb_getManufacturingDate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetManufacturingDate));
      return ReaderCapabilities.cb_getManufacturingDate;
    }

    private static IntPtr n_GetManufacturingDate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ManufacturingDate);
    }

    public virtual unsafe string? ManufacturingDate
    {
      [Register("getManufacturingDate", "()Ljava/lang/String;", "GetGetManufacturingDateHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getManufacturingDate.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetMaxNumOperationsInAccessSequenceHandler()
    {
      if ((object) ReaderCapabilities.cb_getMaxNumOperationsInAccessSequence == null)
        ReaderCapabilities.cb_getMaxNumOperationsInAccessSequence = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetMaxNumOperationsInAccessSequence));
      return ReaderCapabilities.cb_getMaxNumOperationsInAccessSequence;
    }

    private static int n_GetMaxNumOperationsInAccessSequence(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).MaxNumOperationsInAccessSequence;
    }

    private static Delegate GetSetMaxNumOperationsInAccessSequence_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setMaxNumOperationsInAccessSequence_I == null)
        ReaderCapabilities.cb_setMaxNumOperationsInAccessSequence_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetMaxNumOperationsInAccessSequence_I));
      return ReaderCapabilities.cb_setMaxNumOperationsInAccessSequence_I;
    }

    private static void n_SetMaxNumOperationsInAccessSequence_I(
      IntPtr jnienv,
      IntPtr native__this,
      int m_nMaxNumOperationsInAccessSequence)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).MaxNumOperationsInAccessSequence = m_nMaxNumOperationsInAccessSequence;
    }

    public virtual unsafe int MaxNumOperationsInAccessSequence
    {
      [Register("getMaxNumOperationsInAccessSequence", "()I", "GetGetMaxNumOperationsInAccessSequenceHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getMaxNumOperationsInAccessSequence.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaxNumOperationsInAccessSequence", "(I)V", "GetSetMaxNumOperationsInAccessSequence_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxNumOperationsInAccessSequence.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaxNumPreFiltersHandler()
    {
      if ((object) ReaderCapabilities.cb_getMaxNumPreFilters == null)
        ReaderCapabilities.cb_getMaxNumPreFilters = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetMaxNumPreFilters));
      return ReaderCapabilities.cb_getMaxNumPreFilters;
    }

    private static int n_GetMaxNumPreFilters(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).MaxNumPreFilters;
    }

    private static Delegate GetSetMaxNumPreFilters_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setMaxNumPreFilters_I == null)
        ReaderCapabilities.cb_setMaxNumPreFilters_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetMaxNumPreFilters_I));
      return ReaderCapabilities.cb_setMaxNumPreFilters_I;
    }

    private static void n_SetMaxNumPreFilters_I(
      IntPtr jnienv,
      IntPtr native__this,
      int m_nMaxNumPreFilters)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).MaxNumPreFilters = m_nMaxNumPreFilters;
    }

    public virtual unsafe int MaxNumPreFilters
    {
      [Register("getMaxNumPreFilters", "()I", "GetGetMaxNumPreFiltersHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getMaxNumPreFilters.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaxNumPreFilters", "(I)V", "GetSetMaxNumPreFilters_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxNumPreFilters.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetModelNameHandler()
    {
      if ((object) ReaderCapabilities.cb_getModelName == null)
        ReaderCapabilities.cb_getModelName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetModelName));
      return ReaderCapabilities.cb_getModelName;
    }

    private static IntPtr n_GetModelName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ModelName);
    }

    private static Delegate GetSetModelName_Ljava_lang_String_Handler()
    {
      if ((object) ReaderCapabilities.cb_setModelName_Ljava_lang_String_ == null)
        ReaderCapabilities.cb_setModelName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetModelName_Ljava_lang_String_));
      return ReaderCapabilities.cb_setModelName_Ljava_lang_String_;
    }

    private static void n_SetModelName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sModelName)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ModelName = JNIEnv.GetString(native_m_sModelName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? ModelName
    {
      [Register("getModelName", "()Ljava/lang/String;", "GetGetModelNameHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getModelName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setModelName", "(Ljava/lang/String;)V", "GetSetModelName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setModelName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsNXPCommandSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isNXPCommandSupported == null)
        ReaderCapabilities.cb_isNXPCommandSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsNXPCommandSupported));
      return ReaderCapabilities.cb_isNXPCommandSupported;
    }

    private static bool n_IsNXPCommandSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NXPCommandSupported;
    }

    private static Delegate GetSetNXPCommandSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setNXPCommandSupported_Z == null)
        ReaderCapabilities.cb_setNXPCommandSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetNXPCommandSupported_Z));
      return ReaderCapabilities.cb_setNXPCommandSupported_Z;
    }

    private static void n_SetNXPCommandSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsNXPCommandSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NXPCommandSupported = m_bIsNXPCommandSupported;
    }

    public virtual unsafe bool NXPCommandSupported
    {
      [Register("isNXPCommandSupported", "()Z", "GetIsNXPCommandSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isNXPCommandSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNXPCommandSupported", "(Z)V", "GetSetNXPCommandSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setNXPCommandSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNumAntennaSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_getNumAntennaSupported == null)
        ReaderCapabilities.cb_getNumAntennaSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetNumAntennaSupported));
      return ReaderCapabilities.cb_getNumAntennaSupported;
    }

    private static int n_GetNumAntennaSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumAntennaSupported;
    }

    private static Delegate GetSetNumAntennaSupported_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setNumAntennaSupported_I == null)
        ReaderCapabilities.cb_setNumAntennaSupported_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetNumAntennaSupported_I));
      return ReaderCapabilities.cb_setNumAntennaSupported_I;
    }

    private static void n_SetNumAntennaSupported_I(
      IntPtr jnienv,
      IntPtr native__this,
      int m_nNumAntennaSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumAntennaSupported = m_nNumAntennaSupported;
    }

    public virtual unsafe int NumAntennaSupported
    {
      [Register("getNumAntennaSupported", "()I", "GetGetNumAntennaSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getNumAntennaSupported.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNumAntennaSupported", "(I)V", "GetSetNumAntennaSupported_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setNumAntennaSupported.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNumGPIPortsHandler()
    {
      if ((object) ReaderCapabilities.cb_getNumGPIPorts == null)
        ReaderCapabilities.cb_getNumGPIPorts = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetNumGPIPorts));
      return ReaderCapabilities.cb_getNumGPIPorts;
    }

    private static int n_GetNumGPIPorts(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumGPIPorts;
    }

    private static Delegate GetSetNumGPIPorts_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setNumGPIPorts_I == null)
        ReaderCapabilities.cb_setNumGPIPorts_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetNumGPIPorts_I));
      return ReaderCapabilities.cb_setNumGPIPorts_I;
    }

    private static void n_SetNumGPIPorts_I(IntPtr jnienv, IntPtr native__this, int m_nNumGPIPorts)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumGPIPorts = m_nNumGPIPorts;
    }

    public virtual unsafe int NumGPIPorts
    {
      [Register("getNumGPIPorts", "()I", "GetGetNumGPIPortsHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getNumGPIPorts.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNumGPIPorts", "(I)V", "GetSetNumGPIPorts_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setNumGPIPorts.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNumGPOPortsHandler()
    {
      if ((object) ReaderCapabilities.cb_getNumGPOPorts == null)
        ReaderCapabilities.cb_getNumGPOPorts = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderCapabilities.n_GetNumGPOPorts));
      return ReaderCapabilities.cb_getNumGPOPorts;
    }

    private static int n_GetNumGPOPorts(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumGPOPorts;
    }

    private static Delegate GetSetNumGPOPorts_IHandler()
    {
      if ((object) ReaderCapabilities.cb_setNumGPOPorts_I == null)
        ReaderCapabilities.cb_setNumGPOPorts_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderCapabilities.n_SetNumGPOPorts_I));
      return ReaderCapabilities.cb_setNumGPOPorts_I;
    }

    private static void n_SetNumGPOPorts_I(IntPtr jnienv, IntPtr native__this, int m_nNumGPOPorts)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).NumGPOPorts = m_nNumGPOPorts;
    }

    public virtual unsafe int NumGPOPorts
    {
      [Register("getNumGPOPorts", "()I", "GetGetNumGPOPortsHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualInt32Method("getNumGPOPorts.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNumGPOPorts", "(I)V", "GetSetNumGPOPorts_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setNumGPOPorts.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsPeriodicTagReportsSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isPeriodicTagReportsSupported == null)
        ReaderCapabilities.cb_isPeriodicTagReportsSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsPeriodicTagReportsSupported));
      return ReaderCapabilities.cb_isPeriodicTagReportsSupported;
    }

    private static bool n_IsPeriodicTagReportsSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).PeriodicTagReportsSupported;
    }

    private static Delegate GetSetPeriodicTagReportsSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setPeriodicTagReportsSupported_Z == null)
        ReaderCapabilities.cb_setPeriodicTagReportsSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetPeriodicTagReportsSupported_Z));
      return ReaderCapabilities.cb_setPeriodicTagReportsSupported_Z;
    }

    private static void n_SetPeriodicTagReportsSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_IsPeriodicTagReportsSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).PeriodicTagReportsSupported = m_IsPeriodicTagReportsSupported;
    }

    public virtual unsafe bool PeriodicTagReportsSupported
    {
      [Register("isPeriodicTagReportsSupported", "()Z", "GetIsPeriodicTagReportsSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isPeriodicTagReportsSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPeriodicTagReportsSupported", "(Z)V", "GetSetPeriodicTagReportsSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setPeriodicTagReportsSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsRSSIFilterSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isRSSIFilterSupported == null)
        ReaderCapabilities.cb_isRSSIFilterSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsRSSIFilterSupported));
      return ReaderCapabilities.cb_isRSSIFilterSupported;
    }

    private static bool n_IsRSSIFilterSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RSSIFilterSupported;
    }

    private static Delegate GetSetRSSIFilterSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setRSSIFilterSupported_Z == null)
        ReaderCapabilities.cb_setRSSIFilterSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetRSSIFilterSupported_Z));
      return ReaderCapabilities.cb_setRSSIFilterSupported_Z;
    }

    private static void n_SetRSSIFilterSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsRSSIFilterSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RSSIFilterSupported = m_bIsRSSIFilterSupported;
    }

    public virtual unsafe bool RSSIFilterSupported
    {
      [Register("isRSSIFilterSupported", "()Z", "GetIsRSSIFilterSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isRSSIFilterSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRSSIFilterSupported", "(Z)V", "GetSetRSSIFilterSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setRSSIFilterSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsRadioPowerControlSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isRadioPowerControlSupported == null)
        ReaderCapabilities.cb_isRadioPowerControlSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsRadioPowerControlSupported));
      return ReaderCapabilities.cb_isRadioPowerControlSupported;
    }

    private static bool n_IsRadioPowerControlSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RadioPowerControlSupported;
    }

    private static Delegate GetSetRadioPowerControlSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setRadioPowerControlSupported_Z == null)
        ReaderCapabilities.cb_setRadioPowerControlSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetRadioPowerControlSupported_Z));
      return ReaderCapabilities.cb_setRadioPowerControlSupported_Z;
    }

    private static void n_SetRadioPowerControlSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsRadioPowerControlSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RadioPowerControlSupported = m_bIsRadioPowerControlSupported;
    }

    public virtual unsafe bool RadioPowerControlSupported
    {
      [Register("isRadioPowerControlSupported", "()Z", "GetIsRadioPowerControlSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isRadioPowerControlSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRadioPowerControlSupported", "(Z)V", "GetSetRadioPowerControlSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setRadioPowerControlSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsRecommisionSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isRecommisionSupported == null)
        ReaderCapabilities.cb_isRecommisionSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsRecommisionSupported));
      return ReaderCapabilities.cb_isRecommisionSupported;
    }

    private static bool n_IsRecommisionSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RecommisionSupported;
    }

    private static Delegate GetSetRecommisionSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setRecommisionSupported_Z == null)
        ReaderCapabilities.cb_setRecommisionSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetRecommisionSupported_Z));
      return ReaderCapabilities.cb_setRecommisionSupported_Z;
    }

    private static void n_SetRecommisionSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsRecommisionSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).RecommisionSupported = m_bIsRecommisionSupported;
    }

    public virtual unsafe bool RecommisionSupported
    {
      [Register("isRecommisionSupported", "()Z", "GetIsRecommisionSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isRecommisionSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRecommisionSupported", "(Z)V", "GetSetRecommisionSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setRecommisionSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetScannerNameHandler()
    {
      if ((object) ReaderCapabilities.cb_getScannerName == null)
        ReaderCapabilities.cb_getScannerName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetScannerName));
      return ReaderCapabilities.cb_getScannerName;
    }

    private static IntPtr n_GetScannerName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ScannerName);
    }

    public virtual unsafe string? ScannerName
    {
      [Register("getScannerName", "()Ljava/lang/String;", "GetGetScannerNameHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSerialNumberHandler()
    {
      if ((object) ReaderCapabilities.cb_getSerialNumber == null)
        ReaderCapabilities.cb_getSerialNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetSerialNumber));
      return ReaderCapabilities.cb_getSerialNumber;
    }

    private static IntPtr n_GetSerialNumber(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber);
    }

    public virtual unsafe string? SerialNumber
    {
      [Register("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getSerialNumber.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsTagEventReportingSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isTagEventReportingSupported == null)
        ReaderCapabilities.cb_isTagEventReportingSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsTagEventReportingSupported));
      return ReaderCapabilities.cb_isTagEventReportingSupported;
    }

    private static bool n_IsTagEventReportingSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagEventReportingSupported;
    }

    private static Delegate GetSetTagEventReportingSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setTagEventReportingSupported_Z == null)
        ReaderCapabilities.cb_setTagEventReportingSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetTagEventReportingSupported_Z));
      return ReaderCapabilities.cb_setTagEventReportingSupported_Z;
    }

    private static void n_SetTagEventReportingSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsTagEventReportingSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagEventReportingSupported = m_bIsTagEventReportingSupported;
    }

    public virtual unsafe bool TagEventReportingSupported
    {
      [Register("isTagEventReportingSupported", "()Z", "GetIsTagEventReportingSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagEventReportingSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagEventReportingSupported", "(Z)V", "GetSetTagEventReportingSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setTagEventReportingSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsTagInventoryStateAwareSingulationSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isTagInventoryStateAwareSingulationSupported == null)
        ReaderCapabilities.cb_isTagInventoryStateAwareSingulationSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsTagInventoryStateAwareSingulationSupported));
      return ReaderCapabilities.cb_isTagInventoryStateAwareSingulationSupported;
    }

    private static bool n_IsTagInventoryStateAwareSingulationSupported(
      IntPtr jnienv,
      IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagInventoryStateAwareSingulationSupported;
    }

    private static Delegate GetSetTagInventoryStateAwareSingulationSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setTagInventoryStateAwareSingulationSupported_Z == null)
        ReaderCapabilities.cb_setTagInventoryStateAwareSingulationSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetTagInventoryStateAwareSingulationSupported_Z));
      return ReaderCapabilities.cb_setTagInventoryStateAwareSingulationSupported_Z;
    }

    private static void n_SetTagInventoryStateAwareSingulationSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsTagInventoryStateAwareSingulationSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagInventoryStateAwareSingulationSupported = m_bIsTagInventoryStateAwareSingulationSupported;
    }

    public virtual unsafe bool TagInventoryStateAwareSingulationSupported
    {
      [Register("isTagInventoryStateAwareSingulationSupported", "()Z", "GetIsTagInventoryStateAwareSingulationSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagInventoryStateAwareSingulationSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagInventoryStateAwareSingulationSupported", "(Z)V", "GetSetTagInventoryStateAwareSingulationSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setTagInventoryStateAwareSingulationSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsTagLocationingSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isTagLocationingSupported == null)
        ReaderCapabilities.cb_isTagLocationingSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsTagLocationingSupported));
      return ReaderCapabilities.cb_isTagLocationingSupported;
    }

    private static bool n_IsTagLocationingSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagLocationingSupported;
    }

    private static Delegate GetSetTagLocationingSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setTagLocationingSupported_Z == null)
        ReaderCapabilities.cb_setTagLocationingSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetTagLocationingSupported_Z));
      return ReaderCapabilities.cb_setTagLocationingSupported_Z;
    }

    private static void n_SetTagLocationingSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsTagLocationingSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagLocationingSupported = m_bIsTagLocationingSupported;
    }

    public virtual unsafe bool TagLocationingSupported
    {
      [Register("isTagLocationingSupported", "()Z", "GetIsTagLocationingSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagLocationingSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagLocationingSupported", "(Z)V", "GetSetTagLocationingSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setTagLocationingSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsTagMovingStationarySupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isTagMovingStationarySupported == null)
        ReaderCapabilities.cb_isTagMovingStationarySupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsTagMovingStationarySupported));
      return ReaderCapabilities.cb_isTagMovingStationarySupported;
    }

    private static bool n_IsTagMovingStationarySupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagMovingStationarySupported;
    }

    private static Delegate GetSetTagMovingStationarySupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setTagMovingStationarySupported_Z == null)
        ReaderCapabilities.cb_setTagMovingStationarySupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetTagMovingStationarySupported_Z));
      return ReaderCapabilities.cb_setTagMovingStationarySupported_Z;
    }

    private static void n_SetTagMovingStationarySupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_IsTagMovingStationarySupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).TagMovingStationarySupported = m_IsTagMovingStationarySupported;
    }

    public virtual unsafe bool TagMovingStationarySupported
    {
      [Register("isTagMovingStationarySupported", "()Z", "GetIsTagMovingStationarySupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagMovingStationarySupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagMovingStationarySupported", "(Z)V", "GetSetTagMovingStationarySupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setTagMovingStationarySupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsUTCClockSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isUTCClockSupported == null)
        ReaderCapabilities.cb_isUTCClockSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsUTCClockSupported));
      return ReaderCapabilities.cb_isUTCClockSupported;
    }

    private static bool n_IsUTCClockSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).UTCClockSupported;
    }

    private static Delegate GetSetUTCClockSupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setUTCClockSupported_Z == null)
        ReaderCapabilities.cb_setUTCClockSupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetUTCClockSupported_Z));
      return ReaderCapabilities.cb_setUTCClockSupported_Z;
    }

    private static void n_SetUTCClockSupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsUTCClockSupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).UTCClockSupported = m_bIsUTCClockSupported;
    }

    public virtual unsafe bool UTCClockSupported
    {
      [Register("isUTCClockSupported", "()Z", "GetIsUTCClockSupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isUTCClockSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setUTCClockSupported", "(Z)V", "GetSetUTCClockSupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setUTCClockSupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsWriteUMISupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isWriteUMISupported == null)
        ReaderCapabilities.cb_isWriteUMISupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsWriteUMISupported));
      return ReaderCapabilities.cb_isWriteUMISupported;
    }

    private static bool n_IsWriteUMISupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).WriteUMISupported;
    }

    private static Delegate GetSetWriteUMISupported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setWriteUMISupported_Z == null)
        ReaderCapabilities.cb_setWriteUMISupported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetWriteUMISupported_Z));
      return ReaderCapabilities.cb_setWriteUMISupported_Z;
    }

    private static void n_SetWriteUMISupported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bIsWriteUMISupported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).WriteUMISupported = m_bIsWriteUMISupported;
    }

    public virtual unsafe bool WriteUMISupported
    {
      [Register("isWriteUMISupported", "()Z", "GetIsWriteUMISupportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isWriteUMISupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setWriteUMISupported", "(Z)V", "GetSetWriteUMISupported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteUMISupported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsZoneSuppportedHandler()
    {
      if ((object) ReaderCapabilities.cb_isZoneSuppported == null)
        ReaderCapabilities.cb_isZoneSuppported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_IsZoneSuppported));
      return ReaderCapabilities.cb_isZoneSuppported;
    }

    private static bool n_IsZoneSuppported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ZoneSuppported;
    }

    private static Delegate GetSetZoneSuppported_ZHandler()
    {
      if ((object) ReaderCapabilities.cb_setZoneSuppported_Z == null)
        ReaderCapabilities.cb_setZoneSuppported_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(ReaderCapabilities.n_SetZoneSuppported_Z));
      return ReaderCapabilities.cb_setZoneSuppported_Z;
    }

    private static void n_SetZoneSuppported_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_IsZoneSuppported)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).ZoneSuppported = m_IsZoneSuppported;
    }

    public virtual unsafe bool ZoneSuppported
    {
      [Register("isZoneSuppported", "()Z", "GetIsZoneSuppportedHandler")] get
      {
        return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("isZoneSuppported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setZoneSuppported", "(Z)V", "GetSetZoneSuppported_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setZoneSuppported.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDutyCycleValuesHandler()
    {
      if ((object) ReaderCapabilities.cb_getDutyCycleValues == null)
        ReaderCapabilities.cb_getDutyCycleValues = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetDutyCycleValues));
      return ReaderCapabilities.cb_getDutyCycleValues;
    }

    private static IntPtr n_GetDutyCycleValues(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetDutyCycleValues());
    }

    [Register("getDutyCycleValues", "()[S", "GetGetDutyCycleValuesHandler")]
    public virtual unsafe short[]? GetDutyCycleValues()
    {
      JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getDutyCycleValues.()[S", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (short[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (short));
    }

    private static Delegate GetGetFixedFreqValuesHandler()
    {
      if ((object) ReaderCapabilities.cb_getFixedFreqValues == null)
        ReaderCapabilities.cb_getFixedFreqValues = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetFixedFreqValues));
      return ReaderCapabilities.cb_getFixedFreqValues;
    }

    private static IntPtr n_GetFixedFreqValues(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetFixedFreqValues());
    }

    [Register("getFixedFreqValues", "()[I", "GetGetFixedFreqValuesHandler")]
    public virtual unsafe int[]? GetFixedFreqValues()
    {
      JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getFixedFreqValues.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }

    private static Delegate GetGetReaderCapsHandler()
    {
      if ((object) ReaderCapabilities.cb_getReaderCaps == null)
        ReaderCapabilities.cb_getReaderCaps = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ReaderCapabilities.n_GetReaderCaps));
      return ReaderCapabilities.cb_getReaderCaps;
    }

    private static void n_GetReaderCaps(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetReaderCaps();
    }

    [Register("getReaderCaps", "()V", "GetGetReaderCapsHandler")]
    public virtual unsafe void GetReaderCaps()
    {
      ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("getReaderCaps.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetReceiveSensitivityValuesHandler()
    {
      if ((object) ReaderCapabilities.cb_getReceiveSensitivityValues == null)
        ReaderCapabilities.cb_getReceiveSensitivityValues = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetReceiveSensitivityValues));
      return ReaderCapabilities.cb_getReceiveSensitivityValues;
    }

    private static IntPtr n_GetReceiveSensitivityValues(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetReceiveSensitivityValues());
    }

    [Register("getReceiveSensitivityValues", "()[I", "GetGetReceiveSensitivityValuesHandler")]
    public virtual unsafe int[]? GetReceiveSensitivityValues()
    {
      JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getReceiveSensitivityValues.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }

    private static Delegate GetGetTransmitPowerLevelValuesHandler()
    {
      if ((object) ReaderCapabilities.cb_getTransmitPowerLevelValues == null)
        ReaderCapabilities.cb_getTransmitPowerLevelValues = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.n_GetTransmitPowerLevelValues));
      return ReaderCapabilities.cb_getTransmitPowerLevelValues;
    }

    private static IntPtr n_GetTransmitPowerLevelValues(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetTransmitPowerLevelValues());
    }

    [Register("getTransmitPowerLevelValues", "()[I", "GetGetTransmitPowerLevelValuesHandler")]
    public virtual unsafe int[]? GetTransmitPowerLevelValues()
    {
      JniObjectReference jniObjectReference = ReaderCapabilities._members.InstanceMethods.InvokeVirtualObjectMethod("getTransmitPowerLevelValues.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }

    private static Delegate GetGetIsTagPhaseReportingSupportedHandler()
    {
      if ((object) ReaderCapabilities.cb_getIsTagPhaseReportingSupported == null)
        ReaderCapabilities.cb_getIsTagPhaseReportingSupported = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderCapabilities.n_GetIsTagPhaseReportingSupported));
      return ReaderCapabilities.cb_getIsTagPhaseReportingSupported;
    }

    private static bool n_GetIsTagPhaseReportingSupported(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).GetIsTagPhaseReportingSupported();
    }

    [Register("getIsTagPhaseReportingSupported", "()Z", "GetGetIsTagPhaseReportingSupportedHandler")]
    public virtual unsafe bool GetIsTagPhaseReportingSupported()
    {
      return ReaderCapabilities._members.InstanceMethods.InvokeVirtualBooleanMethod("getIsTagPhaseReportingSupported.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetDutyCycleValues_arraySHandler()
    {
      if ((object) ReaderCapabilities.cb_setDutyCycleValues_arrayS == null)
        ReaderCapabilities.cb_setDutyCycleValues_arrayS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetDutyCycleValues_arrayS));
      return ReaderCapabilities.cb_setDutyCycleValues_arrayS;
    }

    private static void n_SetDutyCycleValues_arrayS(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_DutyCycleValues)
    {
      ReaderCapabilities readerCapabilities = Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0);
      short[] array = (short[]) JNIEnv.GetArray(native_m_DutyCycleValues, (JniHandleOwnership) 0, typeof (short));
      short[] m_DutyCycleValues = array;
      readerCapabilities.SetDutyCycleValues(m_DutyCycleValues);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_m_DutyCycleValues);
    }

    [Register("setDutyCycleValues", "([S)V", "GetSetDutyCycleValues_arraySHandler")]
    public virtual unsafe void SetDutyCycleValues(short[]? m_DutyCycleValues)
    {
      IntPtr num = JNIEnv.NewArray(m_DutyCycleValues);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setDutyCycleValues.([S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_DutyCycleValues != null)
        {
          JNIEnv.CopyArray(num, m_DutyCycleValues);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_DutyCycleValues);
      }
    }

    private static Delegate GetSetFixedFreqValues_arrayIHandler()
    {
      if ((object) ReaderCapabilities.cb_setFixedFreqValues_arrayI == null)
        ReaderCapabilities.cb_setFixedFreqValues_arrayI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetFixedFreqValues_arrayI));
      return ReaderCapabilities.cb_setFixedFreqValues_arrayI;
    }

    private static void n_SetFixedFreqValues_arrayI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_FixedFreqValues)
    {
      ReaderCapabilities readerCapabilities = Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0);
      int[] array = (int[]) JNIEnv.GetArray(native_m_FixedFreqValues, (JniHandleOwnership) 0, typeof (int));
      int[] m_FixedFreqValues = array;
      readerCapabilities.SetFixedFreqValues(m_FixedFreqValues);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_m_FixedFreqValues);
    }

    [Register("setFixedFreqValues", "([I)V", "GetSetFixedFreqValues_arrayIHandler")]
    public virtual unsafe void SetFixedFreqValues(int[]? m_FixedFreqValues)
    {
      IntPtr num = JNIEnv.NewArray(m_FixedFreqValues);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setFixedFreqValues.([I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_FixedFreqValues != null)
        {
          JNIEnv.CopyArray(num, m_FixedFreqValues);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_FixedFreqValues);
      }
    }

    private static Delegate GetSetReceiveSensitivityValues_arrayIHandler()
    {
      if ((object) ReaderCapabilities.cb_setReceiveSensitivityValues_arrayI == null)
        ReaderCapabilities.cb_setReceiveSensitivityValues_arrayI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetReceiveSensitivityValues_arrayI));
      return ReaderCapabilities.cb_setReceiveSensitivityValues_arrayI;
    }

    private static void n_SetReceiveSensitivityValues_arrayI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_ReceiveSensitivityValues)
    {
      ReaderCapabilities readerCapabilities = Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0);
      int[] array = (int[]) JNIEnv.GetArray(native_m_ReceiveSensitivityValues, (JniHandleOwnership) 0, typeof (int));
      int[] m_ReceiveSensitivityValues = array;
      readerCapabilities.SetReceiveSensitivityValues(m_ReceiveSensitivityValues);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_m_ReceiveSensitivityValues);
    }

    [Register("setReceiveSensitivityValues", "([I)V", "GetSetReceiveSensitivityValues_arrayIHandler")]
    public virtual unsafe void SetReceiveSensitivityValues(int[]? m_ReceiveSensitivityValues)
    {
      IntPtr num = JNIEnv.NewArray(m_ReceiveSensitivityValues);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setReceiveSensitivityValues.([I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_ReceiveSensitivityValues != null)
        {
          JNIEnv.CopyArray(num, m_ReceiveSensitivityValues);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_ReceiveSensitivityValues);
      }
    }

    private static Delegate GetSetTransmitPowerLevelValues_arrayIHandler()
    {
      if ((object) ReaderCapabilities.cb_setTransmitPowerLevelValues_arrayI == null)
        ReaderCapabilities.cb_setTransmitPowerLevelValues_arrayI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.n_SetTransmitPowerLevelValues_arrayI));
      return ReaderCapabilities.cb_setTransmitPowerLevelValues_arrayI;
    }

    private static void n_SetTransmitPowerLevelValues_arrayI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_TransmitPowerLevelValues)
    {
      ReaderCapabilities readerCapabilities = Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0);
      int[] array = (int[]) JNIEnv.GetArray(native_m_TransmitPowerLevelValues, (JniHandleOwnership) 0, typeof (int));
      int[] m_TransmitPowerLevelValues = array;
      readerCapabilities.SetTransmitPowerLevelValues(m_TransmitPowerLevelValues);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_m_TransmitPowerLevelValues);
    }

    [Register("setTransmitPowerLevelValues", "([I)V", "GetSetTransmitPowerLevelValues_arrayIHandler")]
    public virtual unsafe void SetTransmitPowerLevelValues(int[]? m_TransmitPowerLevelValues)
    {
      IntPtr num = JNIEnv.NewArray(m_TransmitPowerLevelValues);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitPowerLevelValues.([I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_TransmitPowerLevelValues != null)
        {
          JNIEnv.CopyArray(num, m_TransmitPowerLevelValues);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_TransmitPowerLevelValues);
      }
    }

    private static Delegate GetUpdateReaderCapsHandler()
    {
      if ((object) ReaderCapabilities.cb_updateReaderCaps == null)
        ReaderCapabilities.cb_updateReaderCaps = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ReaderCapabilities.n_UpdateReaderCaps));
      return ReaderCapabilities.cb_updateReaderCaps;
    }

    private static void n_UpdateReaderCaps(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ReaderCapabilities>(jnienv, native__this, (JniHandleOwnership) 0).UpdateReaderCaps();
    }

    [Register("updateReaderCaps", "()V", "GetUpdateReaderCapsHandler")]
    public virtual unsafe void UpdateReaderCaps()
    {
      ReaderCapabilities._members.InstanceMethods.InvokeVirtualVoidMethod("updateReaderCaps.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("com/zebra/rfid/api3/ReaderCapabilities$ReaderIdentification", DoNotGenerateAcw = true)]
    public class ReaderIdentification : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderCapabilities$ReaderIdentification", typeof (ReaderCapabilities.ReaderIdentification));
      private static Delegate? cb_getID;
      private static Delegate? cb_setID_Ljava_lang_String_;
      private static Delegate? cb_getReaderIDType;
      private static Delegate? cb_setReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = ReaderCapabilities.ReaderIdentification._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => ReaderCapabilities.ReaderIdentification._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = ReaderCapabilities.ReaderIdentification._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => ReaderCapabilities.ReaderIdentification._members.ManagedPeerType;
      }

      protected ReaderIdentification(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetIDHandler()
      {
        if ((object) ReaderCapabilities.ReaderIdentification.cb_getID == null)
          ReaderCapabilities.ReaderIdentification.cb_getID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.ReaderIdentification.n_GetID));
        return ReaderCapabilities.ReaderIdentification.cb_getID;
      }

      private static IntPtr n_GetID(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<ReaderCapabilities.ReaderIdentification>(jnienv, native__this, (JniHandleOwnership) 0).ID);
      }

      private static Delegate GetSetID_Ljava_lang_String_Handler()
      {
        if ((object) ReaderCapabilities.ReaderIdentification.cb_setID_Ljava_lang_String_ == null)
          ReaderCapabilities.ReaderIdentification.cb_setID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.ReaderIdentification.n_SetID_Ljava_lang_String_));
        return ReaderCapabilities.ReaderIdentification.cb_setID_Ljava_lang_String_;
      }

      private static void n_SetID_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_sID)
      {
        Object.GetObject<ReaderCapabilities.ReaderIdentification>(jnienv, native__this, (JniHandleOwnership) 0).ID = JNIEnv.GetString(native_m_sID, (JniHandleOwnership) 0);
      }

      public virtual unsafe string? ID
      {
        [Register("getID", "()Ljava/lang/String;", "GetGetIDHandler")] get
        {
          JniObjectReference jniObjectReference = ReaderCapabilities.ReaderIdentification._members.InstanceMethods.InvokeVirtualObjectMethod("getID.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setID", "(Ljava/lang/String;)V", "GetSetID_Ljava_lang_String_Handler")] set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(num)
            };
            ReaderCapabilities.ReaderIdentification._members.InstanceMethods.InvokeVirtualVoidMethod("setID.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      private static Delegate GetGetReaderIDTypeHandler()
      {
        if ((object) ReaderCapabilities.ReaderIdentification.cb_getReaderIDType == null)
          ReaderCapabilities.ReaderIdentification.cb_getReaderIDType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderCapabilities.ReaderIdentification.n_GetReaderIDType));
        return ReaderCapabilities.ReaderIdentification.cb_getReaderIDType;
      }

      private static IntPtr n_GetReaderIDType(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderCapabilities.ReaderIdentification>(jnienv, native__this, (JniHandleOwnership) 0).ReaderIDType);
      }

      private static Delegate GetSetReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_Handler()
      {
        if ((object) ReaderCapabilities.ReaderIdentification.cb_setReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_ == null)
          ReaderCapabilities.ReaderIdentification.cb_setReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderCapabilities.ReaderIdentification.n_SetReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_));
        return ReaderCapabilities.ReaderIdentification.cb_setReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_;
      }

      private static void n_SetReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_eType)
      {
        Object.GetObject<ReaderCapabilities.ReaderIdentification>(jnienv, native__this, (JniHandleOwnership) 0).ReaderIDType = Object.GetObject<READER_ID_TYPE>(native_m_eType, (JniHandleOwnership) 0);
      }

      public virtual unsafe READER_ID_TYPE? ReaderIDType
      {
        [Register("getReaderIDType", "()Lcom/zebra/rfid/api3/READER_ID_TYPE;", "GetGetReaderIDTypeHandler")] get
        {
          JniObjectReference jniObjectReference = ReaderCapabilities.ReaderIdentification._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderIDType.()Lcom/zebra/rfid/api3/READER_ID_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<READER_ID_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setReaderIDType", "(Lcom/zebra/rfid/api3/READER_ID_TYPE;)V", "GetSetReaderIDType_Lcom_zebra_rfid_api3_READER_ID_TYPE_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            ReaderCapabilities.ReaderIdentification._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderIDType.(Lcom/zebra/rfid/api3/READER_ID_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }
    }
  }
}
