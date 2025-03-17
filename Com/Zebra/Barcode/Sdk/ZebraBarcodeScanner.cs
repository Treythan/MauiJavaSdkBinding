// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.ZebraBarcodeScanner
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
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/ZebraBarcodeScanner", DoNotGenerateAcw = true)]
  public class ZebraBarcodeScanner : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/ZebraBarcodeScanner", typeof (ZebraBarcodeScanner));
    private static Delegate? cb_isConnected;
    private static Delegate? cb_addAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_;
    private static Delegate? cb_addFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_;
    private static Delegate? cb_connect;
    private static Delegate? cb_disconnect;
    private WeakReference? weak_implementor_AddAuxiliaryScannerStatusChangeListener;
    private WeakReference? weak_implementor_AddFirmwareUpdateEventListener;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ZebraBarcodeScanner._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ZebraBarcodeScanner._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ZebraBarcodeScanner._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ZebraBarcodeScanner._members.ManagedPeerType;

    protected ZebraBarcodeScanner(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Lcom/zebra/barcode/sdk/BarcodeScannerInfo;)V", "")]
    public unsafe ZebraBarcodeScanner(IBarcodeScannerInfo? barcodeScannerInfo)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(barcodeScannerInfo == null ? IntPtr.Zero : ((Object) barcodeScannerInfo).Handle)
        };
        JniObjectReference instance = ZebraBarcodeScanner._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerInfo;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ZebraBarcodeScanner._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/barcode/sdk/BarcodeScannerInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) barcodeScannerInfo);
      }
    }

    private static Delegate GetIsConnectedHandler()
    {
      if ((object) ZebraBarcodeScanner.cb_isConnected == null)
        ZebraBarcodeScanner.cb_isConnected = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(ZebraBarcodeScanner.n_IsConnected));
      return ZebraBarcodeScanner.cb_isConnected;
    }

    private static bool n_IsConnected(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ZebraBarcodeScanner>(jnienv, native__this, (JniHandleOwnership) 0).IsConnected;
    }

    public virtual unsafe bool IsConnected
    {
      [Register("isConnected", "()Z", "GetIsConnectedHandler")] get
      {
        return ZebraBarcodeScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isConnected.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetAddAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_Handler()
    {
      if ((object) ZebraBarcodeScanner.cb_addAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_ == null)
        ZebraBarcodeScanner.cb_addAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ZebraBarcodeScanner.n_AddAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_));
      return ZebraBarcodeScanner.cb_addAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_;
    }

    private static void n_AddAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_auxiliaryScannerStatusChangeListener)
    {
      Object.GetObject<ZebraBarcodeScanner>(jnienv, native__this, (JniHandleOwnership) 0).AddAuxiliaryScannerStatusChangeListener(Object.GetObject<IAuxiliaryScannerStatusChangeListener>(native_auxiliaryScannerStatusChangeListener, (JniHandleOwnership) 0));
    }

    [Register("addAuxiliaryScannerStatusChangeListener", "(Lcom/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener;)V", "GetAddAuxiliaryScannerStatusChangeListener_Lcom_zebra_barcode_sdk_AuxiliaryScannerStatusChangeListener_Handler")]
    public virtual unsafe void AddAuxiliaryScannerStatusChangeListener(
      IAuxiliaryScannerStatusChangeListener? auxiliaryScannerStatusChangeListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(auxiliaryScannerStatusChangeListener == null ? IntPtr.Zero : ((Object) auxiliaryScannerStatusChangeListener).Handle)
        };
        ZebraBarcodeScanner._members.InstanceMethods.InvokeVirtualVoidMethod("addAuxiliaryScannerStatusChangeListener.(Lcom/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) auxiliaryScannerStatusChangeListener);
      }
    }

    private static Delegate GetAddFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_Handler()
    {
      if ((object) ZebraBarcodeScanner.cb_addFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_ == null)
        ZebraBarcodeScanner.cb_addFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ZebraBarcodeScanner.n_AddFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_));
      return ZebraBarcodeScanner.cb_addFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_;
    }

    private static void n_AddFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_firmwareUpdateEventListener)
    {
      Object.GetObject<ZebraBarcodeScanner>(jnienv, native__this, (JniHandleOwnership) 0).AddFirmwareUpdateEventListener(Object.GetObject<IFirmwareUpdateEventListener>(native_firmwareUpdateEventListener, (JniHandleOwnership) 0));
    }

    [Register("addFirmwareUpdateEventListener", "(Lcom/zebra/barcode/sdk/FirmwareUpdateEventListener;)V", "GetAddFirmwareUpdateEventListener_Lcom_zebra_barcode_sdk_FirmwareUpdateEventListener_Handler")]
    public virtual unsafe void AddFirmwareUpdateEventListener(
      IFirmwareUpdateEventListener? firmwareUpdateEventListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(firmwareUpdateEventListener == null ? IntPtr.Zero : ((Object) firmwareUpdateEventListener).Handle)
        };
        ZebraBarcodeScanner._members.InstanceMethods.InvokeVirtualVoidMethod("addFirmwareUpdateEventListener.(Lcom/zebra/barcode/sdk/FirmwareUpdateEventListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) firmwareUpdateEventListener);
      }
    }

    private static Delegate GetConnectHandler()
    {
      if ((object) ZebraBarcodeScanner.cb_connect == null)
        ZebraBarcodeScanner.cb_connect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ZebraBarcodeScanner.n_Connect));
      return ZebraBarcodeScanner.cb_connect;
    }

    private static void n_Connect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ZebraBarcodeScanner>(jnienv, native__this, (JniHandleOwnership) 0).Connect();
    }

    [Register("connect", "()V", "GetConnectHandler")]
    public virtual unsafe void Connect()
    {
      ZebraBarcodeScanner._members.InstanceMethods.InvokeVirtualVoidMethod("connect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDisconnectHandler()
    {
      if ((object) ZebraBarcodeScanner.cb_disconnect == null)
        ZebraBarcodeScanner.cb_disconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(ZebraBarcodeScanner.n_Disconnect));
      return ZebraBarcodeScanner.cb_disconnect;
    }

    private static void n_Disconnect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<ZebraBarcodeScanner>(jnienv, native__this, (JniHandleOwnership) 0).Disconnect();
    }

    [Register("disconnect", "()V", "GetDisconnectHandler")]
    public virtual unsafe void Disconnect()
    {
      ZebraBarcodeScanner._members.InstanceMethods.InvokeVirtualVoidMethod("disconnect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    public event EventHandler<AuxillaryDeviceAddedEventArgs> AuxillaryDeviceAdded
    {
      add
      {
        EventHelper.AddEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_AddAuxiliaryScannerStatusChangeListener, new Func<IAuxiliaryScannerStatusChangeListenerImplementor>(this.__CreateIAuxiliaryScannerStatusChangeListenerImplementor), new Action<IAuxiliaryScannerStatusChangeListener>(this.AddAuxiliaryScannerStatusChangeListener), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceAddedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_AddAuxiliaryScannerStatusChangeListener, ZebraBarcodeScanner.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (ZebraBarcodeScanner.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IAuxiliaryScannerStatusChangeListenerImplementor, bool>(IAuxiliaryScannerStatusChangeListenerImplementor.__IsEmpty)), (Action<IAuxiliaryScannerStatusChangeListener>) (__v =>
        {
          throw new NotSupportedException("Cannot unregister from Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListener.AddAuxiliaryScannerStatusChangeListener");
        }), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceAddedHandler -= value));
      }
    }

    public event EventHandler<AuxillaryDeviceRemovedEventArgs> AuxillaryDeviceRemoved
    {
      add
      {
        EventHelper.AddEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_AddAuxiliaryScannerStatusChangeListener, new Func<IAuxiliaryScannerStatusChangeListenerImplementor>(this.__CreateIAuxiliaryScannerStatusChangeListenerImplementor), new Action<IAuxiliaryScannerStatusChangeListener>(this.AddAuxiliaryScannerStatusChangeListener), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceRemovedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_AddAuxiliaryScannerStatusChangeListener, ZebraBarcodeScanner.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (ZebraBarcodeScanner.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IAuxiliaryScannerStatusChangeListenerImplementor, bool>(IAuxiliaryScannerStatusChangeListenerImplementor.__IsEmpty)), (Action<IAuxiliaryScannerStatusChangeListener>) (__v =>
        {
          throw new NotSupportedException("Cannot unregister from Com.Zebra.Barcode.Sdk.IAuxiliaryScannerStatusChangeListener.AddAuxiliaryScannerStatusChangeListener");
        }), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceRemovedHandler -= value));
      }
    }

    private IAuxiliaryScannerStatusChangeListenerImplementor __CreateIAuxiliaryScannerStatusChangeListenerImplementor()
    {
      return new IAuxiliaryScannerStatusChangeListenerImplementor((object) this);
    }

    public event EventHandler<FirmwareUpdateEventEventArgs> FirmwareUpdateEvent
    {
      add
      {
        EventHelper.AddEventHandler<IFirmwareUpdateEventListener, IFirmwareUpdateEventListenerImplementor>(ref this.weak_implementor_AddFirmwareUpdateEventListener, new Func<IFirmwareUpdateEventListenerImplementor>(this.__CreateIFirmwareUpdateEventListenerImplementor), new Action<IFirmwareUpdateEventListener>(this.AddFirmwareUpdateEventListener), (Action<IFirmwareUpdateEventListenerImplementor>) (__h => __h.Handler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IFirmwareUpdateEventListener, IFirmwareUpdateEventListenerImplementor>(ref this.weak_implementor_AddFirmwareUpdateEventListener, ZebraBarcodeScanner.\u003C\u003EO.\u003C1\u003E____IsEmpty ?? (ZebraBarcodeScanner.\u003C\u003EO.\u003C1\u003E____IsEmpty = new Func<IFirmwareUpdateEventListenerImplementor, bool>(IFirmwareUpdateEventListenerImplementor.__IsEmpty)), (Action<IFirmwareUpdateEventListener>) (__v =>
        {
          throw new NotSupportedException("Cannot unregister from Com.Zebra.Barcode.Sdk.IFirmwareUpdateEventListener.AddFirmwareUpdateEventListener");
        }), (Action<IFirmwareUpdateEventListenerImplementor>) (__h => __h.Handler -= value));
      }
    }

    private IFirmwareUpdateEventListenerImplementor __CreateIFirmwareUpdateEventListenerImplementor()
    {
      return new IFirmwareUpdateEventListenerImplementor((object) this);
    }
  }
}
