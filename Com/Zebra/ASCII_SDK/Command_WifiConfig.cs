// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_WifiConfig
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
  [Register("com/zebra/ASCII_SDK/Command_WifiConfig", DoNotGenerateAcw = true)]
  public class Command_WifiConfig : Command
  {
    [Register("commandName")]
    public const string CommandName = "wificonfig";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_WifiConfig", typeof (Command_WifiConfig));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getWifiOn;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_setwifioff;
    private static Delegate? cb_setwifion;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_WifiConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_WifiConfig._members.ManagedPeerType;

    protected Command_WifiConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_WifiConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_WifiConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_WifiConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_WifiConfig.cb_getCommandType == null)
        Command_WifiConfig.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_WifiConfig.n_GetCommandType));
      return Command_WifiConfig.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetWifiOnHandler()
    {
      if ((object) Command_WifiConfig.cb_getWifiOn == null)
        Command_WifiConfig.cb_getWifiOn = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_WifiConfig.n_GetWifiOn));
      return Command_WifiConfig.cb_getWifiOn;
    }

    private static bool n_GetWifiOn(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).WifiOn;
    }

    public virtual unsafe bool WifiOn
    {
      [Register("getWifiOn", "()Z", "GetGetWifiOnHandler")] get
      {
        return Command_WifiConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getWifiOn.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_WifiConfig.cb_FromString_Ljava_lang_String_ == null)
        Command_WifiConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_WifiConfig.n_FromString_Ljava_lang_String_));
      return Command_WifiConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_WifiConfig.cb_ToString == null)
        Command_WifiConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_WifiConfig.n_ToString));
      return Command_WifiConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetwifioffHandler()
    {
      if ((object) Command_WifiConfig.cb_setwifioff == null)
        Command_WifiConfig.cb_setwifioff = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_WifiConfig.n_Setwifioff));
      return Command_WifiConfig.cb_setwifioff;
    }

    private static void n_Setwifioff(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setwifioff();
    }

    [Register("setwifioff", "()V", "GetSetwifioffHandler")]
    public virtual unsafe void Setwifioff()
    {
      Command_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setwifioff.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetwifionHandler()
    {
      if ((object) Command_WifiConfig.cb_setwifion == null)
        Command_WifiConfig.cb_setwifion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Command_WifiConfig.n_Setwifion));
      return Command_WifiConfig.cb_setwifion;
    }

    private static void n_Setwifion(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Command_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setwifion();
    }

    [Register("setwifion", "()V", "GetSetwifionHandler")]
    public virtual unsafe void Setwifion()
    {
      Command_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setwifion.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
