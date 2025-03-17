// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_CHANGE_CONFIG_MODE
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
  [Register("com/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE", DoNotGenerateAcw = true)]
  public sealed class ENUM_CHANGE_CONFIG_MODE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE", typeof (ENUM_CHANGE_CONFIG_MODE));

    [Register("RESTORE_CUSOME_DEFAULTS")]
    public static ENUM_CHANGE_CONFIG_MODE? RestoreCusomeDefaults
    {
      get
      {
        JniObjectReference objectValue = ENUM_CHANGE_CONFIG_MODE._members.StaticFields.GetObjectValue("RESTORE_CUSOME_DEFAULTS.Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;");
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RESTORE_FACTORY_DEFAULTS")]
    public static ENUM_CHANGE_CONFIG_MODE? RestoreFactoryDefaults
    {
      get
      {
        JniObjectReference objectValue = ENUM_CHANGE_CONFIG_MODE._members.StaticFields.GetObjectValue("RESTORE_FACTORY_DEFAULTS.Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;");
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SAVE_CONFIG")]
    public static ENUM_CHANGE_CONFIG_MODE? SaveConfig
    {
      get
      {
        JniObjectReference objectValue = ENUM_CHANGE_CONFIG_MODE._members.StaticFields.GetObjectValue("SAVE_CONFIG.Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;");
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SAVE_CUSOME_DEFAULTS")]
    public static ENUM_CHANGE_CONFIG_MODE? SaveCusomeDefaults
    {
      get
      {
        JniObjectReference objectValue = ENUM_CHANGE_CONFIG_MODE._members.StaticFields.GetObjectValue("SAVE_CUSOME_DEFAULTS.Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;");
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_CHANGE_CONFIG_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_CHANGE_CONFIG_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_CHANGE_CONFIG_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_CHANGE_CONFIG_MODE._members.ManagedPeerType;

    internal ENUM_CHANGE_CONFIG_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_CHANGE_CONFIG_MODE._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", "")]
    public static unsafe ENUM_CHANGE_CONFIG_MODE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_CHANGE_CONFIG_MODE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", "")]
    public static unsafe ENUM_CHANGE_CONFIG_MODE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_CHANGE_CONFIG_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", "")]
    public static unsafe ENUM_CHANGE_CONFIG_MODE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_CHANGE_CONFIG_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", (JniArgumentValue*) null);
      return (ENUM_CHANGE_CONFIG_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_CHANGE_CONFIG_MODE));
    }
  }
}
