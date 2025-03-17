// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Network_IPConfig
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
  [Register("com/zebra/rfid/api3/Network_IPConfig", DoNotGenerateAcw = true)]
  public class Network_IPConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Network_IPConfig", typeof (Network_IPConfig));
    private static Delegate? cb_getMacAddress;
    private static Delegate? cb_setMacAddress_Ljava_lang_String_;
    private static Delegate? cb_getType;
    private static Delegate? cb_setType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_;
    private static Delegate? cb_getdns;
    private static Delegate? cb_getgateway;
    private static Delegate? cb_getipaddress;
    private static Delegate? cb_getnetmask;
    private static Delegate? cb_setdns_Ljava_lang_String_;
    private static Delegate? cb_setgateway_Ljava_lang_String_;
    private static Delegate? cb_setipaddress_Ljava_lang_String_;
    private static Delegate? cb_setnetmask_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Network_IPConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Network_IPConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Network_IPConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual System.Type ThresholdType => Network_IPConfig._members.ManagedPeerType;

    protected Network_IPConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Network_IPConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Network_IPConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Network_IPConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetMacAddressHandler()
    {
      if ((object) Network_IPConfig.cb_getMacAddress == null)
        Network_IPConfig.cb_getMacAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_GetMacAddress));
      return Network_IPConfig.cb_getMacAddress;
    }

    private static IntPtr n_GetMacAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).MacAddress);
    }

    private static Delegate GetSetMacAddress_Ljava_lang_String_Handler()
    {
      if ((object) Network_IPConfig.cb_setMacAddress_Ljava_lang_String_ == null)
        Network_IPConfig.cb_setMacAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_SetMacAddress_Ljava_lang_String_));
      return Network_IPConfig.cb_setMacAddress_Ljava_lang_String_;
    }

    private static void n_SetMacAddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_macAddress)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).MacAddress = JNIEnv.GetString(native_macAddress, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? MacAddress
    {
      [Register("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")] get
      {
        JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getMacAddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMacAddress", "(Ljava/lang/String;)V", "GetSetMacAddress_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setMacAddress.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetTypeHandler()
    {
      if ((object) Network_IPConfig.cb_getType == null)
        Network_IPConfig.cb_getType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_GetType));
      return Network_IPConfig.cb_getType;
    }

    private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Type);
    }

    private static Delegate GetSetType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_Handler()
    {
      if ((object) Network_IPConfig.cb_setType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_ == null)
        Network_IPConfig.cb_setType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_SetType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_));
      return Network_IPConfig.cb_setType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_;
    }

    private static void n_SetType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_type)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Type = Object.GetObject<NETWORK_CONFIG>(native_type, (JniHandleOwnership) 0);
    }

    public virtual unsafe NETWORK_CONFIG? Type
    {
      [Register("getType", "()Lcom/zebra/rfid/api3/NETWORK_CONFIG;", "GetGetTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Lcom/zebra/rfid/api3/NETWORK_CONFIG;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<NETWORK_CONFIG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setType", "(Lcom/zebra/rfid/api3/NETWORK_CONFIG;)V", "GetSetType_Lcom_zebra_rfid_api3_NETWORK_CONFIG_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setType.(Lcom/zebra/rfid/api3/NETWORK_CONFIG;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetdnsHandler()
    {
      if ((object) Network_IPConfig.cb_getdns == null)
        Network_IPConfig.cb_getdns = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_Getdns));
      return Network_IPConfig.cb_getdns;
    }

    private static IntPtr n_Getdns(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getdns());
    }

    [Register("getdns", "()Ljava/lang/String;", "GetGetdnsHandler")]
    public virtual unsafe string? Getdns()
    {
      JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getdns.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetgatewayHandler()
    {
      if ((object) Network_IPConfig.cb_getgateway == null)
        Network_IPConfig.cb_getgateway = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_Getgateway));
      return Network_IPConfig.cb_getgateway;
    }

    private static IntPtr n_Getgateway(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getgateway());
    }

    [Register("getgateway", "()Ljava/lang/String;", "GetGetgatewayHandler")]
    public virtual unsafe string? Getgateway()
    {
      JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getgateway.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetipaddressHandler()
    {
      if ((object) Network_IPConfig.cb_getipaddress == null)
        Network_IPConfig.cb_getipaddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_Getipaddress));
      return Network_IPConfig.cb_getipaddress;
    }

    private static IntPtr n_Getipaddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getipaddress());
    }

    [Register("getipaddress", "()Ljava/lang/String;", "GetGetipaddressHandler")]
    public virtual unsafe string? Getipaddress()
    {
      JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getipaddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetnetmaskHandler()
    {
      if ((object) Network_IPConfig.cb_getnetmask == null)
        Network_IPConfig.cb_getnetmask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Network_IPConfig.n_Getnetmask));
      return Network_IPConfig.cb_getnetmask;
    }

    private static IntPtr n_Getnetmask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Getnetmask());
    }

    [Register("getnetmask", "()Ljava/lang/String;", "GetGetnetmaskHandler")]
    public virtual unsafe string? Getnetmask()
    {
      JniObjectReference jniObjectReference = Network_IPConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getnetmask.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetdns_Ljava_lang_String_Handler()
    {
      if ((object) Network_IPConfig.cb_setdns_Ljava_lang_String_ == null)
        Network_IPConfig.cb_setdns_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_Setdns_Ljava_lang_String_));
      return Network_IPConfig.cb_setdns_Ljava_lang_String_;
    }

    private static void n_Setdns_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setdns(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setdns", "(Ljava/lang/String;)V", "GetSetdns_Ljava_lang_String_Handler")]
    public virtual unsafe void Setdns(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setdns.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetgateway_Ljava_lang_String_Handler()
    {
      if ((object) Network_IPConfig.cb_setgateway_Ljava_lang_String_ == null)
        Network_IPConfig.cb_setgateway_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_Setgateway_Ljava_lang_String_));
      return Network_IPConfig.cb_setgateway_Ljava_lang_String_;
    }

    private static void n_Setgateway_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setgateway(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setgateway", "(Ljava/lang/String;)V", "GetSetgateway_Ljava_lang_String_Handler")]
    public virtual unsafe void Setgateway(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setgateway.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetipaddress_Ljava_lang_String_Handler()
    {
      if ((object) Network_IPConfig.cb_setipaddress_Ljava_lang_String_ == null)
        Network_IPConfig.cb_setipaddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_Setipaddress_Ljava_lang_String_));
      return Network_IPConfig.cb_setipaddress_Ljava_lang_String_;
    }

    private static void n_Setipaddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setipaddress(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setipaddress", "(Ljava/lang/String;)V", "GetSetipaddress_Ljava_lang_String_Handler")]
    public virtual unsafe void Setipaddress(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setipaddress.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetnetmask_Ljava_lang_String_Handler()
    {
      if ((object) Network_IPConfig.cb_setnetmask_Ljava_lang_String_ == null)
        Network_IPConfig.cb_setnetmask_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Network_IPConfig.n_Setnetmask_Ljava_lang_String_));
      return Network_IPConfig.cb_setnetmask_Ljava_lang_String_;
    }

    private static void n_Setnetmask_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Network_IPConfig>(jnienv, native__this, (JniHandleOwnership) 0).Setnetmask(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setnetmask", "(Ljava/lang/String;)V", "GetSetnetmask_Ljava_lang_String_Handler")]
    public virtual unsafe void Setnetmask(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Network_IPConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setnetmask.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
