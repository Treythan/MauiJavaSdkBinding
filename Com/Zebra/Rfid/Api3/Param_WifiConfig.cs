// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Param_WifiConfig
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/Param_WifiConfig", DoNotGenerateAcw = true)]
  public class Param_WifiConfig : Object
  {
    [Register("commandName")]
    public const string CommandName = "config";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Param_WifiConfig", typeof (Param_WifiConfig));
    private static Delegate? cb_ToString;
    private static Delegate? cb_getgroup;
    private static Delegate? cb_getpairwise;
    private static Delegate? cb_getpsk;
    private static Delegate? cb_setgroup_Ljava_lang_String_;
    private static Delegate? cb_setpairwise_Ljava_lang_String_;
    private static Delegate? cb_setpsk_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_WifiConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_WifiConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_WifiConfig._members.ManagedPeerType;

    protected Param_WifiConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_WifiConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_WifiConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_WifiConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_WifiConfig.cb_ToString == null)
        Param_WifiConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_ToString));
      return Param_WifiConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetgroupHandler()
    {
      if ((object) Param_WifiConfig.cb_getgroup == null)
        Param_WifiConfig.cb_getgroup = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getgroup));
      return Param_WifiConfig.cb_getgroup;
    }

    private static IntPtr n_Getgroup(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getgroup());
    }

    [Register("getgroup", "()Ljava/lang/String;", "GetGetgroupHandler")]
    public virtual unsafe string? Getgroup()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getgroup.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpairwiseHandler()
    {
      if ((object) Param_WifiConfig.cb_getpairwise == null)
        Param_WifiConfig.cb_getpairwise = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getpairwise));
      return Param_WifiConfig.cb_getpairwise;
    }

    private static IntPtr n_Getpairwise(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getpairwise());
    }

    [Register("getpairwise", "()Ljava/lang/String;", "GetGetpairwiseHandler")]
    public virtual unsafe string? Getpairwise()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getpairwise.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpskHandler()
    {
      if ((object) Param_WifiConfig.cb_getpsk == null)
        Param_WifiConfig.cb_getpsk = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_WifiConfig.n_Getpsk));
      return Param_WifiConfig.cb_getpsk;
    }

    private static IntPtr n_Getpsk(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getpsk());
    }

    [Register("getpsk", "()Ljava/lang/String;", "GetGetpskHandler")]
    public virtual unsafe string? Getpsk()
    {
      JniObjectReference jniObjectReference = Param_WifiConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getpsk.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetgroup_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setgroup_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setgroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setgroup_Ljava_lang_String_));
      return Param_WifiConfig.cb_setgroup_Ljava_lang_String_;
    }

    private static void n_Setgroup_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setgroup(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setgroup", "(Ljava/lang/String;)V", "GetSetgroup_Ljava_lang_String_Handler")]
    public virtual unsafe void Setgroup(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setgroup.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetpairwise_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setpairwise_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setpairwise_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setpairwise_Ljava_lang_String_));
      return Param_WifiConfig.cb_setpairwise_Ljava_lang_String_;
    }

    private static void n_Setpairwise_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setpairwise(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpairwise", "(Ljava/lang/String;)V", "GetSetpairwise_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpairwise(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setpairwise.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetpsk_Ljava_lang_String_Handler()
    {
      if ((object) Param_WifiConfig.cb_setpsk_Ljava_lang_String_ == null)
        Param_WifiConfig.cb_setpsk_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_WifiConfig.n_Setpsk_Ljava_lang_String_));
      return Param_WifiConfig.cb_setpsk_Ljava_lang_String_;
    }

    private static void n_Setpsk_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_WifiConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setpsk(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setpsk", "(Ljava/lang/String;)V", "GetSetpsk_Ljava_lang_String_Handler")]
    public virtual unsafe void Setpsk(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_WifiConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setpsk.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
