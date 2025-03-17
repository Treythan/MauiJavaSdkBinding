// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.UsbSerialPort
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Lang;
using System;

#nullable disable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/UsbSerialPort", DoNotGenerateAcw = true)]
  [Obsolete("Use the 'Com.Zebra.Commoniolib.IUsbSerialPort' type. This class will be removed in a future release.")]
  public abstract class UsbSerialPort : Object
  {
    [Register("DATABITS_5")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Databits5'. This class will be removed in a future release.")]
    public const int Databits5 = 5;
    [Register("DATABITS_6")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Databits6'. This class will be removed in a future release.")]
    public const int Databits6 = 6;
    [Register("DATABITS_7")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Databits7'. This class will be removed in a future release.")]
    public const int Databits7 = 7;
    [Register("DATABITS_8")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Databits8'. This class will be removed in a future release.")]
    public const int Databits8 = 8;
    [Register("FLOWCONTROL_NONE")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.FlowcontrolNone'. This class will be removed in a future release.")]
    public const int FlowcontrolNone = 0;
    [Register("FLOWCONTROL_RTSCTS_IN")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.FlowcontrolRtsctsIn'. This class will be removed in a future release.")]
    public const int FlowcontrolRtsctsIn = 1;
    [Register("FLOWCONTROL_RTSCTS_OUT")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.FlowcontrolRtsctsOut'. This class will be removed in a future release.")]
    public const int FlowcontrolRtsctsOut = 2;
    [Register("FLOWCONTROL_XONXOFF_IN")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.FlowcontrolXonxoffIn'. This class will be removed in a future release.")]
    public const int FlowcontrolXonxoffIn = 4;
    [Register("FLOWCONTROL_XONXOFF_OUT")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.FlowcontrolXonxoffOut'. This class will be removed in a future release.")]
    public const int FlowcontrolXonxoffOut = 8;
    [Register("PARITY_EVEN")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.ParityEven'. This class will be removed in a future release.")]
    public const int ParityEven = 2;
    [Register("PARITY_MARK")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.ParityMark'. This class will be removed in a future release.")]
    public const int ParityMark = 3;
    [Register("PARITY_NONE")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.ParityNone'. This class will be removed in a future release.")]
    public const int ParityNone = 0;
    [Register("PARITY_ODD")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.ParityOdd'. This class will be removed in a future release.")]
    public const int ParityOdd = 1;
    [Register("PARITY_SPACE")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.ParitySpace'. This class will be removed in a future release.")]
    public const int ParitySpace = 4;
    [Register("STOPBITS_1")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Stopbits1'. This class will be removed in a future release.")]
    public const int Stopbits1 = 1;
    [Register("STOPBITS_1_5")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Stopbits15'. This class will be removed in a future release.")]
    public const int Stopbits15 = 3;
    [Register("STOPBITS_2")]
    [Obsolete("Use 'Com.Zebra.Commoniolib.IUsbSerialPort.Stopbits2'. This class will be removed in a future release.")]
    public const int Stopbits2 = 2;

    internal UsbSerialPort()
    {
    }
  }
}
