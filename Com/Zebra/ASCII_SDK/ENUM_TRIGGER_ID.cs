// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_TRIGGER_ID
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
  [Register("com/zebra/ASCII_SDK/ENUM_TRIGGER_ID", DoNotGenerateAcw = true)]
  public sealed class ENUM_TRIGGER_ID : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_TRIGGER_ID", typeof (ENUM_TRIGGER_ID));

    [Register("TRIGGER_PRESS")]
    public static ENUM_TRIGGER_ID? TriggerPress
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_ID._members.StaticFields.GetObjectValue("TRIGGER_PRESS.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;");
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRIGGER_RELEASE")]
    public static ENUM_TRIGGER_ID? TriggerRelease
    {
      get
      {
        JniObjectReference objectValue = ENUM_TRIGGER_ID._members.StaticFields.GetObjectValue("TRIGGER_RELEASE.Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;");
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_ID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_TRIGGER_ID._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_TRIGGER_ID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_TRIGGER_ID._members.ManagedPeerType;

    internal ENUM_TRIGGER_ID(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_TRIGGER_ID._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", "")]
    public static unsafe ENUM_TRIGGER_ID? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRIGGER_ID._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", "")]
    public static unsafe ENUM_TRIGGER_ID? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_TRIGGER_ID._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", "")]
    public static unsafe ENUM_TRIGGER_ID[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_TRIGGER_ID._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", (JniArgumentValue*) null);
      return (ENUM_TRIGGER_ID[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_TRIGGER_ID));
    }
  }
}
