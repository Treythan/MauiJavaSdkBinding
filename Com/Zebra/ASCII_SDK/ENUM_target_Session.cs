// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_target_Session
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
  [Register("com/zebra/ASCII_SDK/ENUM_target_Session", DoNotGenerateAcw = true)]
  public sealed class ENUM_target_Session : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_target_Session", typeof (ENUM_target_Session));

    [Register("Select_Flag")]
    public static ENUM_target_Session? SelectFlag
    {
      get
      {
        JniObjectReference objectValue = ENUM_target_Session._members.StaticFields.GetObjectValue("Select_Flag.Lcom/zebra/ASCII_SDK/ENUM_target_Session;");
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("Session_S0")]
    public static ENUM_target_Session? SessionS0
    {
      get
      {
        JniObjectReference objectValue = ENUM_target_Session._members.StaticFields.GetObjectValue("Session_S0.Lcom/zebra/ASCII_SDK/ENUM_target_Session;");
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("Session_S1")]
    public static ENUM_target_Session? SessionS1
    {
      get
      {
        JniObjectReference objectValue = ENUM_target_Session._members.StaticFields.GetObjectValue("Session_S1.Lcom/zebra/ASCII_SDK/ENUM_target_Session;");
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("Session_S2")]
    public static ENUM_target_Session? SessionS2
    {
      get
      {
        JniObjectReference objectValue = ENUM_target_Session._members.StaticFields.GetObjectValue("Session_S2.Lcom/zebra/ASCII_SDK/ENUM_target_Session;");
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("Session_S3")]
    public static ENUM_target_Session? SessionS3
    {
      get
      {
        JniObjectReference objectValue = ENUM_target_Session._members.StaticFields.GetObjectValue("Session_S3.Lcom/zebra/ASCII_SDK/ENUM_target_Session;");
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_target_Session._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_target_Session._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_target_Session._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_target_Session._members.ManagedPeerType;

    internal ENUM_target_Session(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_target_Session;", "")]
    public static unsafe ENUM_target_Session? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_target_Session._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_target_Session;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_target_Session>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_target_Session;", "")]
    public static unsafe ENUM_target_Session[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_target_Session._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_target_Session;", (JniArgumentValue*) null);
      return (ENUM_target_Session[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_target_Session));
    }
  }
}
