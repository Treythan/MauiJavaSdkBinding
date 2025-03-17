// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_TARGET
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
  [Register("com/zebra/ASCII_SDK/ENUM_TARGET", DoNotGenerateAcw = true)]
  public sealed class ENUM_TARGET : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_TARGET", typeof (ENUM_TARGET));

    [Register("SESSION_S0")]
    public static ENUM_TARGET? SessionS0
    {
      get
      {
        JniObjectReference objectValue = ENUM_TARGET._members.StaticFields.GetObjectValue("SESSION_S0.Lcom/zebra/ASCII_SDK/ENUM_TARGET;");
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S1")]
    public static ENUM_TARGET? SessionS1
    {
      get
      {
        JniObjectReference objectValue = ENUM_TARGET._members.StaticFields.GetObjectValue("SESSION_S1.Lcom/zebra/ASCII_SDK/ENUM_TARGET;");
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S2")]
    public static ENUM_TARGET? SessionS2
    {
      get
      {
        JniObjectReference objectValue = ENUM_TARGET._members.StaticFields.GetObjectValue("SESSION_S2.Lcom/zebra/ASCII_SDK/ENUM_TARGET;");
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S3")]
    public static ENUM_TARGET? SessionS3
    {
      get
      {
        JniObjectReference objectValue = ENUM_TARGET._members.StaticFields.GetObjectValue("SESSION_S3.Lcom/zebra/ASCII_SDK/ENUM_TARGET;");
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_FLAG")]
    public static ENUM_TARGET? SlFlag
    {
      get
      {
        JniObjectReference objectValue = ENUM_TARGET._members.StaticFields.GetObjectValue("SL_FLAG.Lcom/zebra/ASCII_SDK/ENUM_TARGET;");
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_TARGET._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_TARGET._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_TARGET._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_TARGET._members.ManagedPeerType;

    internal ENUM_TARGET(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_TARGET._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TARGET;", "")]
    public static unsafe ENUM_TARGET? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TARGET._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TARGET;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TARGET;", "")]
    public static unsafe ENUM_TARGET? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TARGET._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TARGET;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_TARGET;", "")]
    public static unsafe ENUM_TARGET[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_TARGET._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_TARGET;", (JniArgumentValue*) null);
      return (ENUM_TARGET[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_TARGET));
    }
  }
}
