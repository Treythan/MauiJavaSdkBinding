// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_UntraceableConfig
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
  [Register("com/zebra/ASCII_SDK/Param_UntraceableConfig", DoNotGenerateAcw = true)]
  public class Param_UntraceableConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_UntraceableConfig", typeof (Param_UntraceableConfig));
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getassertu;
    private static Delegate? cb_getepcLen;
    private static Delegate? cb_gethidealltid;
    private static Delegate? cb_gethideepc;
    private static Delegate? cb_gethidesometid;
    private static Delegate? cb_gethideuser;
    private static Delegate? cb_getreducerange;
    private static Delegate? cb_getshowepc;
    private static Delegate? cb_getshowtid;
    private static Delegate? cb_getshowuser;
    private static Delegate? cb_gettogglerange;
    private static Delegate? cb_setassertu_Z;
    private static Delegate? cb_setepcLen_I;
    private static Delegate? cb_sethidealltid_Z;
    private static Delegate? cb_sethideepc_Z;
    private static Delegate? cb_sethidesometid_Z;
    private static Delegate? cb_sethideuser_Z;
    private static Delegate? cb_setreducerange_Z;
    private static Delegate? cb_setshowepc_Z;
    private static Delegate? cb_setshowtid_Z;
    private static Delegate? cb_setshowuser_Z;
    private static Delegate? cb_settogglerange_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_UntraceableConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_UntraceableConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_UntraceableConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_UntraceableConfig._members.ManagedPeerType;

    protected Param_UntraceableConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_UntraceableConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_UntraceableConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_UntraceableConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_UntraceableConfig.cb_FromString_Ljava_lang_String_ == null)
        Param_UntraceableConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_UntraceableConfig.n_FromString_Ljava_lang_String_));
      return Param_UntraceableConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public virtual unsafe void FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_UntraceableConfig.cb_ToString == null)
        Param_UntraceableConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_UntraceableConfig.n_ToString));
      return Param_UntraceableConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetassertuHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getassertu == null)
        Param_UntraceableConfig.cb_getassertu = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Getassertu));
      return Param_UntraceableConfig.cb_getassertu;
    }

    private static bool n_Getassertu(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getassertu();
    }

    [Register("getassertu", "()Z", "GetGetassertuHandler")]
    public virtual unsafe bool Getassertu()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getassertu.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetepcLenHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getepcLen == null)
        Param_UntraceableConfig.cb_getepcLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Param_UntraceableConfig.n_GetepcLen));
      return Param_UntraceableConfig.cb_getepcLen;
    }

    private static int n_GetepcLen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).GetepcLen();
    }

    [Register("getepcLen", "()I", "GetGetepcLenHandler")]
    public virtual unsafe int GetepcLen()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualInt32Method("getepcLen.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGethidealltidHandler()
    {
      if ((object) Param_UntraceableConfig.cb_gethidealltid == null)
        Param_UntraceableConfig.cb_gethidealltid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Gethidealltid));
      return Param_UntraceableConfig.cb_gethidealltid;
    }

    private static bool n_Gethidealltid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Gethidealltid();
    }

    [Register("gethidealltid", "()Z", "GetGethidealltidHandler")]
    public virtual unsafe bool Gethidealltid()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("gethidealltid.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGethideepcHandler()
    {
      if ((object) Param_UntraceableConfig.cb_gethideepc == null)
        Param_UntraceableConfig.cb_gethideepc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Gethideepc));
      return Param_UntraceableConfig.cb_gethideepc;
    }

    private static bool n_Gethideepc(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Gethideepc();
    }

    [Register("gethideepc", "()Z", "GetGethideepcHandler")]
    public virtual unsafe bool Gethideepc()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("gethideepc.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGethidesometidHandler()
    {
      if ((object) Param_UntraceableConfig.cb_gethidesometid == null)
        Param_UntraceableConfig.cb_gethidesometid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Gethidesometid));
      return Param_UntraceableConfig.cb_gethidesometid;
    }

    private static bool n_Gethidesometid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Gethidesometid();
    }

    [Register("gethidesometid", "()Z", "GetGethidesometidHandler")]
    public virtual unsafe bool Gethidesometid()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("gethidesometid.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGethideuserHandler()
    {
      if ((object) Param_UntraceableConfig.cb_gethideuser == null)
        Param_UntraceableConfig.cb_gethideuser = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Gethideuser));
      return Param_UntraceableConfig.cb_gethideuser;
    }

    private static bool n_Gethideuser(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Gethideuser();
    }

    [Register("gethideuser", "()Z", "GetGethideuserHandler")]
    public virtual unsafe bool Gethideuser()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("gethideuser.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetreducerangeHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getreducerange == null)
        Param_UntraceableConfig.cb_getreducerange = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Getreducerange));
      return Param_UntraceableConfig.cb_getreducerange;
    }

    private static bool n_Getreducerange(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getreducerange();
    }

    [Register("getreducerange", "()Z", "GetGetreducerangeHandler")]
    public virtual unsafe bool Getreducerange()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getreducerange.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetshowepcHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getshowepc == null)
        Param_UntraceableConfig.cb_getshowepc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Getshowepc));
      return Param_UntraceableConfig.cb_getshowepc;
    }

    private static bool n_Getshowepc(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getshowepc();
    }

    [Register("getshowepc", "()Z", "GetGetshowepcHandler")]
    public virtual unsafe bool Getshowepc()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getshowepc.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetshowtidHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getshowtid == null)
        Param_UntraceableConfig.cb_getshowtid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Getshowtid));
      return Param_UntraceableConfig.cb_getshowtid;
    }

    private static bool n_Getshowtid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getshowtid();
    }

    [Register("getshowtid", "()Z", "GetGetshowtidHandler")]
    public virtual unsafe bool Getshowtid()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getshowtid.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetshowuserHandler()
    {
      if ((object) Param_UntraceableConfig.cb_getshowuser == null)
        Param_UntraceableConfig.cb_getshowuser = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Getshowuser));
      return Param_UntraceableConfig.cb_getshowuser;
    }

    private static bool n_Getshowuser(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getshowuser();
    }

    [Register("getshowuser", "()Z", "GetGetshowuserHandler")]
    public virtual unsafe bool Getshowuser()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getshowuser.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGettogglerangeHandler()
    {
      if ((object) Param_UntraceableConfig.cb_gettogglerange == null)
        Param_UntraceableConfig.cb_gettogglerange = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_UntraceableConfig.n_Gettogglerange));
      return Param_UntraceableConfig.cb_gettogglerange;
    }

    private static bool n_Gettogglerange(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Gettogglerange();
    }

    [Register("gettogglerange", "()Z", "GetGettogglerangeHandler")]
    public virtual unsafe bool Gettogglerange()
    {
      return Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("gettogglerange.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetassertu_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setassertu_Z == null)
        Param_UntraceableConfig.cb_setassertu_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Setassertu_Z));
      return Param_UntraceableConfig.cb_setassertu_Z;
    }

    private static void n_Setassertu_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setassertu(value);
    }

    [Register("setassertu", "(Z)V", "GetSetassertu_ZHandler")]
    public virtual unsafe void Setassertu(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setassertu.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetepcLen_IHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setepcLen_I == null)
        Param_UntraceableConfig.cb_setepcLen_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Param_UntraceableConfig.n_SetepcLen_I));
      return Param_UntraceableConfig.cb_setepcLen_I;
    }

    private static void n_SetepcLen_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).SetepcLen(value);
    }

    [Register("setepcLen", "(I)V", "GetSetepcLen_IHandler")]
    public virtual unsafe void SetepcLen(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setepcLen.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSethidealltid_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_sethidealltid_Z == null)
        Param_UntraceableConfig.cb_sethidealltid_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Sethidealltid_Z));
      return Param_UntraceableConfig.cb_sethidealltid_Z;
    }

    private static void n_Sethidealltid_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Sethidealltid(value);
    }

    [Register("sethidealltid", "(Z)V", "GetSethidealltid_ZHandler")]
    public virtual unsafe void Sethidealltid(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("sethidealltid.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSethideepc_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_sethideepc_Z == null)
        Param_UntraceableConfig.cb_sethideepc_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Sethideepc_Z));
      return Param_UntraceableConfig.cb_sethideepc_Z;
    }

    private static void n_Sethideepc_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Sethideepc(value);
    }

    [Register("sethideepc", "(Z)V", "GetSethideepc_ZHandler")]
    public virtual unsafe void Sethideepc(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("sethideepc.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSethidesometid_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_sethidesometid_Z == null)
        Param_UntraceableConfig.cb_sethidesometid_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Sethidesometid_Z));
      return Param_UntraceableConfig.cb_sethidesometid_Z;
    }

    private static void n_Sethidesometid_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Sethidesometid(value);
    }

    [Register("sethidesometid", "(Z)V", "GetSethidesometid_ZHandler")]
    public virtual unsafe void Sethidesometid(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("sethidesometid.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSethideuser_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_sethideuser_Z == null)
        Param_UntraceableConfig.cb_sethideuser_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Sethideuser_Z));
      return Param_UntraceableConfig.cb_sethideuser_Z;
    }

    private static void n_Sethideuser_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Sethideuser(value);
    }

    [Register("sethideuser", "(Z)V", "GetSethideuser_ZHandler")]
    public virtual unsafe void Sethideuser(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("sethideuser.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetreducerange_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setreducerange_Z == null)
        Param_UntraceableConfig.cb_setreducerange_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Setreducerange_Z));
      return Param_UntraceableConfig.cb_setreducerange_Z;
    }

    private static void n_Setreducerange_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setreducerange(value);
    }

    [Register("setreducerange", "(Z)V", "GetSetreducerange_ZHandler")]
    public virtual unsafe void Setreducerange(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setreducerange.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetshowepc_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setshowepc_Z == null)
        Param_UntraceableConfig.cb_setshowepc_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Setshowepc_Z));
      return Param_UntraceableConfig.cb_setshowepc_Z;
    }

    private static void n_Setshowepc_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setshowepc(value);
    }

    [Register("setshowepc", "(Z)V", "GetSetshowepc_ZHandler")]
    public virtual unsafe void Setshowepc(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setshowepc.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetshowtid_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setshowtid_Z == null)
        Param_UntraceableConfig.cb_setshowtid_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Setshowtid_Z));
      return Param_UntraceableConfig.cb_setshowtid_Z;
    }

    private static void n_Setshowtid_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setshowtid(value);
    }

    [Register("setshowtid", "(Z)V", "GetSetshowtid_ZHandler")]
    public virtual unsafe void Setshowtid(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setshowtid.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetshowuser_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_setshowuser_Z == null)
        Param_UntraceableConfig.cb_setshowuser_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Setshowuser_Z));
      return Param_UntraceableConfig.cb_setshowuser_Z;
    }

    private static void n_Setshowuser_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setshowuser(value);
    }

    [Register("setshowuser", "(Z)V", "GetSetshowuser_ZHandler")]
    public virtual unsafe void Setshowuser(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setshowuser.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSettogglerange_ZHandler()
    {
      if ((object) Param_UntraceableConfig.cb_settogglerange_Z == null)
        Param_UntraceableConfig.cb_settogglerange_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_UntraceableConfig.n_Settogglerange_Z));
      return Param_UntraceableConfig.cb_settogglerange_Z;
    }

    private static void n_Settogglerange_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_UntraceableConfig>(jnienv, native__this, (JniHandleOwnership) 0).Settogglerange(value);
    }

    [Register("settogglerange", "(Z)V", "GetSettogglerange_ZHandler")]
    public virtual unsafe void Settogglerange(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_UntraceableConfig._members.InstanceMethods.InvokeVirtualVoidMethod("settogglerange.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
