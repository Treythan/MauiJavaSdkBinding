﻿// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_setuniquereport
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
  [Register("com/zebra/ASCII_SDK/Command_setuniquereport", DoNotGenerateAcw = true)]
  public class Command_setuniquereport : Command
  {
    [Register("commandName")]
    public const string CommandName = "setuniquereport";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_setuniquereport", typeof (Command_setuniquereport));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getdisable;
    private static Delegate? cb_getenable;
    private static Delegate? cb_setdisable_Z;
    private static Delegate? cb_setenable_Z;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_setuniquereport._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_setuniquereport._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_setuniquereport._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_setuniquereport._members.ManagedPeerType;

    protected Command_setuniquereport(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_setuniquereport()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_setuniquereport._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_setuniquereport._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_setuniquereport.cb_getCommandType == null)
        Command_setuniquereport.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_setuniquereport.n_GetCommandType));
      return Command_setuniquereport.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_setuniquereport._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_setuniquereport.cb_FromString_Ljava_lang_String_ == null)
        Command_setuniquereport.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_setuniquereport.n_FromString_Ljava_lang_String_));
      return Command_setuniquereport.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_setuniquereport._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_setuniquereport.cb_ToString == null)
        Command_setuniquereport.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_setuniquereport.n_ToString));
      return Command_setuniquereport.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_setuniquereport._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetdisableHandler()
    {
      if ((object) Command_setuniquereport.cb_getdisable == null)
        Command_setuniquereport.cb_getdisable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_setuniquereport.n_Getdisable));
      return Command_setuniquereport.cb_getdisable;
    }

    private static bool n_Getdisable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).Getdisable();
    }

    [Register("getdisable", "()Z", "GetGetdisableHandler")]
    public virtual unsafe bool Getdisable()
    {
      return Command_setuniquereport._members.InstanceMethods.InvokeVirtualBooleanMethod("getdisable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetenableHandler()
    {
      if ((object) Command_setuniquereport.cb_getenable == null)
        Command_setuniquereport.cb_getenable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_setuniquereport.n_Getenable));
      return Command_setuniquereport.cb_getenable;
    }

    private static bool n_Getenable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).Getenable();
    }

    [Register("getenable", "()Z", "GetGetenableHandler")]
    public virtual unsafe bool Getenable()
    {
      return Command_setuniquereport._members.InstanceMethods.InvokeVirtualBooleanMethod("getenable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetdisable_ZHandler()
    {
      if ((object) Command_setuniquereport.cb_setdisable_Z == null)
        Command_setuniquereport.cb_setdisable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_setuniquereport.n_Setdisable_Z));
      return Command_setuniquereport.cb_setdisable_Z;
    }

    private static void n_Setdisable_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).Setdisable(value);
    }

    [Register("setdisable", "(Z)V", "GetSetdisable_ZHandler")]
    public virtual unsafe void Setdisable(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_setuniquereport._members.InstanceMethods.InvokeVirtualVoidMethod("setdisable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetenable_ZHandler()
    {
      if ((object) Command_setuniquereport.cb_setenable_Z == null)
        Command_setuniquereport.cb_setenable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_setuniquereport.n_Setenable_Z));
      return Command_setuniquereport.cb_setenable_Z;
    }

    private static void n_Setenable_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_setuniquereport>(jnienv, native__this, (JniHandleOwnership) 0).Setenable(value);
    }

    [Register("setenable", "(Z)V", "GetSetenable_ZHandler")]
    public virtual unsafe void Setenable(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_setuniquereport._members.InstanceMethods.InvokeVirtualVoidMethod("setenable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
