// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IUsbSerialDriver
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Hardware.Usb;
using Android.Runtime;
using Java.Interop;
using System;
using System.Collections.Generic;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/UsbSerialDriver", "", "Com.Zebra.Rfid.Api3.IUsbSerialDriverInvoker")]
  public interface IUsbSerialDriver : IJavaObject, IDisposable, IJavaPeerable
  {
    UsbDevice? Device { [Register("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler:Com.Zebra.Rfid.Api3.IUsbSerialDriverInvoker, MauiJavaSdkBinding")] get; }

    IList<IUsbSerialPort>? Ports { [Register("getPorts", "()Ljava/util/List;", "GetGetPortsHandler:Com.Zebra.Rfid.Api3.IUsbSerialDriverInvoker, MauiJavaSdkBinding")] get; }
  }
}
