// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IWifiScanDataEventsListener
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/WifiScanDataEventsListener", "", "Com.Zebra.Rfid.Api3.IWifiScanDataEventsListenerInvoker")]
  public interface IWifiScanDataEventsListener : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("eventWifiScanNotify", "(Lcom/zebra/rfid/api3/RfidWifiScanEvents;)V", "GetEventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_Handler:Com.Zebra.Rfid.Api3.IWifiScanDataEventsListenerInvoker, MauiJavaSdkBinding")]
    void EventWifiScanNotify(RfidWifiScanEvents? p0);
  }
}
