// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.Usbiomgr
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Runtime;
using Com.Zebra.Scannercontrol;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/usbiomgr", DoNotGenerateAcw = true)]
  public class Usbiomgr : 
    Object,
    SerialInputOutputManager.IListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable,
    ICmniolistner
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/usbiomgr", typeof (Usbiomgr));
    private static Delegate? cb_UsbConnect_Landroid_content_Context_;
    private static Delegate? cb_UsbDisconnect;
    private static Delegate? cb_onNewData_arrayB;
    private static Delegate? cb_onRunError_Ljava_lang_Exception_;
    private static Delegate? cb_read;
    private static Delegate? cb_send_arrayB;
    private static Delegate? cb_send_Ljava_lang_String_;
    private static Delegate? cb_setPortNum_I;
    private static Delegate? cb_setProductId_I;
    private static Delegate? cb_setUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_;
    private static Delegate? cb_setVendorId_I;
    private WeakReference? weak_implementor_SetUsbPermissionStatusListener;

    [Register("PORT_SSI")]
    public static int PortSsi
    {
      get => Usbiomgr._members.StaticFields.GetInt32Value("PORT_SSI.I");
      set => Usbiomgr._members.StaticFields.SetValue("PORT_SSI.I", value);
    }

    [Register("PORT_ZETI")]
    public static int PortZeti
    {
      get => Usbiomgr._members.StaticFields.GetInt32Value("PORT_ZETI.I");
      set => Usbiomgr._members.StaticFields.SetValue("PORT_ZETI.I", value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Usbiomgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Usbiomgr._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Usbiomgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Usbiomgr._members.ManagedPeerType;

    protected Usbiomgr(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Usbiomgr()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Usbiomgr._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Usbiomgr._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetUsbConnect_Landroid_content_Context_Handler()
    {
      if ((object) Usbiomgr.cb_UsbConnect_Landroid_content_Context_ == null)
        Usbiomgr.cb_UsbConnect_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_Z(Usbiomgr.n_UsbConnect_Landroid_content_Context_));
      return Usbiomgr.cb_UsbConnect_Landroid_content_Context_;
    }

    private static bool n_UsbConnect_Landroid_content_Context_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mAppContext)
    {
      return Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).UsbConnect(Object.GetObject<Context>(native_mAppContext, (JniHandleOwnership) 0));
    }

    [Register("UsbConnect", "(Landroid/content/Context;)Z", "GetUsbConnect_Landroid_content_Context_Handler")]
    public virtual unsafe bool UsbConnect(Context? mAppContext)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(mAppContext == null ? IntPtr.Zero : ((Object) mAppContext).Handle)
        };
        return Usbiomgr._members.InstanceMethods.InvokeVirtualBooleanMethod("UsbConnect.(Landroid/content/Context;)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) mAppContext);
      }
    }

    private static Delegate GetUsbDisconnectHandler()
    {
      if ((object) Usbiomgr.cb_UsbDisconnect == null)
        Usbiomgr.cb_UsbDisconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Usbiomgr.n_UsbDisconnect));
      return Usbiomgr.cb_UsbDisconnect;
    }

    private static void n_UsbDisconnect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).UsbDisconnect();
    }

    [Register("UsbDisconnect", "()V", "GetUsbDisconnectHandler")]
    public virtual unsafe void UsbDisconnect()
    {
      Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("UsbDisconnect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("getInstance", "(Landroid/content/Context;Lcom/zebra/scannercontrol/USBCDCScanner;Ljava/lang/String;)Lcom/zebra/commoniolib/usbiomgr;", "")]
    public static unsafe Usbiomgr? GetInstance(
      Context? m_scontext,
      USBCDCScanner? mScanner,
      string? appId)
    {
      IntPtr num = JNIEnv.NewString(appId);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(m_scontext == null ? IntPtr.Zero : ((Object) m_scontext).Handle),
          new JniArgumentValue(mScanner == null ? IntPtr.Zero : mScanner.Handle),
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Usbiomgr._members.StaticMethods.InvokeObjectMethod("getInstance.(Landroid/content/Context;Lcom/zebra/scannercontrol/USBCDCScanner;Ljava/lang/String;)Lcom/zebra/commoniolib/usbiomgr;", jniArgumentValuePtr);
        return Object.GetObject<Usbiomgr>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) m_scontext);
        GC.KeepAlive((object) mScanner);
      }
    }

    private static Delegate GetOnNewData_arrayBHandler()
    {
      if ((object) Usbiomgr.cb_onNewData_arrayB == null)
        Usbiomgr.cb_onNewData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Usbiomgr.n_OnNewData_arrayB));
      return Usbiomgr.cb_onNewData_arrayB;
    }

    private static void n_OnNewData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      Usbiomgr usbiomgr = Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      usbiomgr.OnNewData(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("onNewData", "([B)V", "GetOnNewData_arrayBHandler")]
    public virtual unsafe void OnNewData(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("onNewData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetOnRunError_Ljava_lang_Exception_Handler()
    {
      if ((object) Usbiomgr.cb_onRunError_Ljava_lang_Exception_ == null)
        Usbiomgr.cb_onRunError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Usbiomgr.n_OnRunError_Ljava_lang_Exception_));
      return Usbiomgr.cb_onRunError_Ljava_lang_Exception_;
    }

    private static void n_OnRunError_Ljava_lang_Exception_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_e)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).OnRunError(Object.GetObject<Exception>(native_e, (JniHandleOwnership) 0));
    }

    [Register("onRunError", "(Ljava/lang/Exception;)V", "GetOnRunError_Ljava_lang_Exception_Handler")]
    public virtual unsafe void OnRunError(Exception? e)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(e == null ? IntPtr.Zero : ((Throwable) e).Handle)
        };
        Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("onRunError.(Ljava/lang/Exception;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) e);
      }
    }

    private static Delegate GetReadHandler()
    {
      if ((object) Usbiomgr.cb_read == null)
        Usbiomgr.cb_read = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Usbiomgr.n_Read));
      return Usbiomgr.cb_read;
    }

    private static void n_Read(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).Read();
    }

    [Register("read", "()V", "GetReadHandler")]
    public virtual unsafe void Read()
    {
      Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("read.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSend_arrayBHandler()
    {
      if ((object) Usbiomgr.cb_send_arrayB == null)
        Usbiomgr.cb_send_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Usbiomgr.n_Send_arrayB));
      return Usbiomgr.cb_send_arrayB;
    }

    private static void n_Send_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      Usbiomgr usbiomgr = Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      usbiomgr.Send(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("send", "([B)V", "GetSend_arrayBHandler")]
    public virtual unsafe void Send(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("send.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetSend_Ljava_lang_String_Handler()
    {
      if ((object) Usbiomgr.cb_send_Ljava_lang_String_ == null)
        Usbiomgr.cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Usbiomgr.n_Send_Ljava_lang_String_));
      return Usbiomgr.cb_send_Ljava_lang_String_;
    }

    private static void n_Send_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).Send(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
    public virtual unsafe void Send(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("send.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetPortNum_IHandler()
    {
      if ((object) Usbiomgr.cb_setPortNum_I == null)
        Usbiomgr.cb_setPortNum_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Usbiomgr.n_SetPortNum_I));
      return Usbiomgr.cb_setPortNum_I;
    }

    private static void n_SetPortNum_I(IntPtr jnienv, IntPtr native__this, int portType)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).SetPortNum(portType);
    }

    [Register("setPortNum", "(I)V", "GetSetPortNum_IHandler")]
    public virtual unsafe void SetPortNum(int portType)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(portType)
      };
      Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("setPortNum.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetProductId_IHandler()
    {
      if ((object) Usbiomgr.cb_setProductId_I == null)
        Usbiomgr.cb_setProductId_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Usbiomgr.n_SetProductId_I));
      return Usbiomgr.cb_setProductId_I;
    }

    private static void n_SetProductId_I(IntPtr jnienv, IntPtr native__this, int productId)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).SetProductId(productId);
    }

    [Register("setProductId", "(I)V", "GetSetProductId_IHandler")]
    public virtual unsafe void SetProductId(int productId)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(productId)
      };
      Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("setProductId.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_Handler()
    {
      if ((object) Usbiomgr.cb_setUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_ == null)
        Usbiomgr.cb_setUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Usbiomgr.n_SetUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_));
      return Usbiomgr.cb_setUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_;
    }

    private static void n_SetUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_listener)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).SetUsbPermissionStatusListener(Object.GetObject<Usbiomgr.IUsbPermissionStatusListener>(native_listener, (JniHandleOwnership) 0));
    }

    [Register("setUsbPermissionStatusListener", "(Lcom/zebra/commoniolib/usbiomgr$UsbPermissionStatusListener;)V", "GetSetUsbPermissionStatusListener_Lcom_zebra_commoniolib_usbiomgr_UsbPermissionStatusListener_Handler")]
    public virtual unsafe void SetUsbPermissionStatusListener(
      Usbiomgr.IUsbPermissionStatusListener? listener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(listener == null ? IntPtr.Zero : ((Object) listener).Handle)
        };
        Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("setUsbPermissionStatusListener.(Lcom/zebra/commoniolib/usbiomgr$UsbPermissionStatusListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) listener);
      }
    }

    private static Delegate GetSetVendorId_IHandler()
    {
      if ((object) Usbiomgr.cb_setVendorId_I == null)
        Usbiomgr.cb_setVendorId_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Usbiomgr.n_SetVendorId_I));
      return Usbiomgr.cb_setVendorId_I;
    }

    private static void n_SetVendorId_I(IntPtr jnienv, IntPtr native__this, int vendorId)
    {
      Object.GetObject<Usbiomgr>(jnienv, native__this, (JniHandleOwnership) 0).SetVendorId(vendorId);
    }

    [Register("setVendorId", "(I)V", "GetSetVendorId_IHandler")]
    public virtual unsafe void SetVendorId(int vendorId)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(vendorId)
      };
      Usbiomgr._members.InstanceMethods.InvokeVirtualVoidMethod("setVendorId.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    public event EventHandler PermissionDenied
    {
      add
      {
        EventHelper.AddEventHandler<Usbiomgr.IUsbPermissionStatusListener, Usbiomgr.IUsbPermissionStatusListenerImplementor>(ref this.weak_implementor_SetUsbPermissionStatusListener, new Func<Usbiomgr.IUsbPermissionStatusListenerImplementor>(this.__CreateIUsbPermissionStatusListenerImplementor), new Action<Usbiomgr.IUsbPermissionStatusListener>(this.SetUsbPermissionStatusListener), (Action<Usbiomgr.IUsbPermissionStatusListenerImplementor>) (__h => __h.OnPermissionDeniedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<Usbiomgr.IUsbPermissionStatusListener, Usbiomgr.IUsbPermissionStatusListenerImplementor>(ref this.weak_implementor_SetUsbPermissionStatusListener, Usbiomgr.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (Usbiomgr.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<Usbiomgr.IUsbPermissionStatusListenerImplementor, bool>(Usbiomgr.IUsbPermissionStatusListenerImplementor.__IsEmpty)), (Action<Usbiomgr.IUsbPermissionStatusListener>) (__v => this.SetUsbPermissionStatusListener((Usbiomgr.IUsbPermissionStatusListener) null)), (Action<Usbiomgr.IUsbPermissionStatusListenerImplementor>) (__h => __h.OnPermissionDeniedHandler -= value));
      }
    }

    public event EventHandler PermissionGranted
    {
      add
      {
        EventHelper.AddEventHandler<Usbiomgr.IUsbPermissionStatusListener, Usbiomgr.IUsbPermissionStatusListenerImplementor>(ref this.weak_implementor_SetUsbPermissionStatusListener, new Func<Usbiomgr.IUsbPermissionStatusListenerImplementor>(this.__CreateIUsbPermissionStatusListenerImplementor), new Action<Usbiomgr.IUsbPermissionStatusListener>(this.SetUsbPermissionStatusListener), (Action<Usbiomgr.IUsbPermissionStatusListenerImplementor>) (__h => __h.OnPermissionGrantedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<Usbiomgr.IUsbPermissionStatusListener, Usbiomgr.IUsbPermissionStatusListenerImplementor>(ref this.weak_implementor_SetUsbPermissionStatusListener, Usbiomgr.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (Usbiomgr.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<Usbiomgr.IUsbPermissionStatusListenerImplementor, bool>(Usbiomgr.IUsbPermissionStatusListenerImplementor.__IsEmpty)), (Action<Usbiomgr.IUsbPermissionStatusListener>) (__v => this.SetUsbPermissionStatusListener((Usbiomgr.IUsbPermissionStatusListener) null)), (Action<Usbiomgr.IUsbPermissionStatusListenerImplementor>) (__h => __h.OnPermissionGrantedHandler -= value));
      }
    }

    private Usbiomgr.IUsbPermissionStatusListenerImplementor __CreateIUsbPermissionStatusListenerImplementor()
    {
      return new Usbiomgr.IUsbPermissionStatusListenerImplementor((object) this);
    }

    [Register("com/zebra/commoniolib/usbiomgr$UsbPermissionStatusListener", "", "Com.Zebra.Commoniolib.Usbiomgr/IUsbPermissionStatusListenerInvoker")]
    public interface IUsbPermissionStatusListener : IJavaObject, IDisposable, IJavaPeerable
    {
      [Register("onPermissionDenied", "()V", "GetOnPermissionDeniedHandler:Com.Zebra.Commoniolib.Usbiomgr/IUsbPermissionStatusListenerInvoker, MauiJavaSdkBinding")]
      void OnPermissionDenied();

      [Register("onPermissionGranted", "()V", "GetOnPermissionGrantedHandler:Com.Zebra.Commoniolib.Usbiomgr/IUsbPermissionStatusListenerInvoker, MauiJavaSdkBinding")]
      void OnPermissionGranted();
    }

    [Register("com/zebra/commoniolib/usbiomgr$UsbPermissionStatusListener", DoNotGenerateAcw = true)]
    internal class IUsbPermissionStatusListenerInvoker : 
      Object,
      Usbiomgr.IUsbPermissionStatusListener,
      IJavaObject,
      IDisposable,
      IJavaPeerable
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/usbiomgr$UsbPermissionStatusListener", typeof (Usbiomgr.IUsbPermissionStatusListenerInvoker));
      private IntPtr class_ref;
      private static Delegate? cb_onPermissionDenied;
      private IntPtr id_onPermissionDenied;
      private static Delegate? cb_onPermissionGranted;
      private IntPtr id_onPermissionGranted;

      private static IntPtr java_class_ref
      {
        get
        {
          JniObjectReference peerReference = Usbiomgr.IUsbPermissionStatusListenerInvoker._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => Usbiomgr.IUsbPermissionStatusListenerInvoker._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass => this.class_ref;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => Usbiomgr.IUsbPermissionStatusListenerInvoker._members.ManagedPeerType;
      }

      public static Usbiomgr.IUsbPermissionStatusListener? GetObject(
        IntPtr handle,
        JniHandleOwnership transfer)
      {
        return Object.GetObject<Usbiomgr.IUsbPermissionStatusListener>(handle, transfer);
      }

      private static IntPtr Validate(IntPtr handle)
      {
        return JNIEnv.IsInstanceOf(handle, Usbiomgr.IUsbPermissionStatusListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.commoniolib.usbiomgr.UsbPermissionStatusListener'.");
      }

      protected virtual void Dispose(bool disposing)
      {
        if (this.class_ref != IntPtr.Zero)
          JNIEnv.DeleteGlobalRef(this.class_ref);
        this.class_ref = IntPtr.Zero;
        base.Dispose(disposing);
      }

      public IUsbPermissionStatusListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
        : base(Usbiomgr.IUsbPermissionStatusListenerInvoker.Validate(handle), transfer)
      {
        IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
        this.class_ref = JNIEnv.NewGlobalRef(objectClass);
        JNIEnv.DeleteLocalRef(objectClass);
      }

      private static Delegate GetOnPermissionDeniedHandler()
      {
        if ((object) Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionDenied == null)
          Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionDenied = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Usbiomgr.IUsbPermissionStatusListenerInvoker.n_OnPermissionDenied));
        return Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionDenied;
      }

      private static void n_OnPermissionDenied(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<Usbiomgr.IUsbPermissionStatusListener>(jnienv, native__this, (JniHandleOwnership) 0).OnPermissionDenied();
      }

      public void OnPermissionDenied()
      {
        if (this.id_onPermissionDenied == IntPtr.Zero)
          this.id_onPermissionDenied = JNIEnv.GetMethodID(this.class_ref, "onPermissionDenied", "()V");
        JNIEnv.CallVoidMethod(this.Handle, this.id_onPermissionDenied);
      }

      private static Delegate GetOnPermissionGrantedHandler()
      {
        if ((object) Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionGranted == null)
          Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionGranted = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Usbiomgr.IUsbPermissionStatusListenerInvoker.n_OnPermissionGranted));
        return Usbiomgr.IUsbPermissionStatusListenerInvoker.cb_onPermissionGranted;
      }

      private static void n_OnPermissionGranted(IntPtr jnienv, IntPtr native__this)
      {
        Object.GetObject<Usbiomgr.IUsbPermissionStatusListener>(jnienv, native__this, (JniHandleOwnership) 0).OnPermissionGranted();
      }

      public void OnPermissionGranted()
      {
        if (this.id_onPermissionGranted == IntPtr.Zero)
          this.id_onPermissionGranted = JNIEnv.GetMethodID(this.class_ref, "onPermissionGranted", "()V");
        JNIEnv.CallVoidMethod(this.Handle, this.id_onPermissionGranted);
      }
    }

    [Register("mono/com/zebra/commoniolib/usbiomgr_UsbPermissionStatusListenerImplementor")]
    internal sealed class IUsbPermissionStatusListenerImplementor : 
      Object,
      Usbiomgr.IUsbPermissionStatusListener,
      IJavaObject,
      IDisposable,
      IJavaPeerable
    {
      private object? sender;
      public EventHandler? OnPermissionDeniedHandler;
      public EventHandler? OnPermissionGrantedHandler;

      public unsafe IUsbPermissionStatusListenerImplementor(object sender)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        JniObjectReference instance = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
        this.sender = sender;
      }

      public void OnPermissionDenied()
      {
        EventHandler permissionDeniedHandler = this.OnPermissionDeniedHandler;
        if (permissionDeniedHandler == null)
          return;
        permissionDeniedHandler(this.sender, new EventArgs());
      }

      public void OnPermissionGranted()
      {
        EventHandler permissionGrantedHandler = this.OnPermissionGrantedHandler;
        if (permissionGrantedHandler == null)
          return;
        permissionGrantedHandler(this.sender, new EventArgs());
      }

      internal static bool __IsEmpty(
        Usbiomgr.IUsbPermissionStatusListenerImplementor value)
      {
        return value.OnPermissionDeniedHandler == null && value.OnPermissionGrantedHandler == null;
      }
    }
  }
}
