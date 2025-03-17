// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_ProtocolConfig
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
  [Register("com/zebra/ASCII_SDK/Command_ProtocolConfig", DoNotGenerateAcw = true)]
  public class Command_ProtocolConfig : Command
  {
    [Register("commandName")]
    public const string CommandName = "ProtocolConfig";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_ProtocolConfig", typeof (Command_ProtocolConfig));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getDebugLevel;
    private static Delegate? cb_setDebugLevel_B;
    private static Delegate? cb_getDisableDebug;
    private static Delegate? cb_setDisableDebug_Z;
    private static Delegate? cb_getEchoOff;
    private static Delegate? cb_setEchoOff_Z;
    private static Delegate? cb_getEchoOn;
    private static Delegate? cb_setEchoOn_Z;
    private static Delegate? cb_getEnableDebug;
    private static Delegate? cb_setEnableDebug_Z;
    private static Delegate? cb_getExcBatchmodeEventNotify;
    private static Delegate? cb_setExcBatchmodeEventNotify_Z;
    private static Delegate? cb_getExcBatteryEventNotify;
    private static Delegate? cb_setExcBatteryEventNotify_Z;
    private static Delegate? cb_getExcCRC;
    private static Delegate? cb_setExcCRC_Z;
    private static Delegate? cb_getExcDatabaseEventNotify;
    private static Delegate? cb_setExcDatabaseEventNotify_Z;
    private static Delegate? cb_getExcInvEndSummaryNotify;
    private static Delegate? cb_setExcInvEndSummaryNotify_Z;
    private static Delegate? cb_getExcOperEndSummaryNotify;
    private static Delegate? cb_setExcOperEndSummaryNotify_Z;
    private static Delegate? cb_getExcPowerEventNotify;
    private static Delegate? cb_setExcPowerEventNotify_Z;
    private static Delegate? cb_getExcRadioerrorEventNotify;
    private static Delegate? cb_setExcRadioerrorEventNotify_Z;
    private static Delegate? cb_getExcStartOperationNotify;
    private static Delegate? cb_setExcStartOperationNotify_Z;
    private static Delegate? cb_getExcStopoperationNotify;
    private static Delegate? cb_setExcStopoperationNotify_Z;
    private static Delegate? cb_getExcTemperatureEventNotify;
    private static Delegate? cb_setExcTemperatureEventNotify_Z;
    private static Delegate? cb_getExcWpaEventNotify;
    private static Delegate? cb_setExcWpaEventNotify_Z;
    private static Delegate? cb_getExctriggereventnotify;
    private static Delegate? cb_setExctriggereventnotify_Z;
    private static Delegate? cb_getIncBatchmodeEventNotify;
    private static Delegate? cb_setIncBatchmodeEventNotify_Z;
    private static Delegate? cb_getIncBatteryEventNotify;
    private static Delegate? cb_setIncBatteryEventNotify_Z;
    private static Delegate? cb_getIncCRC;
    private static Delegate? cb_setIncCRC_Z;
    private static Delegate? cb_getIncDatabaseEventNotify;
    private static Delegate? cb_setIncDatabaseEventNotify_Z;
    private static Delegate? cb_getIncInvEndSummaryNotify;
    private static Delegate? cb_setIncInvEndSummaryNotify_Z;
    private static Delegate? cb_getIncOperEndSummaryNotify;
    private static Delegate? cb_setIncOperEndSummaryNotify_Z;
    private static Delegate? cb_getIncPowerEventNotify;
    private static Delegate? cb_setIncPowerEventNotify_Z;
    private static Delegate? cb_getIncRadioerrorEventNotify;
    private static Delegate? cb_setIncRadioerrorEventNotify_Z;
    private static Delegate? cb_getIncStartOperationNotify;
    private static Delegate? cb_setIncStartOperationNotify_Z;
    private static Delegate? cb_getIncStopOperationNotify;
    private static Delegate? cb_setIncStopOperationNotify_Z;
    private static Delegate? cb_getIncTemperatureEventNotify;
    private static Delegate? cb_setIncTemperatureEventNotify_Z;
    private static Delegate? cb_getIncWpaEventNotify;
    private static Delegate? cb_setIncWpaEventNotify_Z;
    private static Delegate? cb_getInctriggereventnotify;
    private static Delegate? cb_setInctriggereventnotify_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_ProtocolConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_ProtocolConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_ProtocolConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_ProtocolConfig._members.ManagedPeerType;

    protected Command_ProtocolConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_ProtocolConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_ProtocolConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_ProtocolConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getCommandType == null)
        Command_ProtocolConfig.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ProtocolConfig.n_GetCommandType));
      return Command_ProtocolConfig.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDebugLevelHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getDebugLevel == null)
        Command_ProtocolConfig.cb_getDebugLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_B(Command_ProtocolConfig.n_GetDebugLevel));
      return Command_ProtocolConfig.cb_getDebugLevel;
    }

    private static sbyte n_GetDebugLevel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).DebugLevel;
    }

    private static Delegate GetSetDebugLevel_BHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setDebugLevel_B == null)
        Command_ProtocolConfig.cb_setDebugLevel_B = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPB_V(Command_ProtocolConfig.n_SetDebugLevel_B));
      return Command_ProtocolConfig.cb_setDebugLevel_B;
    }

    private static void n_SetDebugLevel_B(IntPtr jnienv, IntPtr native__this, sbyte value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).DebugLevel = value;
    }

    public virtual unsafe sbyte DebugLevel
    {
      [Register("getDebugLevel", "()B", "GetGetDebugLevelHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualSByteMethod("getDebugLevel.()B", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDebugLevel", "(B)V", "GetSetDebugLevel_BHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setDebugLevel.(B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDisableDebugHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getDisableDebug == null)
        Command_ProtocolConfig.cb_getDisableDebug = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetDisableDebug));
      return Command_ProtocolConfig.cb_getDisableDebug;
    }

    private static bool n_GetDisableDebug(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).DisableDebug;
    }

    private static Delegate GetSetDisableDebug_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setDisableDebug_Z == null)
        Command_ProtocolConfig.cb_setDisableDebug_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetDisableDebug_Z));
      return Command_ProtocolConfig.cb_setDisableDebug_Z;
    }

    private static void n_SetDisableDebug_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).DisableDebug = value;
    }

    public virtual unsafe bool DisableDebug
    {
      [Register("getDisableDebug", "()Z", "GetGetDisableDebugHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableDebug.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableDebug", "(Z)V", "GetSetDisableDebug_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableDebug.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEchoOffHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getEchoOff == null)
        Command_ProtocolConfig.cb_getEchoOff = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetEchoOff));
      return Command_ProtocolConfig.cb_getEchoOff;
    }

    private static bool n_GetEchoOff(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EchoOff;
    }

    private static Delegate GetSetEchoOff_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setEchoOff_Z == null)
        Command_ProtocolConfig.cb_setEchoOff_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetEchoOff_Z));
      return Command_ProtocolConfig.cb_setEchoOff_Z;
    }

    private static void n_SetEchoOff_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EchoOff = value;
    }

    public virtual unsafe bool EchoOff
    {
      [Register("getEchoOff", "()Z", "GetGetEchoOffHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getEchoOff.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEchoOff", "(Z)V", "GetSetEchoOff_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEchoOff.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEchoOnHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getEchoOn == null)
        Command_ProtocolConfig.cb_getEchoOn = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetEchoOn));
      return Command_ProtocolConfig.cb_getEchoOn;
    }

    private static bool n_GetEchoOn(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EchoOn;
    }

    private static Delegate GetSetEchoOn_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setEchoOn_Z == null)
        Command_ProtocolConfig.cb_setEchoOn_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetEchoOn_Z));
      return Command_ProtocolConfig.cb_setEchoOn_Z;
    }

    private static void n_SetEchoOn_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EchoOn = value;
    }

    public virtual unsafe bool EchoOn
    {
      [Register("getEchoOn", "()Z", "GetGetEchoOnHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getEchoOn.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEchoOn", "(Z)V", "GetSetEchoOn_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEchoOn.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableDebugHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getEnableDebug == null)
        Command_ProtocolConfig.cb_getEnableDebug = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetEnableDebug));
      return Command_ProtocolConfig.cb_getEnableDebug;
    }

    private static bool n_GetEnableDebug(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EnableDebug;
    }

    private static Delegate GetSetEnableDebug_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setEnableDebug_Z == null)
        Command_ProtocolConfig.cb_setEnableDebug_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetEnableDebug_Z));
      return Command_ProtocolConfig.cb_setEnableDebug_Z;
    }

    private static void n_SetEnableDebug_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).EnableDebug = value;
    }

    public virtual unsafe bool EnableDebug
    {
      [Register("getEnableDebug", "()Z", "GetGetEnableDebugHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableDebug.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableDebug", "(Z)V", "GetSetEnableDebug_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableDebug.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcBatchmodeEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcBatchmodeEventNotify == null)
        Command_ProtocolConfig.cb_getExcBatchmodeEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcBatchmodeEventNotify));
      return Command_ProtocolConfig.cb_getExcBatchmodeEventNotify;
    }

    private static bool n_GetExcBatchmodeEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcBatchmodeEventNotify;
    }

    private static Delegate GetSetExcBatchmodeEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcBatchmodeEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcBatchmodeEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcBatchmodeEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcBatchmodeEventNotify_Z;
    }

    private static void n_SetExcBatchmodeEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcBatchmodeEventNotify = value;
    }

    public virtual unsafe bool ExcBatchmodeEventNotify
    {
      [Register("getExcBatchmodeEventNotify", "()Z", "GetGetExcBatchmodeEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcBatchmodeEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcBatchmodeEventNotify", "(Z)V", "GetSetExcBatchmodeEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcBatchmodeEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcBatteryEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcBatteryEventNotify == null)
        Command_ProtocolConfig.cb_getExcBatteryEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcBatteryEventNotify));
      return Command_ProtocolConfig.cb_getExcBatteryEventNotify;
    }

    private static bool n_GetExcBatteryEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcBatteryEventNotify;
    }

    private static Delegate GetSetExcBatteryEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcBatteryEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcBatteryEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcBatteryEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcBatteryEventNotify_Z;
    }

    private static void n_SetExcBatteryEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcBatteryEventNotify = value;
    }

    public virtual unsafe bool ExcBatteryEventNotify
    {
      [Register("getExcBatteryEventNotify", "()Z", "GetGetExcBatteryEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcBatteryEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcBatteryEventNotify", "(Z)V", "GetSetExcBatteryEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcBatteryEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcCRCHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcCRC == null)
        Command_ProtocolConfig.cb_getExcCRC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcCRC));
      return Command_ProtocolConfig.cb_getExcCRC;
    }

    private static bool n_GetExcCRC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcCRC;
    }

    private static Delegate GetSetExcCRC_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcCRC_Z == null)
        Command_ProtocolConfig.cb_setExcCRC_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcCRC_Z));
      return Command_ProtocolConfig.cb_setExcCRC_Z;
    }

    private static void n_SetExcCRC_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcCRC = value;
    }

    public virtual unsafe bool ExcCRC
    {
      [Register("getExcCRC", "()Z", "GetGetExcCRCHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcCRC.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcCRC", "(Z)V", "GetSetExcCRC_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcCRC.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcDatabaseEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcDatabaseEventNotify == null)
        Command_ProtocolConfig.cb_getExcDatabaseEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcDatabaseEventNotify));
      return Command_ProtocolConfig.cb_getExcDatabaseEventNotify;
    }

    private static bool n_GetExcDatabaseEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcDatabaseEventNotify;
    }

    private static Delegate GetSetExcDatabaseEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcDatabaseEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcDatabaseEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcDatabaseEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcDatabaseEventNotify_Z;
    }

    private static void n_SetExcDatabaseEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcDatabaseEventNotify = value;
    }

    public virtual unsafe bool ExcDatabaseEventNotify
    {
      [Register("getExcDatabaseEventNotify", "()Z", "GetGetExcDatabaseEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcDatabaseEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcDatabaseEventNotify", "(Z)V", "GetSetExcDatabaseEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcDatabaseEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcInvEndSummaryNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcInvEndSummaryNotify == null)
        Command_ProtocolConfig.cb_getExcInvEndSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcInvEndSummaryNotify));
      return Command_ProtocolConfig.cb_getExcInvEndSummaryNotify;
    }

    private static bool n_GetExcInvEndSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcInvEndSummaryNotify;
    }

    private static Delegate GetSetExcInvEndSummaryNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcInvEndSummaryNotify_Z == null)
        Command_ProtocolConfig.cb_setExcInvEndSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcInvEndSummaryNotify_Z));
      return Command_ProtocolConfig.cb_setExcInvEndSummaryNotify_Z;
    }

    private static void n_SetExcInvEndSummaryNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcInvEndSummaryNotify = value;
    }

    public virtual unsafe bool ExcInvEndSummaryNotify
    {
      [Register("getExcInvEndSummaryNotify", "()Z", "GetGetExcInvEndSummaryNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcInvEndSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcInvEndSummaryNotify", "(Z)V", "GetSetExcInvEndSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcInvEndSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcOperEndSummaryNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcOperEndSummaryNotify == null)
        Command_ProtocolConfig.cb_getExcOperEndSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcOperEndSummaryNotify));
      return Command_ProtocolConfig.cb_getExcOperEndSummaryNotify;
    }

    private static bool n_GetExcOperEndSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcOperEndSummaryNotify;
    }

    private static Delegate GetSetExcOperEndSummaryNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcOperEndSummaryNotify_Z == null)
        Command_ProtocolConfig.cb_setExcOperEndSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcOperEndSummaryNotify_Z));
      return Command_ProtocolConfig.cb_setExcOperEndSummaryNotify_Z;
    }

    private static void n_SetExcOperEndSummaryNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcOperEndSummaryNotify = value;
    }

    public virtual unsafe bool ExcOperEndSummaryNotify
    {
      [Register("getExcOperEndSummaryNotify", "()Z", "GetGetExcOperEndSummaryNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcOperEndSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcOperEndSummaryNotify", "(Z)V", "GetSetExcOperEndSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcOperEndSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcPowerEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcPowerEventNotify == null)
        Command_ProtocolConfig.cb_getExcPowerEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcPowerEventNotify));
      return Command_ProtocolConfig.cb_getExcPowerEventNotify;
    }

    private static bool n_GetExcPowerEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPowerEventNotify;
    }

    private static Delegate GetSetExcPowerEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcPowerEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcPowerEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcPowerEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcPowerEventNotify_Z;
    }

    private static void n_SetExcPowerEventNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPowerEventNotify = value;
    }

    public virtual unsafe bool ExcPowerEventNotify
    {
      [Register("getExcPowerEventNotify", "()Z", "GetGetExcPowerEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcPowerEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcPowerEventNotify", "(Z)V", "GetSetExcPowerEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcPowerEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcRadioerrorEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcRadioerrorEventNotify == null)
        Command_ProtocolConfig.cb_getExcRadioerrorEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcRadioerrorEventNotify));
      return Command_ProtocolConfig.cb_getExcRadioerrorEventNotify;
    }

    private static bool n_GetExcRadioerrorEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcRadioerrorEventNotify;
    }

    private static Delegate GetSetExcRadioerrorEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcRadioerrorEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcRadioerrorEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcRadioerrorEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcRadioerrorEventNotify_Z;
    }

    private static void n_SetExcRadioerrorEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcRadioerrorEventNotify = value;
    }

    public virtual unsafe bool ExcRadioerrorEventNotify
    {
      [Register("getExcRadioerrorEventNotify", "()Z", "GetGetExcRadioerrorEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcRadioerrorEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcRadioerrorEventNotify", "(Z)V", "GetSetExcRadioerrorEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcRadioerrorEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcStartOperationNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcStartOperationNotify == null)
        Command_ProtocolConfig.cb_getExcStartOperationNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcStartOperationNotify));
      return Command_ProtocolConfig.cb_getExcStartOperationNotify;
    }

    private static bool n_GetExcStartOperationNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcStartOperationNotify;
    }

    private static Delegate GetSetExcStartOperationNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcStartOperationNotify_Z == null)
        Command_ProtocolConfig.cb_setExcStartOperationNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcStartOperationNotify_Z));
      return Command_ProtocolConfig.cb_setExcStartOperationNotify_Z;
    }

    private static void n_SetExcStartOperationNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcStartOperationNotify = value;
    }

    public virtual unsafe bool ExcStartOperationNotify
    {
      [Register("getExcStartOperationNotify", "()Z", "GetGetExcStartOperationNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcStartOperationNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcStartOperationNotify", "(Z)V", "GetSetExcStartOperationNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcStartOperationNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcStopoperationNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcStopoperationNotify == null)
        Command_ProtocolConfig.cb_getExcStopoperationNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcStopoperationNotify));
      return Command_ProtocolConfig.cb_getExcStopoperationNotify;
    }

    private static bool n_GetExcStopoperationNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcStopoperationNotify;
    }

    private static Delegate GetSetExcStopoperationNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcStopoperationNotify_Z == null)
        Command_ProtocolConfig.cb_setExcStopoperationNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcStopoperationNotify_Z));
      return Command_ProtocolConfig.cb_setExcStopoperationNotify_Z;
    }

    private static void n_SetExcStopoperationNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcStopoperationNotify = value;
    }

    public virtual unsafe bool ExcStopoperationNotify
    {
      [Register("getExcStopoperationNotify", "()Z", "GetGetExcStopoperationNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcStopoperationNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcStopoperationNotify", "(Z)V", "GetSetExcStopoperationNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcStopoperationNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcTemperatureEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcTemperatureEventNotify == null)
        Command_ProtocolConfig.cb_getExcTemperatureEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcTemperatureEventNotify));
      return Command_ProtocolConfig.cb_getExcTemperatureEventNotify;
    }

    private static bool n_GetExcTemperatureEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcTemperatureEventNotify;
    }

    private static Delegate GetSetExcTemperatureEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcTemperatureEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcTemperatureEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcTemperatureEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcTemperatureEventNotify_Z;
    }

    private static void n_SetExcTemperatureEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcTemperatureEventNotify = value;
    }

    public virtual unsafe bool ExcTemperatureEventNotify
    {
      [Register("getExcTemperatureEventNotify", "()Z", "GetGetExcTemperatureEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcTemperatureEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcTemperatureEventNotify", "(Z)V", "GetSetExcTemperatureEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcTemperatureEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcWpaEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExcWpaEventNotify == null)
        Command_ProtocolConfig.cb_getExcWpaEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExcWpaEventNotify));
      return Command_ProtocolConfig.cb_getExcWpaEventNotify;
    }

    private static bool n_GetExcWpaEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcWpaEventNotify;
    }

    private static Delegate GetSetExcWpaEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExcWpaEventNotify_Z == null)
        Command_ProtocolConfig.cb_setExcWpaEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExcWpaEventNotify_Z));
      return Command_ProtocolConfig.cb_setExcWpaEventNotify_Z;
    }

    private static void n_SetExcWpaEventNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcWpaEventNotify = value;
    }

    public virtual unsafe bool ExcWpaEventNotify
    {
      [Register("getExcWpaEventNotify", "()Z", "GetGetExcWpaEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcWpaEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcWpaEventNotify", "(Z)V", "GetSetExcWpaEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcWpaEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExctriggereventnotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getExctriggereventnotify == null)
        Command_ProtocolConfig.cb_getExctriggereventnotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetExctriggereventnotify));
      return Command_ProtocolConfig.cb_getExctriggereventnotify;
    }

    private static bool n_GetExctriggereventnotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).Exctriggereventnotify;
    }

    private static Delegate GetSetExctriggereventnotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setExctriggereventnotify_Z == null)
        Command_ProtocolConfig.cb_setExctriggereventnotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetExctriggereventnotify_Z));
      return Command_ProtocolConfig.cb_setExctriggereventnotify_Z;
    }

    private static void n_SetExctriggereventnotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).Exctriggereventnotify = value;
    }

    public virtual unsafe bool Exctriggereventnotify
    {
      [Register("getExctriggereventnotify", "()Z", "GetGetExctriggereventnotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExctriggereventnotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExctriggereventnotify", "(Z)V", "GetSetExctriggereventnotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExctriggereventnotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncBatchmodeEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncBatchmodeEventNotify == null)
        Command_ProtocolConfig.cb_getIncBatchmodeEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncBatchmodeEventNotify));
      return Command_ProtocolConfig.cb_getIncBatchmodeEventNotify;
    }

    private static bool n_GetIncBatchmodeEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncBatchmodeEventNotify;
    }

    private static Delegate GetSetIncBatchmodeEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncBatchmodeEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncBatchmodeEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncBatchmodeEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncBatchmodeEventNotify_Z;
    }

    private static void n_SetIncBatchmodeEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncBatchmodeEventNotify = value;
    }

    public virtual unsafe bool IncBatchmodeEventNotify
    {
      [Register("getIncBatchmodeEventNotify", "()Z", "GetGetIncBatchmodeEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncBatchmodeEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncBatchmodeEventNotify", "(Z)V", "GetSetIncBatchmodeEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncBatchmodeEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncBatteryEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncBatteryEventNotify == null)
        Command_ProtocolConfig.cb_getIncBatteryEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncBatteryEventNotify));
      return Command_ProtocolConfig.cb_getIncBatteryEventNotify;
    }

    private static bool n_GetIncBatteryEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncBatteryEventNotify;
    }

    private static Delegate GetSetIncBatteryEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncBatteryEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncBatteryEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncBatteryEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncBatteryEventNotify_Z;
    }

    private static void n_SetIncBatteryEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncBatteryEventNotify = value;
    }

    public virtual unsafe bool IncBatteryEventNotify
    {
      [Register("getIncBatteryEventNotify", "()Z", "GetGetIncBatteryEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncBatteryEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncBatteryEventNotify", "(Z)V", "GetSetIncBatteryEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncBatteryEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncCRCHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncCRC == null)
        Command_ProtocolConfig.cb_getIncCRC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncCRC));
      return Command_ProtocolConfig.cb_getIncCRC;
    }

    private static bool n_GetIncCRC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncCRC;
    }

    private static Delegate GetSetIncCRC_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncCRC_Z == null)
        Command_ProtocolConfig.cb_setIncCRC_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncCRC_Z));
      return Command_ProtocolConfig.cb_setIncCRC_Z;
    }

    private static void n_SetIncCRC_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncCRC = value;
    }

    public virtual unsafe bool IncCRC
    {
      [Register("getIncCRC", "()Z", "GetGetIncCRCHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncCRC.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncCRC", "(Z)V", "GetSetIncCRC_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncCRC.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncDatabaseEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncDatabaseEventNotify == null)
        Command_ProtocolConfig.cb_getIncDatabaseEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncDatabaseEventNotify));
      return Command_ProtocolConfig.cb_getIncDatabaseEventNotify;
    }

    private static bool n_GetIncDatabaseEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncDatabaseEventNotify;
    }

    private static Delegate GetSetIncDatabaseEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncDatabaseEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncDatabaseEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncDatabaseEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncDatabaseEventNotify_Z;
    }

    private static void n_SetIncDatabaseEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncDatabaseEventNotify = value;
    }

    public virtual unsafe bool IncDatabaseEventNotify
    {
      [Register("getIncDatabaseEventNotify", "()Z", "GetGetIncDatabaseEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncDatabaseEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncDatabaseEventNotify", "(Z)V", "GetSetIncDatabaseEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncDatabaseEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncInvEndSummaryNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncInvEndSummaryNotify == null)
        Command_ProtocolConfig.cb_getIncInvEndSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncInvEndSummaryNotify));
      return Command_ProtocolConfig.cb_getIncInvEndSummaryNotify;
    }

    private static bool n_GetIncInvEndSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncInvEndSummaryNotify;
    }

    private static Delegate GetSetIncInvEndSummaryNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncInvEndSummaryNotify_Z == null)
        Command_ProtocolConfig.cb_setIncInvEndSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncInvEndSummaryNotify_Z));
      return Command_ProtocolConfig.cb_setIncInvEndSummaryNotify_Z;
    }

    private static void n_SetIncInvEndSummaryNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncInvEndSummaryNotify = value;
    }

    public virtual unsafe bool IncInvEndSummaryNotify
    {
      [Register("getIncInvEndSummaryNotify", "()Z", "GetGetIncInvEndSummaryNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncInvEndSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncInvEndSummaryNotify", "(Z)V", "GetSetIncInvEndSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncInvEndSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncOperEndSummaryNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncOperEndSummaryNotify == null)
        Command_ProtocolConfig.cb_getIncOperEndSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncOperEndSummaryNotify));
      return Command_ProtocolConfig.cb_getIncOperEndSummaryNotify;
    }

    private static bool n_GetIncOperEndSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncOperEndSummaryNotify;
    }

    private static Delegate GetSetIncOperEndSummaryNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncOperEndSummaryNotify_Z == null)
        Command_ProtocolConfig.cb_setIncOperEndSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncOperEndSummaryNotify_Z));
      return Command_ProtocolConfig.cb_setIncOperEndSummaryNotify_Z;
    }

    private static void n_SetIncOperEndSummaryNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncOperEndSummaryNotify = value;
    }

    public virtual unsafe bool IncOperEndSummaryNotify
    {
      [Register("getIncOperEndSummaryNotify", "()Z", "GetGetIncOperEndSummaryNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncOperEndSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncOperEndSummaryNotify", "(Z)V", "GetSetIncOperEndSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncOperEndSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncPowerEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncPowerEventNotify == null)
        Command_ProtocolConfig.cb_getIncPowerEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncPowerEventNotify));
      return Command_ProtocolConfig.cb_getIncPowerEventNotify;
    }

    private static bool n_GetIncPowerEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPowerEventNotify;
    }

    private static Delegate GetSetIncPowerEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncPowerEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncPowerEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncPowerEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncPowerEventNotify_Z;
    }

    private static void n_SetIncPowerEventNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPowerEventNotify = value;
    }

    public virtual unsafe bool IncPowerEventNotify
    {
      [Register("getIncPowerEventNotify", "()Z", "GetGetIncPowerEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncPowerEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncPowerEventNotify", "(Z)V", "GetSetIncPowerEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncPowerEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncRadioerrorEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncRadioerrorEventNotify == null)
        Command_ProtocolConfig.cb_getIncRadioerrorEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncRadioerrorEventNotify));
      return Command_ProtocolConfig.cb_getIncRadioerrorEventNotify;
    }

    private static bool n_GetIncRadioerrorEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncRadioerrorEventNotify;
    }

    private static Delegate GetSetIncRadioerrorEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncRadioerrorEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncRadioerrorEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncRadioerrorEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncRadioerrorEventNotify_Z;
    }

    private static void n_SetIncRadioerrorEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncRadioerrorEventNotify = value;
    }

    public virtual unsafe bool IncRadioerrorEventNotify
    {
      [Register("getIncRadioerrorEventNotify", "()Z", "GetGetIncRadioerrorEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncRadioerrorEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncRadioerrorEventNotify", "(Z)V", "GetSetIncRadioerrorEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncRadioerrorEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncStartOperationNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncStartOperationNotify == null)
        Command_ProtocolConfig.cb_getIncStartOperationNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncStartOperationNotify));
      return Command_ProtocolConfig.cb_getIncStartOperationNotify;
    }

    private static bool n_GetIncStartOperationNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncStartOperationNotify;
    }

    private static Delegate GetSetIncStartOperationNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncStartOperationNotify_Z == null)
        Command_ProtocolConfig.cb_setIncStartOperationNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncStartOperationNotify_Z));
      return Command_ProtocolConfig.cb_setIncStartOperationNotify_Z;
    }

    private static void n_SetIncStartOperationNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncStartOperationNotify = value;
    }

    public virtual unsafe bool IncStartOperationNotify
    {
      [Register("getIncStartOperationNotify", "()Z", "GetGetIncStartOperationNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncStartOperationNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncStartOperationNotify", "(Z)V", "GetSetIncStartOperationNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncStartOperationNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncStopOperationNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncStopOperationNotify == null)
        Command_ProtocolConfig.cb_getIncStopOperationNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncStopOperationNotify));
      return Command_ProtocolConfig.cb_getIncStopOperationNotify;
    }

    private static bool n_GetIncStopOperationNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncStopOperationNotify;
    }

    private static Delegate GetSetIncStopOperationNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncStopOperationNotify_Z == null)
        Command_ProtocolConfig.cb_setIncStopOperationNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncStopOperationNotify_Z));
      return Command_ProtocolConfig.cb_setIncStopOperationNotify_Z;
    }

    private static void n_SetIncStopOperationNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncStopOperationNotify = value;
    }

    public virtual unsafe bool IncStopOperationNotify
    {
      [Register("getIncStopOperationNotify", "()Z", "GetGetIncStopOperationNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncStopOperationNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncStopOperationNotify", "(Z)V", "GetSetIncStopOperationNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncStopOperationNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncTemperatureEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncTemperatureEventNotify == null)
        Command_ProtocolConfig.cb_getIncTemperatureEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncTemperatureEventNotify));
      return Command_ProtocolConfig.cb_getIncTemperatureEventNotify;
    }

    private static bool n_GetIncTemperatureEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncTemperatureEventNotify;
    }

    private static Delegate GetSetIncTemperatureEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncTemperatureEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncTemperatureEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncTemperatureEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncTemperatureEventNotify_Z;
    }

    private static void n_SetIncTemperatureEventNotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncTemperatureEventNotify = value;
    }

    public virtual unsafe bool IncTemperatureEventNotify
    {
      [Register("getIncTemperatureEventNotify", "()Z", "GetGetIncTemperatureEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncTemperatureEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncTemperatureEventNotify", "(Z)V", "GetSetIncTemperatureEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncTemperatureEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncWpaEventNotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getIncWpaEventNotify == null)
        Command_ProtocolConfig.cb_getIncWpaEventNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetIncWpaEventNotify));
      return Command_ProtocolConfig.cb_getIncWpaEventNotify;
    }

    private static bool n_GetIncWpaEventNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncWpaEventNotify;
    }

    private static Delegate GetSetIncWpaEventNotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setIncWpaEventNotify_Z == null)
        Command_ProtocolConfig.cb_setIncWpaEventNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetIncWpaEventNotify_Z));
      return Command_ProtocolConfig.cb_setIncWpaEventNotify_Z;
    }

    private static void n_SetIncWpaEventNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncWpaEventNotify = value;
    }

    public virtual unsafe bool IncWpaEventNotify
    {
      [Register("getIncWpaEventNotify", "()Z", "GetGetIncWpaEventNotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncWpaEventNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncWpaEventNotify", "(Z)V", "GetSetIncWpaEventNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncWpaEventNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetInctriggereventnotifyHandler()
    {
      if ((object) Command_ProtocolConfig.cb_getInctriggereventnotify == null)
        Command_ProtocolConfig.cb_getInctriggereventnotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_ProtocolConfig.n_GetInctriggereventnotify));
      return Command_ProtocolConfig.cb_getInctriggereventnotify;
    }

    private static bool n_GetInctriggereventnotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).Inctriggereventnotify;
    }

    private static Delegate GetSetInctriggereventnotify_ZHandler()
    {
      if ((object) Command_ProtocolConfig.cb_setInctriggereventnotify_Z == null)
        Command_ProtocolConfig.cb_setInctriggereventnotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_ProtocolConfig.n_SetInctriggereventnotify_Z));
      return Command_ProtocolConfig.cb_setInctriggereventnotify_Z;
    }

    private static void n_SetInctriggereventnotify_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).Inctriggereventnotify = value;
    }

    public virtual unsafe bool Inctriggereventnotify
    {
      [Register("getInctriggereventnotify", "()Z", "GetGetInctriggereventnotifyHandler")] get
      {
        return Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getInctriggereventnotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setInctriggereventnotify", "(Z)V", "GetSetInctriggereventnotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setInctriggereventnotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_ProtocolConfig.cb_FromString_Ljava_lang_String_ == null)
        Command_ProtocolConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_ProtocolConfig.n_FromString_Ljava_lang_String_));
      return Command_ProtocolConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_ProtocolConfig.cb_ToString == null)
        Command_ProtocolConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_ProtocolConfig.n_ToString));
      return Command_ProtocolConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_ProtocolConfig>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_ProtocolConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
