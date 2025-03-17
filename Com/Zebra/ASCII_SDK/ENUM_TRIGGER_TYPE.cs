// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_TRIGGER_TYPE
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
  [Register("com/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE", DoNotGenerateAcw = true)]
  public sealed class ENUM_TRIGGER_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE", typeof (ENUM_TRIGGER_TYPE));

    [Register("TRIGGER_DUAL")]
    public static ENUM_TRIGGER_TYPE? TriggerDual
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_TYPE._members.StaticFields.GetObjectValue("TRIGGER_DUAL.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;");
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRIGGER_RFID")]
    public static ENUM_TRIGGER_TYPE? TriggerRfid
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_TYPE._members.StaticFields.GetObjectValue("TRIGGER_RFID.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;");
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRIGGER_SCAN")]
    public static ENUM_TRIGGER_TYPE? TriggerScan
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_TYPE._members.StaticFields.GetObjectValue("TRIGGER_SCAN.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;");
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_TRIGGER_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_TRIGGER_TYPE._members.ManagedPeerType;

    internal ENUM_TRIGGER_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_TRIGGER_TYPE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", "")]
    public static unsafe ENUM_TRIGGER_TYPE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRIGGER_TYPE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", "")]
    public static unsafe ENUM_TRIGGER_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRIGGER_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", "")]
    public static unsafe ENUM_TRIGGER_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_TRIGGER_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_TYPE;", (JniArgumentValue*) null);
      return (ENUM_TRIGGER_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_TRIGGER_TYPE));
    }
  }
}
