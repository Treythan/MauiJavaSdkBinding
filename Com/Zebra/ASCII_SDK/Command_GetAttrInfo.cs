// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_GetAttrInfo
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
  [Register("com/zebra/ASCII_SDK/Command_GetAttrInfo", DoNotGenerateAcw = true)]
  public class Command_GetAttrInfo : Command
  {
    [Register("commandName")]
    public const string CommandName = "GetAttrInfo";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_GetAttrInfo", typeof (Command_GetAttrInfo));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getattnum;
    private static Delegate? cb_setattnum_I;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_GetAttrInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_GetAttrInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_GetAttrInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_GetAttrInfo._members.ManagedPeerType;

    protected Command_GetAttrInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_GetAttrInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_GetAttrInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_GetAttrInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_GetAttrInfo.cb_getCommandType == null)
        Command_GetAttrInfo.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_GetAttrInfo.n_GetCommandType));
      return Command_GetAttrInfo.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_GetAttrInfo>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_GetAttrInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_GetAttrInfo.cb_FromString_Ljava_lang_String_ == null)
        Command_GetAttrInfo.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_GetAttrInfo.n_FromString_Ljava_lang_String_));
      return Command_GetAttrInfo.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_GetAttrInfo>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_GetAttrInfo._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_GetAttrInfo.cb_ToString == null)
        Command_GetAttrInfo.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_GetAttrInfo.n_ToString));
      return Command_GetAttrInfo.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_GetAttrInfo>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_GetAttrInfo._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetattnumHandler()
    {
      if ((object) Command_GetAttrInfo.cb_getattnum == null)
        Command_GetAttrInfo.cb_getattnum = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_GetAttrInfo.n_Getattnum));
      return Command_GetAttrInfo.cb_getattnum;
    }

    private static int n_Getattnum(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_GetAttrInfo>(jnienv, native__this, (JniHandleOwnership) 0).Getattnum();
    }

    [Register("getattnum", "()I", "GetGetattnumHandler")]
    public virtual unsafe int Getattnum()
    {
      return Command_GetAttrInfo._members.InstanceMethods.InvokeVirtualInt32Method("getattnum.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetattnum_IHandler()
    {
      if ((object) Command_GetAttrInfo.cb_setattnum_I == null)
        Command_GetAttrInfo.cb_setattnum_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_GetAttrInfo.n_Setattnum_I));
      return Command_GetAttrInfo.cb_setattnum_I;
    }

    private static void n_Setattnum_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_GetAttrInfo>(jnienv, native__this, (JniHandleOwnership) 0).Setattnum(value);
    }

    [Register("setattnum", "(I)V", "GetSetattnum_IHandler")]
    public virtual unsafe void Setattnum(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_GetAttrInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setattnum.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
