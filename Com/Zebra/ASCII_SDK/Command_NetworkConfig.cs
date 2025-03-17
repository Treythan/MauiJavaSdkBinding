// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_NetworkConfig
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
  [Register("com/zebra/ASCII_SDK/Command_NetworkConfig", DoNotGenerateAcw = true)]
  public class Command_NetworkConfig : Command
  {
    [Register("commandName")]
    public const string CommandName = "network";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_NetworkConfig", typeof (Command_NetworkConfig));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getStatus;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getdns;
    private static Delegate? cb_getgateway;
    private static Delegate? cb_getipaddress;
    private static Delegate? cb_getnetmask;
    private static Delegate? cb_getnoexec;
    private static Delegate? cb_setdns_Ljava_lang_String_;
    private static Delegate? cb_setgateway_Ljava_lang_String_;
    private static Delegate? cb_setipaddress_Ljava_lang_String_;
    private static Delegate? cb_setnetmask_Ljava_lang_String_;
    private static Delegate? cb_setnoexec_Z;
    private static Delegate? cb_setstatus_Z;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_NetworkConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_NetworkConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_NetworkConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_NetworkConfig._members.ManagedPeerType;

    protected Command_NetworkConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_NetworkConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_NetworkConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_NetworkConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_NetworkConfig.cb_getCommandType == null)
        Command_NetworkConfig.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_GetCommandType));
      return Command_NetworkConfig.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) Command_NetworkConfig.cb_getStatus == null)
        Command_NetworkConfig.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_NetworkConfig.n_GetStatus));
      return Command_NetworkConfig.cb_getStatus;
    }

    private static bool n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Status;
    }

    public virtual unsafe bool Status
    {
      [Register("getStatus", "()Z", "GetGetStatusHandler")] get
      {
        return Command_NetworkConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_NetworkConfig.cb_FromString_Ljava_lang_String_ == null)
        Command_NetworkConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_NetworkConfig.n_FromString_Ljava_lang_String_));
      return Command_NetworkConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_NetworkConfig.cb_ToString == null)
        Command_NetworkConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_ToString));
      return Command_NetworkConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetdnsHandler()
    {
      if ((object) Command_NetworkConfig.cb_getdns == null)
        Command_NetworkConfig.cb_getdns = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_Getdns));
      return Command_NetworkConfig.cb_getdns;
    }

    private static IntPtr n_Getdns(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getdns());
    }

    [Register("getdns", "()Ljava/lang/String;", "GetGetdnsHandler")]
    public virtual unsafe string? Getdns()
    {
      JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getdns.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetgatewayHandler()
    {
      if ((object) Command_NetworkConfig.cb_getgateway == null)
        Command_NetworkConfig.cb_getgateway = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_Getgateway));
      return Command_NetworkConfig.cb_getgateway;
    }

    private static IntPtr n_Getgateway(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getgateway());
    }

    [Register("getgateway", "()Ljava/lang/String;", "GetGetgatewayHandler")]
    public virtual unsafe string? Getgateway()
    {
      JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getgateway.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetipaddressHandler()
    {
      if ((object) Command_NetworkConfig.cb_getipaddress == null)
        Command_NetworkConfig.cb_getipaddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_Getipaddress));
      return Command_NetworkConfig.cb_getipaddress;
    }

    private static IntPtr n_Getipaddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getipaddress());
    }

    [Register("getipaddress", "()Ljava/lang/String;", "GetGetipaddressHandler")]
    public virtual unsafe string? Getipaddress()
    {
      JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getipaddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetnetmaskHandler()
    {
      if ((object) Command_NetworkConfig.cb_getnetmask == null)
        Command_NetworkConfig.cb_getnetmask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_NetworkConfig.n_Getnetmask));
      return Command_NetworkConfig.cb_getnetmask;
    }

    private static IntPtr n_Getnetmask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getnetmask());
    }

    [Register("getnetmask", "()Ljava/lang/String;", "GetGetnetmaskHandler")]
    public virtual unsafe string? Getnetmask()
    {
      JniObjectReference jniObjectReference = Command_NetworkConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getnetmask.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetnoexecHandler()
    {
      if ((object) Command_NetworkConfig.cb_getnoexec == null)
        Command_NetworkConfig.cb_getnoexec = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_NetworkConfig.n_Getnoexec));
      return Command_NetworkConfig.cb_getnoexec;
    }

    private static bool n_Getnoexec(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getnoexec();
    }

    [Register("getnoexec", "()Z", "GetGetnoexecHandler")]
    public virtual unsafe bool Getnoexec()
    {
      return Command_NetworkConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getnoexec.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetdns_Ljava_lang_String_Handler()
    {
      if ((object) Command_NetworkConfig.cb_setdns_Ljava_lang_String_ == null)
        Command_NetworkConfig.cb_setdns_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_NetworkConfig.n_Setdns_Ljava_lang_String_));
      return Command_NetworkConfig.cb_setdns_Ljava_lang_String_;
    }

    private static void n_Setdns_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setdns(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setdns", "(Ljava/lang/String;)V", "GetSetdns_Ljava_lang_String_Handler")]
    public virtual unsafe void Setdns(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setdns.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetgateway_Ljava_lang_String_Handler()
    {
      if ((object) Command_NetworkConfig.cb_setgateway_Ljava_lang_String_ == null)
        Command_NetworkConfig.cb_setgateway_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_NetworkConfig.n_Setgateway_Ljava_lang_String_));
      return Command_NetworkConfig.cb_setgateway_Ljava_lang_String_;
    }

    private static void n_Setgateway_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setgateway(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setgateway", "(Ljava/lang/String;)V", "GetSetgateway_Ljava_lang_String_Handler")]
    public virtual unsafe void Setgateway(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setgateway.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetipaddress_Ljava_lang_String_Handler()
    {
      if ((object) Command_NetworkConfig.cb_setipaddress_Ljava_lang_String_ == null)
        Command_NetworkConfig.cb_setipaddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_NetworkConfig.n_Setipaddress_Ljava_lang_String_));
      return Command_NetworkConfig.cb_setipaddress_Ljava_lang_String_;
    }

    private static void n_Setipaddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setipaddress(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setipaddress", "(Ljava/lang/String;)V", "GetSetipaddress_Ljava_lang_String_Handler")]
    public virtual unsafe void Setipaddress(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setipaddress.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetnetmask_Ljava_lang_String_Handler()
    {
      if ((object) Command_NetworkConfig.cb_setnetmask_Ljava_lang_String_ == null)
        Command_NetworkConfig.cb_setnetmask_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_NetworkConfig.n_Setnetmask_Ljava_lang_String_));
      return Command_NetworkConfig.cb_setnetmask_Ljava_lang_String_;
    }

    private static void n_Setnetmask_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setnetmask(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setnetmask", "(Ljava/lang/String;)V", "GetSetnetmask_Ljava_lang_String_Handler")]
    public virtual unsafe void Setnetmask(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setnetmask.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetnoexec_ZHandler()
    {
      if ((object) Command_NetworkConfig.cb_setnoexec_Z == null)
        Command_NetworkConfig.cb_setnoexec_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_NetworkConfig.n_Setnoexec_Z));
      return Command_NetworkConfig.cb_setnoexec_Z;
    }

    private static void n_Setnoexec_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setnoexec(value);
    }

    [Register("setnoexec", "(Z)V", "GetSetnoexec_ZHandler")]
    public virtual unsafe void Setnoexec(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setnoexec.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetstatus_ZHandler()
    {
      if ((object) Command_NetworkConfig.cb_setstatus_Z == null)
        Command_NetworkConfig.cb_setstatus_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_NetworkConfig.n_Setstatus_Z));
      return Command_NetworkConfig.cb_setstatus_Z;
    }

    private static void n_Setstatus_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_NetworkConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setstatus(value);
    }

    [Register("setstatus", "(Z)V", "GetSetstatus_ZHandler")]
    public virtual unsafe void Setstatus(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_NetworkConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setstatus.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
