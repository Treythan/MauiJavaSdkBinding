// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_DEVIDE_RATIO
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
  [Register("com/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO", DoNotGenerateAcw = true)]
  public sealed class ENUM_DEVIDE_RATIO : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO", typeof (ENUM_DEVIDE_RATIO));

    [Register("DR_64_3")]
    public static ENUM_DEVIDE_RATIO? Dr643
    {
      get
      {
        JniObjectReference objectValue = ENUM_DEVIDE_RATIO._members.StaticFields.GetObjectValue("DR_64_3.Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;");
        return Object.GetObject<ENUM_DEVIDE_RATIO>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DR_8")]
    public static ENUM_DEVIDE_RATIO? Dr8
    {
      get
      {
        JniObjectReference objectValue = ENUM_DEVIDE_RATIO._members.StaticFields.GetObjectValue("DR_8.Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;");
        return Object.GetObject<ENUM_DEVIDE_RATIO>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_DEVIDE_RATIO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_DEVIDE_RATIO._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_DEVIDE_RATIO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_DEVIDE_RATIO._members.ManagedPeerType;

    internal ENUM_DEVIDE_RATIO(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_DEVIDE_RATIO._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", "")]
    public static unsafe ENUM_DEVIDE_RATIO? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_DEVIDE_RATIO._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_DEVIDE_RATIO>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", "")]
    public static unsafe ENUM_DEVIDE_RATIO? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_DEVIDE_RATIO._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_DEVIDE_RATIO>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", "")]
    public static unsafe ENUM_DEVIDE_RATIO[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_DEVIDE_RATIO._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", (JniArgumentValue*) null);
      return (ENUM_DEVIDE_RATIO[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_DEVIDE_RATIO));
    }
  }
}
