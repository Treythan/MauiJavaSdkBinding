// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WPA_EVENT
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
  [Register("com/zebra/rfid/api3/WPA_EVENT", DoNotGenerateAcw = true)]
  public class WPA_EVENT : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WPA_EVENT", typeof (WPA_EVENT));
    private static Delegate? cb_getType;
    private static Delegate? cb_setType_Ljava_lang_String_;
    private static Delegate? cb_getssid;
    private static Delegate? cb_setssid_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WPA_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WPA_EVENT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WPA_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual System.Type ThresholdType => WPA_EVENT._members.ManagedPeerType;

    protected WPA_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe WPA_EVENT()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = WPA_EVENT._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      WPA_EVENT._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetTypeHandler()
    {
      if ((object) WPA_EVENT.cb_getType == null)
        WPA_EVENT.cb_getType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WPA_EVENT.n_GetType));
      return WPA_EVENT.cb_getType;
    }

    private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WPA_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Type);
    }

    private static Delegate GetSetType_Ljava_lang_String_Handler()
    {
      if ((object) WPA_EVENT.cb_setType_Ljava_lang_String_ == null)
        WPA_EVENT.cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WPA_EVENT.n_SetType_Ljava_lang_String_));
      return WPA_EVENT.cb_setType_Ljava_lang_String_;
    }

    private static void n_SetType_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_Type)
    {
      Object.GetObject<WPA_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Type = JNIEnv.GetString(native_Type, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Type
    {
      [Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler")] get
      {
        JniObjectReference jniObjectReference = WPA_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          WPA_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setType.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetssidHandler()
    {
      if ((object) WPA_EVENT.cb_getssid == null)
        WPA_EVENT.cb_getssid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WPA_EVENT.n_Getssid));
      return WPA_EVENT.cb_getssid;
    }

    private static IntPtr n_Getssid(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WPA_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Getssid());
    }

    [Register("getssid", "()Ljava/lang/String;", "GetGetssidHandler")]
    public virtual unsafe string? Getssid()
    {
      JniObjectReference jniObjectReference = WPA_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getssid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetssid_Ljava_lang_String_Handler()
    {
      if ((object) WPA_EVENT.cb_setssid_Ljava_lang_String_ == null)
        WPA_EVENT.cb_setssid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WPA_EVENT.n_Setssid_Ljava_lang_String_));
      return WPA_EVENT.cb_setssid_Ljava_lang_String_;
    }

    private static void n_Setssid_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_ssid)
    {
      Object.GetObject<WPA_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Setssid(JNIEnv.GetString(native_ssid, (JniHandleOwnership) 0));
    }

    [Register("setssid", "(Ljava/lang/String;)V", "GetSetssid_Ljava_lang_String_Handler")]
    public virtual unsafe void Setssid(string? ssid)
    {
      IntPtr num = JNIEnv.NewString(ssid);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WPA_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setssid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
