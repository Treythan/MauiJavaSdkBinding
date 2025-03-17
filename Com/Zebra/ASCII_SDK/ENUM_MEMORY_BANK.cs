// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_MEMORY_BANK
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
  [Register("com/zebra/ASCII_SDK/ENUM_MEMORY_BANK", DoNotGenerateAcw = true)]
  public sealed class ENUM_MEMORY_BANK : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_MEMORY_BANK", typeof (ENUM_MEMORY_BANK));

    [Register("EPC")]
    public static ENUM_MEMORY_BANK? Epc
    {
      get
      {
        JniObjectReference objectValue = ENUM_MEMORY_BANK._members.StaticFields.GetObjectValue("EPC.Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;");
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RESV")]
    public static ENUM_MEMORY_BANK? Resv
    {
      get
      {
        JniObjectReference objectValue = ENUM_MEMORY_BANK._members.StaticFields.GetObjectValue("RESV.Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;");
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TID")]
    public static ENUM_MEMORY_BANK? Tid
    {
      get
      {
        JniObjectReference objectValue = ENUM_MEMORY_BANK._members.StaticFields.GetObjectValue("TID.Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;");
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("USER")]
    public static ENUM_MEMORY_BANK? User
    {
      get
      {
        JniObjectReference objectValue = ENUM_MEMORY_BANK._members.StaticFields.GetObjectValue("USER.Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;");
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_MEMORY_BANK._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_MEMORY_BANK._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_MEMORY_BANK._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_MEMORY_BANK._members.ManagedPeerType;

    internal ENUM_MEMORY_BANK(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_MEMORY_BANK._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "")]
    public static unsafe ENUM_MEMORY_BANK? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_MEMORY_BANK._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "")]
    public static unsafe ENUM_MEMORY_BANK? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_MEMORY_BANK._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "")]
    public static unsafe ENUM_MEMORY_BANK[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_MEMORY_BANK._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (JniArgumentValue*) null);
      return (ENUM_MEMORY_BANK[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_MEMORY_BANK));
    }
  }
}
