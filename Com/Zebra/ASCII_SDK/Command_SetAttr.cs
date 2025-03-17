// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_SetAttr
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
  [Register("com/zebra/ASCII_SDK/Command_SetAttr", DoNotGenerateAcw = true)]
  public class Command_SetAttr : Command
  {
    [Register("commandName")]
    public const string CommandName = "SetAttr";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_SetAttr", typeof (Command_SetAttr));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getattnum;
    private static Delegate? cb_getatttype;
    private static Delegate? cb_getattvalue;
    private static Delegate? cb_getoffset;
    private static Delegate? cb_setattnum_I;
    private static Delegate? cb_setatttype_Ljava_lang_String_;
    private static Delegate? cb_setattvalue_Ljava_lang_String_;
    private static Delegate? cb_setoffset_I;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_SetAttr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_SetAttr._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_SetAttr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_SetAttr._members.ManagedPeerType;

    protected Command_SetAttr(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_SetAttr()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_SetAttr._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_SetAttr._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_SetAttr.cb_getCommandType == null)
        Command_SetAttr.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAttr.n_GetCommandType));
      return Command_SetAttr.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_SetAttr._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetAttr.cb_FromString_Ljava_lang_String_ == null)
        Command_SetAttr.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetAttr.n_FromString_Ljava_lang_String_));
      return Command_SetAttr.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_SetAttr._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_SetAttr.cb_ToString == null)
        Command_SetAttr.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAttr.n_ToString));
      return Command_SetAttr.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_SetAttr._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetattnumHandler()
    {
      if ((object) Command_SetAttr.cb_getattnum == null)
        Command_SetAttr.cb_getattnum = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetAttr.n_Getattnum));
      return Command_SetAttr.cb_getattnum;
    }

    private static int n_Getattnum(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Getattnum();
    }

    [Register("getattnum", "()I", "GetGetattnumHandler")]
    public virtual unsafe int Getattnum()
    {
      return Command_SetAttr._members.InstanceMethods.InvokeVirtualInt32Method("getattnum.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetatttypeHandler()
    {
      if ((object) Command_SetAttr.cb_getatttype == null)
        Command_SetAttr.cb_getatttype = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAttr.n_Getatttype));
      return Command_SetAttr.cb_getatttype;
    }

    private static IntPtr n_Getatttype(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Getatttype());
    }

    [Register("getatttype", "()Ljava/lang/String;", "GetGetatttypeHandler")]
    public virtual unsafe string? Getatttype()
    {
      JniObjectReference jniObjectReference = Command_SetAttr._members.InstanceMethods.InvokeVirtualObjectMethod("getatttype.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetattvalueHandler()
    {
      if ((object) Command_SetAttr.cb_getattvalue == null)
        Command_SetAttr.cb_getattvalue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_SetAttr.n_Getattvalue));
      return Command_SetAttr.cb_getattvalue;
    }

    private static IntPtr n_Getattvalue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Getattvalue());
    }

    [Register("getattvalue", "()Ljava/lang/String;", "GetGetattvalueHandler")]
    public virtual unsafe string? Getattvalue()
    {
      JniObjectReference jniObjectReference = Command_SetAttr._members.InstanceMethods.InvokeVirtualObjectMethod("getattvalue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetoffsetHandler()
    {
      if ((object) Command_SetAttr.cb_getoffset == null)
        Command_SetAttr.cb_getoffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_SetAttr.n_Getoffset));
      return Command_SetAttr.cb_getoffset;
    }

    private static int n_Getoffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Getoffset();
    }

    [Register("getoffset", "()I", "GetGetoffsetHandler")]
    public virtual unsafe int Getoffset()
    {
      return Command_SetAttr._members.InstanceMethods.InvokeVirtualInt32Method("getoffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetattnum_IHandler()
    {
      if ((object) Command_SetAttr.cb_setattnum_I == null)
        Command_SetAttr.cb_setattnum_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetAttr.n_Setattnum_I));
      return Command_SetAttr.cb_setattnum_I;
    }

    private static void n_Setattnum_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Setattnum(value);
    }

    [Register("setattnum", "(I)V", "GetSetattnum_IHandler")]
    public virtual unsafe void Setattnum(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetAttr._members.InstanceMethods.InvokeVirtualVoidMethod("setattnum.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetatttype_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetAttr.cb_setatttype_Ljava_lang_String_ == null)
        Command_SetAttr.cb_setatttype_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetAttr.n_Setatttype_Ljava_lang_String_));
      return Command_SetAttr.cb_setatttype_Ljava_lang_String_;
    }

    private static void n_Setatttype_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Setatttype(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setatttype", "(Ljava/lang/String;)V", "GetSetatttype_Ljava_lang_String_Handler")]
    public virtual unsafe void Setatttype(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_SetAttr._members.InstanceMethods.InvokeVirtualVoidMethod("setatttype.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetattvalue_Ljava_lang_String_Handler()
    {
      if ((object) Command_SetAttr.cb_setattvalue_Ljava_lang_String_ == null)
        Command_SetAttr.cb_setattvalue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_SetAttr.n_Setattvalue_Ljava_lang_String_));
      return Command_SetAttr.cb_setattvalue_Ljava_lang_String_;
    }

    private static void n_Setattvalue_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Setattvalue(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setattvalue", "(Ljava/lang/String;)V", "GetSetattvalue_Ljava_lang_String_Handler")]
    public virtual unsafe void Setattvalue(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_SetAttr._members.InstanceMethods.InvokeVirtualVoidMethod("setattvalue.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetoffset_IHandler()
    {
      if ((object) Command_SetAttr.cb_setoffset_I == null)
        Command_SetAttr.cb_setoffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_SetAttr.n_Setoffset_I));
      return Command_SetAttr.cb_setoffset_I;
    }

    private static void n_Setoffset_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_SetAttr>(jnienv, native__this, (JniHandleOwnership) 0).Setoffset(value);
    }

    [Register("setoffset", "(I)V", "GetSetoffset_IHandler")]
    public virtual unsafe void Setoffset(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_SetAttr._members.InstanceMethods.InvokeVirtualVoidMethod("setoffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
