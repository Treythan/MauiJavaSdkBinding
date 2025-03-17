// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_Accesscriteria
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
  [Register("com/zebra/ASCII_SDK/Param_Accesscriteria", DoNotGenerateAcw = true)]
  public class Param_Accesscriteria : Object
  {
    [Register("commandName")]
    public const string CommandName = "Accesscriteria";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_Accesscriteria", typeof (Param_Accesscriteria));
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getfilter1data;
    private static Delegate? cb_getfilter1domatch;
    private static Delegate? cb_getfilter1mask;
    private static Delegate? cb_getfilter1maskbank;
    private static Delegate? cb_getfilter1maskstartpos;
    private static Delegate? cb_getfilter1matchlength;
    private static Delegate? cb_getfilter1nomatch;
    private static Delegate? cb_getfilter2data;
    private static Delegate? cb_getfilter2domatch;
    private static Delegate? cb_getfilter2mask;
    private static Delegate? cb_getfilter2maskbank;
    private static Delegate? cb_getfilter2maskstartpos;
    private static Delegate? cb_getfilter2matchlength;
    private static Delegate? cb_getfilter2nomatch;
    private static Delegate? cb_setfilter1data_arrayB;
    private static Delegate? cb_setfilter1domatch_Z;
    private static Delegate? cb_setfilter1mask_arrayB;
    private static Delegate? cb_setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_setfilter1maskstartpos_S;
    private static Delegate? cb_setfilter1matchlength_S;
    private static Delegate? cb_setfilter1nomatch_Z;
    private static Delegate? cb_setfilter2data_arrayB;
    private static Delegate? cb_setfilter2domatch_Z;
    private static Delegate? cb_setfilter2mask_arrayB;
    private static Delegate? cb_setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_setfilter2maskstartpos_S;
    private static Delegate? cb_setfilter2matchlength_S;
    private static Delegate? cb_setfilter2nomatch_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_Accesscriteria._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_Accesscriteria._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_Accesscriteria._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_Accesscriteria._members.ManagedPeerType;

    protected Param_Accesscriteria(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_Accesscriteria()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_Accesscriteria._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_Accesscriteria._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_Accesscriteria.cb_FromString_Ljava_lang_String_ == null)
        Param_Accesscriteria.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_FromString_Ljava_lang_String_));
      return Param_Accesscriteria.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_Accesscriteria.cb_ToString == null)
        Param_Accesscriteria.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_ToString));
      return Param_Accesscriteria.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetfilter1dataHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1data == null)
        Param_Accesscriteria.cb_getfilter1data = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter1data));
      return Param_Accesscriteria.cb_getfilter1data;
    }

    private static IntPtr n_Getfilter1data(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1data());
    }

    [Register("getfilter1data", "()[B", "GetGetfilter1dataHandler")]
    public virtual unsafe byte[]? Getfilter1data()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter1data.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetfilter1domatchHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1domatch == null)
        Param_Accesscriteria.cb_getfilter1domatch = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_Accesscriteria.n_Getfilter1domatch));
      return Param_Accesscriteria.cb_getfilter1domatch;
    }

    private static bool n_Getfilter1domatch(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1domatch();
    }

    [Register("getfilter1domatch", "()Z", "GetGetfilter1domatchHandler")]
    public virtual unsafe bool Getfilter1domatch()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualBooleanMethod("getfilter1domatch.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter1maskHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1mask == null)
        Param_Accesscriteria.cb_getfilter1mask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter1mask));
      return Param_Accesscriteria.cb_getfilter1mask;
    }

    private static IntPtr n_Getfilter1mask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1mask());
    }

    [Register("getfilter1mask", "()[B", "GetGetfilter1maskHandler")]
    public virtual unsafe byte[]? Getfilter1mask()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter1mask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetfilter1maskbankHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1maskbank == null)
        Param_Accesscriteria.cb_getfilter1maskbank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter1maskbank));
      return Param_Accesscriteria.cb_getfilter1maskbank;
    }

    private static IntPtr n_Getfilter1maskbank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1maskbank());
    }

    [Register("getfilter1maskbank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetfilter1maskbankHandler")]
    public virtual unsafe ENUM_MEMORY_BANK? Getfilter1maskbank()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter1maskbank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetfilter1maskstartposHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1maskstartpos == null)
        Param_Accesscriteria.cb_getfilter1maskstartpos = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_Accesscriteria.n_Getfilter1maskstartpos));
      return Param_Accesscriteria.cb_getfilter1maskstartpos;
    }

    private static short n_Getfilter1maskstartpos(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1maskstartpos();
    }

    [Register("getfilter1maskstartpos", "()S", "GetGetfilter1maskstartposHandler")]
    public virtual unsafe short Getfilter1maskstartpos()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualInt16Method("getfilter1maskstartpos.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter1matchlengthHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1matchlength == null)
        Param_Accesscriteria.cb_getfilter1matchlength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_Accesscriteria.n_Getfilter1matchlength));
      return Param_Accesscriteria.cb_getfilter1matchlength;
    }

    private static short n_Getfilter1matchlength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1matchlength();
    }

    [Register("getfilter1matchlength", "()S", "GetGetfilter1matchlengthHandler")]
    public virtual unsafe short Getfilter1matchlength()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualInt16Method("getfilter1matchlength.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter1nomatchHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter1nomatch == null)
        Param_Accesscriteria.cb_getfilter1nomatch = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_Accesscriteria.n_Getfilter1nomatch));
      return Param_Accesscriteria.cb_getfilter1nomatch;
    }

    private static bool n_Getfilter1nomatch(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter1nomatch();
    }

    [Register("getfilter1nomatch", "()Z", "GetGetfilter1nomatchHandler")]
    public virtual unsafe bool Getfilter1nomatch()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualBooleanMethod("getfilter1nomatch.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter2dataHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2data == null)
        Param_Accesscriteria.cb_getfilter2data = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter2data));
      return Param_Accesscriteria.cb_getfilter2data;
    }

    private static IntPtr n_Getfilter2data(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2data());
    }

    [Register("getfilter2data", "()[B", "GetGetfilter2dataHandler")]
    public virtual unsafe byte[]? Getfilter2data()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter2data.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetfilter2domatchHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2domatch == null)
        Param_Accesscriteria.cb_getfilter2domatch = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_Accesscriteria.n_Getfilter2domatch));
      return Param_Accesscriteria.cb_getfilter2domatch;
    }

    private static bool n_Getfilter2domatch(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2domatch();
    }

    [Register("getfilter2domatch", "()Z", "GetGetfilter2domatchHandler")]
    public virtual unsafe bool Getfilter2domatch()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualBooleanMethod("getfilter2domatch.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter2maskHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2mask == null)
        Param_Accesscriteria.cb_getfilter2mask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter2mask));
      return Param_Accesscriteria.cb_getfilter2mask;
    }

    private static IntPtr n_Getfilter2mask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2mask());
    }

    [Register("getfilter2mask", "()[B", "GetGetfilter2maskHandler")]
    public virtual unsafe byte[]? Getfilter2mask()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter2mask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetfilter2maskbankHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2maskbank == null)
        Param_Accesscriteria.cb_getfilter2maskbank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_Accesscriteria.n_Getfilter2maskbank));
      return Param_Accesscriteria.cb_getfilter2maskbank;
    }

    private static IntPtr n_Getfilter2maskbank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2maskbank());
    }

    [Register("getfilter2maskbank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetfilter2maskbankHandler")]
    public virtual unsafe ENUM_MEMORY_BANK? Getfilter2maskbank()
    {
      JniObjectReference jniObjectReference = Param_Accesscriteria._members.InstanceMethods.InvokeVirtualObjectMethod("getfilter2maskbank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetfilter2maskstartposHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2maskstartpos == null)
        Param_Accesscriteria.cb_getfilter2maskstartpos = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_Accesscriteria.n_Getfilter2maskstartpos));
      return Param_Accesscriteria.cb_getfilter2maskstartpos;
    }

    private static short n_Getfilter2maskstartpos(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2maskstartpos();
    }

    [Register("getfilter2maskstartpos", "()S", "GetGetfilter2maskstartposHandler")]
    public virtual unsafe short Getfilter2maskstartpos()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualInt16Method("getfilter2maskstartpos.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter2matchlengthHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2matchlength == null)
        Param_Accesscriteria.cb_getfilter2matchlength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_Accesscriteria.n_Getfilter2matchlength));
      return Param_Accesscriteria.cb_getfilter2matchlength;
    }

    private static short n_Getfilter2matchlength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2matchlength();
    }

    [Register("getfilter2matchlength", "()S", "GetGetfilter2matchlengthHandler")]
    public virtual unsafe short Getfilter2matchlength()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualInt16Method("getfilter2matchlength.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetfilter2nomatchHandler()
    {
      if ((object) Param_Accesscriteria.cb_getfilter2nomatch == null)
        Param_Accesscriteria.cb_getfilter2nomatch = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_Accesscriteria.n_Getfilter2nomatch));
      return Param_Accesscriteria.cb_getfilter2nomatch;
    }

    private static bool n_Getfilter2nomatch(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Getfilter2nomatch();
    }

    [Register("getfilter2nomatch", "()Z", "GetGetfilter2nomatchHandler")]
    public virtual unsafe bool Getfilter2nomatch()
    {
      return Param_Accesscriteria._members.InstanceMethods.InvokeVirtualBooleanMethod("getfilter2nomatch.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetfilter1data_arrayBHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1data_arrayB == null)
        Param_Accesscriteria.cb_setfilter1data_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter1data_arrayB));
      return Param_Accesscriteria.cb_setfilter1data_arrayB;
    }

    private static void n_Setfilter1data_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Param_Accesscriteria paramAccesscriteria = Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      paramAccesscriteria.Setfilter1data(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setfilter1data", "([B)V", "GetSetfilter1data_arrayBHandler")]
    public virtual unsafe void Setfilter1data(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1data.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetfilter1domatch_ZHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1domatch_Z == null)
        Param_Accesscriteria.cb_setfilter1domatch_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_Accesscriteria.n_Setfilter1domatch_Z));
      return Param_Accesscriteria.cb_setfilter1domatch_Z;
    }

    private static void n_Setfilter1domatch_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter1domatch(value);
    }

    [Register("setfilter1domatch", "(Z)V", "GetSetfilter1domatch_ZHandler")]
    public virtual unsafe void Setfilter1domatch(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1domatch.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter1mask_arrayBHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1mask_arrayB == null)
        Param_Accesscriteria.cb_setfilter1mask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter1mask_arrayB));
      return Param_Accesscriteria.cb_setfilter1mask_arrayB;
    }

    private static void n_Setfilter1mask_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Param_Accesscriteria paramAccesscriteria = Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      paramAccesscriteria.Setfilter1mask(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setfilter1mask", "([B)V", "GetSetfilter1mask_arrayBHandler")]
    public virtual unsafe void Setfilter1mask(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1mask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Param_Accesscriteria.cb_setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Param_Accesscriteria.cb_setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_Setfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter1maskbank(Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setfilter1maskbank", "(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", "GetSetfilter1maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler")]
    public virtual unsafe void Setfilter1maskbank(ENUM_MEMORY_BANK? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1maskbank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }

    private static Delegate GetSetfilter1maskstartpos_SHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1maskstartpos_S == null)
        Param_Accesscriteria.cb_setfilter1maskstartpos_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_Accesscriteria.n_Setfilter1maskstartpos_S));
      return Param_Accesscriteria.cb_setfilter1maskstartpos_S;
    }

    private static void n_Setfilter1maskstartpos_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter1maskstartpos(value);
    }

    [Register("setfilter1maskstartpos", "(S)V", "GetSetfilter1maskstartpos_SHandler")]
    public virtual unsafe void Setfilter1maskstartpos(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1maskstartpos.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter1matchlength_SHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1matchlength_S == null)
        Param_Accesscriteria.cb_setfilter1matchlength_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_Accesscriteria.n_Setfilter1matchlength_S));
      return Param_Accesscriteria.cb_setfilter1matchlength_S;
    }

    private static void n_Setfilter1matchlength_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter1matchlength(value);
    }

    [Register("setfilter1matchlength", "(S)V", "GetSetfilter1matchlength_SHandler")]
    public virtual unsafe void Setfilter1matchlength(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1matchlength.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter1nomatch_ZHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter1nomatch_Z == null)
        Param_Accesscriteria.cb_setfilter1nomatch_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_Accesscriteria.n_Setfilter1nomatch_Z));
      return Param_Accesscriteria.cb_setfilter1nomatch_Z;
    }

    private static void n_Setfilter1nomatch_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter1nomatch(value);
    }

    [Register("setfilter1nomatch", "(Z)V", "GetSetfilter1nomatch_ZHandler")]
    public virtual unsafe void Setfilter1nomatch(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter1nomatch.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter2data_arrayBHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2data_arrayB == null)
        Param_Accesscriteria.cb_setfilter2data_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter2data_arrayB));
      return Param_Accesscriteria.cb_setfilter2data_arrayB;
    }

    private static void n_Setfilter2data_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Param_Accesscriteria paramAccesscriteria = Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      paramAccesscriteria.Setfilter2data(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setfilter2data", "([B)V", "GetSetfilter2data_arrayBHandler")]
    public virtual unsafe void Setfilter2data(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2data.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetfilter2domatch_ZHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2domatch_Z == null)
        Param_Accesscriteria.cb_setfilter2domatch_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_Accesscriteria.n_Setfilter2domatch_Z));
      return Param_Accesscriteria.cb_setfilter2domatch_Z;
    }

    private static void n_Setfilter2domatch_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter2domatch(value);
    }

    [Register("setfilter2domatch", "(Z)V", "GetSetfilter2domatch_ZHandler")]
    public virtual unsafe void Setfilter2domatch(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2domatch.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter2mask_arrayBHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2mask_arrayB == null)
        Param_Accesscriteria.cb_setfilter2mask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter2mask_arrayB));
      return Param_Accesscriteria.cb_setfilter2mask_arrayB;
    }

    private static void n_Setfilter2mask_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Param_Accesscriteria paramAccesscriteria = Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      paramAccesscriteria.Setfilter2mask(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setfilter2mask", "([B)V", "GetSetfilter2mask_arrayBHandler")]
    public virtual unsafe void Setfilter2mask(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2mask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSetfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Param_Accesscriteria.cb_setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_Accesscriteria.n_Setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Param_Accesscriteria.cb_setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_Setfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter2maskbank(Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0));
    }

    [Register("setfilter2maskbank", "(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", "GetSetfilter2maskbank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler")]
    public virtual unsafe void Setfilter2maskbank(ENUM_MEMORY_BANK? value)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
        };
        Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2maskbank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) value);
      }
    }

    private static Delegate GetSetfilter2maskstartpos_SHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2maskstartpos_S == null)
        Param_Accesscriteria.cb_setfilter2maskstartpos_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_Accesscriteria.n_Setfilter2maskstartpos_S));
      return Param_Accesscriteria.cb_setfilter2maskstartpos_S;
    }

    private static void n_Setfilter2maskstartpos_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter2maskstartpos(value);
    }

    [Register("setfilter2maskstartpos", "(S)V", "GetSetfilter2maskstartpos_SHandler")]
    public virtual unsafe void Setfilter2maskstartpos(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2maskstartpos.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter2matchlength_SHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2matchlength_S == null)
        Param_Accesscriteria.cb_setfilter2matchlength_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_Accesscriteria.n_Setfilter2matchlength_S));
      return Param_Accesscriteria.cb_setfilter2matchlength_S;
    }

    private static void n_Setfilter2matchlength_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter2matchlength(value);
    }

    [Register("setfilter2matchlength", "(S)V", "GetSetfilter2matchlength_SHandler")]
    public virtual unsafe void Setfilter2matchlength(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2matchlength.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetfilter2nomatch_ZHandler()
    {
      if ((object) Param_Accesscriteria.cb_setfilter2nomatch_Z == null)
        Param_Accesscriteria.cb_setfilter2nomatch_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_Accesscriteria.n_Setfilter2nomatch_Z));
      return Param_Accesscriteria.cb_setfilter2nomatch_Z;
    }

    private static void n_Setfilter2nomatch_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_Accesscriteria>(jnienv, native__this, (JniHandleOwnership) 0).Setfilter2nomatch(value);
    }

    [Register("setfilter2nomatch", "(Z)V", "GetSetfilter2nomatch_ZHandler")]
    public virtual unsafe void Setfilter2nomatch(bool value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Param_Accesscriteria._members.InstanceMethods.InvokeVirtualVoidMethod("setfilter2nomatch.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
