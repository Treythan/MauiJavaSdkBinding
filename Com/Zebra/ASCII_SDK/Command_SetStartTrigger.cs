// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetStartTrigger
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
  [Register("com/zebra/ASCII_SDK/Command_SetStartTrigger", DoNotGenerateAcw = true)]
  public class Command_SetStartTrigger : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetStartTrigger";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetStartTrigger", typeof (Command_SetStartTrigger));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getIgnoreHandHeldTrigger;
    private static Delegate? cb_setIgnoreHandHeldTrigger_Z;
    private static Delegate? cb_getNoRepeat;
    private static Delegate? cb_setNoRepeat_Z;
    private static Delegate? cb_getRepeat;
    private static Delegate? cb_setRepeat_Z;
    private static Delegate? cb_getStartDelay;
    private static Delegate? cb_setStartDelay_J;
    private static Delegate? cb_getStartOnHandHeldTrigger;
    private static Delegate? cb_setStartOnHandHeldTrigger_Z;
    private static Delegate? cb_getTriggerType;
    private static Delegate? cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetStartTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetStartTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetStartTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetStartTrigger._members.ManagedPeerType;

    protected Command_SetStartTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetStartTrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetStartTrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetStartTrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getCommandType == null)
        Command_SetStartTrigger.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStartTrigger.n_GetCommandType));
      return Command_SetStartTrigger.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetIgnoreHandHeldTriggerHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getIgnoreHandHeldTrigger == null)
        Command_SetStartTrigger.cb_getIgnoreHandHeldTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStartTrigger.n_GetIgnoreHandHeldTrigger));
      return Command_SetStartTrigger.cb_getIgnoreHandHeldTrigger;
    }

    private static bool n_GetIgnoreHandHeldTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).IgnoreHandHeldTrigger;
    }

    private static Delegate GetSetIgnoreHandHeldTrigger_ZHandler()
    {
      if ((object) Command_SetStartTrigger.cb_setIgnoreHandHeldTrigger_Z == null)
        Command_SetStartTrigger.cb_setIgnoreHandHeldTrigger_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStartTrigger.n_SetIgnoreHandHeldTrigger_Z));
      return Command_SetStartTrigger.cb_setIgnoreHandHeldTrigger_Z;
    }

    private static void n_SetIgnoreHandHeldTrigger_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).IgnoreHandHeldTrigger = value;
    }

    public virtual unsafe bool IgnoreHandHeldTrigger
    {
      [Register("getIgnoreHandHeldTrigger", "()Z", "GetGetIgnoreHandHeldTriggerHandler")] get
      {
        return Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getIgnoreHandHeldTrigger.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIgnoreHandHeldTrigger", "(Z)V", "GetSetIgnoreHandHeldTrigger_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setIgnoreHandHeldTrigger.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoRepeatHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getNoRepeat == null)
        Command_SetStartTrigger.cb_getNoRepeat = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStartTrigger.n_GetNoRepeat));
      return Command_SetStartTrigger.cb_getNoRepeat;
    }

    private static bool n_GetNoRepeat(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).NoRepeat;
    }

    private static Delegate GetSetNoRepeat_ZHandler()
    {
      if ((object) Command_SetStartTrigger.cb_setNoRepeat_Z == null)
        Command_SetStartTrigger.cb_setNoRepeat_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStartTrigger.n_SetNoRepeat_Z));
      return Command_SetStartTrigger.cb_setNoRepeat_Z;
    }

    private static void n_SetNoRepeat_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).NoRepeat = value;
    }

    public virtual unsafe bool NoRepeat
    {
      [Register("getNoRepeat", "()Z", "GetGetNoRepeatHandler")] get
      {
        return Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoRepeat.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoRepeat", "(Z)V", "GetSetNoRepeat_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setNoRepeat.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetRepeatHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getRepeat == null)
        Command_SetStartTrigger.cb_getRepeat = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStartTrigger.n_GetRepeat));
      return Command_SetStartTrigger.cb_getRepeat;
    }

    private static bool n_GetRepeat(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).Repeat;
    }

    private static Delegate GetSetRepeat_ZHandler()
    {
      if ((object) Command_SetStartTrigger.cb_setRepeat_Z == null)
        Command_SetStartTrigger.cb_setRepeat_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStartTrigger.n_SetRepeat_Z));
      return Command_SetStartTrigger.cb_setRepeat_Z;
    }

    private static void n_SetRepeat_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).Repeat = value;
    }

    public virtual unsafe bool Repeat
    {
      [Register("getRepeat", "()Z", "GetGetRepeatHandler")] get
      {
        return Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getRepeat.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRepeat", "(Z)V", "GetSetRepeat_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setRepeat.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStartDelayHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getStartDelay == null)
        Command_SetStartTrigger.cb_getStartDelay = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_SetStartTrigger.n_GetStartDelay));
      return Command_SetStartTrigger.cb_getStartDelay;
    }

    private static long n_GetStartDelay(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StartDelay;
    }

    private static Delegate GetSetStartDelay_JHandler()
    {
      if ((object) Command_SetStartTrigger.cb_setStartDelay_J == null)
        Command_SetStartTrigger.cb_setStartDelay_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_SetStartTrigger.n_SetStartDelay_J));
      return Command_SetStartTrigger.cb_setStartDelay_J;
    }

    private static void n_SetStartDelay_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StartDelay = value;
    }

    public virtual unsafe long StartDelay
    {
      [Register("getStartDelay", "()J", "GetGetStartDelayHandler")] get
      {
        return Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualInt64Method("getStartDelay.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStartDelay", "(J)V", "GetSetStartDelay_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStartDelay.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStartOnHandHeldTriggerHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getStartOnHandHeldTrigger == null)
        Command_SetStartTrigger.cb_getStartOnHandHeldTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStartTrigger.n_GetStartOnHandHeldTrigger));
      return Command_SetStartTrigger.cb_getStartOnHandHeldTrigger;
    }

    private static bool n_GetStartOnHandHeldTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StartOnHandHeldTrigger;
    }

    private static Delegate GetSetStartOnHandHeldTrigger_ZHandler()
    {
      if ((object) Command_SetStartTrigger.cb_setStartOnHandHeldTrigger_Z == null)
        Command_SetStartTrigger.cb_setStartOnHandHeldTrigger_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStartTrigger.n_SetStartOnHandHeldTrigger_Z));
      return Command_SetStartTrigger.cb_setStartOnHandHeldTrigger_Z;
    }

    private static void n_SetStartOnHandHeldTrigger_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StartOnHandHeldTrigger = value;
    }

    public virtual unsafe bool StartOnHandHeldTrigger
    {
      [Register("getStartOnHandHeldTrigger", "()Z", "GetGetStartOnHandHeldTriggerHandler")] get
      {
        return Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getStartOnHandHeldTrigger.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStartOnHandHeldTrigger", "(Z)V", "GetSetStartOnHandHeldTrigger_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStartOnHandHeldTrigger.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTriggerTypeHandler()
    {
      if ((object) Command_SetStartTrigger.cb_getTriggerType == null)
        Command_SetStartTrigger.cb_getTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStartTrigger.n_GetTriggerType));
      return Command_SetStartTrigger.cb_getTriggerType;
    }

    private static IntPtr n_GetTriggerType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType);
    }

    private static Delegate GetSetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_Handler()
    {
      if ((object) Command_SetStartTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_ == null)
        Command_SetStartTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetStartTrigger.n_SetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_));
      return Command_SetStartTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_;
    }

    private static void n_SetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType = Object.GetObject<ENUM_TRIGGER_ID>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_TRIGGER_ID? TriggerType
    {
      [Register("getTriggerType", "()Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", "GetGetTriggerTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getTriggerType.()Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTriggerType", "(Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;)V", "GetSetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setTriggerType.(Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetStartTrigger.cb_FromString_Ljava_lang_String_ == null)
        Command_SetStartTrigger.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetStartTrigger.n_FromString_Ljava_lang_String_));
      return Command_SetStartTrigger.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetStartTrigger.cb_ToString == null)
        Command_SetStartTrigger.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStartTrigger.n_ToString));
      return Command_SetStartTrigger.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetStartTrigger>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetStartTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
