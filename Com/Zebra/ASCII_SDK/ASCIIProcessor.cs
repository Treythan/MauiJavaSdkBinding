// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ASCIIProcessor
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Com.Zebra.Rfid.Api3;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/ASCIIProcessor", DoNotGenerateAcw = true)]
  public class ASCIIProcessor : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ASCIIProcessor", typeof (ASCIIProcessor));

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = ASCIIProcessor._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ASCIIProcessor._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ASCIIProcessor._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ASCIIProcessor._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ASCIIProcessor._members.ManagedPeerType;

    protected ASCIIProcessor(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ASCIIProcessor()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ASCIIProcessor._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ASCIIProcessor._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("getCommandConfig", "(Lcom/zebra/ASCII_SDK/COMMAND_TYPE;Lcom/zebra/ASCII_SDK/CONFIG_TYPE;)Ljava/lang/String;", "")]
    public static unsafe string? GetCommandConfig(COMMAND_TYPE? cmdType, CONFIG_TYPE? configType)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(cmdType == null ? IntPtr.Zero : ((Object) cmdType).Handle),
          new JniArgumentValue(configType == null ? IntPtr.Zero : ((Object) configType).Handle)
        };
        JniObjectReference jniObjectReference = ASCIIProcessor._members.StaticMethods.InvokeObjectMethod("getCommandConfig.(Lcom/zebra/ASCII_SDK/COMMAND_TYPE;Lcom/zebra/ASCII_SDK/CONFIG_TYPE;)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) cmdType);
        GC.KeepAlive((object) configType);
      }
    }

    [Register("getCommandString", "(Lcom/zebra/ASCII_SDK/Command;)Ljava/lang/String;", "")]
    public static unsafe string? GetCommandString(Command? cmd)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(cmd == null ? IntPtr.Zero : cmd.Handle)
        };
        JniObjectReference jniObjectReference = ASCIIProcessor._members.StaticMethods.InvokeObjectMethod("getCommandString.(Lcom/zebra/ASCII_SDK/Command;)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) cmd);
      }
    }

    [Register("getReplyMsg", "(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/IMsg;", "")]
    public static unsafe IMsg? GetReplyMsg(string? msgString, MetaData? metaData)
    {
      IntPtr num = JNIEnv.NewString(msgString);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(metaData == null ? IntPtr.Zero : metaData.Handle)
        };
        JniObjectReference jniObjectReference = ASCIIProcessor._members.StaticMethods.InvokeObjectMethod("getReplyMsg.(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/IMsg;", jniArgumentValuePtr);
        return Object.GetObject<IMsg>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) metaData);
      }
    }
  }
}
