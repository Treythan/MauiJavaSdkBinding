// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.IDcsSdkApiInvoker
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/IDcsSdkApi", DoNotGenerateAcw = true)]
  internal class IDcsSdkApiInvoker : Object, IDcsSdkApi, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/IDcsSdkApi", typeof (IDcsSdkApiInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_dcssdkClearBTAddress;
    private IntPtr id_dcssdkClearBTAddress;
    private static Delegate? cb_dcssdkClose;
    private IntPtr id_dcssdkClose;
    private static Delegate? cb_dcssdkEnableAutomaticSessionReestablishment_ZI;
    private IntPtr id_dcssdkEnableAutomaticSessionReestablishment_ZI;
    private static Delegate? cb_dcssdkEnableAvailableScannersDetection_Z;
    private IntPtr id_dcssdkEnableAvailableScannersDetection_Z;
    private static Delegate? cb_dcssdkEnableBluetoothScannersDiscovery_Z;
    private IntPtr id_dcssdkEnableBluetoothScannersDiscovery_Z;
    private static Delegate? cb_dcssdkEstablishCommunicationSession_I;
    private IntPtr id_dcssdkEstablishCommunicationSession_I;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_;
    private IntPtr id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_;
    private IntPtr id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private IntPtr id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private static Delegate? cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private IntPtr id_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private static Delegate? cb_dcssdkGetActiveScannersList;
    private IntPtr id_dcssdkGetActiveScannersList;
    private static Delegate? cb_dcssdkGetActiveScannersList_Ljava_util_List_;
    private IntPtr id_dcssdkGetActiveScannersList_Ljava_util_List_;
    private static Delegate? cb_dcssdkGetAvailableScannersList;
    private IntPtr id_dcssdkGetAvailableScannersList;
    private static Delegate? cb_dcssdkGetAvailableScannersList_Ljava_util_List_;
    private IntPtr id_dcssdkGetAvailableScannersList_Ljava_util_List_;
    private static Delegate? cb_dcssdkGetIDCConfig;
    private IntPtr id_dcssdkGetIDCConfig;
    private static Delegate? cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_;
    private IntPtr id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_;
    private static Delegate? cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_;
    private IntPtr id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_;
    private static Delegate? cb_dcssdkGetUSBSNAPIWithImagingBarcode;
    private IntPtr id_dcssdkGetUSBSNAPIWithImagingBarcode;
    private static Delegate? cb_dcssdkGetVersion;
    private IntPtr id_dcssdkGetVersion;
    private static Delegate? cb_dcssdkSetBTAddress_Ljava_lang_String_;
    private IntPtr id_dcssdkSetBTAddress_Ljava_lang_String_;
    private static Delegate? cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_;
    private IntPtr id_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_;
    private static Delegate? cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_;
    private IntPtr id_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_;
    private static Delegate? cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_;
    private IntPtr id_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_;
    private static Delegate? cb_dcssdkSetSTCEnabledState_Z;
    private IntPtr id_dcssdkSetSTCEnabledState_Z;
    private static Delegate? cb_dcssdkStartScanForAvailableDevices;
    private IntPtr id_dcssdkStartScanForAvailableDevices;
    private static Delegate? cb_dcssdkStartScanForTopologyChanges;
    private IntPtr id_dcssdkStartScanForTopologyChanges;
    private static Delegate? cb_dcssdkStopScanningDevices;
    private IntPtr id_dcssdkStopScanningDevices;
    private static Delegate? cb_dcssdkSubsribeForEvents_I;
    private IntPtr id_dcssdkSubsribeForEvents_I;
    private static Delegate? cb_dcssdkTerminateCommunicationSession_I;
    private IntPtr id_dcssdkTerminateCommunicationSession_I;
    private static Delegate? cb_dcssdkUnsubsribeForEvents_I;
    private IntPtr id_dcssdkUnsubsribeForEvents_I;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IDcsSdkApiInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IDcsSdkApiInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IDcsSdkApiInvoker._members.ManagedPeerType;

    public static IDcsSdkApi? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IDcsSdkApi>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IDcsSdkApiInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.scannercontrol.IDcsSdkApi'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IDcsSdkApiInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IDcsSdkApiInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetDcssdkClearBTAddressHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkClearBTAddress == null)
        IDcsSdkApiInvoker.cb_dcssdkClearBTAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkClearBTAddress));
      return IDcsSdkApiInvoker.cb_dcssdkClearBTAddress;
    }

    private static IntPtr n_DcssdkClearBTAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkClearBTAddress());
    }

    public DCSSDKDefs.DCSSDK_RESULT? DcssdkClearBTAddress()
    {
      if (this.id_dcssdkClearBTAddress == IntPtr.Zero)
        this.id_dcssdkClearBTAddress = JNIEnv.GetMethodID(this.class_ref, "dcssdkClearBTAddress", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkClearBTAddress), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkCloseHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkClose == null)
        IDcsSdkApiInvoker.cb_dcssdkClose = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkClose));
      return IDcsSdkApiInvoker.cb_dcssdkClose;
    }

    private static IntPtr n_DcssdkClose(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkClose());
    }

    public DCSSDKDefs.DCSSDK_RESULT? DcssdkClose()
    {
      if (this.id_dcssdkClose == IntPtr.Zero)
        this.id_dcssdkClose = JNIEnv.GetMethodID(this.class_ref, "dcssdkClose", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkClose), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableAutomaticSessionReestablishment_ZIHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkEnableAutomaticSessionReestablishment_ZI == null)
        IDcsSdkApiInvoker.cb_dcssdkEnableAutomaticSessionReestablishment_ZI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZI_L(IDcsSdkApiInvoker.n_DcssdkEnableAutomaticSessionReestablishment_ZI));
      return IDcsSdkApiInvoker.cb_dcssdkEnableAutomaticSessionReestablishment_ZI;
    }

    private static IntPtr n_DcssdkEnableAutomaticSessionReestablishment_ZI(
      IntPtr jnienv,
      IntPtr native__this,
      bool p0,
      int p1)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableAutomaticSessionReestablishment(p0, p1));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAutomaticSessionReestablishment(
      bool p0,
      int p1)
    {
      if (this.id_dcssdkEnableAutomaticSessionReestablishment_ZI == IntPtr.Zero)
        this.id_dcssdkEnableAutomaticSessionReestablishment_ZI = JNIEnv.GetMethodID(this.class_ref, "dcssdkEnableAutomaticSessionReestablishment", "(ZI)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(p0),
        new JValue(p1)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkEnableAutomaticSessionReestablishment_ZI, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableAvailableScannersDetection_ZHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkEnableAvailableScannersDetection_Z == null)
        IDcsSdkApiInvoker.cb_dcssdkEnableAvailableScannersDetection_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(IDcsSdkApiInvoker.n_DcssdkEnableAvailableScannersDetection_Z));
      return IDcsSdkApiInvoker.cb_dcssdkEnableAvailableScannersDetection_Z;
    }

    private static IntPtr n_DcssdkEnableAvailableScannersDetection_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableAvailableScannersDetection(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAvailableScannersDetection(bool p0)
    {
      if (this.id_dcssdkEnableAvailableScannersDetection_Z == IntPtr.Zero)
        this.id_dcssdkEnableAvailableScannersDetection_Z = JNIEnv.GetMethodID(this.class_ref, "dcssdkEnableAvailableScannersDetection", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkEnableAvailableScannersDetection_Z, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableBluetoothScannersDiscovery_ZHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkEnableBluetoothScannersDiscovery_Z == null)
        IDcsSdkApiInvoker.cb_dcssdkEnableBluetoothScannersDiscovery_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(IDcsSdkApiInvoker.n_DcssdkEnableBluetoothScannersDiscovery_Z));
      return IDcsSdkApiInvoker.cb_dcssdkEnableBluetoothScannersDiscovery_Z;
    }

    private static IntPtr n_DcssdkEnableBluetoothScannersDiscovery_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableBluetoothScannersDiscovery(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableBluetoothScannersDiscovery(bool p0)
    {
      if (this.id_dcssdkEnableBluetoothScannersDiscovery_Z == IntPtr.Zero)
        this.id_dcssdkEnableBluetoothScannersDiscovery_Z = JNIEnv.GetMethodID(this.class_ref, "dcssdkEnableBluetoothScannersDiscovery", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkEnableBluetoothScannersDiscovery_Z, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEstablishCommunicationSession_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkEstablishCommunicationSession_I == null)
        IDcsSdkApiInvoker.cb_dcssdkEstablishCommunicationSession_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(IDcsSdkApiInvoker.n_DcssdkEstablishCommunicationSession_I));
      return IDcsSdkApiInvoker.cb_dcssdkEstablishCommunicationSession_I;
    }

    private static IntPtr n_DcssdkEstablishCommunicationSession_I(
      IntPtr jnienv,
      IntPtr native__this,
      int p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEstablishCommunicationSession(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEstablishCommunicationSession(int p0)
    {
      if (this.id_dcssdkEstablishCommunicationSession_I == IntPtr.Zero)
        this.id_dcssdkEstablishCommunicationSession_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkEstablishCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkEstablishCommunicationSession_I, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ == null)
        IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(IDcsSdkApiInvoker.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_));
      return IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_p0, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_p1, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE p0 = dcssdkCommandOpcode;
      string p1 = str;
      return JNIEnv.NewString(dcsSdkApi.DcssdkExecuteCommandOpCodeInXMLForScanner(p0, p1));
    }

    public unsafe string? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1)
    {
      if (this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ == IntPtr.Zero)
        this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;)Ljava/lang/String;");
      IntPtr num = JNIEnv.NewString(p1);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(num)
      };
      string str = JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return str;
    }

    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ == null)
        IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(IDcsSdkApiInvoker.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_));
      return IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_;
    }

    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1,
      IntPtr native_p2)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_p0, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_p1, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_p2, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE p0 = dcssdkCommandOpcode;
      string p1 = str;
      StringBuilder p2 = stringBuilder;
      return JNIEnv.ToLocalJniHandle((IJavaObject) dcsSdkApi.DcssdkExecuteCommandOpCodeInXMLForScanner(p0, p1, p2));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2)
    {
      if (this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ == IntPtr.Zero)
        this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr num = JNIEnv.NewString(p1);
      JValue* jvaluePtr = stackalloc JValue[3]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(num),
        new JValue(p2 == null ? IntPtr.Zero : ((Object) p2).Handle)
      };
      DCSSDKDefs.DCSSDK_RESULT dcssdkResult = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return dcssdkResult;
    }

    [Obsolete]
    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == null)
        IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLI_L(IDcsSdkApiInvoker.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I));
      return IDcsSdkApiInvoker.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    }

    [Obsolete]
    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1,
      IntPtr native_p2,
      int p3)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_p0, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_p1, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_p2, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE p0 = dcssdkCommandOpcode;
      string p1 = str;
      StringBuilder p2 = stringBuilder;
      int p3_1 = p3;
      return JNIEnv.ToLocalJniHandle((IJavaObject) dcsSdkApi.DcssdkExecuteCommandOpCodeInXMLForScanner(p0, p1, p2, p3_1));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2,
      int p3)
    {
      if (this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == IntPtr.Zero)
        this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr num = JNIEnv.NewString(p1);
      JValue* jvaluePtr = stackalloc JValue[4]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(num),
        new JValue(p2 == null ? IntPtr.Zero : ((Object) p2).Handle),
        new JValue(p3)
      };
      DCSSDKDefs.DCSSDK_RESULT dcssdkResult = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return dcssdkResult;
    }

    private static Delegate GetDcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == null)
        IDcsSdkApiInvoker.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLI_L(IDcsSdkApiInvoker.n_DcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I));
      return IDcsSdkApiInvoker.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    }

    private static IntPtr n_DcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1,
      IntPtr native_p2,
      int p3)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_p0, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_p1, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_p2, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE p0 = dcssdkCommandOpcode;
      string p1 = str;
      StringBuilder p2 = stringBuilder;
      int p3_1 = p3;
      return JNIEnv.ToLocalJniHandle((IJavaObject) dcsSdkApi.DcssdkExecuteSSICommandOpCodeInXMLForScanner(p0, p1, p2, p3_1));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteSSICommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2,
      int p3)
    {
      if (this.id_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == IntPtr.Zero)
        this.id_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkExecuteSSICommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr num = JNIEnv.NewString(p1);
      JValue* jvaluePtr = stackalloc JValue[4]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(num),
        new JValue(p2 == null ? IntPtr.Zero : ((Object) p2).Handle),
        new JValue(p3)
      };
      DCSSDKDefs.DCSSDK_RESULT dcssdkResult = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return dcssdkResult;
    }

    private static Delegate GetDcssdkGetActiveScannersListHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList == null)
        IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkGetActiveScannersList));
      return IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList;
    }

    private static IntPtr n_DcssdkGetActiveScannersList(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<DCSScannerInfo>.ToLocalJniHandle(Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetActiveScannersList());
    }

    public IList<DCSScannerInfo>? DcssdkGetActiveScannersList()
    {
      if (this.id_dcssdkGetActiveScannersList == IntPtr.Zero)
        this.id_dcssdkGetActiveScannersList = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetActiveScannersList", "()Ljava/util/List;");
      return JavaList<DCSScannerInfo>.FromJniHandle(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetActiveScannersList), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetActiveScannersList_Ljava_util_List_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList_Ljava_util_List_ == null)
        IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkGetActiveScannersList_Ljava_util_List_));
      return IDcsSdkApiInvoker.cb_dcssdkGetActiveScannersList_Ljava_util_List_;
    }

    private static IntPtr n_DcssdkGetActiveScannersList_Ljava_util_List_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetActiveScannersList(JavaList<DCSScannerInfo>.FromJniHandle(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkGetActiveScannersList(IList<DCSScannerInfo>? p0)
    {
      if (this.id_dcssdkGetActiveScannersList_Ljava_util_List_ == IntPtr.Zero)
        this.id_dcssdkGetActiveScannersList_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetActiveScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr localJniHandle = JavaList<DCSScannerInfo>.ToLocalJniHandle(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(localJniHandle)
      };
      DCSSDKDefs.DCSSDK_RESULT activeScannersList = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetActiveScannersList_Ljava_util_List_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(localJniHandle);
      return activeScannersList;
    }

    private static Delegate GetDcssdkGetAvailableScannersListHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList == null)
        IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkGetAvailableScannersList));
      return IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList;
    }

    private static IntPtr n_DcssdkGetAvailableScannersList(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<DCSScannerInfo>.ToLocalJniHandle(Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetAvailableScannersList());
    }

    public IList<DCSScannerInfo>? DcssdkGetAvailableScannersList()
    {
      if (this.id_dcssdkGetAvailableScannersList == IntPtr.Zero)
        this.id_dcssdkGetAvailableScannersList = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetAvailableScannersList", "()Ljava/util/List;");
      return JavaList<DCSScannerInfo>.FromJniHandle(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetAvailableScannersList), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetAvailableScannersList_Ljava_util_List_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList_Ljava_util_List_ == null)
        IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkGetAvailableScannersList_Ljava_util_List_));
      return IDcsSdkApiInvoker.cb_dcssdkGetAvailableScannersList_Ljava_util_List_;
    }

    private static IntPtr n_DcssdkGetAvailableScannersList_Ljava_util_List_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetAvailableScannersList(JavaList<DCSScannerInfo>.FromJniHandle(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkGetAvailableScannersList(IList<DCSScannerInfo>? p0)
    {
      if (this.id_dcssdkGetAvailableScannersList_Ljava_util_List_ == IntPtr.Zero)
        this.id_dcssdkGetAvailableScannersList_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetAvailableScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr localJniHandle = JavaList<DCSScannerInfo>.ToLocalJniHandle(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(localJniHandle)
      };
      DCSSDKDefs.DCSSDK_RESULT availableScannersList = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetAvailableScannersList_Ljava_util_List_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(localJniHandle);
      return availableScannersList;
    }

    private static Delegate GetDcssdkGetIDCConfigHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetIDCConfig == null)
        IDcsSdkApiInvoker.cb_dcssdkGetIDCConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkGetIDCConfig));
      return IDcsSdkApiInvoker.cb_dcssdkGetIDCConfig;
    }

    private static IntPtr n_DcssdkGetIDCConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetIDCConfig());
    }

    public IDCConfig? DcssdkGetIDCConfig()
    {
      if (this.id_dcssdkGetIDCConfig == IntPtr.Zero)
        this.id_dcssdkGetIDCConfig = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetIDCConfig", "()Lcom/zebra/scannercontrol/IDCConfig;");
      return Object.GetObject<IDCConfig>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetIDCConfig), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ == null)
        IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(IDcsSdkApiInvoker.n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_));
      return IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_;
    }

    private static IntPtr n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL dcssdkBtProtocol = Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(native_p0, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG dcssdkBtScannerConfig = Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(native_p1, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL p0 = dcssdkBtProtocol;
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG p1 = dcssdkBtScannerConfig;
      return JNIEnv.ToLocalJniHandle((IJavaObject) dcsSdkApi.DcssdkGetPairingBarcode(p0, p1));
    }

    public unsafe BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? p0,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? p1)
    {
      if (this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ == IntPtr.Zero)
        this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;)Lcom/zebra/scannercontrol/BarCodeView;");
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(p1 == null ? IntPtr.Zero : ((Object) p1).Handle)
      };
      return Object.GetObject<BarCodeView>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ == null)
        IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(IDcsSdkApiInvoker.n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_));
      return IDcsSdkApiInvoker.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1,
      IntPtr native_p2)
    {
      IDcsSdkApi dcsSdkApi = Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL dcssdkBtProtocol = Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(native_p0, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG dcssdkBtScannerConfig = Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(native_p1, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_p2, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL p0 = dcssdkBtProtocol;
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG p1 = dcssdkBtScannerConfig;
      string p2 = str;
      return JNIEnv.ToLocalJniHandle((IJavaObject) dcsSdkApi.DcssdkGetPairingBarcode(p0, p1, p2));
    }

    public unsafe BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? p0,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? p1,
      string? p2)
    {
      if (this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ == IntPtr.Zero)
        this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;Ljava/lang/String;)Lcom/zebra/scannercontrol/BarCodeView;");
      IntPtr num = JNIEnv.NewString(p2);
      JValue* jvaluePtr = stackalloc JValue[3]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle),
        new JValue(p1 == null ? IntPtr.Zero : ((Object) p1).Handle),
        new JValue(num)
      };
      BarCodeView pairingBarcode = Object.GetObject<BarCodeView>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return pairingBarcode;
    }

    private static Delegate GetDcssdkGetUSBSNAPIWithImagingBarcodeHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetUSBSNAPIWithImagingBarcode == null)
        IDcsSdkApiInvoker.cb_dcssdkGetUSBSNAPIWithImagingBarcode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkGetUSBSNAPIWithImagingBarcode));
      return IDcsSdkApiInvoker.cb_dcssdkGetUSBSNAPIWithImagingBarcode;
    }

    private static IntPtr n_DcssdkGetUSBSNAPIWithImagingBarcode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetUSBSNAPIWithImagingBarcode());
    }

    public BarCodeView? DcssdkGetUSBSNAPIWithImagingBarcode()
    {
      if (this.id_dcssdkGetUSBSNAPIWithImagingBarcode == IntPtr.Zero)
        this.id_dcssdkGetUSBSNAPIWithImagingBarcode = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetUSBSNAPIWithImagingBarcode", "()Lcom/zebra/scannercontrol/BarCodeView;");
      return Object.GetObject<BarCodeView>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetUSBSNAPIWithImagingBarcode), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetVersionHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkGetVersion == null)
        IDcsSdkApiInvoker.cb_dcssdkGetVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkGetVersion));
      return IDcsSdkApiInvoker.cb_dcssdkGetVersion;
    }

    private static IntPtr n_DcssdkGetVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetVersion());
    }

    public string? DcssdkGetVersion()
    {
      if (this.id_dcssdkGetVersion == IntPtr.Zero)
        this.id_dcssdkGetVersion = JNIEnv.GetMethodID(this.class_ref, "dcssdkGetVersion", "()Ljava/lang/String;");
      return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkGetVersion), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSetBTAddress_Ljava_lang_String_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSetBTAddress_Ljava_lang_String_ == null)
        IDcsSdkApiInvoker.cb_dcssdkSetBTAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkSetBTAddress_Ljava_lang_String_));
      return IDcsSdkApiInvoker.cb_dcssdkSetBTAddress_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkSetBTAddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetBTAddress(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetBTAddress(string? p0)
    {
      if (this.id_dcssdkSetBTAddress_Ljava_lang_String_ == IntPtr.Zero)
        this.id_dcssdkSetBTAddress_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkSetBTAddress", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      IntPtr num = JNIEnv.NewString(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      DCSSDKDefs.DCSSDK_RESULT dcssdkResult = Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSetBTAddress_Ljava_lang_String_, jvaluePtr), (JniHandleOwnership) 1);
      JNIEnv.DeleteLocalRef(num);
      return dcssdkResult;
    }

    private static Delegate GetDcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ == null)
        IDcsSdkApiInvoker.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_));
      return IDcsSdkApiInvoker.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_;
    }

    private static IntPtr n_DcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetDelegate(Object.GetObject<IDcsSdkApiDelegate>(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetDelegate(IDcsSdkApiDelegate? p0)
    {
      if (this.id_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ == IntPtr.Zero)
        this.id_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkSetDelegate", "(Lcom/zebra/scannercontrol/IDcsSdkApiDelegate;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ == null)
        IDcsSdkApiInvoker.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_));
      return IDcsSdkApiInvoker.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_;
    }

    private static IntPtr n_DcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetIDCConfig(Object.GetObject<IDCConfig>(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetIDCConfig(IDCConfig? p0)
    {
      if (this.id_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ == IntPtr.Zero)
        this.id_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkSetIDCConfig", "(Lcom/zebra/scannercontrol/IDCConfig;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_Handler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ == null)
        IDcsSdkApiInvoker.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IDcsSdkApiInvoker.n_DcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_));
      return IDcsSdkApiInvoker.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_;
    }

    private static IntPtr n_DcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetOperationalMode(Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(native_p0, (JniHandleOwnership) 0)));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetOperationalMode(DCSSDKDefs.DCSSDK_MODE? p0)
    {
      if (this.id_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ == IntPtr.Zero)
        this.id_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkSetOperationalMode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSetSTCEnabledState_ZHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSetSTCEnabledState_Z == null)
        IDcsSdkApiInvoker.cb_dcssdkSetSTCEnabledState_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(IDcsSdkApiInvoker.n_DcssdkSetSTCEnabledState_Z));
      return IDcsSdkApiInvoker.cb_dcssdkSetSTCEnabledState_Z;
    }

    private static IntPtr n_DcssdkSetSTCEnabledState_Z(IntPtr jnienv, IntPtr native__this, bool p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetSTCEnabledState(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetSTCEnabledState(bool p0)
    {
      if (this.id_dcssdkSetSTCEnabledState_Z == IntPtr.Zero)
        this.id_dcssdkSetSTCEnabledState_Z = JNIEnv.GetMethodID(this.class_ref, "dcssdkSetSTCEnabledState", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSetSTCEnabledState_Z, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStartScanForAvailableDevicesHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkStartScanForAvailableDevices == null)
        IDcsSdkApiInvoker.cb_dcssdkStartScanForAvailableDevices = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkStartScanForAvailableDevices));
      return IDcsSdkApiInvoker.cb_dcssdkStartScanForAvailableDevices;
    }

    private static IntPtr n_DcssdkStartScanForAvailableDevices(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStartScanForAvailableDevices());
    }

    public DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForAvailableDevices()
    {
      if (this.id_dcssdkStartScanForAvailableDevices == IntPtr.Zero)
        this.id_dcssdkStartScanForAvailableDevices = JNIEnv.GetMethodID(this.class_ref, "dcssdkStartScanForAvailableDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkStartScanForAvailableDevices), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStartScanForTopologyChangesHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkStartScanForTopologyChanges == null)
        IDcsSdkApiInvoker.cb_dcssdkStartScanForTopologyChanges = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkStartScanForTopologyChanges));
      return IDcsSdkApiInvoker.cb_dcssdkStartScanForTopologyChanges;
    }

    private static IntPtr n_DcssdkStartScanForTopologyChanges(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStartScanForTopologyChanges());
    }

    public DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForTopologyChanges()
    {
      if (this.id_dcssdkStartScanForTopologyChanges == IntPtr.Zero)
        this.id_dcssdkStartScanForTopologyChanges = JNIEnv.GetMethodID(this.class_ref, "dcssdkStartScanForTopologyChanges", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkStartScanForTopologyChanges), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStopScanningDevicesHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkStopScanningDevices == null)
        IDcsSdkApiInvoker.cb_dcssdkStopScanningDevices = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IDcsSdkApiInvoker.n_DcssdkStopScanningDevices));
      return IDcsSdkApiInvoker.cb_dcssdkStopScanningDevices;
    }

    private static IntPtr n_DcssdkStopScanningDevices(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStopScanningDevices());
    }

    public DCSSDKDefs.DCSSDK_RESULT? DcssdkStopScanningDevices()
    {
      if (this.id_dcssdkStopScanningDevices == IntPtr.Zero)
        this.id_dcssdkStopScanningDevices = JNIEnv.GetMethodID(this.class_ref, "dcssdkStopScanningDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkStopScanningDevices), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSubsribeForEvents_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkSubsribeForEvents_I == null)
        IDcsSdkApiInvoker.cb_dcssdkSubsribeForEvents_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(IDcsSdkApiInvoker.n_DcssdkSubsribeForEvents_I));
      return IDcsSdkApiInvoker.cb_dcssdkSubsribeForEvents_I;
    }

    private static IntPtr n_DcssdkSubsribeForEvents_I(IntPtr jnienv, IntPtr native__this, int p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSubsribeForEvents(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSubsribeForEvents(int p0)
    {
      if (this.id_dcssdkSubsribeForEvents_I == IntPtr.Zero)
        this.id_dcssdkSubsribeForEvents_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkSubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkSubsribeForEvents_I, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkTerminateCommunicationSession_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkTerminateCommunicationSession_I == null)
        IDcsSdkApiInvoker.cb_dcssdkTerminateCommunicationSession_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(IDcsSdkApiInvoker.n_DcssdkTerminateCommunicationSession_I));
      return IDcsSdkApiInvoker.cb_dcssdkTerminateCommunicationSession_I;
    }

    private static IntPtr n_DcssdkTerminateCommunicationSession_I(
      IntPtr jnienv,
      IntPtr native__this,
      int p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkTerminateCommunicationSession(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkTerminateCommunicationSession(int p0)
    {
      if (this.id_dcssdkTerminateCommunicationSession_I == IntPtr.Zero)
        this.id_dcssdkTerminateCommunicationSession_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkTerminateCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkTerminateCommunicationSession_I, jvaluePtr), (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkUnsubsribeForEvents_IHandler()
    {
      if ((object) IDcsSdkApiInvoker.cb_dcssdkUnsubsribeForEvents_I == null)
        IDcsSdkApiInvoker.cb_dcssdkUnsubsribeForEvents_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(IDcsSdkApiInvoker.n_DcssdkUnsubsribeForEvents_I));
      return IDcsSdkApiInvoker.cb_dcssdkUnsubsribeForEvents_I;
    }

    private static IntPtr n_DcssdkUnsubsribeForEvents_I(IntPtr jnienv, IntPtr native__this, int p0)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IDcsSdkApi>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkUnsubsribeForEvents(p0));
    }

    public unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkUnsubsribeForEvents(int p0)
    {
      if (this.id_dcssdkUnsubsribeForEvents_I == IntPtr.Zero)
        this.id_dcssdkUnsubsribeForEvents_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkUnsubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(JNIEnv.CallObjectMethod(this.Handle, this.id_dcssdkUnsubsribeForEvents_I, jvaluePtr), (JniHandleOwnership) 1);
    }
  }
}
