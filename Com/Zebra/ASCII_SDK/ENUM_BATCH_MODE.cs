// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_BATCH_MODE
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
  [Register("com/zebra/ASCII_SDK/ENUM_BATCH_MODE", DoNotGenerateAcw = true)]
  public sealed class ENUM_BATCH_MODE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_BATCH_MODE", typeof (ENUM_BATCH_MODE));

    [Register("AUTO")]
    public static ENUM_BATCH_MODE? Auto
    {
      get
      {
        JniObjectReference objectValue = ENUM_BATCH_MODE._members.StaticFields.GetObjectValue("AUTO.Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;");
        return Object.GetObject<ENUM_BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DISABLE")]
    public static ENUM_BATCH_MODE? Disable
    {
      get
      {
        JniObjectReference objectValue = ENUM_BATCH_MODE._members.StaticFields.GetObjectValue("DISABLE.Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;");
        return Object.GetObject<ENUM_BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ENABLE")]
    public static ENUM_BATCH_MODE? Enable
    {
      get
      {
        JniObjectReference objectValue = ENUM_BATCH_MODE._members.StaticFields.GetObjectValue("ENABLE.Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;");
        return Object.GetObject<ENUM_BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_BATCH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_BATCH_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_BATCH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_BATCH_MODE._members.ManagedPeerType;

    internal ENUM_BATCH_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_BATCH_MODE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", "")]
    public static unsafe ENUM_BATCH_MODE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BATCH_MODE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", "")]
    public static unsafe ENUM_BATCH_MODE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BATCH_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", "")]
    public static unsafe ENUM_BATCH_MODE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_BATCH_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_BATCH_MODE;", (JniArgumentValue*) null);
      return (ENUM_BATCH_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_BATCH_MODE));
    }
  }
}
