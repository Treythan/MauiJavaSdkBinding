// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListenerImplementor
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
  [Register("mono/com/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListenerImplementor")]
  internal sealed class IAuxiliaryScannerStatusChangeListenerImplementor : 
    Object,
    IAuxiliaryScannerStatusChangeListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private object? sender;
    public EventHandler<AuxillaryDeviceAddedEventArgs>? OnAuxillaryDeviceAddedHandler;
    public EventHandler<AuxillaryDeviceRemovedEventArgs>? OnAuxillaryDeviceRemovedHandler;

    public unsafe IAuxiliaryScannerStatusChangeListenerImplementor(object sender)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      this.sender = sender;
    }

    public void OnAuxillaryDeviceAdded(AuxiliaryDeviceStatusEventArgs? p0)
    {
      EventHandler<AuxillaryDeviceAddedEventArgs> deviceAddedHandler = this.OnAuxillaryDeviceAddedHandler;
      if (deviceAddedHandler == null)
        return;
      deviceAddedHandler(this.sender, new AuxillaryDeviceAddedEventArgs(p0));
    }

    public void OnAuxillaryDeviceRemoved(AuxiliaryDeviceStatusEventArgs? p0)
    {
      EventHandler<AuxillaryDeviceRemovedEventArgs> deviceRemovedHandler = this.OnAuxillaryDeviceRemovedHandler;
      if (deviceRemovedHandler == null)
        return;
      deviceRemovedHandler(this.sender, new AuxillaryDeviceRemovedEventArgs(p0));
    }

    internal static bool __IsEmpty(
      IAuxiliaryScannerStatusChangeListenerImplementor value)
    {
      return value.OnAuxillaryDeviceAddedHandler == null && value.OnAuxillaryDeviceRemovedHandler == null;
    }
  }
}
