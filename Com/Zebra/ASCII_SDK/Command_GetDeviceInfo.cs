// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_GetDeviceInfo
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
  [Register("com/zebra/ASCII_SDK/Command_GetDeviceInfo", DoNotGenerateAcw = true)]
  public class Command_GetDeviceInfo : Command
  {
    [Register("commandName")]
    public const string CommandName = "GetDeviceInfo";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_GetDeviceInfo", typeof (Command_GetDeviceInfo));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getOnCradleStatus;
    private static Delegate? cb_getTrigger;
    private static Delegate? cb_setTrigger_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getbattery;
    private static Delegate? cb_getpower;
    private static Delegate? cb_gettemperature;
    private static Delegate? cb_setCradleStatus_Z;
    private static Delegate? cb_setbattery_Z;
    private static Delegate? cb_setpower_Z;
    private static Delegate? cb_settemperature_Z;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_GetDeviceInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_GetDeviceInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_GetDeviceInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_GetDeviceInfo._members.ManagedPeerType;

    protected Command_GetDeviceInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_GetDeviceInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_GetDeviceInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_GetDeviceInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_getCommandType == null)
        Command_GetDeviceInfo.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_GetDeviceInfo.n_GetCommandType));
      return Command_GetDeviceInfo.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetOnCradleStatusHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_getOnCradleStatus == null)
        Command_GetDeviceInfo.cb_getOnCradleStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_GetDeviceInfo.n_GetOnCradleStatus));
      return Command_GetDeviceInfo.cb_getOnCradleStatus;
    }

    private static bool n_GetOnCradleStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).OnCradleStatus;
    }

    public virtual unsafe bool OnCradleStatus
    {
      [Register("getOnCradleStatus", "()Z", "GetGetOnCradleStatusHandler")] get
      {
        return Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getOnCradleStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTriggerHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_getTrigger == null)
        Command_GetDeviceInfo.cb_getTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_GetDeviceInfo.n_GetTrigger));
      return Command_GetDeviceInfo.cb_getTrigger;
    }

    private static bool n_GetTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Trigger;
    }

    private static Delegate GetSetTrigger_ZHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_setTrigger_Z == null)
        Command_GetDeviceInfo.cb_setTrigger_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_GetDeviceInfo.n_SetTrigger_Z));
      return Command_GetDeviceInfo.cb_setTrigger_Z;
    }

    private static void n_SetTrigger_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Trigger = value;
    }

    public virtual unsafe bool Trigger
    {
      [Register("getTrigger", "()Z", "GetGetTriggerHandler")] get
      {
        return Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getTrigger.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTrigger", "(Z)V", "GetSetTrigger_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setTrigger.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_GetDeviceInfo.cb_FromString_Ljava_lang_String_ == null)
        Command_GetDeviceInfo.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_GetDeviceInfo.n_FromString_Ljava_lang_String_));
      return Command_GetDeviceInfo.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_ToString == null)
        Command_GetDeviceInfo.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_GetDeviceInfo.n_ToString));
      return Command_GetDeviceInfo.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetbatteryHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_getbattery == null)
        Command_GetDeviceInfo.cb_getbattery = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_GetDeviceInfo.n_Getbattery));
      return Command_GetDeviceInfo.cb_getbattery;
    }

    private static bool n_Getbattery(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Getbattery();
    }

    [Register("getbattery", "()Z", "GetGetbatteryHandler")]
    public virtual unsafe bool Getbattery()
    {
      return Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getbattery.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetpowerHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_getpower == null)
        Command_GetDeviceInfo.cb_getpower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_GetDeviceInfo.n_Getpower));
      return Command_GetDeviceInfo.cb_getpower;
    }

    private static bool n_Getpower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Getpower();
    }

    [Register("getpower", "()Z", "GetGetpowerHandler")]
    public virtual unsafe bool Getpower()
    {
      return Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getpower.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGettemperatureHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_gettemperature == null)
        Command_GetDeviceInfo.cb_gettemperature = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_GetDeviceInfo.n_Gettemperature));
      return Command_GetDeviceInfo.cb_gettemperature;
    }

    private static bool n_Gettemperature(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Gettemperature();
    }

    [Register("gettemperature", "()Z", "GetGettemperatureHandler")]
    public virtual unsafe bool Gettemperature()
    {
      return Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("gettemperature.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetCradleStatus_ZHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_setCradleStatus_Z == null)
        Command_GetDeviceInfo.cb_setCradleStatus_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_GetDeviceInfo.n_SetCradleStatus_Z));
      return Command_GetDeviceInfo.cb_setCradleStatus_Z;
    }

    private static void n_SetCradleStatus_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetCradleStatus(value);
    }

    [Register("setCradleStatus", "(Z)V", "GetSetCradleStatus_ZHandler")]
    public virtual unsafe void SetCradleStatus(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setCradleStatus.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetbattery_ZHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_setbattery_Z == null)
        Command_GetDeviceInfo.cb_setbattery_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_GetDeviceInfo.n_Setbattery_Z));
      return Command_GetDeviceInfo.cb_setbattery_Z;
    }

    private static void n_Setbattery_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Setbattery(value);
    }

    [Register("setbattery", "(Z)V", "GetSetbattery_ZHandler")]
    public virtual unsafe void Setbattery(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setbattery.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetpower_ZHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_setpower_Z == null)
        Command_GetDeviceInfo.cb_setpower_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_GetDeviceInfo.n_Setpower_Z));
      return Command_GetDeviceInfo.cb_setpower_Z;
    }

    private static void n_Setpower_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Setpower(value);
    }

    [Register("setpower", "(Z)V", "GetSetpower_ZHandler")]
    public virtual unsafe void Setpower(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setpower.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSettemperature_ZHandler()
    {
      if ((object) Command_GetDeviceInfo.cb_settemperature_Z == null)
        Command_GetDeviceInfo.cb_settemperature_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_GetDeviceInfo.n_Settemperature_Z));
      return Command_GetDeviceInfo.cb_settemperature_Z;
    }

    private static void n_Settemperature_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_GetDeviceInfo>(jnienv, native__this, (JniHandleOwnership) 0).Settemperature(value);
    }

    [Register("settemperature", "(Z)V", "GetSettemperature_ZHandler")]
    public virtual unsafe void Settemperature(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_GetDeviceInfo._members.InstanceMethods.InvokeVirtualVoidMethod("settemperature.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
