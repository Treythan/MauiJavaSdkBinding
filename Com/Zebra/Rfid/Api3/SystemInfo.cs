// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SystemInfo
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
  [Register("com/zebra/rfid/api3/SystemInfo", DoNotGenerateAcw = true)]
  public class SystemInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SystemInfo", typeof (SystemInfo));
    private static Delegate? cb_getCPUUsageForSystemProcesses;
    private static Delegate? cb_getCPUUsageForUserProcesses;
    private static Delegate? cb_getFPGAVersion;
    private static Delegate? cb_getFlashAvailable;
    private static Delegate? cb_getM_nRAMTotal;
    private static Delegate? cb_setM_nRAMTotal_I;
    private static Delegate? cb_getM_nRAMUsed;
    private static Delegate? cb_setM_nRAMUsed_I;
    private static Delegate? cb_getPowerSourceType;
    private static Delegate? cb_getRAMAvailable;
    private static Delegate? cb_getRAMTotal;
    private static Delegate? cb_getRAMUsed;
    private static Delegate? cb_getRadioFirmwareVersion;
    private static Delegate? cb_getReaderLocation;
    private static Delegate? cb_getReaderName;
    private static Delegate? cb_getUpTime;
    private static Delegate? cb_setM_sRadioFirmwareVersion_Ljava_lang_String_;
    private static Delegate? cb_setM_sReaderLocation_Ljava_lang_String_;
    private static Delegate? cb_setM_sReaderName_Ljava_lang_String_;
    private static Delegate? cb_setM_sUpTime_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SystemInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SystemInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SystemInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SystemInfo._members.ManagedPeerType;

    protected SystemInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetCPUUsageForSystemProcessesHandler()
    {
      if ((object) SystemInfo.cb_getCPUUsageForSystemProcesses == null)
        SystemInfo.cb_getCPUUsageForSystemProcesses = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetCPUUsageForSystemProcesses));
      return SystemInfo.cb_getCPUUsageForSystemProcesses;
    }

    private static int n_GetCPUUsageForSystemProcesses(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).CPUUsageForSystemProcesses;
    }

    public virtual unsafe int CPUUsageForSystemProcesses
    {
      [Register("getCPUUsageForSystemProcesses", "()I", "GetGetCPUUsageForSystemProcessesHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getCPUUsageForSystemProcesses.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetCPUUsageForUserProcessesHandler()
    {
      if ((object) SystemInfo.cb_getCPUUsageForUserProcesses == null)
        SystemInfo.cb_getCPUUsageForUserProcesses = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetCPUUsageForUserProcesses));
      return SystemInfo.cb_getCPUUsageForUserProcesses;
    }

    private static int n_GetCPUUsageForUserProcesses(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).CPUUsageForUserProcesses;
    }

    public virtual unsafe int CPUUsageForUserProcesses
    {
      [Register("getCPUUsageForUserProcesses", "()I", "GetGetCPUUsageForUserProcessesHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getCPUUsageForUserProcesses.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetFPGAVersionHandler()
    {
      if ((object) SystemInfo.cb_getFPGAVersion == null)
        SystemInfo.cb_getFPGAVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetFPGAVersion));
      return SystemInfo.cb_getFPGAVersion;
    }

    private static IntPtr n_GetFPGAVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).FPGAVersion);
    }

    public virtual unsafe string? FPGAVersion
    {
      [Register("getFPGAVersion", "()Ljava/lang/String;", "GetGetFPGAVersionHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getFPGAVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetFlashAvailableHandler()
    {
      if ((object) SystemInfo.cb_getFlashAvailable == null)
        SystemInfo.cb_getFlashAvailable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetFlashAvailable));
      return SystemInfo.cb_getFlashAvailable;
    }

    private static int n_GetFlashAvailable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).FlashAvailable;
    }

    public virtual unsafe int FlashAvailable
    {
      [Register("getFlashAvailable", "()I", "GetGetFlashAvailableHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getFlashAvailable.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetM_nRAMTotalHandler()
    {
      if ((object) SystemInfo.cb_getM_nRAMTotal == null)
        SystemInfo.cb_getM_nRAMTotal = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetM_nRAMTotal));
      return SystemInfo.cb_getM_nRAMTotal;
    }

    private static int n_GetM_nRAMTotal(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).M_nRAMTotal;
    }

    private static Delegate GetSetM_nRAMTotal_IHandler()
    {
      if ((object) SystemInfo.cb_setM_nRAMTotal_I == null)
        SystemInfo.cb_setM_nRAMTotal_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SystemInfo.n_SetM_nRAMTotal_I));
      return SystemInfo.cb_setM_nRAMTotal_I;
    }

    private static void n_SetM_nRAMTotal_I(IntPtr jnienv, IntPtr native__this, int m_nRAMTotal)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).M_nRAMTotal = m_nRAMTotal;
    }

    public virtual unsafe int M_nRAMTotal
    {
      [Register("getM_nRAMTotal", "()I", "GetGetM_nRAMTotalHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getM_nRAMTotal.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setM_nRAMTotal", "(I)V", "GetSetM_nRAMTotal_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_nRAMTotal.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetM_nRAMUsedHandler()
    {
      if ((object) SystemInfo.cb_getM_nRAMUsed == null)
        SystemInfo.cb_getM_nRAMUsed = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetM_nRAMUsed));
      return SystemInfo.cb_getM_nRAMUsed;
    }

    private static int n_GetM_nRAMUsed(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).M_nRAMUsed;
    }

    private static Delegate GetSetM_nRAMUsed_IHandler()
    {
      if ((object) SystemInfo.cb_setM_nRAMUsed_I == null)
        SystemInfo.cb_setM_nRAMUsed_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SystemInfo.n_SetM_nRAMUsed_I));
      return SystemInfo.cb_setM_nRAMUsed_I;
    }

    private static void n_SetM_nRAMUsed_I(IntPtr jnienv, IntPtr native__this, int m_nRAMUsed)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).M_nRAMUsed = m_nRAMUsed;
    }

    public virtual unsafe int M_nRAMUsed
    {
      [Register("getM_nRAMUsed", "()I", "GetGetM_nRAMUsedHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getM_nRAMUsed.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setM_nRAMUsed", "(I)V", "GetSetM_nRAMUsed_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_nRAMUsed.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerSourceTypeHandler()
    {
      if ((object) SystemInfo.cb_getPowerSourceType == null)
        SystemInfo.cb_getPowerSourceType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetPowerSourceType));
      return SystemInfo.cb_getPowerSourceType;
    }

    private static IntPtr n_GetPowerSourceType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).PowerSourceType);
    }

    public virtual unsafe POWER_SOURCE_TYPE? PowerSourceType
    {
      [Register("getPowerSourceType", "()Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;", "GetGetPowerSourceTypeHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getPowerSourceType.()Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<POWER_SOURCE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRAMAvailableHandler()
    {
      if ((object) SystemInfo.cb_getRAMAvailable == null)
        SystemInfo.cb_getRAMAvailable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetRAMAvailable));
      return SystemInfo.cb_getRAMAvailable;
    }

    private static int n_GetRAMAvailable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).RAMAvailable;
    }

    public virtual unsafe int RAMAvailable
    {
      [Register("getRAMAvailable", "()I", "GetGetRAMAvailableHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getRAMAvailable.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRAMTotalHandler()
    {
      if ((object) SystemInfo.cb_getRAMTotal == null)
        SystemInfo.cb_getRAMTotal = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetRAMTotal));
      return SystemInfo.cb_getRAMTotal;
    }

    private static int n_GetRAMTotal(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).RAMTotal;
    }

    public virtual unsafe int RAMTotal
    {
      [Register("getRAMTotal", "()I", "GetGetRAMTotalHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getRAMTotal.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRAMUsedHandler()
    {
      if ((object) SystemInfo.cb_getRAMUsed == null)
        SystemInfo.cb_getRAMUsed = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SystemInfo.n_GetRAMUsed));
      return SystemInfo.cb_getRAMUsed;
    }

    private static int n_GetRAMUsed(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).RAMUsed;
    }

    public virtual unsafe int RAMUsed
    {
      [Register("getRAMUsed", "()I", "GetGetRAMUsedHandler")] get
      {
        return SystemInfo._members.InstanceMethods.InvokeVirtualInt32Method("getRAMUsed.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRadioFirmwareVersionHandler()
    {
      if ((object) SystemInfo.cb_getRadioFirmwareVersion == null)
        SystemInfo.cb_getRadioFirmwareVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetRadioFirmwareVersion));
      return SystemInfo.cb_getRadioFirmwareVersion;
    }

    private static IntPtr n_GetRadioFirmwareVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).RadioFirmwareVersion);
    }

    public virtual unsafe string? RadioFirmwareVersion
    {
      [Register("getRadioFirmwareVersion", "()Ljava/lang/String;", "GetGetRadioFirmwareVersionHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getRadioFirmwareVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetReaderLocationHandler()
    {
      if ((object) SystemInfo.cb_getReaderLocation == null)
        SystemInfo.cb_getReaderLocation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetReaderLocation));
      return SystemInfo.cb_getReaderLocation;
    }

    private static IntPtr n_GetReaderLocation(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).ReaderLocation);
    }

    public virtual unsafe string? ReaderLocation
    {
      [Register("getReaderLocation", "()Ljava/lang/String;", "GetGetReaderLocationHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderLocation.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetReaderNameHandler()
    {
      if ((object) SystemInfo.cb_getReaderName == null)
        SystemInfo.cb_getReaderName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetReaderName));
      return SystemInfo.cb_getReaderName;
    }

    private static IntPtr n_GetReaderName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).ReaderName);
    }

    public virtual unsafe string? ReaderName
    {
      [Register("getReaderName", "()Ljava/lang/String;", "GetGetReaderNameHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUpTimeHandler()
    {
      if ((object) SystemInfo.cb_getUpTime == null)
        SystemInfo.cb_getUpTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SystemInfo.n_GetUpTime));
      return SystemInfo.cb_getUpTime;
    }

    private static IntPtr n_GetUpTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).UpTime);
    }

    public virtual unsafe string? UpTime
    {
      [Register("getUpTime", "()Ljava/lang/String;", "GetGetUpTimeHandler")] get
      {
        JniObjectReference jniObjectReference = SystemInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getUpTime.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetSetM_sRadioFirmwareVersion_Ljava_lang_String_Handler()
    {
      if ((object) SystemInfo.cb_setM_sRadioFirmwareVersion_Ljava_lang_String_ == null)
        SystemInfo.cb_setM_sRadioFirmwareVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SystemInfo.n_SetM_sRadioFirmwareVersion_Ljava_lang_String_));
      return SystemInfo.cb_setM_sRadioFirmwareVersion_Ljava_lang_String_;
    }

    private static void n_SetM_sRadioFirmwareVersion_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sRadioFirmwareVersion)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetM_sRadioFirmwareVersion(JNIEnv.GetString(native_m_sRadioFirmwareVersion, (JniHandleOwnership) 0));
    }

    [Register("setM_sRadioFirmwareVersion", "(Ljava/lang/String;)V", "GetSetM_sRadioFirmwareVersion_Ljava_lang_String_Handler")]
    public virtual unsafe void SetM_sRadioFirmwareVersion(string? m_sRadioFirmwareVersion)
    {
      IntPtr num = JNIEnv.NewString(m_sRadioFirmwareVersion);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_sRadioFirmwareVersion.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetM_sReaderLocation_Ljava_lang_String_Handler()
    {
      if ((object) SystemInfo.cb_setM_sReaderLocation_Ljava_lang_String_ == null)
        SystemInfo.cb_setM_sReaderLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SystemInfo.n_SetM_sReaderLocation_Ljava_lang_String_));
      return SystemInfo.cb_setM_sReaderLocation_Ljava_lang_String_;
    }

    private static void n_SetM_sReaderLocation_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sReaderLocation)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetM_sReaderLocation(JNIEnv.GetString(native_m_sReaderLocation, (JniHandleOwnership) 0));
    }

    [Register("setM_sReaderLocation", "(Ljava/lang/String;)V", "GetSetM_sReaderLocation_Ljava_lang_String_Handler")]
    public virtual unsafe void SetM_sReaderLocation(string? m_sReaderLocation)
    {
      IntPtr num = JNIEnv.NewString(m_sReaderLocation);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_sReaderLocation.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetM_sReaderName_Ljava_lang_String_Handler()
    {
      if ((object) SystemInfo.cb_setM_sReaderName_Ljava_lang_String_ == null)
        SystemInfo.cb_setM_sReaderName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SystemInfo.n_SetM_sReaderName_Ljava_lang_String_));
      return SystemInfo.cb_setM_sReaderName_Ljava_lang_String_;
    }

    private static void n_SetM_sReaderName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sReaderName)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetM_sReaderName(JNIEnv.GetString(native_m_sReaderName, (JniHandleOwnership) 0));
    }

    [Register("setM_sReaderName", "(Ljava/lang/String;)V", "GetSetM_sReaderName_Ljava_lang_String_Handler")]
    public virtual unsafe void SetM_sReaderName(string? m_sReaderName)
    {
      IntPtr num = JNIEnv.NewString(m_sReaderName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_sReaderName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetM_sUpTime_Ljava_lang_String_Handler()
    {
      if ((object) SystemInfo.cb_setM_sUpTime_Ljava_lang_String_ == null)
        SystemInfo.cb_setM_sUpTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SystemInfo.n_SetM_sUpTime_Ljava_lang_String_));
      return SystemInfo.cb_setM_sUpTime_Ljava_lang_String_;
    }

    private static void n_SetM_sUpTime_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sUpTime)
    {
      Object.GetObject<SystemInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetM_sUpTime(JNIEnv.GetString(native_m_sUpTime, (JniHandleOwnership) 0));
    }

    [Register("setM_sUpTime", "(Ljava/lang/String;)V", "GetSetM_sUpTime_Ljava_lang_String_Handler")]
    public virtual unsafe void SetM_sUpTime(string? m_sUpTime)
    {
      IntPtr num = JNIEnv.NewString(m_sUpTime);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        SystemInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setM_sUpTime.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
