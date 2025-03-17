// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.IBarcodeScannerInfoInvoker
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
  [Register("com/zebra/barcode/sdk/BarcodeScannerInfo", DoNotGenerateAcw = true)]
  internal class IBarcodeScannerInfoInvoker : 
    Object,
    IBarcodeScannerInfo,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BarcodeScannerInfo", typeof (IBarcodeScannerInfoInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_getBarcodeScannerType;
    private IntPtr id_getBarcodeScannerType;
    private static Delegate? cb_getHardwareId;
    private IntPtr id_getHardwareId;
    private static Delegate? cb_getName;
    private IntPtr id_getName;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IBarcodeScannerInfoInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IBarcodeScannerInfoInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IBarcodeScannerInfoInvoker._members.ManagedPeerType;

    public static IBarcodeScannerInfo? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IBarcodeScannerInfo>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IBarcodeScannerInfoInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.barcode.sdk.BarcodeScannerInfo'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IBarcodeScannerInfoInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IBarcodeScannerInfoInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetGetBarcodeScannerTypeHandler()
    {
      if ((object) IBarcodeScannerInfoInvoker.cb_getBarcodeScannerType == null)
        IBarcodeScannerInfoInvoker.cb_getBarcodeScannerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IBarcodeScannerInfoInvoker.n_GetBarcodeScannerType));
      return IBarcodeScannerInfoInvoker.cb_getBarcodeScannerType;
    }

    private static IntPtr n_GetBarcodeScannerType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IBarcodeScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).BarcodeScannerType);
    }

    public BarcodeScannerType? BarcodeScannerType
    {
      get
      {
        if (this.id_getBarcodeScannerType == IntPtr.Zero)
          this.id_getBarcodeScannerType = JNIEnv.GetMethodID(this.class_ref, "getBarcodeScannerType", "()Lcom/zebra/barcode/sdk/BarcodeScannerType;");
        return Object.GetObject<BarcodeScannerType>(JNIEnv.CallObjectMethod(this.Handle, this.id_getBarcodeScannerType), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetHardwareIdHandler()
    {
      if ((object) IBarcodeScannerInfoInvoker.cb_getHardwareId == null)
        IBarcodeScannerInfoInvoker.cb_getHardwareId = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IBarcodeScannerInfoInvoker.n_GetHardwareId));
      return IBarcodeScannerInfoInvoker.cb_getHardwareId;
    }

    private static IntPtr n_GetHardwareId(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<IBarcodeScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).HardwareId);
    }

    public string? HardwareId
    {
      get
      {
        if (this.id_getHardwareId == IntPtr.Zero)
          this.id_getHardwareId = JNIEnv.GetMethodID(this.class_ref, "getHardwareId", "()Ljava/lang/String;");
        return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, this.id_getHardwareId), (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetNameHandler()
    {
      if ((object) IBarcodeScannerInfoInvoker.cb_getName == null)
        IBarcodeScannerInfoInvoker.cb_getName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IBarcodeScannerInfoInvoker.n_GetName));
      return IBarcodeScannerInfoInvoker.cb_getName;
    }

    private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<IBarcodeScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).Name);
    }

    public string? Name
    {
      get
      {
        if (this.id_getName == IntPtr.Zero)
          this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
        return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, this.id_getName), (JniHandleOwnership) 1);
      }
    }
  }
}
