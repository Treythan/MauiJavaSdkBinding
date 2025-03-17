// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IRfidEventsListener
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/RfidEventsListener", "", "Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker")]
  public interface IRfidEventsListener : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("eventReadNotify", "(Lcom/zebra/rfid/api3/RfidReadEvents;)V", "GetEventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_Handler:Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker, MauiJavaSdkBinding")]
    void EventReadNotify(RfidReadEvents? p0);

    [Register("eventStatusNotify", "(Lcom/zebra/rfid/api3/RfidStatusEvents;)V", "GetEventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_Handler:Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker, MauiJavaSdkBinding")]
    void EventStatusNotify(RfidStatusEvents? p0);
  }
}
