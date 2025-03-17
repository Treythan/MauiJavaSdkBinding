// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IUsbSerialPort
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/UsbSerialPort", "", "Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker")]
  public interface IUsbSerialPort : ICloseable, IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("DATABITS_5")]
    const int Databits5 = 5;
    [Register("DATABITS_6")]
    const int Databits6 = 6;
    [Register("DATABITS_7")]
    const int Databits7 = 7;
    [Register("DATABITS_8")]
    const int Databits8 = 8;
    [Register("FLOWCONTROL_NONE")]
    const int FlowcontrolNone = 0;
    [Register("FLOWCONTROL_RTSCTS_IN")]
    const int FlowcontrolRtsctsIn = 1;
    [Register("FLOWCONTROL_RTSCTS_OUT")]
    const int FlowcontrolRtsctsOut = 2;
    [Register("FLOWCONTROL_XONXOFF_IN")]
    const int FlowcontrolXonxoffIn = 4;
    [Register("FLOWCONTROL_XONXOFF_OUT")]
    const int FlowcontrolXonxoffOut = 8;
    [Register("PARITY_EVEN")]
    const int ParityEven = 2;
    [Register("PARITY_MARK")]
    const int ParityMark = 3;
    [Register("PARITY_NONE")]
    const int ParityNone = 0;
    [Register("PARITY_ODD")]
    const int ParityOdd = 1;
    [Register("PARITY_SPACE")]
    const int ParitySpace = 4;
    [Register("STOPBITS_1")]
    const int Stopbits1 = 1;
    [Register("STOPBITS_1_5")]
    const int Stopbits15 = 3;
    [Register("STOPBITS_2")]
    const int Stopbits2 = 2;

    bool CD { [Register("getCD", "()Z", "GetGetCDHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool CTS { [Register("getCTS", "()Z", "GetGetCTSHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    EnumSet? ControlLines { [Register("getControlLines", "()Ljava/util/EnumSet;", "GetGetControlLinesHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool DSR { [Register("getDSR", "()Z", "GetGetDSRHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool DTR { [Register("getDTR", "()Z", "GetGetDTRHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; [Register("setDTR", "(Z)V", "GetSetDTR_ZHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] set; }

    UsbDevice? Device { [Register("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    IUsbSerialDriver? Driver { [Register("getDriver", "()Lcom/zebra/rfid/api3/UsbSerialDriver;", "GetGetDriverHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool IsOpen { [Register("isOpen", "()Z", "GetIsOpenHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    int PortNumber { [Register("getPortNumber", "()I", "GetGetPortNumberHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool RI { [Register("getRI", "()Z", "GetGetRIHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    bool RTS { [Register("getRTS", "()Z", "GetGetRTSHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; [Register("setRTS", "(Z)V", "GetSetRTS_ZHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] set; }

    string? Serial { [Register("getSerial", "()Ljava/lang/String;", "GetGetSerialHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    EnumSet? SupportedControlLines { [Register("getSupportedControlLines", "()Ljava/util/EnumSet;", "GetGetSupportedControlLinesHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")] get; }

    [Register("close", "()V", "GetCloseHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    void Close();

    [Register("open", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    void Open(UsbDeviceConnection? p0);

    [Register("purgeHwBuffers", "(ZZ)Z", "GetPurgeHwBuffers_ZZHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    bool PurgeHwBuffers(bool p0, bool p1);

    [Register("read", "([BI)I", "GetRead_arrayBIHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    int Read(byte[]? p0, int p1);

    [Register("setParameters", "(IIII)V", "GetSetParameters_IIIIHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    void SetParameters(int p0, int p1, int p2, int p3);

    [Register("write", "([BI)I", "GetWrite_arrayBIHandler:Com.Zebra.Rfid.Api3.IUsbSerialPortInvoker, MauiJavaSdkBinding")]
    int Write(byte[]? p0, int p1);

    [Register("com/zebra/rfid/api3/UsbSerialPort$ControlLine", DoNotGenerateAcw = true)]
    sealed class ControlLine : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UsbSerialPort$ControlLine", typeof (IUsbSerialPort.ControlLine));

      [Register("CD")]
      public static IUsbSerialPort.ControlLine? Cd
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("CD.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("CTS")]
      public static IUsbSerialPort.ControlLine? Cts
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("CTS.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DSR")]
      public static IUsbSerialPort.ControlLine? Dsr
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("DSR.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DTR")]
      public static IUsbSerialPort.ControlLine? Dtr
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("DTR.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("RI")]
      public static IUsbSerialPort.ControlLine? Ri
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("RI.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("RTS")]
      public static IUsbSerialPort.ControlLine? Rts
      {
        get
        {
          JniObjectReference objectValue = IUsbSerialPort.ControlLine._members.StaticFields.GetObjectValue("RTS.Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;");
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IUsbSerialPort.ControlLine._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IUsbSerialPort.ControlLine._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IUsbSerialPort.ControlLine._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IUsbSerialPort.ControlLine._members.ManagedPeerType;

      internal ControlLine(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;", "")]
      public static unsafe IUsbSerialPort.ControlLine? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = IUsbSerialPort.ControlLine._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;", jniArgumentValuePtr);
          return Object.GetObject<IUsbSerialPort.ControlLine>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;", "")]
      public static unsafe IUsbSerialPort.ControlLine[]? Values()
      {
        JniObjectReference jniObjectReference = IUsbSerialPort.ControlLine._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/UsbSerialPort$ControlLine;", (JniArgumentValue*) null);
        return (IUsbSerialPort.ControlLine[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (IUsbSerialPort.ControlLine));
      }
    }
  }
}
