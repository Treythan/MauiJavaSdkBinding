// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_AccessConfig
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
  [Register("com/zebra/ASCII_SDK/Param_AccessConfig", DoNotGenerateAcw = true)]
  public class Param_AccessConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_AccessConfig", typeof (Param_AccessConfig));
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

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_AccessConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_AccessConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_AccessConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_AccessConfig._members.ManagedPeerType;

    protected Param_AccessConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_AccessConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_AccessConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_AccessConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetDisableSummaryNotifyHandler()
    {
      if ((object) Param_AccessConfig.cb_getDisableSummaryNotify == null)
        Param_AccessConfig.cb_getDisableSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfig.n_GetDisableSummaryNotify));
      return Param_AccessConfig.cb_getDisableSummaryNotify;
    }

    private static bool n_GetDisableSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).DisableSummaryNotify;
    }

    private static Delegate GetSetDisableSummaryNotify_ZHandler()
    {
      if ((object) Param_AccessConfig.cb_setDisableSummaryNotify_Z == null)
        Param_AccessConfig.cb_setDisableSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfig.n_SetDisableSummaryNotify_Z));
      return Param_AccessConfig.cb_setDisableSummaryNotify_Z;
    }

    private static void n_SetDisableSummaryNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).DisableSummaryNotify = value;
    }

    public virtual unsafe bool DisableSummaryNotify
    {
      [Register("getDisableSummaryNotify", "()Z", "GetGetDisableSummaryNotifyHandler")] get
      {
        return Param_AccessConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getDisableSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDisableSummaryNotify", "(Z)V", "GetSetDisableSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setDisableSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDoSelectHandler()
    {
      if ((object) Param_AccessConfig.cb_getDoSelect == null)
        Param_AccessConfig.cb_getDoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfig.n_GetDoSelect));
      return Param_AccessConfig.cb_getDoSelect;
    }

    private static bool n_GetDoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect;
    }

    private static Delegate GetSetDoSelect_ZHandler()
    {
      if ((object) Param_AccessConfig.cb_setDoSelect_Z == null)
        Param_AccessConfig.cb_setDoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfig.n_SetDoSelect_Z));
      return Param_AccessConfig.cb_setDoSelect_Z;
    }

    private static void n_SetDoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).DoSelect = value;
    }

    public virtual unsafe bool DoSelect
    {
      [Register("getDoSelect", "()Z", "GetGetDoSelectHandler")] get
      {
        return Param_AccessConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoSelect", "(Z)V", "GetSetDoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setDoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetEnableSummaryNotifyHandler()
    {
      if ((object) Param_AccessConfig.cb_getEnableSummaryNotify == null)
        Param_AccessConfig.cb_getEnableSummaryNotify = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfig.n_GetEnableSummaryNotify));
      return Param_AccessConfig.cb_getEnableSummaryNotify;
    }

    private static bool n_GetEnableSummaryNotify(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).EnableSummaryNotify;
    }

    private static Delegate GetSetEnableSummaryNotify_ZHandler()
    {
      if ((object) Param_AccessConfig.cb_setEnableSummaryNotify_Z == null)
        Param_AccessConfig.cb_setEnableSummaryNotify_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfig.n_SetEnableSummaryNotify_Z));
      return Param_AccessConfig.cb_setEnableSummaryNotify_Z;
    }

    private static void n_SetEnableSummaryNotify_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).EnableSummaryNotify = value;
    }

    public virtual unsafe bool EnableSummaryNotify
    {
      [Register("getEnableSummaryNotify", "()Z", "GetGetEnableSummaryNotifyHandler")] get
      {
        return Param_AccessConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getEnableSummaryNotify.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableSummaryNotify", "(Z)V", "GetSetEnableSummaryNotify_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableSummaryNotify.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoSelectHandler()
    {
      if ((object) Param_AccessConfig.cb_getNoSelect == null)
        Param_AccessConfig.cb_getNoSelect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_AccessConfig.n_GetNoSelect));
      return Param_AccessConfig.cb_getNoSelect;
    }

    private static bool n_GetNoSelect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect;
    }

    private static Delegate GetSetNoSelect_ZHandler()
    {
      if ((object) Param_AccessConfig.cb_setNoSelect_Z == null)
        Param_AccessConfig.cb_setNoSelect_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_AccessConfig.n_SetNoSelect_Z));
      return Param_AccessConfig.cb_setNoSelect_Z;
    }

    private static void n_SetNoSelect_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).NoSelect = value;
    }

    public virtual unsafe bool NoSelect
    {
      [Register("getNoSelect", "()Z", "GetGetNoSelectHandler")] get
      {
        return Param_AccessConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoSelect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoSelect", "(Z)V", "GetSetNoSelect_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setNoSelect.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPowerHandler()
    {
      if ((object) Param_AccessConfig.cb_getPower == null)
        Param_AccessConfig.cb_getPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_AccessConfig.n_GetPower));
      return Param_AccessConfig.cb_getPower;
    }

    private static short n_GetPower(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).Power;
    }

    private static Delegate GetSetPower_SHandler()
    {
      if ((object) Param_AccessConfig.cb_setPower_S == null)
        Param_AccessConfig.cb_setPower_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_AccessConfig.n_SetPower_S));
      return Param_AccessConfig.cb_setPower_S;
    }

    private static void n_SetPower_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).Power = value;
    }

    public virtual unsafe short Power
    {
      [Register("getPower", "()S", "GetGetPowerHandler")] get
      {
        return Param_AccessConfig._members.InstanceMethods.InvokeVirtualInt16Method("getPower.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPower", "(S)V", "GetSetPower_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPower.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_AccessConfig.cb_FromString_Ljava_lang_String_ == null)
        Param_AccessConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_AccessConfig.n_FromString_Ljava_lang_String_));
      return Param_AccessConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Param_AccessConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_AccessConfig.cb_ToString == null)
        Param_AccessConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_AccessConfig.n_ToString));
      return Param_AccessConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_AccessConfig>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_AccessConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
