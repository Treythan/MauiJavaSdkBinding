// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ASCIIUtil
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
  [Register("com/zebra/ASCII_SDK/ASCIIUtil", DoNotGenerateAcw = true)]
  public class ASCIIUtil : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ASCIIUtil", typeof (ASCIIUtil));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ASCIIUtil._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ASCIIUtil._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ASCIIUtil._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ASCIIUtil._members.ManagedPeerType;

    protected ASCIIUtil(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ASCIIUtil()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ASCIIUtil._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ASCIIUtil._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("ConvertArrayToNibbleArray", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
    public static unsafe Object? ConvertArrayToNibbleArray(Object? val)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(val == null ? IntPtr.Zero : val.Handle)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("ConvertArrayToNibbleArray.(Ljava/lang/Object;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) val);
      }
    }

    [Register("ConvertArrayToString", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
    public static unsafe Object? ConvertArrayToString(Object? val, string? type, string? format)
    {
      IntPtr num1 = JNIEnv.NewString(type);
      IntPtr num2 = JNIEnv.NewString(format);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(val == null ? IntPtr.Zero : val.Handle),
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("ConvertArrayToString.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) val);
      }
    }

    [Register("GetNodeValue", "([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
    public static unsafe string? GetNodeValue(string[]? strArray, string? key)
    {
      IntPtr num1 = JNIEnv.NewArray(strArray);
      IntPtr num2 = JNIEnv.NewString(key);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("GetNodeValue.([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (strArray != null)
        {
          JNIEnv.CopyArray(num1, strArray);
          JNIEnv.DeleteLocalRef(num1);
        }
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) strArray);
      }
    }

    [Register("GetNodeValue1", "([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
    public static unsafe string? GetNodeValue1(string[]? strArray, string? key)
    {
      IntPtr num1 = JNIEnv.NewArray(strArray);
      IntPtr num2 = JNIEnv.NewString(key);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("GetNodeValue1.([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (strArray != null)
        {
          JNIEnv.CopyArray(num1, strArray);
          JNIEnv.DeleteLocalRef(num1);
        }
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) strArray);
      }
    }

    [Register("GetNodes", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
    public static unsafe string[]? GetNodes(string? strArray, string? key)
    {
      IntPtr num1 = JNIEnv.NewString(strArray);
      IntPtr num2 = JNIEnv.NewString(key);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("GetNodes.(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", jniArgumentValuePtr);
        return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    [Register("IsNodePresent", "([Ljava/lang/String;Ljava/lang/String;)Z", "")]
    public static unsafe bool IsNodePresent(string[]? strArray, string? key)
    {
      IntPtr num1 = JNIEnv.NewArray(strArray);
      IntPtr num2 = JNIEnv.NewString(key);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        return ASCIIUtil._members.StaticMethods.InvokeBooleanMethod("IsNodePresent.([Ljava/lang/String;Ljava/lang/String;)Z", jniArgumentValuePtr);
      }
      finally
      {
        if (strArray != null)
        {
          JNIEnv.CopyArray(num1, strArray);
          JNIEnv.DeleteLocalRef(num1);
        }
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) strArray);
      }
    }

    [Register("ParseArrayFromString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
    public static unsafe Object? ParseArrayFromString(string? val, string? type, string? format)
    {
      IntPtr num1 = JNIEnv.NewString(val);
      IntPtr num2 = JNIEnv.NewString(type);
      IntPtr num3 = JNIEnv.NewString(format);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("ParseArrayFromString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
      }
    }

    [Register("ParseValueTypeFromString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
    public static unsafe Object? ParseValueTypeFromString(string? val, string? type)
    {
      IntPtr num1 = JNIEnv.NewString(val);
      IntPtr num2 = JNIEnv.NewString(type);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("ParseValueTypeFromString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    [Register("ParseValueTypeFromString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
    public static unsafe Object? ParseValueTypeFromString(string? val, string? type, string? format)
    {
      IntPtr num1 = JNIEnv.NewString(val);
      IntPtr num2 = JNIEnv.NewString(type);
      IntPtr num3 = JNIEnv.NewString(format);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3)
        };
        JniObjectReference jniObjectReference = ASCIIUtil._members.StaticMethods.InvokeObjectMethod("ParseValueTypeFromString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
      }
    }

    [Register("isNullOrBlank", "(Ljava/lang/String;)Z", "")]
    public static unsafe bool IsNullOrBlank(string? param)
    {
      IntPtr num = JNIEnv.NewString(param);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        return ASCIIUtil._members.StaticMethods.InvokeBooleanMethod("isNullOrBlank.(Ljava/lang/String;)Z", jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
