// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_SPECTRAL_MASK_INDICATOR
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
  [Register("com/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR", DoNotGenerateAcw = true)]
  public sealed class ENUM_SPECTRAL_MASK_INDICATOR : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR", typeof (ENUM_SPECTRAL_MASK_INDICATOR));

    [Register("SMI_DI")]
    public static ENUM_SPECTRAL_MASK_INDICATOR? SmiDi
    {
      get
      {
        JniObjectReference objectValue = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_DI.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_MI")]
    public static ENUM_SPECTRAL_MASK_INDICATOR? SmiMi
    {
      get
      {
        JniObjectReference objectValue = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_MI.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_SI")]
    public static ENUM_SPECTRAL_MASK_INDICATOR? SmiSi
    {
      get
      {
        JniObjectReference objectValue = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_SI.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_UNKNOWN")]
    public static ENUM_SPECTRAL_MASK_INDICATOR? SmiUnknown
    {
      get
      {
        JniObjectReference objectValue = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_UNKNOWN.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_SPECTRAL_MASK_INDICATOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_SPECTRAL_MASK_INDICATOR._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_SPECTRAL_MASK_INDICATOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_SPECTRAL_MASK_INDICATOR._members.ManagedPeerType;

    internal ENUM_SPECTRAL_MASK_INDICATOR(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_SPECTRAL_MASK_INDICATOR._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", "")]
    public static unsafe ENUM_SPECTRAL_MASK_INDICATOR? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", "")]
    public static unsafe ENUM_SPECTRAL_MASK_INDICATOR? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", "")]
    public static unsafe ENUM_SPECTRAL_MASK_INDICATOR[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_SPECTRAL_MASK_INDICATOR._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", (JniArgumentValue*) null);
      return (ENUM_SPECTRAL_MASK_INDICATOR[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_SPECTRAL_MASK_INDICATOR));
    }
  }
}
