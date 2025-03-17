// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_AccessConfiguration
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
  [Register("com/zebra/ASCII_SDK/Param_AccessConfiguration", DoNotGenerateAcw = true)]
  public class Param_AccessConfiguration : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_AccessConfiguration", typeof (Param_AccessConfiguration));
    private static Delegate? cb_getDisableSummaryNotify;
    private static Delegate? cb_setDisableSummaryNotify_Z;
    private static Delegate? cb_getDoSelect;
    private static Delegate? cb_setDoSelect_Z;
    private static Delegate? cb_getEnableSummaryNotify;
    private static Delegate? cb_setEnableSummaryNotify_Z;
    private static Delegate? cb_getNoSelect;
    private static Delegate? cb_setNoSelect_Z;
    private static Delegate? cb_getPower;
    private static Delegate? cb_setPower_S;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getpassword;
    private static Delegate? cb_getuseaccessfilter;
    private static Delegate? cb_setpassword_J;
    private static Delegate? cb_setuseaccessfilter_S;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_AccessConfiguration._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_AccessConfiguration._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_AccessConfiguration._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_AccessConfiguration._members.ManagedPeerType;

    protected Param_AccessConfiguration(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_AccessConfiguration()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_AccessConfiguration._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_AccessConfiguration._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetDisableSummaryNotifyHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getDisableSummaryNotify == null)
        Param_AccessConfiguration.cb_getDisableSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfiguration.n_GetDisableSummaryNotify));
      return Param_AccessConfiguration.cb_getDisableSummaryNotify;
    }

    private static bool n_GetDisableSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DisableSummaryNotify;
    }

    private static Delegate GetSetDisableSummaryNotify_ZHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setDisableSummaryNotify_Z == null)
        Param_AccessConfiguration.cb_setDisableSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfiguration.n_SetDisableSummaryNotify_Z));
      return Param_AccessConfiguration.cb_setDisableSummaryNotify_Z;
    }

    private static void n_SetDisableSummaryNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DisableSummaryNotify = value;
    }

    public virtual unsafe bool DisableSummaryNotify
    {
      [Register("getDisableSummaryNotify", "()Z", "GetGetDisableSummaryNotifyHandler")] get
      {
        return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableSummaryNotify", "(Z)V", "GetSetDisableSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDoSelectHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getDoSelect == null)
        Param_AccessConfiguration.cb_getDoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfiguration.n_GetDoSelect));
      return Param_AccessConfiguration.cb_getDoSelect;
    }

    private static bool n_GetDoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect;
    }

    private static Delegate GetSetDoSelect_ZHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setDoSelect_Z == null)
        Param_AccessConfiguration.cb_setDoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfiguration.n_SetDoSelect_Z));
      return Param_AccessConfiguration.cb_setDoSelect_Z;
    }

    private static void n_SetDoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect = value;
    }

    public virtual unsafe bool DoSelect
    {
      [Register("getDoSelect", "()Z", "GetGetDoSelectHandler")] get
      {
        return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoSelect", "(Z)V", "GetSetDoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setDoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableSummaryNotifyHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getEnableSummaryNotify == null)
        Param_AccessConfiguration.cb_getEnableSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfiguration.n_GetEnableSummaryNotify));
      return Param_AccessConfiguration.cb_getEnableSummaryNotify;
    }

    private static bool n_GetEnableSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).EnableSummaryNotify;
    }

    private static Delegate GetSetEnableSummaryNotify_ZHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setEnableSummaryNotify_Z == null)
        Param_AccessConfiguration.cb_setEnableSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfiguration.n_SetEnableSummaryNotify_Z));
      return Param_AccessConfiguration.cb_setEnableSummaryNotify_Z;
    }

    private static void n_SetEnableSummaryNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).EnableSummaryNotify = value;
    }

    public virtual unsafe bool EnableSummaryNotify
    {
      [Register("getEnableSummaryNotify", "()Z", "GetGetEnableSummaryNotifyHandler")] get
      {
        return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableSummaryNotify", "(Z)V", "GetSetEnableSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoSelectHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getNoSelect == null)
        Param_AccessConfiguration.cb_getNoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfiguration.n_GetNoSelect));
      return Param_AccessConfiguration.cb_getNoSelect;
    }

    private static bool n_GetNoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect;
    }

    private static Delegate GetSetNoSelect_ZHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setNoSelect_Z == null)
        Param_AccessConfiguration.cb_setNoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfiguration.n_SetNoSelect_Z));
      return Param_AccessConfiguration.cb_setNoSelect_Z;
    }

    private static void n_SetNoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect = value;
    }

    public virtual unsafe bool NoSelect
    {
      [Register("getNoSelect", "()Z", "GetGetNoSelectHandler")] get
      {
        return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoSelect", "(Z)V", "GetSetNoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setNoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getPower == null)
        Param_AccessConfiguration.cb_getPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_AccessConfiguration.n_GetPower));
      return Param_AccessConfiguration.cb_getPower;
    }

    private static short n_GetPower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Power;
    }

    private static Delegate GetSetPower_SHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setPower_S == null)
        Param_AccessConfiguration.cb_setPower_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_AccessConfiguration.n_SetPower_S));
      return Param_AccessConfiguration.cb_setPower_S;
    }

    private static void n_SetPower_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Power = value;
    }

    public virtual unsafe short Power
    {
      [Register("getPower", "()S", "GetGetPowerHandler")] get
      {
        return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualInt16Method("getPower.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPower", "(S)V", "GetSetPower_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setPower.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_AccessConfiguration.cb_FromString_Ljava_lang_String_ == null)
        Param_AccessConfiguration.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_AccessConfiguration.n_FromString_Ljava_lang_String_));
      return Param_AccessConfiguration.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_AccessConfiguration.cb_ToString == null)
        Param_AccessConfiguration.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_AccessConfiguration.n_ToString));
      return Param_AccessConfiguration.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetpasswordHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getpassword == null)
        Param_AccessConfiguration.cb_getpassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Param_AccessConfiguration.n_Getpassword));
      return Param_AccessConfiguration.cb_getpassword;
    }

    private static long n_Getpassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Getpassword();
    }

    [Register("getpassword", "()J", "GetGetpasswordHandler")]
    public virtual unsafe long Getpassword()
    {
      return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualInt64Method("getpassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetuseaccessfilterHandler()
    {
      if ((object) Param_AccessConfiguration.cb_getuseaccessfilter == null)
        Param_AccessConfiguration.cb_getuseaccessfilter = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_AccessConfiguration.n_Getuseaccessfilter));
      return Param_AccessConfiguration.cb_getuseaccessfilter;
    }

    private static short n_Getuseaccessfilter(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Getuseaccessfilter();
    }

    [Register("getuseaccessfilter", "()S", "GetGetuseaccessfilterHandler")]
    public virtual unsafe short Getuseaccessfilter()
    {
      return Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualInt16Method("getuseaccessfilter.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetpassword_JHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setpassword_J == null)
        Param_AccessConfiguration.cb_setpassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Param_AccessConfiguration.n_Setpassword_J));
      return Param_AccessConfiguration.cb_setpassword_J;
    }

    private static void n_Setpassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Setpassword(value);
    }

    [Register("setpassword", "(J)V", "GetSetpassword_JHandler")]
    public virtual unsafe void Setpassword(long value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setpassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetuseaccessfilter_SHandler()
    {
      if ((object) Param_AccessConfiguration.cb_setuseaccessfilter_S == null)
        Param_AccessConfiguration.cb_setuseaccessfilter_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_AccessConfiguration.n_Setuseaccessfilter_S));
      return Param_AccessConfiguration.cb_setuseaccessfilter_S;
    }

    private static void n_Setuseaccessfilter_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_AccessConfiguration>(jnienv, native__this, (JniHandleOwnership) 0).Setuseaccessfilter(value);
    }

    [Register("setuseaccessfilter", "(S)V", "GetSetuseaccessfilter_SHandler")]
    public virtual unsafe void Setuseaccessfilter(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_AccessConfiguration._members.InstanceMethods.InvokeVirtualVoidMethod("setuseaccessfilter.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
