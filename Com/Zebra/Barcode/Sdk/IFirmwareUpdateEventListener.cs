// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListener
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/FirmwareUpdateEventListener", "", "Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListenerInvoker")]
  public interface IFirmwareUpdateEventListener : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("onFirmwareUpdateEventReceived", "(Lcom/zebra/barcode/sdk/FirmwareUpdateEventArgs;)V", "GetOnFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_Handler:Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListenerInvoker, MauiJavaSdkBinding")]
    void OnFirmwareUpdateEventReceived(FirmwareUpdateEventArgs? p0);
  }
}
