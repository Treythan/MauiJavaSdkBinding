// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFIDReader
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
  [Register("com/zebra/rfid/api3/RFIDReader", DoNotGenerateAcw = true)]
  public class RFIDReader : Object
  {
    [Register("DEFAULT_LLRP_TXN_RSP_TIMEOUT")]
    public const int DefaultLlrpTxnRspTimeout = 5000;
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDReader", typeof (RFIDReader));
    private static Delegate? cb_getHostName;
    private static Delegate? cb_setHostName_Ljava_lang_String_;
    private static Delegate? cb_isCapabilitiesReceived;
    private static Delegate? cb_isConnected;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getPort;
    private static Delegate? cb_setPort_I;
    private static Delegate? cb_getTimeout;
    private static Delegate? cb_setTimeout_I;
    private static Delegate? cb_getTransport;
    private static Delegate? cb_AcceptConnection_J;
    private static Delegate? cb_Dispose;
    private static Delegate? cb_Dispose_Z;
    private static Delegate? cb_PostConnectReaderUpdate;
    private static Delegate? cb_connect;
    private static Delegate? cb_disconnect;
    private static Delegate? cb_reconnect;
    private static Delegate? cb_reinitTransport;
    private static Delegate? cb_secureConnection_Z;
    private static Delegate? cb_switchMode;
    private static Delegate? cb_versionInfo;

    [Register("Actions")]
    public Actions? Actions
    {
      get
      {
        JniObjectReference objectValue = RFIDReader._members.InstanceFields.GetObjectValue("Actions.Lcom/zebra/rfid/api3/Actions;", (IJavaPeerable) this);
        return Object.GetObject<Actions>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          RFIDReader._members.InstanceFields.SetValue("Actions.Lcom/zebra/rfid/api3/Actions;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Config")]
    public Config? Config
    {
      get
      {
        JniObjectReference objectValue = RFIDReader._members.InstanceFields.GetObjectValue("Config.Lcom/zebra/rfid/api3/Config;", (IJavaPeerable) this);
        return Object.GetObject<Config>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          RFIDReader._members.InstanceFields.SetValue("Config.Lcom/zebra/rfid/api3/Config;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Events")]
    public Events? Events
    {
      get
      {
        JniObjectReference objectValue = RFIDReader._members.InstanceFields.GetObjectValue("Events.Lcom/zebra/rfid/api3/Events;", (IJavaPeerable) this);
        return Object.GetObject<Events>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          RFIDReader._members.InstanceFields.SetValue("Events.Lcom/zebra/rfid/api3/Events;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = RFIDReader._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("m_defaultLLRPTransactReceiveRespTime")]
    public static int MDefaultLLRPTransactReceiveRespTime
    {
      get
      {
        return RFIDReader._members.StaticFields.GetInt32Value("m_defaultLLRPTransactReceiveRespTime.I");
      }
      set
      {
        RFIDReader._members.StaticFields.SetValue("m_defaultLLRPTransactReceiveRespTime.I", value);
      }
    }

    [Register("ReaderCapabilities")]
    public ReaderCapabilities? ReaderCapabilities
    {
      get
      {
        JniObjectReference objectValue = RFIDReader._members.InstanceFields.GetObjectValue("ReaderCapabilities.Lcom/zebra/rfid/api3/ReaderCapabilities;", (IJavaPeerable) this);
        return Object.GetObject<ReaderCapabilities>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          RFIDReader._members.InstanceFields.SetValue("ReaderCapabilities.Lcom/zebra/rfid/api3/ReaderCapabilities;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFIDReader._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFIDReader._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFIDReader._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFIDReader._members.ManagedPeerType;

    protected RFIDReader(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RFIDReader()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RFIDReader._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RFIDReader._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Ljava/lang/String;II)V", "")]
    public unsafe RFIDReader(string? hostName, int port, int timeoutMilliseconds)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(hostName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(port),
          new JniArgumentValue(timeoutMilliseconds)
        };
        JniObjectReference instance = RFIDReader._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;II)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RFIDReader._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;II)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", "")]
    public unsafe RFIDReader(
      string? hostName,
      int port,
      int timeoutMilliseconds,
      string? Protocol,
      string? Transport)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(hostName);
      IntPtr num2 = JNIEnv.NewString(Protocol);
      IntPtr num3 = JNIEnv.NewString(Transport);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(port),
          new JniArgumentValue(timeoutMilliseconds),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3)
        };
        JniObjectReference instance = RFIDReader._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RFIDReader._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;ILjava/lang/String;)V", "")]
    public unsafe RFIDReader(string? comPort, int baudRate, string? transport)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(comPort);
      IntPtr num2 = JNIEnv.NewString(transport);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(baudRate),
          new JniArgumentValue(num2)
        };
        JniObjectReference instance = RFIDReader._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;ILjava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RFIDReader._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;ILjava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetGetHostNameHandler()
    {
      if ((object) RFIDReader.cb_getHostName == null)
        RFIDReader.cb_getHostName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDReader.n_GetHostName));
      return RFIDReader.cb_getHostName;
    }

    private static IntPtr n_GetHostName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).HostName);
    }

    private static Delegate GetSetHostName_Ljava_lang_String_Handler()
    {
      if ((object) RFIDReader.cb_setHostName_Ljava_lang_String_ == null)
        RFIDReader.cb_setHostName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDReader.n_SetHostName_Ljava_lang_String_));
      return RFIDReader.cb_setHostName_Ljava_lang_String_;
    }

    private static void n_SetHostName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_hostName)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).HostName = JNIEnv.GetString(native_hostName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? HostName
    {
      [Register("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDReader._members.InstanceMethods.InvokeVirtualObjectMethod("getHostName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHostName", "(Ljava/lang/String;)V", "GetSetHostName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("setHostName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsCapabilitiesReceivedHandler()
    {
      if ((object) RFIDReader.cb_isCapabilitiesReceived == null)
        RFIDReader.cb_isCapabilitiesReceived = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RFIDReader.n_IsCapabilitiesReceived));
      return RFIDReader.cb_isCapabilitiesReceived;
    }

    private static bool n_IsCapabilitiesReceived(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).IsCapabilitiesReceived;
    }

    public virtual unsafe bool IsCapabilitiesReceived
    {
      [Register("isCapabilitiesReceived", "()Z", "GetIsCapabilitiesReceivedHandler")] get
      {
        return RFIDReader._members.InstanceMethods.InvokeVirtualBooleanMethod("isCapabilitiesReceived.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsConnectedHandler()
    {
      if ((object) RFIDReader.cb_isConnected == null)
        RFIDReader.cb_isConnected = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RFIDReader.n_IsConnected));
      return RFIDReader.cb_isConnected;
    }

    private static bool n_IsConnected(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).IsConnected;
    }

    public virtual unsafe bool IsConnected
    {
      [Register("isConnected", "()Z", "GetIsConnectedHandler")] get
      {
        return RFIDReader._members.InstanceMethods.InvokeVirtualBooleanMethod("isConnected.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) RFIDReader.cb_getPassword == null)
        RFIDReader.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDReader.n_GetPassword));
      return RFIDReader.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) RFIDReader.cb_setPassword_Ljava_lang_String_ == null)
        RFIDReader.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDReader.n_SetPassword_Ljava_lang_String_));
      return RFIDReader.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDReader._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPortHandler()
    {
      if ((object) RFIDReader.cb_getPort == null)
        RFIDReader.cb_getPort = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDReader.n_GetPort));
      return RFIDReader.cb_getPort;
    }

    private static int n_GetPort(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Port;
    }

    private static Delegate GetSetPort_IHandler()
    {
      if ((object) RFIDReader.cb_setPort_I == null)
        RFIDReader.cb_setPort_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RFIDReader.n_SetPort_I));
      return RFIDReader.cb_setPort_I;
    }

    private static void n_SetPort_I(IntPtr jnienv, IntPtr native__this, int port)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Port = port;
    }

    public virtual unsafe int Port
    {
      [Register("getPort", "()I", "GetGetPortHandler")] get
      {
        return RFIDReader._members.InstanceMethods.InvokeVirtualInt32Method("getPort.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPort", "(I)V", "GetSetPort_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("setPort.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTimeoutHandler()
    {
      if ((object) RFIDReader.cb_getTimeout == null)
        RFIDReader.cb_getTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDReader.n_GetTimeout));
      return RFIDReader.cb_getTimeout;
    }

    private static int n_GetTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Timeout;
    }

    private static Delegate GetSetTimeout_IHandler()
    {
      if ((object) RFIDReader.cb_setTimeout_I == null)
        RFIDReader.cb_setTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RFIDReader.n_SetTimeout_I));
      return RFIDReader.cb_setTimeout_I;
    }

    private static void n_SetTimeout_I(IntPtr jnienv, IntPtr native__this, int timeout)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Timeout = timeout;
    }

    public virtual unsafe int Timeout
    {
      [Register("getTimeout", "()I", "GetGetTimeoutHandler")] get
      {
        return RFIDReader._members.InstanceMethods.InvokeVirtualInt32Method("getTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTimeout", "(I)V", "GetSetTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("setTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTransportHandler()
    {
      if ((object) RFIDReader.cb_getTransport == null)
        RFIDReader.cb_getTransport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDReader.n_GetTransport));
      return RFIDReader.cb_getTransport;
    }

    private static IntPtr n_GetTransport(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Transport);
    }

    public virtual unsafe string? Transport
    {
      [Register("getTransport", "()Ljava/lang/String;", "GetGetTransportHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDReader._members.InstanceMethods.InvokeVirtualObjectMethod("getTransport.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetAcceptConnection_JHandler()
    {
      if ((object) RFIDReader.cb_AcceptConnection_J == null)
        RFIDReader.cb_AcceptConnection_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(RFIDReader.n_AcceptConnection_J));
      return RFIDReader.cb_AcceptConnection_J;
    }

    private static void n_AcceptConnection_J(IntPtr jnienv, IntPtr native__this, long readerSocket)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).AcceptConnection(readerSocket);
    }

    [Register("AcceptConnection", "(J)V", "GetAcceptConnection_JHandler")]
    public virtual unsafe void AcceptConnection(long readerSocket)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(readerSocket)
      };
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("AcceptConnection.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetDisposeHandler()
    {
      if ((object) RFIDReader.cb_Dispose == null)
        RFIDReader.cb_Dispose = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_Dispose));
      return RFIDReader.cb_Dispose;
    }

    private static void n_Dispose(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Dispose();
    }

    [Register("Dispose", "()V", "GetDisposeHandler")]
    public virtual unsafe void Dispose()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("Dispose.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDispose_ZHandler()
    {
      if ((object) RFIDReader.cb_Dispose_Z == null)
        RFIDReader.cb_Dispose_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RFIDReader.n_Dispose_Z));
      return RFIDReader.cb_Dispose_Z;
    }

    private static void n_Dispose_Z(IntPtr jnienv, IntPtr native__this, bool disposing)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Dispose(disposing);
    }

    [Register("Dispose", "(Z)V", "GetDispose_ZHandler")]
    protected virtual unsafe void Dispose(bool disposing)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(disposing)
      };
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("Dispose.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetPostConnectReaderUpdateHandler()
    {
      if ((object) RFIDReader.cb_PostConnectReaderUpdate == null)
        RFIDReader.cb_PostConnectReaderUpdate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_PostConnectReaderUpdate));
      return RFIDReader.cb_PostConnectReaderUpdate;
    }

    private static void n_PostConnectReaderUpdate(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).PostConnectReaderUpdate();
    }

    [Register("PostConnectReaderUpdate", "()V", "GetPostConnectReaderUpdateHandler")]
    public virtual unsafe void PostConnectReaderUpdate()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("PostConnectReaderUpdate.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetConnectHandler()
    {
      if ((object) RFIDReader.cb_connect == null)
        RFIDReader.cb_connect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_Connect));
      return RFIDReader.cb_connect;
    }

    private static void n_Connect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Connect();
    }

    [Register("connect", "()V", "GetConnectHandler")]
    public virtual unsafe void Connect()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("connect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDisconnectHandler()
    {
      if ((object) RFIDReader.cb_disconnect == null)
        RFIDReader.cb_disconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_Disconnect));
      return RFIDReader.cb_disconnect;
    }

    private static void n_Disconnect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Disconnect();
    }

    [Register("disconnect", "()V", "GetDisconnectHandler")]
    public virtual unsafe void Disconnect()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("disconnect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetReconnectHandler()
    {
      if ((object) RFIDReader.cb_reconnect == null)
        RFIDReader.cb_reconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_Reconnect));
      return RFIDReader.cb_reconnect;
    }

    private static void n_Reconnect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).Reconnect();
    }

    [Register("reconnect", "()V", "GetReconnectHandler")]
    public virtual unsafe void Reconnect()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("reconnect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetReinitTransportHandler()
    {
      if ((object) RFIDReader.cb_reinitTransport == null)
        RFIDReader.cb_reinitTransport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_ReinitTransport));
      return RFIDReader.cb_reinitTransport;
    }

    private static void n_ReinitTransport(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).ReinitTransport();
    }

    [Register("reinitTransport", "()V", "GetReinitTransportHandler")]
    public virtual unsafe void ReinitTransport()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("reinitTransport.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSecureConnection_ZHandler()
    {
      if ((object) RFIDReader.cb_secureConnection_Z == null)
        RFIDReader.cb_secureConnection_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RFIDReader.n_SecureConnection_Z));
      return RFIDReader.cb_secureConnection_Z;
    }

    private static void n_SecureConnection_Z(IntPtr jnienv, IntPtr native__this, bool isEnabled)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).SecureConnection(isEnabled);
    }

    [Register("secureConnection", "(Z)V", "GetSecureConnection_ZHandler")]
    public virtual unsafe void SecureConnection(bool isEnabled)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(isEnabled)
      };
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("secureConnection.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSwitchModeHandler()
    {
      if ((object) RFIDReader.cb_switchMode == null)
        RFIDReader.cb_switchMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RFIDReader.n_SwitchMode));
      return RFIDReader.cb_switchMode;
    }

    private static void n_SwitchMode(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).SwitchMode();
    }

    [Register("switchMode", "()V", "GetSwitchModeHandler")]
    public virtual unsafe void SwitchMode()
    {
      RFIDReader._members.InstanceMethods.InvokeVirtualVoidMethod("switchMode.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetVersionInfoHandler()
    {
      if ((object) RFIDReader.cb_versionInfo == null)
        RFIDReader.cb_versionInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDReader.n_VersionInfo));
      return RFIDReader.cb_versionInfo;
    }

    private static IntPtr n_VersionInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDReader>(jnienv, native__this, (JniHandleOwnership) 0).VersionInfo());
    }

    [Register("versionInfo", "()Lcom/zebra/rfid/api3/VersionInfo;", "GetVersionInfoHandler")]
    public virtual unsafe Com.Zebra.Rfid.Api3.VersionInfo? VersionInfo()
    {
      JniObjectReference jniObjectReference = RFIDReader._members.InstanceMethods.InvokeVirtualObjectMethod("versionInfo.()Lcom/zebra/rfid/api3/VersionInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<Com.Zebra.Rfid.Api3.VersionInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
