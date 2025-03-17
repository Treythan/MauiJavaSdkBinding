// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Read
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
  [Register("com/zebra/ASCII_SDK/Command_Read", DoNotGenerateAcw = true)]
  public class Command_Read : Command
  {
    [Register("commandName")]
    public const string CommandName = "Read";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Read", typeof (Command_Read));
    private static Delegate? cb_getBank;
    private static Delegate? cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getLength;
    private static Delegate? cb_setLength_S;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_S;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_Read._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Read._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Command_Read._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Read._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_Read._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Read._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Read._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Read._members.ManagedPeerType;

    protected Command_Read(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Read()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Read._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Read._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBankHandler()
    {
      if ((object) Command_Read.cb_getBank == null)
        Command_Read.cb_getBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Read.n_GetBank));
      return Command_Read.cb_getBank;
    }

    private static IntPtr n_GetBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Bank);
    }

    private static Delegate GetSetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Command_Read.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Command_Read.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Read.n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Command_Read.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Bank = Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_MEMORY_BANK? Bank
    {
      [Register("getBank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetBankHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Read._members.InstanceMethods.InvokeVirtualObjectMethod("getBank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setBank", "(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", "GetSetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("setBank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Read.cb_getCommandType == null)
        Command_Read.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Read.n_GetCommandType));
      return Command_Read.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Read._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_Read.cb_getCriteriaIndex == null)
        Command_Read.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Read.n_GetCriteriaIndex));
      return Command_Read.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_Read.cb_setCriteriaIndex_S == null)
        Command_Read.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Read.n_SetCriteriaIndex_S));
      return Command_Read.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_Read._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetLengthHandler()
    {
      if ((object) Command_Read.cb_getLength == null)
        Command_Read.cb_getLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Read.n_GetLength));
      return Command_Read.cb_getLength;
    }

    private static short n_GetLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Length;
    }

    private static Delegate GetSetLength_SHandler()
    {
      if ((object) Command_Read.cb_setLength_S == null)
        Command_Read.cb_setLength_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Read.n_SetLength_S));
      return Command_Read.cb_setLength_S;
    }

    private static void n_SetLength_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Length = value;
    }

    public virtual unsafe short Length
    {
      [Register("getLength", "()S", "GetGetLengthHandler")] get
      {
        return Command_Read._members.InstanceMethods.InvokeVirtualInt16Method("getLength.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLength", "(S)V", "GetSetLength_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("setLength.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) Command_Read.cb_getOffset == null)
        Command_Read.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Read.n_GetOffset));
      return Command_Read.cb_getOffset;
    }

    private static short n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_SHandler()
    {
      if ((object) Command_Read.cb_setOffset_S == null)
        Command_Read.cb_setOffset_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Read.n_SetOffset_S));
      return Command_Read.cb_setOffset_S;
    }

    private static void n_SetOffset_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Offset = value;
    }

    public virtual unsafe short Offset
    {
      [Register("getOffset", "()S", "GetGetOffsetHandler")] get
      {
        return Command_Read._members.InstanceMethods.InvokeVirtualInt16Method("getOffset.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(S)V", "GetSetOffset_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_Read.cb_getPassword == null)
        Command_Read.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_Read.n_GetPassword));
      return Command_Read.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_Read.cb_setPassword_J == null)
        Command_Read.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_Read.n_SetPassword_J));
      return Command_Read.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_Read._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Read.cb_FromString_Ljava_lang_String_ == null)
        Command_Read.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Read.n_FromString_Ljava_lang_String_));
      return Command_Read.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Read._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Read.cb_ToString == null)
        Command_Read.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Read.n_ToString));
      return Command_Read.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Read>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Read._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
