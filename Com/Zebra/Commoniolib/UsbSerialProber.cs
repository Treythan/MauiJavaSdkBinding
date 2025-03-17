// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.UsbSerialProber
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Hardware.Usb;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/UsbSerialProber", DoNotGenerateAcw = true)]
  public class UsbSerialProber : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/UsbSerialProber", typeof (UsbSerialProber));
    private static Delegate? cb_findAllDrivers_Landroid_hardware_usb_UsbManager_;
    private static Delegate? cb_probeDevice_Landroid_hardware_usb_UsbDevice_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UsbSerialProber._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UsbSerialProber._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UsbSerialProber._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UsbSerialProber._members.ManagedPeerType;

    protected UsbSerialProber(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Lcom/zebra/commoniolib/ProbeTable;)V", "")]
    public unsafe UsbSerialProber(ProbeTable? probeTable)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(probeTable == null ? IntPtr.Zero : probeTable.Handle)
        };
        JniObjectReference instance = UsbSerialProber._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/commoniolib/ProbeTable;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        UsbSerialProber._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/commoniolib/ProbeTable;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) probeTable);
      }
    }

    public static unsafe ProbeTable? DefaultProbeTable
    {
      [Register("getDefaultProbeTable", "()Lcom/zebra/commoniolib/ProbeTable;", "")] get
      {
        JniObjectReference jniObjectReference = UsbSerialProber._members.StaticMethods.InvokeObjectMethod("getDefaultProbeTable.()Lcom/zebra/commoniolib/ProbeTable;", (JniArgumentValue*) null);
        return Object.GetObject<ProbeTable>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public static unsafe UsbSerialProber? DefaultProber
    {
      [Register("getDefaultProber", "()Lcom/zebra/commoniolib/UsbSerialProber;", "")] get
      {
        JniObjectReference jniObjectReference = UsbSerialProber._members.StaticMethods.InvokeObjectMethod("getDefaultProber.()Lcom/zebra/commoniolib/UsbSerialProber;", (JniArgumentValue*) null);
        return Object.GetObject<UsbSerialProber>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFindAllDrivers_Landroid_hardware_usb_UsbManager_Handler()
    {
      if ((object) UsbSerialProber.cb_findAllDrivers_Landroid_hardware_usb_UsbManager_ == null)
        UsbSerialProber.cb_findAllDrivers_Landroid_hardware_usb_UsbManager_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(UsbSerialProber.n_FindAllDrivers_Landroid_hardware_usb_UsbManager_));
      return UsbSerialProber.cb_findAllDrivers_Landroid_hardware_usb_UsbManager_;
    }

    private static IntPtr n_FindAllDrivers_Landroid_hardware_usb_UsbManager_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_usbManager)
    {
      return JavaList<IUsbSerialDriver>.ToLocalJniHandle(Object.GetObject<UsbSerialProber>(jnienv, native__this, (JniHandleOwnership) 0).FindAllDrivers(Object.GetObject<UsbManager>(native_usbManager, (JniHandleOwnership) 0)));
    }

    [Register("findAllDrivers", "(Landroid/hardware/usb/UsbManager;)Ljava/util/List;", "GetFindAllDrivers_Landroid_hardware_usb_UsbManager_Handler")]
    public virtual unsafe IList<IUsbSerialDriver>? FindAllDrivers(UsbManager? usbManager)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(usbManager == null ? IntPtr.Zero : ((Object) usbManager).Handle)
        };
        JniObjectReference jniObjectReference = UsbSerialProber._members.InstanceMethods.InvokeVirtualObjectMethod("findAllDrivers.(Landroid/hardware/usb/UsbManager;)Ljava/util/List;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JavaList<IUsbSerialDriver>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) usbManager);
      }
    }

    private static Delegate GetProbeDevice_Landroid_hardware_usb_UsbDevice_Handler()
    {
      if ((object) UsbSerialProber.cb_probeDevice_Landroid_hardware_usb_UsbDevice_ == null)
        UsbSerialProber.cb_probeDevice_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(UsbSerialProber.n_ProbeDevice_Landroid_hardware_usb_UsbDevice_));
      return UsbSerialProber.cb_probeDevice_Landroid_hardware_usb_UsbDevice_;
    }

    private static IntPtr n_ProbeDevice_Landroid_hardware_usb_UsbDevice_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_usbDevice)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<UsbSerialProber>(jnienv, native__this, (JniHandleOwnership) 0).ProbeDevice(Object.GetObject<UsbDevice>(native_usbDevice, (JniHandleOwnership) 0)));
    }

    [Register("probeDevice", "(Landroid/hardware/usb/UsbDevice;)Lcom/zebra/commoniolib/UsbSerialDriver;", "GetProbeDevice_Landroid_hardware_usb_UsbDevice_Handler")]
    public virtual unsafe IUsbSerialDriver? ProbeDevice(UsbDevice? usbDevice)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(usbDevice == null ? IntPtr.Zero : ((Object) usbDevice).Handle)
        };
        JniObjectReference jniObjectReference = UsbSerialProber._members.InstanceMethods.InvokeVirtualObjectMethod("probeDevice.(Landroid/hardware/usb/UsbDevice;)Lcom/zebra/commoniolib/UsbSerialDriver;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<IUsbSerialDriver>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) usbDevice);
      }
    }
  }
}
