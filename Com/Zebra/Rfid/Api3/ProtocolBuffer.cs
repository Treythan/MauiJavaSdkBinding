// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ProtocolBuffer
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
  [Register("com/zebra/rfid/api3/ProtocolBuffer", DoNotGenerateAcw = true)]
  public class ProtocolBuffer : Object
  {
    [Register("BINARY")]
    public const string Binary = "binary";
    [Register("TEXT")]
    public const string Text = "text";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ProtocolBuffer", typeof (ProtocolBuffer));
    private static Delegate? cb_hasMoreCommands;
    private static Delegate? cb_appendData_arrayB;
    private static Delegate? cb_nextBinaryCommand;
    private static Delegate? cb_nextTextCommand;
    private static Delegate? cb_setDelimiter_arrayB;
    private static Delegate? cb_setDelimiter_Ljava_lang_String_;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = ProtocolBuffer._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ProtocolBuffer._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ProtocolBuffer._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ProtocolBuffer._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ProtocolBuffer._members.ManagedPeerType;

    protected ProtocolBuffer(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/String;)V", "")]
    public unsafe ProtocolBuffer(string? mode)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(mode);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference instance = ProtocolBuffer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ProtocolBuffer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;I)V", "")]
    public unsafe ProtocolBuffer(string? mode, int bufferSize)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(mode);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(bufferSize)
        };
        JniObjectReference instance = ProtocolBuffer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ProtocolBuffer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetHasMoreCommandsHandler()
    {
      if ((object) ProtocolBuffer.cb_hasMoreCommands == null)
        ProtocolBuffer.cb_hasMoreCommands = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ProtocolBuffer.n_HasMoreCommands));
      return ProtocolBuffer.cb_hasMoreCommands;
    }

    private static bool n_HasMoreCommands(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0).HasMoreCommands;
    }

    public virtual unsafe bool HasMoreCommands
    {
      [Register("hasMoreCommands", "()Z", "GetHasMoreCommandsHandler")] get
      {
        return ProtocolBuffer._members.InstanceMethods.InvokeVirtualBooleanMethod("hasMoreCommands.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetAppendData_arrayBHandler()
    {
      if ((object) ProtocolBuffer.cb_appendData_arrayB == null)
        ProtocolBuffer.cb_appendData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ProtocolBuffer.n_AppendData_arrayB));
      return ProtocolBuffer.cb_appendData_arrayB;
    }

    private static void n_AppendData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      ProtocolBuffer protocolBuffer = Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      protocolBuffer.AppendData(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("appendData", "([B)V", "GetAppendData_arrayBHandler")]
    public virtual unsafe void AppendData(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ProtocolBuffer._members.InstanceMethods.InvokeVirtualVoidMethod("appendData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (data != null)
        {
          JNIEnv.CopyArray(num, data);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) data);
      }
    }

    private static Delegate GetNextBinaryCommandHandler()
    {
      if ((object) ProtocolBuffer.cb_nextBinaryCommand == null)
        ProtocolBuffer.cb_nextBinaryCommand = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ProtocolBuffer.n_NextBinaryCommand));
      return ProtocolBuffer.cb_nextBinaryCommand;
    }

    private static IntPtr n_NextBinaryCommand(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0).NextBinaryCommand());
    }

    [Register("nextBinaryCommand", "()[B", "GetNextBinaryCommandHandler")]
    public virtual unsafe byte[]? NextBinaryCommand()
    {
      JniObjectReference jniObjectReference = ProtocolBuffer._members.InstanceMethods.InvokeVirtualObjectMethod("nextBinaryCommand.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetNextTextCommandHandler()
    {
      if ((object) ProtocolBuffer.cb_nextTextCommand == null)
        ProtocolBuffer.cb_nextTextCommand = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ProtocolBuffer.n_NextTextCommand));
      return ProtocolBuffer.cb_nextTextCommand;
    }

    private static IntPtr n_NextTextCommand(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0).NextTextCommand());
    }

    [Register("nextTextCommand", "()Ljava/lang/String;", "GetNextTextCommandHandler")]
    public virtual unsafe string? NextTextCommand()
    {
      JniObjectReference jniObjectReference = ProtocolBuffer._members.InstanceMethods.InvokeVirtualObjectMethod("nextTextCommand.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetDelimiter_arrayBHandler()
    {
      if ((object) ProtocolBuffer.cb_setDelimiter_arrayB == null)
        ProtocolBuffer.cb_setDelimiter_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ProtocolBuffer.n_SetDelimiter_arrayB));
      return ProtocolBuffer.cb_setDelimiter_arrayB;
    }

    private static void n_SetDelimiter_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_delimiter)
    {
      ProtocolBuffer protocolBuffer = Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_delimiter, (JniHandleOwnership) 0, typeof (byte));
      byte[] delimiter = array;
      protocolBuffer.SetDelimiter(delimiter);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_delimiter);
    }

    [Register("setDelimiter", "([B)V", "GetSetDelimiter_arrayBHandler")]
    public virtual unsafe void SetDelimiter(byte[]? delimiter)
    {
      IntPtr num = JNIEnv.NewArray(delimiter);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ProtocolBuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setDelimiter.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (delimiter != null)
        {
          JNIEnv.CopyArray(num, delimiter);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) delimiter);
      }
    }

    private static Delegate GetSetDelimiter_Ljava_lang_String_Handler()
    {
      if ((object) ProtocolBuffer.cb_setDelimiter_Ljava_lang_String_ == null)
        ProtocolBuffer.cb_setDelimiter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ProtocolBuffer.n_SetDelimiter_Ljava_lang_String_));
      return ProtocolBuffer.cb_setDelimiter_Ljava_lang_String_;
    }

    private static void n_SetDelimiter_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_delimiter)
    {
      Object.GetObject<ProtocolBuffer>(jnienv, native__this, (JniHandleOwnership) 0).SetDelimiter(JNIEnv.GetString(native_delimiter, (JniHandleOwnership) 0));
    }

    [Register("setDelimiter", "(Ljava/lang/String;)V", "GetSetDelimiter_Ljava_lang_String_Handler")]
    public virtual unsafe void SetDelimiter(string? delimiter)
    {
      IntPtr num = JNIEnv.NewString(delimiter);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        ProtocolBuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setDelimiter.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
