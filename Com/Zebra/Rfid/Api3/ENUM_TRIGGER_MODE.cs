// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_TRIGGER_MODE
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/ENUM_TRIGGER_MODE", DoNotGenerateAcw = true)]
  public sealed class ENUM_TRIGGER_MODE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_TRIGGER_MODE", typeof (ENUM_TRIGGER_MODE));

    [Register("BARCODE_MODE")]
    public static ENUM_TRIGGER_MODE? BarcodeMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_MODE._members.StaticFields.GetObjectValue("BARCODE_MODE.Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;");
        return Object.GetObject<ENUM_TRIGGER_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_MODE")]
    public static ENUM_TRIGGER_MODE? RfidMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_MODE._members.StaticFields.GetObjectValue("RFID_MODE.Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;");
        return Object.GetObject<ENUM_TRIGGER_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_TRIGGER_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_TRIGGER_MODE._members.ManagedPeerType;

    internal ENUM_TRIGGER_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;", "")]
    public static unsafe ENUM_TRIGGER_MODE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRIGGER_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRIGGER_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;", "")]
    public static unsafe ENUM_TRIGGER_MODE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_TRIGGER_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_TRIGGER_MODE;", (JniArgumentValue*) null);
      return (ENUM_TRIGGER_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_TRIGGER_MODE));
    }
  }
}
