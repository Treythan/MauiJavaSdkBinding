// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_ExecAccessSequence
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
  [Register("com/zebra/ASCII_SDK/Command_ExecAccessSequence", DoNotGenerateAcw = true)]
  public class Command_ExecAccessSequence : Command
  {
    [Register("commandName")]
    public const string CommandName = "ExecAccessSequence";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_ExecAccessSequence", typeof (Command_ExecAccessSequence));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getDoSelect;
    private static Delegate? cb_setDoSelect_Z;
    private static Delegate? cb_getNoSelect;
    private static Delegate? cb_setNoSelect_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    [Register("ReportConfig")]
    public Param_ReportConfig? ReportConfig
    {
      get
      {
        JniObjectReference objectValue = Command_ExecAccessSequence._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_ExecAccessSequence._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_ExecAccessSequence._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_ExecAccessSequence._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_ExecAccessSequence._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_ExecAccessSequence._members.ManagedPeerType;

    protected Command_ExecAccessSequence(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_ExecAccessSequence()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_ExecAccessSequence._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_ExecAccessSequence._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_getCommandType == null)
        Command_ExecAccessSequence.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ExecAccessSequence.n_GetCommandType));
      return Command_ExecAccessSequence.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_getCriteriaIndex == null)
        Command_ExecAccessSequence.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_ExecAccessSequence.n_GetCriteriaIndex));
      return Command_ExecAccessSequence.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_setCriteriaIndex_S == null)
        Command_ExecAccessSequence.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_ExecAccessSequence.n_SetCriteriaIndex_S));
      return Command_ExecAccessSequence.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDoSelectHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_getDoSelect == null)
        Command_ExecAccessSequence.cb_getDoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ExecAccessSequence.n_GetDoSelect));
      return Command_ExecAccessSequence.cb_getDoSelect;
    }

    private static bool n_GetDoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect;
    }

    private static Delegate GetSetDoSelect_ZHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_setDoSelect_Z == null)
        Command_ExecAccessSequence.cb_setDoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ExecAccessSequence.n_SetDoSelect_Z));
      return Command_ExecAccessSequence.cb_setDoSelect_Z;
    }

    private static void n_SetDoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect = value;
    }

    public virtual unsafe bool DoSelect
    {
      [Register("getDoSelect", "()Z", "GetGetDoSelectHandler")] get
      {
        return Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoSelect", "(Z)V", "GetSetDoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualVoidMethod("setDoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoSelectHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_getNoSelect == null)
        Command_ExecAccessSequence.cb_getNoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ExecAccessSequence.n_GetNoSelect));
      return Command_ExecAccessSequence.cb_getNoSelect;
    }

    private static bool n_GetNoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect;
    }

    private static Delegate GetSetNoSelect_ZHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_setNoSelect_Z == null)
        Command_ExecAccessSequence.cb_setNoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ExecAccessSequence.n_SetNoSelect_Z));
      return Command_ExecAccessSequence.cb_setNoSelect_Z;
    }

    private static void n_SetNoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect = value;
    }

    public virtual unsafe bool NoSelect
    {
      [Register("getNoSelect", "()Z", "GetGetNoSelectHandler")] get
      {
        return Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoSelect", "(Z)V", "GetSetNoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualVoidMethod("setNoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_ExecAccessSequence.cb_FromString_Ljava_lang_String_ == null)
        Command_ExecAccessSequence.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_ExecAccessSequence.n_FromString_Ljava_lang_String_));
      return Command_ExecAccessSequence.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_ExecAccessSequence.cb_ToString == null)
        Command_ExecAccessSequence.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ExecAccessSequence.n_ToString));
      return Command_ExecAccessSequence.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_ExecAccessSequence>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_ExecAccessSequence._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
