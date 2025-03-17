// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Response_VersionInfo
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
  [Register("com/zebra/ASCII_SDK/Response_VersionInfo", DoNotGenerateAcw = true)]
  public class Response_VersionInfo : ResponseMsg
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Response_VersionInfo", typeof (Response_VersionInfo));
    private static Delegate? cb_getResponseType;

    [Register("Device")]
    public string? Device
    {
      get
      {
        JniObjectReference objectValue = Response_VersionInfo._members.InstanceFields.GetObjectValue("Device.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Response_VersionInfo._members.InstanceFields.SetValue("Device.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("Version")]
    public string? Version
    {
      get
      {
        JniObjectReference objectValue = Response_VersionInfo._members.InstanceFields.GetObjectValue("Version.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Response_VersionInfo._members.InstanceFields.SetValue("Version.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Response_VersionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Response_VersionInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Response_VersionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Response_VersionInfo._members.ManagedPeerType;

    protected Response_VersionInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Response_VersionInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Response_VersionInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Response_VersionInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetResponseTypeHandler()
    {
      if ((object) Response_VersionInfo.cb_getResponseType == null)
        Response_VersionInfo.cb_getResponseType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Response_VersionInfo.n_GetResponseType));
      return Response_VersionInfo.cb_getResponseType;
    }

    private static IntPtr n_GetResponseType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Response_VersionInfo>(jnienv, native__this, (JniHandleOwnership) 0).ResponseType);
    }

    public override unsafe RESPONSE_TYPE? ResponseType
    {
      [Register("getResponseType", "()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "GetGetResponseTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Response_VersionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getResponseType.()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_VersionInfo;", "")]
    public static unsafe Response_VersionInfo? FromString(string? str, MetaData? mData)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(mData == null ? IntPtr.Zero : mData.Handle)
        };
        JniObjectReference jniObjectReference = Response_VersionInfo._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_VersionInfo;", jniArgumentValuePtr);
        return Object.GetObject<Response_VersionInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) mData);
      }
    }
  }
}
