// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WifiScanData
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/WifiScanData", DoNotGenerateAcw = true)]
  public class WifiScanData : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WifiScanData", typeof (WifiScanData));
    private static Delegate? cb_getLevel;
    private static Delegate? cb_setLevel_I;
    private static Delegate? cb_getProtocol;
    private static Delegate? cb_setProtocol_Ljava_util_ArrayList_;
    private static Delegate? cb_getmacaddress;
    private static Delegate? cb_getssid;
    private static Delegate? cb_setMacaddress_Ljava_lang_String_;
    private static Delegate? cb_setssid_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WifiScanData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WifiScanData._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WifiScanData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => WifiScanData._members.ManagedPeerType;

    protected WifiScanData(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe WifiScanData()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = WifiScanData._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      WifiScanData._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetLevelHandler()
    {
      if ((object) WifiScanData.cb_getLevel == null)
        WifiScanData.cb_getLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WifiScanData.n_GetLevel));
      return WifiScanData.cb_getLevel;
    }

    private static int n_GetLevel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Level;
    }

    private static Delegate GetSetLevel_IHandler()
    {
      if ((object) WifiScanData.cb_setLevel_I == null)
        WifiScanData.cb_setLevel_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(WifiScanData.n_SetLevel_I));
      return WifiScanData.cb_setLevel_I;
    }

    private static void n_SetLevel_I(IntPtr jnienv, IntPtr native__this, int level)
    {
      Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Level = level;
    }

    public virtual unsafe int Level
    {
      [Register("getLevel", "()I", "GetGetLevelHandler")] get
      {
        return WifiScanData._members.InstanceMethods.InvokeVirtualInt32Method("getLevel.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLevel", "(I)V", "GetSetLevel_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WifiScanData._members.InstanceMethods.InvokeVirtualVoidMethod("setLevel.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetProtocolHandler()
    {
      if ((object) WifiScanData.cb_getProtocol == null)
        WifiScanData.cb_getProtocol = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiScanData.n_GetProtocol));
      return WifiScanData.cb_getProtocol;
    }

    private static IntPtr n_GetProtocol(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<ENUM_WIFI_PROTOCOL_TYPE>.ToLocalJniHandle(Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Protocol);
    }

    private static Delegate GetSetProtocol_Ljava_util_ArrayList_Handler()
    {
      if ((object) WifiScanData.cb_setProtocol_Ljava_util_ArrayList_ == null)
        WifiScanData.cb_setProtocol_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiScanData.n_SetProtocol_Ljava_util_ArrayList_));
      return WifiScanData.cb_setProtocol_Ljava_util_ArrayList_;
    }

    private static void n_SetProtocol_Ljava_util_ArrayList_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Protocol = JavaList<ENUM_WIFI_PROTOCOL_TYPE>.FromJniHandle(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe IList<ENUM_WIFI_PROTOCOL_TYPE>? Protocol
    {
      [Register("getProtocol", "()Ljava/util/ArrayList;", "GetGetProtocolHandler")] get
      {
        JniObjectReference jniObjectReference = WifiScanData._members.InstanceMethods.InvokeVirtualObjectMethod("getProtocol.()Ljava/util/ArrayList;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JavaList<ENUM_WIFI_PROTOCOL_TYPE>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setProtocol", "(Ljava/util/ArrayList;)V", "GetSetProtocol_Ljava_util_ArrayList_Handler")] set
      {
        IntPtr localJniHandle = JavaList<ENUM_WIFI_PROTOCOL_TYPE>.ToLocalJniHandle(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(localJniHandle)
          };
          WifiScanData._members.InstanceMethods.InvokeVirtualVoidMethod("setProtocol.(Ljava/util/ArrayList;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetmacaddressHandler()
    {
      if ((object) WifiScanData.cb_getmacaddress == null)
        WifiScanData.cb_getmacaddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiScanData.n_Getmacaddress));
      return WifiScanData.cb_getmacaddress;
    }

    private static IntPtr n_Getmacaddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Getmacaddress());
    }

    [Register("getmacaddress", "()Ljava/lang/String;", "GetGetmacaddressHandler")]
    public virtual unsafe string? Getmacaddress()
    {
      JniObjectReference jniObjectReference = WifiScanData._members.InstanceMethods.InvokeVirtualObjectMethod("getmacaddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetssidHandler()
    {
      if ((object) WifiScanData.cb_getssid == null)
        WifiScanData.cb_getssid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WifiScanData.n_Getssid));
      return WifiScanData.cb_getssid;
    }

    private static IntPtr n_Getssid(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Getssid());
    }

    [Register("getssid", "()Ljava/lang/String;", "GetGetssidHandler")]
    public virtual unsafe string? Getssid()
    {
      JniObjectReference jniObjectReference = WifiScanData._members.InstanceMethods.InvokeVirtualObjectMethod("getssid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetMacaddress_Ljava_lang_String_Handler()
    {
      if ((object) WifiScanData.cb_setMacaddress_Ljava_lang_String_ == null)
        WifiScanData.cb_setMacaddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiScanData.n_SetMacaddress_Ljava_lang_String_));
      return WifiScanData.cb_setMacaddress_Ljava_lang_String_;
    }

    private static void n_SetMacaddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).SetMacaddress(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setMacaddress", "(Ljava/lang/String;)V", "GetSetMacaddress_Ljava_lang_String_Handler")]
    public virtual unsafe void SetMacaddress(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiScanData._members.InstanceMethods.InvokeVirtualVoidMethod("setMacaddress.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetssid_Ljava_lang_String_Handler()
    {
      if ((object) WifiScanData.cb_setssid_Ljava_lang_String_ == null)
        WifiScanData.cb_setssid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WifiScanData.n_Setssid_Ljava_lang_String_));
      return WifiScanData.cb_setssid_Ljava_lang_String_;
    }

    private static void n_Setssid_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<WifiScanData>(jnienv, native__this, (JniHandleOwnership) 0).Setssid(JNIEnv.GetString(native_value, (JniHandleOwnership) 0));
    }

    [Register("setssid", "(Ljava/lang/String;)V", "GetSetssid_Ljava_lang_String_Handler")]
    public virtual unsafe void Setssid(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WifiScanData._members.InstanceMethods.InvokeVirtualVoidMethod("setssid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
