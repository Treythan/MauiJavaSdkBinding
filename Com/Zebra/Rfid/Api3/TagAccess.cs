// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagAccess
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
  [Register("com/zebra/rfid/api3/TagAccess", DoNotGenerateAcw = true)]
  public class TagAccess : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess", typeof (TagAccess));
    private static Delegate? cb_blockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    private static Delegate? cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z;
    private static Delegate? cb_blockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    private static Delegate? cb_blockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    private static Delegate? cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ;
    private static Delegate? cb_getLastAccessResult_arrayIarrayI;
    private static Delegate? cb_killEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    private static Delegate? cb_lockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    private static Delegate? cb_readEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    private static Delegate? cb_recommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_recommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_stopAccess;
    private static Delegate? cb_writeAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_writeEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_writeKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_writeTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    private static Delegate? cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ;

    [Register("OperationSequence")]
    public TagAccess.Sequence? OperationSequence
    {
      get
      {
        JniObjectReference objectValue = TagAccess._members.InstanceFields.GetObjectValue("OperationSequence.Lcom/zebra/rfid/api3/TagAccess$Sequence;", (IJavaPeerable) this);
        return Object.GetObject<TagAccess.Sequence>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TagAccess._members.InstanceFields.SetValue("OperationSequence.Lcom/zebra/rfid/api3/TagAccess$Sequence;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = TagAccess._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagAccess._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagAccess._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagAccess._members.ManagedPeerType;

    protected TagAccess(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TagAccess()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TagAccess._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagAccess._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("AssignMethods", "(Ljava/lang/String;)V", "")]
    protected static unsafe void AssignMethods(string? m_sProtocol)
    {
      IntPtr num = JNIEnv.NewString(m_sProtocol);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        TagAccess._members.StaticMethods.InvokeVoidMethod("AssignMethods.(Ljava/lang/String;)V", jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetBlockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_blockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_blockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_BlockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_blockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_BlockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_blockEraseAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.BlockEraseAccessParams eraseAccessParams = Object.GetObject<TagAccess.BlockEraseAccessParams>(native_blockEraseAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.BlockEraseAccessParams blockEraseAccessParams = eraseAccessParams;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.BlockEraseEvent(blockEraseAccessParams, accessFilter2, antennaInfo2);
    }

    [Register("blockEraseEvent", "(Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetBlockEraseEvent_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void BlockEraseEvent(
      TagAccess.BlockEraseAccessParams? blockEraseAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(blockEraseAccessParams == null ? IntPtr.Zero : blockEraseAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockEraseEvent.(Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) blockEraseAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetBlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler()
    {
      if ((object) TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ == null)
        TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLL_V(TagAccess.n_BlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_));
      return TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    }

    private static void n_BlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_blockEraseAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.BlockEraseAccessParams eraseAccessParams = Object.GetObject<TagAccess.BlockEraseAccessParams>(native_blockEraseAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.BlockEraseAccessParams blockEraseAccessParams = eraseAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      tagAccess.BlockEraseWait(tagID, blockEraseAccessParams, antennaInfo2, tagData2);
    }

    [Register("blockEraseWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", "GetBlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler")]
    public virtual unsafe void BlockEraseWait(
      string? tagID,
      TagAccess.BlockEraseAccessParams? blockEraseAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(blockEraseAccessParams == null ? IntPtr.Zero : blockEraseAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockEraseWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) blockEraseAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    private static Delegate GetBlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZHandler()
    {
      if ((object) TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z == null)
        TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLLZ_V(TagAccess.n_BlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z));
      return TagAccess.cb_blockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z;
    }

    private static void n_BlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_blockEraseAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData,
      bool bPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.BlockEraseAccessParams eraseAccessParams = Object.GetObject<TagAccess.BlockEraseAccessParams>(native_blockEraseAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.BlockEraseAccessParams blockEraseAccessParams = eraseAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      int num = bPrefilter ? 1 : 0;
      tagAccess.BlockEraseWait(tagID, blockEraseAccessParams, antennaInfo2, tagData2, num != 0);
    }

    [Register("blockEraseWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;Z)V", "GetBlockEraseWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockEraseAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZHandler")]
    public virtual unsafe void BlockEraseWait(
      string? tagID,
      TagAccess.BlockEraseAccessParams? blockEraseAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData,
      bool bPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(blockEraseAccessParams == null ? IntPtr.Zero : blockEraseAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle),
          new JniArgumentValue(bPrefilter)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockEraseWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) blockEraseAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    private static Delegate GetBlockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_blockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_blockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_BlockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_blockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_BlockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_blockPermalockAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.BlockPermalockAccessParams permalockAccessParams = Object.GetObject<TagAccess.BlockPermalockAccessParams>(native_blockPermalockAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.BlockPermalockAccessParams blockPermalockAccessParams = permalockAccessParams;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.BlockPermalockEvent(blockPermalockAccessParams, accessFilter2, antennaInfo2);
    }

    [Register("blockPermalockEvent", "(Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetBlockPermalockEvent_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void BlockPermalockEvent(
      TagAccess.BlockPermalockAccessParams? blockPermalockAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(blockPermalockAccessParams == null ? IntPtr.Zero : blockPermalockAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockPermalockEvent.(Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) blockPermalockAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetBlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(TagAccess.n_BlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static IntPtr n_BlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_blockPermalockAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.BlockPermalockAccessParams permalockAccessParams = Object.GetObject<TagAccess.BlockPermalockAccessParams>(native_blockPermalockAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.BlockPermalockAccessParams blockPermalockAccessParams = permalockAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      return JNIEnv.ToLocalJniHandle((IJavaObject) tagAccess.BlockPermalockWait(tagID, blockPermalockAccessParams, antennaInfo2));
    }

    [Register("blockPermalockWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)Lcom/zebra/rfid/api3/TagData;", "GetBlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe TagData? BlockPermalockWait(
      string? tagID,
      TagAccess.BlockPermalockAccessParams? blockPermalockAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(blockPermalockAccessParams == null ? IntPtr.Zero : blockPermalockAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        JniObjectReference jniObjectReference = TagAccess._members.InstanceMethods.InvokeVirtualObjectMethod("blockPermalockWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<TagData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) blockPermalockAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetBlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler()
    {
      if ((object) TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z == null)
        TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZ_L(TagAccess.n_BlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z));
      return TagAccess.cb_blockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    }

    private static IntPtr n_BlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_blockPermalockAccessParams,
      IntPtr native_antennaInfo,
      bool bPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.BlockPermalockAccessParams permalockAccessParams = Object.GetObject<TagAccess.BlockPermalockAccessParams>(native_blockPermalockAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.BlockPermalockAccessParams blockPermalockAccessParams = permalockAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      int num = bPrefilter ? 1 : 0;
      return JNIEnv.ToLocalJniHandle((IJavaObject) tagAccess.BlockPermalockWait(tagID, blockPermalockAccessParams, antennaInfo2, num != 0));
    }

    [Register("blockPermalockWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)Lcom/zebra/rfid/api3/TagData;", "GetBlockPermalockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_BlockPermalockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler")]
    public virtual unsafe TagData? BlockPermalockWait(
      string? tagID,
      TagAccess.BlockPermalockAccessParams? blockPermalockAccessParams,
      AntennaInfo? antennaInfo,
      bool bPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(blockPermalockAccessParams == null ? IntPtr.Zero : blockPermalockAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(bPrefilter)
        };
        JniObjectReference jniObjectReference = TagAccess._members.InstanceMethods.InvokeVirtualObjectMethod("blockPermalockWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<TagData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) blockPermalockAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetBlockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_blockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_blockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_BlockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_blockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_BlockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_writeAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.BlockWriteEvent(writeAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("blockWriteEvent", "(Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetBlockWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void BlockWriteEvent(
      TagAccess.WriteAccessParams? writeAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockWriteEvent.(Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetBlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler()
    {
      if ((object) TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ == null)
        TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLL_V(TagAccess.n_BlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_));
      return TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    }

    private static void n_BlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      tagAccess.BlockWriteWait(tagID, writeAccessParams2, antennaInfo2, tagData2);
    }

    [Register("blockWriteWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", "GetBlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler")]
    public virtual unsafe void BlockWriteWait(
      string? tagID,
      TagAccess.WriteAccessParams? writeAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockWriteWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    private static Delegate GetBlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZHandler()
    {
      if ((object) TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ == null)
        TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLLZZ_V(TagAccess.n_BlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ));
      return TagAccess.cb_blockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ;
    }

    private static void n_BlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData,
      bool bPrefilter,
      bool bTIDPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      int num1 = bPrefilter ? 1 : 0;
      int num2 = bTIDPrefilter ? 1 : 0;
      tagAccess.BlockWriteWait(tagID, writeAccessParams2, antennaInfo2, tagData2, num1 != 0, num2 != 0);
    }

    [Register("blockWriteWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;ZZ)V", "GetBlockWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZHandler")]
    public virtual unsafe void BlockWriteWait(
      string? tagID,
      TagAccess.WriteAccessParams? writeAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData,
      bool bPrefilter,
      bool bTIDPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[6]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle),
          new JniArgumentValue(bPrefilter),
          new JniArgumentValue(bTIDPrefilter)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("blockWriteWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;ZZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    private static Delegate GetGetLastAccessResult_arrayIarrayIHandler()
    {
      if ((object) TagAccess.cb_getLastAccessResult_arrayIarrayI == null)
        TagAccess.cb_getLastAccessResult_arrayIarrayI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(TagAccess.n_GetLastAccessResult_arrayIarrayI));
      return TagAccess.cb_getLastAccessResult_arrayIarrayI;
    }

    private static void n_GetLastAccessResult_arrayIarrayI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_successCount,
      IntPtr native_failureCount)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      int[] array1 = (int[]) JNIEnv.GetArray(native_successCount, (JniHandleOwnership) 0, typeof (int));
      int[] array2 = (int[]) JNIEnv.GetArray(native_failureCount, (JniHandleOwnership) 0, typeof (int));
      int[] successCount = array1;
      int[] failureCount = array2;
      tagAccess.GetLastAccessResult(successCount, failureCount);
      if (array1 != null)
        JNIEnv.CopyArray(array1, native_successCount);
      if (array2 == null)
        return;
      JNIEnv.CopyArray(array2, native_failureCount);
    }

    [Register("getLastAccessResult", "([I[I)V", "GetGetLastAccessResult_arrayIarrayIHandler")]
    public virtual unsafe void GetLastAccessResult(int[]? successCount, int[]? failureCount)
    {
      IntPtr num1 = JNIEnv.NewArray(successCount);
      IntPtr num2 = JNIEnv.NewArray(failureCount);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("getLastAccessResult.([I[I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (successCount != null)
        {
          JNIEnv.CopyArray(num1, successCount);
          JNIEnv.DeleteLocalRef(num1);
        }
        if (failureCount != null)
        {
          JNIEnv.CopyArray(num2, failureCount);
          JNIEnv.DeleteLocalRef(num2);
        }
        GC.KeepAlive((object) successCount);
        GC.KeepAlive((object) failureCount);
      }
    }

    private static Delegate GetKillEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_killEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_killEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_KillEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_killEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_KillEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_killAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.KillAccessParams killAccessParams1 = Object.GetObject<TagAccess.KillAccessParams>(native_killAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.KillAccessParams killAccessParams2 = killAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.KillEvent(killAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("killEvent", "(Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetKillEvent_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void KillEvent(
      TagAccess.KillAccessParams? killAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(killAccessParams == null ? IntPtr.Zero : killAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("killEvent.(Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) killAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetKillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_KillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_KillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_killAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.KillAccessParams killAccessParams1 = Object.GetObject<TagAccess.KillAccessParams>(native_killAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.KillAccessParams killAccessParams2 = killAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.KillWait(tagID, killAccessParams2, antennaInfo2);
    }

    [Register("killWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetKillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void KillWait(
      string? tagID,
      TagAccess.KillAccessParams? killAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(killAccessParams == null ? IntPtr.Zero : killAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("killWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) killAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetKillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler()
    {
      if ((object) TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z == null)
        TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZ_V(TagAccess.n_KillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z));
      return TagAccess.cb_killWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    }

    private static void n_KillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_killAccessParams,
      IntPtr native_antennaInfo,
      bool bPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.KillAccessParams killAccessParams1 = Object.GetObject<TagAccess.KillAccessParams>(native_killAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.KillAccessParams killAccessParams2 = killAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      int num = bPrefilter ? 1 : 0;
      tagAccess.KillWait(tagID, killAccessParams2, antennaInfo2, num != 0);
    }

    [Register("killWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)V", "GetKillWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_KillAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler")]
    public virtual unsafe void KillWait(
      string? tagID,
      TagAccess.KillAccessParams? killAccessParams,
      AntennaInfo? antennaInfo,
      bool bPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(killAccessParams == null ? IntPtr.Zero : killAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(bPrefilter)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("killWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) killAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetLockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_lockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_lockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_LockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_lockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_LockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_lockAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.LockAccessParams lockAccessParams1 = Object.GetObject<TagAccess.LockAccessParams>(native_lockAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.LockAccessParams lockAccessParams2 = lockAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.LockEvent(lockAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("lockEvent", "(Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetLockEvent_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void LockEvent(
      TagAccess.LockAccessParams? lockAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(lockAccessParams == null ? IntPtr.Zero : lockAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("lockEvent.(Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) lockAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetLockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_LockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_LockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_lockAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.LockAccessParams lockAccessParams1 = Object.GetObject<TagAccess.LockAccessParams>(native_lockAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.LockAccessParams lockAccessParams2 = lockAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.LockWait(tagID, lockAccessParams2, antennaInfo2);
    }

    [Register("lockWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetLockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void LockWait(
      string? tagID,
      TagAccess.LockAccessParams? lockAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(lockAccessParams == null ? IntPtr.Zero : lockAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("lockWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) lockAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetLockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler()
    {
      if ((object) TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z == null)
        TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZ_V(TagAccess.n_LockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z));
      return TagAccess.cb_lockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    }

    private static void n_LockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_lockAccessParams,
      IntPtr native_antennaInfo,
      bool bPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.LockAccessParams lockAccessParams1 = Object.GetObject<TagAccess.LockAccessParams>(native_lockAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.LockAccessParams lockAccessParams2 = lockAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      int num = bPrefilter ? 1 : 0;
      tagAccess.LockWait(tagID, lockAccessParams2, antennaInfo2, num != 0);
    }

    [Register("lockWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)V", "GetLockWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_LockAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler")]
    public virtual unsafe void LockWait(
      string? tagID,
      TagAccess.LockAccessParams? lockAccessParams,
      AntennaInfo? antennaInfo,
      bool bPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(lockAccessParams == null ? IntPtr.Zero : lockAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(bPrefilter)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("lockWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) lockAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetReadEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_readEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_readEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_ReadEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_readEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_ReadEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.ReadAccessParams readAccessParams1 = Object.GetObject<TagAccess.ReadAccessParams>(native_readAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.ReadAccessParams readAccessParams2 = readAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.ReadEvent(readAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("readEvent", "(Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetReadEvent_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void ReadEvent(
      TagAccess.ReadAccessParams? readAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(readAccessParams == null ? IntPtr.Zero : readAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("readEvent.(Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(TagAccess.n_ReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static IntPtr n_ReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_readAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.ReadAccessParams readAccessParams1 = Object.GetObject<TagAccess.ReadAccessParams>(native_readAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.ReadAccessParams readAccessParams2 = readAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      return JNIEnv.ToLocalJniHandle((IJavaObject) tagAccess.ReadWait(tagID, readAccessParams2, antennaInfo2));
    }

    [Register("readWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)Lcom/zebra/rfid/api3/TagData;", "GetReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe TagData? ReadWait(
      string? tagID,
      TagAccess.ReadAccessParams? readAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(readAccessParams == null ? IntPtr.Zero : readAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        JniObjectReference jniObjectReference = TagAccess._members.InstanceMethods.InvokeVirtualObjectMethod("readWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<TagData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) readAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler()
    {
      if ((object) TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z == null)
        TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZ_L(TagAccess.n_ReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z));
      return TagAccess.cb_readWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z;
    }

    private static IntPtr n_ReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_readAccessParams,
      IntPtr native_antennaInfo,
      bool bPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.ReadAccessParams readAccessParams1 = Object.GetObject<TagAccess.ReadAccessParams>(native_readAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.ReadAccessParams readAccessParams2 = readAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      int num = bPrefilter ? 1 : 0;
      return JNIEnv.ToLocalJniHandle((IJavaObject) tagAccess.ReadWait(tagID, readAccessParams2, antennaInfo2, num != 0));
    }

    [Register("readWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)Lcom/zebra/rfid/api3/TagData;", "GetReadWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_ReadAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ZHandler")]
    public virtual unsafe TagData? ReadWait(
      string? tagID,
      TagAccess.ReadAccessParams? readAccessParams,
      AntennaInfo? antennaInfo,
      bool bPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(readAccessParams == null ? IntPtr.Zero : readAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(bPrefilter)
        };
        JniObjectReference jniObjectReference = TagAccess._members.InstanceMethods.InvokeVirtualObjectMethod("readWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Z)Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<TagData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) readAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetRecommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_recommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_recommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_RecommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_recommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_RecommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_recommisionAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.RecommisionAccessParams recommisionAccessParams1 = Object.GetObject<TagAccess.RecommisionAccessParams>(native_recommisionAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.RecommisionAccessParams recommisionAccessParams2 = recommisionAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.RecommisionEvent(recommisionAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("recommisionEvent", "(Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetRecommisionEvent_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void RecommisionEvent(
      TagAccess.RecommisionAccessParams? recommisionAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(recommisionAccessParams == null ? IntPtr.Zero : recommisionAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("recommisionEvent.(Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) recommisionAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetRecommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_recommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_recommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_RecommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_recommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_RecommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_recommisionAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.RecommisionAccessParams recommisionAccessParams1 = Object.GetObject<TagAccess.RecommisionAccessParams>(native_recommisionAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.RecommisionAccessParams recommisionAccessParams2 = recommisionAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.RecommisionWait(tagID, recommisionAccessParams2, antennaInfo2);
    }

    [Register("recommisionWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetRecommisionWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_RecommisionAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void RecommisionWait(
      string? tagID,
      TagAccess.RecommisionAccessParams? recommisionAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(recommisionAccessParams == null ? IntPtr.Zero : recommisionAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("recommisionWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) recommisionAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetStopAccessHandler()
    {
      if ((object) TagAccess.cb_stopAccess == null)
        TagAccess.cb_stopAccess = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.n_StopAccess));
      return TagAccess.cb_stopAccess;
    }

    private static void n_StopAccess(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0).StopAccess();
    }

    [Register("stopAccess", "()V", "GetStopAccessHandler")]
    public virtual unsafe void StopAccess()
    {
      TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("stopAccess.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetWriteAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_writeAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_writeAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_WriteAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_writeAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_WriteAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeSpecificFieldAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteSpecificFieldAccessParams fieldAccessParams = Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(native_writeSpecificFieldAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteSpecificFieldAccessParams writeSpecificFieldAccessParams = fieldAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.WriteAccessPasswordWait(tagID, writeSpecificFieldAccessParams, antennaInfo2);
    }

    [Register("writeAccessPasswordWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetWriteAccessPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void WriteAccessPasswordWait(
      string? tagID,
      TagAccess.WriteSpecificFieldAccessParams? writeSpecificFieldAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeSpecificFieldAccessParams == null ? IntPtr.Zero : writeSpecificFieldAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeAccessPasswordWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeSpecificFieldAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_writeEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_writeEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_WriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_writeEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_WriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_writeAccessParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.WriteEvent(writeAccessParams2, accessFilter2, antennaInfo2);
    }

    [Register("writeEvent", "(Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetWriteEvent_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void WriteEvent(
      TagAccess.WriteAccessParams? writeAccessParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeEvent.(Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetWriteKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_writeKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_writeKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_WriteKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_writeKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_WriteKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeSpecificFieldAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteSpecificFieldAccessParams fieldAccessParams = Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(native_writeSpecificFieldAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteSpecificFieldAccessParams writeSpecificFieldAccessParams = fieldAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.WriteKillPasswordWait(tagID, writeSpecificFieldAccessParams, antennaInfo2);
    }

    [Register("writeKillPasswordWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetWriteKillPasswordWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void WriteKillPasswordWait(
      string? tagID,
      TagAccess.WriteSpecificFieldAccessParams? writeSpecificFieldAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeSpecificFieldAccessParams == null ? IntPtr.Zero : writeSpecificFieldAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeKillPasswordWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeSpecificFieldAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetWriteTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagAccess.cb_writeTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagAccess.cb_writeTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.n_WriteTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagAccess.cb_writeTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_WriteTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeSpecificFieldAccessParams,
      IntPtr native_antennaInfo)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteSpecificFieldAccessParams fieldAccessParams = Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(native_writeSpecificFieldAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteSpecificFieldAccessParams writeSpecificFieldAccessParams = fieldAccessParams;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagAccess.WriteTagIDWait(tagID, writeSpecificFieldAccessParams, antennaInfo2);
    }

    [Register("writeTagIDWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetWriteTagIDWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteSpecificFieldAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void WriteTagIDWait(
      string? tagID,
      TagAccess.WriteSpecificFieldAccessParams? writeSpecificFieldAccessParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeSpecificFieldAccessParams == null ? IntPtr.Zero : writeSpecificFieldAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeTagIDWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeSpecificFieldAccessParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler()
    {
      if ((object) TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ == null)
        TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLL_V(TagAccess.n_WriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_));
      return TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_;
    }

    private static void n_WriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      tagAccess.WriteWait(tagID, writeAccessParams2, antennaInfo2, tagData2);
    }

    [Register("writeWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", "GetWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_Handler")]
    public virtual unsafe void WriteWait(
      string? tagID,
      TagAccess.WriteAccessParams? writeAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    private static Delegate GetWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZHandler()
    {
      if ((object) TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ == null)
        TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLLZZ_V(TagAccess.n_WriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ));
      return TagAccess.cb_writeWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ;
    }

    private static void n_WriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZ(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_writeAccessParams,
      IntPtr native_antennaInfo,
      IntPtr native_tagData,
      bool bPrefilter,
      bool bTIDPrefilter)
    {
      TagAccess tagAccess = Object.GetObject<TagAccess>(jnienv, native__this, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      TagAccess.WriteAccessParams writeAccessParams1 = Object.GetObject<TagAccess.WriteAccessParams>(native_writeAccessParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagData tagData1 = Object.GetObject<TagData>(native_tagData, (JniHandleOwnership) 0);
      string tagID = str;
      TagAccess.WriteAccessParams writeAccessParams2 = writeAccessParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      TagData tagData2 = tagData1;
      int num1 = bPrefilter ? 1 : 0;
      int num2 = bTIDPrefilter ? 1 : 0;
      tagAccess.WriteWait(tagID, writeAccessParams2, antennaInfo2, tagData2, num1 != 0, num2 != 0);
    }

    [Register("writeWait", "(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;ZZ)V", "GetWriteWait_Ljava_lang_String_Lcom_zebra_rfid_api3_TagAccess_WriteAccessParams_Lcom_zebra_rfid_api3_AntennaInfo_Lcom_zebra_rfid_api3_TagData_ZZHandler")]
    public virtual unsafe void WriteWait(
      string? tagID,
      TagAccess.WriteAccessParams? writeAccessParams,
      AntennaInfo? antennaInfo,
      TagData? tagData,
      bool bPrefilter,
      bool bTIDPrefilter)
    {
      IntPtr num = JNIEnv.NewString(tagID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[6]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(writeAccessParams == null ? IntPtr.Zero : writeAccessParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle),
          new JniArgumentValue(tagData == null ? IntPtr.Zero : tagData.Handle),
          new JniArgumentValue(bPrefilter),
          new JniArgumentValue(bTIDPrefilter)
        };
        TagAccess._members.InstanceMethods.InvokeVirtualVoidMethod("writeWait.(Ljava/lang/String;Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;Lcom/zebra/rfid/api3/AntennaInfo;Lcom/zebra/rfid/api3/TagData;ZZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) writeAccessParams);
        GC.KeepAlive((object) antennaInfo);
        GC.KeepAlive((object) tagData);
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$BlockEraseAccessParams", DoNotGenerateAcw = true)]
    public class BlockEraseAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$BlockEraseAccessParams", typeof (TagAccess.BlockEraseAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getByteCount;
      private static Delegate? cb_setByteCount_I;
      private static Delegate? cb_getByteOffset;
      private static Delegate? cb_setByteOffset_I;
      private static Delegate? cb_getCount;
      private static Delegate? cb_setCount_I;
      private static Delegate? cb_getMemoryBank;
      private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      private static Delegate? cb_getOffset;
      private static Delegate? cb_setOffset_I;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.BlockEraseAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.BlockEraseAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.BlockEraseAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => TagAccess.BlockEraseAccessParams._members.ManagedPeerType;
      }

      protected BlockEraseAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe BlockEraseAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.BlockEraseAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V", "")]
      public unsafe BlockEraseAccessParams(
        TagAccess? __self,
        MEMORY_BANK? m_eMemoryBank,
        int m_nByteOffset,
        int m_nByteCount,
        long m_nAccessPassword)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
            new JniArgumentValue(m_nByteOffset),
            new JniArgumentValue(m_nByteCount),
            new JniArgumentValue(m_nAccessPassword)
          };
          JniObjectReference instance = TagAccess.BlockEraseAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_eMemoryBank);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getAccessPassword == null)
          TagAccess.BlockEraseAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.BlockEraseAccessParams.n_GetAccessPassword));
        return TagAccess.BlockEraseAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setAccessPassword_J == null)
          TagAccess.BlockEraseAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.BlockEraseAccessParams.n_SetAccessPassword_J));
        return TagAccess.BlockEraseAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteCountHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getByteCount == null)
          TagAccess.BlockEraseAccessParams.cb_getByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockEraseAccessParams.n_GetByteCount));
        return TagAccess.BlockEraseAccessParams.cb_getByteCount;
      }

      [Obsolete]
      private static int n_GetByteCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount;
      }

      [Obsolete]
      private static Delegate GetSetByteCount_IHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setByteCount_I == null)
          TagAccess.BlockEraseAccessParams.cb_setByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockEraseAccessParams.n_SetByteCount_I));
        return TagAccess.BlockEraseAccessParams.cb_setByteCount_I;
      }

      [Obsolete]
      private static void n_SetByteCount_I(IntPtr jnienv, IntPtr native__this, int byteCount)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount = byteCount;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteCount
      {
        [Register("getByteCount", "()I", "GetGetByteCountHandler")] get
        {
          return TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteCount", "(I)V", "GetSetByteCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteOffsetHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getByteOffset == null)
          TagAccess.BlockEraseAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockEraseAccessParams.n_GetByteOffset));
        return TagAccess.BlockEraseAccessParams.cb_getByteOffset;
      }

      [Obsolete]
      private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
      }

      [Obsolete]
      private static Delegate GetSetByteOffset_IHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setByteOffset_I == null)
          TagAccess.BlockEraseAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockEraseAccessParams.n_SetByteOffset_I));
        return TagAccess.BlockEraseAccessParams.cb_setByteOffset_I;
      }

      [Obsolete]
      private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteOffset
      {
        [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
        {
          return TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetCountHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getCount == null)
          TagAccess.BlockEraseAccessParams.cb_getCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockEraseAccessParams.n_GetCount));
        return TagAccess.BlockEraseAccessParams.cb_getCount;
      }

      private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count;
      }

      private static Delegate GetSetCount_IHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setCount_I == null)
          TagAccess.BlockEraseAccessParams.cb_setCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockEraseAccessParams.n_SetCount_I));
        return TagAccess.BlockEraseAccessParams.cb_setCount_I;
      }

      private static void n_SetCount_I(IntPtr jnienv, IntPtr native__this, int Count)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count = Count;
      }

      public virtual unsafe int Count
      {
        [Register("getCount", "()I", "GetGetCountHandler")] get
        {
          return TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setCount", "(I)V", "GetSetCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMemoryBankHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getMemoryBank == null)
          TagAccess.BlockEraseAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.BlockEraseAccessParams.n_GetMemoryBank));
        return TagAccess.BlockEraseAccessParams.cb_getMemoryBank;
      }

      private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
      }

      private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
          TagAccess.BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.BlockEraseAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
        return TagAccess.BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      }

      private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_memoryBank)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
      }

      public virtual unsafe MEMORY_BANK? MemoryBank
      {
        [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetOffsetHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_getOffset == null)
          TagAccess.BlockEraseAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockEraseAccessParams.n_GetOffset));
        return TagAccess.BlockEraseAccessParams.cb_getOffset;
      }

      private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
      }

      private static Delegate GetSetOffset_IHandler()
      {
        if ((object) TagAccess.BlockEraseAccessParams.cb_setOffset_I == null)
          TagAccess.BlockEraseAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockEraseAccessParams.n_SetOffset_I));
        return TagAccess.BlockEraseAccessParams.cb_setOffset_I;
      }

      private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
      {
        Object.GetObject<TagAccess.BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
      }

      public virtual unsafe int Offset
      {
        [Register("getOffset", "()I", "GetGetOffsetHandler")] get
        {
          return TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams", DoNotGenerateAcw = true)]
    public class BlockPermalockAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams", typeof (TagAccess.BlockPermalockAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getByteCount;
      private static Delegate? cb_setByteCount_I;
      private static Delegate? cb_getByteOffset;
      private static Delegate? cb_setByteOffset_I;
      private static Delegate? cb_getCount;
      private static Delegate? cb_setCount_I;
      private static Delegate? cb_getMaskLength;
      private static Delegate? cb_setMaskLength_I;
      private static Delegate? cb_getMemoryBank;
      private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      private static Delegate? cb_getOffset;
      private static Delegate? cb_setOffset_I;
      private static Delegate? cb_getReadLock;
      private static Delegate? cb_setReadLock_Z;
      private static Delegate? cb_getMask;
      private static Delegate? cb_setMask_arrayB;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.BlockPermalockAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.BlockPermalockAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.BlockPermalockAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => TagAccess.BlockPermalockAccessParams._members.ManagedPeerType;
      }

      protected BlockPermalockAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe BlockPermalockAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.BlockPermalockAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;Lcom/zebra/rfid/api3/MEMORY_BANK;ZIIJI[B)V", "")]
      public unsafe BlockPermalockAccessParams(
        TagAccess? __self,
        MEMORY_BANK? m_eMemoryBank,
        bool m_bReadLock,
        int m_nByteOffset,
        int m_nByteCount,
        long m_nAccessPassword,
        int m_nMaskLength,
        byte[]? m_pMask)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Lcom/zebra/rfid/api3/MEMORY_BANK;ZIIJI[B)V";
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewArray(m_pMask);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[8]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
            new JniArgumentValue(m_bReadLock),
            new JniArgumentValue(m_nByteOffset),
            new JniArgumentValue(m_nByteCount),
            new JniArgumentValue(m_nAccessPassword),
            new JniArgumentValue(m_nMaskLength),
            new JniArgumentValue(num)
          };
          JniObjectReference instance = TagAccess.BlockPermalockAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (m_pMask != null)
          {
            JNIEnv.CopyArray(num, m_pMask);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_eMemoryBank);
          GC.KeepAlive((object) m_pMask);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getAccessPassword == null)
          TagAccess.BlockPermalockAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.BlockPermalockAccessParams.n_GetAccessPassword));
        return TagAccess.BlockPermalockAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setAccessPassword_J == null)
          TagAccess.BlockPermalockAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.BlockPermalockAccessParams.n_SetAccessPassword_J));
        return TagAccess.BlockPermalockAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteCountHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getByteCount == null)
          TagAccess.BlockPermalockAccessParams.cb_getByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockPermalockAccessParams.n_GetByteCount));
        return TagAccess.BlockPermalockAccessParams.cb_getByteCount;
      }

      [Obsolete]
      private static int n_GetByteCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount;
      }

      [Obsolete]
      private static Delegate GetSetByteCount_IHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setByteCount_I == null)
          TagAccess.BlockPermalockAccessParams.cb_setByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockPermalockAccessParams.n_SetByteCount_I));
        return TagAccess.BlockPermalockAccessParams.cb_setByteCount_I;
      }

      [Obsolete]
      private static void n_SetByteCount_I(IntPtr jnienv, IntPtr native__this, int byteCount)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount = byteCount;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteCount
      {
        [Register("getByteCount", "()I", "GetGetByteCountHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteCount", "(I)V", "GetSetByteCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteOffsetHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getByteOffset == null)
          TagAccess.BlockPermalockAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockPermalockAccessParams.n_GetByteOffset));
        return TagAccess.BlockPermalockAccessParams.cb_getByteOffset;
      }

      [Obsolete]
      private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
      }

      [Obsolete]
      private static Delegate GetSetByteOffset_IHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setByteOffset_I == null)
          TagAccess.BlockPermalockAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockPermalockAccessParams.n_SetByteOffset_I));
        return TagAccess.BlockPermalockAccessParams.cb_setByteOffset_I;
      }

      [Obsolete]
      private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteOffset
      {
        [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetCountHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getCount == null)
          TagAccess.BlockPermalockAccessParams.cb_getCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockPermalockAccessParams.n_GetCount));
        return TagAccess.BlockPermalockAccessParams.cb_getCount;
      }

      private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count;
      }

      private static Delegate GetSetCount_IHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setCount_I == null)
          TagAccess.BlockPermalockAccessParams.cb_setCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockPermalockAccessParams.n_SetCount_I));
        return TagAccess.BlockPermalockAccessParams.cb_setCount_I;
      }

      private static void n_SetCount_I(IntPtr jnienv, IntPtr native__this, int Count)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count = Count;
      }

      public virtual unsafe int Count
      {
        [Register("getCount", "()I", "GetGetCountHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setCount", "(I)V", "GetSetCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMaskLengthHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getMaskLength == null)
          TagAccess.BlockPermalockAccessParams.cb_getMaskLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockPermalockAccessParams.n_GetMaskLength));
        return TagAccess.BlockPermalockAccessParams.cb_getMaskLength;
      }

      private static int n_GetMaskLength(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MaskLength;
      }

      private static Delegate GetSetMaskLength_IHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setMaskLength_I == null)
          TagAccess.BlockPermalockAccessParams.cb_setMaskLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockPermalockAccessParams.n_SetMaskLength_I));
        return TagAccess.BlockPermalockAccessParams.cb_setMaskLength_I;
      }

      private static void n_SetMaskLength_I(IntPtr jnienv, IntPtr native__this, int maskLength)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MaskLength = maskLength;
      }

      public virtual unsafe int MaskLength
      {
        [Register("getMaskLength", "()I", "GetGetMaskLengthHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getMaskLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setMaskLength", "(I)V", "GetSetMaskLength_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMaskLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMemoryBankHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getMemoryBank == null)
          TagAccess.BlockPermalockAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.BlockPermalockAccessParams.n_GetMemoryBank));
        return TagAccess.BlockPermalockAccessParams.cb_getMemoryBank;
      }

      private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
      }

      private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
          TagAccess.BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.BlockPermalockAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
        return TagAccess.BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      }

      private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_memoryBank)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
      }

      public virtual unsafe MEMORY_BANK? MemoryBank
      {
        [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetOffsetHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getOffset == null)
          TagAccess.BlockPermalockAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.BlockPermalockAccessParams.n_GetOffset));
        return TagAccess.BlockPermalockAccessParams.cb_getOffset;
      }

      private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
      }

      private static Delegate GetSetOffset_IHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setOffset_I == null)
          TagAccess.BlockPermalockAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.BlockPermalockAccessParams.n_SetOffset_I));
        return TagAccess.BlockPermalockAccessParams.cb_setOffset_I;
      }

      private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
      }

      public virtual unsafe int Offset
      {
        [Register("getOffset", "()I", "GetGetOffsetHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetReadLockHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getReadLock == null)
          TagAccess.BlockPermalockAccessParams.cb_getReadLock = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TagAccess.BlockPermalockAccessParams.n_GetReadLock));
        return TagAccess.BlockPermalockAccessParams.cb_getReadLock;
      }

      private static bool n_GetReadLock(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ReadLock;
      }

      private static Delegate GetSetReadLock_ZHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setReadLock_Z == null)
          TagAccess.BlockPermalockAccessParams.cb_setReadLock_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(TagAccess.BlockPermalockAccessParams.n_SetReadLock_Z));
        return TagAccess.BlockPermalockAccessParams.cb_setReadLock_Z;
      }

      private static void n_SetReadLock_Z(IntPtr jnienv, IntPtr native__this, bool readLock)
      {
        Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ReadLock = readLock;
      }

      public virtual unsafe bool ReadLock
      {
        [Register("getReadLock", "()Z", "GetGetReadLockHandler")] get
        {
          return TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getReadLock.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setReadLock", "(Z)V", "GetSetReadLock_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setReadLock.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMaskHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_getMask == null)
          TagAccess.BlockPermalockAccessParams.cb_getMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.BlockPermalockAccessParams.n_GetMask));
        return TagAccess.BlockPermalockAccessParams.cb_getMask;
      }

      private static IntPtr n_GetMask(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewArray(Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetMask());
      }

      [Register("getMask", "()[B", "GetGetMaskHandler")]
      public virtual unsafe byte[]? GetMask()
      {
        JniObjectReference jniObjectReference = TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }

      private static Delegate GetSetMask_arrayBHandler()
      {
        if ((object) TagAccess.BlockPermalockAccessParams.cb_setMask_arrayB == null)
          TagAccess.BlockPermalockAccessParams.cb_setMask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.BlockPermalockAccessParams.n_SetMask_arrayB));
        return TagAccess.BlockPermalockAccessParams.cb_setMask_arrayB;
      }

      private static void n_SetMask_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_mask)
      {
        TagAccess.BlockPermalockAccessParams permalockAccessParams = Object.GetObject<TagAccess.BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
        byte[] array = (byte[]) JNIEnv.GetArray(native_mask, (JniHandleOwnership) 0, typeof (byte));
        byte[] mask = array;
        permalockAccessParams.SetMask(mask);
        if (array == null)
          return;
        JNIEnv.CopyArray(array, native_mask);
      }

      [Register("setMask", "([B)V", "GetSetMask_arrayBHandler")]
      public virtual unsafe void SetMask(byte[]? mask)
      {
        IntPtr num = JNIEnv.NewArray(mask);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagAccess.BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (mask != null)
          {
            JNIEnv.CopyArray(num, mask);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) mask);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$KillAccessParams", DoNotGenerateAcw = true)]
    public class KillAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$KillAccessParams", typeof (TagAccess.KillAccessParams));
      private static Delegate? cb_getKillPassword;
      private static Delegate? cb_setKillPassword_J;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.KillAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.KillAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.KillAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => TagAccess.KillAccessParams._members.ManagedPeerType;

      protected KillAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe KillAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.KillAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.KillAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;J)V", "")]
      public unsafe KillAccessParams(TagAccess? __self, long m_nKillPassword)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";J)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_nKillPassword)
          };
          JniObjectReference instance = TagAccess.KillAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.KillAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetKillPasswordHandler()
      {
        if ((object) TagAccess.KillAccessParams.cb_getKillPassword == null)
          TagAccess.KillAccessParams.cb_getKillPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.KillAccessParams.n_GetKillPassword));
        return TagAccess.KillAccessParams.cb_getKillPassword;
      }

      private static long n_GetKillPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.KillAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword;
      }

      private static Delegate GetSetKillPassword_JHandler()
      {
        if ((object) TagAccess.KillAccessParams.cb_setKillPassword_J == null)
          TagAccess.KillAccessParams.cb_setKillPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.KillAccessParams.n_SetKillPassword_J));
        return TagAccess.KillAccessParams.cb_setKillPassword_J;
      }

      private static void n_SetKillPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long killPassword)
      {
        Object.GetObject<TagAccess.KillAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword = killPassword;
      }

      public virtual unsafe long KillPassword
      {
        [Register("getKillPassword", "()J", "GetGetKillPasswordHandler")] get
        {
          return TagAccess.KillAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getKillPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setKillPassword", "(J)V", "GetSetKillPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.KillAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setKillPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$LockAccessParams", DoNotGenerateAcw = true)]
    public class LockAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$LockAccessParams", typeof (TagAccess.LockAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getAccessPasswordMemoryIndex;
      private static Delegate? cb_getEPCMemoryIndex;
      private static Delegate? cb_getKillPasswordMemoryIndex;
      private static Delegate? cb_getTIDMemoryIndex;
      private static Delegate? cb_getUserMemoryIndex;
      private static Delegate? cb_getLockPrivilege;
      private static Delegate? cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.LockAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.LockAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.LockAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => TagAccess.LockAccessParams._members.ManagedPeerType;

      protected LockAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe LockAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.LockAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.LockAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;J[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", "")]
      public unsafe LockAccessParams(
        TagAccess? __self,
        long m_nAccessPassword,
        LOCK_PRIVILEGE[]? m_eLockPrivilege)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";J[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V";
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewArray<LOCK_PRIVILEGE>(m_eLockPrivilege);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_nAccessPassword),
            new JniArgumentValue(num)
          };
          JniObjectReference instance = TagAccess.LockAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.LockAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (m_eLockPrivilege != null)
          {
            JNIEnv.CopyArray<LOCK_PRIVILEGE>(num, m_eLockPrivilege);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_eLockPrivilege);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getAccessPassword == null)
          TagAccess.LockAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.LockAccessParams.n_GetAccessPassword));
        return TagAccess.LockAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_setAccessPassword_J == null)
          TagAccess.LockAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.LockAccessParams.n_SetAccessPassword_J));
        return TagAccess.LockAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetAccessPasswordMemoryIndexHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getAccessPasswordMemoryIndex == null)
          TagAccess.LockAccessParams.cb_getAccessPasswordMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.LockAccessParams.n_GetAccessPasswordMemoryIndex));
        return TagAccess.LockAccessParams.cb_getAccessPasswordMemoryIndex;
      }

      private static int n_GetAccessPasswordMemoryIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPasswordMemoryIndex;
      }

      public virtual unsafe int AccessPasswordMemoryIndex
      {
        [Register("getAccessPasswordMemoryIndex", "()I", "GetGetAccessPasswordMemoryIndexHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getAccessPasswordMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetEPCMemoryIndexHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getEPCMemoryIndex == null)
          TagAccess.LockAccessParams.cb_getEPCMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.LockAccessParams.n_GetEPCMemoryIndex));
        return TagAccess.LockAccessParams.cb_getEPCMemoryIndex;
      }

      private static int n_GetEPCMemoryIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).EPCMemoryIndex;
      }

      public virtual unsafe int EPCMemoryIndex
      {
        [Register("getEPCMemoryIndex", "()I", "GetGetEPCMemoryIndexHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getEPCMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetKillPasswordMemoryIndexHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getKillPasswordMemoryIndex == null)
          TagAccess.LockAccessParams.cb_getKillPasswordMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.LockAccessParams.n_GetKillPasswordMemoryIndex));
        return TagAccess.LockAccessParams.cb_getKillPasswordMemoryIndex;
      }

      private static int n_GetKillPasswordMemoryIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPasswordMemoryIndex;
      }

      public virtual unsafe int KillPasswordMemoryIndex
      {
        [Register("getKillPasswordMemoryIndex", "()I", "GetGetKillPasswordMemoryIndexHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getKillPasswordMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetTIDMemoryIndexHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getTIDMemoryIndex == null)
          TagAccess.LockAccessParams.cb_getTIDMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.LockAccessParams.n_GetTIDMemoryIndex));
        return TagAccess.LockAccessParams.cb_getTIDMemoryIndex;
      }

      private static int n_GetTIDMemoryIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).TIDMemoryIndex;
      }

      public virtual unsafe int TIDMemoryIndex
      {
        [Register("getTIDMemoryIndex", "()I", "GetGetTIDMemoryIndexHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getTIDMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetUserMemoryIndexHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getUserMemoryIndex == null)
          TagAccess.LockAccessParams.cb_getUserMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.LockAccessParams.n_GetUserMemoryIndex));
        return TagAccess.LockAccessParams.cb_getUserMemoryIndex;
      }

      private static int n_GetUserMemoryIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).UserMemoryIndex;
      }

      public virtual unsafe int UserMemoryIndex
      {
        [Register("getUserMemoryIndex", "()I", "GetGetUserMemoryIndexHandler")] get
        {
          return TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getUserMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetLockPrivilegeHandler()
      {
        if ((object) TagAccess.LockAccessParams.cb_getLockPrivilege == null)
          TagAccess.LockAccessParams.cb_getLockPrivilege = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.LockAccessParams.n_GetLockPrivilege));
        return TagAccess.LockAccessParams.cb_getLockPrivilege;
      }

      private static IntPtr n_GetLockPrivilege(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewArray<LOCK_PRIVILEGE>(Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetLockPrivilege());
      }

      [Register("getLockPrivilege", "()[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", "GetGetLockPrivilegeHandler")]
      public virtual unsafe LOCK_PRIVILEGE[]? GetLockPrivilege()
      {
        JniObjectReference jniObjectReference = TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getLockPrivilege.()[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return (LOCK_PRIVILEGE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (LOCK_PRIVILEGE));
      }

      private static Delegate GetSetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_Handler()
      {
        if ((object) TagAccess.LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_ == null)
          TagAccess.LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(TagAccess.LockAccessParams.n_SetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_));
        return TagAccess.LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_;
      }

      private static void n_SetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_lockDataField,
        IntPtr native_lockPrivilege)
      {
        TagAccess.LockAccessParams lockAccessParams = Object.GetObject<TagAccess.LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
        LOCK_DATA_FIELD lockDataField1 = Object.GetObject<LOCK_DATA_FIELD>(native_lockDataField, (JniHandleOwnership) 0);
        LOCK_PRIVILEGE lockPrivilege1 = Object.GetObject<LOCK_PRIVILEGE>(native_lockPrivilege, (JniHandleOwnership) 0);
        LOCK_DATA_FIELD lockDataField2 = lockDataField1;
        LOCK_PRIVILEGE lockPrivilege2 = lockPrivilege1;
        lockAccessParams.SetLockPrivilege(lockDataField2, lockPrivilege2);
      }

      [Register("setLockPrivilege", "(Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", "GetSetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_Handler")]
      public virtual unsafe void SetLockPrivilege(
        LOCK_DATA_FIELD? lockDataField,
        LOCK_PRIVILEGE? lockPrivilege)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
          {
            new JniArgumentValue(lockDataField == null ? IntPtr.Zero : lockDataField.Handle),
            new JniArgumentValue(lockPrivilege == null ? IntPtr.Zero : lockPrivilege.Handle)
          };
          TagAccess.LockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setLockPrivilege.(Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) lockDataField);
          GC.KeepAlive((object) lockPrivilege);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$ReadAccessParams", DoNotGenerateAcw = true)]
    public class ReadAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$ReadAccessParams", typeof (TagAccess.ReadAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getByteCount;
      private static Delegate? cb_setByteCount_I;
      private static Delegate? cb_getByteOffset;
      private static Delegate? cb_setByteOffset_I;
      private static Delegate? cb_getCount;
      private static Delegate? cb_setCount_I;
      private static Delegate? cb_getMemoryBank;
      private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      private static Delegate? cb_getOffset;
      private static Delegate? cb_setOffset_I;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.ReadAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.ReadAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.ReadAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => TagAccess.ReadAccessParams._members.ManagedPeerType;

      protected ReadAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe ReadAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.ReadAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.ReadAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V", "")]
      public unsafe ReadAccessParams(
        TagAccess? __self,
        MEMORY_BANK? m_eMemoryBank,
        int m_nByteOffset,
        int m_nByteCount,
        long m_nAccessPassword)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
            new JniArgumentValue(m_nByteOffset),
            new JniArgumentValue(m_nByteCount),
            new JniArgumentValue(m_nAccessPassword)
          };
          JniObjectReference instance = TagAccess.ReadAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.ReadAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_eMemoryBank);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getAccessPassword == null)
          TagAccess.ReadAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.ReadAccessParams.n_GetAccessPassword));
        return TagAccess.ReadAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setAccessPassword_J == null)
          TagAccess.ReadAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.ReadAccessParams.n_SetAccessPassword_J));
        return TagAccess.ReadAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteCountHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getByteCount == null)
          TagAccess.ReadAccessParams.cb_getByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.ReadAccessParams.n_GetByteCount));
        return TagAccess.ReadAccessParams.cb_getByteCount;
      }

      [Obsolete]
      private static int n_GetByteCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount;
      }

      [Obsolete]
      private static Delegate GetSetByteCount_IHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setByteCount_I == null)
          TagAccess.ReadAccessParams.cb_setByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.ReadAccessParams.n_SetByteCount_I));
        return TagAccess.ReadAccessParams.cb_setByteCount_I;
      }

      [Obsolete]
      private static void n_SetByteCount_I(IntPtr jnienv, IntPtr native__this, int m_nByteCount)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount = m_nByteCount;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteCount
      {
        [Register("getByteCount", "()I", "GetGetByteCountHandler")] get
        {
          return TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteCount", "(I)V", "GetSetByteCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteOffsetHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getByteOffset == null)
          TagAccess.ReadAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.ReadAccessParams.n_GetByteOffset));
        return TagAccess.ReadAccessParams.cb_getByteOffset;
      }

      [Obsolete]
      private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
      }

      [Obsolete]
      private static Delegate GetSetByteOffset_IHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setByteOffset_I == null)
          TagAccess.ReadAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.ReadAccessParams.n_SetByteOffset_I));
        return TagAccess.ReadAccessParams.cb_setByteOffset_I;
      }

      [Obsolete]
      private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteOffset
      {
        [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
        {
          return TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetCountHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getCount == null)
          TagAccess.ReadAccessParams.cb_getCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.ReadAccessParams.n_GetCount));
        return TagAccess.ReadAccessParams.cb_getCount;
      }

      private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count;
      }

      private static Delegate GetSetCount_IHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setCount_I == null)
          TagAccess.ReadAccessParams.cb_setCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.ReadAccessParams.n_SetCount_I));
        return TagAccess.ReadAccessParams.cb_setCount_I;
      }

      private static void n_SetCount_I(IntPtr jnienv, IntPtr native__this, int m_nCount)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count = m_nCount;
      }

      public virtual unsafe int Count
      {
        [Register("getCount", "()I", "GetGetCountHandler")] get
        {
          return TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setCount", "(I)V", "GetSetCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMemoryBankHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getMemoryBank == null)
          TagAccess.ReadAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.ReadAccessParams.n_GetMemoryBank));
        return TagAccess.ReadAccessParams.cb_getMemoryBank;
      }

      private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
      }

      private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
          TagAccess.ReadAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.ReadAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
        return TagAccess.ReadAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      }

      private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_memoryBank)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
      }

      public virtual unsafe MEMORY_BANK? MemoryBank
      {
        [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetOffsetHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_getOffset == null)
          TagAccess.ReadAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.ReadAccessParams.n_GetOffset));
        return TagAccess.ReadAccessParams.cb_getOffset;
      }

      private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
      }

      private static Delegate GetSetOffset_IHandler()
      {
        if ((object) TagAccess.ReadAccessParams.cb_setOffset_I == null)
          TagAccess.ReadAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.ReadAccessParams.n_SetOffset_I));
        return TagAccess.ReadAccessParams.cb_setOffset_I;
      }

      private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
      {
        Object.GetObject<TagAccess.ReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
      }

      public virtual unsafe int Offset
      {
        [Register("getOffset", "()I", "GetGetOffsetHandler")] get
        {
          return TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.ReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$RecommisionAccessParams", DoNotGenerateAcw = true)]
    public class RecommisionAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$RecommisionAccessParams", typeof (TagAccess.RecommisionAccessParams));
      private static Delegate? cb_getKillPassword;
      private static Delegate? cb_setKillPassword_J;
      private static Delegate? cb_getOpCode;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.RecommisionAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.RecommisionAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.RecommisionAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => TagAccess.RecommisionAccessParams._members.ManagedPeerType;
      }

      protected RecommisionAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe RecommisionAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.RecommisionAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.RecommisionAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetKillPasswordHandler()
      {
        if ((object) TagAccess.RecommisionAccessParams.cb_getKillPassword == null)
          TagAccess.RecommisionAccessParams.cb_getKillPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.RecommisionAccessParams.n_GetKillPassword));
        return TagAccess.RecommisionAccessParams.cb_getKillPassword;
      }

      private static long n_GetKillPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword;
      }

      private static Delegate GetSetKillPassword_JHandler()
      {
        if ((object) TagAccess.RecommisionAccessParams.cb_setKillPassword_J == null)
          TagAccess.RecommisionAccessParams.cb_setKillPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.RecommisionAccessParams.n_SetKillPassword_J));
        return TagAccess.RecommisionAccessParams.cb_setKillPassword_J;
      }

      private static void n_SetKillPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long killPassword)
      {
        Object.GetObject<TagAccess.RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword = killPassword;
      }

      public virtual unsafe long KillPassword
      {
        [Register("getKillPassword", "()J", "GetGetKillPasswordHandler")] get
        {
          return TagAccess.RecommisionAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getKillPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setKillPassword", "(J)V", "GetSetKillPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.RecommisionAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setKillPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetOpCodeHandler()
      {
        if ((object) TagAccess.RecommisionAccessParams.cb_getOpCode == null)
          TagAccess.RecommisionAccessParams.cb_getOpCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.RecommisionAccessParams.n_GetOpCode));
        return TagAccess.RecommisionAccessParams.cb_getOpCode;
      }

      private static IntPtr n_GetOpCode(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).OpCode);
      }

      public virtual unsafe Object? OpCode
      {
        [Register("getOpCode", "()Ljava/lang/Object;", "GetGetOpCodeHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.RecommisionAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getOpCode.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$Sequence", DoNotGenerateAcw = true)]
    public class Sequence : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$Sequence", typeof (TagAccess.Sequence));
      private static Delegate? cb_getLength;
      private static Delegate? cb_add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_;
      private static Delegate? cb_deInitSequence;
      private static Delegate? cb_delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_;
      private static Delegate? cb_deleteAll;
      private static Delegate? cb_getOperation_I;
      private static Delegate? cb_initSequence;
      private static Delegate? cb_performSequence;
      private static Delegate? cb_performSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_;
      private static Delegate? cb_stopSequence;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.Sequence._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.Sequence._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.Sequence._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => TagAccess.Sequence._members.ManagedPeerType;

      protected Sequence(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe Sequence(TagAccess? __self, TagAccess? tagAccess)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Lcom/zebra/rfid/api3/TagAccess;)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(tagAccess == null ? IntPtr.Zero : tagAccess.Handle)
          };
          JniObjectReference instance = TagAccess.Sequence._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.Sequence._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) tagAccess);
        }
      }

      private static Delegate GetGetLengthHandler()
      {
        if ((object) TagAccess.Sequence.cb_getLength == null)
          TagAccess.Sequence.cb_getLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.Sequence.n_GetLength));
        return TagAccess.Sequence.cb_getLength;
      }

      private static int n_GetLength(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).Length;
      }

      public virtual unsafe int Length
      {
        [Register("getLength", "()I", "GetGetLengthHandler")] get
        {
          return TagAccess.Sequence._members.InstanceMethods.InvokeVirtualInt32Method("getLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetAdd_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_Handler()
      {
        if ((object) TagAccess.Sequence.cb_add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_ == null)
          TagAccess.Sequence.cb_add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.Sequence.n_Add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_));
        return TagAccess.Sequence.cb_add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_;
      }

      private static void n_Add_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_operation)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).Add(Object.GetObject<TagAccess.Sequence.Operation>(native_operation, (JniHandleOwnership) 0));
      }

      [Register("add", "(Lcom/zebra/rfid/api3/TagAccess$Sequence$Operation;)V", "GetAdd_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_Handler")]
      public virtual unsafe void Add(TagAccess.Sequence.Operation? operation)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(operation == null ? IntPtr.Zero : operation.Handle)
          };
          TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("add.(Lcom/zebra/rfid/api3/TagAccess$Sequence$Operation;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) operation);
        }
      }

      private static Delegate GetDeInitSequenceHandler()
      {
        if ((object) TagAccess.Sequence.cb_deInitSequence == null)
          TagAccess.Sequence.cb_deInitSequence = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.Sequence.n_DeInitSequence));
        return TagAccess.Sequence.cb_deInitSequence;
      }

      private static void n_DeInitSequence(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).DeInitSequence();
      }

      [Register("deInitSequence", "()V", "GetDeInitSequenceHandler")]
      public virtual unsafe void DeInitSequence()
      {
        TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("deInitSequence.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetDelete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_Handler()
      {
        if ((object) TagAccess.Sequence.cb_delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_ == null)
          TagAccess.Sequence.cb_delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.Sequence.n_Delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_));
        return TagAccess.Sequence.cb_delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_;
      }

      private static void n_Delete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_operation)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).Delete(Object.GetObject<TagAccess.Sequence.Operation>(native_operation, (JniHandleOwnership) 0));
      }

      [Register("delete", "(Lcom/zebra/rfid/api3/TagAccess$Sequence$Operation;)V", "GetDelete_Lcom_zebra_rfid_api3_TagAccess_Sequence_Operation_Handler")]
      public virtual unsafe void Delete(TagAccess.Sequence.Operation? operation)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(operation == null ? IntPtr.Zero : operation.Handle)
          };
          TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("delete.(Lcom/zebra/rfid/api3/TagAccess$Sequence$Operation;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) operation);
        }
      }

      private static Delegate GetDeleteAllHandler()
      {
        if ((object) TagAccess.Sequence.cb_deleteAll == null)
          TagAccess.Sequence.cb_deleteAll = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.Sequence.n_DeleteAll));
        return TagAccess.Sequence.cb_deleteAll;
      }

      private static void n_DeleteAll(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).DeleteAll();
      }

      [Register("deleteAll", "()V", "GetDeleteAllHandler")]
      public virtual unsafe void DeleteAll()
      {
        TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("deleteAll.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetGetOperation_IHandler()
      {
        if ((object) TagAccess.Sequence.cb_getOperation_I == null)
          TagAccess.Sequence.cb_getOperation_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(TagAccess.Sequence.n_GetOperation_I));
        return TagAccess.Sequence.cb_getOperation_I;
      }

      private static IntPtr n_GetOperation_I(IntPtr jnienv, IntPtr native__this, int index)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).GetOperation(index));
      }

      [Register("getOperation", "(I)Ljava/lang/Object;", "GetGetOperation_IHandler")]
      public virtual unsafe Object? GetOperation(int index)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(index)
        };
        JniObjectReference jniObjectReference = TagAccess.Sequence._members.InstanceMethods.InvokeVirtualObjectMethod("getOperation.(I)Ljava/lang/Object;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }

      private static Delegate GetInitSequenceHandler()
      {
        if ((object) TagAccess.Sequence.cb_initSequence == null)
          TagAccess.Sequence.cb_initSequence = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.Sequence.n_InitSequence));
        return TagAccess.Sequence.cb_initSequence;
      }

      private static void n_InitSequence(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).InitSequence();
      }

      [Register("initSequence", "()V", "GetInitSequenceHandler")]
      public virtual unsafe void InitSequence()
      {
        TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("initSequence.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetPerformSequenceHandler()
      {
        if ((object) TagAccess.Sequence.cb_performSequence == null)
          TagAccess.Sequence.cb_performSequence = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.Sequence.n_PerformSequence));
        return TagAccess.Sequence.cb_performSequence;
      }

      private static void n_PerformSequence(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).PerformSequence();
      }

      [Register("performSequence", "()V", "GetPerformSequenceHandler")]
      public virtual unsafe void PerformSequence()
      {
        TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("performSequence.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetPerformSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
      {
        if ((object) TagAccess.Sequence.cb_performSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
          TagAccess.Sequence.cb_performSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagAccess.Sequence.n_PerformSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_));
        return TagAccess.Sequence.cb_performSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_;
      }

      private static void n_PerformSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_accessFilterInfo,
        IntPtr native_triggerInfo,
        IntPtr native_antennaInfo)
      {
        TagAccess.Sequence sequence = Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0);
        AccessFilter accessFilter = Object.GetObject<AccessFilter>(native_accessFilterInfo, (JniHandleOwnership) 0);
        TriggerInfo triggerInfo1 = Object.GetObject<TriggerInfo>(native_triggerInfo, (JniHandleOwnership) 0);
        AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
        AccessFilter accessFilterInfo = accessFilter;
        TriggerInfo triggerInfo2 = triggerInfo1;
        AntennaInfo antennaInfo2 = antennaInfo1;
        sequence.PerformSequence(accessFilterInfo, triggerInfo2, antennaInfo2);
      }

      [Register("performSequence", "(Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/TriggerInfo;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetPerformSequence_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_TriggerInfo_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
      public virtual unsafe void PerformSequence(
        AccessFilter? accessFilterInfo,
        TriggerInfo? triggerInfo,
        AntennaInfo? antennaInfo)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(accessFilterInfo == null ? IntPtr.Zero : accessFilterInfo.Handle),
            new JniArgumentValue(triggerInfo == null ? IntPtr.Zero : triggerInfo.Handle),
            new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
          };
          TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("performSequence.(Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/TriggerInfo;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) accessFilterInfo);
          GC.KeepAlive((object) triggerInfo);
          GC.KeepAlive((object) antennaInfo);
        }
      }

      private static Delegate GetStopSequenceHandler()
      {
        if ((object) TagAccess.Sequence.cb_stopSequence == null)
          TagAccess.Sequence.cb_stopSequence = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagAccess.Sequence.n_StopSequence));
        return TagAccess.Sequence.cb_stopSequence;
      }

      private static void n_StopSequence(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<TagAccess.Sequence>(jnienv, native__this, (JniHandleOwnership) 0).StopSequence();
      }

      [Register("stopSequence", "()V", "GetStopSequenceHandler")]
      public virtual unsafe void StopSequence()
      {
        TagAccess.Sequence._members.InstanceMethods.InvokeVirtualVoidMethod("stopSequence.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      [Register("com/zebra/rfid/api3/TagAccess$Sequence$Operation", DoNotGenerateAcw = true)]
      public class Operation : Object
      {
        private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$Sequence$Operation", typeof (TagAccess.Sequence.Operation));
        private static Delegate? cb_getAccessOperationCode;
        private static Delegate? cb_setAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_;
        private static Delegate? cb_getOperationIndex;

        [Register("BlockEraseAccessParams")]
        public TagAccess.BlockEraseAccessParams? BlockEraseAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("BlockEraseAccessParams.Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.BlockEraseAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("BlockEraseAccessParams.Lcom/zebra/rfid/api3/TagAccess$BlockEraseAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("BlockPermaLockAccessParams")]
        public TagAccess.BlockPermalockAccessParams? BlockPermaLockAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("BlockPermaLockAccessParams.Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.BlockPermalockAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("BlockPermaLockAccessParams.Lcom/zebra/rfid/api3/TagAccess$BlockPermalockAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("BlockWriteAccessParams")]
        public TagAccess.WriteAccessParams? BlockWriteAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("BlockWriteAccessParams.Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.WriteAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("BlockWriteAccessParams.Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("KillAccessParams")]
        public TagAccess.KillAccessParams? KillAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("KillAccessParams.Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.KillAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("KillAccessParams.Lcom/zebra/rfid/api3/TagAccess$KillAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("LockAccessParams")]
        public TagAccess.LockAccessParams? LockAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("LockAccessParams.Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.LockAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("LockAccessParams.Lcom/zebra/rfid/api3/TagAccess$LockAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("ReadAccessParams")]
        public TagAccess.ReadAccessParams? ReadAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("ReadAccessParams.Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.ReadAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("ReadAccessParams.Lcom/zebra/rfid/api3/TagAccess$ReadAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("RecommisionAccessParams")]
        public TagAccess.RecommisionAccessParams? RecommisionAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("RecommisionAccessParams.Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.RecommisionAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("RecommisionAccessParams.Lcom/zebra/rfid/api3/TagAccess$RecommisionAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
            }
            finally
            {
              JNIEnv.DeleteLocalRef(localJniHandle);
            }
          }
        }

        [Register("WriteAccessParams")]
        public TagAccess.WriteAccessParams? WriteAccessParams
        {
          get
          {
            JniObjectReference objectValue = TagAccess.Sequence.Operation._members.InstanceFields.GetObjectValue("WriteAccessParams.Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;", (IJavaPeerable) this);
            return Object.GetObject<TagAccess.WriteAccessParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
          }
          set
          {
            IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
            try
            {
              TagAccess.Sequence.Operation._members.InstanceFields.SetValue("WriteAccessParams.Lcom/zebra/rfid/api3/TagAccess$WriteAccessParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
            JniObjectReference peerReference = TagAccess.Sequence.Operation._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual JniPeerMembers JniPeerMembers => TagAccess.Sequence.Operation._members;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual IntPtr ThresholdClass
        {
          get
          {
            JniObjectReference peerReference = TagAccess.Sequence.Operation._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual Type ThresholdType
        {
          get => TagAccess.Sequence.Operation._members.ManagedPeerType;
        }

        protected Operation(IntPtr javaReference, JniHandleOwnership transfer)
          : base(javaReference, transfer)
        {
        }

        [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess$Sequence;)V", "")]
        public unsafe Operation(TagAccess.Sequence? __self)
          : base(IntPtr.Zero, (JniHandleOwnership) 0)
        {
          string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
          if (this.Handle != IntPtr.Zero)
            return;
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
            };
            JniObjectReference instance = TagAccess.Sequence.Operation._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
            this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
            TagAccess.Sequence.Operation._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) __self);
          }
        }

        private static Delegate GetGetAccessOperationCodeHandler()
        {
          if ((object) TagAccess.Sequence.Operation.cb_getAccessOperationCode == null)
            TagAccess.Sequence.Operation.cb_getAccessOperationCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.Sequence.Operation.n_GetAccessOperationCode));
          return TagAccess.Sequence.Operation.cb_getAccessOperationCode;
        }

        private static IntPtr n_GetAccessOperationCode(IntPtr jnienv, IntPtr native__this)
        {
          return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.Sequence.Operation>(jnienv, native__this, (JniHandleOwnership) 0).AccessOperationCode);
        }

        private static Delegate GetSetAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_Handler()
        {
          if ((object) TagAccess.Sequence.Operation.cb_setAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_ == null)
            TagAccess.Sequence.Operation.cb_setAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.Sequence.Operation.n_SetAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_));
          return TagAccess.Sequence.Operation.cb_setAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_;
        }

        private static void n_SetAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_(
          IntPtr jnienv,
          IntPtr native__this,
          IntPtr native_accessOperationCode)
        {
          Object.GetObject<TagAccess.Sequence.Operation>(jnienv, native__this, (JniHandleOwnership) 0).AccessOperationCode = Object.GetObject<ACCESS_OPERATION_CODE>(native_accessOperationCode, (JniHandleOwnership) 0);
        }

        public virtual unsafe ACCESS_OPERATION_CODE? AccessOperationCode
        {
          [Register("getAccessOperationCode", "()Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", "GetGetAccessOperationCodeHandler")] get
          {
            JniObjectReference jniObjectReference = TagAccess.Sequence.Operation._members.InstanceMethods.InvokeVirtualObjectMethod("getAccessOperationCode.()Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
            return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
          }
          [Register("setAccessOperationCode", "(Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;)V", "GetSetAccessOperationCode_Lcom_zebra_rfid_api3_ACCESS_OPERATION_CODE_Handler")] set
          {
            try
            {
              JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
              {
                new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
              };
              TagAccess.Sequence.Operation._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessOperationCode.(Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
            }
            finally
            {
              GC.KeepAlive((object) value);
            }
          }
        }

        private static Delegate GetGetOperationIndexHandler()
        {
          if ((object) TagAccess.Sequence.Operation.cb_getOperationIndex == null)
            TagAccess.Sequence.Operation.cb_getOperationIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.Sequence.Operation.n_GetOperationIndex));
          return TagAccess.Sequence.Operation.cb_getOperationIndex;
        }

        private static int n_GetOperationIndex(IntPtr jnienv, IntPtr native__this)
        {
          return Object.GetObject<TagAccess.Sequence.Operation>(jnienv, native__this, (JniHandleOwnership) 0).OperationIndex;
        }

        public virtual unsafe int OperationIndex
        {
          [Register("getOperationIndex", "()I", "GetGetOperationIndexHandler")] get
          {
            return TagAccess.Sequence.Operation._members.InstanceMethods.InvokeVirtualInt32Method("getOperationIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
          }
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$WriteAccessParams", DoNotGenerateAcw = true)]
    public class WriteAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$WriteAccessParams", typeof (TagAccess.WriteAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getByteOffset;
      private static Delegate? cb_setByteOffset_I;
      private static Delegate? cb_getMemoryBank;
      private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      private static Delegate? cb_getOffset;
      private static Delegate? cb_setOffset_I;
      private static Delegate? cb_getStringWriteData;
      private static Delegate? cb_getWriteDataLength;
      private static Delegate? cb_setWriteDataLength_I;
      private static Delegate? cb_getWriteRetries;
      private static Delegate? cb_setWriteRetries_I;
      private static Delegate? cb_getWriteData;
      private static Delegate? cb_setWriteData_arrayB;
      private static Delegate? cb_setWriteData_Ljava_lang_String_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.WriteAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => TagAccess.WriteAccessParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.WriteAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => TagAccess.WriteAccessParams._members.ManagedPeerType;

      protected WriteAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe WriteAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.WriteAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.WriteAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ[B)V", "")]
      public unsafe WriteAccessParams(
        TagAccess? __self,
        MEMORY_BANK? m_eMemoryBank,
        int m_nByteOffset,
        int m_nWriteDataLength,
        long m_nAccessPassword,
        byte[]? m_WriteData)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ[B)V";
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewArray(m_WriteData);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[6]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
            new JniArgumentValue(m_nByteOffset),
            new JniArgumentValue(m_nWriteDataLength),
            new JniArgumentValue(m_nAccessPassword),
            new JniArgumentValue(num)
          };
          JniObjectReference instance = TagAccess.WriteAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.WriteAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (m_WriteData != null)
          {
            JNIEnv.CopyArray(num, m_WriteData);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_eMemoryBank);
          GC.KeepAlive((object) m_WriteData);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getAccessPassword == null)
          TagAccess.WriteAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.WriteAccessParams.n_GetAccessPassword));
        return TagAccess.WriteAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setAccessPassword_J == null)
          TagAccess.WriteAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.WriteAccessParams.n_SetAccessPassword_J));
        return TagAccess.WriteAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Obsolete]
      private static Delegate GetGetByteOffsetHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getByteOffset == null)
          TagAccess.WriteAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.WriteAccessParams.n_GetByteOffset));
        return TagAccess.WriteAccessParams.cb_getByteOffset;
      }

      [Obsolete]
      private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
      }

      [Obsolete]
      private static Delegate GetSetByteOffset_IHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setByteOffset_I == null)
          TagAccess.WriteAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.WriteAccessParams.n_SetByteOffset_I));
        return TagAccess.WriteAccessParams.cb_setByteOffset_I;
      }

      [Obsolete]
      private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
      }

      [Obsolete("deprecated")]
      public virtual unsafe int ByteOffset
      {
        [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
        {
          return TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMemoryBankHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getMemoryBank == null)
          TagAccess.WriteAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.WriteAccessParams.n_GetMemoryBank));
        return TagAccess.WriteAccessParams.cb_getMemoryBank;
      }

      private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
      }

      private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
          TagAccess.WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.WriteAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
        return TagAccess.WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      }

      private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_memoryBank)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
      }

      public virtual unsafe MEMORY_BANK? MemoryBank
      {
        [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetOffsetHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getOffset == null)
          TagAccess.WriteAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.WriteAccessParams.n_GetOffset));
        return TagAccess.WriteAccessParams.cb_getOffset;
      }

      private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
      }

      private static Delegate GetSetOffset_IHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setOffset_I == null)
          TagAccess.WriteAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.WriteAccessParams.n_SetOffset_I));
        return TagAccess.WriteAccessParams.cb_setOffset_I;
      }

      private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
      }

      public virtual unsafe int Offset
      {
        [Register("getOffset", "()I", "GetGetOffsetHandler")] get
        {
          return TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetStringWriteDataHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getStringWriteData == null)
          TagAccess.WriteAccessParams.cb_getStringWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.WriteAccessParams.n_GetStringWriteData));
        return TagAccess.WriteAccessParams.cb_getStringWriteData;
      }

      private static IntPtr n_GetStringWriteData(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).StringWriteData);
      }

      public virtual unsafe string? StringWriteData
      {
        [Register("getStringWriteData", "()Ljava/lang/String;", "GetGetStringWriteDataHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getStringWriteData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetWriteDataLengthHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getWriteDataLength == null)
          TagAccess.WriteAccessParams.cb_getWriteDataLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.WriteAccessParams.n_GetWriteDataLength));
        return TagAccess.WriteAccessParams.cb_getWriteDataLength;
      }

      private static int n_GetWriteDataLength(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength;
      }

      private static Delegate GetSetWriteDataLength_IHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setWriteDataLength_I == null)
          TagAccess.WriteAccessParams.cb_setWriteDataLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.WriteAccessParams.n_SetWriteDataLength_I));
        return TagAccess.WriteAccessParams.cb_setWriteDataLength_I;
      }

      private static void n_SetWriteDataLength_I(
        IntPtr jnienv,
        IntPtr native__this,
        int writeDataLength)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength = writeDataLength;
      }

      public virtual unsafe int WriteDataLength
      {
        [Register("getWriteDataLength", "()I", "GetGetWriteDataLengthHandler")] get
        {
          return TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getWriteDataLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setWriteDataLength", "(I)V", "GetSetWriteDataLength_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteDataLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetWriteRetriesHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getWriteRetries == null)
          TagAccess.WriteAccessParams.cb_getWriteRetries = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.WriteAccessParams.n_GetWriteRetries));
        return TagAccess.WriteAccessParams.cb_getWriteRetries;
      }

      private static int n_GetWriteRetries(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteRetries;
      }

      private static Delegate GetSetWriteRetries_IHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setWriteRetries_I == null)
          TagAccess.WriteAccessParams.cb_setWriteRetries_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.WriteAccessParams.n_SetWriteRetries_I));
        return TagAccess.WriteAccessParams.cb_setWriteRetries_I;
      }

      private static void n_SetWriteRetries_I(IntPtr jnienv, IntPtr native__this, int writeRetries)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteRetries = writeRetries;
      }

      public virtual unsafe int WriteRetries
      {
        [Register("getWriteRetries", "()I", "GetGetWriteRetriesHandler")] get
        {
          return TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getWriteRetries.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setWriteRetries", "(I)V", "GetSetWriteRetries_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteRetries.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetWriteDataHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_getWriteData == null)
          TagAccess.WriteAccessParams.cb_getWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.WriteAccessParams.n_GetWriteData));
        return TagAccess.WriteAccessParams.cb_getWriteData;
      }

      private static IntPtr n_GetWriteData(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewArray(Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetWriteData());
      }

      [Register("getWriteData", "()[B", "GetGetWriteDataHandler")]
      public virtual unsafe byte[]? GetWriteData()
      {
        JniObjectReference jniObjectReference = TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getWriteData.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }

      [Obsolete]
      private static Delegate GetSetWriteData_arrayBHandler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setWriteData_arrayB == null)
          TagAccess.WriteAccessParams.cb_setWriteData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.WriteAccessParams.n_SetWriteData_arrayB));
        return TagAccess.WriteAccessParams.cb_setWriteData_arrayB;
      }

      [Obsolete]
      private static void n_SetWriteData_arrayB(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_writeData)
      {
        TagAccess.WriteAccessParams writeAccessParams = Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
        byte[] array = (byte[]) JNIEnv.GetArray(native_writeData, (JniHandleOwnership) 0, typeof (byte));
        byte[] writeData = array;
        writeAccessParams.SetWriteData(writeData);
        if (array == null)
          return;
        JNIEnv.CopyArray(array, native_writeData);
      }

      [Obsolete("deprecated")]
      [Register("setWriteData", "([B)V", "GetSetWriteData_arrayBHandler")]
      public virtual unsafe void SetWriteData(byte[]? writeData)
      {
        IntPtr num = JNIEnv.NewArray(writeData);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (writeData != null)
          {
            JNIEnv.CopyArray(num, writeData);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) writeData);
        }
      }

      private static Delegate GetSetWriteData_Ljava_lang_String_Handler()
      {
        if ((object) TagAccess.WriteAccessParams.cb_setWriteData_Ljava_lang_String_ == null)
          TagAccess.WriteAccessParams.cb_setWriteData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.WriteAccessParams.n_SetWriteData_Ljava_lang_String_));
        return TagAccess.WriteAccessParams.cb_setWriteData_Ljava_lang_String_;
      }

      private static void n_SetWriteData_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_writeDataInStringFormat)
      {
        Object.GetObject<TagAccess.WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).SetWriteData(JNIEnv.GetString(native_writeDataInStringFormat, (JniHandleOwnership) 0));
      }

      [Register("setWriteData", "(Ljava/lang/String;)V", "GetSetWriteData_Ljava_lang_String_Handler")]
      public virtual unsafe void SetWriteData(string? writeDataInStringFormat)
      {
        IntPtr num = JNIEnv.NewString(writeDataInStringFormat);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagAccess.WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("com/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams", DoNotGenerateAcw = true)]
    public class WriteSpecificFieldAccessParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagAccess$WriteSpecificFieldAccessParams", typeof (TagAccess.WriteSpecificFieldAccessParams));
      private static Delegate? cb_getAccessPassword;
      private static Delegate? cb_setAccessPassword_J;
      private static Delegate? cb_getStringWriteData;
      private static Delegate? cb_getWriteDataLength;
      private static Delegate? cb_setWriteDataLength_I;
      private static Delegate? cb_getWriteData;
      private static Delegate? cb_setWriteData_arrayB;
      private static Delegate? cb_setWriteData_Ljava_lang_String_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = TagAccess.WriteSpecificFieldAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => TagAccess.WriteSpecificFieldAccessParams._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = TagAccess.WriteSpecificFieldAccessParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => TagAccess.WriteSpecificFieldAccessParams._members.ManagedPeerType;
      }

      protected WriteSpecificFieldAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;)V", "")]
      public unsafe WriteSpecificFieldAccessParams(TagAccess? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/TagAccess;[BIJ)V", "")]
      public unsafe WriteSpecificFieldAccessParams(
        TagAccess? __self,
        byte[]? m_WriteData,
        int m_nWriteDataLength,
        long m_nAccessPassword)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";[BIJ)V";
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewArray(m_WriteData);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(num),
            new JniArgumentValue(m_nWriteDataLength),
            new JniArgumentValue(m_nAccessPassword)
          };
          JniObjectReference instance = TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (m_WriteData != null)
          {
            JNIEnv.CopyArray(num, m_WriteData);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_WriteData);
        }
      }

      private static Delegate GetGetAccessPasswordHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_getAccessPassword == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(TagAccess.WriteSpecificFieldAccessParams.n_GetAccessPassword));
        return TagAccess.WriteSpecificFieldAccessParams.cb_getAccessPassword;
      }

      private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
      }

      private static Delegate GetSetAccessPassword_JHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_setAccessPassword_J == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(TagAccess.WriteSpecificFieldAccessParams.n_SetAccessPassword_J));
        return TagAccess.WriteSpecificFieldAccessParams.cb_setAccessPassword_J;
      }

      private static void n_SetAccessPassword_J(
        IntPtr jnienv,
        IntPtr native__this,
        long accessPassword)
      {
        Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
      }

      public virtual unsafe long AccessPassword
      {
        [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
        {
          return TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetStringWriteDataHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_getStringWriteData == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_getStringWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.WriteSpecificFieldAccessParams.n_GetStringWriteData));
        return TagAccess.WriteSpecificFieldAccessParams.cb_getStringWriteData;
      }

      private static IntPtr n_GetStringWriteData(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).StringWriteData);
      }

      public virtual unsafe string? StringWriteData
      {
        [Register("getStringWriteData", "()Ljava/lang/String;", "GetGetStringWriteDataHandler")] get
        {
          JniObjectReference jniObjectReference = TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getStringWriteData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetWriteDataLengthHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_getWriteDataLength == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_getWriteDataLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagAccess.WriteSpecificFieldAccessParams.n_GetWriteDataLength));
        return TagAccess.WriteSpecificFieldAccessParams.cb_getWriteDataLength;
      }

      private static int n_GetWriteDataLength(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength;
      }

      private static Delegate GetSetWriteDataLength_IHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_setWriteDataLength_I == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_setWriteDataLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagAccess.WriteSpecificFieldAccessParams.n_SetWriteDataLength_I));
        return TagAccess.WriteSpecificFieldAccessParams.cb_setWriteDataLength_I;
      }

      private static void n_SetWriteDataLength_I(
        IntPtr jnienv,
        IntPtr native__this,
        int writeDataLength)
      {
        Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength = writeDataLength;
      }

      public virtual unsafe int WriteDataLength
      {
        [Register("getWriteDataLength", "()I", "GetGetWriteDataLengthHandler")] get
        {
          return TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getWriteDataLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setWriteDataLength", "(I)V", "GetSetWriteDataLength_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteDataLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetWriteDataHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_getWriteData == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_getWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagAccess.WriteSpecificFieldAccessParams.n_GetWriteData));
        return TagAccess.WriteSpecificFieldAccessParams.cb_getWriteData;
      }

      private static IntPtr n_GetWriteData(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewArray(Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetWriteData());
      }

      [Register("getWriteData", "()[B", "GetGetWriteDataHandler")]
      public virtual unsafe byte[]? GetWriteData()
      {
        JniObjectReference jniObjectReference = TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getWriteData.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }

      private static Delegate GetSetWriteData_arrayBHandler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_arrayB == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.WriteSpecificFieldAccessParams.n_SetWriteData_arrayB));
        return TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_arrayB;
      }

      private static void n_SetWriteData_arrayB(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_writeData)
      {
        TagAccess.WriteSpecificFieldAccessParams fieldAccessParams = Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
        byte[] array = (byte[]) JNIEnv.GetArray(native_writeData, (JniHandleOwnership) 0, typeof (byte));
        byte[] writeData = array;
        fieldAccessParams.SetWriteData(writeData);
        if (array == null)
          return;
        JNIEnv.CopyArray(array, native_writeData);
      }

      [Register("setWriteData", "([B)V", "GetSetWriteData_arrayBHandler")]
      public virtual unsafe void SetWriteData(byte[]? writeData)
      {
        IntPtr num = JNIEnv.NewArray(writeData);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (writeData != null)
          {
            JNIEnv.CopyArray(num, writeData);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) writeData);
        }
      }

      private static Delegate GetSetWriteData_Ljava_lang_String_Handler()
      {
        if ((object) TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_Ljava_lang_String_ == null)
          TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagAccess.WriteSpecificFieldAccessParams.n_SetWriteData_Ljava_lang_String_));
        return TagAccess.WriteSpecificFieldAccessParams.cb_setWriteData_Ljava_lang_String_;
      }

      private static void n_SetWriteData_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_writeDataInStringFormat)
      {
        Object.GetObject<TagAccess.WriteSpecificFieldAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).SetWriteData(JNIEnv.GetString(native_writeDataInStringFormat, (JniHandleOwnership) 0));
      }

      [Register("setWriteData", "(Ljava/lang/String;)V", "GetSetWriteData_Ljava_lang_String_Handler")]
      public virtual unsafe void SetWriteData(string? writeDataInStringFormat)
      {
        IntPtr num = JNIEnv.NewString(writeDataInStringFormat);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          TagAccess.WriteSpecificFieldAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }
  }
}
