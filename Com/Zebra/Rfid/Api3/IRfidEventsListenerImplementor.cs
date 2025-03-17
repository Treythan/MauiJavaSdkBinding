// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IRfidEventsListenerImplementor
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("mono/com/zebra/rfid/api3/RfidEventsListenerImplementor")]
  internal sealed class IRfidEventsListenerImplementor : 
    Object,
    IRfidEventsListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private object? sender;
    public EventHandler<EventReadNotifyEventArgs>? EventReadNotifyHandler;
    public EventHandler<EventStatusNotifyEventArgs>? EventStatusNotifyHandler;

    public unsafe IRfidEventsListenerImplementor(object sender)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      this.sender = sender;
    }

    public void EventReadNotify(RfidReadEvents? p0)
    {
      EventHandler<EventReadNotifyEventArgs> readNotifyHandler = this.EventReadNotifyHandler;
      if (readNotifyHandler == null)
        return;
      readNotifyHandler(this.sender, new EventReadNotifyEventArgs(p0));
    }

    public void EventStatusNotify(RfidStatusEvents? p0)
    {
      EventHandler<EventStatusNotifyEventArgs> statusNotifyHandler = this.EventStatusNotifyHandler;
      if (statusNotifyHandler == null)
        return;
      statusNotifyHandler(this.sender, new EventStatusNotifyEventArgs(p0));
    }

    internal static bool __IsEmpty(IRfidEventsListenerImplementor value)
    {
      return value.EventReadNotifyHandler == null && value.EventStatusNotifyHandler == null;
    }
  }
}
