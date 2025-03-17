// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UNTRACEABLE_TID
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/UNTRACEABLE_TID", DoNotGenerateAcw = true)]
  public class UNTRACEABLE_TID : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UNTRACEABLE_TID", typeof (UNTRACEABLE_TID));

    [Register("HIDE_ALL_TID")]
    public static UNTRACEABLE_TID? HideAllTid
    {
      get
      {
        JniObjectReference objectValue = UNTRACEABLE_TID._members.StaticFields.GetObjectValue("HIDE_ALL_TID.Lcom/zebra/rfid/api3/UNTRACEABLE_TID;");
        return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HIDE_SOME_TID")]
    public static UNTRACEABLE_TID? HideSomeTid
    {
      get
      {
        JniObjectReference objectValue = UNTRACEABLE_TID._members.StaticFields.GetObjectValue("HIDE_SOME_TID.Lcom/zebra/rfid/api3/UNTRACEABLE_TID;");
        return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return UNTRACEABLE_TID._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        UNTRACEABLE_TID._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("SHOW_TID")]
    public static UNTRACEABLE_TID? ShowTid
    {
      get
      {
        JniObjectReference objectValue = UNTRACEABLE_TID._members.StaticFields.GetObjectValue("SHOW_TID.Lcom/zebra/rfid/api3/UNTRACEABLE_TID;");
        return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UNTRACEABLE_TID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UNTRACEABLE_TID._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UNTRACEABLE_TID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UNTRACEABLE_TID._members.ManagedPeerType;

    protected UNTRACEABLE_TID(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("GetUntraceableTidValue", "(I)Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", "")]
    public static unsafe UNTRACEABLE_TID? GetUntraceableTidValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = UNTRACEABLE_TID._members.StaticMethods.InvokeObjectMethod("GetUntraceableTidValue.(I)Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", jniArgumentValuePtr);
      return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetUntraceableTidValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", "")]
    public static unsafe UNTRACEABLE_TID? GetUntraceableTidValue(string? untraceableTid)
    {
      IntPtr num = JNIEnv.NewString(untraceableTid);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = UNTRACEABLE_TID._members.StaticMethods.InvokeObjectMethod("GetUntraceableTidValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", jniArgumentValuePtr);
        return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
