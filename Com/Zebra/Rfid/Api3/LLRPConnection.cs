// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LLRPConnection
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
  [Register("com/zebra/rfid/api3/LLRPConnection", DoNotGenerateAcw = true)]
  public class LLRPConnection : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LLRPConnection", typeof (LLRPConnection));
    private static Delegate? cb_getLLRPConnectionConfig;
    private static Delegate? cb_setLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_;
    private static Delegate? cb_disconnectFromReader;
    private static Delegate? cb_initiateFromReader;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LLRPConnection._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LLRPConnection._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LLRPConnection._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LLRPConnection._members.ManagedPeerType;

    protected LLRPConnection(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetLLRPConnectionConfigHandler()
    {
      if ((object) LLRPConnection.cb_getLLRPConnectionConfig == null)
        LLRPConnection.cb_getLLRPConnectionConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LLRPConnection.n_GetLLRPConnectionConfig));
      return LLRPConnection.cb_getLLRPConnectionConfig;
    }

    private static IntPtr n_GetLLRPConnectionConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<LLRPConnection>(jnienv, native__this, (JniHandleOwnership) 0).LLRPConnectionConfig);
    }

    private static Delegate GetSetLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_Handler()
    {
      if ((object) LLRPConnection.cb_setLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_ == null)
        LLRPConnection.cb_setLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LLRPConnection.n_SetLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_));
      return LLRPConnection.cb_setLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_;
    }

    private static void n_SetLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_llrpConnectionConfig)
    {
      Object.GetObject<LLRPConnection>(jnienv, native__this, (JniHandleOwnership) 0).LLRPConnectionConfig = Object.GetObject<LLRPConnectionConfig>(native_llrpConnectionConfig, (JniHandleOwnership) 0);
    }

    public virtual unsafe LLRPConnectionConfig? LLRPConnectionConfig
    {
      [Register("getLLRPConnectionConfig", "()Lcom/zebra/rfid/api3/LLRPConnectionConfig;", "GetGetLLRPConnectionConfigHandler")] get
      {
        JniObjectReference jniObjectReference = LLRPConnection._members.InstanceMethods.InvokeVirtualObjectMethod("getLLRPConnectionConfig.()Lcom/zebra/rfid/api3/LLRPConnectionConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<LLRPConnectionConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setLLRPConnectionConfig", "(Lcom/zebra/rfid/api3/LLRPConnectionConfig;)V", "GetSetLLRPConnectionConfig_Lcom_zebra_rfid_api3_LLRPConnectionConfig_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          LLRPConnection._members.InstanceMethods.InvokeVirtualVoidMethod("setLLRPConnectionConfig.(Lcom/zebra/rfid/api3/LLRPConnectionConfig;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetDisconnectFromReaderHandler()
    {
      if ((object) LLRPConnection.cb_disconnectFromReader == null)
        LLRPConnection.cb_disconnectFromReader = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(LLRPConnection.n_DisconnectFromReader));
      return LLRPConnection.cb_disconnectFromReader;
    }

    private static void n_DisconnectFromReader(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<LLRPConnection>(jnienv, native__this, (JniHandleOwnership) 0).DisconnectFromReader();
    }

    [Register("disconnectFromReader", "()V", "GetDisconnectFromReaderHandler")]
    public virtual unsafe void DisconnectFromReader()
    {
      LLRPConnection._members.InstanceMethods.InvokeVirtualVoidMethod("disconnectFromReader.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetInitiateFromReaderHandler()
    {
      if ((object) LLRPConnection.cb_initiateFromReader == null)
        LLRPConnection.cb_initiateFromReader = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(LLRPConnection.n_InitiateFromReader));
      return LLRPConnection.cb_initiateFromReader;
    }

    private static void n_InitiateFromReader(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<LLRPConnection>(jnienv, native__this, (JniHandleOwnership) 0).InitiateFromReader();
    }

    [Register("initiateFromReader", "()V", "GetInitiateFromReaderHandler")]
    public virtual unsafe void InitiateFromReader()
    {
      LLRPConnection._members.InstanceMethods.InvokeVirtualVoidMethod("initiateFromReader.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
