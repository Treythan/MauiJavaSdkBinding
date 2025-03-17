// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_BlockPermaLock
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
  [Register("com/zebra/ASCII_SDK/Command_BlockPermaLock", DoNotGenerateAcw = true)]
  public class Command_BlockPermaLock : Command
  {
    [Register("commandName")]
    public const string CommandName = "BlockPermaLock";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_BlockPermaLock", typeof (Command_BlockPermaLock));
    private static Delegate? cb_getBank;
    private static Delegate? cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_getBlockPtr;
    private static Delegate? cb_setBlockPtr_S;
    private static Delegate? cb_getBlockRange;
    private static Delegate? cb_setBlockRange_S;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getDoLock;
    private static Delegate? cb_setDoLock_Z;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getBlockMask;
    private static Delegate? cb_setBlockMask_arrayB;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_BlockPermaLock._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_BlockPermaLock._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Command_BlockPermaLock._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_BlockPermaLock._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_BlockPermaLock._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_BlockPermaLock._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_BlockPermaLock._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_BlockPermaLock._members.ManagedPeerType;

    protected Command_BlockPermaLock(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_BlockPermaLock()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_BlockPermaLock._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_BlockPermaLock._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBankHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getBank == null)
        Command_BlockPermaLock.cb_getBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BlockPermaLock.n_GetBank));
      return Command_BlockPermaLock.cb_getBank;
    }

    private static IntPtr n_GetBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).Bank);
    }

    private static Delegate GetSetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Command_BlockPermaLock.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Command_BlockPermaLock.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_BlockPermaLock.n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Command_BlockPermaLock.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).Bank = Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_MEMORY_BANK? Bank
    {
      [Register("getBank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetBankHandler")] get
      {
        JniObjectReference jniObjectReference = Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualObjectMethod("getBank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setBank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetBlockPtrHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getBlockPtr == null)
        Command_BlockPermaLock.cb_getBlockPtr = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_BlockPermaLock.n_GetBlockPtr));
      return Command_BlockPermaLock.cb_getBlockPtr;
    }

    private static short n_GetBlockPtr(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).BlockPtr;
    }

    private static Delegate GetSetBlockPtr_SHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setBlockPtr_S == null)
        Command_BlockPermaLock.cb_setBlockPtr_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_BlockPermaLock.n_SetBlockPtr_S));
      return Command_BlockPermaLock.cb_setBlockPtr_S;
    }

    private static void n_SetBlockPtr_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).BlockPtr = value;
    }

    public virtual unsafe short BlockPtr
    {
      [Register("getBlockPtr", "()S", "GetGetBlockPtrHandler")] get
      {
        return Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualInt16Method("getBlockPtr.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlockPtr", "(S)V", "GetSetBlockPtr_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockPtr.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetBlockRangeHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getBlockRange == null)
        Command_BlockPermaLock.cb_getBlockRange = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_BlockPermaLock.n_GetBlockRange));
      return Command_BlockPermaLock.cb_getBlockRange;
    }

    private static short n_GetBlockRange(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).BlockRange;
    }

    private static Delegate GetSetBlockRange_SHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setBlockRange_S == null)
        Command_BlockPermaLock.cb_setBlockRange_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_BlockPermaLock.n_SetBlockRange_S));
      return Command_BlockPermaLock.cb_setBlockRange_S;
    }

    private static void n_SetBlockRange_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).BlockRange = value;
    }

    public virtual unsafe short BlockRange
    {
      [Register("getBlockRange", "()S", "GetGetBlockRangeHandler")] get
      {
        return Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualInt16Method("getBlockRange.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlockRange", "(S)V", "GetSetBlockRange_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockRange.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getCommandType == null)
        Command_BlockPermaLock.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BlockPermaLock.n_GetCommandType));
      return Command_BlockPermaLock.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getCriteriaIndex == null)
        Command_BlockPermaLock.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_BlockPermaLock.n_GetCriteriaIndex));
      return Command_BlockPermaLock.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setCriteriaIndex_S == null)
        Command_BlockPermaLock.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_BlockPermaLock.n_SetCriteriaIndex_S));
      return Command_BlockPermaLock.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDoLockHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getDoLock == null)
        Command_BlockPermaLock.cb_getDoLock = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_BlockPermaLock.n_GetDoLock));
      return Command_BlockPermaLock.cb_getDoLock;
    }

    private static bool n_GetDoLock(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).DoLock;
    }

    private static Delegate GetSetDoLock_ZHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setDoLock_Z == null)
        Command_BlockPermaLock.cb_setDoLock_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_BlockPermaLock.n_SetDoLock_Z));
      return Command_BlockPermaLock.cb_setDoLock_Z;
    }

    private static void n_SetDoLock_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).DoLock = value;
    }

    public virtual unsafe bool DoLock
    {
      [Register("getDoLock", "()Z", "GetGetDoLockHandler")] get
      {
        return Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoLock.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoLock", "(Z)V", "GetSetDoLock_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setDoLock.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getPassword == null)
        Command_BlockPermaLock.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_BlockPermaLock.n_GetPassword));
      return Command_BlockPermaLock.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setPassword_J == null)
        Command_BlockPermaLock.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_BlockPermaLock.n_SetPassword_J));
      return Command_BlockPermaLock.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_BlockPermaLock.cb_FromString_Ljava_lang_String_ == null)
        Command_BlockPermaLock.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_BlockPermaLock.n_FromString_Ljava_lang_String_));
      return Command_BlockPermaLock.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_BlockPermaLock.cb_ToString == null)
        Command_BlockPermaLock.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BlockPermaLock.n_ToString));
      return Command_BlockPermaLock.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetBlockMaskHandler()
    {
      if ((object) Command_BlockPermaLock.cb_getBlockMask == null)
        Command_BlockPermaLock.cb_getBlockMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BlockPermaLock.n_GetBlockMask));
      return Command_BlockPermaLock.cb_getBlockMask;
    }

    private static IntPtr n_GetBlockMask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0).GetBlockMask());
    }

    [Register("getBlockMask", "()[B", "GetGetBlockMaskHandler")]
    public virtual unsafe byte[]? GetBlockMask()
    {
      JniObjectReference jniObjectReference = Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualObjectMethod("getBlockMask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetBlockMask_arrayBHandler()
    {
      if ((object) Command_BlockPermaLock.cb_setBlockMask_arrayB == null)
        Command_BlockPermaLock.cb_setBlockMask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_BlockPermaLock.n_SetBlockMask_arrayB));
      return Command_BlockPermaLock.cb_setBlockMask_arrayB;
    }

    private static void n_SetBlockMask_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Command_BlockPermaLock commandBlockPermaLock = Object.GetObject<Command_BlockPermaLock>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      commandBlockPermaLock.SetBlockMask(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setBlockMask", "([B)V", "GetSetBlockMask_arrayBHandler")]
    public virtual unsafe void SetBlockMask(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_BlockPermaLock._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockMask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (value != null)
        {
          JNIEnv.CopyArray(num, value);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) value);
      }
    }
  }
}
