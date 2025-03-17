// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_readbuffer
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
  [Register("com/zebra/ASCII_SDK/Command_readbuffer", DoNotGenerateAcw = true)]
  public class Command_readbuffer : Command
  {
    [Register("commandName")]
    public const string CommandName = "readbuffer";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_readbuffer", typeof (Command_readbuffer));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getbitcount;
    private static Delegate? cb_getwordptr;
    private static Delegate? cb_setbitcount_I;
    private static Delegate? cb_setwordptr_I;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_readbuffer._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_readbuffer._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("ReportConfig")]
    public Param_ReportConfig? ReportConfig
    {
      get
      {
        JniObjectReference objectValue = Command_readbuffer._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_readbuffer._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_readbuffer._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_readbuffer._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_readbuffer._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_readbuffer._members.ManagedPeerType;

    protected Command_readbuffer(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_readbuffer()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_readbuffer._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_readbuffer._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_readbuffer.cb_getCommandType == null)
        Command_readbuffer.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_readbuffer.n_GetCommandType));
      return Command_readbuffer.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_readbuffer._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_readbuffer.cb_getCriteriaIndex == null)
        Command_readbuffer.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_readbuffer.n_GetCriteriaIndex));
      return Command_readbuffer.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_readbuffer.cb_setCriteriaIndex_S == null)
        Command_readbuffer.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_readbuffer.n_SetCriteriaIndex_S));
      return Command_readbuffer.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_readbuffer._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_readbuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_readbuffer.cb_getPassword == null)
        Command_readbuffer.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_readbuffer.n_GetPassword));
      return Command_readbuffer.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_readbuffer.cb_setPassword_J == null)
        Command_readbuffer.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_readbuffer.n_SetPassword_J));
      return Command_readbuffer.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_readbuffer._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_readbuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_readbuffer.cb_FromString_Ljava_lang_String_ == null)
        Command_readbuffer.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_readbuffer.n_FromString_Ljava_lang_String_));
      return Command_readbuffer.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_readbuffer._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_readbuffer.cb_ToString == null)
        Command_readbuffer.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_readbuffer.n_ToString));
      return Command_readbuffer.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_readbuffer._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetbitcountHandler()
    {
      if ((object) Command_readbuffer.cb_getbitcount == null)
        Command_readbuffer.cb_getbitcount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_readbuffer.n_Getbitcount));
      return Command_readbuffer.cb_getbitcount;
    }

    private static int n_Getbitcount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Getbitcount();
    }

    [Register("getbitcount", "()I", "GetGetbitcountHandler")]
    public virtual unsafe int Getbitcount()
    {
      return Command_readbuffer._members.InstanceMethods.InvokeVirtualInt32Method("getbitcount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetwordptrHandler()
    {
      if ((object) Command_readbuffer.cb_getwordptr == null)
        Command_readbuffer.cb_getwordptr = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_readbuffer.n_Getwordptr));
      return Command_readbuffer.cb_getwordptr;
    }

    private static int n_Getwordptr(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Getwordptr();
    }

    [Register("getwordptr", "()I", "GetGetwordptrHandler")]
    public virtual unsafe int Getwordptr()
    {
      return Command_readbuffer._members.InstanceMethods.InvokeVirtualInt32Method("getwordptr.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetbitcount_IHandler()
    {
      if ((object) Command_readbuffer.cb_setbitcount_I == null)
        Command_readbuffer.cb_setbitcount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_readbuffer.n_Setbitcount_I));
      return Command_readbuffer.cb_setbitcount_I;
    }

    private static void n_Setbitcount_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Setbitcount(value);
    }

    [Register("setbitcount", "(I)V", "GetSetbitcount_IHandler")]
    public virtual unsafe void Setbitcount(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_readbuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setbitcount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetwordptr_IHandler()
    {
      if ((object) Command_readbuffer.cb_setwordptr_I == null)
        Command_readbuffer.cb_setwordptr_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_readbuffer.n_Setwordptr_I));
      return Command_readbuffer.cb_setwordptr_I;
    }

    private static void n_Setwordptr_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_readbuffer>(jnienv, native__this, (JniHandleOwnership) 0).Setwordptr(value);
    }

    [Register("setwordptr", "(I)V", "GetSetwordptr_IHandler")]
    public virtual unsafe void Setwordptr(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_readbuffer._members.InstanceMethods.InvokeVirtualVoidMethod("setwordptr.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
