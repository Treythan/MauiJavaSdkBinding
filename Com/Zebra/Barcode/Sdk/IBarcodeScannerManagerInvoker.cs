// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IBarcodeScannerManagerInvoker
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/BarcodeScannerManager", DoNotGenerateAcw = true)]
  internal class IBarcodeScannerManagerInvoker : 
    Object,
    IBarcodeScannerManager,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BarcodeScannerManager", typeof (IBarcodeScannerManagerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_getScanners;
    private IntPtr id_getScanners;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IBarcodeScannerManagerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IBarcodeScannerManagerInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IBarcodeScannerManagerInvoker._members.ManagedPeerType;

    public static IBarcodeScannerManager? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IBarcodeScannerManager>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IBarcodeScannerManagerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.barcode.sdk.BarcodeScannerManager'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IBarcodeScannerManagerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IBarcodeScannerManagerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetGetScannersHandler()
    {
      if ((object) IBarcodeScannerManagerInvoker.cb_getScanners == null)
        IBarcodeScannerManagerInvoker.cb_getScanners = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IBarcodeScannerManagerInvoker.n_GetScanners));
      return IBarcodeScannerManagerInvoker.cb_getScanners;
    }

    private static IntPtr n_GetScanners(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<IBarcodeScannerInfo>.ToLocalJniHandle(Object.GetObject<IBarcodeScannerManager>(jnienv, native__this, (JniHandleOwnership) 0).Scanners);
    }

    public IList<IBarcodeScannerInfo>? Scanners
    {
      get
      {
        if (this.id_getScanners == IntPtr.Zero)
          this.id_getScanners = JNIEnv.GetMethodID(this.class_ref, "getScanners", "()Ljava/util/ArrayList;");
        return JavaList<IBarcodeScannerInfo>.FromJniHandle(JNIEnv.CallObjectMethod(this.Handle, this.id_getScanners), (JniHandleOwnership) 1);
      }
    }
  }
}
