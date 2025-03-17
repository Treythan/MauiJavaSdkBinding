// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.CommonUsbSerialPort
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Hardware.Usb;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/CommonUsbSerialPort", DoNotGenerateAcw = true)]
  public abstract class CommonUsbSerialPort : 
    Object,
    IUsbSerialPort,
    ICloseable,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/CommonUsbSerialPort", typeof (CommonUsbSerialPort));
    private static Delegate? cb_getCD;
    private static Delegate? cb_getCTS;
    private static Delegate? cb_getControlLines;
    private static Delegate? cb_getDSR;
    private static Delegate? cb_getDTR;
    private static Delegate? cb_setDTR_Z;
    private static Delegate? cb_getDevice;
    private static Delegate? cb_isOpen;
    private static Delegate? cb_getPortNumber;
    private static Delegate? cb_getRI;
    private static Delegate? cb_getRTS;
    private static Delegate? cb_setRTS_Z;
    private static Delegate? cb_getSerial;
    private static Delegate? cb_getSupportedControlLines;
    private static Delegate? cb_close;
    private static Delegate? cb_closeInt;
    private static Delegate? cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
    private static Delegate? cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_;
    private static Delegate? cb_purgeHwBuffers_ZZ;
    private static Delegate? cb_read_arrayBI;
    private static Delegate? cb_readFilter_arrayBI;
    private static Delegate? cb_setParameters_IIII;
    private static Delegate? cb_write_arrayBI;
    private static Delegate? cb_getDriver;

    [Register("mConnection")]
    protected UsbDeviceConnection? MConnection
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mConnection.Landroid/hardware/usb/UsbDeviceConnection;", (IJavaPeerable) this);
        return Object.GetObject<UsbDeviceConnection>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mConnection.Landroid/hardware/usb/UsbDeviceConnection;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mDevice")]
    protected UsbDevice? MDevice
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mDevice.Landroid/hardware/usb/UsbDevice;", (IJavaPeerable) this);
        return Object.GetObject<UsbDevice>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mDevice.Landroid/hardware/usb/UsbDevice;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mPortNumber")]
    protected int MPortNumber
    {
      get
      {
        return CommonUsbSerialPort._members.InstanceFields.GetInt32Value("mPortNumber.I", (IJavaPeerable) this);
      }
      set
      {
        CommonUsbSerialPort._members.InstanceFields.SetValue("mPortNumber.I", (IJavaPeerable) this, value);
      }
    }

    [Register("mReadEndpoint")]
    protected UsbEndpoint? MReadEndpoint
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mReadEndpoint.Landroid/hardware/usb/UsbEndpoint;", (IJavaPeerable) this);
        return Object.GetObject<UsbEndpoint>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mReadEndpoint.Landroid/hardware/usb/UsbEndpoint;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mUsbRequest")]
    protected UsbRequest? MUsbRequest
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mUsbRequest.Landroid/hardware/usb/UsbRequest;", (IJavaPeerable) this);
        return Object.GetObject<UsbRequest>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mUsbRequest.Landroid/hardware/usb/UsbRequest;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mWriteBuffer")]
    protected IList<byte>? MWriteBuffer
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mWriteBuffer.[B", (IJavaPeerable) this);
        return (IList<byte>) JavaArray<byte>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<byte>.ToLocalJniHandle(value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mWriteBuffer.[B", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mWriteBufferLock")]
    protected Object? MWriteBufferLock
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mWriteBufferLock.Ljava/lang/Object;", (IJavaPeerable) this);
        return Object.GetObject<Object>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mWriteBufferLock.Ljava/lang/Object;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mWriteEndpoint")]
    protected UsbEndpoint? MWriteEndpoint
    {
      get
      {
        JniObjectReference objectValue = CommonUsbSerialPort._members.InstanceFields.GetObjectValue("mWriteEndpoint.Landroid/hardware/usb/UsbEndpoint;", (IJavaPeerable) this);
        return Object.GetObject<UsbEndpoint>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          CommonUsbSerialPort._members.InstanceFields.SetValue("mWriteEndpoint.Landroid/hardware/usb/UsbEndpoint;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = CommonUsbSerialPort._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CommonUsbSerialPort._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CommonUsbSerialPort._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CommonUsbSerialPort._members.ManagedPeerType;

    protected CommonUsbSerialPort(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Landroid/hardware/usb/UsbDevice;I)V", "")]
    public unsafe CommonUsbSerialPort(UsbDevice? device, int portNumber)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(device == null ? IntPtr.Zero : ((Object) device).Handle),
          new JniArgumentValue(portNumber)
        };
        JniObjectReference instance = CommonUsbSerialPort._members.InstanceMethods.StartCreateInstance("(Landroid/hardware/usb/UsbDevice;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        CommonUsbSerialPort._members.InstanceMethods.FinishCreateInstance("(Landroid/hardware/usb/UsbDevice;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) device);
      }
    }

    private static Delegate GetGetCDHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getCD == null)
        CommonUsbSerialPort.cb_getCD = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetCD));
      return CommonUsbSerialPort.cb_getCD;
    }

    private static bool n_GetCD(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CD;
    }

    public abstract bool CD { [Register("getCD", "()Z", "GetGetCDHandler")] get; }

    private static Delegate GetGetCTSHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getCTS == null)
        CommonUsbSerialPort.cb_getCTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetCTS));
      return CommonUsbSerialPort.cb_getCTS;
    }

    private static bool n_GetCTS(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CTS;
    }

    public abstract bool CTS { [Register("getCTS", "()Z", "GetGetCTSHandler")] get; }

    private static Delegate GetGetControlLinesHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getControlLines == null)
        CommonUsbSerialPort.cb_getControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommonUsbSerialPort.n_GetControlLines));
      return CommonUsbSerialPort.cb_getControlLines;
    }

    private static IntPtr n_GetControlLines(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).ControlLines);
    }

    public abstract EnumSet? ControlLines { [Register("getControlLines", "()Ljava/util/EnumSet;", "GetGetControlLinesHandler")] get; }

    private static Delegate GetGetDSRHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getDSR == null)
        CommonUsbSerialPort.cb_getDSR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetDSR));
      return CommonUsbSerialPort.cb_getDSR;
    }

    private static bool n_GetDSR(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DSR;
    }

    public abstract bool DSR { [Register("getDSR", "()Z", "GetGetDSRHandler")] get; }

    private static Delegate GetGetDTRHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getDTR == null)
        CommonUsbSerialPort.cb_getDTR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetDTR));
      return CommonUsbSerialPort.cb_getDTR;
    }

    private static bool n_GetDTR(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR;
    }

    private static Delegate GetSetDTR_ZHandler()
    {
      if ((object) CommonUsbSerialPort.cb_setDTR_Z == null)
        CommonUsbSerialPort.cb_setDTR_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(CommonUsbSerialPort.n_SetDTR_Z));
      return CommonUsbSerialPort.cb_setDTR_Z;
    }

    private static void n_SetDTR_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR = p0;
    }

    public abstract bool DTR { [Register("getDTR", "()Z", "GetGetDTRHandler")] get; [Register("setDTR", "(Z)V", "GetSetDTR_ZHandler")] set; }

    private static Delegate GetGetDeviceHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getDevice == null)
        CommonUsbSerialPort.cb_getDevice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommonUsbSerialPort.n_GetDevice));
      return CommonUsbSerialPort.cb_getDevice;
    }

    private static IntPtr n_GetDevice(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Device);
    }

    public virtual unsafe UsbDevice? Device
    {
      [Register("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler")] get
      {
        JniObjectReference jniObjectReference = CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualObjectMethod("getDevice.()Landroid/hardware/usb/UsbDevice;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<UsbDevice>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsOpenHandler()
    {
      if ((object) CommonUsbSerialPort.cb_isOpen == null)
        CommonUsbSerialPort.cb_isOpen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_IsOpen));
      return CommonUsbSerialPort.cb_isOpen;
    }

    private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).IsOpen;
    }

    public virtual unsafe bool IsOpen
    {
      [Register("isOpen", "()Z", "GetIsOpenHandler")] get
      {
        return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("isOpen.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetPortNumberHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getPortNumber == null)
        CommonUsbSerialPort.cb_getPortNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(CommonUsbSerialPort.n_GetPortNumber));
      return CommonUsbSerialPort.cb_getPortNumber;
    }

    private static int n_GetPortNumber(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).PortNumber;
    }

    public virtual unsafe int PortNumber
    {
      [Register("getPortNumber", "()I", "GetGetPortNumberHandler")] get
      {
        return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualInt32Method("getPortNumber.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRIHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getRI == null)
        CommonUsbSerialPort.cb_getRI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetRI));
      return CommonUsbSerialPort.cb_getRI;
    }

    private static bool n_GetRI(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RI;
    }

    public abstract bool RI { [Register("getRI", "()Z", "GetGetRIHandler")] get; }

    private static Delegate GetGetRTSHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getRTS == null)
        CommonUsbSerialPort.cb_getRTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CommonUsbSerialPort.n_GetRTS));
      return CommonUsbSerialPort.cb_getRTS;
    }

    private static bool n_GetRTS(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS;
    }

    private static Delegate GetSetRTS_ZHandler()
    {
      if ((object) CommonUsbSerialPort.cb_setRTS_Z == null)
        CommonUsbSerialPort.cb_setRTS_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(CommonUsbSerialPort.n_SetRTS_Z));
      return CommonUsbSerialPort.cb_setRTS_Z;
    }

    private static void n_SetRTS_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS = p0;
    }

    public abstract bool RTS { [Register("getRTS", "()Z", "GetGetRTSHandler")] get; [Register("setRTS", "(Z)V", "GetSetRTS_ZHandler")] set; }

    private static Delegate GetGetSerialHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getSerial == null)
        CommonUsbSerialPort.cb_getSerial = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommonUsbSerialPort.n_GetSerial));
      return CommonUsbSerialPort.cb_getSerial;
    }

    private static IntPtr n_GetSerial(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Serial);
    }

    public virtual unsafe string? Serial
    {
      [Register("getSerial", "()Ljava/lang/String;", "GetGetSerialHandler")] get
      {
        JniObjectReference jniObjectReference = CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualObjectMethod("getSerial.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSupportedControlLinesHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getSupportedControlLines == null)
        CommonUsbSerialPort.cb_getSupportedControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommonUsbSerialPort.n_GetSupportedControlLines));
      return CommonUsbSerialPort.cb_getSupportedControlLines;
    }

    private static IntPtr n_GetSupportedControlLines(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SupportedControlLines);
    }

    public abstract EnumSet? SupportedControlLines { [Register("getSupportedControlLines", "()Ljava/util/EnumSet;", "GetGetSupportedControlLinesHandler")] get; }

    private static Delegate GetCloseHandler()
    {
      if ((object) CommonUsbSerialPort.cb_close == null)
        CommonUsbSerialPort.cb_close = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(CommonUsbSerialPort.n_Close));
      return CommonUsbSerialPort.cb_close;
    }

    private static void n_Close(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Close();
    }

    [Register("close", "()V", "GetCloseHandler")]
    public virtual unsafe void Close()
    {
      CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetCloseIntHandler()
    {
      if ((object) CommonUsbSerialPort.cb_closeInt == null)
        CommonUsbSerialPort.cb_closeInt = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(CommonUsbSerialPort.n_CloseInt));
      return CommonUsbSerialPort.cb_closeInt;
    }

    private static void n_CloseInt(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CloseInt();
    }

    [Register("closeInt", "()V", "GetCloseIntHandler")]
    protected abstract void CloseInt();

    private static Delegate GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler()
    {
      if ((object) CommonUsbSerialPort.cb_open_Landroid_hardware_usb_UsbDeviceConnection_ == null)
        CommonUsbSerialPort.cb_open_Landroid_hardware_usb_UsbDeviceConnection_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(CommonUsbSerialPort.n_Open_Landroid_hardware_usb_UsbDeviceConnection_));
      return CommonUsbSerialPort.cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
    }

    private static void n_Open_Landroid_hardware_usb_UsbDeviceConnection_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_connection)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Open(Object.GetObject<UsbDeviceConnection>(native_connection, (JniHandleOwnership) 0));
    }

    [Register("open", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler")]
    public virtual unsafe void Open(UsbDeviceConnection? connection)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(connection == null ? IntPtr.Zero : ((Object) connection).Handle)
        };
        CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("open.(Landroid/hardware/usb/UsbDeviceConnection;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) connection);
      }
    }

    private static Delegate GetOpenInt_Landroid_hardware_usb_UsbDeviceConnection_Handler()
    {
      if ((object) CommonUsbSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_ == null)
        CommonUsbSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(CommonUsbSerialPort.n_OpenInt_Landroid_hardware_usb_UsbDeviceConnection_));
      return CommonUsbSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_;
    }

    private static void n_OpenInt_Landroid_hardware_usb_UsbDeviceConnection_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).OpenInt(Object.GetObject<UsbDeviceConnection>(native_p0, (JniHandleOwnership) 0));
    }

    [Register("openInt", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpenInt_Landroid_hardware_usb_UsbDeviceConnection_Handler")]
    protected abstract void OpenInt(UsbDeviceConnection? p0);

    private static Delegate GetPurgeHwBuffers_ZZHandler()
    {
      if ((object) CommonUsbSerialPort.cb_purgeHwBuffers_ZZ == null)
        CommonUsbSerialPort.cb_purgeHwBuffers_ZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZZ_Z(CommonUsbSerialPort.n_PurgeHwBuffers_ZZ));
      return CommonUsbSerialPort.cb_purgeHwBuffers_ZZ;
    }

    private static bool n_PurgeHwBuffers_ZZ(
      IntPtr jnienv,
      IntPtr native__this,
      bool purgeWriteBuffers,
      bool purgeReadBuffers)
    {
      return Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).PurgeHwBuffers(purgeWriteBuffers, purgeReadBuffers);
    }

    [Register("purgeHwBuffers", "(ZZ)Z", "GetPurgeHwBuffers_ZZHandler")]
    public virtual unsafe bool PurgeHwBuffers(bool purgeWriteBuffers, bool purgeReadBuffers)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
      {
        new JniArgumentValue(purgeWriteBuffers),
        new JniArgumentValue(purgeReadBuffers)
      };
      return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("purgeHwBuffers.(ZZ)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetRead_arrayBIHandler()
    {
      if ((object) CommonUsbSerialPort.cb_read_arrayBI == null)
        CommonUsbSerialPort.cb_read_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(CommonUsbSerialPort.n_Read_arrayBI));
      return CommonUsbSerialPort.cb_read_arrayBI;
    }

    private static int n_Read_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_dest,
      int timeout)
    {
      CommonUsbSerialPort commonUsbSerialPort = Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_dest, (JniHandleOwnership) 0, typeof (byte));
      byte[] dest = array;
      int timeout1 = timeout;
      int num = commonUsbSerialPort.Read(dest, timeout1);
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_dest);
      return num;
    }

    [Register("read", "([BI)I", "GetRead_arrayBIHandler")]
    public virtual unsafe int Read(byte[]? dest, int timeout)
    {
      IntPtr num = JNIEnv.NewArray(dest);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(timeout)
        };
        return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualInt32Method("read.([BI)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (dest != null)
        {
          JNIEnv.CopyArray(num, dest);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) dest);
      }
    }

    private static Delegate GetReadFilter_arrayBIHandler()
    {
      if ((object) CommonUsbSerialPort.cb_readFilter_arrayBI == null)
        CommonUsbSerialPort.cb_readFilter_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(CommonUsbSerialPort.n_ReadFilter_arrayBI));
      return CommonUsbSerialPort.cb_readFilter_arrayBI;
    }

    private static int n_ReadFilter_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_buffer,
      int len)
    {
      CommonUsbSerialPort commonUsbSerialPort = Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_buffer, (JniHandleOwnership) 0, typeof (byte));
      byte[] buffer = array;
      int len1 = len;
      int num = commonUsbSerialPort.ReadFilter(buffer, len1);
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_buffer);
      return num;
    }

    [Register("readFilter", "([BI)I", "GetReadFilter_arrayBIHandler")]
    protected virtual unsafe int ReadFilter(byte[]? buffer, int len)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(len)
        };
        return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualInt32Method("readFilter.([BI)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }

    private static Delegate GetSetParameters_IIIIHandler()
    {
      if ((object) CommonUsbSerialPort.cb_setParameters_IIII == null)
        CommonUsbSerialPort.cb_setParameters_IIII = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIIII_V(CommonUsbSerialPort.n_SetParameters_IIII));
      return CommonUsbSerialPort.cb_setParameters_IIII;
    }

    private static void n_SetParameters_IIII(
      IntPtr jnienv,
      IntPtr native__this,
      int p0,
      int p1,
      int p2,
      int p3)
    {
      Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SetParameters(p0, p1, p2, p3);
    }

    [Register("setParameters", "(IIII)V", "GetSetParameters_IIIIHandler")]
    public abstract void SetParameters(int p0, int p1, int p2, int p3);

    [Register("setWriteBufferSize", "(I)V", "")]
    public unsafe void SetWriteBufferSize(int bufferSize)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(bufferSize)
      };
      CommonUsbSerialPort._members.InstanceMethods.InvokeNonvirtualVoidMethod("setWriteBufferSize.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetWrite_arrayBIHandler()
    {
      if ((object) CommonUsbSerialPort.cb_write_arrayBI == null)
        CommonUsbSerialPort.cb_write_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(CommonUsbSerialPort.n_Write_arrayBI));
      return CommonUsbSerialPort.cb_write_arrayBI;
    }

    private static int n_Write_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_src,
      int timeout)
    {
      CommonUsbSerialPort commonUsbSerialPort = Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_src, (JniHandleOwnership) 0, typeof (byte));
      byte[] src = array;
      int timeout1 = timeout;
      int num = commonUsbSerialPort.Write(src, timeout1);
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_src);
      return num;
    }

    [Register("write", "([BI)I", "GetWrite_arrayBIHandler")]
    public virtual unsafe int Write(byte[]? src, int timeout)
    {
      IntPtr num = JNIEnv.NewArray(src);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(timeout)
        };
        return CommonUsbSerialPort._members.InstanceMethods.InvokeVirtualInt32Method("write.([BI)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (src != null)
        {
          JNIEnv.CopyArray(num, src);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) src);
      }
    }

    private static Delegate GetGetDriverHandler()
    {
      if ((object) CommonUsbSerialPort.cb_getDriver == null)
        CommonUsbSerialPort.cb_getDriver = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CommonUsbSerialPort.n_GetDriver));
      return CommonUsbSerialPort.cb_getDriver;
    }

    private static IntPtr n_GetDriver(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CommonUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Driver);
    }

    public abstract IUsbSerialDriver? Driver { [Register("getDriver", "()Lcom/zebra/commoniolib/UsbSerialDriver;", "GetGetDriverHandler")] get; }

    public static class InterfaceConsts
    {
      [Register("DATABITS_5")]
      public const int Databits5 = 5;
      [Register("DATABITS_6")]
      public const int Databits6 = 6;
      [Register("DATABITS_7")]
      public const int Databits7 = 7;
      [Register("DATABITS_8")]
      public const int Databits8 = 8;
      [Register("FLOWCONTROL_NONE")]
      public const int FlowcontrolNone = 0;
      [Register("FLOWCONTROL_RTSCTS_IN")]
      public const int FlowcontrolRtsctsIn = 1;
      [Register("FLOWCONTROL_RTSCTS_OUT")]
      public const int FlowcontrolRtsctsOut = 2;
      [Register("FLOWCONTROL_XONXOFF_IN")]
      public const int FlowcontrolXonxoffIn = 4;
      [Register("FLOWCONTROL_XONXOFF_OUT")]
      public const int FlowcontrolXonxoffOut = 8;
      [Register("PARITY_EVEN")]
      public const int ParityEven = 2;
      [Register("PARITY_MARK")]
      public const int ParityMark = 3;
      [Register("PARITY_NONE")]
      public const int ParityNone = 0;
      [Register("PARITY_ODD")]
      public const int ParityOdd = 1;
      [Register("PARITY_SPACE")]
      public const int ParitySpace = 4;
      [Register("STOPBITS_1")]
      public const int Stopbits1 = 1;
      [Register("STOPBITS_1_5")]
      public const int Stopbits15 = 3;
      [Register("STOPBITS_2")]
      public const int Stopbits2 = 2;
    }
  }
}
