﻿// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.BarcodeScannerManagementServicesFactory
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
  [Register("com/zebra/barcode/sdk/BarcodeScannerManagementServicesFactory", DoNotGenerateAcw = true)]
  public sealed class BarcodeScannerManagementServicesFactory : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BarcodeScannerManagementServicesFactory", typeof (BarcodeScannerManagementServicesFactory));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerManagementServicesFactory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers
    {
      get => BarcodeScannerManagementServicesFactory._members;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerManagementServicesFactory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType
    {
      get => BarcodeScannerManagementServicesFactory._members.ManagedPeerType;
    }

    internal BarcodeScannerManagementServicesFactory(
      IntPtr javaReference,
      JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BarcodeScannerManagementServicesFactory()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BarcodeScannerManagementServicesFactory._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BarcodeScannerManagementServicesFactory._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("createBarcodeScannerManager", "(Lcom/zebra/barcode/sdk/BarcodeScannerType;)Lcom/zebra/barcode/sdk/BarcodeScannerManager;", "")]
    public unsafe IBarcodeScannerManager? CreateBarcodeScannerManager(
      BarcodeScannerType? barcodeScannerType)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(barcodeScannerType == null ? IntPtr.Zero : ((Object) barcodeScannerType).Handle)
        };
        JniObjectReference jniObjectReference = BarcodeScannerManagementServicesFactory._members.InstanceMethods.InvokeAbstractObjectMethod("createBarcodeScannerManager.(Lcom/zebra/barcode/sdk/BarcodeScannerType;)Lcom/zebra/barcode/sdk/BarcodeScannerManager;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<IBarcodeScannerManager>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) barcodeScannerType);
      }
    }
  }
}
