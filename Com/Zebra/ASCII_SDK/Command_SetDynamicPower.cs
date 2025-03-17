// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetDynamicPower
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
  [Register("com/zebra/ASCII_SDK/Command_SetDynamicPower", DoNotGenerateAcw = true)]
  public class Command_SetDynamicPower : Command
  {
    [Register("commandName")]
    public const string CommandName = "setdynamicpower";
    [Register("DISABLE_DYNAMIC_POWER")]
    public const int DisableDynamicPower = 0;
    [Register("ENABLE_DYNAMIC_POWER")]
    public const int EnableDynamicPower = 1;
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetDynamicPower", typeof (Command_SetDynamicPower));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getStatus;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_setDisable;
    private static Delegate? cb_setEnable;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetDynamicPower._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetDynamicPower._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetDynamicPower._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetDynamicPower._members.ManagedPeerType;

    protected Command_SetDynamicPower(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetDynamicPower()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetDynamicPower._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetDynamicPower._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetDynamicPower.cb_getCommandType == null)
        Command_SetDynamicPower.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetDynamicPower.n_GetCommandType));
      return Command_SetDynamicPower.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) Command_SetDynamicPower.cb_getStatus == null)
        Command_SetDynamicPower.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetDynamicPower.n_GetStatus));
      return Command_SetDynamicPower.cb_getStatus;
    }

    private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).Status;
    }

    public virtual unsafe int Status
    {
      [Register("getStatus", "()I", "GetGetStatusHandler")] get
      {
        return Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualInt32Method("getStatus.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetDynamicPower.cb_FromString_Ljava_lang_String_ == null)
        Command_SetDynamicPower.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetDynamicPower.n_FromString_Ljava_lang_String_));
      return Command_SetDynamicPower.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetDynamicPower.cb_ToString == null)
        Command_SetDynamicPower.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetDynamicPower.n_ToString));
      return Command_SetDynamicPower.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetDisableHandler()
    {
      if ((object) Command_SetDynamicPower.cb_setDisable == null)
        Command_SetDynamicPower.cb_setDisable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_SetDynamicPower.n_SetDisable));
      return Command_SetDynamicPower.cb_setDisable;
    }

    private static void n_SetDisable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).SetDisable();
    }

    [Register("setDisable", "()V", "GetSetDisableHandler")]
    public virtual unsafe void SetDisable()
    {
      Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualVoidMethod("setDisable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetEnableHandler()
    {
      if ((object) Command_SetDynamicPower.cb_setEnable == null)
        Command_SetDynamicPower.cb_setEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_SetDynamicPower.n_SetEnable));
      return Command_SetDynamicPower.cb_setEnable;
    }

    private static void n_SetEnable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_SetDynamicPower>(jnienv, native__this, (JniHandleOwnership) 0).SetEnable();
    }

    [Register("setEnable", "()V", "GetSetEnableHandler")]
    public virtual unsafe void SetEnable()
    {
      Command_SetDynamicPower._members.InstanceMethods.InvokeVirtualVoidMethod("setEnable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
