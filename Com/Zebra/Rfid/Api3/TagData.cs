// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagData
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
  [Register("com/zebra/rfid/api3/TagData", DoNotGenerateAcw = true)]
  public class TagData : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagData", typeof (TagData));
    private static Delegate? cb_getAccessOperationStatus;
    private static Delegate? cb_setAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_;
    private static Delegate? cb_getAntennaID;
    private static Delegate? cb_setAntennaID_S;
    private static Delegate? cb_getBrandIDStatus;
    private static Delegate? cb_getCRC;
    private static Delegate? cb_setCRC_I;
    private static Delegate? cb_getChannel;
    private static Delegate? cb_getChannelIndex;
    private static Delegate? cb_setChannelIndex_S;
    private static Delegate? cb_getG2v2OpCode;
    private static Delegate? cb_getG2v2OpStatus;
    private static Delegate? cb_getG2v2Response;
    private static Delegate? cb_isContainsLocationInfo;
    private static Delegate? cb_isContainsMultiTagLocateInfo;
    private static Delegate? cb_getM_PhaseInfo;
    private static Delegate? cb_setM_PhaseInfo_S;
    private static Delegate? cb_getM_brandValid;
    private static Delegate? cb_setM_brandValid_S;
    private static Delegate? cb_getM_nMemoryBankDataOffset;
    private static Delegate? cb_setM_nMemoryBankDataOffset_I;
    private static Delegate? cb_getMemoryBank;
    private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    private static Delegate? cb_getMemoryBankData;
    private static Delegate? cb_getMemoryBankDataAllocatedSize;
    private static Delegate? cb_getMemoryBankDataOffset;
    private static Delegate? cb_getNumberOfWords;
    private static Delegate? cb_getOpCode;
    private static Delegate? cb_setOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_;
    private static Delegate? cb_getOpStatus;
    private static Delegate? cb_getPC;
    private static Delegate? cb_setPC_I;
    private static Delegate? cb_getPeakRSSI;
    private static Delegate? cb_setPeakRSSI_S;
    private static Delegate? cb_getPermaLockData;
    private static Delegate? cb_getPhase;
    private static Delegate? cb_getStringCRC;
    private static Delegate? cb_getTID;
    private static Delegate? cb_getTagControlData;
    private static Delegate? cb_setTagControlData_S;
    private static Delegate? cb_getTagEvent;
    private static Delegate? cb_getTagEventTimeStamp;
    private static Delegate? cb_setTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    private static Delegate? cb_getTagID;
    private static Delegate? cb_setTagID_Ljava_lang_String_;
    private static Delegate? cb_getTagIDAllocatedSize;
    private static Delegate? cb_getTagSeenCount;
    private static Delegate? cb_setTagSeenCount_I;
    private static Delegate? cb_getUser;
    private static Delegate? cb_getXPCW1;
    private static Delegate? cb_setXPCW1_S;
    private static Delegate? cb_getXPC_W1;
    private static Delegate? cb_getXPC_W2;
    private static Delegate? cb_setChannelFreq_Ljava_lang_String_;
    private static Delegate? cb_setMemoryBankData_Ljava_lang_String_;
    private static Delegate? cb_setUISeenTime_Lcom_zebra_rfid_api3_SeenTime_;

    [Register("AccessOperationResult")]
    public AccessOperationResult? AccessOperationResult
    {
      get
      {
        JniObjectReference objectValue = TagData._members.InstanceFields.GetObjectValue("AccessOperationResult.Lcom/zebra/rfid/api3/AccessOperationResult;", (IJavaPeerable) this);
        return Object.GetObject<AccessOperationResult>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TagData._members.InstanceFields.SetValue("AccessOperationResult.Lcom/zebra/rfid/api3/AccessOperationResult;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("AccessOptErrorCode")]
    public int AccessOptErrorCode
    {
      get
      {
        return TagData._members.InstanceFields.GetInt32Value("AccessOptErrorCode.I", (IJavaPeerable) this);
      }
      set
      {
        TagData._members.InstanceFields.SetValue("AccessOptErrorCode.I", (IJavaPeerable) this, value);
      }
    }

    [Register("LocationInfo")]
    public LocationInfo? LocationInfo
    {
      get
      {
        JniObjectReference objectValue = TagData._members.InstanceFields.GetObjectValue("LocationInfo.Lcom/zebra/rfid/api3/LocationInfo;", (IJavaPeerable) this);
        return Object.GetObject<LocationInfo>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TagData._members.InstanceFields.SetValue("LocationInfo.Lcom/zebra/rfid/api3/LocationInfo;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("MultiTagLocateInfo")]
    public MultiTagLocateInfo? MultiTagLocateInfo
    {
      get
      {
        JniObjectReference objectValue = TagData._members.InstanceFields.GetObjectValue("MultiTagLocateInfo.Lcom/zebra/rfid/api3/MultiTagLocateInfo;", (IJavaPeerable) this);
        return Object.GetObject<MultiTagLocateInfo>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TagData._members.InstanceFields.SetValue("MultiTagLocateInfo.Lcom/zebra/rfid/api3/MultiTagLocateInfo;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("SeenTime")]
    public SeenTime? SeenTime
    {
      get
      {
        JniObjectReference objectValue = TagData._members.InstanceFields.GetObjectValue("SeenTime.Lcom/zebra/rfid/api3/SeenTime;", (IJavaPeerable) this);
        return Object.GetObject<SeenTime>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TagData._members.InstanceFields.SetValue("SeenTime.Lcom/zebra/rfid/api3/SeenTime;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = TagData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagData._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagData._members.ManagedPeerType;

    protected TagData(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TagData()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TagData._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagData._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccessOperationStatusHandler()
    {
      if ((object) TagData.cb_getAccessOperationStatus == null)
        TagData.cb_getAccessOperationStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetAccessOperationStatus));
      return TagData.cb_getAccessOperationStatus;
    }

    private static IntPtr n_GetAccessOperationStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).AccessOperationStatus);
    }

    private static Delegate GetSetAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_Handler()
    {
      if ((object) TagData.cb_setAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_ == null)
        TagData.cb_setAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_));
      return TagData.cb_setAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_;
    }

    private static void n_SetAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_access_operation_status)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).AccessOperationStatus = Object.GetObject<ACCESS_OPERATION_STATUS>(native_access_operation_status, (JniHandleOwnership) 0);
    }

    public virtual unsafe ACCESS_OPERATION_STATUS? AccessOperationStatus
    {
      [Register("getAccessOperationStatus", "()Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", "GetGetAccessOperationStatusHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getAccessOperationStatus.()Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ACCESS_OPERATION_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAccessOperationStatus", "(Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;)V", "GetSetAccessOperationStatus_Lcom_zebra_rfid_api3_ACCESS_OPERATION_STATUS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessOperationStatus.(Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetAntennaIDHandler()
    {
      if ((object) TagData.cb_getAntennaID == null)
        TagData.cb_getAntennaID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetAntennaID));
      return TagData.cb_getAntennaID;
    }

    private static short n_GetAntennaID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID;
    }

    private static Delegate GetSetAntennaID_SHandler()
    {
      if ((object) TagData.cb_setAntennaID_S == null)
        TagData.cb_setAntennaID_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetAntennaID_S));
      return TagData.cb_setAntennaID_S;
    }

    private static void n_SetAntennaID_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID = value;
    }

    public virtual unsafe short AntennaID
    {
      [Register("getAntennaID", "()S", "GetGetAntennaIDHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getAntennaID.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAntennaID", "(S)V", "GetSetAntennaID_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaID.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetBrandIDStatusHandler()
    {
      if ((object) TagData.cb_getBrandIDStatus == null)
        TagData.cb_getBrandIDStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetBrandIDStatus));
      return TagData.cb_getBrandIDStatus;
    }

    private static IntPtr n_GetBrandIDStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).BrandIDStatus);
    }

    public virtual unsafe Boolean? BrandIDStatus
    {
      [Register("getBrandIDStatus", "()Ljava/lang/Boolean;", "GetGetBrandIDStatusHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getBrandIDStatus.()Ljava/lang/Boolean;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Boolean>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCRCHandler()
    {
      if ((object) TagData.cb_getCRC == null)
        TagData.cb_getCRC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetCRC));
      return TagData.cb_getCRC;
    }

    private static int n_GetCRC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).CRC;
    }

    private static Delegate GetSetCRC_IHandler()
    {
      if ((object) TagData.cb_setCRC_I == null)
        TagData.cb_setCRC_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagData.n_SetCRC_I));
      return TagData.cb_setCRC_I;
    }

    private static void n_SetCRC_I(IntPtr jnienv, IntPtr native__this, int CRC)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).CRC = CRC;
    }

    public virtual unsafe int CRC
    {
      [Register("getCRC", "()I", "GetGetCRCHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getCRC.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCRC", "(I)V", "GetSetCRC_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setCRC.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetChannelHandler()
    {
      if ((object) TagData.cb_getChannel == null)
        TagData.cb_getChannel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetChannel));
      return TagData.cb_getChannel;
    }

    private static IntPtr n_GetChannel(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).Channel);
    }

    public virtual unsafe string? Channel
    {
      [Register("getChannel", "()Ljava/lang/String;", "GetGetChannelHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getChannel.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetChannelIndexHandler()
    {
      if ((object) TagData.cb_getChannelIndex == null)
        TagData.cb_getChannelIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetChannelIndex));
      return TagData.cb_getChannelIndex;
    }

    private static short n_GetChannelIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).ChannelIndex;
    }

    private static Delegate GetSetChannelIndex_SHandler()
    {
      if ((object) TagData.cb_setChannelIndex_S == null)
        TagData.cb_setChannelIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetChannelIndex_S));
      return TagData.cb_setChannelIndex_S;
    }

    private static void n_SetChannelIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).ChannelIndex = value;
    }

    public virtual unsafe short ChannelIndex
    {
      [Register("getChannelIndex", "()S", "GetGetChannelIndexHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getChannelIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setChannelIndex", "(S)V", "GetSetChannelIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setChannelIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetG2v2OpCodeHandler()
    {
      if ((object) TagData.cb_getG2v2OpCode == null)
        TagData.cb_getG2v2OpCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetG2v2OpCode));
      return TagData.cb_getG2v2OpCode;
    }

    private static IntPtr n_GetG2v2OpCode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).G2v2OpCode);
    }

    public virtual unsafe GEN2V2_OPERATION_CODE? G2v2OpCode
    {
      [Register("getG2v2OpCode", "()Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", "GetGetG2v2OpCodeHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getG2v2OpCode.()Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetG2v2OpStatusHandler()
    {
      if ((object) TagData.cb_getG2v2OpStatus == null)
        TagData.cb_getG2v2OpStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetG2v2OpStatus));
      return TagData.cb_getG2v2OpStatus;
    }

    private static IntPtr n_GetG2v2OpStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).G2v2OpStatus);
    }

    public virtual unsafe GEN2V2_OPERATION_STATUS? G2v2OpStatus
    {
      [Register("getG2v2OpStatus", "()Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;", "GetGetG2v2OpStatusHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getG2v2OpStatus.()Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetG2v2ResponseHandler()
    {
      if ((object) TagData.cb_getG2v2Response == null)
        TagData.cb_getG2v2Response = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetG2v2Response));
      return TagData.cb_getG2v2Response;
    }

    private static IntPtr n_GetG2v2Response(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).G2v2Response);
    }

    public virtual unsafe string? G2v2Response
    {
      [Register("getG2v2Response", "()Ljava/lang/String;", "GetGetG2v2ResponseHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getG2v2Response.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsContainsLocationInfoHandler()
    {
      if ((object) TagData.cb_isContainsLocationInfo == null)
        TagData.cb_isContainsLocationInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TagData.n_IsContainsLocationInfo));
      return TagData.cb_isContainsLocationInfo;
    }

    private static bool n_IsContainsLocationInfo(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).IsContainsLocationInfo;
    }

    public virtual unsafe bool IsContainsLocationInfo
    {
      [Register("isContainsLocationInfo", "()Z", "GetIsContainsLocationInfoHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualBooleanMethod("isContainsLocationInfo.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsContainsMultiTagLocateInfoHandler()
    {
      if ((object) TagData.cb_isContainsMultiTagLocateInfo == null)
        TagData.cb_isContainsMultiTagLocateInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TagData.n_IsContainsMultiTagLocateInfo));
      return TagData.cb_isContainsMultiTagLocateInfo;
    }

    private static bool n_IsContainsMultiTagLocateInfo(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).IsContainsMultiTagLocateInfo;
    }

    public virtual unsafe bool IsContainsMultiTagLocateInfo
    {
      [Register("isContainsMultiTagLocateInfo", "()Z", "GetIsContainsMultiTagLocateInfoHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualBooleanMethod("isContainsMultiTagLocateInfo.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetM_PhaseInfoHandler()
    {
      if ((object) TagData.cb_getM_PhaseInfo == null)
        TagData.cb_getM_PhaseInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetM_PhaseInfo));
      return TagData.cb_getM_PhaseInfo;
    }

    private static short n_GetM_PhaseInfo(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_PhaseInfo;
    }

    private static Delegate GetSetM_PhaseInfo_SHandler()
    {
      if ((object) TagData.cb_setM_PhaseInfo_S == null)
        TagData.cb_setM_PhaseInfo_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetM_PhaseInfo_S));
      return TagData.cb_setM_PhaseInfo_S;
    }

    private static void n_SetM_PhaseInfo_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_PhaseInfo = value;
    }

    public virtual unsafe short M_PhaseInfo
    {
      [Register("getM_PhaseInfo", "()S", "GetGetM_PhaseInfoHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getM_PhaseInfo.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setM_PhaseInfo", "(S)V", "GetSetM_PhaseInfo_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setM_PhaseInfo.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetM_brandValidHandler()
    {
      if ((object) TagData.cb_getM_brandValid == null)
        TagData.cb_getM_brandValid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetM_brandValid));
      return TagData.cb_getM_brandValid;
    }

    private static short n_GetM_brandValid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_brandValid;
    }

    private static Delegate GetSetM_brandValid_SHandler()
    {
      if ((object) TagData.cb_setM_brandValid_S == null)
        TagData.cb_setM_brandValid_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetM_brandValid_S));
      return TagData.cb_setM_brandValid_S;
    }

    private static void n_SetM_brandValid_S(IntPtr jnienv, IntPtr native__this, short m_brandValid)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_brandValid = m_brandValid;
    }

    public virtual unsafe short M_brandValid
    {
      [Register("getM_brandValid", "()S", "GetGetM_brandValidHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getM_brandValid.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setM_brandValid", "(S)V", "GetSetM_brandValid_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setM_brandValid.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetM_nMemoryBankDataOffsetHandler()
    {
      if ((object) TagData.cb_getM_nMemoryBankDataOffset == null)
        TagData.cb_getM_nMemoryBankDataOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetM_nMemoryBankDataOffset));
      return TagData.cb_getM_nMemoryBankDataOffset;
    }

    private static int n_GetM_nMemoryBankDataOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_nMemoryBankDataOffset;
    }

    private static Delegate GetSetM_nMemoryBankDataOffset_IHandler()
    {
      if ((object) TagData.cb_setM_nMemoryBankDataOffset_I == null)
        TagData.cb_setM_nMemoryBankDataOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagData.n_SetM_nMemoryBankDataOffset_I));
      return TagData.cb_setM_nMemoryBankDataOffset_I;
    }

    private static void n_SetM_nMemoryBankDataOffset_I(
      IntPtr jnienv,
      IntPtr native__this,
      int m_nMemoryBankDataOffset)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).M_nMemoryBankDataOffset = m_nMemoryBankDataOffset;
    }

    public virtual unsafe int M_nMemoryBankDataOffset
    {
      [Register("getM_nMemoryBankDataOffset", "()I", "GetGetM_nMemoryBankDataOffsetHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getM_nMemoryBankDataOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setM_nMemoryBankDataOffset", "(I)V", "GetSetM_nMemoryBankDataOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setM_nMemoryBankDataOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMemoryBankHandler()
    {
      if ((object) TagData.cb_getMemoryBank == null)
        TagData.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetMemoryBank));
      return TagData.cb_getMemoryBank;
    }

    private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
    }

    private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
    {
      if ((object) TagData.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
        TagData.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
      return TagData.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    }

    private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_eMemoryBank)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_m_eMemoryBank, (JniHandleOwnership) 0);
    }

    public virtual unsafe MEMORY_BANK? MemoryBank
    {
      [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMemoryBank", "(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", "GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetMemoryBankDataHandler()
    {
      if ((object) TagData.cb_getMemoryBankData == null)
        TagData.cb_getMemoryBankData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetMemoryBankData));
      return TagData.cb_getMemoryBankData;
    }

    private static IntPtr n_GetMemoryBankData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBankData);
    }

    public virtual unsafe string? MemoryBankData
    {
      [Register("getMemoryBankData", "()Ljava/lang/String;", "GetGetMemoryBankDataHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBankData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetMemoryBankDataAllocatedSizeHandler()
    {
      if ((object) TagData.cb_getMemoryBankDataAllocatedSize == null)
        TagData.cb_getMemoryBankDataAllocatedSize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetMemoryBankDataAllocatedSize));
      return TagData.cb_getMemoryBankDataAllocatedSize;
    }

    private static int n_GetMemoryBankDataAllocatedSize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBankDataAllocatedSize;
    }

    public virtual unsafe int MemoryBankDataAllocatedSize
    {
      [Register("getMemoryBankDataAllocatedSize", "()I", "GetGetMemoryBankDataAllocatedSizeHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getMemoryBankDataAllocatedSize.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMemoryBankDataOffsetHandler()
    {
      if ((object) TagData.cb_getMemoryBankDataOffset == null)
        TagData.cb_getMemoryBankDataOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetMemoryBankDataOffset));
      return TagData.cb_getMemoryBankDataOffset;
    }

    private static int n_GetMemoryBankDataOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBankDataOffset;
    }

    public virtual unsafe int MemoryBankDataOffset
    {
      [Register("getMemoryBankDataOffset", "()I", "GetGetMemoryBankDataOffsetHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getMemoryBankDataOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetNumberOfWordsHandler()
    {
      if ((object) TagData.cb_getNumberOfWords == null)
        TagData.cb_getNumberOfWords = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetNumberOfWords));
      return TagData.cb_getNumberOfWords;
    }

    private static int n_GetNumberOfWords(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).NumberOfWords;
    }

    public virtual unsafe int NumberOfWords
    {
      [Register("getNumberOfWords", "()I", "GetGetNumberOfWordsHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getNumberOfWords.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetOpCodeHandler()
    {
      if ((object) TagData.cb_getOpCode == null)
        TagData.cb_getOpCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetOpCode));
      return TagData.cb_getOpCode;
    }

    private static IntPtr n_GetOpCode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).OpCode);
    }

    private static Delegate GetSetOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_Handler()
    {
      if ((object) TagData.cb_setOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_ == null)
        TagData.cb_setOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_));
      return TagData.cb_setOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_;
    }

    private static void n_SetOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_eOpCode)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).OpCode = Object.GetObject<ACCESS_OPERATION_CODE>(native_m_eOpCode, (JniHandleOwnership) 0);
    }

    public virtual unsafe ACCESS_OPERATION_CODE? OpCode
    {
      [Register("getOpCode", "()Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", "GetGetOpCodeHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getOpCode.()Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setOpCode", "(Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;)V", "GetSetOpCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setOpCode.(Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetOpStatusHandler()
    {
      if ((object) TagData.cb_getOpStatus == null)
        TagData.cb_getOpStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetOpStatus));
      return TagData.cb_getOpStatus;
    }

    private static IntPtr n_GetOpStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).OpStatus);
    }

    public virtual unsafe ACCESS_OPERATION_STATUS? OpStatus
    {
      [Register("getOpStatus", "()Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", "GetGetOpStatusHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getOpStatus.()Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ACCESS_OPERATION_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPCHandler()
    {
      if ((object) TagData.cb_getPC == null)
        TagData.cb_getPC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetPC));
      return TagData.cb_getPC;
    }

    private static int n_GetPC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).PC;
    }

    private static Delegate GetSetPC_IHandler()
    {
      if ((object) TagData.cb_setPC_I == null)
        TagData.cb_setPC_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagData.n_SetPC_I));
      return TagData.cb_setPC_I;
    }

    private static void n_SetPC_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).PC = value;
    }

    public virtual unsafe int PC
    {
      [Register("getPC", "()I", "GetGetPCHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getPC.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPC", "(I)V", "GetSetPC_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setPC.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPeakRSSIHandler()
    {
      if ((object) TagData.cb_getPeakRSSI == null)
        TagData.cb_getPeakRSSI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetPeakRSSI));
      return TagData.cb_getPeakRSSI;
    }

    private static short n_GetPeakRSSI(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).PeakRSSI;
    }

    private static Delegate GetSetPeakRSSI_SHandler()
    {
      if ((object) TagData.cb_setPeakRSSI_S == null)
        TagData.cb_setPeakRSSI_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetPeakRSSI_S));
      return TagData.cb_setPeakRSSI_S;
    }

    private static void n_SetPeakRSSI_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).PeakRSSI = value;
    }

    public virtual unsafe short PeakRSSI
    {
      [Register("getPeakRSSI", "()S", "GetGetPeakRSSIHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getPeakRSSI.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPeakRSSI", "(S)V", "GetSetPeakRSSI_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setPeakRSSI.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPermaLockDataHandler()
    {
      if ((object) TagData.cb_getPermaLockData == null)
        TagData.cb_getPermaLockData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetPermaLockData));
      return TagData.cb_getPermaLockData;
    }

    private static IntPtr n_GetPermaLockData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).PermaLockData);
    }

    public virtual unsafe string? PermaLockData
    {
      [Register("getPermaLockData", "()Ljava/lang/String;", "GetGetPermaLockDataHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getPermaLockData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPhaseHandler()
    {
      if ((object) TagData.cb_getPhase == null)
        TagData.cb_getPhase = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetPhase));
      return TagData.cb_getPhase;
    }

    private static short n_GetPhase(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).Phase;
    }

    public virtual unsafe short Phase
    {
      [Register("getPhase", "()S", "GetGetPhaseHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getPhase.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetStringCRCHandler()
    {
      if ((object) TagData.cb_getStringCRC == null)
        TagData.cb_getStringCRC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetStringCRC));
      return TagData.cb_getStringCRC;
    }

    private static IntPtr n_GetStringCRC(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).StringCRC);
    }

    public virtual unsafe string? StringCRC
    {
      [Register("getStringCRC", "()Ljava/lang/String;", "GetGetStringCRCHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getStringCRC.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTIDHandler()
    {
      if ((object) TagData.cb_getTID == null)
        TagData.cb_getTID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetTID));
      return TagData.cb_getTID;
    }

    private static IntPtr n_GetTID(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TID);
    }

    public virtual unsafe string? TID
    {
      [Register("getTID", "()Ljava/lang/String;", "GetGetTIDHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getTID.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTagControlDataHandler()
    {
      if ((object) TagData.cb_getTagControlData == null)
        TagData.cb_getTagControlData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetTagControlData));
      return TagData.cb_getTagControlData;
    }

    private static short n_GetTagControlData(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagControlData;
    }

    private static Delegate GetSetTagControlData_SHandler()
    {
      if ((object) TagData.cb_setTagControlData_S == null)
        TagData.cb_setTagControlData_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetTagControlData_S));
      return TagData.cb_setTagControlData_S;
    }

    private static void n_SetTagControlData_S(IntPtr jnienv, IntPtr native__this, short data)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagControlData = data;
    }

    public virtual unsafe short TagControlData
    {
      [Register("getTagControlData", "()S", "GetGetTagControlDataHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getTagControlData.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagControlData", "(S)V", "GetSetTagControlData_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setTagControlData.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTagEventHandler()
    {
      if ((object) TagData.cb_getTagEvent == null)
        TagData.cb_getTagEvent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetTagEvent));
      return TagData.cb_getTagEvent;
    }

    private static IntPtr n_GetTagEvent(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagEvent);
    }

    public virtual unsafe Object? TagEvent
    {
      [Register("getTagEvent", "()Ljava/lang/Object;", "GetGetTagEventHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getTagEvent.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTagEventTimeStampHandler()
    {
      if ((object) TagData.cb_getTagEventTimeStamp == null)
        TagData.cb_getTagEventTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetTagEventTimeStamp));
      return TagData.cb_getTagEventTimeStamp;
    }

    private static IntPtr n_GetTagEventTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagEventTimeStamp);
    }

    private static Delegate GetSetTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler()
    {
      if ((object) TagData.cb_setTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ == null)
        TagData.cb_setTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_));
      return TagData.cb_setTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    }

    private static void n_SetTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagEventTimeStamp = Object.GetObject<SYSTEMTIME>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe SYSTEMTIME? TagEventTimeStamp
    {
      [Register("getTagEventTimeStamp", "()Lcom/zebra/rfid/api3/SYSTEMTIME;", "GetGetTagEventTimeStampHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getTagEventTimeStamp.()Lcom/zebra/rfid/api3/SYSTEMTIME;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SYSTEMTIME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTagEventTimeStamp", "(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", "GetSetTagEventTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setTagEventTimeStamp.(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetTagIDHandler()
    {
      if ((object) TagData.cb_getTagID == null)
        TagData.cb_getTagID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetTagID));
      return TagData.cb_getTagID;
    }

    private static IntPtr n_GetTagID(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagID);
    }

    private static Delegate GetSetTagID_Ljava_lang_String_Handler()
    {
      if ((object) TagData.cb_setTagID_Ljava_lang_String_ == null)
        TagData.cb_setTagID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetTagID_Ljava_lang_String_));
      return TagData.cb_setTagID_Ljava_lang_String_;
    }

    private static void n_SetTagID_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagID = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? TagID
    {
      [Register("getTagID", "()Ljava/lang/String;", "GetGetTagIDHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getTagID.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTagID", "(Ljava/lang/String;)V", "GetSetTagID_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setTagID.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetTagIDAllocatedSizeHandler()
    {
      if ((object) TagData.cb_getTagIDAllocatedSize == null)
        TagData.cb_getTagIDAllocatedSize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetTagIDAllocatedSize));
      return TagData.cb_getTagIDAllocatedSize;
    }

    private static int n_GetTagIDAllocatedSize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagIDAllocatedSize;
    }

    public virtual unsafe int TagIDAllocatedSize
    {
      [Register("getTagIDAllocatedSize", "()I", "GetGetTagIDAllocatedSizeHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getTagIDAllocatedSize.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTagSeenCountHandler()
    {
      if ((object) TagData.cb_getTagSeenCount == null)
        TagData.cb_getTagSeenCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetTagSeenCount));
      return TagData.cb_getTagSeenCount;
    }

    private static int n_GetTagSeenCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagSeenCount;
    }

    private static Delegate GetSetTagSeenCount_IHandler()
    {
      if ((object) TagData.cb_setTagSeenCount_I == null)
        TagData.cb_setTagSeenCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagData.n_SetTagSeenCount_I));
      return TagData.cb_setTagSeenCount_I;
    }

    private static void n_SetTagSeenCount_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).TagSeenCount = value;
    }

    public virtual unsafe int TagSeenCount
    {
      [Register("getTagSeenCount", "()I", "GetGetTagSeenCountHandler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getTagSeenCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagSeenCount", "(I)V", "GetSetTagSeenCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setTagSeenCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetUserHandler()
    {
      if ((object) TagData.cb_getUser == null)
        TagData.cb_getUser = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagData.n_GetUser));
      return TagData.cb_getUser;
    }

    private static IntPtr n_GetUser(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).User);
    }

    public virtual unsafe string? User
    {
      [Register("getUser", "()Ljava/lang/String;", "GetGetUserHandler")] get
      {
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("getUser.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetXPCW1Handler()
    {
      if ((object) TagData.cb_getXPCW1 == null)
        TagData.cb_getXPCW1 = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TagData.n_GetXPCW1));
      return TagData.cb_getXPCW1;
    }

    private static short n_GetXPCW1(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).XPCW1;
    }

    private static Delegate GetSetXPCW1_SHandler()
    {
      if ((object) TagData.cb_setXPCW1_S == null)
        TagData.cb_setXPCW1_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TagData.n_SetXPCW1_S));
      return TagData.cb_setXPCW1_S;
    }

    private static void n_SetXPCW1_S(IntPtr jnienv, IntPtr native__this, short m_XPC)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).XPCW1 = m_XPC;
    }

    public virtual unsafe short XPCW1
    {
      [Register("getXPCW1", "()S", "GetGetXPCW1Handler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt16Method("getXPCW1.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setXPCW1", "(S)V", "GetSetXPCW1_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setXPCW1.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetXPC_W1Handler()
    {
      if ((object) TagData.cb_getXPC_W1 == null)
        TagData.cb_getXPC_W1 = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetXPC_W1));
      return TagData.cb_getXPC_W1;
    }

    private static int n_GetXPC_W1(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).XPC_W1;
    }

    public virtual unsafe int XPC_W1
    {
      [Register("getXPC_W1", "()I", "GetGetXPC_W1Handler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getXPC_W1.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetXPC_W2Handler()
    {
      if ((object) TagData.cb_getXPC_W2 == null)
        TagData.cb_getXPC_W2 = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagData.n_GetXPC_W2));
      return TagData.cb_getXPC_W2;
    }

    private static int n_GetXPC_W2(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).XPC_W2;
    }

    public virtual unsafe int XPC_W2
    {
      [Register("getXPC_W2", "()I", "GetGetXPC_W2Handler")] get
      {
        return TagData._members.InstanceMethods.InvokeVirtualInt32Method("getXPC_W2.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetSetChannelFreq_Ljava_lang_String_Handler()
    {
      if ((object) TagData.cb_setChannelFreq_Ljava_lang_String_ == null)
        TagData.cb_setChannelFreq_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetChannelFreq_Ljava_lang_String_));
      return TagData.cb_setChannelFreq_Ljava_lang_String_;
    }

    private static void n_SetChannelFreq_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_channelFreq)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).SetChannelFreq(JNIEnv.GetString(native_channelFreq, (JniHandleOwnership) 0));
    }

    [Register("setChannelFreq", "(Ljava/lang/String;)V", "GetSetChannelFreq_Ljava_lang_String_Handler")]
    public virtual unsafe void SetChannelFreq(string? channelFreq)
    {
      IntPtr num = JNIEnv.NewString(channelFreq);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setChannelFreq.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetMemoryBankData_Ljava_lang_String_Handler()
    {
      if ((object) TagData.cb_setMemoryBankData_Ljava_lang_String_ == null)
        TagData.cb_setMemoryBankData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(TagData.n_SetMemoryBankData_Ljava_lang_String_));
      return TagData.cb_setMemoryBankData_Ljava_lang_String_;
    }

    private static IntPtr n_SetMemoryBankData_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_MemoryBankData)
    {
      return JNIEnv.NewString(Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).SetMemoryBankData(JNIEnv.GetString(native_m_MemoryBankData, (JniHandleOwnership) 0)));
    }

    [Register("setMemoryBankData", "(Ljava/lang/String;)Ljava/lang/String;", "GetSetMemoryBankData_Ljava_lang_String_Handler")]
    public virtual unsafe string? SetMemoryBankData(string? m_MemoryBankData)
    {
      IntPtr num = JNIEnv.NewString(m_MemoryBankData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = TagData._members.InstanceMethods.InvokeVirtualObjectMethod("setMemoryBankData.(Ljava/lang/String;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetUISeenTime_Lcom_zebra_rfid_api3_SeenTime_Handler()
    {
      if ((object) TagData.cb_setUISeenTime_Lcom_zebra_rfid_api3_SeenTime_ == null)
        TagData.cb_setUISeenTime_Lcom_zebra_rfid_api3_SeenTime_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagData.n_SetUISeenTime_Lcom_zebra_rfid_api3_SeenTime_));
      return TagData.cb_setUISeenTime_Lcom_zebra_rfid_api3_SeenTime_;
    }

    private static void n_SetUISeenTime_Lcom_zebra_rfid_api3_SeenTime_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<TagData>(jnienv, native__this, (JniHandleOwnership) 0).SetUISeenTime(Object.GetObject<SeenTime>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setUISeenTime", "(Lcom/zebra/rfid/api3/SeenTime;)V", "GetSetUISeenTime_Lcom_zebra_rfid_api3_SeenTime_Handler")]
    public virtual unsafe void SetUISeenTime(SeenTime? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
        };
        TagData._members.InstanceMethods.InvokeVirtualVoidMethod("setUISeenTime.(Lcom/zebra/rfid/api3/SeenTime;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }
  }
}
