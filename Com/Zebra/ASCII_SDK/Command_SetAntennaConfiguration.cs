// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetAntennaConfiguration
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
  [Register("com/zebra/ASCII_SDK/Command_SetAntennaConfiguration", DoNotGenerateAcw = true)]
  public class Command_SetAntennaConfiguration : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetAntennaConfiguration";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetAntennaConfiguration", typeof (Command_SetAntennaConfiguration));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getDoSelect;
    private static Delegate? cb_setDoSelect_Z;
    private static Delegate? cb_getLinkProfileIndex;
    private static Delegate? cb_setLinkProfileIndex_S;
    private static Delegate? cb_getNoSelect;
    private static Delegate? cb_setNoSelect_Z;
    private static Delegate? cb_getPower;
    private static Delegate? cb_setPower_S;
    private static Delegate? cb_getTari;
    private static Delegate? cb_setTari_I;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetAntennaConfiguration._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetAntennaConfiguration._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetAntennaConfiguration._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType
    {
      get => Command_SetAntennaConfiguration._members.ManagedPeerType;
    }

    protected Command_SetAntennaConfiguration(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetAntennaConfiguration()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetAntennaConfiguration._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetAntennaConfiguration._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getCommandType == null)
        Command_SetAntennaConfiguration.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAntennaConfiguration.n_GetCommandType));
      return Command_SetAntennaConfiguration.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDoSelectHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getDoSelect == null)
        Command_SetAntennaConfiguration.cb_getDoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetAntennaConfiguration.n_GetDoSelect));
      return Command_SetAntennaConfiguration.cb_getDoSelect;
    }

    private static bool n_GetDoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect;
    }

    private static Delegate GetSetDoSelect_ZHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_setDoSelect_Z == null)
        Command_SetAntennaConfiguration.cb_setDoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetAntennaConfiguration.n_SetDoSelect_Z));
      return Command_SetAntennaConfiguration.cb_setDoSelect_Z;
    }

    private static void n_SetDoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect = value;
    }

    public virtual unsafe bool DoSelect
    {
      [Register("getDoSelect", "()Z", "GetGetDoSelectHandler")] get
      {
        return Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoSelect", "(Z)V", "GetSetDoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setDoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetLinkProfileIndexHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getLinkProfileIndex == null)
        Command_SetAntennaConfiguration.cb_getLinkProfileIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_SetAntennaConfiguration.n_GetLinkProfileIndex));
      return Command_SetAntennaConfiguration.cb_getLinkProfileIndex;
    }

    private static short n_GetLinkProfileIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).LinkProfileIndex;
    }

    private static Delegate GetSetLinkProfileIndex_SHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_setLinkProfileIndex_S == null)
        Command_SetAntennaConfiguration.cb_setLinkProfileIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_SetAntennaConfiguration.n_SetLinkProfileIndex_S));
      return Command_SetAntennaConfiguration.cb_setLinkProfileIndex_S;
    }

    private static void n_SetLinkProfileIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).LinkProfileIndex = value;
    }

    public virtual unsafe short LinkProfileIndex
    {
      [Register("getLinkProfileIndex", "()S", "GetGetLinkProfileIndexHandler")] get
      {
        return Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualInt16Method("getLinkProfileIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLinkProfileIndex", "(S)V", "GetSetLinkProfileIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setLinkProfileIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoSelectHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getNoSelect == null)
        Command_SetAntennaConfiguration.cb_getNoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetAntennaConfiguration.n_GetNoSelect));
      return Command_SetAntennaConfiguration.cb_getNoSelect;
    }

    private static bool n_GetNoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect;
    }

    private static Delegate GetSetNoSelect_ZHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_setNoSelect_Z == null)
        Command_SetAntennaConfiguration.cb_setNoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetAntennaConfiguration.n_SetNoSelect_Z));
      return Command_SetAntennaConfiguration.cb_setNoSelect_Z;
    }

    private static void n_SetNoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect = value;
    }

    public virtual unsafe bool NoSelect
    {
      [Register("getNoSelect", "()Z", "GetGetNoSelectHandler")] get
      {
        return Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoSelect", "(Z)V", "GetSetNoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setNoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getPower == null)
        Command_SetAntennaConfiguration.cb_getPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_SetAntennaConfiguration.n_GetPower));
      return Command_SetAntennaConfiguration.cb_getPower;
    }

    private static short n_GetPower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Power;
    }

    private static Delegate GetSetPower_SHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_setPower_S == null)
        Command_SetAntennaConfiguration.cb_setPower_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_SetAntennaConfiguration.n_SetPower_S));
      return Command_SetAntennaConfiguration.cb_setPower_S;
    }

    private static void n_SetPower_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Power = value;
    }

    public virtual unsafe short Power
    {
      [Register("getPower", "()S", "GetGetPowerHandler")] get
      {
        return Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualInt16Method("getPower.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPower", "(S)V", "GetSetPower_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setPower.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTariHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_getTari == null)
        Command_SetAntennaConfiguration.cb_getTari = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetAntennaConfiguration.n_GetTari));
      return Command_SetAntennaConfiguration.cb_getTari;
    }

    private static int n_GetTari(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Tari;
    }

    private static Delegate GetSetTari_IHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_setTari_I == null)
        Command_SetAntennaConfiguration.cb_setTari_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetAntennaConfiguration.n_SetTari_I));
      return Command_SetAntennaConfiguration.cb_setTari_I;
    }

    private static void n_SetTari_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Tari = value;
    }

    public virtual unsafe int Tari
    {
      [Register("getTari", "()I", "GetGetTariHandler")] get
      {
        return Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualInt32Method("getTari.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTari", "(I)V", "GetSetTari_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setTari.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_FromString_Ljava_lang_String_ == null)
        Command_SetAntennaConfiguration.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetAntennaConfiguration.n_FromString_Ljava_lang_String_));
      return Command_SetAntennaConfiguration.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetAntennaConfiguration.cb_ToString == null)
        Command_SetAntennaConfiguration.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAntennaConfiguration.n_ToString));
      return Command_SetAntennaConfiguration.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetAntennaConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetAntennaConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
