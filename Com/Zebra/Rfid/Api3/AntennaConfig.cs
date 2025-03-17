// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.AntennaConfig
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
  [Register("com/zebra/rfid/api3/AntennaConfig", DoNotGenerateAcw = true)]
  public class AntennaConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/AntennaConfig", typeof (AntennaConfig));
    private static Delegate? cb_getAntennaId;
    private static Delegate? cb_setAntennaId_I;
    private static Delegate? cb_getAntennaRfConfig;
    private static Delegate? cb_setAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_;
    private static Delegate? cb_getPrefilterList;
    private static Delegate? cb_setPrefilterList_Lcom_zebra_rfid_api3_PreFilters_;
    private static Delegate? cb_getSingulationControl;
    private static Delegate? cb_setSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = AntennaConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => AntennaConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = AntennaConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => AntennaConfig._members.ManagedPeerType;

    protected AntennaConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(I)V", "")]
    public unsafe AntennaConfig(int antennaId)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaId)
      };
      JniObjectReference instance = AntennaConfig._members.InstanceMethods.StartCreateInstance("(I)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      AntennaConfig._members.InstanceMethods.FinishCreateInstance("(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register(".ctor", "(ILcom/zebra/rfid/api3/PreFilters;Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", "")]
    public unsafe AntennaConfig(
      int antennaId,
      PreFilters? preFilters,
      Antennas.AntennaRfConfig? antennaRfConfig,
      Antennas.SingulationControl? singulationControl)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(antennaId),
          new JniArgumentValue(preFilters == null ? IntPtr.Zero : preFilters.Handle),
          new JniArgumentValue(antennaRfConfig == null ? IntPtr.Zero : antennaRfConfig.Handle),
          new JniArgumentValue(singulationControl == null ? IntPtr.Zero : singulationControl.Handle)
        };
        JniObjectReference instance = AntennaConfig._members.InstanceMethods.StartCreateInstance("(ILcom/zebra/rfid/api3/PreFilters;Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        AntennaConfig._members.InstanceMethods.FinishCreateInstance("(ILcom/zebra/rfid/api3/PreFilters;Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) preFilters);
        GC.KeepAlive((object) antennaRfConfig);
        GC.KeepAlive((object) singulationControl);
      }
    }

    private static Delegate GetGetAntennaIdHandler()
    {
      if ((object) AntennaConfig.cb_getAntennaId == null)
        AntennaConfig.cb_getAntennaId = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(AntennaConfig.n_GetAntennaId));
      return AntennaConfig.cb_getAntennaId;
    }

    private static int n_GetAntennaId(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaId;
    }

    private static Delegate GetSetAntennaId_IHandler()
    {
      if ((object) AntennaConfig.cb_setAntennaId_I == null)
        AntennaConfig.cb_setAntennaId_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(AntennaConfig.n_SetAntennaId_I));
      return AntennaConfig.cb_setAntennaId_I;
    }

    private static void n_SetAntennaId_I(IntPtr jnienv, IntPtr native__this, int m_AntennaId)
    {
      Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaId = m_AntennaId;
    }

    public virtual unsafe int AntennaId
    {
      [Register("getAntennaId", "()I", "GetGetAntennaIdHandler")] get
      {
        return AntennaConfig._members.InstanceMethods.InvokeVirtualInt32Method("getAntennaId.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAntennaId", "(I)V", "GetSetAntennaId_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        AntennaConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaId.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetAntennaRfConfigHandler()
    {
      if ((object) AntennaConfig.cb_getAntennaRfConfig == null)
        AntennaConfig.cb_getAntennaRfConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AntennaConfig.n_GetAntennaRfConfig));
      return AntennaConfig.cb_getAntennaRfConfig;
    }

    private static IntPtr n_GetAntennaRfConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaRfConfig);
    }

    private static Delegate GetSetAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Handler()
    {
      if ((object) AntennaConfig.cb_setAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_ == null)
        AntennaConfig.cb_setAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AntennaConfig.n_SetAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_));
      return AntennaConfig.cb_setAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_;
    }

    private static void n_SetAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_AntennaRfConfig)
    {
      Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaRfConfig = Object.GetObject<Antennas.AntennaRfConfig>(native_m_AntennaRfConfig, (JniHandleOwnership) 0);
    }

    public virtual unsafe Antennas.AntennaRfConfig? AntennaRfConfig
    {
      [Register("getAntennaRfConfig", "()Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;", "GetGetAntennaRfConfigHandler")] get
      {
        JniObjectReference jniObjectReference = AntennaConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaRfConfig.()Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Antennas.AntennaRfConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAntennaRfConfig", "(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;)V", "GetSetAntennaRfConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          AntennaConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaRfConfig.(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetPrefilterListHandler()
    {
      if ((object) AntennaConfig.cb_getPrefilterList == null)
        AntennaConfig.cb_getPrefilterList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AntennaConfig.n_GetPrefilterList));
      return AntennaConfig.cb_getPrefilterList;
    }

    private static IntPtr n_GetPrefilterList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrefilterList);
    }

    private static Delegate GetSetPrefilterList_Lcom_zebra_rfid_api3_PreFilters_Handler()
    {
      if ((object) AntennaConfig.cb_setPrefilterList_Lcom_zebra_rfid_api3_PreFilters_ == null)
        AntennaConfig.cb_setPrefilterList_Lcom_zebra_rfid_api3_PreFilters_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AntennaConfig.n_SetPrefilterList_Lcom_zebra_rfid_api3_PreFilters_));
      return AntennaConfig.cb_setPrefilterList_Lcom_zebra_rfid_api3_PreFilters_;
    }

    private static void n_SetPrefilterList_Lcom_zebra_rfid_api3_PreFilters_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_PrefilterList)
    {
      Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).PrefilterList = Object.GetObject<PreFilters>(native_m_PrefilterList, (JniHandleOwnership) 0);
    }

    public virtual unsafe PreFilters? PrefilterList
    {
      [Register("getPrefilterList", "()Lcom/zebra/rfid/api3/PreFilters;", "GetGetPrefilterListHandler")] get
      {
        JniObjectReference jniObjectReference = AntennaConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getPrefilterList.()Lcom/zebra/rfid/api3/PreFilters;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<PreFilters>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPrefilterList", "(Lcom/zebra/rfid/api3/PreFilters;)V", "GetSetPrefilterList_Lcom_zebra_rfid_api3_PreFilters_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          AntennaConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPrefilterList.(Lcom/zebra/rfid/api3/PreFilters;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetSingulationControlHandler()
    {
      if ((object) AntennaConfig.cb_getSingulationControl == null)
        AntennaConfig.cb_getSingulationControl = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AntennaConfig.n_GetSingulationControl));
      return AntennaConfig.cb_getSingulationControl;
    }

    private static IntPtr n_GetSingulationControl(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).SingulationControl);
    }

    private static Delegate GetSetSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Handler()
    {
      if ((object) AntennaConfig.cb_setSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_ == null)
        AntennaConfig.cb_setSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AntennaConfig.n_SetSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_));
      return AntennaConfig.cb_setSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_;
    }

    private static void n_SetSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_SingulationControl)
    {
      Object.GetObject<AntennaConfig>(jnienv, native__this, (JniHandleOwnership) 0).SingulationControl = Object.GetObject<Antennas.SingulationControl>(native_m_SingulationControl, (JniHandleOwnership) 0);
    }

    public virtual unsafe Antennas.SingulationControl? SingulationControl
    {
      [Register("getSingulationControl", "()Lcom/zebra/rfid/api3/Antennas$SingulationControl;", "GetGetSingulationControlHandler")] get
      {
        JniObjectReference jniObjectReference = AntennaConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getSingulationControl.()Lcom/zebra/rfid/api3/Antennas$SingulationControl;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Antennas.SingulationControl>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setSingulationControl", "(Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", "GetSetSingulationControl_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          AntennaConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setSingulationControl.(Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }
  }
}
