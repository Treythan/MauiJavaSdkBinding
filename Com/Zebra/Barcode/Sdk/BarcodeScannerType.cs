// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.BarcodeScannerType
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
  [Register("com/zebra/barcode/sdk/BarcodeScannerType", DoNotGenerateAcw = true)]
  public sealed class BarcodeScannerType : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/BarcodeScannerType", typeof (BarcodeScannerType));

    [Register("BLUETOOTH")]
    public static BarcodeScannerType? Bluetooth
    {
      get
      {
        JniObjectReference objectValue = BarcodeScannerType._members.StaticFields.GetObjectValue("BLUETOOTH.Lcom/zebra/barcode/sdk/BarcodeScannerType;");
        return Object.GetObject<BarcodeScannerType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BLUETOOTH_LE")]
    public static BarcodeScannerType? BluetoothLe
    {
      get
      {
        JniObjectReference objectValue = BarcodeScannerType._members.StaticFields.GetObjectValue("BLUETOOTH_LE.Lcom/zebra/barcode/sdk/BarcodeScannerType;");
        return Object.GetObject<BarcodeScannerType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("USB")]
    public static BarcodeScannerType? Usb
    {
      get
      {
        JniObjectReference objectValue = BarcodeScannerType._members.StaticFields.GetObjectValue("USB.Lcom/zebra/barcode/sdk/BarcodeScannerType;");
        return Object.GetObject<BarcodeScannerType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerType._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BarcodeScannerType._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BarcodeScannerType._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BarcodeScannerType._members.ManagedPeerType;

    internal BarcodeScannerType(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/barcode/sdk/BarcodeScannerType;", "")]
    public static unsafe BarcodeScannerType? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = BarcodeScannerType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/barcode/sdk/BarcodeScannerType;", jniArgumentValuePtr);
        return Object.GetObject<BarcodeScannerType>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/barcode/sdk/BarcodeScannerType;", "")]
    public static unsafe BarcodeScannerType[]? Values()
    {
      JniObjectReference jniObjectReference = BarcodeScannerType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/barcode/sdk/BarcodeScannerType;", (JniArgumentValue*) null);
      return (BarcodeScannerType[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (BarcodeScannerType));
    }
  }
}
