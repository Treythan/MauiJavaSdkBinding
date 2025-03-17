// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_Wpaconfig
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Com.Zebra.Rfid.Api3;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/Command_Wpaconfig", DoNotGenerateAcw = true)]
  public class Command_Wpaconfig : Command
  {
    [Register("commandName")]
    public const string CommandName = "wpaconfig";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_Wpaconfig", typeof (Command_Wpaconfig));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_get_paramwificonfig;
    private static Delegate? cb_get_wifipassword;
    private static Delegate? cb_get_wifissid;
    private static Delegate? cb_get_wpaconfigCommand;
    private static Delegate? cb_set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_;
    private static Delegate? cb_set_wifipassword_Ljava_lang_String_;
    private static Delegate? cb_set_wifissid_Ljava_lang_String_;
    private static Delegate? cb_set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_;

    [Register("Paramwificonfig")]
    public Param_WifiConfig? Paramwificonfig
    {
      get
      {
        JniObjectReference objectValue = Command_Wpaconfig._members.InstanceFields.GetObjectValue("Paramwificonfig.Lcom/zebra/ASCII_SDK/Param_WifiConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_WifiConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Wpaconfig._members.InstanceFields.SetValue("Paramwificonfig.Lcom/zebra/ASCII_SDK/Param_WifiConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("wifi_cmdmap")]
    public EnumMap? WifiCmdmap
    {
      get
      {
        JniObjectReference objectValue = Command_Wpaconfig._members.InstanceFields.GetObjectValue("wifi_cmdmap.Ljava/util/EnumMap;", (IJavaPeerable) this);
        return Object.GetObject<EnumMap>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_Wpaconfig._members.InstanceFields.SetValue("wifi_cmdmap.Ljava/util/EnumMap;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_Wpaconfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_Wpaconfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_Wpaconfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_Wpaconfig._members.ManagedPeerType;

    protected Command_Wpaconfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_Wpaconfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_Wpaconfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_Wpaconfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_Wpaconfig.cb_getCommandType == null)
        Command_Wpaconfig.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_GetCommandType));
      return Command_Wpaconfig.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_Wpaconfig.cb_FromString_Ljava_lang_String_ == null)
        Command_Wpaconfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Wpaconfig.n_FromString_Ljava_lang_String_));
      return Command_Wpaconfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_Wpaconfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_Wpaconfig.cb_ToString == null)
        Command_Wpaconfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_ToString));
      return Command_Wpaconfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGet_paramwificonfigHandler()
    {
      if ((object) Command_Wpaconfig.cb_get_paramwificonfig == null)
        Command_Wpaconfig.cb_get_paramwificonfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_Get_paramwificonfig));
      return Command_Wpaconfig.cb_get_paramwificonfig;
    }

    private static IntPtr n_Get_paramwificonfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Get_paramwificonfig());
    }

    [Register("get_paramwificonfig", "()Lcom/zebra/ASCII_SDK/Param_WifiConfig;", "GetGet_paramwificonfigHandler")]
    public virtual unsafe Param_WifiConfig? Get_paramwificonfig()
    {
      JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("get_paramwificonfig.()Lcom/zebra/ASCII_SDK/Param_WifiConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<Param_WifiConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGet_wifipasswordHandler()
    {
      if ((object) Command_Wpaconfig.cb_get_wifipassword == null)
        Command_Wpaconfig.cb_get_wifipassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_Get_wifipassword));
      return Command_Wpaconfig.cb_get_wifipassword;
    }

    private static IntPtr n_Get_wifipassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Get_wifipassword());
    }

    [Register("get_wifipassword", "()Ljava/lang/String;", "GetGet_wifipasswordHandler")]
    public virtual unsafe string? Get_wifipassword()
    {
      JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("get_wifipassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGet_wifissidHandler()
    {
      if ((object) Command_Wpaconfig.cb_get_wifissid == null)
        Command_Wpaconfig.cb_get_wifissid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_Get_wifissid));
      return Command_Wpaconfig.cb_get_wifissid;
    }

    private static IntPtr n_Get_wifissid(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Get_wifissid());
    }

    [Register("get_wifissid", "()Ljava/lang/String;", "GetGet_wifissidHandler")]
    public virtual unsafe string? Get_wifissid()
    {
      JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("get_wifissid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGet_wpaconfigCommandHandler()
    {
      if ((object) Command_Wpaconfig.cb_get_wpaconfigCommand == null)
        Command_Wpaconfig.cb_get_wpaconfigCommand = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_Wpaconfig.n_Get_wpaconfigCommand));
      return Command_Wpaconfig.cb_get_wpaconfigCommand;
    }

    private static IntPtr n_Get_wpaconfigCommand(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Get_wpaconfigCommand());
    }

    [Register("get_wpaconfigCommand", "()Ljava/lang/String;", "GetGet_wpaconfigCommandHandler")]
    public virtual unsafe string? Get_wpaconfigCommand()
    {
      JniObjectReference jniObjectReference = Command_Wpaconfig._members.InstanceMethods.InvokeVirtualObjectMethod("get_wpaconfigCommand.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSet_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_Handler()
    {
      if ((object) Command_Wpaconfig.cb_set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_ == null)
        Command_Wpaconfig.cb_set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Wpaconfig.n_Set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_));
      return Command_Wpaconfig.cb_set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_;
    }

    private static void n_Set_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Set_paramwificonfig(Object.GetObject<Param_WifiConfig>(native_value, (JniHandleOwnership) 0));
    }

    [Register("set_paramwificonfig", "(Lcom/zebra/ASCII_SDK/Param_WifiConfig;)V", "GetSet_paramwificonfig_Lcom_zebra_ASCII_SDK_Param_WifiConfig_Handler")]
    public virtual unsafe void Set_paramwificonfig(Param_WifiConfig? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
        };
        Command_Wpaconfig._members.InstanceMethods.InvokeVirtualVoidMethod("set_paramwificonfig.(Lcom/zebra/ASCII_SDK/Param_WifiConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }

    private static Delegate GetSet_wifipassword_Ljava_lang_String_Handler()
    {
      if ((object) Command_Wpaconfig.cb_set_wifipassword_Ljava_lang_String_ == null)
        Command_Wpaconfig.cb_set_wifipassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Wpaconfig.n_Set_wifipassword_Ljava_lang_String_));
      return Command_Wpaconfig.cb_set_wifipassword_Ljava_lang_String_;
    }

    private static void n_Set_wifipassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Set_wifipassword(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("set_wifipassword", "(Ljava/lang/String;)V", "GetSet_wifipassword_Ljava_lang_String_Handler")]
    public virtual unsafe void Set_wifipassword(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_Wpaconfig._members.InstanceMethods.InvokeVirtualVoidMethod("set_wifipassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSet_wifissid_Ljava_lang_String_Handler()
    {
      if ((object) Command_Wpaconfig.cb_set_wifissid_Ljava_lang_String_ == null)
        Command_Wpaconfig.cb_set_wifissid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Wpaconfig.n_Set_wifissid_Ljava_lang_String_));
      return Command_Wpaconfig.cb_set_wifissid_Ljava_lang_String_;
    }

    private static void n_Set_wifissid_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Set_wifissid(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("set_wifissid", "(Ljava/lang/String;)V", "GetSet_wifissid_Ljava_lang_String_Handler")]
    public virtual unsafe void Set_wifissid(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_Wpaconfig._members.InstanceMethods.InvokeVirtualVoidMethod("set_wifissid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSet_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_Handler()
    {
      if ((object) Command_Wpaconfig.cb_set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_ == null)
        Command_Wpaconfig.cb_set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_Wpaconfig.n_Set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_));
      return Command_Wpaconfig.cb_set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_;
    }

    private static void n_Set_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_Wpaconfig>(jnienv, native__this, (JniHandleOwnership) 0).Set_wpaconfigCommand(Object.GetObject<ENUM_WIFI_COMMAND_TYPE>(native_value, (JniHandleOwnership) 0));
    }

    [Register("set_wpaconfigCommand", "(Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;)V", "GetSet_wpaconfigCommand_Lcom_zebra_rfid_api3_ENUM_WIFI_COMMAND_TYPE_Handler")]
    public virtual unsafe void Set_wpaconfigCommand(ENUM_WIFI_COMMAND_TYPE? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        Command_Wpaconfig._members.InstanceMethods.InvokeVirtualVoidMethod("set_wpaconfigCommand.(Lcom/zebra/rfid/api3/ENUM_WIFI_COMMAND_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }
  }
}
