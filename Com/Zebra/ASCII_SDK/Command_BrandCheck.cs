// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_BrandCheck
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
  [Register("com/zebra/ASCII_SDK/Command_BrandCheck", DoNotGenerateAcw = true)]
  public class Command_BrandCheck : Command
  {
    [Register("commandName")]
    public const string CommandName = "BrandCheck";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_BrandCheck", typeof (Command_BrandCheck));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getbrandid;
    private static Delegate? cb_getepclength;
    private static Delegate? cb_setbrandid_I;
    private static Delegate? cb_setepclength_S;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_BrandCheck._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_BrandCheck._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_BrandCheck._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_BrandCheck._members.ManagedPeerType;

    protected Command_BrandCheck(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_BrandCheck()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_BrandCheck._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_BrandCheck._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_BrandCheck.cb_getCommandType == null)
        Command_BrandCheck.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BrandCheck.n_GetCommandType));
      return Command_BrandCheck.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_BrandCheck._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_BrandCheck.cb_FromString_Ljava_lang_String_ == null)
        Command_BrandCheck.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_BrandCheck.n_FromString_Ljava_lang_String_));
      return Command_BrandCheck.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_BrandCheck._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_BrandCheck.cb_ToString == null)
        Command_BrandCheck.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_BrandCheck.n_ToString));
      return Command_BrandCheck.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_BrandCheck._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetbrandidHandler()
    {
      if ((object) Command_BrandCheck.cb_getbrandid == null)
        Command_BrandCheck.cb_getbrandid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_BrandCheck.n_Getbrandid));
      return Command_BrandCheck.cb_getbrandid;
    }

    private static int n_Getbrandid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).Getbrandid();
    }

    [Register("getbrandid", "()I", "GetGetbrandidHandler")]
    public virtual unsafe int Getbrandid()
    {
      return Command_BrandCheck._members.InstanceMethods.InvokeVirtualInt32Method("getbrandid.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetepclengthHandler()
    {
      if ((object) Command_BrandCheck.cb_getepclength == null)
        Command_BrandCheck.cb_getepclength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_BrandCheck.n_Getepclength));
      return Command_BrandCheck.cb_getepclength;
    }

    private static short n_Getepclength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).Getepclength();
    }

    [Register("getepclength", "()S", "GetGetepclengthHandler")]
    public virtual unsafe short Getepclength()
    {
      return Command_BrandCheck._members.InstanceMethods.InvokeVirtualInt16Method("getepclength.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetbrandid_IHandler()
    {
      if ((object) Command_BrandCheck.cb_setbrandid_I == null)
        Command_BrandCheck.cb_setbrandid_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_BrandCheck.n_Setbrandid_I));
      return Command_BrandCheck.cb_setbrandid_I;
    }

    private static void n_Setbrandid_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).Setbrandid(value);
    }

    [Register("setbrandid", "(I)V", "GetSetbrandid_IHandler")]
    public virtual unsafe void Setbrandid(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_BrandCheck._members.InstanceMethods.InvokeVirtualVoidMethod("setbrandid.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetepclength_SHandler()
    {
      if ((object) Command_BrandCheck.cb_setepclength_S == null)
        Command_BrandCheck.cb_setepclength_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_BrandCheck.n_Setepclength_S));
      return Command_BrandCheck.cb_setepclength_S;
    }

    private static void n_Setepclength_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_BrandCheck>(jnienv, native__this, (JniHandleOwnership) 0).Setepclength(value);
    }

    [Register("setepclength", "(S)V", "GetSetepclength_SHandler")]
    public virtual unsafe void Setepclength(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_BrandCheck._members.InstanceMethods.InvokeVirtualVoidMethod("setepclength.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
