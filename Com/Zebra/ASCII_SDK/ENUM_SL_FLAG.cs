// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_SL_FLAG
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
  [Register("com/zebra/ASCII_SDK/ENUM_SL_FLAG", DoNotGenerateAcw = true)]
  public sealed class ENUM_SL_FLAG : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_SL_FLAG", typeof (ENUM_SL_FLAG));

    [Register("DUMMY_SL_ALL")]
    public static ENUM_SL_FLAG? DummySlAll
    {
      get
      {
        JniObjectReference objectValue = ENUM_SL_FLAG._members.StaticFields.GetObjectValue("DUMMY_SL_ALL.Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;");
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_ALL")]
    public static ENUM_SL_FLAG? SlAll
    {
      get
      {
        JniObjectReference objectValue = ENUM_SL_FLAG._members.StaticFields.GetObjectValue("SL_ALL.Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;");
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_FLAG_ASSERTED")]
    public static ENUM_SL_FLAG? SlFlagAsserted
    {
      get
      {
        JniObjectReference objectValue = ENUM_SL_FLAG._members.StaticFields.GetObjectValue("SL_FLAG_ASSERTED.Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;");
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_FLAG_DEASSERTED")]
    public static ENUM_SL_FLAG? SlFlagDeasserted
    {
      get
      {
        JniObjectReference objectValue = ENUM_SL_FLAG._members.StaticFields.GetObjectValue("SL_FLAG_DEASSERTED.Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;");
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_SL_FLAG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_SL_FLAG._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_SL_FLAG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_SL_FLAG._members.ManagedPeerType;

    internal ENUM_SL_FLAG(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_SL_FLAG._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", "")]
    public static unsafe ENUM_SL_FLAG? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SL_FLAG._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", "")]
    public static unsafe ENUM_SL_FLAG? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SL_FLAG._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", "")]
    public static unsafe ENUM_SL_FLAG[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_SL_FLAG._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", (JniArgumentValue*) null);
      return (ENUM_SL_FLAG[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_SL_FLAG));
    }
  }
}
