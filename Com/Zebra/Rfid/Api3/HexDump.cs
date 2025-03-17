// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.HexDump
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
  [Register("com/zebra/rfid/api3/HexDump", DoNotGenerateAcw = true)]
  public class HexDump : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/HexDump", typeof (HexDump));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = HexDump._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => HexDump._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = HexDump._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => HexDump._members.ManagedPeerType;

    protected HexDump(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe HexDump()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = HexDump._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      HexDump._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("dumpHexString", "([B)Ljava/lang/String;", "")]
    public static unsafe string? DumpHexString(byte[]? array)
    {
      IntPtr num = JNIEnv.NewArray(array);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("dumpHexString.([B)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (array != null)
        {
          JNIEnv.CopyArray(num, array);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) array);
      }
    }

    [Register("dumpHexString", "([BII)Ljava/lang/String;", "")]
    public static unsafe string? DumpHexString(byte[]? array, int offset, int length)
    {
      IntPtr num = JNIEnv.NewArray(array);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(offset),
          new JniArgumentValue(length)
        };
        JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("dumpHexString.([BII)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (array != null)
        {
          JNIEnv.CopyArray(num, array);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) array);
      }
    }

    [Register("hexStringToByteArray", "(Ljava/lang/String;)[B", "")]
    public static unsafe byte[]? HexStringToByteArray(string? hexString)
    {
      IntPtr num = JNIEnv.NewString(hexString);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("hexStringToByteArray.(Ljava/lang/String;)[B", jniArgumentValuePtr);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("toByteArray", "(B)[B", "")]
    public static unsafe byte[]? ToByteArray(sbyte b)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(b)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toByteArray.(B)[B", jniArgumentValuePtr);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    [Register("toByteArray", "(I)[B", "")]
    public static unsafe byte[]? ToByteArray(int i)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(i)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toByteArray.(I)[B", jniArgumentValuePtr);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    [Register("toByteArray", "(S)[B", "")]
    public static unsafe byte[]? ToByteArray(short i)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(i)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toByteArray.(S)[B", jniArgumentValuePtr);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    [Register("toHexString", "(B)Ljava/lang/String;", "")]
    public static unsafe string? ToHexString(sbyte b)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(b)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toHexString.(B)Ljava/lang/String;", jniArgumentValuePtr);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("toHexString", "([B)Ljava/lang/String;", "")]
    public static unsafe string? ToHexString(byte[]? array)
    {
      IntPtr num = JNIEnv.NewArray(array);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toHexString.([B)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (array != null)
        {
          JNIEnv.CopyArray(num, array);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) array);
      }
    }

    [Register("toHexString", "([BII)Ljava/lang/String;", "")]
    public static unsafe string? ToHexString(byte[]? array, int offset, int length)
    {
      IntPtr num = JNIEnv.NewArray(array);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(offset),
          new JniArgumentValue(length)
        };
        JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toHexString.([BII)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        if (array != null)
        {
          JNIEnv.CopyArray(num, array);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) array);
      }
    }

    [Register("toHexString", "(I)Ljava/lang/String;", "")]
    public static unsafe string? ToHexString(int i)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(i)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toHexString.(I)Ljava/lang/String;", jniArgumentValuePtr);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("toHexString", "(S)Ljava/lang/String;", "")]
    public static unsafe string? ToHexString(short i)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(i)
      };
      JniObjectReference jniObjectReference = HexDump._members.StaticMethods.InvokeObjectMethod("toHexString.(S)Ljava/lang/String;", jniArgumentValuePtr);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
