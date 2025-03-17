// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetQueryParams
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
  [Register("com/zebra/ASCII_SDK/Command_SetQueryParams", DoNotGenerateAcw = true)]
  public class Command_SetQueryParams : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetQueryParams";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetQueryParams", typeof (Command_SetQueryParams));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getPopulation;
    private static Delegate? cb_setPopulation_I;
    private static Delegate? cb_getQuerySelect;
    private static Delegate? cb_setQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_;
    private static Delegate? cb_getQuerySession;
    private static Delegate? cb_setQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_;
    private static Delegate? cb_getQueryTarget;
    private static Delegate? cb_setQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetQueryParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetQueryParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetQueryParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetQueryParams._members.ManagedPeerType;

    protected Command_SetQueryParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetQueryParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetQueryParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetQueryParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetQueryParams.cb_getCommandType == null)
        Command_SetQueryParams.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetQueryParams.n_GetCommandType));
      return Command_SetQueryParams.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetQueryParams._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPopulationHandler()
    {
      if ((object) Command_SetQueryParams.cb_getPopulation == null)
        Command_SetQueryParams.cb_getPopulation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetQueryParams.n_GetPopulation));
      return Command_SetQueryParams.cb_getPopulation;
    }

    private static int n_GetPopulation(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).Population;
    }

    private static Delegate GetSetPopulation_IHandler()
    {
      if ((object) Command_SetQueryParams.cb_setPopulation_I == null)
        Command_SetQueryParams.cb_setPopulation_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetQueryParams.n_SetPopulation_I));
      return Command_SetQueryParams.cb_setPopulation_I;
    }

    private static void n_SetPopulation_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).Population = value;
    }

    public virtual unsafe int Population
    {
      [Register("getPopulation", "()I", "GetGetPopulationHandler")] get
      {
        return Command_SetQueryParams._members.InstanceMethods.InvokeVirtualInt32Method("getPopulation.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPopulation", "(I)V", "GetSetPopulation_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetQueryParams._members.InstanceMethods.InvokeVirtualVoidMethod("setPopulation.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetQuerySelectHandler()
    {
      if ((object) Command_SetQueryParams.cb_getQuerySelect == null)
        Command_SetQueryParams.cb_getQuerySelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetQueryParams.n_GetQuerySelect));
      return Command_SetQueryParams.cb_getQuerySelect;
    }

    private static IntPtr n_GetQuerySelect(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QuerySelect);
    }

    private static Delegate GetSetQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_Handler()
    {
      if ((object) Command_SetQueryParams.cb_setQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_ == null)
        Command_SetQueryParams.cb_setQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetQueryParams.n_SetQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_));
      return Command_SetQueryParams.cb_setQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_;
    }

    private static void n_SetQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QuerySelect = Object.GetObject<ENUM_SL_FLAG>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_SL_FLAG? QuerySelect
    {
      [Register("getQuerySelect", "()Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", "GetGetQuerySelectHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetQueryParams._members.InstanceMethods.InvokeVirtualObjectMethod("getQuerySelect.()Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_SL_FLAG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setQuerySelect", "(Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;)V", "GetSetQuerySelect_Lcom_zebra_ASCII_SDK_ENUM_SL_FLAG_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_SetQueryParams._members.InstanceMethods.InvokeVirtualVoidMethod("setQuerySelect.(Lcom/zebra/ASCII_SDK/ENUM_SL_FLAG;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetQuerySessionHandler()
    {
      if ((object) Command_SetQueryParams.cb_getQuerySession == null)
        Command_SetQueryParams.cb_getQuerySession = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetQueryParams.n_GetQuerySession));
      return Command_SetQueryParams.cb_getQuerySession;
    }

    private static IntPtr n_GetQuerySession(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QuerySession);
    }

    private static Delegate GetSetQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_Handler()
    {
      if ((object) Command_SetQueryParams.cb_setQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_ == null)
        Command_SetQueryParams.cb_setQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetQueryParams.n_SetQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_));
      return Command_SetQueryParams.cb_setQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_;
    }

    private static void n_SetQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QuerySession = Object.GetObject<ENUM_SESSION>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_SESSION? QuerySession
    {
      [Register("getQuerySession", "()Lcom/zebra/ASCII_SDK/ENUM_SESSION;", "GetGetQuerySessionHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetQueryParams._members.InstanceMethods.InvokeVirtualObjectMethod("getQuerySession.()Lcom/zebra/ASCII_SDK/ENUM_SESSION;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_SESSION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setQuerySession", "(Lcom/zebra/ASCII_SDK/ENUM_SESSION;)V", "GetSetQuerySession_Lcom_zebra_ASCII_SDK_ENUM_SESSION_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_SetQueryParams._members.InstanceMethods.InvokeVirtualVoidMethod("setQuerySession.(Lcom/zebra/ASCII_SDK/ENUM_SESSION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetQueryTargetHandler()
    {
      if ((object) Command_SetQueryParams.cb_getQueryTarget == null)
        Command_SetQueryParams.cb_getQueryTarget = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetQueryParams.n_GetQueryTarget));
      return Command_SetQueryParams.cb_getQueryTarget;
    }

    private static IntPtr n_GetQueryTarget(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QueryTarget);
    }

    private static Delegate GetSetQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_Handler()
    {
      if ((object) Command_SetQueryParams.cb_setQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_ == null)
        Command_SetQueryParams.cb_setQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetQueryParams.n_SetQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_));
      return Command_SetQueryParams.cb_setQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_;
    }

    private static void n_SetQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).QueryTarget = Object.GetObject<ENUM_STATE>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_STATE? QueryTarget
    {
      [Register("getQueryTarget", "()Lcom/zebra/ASCII_SDK/ENUM_STATE;", "GetGetQueryTargetHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetQueryParams._members.InstanceMethods.InvokeVirtualObjectMethod("getQueryTarget.()Lcom/zebra/ASCII_SDK/ENUM_STATE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setQueryTarget", "(Lcom/zebra/ASCII_SDK/ENUM_STATE;)V", "GetSetQueryTarget_Lcom_zebra_ASCII_SDK_ENUM_STATE_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_SetQueryParams._members.InstanceMethods.InvokeVirtualVoidMethod("setQueryTarget.(Lcom/zebra/ASCII_SDK/ENUM_STATE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetQueryParams.cb_FromString_Ljava_lang_String_ == null)
        Command_SetQueryParams.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetQueryParams.n_FromString_Ljava_lang_String_));
      return Command_SetQueryParams.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetQueryParams._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetQueryParams.cb_ToString == null)
        Command_SetQueryParams.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetQueryParams.n_ToString));
      return Command_SetQueryParams.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetQueryParams>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetQueryParams._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
