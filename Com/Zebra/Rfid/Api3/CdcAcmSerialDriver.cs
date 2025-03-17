// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CdcAcmSerialDriver
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Hardware.Usb;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/CdcAcmSerialDriver", DoNotGenerateAcw = true)]
  public class CdcAcmSerialDriver : Object, IUsbSerialDriver, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CdcAcmSerialDriver", typeof (CdcAcmSerialDriver));
    private static Delegate? cb_getDevice;
    private static Delegate? cb_getPorts;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = CdcAcmSerialDriver._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CdcAcmSerialDriver._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CdcAcmSerialDriver._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CdcAcmSerialDriver._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CdcAcmSerialDriver._members.ManagedPeerType;

    protected CdcAcmSerialDriver(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Landroid/hardware/usb/UsbDevice;)V", "")]
    public unsafe CdcAcmSerialDriver(UsbDevice? device)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(device == null ? IntPtr.Zero : ((Object) device).Handle)
        };
        JniObjectReference instance = CdcAcmSerialDriver._members.InstanceMethods.StartCreateInstance("(Landroid/hardware/usb/UsbDevice;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        CdcAcmSerialDriver._members.InstanceMethods.FinishCreateInstance("(Landroid/hardware/usb/UsbDevice;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) device);
      }
    }

    private static Delegate GetGetDeviceHandler()
    {
      if ((object) CdcAcmSerialDriver.cb_getDevice == null)
        CdcAcmSerialDriver.cb_getDevice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CdcAcmSerialDriver.n_GetDevice));
      return CdcAcmSerialDriver.cb_getDevice;
    }

    private static IntPtr n_GetDevice(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CdcAcmSerialDriver>(jnienv, native__this, (JniHandleOwnership) 0).Device);
    }

    public virtual unsafe UsbDevice? Device
    {
      [Register("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler")] get
      {
        JniObjectReference jniObjectReference = CdcAcmSerialDriver._members.InstanceMethods.InvokeVirtualObjectMethod("getDevice.()Landroid/hardware/usb/UsbDevice;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<UsbDevice>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPortsHandler()
    {
      if ((object) CdcAcmSerialDriver.cb_getPorts == null)
        CdcAcmSerialDriver.cb_getPorts = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CdcAcmSerialDriver.n_GetPorts));
      return CdcAcmSerialDriver.cb_getPorts;
    }

    private static IntPtr n_GetPorts(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<IUsbSerialPort>.ToLocalJniHandle(Object.GetObject<CdcAcmSerialDriver>(jnienv, native__this, (JniHandleOwnership) 0).Ports);
    }

    public virtual unsafe IList<IUsbSerialPort>? Ports
    {
      [Register("getPorts", "()Ljava/util/List;", "GetGetPortsHandler")] get
      {
        JniObjectReference jniObjectReference = CdcAcmSerialDriver._members.InstanceMethods.InvokeVirtualObjectMethod("getPorts.()Ljava/util/List;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JavaList<IUsbSerialPort>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public static unsafe IDictionary<Integer, int[]>? SupportedDevices
    {
      [Register("getSupportedDevices", "()Ljava/util/Map;", "")] get
      {
        JniObjectReference jniObjectReference = CdcAcmSerialDriver._members.StaticMethods.InvokeObjectMethod("getSupportedDevices.()Ljava/util/Map;", (JniArgumentValue*) null);
        return JavaDictionary<Integer, int[]>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("com/zebra/rfid/api3/CdcAcmSerialDriver$CdcAcmSerialPort", DoNotGenerateAcw = true)]
    public class CdcAcmSerialPort : CommonUsbSerialPort
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CdcAcmSerialDriver$CdcAcmSerialPort", typeof (CdcAcmSerialDriver.CdcAcmSerialPort));
      private static Delegate? cb_getCD;
      private static Delegate? cb_getCTS;
      private static Delegate? cb_getControlLines;
      private static Delegate? cb_getDSR;
      private static Delegate? cb_getDTR;
      private static Delegate? cb_setDTR_Z;
      private static Delegate? cb_getDriver;
      private static Delegate? cb_getRI;
      private static Delegate? cb_getRTS;
      private static Delegate? cb_setRTS_Z;
      private static Delegate? cb_getSupportedControlLines;
      private static Delegate? cb_closeInt;
      private static Delegate? cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_;
      private static Delegate? cb_setParameters_IIII;

      internal new static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = CdcAcmSerialDriver.CdcAcmSerialPort._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override JniPeerMembers JniPeerMembers => CdcAcmSerialDriver.CdcAcmSerialPort._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected override IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = CdcAcmSerialDriver.CdcAcmSerialPort._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected override Type ThresholdType
      {
        get => CdcAcmSerialDriver.CdcAcmSerialPort._members.ManagedPeerType;
      }

      protected CdcAcmSerialPort(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/CdcAcmSerialDriver;Landroid/hardware/usb/UsbDevice;I)V", "")]
      public unsafe CdcAcmSerialPort(CdcAcmSerialDriver? __self, UsbDevice? device, int portNumber)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Landroid/hardware/usb/UsbDevice;I)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(device == null ? IntPtr.Zero : ((Object) device).Handle),
            new JniArgumentValue(portNumber)
          };
          JniObjectReference instance = CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) device);
        }
      }

      private static Delegate GetGetCDHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCD == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCD = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetCD));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCD;
      }

      private static bool n_GetCD(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CD;
      }

      public override unsafe bool CD
      {
        [Register("getCD", "()Z", "GetGetCDHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getCD.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetCTSHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCTS == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetCTS));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getCTS;
      }

      private static bool n_GetCTS(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CTS;
      }

      public override unsafe bool CTS
      {
        [Register("getCTS", "()Z", "GetGetCTSHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getCTS.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetControlLinesHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getControlLines == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetControlLines));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getControlLines;
      }

      private static IntPtr n_GetControlLines(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).ControlLines);
      }

      public override unsafe EnumSet? ControlLines
      {
        [Register("getControlLines", "()Ljava/util/EnumSet;", "GetGetControlLinesHandler")] get
        {
          JniObjectReference jniObjectReference = CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualObjectMethod("getControlLines.()Ljava/util/EnumSet;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<EnumSet>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetDSRHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDSR == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDSR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetDSR));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDSR;
      }

      private static bool n_GetDSR(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DSR;
      }

      public override unsafe bool DSR
      {
        [Register("getDSR", "()Z", "GetGetDSRHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getDSR.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetDTRHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDTR == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDTR = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetDTR));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDTR;
      }

      private static bool n_GetDTR(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR;
      }

      private static Delegate GetSetDTR_ZHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_setDTR_Z == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_setDTR_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(CdcAcmSerialDriver.CdcAcmSerialPort.n_SetDTR_Z));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_setDTR_Z;
      }

      private static void n_SetDTR_Z(IntPtr jnienv, IntPtr native__this, bool value)
      {
        Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).DTR = value;
      }

      public override unsafe bool DTR
      {
        [Register("getDTR", "()Z", "GetGetDTRHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getDTR.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setDTR", "(Z)V", "GetSetDTR_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("setDTR.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetDriverHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDriver == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDriver = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetDriver));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getDriver;
      }

      private static IntPtr n_GetDriver(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).Driver);
      }

      public override unsafe IUsbSerialDriver? Driver
      {
        [Register("getDriver", "()Lcom/zebra/rfid/api3/UsbSerialDriver;", "GetGetDriverHandler")] get
        {
          JniObjectReference jniObjectReference = CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualObjectMethod("getDriver.()Lcom/zebra/rfid/api3/UsbSerialDriver;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<IUsbSerialDriver>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetRIHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRI == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetRI));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRI;
      }

      private static bool n_GetRI(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RI;
      }

      public override unsafe bool RI
      {
        [Register("getRI", "()Z", "GetGetRIHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getRI.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetRTSHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRTS == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRTS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetRTS));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getRTS;
      }

      private static bool n_GetRTS(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS;
      }

      private static Delegate GetSetRTS_ZHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_setRTS_Z == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_setRTS_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(CdcAcmSerialDriver.CdcAcmSerialPort.n_SetRTS_Z));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_setRTS_Z;
      }

      private static void n_SetRTS_Z(IntPtr jnienv, IntPtr native__this, bool value)
      {
        Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).RTS = value;
      }

      public override unsafe bool RTS
      {
        [Register("getRTS", "()Z", "GetGetRTSHandler")] get
        {
          return CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualBooleanMethod("getRTS.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setRTS", "(Z)V", "GetSetRTS_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("setRTS.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetSupportedControlLinesHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_getSupportedControlLines == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_getSupportedControlLines = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CdcAcmSerialDriver.CdcAcmSerialPort.n_GetSupportedControlLines));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_getSupportedControlLines;
      }

      private static IntPtr n_GetSupportedControlLines(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SupportedControlLines);
      }

      public override unsafe EnumSet? SupportedControlLines
      {
        [Register("getSupportedControlLines", "()Ljava/util/EnumSet;", "GetGetSupportedControlLinesHandler")] get
        {
          JniObjectReference jniObjectReference = CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportedControlLines.()Ljava/util/EnumSet;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<EnumSet>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetCloseIntHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_closeInt == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_closeInt = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(CdcAcmSerialDriver.CdcAcmSerialPort.n_CloseInt));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_closeInt;
      }

      private static void n_CloseInt(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).CloseInt();
      }

      [Register("closeInt", "()V", "GetCloseIntHandler")]
      protected override unsafe void CloseInt()
      {
        CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("closeInt.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetOpenInt_Landroid_hardware_usb_UsbDeviceConnection_Handler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_ == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(CdcAcmSerialDriver.CdcAcmSerialPort.n_OpenInt_Landroid_hardware_usb_UsbDeviceConnection_));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_openInt_Landroid_hardware_usb_UsbDeviceConnection_;
      }

      private static void n_OpenInt_Landroid_hardware_usb_UsbDeviceConnection_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_connection)
      {
        Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).OpenInt(Object.GetObject<UsbDeviceConnection>(native_connection, (JniHandleOwnership) 0));
      }

      [Register("openInt", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpenInt_Landroid_hardware_usb_UsbDeviceConnection_Handler")]
      protected override unsafe void OpenInt(UsbDeviceConnection? connection)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(connection == null ? IntPtr.Zero : ((Object) connection).Handle)
          };
          CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("openInt.(Landroid/hardware/usb/UsbDeviceConnection;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) connection);
        }
      }

      private static Delegate GetSetParameters_IIIIHandler()
      {
        if ((object) CdcAcmSerialDriver.CdcAcmSerialPort.cb_setParameters_IIII == null)
          CdcAcmSerialDriver.CdcAcmSerialPort.cb_setParameters_IIII = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIIII_V(CdcAcmSerialDriver.CdcAcmSerialPort.n_SetParameters_IIII));
        return CdcAcmSerialDriver.CdcAcmSerialPort.cb_setParameters_IIII;
      }

      private static void n_SetParameters_IIII(
        IntPtr jnienv,
        IntPtr native__this,
        int baudRate,
        int dataBits,
        int stopBits,
        int parity)
      {
        Object.GetObject<CdcAcmSerialDriver.CdcAcmSerialPort>(jnienv, native__this, (JniHandleOwnership) 0).SetParameters(baudRate, dataBits, stopBits, parity);
      }

      [Register("setParameters", "(IIII)V", "GetSetParameters_IIIIHandler")]
      public override unsafe void SetParameters(
        int baudRate,
        int dataBits,
        int stopBits,
        int parity)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(baudRate),
          new JniArgumentValue(dataBits),
          new JniArgumentValue(stopBits),
          new JniArgumentValue(parity)
        };
        CdcAcmSerialDriver.CdcAcmSerialPort._members.InstanceMethods.InvokeVirtualVoidMethod("setParameters.(IIII)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Register("com/zebra/rfid/api3/CdcAcmSerialDriver$UsbId", DoNotGenerateAcw = true)]
    public sealed class UsbId : Object
    {
      [Register("ARDUINO_LEONARDO")]
      public const int ArduinoLeonardo = 32822;
      [Register("ARDUINO_MEGA_2560")]
      public const int ArduinoMega2560 = 16;
      [Register("ARDUINO_MEGA_2560_R3")]
      public const int ArduinoMega2560R3 = 66;
      [Register("ARDUINO_MEGA_ADK")]
      public const int ArduinoMegaAdk = 63;
      [Register("ARDUINO_MEGA_ADK_R3")]
      public const int ArduinoMegaAdkR3 = 68;
      [Register("ARDUINO_MICRO")]
      public const int ArduinoMicro = 32823;
      [Register("ARDUINO_SERIAL_ADAPTER")]
      public const int ArduinoSerialAdapter = 59;
      [Register("ARDUINO_SERIAL_ADAPTER_R3")]
      public const int ArduinoSerialAdapterR3 = 68;
      [Register("ARDUINO_UNO")]
      public const int ArduinoUno = 1;
      [Register("ARDUINO_UNO_R3")]
      public const int ArduinoUnoR3 = 67;
      [Register("ARM_MBED")]
      public const int ArmMbed = 516;
      [Register("ATMEL_LUFA_CDC_DEMO_APP")]
      public const int AtmelLufaCdcDemoApp = 8260;
      [Register("FTDI_FT2232H")]
      public const int FtdiFt2232h = 24592;
      [Register("FTDI_FT231X")]
      public const int FtdiFt231x = 24597;
      [Register("FTDI_FT232H")]
      public const int FtdiFt232h = 24596;
      [Register("FTDI_FT232R")]
      public const int FtdiFt232r = 24577;
      [Register("FTDI_FT4232H")]
      public const int FtdiFt4232h = 24593;
      [Register("LEAFLABS_MAPLE")]
      public const int LeaflabsMaple = 4;
      [Register("PROLIFIC_PL2303")]
      public const int ProlificPl2303 = 8963;
      [Register("QINHENG_CH340")]
      public const int QinhengCh340 = 29987;
      [Register("QINHENG_CH341A")]
      public const int QinhengCh341a = 21795;
      [Register("SILABS_CP2102")]
      public const int SilabsCp2102 = 60000;
      [Register("SILABS_CP2105")]
      public const int SilabsCp2105 = 60016;
      [Register("SILABS_CP2108")]
      public const int SilabsCp2108 = 60017;
      [Register("SILABS_CP2110")]
      public const int SilabsCp2110 = 60032;
      [Register("VAN_OOIJEN_TECH_TEENSYDUINO_SERIAL")]
      public const int VanOoijenTechTeensyduinoSerial = 1155;
      [Register("VENDOR_ARDUINO")]
      public const int VendorArduino = 9025;
      [Register("VENDOR_ARM")]
      public const int VendorArm = 3368;
      [Register("VENDOR_ATMEL")]
      public const int VendorAtmel = 1003;
      [Register("VENDOR_FTDI")]
      public const int VendorFtdi = 1027;
      [Register("VENDOR_LEAFLABS")]
      public const int VendorLeaflabs = 7855;
      [Register("VENDOR_PROLIFIC")]
      public const int VendorProlific = 1659;
      [Register("VENDOR_QINHENG")]
      public const int VendorQinheng = 6790;
      [Register("VENDOR_SILABS")]
      public const int VendorSilabs = 4292;
      [Register("VENDOR_VAN_OOIJEN_TECH")]
      public const int VendorVanOoijenTech = 5824;
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CdcAcmSerialDriver$UsbId", typeof (CdcAcmSerialDriver.UsbId));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = CdcAcmSerialDriver.UsbId._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => CdcAcmSerialDriver.UsbId._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = CdcAcmSerialDriver.UsbId._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => CdcAcmSerialDriver.UsbId._members.ManagedPeerType;

      internal UsbId(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }
  }
}
