// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.MSG_TYPE
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
  [Register("com/zebra/ASCII_SDK/MSG_TYPE", DoNotGenerateAcw = true)]
  public sealed class MSG_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/MSG_TYPE", typeof (MSG_TYPE));

    [Register("COMMAND")]
    public static MSG_TYPE? Command
    {
      get
      {
        JniObjectReference objectValue = MSG_TYPE._members.StaticFields.GetObjectValue("COMMAND.Lcom/zebra/ASCII_SDK/MSG_TYPE;");
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("METADATA")]
    public static MSG_TYPE? Metadata
    {
      get
      {
        JniObjectReference objectValue = MSG_TYPE._members.StaticFields.GetObjectValue("METADATA.Lcom/zebra/ASCII_SDK/MSG_TYPE;");
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOTIFICATION")]
    public static MSG_TYPE? Notification
    {
      get
      {
        JniObjectReference objectValue = MSG_TYPE._members.StaticFields.GetObjectValue("NOTIFICATION.Lcom/zebra/ASCII_SDK/MSG_TYPE;");
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RESPONSE_MSG")]
    public static MSG_TYPE? ResponseMsg
    {
      get
      {
        JniObjectReference objectValue = MSG_TYPE._members.StaticFields.GetObjectValue("RESPONSE_MSG.Lcom/zebra/ASCII_SDK/MSG_TYPE;");
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MSG_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MSG_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MSG_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MSG_TYPE._members.ManagedPeerType;

    internal MSG_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/MSG_TYPE;", "")]
    public static unsafe MSG_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = MSG_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/MSG_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/MSG_TYPE;", "")]
    public static unsafe MSG_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = MSG_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/MSG_TYPE;", (JniArgumentValue*) null);
      return (MSG_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (MSG_TYPE));
    }
  }
}
