// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_MODULATION
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
  [Register("com/zebra/ASCII_SDK/ENUM_MODULATION", DoNotGenerateAcw = true)]
  public sealed class ENUM_MODULATION : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_MODULATION", typeof (ENUM_MODULATION));

    [Register("MV_2")]
    public static ENUM_MODULATION? Mv2
    {
      get
      {
        JniObjectReference objectValue = ENUM_MODULATION._members.StaticFields.GetObjectValue("MV_2.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;");
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_4")]
    public static ENUM_MODULATION? Mv4
    {
      get
      {
        JniObjectReference objectValue = ENUM_MODULATION._members.StaticFields.GetObjectValue("MV_4.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;");
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_8")]
    public static ENUM_MODULATION? Mv8
    {
      get
      {
        JniObjectReference objectValue = ENUM_MODULATION._members.StaticFields.GetObjectValue("MV_8.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;");
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_FM0")]
    public static ENUM_MODULATION? MvFm0
    {
      get
      {
        JniObjectReference objectValue = ENUM_MODULATION._members.StaticFields.GetObjectValue("MV_FM0.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;");
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_MODULATION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_MODULATION._members.ManagedPeerType;

    internal ENUM_MODULATION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_MODULATION._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", "")]
    public static unsafe ENUM_MODULATION? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_MODULATION._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", "")]
    public static unsafe ENUM_MODULATION? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_MODULATION._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", "")]
    public static unsafe ENUM_MODULATION[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_MODULATION._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", (JniArgumentValue*) null);
      return (ENUM_MODULATION[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_MODULATION));
    }
  }
}
