// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SerialInputOutputManager
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/SerialInputOutputManager", DoNotGenerateAcw = true)]
  public class SerialInputOutputManager : Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SerialInputOutputManager", typeof (SerialInputOutputManager));
    private static Delegate? cb_getListener;
    private static Delegate? cb_setListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_;
    private static Delegate? cb_getReadTimeout;
    private static Delegate? cb_setReadTimeout_I;
    private static Delegate? cb_getWriteTimeout;
    private static Delegate? cb_setWriteTimeout_I;
    private static Delegate? cb_getState;
    private static Delegate? cb_run;
    private static Delegate? cb_setUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_;
    private static Delegate? cb_stop;
    private static Delegate? cb_writeAsync_arrayB;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = SerialInputOutputManager._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SerialInputOutputManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SerialInputOutputManager._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SerialInputOutputManager._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SerialInputOutputManager._members.ManagedPeerType;

    protected SerialInputOutputManager(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Landroid/content/Context;Lcom/zebra/rfid/api3/UsbSerialPort;Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;)V", "")]
    public unsafe SerialInputOutputManager(
      Context? mAppContext,
      IUsbSerialPort? serialPort,
      SerialInputOutputManager.IListener? listener)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(mAppContext == null ? IntPtr.Zero : ((Object) mAppContext).Handle),
          new JniArgumentValue(serialPort == null ? IntPtr.Zero : ((Object) serialPort).Handle),
          new JniArgumentValue(listener == null ? IntPtr.Zero : ((Object) listener).Handle)
        };
        JniObjectReference instance = SerialInputOutputManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/zebra/rfid/api3/UsbSerialPort;Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        SerialInputOutputManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/zebra/rfid/api3/UsbSerialPort;Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) mAppContext);
        GC.KeepAlive((object) serialPort);
        GC.KeepAlive((object) listener);
      }
    }

    private static Delegate GetGetListenerHandler()
    {
      if ((object) SerialInputOutputManager.cb_getListener == null)
        SerialInputOutputManager.cb_getListener = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SerialInputOutputManager.n_GetListener));
      return SerialInputOutputManager.cb_getListener;
    }

    private static IntPtr n_GetListener(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).Listener);
    }

    private static Delegate GetSetListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_Handler()
    {
      if ((object) SerialInputOutputManager.cb_setListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_ == null)
        SerialInputOutputManager.cb_setListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SerialInputOutputManager.n_SetListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_));
      return SerialInputOutputManager.cb_setListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_;
    }

    private static void n_SetListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_listener)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).Listener = Object.GetObject<SerialInputOutputManager.IListener>(native_listener, (JniHandleOwnership) 0);
    }

    public virtual unsafe SerialInputOutputManager.IListener? Listener
    {
      [Register("getListener", "()Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;", "GetGetListenerHandler")] get
      {
        JniObjectReference jniObjectReference = SerialInputOutputManager._members.InstanceMethods.InvokeVirtualObjectMethod("getListener.()Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SerialInputOutputManager.IListener>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setListener", "(Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;)V", "GetSetListener_Lcom_zebra_rfid_api3_SerialInputOutputManager_Listener_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/zebra/rfid/api3/SerialInputOutputManager$Listener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetReadTimeoutHandler()
    {
      if ((object) SerialInputOutputManager.cb_getReadTimeout == null)
        SerialInputOutputManager.cb_getReadTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SerialInputOutputManager.n_GetReadTimeout));
      return SerialInputOutputManager.cb_getReadTimeout;
    }

    private static int n_GetReadTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).ReadTimeout;
    }

    private static Delegate GetSetReadTimeout_IHandler()
    {
      if ((object) SerialInputOutputManager.cb_setReadTimeout_I == null)
        SerialInputOutputManager.cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SerialInputOutputManager.n_SetReadTimeout_I));
      return SerialInputOutputManager.cb_setReadTimeout_I;
    }

    private static void n_SetReadTimeout_I(IntPtr jnienv, IntPtr native__this, int timeout)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).ReadTimeout = timeout;
    }

    public virtual unsafe int ReadTimeout
    {
      [Register("getReadTimeout", "()I", "GetGetReadTimeoutHandler")] get
      {
        return SerialInputOutputManager._members.InstanceMethods.InvokeVirtualInt32Method("getReadTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("setReadTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetWriteTimeoutHandler()
    {
      if ((object) SerialInputOutputManager.cb_getWriteTimeout == null)
        SerialInputOutputManager.cb_getWriteTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SerialInputOutputManager.n_GetWriteTimeout));
      return SerialInputOutputManager.cb_getWriteTimeout;
    }

    private static int n_GetWriteTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).WriteTimeout;
    }

    private static Delegate GetSetWriteTimeout_IHandler()
    {
      if ((object) SerialInputOutputManager.cb_setWriteTimeout_I == null)
        SerialInputOutputManager.cb_setWriteTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SerialInputOutputManager.n_SetWriteTimeout_I));
      return SerialInputOutputManager.cb_setWriteTimeout_I;
    }

    private static void n_SetWriteTimeout_I(IntPtr jnienv, IntPtr native__this, int timeout)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).WriteTimeout = timeout;
    }

    public virtual unsafe int WriteTimeout
    {
      [Register("getWriteTimeout", "()I", "GetGetWriteTimeoutHandler")] get
      {
        return SerialInputOutputManager._members.InstanceMethods.InvokeVirtualInt32Method("getWriteTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setWriteTimeout", "(I)V", "GetSetWriteTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStateHandler()
    {
      if ((object) SerialInputOutputManager.cb_getState == null)
        SerialInputOutputManager.cb_getState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SerialInputOutputManager.n_GetState));
      return SerialInputOutputManager.cb_getState;
    }

    private static IntPtr n_GetState(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).GetState());
    }

    [Register("getState", "()Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", "GetGetStateHandler")]
    public virtual unsafe SerialInputOutputManager.State? GetState()
    {
      JniObjectReference jniObjectReference = SerialInputOutputManager._members.InstanceMethods.InvokeVirtualObjectMethod("getState.()Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<SerialInputOutputManager.State>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetRunHandler()
    {
      if ((object) SerialInputOutputManager.cb_run == null)
        SerialInputOutputManager.cb_run = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(SerialInputOutputManager.n_Run));
      return SerialInputOutputManager.cb_run;
    }

    private static void n_Run(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).Run();
    }

    [Register("run", "()V", "GetRunHandler")]
    public virtual unsafe void Run()
    {
      SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("run.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_Handler()
    {
      if ((object) SerialInputOutputManager.cb_setUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_ == null)
        SerialInputOutputManager.cb_setUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SerialInputOutputManager.n_SetUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_));
      return SerialInputOutputManager.cb_setUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_;
    }

    private static void n_SetUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_usbSerialPort)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).SetUsbSerialPort(Object.GetObject<IUsbSerialPort>(native_usbSerialPort, (JniHandleOwnership) 0));
    }

    [Register("setUsbSerialPort", "(Lcom/zebra/rfid/api3/UsbSerialPort;)V", "GetSetUsbSerialPort_Lcom_zebra_rfid_api3_UsbSerialPort_Handler")]
    public virtual unsafe void SetUsbSerialPort(IUsbSerialPort? usbSerialPort)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(usbSerialPort == null ? IntPtr.Zero : ((Object) usbSerialPort).Handle)
        };
        SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("setUsbSerialPort.(Lcom/zebra/rfid/api3/UsbSerialPort;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) usbSerialPort);
      }
    }

    private static Delegate GetStopHandler()
    {
      if ((object) SerialInputOutputManager.cb_stop == null)
        SerialInputOutputManager.cb_stop = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(SerialInputOutputManager.n_Stop));
      return SerialInputOutputManager.cb_stop;
    }

    private static void n_Stop(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0).Stop();
    }

    [Register("stop", "()V", "GetStopHandler")]
    public virtual unsafe void Stop()
    {
      SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetWriteAsync_arrayBHandler()
    {
      if ((object) SerialInputOutputManager.cb_writeAsync_arrayB == null)
        SerialInputOutputManager.cb_writeAsync_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SerialInputOutputManager.n_WriteAsync_arrayB));
      return SerialInputOutputManager.cb_writeAsync_arrayB;
    }

    private static void n_WriteAsync_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      SerialInputOutputManager inputOutputManager = Object.GetObject<SerialInputOutputManager>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      inputOutputManager.WriteAsync(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("writeAsync", "([B)V", "GetWriteAsync_arrayBHandler")]
    public virtual unsafe void WriteAsync(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        SerialInputOutputManager._members.InstanceMethods.InvokeVirtualVoidMethod("writeAsync.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (data != null)
        {
          JNIEnv.CopyArray(num, data);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) data);
      }
    }

    private SerialInputOutputManager.IListenerImplementor __CreateIListenerImplementor()
    {
      return new SerialInputOutputManager.IListenerImplementor((object) this);
    }

    [Register("com/zebra/rfid/api3/SerialInputOutputManager$Listener", "", "Com.Zebra.Rfid.Api3.SerialInputOutputManager/IListenerInvoker")]
    public interface IListener : IJavaObject, IDisposable, IJavaPeerable
    {
      [Register("isConnected", "()Ljava/lang/Boolean;", "GetIsConnectedHandler:Com.Zebra.Rfid.Api3.SerialInputOutputManager/IListenerInvoker, MauiJavaSdkBinding")]
      Boolean? IsConnected();

      [Register("onNewData", "([B)V", "GetOnNewData_arrayBHandler:Com.Zebra.Rfid.Api3.SerialInputOutputManager/IListenerInvoker, MauiJavaSdkBinding")]
      void OnNewData(byte[]? p0);

      [Register("onRunError", "(Ljava/lang/Exception;)V", "GetOnRunError_Ljava_lang_Exception_Handler:Com.Zebra.Rfid.Api3.SerialInputOutputManager/IListenerInvoker, MauiJavaSdkBinding")]
      void OnRunError(Exception? p0);
    }

    [Register("com/zebra/rfid/api3/SerialInputOutputManager$Listener", DoNotGenerateAcw = true)]
    internal class IListenerInvoker : 
      Object,
      SerialInputOutputManager.IListener,
      IJavaObject,
      IDisposable,
      IJavaPeerable
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SerialInputOutputManager$Listener", typeof (SerialInputOutputManager.IListenerInvoker));
      private IntPtr class_ref;
      private static Delegate? cb_isConnected;
      private IntPtr id_isConnected;
      private static Delegate? cb_onNewData_arrayB;
      private IntPtr id_onNewData_arrayB;
      private static Delegate? cb_onRunError_Ljava_lang_Exception_;
      private IntPtr id_onRunError_Ljava_lang_Exception_;

      private static IntPtr java_class_ref
      {
        get
        {
          JniObjectReference peerReference = SerialInputOutputManager.IListenerInvoker._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => SerialInputOutputManager.IListenerInvoker._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass => this.class_ref;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => SerialInputOutputManager.IListenerInvoker._members.ManagedPeerType;
      }

      public static SerialInputOutputManager.IListener? GetObject(
        IntPtr handle,
        JniHandleOwnership transfer)
      {
        return Object.GetObject<SerialInputOutputManager.IListener>(handle, transfer);
      }

      private static IntPtr Validate(IntPtr handle)
      {
        return JNIEnv.IsInstanceOf(handle, SerialInputOutputManager.IListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.SerialInputOutputManager.Listener'.");
      }

      protected virtual void Dispose(bool disposing)
      {
        if (this.class_ref != IntPtr.Zero)
          JNIEnv.DeleteGlobalRef(this.class_ref);
        this.class_ref = IntPtr.Zero;
        base.Dispose(disposing);
      }

      public IListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
        : base(SerialInputOutputManager.IListenerInvoker.Validate(handle), transfer)
      {
        IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
        this.class_ref = JNIEnv.NewGlobalRef(objectClass);
        JNIEnv.DeleteLocalRef(objectClass);
      }

      private static Delegate GetIsConnectedHandler()
      {
        if ((object) SerialInputOutputManager.IListenerInvoker.cb_isConnected == null)
          SerialInputOutputManager.IListenerInvoker.cb_isConnected = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SerialInputOutputManager.IListenerInvoker.n_IsConnected));
        return SerialInputOutputManager.IListenerInvoker.cb_isConnected;
      }

      private static IntPtr n_IsConnected(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SerialInputOutputManager.IListener>(jnienv, native__this, (JniHandleOwnership) 0).IsConnected());
      }

      public Boolean? IsConnected()
      {
        if (this.id_isConnected == IntPtr.Zero)
          this.id_isConnected = JNIEnv.GetMethodID(this.class_ref, "isConnected", "()Ljava/lang/Boolean;");
        return Object.GetObject<Boolean>(JNIEnv.CallObjectMethod(this.Handle, this.id_isConnected), (JniHandleOwnership) 1);
      }

      private static Delegate GetOnNewData_arrayBHandler()
      {
        if ((object) SerialInputOutputManager.IListenerInvoker.cb_onNewData_arrayB == null)
          SerialInputOutputManager.IListenerInvoker.cb_onNewData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SerialInputOutputManager.IListenerInvoker.n_OnNewData_arrayB));
        return SerialInputOutputManager.IListenerInvoker.cb_onNewData_arrayB;
      }

      private static void n_OnNewData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
      {
        SerialInputOutputManager.IListener listener = Object.GetObject<SerialInputOutputManager.IListener>(jnienv, native__this, (JniHandleOwnership) 0);
        byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
        byte[] p0 = array;
        listener.OnNewData(p0);
        if (array == null)
          return;
        JNIEnv.CopyArray(array, native_p0);
      }

      public unsafe void OnNewData(byte[]? p0)
      {
        if (this.id_onNewData_arrayB == IntPtr.Zero)
          this.id_onNewData_arrayB = JNIEnv.GetMethodID(this.class_ref, "onNewData", "([B)V");
        IntPtr num = JNIEnv.NewArray(p0);
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(num)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_onNewData_arrayB, jvaluePtr);
        if (p0 == null)
          return;
        JNIEnv.CopyArray(num, p0);
        JNIEnv.DeleteLocalRef(num);
      }

      private static Delegate GetOnRunError_Ljava_lang_Exception_Handler()
      {
        if ((object) SerialInputOutputManager.IListenerInvoker.cb_onRunError_Ljava_lang_Exception_ == null)
          SerialInputOutputManager.IListenerInvoker.cb_onRunError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SerialInputOutputManager.IListenerInvoker.n_OnRunError_Ljava_lang_Exception_));
        return SerialInputOutputManager.IListenerInvoker.cb_onRunError_Ljava_lang_Exception_;
      }

      private static void n_OnRunError_Ljava_lang_Exception_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_p0)
      {
        Object.GetObject<SerialInputOutputManager.IListener>(jnienv, native__this, (JniHandleOwnership) 0).OnRunError(Object.GetObject<Exception>(native_p0, (JniHandleOwnership) 0));
      }

      public unsafe void OnRunError(Exception? p0)
      {
        if (this.id_onRunError_Ljava_lang_Exception_ == IntPtr.Zero)
          this.id_onRunError_Ljava_lang_Exception_ = JNIEnv.GetMethodID(this.class_ref, "onRunError", "(Ljava/lang/Exception;)V");
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(p0 == null ? IntPtr.Zero : ((Throwable) p0).Handle)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_onRunError_Ljava_lang_Exception_, jvaluePtr);
      }
    }

    public delegate Boolean? IsConnectedHandler();

    public class NewDataEventArgs : EventArgs
    {
      private byte[]? p0;

      public NewDataEventArgs(byte[]? p0) => this.p0 = p0;

      public byte[]? P0 => this.p0;
    }

    public class RunErrorEventArgs : EventArgs
    {
      private Exception? p0;

      public RunErrorEventArgs(Exception? p0) => this.p0 = p0;

      public Exception? P0 => this.p0;
    }

    [Register("mono/com/zebra/rfid/api3/SerialInputOutputManager_ListenerImplementor")]
    internal sealed class IListenerImplementor : 
      Object,
      SerialInputOutputManager.IListener,
      IJavaObject,
      IDisposable,
      IJavaPeerable
    {
      private object? sender;
      public SerialInputOutputManager.IsConnectedHandler? IsConnectedHandler;
      public EventHandler<SerialInputOutputManager.NewDataEventArgs>? OnNewDataHandler;
      public EventHandler<SerialInputOutputManager.RunErrorEventArgs>? OnRunErrorHandler;

      public unsafe IListenerImplementor(object sender)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        JniObjectReference instance = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
        this.sender = sender;
      }

      public Boolean? IsConnected()
      {
        SerialInputOutputManager.IsConnectedHandler connectedHandler = this.IsConnectedHandler;
        return connectedHandler == null ? (Boolean) null : connectedHandler();
      }

      public void OnNewData(byte[]? p0)
      {
        EventHandler<SerialInputOutputManager.NewDataEventArgs> onNewDataHandler = this.OnNewDataHandler;
        if (onNewDataHandler == null)
          return;
        onNewDataHandler(this.sender, new SerialInputOutputManager.NewDataEventArgs(p0));
      }

      public void OnRunError(Exception? p0)
      {
        EventHandler<SerialInputOutputManager.RunErrorEventArgs> onRunErrorHandler = this.OnRunErrorHandler;
        if (onRunErrorHandler == null)
          return;
        onRunErrorHandler(this.sender, new SerialInputOutputManager.RunErrorEventArgs(p0));
      }

      internal static bool __IsEmpty(
        SerialInputOutputManager.IListenerImplementor value)
      {
        return value.IsConnectedHandler == null && value.OnNewDataHandler == null && value.OnRunErrorHandler == null;
      }
    }

    [Register("com/zebra/rfid/api3/SerialInputOutputManager$State", DoNotGenerateAcw = true)]
    public sealed class State : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SerialInputOutputManager$State", typeof (SerialInputOutputManager.State));

      [Register("RUNNING")]
      public static SerialInputOutputManager.State? Running
      {
        get
        {
          JniObjectReference objectValue = SerialInputOutputManager.State._members.StaticFields.GetObjectValue("RUNNING.Lcom/zebra/rfid/api3/SerialInputOutputManager$State;");
          return Object.GetObject<SerialInputOutputManager.State>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("STOPPED")]
      public static SerialInputOutputManager.State? Stopped
      {
        get
        {
          JniObjectReference objectValue = SerialInputOutputManager.State._members.StaticFields.GetObjectValue("STOPPED.Lcom/zebra/rfid/api3/SerialInputOutputManager$State;");
          return Object.GetObject<SerialInputOutputManager.State>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("STOPPING")]
      public static SerialInputOutputManager.State? Stopping
      {
        get
        {
          JniObjectReference objectValue = SerialInputOutputManager.State._members.StaticFields.GetObjectValue("STOPPING.Lcom/zebra/rfid/api3/SerialInputOutputManager$State;");
          return Object.GetObject<SerialInputOutputManager.State>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = SerialInputOutputManager.State._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => SerialInputOutputManager.State._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = SerialInputOutputManager.State._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => SerialInputOutputManager.State._members.ManagedPeerType;
      }

      internal State(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", "")]
      public static unsafe SerialInputOutputManager.State? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = SerialInputOutputManager.State._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", jniArgumentValuePtr);
          return Object.GetObject<SerialInputOutputManager.State>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", "")]
      public static unsafe SerialInputOutputManager.State[]? Values()
      {
        JniObjectReference jniObjectReference = SerialInputOutputManager.State._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/SerialInputOutputManager$State;", (JniArgumentValue*) null);
        return (SerialInputOutputManager.State[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (SerialInputOutputManager.State));
      }
    }
  }
}
