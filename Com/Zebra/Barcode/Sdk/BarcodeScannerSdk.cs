// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.BarcodeScannerSdk
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/BarcodeScannerSdk", DoNotGenerateAcw = true)]
  public sealed class BarcodeScannerSdk : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BarcodeScannerSdk", typeof (BarcodeScannerSdk));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerSdk._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BarcodeScannerSdk._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerSdk._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BarcodeScannerSdk._members.ManagedPeerType;

    internal BarcodeScannerSdk(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BarcodeScannerSdk()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BarcodeScannerSdk._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BarcodeScannerSdk._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    public static unsafe BarcodeScannerFactory? BarcodeScannerFactory
    {
      [Register("getBarcodeScannerFactory", "()Lcom/zebra/barcode/sdk/BarcodeScannerFactory;", "")] get
      {
        JniObjectReference jniObjectReference = BarcodeScannerSdk._members.StaticMethods.InvokeObjectMethod("getBarcodeScannerFactory.()Lcom/zebra/barcode/sdk/BarcodeScannerFactory;", (JniArgumentValue*) null);
        return Object.GetObject<BarcodeScannerFactory>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public static unsafe BarcodeScannerManagementServicesFactory? BarcodeScannerManagementServicesFactory
    {
      [Register("getBarcodeScannerManagementServicesFactory", "()Lcom/zebra/barcode/sdk/BarcodeScannerManagementServicesFactory;", "")] get
      {
        JniObjectReference jniObjectReference = BarcodeScannerSdk._members.StaticMethods.InvokeObjectMethod("getBarcodeScannerManagementServicesFactory.()Lcom/zebra/barcode/sdk/BarcodeScannerManagementServicesFactory;", (JniArgumentValue*) null);
        return Object.GetObject<BarcodeScannerManagementServicesFactory>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public static unsafe BarcodeScannerWatcherServicesFactory? BarcodeScannerWatcherServicesFactory
    {
      [Register("getBarcodeScannerWatcherServicesFactory", "()Lcom/zebra/barcode/sdk/BarcodeScannerWatcherServicesFactory;", "")] get
      {
        JniObjectReference jniObjectReference = BarcodeScannerSdk._members.StaticMethods.InvokeObjectMethod("getBarcodeScannerWatcherServicesFactory.()Lcom/zebra/barcode/sdk/BarcodeScannerWatcherServicesFactory;", (JniArgumentValue*) null);
        return Object.GetObject<BarcodeScannerWatcherServicesFactory>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public unsafe string? SdkVersion
    {
      [Register("getSdkVersion", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = BarcodeScannerSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getSdkVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("setContext", "(Landroid/content/Context;)V", "")]
    public static unsafe void SetContext(Context? context)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle)
        };
        BarcodeScannerSdk._members.StaticMethods.InvokeVoidMethod("setContext.(Landroid/content/Context;)V", jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
      }
    }
  }
}
