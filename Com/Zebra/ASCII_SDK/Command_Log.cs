// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Log
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
  [Register("com/zebra/ASCII_SDK/Command_Log", DoNotGenerateAcw = true)]
  public class Command_Log : Command
  {
    [Register("commandName")]
    public const string CommandName = "Log";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Log", typeof (Command_Log));
    private static Delegate? cb_getChoice;
    private static Delegate? cb_setChoice_S;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getLevel;
    private static Delegate? cb_setLevel_S;
    private static Delegate? cb_getOption;
    private static Delegate? cb_setOption_S;
    private static Delegate? cb_getTarget;
    private static Delegate? cb_setTarget_S;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_Log._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Log._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Log._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Log._members.ManagedPeerType;

    protected Command_Log(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Log()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Log._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Log._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetChoiceHandler()
    {
      if ((object) Command_Log.cb_getChoice == null)
        Command_Log.cb_getChoice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Log.n_GetChoice));
      return Command_Log.cb_getChoice;
    }

    private static short n_GetChoice(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Choice;
    }

    private static Delegate GetSetChoice_SHandler()
    {
      if ((object) Command_Log.cb_setChoice_S == null)
        Command_Log.cb_setChoice_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Log.n_SetChoice_S));
      return Command_Log.cb_setChoice_S;
    }

    private static void n_SetChoice_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Choice = value;
    }

    public virtual unsafe short Choice
    {
      [Register("getChoice", "()S", "GetGetChoiceHandler")] get
      {
        return Command_Log._members.InstanceMethods.InvokeVirtualInt16Method("getChoice.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setChoice", "(S)V", "GetSetChoice_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Log._members.InstanceMethods.InvokeVirtualVoidMethod("setChoice.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Log.cb_getCommandType == null)
        Command_Log.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Log.n_GetCommandType));
      return Command_Log.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Log._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetLevelHandler()
    {
      if ((object) Command_Log.cb_getLevel == null)
        Command_Log.cb_getLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Log.n_GetLevel));
      return Command_Log.cb_getLevel;
    }

    private static short n_GetLevel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Level;
    }

    private static Delegate GetSetLevel_SHandler()
    {
      if ((object) Command_Log.cb_setLevel_S == null)
        Command_Log.cb_setLevel_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Log.n_SetLevel_S));
      return Command_Log.cb_setLevel_S;
    }

    private static void n_SetLevel_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Level = value;
    }

    public virtual unsafe short Level
    {
      [Register("getLevel", "()S", "GetGetLevelHandler")] get
      {
        return Command_Log._members.InstanceMethods.InvokeVirtualInt16Method("getLevel.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLevel", "(S)V", "GetSetLevel_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Log._members.InstanceMethods.InvokeVirtualVoidMethod("setLevel.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOptionHandler()
    {
      if ((object) Command_Log.cb_getOption == null)
        Command_Log.cb_getOption = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Log.n_GetOption));
      return Command_Log.cb_getOption;
    }

    private static short n_GetOption(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Option;
    }

    private static Delegate GetSetOption_SHandler()
    {
      if ((object) Command_Log.cb_setOption_S == null)
        Command_Log.cb_setOption_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Log.n_SetOption_S));
      return Command_Log.cb_setOption_S;
    }

    private static void n_SetOption_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Option = value;
    }

    public virtual unsafe short Option
    {
      [Register("getOption", "()S", "GetGetOptionHandler")] get
      {
        return Command_Log._members.InstanceMethods.InvokeVirtualInt16Method("getOption.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOption", "(S)V", "GetSetOption_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Log._members.InstanceMethods.InvokeVirtualVoidMethod("setOption.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTargetHandler()
    {
      if ((object) Command_Log.cb_getTarget == null)
        Command_Log.cb_getTarget = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Log.n_GetTarget));
      return Command_Log.cb_getTarget;
    }

    private static short n_GetTarget(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Target;
    }

    private static Delegate GetSetTarget_SHandler()
    {
      if ((object) Command_Log.cb_setTarget_S == null)
        Command_Log.cb_setTarget_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Log.n_SetTarget_S));
      return Command_Log.cb_setTarget_S;
    }

    private static void n_SetTarget_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).Target = value;
    }

    public virtual unsafe short Target
    {
      [Register("getTarget", "()S", "GetGetTargetHandler")] get
      {
        return Command_Log._members.InstanceMethods.InvokeVirtualInt16Method("getTarget.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTarget", "(S)V", "GetSetTarget_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Log._members.InstanceMethods.InvokeVirtualVoidMethod("setTarget.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Log.cb_FromString_Ljava_lang_String_ == null)
        Command_Log.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Log.n_FromString_Ljava_lang_String_));
      return Command_Log.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Log._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Log.cb_ToString == null)
        Command_Log.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Log.n_ToString));
      return Command_Log.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Log>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Log._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
