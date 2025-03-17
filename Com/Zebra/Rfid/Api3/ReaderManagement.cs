// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReaderManagement
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/ReaderManagement", DoNotGenerateAcw = true)]
  public class ReaderManagement : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderManagement", typeof (ReaderManagement));
    private static Delegate? cb_getActiveRegionStandardInfo;
    private static Delegate? cb_getAntennaMode;
    private static Delegate? cb_setAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_;
    private static Delegate? cb_getGPIDebounceTimeMilliseconds;
    private static Delegate? cb_setGPIDebounceTimeMilliseconds_I;
    private static Delegate? cb_isLoggedIn;
    private static Delegate? cb_getLocalTime;
    private static Delegate? cb_getProfileList;
    private static Delegate? cb_getRadioConfigUpdate;
    private static Delegate? cb_getRadioFirmwareUpdate;
    private static Delegate? cb_getRadioIdleTimeout;
    private static Delegate? cb_getReaderInfo;
    private static Delegate? cb_setReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_;
    private static Delegate? cb_getSoftwareUpdate;
    private static Delegate? cb_getSystemInfo;
    private static Delegate? cb_getTimeZoneList;
    private static Delegate? cb_getUSBOperationMode;
    private static Delegate? cb_clearReaderStatistics;
    private static Delegate? cb_deleteProfile_Ljava_lang_String_;
    private static Delegate? cb_dispose;
    private static Delegate? cb_exportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z;
    private static Delegate? cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z;
    private static Delegate? cb_getCableLossCompensation_I;
    private static Delegate? cb_getHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_;
    private static Delegate? cb_getNtpServer;
    private static Delegate? cb_getReaderStatistics_S;
    private static Delegate? cb_getRegionStandardList_Ljava_lang_String_;
    private static Delegate? cb_getSupportedRegionList;
    private static Delegate? cb_getTraceLevel;
    private static Delegate? cb_importFromReader_Landroid_content_Context_Ljava_lang_String_;
    private static Delegate? cb_importFromReader_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_;
    private static Delegate? cb_logout;
    private static Delegate? cb_restart;
    private static Delegate? cb_setActiveProfile_Ljava_lang_String_;
    private static Delegate? cb_setActiveRegion_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_;
    private static Delegate? cb_setFrequencySetting_ZarrayI;
    private static Delegate? cb_setLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    private static Delegate? cb_setNtpServer_Ljava_lang_String_;
    private static Delegate? cb_setTimeZone_S;
    private static Delegate? cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_;
    private static Delegate? cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_;
    private static Delegate? cb_setUserLED_Lcom_zebra_rfid_api3_LedInfo_;
    private static Delegate? cb_turnOffRadiowhenIdle_I;

    [Register("LLRPConnection")]
    public LLRPConnection? LLRPConnection
    {
      get
      {
        JniObjectReference objectValue = ReaderManagement._members.InstanceFields.GetObjectValue("LLRPConnection.Lcom/zebra/rfid/api3/LLRPConnection;", (IJavaPeerable) this);
        return Object.GetObject<LLRPConnection>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderManagement._members.InstanceFields.SetValue("LLRPConnection.Lcom/zebra/rfid/api3/LLRPConnection;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Profile")]
    public Profile? Profile
    {
      get
      {
        JniObjectReference objectValue = ReaderManagement._members.InstanceFields.GetObjectValue("Profile.Lcom/zebra/rfid/api3/Profile;", (IJavaPeerable) this);
        return Object.GetObject<Profile>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderManagement._members.InstanceFields.SetValue("Profile.Lcom/zebra/rfid/api3/Profile;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("ReadPoint")]
    public ReadPoint? ReadPoint
    {
      get
      {
        JniObjectReference objectValue = ReaderManagement._members.InstanceFields.GetObjectValue("ReadPoint.Lcom/zebra/rfid/api3/ReadPoint;", (IJavaPeerable) this);
        return Object.GetObject<ReadPoint>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderManagement._members.InstanceFields.SetValue("ReadPoint.Lcom/zebra/rfid/api3/ReadPoint;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TimeZone")]
    public TimeZone? TimeZone
    {
      get
      {
        JniObjectReference objectValue = ReaderManagement._members.InstanceFields.GetObjectValue("TimeZone.Lcom/zebra/rfid/api3/TimeZone;", (IJavaPeerable) this);
        return Object.GetObject<TimeZone>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderManagement._members.InstanceFields.SetValue("TimeZone.Lcom/zebra/rfid/api3/TimeZone;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("UserApp")]
    public UserApp? UserApp
    {
      get
      {
        JniObjectReference objectValue = ReaderManagement._members.InstanceFields.GetObjectValue("UserApp.Lcom/zebra/rfid/api3/UserApp;", (IJavaPeerable) this);
        return Object.GetObject<UserApp>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          ReaderManagement._members.InstanceFields.SetValue("UserApp.Lcom/zebra/rfid/api3/UserApp;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = ReaderManagement._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReaderManagement._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReaderManagement._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReaderManagement._members.ManagedPeerType;

    protected ReaderManagement(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ReaderManagement()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ReaderManagement._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ReaderManagement._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetActiveRegionStandardInfoHandler()
    {
      if ((object) ReaderManagement.cb_getActiveRegionStandardInfo == null)
        ReaderManagement.cb_getActiveRegionStandardInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetActiveRegionStandardInfo));
      return ReaderManagement.cb_getActiveRegionStandardInfo;
    }

    private static IntPtr n_GetActiveRegionStandardInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).ActiveRegionStandardInfo);
    }

    public virtual unsafe CommunicationStandardInfo? ActiveRegionStandardInfo
    {
      [Register("getActiveRegionStandardInfo", "()Lcom/zebra/rfid/api3/CommunicationStandardInfo;", "GetGetActiveRegionStandardInfoHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getActiveRegionStandardInfo.()Lcom/zebra/rfid/api3/CommunicationStandardInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<CommunicationStandardInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetAntennaModeHandler()
    {
      if ((object) ReaderManagement.cb_getAntennaMode == null)
        ReaderManagement.cb_getAntennaMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetAntennaMode));
      return ReaderManagement.cb_getAntennaMode;
    }

    private static IntPtr n_GetAntennaMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).AntennaMode);
    }

    private static Delegate GetSetAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_Handler()
    {
      if ((object) ReaderManagement.cb_setAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_ == null)
        ReaderManagement.cb_setAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_));
      return ReaderManagement.cb_setAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_;
    }

    private static void n_SetAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_antennaMode)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).AntennaMode = Object.GetObject<ANTENNA_MODE>(native_antennaMode, (JniHandleOwnership) 0);
    }

    public virtual unsafe ANTENNA_MODE? AntennaMode
    {
      [Register("getAntennaMode", "()Lcom/zebra/rfid/api3/ANTENNA_MODE;", "GetGetAntennaModeHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaMode.()Lcom/zebra/rfid/api3/ANTENNA_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ANTENNA_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAntennaMode", "(Lcom/zebra/rfid/api3/ANTENNA_MODE;)V", "GetSetAntennaMode_Lcom_zebra_rfid_api3_ANTENNA_MODE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaMode.(Lcom/zebra/rfid/api3/ANTENNA_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetGPIDebounceTimeMillisecondsHandler()
    {
      if ((object) ReaderManagement.cb_getGPIDebounceTimeMilliseconds == null)
        ReaderManagement.cb_getGPIDebounceTimeMilliseconds = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderManagement.n_GetGPIDebounceTimeMilliseconds));
      return ReaderManagement.cb_getGPIDebounceTimeMilliseconds;
    }

    private static int n_GetGPIDebounceTimeMilliseconds(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GPIDebounceTimeMilliseconds;
    }

    private static Delegate GetSetGPIDebounceTimeMilliseconds_IHandler()
    {
      if ((object) ReaderManagement.cb_setGPIDebounceTimeMilliseconds_I == null)
        ReaderManagement.cb_setGPIDebounceTimeMilliseconds_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderManagement.n_SetGPIDebounceTimeMilliseconds_I));
      return ReaderManagement.cb_setGPIDebounceTimeMilliseconds_I;
    }

    private static void n_SetGPIDebounceTimeMilliseconds_I(
      IntPtr jnienv,
      IntPtr native__this,
      int gpiDebounceTimeMilliseconds)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GPIDebounceTimeMilliseconds = gpiDebounceTimeMilliseconds;
    }

    public virtual unsafe int GPIDebounceTimeMilliseconds
    {
      [Register("getGPIDebounceTimeMilliseconds", "()I", "GetGetGPIDebounceTimeMillisecondsHandler")] get
      {
        return ReaderManagement._members.InstanceMethods.InvokeVirtualInt32Method("getGPIDebounceTimeMilliseconds.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setGPIDebounceTimeMilliseconds", "(I)V", "GetSetGPIDebounceTimeMilliseconds_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setGPIDebounceTimeMilliseconds.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsLoggedInHandler()
    {
      if ((object) ReaderManagement.cb_isLoggedIn == null)
        ReaderManagement.cb_isLoggedIn = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderManagement.n_IsLoggedIn));
      return ReaderManagement.cb_isLoggedIn;
    }

    private static bool n_IsLoggedIn(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).IsLoggedIn;
    }

    public virtual unsafe bool IsLoggedIn
    {
      [Register("isLoggedIn", "()Z", "GetIsLoggedInHandler")] get
      {
        return ReaderManagement._members.InstanceMethods.InvokeVirtualBooleanMethod("isLoggedIn.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLocalTimeHandler()
    {
      if ((object) ReaderManagement.cb_getLocalTime == null)
        ReaderManagement.cb_getLocalTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetLocalTime));
      return ReaderManagement.cb_getLocalTime;
    }

    private static IntPtr n_GetLocalTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).LocalTime);
    }

    public virtual unsafe string? LocalTime
    {
      [Register("getLocalTime", "()Ljava/lang/String;", "GetGetLocalTimeHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getLocalTime.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetProfileListHandler()
    {
      if ((object) ReaderManagement.cb_getProfileList == null)
        ReaderManagement.cb_getProfileList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetProfileList));
      return ReaderManagement.cb_getProfileList;
    }

    private static IntPtr n_GetProfileList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).ProfileList);
    }

    public virtual unsafe ProfileInfo? ProfileList
    {
      [Register("getProfileList", "()Lcom/zebra/rfid/api3/ProfileInfo;", "GetGetProfileListHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getProfileList.()Lcom/zebra/rfid/api3/ProfileInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ProfileInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioConfigUpdateHandler()
    {
      if ((object) ReaderManagement.cb_getRadioConfigUpdate == null)
        ReaderManagement.cb_getRadioConfigUpdate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetRadioConfigUpdate));
      return ReaderManagement.cb_getRadioConfigUpdate;
    }

    private static IntPtr n_GetRadioConfigUpdate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).RadioConfigUpdate);
    }

    public virtual unsafe Object? RadioConfigUpdate
    {
      [Register("getRadioConfigUpdate", "()Ljava/lang/Object;", "GetGetRadioConfigUpdateHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioConfigUpdate.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioFirmwareUpdateHandler()
    {
      if ((object) ReaderManagement.cb_getRadioFirmwareUpdate == null)
        ReaderManagement.cb_getRadioFirmwareUpdate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetRadioFirmwareUpdate));
      return ReaderManagement.cb_getRadioFirmwareUpdate;
    }

    private static IntPtr n_GetRadioFirmwareUpdate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).RadioFirmwareUpdate);
    }

    public virtual unsafe Object? RadioFirmwareUpdate
    {
      [Register("getRadioFirmwareUpdate", "()Ljava/lang/Object;", "GetGetRadioFirmwareUpdateHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioFirmwareUpdate.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioIdleTimeoutHandler()
    {
      if ((object) ReaderManagement.cb_getRadioIdleTimeout == null)
        ReaderManagement.cb_getRadioIdleTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderManagement.n_GetRadioIdleTimeout));
      return ReaderManagement.cb_getRadioIdleTimeout;
    }

    private static int n_GetRadioIdleTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).RadioIdleTimeout;
    }

    public virtual unsafe int RadioIdleTimeout
    {
      [Register("getRadioIdleTimeout", "()I", "GetGetRadioIdleTimeoutHandler")] get
      {
        return ReaderManagement._members.InstanceMethods.InvokeVirtualInt32Method("getRadioIdleTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetReaderInfoHandler()
    {
      if ((object) ReaderManagement.cb_getReaderInfo == null)
        ReaderManagement.cb_getReaderInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetReaderInfo));
      return ReaderManagement.cb_getReaderInfo;
    }

    private static IntPtr n_GetReaderInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).ReaderInfo);
    }

    private static Delegate GetSetReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_Handler()
    {
      if ((object) ReaderManagement.cb_setReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_ == null)
        ReaderManagement.cb_setReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_));
      return ReaderManagement.cb_setReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_;
    }

    private static void n_SetReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerInfo)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).ReaderInfo = Object.GetObject<ReaderInfo>(native_readerInfo, (JniHandleOwnership) 0);
    }

    public virtual unsafe ReaderInfo? ReaderInfo
    {
      [Register("getReaderInfo", "()Lcom/zebra/rfid/api3/ReaderInfo;", "GetGetReaderInfoHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderInfo.()Lcom/zebra/rfid/api3/ReaderInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ReaderInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setReaderInfo", "(Lcom/zebra/rfid/api3/ReaderInfo;)V", "GetSetReaderInfo_Lcom_zebra_rfid_api3_ReaderInfo_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderInfo.(Lcom/zebra/rfid/api3/ReaderInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetSoftwareUpdateHandler()
    {
      if ((object) ReaderManagement.cb_getSoftwareUpdate == null)
        ReaderManagement.cb_getSoftwareUpdate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetSoftwareUpdate));
      return ReaderManagement.cb_getSoftwareUpdate;
    }

    private static IntPtr n_GetSoftwareUpdate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SoftwareUpdate);
    }

    public virtual unsafe SoftwareUpdate? SoftwareUpdate
    {
      [Register("getSoftwareUpdate", "()Lcom/zebra/rfid/api3/SoftwareUpdate;", "GetGetSoftwareUpdateHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getSoftwareUpdate.()Lcom/zebra/rfid/api3/SoftwareUpdate;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SoftwareUpdate>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSystemInfoHandler()
    {
      if ((object) ReaderManagement.cb_getSystemInfo == null)
        ReaderManagement.cb_getSystemInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetSystemInfo));
      return ReaderManagement.cb_getSystemInfo;
    }

    private static IntPtr n_GetSystemInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SystemInfo);
    }

    public virtual unsafe SystemInfo? SystemInfo
    {
      [Register("getSystemInfo", "()Lcom/zebra/rfid/api3/SystemInfo;", "GetGetSystemInfoHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getSystemInfo.()Lcom/zebra/rfid/api3/SystemInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SystemInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTimeZoneListHandler()
    {
      if ((object) ReaderManagement.cb_getTimeZoneList == null)
        ReaderManagement.cb_getTimeZoneList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetTimeZoneList));
      return ReaderManagement.cb_getTimeZoneList;
    }

    private static IntPtr n_GetTimeZoneList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).TimeZoneList);
    }

    public virtual unsafe TimeZoneInfo? TimeZoneList
    {
      [Register("getTimeZoneList", "()Lcom/zebra/rfid/api3/TimeZoneInfo;", "GetGetTimeZoneListHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getTimeZoneList.()Lcom/zebra/rfid/api3/TimeZoneInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<TimeZoneInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUSBOperationModeHandler()
    {
      if ((object) ReaderManagement.cb_getUSBOperationMode == null)
        ReaderManagement.cb_getUSBOperationMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetUSBOperationMode));
      return ReaderManagement.cb_getUSBOperationMode;
    }

    private static IntPtr n_GetUSBOperationMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).USBOperationMode);
    }

    public virtual unsafe Object? USBOperationMode
    {
      [Register("getUSBOperationMode", "()Ljava/lang/Object;", "GetGetUSBOperationModeHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getUSBOperationMode.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetClearReaderStatisticsHandler()
    {
      if ((object) ReaderManagement.cb_clearReaderStatistics == null)
        ReaderManagement.cb_clearReaderStatistics = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ReaderManagement.n_ClearReaderStatistics));
      return ReaderManagement.cb_clearReaderStatistics;
    }

    private static bool n_ClearReaderStatistics(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).ClearReaderStatistics();
    }

    [Register("clearReaderStatistics", "()Z", "GetClearReaderStatisticsHandler")]
    public virtual unsafe bool ClearReaderStatistics()
    {
      return ReaderManagement._members.InstanceMethods.InvokeVirtualBooleanMethod("clearReaderStatistics.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDeleteProfile_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_deleteProfile_Ljava_lang_String_ == null)
        ReaderManagement.cb_deleteProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_DeleteProfile_Ljava_lang_String_));
      return ReaderManagement.cb_deleteProfile_Ljava_lang_String_;
    }

    private static void n_DeleteProfile_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).DeleteProfile(JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0));
    }

    [Register("deleteProfile", "(Ljava/lang/String;)V", "GetDeleteProfile_Ljava_lang_String_Handler")]
    public virtual unsafe void DeleteProfile(string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("deleteProfile.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetDisposeHandler()
    {
      if ((object) ReaderManagement.cb_dispose == null)
        ReaderManagement.cb_dispose = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ReaderManagement.n_Dispose));
      return ReaderManagement.cb_dispose;
    }

    private static void n_Dispose(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).Dispose();
    }

    [Register("dispose", "()V", "GetDisposeHandler")]
    public virtual unsafe void Dispose()
    {
      ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("dispose.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetExportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_ZHandler()
    {
      if ((object) ReaderManagement.cb_exportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z == null)
        ReaderManagement.cb_exportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZ_V(ReaderManagement.n_ExportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z));
      return ReaderManagement.cb_exportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z;
    }

    private static void n_ExportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_uri,
      IntPtr native_context,
      IntPtr native_profileName,
      bool activation)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      Uri uri1 = Object.GetObject<Uri>(native_uri, (JniHandleOwnership) 0);
      Context context1 = Object.GetObject<Context>(native_context, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      Uri uri2 = uri1;
      Context context2 = context1;
      string profileName = str;
      int num = activation ? 1 : 0;
      readerManagement.ExportToReader(uri2, context2, profileName, num != 0);
    }

    [Register("exportToReader", "(Landroid/net/Uri;Landroid/content/Context;Ljava/lang/String;Z)V", "GetExportToReader_Landroid_net_Uri_Landroid_content_Context_Ljava_lang_String_ZHandler")]
    public virtual unsafe void ExportToReader(
      Uri? uri,
      Context? context,
      string? profileName,
      bool activation)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(uri == null ? IntPtr.Zero : ((Object) uri).Handle),
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(activation)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("exportToReader.(Landroid/net/Uri;Landroid/content/Context;Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) uri);
        GC.KeepAlive((object) context);
      }
    }

    private static Delegate GetExportToReader_Ljava_lang_String_Ljava_lang_String_ZHandler()
    {
      if ((object) ReaderManagement.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z == null)
        ReaderManagement.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLZ_V(ReaderManagement.n_ExportToReader_Ljava_lang_String_Ljava_lang_String_Z));
      return ReaderManagement.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z;
    }

    private static void n_ExportToReader_Ljava_lang_String_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName,
      IntPtr native_profilePath,
      bool activation)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_profilePath, (JniHandleOwnership) 0);
      string profileName = str1;
      string profilePath = str2;
      int num = activation ? 1 : 0;
      readerManagement.ExportToReader(profileName, profilePath, num != 0);
    }

    [Register("exportToReader", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetExportToReader_Ljava_lang_String_Ljava_lang_String_ZHandler")]
    public virtual unsafe void ExportToReader(
      string? profileName,
      string? profilePath,
      bool activation)
    {
      IntPtr num1 = JNIEnv.NewString(profileName);
      IntPtr num2 = JNIEnv.NewString(profilePath);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(activation)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("exportToReader.(Ljava/lang/String;Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetGetCableLossCompensation_IHandler()
    {
      if ((object) ReaderManagement.cb_getCableLossCompensation_I == null)
        ReaderManagement.cb_getCableLossCompensation_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(ReaderManagement.n_GetCableLossCompensation_I));
      return ReaderManagement.cb_getCableLossCompensation_I;
    }

    private static IntPtr n_GetCableLossCompensation_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetCableLossCompensation(antennaID));
    }

    [Register("getCableLossCompensation", "(I)Lcom/zebra/rfid/api3/CableLossCompensation;", "GetGetCableLossCompensation_IHandler")]
    public virtual unsafe CableLossCompensation? GetCableLossCompensation(int antennaID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaID)
      };
      JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getCableLossCompensation.(I)Lcom/zebra/rfid/api3/CableLossCompensation;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<CableLossCompensation>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_Handler()
    {
      if ((object) ReaderManagement.cb_getHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_ == null)
        ReaderManagement.cb_getHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(ReaderManagement.n_GetHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_));
      return ReaderManagement.cb_getHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_;
    }

    private static IntPtr n_GetHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_serviceID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetHealthStatus(Object.GetObject<SERVICE_ID>(native_serviceID, (JniHandleOwnership) 0)));
    }

    [Register("getHealthStatus", "(Lcom/zebra/rfid/api3/SERVICE_ID;)Lcom/zebra/rfid/api3/HEALTH_STATUS;", "GetGetHealthStatus_Lcom_zebra_rfid_api3_SERVICE_ID_Handler")]
    public virtual unsafe HEALTH_STATUS? GetHealthStatus(SERVICE_ID? serviceID)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(serviceID == null ? IntPtr.Zero : serviceID.Handle)
        };
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getHealthStatus.(Lcom/zebra/rfid/api3/SERVICE_ID;)Lcom/zebra/rfid/api3/HEALTH_STATUS;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<HEALTH_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) serviceID);
      }
    }

    private static Delegate GetGetNtpServerHandler()
    {
      if ((object) ReaderManagement.cb_getNtpServer == null)
        ReaderManagement.cb_getNtpServer = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetNtpServer));
      return ReaderManagement.cb_getNtpServer;
    }

    private static IntPtr n_GetNtpServer(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetNtpServer());
    }

    [Register("getNtpServer", "()[Ljava/lang/String;", "GetGetNtpServerHandler")]
    public virtual unsafe string[]? GetNtpServer()
    {
      JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getNtpServer.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }

    private static Delegate GetGetReaderStatistics_SHandler()
    {
      if ((object) ReaderManagement.cb_getReaderStatistics_S == null)
        ReaderManagement.cb_getReaderStatistics_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_L(ReaderManagement.n_GetReaderStatistics_S));
      return ReaderManagement.cb_getReaderStatistics_S;
    }

    private static IntPtr n_GetReaderStatistics_S(
      IntPtr jnienv,
      IntPtr native__this,
      short antennaID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetReaderStatistics(antennaID));
    }

    [Register("getReaderStatistics", "(S)Lcom/zebra/rfid/api3/ReaderStatistics;", "GetGetReaderStatistics_SHandler")]
    public virtual unsafe ReaderStatistics? GetReaderStatistics(short antennaID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaID)
      };
      JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderStatistics.(S)Lcom/zebra/rfid/api3/ReaderStatistics;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<ReaderStatistics>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetRegionStandardList_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_getRegionStandardList_Ljava_lang_String_ == null)
        ReaderManagement.cb_getRegionStandardList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(ReaderManagement.n_GetRegionStandardList_Ljava_lang_String_));
      return ReaderManagement.cb_getRegionStandardList_Ljava_lang_String_;
    }

    private static IntPtr n_GetRegionStandardList_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_regionName)
    {
      return JNIEnv.NewArray<CommunicationStandardInfo>(Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetRegionStandardList(JNIEnv.GetString(native_regionName, (JniHandleOwnership) 0)));
    }

    [Register("getRegionStandardList", "(Ljava/lang/String;)[Lcom/zebra/rfid/api3/CommunicationStandardInfo;", "GetGetRegionStandardList_Ljava_lang_String_Handler")]
    public virtual unsafe CommunicationStandardInfo[]? GetRegionStandardList(string? regionName)
    {
      IntPtr num = JNIEnv.NewString(regionName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getRegionStandardList.(Ljava/lang/String;)[Lcom/zebra/rfid/api3/CommunicationStandardInfo;", (IJavaPeerable) this, jniArgumentValuePtr);
        return (CommunicationStandardInfo[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (CommunicationStandardInfo));
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetSupportedRegionListHandler()
    {
      if ((object) ReaderManagement.cb_getSupportedRegionList == null)
        ReaderManagement.cb_getSupportedRegionList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetSupportedRegionList));
      return ReaderManagement.cb_getSupportedRegionList;
    }

    private static IntPtr n_GetSupportedRegionList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetSupportedRegionList());
    }

    [Register("getSupportedRegionList", "()[Ljava/lang/String;", "GetGetSupportedRegionListHandler")]
    public virtual unsafe string[]? GetSupportedRegionList()
    {
      JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportedRegionList.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }

    private static Delegate GetGetTraceLevelHandler()
    {
      if ((object) ReaderManagement.cb_getTraceLevel == null)
        ReaderManagement.cb_getTraceLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderManagement.n_GetTraceLevel));
      return ReaderManagement.cb_getTraceLevel;
    }

    private static IntPtr n_GetTraceLevel(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<TRACE_LEVEL>(Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).GetTraceLevel());
    }

    [Register("getTraceLevel", "()[Lcom/zebra/rfid/api3/TRACE_LEVEL;", "GetGetTraceLevelHandler")]
    public virtual unsafe TRACE_LEVEL[]? GetTraceLevel()
    {
      JniObjectReference jniObjectReference = ReaderManagement._members.InstanceMethods.InvokeVirtualObjectMethod("getTraceLevel.()[Lcom/zebra/rfid/api3/TRACE_LEVEL;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (TRACE_LEVEL[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TRACE_LEVEL));
    }

    private static Delegate GetImportFromReader_Landroid_content_Context_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_importFromReader_Landroid_content_Context_Ljava_lang_String_ == null)
        ReaderManagement.cb_importFromReader_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(ReaderManagement.n_ImportFromReader_Landroid_content_Context_Ljava_lang_String_));
      return ReaderManagement.cb_importFromReader_Landroid_content_Context_Ljava_lang_String_;
    }

    private static void n_ImportFromReader_Landroid_content_Context_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_context,
      IntPtr native_profileName)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      Context context1 = Object.GetObject<Context>(native_context, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      Context context2 = context1;
      string profileName = str;
      readerManagement.ImportFromReader(context2, profileName);
    }

    [Register("importFromReader", "(Landroid/content/Context;Ljava/lang/String;)V", "GetImportFromReader_Landroid_content_Context_Ljava_lang_String_Handler")]
    public virtual unsafe void ImportFromReader(Context? context, string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("importFromReader.(Landroid/content/Context;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) context);
      }
    }

    private static Delegate GetImportFromReader_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_ == null)
        ReaderManagement.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(ReaderManagement.n_ImportFromReader_Ljava_lang_String_Ljava_lang_String_));
      return ReaderManagement.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_;
    }

    private static void n_ImportFromReader_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName,
      IntPtr native_profilePath)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_profilePath, (JniHandleOwnership) 0);
      string profileName = str1;
      string profilePath = str2;
      readerManagement.ImportFromReader(profileName, profilePath);
    }

    [Register("importFromReader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetImportFromReader_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe void ImportFromReader(string? profileName, string? profilePath)
    {
      IntPtr num1 = JNIEnv.NewString(profileName);
      IntPtr num2 = JNIEnv.NewString(profilePath);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("importFromReader.(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetLogin_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_Handler()
    {
      if ((object) ReaderManagement.cb_login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_ == null)
        ReaderManagement.cb_login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(ReaderManagement.n_Login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_));
      return ReaderManagement.cb_login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_;
    }

    private static void n_Login_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_loginInfo,
      IntPtr native_readerType)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      LoginInfo loginInfo1 = Object.GetObject<LoginInfo>(native_loginInfo, (JniHandleOwnership) 0);
      READER_TYPE readerType1 = Object.GetObject<READER_TYPE>(native_readerType, (JniHandleOwnership) 0);
      LoginInfo loginInfo2 = loginInfo1;
      READER_TYPE readerType2 = readerType1;
      readerManagement.Login(loginInfo2, readerType2);
    }

    [Register("login", "(Lcom/zebra/rfid/api3/LoginInfo;Lcom/zebra/rfid/api3/READER_TYPE;)V", "GetLogin_Lcom_zebra_rfid_api3_LoginInfo_Lcom_zebra_rfid_api3_READER_TYPE_Handler")]
    public virtual unsafe void Login(LoginInfo? loginInfo, READER_TYPE? readerType)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(loginInfo == null ? IntPtr.Zero : loginInfo.Handle),
          new JniArgumentValue(readerType == null ? IntPtr.Zero : readerType.Handle)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("login.(Lcom/zebra/rfid/api3/LoginInfo;Lcom/zebra/rfid/api3/READER_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) loginInfo);
        GC.KeepAlive((object) readerType);
      }
    }

    private static Delegate GetLogoutHandler()
    {
      if ((object) ReaderManagement.cb_logout == null)
        ReaderManagement.cb_logout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ReaderManagement.n_Logout));
      return ReaderManagement.cb_logout;
    }

    private static void n_Logout(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).Logout();
    }

    [Register("logout", "()V", "GetLogoutHandler")]
    public virtual unsafe void Logout()
    {
      ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("logout.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetRestartHandler()
    {
      if ((object) ReaderManagement.cb_restart == null)
        ReaderManagement.cb_restart = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ReaderManagement.n_Restart));
      return ReaderManagement.cb_restart;
    }

    private static void n_Restart(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).Restart();
    }

    [Register("restart", "()V", "GetRestartHandler")]
    public virtual unsafe void Restart()
    {
      ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("restart.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetActiveProfile_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_setActiveProfile_Ljava_lang_String_ == null)
        ReaderManagement.cb_setActiveProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetActiveProfile_Ljava_lang_String_));
      return ReaderManagement.cb_setActiveProfile_Ljava_lang_String_;
    }

    private static void n_SetActiveProfile_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetActiveProfile(JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0));
    }

    [Register("setActiveProfile", "(Ljava/lang/String;)V", "GetSetActiveProfile_Ljava_lang_String_Handler")]
    public virtual unsafe void SetActiveProfile(string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setActiveProfile.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetActiveRegion_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_setActiveRegion_Ljava_lang_String_Ljava_lang_String_ == null)
        ReaderManagement.cb_setActiveRegion_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(ReaderManagement.n_SetActiveRegion_Ljava_lang_String_Ljava_lang_String_));
      return ReaderManagement.cb_setActiveRegion_Ljava_lang_String_Ljava_lang_String_;
    }

    private static void n_SetActiveRegion_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_regionName,
      IntPtr native_StandardName)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_regionName, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_StandardName, (JniHandleOwnership) 0);
      string regionName = str1;
      string StandardName = str2;
      readerManagement.SetActiveRegion(regionName, StandardName);
    }

    [Register("setActiveRegion", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetActiveRegion_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe void SetActiveRegion(string? regionName, string? StandardName)
    {
      IntPtr num1 = JNIEnv.NewString(regionName);
      IntPtr num2 = JNIEnv.NewString(StandardName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setActiveRegion.(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetSetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_Handler()
    {
      if ((object) ReaderManagement.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_ == null)
        ReaderManagement.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_));
      return ReaderManagement.cb_setCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_;
    }

    private static void n_SetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cableLossCompensationInfo)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      CableLossCompensation[] array = (CableLossCompensation[]) JNIEnv.GetArray(native_cableLossCompensationInfo, (JniHandleOwnership) 0, typeof (CableLossCompensation));
      CableLossCompensation[] cableLossCompensationInfo = array;
      readerManagement.SetCableLossCompensation(cableLossCompensationInfo);
      if (array == null)
        return;
      JNIEnv.CopyArray<CableLossCompensation>(array, native_cableLossCompensationInfo);
    }

    [Register("setCableLossCompensation", "([Lcom/zebra/rfid/api3/CableLossCompensation;)V", "GetSetCableLossCompensation_arrayLcom_zebra_rfid_api3_CableLossCompensation_Handler")]
    public virtual unsafe void SetCableLossCompensation(
      CableLossCompensation[]? cableLossCompensationInfo)
    {
      IntPtr num = JNIEnv.NewArray<CableLossCompensation>(cableLossCompensationInfo);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setCableLossCompensation.([Lcom/zebra/rfid/api3/CableLossCompensation;)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetFrequencySetting_ZarrayIHandler()
    {
      if ((object) ReaderManagement.cb_setFrequencySetting_ZarrayI == null)
        ReaderManagement.cb_setFrequencySetting_ZarrayI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZL_V(ReaderManagement.n_SetFrequencySetting_ZarrayI));
      return ReaderManagement.cb_setFrequencySetting_ZarrayI;
    }

    private static void n_SetFrequencySetting_ZarrayI(
      IntPtr jnienv,
      IntPtr native__this,
      bool enableFrequencyHopping,
      IntPtr native_channelIndexList)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      int[] array = (int[]) JNIEnv.GetArray(native_channelIndexList, (JniHandleOwnership) 0, typeof (int));
      int num = enableFrequencyHopping ? 1 : 0;
      int[] channelIndexList = array;
      readerManagement.SetFrequencySetting(num != 0, channelIndexList);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_channelIndexList);
    }

    [Register("setFrequencySetting", "(Z[I)V", "GetSetFrequencySetting_ZarrayIHandler")]
    public virtual unsafe void SetFrequencySetting(
      bool enableFrequencyHopping,
      int[]? channelIndexList)
    {
      IntPtr num = JNIEnv.NewArray(channelIndexList);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(enableFrequencyHopping),
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setFrequencySetting.(Z[I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (channelIndexList != null)
        {
          JNIEnv.CopyArray(num, channelIndexList);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) channelIndexList);
      }
    }

    private static Delegate GetSetLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler()
    {
      if ((object) ReaderManagement.cb_setLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_ == null)
        ReaderManagement.cb_setLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_));
      return ReaderManagement.cb_setLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    }

    private static void n_SetLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_localTime)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetLocalTime(Object.GetObject<SYSTEMTIME>(native_localTime, (JniHandleOwnership) 0));
    }

    [Register("setLocalTime", "(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", "GetSetLocalTime_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler")]
    public virtual unsafe void SetLocalTime(SYSTEMTIME? localTime)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(localTime == null ? IntPtr.Zero : localTime.Handle)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalTime.(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) localTime);
      }
    }

    private static Delegate GetSetNtpServer_Ljava_lang_String_Handler()
    {
      if ((object) ReaderManagement.cb_setNtpServer_Ljava_lang_String_ == null)
        ReaderManagement.cb_setNtpServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetNtpServer_Ljava_lang_String_));
      return ReaderManagement.cb_setNtpServer_Ljava_lang_String_;
    }

    private static void n_SetNtpServer_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_hostName)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetNtpServer(JNIEnv.GetString(native_hostName, (JniHandleOwnership) 0));
    }

    [Register("setNtpServer", "(Ljava/lang/String;)V", "GetSetNtpServer_Ljava_lang_String_Handler")]
    public virtual unsafe void SetNtpServer(string? hostName)
    {
      IntPtr num = JNIEnv.NewString(hostName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setNtpServer.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetTimeZone_SHandler()
    {
      if ((object) ReaderManagement.cb_setTimeZone_S == null)
        ReaderManagement.cb_setTimeZone_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(ReaderManagement.n_SetTimeZone_S));
      return ReaderManagement.cb_setTimeZone_S;
    }

    private static void n_SetTimeZone_S(IntPtr jnienv, IntPtr native__this, short timeZoneIndex)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetTimeZone(timeZoneIndex);
    }

    [Register("setTimeZone", "(S)V", "GetSetTimeZone_SHandler")]
    public virtual unsafe void SetTimeZone(short timeZoneIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(timeZoneIndex)
      };
      ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setTimeZone.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_Handler()
    {
      if ((object) ReaderManagement.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_ == null)
        ReaderManagement.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_));
      return ReaderManagement.cb_setTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_;
    }

    private static void n_SetTraceLevel_Lcom_zebra_rfid_api3_TRACE_LEVEL_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_traceLevel)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetTraceLevel(Object.GetObject<TRACE_LEVEL>(native_traceLevel, (JniHandleOwnership) 0));
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
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setTraceLevel.(Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) traceLevel);
      }
    }

    private static Delegate GetSetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_Handler()
    {
      if ((object) ReaderManagement.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_ == null)
        ReaderManagement.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_));
      return ReaderManagement.cb_setTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_;
    }

    private static void n_SetTraceLevel_arrayLcom_zebra_rfid_api3_TRACE_LEVEL_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_arrTraceLevel)
    {
      ReaderManagement readerManagement = Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0);
      TRACE_LEVEL[] array = (TRACE_LEVEL[]) JNIEnv.GetArray(native_arrTraceLevel, (JniHandleOwnership) 0, typeof (TRACE_LEVEL));
      TRACE_LEVEL[] arrTraceLevel = array;
      readerManagement.SetTraceLevel(arrTraceLevel);
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
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setTraceLevel.([Lcom/zebra/rfid/api3/TRACE_LEVEL;)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetUserLED_Lcom_zebra_rfid_api3_LedInfo_Handler()
    {
      if ((object) ReaderManagement.cb_setUserLED_Lcom_zebra_rfid_api3_LedInfo_ == null)
        ReaderManagement.cb_setUserLED_Lcom_zebra_rfid_api3_LedInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderManagement.n_SetUserLED_Lcom_zebra_rfid_api3_LedInfo_));
      return ReaderManagement.cb_setUserLED_Lcom_zebra_rfid_api3_LedInfo_;
    }

    private static void n_SetUserLED_Lcom_zebra_rfid_api3_LedInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_ledInfo)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).SetUserLED(Object.GetObject<LedInfo>(native_ledInfo, (JniHandleOwnership) 0));
    }

    [Register("setUserLED", "(Lcom/zebra/rfid/api3/LedInfo;)V", "GetSetUserLED_Lcom_zebra_rfid_api3_LedInfo_Handler")]
    public virtual unsafe void SetUserLED(LedInfo? ledInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(ledInfo == null ? IntPtr.Zero : ledInfo.Handle)
        };
        ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("setUserLED.(Lcom/zebra/rfid/api3/LedInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) ledInfo);
      }
    }

    private static Delegate GetTurnOffRadiowhenIdle_IHandler()
    {
      if ((object) ReaderManagement.cb_turnOffRadiowhenIdle_I == null)
        ReaderManagement.cb_turnOffRadiowhenIdle_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReaderManagement.n_TurnOffRadiowhenIdle_I));
      return ReaderManagement.cb_turnOffRadiowhenIdle_I;
    }

    private static void n_TurnOffRadiowhenIdle_I(
      IntPtr jnienv,
      IntPtr native__this,
      int idleTimeout)
    {
      Object.GetObject<ReaderManagement>(jnienv, native__this, (JniHandleOwnership) 0).TurnOffRadiowhenIdle(idleTimeout);
    }

    [Register("turnOffRadiowhenIdle", "(I)V", "GetTurnOffRadiowhenIdle_IHandler")]
    public virtual unsafe void TurnOffRadiowhenIdle(int idleTimeout)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(idleTimeout)
      };
      ReaderManagement._members.InstanceMethods.InvokeVirtualVoidMethod("turnOffRadiowhenIdle.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
