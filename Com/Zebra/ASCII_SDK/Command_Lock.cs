// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Lock
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
  [Register("com/zebra/ASCII_SDK/Command_Lock", DoNotGenerateAcw = true)]
  public class Command_Lock : Command
  {
    [Register("commandName")]
    public const string CommandName = "Lock";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Lock", typeof (Command_Lock));
    private static Delegate? cb_getAccessPwd;
    private static Delegate? cb_setAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getEpcMem;
    private static Delegate? cb_setEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    private static Delegate? cb_getKillPwd;
    private static Delegate? cb_setKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_getTidMem;
    private static Delegate? cb_setTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    private static Delegate? cb_getUserMem;
    private static Delegate? cb_setUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_Lock._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Lock._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Command_Lock._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Lock._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_Lock._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Lock._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Lock._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Lock._members.ManagedPeerType;

    protected Command_Lock(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Lock()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Lock._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Lock._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccessPwdHandler()
    {
      if ((object) Command_Lock.cb_getAccessPwd == null)
        Command_Lock.cb_getAccessPwd = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetAccessPwd));
      return Command_Lock.cb_getAccessPwd;
    }

    private static IntPtr n_GetAccessPwd(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).AccessPwd);
    }

    private static Delegate GetSetAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler()
    {
      if ((object) Command_Lock.cb_setAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ == null)
        Command_Lock.cb_setAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_SetAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_));
      return Command_Lock.cb_setAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    }

    private static void n_SetAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).AccessPwd = Object.GetObject<ENUM_ACCESS_PERMISSIONS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACCESS_PERMISSIONS? AccessPwd
    {
      [Register("getAccessPwd", "()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "GetGetAccessPwdHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getAccessPwd.()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAccessPwd", "(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", "GetSetAccessPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPwd.(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Lock.cb_getCommandType == null)
        Command_Lock.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetCommandType));
      return Command_Lock.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_Lock.cb_getCriteriaIndex == null)
        Command_Lock.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_Lock.n_GetCriteriaIndex));
      return Command_Lock.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_Lock.cb_setCriteriaIndex_S == null)
        Command_Lock.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_Lock.n_SetCriteriaIndex_S));
      return Command_Lock.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_Lock._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEpcMemHandler()
    {
      if ((object) Command_Lock.cb_getEpcMem == null)
        Command_Lock.cb_getEpcMem = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetEpcMem));
      return Command_Lock.cb_getEpcMem;
    }

    private static IntPtr n_GetEpcMem(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).EpcMem);
    }

    private static Delegate GetSetEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler()
    {
      if ((object) Command_Lock.cb_setEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ == null)
        Command_Lock.cb_setEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_SetEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_));
      return Command_Lock.cb_setEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    }

    private static void n_SetEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).EpcMem = Object.GetObject<ENUM_ACCESS_PERMISSIONS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACCESS_PERMISSIONS? EpcMem
    {
      [Register("getEpcMem", "()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "GetGetEpcMemHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getEpcMem.()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setEpcMem", "(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", "GetSetEpcMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setEpcMem.(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetKillPwdHandler()
    {
      if ((object) Command_Lock.cb_getKillPwd == null)
        Command_Lock.cb_getKillPwd = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetKillPwd));
      return Command_Lock.cb_getKillPwd;
    }

    private static IntPtr n_GetKillPwd(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).KillPwd);
    }

    private static Delegate GetSetKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler()
    {
      if ((object) Command_Lock.cb_setKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ == null)
        Command_Lock.cb_setKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_SetKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_));
      return Command_Lock.cb_setKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    }

    private static void n_SetKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).KillPwd = Object.GetObject<ENUM_ACCESS_PERMISSIONS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACCESS_PERMISSIONS? KillPwd
    {
      [Register("getKillPwd", "()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "GetGetKillPwdHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getKillPwd.()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setKillPwd", "(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", "GetSetKillPwd_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setKillPwd.(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_Lock.cb_getPassword == null)
        Command_Lock.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_Lock.n_GetPassword));
      return Command_Lock.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_Lock.cb_setPassword_J == null)
        Command_Lock.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_Lock.n_SetPassword_J));
      return Command_Lock.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_Lock._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTidMemHandler()
    {
      if ((object) Command_Lock.cb_getTidMem == null)
        Command_Lock.cb_getTidMem = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetTidMem));
      return Command_Lock.cb_getTidMem;
    }

    private static IntPtr n_GetTidMem(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).TidMem);
    }

    private static Delegate GetSetTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler()
    {
      if ((object) Command_Lock.cb_setTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ == null)
        Command_Lock.cb_setTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_SetTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_));
      return Command_Lock.cb_setTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    }

    private static void n_SetTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).TidMem = Object.GetObject<ENUM_ACCESS_PERMISSIONS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACCESS_PERMISSIONS? TidMem
    {
      [Register("getTidMem", "()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "GetGetTidMemHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getTidMem.()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTidMem", "(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", "GetSetTidMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setTidMem.(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetUserMemHandler()
    {
      if ((object) Command_Lock.cb_getUserMem == null)
        Command_Lock.cb_getUserMem = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_GetUserMem));
      return Command_Lock.cb_getUserMem;
    }

    private static IntPtr n_GetUserMem(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).UserMem);
    }

    private static Delegate GetSetUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler()
    {
      if ((object) Command_Lock.cb_setUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ == null)
        Command_Lock.cb_setUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_SetUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_));
      return Command_Lock.cb_setUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_;
    }

    private static void n_SetUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).UserMem = Object.GetObject<ENUM_ACCESS_PERMISSIONS>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACCESS_PERMISSIONS? UserMem
    {
      [Register("getUserMem", "()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "GetGetUserMemHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("getUserMem.()Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setUserMem", "(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", "GetSetUserMem_Lcom_zebra_ASCII_SDK_ENUM_ACCESS_PERMISSIONS_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("setUserMem.(Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Lock.cb_FromString_Ljava_lang_String_ == null)
        Command_Lock.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Lock.n_FromString_Ljava_lang_String_));
      return Command_Lock.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Lock._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Lock.cb_ToString == null)
        Command_Lock.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Lock.n_ToString));
      return Command_Lock.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Lock>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Lock._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
