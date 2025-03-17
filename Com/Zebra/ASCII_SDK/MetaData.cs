// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.MetaData
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
  [Register("com/zebra/ASCII_SDK/MetaData", DoNotGenerateAcw = true)]
  public abstract class MetaData : Object, IMsg, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/MetaData", typeof (MetaData));
    private static Delegate? cb_getMsgType;
    private static Delegate? cb_getResponseType;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MetaData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MetaData._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MetaData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MetaData._members.ManagedPeerType;

    protected MetaData(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe MetaData()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = MetaData._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      MetaData._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetMsgTypeHandler()
    {
      if ((object) MetaData.cb_getMsgType == null)
        MetaData.cb_getMsgType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MetaData.n_GetMsgType));
      return MetaData.cb_getMsgType;
    }

    private static IntPtr n_GetMsgType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MetaData>(jnienv, native__this, (JniHandleOwnership) 0).MsgType);
    }

    public virtual unsafe MSG_TYPE? MsgType
    {
      [Register("getMsgType", "()Lcom/zebra/ASCII_SDK/MSG_TYPE;", "GetGetMsgTypeHandler")] get
      {
        JniObjectReference jniObjectReference = MetaData._members.InstanceMethods.InvokeVirtualObjectMethod("getMsgType.()Lcom/zebra/ASCII_SDK/MSG_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MSG_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetResponseTypeHandler()
    {
      if ((object) MetaData.cb_getResponseType == null)
        MetaData.cb_getResponseType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MetaData.n_GetResponseType));
      return MetaData.cb_getResponseType;
    }

    private static IntPtr n_GetResponseType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MetaData>(jnienv, native__this, (JniHandleOwnership) 0).ResponseType);
    }

    public abstract RESPONSE_TYPE? ResponseType { [Register("getResponseType", "()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "GetGetResponseTypeHandler")] get; }
  }
}
