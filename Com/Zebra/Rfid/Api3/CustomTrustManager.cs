// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CustomTrustManager
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security.Cert;
using Javax.Net.Ssl;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/CustomTrustManager", DoNotGenerateAcw = true)]
  public class CustomTrustManager : 
    Object,
    IX509TrustManager,
    ITrustManager,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CustomTrustManager", typeof (CustomTrustManager));
    private static Delegate? cb_getDefaultCertificates;
    private static Delegate? cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
    private static Delegate? cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
    private static Delegate? cb_getAcceptedIssuers;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CustomTrustManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CustomTrustManager._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CustomTrustManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CustomTrustManager._members.ManagedPeerType;

    protected CustomTrustManager(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe CustomTrustManager()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = CustomTrustManager._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      CustomTrustManager._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetDefaultCertificatesHandler()
    {
      if ((object) CustomTrustManager.cb_getDefaultCertificates == null)
        CustomTrustManager.cb_getDefaultCertificates = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CustomTrustManager.n_GetDefaultCertificates));
      return CustomTrustManager.cb_getDefaultCertificates;
    }

    private static IntPtr n_GetDefaultCertificates(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<CustomTrustManager>(jnienv, native__this, (JniHandleOwnership) 0).DefaultCertificates);
    }

    public virtual unsafe IX509TrustManager? DefaultCertificates
    {
      [Register("getDefaultCertificates", "()Ljavax/net/ssl/X509TrustManager;", "GetGetDefaultCertificatesHandler")] get
      {
        JniObjectReference jniObjectReference = CustomTrustManager._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultCertificates.()Ljavax/net/ssl/X509TrustManager;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<IX509TrustManager>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler()
    {
      if ((object) CustomTrustManager.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
        CustomTrustManager.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(CustomTrustManager.n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_));
      return CustomTrustManager.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
    }

    private static void n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_x509Certificates,
      IntPtr native_s)
    {
      CustomTrustManager customTrustManager = Object.GetObject<CustomTrustManager>(jnienv, native__this, (JniHandleOwnership) 0);
      X509Certificate[] array = (X509Certificate[]) JNIEnv.GetArray(native_x509Certificates, (JniHandleOwnership) 0, typeof (X509Certificate));
      string str = JNIEnv.GetString(native_s, (JniHandleOwnership) 0);
      X509Certificate[] x509Certificates = array;
      string s = str;
      customTrustManager.CheckClientTrusted(x509Certificates, s);
      if (array == null)
        return;
      JNIEnv.CopyArray<X509Certificate>(array, native_x509Certificates);
    }

    [Register("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
    public virtual unsafe void CheckClientTrusted(X509Certificate[]? x509Certificates, string? s)
    {
      IntPtr num1 = JNIEnv.NewArray<X509Certificate>(x509Certificates);
      IntPtr num2 = JNIEnv.NewString(s);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        CustomTrustManager._members.InstanceMethods.InvokeVirtualVoidMethod("checkClientTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (x509Certificates != null)
        {
          JNIEnv.CopyArray<X509Certificate>(num1, x509Certificates);
          JNIEnv.DeleteLocalRef(num1);
        }
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) x509Certificates);
      }
    }

    private static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler()
    {
      if ((object) CustomTrustManager.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
        CustomTrustManager.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(CustomTrustManager.n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_));
      return CustomTrustManager.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
    }

    private static void n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_x509CertificateArray,
      IntPtr native_authType)
    {
      CustomTrustManager customTrustManager = Object.GetObject<CustomTrustManager>(jnienv, native__this, (JniHandleOwnership) 0);
      X509Certificate[] array = (X509Certificate[]) JNIEnv.GetArray(native_x509CertificateArray, (JniHandleOwnership) 0, typeof (X509Certificate));
      string str = JNIEnv.GetString(native_authType, (JniHandleOwnership) 0);
      X509Certificate[] x509CertificateArray = array;
      string authType = str;
      customTrustManager.CheckServerTrusted(x509CertificateArray, authType);
      if (array == null)
        return;
      JNIEnv.CopyArray<X509Certificate>(array, native_x509CertificateArray);
    }

    [Register("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
    public virtual unsafe void CheckServerTrusted(
      X509Certificate[]? x509CertificateArray,
      string? authType)
    {
      IntPtr num1 = JNIEnv.NewArray<X509Certificate>(x509CertificateArray);
      IntPtr num2 = JNIEnv.NewString(authType);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        CustomTrustManager._members.InstanceMethods.InvokeVirtualVoidMethod("checkServerTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (x509CertificateArray != null)
        {
          JNIEnv.CopyArray<X509Certificate>(num1, x509CertificateArray);
          JNIEnv.DeleteLocalRef(num1);
        }
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) x509CertificateArray);
      }
    }

    private static Delegate GetGetAcceptedIssuersHandler()
    {
      if ((object) CustomTrustManager.cb_getAcceptedIssuers == null)
        CustomTrustManager.cb_getAcceptedIssuers = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CustomTrustManager.n_GetAcceptedIssuers));
      return CustomTrustManager.cb_getAcceptedIssuers;
    }

    private static IntPtr n_GetAcceptedIssuers(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<X509Certificate>(Object.GetObject<CustomTrustManager>(jnienv, native__this, (JniHandleOwnership) 0).GetAcceptedIssuers());
    }

    [Register("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "GetGetAcceptedIssuersHandler")]
    public virtual unsafe X509Certificate[]? GetAcceptedIssuers()
    {
      JniObjectReference jniObjectReference = CustomTrustManager._members.InstanceMethods.InvokeVirtualObjectMethod("getAcceptedIssuers.()[Ljava/security/cert/X509Certificate;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (X509Certificate[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (X509Certificate));
    }
  }
}
