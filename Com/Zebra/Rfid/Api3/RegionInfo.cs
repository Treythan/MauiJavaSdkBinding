// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RegionInfo
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
  [Register("com/zebra/rfid/api3/RegionInfo", DoNotGenerateAcw = true)]
  public class RegionInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RegionInfo", typeof (RegionInfo));
    private static Delegate? cb_isChannelSelectable;
    private static Delegate? cb_setChannelSelectable_Z;
    private static Delegate? cb_isHoppingConfigurable;
    private static Delegate? cb_isLBTConfigurable;
    private static Delegate? cb_setLBTConfigurable_Z;
    private static Delegate? cb_getName;
    private static Delegate? cb_getRegionCode;
    private static Delegate? cb_getStandardName;
    private static Delegate? cb_setStandardName_Ljava_lang_String_;
    private static Delegate? cb_getSupportedChannels;

    [Register("isChannelSelectable")]
    protected bool IsChannelSelectable
    {
      get
      {
        return RegionInfo._members.InstanceFields.GetBooleanValue("isChannelSelectable.Z", (IJavaPeerable) this);
      }
      set
      {
        RegionInfo._members.InstanceFields.SetValue("isChannelSelectable.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("isLBTConfigurable")]
    protected bool IsLBTConfigurable
    {
      get
      {
        return RegionInfo._members.InstanceFields.GetBooleanValue("isLBTConfigurable.Z", (IJavaPeerable) this);
      }
      set
      {
        RegionInfo._members.InstanceFields.SetValue("isLBTConfigurable.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_bHoppingConfigurable")]
    protected bool MBHoppingConfigurable
    {
      get
      {
        return RegionInfo._members.InstanceFields.GetBooleanValue("m_bHoppingConfigurable.Z", (IJavaPeerable) this);
      }
      set
      {
        RegionInfo._members.InstanceFields.SetValue("m_bHoppingConfigurable.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("m_communicationStandardCode")]
    protected int MCommunicationStandardCode
    {
      get
      {
        return RegionInfo._members.InstanceFields.GetInt32Value("m_communicationStandardCode.I", (IJavaPeerable) this);
      }
      set
      {
        RegionInfo._members.InstanceFields.SetValue("m_communicationStandardCode.I", (IJavaPeerable) this, value);
      }
    }

    [Register("m_index")]
    protected int MIndex
    {
      get => RegionInfo._members.InstanceFields.GetInt32Value("m_index.I", (IJavaPeerable) this);
      set => RegionInfo._members.InstanceFields.SetValue("m_index.I", (IJavaPeerable) this, value);
    }

    [Register("m_regulatoryDomainCode")]
    protected int MRegulatoryDomainCode
    {
      get
      {
        return RegionInfo._members.InstanceFields.GetInt32Value("m_regulatoryDomainCode.I", (IJavaPeerable) this);
      }
      set
      {
        RegionInfo._members.InstanceFields.SetValue("m_regulatoryDomainCode.I", (IJavaPeerable) this, value);
      }
    }

    [Register("m_skuId")]
    protected string? MSkuId
    {
      get
      {
        JniObjectReference objectValue = RegionInfo._members.InstanceFields.GetObjectValue("m_skuId.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          RegionInfo._members.InstanceFields.SetValue("m_skuId.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_sName")]
    protected string? MSName
    {
      get
      {
        JniObjectReference objectValue = RegionInfo._members.InstanceFields.GetObjectValue("m_sName.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          RegionInfo._members.InstanceFields.SetValue("m_sName.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_sRegionCode")]
    protected string? MSRegionCode
    {
      get
      {
        JniObjectReference objectValue = RegionInfo._members.InstanceFields.GetObjectValue("m_sRegionCode.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          RegionInfo._members.InstanceFields.SetValue("m_sRegionCode.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("m_SupportedChannels")]
    protected IList<string>? MSupportedChannels
    {
      get
      {
        JniObjectReference objectValue = RegionInfo._members.InstanceFields.GetObjectValue("m_SupportedChannels.[Ljava/lang/String;", (IJavaPeerable) this);
        return (IList<string>) JavaArray<string>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<string>.ToLocalJniHandle(value);
        try
        {
          RegionInfo._members.InstanceFields.SetValue("m_SupportedChannels.[Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("m_userNVM")]
    protected int MUserNVM
    {
      get => RegionInfo._members.InstanceFields.GetInt32Value("m_userNVM.I", (IJavaPeerable) this);
      set
      {
        RegionInfo._members.InstanceFields.SetValue("m_userNVM.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RegionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RegionInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RegionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RegionInfo._members.ManagedPeerType;

    protected RegionInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RegionInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RegionInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RegionInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetIsChannelSelectableHandler()
    {
      if ((object) RegionInfo.cb_isChannelSelectable == null)
        RegionInfo.cb_isChannelSelectable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegionInfo.n_IsChannelSelectable));
      return RegionInfo.cb_isChannelSelectable;
    }

    private static bool n_IsChannelSelectable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).ChannelSelectable;
    }

    private static Delegate GetSetChannelSelectable_ZHandler()
    {
      if ((object) RegionInfo.cb_setChannelSelectable_Z == null)
        RegionInfo.cb_setChannelSelectable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RegionInfo.n_SetChannelSelectable_Z));
      return RegionInfo.cb_setChannelSelectable_Z;
    }

    private static void n_SetChannelSelectable_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool selectable)
    {
      Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).ChannelSelectable = selectable;
    }

    public virtual unsafe bool ChannelSelectable
    {
      [Register("isChannelSelectable", "()Z", "GetIsChannelSelectableHandler")] get
      {
        return RegionInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isChannelSelectable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setChannelSelectable", "(Z)V", "GetSetChannelSelectable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RegionInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setChannelSelectable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsHoppingConfigurableHandler()
    {
      if ((object) RegionInfo.cb_isHoppingConfigurable == null)
        RegionInfo.cb_isHoppingConfigurable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegionInfo.n_IsHoppingConfigurable));
      return RegionInfo.cb_isHoppingConfigurable;
    }

    private static bool n_IsHoppingConfigurable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).IsHoppingConfigurable;
    }

    public virtual unsafe bool IsHoppingConfigurable
    {
      [Register("isHoppingConfigurable", "()Z", "GetIsHoppingConfigurableHandler")] get
      {
        return RegionInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isHoppingConfigurable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsLBTConfigurableHandler()
    {
      if ((object) RegionInfo.cb_isLBTConfigurable == null)
        RegionInfo.cb_isLBTConfigurable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegionInfo.n_IsLBTConfigurable));
      return RegionInfo.cb_isLBTConfigurable;
    }

    private static bool n_IsLBTConfigurable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).LBTConfigurable;
    }

    private static Delegate GetSetLBTConfigurable_ZHandler()
    {
      if ((object) RegionInfo.cb_setLBTConfigurable_Z == null)
        RegionInfo.cb_setLBTConfigurable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RegionInfo.n_SetLBTConfigurable_Z));
      return RegionInfo.cb_setLBTConfigurable_Z;
    }

    private static void n_SetLBTConfigurable_Z(IntPtr jnienv, IntPtr native__this, bool LBTVal)
    {
      Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).LBTConfigurable = LBTVal;
    }

    public virtual unsafe bool LBTConfigurable
    {
      [Register("isLBTConfigurable", "()Z", "GetIsLBTConfigurableHandler")] get
      {
        return RegionInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isLBTConfigurable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLBTConfigurable", "(Z)V", "GetSetLBTConfigurable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RegionInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setLBTConfigurable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNameHandler()
    {
      if ((object) RegionInfo.cb_getName == null)
        RegionInfo.cb_getName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegionInfo.n_GetName));
      return RegionInfo.cb_getName;
    }

    private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).Name);
    }

    public virtual unsafe string? Name
    {
      [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get
      {
        JniObjectReference jniObjectReference = RegionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRegionCodeHandler()
    {
      if ((object) RegionInfo.cb_getRegionCode == null)
        RegionInfo.cb_getRegionCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegionInfo.n_GetRegionCode));
      return RegionInfo.cb_getRegionCode;
    }

    private static IntPtr n_GetRegionCode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).RegionCode);
    }

    public virtual unsafe string? RegionCode
    {
      [Register("getRegionCode", "()Ljava/lang/String;", "GetGetRegionCodeHandler")] get
      {
        JniObjectReference jniObjectReference = RegionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getRegionCode.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStandardNameHandler()
    {
      if ((object) RegionInfo.cb_getStandardName == null)
        RegionInfo.cb_getStandardName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegionInfo.n_GetStandardName));
      return RegionInfo.cb_getStandardName;
    }

    private static IntPtr n_GetStandardName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).StandardName);
    }

    private static Delegate GetSetStandardName_Ljava_lang_String_Handler()
    {
      if ((object) RegionInfo.cb_setStandardName_Ljava_lang_String_ == null)
        RegionInfo.cb_setStandardName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RegionInfo.n_SetStandardName_Ljava_lang_String_));
      return RegionInfo.cb_setStandardName_Ljava_lang_String_;
    }

    private static void n_SetStandardName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_standardName)
    {
      Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).StandardName = JNIEnv.GetString(native_standardName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? StandardName
    {
      [Register("getStandardName", "()Ljava/lang/String;", "GetGetStandardNameHandler")] get
      {
        JniObjectReference jniObjectReference = RegionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getStandardName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setStandardName", "(Ljava/lang/String;)V", "GetSetStandardName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RegionInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setStandardName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetSupportedChannelsHandler()
    {
      if ((object) RegionInfo.cb_getSupportedChannels == null)
        RegionInfo.cb_getSupportedChannels = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegionInfo.n_GetSupportedChannels));
      return RegionInfo.cb_getSupportedChannels;
    }

    private static IntPtr n_GetSupportedChannels(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<RegionInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetSupportedChannels());
    }

    [Register("getSupportedChannels", "()[Ljava/lang/String;", "GetGetSupportedChannelsHandler")]
    public virtual unsafe string[]? GetSupportedChannels()
    {
      JniObjectReference jniObjectReference = RegionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportedChannels.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }
  }
}
