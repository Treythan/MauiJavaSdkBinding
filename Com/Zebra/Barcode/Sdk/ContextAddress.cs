// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.ContextAddress
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
  [Register("com/zebra/barcode/sdk/ContextAddress", DoNotGenerateAcw = true)]
  public sealed class ContextAddress : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/ContextAddress", typeof (ContextAddress));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ContextAddress._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ContextAddress._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ContextAddress._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ContextAddress._members.ManagedPeerType;

    internal ContextAddress(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ContextAddress()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ContextAddress._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ContextAddress._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("create", "()Lcom/zebra/barcode/sdk/ContextAddress;", "")]
    public static unsafe ContextAddress? Create()
    {
      JniObjectReference jniObjectReference = ContextAddress._members.StaticMethods.InvokeObjectMethod("create.()Lcom/zebra/barcode/sdk/ContextAddress;", (JniArgumentValue*) null);
      return Object.GetObject<ContextAddress>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("create", "(Lcom/zebra/barcode/sdk/ContextAddress;S)Lcom/zebra/barcode/sdk/ContextAddress;", "")]
    public static unsafe ContextAddress? Create(
      ContextAddress? parentContextAddress,
      short hopNumber)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(parentContextAddress == null ? IntPtr.Zero : parentContextAddress.Handle),
          new JniArgumentValue(hopNumber)
        };
        JniObjectReference jniObjectReference = ContextAddress._members.StaticMethods.InvokeObjectMethod("create.(Lcom/zebra/barcode/sdk/ContextAddress;S)Lcom/zebra/barcode/sdk/ContextAddress;", jniArgumentValuePtr);
        return Object.GetObject<ContextAddress>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) parentContextAddress);
      }
    }
  }
}
