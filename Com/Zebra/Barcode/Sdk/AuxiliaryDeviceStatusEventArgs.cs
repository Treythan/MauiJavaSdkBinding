// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.AuxiliaryDeviceStatusEventArgs
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
  [Register("com/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs", DoNotGenerateAcw = true)]
  public sealed class AuxiliaryDeviceStatusEventArgs : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs", typeof (AuxiliaryDeviceStatusEventArgs));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = AuxiliaryDeviceStatusEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => AuxiliaryDeviceStatusEventArgs._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = AuxiliaryDeviceStatusEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => AuxiliaryDeviceStatusEventArgs._members.ManagedPeerType;

    internal AuxiliaryDeviceStatusEventArgs(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;Lcom/zebra/barcode/sdk/ContextAddress;)V", "")]
    public unsafe AuxiliaryDeviceStatusEventArgs(
      AuxiliaryDeviceStatusEventArgs.DeviceStatus? deviceStatus,
      ContextAddress? contextAddress)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(deviceStatus == null ? IntPtr.Zero : ((Object) deviceStatus).Handle),
          new JniArgumentValue(contextAddress == null ? IntPtr.Zero : contextAddress.Handle)
        };
        JniObjectReference instance = AuxiliaryDeviceStatusEventArgs._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;Lcom/zebra/barcode/sdk/ContextAddress;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        AuxiliaryDeviceStatusEventArgs._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;Lcom/zebra/barcode/sdk/ContextAddress;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) deviceStatus);
        GC.KeepAlive((object) contextAddress);
      }
    }

    public unsafe ContextAddress? ContextAddress
    {
      [Register("getContextAddress", "()Lcom/zebra/barcode/sdk/ContextAddress;", "")] get
      {
        JniObjectReference jniObjectReference = AuxiliaryDeviceStatusEventArgs._members.InstanceMethods.InvokeAbstractObjectMethod("getContextAddress.()Lcom/zebra/barcode/sdk/ContextAddress;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ContextAddress>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getDeviceStatus", "()Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", "")]
    public unsafe AuxiliaryDeviceStatusEventArgs.DeviceStatus? GetDeviceStatus()
    {
      JniObjectReference jniObjectReference = AuxiliaryDeviceStatusEventArgs._members.InstanceMethods.InvokeAbstractObjectMethod("getDeviceStatus.()Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<AuxiliaryDeviceStatusEventArgs.DeviceStatus>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("com/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus", DoNotGenerateAcw = true)]
    public sealed class DeviceStatus : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus", typeof (AuxiliaryDeviceStatusEventArgs.DeviceStatus));

      [Register("ADDED")]
      public static AuxiliaryDeviceStatusEventArgs.DeviceStatus? Added
      {
        get
        {
          JniObjectReference objectValue = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.StaticFields.GetObjectValue("ADDED.Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;");
          return Object.GetObject<AuxiliaryDeviceStatusEventArgs.DeviceStatus>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("REMOVED")]
      public static AuxiliaryDeviceStatusEventArgs.DeviceStatus? Removed
      {
        get
        {
          JniObjectReference objectValue = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.StaticFields.GetObjectValue("REMOVED.Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;");
          return Object.GetObject<AuxiliaryDeviceStatusEventArgs.DeviceStatus>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => AuxiliaryDeviceStatusEventArgs.DeviceStatus._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.ManagedPeerType;
      }

      internal DeviceStatus(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", "")]
      public static unsafe AuxiliaryDeviceStatusEventArgs.DeviceStatus? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", jniArgumentValuePtr);
          return Object.GetObject<AuxiliaryDeviceStatusEventArgs.DeviceStatus>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", "")]
      public static unsafe AuxiliaryDeviceStatusEventArgs.DeviceStatus[]? Values()
      {
        JniObjectReference jniObjectReference = AuxiliaryDeviceStatusEventArgs.DeviceStatus._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/barcode/sdk/AuxiliaryDeviceStatusEventArgs$DeviceStatus;", (JniArgumentValue*) null);
        return (AuxiliaryDeviceStatusEventArgs.DeviceStatus[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (AuxiliaryDeviceStatusEventArgs.DeviceStatus));
      }
    }
  }
}
