// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command
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
  [Register("com/zebra/ASCII_SDK/Command", DoNotGenerateAcw = true)]
  public abstract class Command : Object, IMsg, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command", typeof (Command));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getMsgType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Command._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Command._members.ManagedPeerType;

    protected Command(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command.cb_getCommandType == null)
        Command.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command.n_GetCommandType));
      return Command.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public abstract COMMAND_TYPE? CommandType { [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get; }

    private static Delegate GetGetMsgTypeHandler()
    {
      if ((object) Command.cb_getMsgType == null)
        Command.cb_getMsgType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command.n_GetMsgType));
      return Command.cb_getMsgType;
    }

    private static IntPtr n_GetMsgType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command>(jnienv, native__this, (JniHandleOwnership) 0).MsgType);
    }

    public virtual unsafe MSG_TYPE? MsgType
    {
      [Register("getMsgType", "()Lcom/zebra/ASCII_SDK/MSG_TYPE;", "GetGetMsgTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command._members.InstanceMethods.InvokeVirtualObjectMethod("getMsgType.()Lcom/zebra/ASCII_SDK/MSG_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command.cb_FromString_Ljava_lang_String_ == null)
        Command.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command.n_FromString_Ljava_lang_String_));
      return Command.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<Command>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public abstract void FromString(string? p0);

    private static Delegate GetToStringHandler()
    {
      if ((object) Command.cb_ToString == null)
        Command.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command.n_ToString));
      return Command.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public abstract string? ToString();
  }
}
