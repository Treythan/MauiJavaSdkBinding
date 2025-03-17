// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CommunicationStandardInfo
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/CommunicationStandardInfo", DoNotGenerateAcw = true)]
  public class CommunicationStandardInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CommunicationStandardInfo", typeof (CommunicationStandardInfo));
    private static Delegate? cb_getIsHoppingConfigurable;
    private static Delegate? cb_getRegionName;
    private static Delegate? cb_getStandardName;
    private static Delegate? cb_getChannelFrequencyValueList;
    private static Delegate? cb_getChannelIndexList;

    [Register("m_bIsHoppingConfigurable")]
    public bool MBIsHoppingConfigurable
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetBooleanValue("m_bIsHoppingConfigurable.Z", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_bIsHoppingConfigurable.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_ChannelFrequencyValueList")]
    public IList<int>? MChannelFrequencyValueList
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_ChannelFrequencyValueList.[I", (IJavaPeerable) this);
        return (IList<int>) JavaArray<int>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<int>.ToLocalJniHandle(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_ChannelFrequencyValueList.[I", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("m_ChannelIndexList")]
    public IList<int>? MChannelIndexList
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_ChannelIndexList.[I", (IJavaPeerable) this);
        return (IList<int>) JavaArray<int>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<int>.ToLocalJniHandle(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_ChannelIndexList.[I", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("m_CommSTDCode")]
    protected int MCommSTDCode
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt32Value("m_CommSTDCode.I", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_CommSTDCode.I", (IJavaPeerable) this, value);
      }
    }

    [Register("m_MaxPower")]
    protected short MMaxPower
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt16Value("m_MaxPower.S", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_MaxPower.S", (IJavaPeerable) this, value);
      }
    }

    [Register("m_msMaxOffTime")]
    protected short MMsMaxOffTime
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt16Value("m_msMaxOffTime.S", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_msMaxOffTime.S", (IJavaPeerable) this, value);
      }
    }

    [Register("m_msMaxOnTime")]
    protected short MMsMaxOnTime
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt16Value("m_msMaxOnTime.S", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_msMaxOnTime.S", (IJavaPeerable) this, value);
      }
    }

    [Register("m_NoHopChannelOffTime")]
    protected short MNoHopChannelOffTime
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt16Value("m_NoHopChannelOffTime.S", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_NoHopChannelOffTime.S", (IJavaPeerable) this, value);
      }
    }

    [Register("m_RegulatoryCode")]
    protected int MRegulatoryCode
    {
      get
      {
        return CommunicationStandardInfo._members.InstanceFields.GetInt32Value("m_RegulatoryCode.I", (IJavaPeerable) this);
      }
      set
      {
        CommunicationStandardInfo._members.InstanceFields.SetValue("m_RegulatoryCode.I", (IJavaPeerable) this, value);
      }
    }

    [Register("m_sCodeName")]
    public string? MSCodeName
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_sCodeName.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_sCodeName.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_sCountry")]
    public string? MSCountry
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_sCountry.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_sCountry.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_sRregionName")]
    public string? MSRregionName
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_sRregionName.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_sRregionName.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_sStandardName")]
    public string? MSStandardName
    {
      get
      {
        JniObjectReference objectValue = CommunicationStandardInfo._members.InstanceFields.GetObjectValue("m_sStandardName.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          CommunicationStandardInfo._members.InstanceFields.SetValue("m_sStandardName.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CommunicationStandardInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CommunicationStandardInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CommunicationStandardInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CommunicationStandardInfo._members.ManagedPeerType;

    protected CommunicationStandardInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe CommunicationStandardInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = CommunicationStandardInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      CommunicationStandardInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetIsHoppingConfigurableHandler()
    {
      if ((object) CommunicationStandardInfo.cb_getIsHoppingConfigurable == null)
        CommunicationStandardInfo.cb_getIsHoppingConfigurable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommunicationStandardInfo.n_GetIsHoppingConfigurable));
      return CommunicationStandardInfo.cb_getIsHoppingConfigurable;
    }

    private static bool n_GetIsHoppingConfigurable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommunicationStandardInfo>(jnienv, native__this, (JniHandleOwnership) 0).IsHoppingConfigurable;
    }

    public virtual unsafe bool IsHoppingConfigurable
    {
      [Register("getIsHoppingConfigurable", "()Z", "GetGetIsHoppingConfigurableHandler")] get
      {
        return CommunicationStandardInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getIsHoppingConfigurable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRegionNameHandler()
    {
      if ((object) CommunicationStandardInfo.cb_getRegionName == null)
        CommunicationStandardInfo.cb_getRegionName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommunicationStandardInfo.n_GetRegionName));
      return CommunicationStandardInfo.cb_getRegionName;
    }

    private static IntPtr n_GetRegionName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<CommunicationStandardInfo>(jnienv, native__this, (JniHandleOwnership) 0).RegionName);
    }

    public virtual unsafe string? RegionName
    {
      [Register("getRegionName", "()Ljava/lang/String;", "GetGetRegionNameHandler")] get
      {
        JniObjectReference jniObjectReference = CommunicationStandardInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getRegionName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStandardNameHandler()
    {
      if ((object) CommunicationStandardInfo.cb_getStandardName == null)
        CommunicationStandardInfo.cb_getStandardName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommunicationStandardInfo.n_GetStandardName));
      return CommunicationStandardInfo.cb_getStandardName;
    }

    private static IntPtr n_GetStandardName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<CommunicationStandardInfo>(jnienv, native__this, (JniHandleOwnership) 0).StandardName);
    }

    public virtual unsafe string? StandardName
    {
      [Register("getStandardName", "()Ljava/lang/String;", "GetGetStandardNameHandler")] get
      {
        JniObjectReference jniObjectReference = CommunicationStandardInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getStandardName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetChannelFrequencyValueListHandler()
    {
      if ((object) CommunicationStandardInfo.cb_getChannelFrequencyValueList == null)
        CommunicationStandardInfo.cb_getChannelFrequencyValueList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommunicationStandardInfo.n_GetChannelFrequencyValueList));
      return CommunicationStandardInfo.cb_getChannelFrequencyValueList;
    }

    private static IntPtr n_GetChannelFrequencyValueList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<CommunicationStandardInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetChannelFrequencyValueList());
    }

    [Register("getChannelFrequencyValueList", "()[I", "GetGetChannelFrequencyValueListHandler")]
    public virtual unsafe int[]? GetChannelFrequencyValueList()
    {
      JniObjectReference jniObjectReference = CommunicationStandardInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getChannelFrequencyValueList.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }

    private static Delegate GetGetChannelIndexListHandler()
    {
      if ((object) CommunicationStandardInfo.cb_getChannelIndexList == null)
        CommunicationStandardInfo.cb_getChannelIndexList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommunicationStandardInfo.n_GetChannelIndexList));
      return CommunicationStandardInfo.cb_getChannelIndexList;
    }

    private static IntPtr n_GetChannelIndexList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<CommunicationStandardInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetChannelIndexList());
    }

    [Register("getChannelIndexList", "()[I", "GetGetChannelIndexListHandler")]
    public virtual unsafe int[]? GetChannelIndexList()
    {
      JniObjectReference jniObjectReference = CommunicationStandardInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getChannelIndexList.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }
  }
}
