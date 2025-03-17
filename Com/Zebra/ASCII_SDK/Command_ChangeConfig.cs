// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_ChangeConfig
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
  [Register("com/zebra/ASCII_SDK/Command_ChangeConfig", DoNotGenerateAcw = true)]
  public class Command_ChangeConfig : Command
  {
    [Register("commandName")]
    public const string CommandName = "ChangeConfig";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_ChangeConfig", typeof (Command_ChangeConfig));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getMode;
    private static Delegate? cb_setMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_ChangeConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_ChangeConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_ChangeConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_ChangeConfig._members.ManagedPeerType;

    protected Command_ChangeConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_ChangeConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_ChangeConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_ChangeConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_ChangeConfig.cb_getCommandType == null)
        Command_ChangeConfig.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ChangeConfig.n_GetCommandType));
      return Command_ChangeConfig.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_ChangeConfig>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_ChangeConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetModeHandler()
    {
      if ((object) Command_ChangeConfig.cb_getMode == null)
        Command_ChangeConfig.cb_getMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ChangeConfig.n_GetMode));
      return Command_ChangeConfig.cb_getMode;
    }

    private static IntPtr n_GetMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_ChangeConfig>(jnienv, native__this, (JniHandleOwnership) 0).Mode);
    }

    private static Delegate GetSetMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_Handler()
    {
      if ((object) Command_ChangeConfig.cb_setMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_ == null)
        Command_ChangeConfig.cb_setMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_ChangeConfig.n_SetMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_));
      return Command_ChangeConfig.cb_setMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_;
    }

    private static void n_SetMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_ChangeConfig>(jnienv, native__this, (JniHandleOwnership) 0).Mode = Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_CHANGE_CONFIG_MODE? Mode
    {
      [Register("getMode", "()Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", "GetGetModeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_ChangeConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getMode.()Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_CHANGE_CONFIG_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMode", "(Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;)V", "GetSetMode_Lcom_zebra_ASCII_SDK_ENUM_CHANGE_CONFIG_MODE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_ChangeConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setMode.(Lcom/zebra/ASCII_SDK/ENUM_CHANGE_CONFIG_MODE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_ChangeConfig.cb_FromString_Ljava_lang_String_ == null)
        Command_ChangeConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_ChangeConfig.n_FromString_Ljava_lang_String_));
      return Command_ChangeConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_ChangeConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_ChangeConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_ChangeConfig.cb_ToString == null)
        Command_ChangeConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ChangeConfig.n_ToString));
      return Command_ChangeConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_ChangeConfig>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_ChangeConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
