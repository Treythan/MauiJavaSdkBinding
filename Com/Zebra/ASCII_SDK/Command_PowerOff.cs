// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_PowerOff
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
  [Register("com/zebra/ASCII_SDK/Command_PowerOff", DoNotGenerateAcw = true)]
  public class Command_PowerOff : Command
  {
    [Register("commandName")]
    public const string CommandName = "PowerOff";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_PowerOff", typeof (Command_PowerOff));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getRadio;
    private static Delegate? cb_setRadio_Z;
    private static Delegate? cb_getSled;
    private static Delegate? cb_setSled_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_PowerOff._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_PowerOff._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_PowerOff._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_PowerOff._members.ManagedPeerType;

    protected Command_PowerOff(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_PowerOff()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_PowerOff._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_PowerOff._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_PowerOff.cb_getCommandType == null)
        Command_PowerOff.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_PowerOff.n_GetCommandType));
      return Command_PowerOff.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_PowerOff._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRadioHandler()
    {
      if ((object) Command_PowerOff.cb_getRadio == null)
        Command_PowerOff.cb_getRadio = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_PowerOff.n_GetRadio));
      return Command_PowerOff.cb_getRadio;
    }

    private static bool n_GetRadio(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).Radio;
    }

    private static Delegate GetSetRadio_ZHandler()
    {
      if ((object) Command_PowerOff.cb_setRadio_Z == null)
        Command_PowerOff.cb_setRadio_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_PowerOff.n_SetRadio_Z));
      return Command_PowerOff.cb_setRadio_Z;
    }

    private static void n_SetRadio_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).Radio = value;
    }

    public virtual unsafe bool Radio
    {
      [Register("getRadio", "()Z", "GetGetRadioHandler")] get
      {
        return Command_PowerOff._members.InstanceMethods.InvokeVirtualBooleanMethod("getRadio.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRadio", "(Z)V", "GetSetRadio_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_PowerOff._members.InstanceMethods.InvokeVirtualVoidMethod("setRadio.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetSledHandler()
    {
      if ((object) Command_PowerOff.cb_getSled == null)
        Command_PowerOff.cb_getSled = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_PowerOff.n_GetSled));
      return Command_PowerOff.cb_getSled;
    }

    private static bool n_GetSled(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).Sled;
    }

    private static Delegate GetSetSled_ZHandler()
    {
      if ((object) Command_PowerOff.cb_setSled_Z == null)
        Command_PowerOff.cb_setSled_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_PowerOff.n_SetSled_Z));
      return Command_PowerOff.cb_setSled_Z;
    }

    private static void n_SetSled_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).Sled = value;
    }

    public virtual unsafe bool Sled
    {
      [Register("getSled", "()Z", "GetGetSledHandler")] get
      {
        return Command_PowerOff._members.InstanceMethods.InvokeVirtualBooleanMethod("getSled.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setSled", "(Z)V", "GetSetSled_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_PowerOff._members.InstanceMethods.InvokeVirtualVoidMethod("setSled.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_PowerOff.cb_FromString_Ljava_lang_String_ == null)
        Command_PowerOff.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_PowerOff.n_FromString_Ljava_lang_String_));
      return Command_PowerOff.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_PowerOff._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_PowerOff.cb_ToString == null)
        Command_PowerOff.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_PowerOff.n_ToString));
      return Command_PowerOff.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_PowerOff>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_PowerOff._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
