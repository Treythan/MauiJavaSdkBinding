// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetStopTrigger
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
  [Register("com/zebra/ASCII_SDK/Command_SetStopTrigger", DoNotGenerateAcw = true)]
  public class Command_SetStopTrigger : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetStopTrigger";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetStopTrigger", typeof (Command_SetStopTrigger));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getDisableStopOnAccessCount;
    private static Delegate? cb_setDisableStopOnAccessCount_Z;
    private static Delegate? cb_getDisableStopOnTimeout;
    private static Delegate? cb_setDisableStopOnTimeout_Z;
    private static Delegate? cb_getDisableStopOntagcount;
    private static Delegate? cb_setDisableStopOntagcount_Z;
    private static Delegate? cb_getDisableStoponInventoryCount;
    private static Delegate? cb_setDisableStoponInventoryCount_Z;
    private static Delegate? cb_getEnableStopOnInventoryCount;
    private static Delegate? cb_setEnableStopOnInventoryCount_Z;
    private static Delegate? cb_getEnableStopOnTimeout;
    private static Delegate? cb_setEnableStopOnTimeout_Z;
    private static Delegate? cb_getEnableStopOntagcount;
    private static Delegate? cb_setEnableStopOntagcount_Z;
    private static Delegate? cb_getIgnoreHandHeldTrigger;
    private static Delegate? cb_setIgnoreHandHeldTrigger_Z;
    private static Delegate? cb_getStopAccessCount;
    private static Delegate? cb_setStopAccessCount_I;
    private static Delegate? cb_getStopInventoryCount;
    private static Delegate? cb_setStopInventoryCount_J;
    private static Delegate? cb_getStopOnHandHeldTrigger;
    private static Delegate? cb_setStopOnHandHeldTrigger_Z;
    private static Delegate? cb_getStopTagCount;
    private static Delegate? cb_setStopTagCount_J;
    private static Delegate? cb_getStopTimeout;
    private static Delegate? cb_setStopTimeout_J;
    private static Delegate? cb_getTriggerType;
    private static Delegate? cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getenableStopOnAccessCount;
    private static Delegate? cb_setenableStopOnAccessCount_Z;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetStopTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetStopTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetStopTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetStopTrigger._members.ManagedPeerType;

    protected Command_SetStopTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetStopTrigger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetStopTrigger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetStopTrigger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getCommandType == null)
        Command_SetStopTrigger.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStopTrigger.n_GetCommandType));
      return Command_SetStopTrigger.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetDisableStopOnAccessCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getDisableStopOnAccessCount == null)
        Command_SetStopTrigger.cb_getDisableStopOnAccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetDisableStopOnAccessCount));
      return Command_SetStopTrigger.cb_getDisableStopOnAccessCount;
    }

    private static bool n_GetDisableStopOnAccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOnAccessCount;
    }

    private static Delegate GetSetDisableStopOnAccessCount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setDisableStopOnAccessCount_Z == null)
        Command_SetStopTrigger.cb_setDisableStopOnAccessCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetDisableStopOnAccessCount_Z));
      return Command_SetStopTrigger.cb_setDisableStopOnAccessCount_Z;
    }

    private static void n_SetDisableStopOnAccessCount_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOnAccessCount = value;
    }

    public virtual unsafe bool DisableStopOnAccessCount
    {
      [Register("getDisableStopOnAccessCount", "()Z", "GetGetDisableStopOnAccessCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableStopOnAccessCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableStopOnAccessCount", "(Z)V", "GetSetDisableStopOnAccessCount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableStopOnAccessCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDisableStopOnTimeoutHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getDisableStopOnTimeout == null)
        Command_SetStopTrigger.cb_getDisableStopOnTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetDisableStopOnTimeout));
      return Command_SetStopTrigger.cb_getDisableStopOnTimeout;
    }

    private static bool n_GetDisableStopOnTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOnTimeout;
    }

    private static Delegate GetSetDisableStopOnTimeout_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setDisableStopOnTimeout_Z == null)
        Command_SetStopTrigger.cb_setDisableStopOnTimeout_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetDisableStopOnTimeout_Z));
      return Command_SetStopTrigger.cb_setDisableStopOnTimeout_Z;
    }

    private static void n_SetDisableStopOnTimeout_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOnTimeout = value;
    }

    public virtual unsafe bool DisableStopOnTimeout
    {
      [Register("getDisableStopOnTimeout", "()Z", "GetGetDisableStopOnTimeoutHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableStopOnTimeout.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableStopOnTimeout", "(Z)V", "GetSetDisableStopOnTimeout_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableStopOnTimeout.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDisableStopOntagcountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getDisableStopOntagcount == null)
        Command_SetStopTrigger.cb_getDisableStopOntagcount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetDisableStopOntagcount));
      return Command_SetStopTrigger.cb_getDisableStopOntagcount;
    }

    private static bool n_GetDisableStopOntagcount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOntagcount;
    }

    private static Delegate GetSetDisableStopOntagcount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setDisableStopOntagcount_Z == null)
        Command_SetStopTrigger.cb_setDisableStopOntagcount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetDisableStopOntagcount_Z));
      return Command_SetStopTrigger.cb_setDisableStopOntagcount_Z;
    }

    private static void n_SetDisableStopOntagcount_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStopOntagcount = value;
    }

    public virtual unsafe bool DisableStopOntagcount
    {
      [Register("getDisableStopOntagcount", "()Z", "GetGetDisableStopOntagcountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableStopOntagcount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableStopOntagcount", "(Z)V", "GetSetDisableStopOntagcount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableStopOntagcount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDisableStoponInventoryCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getDisableStoponInventoryCount == null)
        Command_SetStopTrigger.cb_getDisableStoponInventoryCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetDisableStoponInventoryCount));
      return Command_SetStopTrigger.cb_getDisableStoponInventoryCount;
    }

    private static bool n_GetDisableStoponInventoryCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStoponInventoryCount;
    }

    private static Delegate GetSetDisableStoponInventoryCount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setDisableStoponInventoryCount_Z == null)
        Command_SetStopTrigger.cb_setDisableStoponInventoryCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetDisableStoponInventoryCount_Z));
      return Command_SetStopTrigger.cb_setDisableStoponInventoryCount_Z;
    }

    private static void n_SetDisableStoponInventoryCount_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).DisableStoponInventoryCount = value;
    }

    public virtual unsafe bool DisableStoponInventoryCount
    {
      [Register("getDisableStoponInventoryCount", "()Z", "GetGetDisableStoponInventoryCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableStoponInventoryCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableStoponInventoryCount", "(Z)V", "GetSetDisableStoponInventoryCount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableStoponInventoryCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableStopOnInventoryCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getEnableStopOnInventoryCount == null)
        Command_SetStopTrigger.cb_getEnableStopOnInventoryCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetEnableStopOnInventoryCount));
      return Command_SetStopTrigger.cb_getEnableStopOnInventoryCount;
    }

    private static bool n_GetEnableStopOnInventoryCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOnInventoryCount;
    }

    private static Delegate GetSetEnableStopOnInventoryCount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setEnableStopOnInventoryCount_Z == null)
        Command_SetStopTrigger.cb_setEnableStopOnInventoryCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetEnableStopOnInventoryCount_Z));
      return Command_SetStopTrigger.cb_setEnableStopOnInventoryCount_Z;
    }

    private static void n_SetEnableStopOnInventoryCount_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOnInventoryCount = value;
    }

    public virtual unsafe bool EnableStopOnInventoryCount
    {
      [Register("getEnableStopOnInventoryCount", "()Z", "GetGetEnableStopOnInventoryCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableStopOnInventoryCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableStopOnInventoryCount", "(Z)V", "GetSetEnableStopOnInventoryCount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableStopOnInventoryCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableStopOnTimeoutHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getEnableStopOnTimeout == null)
        Command_SetStopTrigger.cb_getEnableStopOnTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetEnableStopOnTimeout));
      return Command_SetStopTrigger.cb_getEnableStopOnTimeout;
    }

    private static bool n_GetEnableStopOnTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOnTimeout;
    }

    private static Delegate GetSetEnableStopOnTimeout_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setEnableStopOnTimeout_Z == null)
        Command_SetStopTrigger.cb_setEnableStopOnTimeout_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetEnableStopOnTimeout_Z));
      return Command_SetStopTrigger.cb_setEnableStopOnTimeout_Z;
    }

    private static void n_SetEnableStopOnTimeout_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOnTimeout = value;
    }

    public virtual unsafe bool EnableStopOnTimeout
    {
      [Register("getEnableStopOnTimeout", "()Z", "GetGetEnableStopOnTimeoutHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableStopOnTimeout.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableStopOnTimeout", "(Z)V", "GetSetEnableStopOnTimeout_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableStopOnTimeout.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableStopOntagcountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getEnableStopOntagcount == null)
        Command_SetStopTrigger.cb_getEnableStopOntagcount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetEnableStopOntagcount));
      return Command_SetStopTrigger.cb_getEnableStopOntagcount;
    }

    private static bool n_GetEnableStopOntagcount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOntagcount;
    }

    private static Delegate GetSetEnableStopOntagcount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setEnableStopOntagcount_Z == null)
        Command_SetStopTrigger.cb_setEnableStopOntagcount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetEnableStopOntagcount_Z));
      return Command_SetStopTrigger.cb_setEnableStopOntagcount_Z;
    }

    private static void n_SetEnableStopOntagcount_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).EnableStopOntagcount = value;
    }

    public virtual unsafe bool EnableStopOntagcount
    {
      [Register("getEnableStopOntagcount", "()Z", "GetGetEnableStopOntagcountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableStopOntagcount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableStopOntagcount", "(Z)V", "GetSetEnableStopOntagcount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableStopOntagcount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIgnoreHandHeldTriggerHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getIgnoreHandHeldTrigger == null)
        Command_SetStopTrigger.cb_getIgnoreHandHeldTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetIgnoreHandHeldTrigger));
      return Command_SetStopTrigger.cb_getIgnoreHandHeldTrigger;
    }

    private static bool n_GetIgnoreHandHeldTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).IgnoreHandHeldTrigger;
    }

    private static Delegate GetSetIgnoreHandHeldTrigger_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setIgnoreHandHeldTrigger_Z == null)
        Command_SetStopTrigger.cb_setIgnoreHandHeldTrigger_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetIgnoreHandHeldTrigger_Z));
      return Command_SetStopTrigger.cb_setIgnoreHandHeldTrigger_Z;
    }

    private static void n_SetIgnoreHandHeldTrigger_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).IgnoreHandHeldTrigger = value;
    }

    public virtual unsafe bool IgnoreHandHeldTrigger
    {
      [Register("getIgnoreHandHeldTrigger", "()Z", "GetGetIgnoreHandHeldTriggerHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getIgnoreHandHeldTrigger.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIgnoreHandHeldTrigger", "(Z)V", "GetSetIgnoreHandHeldTrigger_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setIgnoreHandHeldTrigger.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStopAccessCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getStopAccessCount == null)
        Command_SetStopTrigger.cb_getStopAccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetStopTrigger.n_GetStopAccessCount));
      return Command_SetStopTrigger.cb_getStopAccessCount;
    }

    private static int n_GetStopAccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopAccessCount;
    }

    private static Delegate GetSetStopAccessCount_IHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setStopAccessCount_I == null)
        Command_SetStopTrigger.cb_setStopAccessCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetStopTrigger.n_SetStopAccessCount_I));
      return Command_SetStopTrigger.cb_setStopAccessCount_I;
    }

    private static void n_SetStopAccessCount_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopAccessCount = value;
    }

    public virtual unsafe int StopAccessCount
    {
      [Register("getStopAccessCount", "()I", "GetGetStopAccessCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualInt32Method("getStopAccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStopAccessCount", "(I)V", "GetSetStopAccessCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopAccessCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStopInventoryCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getStopInventoryCount == null)
        Command_SetStopTrigger.cb_getStopInventoryCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_SetStopTrigger.n_GetStopInventoryCount));
      return Command_SetStopTrigger.cb_getStopInventoryCount;
    }

    private static long n_GetStopInventoryCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopInventoryCount;
    }

    private static Delegate GetSetStopInventoryCount_JHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setStopInventoryCount_J == null)
        Command_SetStopTrigger.cb_setStopInventoryCount_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_SetStopTrigger.n_SetStopInventoryCount_J));
      return Command_SetStopTrigger.cb_setStopInventoryCount_J;
    }

    private static void n_SetStopInventoryCount_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopInventoryCount = value;
    }

    public virtual unsafe long StopInventoryCount
    {
      [Register("getStopInventoryCount", "()J", "GetGetStopInventoryCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualInt64Method("getStopInventoryCount.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStopInventoryCount", "(J)V", "GetSetStopInventoryCount_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopInventoryCount.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStopOnHandHeldTriggerHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getStopOnHandHeldTrigger == null)
        Command_SetStopTrigger.cb_getStopOnHandHeldTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetStopOnHandHeldTrigger));
      return Command_SetStopTrigger.cb_getStopOnHandHeldTrigger;
    }

    private static bool n_GetStopOnHandHeldTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopOnHandHeldTrigger;
    }

    private static Delegate GetSetStopOnHandHeldTrigger_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setStopOnHandHeldTrigger_Z == null)
        Command_SetStopTrigger.cb_setStopOnHandHeldTrigger_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetStopOnHandHeldTrigger_Z));
      return Command_SetStopTrigger.cb_setStopOnHandHeldTrigger_Z;
    }

    private static void n_SetStopOnHandHeldTrigger_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopOnHandHeldTrigger = value;
    }

    public virtual unsafe bool StopOnHandHeldTrigger
    {
      [Register("getStopOnHandHeldTrigger", "()Z", "GetGetStopOnHandHeldTriggerHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getStopOnHandHeldTrigger.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStopOnHandHeldTrigger", "(Z)V", "GetSetStopOnHandHeldTrigger_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopOnHandHeldTrigger.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStopTagCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getStopTagCount == null)
        Command_SetStopTrigger.cb_getStopTagCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_SetStopTrigger.n_GetStopTagCount));
      return Command_SetStopTrigger.cb_getStopTagCount;
    }

    private static long n_GetStopTagCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTagCount;
    }

    private static Delegate GetSetStopTagCount_JHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setStopTagCount_J == null)
        Command_SetStopTrigger.cb_setStopTagCount_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_SetStopTrigger.n_SetStopTagCount_J));
      return Command_SetStopTrigger.cb_setStopTagCount_J;
    }

    private static void n_SetStopTagCount_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTagCount = value;
    }

    public virtual unsafe long StopTagCount
    {
      [Register("getStopTagCount", "()J", "GetGetStopTagCountHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualInt64Method("getStopTagCount.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStopTagCount", "(J)V", "GetSetStopTagCount_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopTagCount.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStopTimeoutHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getStopTimeout == null)
        Command_SetStopTrigger.cb_getStopTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_SetStopTrigger.n_GetStopTimeout));
      return Command_SetStopTrigger.cb_getStopTimeout;
    }

    private static long n_GetStopTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTimeout;
    }

    private static Delegate GetSetStopTimeout_JHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setStopTimeout_J == null)
        Command_SetStopTrigger.cb_setStopTimeout_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_SetStopTrigger.n_SetStopTimeout_J));
      return Command_SetStopTrigger.cb_setStopTimeout_J;
    }

    private static void n_SetStopTimeout_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).StopTimeout = value;
    }

    public virtual unsafe long StopTimeout
    {
      [Register("getStopTimeout", "()J", "GetGetStopTimeoutHandler")] get
      {
        return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualInt64Method("getStopTimeout.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStopTimeout", "(J)V", "GetSetStopTimeout_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setStopTimeout.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTriggerTypeHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getTriggerType == null)
        Command_SetStopTrigger.cb_getTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStopTrigger.n_GetTriggerType));
      return Command_SetStopTrigger.cb_getTriggerType;
    }

    private static IntPtr n_GetTriggerType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType);
    }

    private static Delegate GetSetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_Handler()
    {
      if ((object) Command_SetStopTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_ == null)
        Command_SetStopTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetStopTrigger.n_SetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_));
      return Command_SetStopTrigger.cb_setTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_;
    }

    private static void n_SetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).TriggerType = Object.GetObject<ENUM_TRIGGER_ID>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_TRIGGER_ID? TriggerType
    {
      [Register("getTriggerType", "()Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", "GetGetTriggerTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("getTriggerType.()Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_TRIGGER_ID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTriggerType", "(Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;)V", "GetSetTriggerType_Lcom_zebra_ASCII_SDK_ENUM_TRIGGER_ID_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setTriggerType.(Lcom/zebra/ASCII_SDK/ENUM_TRIGGER_ID;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetStopTrigger.cb_FromString_Ljava_lang_String_ == null)
        Command_SetStopTrigger.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetStopTrigger.n_FromString_Ljava_lang_String_));
      return Command_SetStopTrigger.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetStopTrigger.cb_ToString == null)
        Command_SetStopTrigger.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetStopTrigger.n_ToString));
      return Command_SetStopTrigger.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetenableStopOnAccessCountHandler()
    {
      if ((object) Command_SetStopTrigger.cb_getenableStopOnAccessCount == null)
        Command_SetStopTrigger.cb_getenableStopOnAccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetStopTrigger.n_GetenableStopOnAccessCount));
      return Command_SetStopTrigger.cb_getenableStopOnAccessCount;
    }

    private static bool n_GetenableStopOnAccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).GetenableStopOnAccessCount();
    }

    [Register("getenableStopOnAccessCount", "()Z", "GetGetenableStopOnAccessCountHandler")]
    public virtual unsafe bool GetenableStopOnAccessCount()
    {
      return Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualBooleanMethod("getenableStopOnAccessCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetenableStopOnAccessCount_ZHandler()
    {
      if ((object) Command_SetStopTrigger.cb_setenableStopOnAccessCount_Z == null)
        Command_SetStopTrigger.cb_setenableStopOnAccessCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetStopTrigger.n_SetenableStopOnAccessCount_Z));
      return Command_SetStopTrigger.cb_setenableStopOnAccessCount_Z;
    }

    private static void n_SetenableStopOnAccessCount_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool value)
    {
      Object.GetObject<Command_SetStopTrigger>(jnienv, native__this, (JniHandleOwnership) 0).SetenableStopOnAccessCount(value);
    }

    [Register("setenableStopOnAccessCount", "(Z)V", "GetSetenableStopOnAccessCount_ZHandler")]
    public virtual unsafe void SetenableStopOnAccessCount(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetStopTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setenableStopOnAccessCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
