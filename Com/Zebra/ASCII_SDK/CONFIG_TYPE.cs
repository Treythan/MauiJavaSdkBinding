// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.CONFIG_TYPE
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
  [Register("com/zebra/ASCII_SDK/CONFIG_TYPE", DoNotGenerateAcw = true)]
  public sealed class CONFIG_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/CONFIG_TYPE", typeof (CONFIG_TYPE));

    [Register("CURRENT")]
    public static CONFIG_TYPE? Current
    {
      get
      {
        JniObjectReference objectValue = CONFIG_TYPE._members.StaticFields.GetObjectValue("CURRENT.Lcom/zebra/ASCII_SDK/CONFIG_TYPE;");
        return Object.GetObject<CONFIG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DEFAULT")]
    public static CONFIG_TYPE? Default
    {
      get
      {
        JniObjectReference objectValue = CONFIG_TYPE._members.StaticFields.GetObjectValue("DEFAULT.Lcom/zebra/ASCII_SDK/CONFIG_TYPE;");
        return Object.GetObject<CONFIG_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CONFIG_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CONFIG_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CONFIG_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CONFIG_TYPE._members.ManagedPeerType;

    internal CONFIG_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/CONFIG_TYPE;", "")]
    public static unsafe CONFIG_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = CONFIG_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/CONFIG_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<CONFIG_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/CONFIG_TYPE;", "")]
    public static unsafe CONFIG_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = CONFIG_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/CONFIG_TYPE;", (JniArgumentValue*) null);
      return (CONFIG_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (CONFIG_TYPE));
    }
  }
}
