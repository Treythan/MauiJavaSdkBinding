// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_BLUETOOTH_MODE
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
  [Register("com/zebra/rfid/api3/ENUM_BLUETOOTH_MODE", DoNotGenerateAcw = true)]
  public sealed class ENUM_BLUETOOTH_MODE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_BLUETOOTH_MODE", typeof (ENUM_BLUETOOTH_MODE));

    [Register("BLUETOOTH_CDCMODE")]
    public static ENUM_BLUETOOTH_MODE? BluetoothCdcmode
    {
      get
      {
        JniObjectReference objectValue = ENUM_BLUETOOTH_MODE._members.StaticFields.GetObjectValue("BLUETOOTH_CDCMODE.Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;");
        return Object.GetObject<ENUM_BLUETOOTH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BLUETOOTH_HIDMODE")]
    public static ENUM_BLUETOOTH_MODE? BluetoothHidmode
    {
      get
      {
        JniObjectReference objectValue = ENUM_BLUETOOTH_MODE._members.StaticFields.GetObjectValue("BLUETOOTH_HIDMODE.Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;");
        return Object.GetObject<ENUM_BLUETOOTH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_BLUETOOTH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_BLUETOOTH_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_BLUETOOTH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_BLUETOOTH_MODE._members.ManagedPeerType;

    internal ENUM_BLUETOOTH_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_BLUETOOTH_MODE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", "")]
    public static unsafe ENUM_BLUETOOTH_MODE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BLUETOOTH_MODE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BLUETOOTH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", "")]
    public static unsafe ENUM_BLUETOOTH_MODE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BLUETOOTH_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BLUETOOTH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", "")]
    public static unsafe ENUM_BLUETOOTH_MODE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_BLUETOOTH_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_BLUETOOTH_MODE;", (JniArgumentValue*) null);
      return (ENUM_BLUETOOTH_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_BLUETOOTH_MODE));
    }
  }
}
