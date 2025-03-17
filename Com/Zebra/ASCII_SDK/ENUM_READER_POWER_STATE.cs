// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_READER_POWER_STATE
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
  [Register("com/zebra/ASCII_SDK/ENUM_READER_POWER_STATE", DoNotGenerateAcw = true)]
  public sealed class ENUM_READER_POWER_STATE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_READER_POWER_STATE", typeof (ENUM_READER_POWER_STATE));

    [Register("POWER_STATE_ACTIVE")]
    public static ENUM_READER_POWER_STATE? PowerStateActive
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_ACTIVE.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_BT_OFF")]
    public static ENUM_READER_POWER_STATE? PowerStateBtOff
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_BT_OFF.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_OFF")]
    public static ENUM_READER_POWER_STATE? PowerStateOff
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_OFF.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_RF_ACTIVE")]
    public static ENUM_READER_POWER_STATE? PowerStateRfActive
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_RF_ACTIVE.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_STANDBY")]
    public static ENUM_READER_POWER_STATE? PowerStateStandby
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_STANDBY.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWER_STATE_UNKNOWN")]
    public static ENUM_READER_POWER_STATE? PowerStateUnknown
    {
      get
      {
        JniObjectReference objectValue = ENUM_READER_POWER_STATE._members.StaticFields.GetObjectValue("POWER_STATE_UNKNOWN.Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;");
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_READER_POWER_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_READER_POWER_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_READER_POWER_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_READER_POWER_STATE._members.ManagedPeerType;

    internal ENUM_READER_POWER_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_READER_POWER_STATE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", "")]
    public static unsafe ENUM_READER_POWER_STATE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_READER_POWER_STATE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", "")]
    public static unsafe ENUM_READER_POWER_STATE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_READER_POWER_STATE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_READER_POWER_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", "")]
    public static unsafe ENUM_READER_POWER_STATE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_READER_POWER_STATE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_READER_POWER_STATE;", (JniArgumentValue*) null);
      return (ENUM_READER_POWER_STATE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_READER_POWER_STATE));
    }
  }
}
