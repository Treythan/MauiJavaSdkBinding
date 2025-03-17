// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Antennas
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
  [Register("com/zebra/rfid/api3/Antennas", DoNotGenerateAcw = true)]
  public class Antennas : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas", typeof (Antennas));
    private static Delegate? cb_getLength;
    private static Delegate? cb_AntennaProperties_I;
    private static Delegate? cb_getAntennaConfig_I;
    private static Delegate? cb_getAntennaRfConfig_I;
    private static Delegate? cb_getAvailableAntennas;
    private static Delegate? cb_getPhysicalProperties_I;
    private static Delegate? cb_getRFMode_I;
    private static Delegate? cb_getSingulationControl_I;
    private static Delegate? cb_setAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_;
    private static Delegate? cb_setAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_;
    private static Delegate? cb_setRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_;
    private static Delegate? cb_setSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Antennas._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Antennas._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Antennas._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Antennas._members.ManagedPeerType;

    protected Antennas(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetLengthHandler()
    {
      if ((object) Antennas.cb_getLength == null)
        Antennas.cb_getLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.n_GetLength));
      return Antennas.cb_getLength;
    }

    private static int n_GetLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).Length;
    }

    public virtual unsafe int Length
    {
      [Register("getLength", "()I", "GetGetLengthHandler")] get
      {
        return Antennas._members.InstanceMethods.InvokeVirtualInt32Method("getLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetInvokeAntennaProperties_IHandler()
    {
      if ((object) Antennas.cb_AntennaProperties_I == null)
        Antennas.cb_AntennaProperties_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_InvokeAntennaProperties_I));
      return Antennas.cb_AntennaProperties_I;
    }

    private static IntPtr n_InvokeAntennaProperties_I(
      IntPtr jnienv,
      IntPtr native__this,
      int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).InvokeAntennaProperties(index));
    }

    [Register("AntennaProperties", "(I)Lcom/zebra/rfid/api3/Antennas$AntennaProperties;", "GetInvokeAntennaProperties_IHandler")]
    public virtual unsafe Antennas.AntennaProperties? InvokeAntennaProperties(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("AntennaProperties.(I)Lcom/zebra/rfid/api3/Antennas$AntennaProperties;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.AntennaProperties>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetAntennaConfig_IHandler()
    {
      if ((object) Antennas.cb_getAntennaConfig_I == null)
        Antennas.cb_getAntennaConfig_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_GetAntennaConfig_I));
      return Antennas.cb_getAntennaConfig_I;
    }

    private static IntPtr n_GetAntennaConfig_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetAntennaConfig(antennaIndex));
    }

    [Register("getAntennaConfig", "(I)Lcom/zebra/rfid/api3/Antennas$Config;", "GetGetAntennaConfig_IHandler")]
    public virtual unsafe Antennas.Config? GetAntennaConfig(int antennaIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaIndex)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaConfig.(I)Lcom/zebra/rfid/api3/Antennas$Config;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.Config>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetAntennaRfConfig_IHandler()
    {
      if ((object) Antennas.cb_getAntennaRfConfig_I == null)
        Antennas.cb_getAntennaRfConfig_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_GetAntennaRfConfig_I));
      return Antennas.cb_getAntennaRfConfig_I;
    }

    private static IntPtr n_GetAntennaRfConfig_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetAntennaRfConfig(antennaIndex));
    }

    [Register("getAntennaRfConfig", "(I)Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;", "GetGetAntennaRfConfig_IHandler")]
    public virtual unsafe Antennas.AntennaRfConfig? GetAntennaRfConfig(int antennaIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaIndex)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaRfConfig.(I)Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.AntennaRfConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetAvailableAntennasHandler()
    {
      if ((object) Antennas.cb_getAvailableAntennas == null)
        Antennas.cb_getAvailableAntennas = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.n_GetAvailableAntennas));
      return Antennas.cb_getAvailableAntennas;
    }

    private static IntPtr n_GetAvailableAntennas(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetAvailableAntennas());
    }

    [Register("getAvailableAntennas", "()[S", "GetGetAvailableAntennasHandler")]
    public virtual unsafe short[]? GetAvailableAntennas()
    {
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getAvailableAntennas.()[S", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (short[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (short));
    }

    private static Delegate GetGetPhysicalProperties_IHandler()
    {
      if ((object) Antennas.cb_getPhysicalProperties_I == null)
        Antennas.cb_getPhysicalProperties_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_GetPhysicalProperties_I));
      return Antennas.cb_getPhysicalProperties_I;
    }

    private static IntPtr n_GetPhysicalProperties_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetPhysicalProperties(antennaIndex));
    }

    [Register("getPhysicalProperties", "(I)Lcom/zebra/rfid/api3/Antennas$PhysicalProperties;", "GetGetPhysicalProperties_IHandler")]
    public virtual unsafe Antennas.PhysicalProperties? GetPhysicalProperties(int antennaIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaIndex)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getPhysicalProperties.(I)Lcom/zebra/rfid/api3/Antennas$PhysicalProperties;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.PhysicalProperties>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetRFMode_IHandler()
    {
      if ((object) Antennas.cb_getRFMode_I == null)
        Antennas.cb_getRFMode_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_GetRFMode_I));
      return Antennas.cb_getRFMode_I;
    }

    private static IntPtr n_GetRFMode_I(IntPtr jnienv, IntPtr native__this, int antennaIndex)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetRFMode(antennaIndex));
    }

    [Register("getRFMode", "(I)Lcom/zebra/rfid/api3/Antennas$RFMode;", "GetGetRFMode_IHandler")]
    public virtual unsafe Antennas.RFMode? GetRFMode(int antennaIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaIndex)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getRFMode.(I)Lcom/zebra/rfid/api3/Antennas$RFMode;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.RFMode>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetSingulationControl_IHandler()
    {
      if ((object) Antennas.cb_getSingulationControl_I == null)
        Antennas.cb_getSingulationControl_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Antennas.n_GetSingulationControl_I));
      return Antennas.cb_getSingulationControl_I;
    }

    private static IntPtr n_GetSingulationControl_I(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0).GetSingulationControl(antennaIndex));
    }

    [Register("getSingulationControl", "(I)Lcom/zebra/rfid/api3/Antennas$SingulationControl;", "GetGetSingulationControl_IHandler")]
    public virtual unsafe Antennas.SingulationControl? GetSingulationControl(int antennaIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaIndex)
      };
      JniObjectReference jniObjectReference = Antennas._members.InstanceMethods.InvokeVirtualObjectMethod("getSingulationControl.(I)Lcom/zebra/rfid/api3/Antennas$SingulationControl;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Antennas.SingulationControl>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_Handler()
    {
      if ((object) Antennas.cb_setAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_ == null)
        Antennas.cb_setAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIL_V(Antennas.n_SetAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_));
      return Antennas.cb_setAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_;
    }

    private static void n_SetAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex,
      IntPtr native_antennaConfig)
    {
      Antennas antennas = Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0);
      Antennas.Config config = Object.GetObject<Antennas.Config>(native_antennaConfig, (JniHandleOwnership) 0);
      int antennaIndex1 = antennaIndex;
      Antennas.Config antennaConfig = config;
      antennas.SetAntennaConfig(antennaIndex1, antennaConfig);
    }

    [Register("setAntennaConfig", "(ILcom/zebra/rfid/api3/Antennas$Config;)V", "GetSetAntennaConfig_ILcom_zebra_rfid_api3_Antennas_Config_Handler")]
    public virtual unsafe void SetAntennaConfig(int antennaIndex, Antennas.Config? antennaConfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(antennaIndex),
          new JniArgumentValue(antennaConfig == null ? IntPtr.Zero : antennaConfig.Handle)
        };
        Antennas._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaConfig.(ILcom/zebra/rfid/api3/Antennas$Config;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) antennaConfig);
      }
    }

    private static Delegate GetSetAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Handler()
    {
      if ((object) Antennas.cb_setAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_ == null)
        Antennas.cb_setAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIL_V(Antennas.n_SetAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_));
      return Antennas.cb_setAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_;
    }

    private static void n_SetAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex,
      IntPtr native_antennaRfConfig)
    {
      Antennas antennas = Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0);
      Antennas.AntennaRfConfig antennaRfConfig1 = Object.GetObject<Antennas.AntennaRfConfig>(native_antennaRfConfig, (JniHandleOwnership) 0);
      int antennaIndex1 = antennaIndex;
      Antennas.AntennaRfConfig antennaRfConfig2 = antennaRfConfig1;
      antennas.SetAntennaRfConfig(antennaIndex1, antennaRfConfig2);
    }

    [Register("setAntennaRfConfig", "(ILcom/zebra/rfid/api3/Antennas$AntennaRfConfig;)V", "GetSetAntennaRfConfig_ILcom_zebra_rfid_api3_Antennas_AntennaRfConfig_Handler")]
    public virtual unsafe void SetAntennaRfConfig(
      int antennaIndex,
      Antennas.AntennaRfConfig? antennaRfConfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(antennaIndex),
          new JniArgumentValue(antennaRfConfig == null ? IntPtr.Zero : antennaRfConfig.Handle)
        };
        Antennas._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaRfConfig.(ILcom/zebra/rfid/api3/Antennas$AntennaRfConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) antennaRfConfig);
      }
    }

    private static Delegate GetSetRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_Handler()
    {
      if ((object) Antennas.cb_setRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_ == null)
        Antennas.cb_setRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIL_V(Antennas.n_SetRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_));
      return Antennas.cb_setRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_;
    }

    private static void n_SetRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex,
      IntPtr native_antennaRFMode)
    {
      Antennas antennas = Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0);
      Antennas.RFMode rfMode = Object.GetObject<Antennas.RFMode>(native_antennaRFMode, (JniHandleOwnership) 0);
      int antennaIndex1 = antennaIndex;
      Antennas.RFMode antennaRFMode = rfMode;
      antennas.SetRFMode(antennaIndex1, antennaRFMode);
    }

    [Register("setRFMode", "(ILcom/zebra/rfid/api3/Antennas$RFMode;)V", "GetSetRFMode_ILcom_zebra_rfid_api3_Antennas_RFMode_Handler")]
    public virtual unsafe void SetRFMode(int antennaIndex, Antennas.RFMode? antennaRFMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(antennaIndex),
          new JniArgumentValue(antennaRFMode == null ? IntPtr.Zero : antennaRFMode.Handle)
        };
        Antennas._members.InstanceMethods.InvokeVirtualVoidMethod("setRFMode.(ILcom/zebra/rfid/api3/Antennas$RFMode;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) antennaRFMode);
      }
    }

    private static Delegate GetSetSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_Handler()
    {
      if ((object) Antennas.cb_setSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_ == null)
        Antennas.cb_setSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIL_V(Antennas.n_SetSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_));
      return Antennas.cb_setSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_;
    }

    private static void n_SetSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_(
      IntPtr jnienv,
      IntPtr native__this,
      int antennaIndex,
      IntPtr native_antennaSingulationControl)
    {
      Antennas antennas = Object.GetObject<Antennas>(jnienv, native__this, (JniHandleOwnership) 0);
      Antennas.SingulationControl singulationControl = Object.GetObject<Antennas.SingulationControl>(native_antennaSingulationControl, (JniHandleOwnership) 0);
      int antennaIndex1 = antennaIndex;
      Antennas.SingulationControl antennaSingulationControl = singulationControl;
      antennas.SetSingulationControl(antennaIndex1, antennaSingulationControl);
    }

    [Register("setSingulationControl", "(ILcom/zebra/rfid/api3/Antennas$SingulationControl;)V", "GetSetSingulationControl_ILcom_zebra_rfid_api3_Antennas_SingulationControl_Handler")]
    public virtual unsafe void SetSingulationControl(
      int antennaIndex,
      Antennas.SingulationControl? antennaSingulationControl)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(antennaIndex),
          new JniArgumentValue(antennaSingulationControl == null ? IntPtr.Zero : antennaSingulationControl.Handle)
        };
        Antennas._members.InstanceMethods.InvokeVirtualVoidMethod("setSingulationControl.(ILcom/zebra/rfid/api3/Antennas$SingulationControl;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) antennaSingulationControl);
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$AntennaProperties", DoNotGenerateAcw = true)]
    public class AntennaProperties : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$AntennaProperties", typeof (Antennas.AntennaProperties));
      private static Delegate? cb_getIndex;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Antennas.AntennaProperties._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.AntennaProperties._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.AntennaProperties._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.AntennaProperties._members.ManagedPeerType;

      protected AntennaProperties(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetIndexHandler()
      {
        if ((object) Antennas.AntennaProperties.cb_getIndex == null)
          Antennas.AntennaProperties.cb_getIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.AntennaProperties.n_GetIndex));
        return Antennas.AntennaProperties.cb_getIndex;
      }

      private static short n_GetIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaProperties>(jnienv, native__this, (JniHandleOwnership) 0).Index;
      }

      public virtual unsafe short Index
      {
        [Register("getIndex", "()S", "GetGetIndexHandler")] get
        {
          return Antennas.AntennaProperties._members.InstanceMethods.InvokeVirtualInt16Method("getIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$AntennaRfConfig", DoNotGenerateAcw = true)]
    public class AntennaRfConfig : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$AntennaRfConfig", typeof (Antennas.AntennaRfConfig));
      private static Delegate? cb_getAntennaStopTriggerConfig;
      private static Delegate? cb_setAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_;
      private static Delegate? cb_getEnvironment_mode;
      private static Delegate? cb_setEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_;
      private static Delegate? cb_getReceivePort;
      private static Delegate? cb_setReceivePort_I;
      private static Delegate? cb_getReceiveSensitivityIndex;
      private static Delegate? cb_setReceiveSensitivityIndex_I;
      private static Delegate? cb_getTari;
      private static Delegate? cb_setTari_J;
      private static Delegate? cb_getTransmitFrequencyIndex;
      private static Delegate? cb_setTransmitFrequencyIndex_I;
      private static Delegate? cb_getTransmitPort;
      private static Delegate? cb_setTransmitPort_I;
      private static Delegate? cb_getTransmitPowerIndex;
      private static Delegate? cb_setTransmitPowerIndex_I;
      private static Delegate? cb_getrfModeTableIndex;
      private static Delegate? cb_setrfModeTableIndex_J;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Antennas.AntennaRfConfig._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.AntennaRfConfig._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.AntennaRfConfig._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.AntennaRfConfig._members.ManagedPeerType;

      protected AntennaRfConfig(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;)V", "")]
      public unsafe AntennaRfConfig(Antennas? __self)
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
          JniObjectReference instance = Antennas.AntennaRfConfig._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.AntennaRfConfig._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetAntennaStopTriggerConfigHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getAntennaStopTriggerConfig == null)
          Antennas.AntennaRfConfig.cb_getAntennaStopTriggerConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.AntennaRfConfig.n_GetAntennaStopTriggerConfig));
        return Antennas.AntennaRfConfig.cb_getAntennaStopTriggerConfig;
      }

      private static IntPtr n_GetAntennaStopTriggerConfig(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaStopTriggerConfig);
      }

      private static Delegate GetSetAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_Handler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_ == null)
          Antennas.AntennaRfConfig.cb_setAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.AntennaRfConfig.n_SetAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_));
        return Antennas.AntennaRfConfig.cb_setAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_;
      }

      private static void n_SetAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_AntennaStopTriggerConfig)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).AntennaStopTriggerConfig = Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(native_m_AntennaStopTriggerConfig, (JniHandleOwnership) 0);
      }

      public virtual unsafe Antennas.AntennaRfConfig.AntennaStopTrigger? AntennaStopTriggerConfig
      {
        [Register("getAntennaStopTriggerConfig", "()Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger;", "GetGetAntennaStopTriggerConfigHandler")] get
        {
          JniObjectReference jniObjectReference = Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaStopTriggerConfig.()Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setAntennaStopTriggerConfig", "(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger;)V", "GetSetAntennaStopTriggerConfig_Lcom_zebra_rfid_api3_Antennas_AntennaRfConfig_AntennaStopTrigger_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaStopTriggerConfig.(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetEnvironment_modeHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getEnvironment_mode == null)
          Antennas.AntennaRfConfig.cb_getEnvironment_mode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.AntennaRfConfig.n_GetEnvironment_mode));
        return Antennas.AntennaRfConfig.cb_getEnvironment_mode;
      }

      private static IntPtr n_GetEnvironment_mode(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).Environment_mode);
      }

      private static Delegate GetSetEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_Handler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_ == null)
          Antennas.AntennaRfConfig.cb_setEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.AntennaRfConfig.n_SetEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_));
        return Antennas.AntennaRfConfig.cb_setEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_;
      }

      private static void n_SetEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_environment_mode)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).Environment_mode = Object.GetObject<ENVIRONMENT_MODE>(native_environment_mode, (JniHandleOwnership) 0);
      }

      public virtual unsafe ENVIRONMENT_MODE? Environment_mode
      {
        [Register("getEnvironment_mode", "()Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", "GetGetEnvironment_modeHandler")] get
        {
          JniObjectReference jniObjectReference = Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getEnvironment_mode.()Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setEnvironment_mode", "(Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;)V", "GetSetEnvironment_mode_Lcom_zebra_rfid_api3_ENVIRONMENT_MODE_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEnvironment_mode.(Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetReceivePortHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getReceivePort == null)
          Antennas.AntennaRfConfig.cb_getReceivePort = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.n_GetReceivePort));
        return Antennas.AntennaRfConfig.cb_getReceivePort;
      }

      private static int n_GetReceivePort(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).ReceivePort;
      }

      private static Delegate GetSetReceivePort_IHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setReceivePort_I == null)
          Antennas.AntennaRfConfig.cb_setReceivePort_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.n_SetReceivePort_I));
        return Antennas.AntennaRfConfig.cb_setReceivePort_I;
      }

      private static void n_SetReceivePort_I(IntPtr jnienv, IntPtr native__this, int m_ReceivePort)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).ReceivePort = m_ReceivePort;
      }

      public virtual unsafe int ReceivePort
      {
        [Register("getReceivePort", "()I", "GetGetReceivePortHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt32Method("getReceivePort.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setReceivePort", "(I)V", "GetSetReceivePort_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setReceivePort.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetReceiveSensitivityIndexHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getReceiveSensitivityIndex == null)
          Antennas.AntennaRfConfig.cb_getReceiveSensitivityIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.n_GetReceiveSensitivityIndex));
        return Antennas.AntennaRfConfig.cb_getReceiveSensitivityIndex;
      }

      private static int n_GetReceiveSensitivityIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).ReceiveSensitivityIndex;
      }

      private static Delegate GetSetReceiveSensitivityIndex_IHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setReceiveSensitivityIndex_I == null)
          Antennas.AntennaRfConfig.cb_setReceiveSensitivityIndex_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.n_SetReceiveSensitivityIndex_I));
        return Antennas.AntennaRfConfig.cb_setReceiveSensitivityIndex_I;
      }

      private static void n_SetReceiveSensitivityIndex_I(
        IntPtr jnienv,
        IntPtr native__this,
        int m_nReceiveSensitivityIndex)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).ReceiveSensitivityIndex = m_nReceiveSensitivityIndex;
      }

      public virtual unsafe int ReceiveSensitivityIndex
      {
        [Register("getReceiveSensitivityIndex", "()I", "GetGetReceiveSensitivityIndexHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt32Method("getReceiveSensitivityIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setReceiveSensitivityIndex", "(I)V", "GetSetReceiveSensitivityIndex_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setReceiveSensitivityIndex.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTariHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getTari == null)
          Antennas.AntennaRfConfig.cb_getTari = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Antennas.AntennaRfConfig.n_GetTari));
        return Antennas.AntennaRfConfig.cb_getTari;
      }

      private static long n_GetTari(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).Tari;
      }

      private static Delegate GetSetTari_JHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setTari_J == null)
          Antennas.AntennaRfConfig.cb_setTari_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Antennas.AntennaRfConfig.n_SetTari_J));
        return Antennas.AntennaRfConfig.cb_setTari_J;
      }

      private static void n_SetTari_J(IntPtr jnienv, IntPtr native__this, long m_Tari)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).Tari = m_Tari;
      }

      public virtual unsafe long Tari
      {
        [Register("getTari", "()J", "GetGetTariHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt64Method("getTari.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTari", "(J)V", "GetSetTari_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setTari.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTransmitFrequencyIndexHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getTransmitFrequencyIndex == null)
          Antennas.AntennaRfConfig.cb_getTransmitFrequencyIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.n_GetTransmitFrequencyIndex));
        return Antennas.AntennaRfConfig.cb_getTransmitFrequencyIndex;
      }

      private static int n_GetTransmitFrequencyIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitFrequencyIndex;
      }

      private static Delegate GetSetTransmitFrequencyIndex_IHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setTransmitFrequencyIndex_I == null)
          Antennas.AntennaRfConfig.cb_setTransmitFrequencyIndex_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.n_SetTransmitFrequencyIndex_I));
        return Antennas.AntennaRfConfig.cb_setTransmitFrequencyIndex_I;
      }

      private static void n_SetTransmitFrequencyIndex_I(
        IntPtr jnienv,
        IntPtr native__this,
        int m_nTransmitFrequencyIndex)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitFrequencyIndex = m_nTransmitFrequencyIndex;
      }

      public virtual unsafe int TransmitFrequencyIndex
      {
        [Register("getTransmitFrequencyIndex", "()I", "GetGetTransmitFrequencyIndexHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt32Method("getTransmitFrequencyIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTransmitFrequencyIndex", "(I)V", "GetSetTransmitFrequencyIndex_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitFrequencyIndex.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTransmitPortHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getTransmitPort == null)
          Antennas.AntennaRfConfig.cb_getTransmitPort = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.n_GetTransmitPort));
        return Antennas.AntennaRfConfig.cb_getTransmitPort;
      }

      private static int n_GetTransmitPort(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPort;
      }

      private static Delegate GetSetTransmitPort_IHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setTransmitPort_I == null)
          Antennas.AntennaRfConfig.cb_setTransmitPort_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.n_SetTransmitPort_I));
        return Antennas.AntennaRfConfig.cb_setTransmitPort_I;
      }

      private static void n_SetTransmitPort_I(
        IntPtr jnienv,
        IntPtr native__this,
        int m_TransmitPort)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPort = m_TransmitPort;
      }

      public virtual unsafe int TransmitPort
      {
        [Register("getTransmitPort", "()I", "GetGetTransmitPortHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt32Method("getTransmitPort.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTransmitPort", "(I)V", "GetSetTransmitPort_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitPort.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTransmitPowerIndexHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getTransmitPowerIndex == null)
          Antennas.AntennaRfConfig.cb_getTransmitPowerIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.n_GetTransmitPowerIndex));
        return Antennas.AntennaRfConfig.cb_getTransmitPowerIndex;
      }

      private static int n_GetTransmitPowerIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPowerIndex;
      }

      private static Delegate GetSetTransmitPowerIndex_IHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setTransmitPowerIndex_I == null)
          Antennas.AntennaRfConfig.cb_setTransmitPowerIndex_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.n_SetTransmitPowerIndex_I));
        return Antennas.AntennaRfConfig.cb_setTransmitPowerIndex_I;
      }

      private static void n_SetTransmitPowerIndex_I(
        IntPtr jnienv,
        IntPtr native__this,
        int m_nTransmitPowerIndex)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPowerIndex = m_nTransmitPowerIndex;
      }

      public virtual unsafe int TransmitPowerIndex
      {
        [Register("getTransmitPowerIndex", "()I", "GetGetTransmitPowerIndexHandler")] get
        {
          return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt32Method("getTransmitPowerIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTransmitPowerIndex", "(I)V", "GetSetTransmitPowerIndex_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitPowerIndex.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetrfModeTableIndexHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_getrfModeTableIndex == null)
          Antennas.AntennaRfConfig.cb_getrfModeTableIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Antennas.AntennaRfConfig.n_GetrfModeTableIndex));
        return Antennas.AntennaRfConfig.cb_getrfModeTableIndex;
      }

      private static long n_GetrfModeTableIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).GetrfModeTableIndex();
      }

      [Register("getrfModeTableIndex", "()J", "GetGetrfModeTableIndexHandler")]
      public virtual unsafe long GetrfModeTableIndex()
      {
        return Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualInt64Method("getrfModeTableIndex.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetSetrfModeTableIndex_JHandler()
      {
        if ((object) Antennas.AntennaRfConfig.cb_setrfModeTableIndex_J == null)
          Antennas.AntennaRfConfig.cb_setrfModeTableIndex_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Antennas.AntennaRfConfig.n_SetrfModeTableIndex_J));
        return Antennas.AntennaRfConfig.cb_setrfModeTableIndex_J;
      }

      private static void n_SetrfModeTableIndex_J(
        IntPtr jnienv,
        IntPtr native__this,
        long m_rfModeTableIndex)
      {
        Object.GetObject<Antennas.AntennaRfConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetrfModeTableIndex(m_rfModeTableIndex);
      }

      [Register("setrfModeTableIndex", "(J)V", "GetSetrfModeTableIndex_JHandler")]
      public virtual unsafe void SetrfModeTableIndex(long m_rfModeTableIndex)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(m_rfModeTableIndex)
        };
        Antennas.AntennaRfConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setrfModeTableIndex.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }

      [Register("com/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger", DoNotGenerateAcw = true)]
      public class AntennaStopTrigger : Object
      {
        private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$AntennaRfConfig$AntennaStopTrigger", typeof (Antennas.AntennaRfConfig.AntennaStopTrigger));
        private static Delegate? cb_getAntennaStopConditionValue;
        private static Delegate? cb_setAntennaStopConditionValue_I;
        private static Delegate? cb_getGpiTrigger;
        private static Delegate? cb_setGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_;
        private static Delegate? cb_getStopTriggerType;
        private static Delegate? cb_setStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_;

        internal static IntPtr class_ref
        {
          get
          {
            JniObjectReference peerReference = Antennas.AntennaRfConfig.AntennaStopTrigger._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual JniPeerMembers JniPeerMembers
        {
          get => Antennas.AntennaRfConfig.AntennaStopTrigger._members;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual IntPtr ThresholdClass
        {
          get
          {
            JniObjectReference peerReference = Antennas.AntennaRfConfig.AntennaStopTrigger._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual Type ThresholdType
        {
          get => Antennas.AntennaRfConfig.AntennaStopTrigger._members.ManagedPeerType;
        }

        protected AntennaStopTrigger(IntPtr javaReference, JniHandleOwnership transfer)
          : base(javaReference, transfer)
        {
        }

        [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas$AntennaRfConfig;)V", "")]
        public unsafe AntennaStopTrigger(Antennas.AntennaRfConfig? __self)
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
            JniObjectReference instance = Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
            this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
            Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) __self);
          }
        }

        private static Delegate GetGetAntennaStopConditionValueHandler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getAntennaStopConditionValue == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getAntennaStopConditionValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.AntennaRfConfig.AntennaStopTrigger.n_GetAntennaStopConditionValue));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getAntennaStopConditionValue;
        }

        private static int n_GetAntennaStopConditionValue(IntPtr jnienv, IntPtr native__this)
        {
          return Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).AntennaStopConditionValue;
        }

        private static Delegate GetSetAntennaStopConditionValue_IHandler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setAntennaStopConditionValue_I == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setAntennaStopConditionValue_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.AntennaRfConfig.AntennaStopTrigger.n_SetAntennaStopConditionValue_I));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setAntennaStopConditionValue_I;
        }

        private static void n_SetAntennaStopConditionValue_I(
          IntPtr jnienv,
          IntPtr native__this,
          int m_AntennaStopConditionValue)
        {
          Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).AntennaStopConditionValue = m_AntennaStopConditionValue;
        }

        public virtual unsafe int AntennaStopConditionValue
        {
          [Register("getAntennaStopConditionValue", "()I", "GetGetAntennaStopConditionValueHandler")] get
          {
            return Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualInt32Method("getAntennaStopConditionValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
          }
          [Register("setAntennaStopConditionValue", "(I)V", "GetSetAntennaStopConditionValue_IHandler")] set
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value)
            };
            Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaStopConditionValue.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
        }

        private static Delegate GetGetGpiTriggerHandler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getGpiTrigger == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getGpiTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.AntennaRfConfig.AntennaStopTrigger.n_GetGpiTrigger));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getGpiTrigger;
        }

        private static IntPtr n_GetGpiTrigger(IntPtr jnienv, IntPtr native__this)
        {
          return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).GpiTrigger);
        }

        private static Delegate GetSetGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_Handler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_ == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.AntennaRfConfig.AntennaStopTrigger.n_SetGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_;
        }

        private static void n_SetGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_(
          IntPtr jnienv,
          IntPtr native__this,
          IntPtr native_gpiTrigger)
        {
          Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).GpiTrigger = Object.GetObject<GPITrigger>(native_gpiTrigger, (JniHandleOwnership) 0);
        }

        public virtual unsafe GPITrigger? GpiTrigger
        {
          [Register("getGpiTrigger", "()Lcom/zebra/rfid/api3/GPITrigger;", "GetGetGpiTriggerHandler")] get
          {
            JniObjectReference jniObjectReference = Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getGpiTrigger.()Lcom/zebra/rfid/api3/GPITrigger;", (IJavaPeerable) this, (JniArgumentValue*) null);
            return Object.GetObject<GPITrigger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
          }
          [Register("setGpiTrigger", "(Lcom/zebra/rfid/api3/GPITrigger;)V", "GetSetGpiTrigger_Lcom_zebra_rfid_api3_GPITrigger_Handler")] set
          {
            try
            {
              JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
              {
                new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
              };
              Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setGpiTrigger.(Lcom/zebra/rfid/api3/GPITrigger;)V", (IJavaPeerable) this, jniArgumentValuePtr);
            }
            finally
            {
              GC.KeepAlive((object) value);
            }
          }
        }

        private static Delegate GetGetStopTriggerTypeHandler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getStopTriggerType == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getStopTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.AntennaRfConfig.AntennaStopTrigger.n_GetStopTriggerType));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_getStopTriggerType;
        }

        private static IntPtr n_GetStopTriggerType(IntPtr jnienv, IntPtr native__this)
        {
          return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTriggerType);
        }

        private static Delegate GetSetStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_Handler()
        {
          if ((object) Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_ == null)
            Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.AntennaRfConfig.AntennaStopTrigger.n_SetStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_));
          return Antennas.AntennaRfConfig.AntennaStopTrigger.cb_setStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_;
        }

        private static void n_SetStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_(
          IntPtr jnienv,
          IntPtr native__this,
          IntPtr native_m_StopTriggerType)
        {
          Object.GetObject<Antennas.AntennaRfConfig.AntennaStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTriggerType = Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(native_m_StopTriggerType, (JniHandleOwnership) 0);
        }

        public virtual unsafe ANTENNA_STOP_TRIGGER_TYPE? StopTriggerType
        {
          [Register("getStopTriggerType", "()Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", "GetGetStopTriggerTypeHandler")] get
          {
            JniObjectReference jniObjectReference = Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getStopTriggerType.()Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
            return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
          }
          [Register("setStopTriggerType", "(Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;)V", "GetSetStopTriggerType_Lcom_zebra_rfid_api3_ANTENNA_STOP_TRIGGER_TYPE_Handler")] set
          {
            try
            {
              JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
              {
                new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
              };
              Antennas.AntennaRfConfig.AntennaStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopTriggerType.(Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
            }
            finally
            {
              GC.KeepAlive((object) value);
            }
          }
        }
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$Config", DoNotGenerateAcw = true)]
    public class Config : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$Config", typeof (Antennas.Config));
      private static Delegate? cb_getReceiveSensitivityIndex;
      private static Delegate? cb_setReceiveSensitivityIndex_S;
      private static Delegate? cb_getTransmitFrequencyIndex;
      private static Delegate? cb_setTransmitFrequencyIndex_S;
      private static Delegate? cb_getTransmitPowerIndex;
      private static Delegate? cb_setTransmitPowerIndex_S;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Antennas.Config._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.Config._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.Config._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.Config._members.ManagedPeerType;

      protected Config(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;)V", "")]
      public unsafe Config(Antennas? __self)
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
          JniObjectReference instance = Antennas.Config._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.Config._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;SSS)V", "")]
      public unsafe Config(
        Antennas? __self,
        short receiveSensitivityIndex,
        short transmitPowerIndex,
        short transmitFrequencyIndex)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";SSS)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(receiveSensitivityIndex),
            new JniArgumentValue(transmitPowerIndex),
            new JniArgumentValue(transmitFrequencyIndex)
          };
          JniObjectReference instance = Antennas.Config._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.Config._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetReceiveSensitivityIndexHandler()
      {
        if ((object) Antennas.Config.cb_getReceiveSensitivityIndex == null)
          Antennas.Config.cb_getReceiveSensitivityIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.Config.n_GetReceiveSensitivityIndex));
        return Antennas.Config.cb_getReceiveSensitivityIndex;
      }

      private static short n_GetReceiveSensitivityIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).ReceiveSensitivityIndex;
      }

      private static Delegate GetSetReceiveSensitivityIndex_SHandler()
      {
        if ((object) Antennas.Config.cb_setReceiveSensitivityIndex_S == null)
          Antennas.Config.cb_setReceiveSensitivityIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Antennas.Config.n_SetReceiveSensitivityIndex_S));
        return Antennas.Config.cb_setReceiveSensitivityIndex_S;
      }

      private static void n_SetReceiveSensitivityIndex_S(
        IntPtr jnienv,
        IntPtr native__this,
        short receiveSensitivityIndex)
      {
        Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).ReceiveSensitivityIndex = receiveSensitivityIndex;
      }

      public virtual unsafe short ReceiveSensitivityIndex
      {
        [Register("getReceiveSensitivityIndex", "()S", "GetGetReceiveSensitivityIndexHandler")] get
        {
          return Antennas.Config._members.InstanceMethods.InvokeVirtualInt16Method("getReceiveSensitivityIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setReceiveSensitivityIndex", "(S)V", "GetSetReceiveSensitivityIndex_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.Config._members.InstanceMethods.InvokeVirtualVoidMethod("setReceiveSensitivityIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTransmitFrequencyIndexHandler()
      {
        if ((object) Antennas.Config.cb_getTransmitFrequencyIndex == null)
          Antennas.Config.cb_getTransmitFrequencyIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.Config.n_GetTransmitFrequencyIndex));
        return Antennas.Config.cb_getTransmitFrequencyIndex;
      }

      private static short n_GetTransmitFrequencyIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).TransmitFrequencyIndex;
      }

      private static Delegate GetSetTransmitFrequencyIndex_SHandler()
      {
        if ((object) Antennas.Config.cb_setTransmitFrequencyIndex_S == null)
          Antennas.Config.cb_setTransmitFrequencyIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Antennas.Config.n_SetTransmitFrequencyIndex_S));
        return Antennas.Config.cb_setTransmitFrequencyIndex_S;
      }

      private static void n_SetTransmitFrequencyIndex_S(
        IntPtr jnienv,
        IntPtr native__this,
        short transmitFrequencyIndex)
      {
        Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).TransmitFrequencyIndex = transmitFrequencyIndex;
      }

      public virtual unsafe short TransmitFrequencyIndex
      {
        [Register("getTransmitFrequencyIndex", "()S", "GetGetTransmitFrequencyIndexHandler")] get
        {
          return Antennas.Config._members.InstanceMethods.InvokeVirtualInt16Method("getTransmitFrequencyIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTransmitFrequencyIndex", "(S)V", "GetSetTransmitFrequencyIndex_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.Config._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitFrequencyIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTransmitPowerIndexHandler()
      {
        if ((object) Antennas.Config.cb_getTransmitPowerIndex == null)
          Antennas.Config.cb_getTransmitPowerIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.Config.n_GetTransmitPowerIndex));
        return Antennas.Config.cb_getTransmitPowerIndex;
      }

      private static short n_GetTransmitPowerIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPowerIndex;
      }

      private static Delegate GetSetTransmitPowerIndex_SHandler()
      {
        if ((object) Antennas.Config.cb_setTransmitPowerIndex_S == null)
          Antennas.Config.cb_setTransmitPowerIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Antennas.Config.n_SetTransmitPowerIndex_S));
        return Antennas.Config.cb_setTransmitPowerIndex_S;
      }

      private static void n_SetTransmitPowerIndex_S(
        IntPtr jnienv,
        IntPtr native__this,
        short transmitPowerIndex)
      {
        Object.GetObject<Antennas.Config>(jnienv, native__this, (JniHandleOwnership) 0).TransmitPowerIndex = transmitPowerIndex;
      }

      public virtual unsafe short TransmitPowerIndex
      {
        [Register("getTransmitPowerIndex", "()S", "GetGetTransmitPowerIndexHandler")] get
        {
          return Antennas.Config._members.InstanceMethods.InvokeVirtualInt16Method("getTransmitPowerIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTransmitPowerIndex", "(S)V", "GetSetTransmitPowerIndex_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.Config._members.InstanceMethods.InvokeVirtualVoidMethod("setTransmitPowerIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$PhysicalProperties", DoNotGenerateAcw = true)]
    public class PhysicalProperties : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$PhysicalProperties", typeof (Antennas.PhysicalProperties));
      private static Delegate? cb_getAntennaGain;
      private static Delegate? cb_isConnected;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Antennas.PhysicalProperties._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.PhysicalProperties._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.PhysicalProperties._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.PhysicalProperties._members.ManagedPeerType;

      protected PhysicalProperties(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;)V", "")]
      public unsafe PhysicalProperties(Antennas? __self)
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
          JniObjectReference instance = Antennas.PhysicalProperties._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.PhysicalProperties._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetAntennaGainHandler()
      {
        if ((object) Antennas.PhysicalProperties.cb_getAntennaGain == null)
          Antennas.PhysicalProperties.cb_getAntennaGain = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.PhysicalProperties.n_GetAntennaGain));
        return Antennas.PhysicalProperties.cb_getAntennaGain;
      }

      private static int n_GetAntennaGain(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.PhysicalProperties>(jnienv, native__this, (JniHandleOwnership) 0).AntennaGain;
      }

      public virtual unsafe int AntennaGain
      {
        [Register("getAntennaGain", "()I", "GetGetAntennaGainHandler")] get
        {
          return Antennas.PhysicalProperties._members.InstanceMethods.InvokeVirtualInt32Method("getAntennaGain.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetIsConnectedHandler()
      {
        if ((object) Antennas.PhysicalProperties.cb_isConnected == null)
          Antennas.PhysicalProperties.cb_isConnected = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Antennas.PhysicalProperties.n_IsConnected));
        return Antennas.PhysicalProperties.cb_isConnected;
      }

      private static bool n_IsConnected(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.PhysicalProperties>(jnienv, native__this, (JniHandleOwnership) 0).IsConnected;
      }

      public virtual unsafe bool IsConnected
      {
        [Register("isConnected", "()Z", "GetIsConnectedHandler")] get
        {
          return Antennas.PhysicalProperties._members.InstanceMethods.InvokeVirtualBooleanMethod("isConnected.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$RFMode", DoNotGenerateAcw = true)]
    public class RFMode : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$RFMode", typeof (Antennas.RFMode));
      private static Delegate? cb_getTableIndex;
      private static Delegate? cb_setTableIndex_I;
      private static Delegate? cb_getTari;
      private static Delegate? cb_setTari_I;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Antennas.RFMode._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.RFMode._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.RFMode._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.RFMode._members.ManagedPeerType;

      protected RFMode(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;)V", "")]
      public unsafe RFMode(Antennas? __self)
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
          JniObjectReference instance = Antennas.RFMode._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.RFMode._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas;II)V", "")]
      public unsafe RFMode(Antennas? __self, int tableIndex, int tari)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";II)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(tableIndex),
            new JniArgumentValue(tari)
          };
          JniObjectReference instance = Antennas.RFMode._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Antennas.RFMode._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetTableIndexHandler()
      {
        if ((object) Antennas.RFMode.cb_getTableIndex == null)
          Antennas.RFMode.cb_getTableIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.RFMode.n_GetTableIndex));
        return Antennas.RFMode.cb_getTableIndex;
      }

      private static int n_GetTableIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.RFMode>(jnienv, native__this, (JniHandleOwnership) 0).TableIndex;
      }

      private static Delegate GetSetTableIndex_IHandler()
      {
        if ((object) Antennas.RFMode.cb_setTableIndex_I == null)
          Antennas.RFMode.cb_setTableIndex_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.RFMode.n_SetTableIndex_I));
        return Antennas.RFMode.cb_setTableIndex_I;
      }

      private static void n_SetTableIndex_I(IntPtr jnienv, IntPtr native__this, int tableIndex)
      {
        Object.GetObject<Antennas.RFMode>(jnienv, native__this, (JniHandleOwnership) 0).TableIndex = tableIndex;
      }

      public virtual unsafe int TableIndex
      {
        [Register("getTableIndex", "()I", "GetGetTableIndexHandler")] get
        {
          return Antennas.RFMode._members.InstanceMethods.InvokeVirtualInt32Method("getTableIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTableIndex", "(I)V", "GetSetTableIndex_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.RFMode._members.InstanceMethods.InvokeVirtualVoidMethod("setTableIndex.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTariHandler()
      {
        if ((object) Antennas.RFMode.cb_getTari == null)
          Antennas.RFMode.cb_getTari = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Antennas.RFMode.n_GetTari));
        return Antennas.RFMode.cb_getTari;
      }

      private static int n_GetTari(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.RFMode>(jnienv, native__this, (JniHandleOwnership) 0).Tari;
      }

      private static Delegate GetSetTari_IHandler()
      {
        if ((object) Antennas.RFMode.cb_setTari_I == null)
          Antennas.RFMode.cb_setTari_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Antennas.RFMode.n_SetTari_I));
        return Antennas.RFMode.cb_setTari_I;
      }

      private static void n_SetTari_I(IntPtr jnienv, IntPtr native__this, int tari)
      {
        Object.GetObject<Antennas.RFMode>(jnienv, native__this, (JniHandleOwnership) 0).Tari = tari;
      }

      public virtual unsafe int Tari
      {
        [Register("getTari", "()I", "GetGetTariHandler")] get
        {
          return Antennas.RFMode._members.InstanceMethods.InvokeVirtualInt32Method("getTari.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTari", "(I)V", "GetSetTari_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.RFMode._members.InstanceMethods.InvokeVirtualVoidMethod("setTari.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Antennas$SingulationControl", DoNotGenerateAcw = true)]
    public class SingulationControl : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$SingulationControl", typeof (Antennas.SingulationControl));
      private static Delegate? cb_getSession;
      private static Delegate? cb_setSession_Lcom_zebra_rfid_api3_SESSION_;
      private static Delegate? cb_getTagPopulation;
      private static Delegate? cb_setTagPopulation_S;
      private static Delegate? cb_getTagTransitTime;
      private static Delegate? cb_setTagTransitTime_S;

      [Register("Action")]
      public Antennas.SingulationControl.SingulationAction? Action
      {
        get
        {
          JniObjectReference objectValue = Antennas.SingulationControl._members.InstanceFields.GetObjectValue("Action.Lcom/zebra/rfid/api3/Antennas$SingulationControl$SingulationAction;", (IJavaPeerable) this);
          return Object.GetObject<Antennas.SingulationControl.SingulationAction>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            Antennas.SingulationControl._members.InstanceFields.SetValue("Action.Lcom/zebra/rfid/api3/Antennas$SingulationControl$SingulationAction;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
          JniObjectReference peerReference = Antennas.SingulationControl._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Antennas.SingulationControl._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Antennas.SingulationControl._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Antennas.SingulationControl._members.ManagedPeerType;

      protected SingulationControl(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "()V", "")]
      public unsafe SingulationControl()
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        JniObjectReference instance = Antennas.SingulationControl._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        Antennas.SingulationControl._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetGetSessionHandler()
      {
        if ((object) Antennas.SingulationControl.cb_getSession == null)
          Antennas.SingulationControl.cb_getSession = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.SingulationControl.n_GetSession));
        return Antennas.SingulationControl.cb_getSession;
      }

      private static IntPtr n_GetSession(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).Session);
      }

      private static Delegate GetSetSession_Lcom_zebra_rfid_api3_SESSION_Handler()
      {
        if ((object) Antennas.SingulationControl.cb_setSession_Lcom_zebra_rfid_api3_SESSION_ == null)
          Antennas.SingulationControl.cb_setSession_Lcom_zebra_rfid_api3_SESSION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.SingulationControl.n_SetSession_Lcom_zebra_rfid_api3_SESSION_));
        return Antennas.SingulationControl.cb_setSession_Lcom_zebra_rfid_api3_SESSION_;
      }

      private static void n_SetSession_Lcom_zebra_rfid_api3_SESSION_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_session)
      {
        Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).Session = Object.GetObject<SESSION>(native_session, (JniHandleOwnership) 0);
      }

      public virtual unsafe SESSION? Session
      {
        [Register("getSession", "()Lcom/zebra/rfid/api3/SESSION;", "GetGetSessionHandler")] get
        {
          JniObjectReference jniObjectReference = Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualObjectMethod("getSession.()Lcom/zebra/rfid/api3/SESSION;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<SESSION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setSession", "(Lcom/zebra/rfid/api3/SESSION;)V", "GetSetSession_Lcom_zebra_rfid_api3_SESSION_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualVoidMethod("setSession.(Lcom/zebra/rfid/api3/SESSION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetTagPopulationHandler()
      {
        if ((object) Antennas.SingulationControl.cb_getTagPopulation == null)
          Antennas.SingulationControl.cb_getTagPopulation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.SingulationControl.n_GetTagPopulation));
        return Antennas.SingulationControl.cb_getTagPopulation;
      }

      private static short n_GetTagPopulation(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).TagPopulation;
      }

      private static Delegate GetSetTagPopulation_SHandler()
      {
        if ((object) Antennas.SingulationControl.cb_setTagPopulation_S == null)
          Antennas.SingulationControl.cb_setTagPopulation_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Antennas.SingulationControl.n_SetTagPopulation_S));
        return Antennas.SingulationControl.cb_setTagPopulation_S;
      }

      private static void n_SetTagPopulation_S(
        IntPtr jnienv,
        IntPtr native__this,
        short tagPopulation)
      {
        Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).TagPopulation = tagPopulation;
      }

      public virtual unsafe short TagPopulation
      {
        [Register("getTagPopulation", "()S", "GetGetTagPopulationHandler")] get
        {
          return Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualInt16Method("getTagPopulation.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTagPopulation", "(S)V", "GetSetTagPopulation_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPopulation.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTagTransitTimeHandler()
      {
        if ((object) Antennas.SingulationControl.cb_getTagTransitTime == null)
          Antennas.SingulationControl.cb_getTagTransitTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Antennas.SingulationControl.n_GetTagTransitTime));
        return Antennas.SingulationControl.cb_getTagTransitTime;
      }

      private static short n_GetTagTransitTime(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).TagTransitTime;
      }

      private static Delegate GetSetTagTransitTime_SHandler()
      {
        if ((object) Antennas.SingulationControl.cb_setTagTransitTime_S == null)
          Antennas.SingulationControl.cb_setTagTransitTime_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Antennas.SingulationControl.n_SetTagTransitTime_S));
        return Antennas.SingulationControl.cb_setTagTransitTime_S;
      }

      private static void n_SetTagTransitTime_S(
        IntPtr jnienv,
        IntPtr native__this,
        short tagTransitTime)
      {
        Object.GetObject<Antennas.SingulationControl>(jnienv, native__this, (JniHandleOwnership) 0).TagTransitTime = tagTransitTime;
      }

      public virtual unsafe short TagTransitTime
      {
        [Register("getTagTransitTime", "()S", "GetGetTagTransitTimeHandler")] get
        {
          return Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualInt16Method("getTagTransitTime.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTagTransitTime", "(S)V", "GetSetTagTransitTime_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Antennas.SingulationControl._members.InstanceMethods.InvokeVirtualVoidMethod("setTagTransitTime.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      [Register("com/zebra/rfid/api3/Antennas$SingulationControl$SingulationAction", DoNotGenerateAcw = true)]
      public class SingulationAction : Object
      {
        private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Antennas$SingulationControl$SingulationAction", typeof (Antennas.SingulationControl.SingulationAction));
        private static Delegate? cb_getInventoryState;
        private static Delegate? cb_setInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_;
        private static Delegate? cb_isPerformStateAwareSingulationActionSet;
        private static Delegate? cb_getSLFlag;
        private static Delegate? cb_setSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_;
        private static Delegate? cb_setPerformStateAwareSingulationAction_Z;

        internal static IntPtr class_ref
        {
          get
          {
            JniObjectReference peerReference = Antennas.SingulationControl.SingulationAction._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual JniPeerMembers JniPeerMembers
        {
          get => Antennas.SingulationControl.SingulationAction._members;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual IntPtr ThresholdClass
        {
          get
          {
            JniObjectReference peerReference = Antennas.SingulationControl.SingulationAction._members.JniPeerType.PeerReference;
            return ((JniObjectReference) ref peerReference).Handle;
          }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual Type ThresholdType
        {
          get => Antennas.SingulationControl.SingulationAction._members.ManagedPeerType;
        }

        protected SingulationAction(IntPtr javaReference, JniHandleOwnership transfer)
          : base(javaReference, transfer)
        {
        }

        [Register(".ctor", "(Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", "")]
        public unsafe SingulationAction(Antennas.SingulationControl? __self)
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
            JniObjectReference instance = Antennas.SingulationControl.SingulationAction._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
            this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
            Antennas.SingulationControl.SingulationAction._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) __self);
          }
        }

        private static Delegate GetGetInventoryStateHandler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_getInventoryState == null)
            Antennas.SingulationControl.SingulationAction.cb_getInventoryState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.SingulationControl.SingulationAction.n_GetInventoryState));
          return Antennas.SingulationControl.SingulationAction.cb_getInventoryState;
        }

        private static IntPtr n_GetInventoryState(IntPtr jnienv, IntPtr native__this)
        {
          return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).InventoryState);
        }

        private static Delegate GetSetInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_Handler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_setInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_ == null)
            Antennas.SingulationControl.SingulationAction.cb_setInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.SingulationControl.SingulationAction.n_SetInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_));
          return Antennas.SingulationControl.SingulationAction.cb_setInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_;
        }

        private static void n_SetInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_(
          IntPtr jnienv,
          IntPtr native__this,
          IntPtr native_inventoryState)
        {
          Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).InventoryState = Object.GetObject<INVENTORY_STATE>(native_inventoryState, (JniHandleOwnership) 0);
        }

        public virtual unsafe INVENTORY_STATE? InventoryState
        {
          [Register("getInventoryState", "()Lcom/zebra/rfid/api3/INVENTORY_STATE;", "GetGetInventoryStateHandler")] get
          {
            JniObjectReference jniObjectReference = Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualObjectMethod("getInventoryState.()Lcom/zebra/rfid/api3/INVENTORY_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
            return Object.GetObject<INVENTORY_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
          }
          [Register("setInventoryState", "(Lcom/zebra/rfid/api3/INVENTORY_STATE;)V", "GetSetInventoryState_Lcom_zebra_rfid_api3_INVENTORY_STATE_Handler")] set
          {
            try
            {
              JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
              {
                new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
              };
              Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualVoidMethod("setInventoryState.(Lcom/zebra/rfid/api3/INVENTORY_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
            }
            finally
            {
              GC.KeepAlive((object) value);
            }
          }
        }

        private static Delegate GetIsPerformStateAwareSingulationActionSetHandler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_isPerformStateAwareSingulationActionSet == null)
            Antennas.SingulationControl.SingulationAction.cb_isPerformStateAwareSingulationActionSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Antennas.SingulationControl.SingulationAction.n_IsPerformStateAwareSingulationActionSet));
          return Antennas.SingulationControl.SingulationAction.cb_isPerformStateAwareSingulationActionSet;
        }

        private static bool n_IsPerformStateAwareSingulationActionSet(
          IntPtr jnienv,
          IntPtr native__this)
        {
          return Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).IsPerformStateAwareSingulationActionSet;
        }

        public virtual unsafe bool IsPerformStateAwareSingulationActionSet
        {
          [Register("isPerformStateAwareSingulationActionSet", "()Z", "GetIsPerformStateAwareSingulationActionSetHandler")] get
          {
            return Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualBooleanMethod("isPerformStateAwareSingulationActionSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
          }
        }

        private static Delegate GetGetSLFlagHandler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_getSLFlag == null)
            Antennas.SingulationControl.SingulationAction.cb_getSLFlag = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Antennas.SingulationControl.SingulationAction.n_GetSLFlag));
          return Antennas.SingulationControl.SingulationAction.cb_getSLFlag;
        }

        private static IntPtr n_GetSLFlag(IntPtr jnienv, IntPtr native__this)
        {
          return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).SLFlag);
        }

        private static Delegate GetSetSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_Handler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_setSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_ == null)
            Antennas.SingulationControl.SingulationAction.cb_setSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Antennas.SingulationControl.SingulationAction.n_SetSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_));
          return Antennas.SingulationControl.SingulationAction.cb_setSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_;
        }

        private static void n_SetSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_(
          IntPtr jnienv,
          IntPtr native__this,
          IntPtr native_slFlag)
        {
          Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).SLFlag = Object.GetObject<SL_FLAG>(native_slFlag, (JniHandleOwnership) 0);
        }

        public virtual unsafe SL_FLAG? SLFlag
        {
          [Register("getSLFlag", "()Lcom/zebra/rfid/api3/SL_FLAG;", "GetGetSLFlagHandler")] get
          {
            JniObjectReference jniObjectReference = Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualObjectMethod("getSLFlag.()Lcom/zebra/rfid/api3/SL_FLAG;", (IJavaPeerable) this, (JniArgumentValue*) null);
            return Object.GetObject<SL_FLAG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
          }
          [Register("setSLFlag", "(Lcom/zebra/rfid/api3/SL_FLAG;)V", "GetSetSLFlag_Lcom_zebra_rfid_api3_SL_FLAG_Handler")] set
          {
            try
            {
              JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
              {
                new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
              };
              Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualVoidMethod("setSLFlag.(Lcom/zebra/rfid/api3/SL_FLAG;)V", (IJavaPeerable) this, jniArgumentValuePtr);
            }
            finally
            {
              GC.KeepAlive((object) value);
            }
          }
        }

        private static Delegate GetSetPerformStateAwareSingulationAction_ZHandler()
        {
          if ((object) Antennas.SingulationControl.SingulationAction.cb_setPerformStateAwareSingulationAction_Z == null)
            Antennas.SingulationControl.SingulationAction.cb_setPerformStateAwareSingulationAction_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Antennas.SingulationControl.SingulationAction.n_SetPerformStateAwareSingulationAction_Z));
          return Antennas.SingulationControl.SingulationAction.cb_setPerformStateAwareSingulationAction_Z;
        }

        private static void n_SetPerformStateAwareSingulationAction_Z(
          IntPtr jnienv,
          IntPtr native__this,
          bool m_PerformStateAwareSingulationAction)
        {
          Object.GetObject<Antennas.SingulationControl.SingulationAction>(jnienv, native__this, (JniHandleOwnership) 0).SetPerformStateAwareSingulationAction(m_PerformStateAwareSingulationAction);
        }

        [Register("setPerformStateAwareSingulationAction", "(Z)V", "GetSetPerformStateAwareSingulationAction_ZHandler")]
        public virtual unsafe void SetPerformStateAwareSingulationAction(
          bool m_PerformStateAwareSingulationAction)
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(m_PerformStateAwareSingulationAction)
          };
          Antennas.SingulationControl.SingulationAction._members.InstanceMethods.InvokeVirtualVoidMethod("setPerformStateAwareSingulationAction.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }
  }
}
