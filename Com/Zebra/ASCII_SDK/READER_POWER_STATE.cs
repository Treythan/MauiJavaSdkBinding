// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.READER_POWER_STATE
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
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/READER_POWER_STATE", DoNotGenerateAcw = true)]
  public sealed class READER_POWER_STATE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/READER_POWER_STATE", typeof (READER_POWER_STATE));

    [Register("POWER_STATE_ACTIVE")]
    public static READER_POWER_STATE? PowerStateActive
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_ACTIVE.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_BT_OFF")]
    public static READER_POWER_STATE? PowerStateBtOff
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_BT_OFF.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_OFF")]
    public static READER_POWER_STATE? PowerStateOff
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_OFF.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_RF_ACTIVE")]
    public static READER_POWER_STATE? PowerStateRfActive
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_RF_ACTIVE.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_STANDBY")]
    public static READER_POWER_STATE? PowerStateStandby
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_STANDBY.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_UNKNOWN")]
    public static READER_POWER_STATE? PowerStateUnknown
    {
      get
      {
        JniObjectReference objectValue = READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_UNKNOWN.Lcom/zebra/ASCII_SDK/READER_POWER_STATE;");
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = READER_POWER_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => READER_POWER_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = READER_POWER_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => READER_POWER_STATE._members.ManagedPeerType;

    internal READER_POWER_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/READER_POWER_STATE;", "")]
    public static unsafe READER_POWER_STATE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = READER_POWER_STATE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/READER_POWER_STATE;", jniArgumentValuePtr);
        return Object.GetObject<READER_POWER_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/READER_POWER_STATE;", "")]
    public static unsafe READER_POWER_STATE[]? Values()
    {
      JniObjectReference jniObjectReference = READER_POWER_STATE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/READER_POWER_STATE;", (JniArgumentValue*) null);
      return (READER_POWER_STATE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (READER_POWER_STATE));
    }
  }
}
