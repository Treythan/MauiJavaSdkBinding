// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetRegulatory
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
  [Register("com/zebra/ASCII_SDK/Command_SetRegulatory", DoNotGenerateAcw = true)]
  public class Command_SetRegulatory : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetRegulatory";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetRegulatory", typeof (Command_SetRegulatory));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getenabledchannels;
    private static Delegate? cb_gethoppingoff;
    private static Delegate? cb_gethoppingon;
    private static Delegate? cb_getregion;
    private static Delegate? cb_setenabledchannels_Ljava_lang_String_;
    private static Delegate? cb_sethoppingoff_Z;
    private static Delegate? cb_sethoppingon_Z;
    private static Delegate? cb_setregion_Ljava_lang_String_;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetRegulatory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetRegulatory._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetRegulatory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetRegulatory._members.ManagedPeerType;

    protected Command_SetRegulatory(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetRegulatory()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetRegulatory._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetRegulatory._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetRegulatory.cb_getCommandType == null)
        Command_SetRegulatory.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetRegulatory.n_GetCommandType));
      return Command_SetRegulatory.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetRegulatory._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetRegulatory.cb_FromString_Ljava_lang_String_ == null)
        Command_SetRegulatory.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetRegulatory.n_FromString_Ljava_lang_String_));
      return Command_SetRegulatory.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetRegulatory._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetRegulatory.cb_ToString == null)
        Command_SetRegulatory.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetRegulatory.n_ToString));
      return Command_SetRegulatory.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetRegulatory._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetenabledchannelsHandler()
    {
      if ((object) Command_SetRegulatory.cb_getenabledchannels == null)
        Command_SetRegulatory.cb_getenabledchannels = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetRegulatory.n_Getenabledchannels));
      return Command_SetRegulatory.cb_getenabledchannels;
    }

    private static IntPtr n_Getenabledchannels(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Getenabledchannels());
    }

    [Register("getenabledchannels", "()Ljava/lang/String;", "GetGetenabledchannelsHandler")]
    public virtual unsafe string? Getenabledchannels()
    {
      JniObjectReference jniObjectReference = Command_SetRegulatory._members.InstanceMethods.InvokeVirtualObjectMethod("getenabledchannels.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGethoppingoffHandler()
    {
      if ((object) Command_SetRegulatory.cb_gethoppingoff == null)
        Command_SetRegulatory.cb_gethoppingoff = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetRegulatory.n_Gethoppingoff));
      return Command_SetRegulatory.cb_gethoppingoff;
    }

    private static bool n_Gethoppingoff(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Gethoppingoff();
    }

    [Register("gethoppingoff", "()Z", "GetGethoppingoffHandler")]
    public virtual unsafe bool Gethoppingoff()
    {
      return Command_SetRegulatory._members.InstanceMethods.InvokeVirtualBooleanMethod("gethoppingoff.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGethoppingonHandler()
    {
      if ((object) Command_SetRegulatory.cb_gethoppingon == null)
        Command_SetRegulatory.cb_gethoppingon = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetRegulatory.n_Gethoppingon));
      return Command_SetRegulatory.cb_gethoppingon;
    }

    private static bool n_Gethoppingon(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Gethoppingon();
    }

    [Register("gethoppingon", "()Z", "GetGethoppingonHandler")]
    public virtual unsafe bool Gethoppingon()
    {
      return Command_SetRegulatory._members.InstanceMethods.InvokeVirtualBooleanMethod("gethoppingon.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetregionHandler()
    {
      if ((object) Command_SetRegulatory.cb_getregion == null)
        Command_SetRegulatory.cb_getregion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetRegulatory.n_Getregion));
      return Command_SetRegulatory.cb_getregion;
    }

    private static IntPtr n_Getregion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Getregion());
    }

    [Register("getregion", "()Ljava/lang/String;", "GetGetregionHandler")]
    public virtual unsafe string? Getregion()
    {
      JniObjectReference jniObjectReference = Command_SetRegulatory._members.InstanceMethods.InvokeVirtualObjectMethod("getregion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetenabledchannels_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetRegulatory.cb_setenabledchannels_Ljava_lang_String_ == null)
        Command_SetRegulatory.cb_setenabledchannels_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetRegulatory.n_Setenabledchannels_Ljava_lang_String_));
      return Command_SetRegulatory.cb_setenabledchannels_Ljava_lang_String_;
    }

    private static void n_Setenabledchannels_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Setenabledchannels(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setenabledchannels", "(Ljava/lang/String;)V", "GetSetenabledchannels_Ljava_lang_String_Handler")]
    public virtual unsafe void Setenabledchannels(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_SetRegulatory._members.InstanceMethods.InvokeVirtualVoidMethod("setenabledchannels.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSethoppingoff_ZHandler()
    {
      if ((object) Command_SetRegulatory.cb_sethoppingoff_Z == null)
        Command_SetRegulatory.cb_sethoppingoff_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetRegulatory.n_Sethoppingoff_Z));
      return Command_SetRegulatory.cb_sethoppingoff_Z;
    }

    private static void n_Sethoppingoff_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Sethoppingoff(value);
    }

    [Register("sethoppingoff", "(Z)V", "GetSethoppingoff_ZHandler")]
    public virtual unsafe void Sethoppingoff(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetRegulatory._members.InstanceMethods.InvokeVirtualVoidMethod("sethoppingoff.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSethoppingon_ZHandler()
    {
      if ((object) Command_SetRegulatory.cb_sethoppingon_Z == null)
        Command_SetRegulatory.cb_sethoppingon_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetRegulatory.n_Sethoppingon_Z));
      return Command_SetRegulatory.cb_sethoppingon_Z;
    }

    private static void n_Sethoppingon_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Sethoppingon(value);
    }

    [Register("sethoppingon", "(Z)V", "GetSethoppingon_ZHandler")]
    public virtual unsafe void Sethoppingon(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetRegulatory._members.InstanceMethods.InvokeVirtualVoidMethod("sethoppingon.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetregion_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetRegulatory.cb_setregion_Ljava_lang_String_ == null)
        Command_SetRegulatory.cb_setregion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetRegulatory.n_Setregion_Ljava_lang_String_));
      return Command_SetRegulatory.cb_setregion_Ljava_lang_String_;
    }

    private static void n_Setregion_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetRegulatory>(jnienv, native__this, (JniHandleOwnership) 0).Setregion(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setregion", "(Ljava/lang/String;)V", "GetSetregion_Ljava_lang_String_Handler")]
    public virtual unsafe void Setregion(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_SetRegulatory._members.InstanceMethods.InvokeVirtualVoidMethod("setregion.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
