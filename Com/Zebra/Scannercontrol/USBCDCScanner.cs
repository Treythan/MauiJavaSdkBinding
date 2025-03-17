// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.USBCDCScanner
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Hardware.Usb;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/USBCDCScanner", DoNotGenerateAcw = true)]
  public class USBCDCScanner : DCSScannerInfo
  {
    [Register("USB_CDC_RESPONSE_ACTION")]
    public const string UsbCdcResponseAction = "response_action";
    [Register("waitTime")]
    public const long WaitTime = 50;
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/USBCDCScanner", typeof (USBCDCScanner));
    private static Delegate? cb_isBulkFirmwareUpdateAvailable;
    private static Delegate? cb_setBulkFirmwareUpdateAvailable_Z;
    private static Delegate? cb_isFirmwareUpdateInProgress;
    private static Delegate? cb_setFirmwareUpdateInProgress_Z;
    private static Delegate? cb_getGUID;
    private static Delegate? cb_setGUID_Ljava_lang_String_;
    private static Delegate? cb_getInternalName;
    private static Delegate? cb_setInternalName_Ljava_lang_String_;
    private static Delegate? cb_isScaleAvailable;
    private static Delegate? cb_getNotificationEventsMask;
    private static Delegate? cb_setNotificationEventsMask_I;
    private static Delegate? cb_getPacketSize;
    private static Delegate? cb_getProductID;
    private static Delegate? cb_setProductID_I;
    private static Delegate? cb_isReady;
    private static Delegate? cb_setReady_Z;
    private static Delegate? cb_getSerialNumber;
    private static Delegate? cb_setSerialNumber_Ljava_lang_String_;
    private static Delegate? cb_isSsiPlusSupport;
    private static Delegate? cb_setSsiPlusSupport_Z;
    private static Delegate? cb_getTunnelAddress;
    private static Delegate? cb_getVendorID;
    private static Delegate? cb_setVendorID_I;
    private static Delegate? cb_barcodeEvent_arrayBI;
    private static Delegate? cb_binaryDataEvent_arrayB;
    private static Delegate? cb_cleanUp;
    private static Delegate? cb_cmdMPAck_I;
    private static Delegate? cb_communicationSessionEstablished;
    private static Delegate? cb_communicationSessionTerminated;
    private static Delegate? cb_connect;
    private static Delegate? cb_disable;
    private static Delegate? cb_disconnect;
    private static Delegate? cb_enable;
    private static Delegate? cb_enumerateEndPointsAndStartReading;
    private static Delegate? cb_getFileName_Landroid_net_Uri_;
    private static Delegate? cb_getFilePath_Landroid_net_Uri_;
    private static Delegate? cb_getmHWDevice;
    private static Delegate? cb_imageEvent_arrayB;
    private static Delegate? cb_initialize_Lcom_zebra_scannercontrol_SDKHandler_;
    private static Delegate? cb_postData_arrayB;
    private static Delegate? cb_readData_arrayB;
    private static Delegate? cb_readDataFromScanner_arrayBI;
    private static Delegate? cb_rsmEvent_arrayB;
    private static Delegate? cb_scannerAppeared;
    private static Delegate? cb_scannerDisAppeared;
    private static Delegate? cb_sendHostInit;
    private static Delegate? cb_setScaleDisable;
    private static Delegate? cb_setScaleEnable;
    private static Delegate? cb_setmHWDevice_Landroid_hardware_usb_UsbDevice_;
    private static Delegate? cb_setmUSBManager_Landroid_hardware_usb_UsbManager_;
    private static Delegate? cb_stopRSMEventThread;
    private static Delegate? cb_updateAssetInfo;
    private static Delegate? cb_updateScannerName;
    private static Delegate? cb_videoEvent_arrayB;
    private static Delegate? cb_breakdownMyTunnel;
    private static Delegate? cb_executeCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ;
    private static Delegate? cb_getTwoBytes_arrayBI;
    private static Delegate? cb_setupTunnelToMe;
    private static Delegate? cb_tunnelReportContext;
    private static Delegate? cb_tunnelReportNextHop;

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = USBCDCScanner._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => USBCDCScanner._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = USBCDCScanner._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => USBCDCScanner._members.ManagedPeerType;

    protected USBCDCScanner(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Landroid/content/Context;)V", "")]
    public unsafe USBCDCScanner(Context? context)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle)
        };
        JniObjectReference instance = USBCDCScanner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        USBCDCScanner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
      }
    }

    [Register(".ctor", "(Landroid/content/Context;Lcom/zebra/scannercontrol/USBCDCScanner;)V", "")]
    public unsafe USBCDCScanner(Context? context, USBCDCScanner? parent)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(parent == null ? IntPtr.Zero : parent.Handle)
        };
        JniObjectReference instance = USBCDCScanner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/zebra/scannercontrol/USBCDCScanner;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        USBCDCScanner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/zebra/scannercontrol/USBCDCScanner;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
        GC.KeepAlive((object) parent);
      }
    }

    private static Delegate GetIsBulkFirmwareUpdateAvailableHandler()
    {
      if ((object) USBCDCScanner.cb_isBulkFirmwareUpdateAvailable == null)
        USBCDCScanner.cb_isBulkFirmwareUpdateAvailable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_IsBulkFirmwareUpdateAvailable));
      return USBCDCScanner.cb_isBulkFirmwareUpdateAvailable;
    }

    private static bool n_IsBulkFirmwareUpdateAvailable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).BulkFirmwareUpdateAvailable;
    }

    private static Delegate GetSetBulkFirmwareUpdateAvailable_ZHandler()
    {
      if ((object) USBCDCScanner.cb_setBulkFirmwareUpdateAvailable_Z == null)
        USBCDCScanner.cb_setBulkFirmwareUpdateAvailable_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(USBCDCScanner.n_SetBulkFirmwareUpdateAvailable_Z));
      return USBCDCScanner.cb_setBulkFirmwareUpdateAvailable_Z;
    }

    private static void n_SetBulkFirmwareUpdateAvailable_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool bulkFirmwareUpdateAvailable)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).BulkFirmwareUpdateAvailable = bulkFirmwareUpdateAvailable;
    }

    public virtual unsafe bool BulkFirmwareUpdateAvailable
    {
      [Register("isBulkFirmwareUpdateAvailable", "()Z", "GetIsBulkFirmwareUpdateAvailableHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isBulkFirmwareUpdateAvailable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBulkFirmwareUpdateAvailable", "(Z)V", "GetSetBulkFirmwareUpdateAvailable_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setBulkFirmwareUpdateAvailable.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsFirmwareUpdateInProgressHandler()
    {
      if ((object) USBCDCScanner.cb_isFirmwareUpdateInProgress == null)
        USBCDCScanner.cb_isFirmwareUpdateInProgress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_IsFirmwareUpdateInProgress));
      return USBCDCScanner.cb_isFirmwareUpdateInProgress;
    }

    private static bool n_IsFirmwareUpdateInProgress(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).FirmwareUpdateInProgress;
    }

    private static Delegate GetSetFirmwareUpdateInProgress_ZHandler()
    {
      if ((object) USBCDCScanner.cb_setFirmwareUpdateInProgress_Z == null)
        USBCDCScanner.cb_setFirmwareUpdateInProgress_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(USBCDCScanner.n_SetFirmwareUpdateInProgress_Z));
      return USBCDCScanner.cb_setFirmwareUpdateInProgress_Z;
    }

    private static void n_SetFirmwareUpdateInProgress_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool p0)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).FirmwareUpdateInProgress = p0;
    }

    public virtual unsafe bool FirmwareUpdateInProgress
    {
      [Register("isFirmwareUpdateInProgress", "()Z", "GetIsFirmwareUpdateInProgressHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isFirmwareUpdateInProgress.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setFirmwareUpdateInProgress", "(Z)V", "GetSetFirmwareUpdateInProgress_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setFirmwareUpdateInProgress.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetGUIDHandler()
    {
      if ((object) USBCDCScanner.cb_getGUID == null)
        USBCDCScanner.cb_getGUID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_GetGUID));
      return USBCDCScanner.cb_getGUID;
    }

    private static IntPtr n_GetGUID(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).GUID);
    }

    private static Delegate GetSetGUID_Ljava_lang_String_Handler()
    {
      if ((object) USBCDCScanner.cb_setGUID_Ljava_lang_String_ == null)
        USBCDCScanner.cb_setGUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_SetGUID_Ljava_lang_String_));
      return USBCDCScanner.cb_setGUID_Ljava_lang_String_;
    }

    private static void n_SetGUID_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_GUID)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).GUID = JNIEnv.GetString(native_GUID, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? GUID
    {
      [Register("getGUID", "()Ljava/lang/String;", "GetGetGUIDHandler")] get
      {
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getGUID.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setGUID", "(Ljava/lang/String;)V", "GetSetGUID_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setGUID.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetInternalNameHandler()
    {
      if ((object) USBCDCScanner.cb_getInternalName == null)
        USBCDCScanner.cb_getInternalName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_GetInternalName));
      return USBCDCScanner.cb_getInternalName;
    }

    private static IntPtr n_GetInternalName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).InternalName);
    }

    private static Delegate GetSetInternalName_Ljava_lang_String_Handler()
    {
      if ((object) USBCDCScanner.cb_setInternalName_Ljava_lang_String_ == null)
        USBCDCScanner.cb_setInternalName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_SetInternalName_Ljava_lang_String_));
      return USBCDCScanner.cb_setInternalName_Ljava_lang_String_;
    }

    private static void n_SetInternalName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_internalName)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).InternalName = JNIEnv.GetString(native_internalName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? InternalName
    {
      [Register("getInternalName", "()Ljava/lang/String;", "GetGetInternalNameHandler")] get
      {
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getInternalName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setInternalName", "(Ljava/lang/String;)V", "GetSetInternalName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setInternalName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsScaleAvailableHandler()
    {
      if ((object) USBCDCScanner.cb_isScaleAvailable == null)
        USBCDCScanner.cb_isScaleAvailable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_IsScaleAvailable));
      return USBCDCScanner.cb_isScaleAvailable;
    }

    private static bool n_IsScaleAvailable(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).IsScaleAvailable;
    }

    public virtual unsafe bool IsScaleAvailable
    {
      [Register("isScaleAvailable", "()Z", "GetIsScaleAvailableHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isScaleAvailable.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetNotificationEventsMaskHandler()
    {
      if ((object) USBCDCScanner.cb_getNotificationEventsMask == null)
        USBCDCScanner.cb_getNotificationEventsMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(USBCDCScanner.n_GetNotificationEventsMask));
      return USBCDCScanner.cb_getNotificationEventsMask;
    }

    private static int n_GetNotificationEventsMask(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).NotificationEventsMask;
    }

    private static Delegate GetSetNotificationEventsMask_IHandler()
    {
      if ((object) USBCDCScanner.cb_setNotificationEventsMask_I == null)
        USBCDCScanner.cb_setNotificationEventsMask_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(USBCDCScanner.n_SetNotificationEventsMask_I));
      return USBCDCScanner.cb_setNotificationEventsMask_I;
    }

    private static void n_SetNotificationEventsMask_I(IntPtr jnienv, IntPtr native__this, int p0)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).NotificationEventsMask = p0;
    }

    public virtual unsafe int NotificationEventsMask
    {
      [Register("getNotificationEventsMask", "()I", "GetGetNotificationEventsMaskHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("getNotificationEventsMask.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNotificationEventsMask", "(I)V", "GetSetNotificationEventsMask_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setNotificationEventsMask.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPacketSizeHandler()
    {
      if ((object) USBCDCScanner.cb_getPacketSize == null)
        USBCDCScanner.cb_getPacketSize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_GetPacketSize));
      return USBCDCScanner.cb_getPacketSize;
    }

    private static bool n_GetPacketSize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).PacketSize;
    }

    protected virtual unsafe bool PacketSize
    {
      [Register("getPacketSize", "()Z", "GetGetPacketSizeHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("getPacketSize.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetProductIDHandler()
    {
      if ((object) USBCDCScanner.cb_getProductID == null)
        USBCDCScanner.cb_getProductID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(USBCDCScanner.n_GetProductID));
      return USBCDCScanner.cb_getProductID;
    }

    private static int n_GetProductID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).ProductID;
    }

    private static Delegate GetSetProductID_IHandler()
    {
      if ((object) USBCDCScanner.cb_setProductID_I == null)
        USBCDCScanner.cb_setProductID_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(USBCDCScanner.n_SetProductID_I));
      return USBCDCScanner.cb_setProductID_I;
    }

    private static void n_SetProductID_I(IntPtr jnienv, IntPtr native__this, int productID)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).ProductID = productID;
    }

    public virtual unsafe int ProductID
    {
      [Register("getProductID", "()I", "GetGetProductIDHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("getProductID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setProductID", "(I)V", "GetSetProductID_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setProductID.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsReadyHandler()
    {
      if ((object) USBCDCScanner.cb_isReady == null)
        USBCDCScanner.cb_isReady = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_IsReady));
      return USBCDCScanner.cb_isReady;
    }

    private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Ready;
    }

    private static Delegate GetSetReady_ZHandler()
    {
      if ((object) USBCDCScanner.cb_setReady_Z == null)
        USBCDCScanner.cb_setReady_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(USBCDCScanner.n_SetReady_Z));
      return USBCDCScanner.cb_setReady_Z;
    }

    private static void n_SetReady_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Ready = p0;
    }

    public virtual unsafe bool Ready
    {
      [Register("isReady", "()Z", "GetIsReadyHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isReady.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setReady", "(Z)V", "GetSetReady_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setReady.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetSerialNumberHandler()
    {
      if ((object) USBCDCScanner.cb_getSerialNumber == null)
        USBCDCScanner.cb_getSerialNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_GetSerialNumber));
      return USBCDCScanner.cb_getSerialNumber;
    }

    private static IntPtr n_GetSerialNumber(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber);
    }

    private static Delegate GetSetSerialNumber_Ljava_lang_String_Handler()
    {
      if ((object) USBCDCScanner.cb_setSerialNumber_Ljava_lang_String_ == null)
        USBCDCScanner.cb_setSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_SetSerialNumber_Ljava_lang_String_));
      return USBCDCScanner.cb_setSerialNumber_Ljava_lang_String_;
    }

    private static void n_SetSerialNumber_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber = JNIEnv.GetString(native_p0, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? SerialNumber
    {
      [Register("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")] get
      {
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getSerialNumber.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setSerialNumber.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsSsiPlusSupportHandler()
    {
      if ((object) USBCDCScanner.cb_isSsiPlusSupport == null)
        USBCDCScanner.cb_isSsiPlusSupport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_IsSsiPlusSupport));
      return USBCDCScanner.cb_isSsiPlusSupport;
    }

    private static bool n_IsSsiPlusSupport(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SsiPlusSupport;
    }

    private static Delegate GetSetSsiPlusSupport_ZHandler()
    {
      if ((object) USBCDCScanner.cb_setSsiPlusSupport_Z == null)
        USBCDCScanner.cb_setSsiPlusSupport_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(USBCDCScanner.n_SetSsiPlusSupport_Z));
      return USBCDCScanner.cb_setSsiPlusSupport_Z;
    }

    private static void n_SetSsiPlusSupport_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool ssiPlusSupport)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SsiPlusSupport = ssiPlusSupport;
    }

    public virtual unsafe bool SsiPlusSupport
    {
      [Register("isSsiPlusSupport", "()Z", "GetIsSsiPlusSupportHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("isSsiPlusSupport.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setSsiPlusSupport", "(Z)V", "GetSetSsiPlusSupport_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setSsiPlusSupport.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTunnelAddressHandler()
    {
      if ((object) USBCDCScanner.cb_getTunnelAddress == null)
        USBCDCScanner.cb_getTunnelAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_GetTunnelAddress));
      return USBCDCScanner.cb_getTunnelAddress;
    }

    private static IntPtr n_GetTunnelAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).TunnelAddress);
    }

    public virtual unsafe string? TunnelAddress
    {
      [Register("getTunnelAddress", "()Ljava/lang/String;", "GetGetTunnelAddressHandler")] get
      {
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getTunnelAddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetVendorIDHandler()
    {
      if ((object) USBCDCScanner.cb_getVendorID == null)
        USBCDCScanner.cb_getVendorID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(USBCDCScanner.n_GetVendorID));
      return USBCDCScanner.cb_getVendorID;
    }

    private static int n_GetVendorID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).VendorID;
    }

    private static Delegate GetSetVendorID_IHandler()
    {
      if ((object) USBCDCScanner.cb_setVendorID_I == null)
        USBCDCScanner.cb_setVendorID_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(USBCDCScanner.n_SetVendorID_I));
      return USBCDCScanner.cb_setVendorID_I;
    }

    private static void n_SetVendorID_I(IntPtr jnienv, IntPtr native__this, int vendorID)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).VendorID = vendorID;
    }

    public virtual unsafe int VendorID
    {
      [Register("getVendorID", "()I", "GetGetVendorIDHandler")] get
      {
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("getVendorID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setVendorID", "(I)V", "GetSetVendorID_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setVendorID.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetBarcodeEvent_arrayBIHandler()
    {
      if ((object) USBCDCScanner.cb_barcodeEvent_arrayBI == null)
        USBCDCScanner.cb_barcodeEvent_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(USBCDCScanner.n_BarcodeEvent_arrayBI));
      return USBCDCScanner.cb_barcodeEvent_arrayBI;
    }

    private static void n_BarcodeEvent_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      usbcdcScanner.BarcodeEvent(p0, p1_1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    [Register("barcodeEvent", "([BI)V", "GetBarcodeEvent_arrayBIHandler")]
    public virtual unsafe void BarcodeEvent(byte[]? p0, int p1)
    {
      IntPtr num = JNIEnv.NewArray(p0);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(p1)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("barcodeEvent.([BI)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (p0 != null)
        {
          JNIEnv.CopyArray(num, p0);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetBinaryDataEvent_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_binaryDataEvent_arrayB == null)
        USBCDCScanner.cb_binaryDataEvent_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_BinaryDataEvent_arrayB));
      return USBCDCScanner.cb_binaryDataEvent_arrayB;
    }

    private static void n_BinaryDataEvent_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      usbcdcScanner.BinaryDataEvent(p0);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    [Register("binaryDataEvent", "([B)V", "GetBinaryDataEvent_arrayBHandler")]
    public virtual unsafe void BinaryDataEvent(byte[]? p0)
    {
      IntPtr num = JNIEnv.NewArray(p0);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("binaryDataEvent.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (p0 != null)
        {
          JNIEnv.CopyArray(num, p0);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetCleanUpHandler()
    {
      if ((object) USBCDCScanner.cb_cleanUp == null)
        USBCDCScanner.cb_cleanUp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_CleanUp));
      return USBCDCScanner.cb_cleanUp;
    }

    private static void n_CleanUp(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).CleanUp();
    }

    [Register("cleanUp", "()V", "GetCleanUpHandler")]
    public virtual unsafe void CleanUp()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("cleanUp.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetCmdMPAck_IHandler()
    {
      if ((object) USBCDCScanner.cb_cmdMPAck_I == null)
        USBCDCScanner.cb_cmdMPAck_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_I(USBCDCScanner.n_CmdMPAck_I));
      return USBCDCScanner.cb_cmdMPAck_I;
    }

    private static int n_CmdMPAck_I(IntPtr jnienv, IntPtr native__this, int number)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).CmdMPAck(number);
    }

    [Register("cmdMPAck", "(I)I", "GetCmdMPAck_IHandler")]
    public virtual unsafe int CmdMPAck(int number)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(number)
      };
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("cmdMPAck.(I)I", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetCommunicationSessionEstablishedHandler()
    {
      if ((object) USBCDCScanner.cb_communicationSessionEstablished == null)
        USBCDCScanner.cb_communicationSessionEstablished = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_CommunicationSessionEstablished));
      return USBCDCScanner.cb_communicationSessionEstablished;
    }

    private static void n_CommunicationSessionEstablished(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).CommunicationSessionEstablished();
    }

    [Register("communicationSessionEstablished", "()V", "GetCommunicationSessionEstablishedHandler")]
    public virtual unsafe void CommunicationSessionEstablished()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("communicationSessionEstablished.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetCommunicationSessionTerminatedHandler()
    {
      if ((object) USBCDCScanner.cb_communicationSessionTerminated == null)
        USBCDCScanner.cb_communicationSessionTerminated = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_CommunicationSessionTerminated));
      return USBCDCScanner.cb_communicationSessionTerminated;
    }

    private static void n_CommunicationSessionTerminated(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).CommunicationSessionTerminated();
    }

    [Register("communicationSessionTerminated", "()V", "GetCommunicationSessionTerminatedHandler")]
    public virtual unsafe void CommunicationSessionTerminated()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("communicationSessionTerminated.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetConnectHandler()
    {
      if ((object) USBCDCScanner.cb_connect == null)
        USBCDCScanner.cb_connect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_Connect));
      return USBCDCScanner.cb_connect;
    }

    private static bool n_Connect(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Connect();
    }

    [Register("connect", "()Z", "GetConnectHandler")]
    public virtual unsafe bool Connect()
    {
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("connect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDisableHandler()
    {
      if ((object) USBCDCScanner.cb_disable == null)
        USBCDCScanner.cb_disable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_Disable));
      return USBCDCScanner.cb_disable;
    }

    private static void n_Disable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Disable();
    }

    [Register("disable", "()V", "GetDisableHandler")]
    public virtual unsafe void Disable()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("disable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDisconnectHandler()
    {
      if ((object) USBCDCScanner.cb_disconnect == null)
        USBCDCScanner.cb_disconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_Disconnect));
      return USBCDCScanner.cb_disconnect;
    }

    private static void n_Disconnect(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Disconnect();
    }

    [Register("disconnect", "()V", "GetDisconnectHandler")]
    public virtual unsafe void Disconnect()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("disconnect.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetEnableHandler()
    {
      if ((object) USBCDCScanner.cb_enable == null)
        USBCDCScanner.cb_enable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_Enable));
      return USBCDCScanner.cb_enable;
    }

    private static void n_Enable(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Enable();
    }

    [Register("enable", "()V", "GetEnableHandler")]
    public virtual unsafe void Enable()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("enable.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetEnumerateEndPointsAndStartReadingHandler()
    {
      if ((object) USBCDCScanner.cb_enumerateEndPointsAndStartReading == null)
        USBCDCScanner.cb_enumerateEndPointsAndStartReading = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_EnumerateEndPointsAndStartReading));
      return USBCDCScanner.cb_enumerateEndPointsAndStartReading;
    }

    private static bool n_EnumerateEndPointsAndStartReading(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).EnumerateEndPointsAndStartReading();
    }

    [Register("enumerateEndPointsAndStartReading", "()Z", "GetEnumerateEndPointsAndStartReadingHandler")]
    protected virtual unsafe bool EnumerateEndPointsAndStartReading()
    {
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("enumerateEndPointsAndStartReading.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetFileName_Landroid_net_Uri_Handler()
    {
      if ((object) USBCDCScanner.cb_getFileName_Landroid_net_Uri_ == null)
        USBCDCScanner.cb_getFileName_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(USBCDCScanner.n_GetFileName_Landroid_net_Uri_));
      return USBCDCScanner.cb_getFileName_Landroid_net_Uri_;
    }

    private static IntPtr n_GetFileName_Landroid_net_Uri_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).GetFileName(Object.GetObject<Uri>(native_p0, (JniHandleOwnership) 0)));
    }

    [Register("getFileName", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetFileName_Landroid_net_Uri_Handler")]
    public virtual unsafe string? GetFileName(Uri? p0)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
        };
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getFileName.(Landroid/net/Uri;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetGetFilePath_Landroid_net_Uri_Handler()
    {
      if ((object) USBCDCScanner.cb_getFilePath_Landroid_net_Uri_ == null)
        USBCDCScanner.cb_getFilePath_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(USBCDCScanner.n_GetFilePath_Landroid_net_Uri_));
      return USBCDCScanner.cb_getFilePath_Landroid_net_Uri_;
    }

    private static IntPtr n_GetFilePath_Landroid_net_Uri_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.NewString(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).GetFilePath(Object.GetObject<Uri>(native_p0, (JniHandleOwnership) 0)));
    }

    [Register("getFilePath", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetFilePath_Landroid_net_Uri_Handler")]
    public virtual unsafe string? GetFilePath(Uri? p0)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
        };
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getFilePath.(Landroid/net/Uri;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetGetmHWDeviceHandler()
    {
      if ((object) USBCDCScanner.cb_getmHWDevice == null)
        USBCDCScanner.cb_getmHWDevice = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_GetmHWDevice));
      return USBCDCScanner.cb_getmHWDevice;
    }

    private static IntPtr n_GetmHWDevice(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).GetmHWDevice());
    }

    [Register("getmHWDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetmHWDeviceHandler")]
    protected virtual unsafe UsbDevice? GetmHWDevice()
    {
      JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("getmHWDevice.()Landroid/hardware/usb/UsbDevice;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<UsbDevice>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetImageEvent_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_imageEvent_arrayB == null)
        USBCDCScanner.cb_imageEvent_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_ImageEvent_arrayB));
      return USBCDCScanner.cb_imageEvent_arrayB;
    }

    private static void n_ImageEvent_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      usbcdcScanner.ImageEvent(p0);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    [Register("imageEvent", "([B)V", "GetImageEvent_arrayBHandler")]
    public virtual unsafe void ImageEvent(byte[]? p0)
    {
      IntPtr num = JNIEnv.NewArray(p0);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("imageEvent.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (p0 != null)
        {
          JNIEnv.CopyArray(num, p0);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetInitialize_Lcom_zebra_scannercontrol_SDKHandler_Handler()
    {
      if ((object) USBCDCScanner.cb_initialize_Lcom_zebra_scannercontrol_SDKHandler_ == null)
        USBCDCScanner.cb_initialize_Lcom_zebra_scannercontrol_SDKHandler_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_Z(USBCDCScanner.n_Initialize_Lcom_zebra_scannercontrol_SDKHandler_));
      return USBCDCScanner.cb_initialize_Lcom_zebra_scannercontrol_SDKHandler_;
    }

    private static bool n_Initialize_Lcom_zebra_scannercontrol_SDKHandler_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native__sdkHandler)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).Initialize(Object.GetObject<SDKHandler>(native__sdkHandler, (JniHandleOwnership) 0));
    }

    [Register("initialize", "(Lcom/zebra/scannercontrol/SDKHandler;)Z", "GetInitialize_Lcom_zebra_scannercontrol_SDKHandler_Handler")]
    public virtual unsafe bool Initialize(SDKHandler? _sdkHandler)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(_sdkHandler == null ? IntPtr.Zero : _sdkHandler.Handle)
        };
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("initialize.(Lcom/zebra/scannercontrol/SDKHandler;)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) _sdkHandler);
      }
    }

    private static Delegate GetPostData_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_postData_arrayB == null)
        USBCDCScanner.cb_postData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_PostData_arrayB));
      return USBCDCScanner.cb_postData_arrayB;
    }

    private static void n_PostData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      usbcdcScanner.PostData(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("postData", "([B)V", "GetPostData_arrayBHandler")]
    public virtual unsafe void PostData(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("postData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetReadData_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_readData_arrayB == null)
        USBCDCScanner.cb_readData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_ReadData_arrayB));
      return USBCDCScanner.cb_readData_arrayB;
    }

    private static void n_ReadData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_data, (JniHandleOwnership) 0, typeof (byte));
      byte[] data = array;
      usbcdcScanner.ReadData(data);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_data);
    }

    [Register("readData", "([B)V", "GetReadData_arrayBHandler")]
    public virtual unsafe void ReadData(byte[]? data)
    {
      IntPtr num = JNIEnv.NewArray(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("readData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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

    private static Delegate GetReadDataFromScanner_arrayBIHandler()
    {
      if ((object) USBCDCScanner.cb_readDataFromScanner_arrayBI == null)
        USBCDCScanner.cb_readDataFromScanner_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(USBCDCScanner.n_ReadDataFromScanner_arrayBI));
      return USBCDCScanner.cb_readDataFromScanner_arrayBI;
    }

    private static void n_ReadDataFromScanner_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_buffer,
      int size)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_buffer, (JniHandleOwnership) 0, typeof (byte));
      byte[] buffer = array;
      int size1 = size;
      usbcdcScanner.ReadDataFromScanner(buffer, size1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_buffer);
    }

    [Register("readDataFromScanner", "([BI)V", "GetReadDataFromScanner_arrayBIHandler")]
    protected virtual unsafe void ReadDataFromScanner(byte[]? buffer, int size)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(size)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("readDataFromScanner.([BI)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }

    private static Delegate GetRsmEvent_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_rsmEvent_arrayB == null)
        USBCDCScanner.cb_rsmEvent_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_RsmEvent_arrayB));
      return USBCDCScanner.cb_rsmEvent_arrayB;
    }

    private static void n_RsmEvent_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      usbcdcScanner.RsmEvent(p0);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    [Register("rsmEvent", "([B)V", "GetRsmEvent_arrayBHandler")]
    public virtual unsafe void RsmEvent(byte[]? p0)
    {
      IntPtr num = JNIEnv.NewArray(p0);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("rsmEvent.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (p0 != null)
        {
          JNIEnv.CopyArray(num, p0);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetScannerAppearedHandler()
    {
      if ((object) USBCDCScanner.cb_scannerAppeared == null)
        USBCDCScanner.cb_scannerAppeared = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_ScannerAppeared));
      return USBCDCScanner.cb_scannerAppeared;
    }

    private static void n_ScannerAppeared(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).ScannerAppeared();
    }

    [Register("scannerAppeared", "()V", "GetScannerAppearedHandler")]
    public virtual unsafe void ScannerAppeared()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("scannerAppeared.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetScannerDisAppearedHandler()
    {
      if ((object) USBCDCScanner.cb_scannerDisAppeared == null)
        USBCDCScanner.cb_scannerDisAppeared = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_ScannerDisAppeared));
      return USBCDCScanner.cb_scannerDisAppeared;
    }

    private static void n_ScannerDisAppeared(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).ScannerDisAppeared();
    }

    [Register("scannerDisAppeared", "()V", "GetScannerDisAppearedHandler")]
    public virtual unsafe void ScannerDisAppeared()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("scannerDisAppeared.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSendHostInitHandler()
    {
      if ((object) USBCDCScanner.cb_sendHostInit == null)
        USBCDCScanner.cb_sendHostInit = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(USBCDCScanner.n_SendHostInit));
      return USBCDCScanner.cb_sendHostInit;
    }

    private static int n_SendHostInit(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SendHostInit();
    }

    [Register("sendHostInit", "()I", "GetSendHostInitHandler")]
    public virtual unsafe int SendHostInit()
    {
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("sendHostInit.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetScaleDisableHandler()
    {
      if ((object) USBCDCScanner.cb_setScaleDisable == null)
        USBCDCScanner.cb_setScaleDisable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_SetScaleDisable));
      return USBCDCScanner.cb_setScaleDisable;
    }

    private static IntPtr n_SetScaleDisable(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SetScaleDisable());
    }

    [Register("setScaleDisable", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetSetScaleDisableHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? SetScaleDisable()
    {
      JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("setScaleDisable.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetScaleEnableHandler()
    {
      if ((object) USBCDCScanner.cb_setScaleEnable == null)
        USBCDCScanner.cb_setScaleEnable = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_SetScaleEnable));
      return USBCDCScanner.cb_setScaleEnable;
    }

    private static IntPtr n_SetScaleEnable(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SetScaleEnable());
    }

    [Register("setScaleEnable", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetSetScaleEnableHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? SetScaleEnable()
    {
      JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("setScaleEnable.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetmHWDevice_Landroid_hardware_usb_UsbDevice_Handler()
    {
      if ((object) USBCDCScanner.cb_setmHWDevice_Landroid_hardware_usb_UsbDevice_ == null)
        USBCDCScanner.cb_setmHWDevice_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_SetmHWDevice_Landroid_hardware_usb_UsbDevice_));
      return USBCDCScanner.cb_setmHWDevice_Landroid_hardware_usb_UsbDevice_;
    }

    private static void n_SetmHWDevice_Landroid_hardware_usb_UsbDevice_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mHWDevice)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SetmHWDevice(Object.GetObject<UsbDevice>(native_mHWDevice, (JniHandleOwnership) 0));
    }

    [Register("setmHWDevice", "(Landroid/hardware/usb/UsbDevice;)V", "GetSetmHWDevice_Landroid_hardware_usb_UsbDevice_Handler")]
    protected virtual unsafe void SetmHWDevice(UsbDevice? mHWDevice)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(mHWDevice == null ? IntPtr.Zero : ((Object) mHWDevice).Handle)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setmHWDevice.(Landroid/hardware/usb/UsbDevice;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) mHWDevice);
      }
    }

    private static Delegate GetSetmUSBManager_Landroid_hardware_usb_UsbManager_Handler()
    {
      if ((object) USBCDCScanner.cb_setmUSBManager_Landroid_hardware_usb_UsbManager_ == null)
        USBCDCScanner.cb_setmUSBManager_Landroid_hardware_usb_UsbManager_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_SetmUSBManager_Landroid_hardware_usb_UsbManager_));
      return USBCDCScanner.cb_setmUSBManager_Landroid_hardware_usb_UsbManager_;
    }

    private static void n_SetmUSBManager_Landroid_hardware_usb_UsbManager_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mUSBManager)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SetmUSBManager(Object.GetObject<UsbManager>(native_mUSBManager, (JniHandleOwnership) 0));
    }

    [Register("setmUSBManager", "(Landroid/hardware/usb/UsbManager;)V", "GetSetmUSBManager_Landroid_hardware_usb_UsbManager_Handler")]
    protected virtual unsafe void SetmUSBManager(UsbManager? mUSBManager)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(mUSBManager == null ? IntPtr.Zero : ((Object) mUSBManager).Handle)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("setmUSBManager.(Landroid/hardware/usb/UsbManager;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) mUSBManager);
      }
    }

    private static Delegate GetStopRSMEventThreadHandler()
    {
      if ((object) USBCDCScanner.cb_stopRSMEventThread == null)
        USBCDCScanner.cb_stopRSMEventThread = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_StopRSMEventThread));
      return USBCDCScanner.cb_stopRSMEventThread;
    }

    private static void n_StopRSMEventThread(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).StopRSMEventThread();
    }

    [Register("stopRSMEventThread", "()V", "GetStopRSMEventThreadHandler")]
    public virtual unsafe void StopRSMEventThread()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("stopRSMEventThread.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetUpdateAssetInfoHandler()
    {
      if ((object) USBCDCScanner.cb_updateAssetInfo == null)
        USBCDCScanner.cb_updateAssetInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_UpdateAssetInfo));
      return USBCDCScanner.cb_updateAssetInfo;
    }

    private static void n_UpdateAssetInfo(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).UpdateAssetInfo();
    }

    [Register("updateAssetInfo", "()V", "GetUpdateAssetInfoHandler")]
    public virtual unsafe void UpdateAssetInfo()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("updateAssetInfo.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetUpdateScannerNameHandler()
    {
      if ((object) USBCDCScanner.cb_updateScannerName == null)
        USBCDCScanner.cb_updateScannerName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(USBCDCScanner.n_UpdateScannerName));
      return USBCDCScanner.cb_updateScannerName;
    }

    private static void n_UpdateScannerName(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).UpdateScannerName();
    }

    [Register("updateScannerName", "()V", "GetUpdateScannerNameHandler")]
    public virtual unsafe void UpdateScannerName()
    {
      USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("updateScannerName.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetVideoEvent_arrayBHandler()
    {
      if ((object) USBCDCScanner.cb_videoEvent_arrayB == null)
        USBCDCScanner.cb_videoEvent_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(USBCDCScanner.n_VideoEvent_arrayB));
      return USBCDCScanner.cb_videoEvent_arrayB;
    }

    private static void n_VideoEvent_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      usbcdcScanner.VideoEvent(p0);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    [Register("videoEvent", "([B)V", "GetVideoEvent_arrayBHandler")]
    public virtual unsafe void VideoEvent(byte[]? p0)
    {
      IntPtr num = JNIEnv.NewArray(p0);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        USBCDCScanner._members.InstanceMethods.InvokeVirtualVoidMethod("videoEvent.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (p0 != null)
        {
          JNIEnv.CopyArray(num, p0);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) p0);
      }
    }

    private static Delegate GetBreakdownMyTunnelHandler()
    {
      if ((object) USBCDCScanner.cb_breakdownMyTunnel == null)
        USBCDCScanner.cb_breakdownMyTunnel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_BreakdownMyTunnel));
      return USBCDCScanner.cb_breakdownMyTunnel;
    }

    private static bool n_BreakdownMyTunnel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).BreakdownMyTunnel();
    }

    [Register("breakdownMyTunnel", "()Z", "GetBreakdownMyTunnelHandler")]
    protected virtual unsafe bool BreakdownMyTunnel()
    {
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("breakdownMyTunnel.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetExecuteCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZHandler()
    {
      if ((object) USBCDCScanner.cb_executeCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ == null)
        USBCDCScanner.cb_executeCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLZZ_L(USBCDCScanner.n_ExecuteCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ));
      return USBCDCScanner.cb_executeCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ;
    }

    private static IntPtr n_ExecuteCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZ(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_opCode,
      IntPtr native_inXML,
      IntPtr native_outXML,
      bool isSync,
      bool isSSICommand)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_opCode, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_inXML, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_outXML, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE opCode = dcssdkCommandOpcode;
      string inXML = str;
      StringBuilder outXML = stringBuilder;
      int num1 = isSync ? 1 : 0;
      int num2 = isSSICommand ? 1 : 0;
      return JNIEnv.ToLocalJniHandle((IJavaObject) usbcdcScanner.ExecuteCommand(opCode, inXML, outXML, num1 != 0, num2 != 0));
    }

    [Register("executeCommand", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;ZZ)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetExecuteCommand_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ZZHandler")]
    protected virtual unsafe DCSSDKDefs.DCSSDK_RESULT? ExecuteCommand(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? opCode,
      string? inXML,
      StringBuilder? outXML,
      bool isSync,
      bool isSSICommand)
    {
      IntPtr num = JNIEnv.NewString(inXML);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(opCode == null ? IntPtr.Zero : ((Object) opCode).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(outXML == null ? IntPtr.Zero : ((Object) outXML).Handle),
          new JniArgumentValue(isSync),
          new JniArgumentValue(isSSICommand)
        };
        JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("executeCommand.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;ZZ)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) opCode);
        GC.KeepAlive((object) outXML);
      }
    }

    private static Delegate GetGetTwoBytes_arrayBIHandler()
    {
      if ((object) USBCDCScanner.cb_getTwoBytes_arrayBI == null)
        USBCDCScanner.cb_getTwoBytes_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_I(USBCDCScanner.n_GetTwoBytes_arrayBI));
      return USBCDCScanner.cb_getTwoBytes_arrayBI;
    }

    private static int n_GetTwoBytes_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_buffer,
      int offset)
    {
      USBCDCScanner usbcdcScanner = Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_buffer, (JniHandleOwnership) 0, typeof (byte));
      byte[] buffer = array;
      int offset1 = offset;
      int twoBytes = usbcdcScanner.GetTwoBytes(buffer, offset1);
      if (array == null)
        return twoBytes;
      JNIEnv.CopyArray(array, native_buffer);
      return twoBytes;
    }

    [Register("getTwoBytes", "([BI)I", "GetGetTwoBytes_arrayBIHandler")]
    protected virtual unsafe int GetTwoBytes(byte[]? buffer, int offset)
    {
      IntPtr num = JNIEnv.NewArray(buffer);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(offset)
        };
        return USBCDCScanner._members.InstanceMethods.InvokeVirtualInt32Method("getTwoBytes.([BI)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (buffer != null)
        {
          JNIEnv.CopyArray(num, buffer);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) buffer);
      }
    }

    [Register("setSdkHandler", "(Lcom/zebra/scannercontrol/SDKHandler;)V", "")]
    public static unsafe void SetSdkHandler(SDKHandler? sdkHandler)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(sdkHandler == null ? IntPtr.Zero : sdkHandler.Handle)
        };
        USBCDCScanner._members.StaticMethods.InvokeVoidMethod("setSdkHandler.(Lcom/zebra/scannercontrol/SDKHandler;)V", jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) sdkHandler);
      }
    }

    private static Delegate GetSetupTunnelToMeHandler()
    {
      if ((object) USBCDCScanner.cb_setupTunnelToMe == null)
        USBCDCScanner.cb_setupTunnelToMe = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(USBCDCScanner.n_SetupTunnelToMe));
      return USBCDCScanner.cb_setupTunnelToMe;
    }

    private static bool n_SetupTunnelToMe(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).SetupTunnelToMe();
    }

    [Register("setupTunnelToMe", "()Z", "GetSetupTunnelToMeHandler")]
    protected virtual unsafe bool SetupTunnelToMe()
    {
      return USBCDCScanner._members.InstanceMethods.InvokeVirtualBooleanMethod("setupTunnelToMe.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetTunnelReportContextHandler()
    {
      if ((object) USBCDCScanner.cb_tunnelReportContext == null)
        USBCDCScanner.cb_tunnelReportContext = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_TunnelReportContext));
      return USBCDCScanner.cb_tunnelReportContext;
    }

    private static IntPtr n_TunnelReportContext(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).TunnelReportContext());
    }

    [Register("tunnelReportContext", "()[B", "GetTunnelReportContextHandler")]
    protected virtual unsafe byte[]? TunnelReportContext()
    {
      JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("tunnelReportContext.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetTunnelReportNextHopHandler()
    {
      if ((object) USBCDCScanner.cb_tunnelReportNextHop == null)
        USBCDCScanner.cb_tunnelReportNextHop = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(USBCDCScanner.n_TunnelReportNextHop));
      return USBCDCScanner.cb_tunnelReportNextHop;
    }

    private static IntPtr n_TunnelReportNextHop(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<USBCDCScanner>(jnienv, native__this, (JniHandleOwnership) 0).TunnelReportNextHop());
    }

    [Register("tunnelReportNextHop", "()[B", "GetTunnelReportNextHopHandler")]
    protected virtual unsafe byte[]? TunnelReportNextHop()
    {
      JniObjectReference jniObjectReference = USBCDCScanner._members.InstanceMethods.InvokeVirtualObjectMethod("tunnelReportNextHop.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    [Register("com/zebra/scannercontrol/USBCDCScanner$SSIDecodeDataPlus", DoNotGenerateAcw = true)]
    public class SSIDecodeDataPlus : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/USBCDCScanner$SSIDecodeDataPlus", typeof (USBCDCScanner.SSIDecodeDataPlus));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = USBCDCScanner.SSIDecodeDataPlus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => USBCDCScanner.SSIDecodeDataPlus._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = USBCDCScanner.SSIDecodeDataPlus._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => USBCDCScanner.SSIDecodeDataPlus._members.ManagedPeerType;
      }

      protected SSIDecodeDataPlus(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "()V", "")]
      public unsafe SSIDecodeDataPlus()
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        JniObjectReference instance = USBCDCScanner.SSIDecodeDataPlus._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        USBCDCScanner.SSIDecodeDataPlus._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      [Register("getASCIIDataFromRawData", "(Ljava/io/ByteArrayOutputStream;)Ljava/io/ByteArrayOutputStream;", "")]
      public static unsafe ByteArrayOutputStream? GetASCIIDataFromRawData(
        ByteArrayOutputStream? rawData)
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(rawData == null ? IntPtr.Zero : ((Object) rawData).Handle)
          };
          JniObjectReference jniObjectReference = USBCDCScanner.SSIDecodeDataPlus._members.StaticMethods.InvokeObjectMethod("getASCIIDataFromRawData.(Ljava/io/ByteArrayOutputStream;)Ljava/io/ByteArrayOutputStream;", jniArgumentValuePtr);
          return Object.GetObject<ByteArrayOutputStream>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          GC.KeepAlive((object) rawData);
        }
      }
    }
  }
}
