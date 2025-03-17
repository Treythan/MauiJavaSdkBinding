// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListenerImplementor
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("mono/com/zebra/barcode/sdk/FirmwareUpdateEventListenerImplementor")]
  internal sealed class IFirmwareUpdateEventListenerImplementor : 
    Object,
    IFirmwareUpdateEventListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private object? sender;
    public EventHandler<FirmwareUpdateEventEventArgs>? Handler;

    public unsafe IFirmwareUpdateEventListenerImplementor(object sender)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      this.sender = sender;
    }

    public void OnFirmwareUpdateEventReceived(FirmwareUpdateEventArgs? p0)
    {
      EventHandler<FirmwareUpdateEventEventArgs> handler = this.Handler;
      if (handler == null)
        return;
      handler(this.sender, new FirmwareUpdateEventEventArgs(p0));
    }

    internal static bool __IsEmpty(IFirmwareUpdateEventListenerImplementor value)
    {
      return value.Handler == null;
    }
  }
}
