﻿// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.FirmwareUpdateEventEventArgs
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using System;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  public class FirmwareUpdateEventEventArgs : EventArgs
  {
    private FirmwareUpdateEventArgs? p0;

    public FirmwareUpdateEventEventArgs(FirmwareUpdateEventArgs? p0) => this.p0 = p0;

    public FirmwareUpdateEventArgs? P0 => this.p0;
  }
}
