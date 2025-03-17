// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RegulatoryConfig
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
  [Register("com/zebra/rfid/api3/RegulatoryConfig", DoNotGenerateAcw = true)]
  public class RegulatoryConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RegulatoryConfig", typeof (RegulatoryConfig));
    private static Delegate? cb_isChannelSelectable;
    private static Delegate? cb_setChannelSelectable_Z;
    private static Delegate? cb_isHoppingon;
    private static Delegate? cb_isLBTConfigurable;
    private static Delegate? cb_setLBTConfigurable_Z;
    private static Delegate? cb_getRegion;
    private static Delegate? cb_setRegion_Ljava_lang_String_;
    private static Delegate? cb_getStandardName;
    private static Delegate? cb_setStandardName_Ljava_lang_String_;
    private static Delegate? cb_getEnabledchannels;
    private static Delegate? cb_setEnabledChannels_arrayLjava_lang_String_;
    private static Delegate? cb_setIsHoppingOn_Z;
    private static Delegate? cb_setMaxTransmitPowerLevelValue_I;
    private static Delegate? cb_setMinTransmitPowerLevelValue_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RegulatoryConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RegulatoryConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RegulatoryConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RegulatoryConfig._members.ManagedPeerType;

    protected RegulatoryConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RegulatoryConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RegulatoryConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RegulatoryConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetIsChannelSelectableHandler()
    {
      if ((object) RegulatoryConfig.cb_isChannelSelectable == null)
        RegulatoryConfig.cb_isChannelSelectable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegulatoryConfig.n_IsChannelSelectable));
      return RegulatoryConfig.cb_isChannelSelectable;
    }

    private static bool n_IsChannelSelectable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).ChannelSelectable;
    }

    private static Delegate GetSetChannelSelectable_ZHandler()
    {
      if ((object) RegulatoryConfig.cb_setChannelSelectable_Z == null)
        RegulatoryConfig.cb_setChannelSelectable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RegulatoryConfig.n_SetChannelSelectable_Z));
      return RegulatoryConfig.cb_setChannelSelectable_Z;
    }

    private static void n_SetChannelSelectable_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool selectable)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).ChannelSelectable = selectable;
    }

    public virtual unsafe bool ChannelSelectable
    {
      [Register("isChannelSelectable", "()Z", "GetIsChannelSelectableHandler")] get
      {
        return RegulatoryConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("isChannelSelectable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setChannelSelectable", "(Z)V", "GetSetChannelSelectable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setChannelSelectable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsHoppingonHandler()
    {
      if ((object) RegulatoryConfig.cb_isHoppingon == null)
        RegulatoryConfig.cb_isHoppingon = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegulatoryConfig.n_IsHoppingon));
      return RegulatoryConfig.cb_isHoppingon;
    }

    private static bool n_IsHoppingon(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).IsHoppingon;
    }

    public virtual unsafe bool IsHoppingon
    {
      [Register("isHoppingon", "()Z", "GetIsHoppingonHandler")] get
      {
        return RegulatoryConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("isHoppingon.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsLBTConfigurableHandler()
    {
      if ((object) RegulatoryConfig.cb_isLBTConfigurable == null)
        RegulatoryConfig.cb_isLBTConfigurable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RegulatoryConfig.n_IsLBTConfigurable));
      return RegulatoryConfig.cb_isLBTConfigurable;
    }

    private static bool n_IsLBTConfigurable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).LBTConfigurable;
    }

    private static Delegate GetSetLBTConfigurable_ZHandler()
    {
      if ((object) RegulatoryConfig.cb_setLBTConfigurable_Z == null)
        RegulatoryConfig.cb_setLBTConfigurable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RegulatoryConfig.n_SetLBTConfigurable_Z));
      return RegulatoryConfig.cb_setLBTConfigurable_Z;
    }

    private static void n_SetLBTConfigurable_Z(IntPtr jnienv, IntPtr native__this, bool LBTVal)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).LBTConfigurable = LBTVal;
    }

    public virtual unsafe bool LBTConfigurable
    {
      [Register("isLBTConfigurable", "()Z", "GetIsLBTConfigurableHandler")] get
      {
        return RegulatoryConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("isLBTConfigurable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLBTConfigurable", "(Z)V", "GetSetLBTConfigurable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setLBTConfigurable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetRegionHandler()
    {
      if ((object) RegulatoryConfig.cb_getRegion == null)
        RegulatoryConfig.cb_getRegion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegulatoryConfig.n_GetRegion));
      return RegulatoryConfig.cb_getRegion;
    }

    private static IntPtr n_GetRegion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).Region);
    }

    private static Delegate GetSetRegion_Ljava_lang_String_Handler()
    {
      if ((object) RegulatoryConfig.cb_setRegion_Ljava_lang_String_ == null)
        RegulatoryConfig.cb_setRegion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RegulatoryConfig.n_SetRegion_Ljava_lang_String_));
      return RegulatoryConfig.cb_setRegion_Ljava_lang_String_;
    }

    private static void n_SetRegion_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sRegion)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).Region = JNIEnv.GetString(native_m_sRegion, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Region
    {
      [Register("getRegion", "()Ljava/lang/String;", "GetGetRegionHandler")] get
      {
        JniObjectReference jniObjectReference = RegulatoryConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getRegion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setRegion", "(Ljava/lang/String;)V", "GetSetRegion_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setRegion.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetStandardNameHandler()
    {
      if ((object) RegulatoryConfig.cb_getStandardName == null)
        RegulatoryConfig.cb_getStandardName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegulatoryConfig.n_GetStandardName));
      return RegulatoryConfig.cb_getStandardName;
    }

    private static IntPtr n_GetStandardName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).StandardName);
    }

    private static Delegate GetSetStandardName_Ljava_lang_String_Handler()
    {
      if ((object) RegulatoryConfig.cb_setStandardName_Ljava_lang_String_ == null)
        RegulatoryConfig.cb_setStandardName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RegulatoryConfig.n_SetStandardName_Ljava_lang_String_));
      return RegulatoryConfig.cb_setStandardName_Ljava_lang_String_;
    }

    private static void n_SetStandardName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_standardName)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).StandardName = JNIEnv.GetString(native_standardName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? StandardName
    {
      [Register("getStandardName", "()Ljava/lang/String;", "GetGetStandardNameHandler")] get
      {
        JniObjectReference jniObjectReference = RegulatoryConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getStandardName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setStandardName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetEnabledchannelsHandler()
    {
      if ((object) RegulatoryConfig.cb_getEnabledchannels == null)
        RegulatoryConfig.cb_getEnabledchannels = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RegulatoryConfig.n_GetEnabledchannels));
      return RegulatoryConfig.cb_getEnabledchannels;
    }

    private static IntPtr n_GetEnabledchannels(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).GetEnabledchannels());
    }

    [Register("getEnabledchannels", "()[Ljava/lang/String;", "GetGetEnabledchannelsHandler")]
    public virtual unsafe string[]? GetEnabledchannels()
    {
      JniObjectReference jniObjectReference = RegulatoryConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getEnabledchannels.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }

    private static Delegate GetSetEnabledChannels_arrayLjava_lang_String_Handler()
    {
      if ((object) RegulatoryConfig.cb_setEnabledChannels_arrayLjava_lang_String_ == null)
        RegulatoryConfig.cb_setEnabledChannels_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RegulatoryConfig.n_SetEnabledChannels_arrayLjava_lang_String_));
      return RegulatoryConfig.cb_setEnabledChannels_arrayLjava_lang_String_;
    }

    private static void n_SetEnabledChannels_arrayLjava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_EnabledChannels)
    {
      RegulatoryConfig regulatoryConfig = Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0);
      string[] array = (string[]) JNIEnv.GetArray(native_m_EnabledChannels, (JniHandleOwnership) 0, typeof (string));
      string[] m_EnabledChannels = array;
      regulatoryConfig.SetEnabledChannels(m_EnabledChannels);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_m_EnabledChannels);
    }

    [Register("setEnabledChannels", "([Ljava/lang/String;)V", "GetSetEnabledChannels_arrayLjava_lang_String_Handler")]
    public virtual unsafe void SetEnabledChannels(string[]? m_EnabledChannels)
    {
      IntPtr num = JNIEnv.NewArray(m_EnabledChannels);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEnabledChannels.([Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_EnabledChannels != null)
        {
          JNIEnv.CopyArray(num, m_EnabledChannels);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_EnabledChannels);
      }
    }

    private static Delegate GetSetIsHoppingOn_ZHandler()
    {
      if ((object) RegulatoryConfig.cb_setIsHoppingOn_Z == null)
        RegulatoryConfig.cb_setIsHoppingOn_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RegulatoryConfig.n_SetIsHoppingOn_Z));
      return RegulatoryConfig.cb_setIsHoppingOn_Z;
    }

    private static void n_SetIsHoppingOn_Z(IntPtr jnienv, IntPtr native__this, bool m_bIsHoppingOn)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetIsHoppingOn(m_bIsHoppingOn);
    }

    [Register("setIsHoppingOn", "(Z)V", "GetSetIsHoppingOn_ZHandler")]
    public virtual unsafe void SetIsHoppingOn(bool m_bIsHoppingOn)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(m_bIsHoppingOn)
      };
      RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIsHoppingOn.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetMaxTransmitPowerLevelValue_IHandler()
    {
      if ((object) RegulatoryConfig.cb_setMaxTransmitPowerLevelValue_I == null)
        RegulatoryConfig.cb_setMaxTransmitPowerLevelValue_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RegulatoryConfig.n_SetMaxTransmitPowerLevelValue_I));
      return RegulatoryConfig.cb_setMaxTransmitPowerLevelValue_I;
    }

    private static void n_SetMaxTransmitPowerLevelValue_I(
      IntPtr jnienv,
      IntPtr native__this,
      int maxTransmitPowerLevelValue)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetMaxTransmitPowerLevelValue(maxTransmitPowerLevelValue);
    }

    [Register("setMaxTransmitPowerLevelValue", "(I)V", "GetSetMaxTransmitPowerLevelValue_IHandler")]
    public virtual unsafe void SetMaxTransmitPowerLevelValue(int maxTransmitPowerLevelValue)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(maxTransmitPowerLevelValue)
      };
      RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxTransmitPowerLevelValue.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetMinTransmitPowerLevelValue_IHandler()
    {
      if ((object) RegulatoryConfig.cb_setMinTransmitPowerLevelValue_I == null)
        RegulatoryConfig.cb_setMinTransmitPowerLevelValue_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RegulatoryConfig.n_SetMinTransmitPowerLevelValue_I));
      return RegulatoryConfig.cb_setMinTransmitPowerLevelValue_I;
    }

    private static void n_SetMinTransmitPowerLevelValue_I(
      IntPtr jnienv,
      IntPtr native__this,
      int minTransmitPowerLevelValue)
    {
      Object.GetObject<RegulatoryConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetMinTransmitPowerLevelValue(minTransmitPowerLevelValue);
    }

    [Register("setMinTransmitPowerLevelValue", "(I)V", "GetSetMinTransmitPowerLevelValue_IHandler")]
    public virtual unsafe void SetMinTransmitPowerLevelValue(int minTransmitPowerLevelValue)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(minTransmitPowerLevelValue)
      };
      RegulatoryConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setMinTransmitPowerLevelValue.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
