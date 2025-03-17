// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetKeyMap
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Com.Zebra.Rfid.Api3;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/Command_SetKeyMap", DoNotGenerateAcw = true)]
  public class Command_SetKeyMap : Command
  {
    [Register("commandName")]
    public const string CommandName = "keymap";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetKeyMap", typeof (Command_SetKeyMap));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getdefaults;
    private static Delegate? cb_getkeylayoutType;
    private static Delegate? cb_setdefaults_Z;
    private static Delegate? cb_setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetKeyMap._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetKeyMap._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetKeyMap._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetKeyMap._members.ManagedPeerType;

    protected Command_SetKeyMap(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetKeyMap()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetKeyMap._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetKeyMap._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetKeyMap.cb_getCommandType == null)
        Command_SetKeyMap.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetKeyMap.n_GetCommandType));
      return Command_SetKeyMap.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetKeyMap._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetKeyMap.cb_FromString_Ljava_lang_String_ == null)
        Command_SetKeyMap.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetKeyMap.n_FromString_Ljava_lang_String_));
      return Command_SetKeyMap.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetKeyMap._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetKeyMap.cb_ToString == null)
        Command_SetKeyMap.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetKeyMap.n_ToString));
      return Command_SetKeyMap.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetKeyMap._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetdefaultsHandler()
    {
      if ((object) Command_SetKeyMap.cb_getdefaults == null)
        Command_SetKeyMap.cb_getdefaults = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_SetKeyMap.n_Getdefaults));
      return Command_SetKeyMap.cb_getdefaults;
    }

    private static bool n_Getdefaults(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).Getdefaults();
    }

    [Register("getdefaults", "()Z", "GetGetdefaultsHandler")]
    public virtual unsafe bool Getdefaults()
    {
      return Command_SetKeyMap._members.InstanceMethods.InvokeVirtualBooleanMethod("getdefaults.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetkeylayoutTypeHandler()
    {
      if ((object) Command_SetKeyMap.cb_getkeylayoutType == null)
        Command_SetKeyMap.cb_getkeylayoutType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetKeyMap.n_GetkeylayoutType));
      return Command_SetKeyMap.cb_getkeylayoutType;
    }

    private static IntPtr n_GetkeylayoutType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).GetkeylayoutType());
    }

    [Register("getkeylayoutType", "()Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", "GetGetkeylayoutTypeHandler")]
    public virtual unsafe ENUM_KEYLAYOUT_TYPE? GetkeylayoutType()
    {
      JniObjectReference jniObjectReference = Command_SetKeyMap._members.InstanceMethods.InvokeVirtualObjectMethod("getkeylayoutType.()Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetdefaults_ZHandler()
    {
      if ((object) Command_SetKeyMap.cb_setdefaults_Z == null)
        Command_SetKeyMap.cb_setdefaults_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_SetKeyMap.n_Setdefaults_Z));
      return Command_SetKeyMap.cb_setdefaults_Z;
    }

    private static void n_Setdefaults_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).Setdefaults(value);
    }

    [Register("setdefaults", "(Z)V", "GetSetdefaults_ZHandler")]
    public virtual unsafe void Setdefaults(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetKeyMap._members.InstanceMethods.InvokeVirtualVoidMethod("setdefaults.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_Handler()
    {
      if ((object) Command_SetKeyMap.cb_setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_ == null)
        Command_SetKeyMap.cb_setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetKeyMap.n_Setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_));
      return Command_SetKeyMap.cb_setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_;
    }

    private static void n_Setkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetKeyMap>(jnienv, native__this, (JniHandleOwnership) 0).Setkeylayout(Object.GetObject<ENUM_KEYLAYOUT_TYPE>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setkeylayout", "(Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;)V", "GetSetkeylayout_Lcom_zebra_rfid_api3_ENUM_KEYLAYOUT_TYPE_Handler")]
    public virtual unsafe void Setkeylayout(ENUM_KEYLAYOUT_TYPE? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        Command_SetKeyMap._members.InstanceMethods.InvokeVirtualVoidMethod("setkeylayout.(Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }
  }
}
