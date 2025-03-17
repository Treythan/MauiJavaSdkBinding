// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListenerInvoker
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/FirmwareUpdateEventListener", DoNotGenerateAcw = true)]
  internal class IFirmwareUpdateEventListenerInvoker : 
    Object,
    IFirmwareUpdateEventListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/FirmwareUpdateEventListener", typeof (IFirmwareUpdateEventListenerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_;
    private IntPtr id_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IFirmwareUpdateEventListenerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IFirmwareUpdateEventListenerInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType
    {
      get => IFirmwareUpdateEventListenerInvoker._members.ManagedPeerType;
    }

    public static IFirmwareUpdateEventListener? GetObject(
      IntPtr handle,
      JniHandleOwnership transfer)
    {
      return Object.GetObject<IFirmwareUpdateEventListener>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IFirmwareUpdateEventListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.barcode.sdk.FirmwareUpdateEventListener'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IFirmwareUpdateEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IFirmwareUpdateEventListenerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetOnFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_Handler()
    {
      if ((object) IFirmwareUpdateEventListenerInvoker.cb_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_ == null)
        IFirmwareUpdateEventListenerInvoker.cb_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IFirmwareUpdateEventListenerInvoker.n_OnFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_));
      return IFirmwareUpdateEventListenerInvoker.cb_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_;
    }

    private static void n_OnFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IFirmwareUpdateEventListener>(jnienv, native__this, (JniHandleOwnership) 0).OnFirmwareUpdateEventReceived(Object.GetObject<FirmwareUpdateEventArgs>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void OnFirmwareUpdateEventReceived(FirmwareUpdateEventArgs? p0)
    {
      if (this.id_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_ == IntPtr.Zero)
        this.id_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_ = JNIEnv.GetMethodID(this.class_ref, "onFirmwareUpdateEventReceived", "(Lcom/zebra/barcode/sdk/FirmwareUpdateEventArgs;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_onFirmwareUpdateEventReceived_Lcom_zebra_barcode_sdk_FirmwareUpdateEventArgs_, jvaluePtr);
    }
  }
}
