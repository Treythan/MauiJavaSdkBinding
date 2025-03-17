// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_UpdateFirmware
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
  [Register("com/zebra/ASCII_SDK/Command_UpdateFirmware", DoNotGenerateAcw = true)]
  public class Command_UpdateFirmware : Command
  {
    [Register("commandName")]
    public const string CommandName = "UpdateFirmware";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_UpdateFirmware", typeof (Command_UpdateFirmware));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getradio;
    private static Delegate? cb_getstm32;
    private static Delegate? cb_setradio_Z;
    private static Delegate? cb_setstm32_Z;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_UpdateFirmware._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_UpdateFirmware._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_UpdateFirmware._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_UpdateFirmware._members.ManagedPeerType;

    protected Command_UpdateFirmware(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_UpdateFirmware()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_UpdateFirmware._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_UpdateFirmware._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_UpdateFirmware.cb_getCommandType == null)
        Command_UpdateFirmware.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_UpdateFirmware.n_GetCommandType));
      return Command_UpdateFirmware.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_UpdateFirmware.cb_FromString_Ljava_lang_String_ == null)
        Command_UpdateFirmware.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_UpdateFirmware.n_FromString_Ljava_lang_String_));
      return Command_UpdateFirmware.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_UpdateFirmware.cb_ToString == null)
        Command_UpdateFirmware.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_UpdateFirmware.n_ToString));
      return Command_UpdateFirmware.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetradioHandler()
    {
      if ((object) Command_UpdateFirmware.cb_getradio == null)
        Command_UpdateFirmware.cb_getradio = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_UpdateFirmware.n_Getradio));
      return Command_UpdateFirmware.cb_getradio;
    }

    private static bool n_Getradio(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).Getradio();
    }

    [Register("getradio", "()Z", "GetGetradioHandler")]
    public virtual unsafe bool Getradio()
    {
      return Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualBooleanMethod("getradio.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetstm32Handler()
    {
      if ((object) Command_UpdateFirmware.cb_getstm32 == null)
        Command_UpdateFirmware.cb_getstm32 = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_UpdateFirmware.n_Getstm32));
      return Command_UpdateFirmware.cb_getstm32;
    }

    private static bool n_Getstm32(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).Getstm32();
    }

    [Register("getstm32", "()Z", "GetGetstm32Handler")]
    public virtual unsafe bool Getstm32()
    {
      return Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualBooleanMethod("getstm32.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetradio_ZHandler()
    {
      if ((object) Command_UpdateFirmware.cb_setradio_Z == null)
        Command_UpdateFirmware.cb_setradio_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_UpdateFirmware.n_Setradio_Z));
      return Command_UpdateFirmware.cb_setradio_Z;
    }

    private static void n_Setradio_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).Setradio(value);
    }

    [Register("setradio", "(Z)V", "GetSetradio_ZHandler")]
    public virtual unsafe void Setradio(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualVoidMethod("setradio.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetstm32_ZHandler()
    {
      if ((object) Command_UpdateFirmware.cb_setstm32_Z == null)
        Command_UpdateFirmware.cb_setstm32_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_UpdateFirmware.n_Setstm32_Z));
      return Command_UpdateFirmware.cb_setstm32_Z;
    }

    private static void n_Setstm32_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_UpdateFirmware>(jnienv, native__this, (JniHandleOwnership) 0).Setstm32(value);
    }

    [Register("setstm32", "(Z)V", "GetSetstm32_ZHandler")]
    public virtual unsafe void Setstm32(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_UpdateFirmware._members.InstanceMethods.InvokeVirtualVoidMethod("setstm32.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
