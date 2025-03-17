// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.IUsbSerialPortInvoker
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
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/UsbSerialPort", DoNotGenerateAcw = true)]
  internal class IUsbSerialPortInvoker : 
    Object,
    IUsbSerialPort,
    ICloseable,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/UsbSerialPort", typeof (IUsbSerialPortInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_getCD;
    private IntPtr id_getCD;
    private static Delegate? cb_getCTS;
    private IntPtr id_getCTS;
    private static Delegate? cb_getControlLines;
    private IntPtr id_getControlLines;
    private static Delegate? cb_getDSR;
    private IntPtr id_getDSR;
    private static Delegate? cb_getDTR;
    private static Delegate? cb_setDTR_Z;
    private IntPtr id_getDTR;
    private IntPtr id_setDTR_Z;
    private static Delegate? cb_getDevice;
    private IntPtr id_getDevice;
    private static Delegate? cb_getDriver;
    private IntPtr id_getDriver;
    private static Delegate? cb_isOpen;
    private IntPtr id_isOpen;
    private static Delegate? cb_getPortNumber;
    private IntPtr id_getPortNumber;
    private static Delegate? cb_getRI;
    private IntPtr id_getRI;
    private static Delegate? cb_getRTS;
    private static Delegate? cb_setRTS_Z;
    private IntPtr id_getRTS;
    private IntPtr id_setRTS_Z;
    private static Delegate? cb_getSerial;
    private IntPtr id_getSerial;
    private static Delegate? cb_getSupportedControlLines;
    private IntPtr id_getSupportedControlLines;
    private static Delegate? cb_close;
    private IntPtr id_close;
    private static Delegate? cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
    private IntPtr id_open_Landroid_hardware_usb_UsbDeviceConnection_;
    private static Delegate? cb_purgeHwBuffers_ZZ;
    private IntPtr id_purgeHwBuffers_ZZ;
    private static Delegate? cb_read_arrayBI;
    private IntPtr id_read_arrayBI;
    private static Delegate? cb_setParameters_IIII;
    private IntPtr id_setParameters_IIII;
    private static Delegate? cb_write_arrayBI;
    private IntPtr id_write_arrayBI;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IUsbSerialPortInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IUsbSerialPortInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IUsbSerialPortInvoker._members.ManagedPeerType;

    public static IUsbSerialPort? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IUsbSerialPort>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IUsbSerialPortInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.commoniolib.UsbSerialPort'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IUsbSerialPortInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IUsbSerialPortInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetGetCDHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getCD == null)
        IUsbSerialPortInvoker.cb_getCD = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetCD));
      return IUsbSerialPortInvoker.cb_getCD;
    }

    private static bool n_GetCD(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CD;
    }

    public bool CD
    {
      get
      {
        if (this.id_getCD == IntPtr.Zero)
          this.id_getCD = JNIEnv.GetMethodID(this.class_ref, "getCD", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getCD);
      }
    }

    private static Delegate GetGetCTSHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getCTS == null)
        IUsbSerialPortInvoker.cb_getCTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetCTS));
      return IUsbSerialPortInvoker.cb_getCTS;
    }

    private static bool n_GetCTS(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CTS;
    }

    public bool CTS
    {
      get
      {
        if (this.id_getCTS == IntPtr.Zero)
          this.id_getCTS = JNIEnv.GetMethodID(this.class_ref, "getCTS", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getCTS);
      }
    }

    private static Delegate GetGetControlLinesHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getControlLines == null)
        IUsbSerialPortInvoker.cb_getControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialPortInvoker.n_GetControlLines));
      return IUsbSerialPortInvoker.cb_getControlLines;
    }

    private static IntPtr n_GetControlLines(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).ControlLines);
    }

    public EnumSet? ControlLines
    {
      get
      {
        if (this.id_getControlLines == IntPtr.Zero)
          this.id_getControlLines = JNIEnv.GetMethodID(this.class_ref, "getControlLines", "()Ljava/util/EnumSet;");
        return Object.GetObject<EnumSet>(JNIEnv.CallObjectMethod(this.Handle, this.id_getControlLines), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDSRHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getDSR == null)
        IUsbSerialPortInvoker.cb_getDSR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetDSR));
      return IUsbSerialPortInvoker.cb_getDSR;
    }

    private static bool n_GetDSR(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DSR;
    }

    public bool DSR
    {
      get
      {
        if (this.id_getDSR == IntPtr.Zero)
          this.id_getDSR = JNIEnv.GetMethodID(this.class_ref, "getDSR", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getDSR);
      }
    }

    private static Delegate GetGetDTRHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getDTR == null)
        IUsbSerialPortInvoker.cb_getDTR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetDTR));
      return IUsbSerialPortInvoker.cb_getDTR;
    }

    private static bool n_GetDTR(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR;
    }

    private static Delegate GetSetDTR_ZHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_setDTR_Z == null)
        IUsbSerialPortInvoker.cb_setDTR_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(IUsbSerialPortInvoker.n_SetDTR_Z));
      return IUsbSerialPortInvoker.cb_setDTR_Z;
    }

    private static void n_SetDTR_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR = p0;
    }

    public unsafe bool DTR
    {
      get
      {
        if (this.id_getDTR == IntPtr.Zero)
          this.id_getDTR = JNIEnv.GetMethodID(this.class_ref, "getDTR", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getDTR);
      }
      set
      {
        if (this.id_setDTR_Z == IntPtr.Zero)
          this.id_setDTR_Z = JNIEnv.GetMethodID(this.class_ref, "setDTR", "(Z)V");
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(value)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_setDTR_Z, jvaluePtr);
      }
    }

    private static Delegate GetGetDeviceHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getDevice == null)
        IUsbSerialPortInvoker.cb_getDevice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialPortInvoker.n_GetDevice));
      return IUsbSerialPortInvoker.cb_getDevice;
    }

    private static IntPtr n_GetDevice(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Device);
    }

    public UsbDevice? Device
    {
      get
      {
        if (this.id_getDevice == IntPtr.Zero)
          this.id_getDevice = JNIEnv.GetMethodID(this.class_ref, "getDevice", "()Landroid/hardware/usb/UsbDevice;");
        return Object.GetObject<UsbDevice>(JNIEnv.CallObjectMethod(this.Handle, this.id_getDevice), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDriverHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getDriver == null)
        IUsbSerialPortInvoker.cb_getDriver = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialPortInvoker.n_GetDriver));
      return IUsbSerialPortInvoker.cb_getDriver;
    }

    private static IntPtr n_GetDriver(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Driver);
    }

    public IUsbSerialDriver? Driver
    {
      get
      {
        if (this.id_getDriver == IntPtr.Zero)
          this.id_getDriver = JNIEnv.GetMethodID(this.class_ref, "getDriver", "()Lcom/zebra/commoniolib/UsbSerialDriver;");
        return Object.GetObject<IUsbSerialDriver>(JNIEnv.CallObjectMethod(this.Handle, this.id_getDriver), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsOpenHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_isOpen == null)
        IUsbSerialPortInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_IsOpen));
      return IUsbSerialPortInvoker.cb_isOpen;
    }

    private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).IsOpen;
    }

    public bool IsOpen
    {
      get
      {
        if (this.id_isOpen == IntPtr.Zero)
          this.id_isOpen = JNIEnv.GetMethodID(this.class_ref, "isOpen", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_isOpen);
      }
    }

    private static Delegate GetGetPortNumberHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getPortNumber == null)
        IUsbSerialPortInvoker.cb_getPortNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IUsbSerialPortInvoker.n_GetPortNumber));
      return IUsbSerialPortInvoker.cb_getPortNumber;
    }

    private static int n_GetPortNumber(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).PortNumber;
    }

    public int PortNumber
    {
      get
      {
        if (this.id_getPortNumber == IntPtr.Zero)
          this.id_getPortNumber = JNIEnv.GetMethodID(this.class_ref, "getPortNumber", "()I");
        return JNIEnv.CallIntMethod(this.Handle, this.id_getPortNumber);
      }
    }

    private static Delegate GetGetRIHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getRI == null)
        IUsbSerialPortInvoker.cb_getRI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetRI));
      return IUsbSerialPortInvoker.cb_getRI;
    }

    private static bool n_GetRI(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RI;
    }

    public bool RI
    {
      get
      {
        if (this.id_getRI == IntPtr.Zero)
          this.id_getRI = JNIEnv.GetMethodID(this.class_ref, "getRI", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getRI);
      }
    }

    private static Delegate GetGetRTSHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getRTS == null)
        IUsbSerialPortInvoker.cb_getRTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IUsbSerialPortInvoker.n_GetRTS));
      return IUsbSerialPortInvoker.cb_getRTS;
    }

    private static bool n_GetRTS(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS;
    }

    private static Delegate GetSetRTS_ZHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_setRTS_Z == null)
        IUsbSerialPortInvoker.cb_setRTS_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(IUsbSerialPortInvoker.n_SetRTS_Z));
      return IUsbSerialPortInvoker.cb_setRTS_Z;
    }

    private static void n_SetRTS_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS = p0;
    }

    public unsafe bool RTS
    {
      get
      {
        if (this.id_getRTS == IntPtr.Zero)
          this.id_getRTS = JNIEnv.GetMethodID(this.class_ref, "getRTS", "()Z");
        return JNIEnv.CallBooleanMethod(this.Handle, this.id_getRTS);
      }
      set
      {
        if (this.id_setRTS_Z == IntPtr.Zero)
          this.id_setRTS_Z = JNIEnv.GetMethodID(this.class_ref, "setRTS", "(Z)V");
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(value)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_setRTS_Z, jvaluePtr);
      }
    }

    private static Delegate GetGetSerialHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getSerial == null)
        IUsbSerialPortInvoker.cb_getSerial = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialPortInvoker.n_GetSerial));
      return IUsbSerialPortInvoker.cb_getSerial;
    }

    private static IntPtr n_GetSerial(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Serial);
    }

    public string? Serial
    {
      get
      {
        if (this.id_getSerial == IntPtr.Zero)
          this.id_getSerial = JNIEnv.GetMethodID(this.class_ref, "getSerial", "()Ljava/lang/String;");
        return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, this.id_getSerial), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSupportedControlLinesHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_getSupportedControlLines == null)
        IUsbSerialPortInvoker.cb_getSupportedControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialPortInvoker.n_GetSupportedControlLines));
      return IUsbSerialPortInvoker.cb_getSupportedControlLines;
    }

    private static IntPtr n_GetSupportedControlLines(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SupportedControlLines);
    }

    public EnumSet? SupportedControlLines
    {
      get
      {
        if (this.id_getSupportedControlLines == IntPtr.Zero)
          this.id_getSupportedControlLines = JNIEnv.GetMethodID(this.class_ref, "getSupportedControlLines", "()Ljava/util/EnumSet;");
        return Object.GetObject<EnumSet>(JNIEnv.CallObjectMethod(this.Handle, this.id_getSupportedControlLines), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetCloseHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_close == null)
        IUsbSerialPortInvoker.cb_close = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(IUsbSerialPortInvoker.n_Close));
      return IUsbSerialPortInvoker.cb_close;
    }

    private static void n_Close(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Close();
    }

    public void Close()
    {
      if (this.id_close == IntPtr.Zero)
        this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
      JNIEnv.CallVoidMethod(this.Handle, this.id_close);
    }

    private static Delegate GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler()
    {
      if ((object) IUsbSerialPortInvoker.cb_open_Landroid_hardware_usb_UsbDeviceConnection_ == null)
        IUsbSerialPortInvoker.cb_open_Landroid_hardware_usb_UsbDeviceConnection_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IUsbSerialPortInvoker.n_Open_Landroid_hardware_usb_UsbDeviceConnection_));
      return IUsbSerialPortInvoker.cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
    }

    private static void n_Open_Landroid_hardware_usb_UsbDeviceConnection_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Open(Object.GetObject<UsbDeviceConnection>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void Open(UsbDeviceConnection? p0)
    {
      if (this.id_open_Landroid_hardware_usb_UsbDeviceConnection_ == IntPtr.Zero)
        this.id_open_Landroid_hardware_usb_UsbDeviceConnection_ = JNIEnv.GetMethodID(this.class_ref, "open", "(Landroid/hardware/usb/UsbDeviceConnection;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_open_Landroid_hardware_usb_UsbDeviceConnection_, jvaluePtr);
    }

    private static Delegate GetPurgeHwBuffers_ZZHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_purgeHwBuffers_ZZ == null)
        IUsbSerialPortInvoker.cb_purgeHwBuffers_ZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZZ_Z(IUsbSerialPortInvoker.n_PurgeHwBuffers_ZZ));
      return IUsbSerialPortInvoker.cb_purgeHwBuffers_ZZ;
    }

    private static bool n_PurgeHwBuffers_ZZ(IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
    {
      return Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).PurgeHwBuffers(p0, p1);
    }

    public unsafe bool PurgeHwBuffers(bool p0, bool p1)
    {
      if (this.id_purgeHwBuffers_ZZ == IntPtr.Zero)
        this.id_purgeHwBuffers_ZZ = JNIEnv.GetMethodID(this.class_ref, "purgeHwBuffers", "(ZZ)Z");
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(p0),
        new JValue(p1)
      };
      return JNIEnv.CallBooleanMethod(this.Handle, this.id_purgeHwBuffers_ZZ, jvaluePtr);
    }

    private static Delegate GetRead_arrayBIHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_read_arrayBI == null)
        IUsbSerialPortInvoker.cb_read_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(IUsbSerialPortInvoker.n_Read_arrayBI));
      return IUsbSerialPortInvoker.cb_read_arrayBI;
    }

    private static int n_Read_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      IUsbSerialPort usbSerialPort = Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      int num = usbSerialPort.Read(p0, p1_1);
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_p0);
      return num;
    }

    public unsafe int Read(byte[]? p0, int p1)
    {
      if (this.id_read_arrayBI == IntPtr.Zero)
        this.id_read_arrayBI = JNIEnv.GetMethodID(this.class_ref, "read", "([BI)I");
      IntPtr num1 = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(num1),
        new JValue(p1)
      };
      int num2 = JNIEnv.CallIntMethod(this.Handle, this.id_read_arrayBI, jvaluePtr);
      if (p0 == null)
        return num2;
      JNIEnv.CopyArray(num1, p0);
      JNIEnv.DeleteLocalRef(num1);
      return num2;
    }

    private static Delegate GetSetParameters_IIIIHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_setParameters_IIII == null)
        IUsbSerialPortInvoker.cb_setParameters_IIII = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIIII_V(IUsbSerialPortInvoker.n_SetParameters_IIII));
      return IUsbSerialPortInvoker.cb_setParameters_IIII;
    }

    private static void n_SetParameters_IIII(
      IntPtr jnienv,
      IntPtr native__this,
      int p0,
      int p1,
      int p2,
      int p3)
    {
      Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SetParameters(p0, p1, p2, p3);
    }

    public unsafe void SetParameters(int p0, int p1, int p2, int p3)
    {
      if (this.id_setParameters_IIII == IntPtr.Zero)
        this.id_setParameters_IIII = JNIEnv.GetMethodID(this.class_ref, "setParameters", "(IIII)V");
      JValue* jvaluePtr = stackalloc JValue[4]
      {
        new JValue(p0),
        new JValue(p1),
        new JValue(p2),
        new JValue(p3)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_setParameters_IIII, jvaluePtr);
    }

    private static Delegate GetWrite_arrayBIHandler()
    {
      if ((object) IUsbSerialPortInvoker.cb_write_arrayBI == null)
        IUsbSerialPortInvoker.cb_write_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(IUsbSerialPortInvoker.n_Write_arrayBI));
      return IUsbSerialPortInvoker.cb_write_arrayBI;
    }

    private static int n_Write_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      IUsbSerialPort usbSerialPort = Object.GetObject<IUsbSerialPort>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      int num = usbSerialPort.Write(p0, p1_1);
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_p0);
      return num;
    }

    public unsafe int Write(byte[]? p0, int p1)
    {
      if (this.id_write_arrayBI == IntPtr.Zero)
        this.id_write_arrayBI = JNIEnv.GetMethodID(this.class_ref, "write", "([BI)I");
      IntPtr num1 = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(num1),
        new JValue(p1)
      };
      int num2 = JNIEnv.CallIntMethod(this.Handle, this.id_write_arrayBI, jvaluePtr);
      if (p0 == null)
        return num2;
      JNIEnv.CopyArray(num1, p0);
      JNIEnv.DeleteLocalRef(num1);
      return num2;
    }
  }
}
