﻿// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WifiScanDataEventsEventArgs
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  public class WifiScanDataEventsEventArgs : EventArgs
  {
    private RfidWifiScanEvents? p0;

    public WifiScanDataEventsEventArgs(RfidWifiScanEvents? p0) => this.p0 = p0;

    public RfidWifiScanEvents? P0 => this.p0;
  }
}
