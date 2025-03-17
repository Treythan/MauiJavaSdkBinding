// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Connect
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
  [Register("com/zebra/ASCII_SDK/Command_Connect", DoNotGenerateAcw = true)]
  public class Command_Connect : Command
  {
    [Register("commandName")]
    public const string CommandName = "Connect";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Connect", typeof (Command_Connect));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getdisableLowPower;
    private static Delegate? cb_getoverride;
    private static Delegate? cb_getpassword;
    private static Delegate? cb_setdisableLowPower_Z;
    private static Delegate? cb_setoverride_Z;
    private static Delegate? cb_setpassword_Ljava_lang_String_;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_Connect._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Connect._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Connect._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Connect._members.ManagedPeerType;

    protected Command_Connect(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Connect()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Connect._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Connect._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Connect.cb_getCommandType == null)
        Command_Connect.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Connect.n_GetCommandType));
      return Command_Connect.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Connect._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Connect.cb_FromString_Ljava_lang_String_ == null)
        Command_Connect.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Connect.n_FromString_Ljava_lang_String_));
      return Command_Connect.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Connect._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Connect.cb_ToString == null)
        Command_Connect.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Connect.n_ToString));
      return Command_Connect.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Connect._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetdisableLowPowerHandler()
    {
      if ((object) Command_Connect.cb_getdisableLowPower == null)
        Command_Connect.cb_getdisableLowPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_Connect.n_GetdisableLowPower));
      return Command_Connect.cb_getdisableLowPower;
    }

    private static bool n_GetdisableLowPower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).GetdisableLowPower();
    }

    [Register("getdisableLowPower", "()Z", "GetGetdisableLowPowerHandler")]
    public virtual unsafe bool GetdisableLowPower()
    {
      return Command_Connect._members.InstanceMethods.InvokeVirtualBooleanMethod("getdisableLowPower.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetoverrideHandler()
    {
      if ((object) Command_Connect.cb_getoverride == null)
        Command_Connect.cb_getoverride = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_Connect.n_Getoverride));
      return Command_Connect.cb_getoverride;
    }

    private static bool n_Getoverride(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).Getoverride();
    }

    [Register("getoverride", "()Z", "GetGetoverrideHandler")]
    public virtual unsafe bool Getoverride()
    {
      return Command_Connect._members.InstanceMethods.InvokeVirtualBooleanMethod("getoverride.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetpasswordHandler()
    {
      if ((object) Command_Connect.cb_getpassword == null)
        Command_Connect.cb_getpassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Connect.n_Getpassword));
      return Command_Connect.cb_getpassword;
    }

    private static IntPtr n_Getpassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).Getpassword());
    }

    [Register("getpassword", "()Ljava/lang/String;", "GetGetpasswordHandler")]
    public virtual unsafe string? Getpassword()
    {
      JniObjectReference jniObjectReference = Command_Connect._members.InstanceMethods.InvokeVirtualObjectMethod("getpassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetdisableLowPower_ZHandler()
    {
      if ((object) Command_Connect.cb_setdisableLowPower_Z == null)
        Command_Connect.cb_setdisableLowPower_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_Connect.n_SetdisableLowPower_Z));
      return Command_Connect.cb_setdisableLowPower_Z;
    }

    private static void n_SetdisableLowPower_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).SetdisableLowPower(value);
    }

    [Register("setdisableLowPower", "(Z)V", "GetSetdisableLowPower_ZHandler")]
    public virtual unsafe void SetdisableLowPower(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_Connect._members.InstanceMethods.InvokeVirtualVoidMethod("setdisableLowPower.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetoverride_ZHandler()
    {
      if ((object) Command_Connect.cb_setoverride_Z == null)
        Command_Connect.cb_setoverride_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_Connect.n_Setoverride_Z));
      return Command_Connect.cb_setoverride_Z;
    }

    private static void n_Setoverride_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).Setoverride(value);
    }

    [Register("setoverride", "(Z)V", "GetSetoverride_ZHandler")]
    public virtual unsafe void Setoverride(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_Connect._members.InstanceMethods.InvokeVirtualVoidMethod("setoverride.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetpassword_Ljava_lang_String_Handler()
    {
      if ((object) Command_Connect.cb_setpassword_Ljava_lang_String_ == null)
        Command_Connect.cb_setpassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Connect.n_Setpassword_Ljava_lang_String_));
      return Command_Connect.cb_setpassword_Ljava_lang_String_;
    }

    private static void n_Setpassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Connect>(jnienv, native__this, (JniHandleOwnership) 0).Setpassword(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpassword", "(Ljava/lang/String;)V", "GetSetpassword_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpassword(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_Connect._members.InstanceMethods.InvokeVirtualVoidMethod("setpassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
