// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_BEEPER_VOLUME
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
  [Register("com/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME", DoNotGenerateAcw = true)]
  public sealed class ENUM_BEEPER_VOLUME : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME", typeof (ENUM_BEEPER_VOLUME));

    [Register("HIGH_BEEP")]
    public static ENUM_BEEPER_VOLUME? HighBeep
    {
      get
      {
        JniObjectReference objectValue = ENUM_BEEPER_VOLUME._members.StaticFields.GetObjectValue("HIGH_BEEP.Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;");
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOW_BEEP")]
    public static ENUM_BEEPER_VOLUME? LowBeep
    {
      get
      {
        JniObjectReference objectValue = ENUM_BEEPER_VOLUME._members.StaticFields.GetObjectValue("LOW_BEEP.Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;");
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEDIUM_BEE")]
    public static ENUM_BEEPER_VOLUME? MediumBee
    {
      get
      {
        JniObjectReference objectValue = ENUM_BEEPER_VOLUME._members.StaticFields.GetObjectValue("MEDIUM_BEE.Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;");
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("QUITE_BEEP")]
    public static ENUM_BEEPER_VOLUME? QuiteBeep
    {
      get
      {
        JniObjectReference objectValue = ENUM_BEEPER_VOLUME._members.StaticFields.GetObjectValue("QUITE_BEEP.Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;");
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_BEEPER_VOLUME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_BEEPER_VOLUME._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_BEEPER_VOLUME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_BEEPER_VOLUME._members.ManagedPeerType;

    internal ENUM_BEEPER_VOLUME(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_BEEPER_VOLUME._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", "")]
    public static unsafe ENUM_BEEPER_VOLUME? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BEEPER_VOLUME._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", "")]
    public static unsafe ENUM_BEEPER_VOLUME? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_BEEPER_VOLUME._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_BEEPER_VOLUME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", "")]
    public static unsafe ENUM_BEEPER_VOLUME[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_BEEPER_VOLUME._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_BEEPER_VOLUME;", (JniArgumentValue*) null);
      return (ENUM_BEEPER_VOLUME[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_BEEPER_VOLUME));
    }
  }
}
