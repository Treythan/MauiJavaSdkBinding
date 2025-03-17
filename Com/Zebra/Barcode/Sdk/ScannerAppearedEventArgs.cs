// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.ScannerAppearedEventArgs
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
  [Register("com/zebra/barcode/sdk/ScannerAppearedEventArgs", DoNotGenerateAcw = true)]
  public class ScannerAppearedEventArgs : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/ScannerAppearedEventArgs", typeof (ScannerAppearedEventArgs));
    private static Delegate? cb_getScannerInfo;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ScannerAppearedEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ScannerAppearedEventArgs._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ScannerAppearedEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ScannerAppearedEventArgs._members.ManagedPeerType;

    protected ScannerAppearedEventArgs(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetScannerInfoHandler()
    {
      if ((object) ScannerAppearedEventArgs.cb_getScannerInfo == null)
        ScannerAppearedEventArgs.cb_getScannerInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ScannerAppearedEventArgs.n_GetScannerInfo));
      return ScannerAppearedEventArgs.cb_getScannerInfo;
    }

    private static IntPtr n_GetScannerInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ScannerAppearedEventArgs>(jnienv, native__this, (JniHandleOwnership) 0).ScannerInfo);
    }

    public virtual unsafe ScannerInfo? ScannerInfo
    {
      [Register("getScannerInfo", "()Lcom/zebra/barcode/sdk/ScannerInfo;", "GetGetScannerInfoHandler")] get
      {
        JniObjectReference jniObjectReference = ScannerAppearedEventArgs._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerInfo.()Lcom/zebra/barcode/sdk/ScannerInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ScannerInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
