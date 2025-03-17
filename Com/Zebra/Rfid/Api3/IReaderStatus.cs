// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IReaderStatus
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/IReaderStatus", "", "Com.Zebra.Rfid.Api3.IReaderStatusInvoker")]
  public interface IReaderStatus : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("USBDeviceAttached", "(Ljava/lang/String;)V", "GetUSBDeviceAttached_Ljava_lang_String_Handler:Com.Zebra.Rfid.Api3.IReaderStatusInvoker, MauiJavaSdkBinding")]
    void USBDeviceAttached(string? p0);

    [Register("USBDeviceDeAttached", "(Ljava/lang/String;)V", "GetUSBDeviceDeAttached_Ljava_lang_String_Handler:Com.Zebra.Rfid.Api3.IReaderStatusInvoker, MauiJavaSdkBinding")]
    void USBDeviceDeAttached(string? p0);

    [Register("readerAvailable", "(Ljava/lang/String;)V", "GetReaderAvailable_Ljava_lang_String_Handler:Com.Zebra.Rfid.Api3.IReaderStatusInvoker, MauiJavaSdkBinding")]
    void ReaderAvailable(string? p0);

    [Register("readerDisappeared", "(Ljava/lang/String;)V", "GetReaderDisappeared_Ljava_lang_String_Handler:Com.Zebra.Rfid.Api3.IReaderStatusInvoker, MauiJavaSdkBinding")]
    void ReaderDisappeared(string? p0);
  }
}
