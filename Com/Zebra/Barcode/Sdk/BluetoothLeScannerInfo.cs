// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.BluetoothLeScannerInfo
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
  [Register("com/zebra/barcode/sdk/BluetoothLeScannerInfo", DoNotGenerateAcw = true)]
  public sealed class BluetoothLeScannerInfo : 
    Object,
    IBarcodeScannerInfo,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BluetoothLeScannerInfo", typeof (BluetoothLeScannerInfo));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BluetoothLeScannerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BluetoothLeScannerInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BluetoothLeScannerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BluetoothLeScannerInfo._members.ManagedPeerType;

    internal BluetoothLeScannerInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BluetoothLeScannerInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BluetoothLeScannerInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BluetoothLeScannerInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    public unsafe BarcodeScannerType? BarcodeScannerType
    {
      [Register("getBarcodeScannerType", "()Lcom/zebra/barcode/sdk/BarcodeScannerType;", "")] get
      {
        JniObjectReference jniObjectReference = BluetoothLeScannerInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getBarcodeScannerType.()Lcom/zebra/barcode/sdk/BarcodeScannerType;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<BarcodeScannerType>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public unsafe string? HardwareId
    {
      [Register("getHardwareId", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = BluetoothLeScannerInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getHardwareId.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public unsafe int Id
    {
      [Register("getId", "()I", "")] get
      {
        return BluetoothLeScannerInfo._members.InstanceMethods.InvokeAbstractInt32Method("getId.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    public unsafe string? Name
    {
      [Register("getName", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = BluetoothLeScannerInfo._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
