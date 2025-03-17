// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_ChargeTerminal
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
  [Register("com/zebra/ASCII_SDK/Command_ChargeTerminal", DoNotGenerateAcw = true)]
  public class Command_ChargeTerminal : Command
  {
    [Register("commandName")]
    public const string CommandName = "chargeterminal";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_ChargeTerminal", typeof (Command_ChargeTerminal));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_setDisable;
    private static Delegate? cb_setEnable;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_ChargeTerminal._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_ChargeTerminal._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_ChargeTerminal._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_ChargeTerminal._members.ManagedPeerType;

    protected Command_ChargeTerminal(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_ChargeTerminal()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_ChargeTerminal._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_ChargeTerminal._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_ChargeTerminal.cb_getCommandType == null)
        Command_ChargeTerminal.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ChargeTerminal.n_GetCommandType));
      return Command_ChargeTerminal.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_ChargeTerminal>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_ChargeTerminal._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_ChargeTerminal.cb_FromString_Ljava_lang_String_ == null)
        Command_ChargeTerminal.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_ChargeTerminal.n_FromString_Ljava_lang_String_));
      return Command_ChargeTerminal.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_ChargeTerminal>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public override unsafe void FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_ChargeTerminal._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_ChargeTerminal.cb_ToString == null)
        Command_ChargeTerminal.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ChargeTerminal.n_ToString));
      return Command_ChargeTerminal.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_ChargeTerminal>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_ChargeTerminal._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetDisableHandler()
    {
      if ((object) Command_ChargeTerminal.cb_setDisable == null)
        Command_ChargeTerminal.cb_setDisable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_ChargeTerminal.n_SetDisable));
      return Command_ChargeTerminal.cb_setDisable;
    }

    private static void n_SetDisable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_ChargeTerminal>(jnienv, native__this, (JniHandleOwnership) 0).SetDisable();
    }

    [Register("setDisable", "()V", "GetSetDisableHandler")]
    public virtual unsafe void SetDisable()
    {
      Command_ChargeTerminal._members.InstanceMethods.InvokeVirtualVoidMethod("setDisable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetEnableHandler()
    {
      if ((object) Command_ChargeTerminal.cb_setEnable == null)
        Command_ChargeTerminal.cb_setEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_ChargeTerminal.n_SetEnable));
      return Command_ChargeTerminal.cb_setEnable;
    }

    private static void n_SetEnable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_ChargeTerminal>(jnienv, native__this, (JniHandleOwnership) 0).SetEnable();
    }

    [Register("setEnable", "()V", "GetSetEnableHandler")]
    public virtual unsafe void SetEnable()
    {
      Command_ChargeTerminal._members.InstanceMethods.InvokeVirtualVoidMethod("setEnable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
