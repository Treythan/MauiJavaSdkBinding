// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.Fipssupport.Utils
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
namespace Com.Zebra.Scannercontrol.Fipssupport
{
  [Register("com/zebra/scannercontrol/fipssupport/Utils", DoNotGenerateAcw = true)]
  public class Utils : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/fipssupport/Utils", typeof (Utils));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Utils._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Utils._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Utils._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Utils._members.ManagedPeerType;

    protected Utils(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Utils()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Utils._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Utils._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("convertByteToString", "([B)Ljava/lang/String;", "")]
    public static unsafe string? ConvertByteToString(byte[]? buffer)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Utils._members.StaticMethods.InvokeObjectMethod("convertByteToString.([B)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }

    [Register("formatByteArray", "([B)Ljava/lang/String;", "")]
    public static unsafe string? FormatByteArray(byte[]? buffer)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Utils._members.StaticMethods.InvokeObjectMethod("formatByteArray.([B)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }

    [Register("printByteArray", "([B)V", "")]
    public static unsafe void PrintByteArray(byte[]? buffer)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Utils._members.StaticMethods.InvokeVoidMethod("printByteArray.([B)V", jniArgumentValuePtr);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }
  }
}
