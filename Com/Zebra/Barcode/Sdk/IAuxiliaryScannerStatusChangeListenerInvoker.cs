// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListenerInvoker
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
  [Register("com/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener", DoNotGenerateAcw = true)]
  internal class IAuxiliaryScannerStatusChangeListenerInvoker : 
    Object,
    IAuxiliaryScannerStatusChangeListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener", typeof (IAuxiliaryScannerStatusChangeListenerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;
    private IntPtr id_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;
    private static Delegate? cb_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;
    private IntPtr id_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IAuxiliaryScannerStatusChangeListenerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers
    {
      get => IAuxiliaryScannerStatusChangeListenerInvoker._members;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType
    {
      get => IAuxiliaryScannerStatusChangeListenerInvoker._members.ManagedPeerType;
    }

    public static IAuxiliaryScannerStatusChangeListener? GetObject(
      IntPtr handle,
      JniHandleOwnership transfer)
    {
      return Object.GetObject<IAuxiliaryScannerStatusChangeListener>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IAuxiliaryScannerStatusChangeListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.barcode.sdk.AuxiliaryScannerStatusChangeListener'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IAuxiliaryScannerStatusChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IAuxiliaryScannerStatusChangeListenerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetOnAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_Handler()
    {
      if ((object) IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ == null)
        IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IAuxiliaryScannerStatusChangeListenerInvoker.n_OnAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_));
      return IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;
    }

    private static void n_OnAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IAuxiliaryScannerStatusChangeListener>(jnienv, native__this, (JniHandleOwnership) 0).OnAuxillaryDeviceAdded(Object.GetObject<AuxiliaryDeviceStatusEventArgs>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void OnAuxillaryDeviceAdded(AuxiliaryDeviceStatusEventArgs? p0)
    {
      if (this.id_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ == IntPtr.Zero)
        this.id_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ = JNIEnv.GetMethodID(this.class_ref, "onAuxillaryDeviceAdded", "(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_onAuxillaryDeviceAdded_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_, jvaluePtr);
    }

    private static Delegate GetOnAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_Handler()
    {
      if ((object) IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ == null)
        IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IAuxiliaryScannerStatusChangeListenerInvoker.n_OnAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_));
      return IAuxiliaryScannerStatusChangeListenerInvoker.cb_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_;
    }

    private static void n_OnAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IAuxiliaryScannerStatusChangeListener>(jnienv, native__this, (JniHandleOwnership) 0).OnAuxillaryDeviceRemoved(Object.GetObject<AuxiliaryDeviceStatusEventArgs>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void OnAuxillaryDeviceRemoved(AuxiliaryDeviceStatusEventArgs? p0)
    {
      if (this.id_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ == IntPtr.Zero)
        this.id_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_ = JNIEnv.GetMethodID(this.class_ref, "onAuxillaryDeviceRemoved", "(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_onAuxillaryDeviceRemoved_Lcom_zebra_barcode_sdk_AuxiliaryDeviceStatusEventArgs_, jvaluePtr);
    }
  }
}
