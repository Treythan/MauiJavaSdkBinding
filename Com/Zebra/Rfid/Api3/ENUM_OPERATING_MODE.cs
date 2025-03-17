// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_OPERATING_MODE
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
  [Register("com/zebra/rfid/api3/ENUM_OPERATING_MODE", DoNotGenerateAcw = true)]
  public sealed class ENUM_OPERATING_MODE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_OPERATING_MODE", typeof (ENUM_OPERATING_MODE));

    [Register("CONVEYOR_MODE")]
    public static ENUM_OPERATING_MODE? ConveyorMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_OPERATING_MODE._members.StaticFields.GetObjectValue("CONVEYOR_MODE.Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;");
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CUSTOM_MODE")]
    public static ENUM_OPERATING_MODE? CustomMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_OPERATING_MODE._members.StaticFields.GetObjectValue("CUSTOM_MODE.Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;");
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INVENTORY_MODE")]
    public static ENUM_OPERATING_MODE? InventoryMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_OPERATING_MODE._members.StaticFields.GetObjectValue("INVENTORY_MODE.Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;");
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("PORTAL_MODE")]
    public static ENUM_OPERATING_MODE? PortalMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_OPERATING_MODE._members.StaticFields.GetObjectValue("PORTAL_MODE.Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;");
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SIMPLE_MODE")]
    public static ENUM_OPERATING_MODE? SimpleMode
    {
      get
      {
        JniObjectReference objectValue = ENUM_OPERATING_MODE._members.StaticFields.GetObjectValue("SIMPLE_MODE.Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;");
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_OPERATING_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_OPERATING_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_OPERATING_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_OPERATING_MODE._members.ManagedPeerType;

    internal ENUM_OPERATING_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;", "")]
    public static unsafe ENUM_OPERATING_MODE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_OPERATING_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_OPERATING_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;", "")]
    public static unsafe ENUM_OPERATING_MODE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_OPERATING_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_OPERATING_MODE;", (JniArgumentValue*) null);
      return (ENUM_OPERATING_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_OPERATING_MODE));
    }
  }
}
