// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.LegacySdkEventHandler
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Com.Zebra.Scannercontrol;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/LegacySdkEventHandler", DoNotGenerateAcw = true)]
  public sealed class LegacySdkEventHandler : 
    Object,
    IDcsSdkApiDelegate,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/LegacySdkEventHandler", typeof (LegacySdkEventHandler));
    private WeakReference? weak_implementor_SetAuxiliaryScannerStatusChangeListener;
    private WeakReference? weak_implementor_SetFirmwareUpdateEventListeners;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LegacySdkEventHandler._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LegacySdkEventHandler._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LegacySdkEventHandler._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LegacySdkEventHandler._members.ManagedPeerType;

    internal LegacySdkEventHandler(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public static unsafe LegacySdkEventHandler? EventHandler
    {
      [Register("getEventHandler", "()Lcom/zebra/barcode/sdk/LegacySdkEventHandler;", "")] get
      {
        JniObjectReference jniObjectReference = LegacySdkEventHandler._members.StaticMethods.InvokeObjectMethod("getEventHandler.()Lcom/zebra/barcode/sdk/LegacySdkEventHandler;", (JniArgumentValue*) null);
        return Object.GetObject<LegacySdkEventHandler>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("dcssdkEventAuxScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "")]
    public unsafe void DcssdkEventAuxScannerAppeared(
      DCSScannerInfo? newTopology,
      DCSScannerInfo? auxScanner)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(newTopology == null ? IntPtr.Zero : newTopology.Handle),
          new JniArgumentValue(auxScanner == null ? IntPtr.Zero : auxScanner.Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventAuxScannerAppeared.(Lcom/zebra/scannercontrol/DCSScannerInfo;Lcom/zebra/scannercontrol/DCSScannerInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) newTopology);
        GC.KeepAlive((object) auxScanner);
      }
    }

    [Register("dcssdkEventBarcode", "([BII)V", "")]
    public unsafe void DcssdkEventBarcode(byte[]? barcodeData, int barcodeType, int fromScannerId)
    {
      IntPtr num = JNIEnv.NewArray(barcodeData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(barcodeType),
          new JniArgumentValue(fromScannerId)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventBarcode.([BII)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (barcodeData != null)
        {
          JNIEnv.CopyArray(num, barcodeData);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) barcodeData);
      }
    }

    [Register("dcssdkEventBinaryData", "([BI)V", "")]
    public unsafe void DcssdkEventBinaryData(byte[]? binaryData, int fromScannerId)
    {
      IntPtr num = JNIEnv.NewArray(binaryData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(fromScannerId)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventBinaryData.([BI)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (binaryData != null)
        {
          JNIEnv.CopyArray(num, binaryData);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) binaryData);
      }
    }

    [Register("dcssdkEventCommunicationSessionEstablished", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "")]
    public unsafe void DcssdkEventCommunicationSessionEstablished(DCSScannerInfo? activeScanner)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(activeScanner == null ? IntPtr.Zero : activeScanner.Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventCommunicationSessionEstablished.(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) activeScanner);
      }
    }

    [Register("dcssdkEventCommunicationSessionTerminated", "(I)V", "")]
    public unsafe void DcssdkEventCommunicationSessionTerminated(int scannerId)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(scannerId)
      };
      LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventCommunicationSessionTerminated.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("dcssdkEventFirmwareUpdate", "(Lcom/zebra/scannercontrol/FirmwareUpdateEvent;)V", "")]
    public unsafe void DcssdkEventFirmwareUpdate(FirmwareUpdateEvent? firmwareUpdateEvent)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(firmwareUpdateEvent == null ? IntPtr.Zero : firmwareUpdateEvent.Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventFirmwareUpdate.(Lcom/zebra/scannercontrol/FirmwareUpdateEvent;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) firmwareUpdateEvent);
      }
    }

    [Register("dcssdkEventImage", "([BI)V", "")]
    public unsafe void DcssdkEventImage(byte[]? imageData, int fromScannerId)
    {
      IntPtr num = JNIEnv.NewArray(imageData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(fromScannerId)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventImage.([BI)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (imageData != null)
        {
          JNIEnv.CopyArray(num, imageData);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) imageData);
      }
    }

    [Register("dcssdkEventScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "")]
    public unsafe void DcssdkEventScannerAppeared(DCSScannerInfo? availableScanner)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(availableScanner == null ? IntPtr.Zero : availableScanner.Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventScannerAppeared.(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) availableScanner);
      }
    }

    [Register("dcssdkEventScannerDisappeared", "(I)V", "")]
    public unsafe void DcssdkEventScannerDisappeared(int scannerId)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(scannerId)
      };
      LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventScannerDisappeared.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("dcssdkEventVideo", "([BI)V", "")]
    public unsafe void DcssdkEventVideo(byte[]? videoFrame, int fromScannerId)
    {
      IntPtr num = JNIEnv.NewArray(videoFrame);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(fromScannerId)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("dcssdkEventVideo.([BI)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (videoFrame != null)
        {
          JNIEnv.CopyArray(num, videoFrame);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) videoFrame);
      }
    }

    [Register("setAuxiliaryScannerStatusChangeListener", "(Lcom/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener;)V", "")]
    public unsafe void SetAuxiliaryScannerStatusChangeListener(
      IAuxiliaryScannerStatusChangeListener? auxiliaryScannerStatusChangeListener)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(auxiliaryScannerStatusChangeListener == null ? IntPtr.Zero : ((Object) auxiliaryScannerStatusChangeListener).Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("setAuxiliaryScannerStatusChangeListener.(Lcom/zebra/barcode/sdk/AuxiliaryScannerStatusChangeListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) auxiliaryScannerStatusChangeListener);
      }
    }

    [Register("setFirmwareUpdateEventListeners", "(Lcom/zebra/barcode/sdk/FirmwareUpdateEventListener;)V", "")]
    public unsafe void SetFirmwareUpdateEventListeners(
      IFirmwareUpdateEventListener? firmwareUpdateEventListeners)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(firmwareUpdateEventListeners == null ? IntPtr.Zero : ((Object) firmwareUpdateEventListeners).Handle)
        };
        LegacySdkEventHandler._members.InstanceMethods.InvokeAbstractVoidMethod("setFirmwareUpdateEventListeners.(Lcom/zebra/barcode/sdk/FirmwareUpdateEventListener;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) firmwareUpdateEventListeners);
      }
    }

    public event System.EventHandler<AuxillaryDeviceAddedEventArgs> AuxillaryDeviceAdded
    {
      add
      {
        EventHelper.AddEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_SetAuxiliaryScannerStatusChangeListener, new Func<IAuxiliaryScannerStatusChangeListenerImplementor>(this.__CreateIAuxiliaryScannerStatusChangeListenerImplementor), new Action<IAuxiliaryScannerStatusChangeListener>(this.SetAuxiliaryScannerStatusChangeListener), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceAddedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_SetAuxiliaryScannerStatusChangeListener, LegacySdkEventHandler.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (LegacySdkEventHandler.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IAuxiliaryScannerStatusChangeListenerImplementor, bool>(IAuxiliaryScannerStatusChangeListenerImplementor.__IsEmpty)), (Action<IAuxiliaryScannerStatusChangeListener>) (__v => this.SetAuxiliaryScannerStatusChangeListener((IAuxiliaryScannerStatusChangeListener) null)), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceAddedHandler -= value));
      }
    }

    public event System.EventHandler<AuxillaryDeviceRemovedEventArgs> AuxillaryDeviceRemoved
    {
      add
      {
        EventHelper.AddEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_SetAuxiliaryScannerStatusChangeListener, new Func<IAuxiliaryScannerStatusChangeListenerImplementor>(this.__CreateIAuxiliaryScannerStatusChangeListenerImplementor), new Action<IAuxiliaryScannerStatusChangeListener>(this.SetAuxiliaryScannerStatusChangeListener), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceRemovedHandler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IAuxiliaryScannerStatusChangeListener, IAuxiliaryScannerStatusChangeListenerImplementor>(ref this.weak_implementor_SetAuxiliaryScannerStatusChangeListener, LegacySdkEventHandler.\u003C\u003EO.\u003C0\u003E____IsEmpty ?? (LegacySdkEventHandler.\u003C\u003EO.\u003C0\u003E____IsEmpty = new Func<IAuxiliaryScannerStatusChangeListenerImplementor, bool>(IAuxiliaryScannerStatusChangeListenerImplementor.__IsEmpty)), (Action<IAuxiliaryScannerStatusChangeListener>) (__v => this.SetAuxiliaryScannerStatusChangeListener((IAuxiliaryScannerStatusChangeListener) null)), (Action<IAuxiliaryScannerStatusChangeListenerImplementor>) (__h => __h.OnAuxillaryDeviceRemovedHandler -= value));
      }
    }

    private IAuxiliaryScannerStatusChangeListenerImplementor __CreateIAuxiliaryScannerStatusChangeListenerImplementor()
    {
      return new IAuxiliaryScannerStatusChangeListenerImplementor((object) this);
    }

    public event System.EventHandler<FirmwareUpdateEventEventArgs> FirmwareUpdateEventListeners
    {
      add
      {
        EventHelper.AddEventHandler<IFirmwareUpdateEventListener, IFirmwareUpdateEventListenerImplementor>(ref this.weak_implementor_SetFirmwareUpdateEventListeners, new Func<IFirmwareUpdateEventListenerImplementor>(this.__CreateIFirmwareUpdateEventListenerImplementor), new Action<IFirmwareUpdateEventListener>(this.SetFirmwareUpdateEventListeners), (Action<IFirmwareUpdateEventListenerImplementor>) (__h => __h.Handler += value));
      }
      remove
      {
        EventHelper.RemoveEventHandler<IFirmwareUpdateEventListener, IFirmwareUpdateEventListenerImplementor>(ref this.weak_implementor_SetFirmwareUpdateEventListeners, LegacySdkEventHandler.\u003C\u003EO.\u003C1\u003E____IsEmpty ?? (LegacySdkEventHandler.\u003C\u003EO.\u003C1\u003E____IsEmpty = new Func<IFirmwareUpdateEventListenerImplementor, bool>(IFirmwareUpdateEventListenerImplementor.__IsEmpty)), (Action<IFirmwareUpdateEventListener>) (__v => this.SetFirmwareUpdateEventListeners((IFirmwareUpdateEventListener) null)), (Action<IFirmwareUpdateEventListenerImplementor>) (__h => __h.Handler -= value));
      }
    }

    private IFirmwareUpdateEventListenerImplementor __CreateIFirmwareUpdateEventListenerImplementor()
    {
      return new IFirmwareUpdateEventListenerImplementor((object) this);
    }
  }
}
