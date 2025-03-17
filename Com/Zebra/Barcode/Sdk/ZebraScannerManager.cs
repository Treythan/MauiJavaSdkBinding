// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.ZebraScannerManager
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
  [Register("com/zebra/barcode/sdk/ZebraScannerManager", DoNotGenerateAcw = true)]
  public class ZebraScannerManager : 
    Object,
    IBarcodeScannerManager,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/ZebraScannerManager", typeof (ZebraScannerManager));
    private static Delegate? cb_getScanners;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ZebraScannerManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ZebraScannerManager._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ZebraScannerManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ZebraScannerManager._members.ManagedPeerType;

    protected ZebraScannerManager(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", "")]
    public unsafe ZebraScannerManager(BarcodeScannerType? scannerType)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(scannerType == null ? IntPtr.Zero : ((Object) scannerType).Handle)
        };
        JniObjectReference instance = ZebraScannerManager._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ZebraScannerManager._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) scannerType);
      }
    }

    private static Delegate GetGetScannersHandler()
    {
      if ((object) ZebraScannerManager.cb_getScanners == null)
        ZebraScannerManager.cb_getScanners = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ZebraScannerManager.n_GetScanners));
      return ZebraScannerManager.cb_getScanners;
    }

    private static IntPtr n_GetScanners(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<IBarcodeScannerInfo>.ToLocalJniHandle(Object.GetObject<ZebraScannerManager>(jnienv, native__this, (JniHandleOwnership) 0).Scanners);
    }

    public virtual unsafe IList<IBarcodeScannerInfo>? Scanners
    {
      [Register("getScanners", "()Ljava/util/ArrayList;", "GetGetScannersHandler")] get
      {
        JniObjectReference jniObjectReference = ZebraScannerManager._members.InstanceMethods.InvokeVirtualObjectMethod("getScanners.()Ljava/util/ArrayList;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JavaList<IBarcodeScannerInfo>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
