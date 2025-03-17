// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Write
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
  [Register("com/zebra/ASCII_SDK/Command_Write", DoNotGenerateAcw = true)]
  public class Command_Write : Command
  {
    [Register("commandName")]
    public const string CommandName = "Write";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Write", typeof (Command_Write));
    private static Delegate? cb_getBank;
    private static Delegate? cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getDoBlockWrite;
    private static Delegate? cb_setDoBlockWrite_Z;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_S;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getData;
    private static Delegate? cb_setData_arrayB;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_Write._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Write._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Command_Write._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Write._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_Write._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Write._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Write._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Write._members.ManagedPeerType;

    protected Command_Write(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Write()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Write._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Write._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBankHandler()
    {
      if ((object) Command_Write.cb_getBank == null)
        Command_Write.cb_getBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Write.n_GetBank));
      return Command_Write.cb_getBank;
    }

    private static IntPtr n_GetBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Bank);
    }

    private static Delegate GetSetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Command_Write.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Command_Write.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Write.n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Command_Write.cb_setBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_SetBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Bank = Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_MEMORY_BANK? Bank
    {
      [Register("getBank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetBankHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Write._members.InstanceMethods.InvokeVirtualObjectMethod("getBank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setBank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Write.cb_getCommandType == null)
        Command_Write.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Write.n_GetCommandType));
      return Command_Write.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Write._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_Write.cb_getCriteriaIndex == null)
        Command_Write.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Write.n_GetCriteriaIndex));
      return Command_Write.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_Write.cb_setCriteriaIndex_S == null)
        Command_Write.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Write.n_SetCriteriaIndex_S));
      return Command_Write.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_Write._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDoBlockWriteHandler()
    {
      if ((object) Command_Write.cb_getDoBlockWrite == null)
        Command_Write.cb_getDoBlockWrite = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_Write.n_GetDoBlockWrite));
      return Command_Write.cb_getDoBlockWrite;
    }

    private static bool n_GetDoBlockWrite(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).DoBlockWrite;
    }

    private static Delegate GetSetDoBlockWrite_ZHandler()
    {
      if ((object) Command_Write.cb_setDoBlockWrite_Z == null)
        Command_Write.cb_setDoBlockWrite_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_Write.n_SetDoBlockWrite_Z));
      return Command_Write.cb_setDoBlockWrite_Z;
    }

    private static void n_SetDoBlockWrite_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).DoBlockWrite = value;
    }

    public virtual unsafe bool DoBlockWrite
    {
      [Register("getDoBlockWrite", "()Z", "GetGetDoBlockWriteHandler")] get
      {
        return Command_Write._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoBlockWrite.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoBlockWrite", "(Z)V", "GetSetDoBlockWrite_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setDoBlockWrite.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) Command_Write.cb_getOffset == null)
        Command_Write.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Write.n_GetOffset));
      return Command_Write.cb_getOffset;
    }

    private static short n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_SHandler()
    {
      if ((object) Command_Write.cb_setOffset_S == null)
        Command_Write.cb_setOffset_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Write.n_SetOffset_S));
      return Command_Write.cb_setOffset_S;
    }

    private static void n_SetOffset_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Offset = value;
    }

    public virtual unsafe short Offset
    {
      [Register("getOffset", "()S", "GetGetOffsetHandler")] get
      {
        return Command_Write._members.InstanceMethods.InvokeVirtualInt16Method("getOffset.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(S)V", "GetSetOffset_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_Write.cb_getPassword == null)
        Command_Write.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_Write.n_GetPassword));
      return Command_Write.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_Write.cb_setPassword_J == null)
        Command_Write.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_Write.n_SetPassword_J));
      return Command_Write.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_Write._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Write.cb_FromString_Ljava_lang_String_ == null)
        Command_Write.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Write.n_FromString_Ljava_lang_String_));
      return Command_Write.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Write.cb_ToString == null)
        Command_Write.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Write.n_ToString));
      return Command_Write.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Write._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetDataHandler()
    {
      if ((object) Command_Write.cb_getData == null)
        Command_Write.cb_getData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Write.n_GetData));
      return Command_Write.cb_getData;
    }

    private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0).GetData());
    }

    [Register("getData", "()[B", "GetGetDataHandler")]
    public virtual unsafe byte[]? GetData()
    {
      JniObjectReference jniObjectReference = Command_Write._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetData_arrayBHandler()
    {
      if ((object) Command_Write.cb_setData_arrayB == null)
        Command_Write.cb_setData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Write.n_SetData_arrayB));
      return Command_Write.cb_setData_arrayB;
    }

    private static void n_SetData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
    {
      Command_Write commandWrite = Object.GetObject<Command_Write>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      commandWrite.SetData(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setData", "([B)V", "GetSetData_arrayBHandler")]
    public virtual unsafe void SetData(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_Write._members.InstanceMethods.InvokeVirtualVoidMethod("setData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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
