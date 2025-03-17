// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LLRPConnectionConfig
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
  [Register("com/zebra/rfid/api3/LLRPConnectionConfig", DoNotGenerateAcw = true)]
  public class LLRPConnectionConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LLRPConnectionConfig", typeof (LLRPConnectionConfig));
    private static Delegate? cb_isClient;
    private static Delegate? cb_setClient_Z;
    private static Delegate? cb_getHostServerIP;
    private static Delegate? cb_setHostServerIP_Ljava_lang_String_;
    private static Delegate? cb_getPort;
    private static Delegate? cb_setPort_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LLRPConnectionConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LLRPConnectionConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LLRPConnectionConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LLRPConnectionConfig._members.ManagedPeerType;

    protected LLRPConnectionConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe LLRPConnectionConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = LLRPConnectionConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      LLRPConnectionConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(ZILjava/lang/String;)V", "")]
    public unsafe LLRPConnectionConfig(bool isCient, int port, string? hostServerIP)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(hostServerIP);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(isCient),
          new JniArgumentValue(port),
          new JniArgumentValue(num)
        };
        JniObjectReference instance = LLRPConnectionConfig._members.InstanceMethods.StartCreateInstance("(ZILjava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        LLRPConnectionConfig._members.InstanceMethods.FinishCreateInstance("(ZILjava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetIsClientHandler()
    {
      if ((object) LLRPConnectionConfig.cb_isClient == null)
        LLRPConnectionConfig.cb_isClient = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(LLRPConnectionConfig.n_IsClient));
      return LLRPConnectionConfig.cb_isClient;
    }

    private static bool n_IsClient(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).Client;
    }

    private static Delegate GetSetClient_ZHandler()
    {
      if ((object) LLRPConnectionConfig.cb_setClient_Z == null)
        LLRPConnectionConfig.cb_setClient_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(LLRPConnectionConfig.n_SetClient_Z));
      return LLRPConnectionConfig.cb_setClient_Z;
    }

    private static void n_SetClient_Z(IntPtr jnienv, IntPtr native__this, bool m_IsClient)
    {
      Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).Client = m_IsClient;
    }

    public virtual unsafe bool Client
    {
      [Register("isClient", "()Z", "GetIsClientHandler")] get
      {
        return LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("isClient.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setClient", "(Z)V", "GetSetClient_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setClient.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetHostServerIPHandler()
    {
      if ((object) LLRPConnectionConfig.cb_getHostServerIP == null)
        LLRPConnectionConfig.cb_getHostServerIP = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LLRPConnectionConfig.n_GetHostServerIP));
      return LLRPConnectionConfig.cb_getHostServerIP;
    }

    private static IntPtr n_GetHostServerIP(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).HostServerIP);
    }

    private static Delegate GetSetHostServerIP_Ljava_lang_String_Handler()
    {
      if ((object) LLRPConnectionConfig.cb_setHostServerIP_Ljava_lang_String_ == null)
        LLRPConnectionConfig.cb_setHostServerIP_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LLRPConnectionConfig.n_SetHostServerIP_Ljava_lang_String_));
      return LLRPConnectionConfig.cb_setHostServerIP_Ljava_lang_String_;
    }

    private static void n_SetHostServerIP_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_HostServerIP)
    {
      Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).HostServerIP = JNIEnv.GetString(native_m_HostServerIP, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? HostServerIP
    {
      [Register("getHostServerIP", "()Ljava/lang/String;", "GetGetHostServerIPHandler")] get
      {
        JniObjectReference jniObjectReference = LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getHostServerIP.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHostServerIP", "(Ljava/lang/String;)V", "GetSetHostServerIP_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setHostServerIP.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPortHandler()
    {
      if ((object) LLRPConnectionConfig.cb_getPort == null)
        LLRPConnectionConfig.cb_getPort = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LLRPConnectionConfig.n_GetPort));
      return LLRPConnectionConfig.cb_getPort;
    }

    private static int n_GetPort(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).Port;
    }

    private static Delegate GetSetPort_IHandler()
    {
      if ((object) LLRPConnectionConfig.cb_setPort_I == null)
        LLRPConnectionConfig.cb_setPort_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(LLRPConnectionConfig.n_SetPort_I));
      return LLRPConnectionConfig.cb_setPort_I;
    }

    private static void n_SetPort_I(IntPtr jnienv, IntPtr native__this, int m_Port)
    {
      Object.GetObject<LLRPConnectionConfig>(jnienv, native__this, (JniHandleOwnership) 0).Port = m_Port;
    }

    public virtual unsafe int Port
    {
      [Register("getPort", "()I", "GetGetPortHandler")] get
      {
        return LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualInt32Method("getPort.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPort", "(I)V", "GetSetPort_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LLRPConnectionConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setPort.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
