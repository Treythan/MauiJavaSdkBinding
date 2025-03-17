// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListener
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener", "", "Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListenerInvoker")]
  public interface IAuxiliaryScannerStatusChangeListener : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("onAuxillaryDeviceAdded", "(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs;)V", "GetOnAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_Handler:Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListenerInvoker, MauiJavaSdkBinding")]
    void OnAuxillaryDeviceAdded(AuxiliaryDeviceStatusEventArgs? p0);

    [Register("onAuxillaryDeviceRemoved", "(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs;)V", "GetOnAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_Handler:Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListenerInvoker, MauiJavaSdkBinding")]
    void OnAuxillaryDeviceRemoved(AuxiliaryDeviceStatusEventArgs? p0);
  }
}
