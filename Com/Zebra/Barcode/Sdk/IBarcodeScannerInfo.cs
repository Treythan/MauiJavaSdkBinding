// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IBarcodeScannerInfo
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/BarcodeScannerInfo", "", "Com.Zebra.Barcode.Sdk.IBarcodeScannerInfoInvoker")]
  public interface IBarcodeScannerInfo : IJavaObject, IDisposable, IJavaPeerable
  {
    BarcodeScannerType? BarcodeScannerType { [Register("getBarcodeScannerType", "()Lcom/zebra/barcode/sdk/BarcodeScannerType;", "GetGetBarcodeScannerTypeHandler:Com.Zebra.Barcode.Sdk.IBarcodeScannerInfoInvoker, MauiJavaSdkBinding")] get; }

    string? HardwareId { [Register("getHardwareId", "()Ljava/lang/String;", "GetGetHardwareIdHandler:Com.Zebra.Barcode.Sdk.IBarcodeScannerInfoInvoker, MauiJavaSdkBinding")] get; }

    string? Name { [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Zebra.Barcode.Sdk.IBarcodeScannerInfoInvoker, MauiJavaSdkBinding")] get; }
  }
}
