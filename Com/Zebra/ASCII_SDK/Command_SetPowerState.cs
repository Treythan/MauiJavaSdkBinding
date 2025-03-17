// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetPowerState
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
  [Register("com/zebra/ASCII_SDK/Command_SetPowerState", DoNotGenerateAcw = true)]
  public class Command_SetPowerState : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetPowerState";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetPowerState", typeof (Command_SetPowerState));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getstate;
    private static Delegate? cb_setstate_I;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetPowerState._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetPowerState._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetPowerState._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetPowerState._members.ManagedPeerType;

    protected Command_SetPowerState(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetPowerState()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetPowerState._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetPowerState._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetPowerState.cb_getCommandType == null)
        Command_SetPowerState.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetPowerState.n_GetCommandType));
      return Command_SetPowerState.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetPowerState>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetPowerState._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetPowerState.cb_FromString_Ljava_lang_String_ == null)
        Command_SetPowerState.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetPowerState.n_FromString_Ljava_lang_String_));
      return Command_SetPowerState.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetPowerState>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetPowerState._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetPowerState.cb_ToString == null)
        Command_SetPowerState.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetPowerState.n_ToString));
      return Command_SetPowerState.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetPowerState>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetPowerState._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetstateHandler()
    {
      if ((object) Command_SetPowerState.cb_getstate == null)
        Command_SetPowerState.cb_getstate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetPowerState.n_Getstate));
      return Command_SetPowerState.cb_getstate;
    }

    private static int n_Getstate(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetPowerState>(jnienv, native__this, (JniHandleOwnership) 0).Getstate();
    }

    [Register("getstate", "()I", "GetGetstateHandler")]
    public virtual unsafe int Getstate()
    {
      return Command_SetPowerState._members.InstanceMethods.InvokeVirtualInt32Method("getstate.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetstate_IHandler()
    {
      if ((object) Command_SetPowerState.cb_setstate_I == null)
        Command_SetPowerState.cb_setstate_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetPowerState.n_Setstate_I));
      return Command_SetPowerState.cb_setstate_I;
    }

    private static void n_Setstate_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetPowerState>(jnienv, native__this, (JniHandleOwnership) 0).Setstate(value);
    }

    [Register("setstate", "(I)V", "GetSetstate_IHandler")]
    public virtual unsafe void Setstate(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetPowerState._members.InstanceMethods.InvokeVirtualVoidMethod("setstate.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
