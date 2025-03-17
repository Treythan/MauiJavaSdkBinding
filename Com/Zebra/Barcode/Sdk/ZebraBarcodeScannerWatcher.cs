// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.ZebraBarcodeScannerWatcher
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
  [Register("com/zebra/barcode/sdk/ZebraBarcodeScannerWatcher", DoNotGenerateAcw = true)]
  public class ZebraBarcodeScannerWatcher : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/ZebraBarcodeScannerWatcher", typeof (ZebraBarcodeScannerWatcher));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ZebraBarcodeScannerWatcher._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ZebraBarcodeScannerWatcher._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ZebraBarcodeScannerWatcher._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ZebraBarcodeScannerWatcher._members.ManagedPeerType;

    protected ZebraBarcodeScannerWatcher(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", "")]
    public unsafe ZebraBarcodeScannerWatcher(BarcodeScannerType? barcodeScannerType)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(barcodeScannerType == null ? IntPtr.Zero : ((Object) barcodeScannerType).Handle)
        };
        JniObjectReference instance = ZebraBarcodeScannerWatcher._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ZebraBarcodeScannerWatcher._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerType;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) barcodeScannerType);
      }
    }
  }
}
