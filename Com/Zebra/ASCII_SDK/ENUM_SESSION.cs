// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_SESSION
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
  [Register("com/zebra/ASCII_SDK/ENUM_SESSION", DoNotGenerateAcw = true)]
  public sealed class ENUM_SESSION : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_SESSION", typeof (ENUM_SESSION));

    [Register("SESSION_S0")]
    public static ENUM_SESSION? SessionS0
    {
      get
      {
        JniObjectReference objectValue = ENUM_SESSION._members.StaticFields.GetObjectValue("SESSION_S0.Lcom/zebra/ASCII_SDK/ENUM_SESSION;");
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S1")]
    public static ENUM_SESSION? SessionS1
    {
      get
      {
        JniObjectReference objectValue = ENUM_SESSION._members.StaticFields.GetObjectValue("SESSION_S1.Lcom/zebra/ASCII_SDK/ENUM_SESSION;");
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S2")]
    public static ENUM_SESSION? SessionS2
    {
      get
      {
        JniObjectReference objectValue = ENUM_SESSION._members.StaticFields.GetObjectValue("SESSION_S2.Lcom/zebra/ASCII_SDK/ENUM_SESSION;");
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S3")]
    public static ENUM_SESSION? SessionS3
    {
      get
      {
        JniObjectReference objectValue = ENUM_SESSION._members.StaticFields.GetObjectValue("SESSION_S3.Lcom/zebra/ASCII_SDK/ENUM_SESSION;");
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_SESSION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_SESSION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_SESSION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_SESSION._members.ManagedPeerType;

    internal ENUM_SESSION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_SESSION._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SESSION;", "")]
    public static unsafe ENUM_SESSION? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SESSION._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SESSION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SESSION;", "")]
    public static unsafe ENUM_SESSION? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SESSION._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SESSION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_SESSION;", "")]
    public static unsafe ENUM_SESSION[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_SESSION._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_SESSION;", (JniArgumentValue*) null);
      return (ENUM_SESSION[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_SESSION));
    }
  }
}
