// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_LocateTag
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
  [Register("com/zebra/ASCII_SDK/Command_LocateTag", DoNotGenerateAcw = true)]
  public class Command_LocateTag : Command
  {
    [Register("commandName")]
    public const string CommandName = "LocateTag";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_LocateTag", typeof (Command_LocateTag));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getMultiEnable;
    private static Delegate? cb_setMultiEnable_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getepc;
    private static Delegate? cb_getepm;
    private static Delegate? cb_getversion;
    private static Delegate? cb_setepc_arrayB;
    private static Delegate? cb_setepm_arrayB;
    private static Delegate? cb_setversion_S;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_LocateTag._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_LocateTag._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_LocateTag._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_LocateTag._members.ManagedPeerType;

    protected Command_LocateTag(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_LocateTag()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_LocateTag._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_LocateTag._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_LocateTag.cb_getCommandType == null)
        Command_LocateTag.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_LocateTag.n_GetCommandType));
      return Command_LocateTag.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_LocateTag._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetMultiEnableHandler()
    {
      if ((object) Command_LocateTag.cb_getMultiEnable == null)
        Command_LocateTag.cb_getMultiEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_LocateTag.n_GetMultiEnable));
      return Command_LocateTag.cb_getMultiEnable;
    }

    private static bool n_GetMultiEnable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).MultiEnable;
    }

    private static Delegate GetSetMultiEnable_ZHandler()
    {
      if ((object) Command_LocateTag.cb_setMultiEnable_Z == null)
        Command_LocateTag.cb_setMultiEnable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_LocateTag.n_SetMultiEnable_Z));
      return Command_LocateTag.cb_setMultiEnable_Z;
    }

    private static void n_SetMultiEnable_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).MultiEnable = value;
    }

    public virtual unsafe bool MultiEnable
    {
      [Register("getMultiEnable", "()Z", "GetGetMultiEnableHandler")] get
      {
        return Command_LocateTag._members.InstanceMethods.InvokeVirtualBooleanMethod("getMultiEnable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMultiEnable", "(Z)V", "GetSetMultiEnable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_LocateTag._members.InstanceMethods.InvokeVirtualVoidMethod("setMultiEnable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_LocateTag.cb_FromString_Ljava_lang_String_ == null)
        Command_LocateTag.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_LocateTag.n_FromString_Ljava_lang_String_));
      return Command_LocateTag.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_LocateTag._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_LocateTag.cb_ToString == null)
        Command_LocateTag.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_LocateTag.n_ToString));
      return Command_LocateTag.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_LocateTag._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetepcHandler()
    {
      if ((object) Command_LocateTag.cb_getepc == null)
        Command_LocateTag.cb_getepc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_LocateTag.n_Getepc));
      return Command_LocateTag.cb_getepc;
    }

    private static IntPtr n_Getepc(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).Getepc());
    }

    [Register("getepc", "()[B", "GetGetepcHandler")]
    public virtual unsafe byte[]? Getepc()
    {
      JniObjectReference jniObjectReference = Command_LocateTag._members.InstanceMethods.InvokeVirtualObjectMethod("getepc.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetepmHandler()
    {
      if ((object) Command_LocateTag.cb_getepm == null)
        Command_LocateTag.cb_getepm = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_LocateTag.n_Getepm));
      return Command_LocateTag.cb_getepm;
    }

    private static IntPtr n_Getepm(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).Getepm());
    }

    [Register("getepm", "()[B", "GetGetepmHandler")]
    public virtual unsafe byte[]? Getepm()
    {
      JniObjectReference jniObjectReference = Command_LocateTag._members.InstanceMethods.InvokeVirtualObjectMethod("getepm.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetversionHandler()
    {
      if ((object) Command_LocateTag.cb_getversion == null)
        Command_LocateTag.cb_getversion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_LocateTag.n_Getversion));
      return Command_LocateTag.cb_getversion;
    }

    private static short n_Getversion(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).Getversion();
    }

    [Register("getversion", "()S", "GetGetversionHandler")]
    public virtual unsafe short Getversion()
    {
      return Command_LocateTag._members.InstanceMethods.InvokeVirtualInt16Method("getversion.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetepc_arrayBHandler()
    {
      if ((object) Command_LocateTag.cb_setepc_arrayB == null)
        Command_LocateTag.cb_setepc_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_LocateTag.n_Setepc_arrayB));
      return Command_LocateTag.cb_setepc_arrayB;
    }

    private static void n_Setepc_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
    {
      Command_LocateTag commandLocateTag = Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      commandLocateTag.Setepc(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setepc", "([B)V", "GetSetepc_arrayBHandler")]
    public virtual unsafe void Setepc(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_LocateTag._members.InstanceMethods.InvokeVirtualVoidMethod("setepc.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetepm_arrayBHandler()
    {
      if ((object) Command_LocateTag.cb_setepm_arrayB == null)
        Command_LocateTag.cb_setepm_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_LocateTag.n_Setepm_arrayB));
      return Command_LocateTag.cb_setepm_arrayB;
    }

    private static void n_Setepm_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
    {
      Command_LocateTag commandLocateTag = Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      commandLocateTag.Setepm(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setepm", "([B)V", "GetSetepm_arrayBHandler")]
    public virtual unsafe void Setepm(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_LocateTag._members.InstanceMethods.InvokeVirtualVoidMethod("setepm.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetversion_SHandler()
    {
      if ((object) Command_LocateTag.cb_setversion_S == null)
        Command_LocateTag.cb_setversion_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_LocateTag.n_Setversion_S));
      return Command_LocateTag.cb_setversion_S;
    }

    private static void n_Setversion_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_LocateTag>(jnienv, native__this, (JniHandleOwnership) 0).Setversion(value);
    }

    [Register("setversion", "(S)V", "GetSetversion_SHandler")]
    public virtual unsafe void Setversion(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_LocateTag._members.InstanceMethods.InvokeVirtualVoidMethod("setversion.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
