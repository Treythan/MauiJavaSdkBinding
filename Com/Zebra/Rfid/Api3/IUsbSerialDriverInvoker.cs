// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IUsbSerialDriverInvoker
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/UsbSerialDriver", DoNotGenerateAcw = true)]
  internal class IUsbSerialDriverInvoker : 
    Object,
    IUsbSerialDriver,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UsbSerialDriver", typeof (IUsbSerialDriverInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_getDevice;
    private IntPtr id_getDevice;
    private static Delegate? cb_getPorts;
    private IntPtr id_getPorts;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IUsbSerialDriverInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IUsbSerialDriverInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IUsbSerialDriverInvoker._members.ManagedPeerType;

    public static IUsbSerialDriver? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IUsbSerialDriver>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IUsbSerialDriverInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.UsbSerialDriver'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IUsbSerialDriverInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IUsbSerialDriverInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetGetDeviceHandler()
    {
      if ((object) IUsbSerialDriverInvoker.cb_getDevice == null)
        IUsbSerialDriverInvoker.cb_getDevice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialDriverInvoker.n_GetDevice));
      return IUsbSerialDriverInvoker.cb_getDevice;
    }

    private static IntPtr n_GetDevice(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IUsbSerialDriver>(jnienv, native__this, (JniHandleOwnership) 0).Device);
    }

    public UsbDevice? Device
    {
      get
      {
        if (this.id_getDevice == IntPtr.Zero)
          this.id_getDevice = JNIEnv.GetMethodID(this.class_ref, "getDevice", "()Landroid/hardware/usb/UsbDevice;");
        return Object.GetObject<UsbDevice>(JNIEnv.CallObjectMethod(this.Handle, this.id_getDevice), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPortsHandler()
    {
      if ((object) IUsbSerialDriverInvoker.cb_getPorts == null)
        IUsbSerialDriverInvoker.cb_getPorts = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IUsbSerialDriverInvoker.n_GetPorts));
      return IUsbSerialDriverInvoker.cb_getPorts;
    }

    private static IntPtr n_GetPorts(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<IUsbSerialPort>.ToLocalJniHandle(Object.GetObject<IUsbSerialDriver>(jnienv, native__this, (JniHandleOwnership) 0).Ports);
    }

    public IList<IUsbSerialPort>? Ports
    {
      get
      {
        if (this.id_getPorts == IntPtr.Zero)
          this.id_getPorts = JNIEnv.GetMethodID(this.class_ref, "getPorts", "()Ljava/util/List;");
        return JavaList<IUsbSerialPort>.FromJniHandle(JNIEnv.CallObjectMethod(this.Handle, this.id_getPorts), (JniHandleOwnership) 1);
      }
    }
  }
}
