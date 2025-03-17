// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.SDKHandler
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
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
  [Register("com/zebra/scannercontrol/SDKHandler", DoNotGenerateAcw = true)]
  public class SDKHandler : Object, IDcsSdkApi, IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("BLUETOOTH_MAC_ADDRESS_CHARACTER_COUNT")]
    public const int BluetoothMacAddressCharacterCount = 12;
    [Register("MAC_ADDRESS_FORMATTING_REGULAR_EXPRESSION")]
    public const string MacAddressFormattingRegularExpression = "..(?!$)";
    [Register("REPLACEMENT_DELIMITER")]
    public const string ReplacementDelimiter = "$0:";
    [Register("sleepDuration")]
    public const int SleepDuration = 1000;
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/SDKHandler", typeof (SDKHandler));
    private static Delegate? cb_dcssdkClearBTAddress;
    private static Delegate? cb_dcssdkClose;
    private static Delegate? cb_dcssdkEnableAutomaticSessionReestablishment_ZI;
    private static Delegate? cb_dcssdkEnableAvailableScannersDetection_Z;
    private static Delegate? cb_dcssdkEnableBluetoothScannersDiscovery_Z;
    private static Delegate? cb_dcssdkEstablishCommunicationSession_I;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_;
    private static Delegate? cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private static Delegate? cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    private static Delegate? cb_dcssdkGetActiveScannersList;
    private static Delegate? cb_dcssdkGetActiveScannersList_Ljava_util_List_;
    private static Delegate? cb_dcssdkGetAvailableScannersList;
    private static Delegate? cb_dcssdkGetAvailableScannersList_Ljava_util_List_;
    private static Delegate? cb_dcssdkGetIDCConfig;
    private static Delegate? cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_;
    private static Delegate? cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_;
    private static Delegate? cb_dcssdkGetUSBSNAPIWithImagingBarcode;
    private static Delegate? cb_dcssdkGetVersion;
    private static Delegate? cb_dcssdkSetBTAddress_Ljava_lang_String_;
    private static Delegate? cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_;
    private static Delegate? cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_;
    private static Delegate? cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_;
    private static Delegate? cb_dcssdkSetSTCEnabledState_Z;
    private static Delegate? cb_dcssdkStartScanForAvailableDevices;
    private static Delegate? cb_dcssdkStartScanForTopologyChanges;
    private static Delegate? cb_dcssdkStopScanningDevices;
    private static Delegate? cb_dcssdkSubsribeForEvents_I;
    private static Delegate? cb_dcssdkTerminateCommunicationSession_I;
    private static Delegate? cb_dcssdkUnsubsribeForEvents_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SDKHandler._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SDKHandler._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SDKHandler._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SDKHandler._members.ManagedPeerType;

    protected SDKHandler(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Landroid/content/Context;)V", "")]
    public unsafe SDKHandler(Context? context)
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
        JniObjectReference instance = SDKHandler._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        SDKHandler._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
      }
    }

    [Register(".ctor", "(Landroid/content/Context;Z)V", "")]
    public unsafe SDKHandler(Context? context, bool enableSTCEnabledState)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(enableSTCEnabledState)
        };
        JniObjectReference instance = SDKHandler._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Z)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        SDKHandler._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
      }
    }

    private static Delegate GetDcssdkClearBTAddressHandler()
    {
      if ((object) SDKHandler.cb_dcssdkClearBTAddress == null)
        SDKHandler.cb_dcssdkClearBTAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkClearBTAddress));
      return SDKHandler.cb_dcssdkClearBTAddress;
    }

    private static IntPtr n_DcssdkClearBTAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkClearBTAddress());
    }

    [Register("dcssdkClearBTAddress", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkClearBTAddressHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkClearBTAddress()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkClearBTAddress.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkCloseHandler()
    {
      if ((object) SDKHandler.cb_dcssdkClose == null)
        SDKHandler.cb_dcssdkClose = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkClose));
      return SDKHandler.cb_dcssdkClose;
    }

    private static IntPtr n_DcssdkClose(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkClose());
    }

    [Register("dcssdkClose", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkCloseHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkClose()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkClose.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableAutomaticSessionReestablishment_ZIHandler()
    {
      if ((object) SDKHandler.cb_dcssdkEnableAutomaticSessionReestablishment_ZI == null)
        SDKHandler.cb_dcssdkEnableAutomaticSessionReestablishment_ZI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZI_L(SDKHandler.n_DcssdkEnableAutomaticSessionReestablishment_ZI));
      return SDKHandler.cb_dcssdkEnableAutomaticSessionReestablishment_ZI;
    }

    private static IntPtr n_DcssdkEnableAutomaticSessionReestablishment_ZI(
      IntPtr jnienv,
      IntPtr native__this,
      bool enable,
      int fromScannerID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableAutomaticSessionReestablishment(enable, fromScannerID));
    }

    [Register("dcssdkEnableAutomaticSessionReestablishment", "(ZI)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableAutomaticSessionReestablishment_ZIHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAutomaticSessionReestablishment(
      bool enable,
      int fromScannerID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
      {
        new JniArgumentValue(enable),
        new JniArgumentValue(fromScannerID)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkEnableAutomaticSessionReestablishment.(ZI)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableAvailableScannersDetection_ZHandler()
    {
      if ((object) SDKHandler.cb_dcssdkEnableAvailableScannersDetection_Z == null)
        SDKHandler.cb_dcssdkEnableAvailableScannersDetection_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(SDKHandler.n_DcssdkEnableAvailableScannersDetection_Z));
      return SDKHandler.cb_dcssdkEnableAvailableScannersDetection_Z;
    }

    private static IntPtr n_DcssdkEnableAvailableScannersDetection_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enable)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableAvailableScannersDetection(enable));
    }

    [Register("dcssdkEnableAvailableScannersDetection", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableAvailableScannersDetection_ZHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAvailableScannersDetection(
      bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkEnableAvailableScannersDetection.(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEnableBluetoothScannersDiscovery_ZHandler()
    {
      if ((object) SDKHandler.cb_dcssdkEnableBluetoothScannersDiscovery_Z == null)
        SDKHandler.cb_dcssdkEnableBluetoothScannersDiscovery_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(SDKHandler.n_DcssdkEnableBluetoothScannersDiscovery_Z));
      return SDKHandler.cb_dcssdkEnableBluetoothScannersDiscovery_Z;
    }

    private static IntPtr n_DcssdkEnableBluetoothScannersDiscovery_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enable)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEnableBluetoothScannersDiscovery(enable));
    }

    [Register("dcssdkEnableBluetoothScannersDiscovery", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableBluetoothScannersDiscovery_ZHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableBluetoothScannersDiscovery(
      bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkEnableBluetoothScannersDiscovery.(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkEstablishCommunicationSession_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkEstablishCommunicationSession_I == null)
        SDKHandler.cb_dcssdkEstablishCommunicationSession_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(SDKHandler.n_DcssdkEstablishCommunicationSession_I));
      return SDKHandler.cb_dcssdkEstablishCommunicationSession_I;
    }

    private static IntPtr n_DcssdkEstablishCommunicationSession_I(
      IntPtr jnienv,
      IntPtr native__this,
      int scannerID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEstablishCommunicationSession(scannerID));
    }

    [Register("dcssdkEstablishCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEstablishCommunicationSession_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkEstablishCommunicationSession(
      int scannerID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(scannerID)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkEstablishCommunicationSession.(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ == null)
        SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(SDKHandler.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_));
      return SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_opCode,
      IntPtr native_inXML)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_opCode, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_inXML, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE opCode = dcssdkCommandOpcode;
      string inXML = str;
      return JNIEnv.NewString(sdkHandler.DcssdkExecuteCommandOpCodeInXMLForScanner(opCode, inXML));
    }

    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;)Ljava/lang/String;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Handler")]
    public virtual unsafe string? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? opCode,
      string? inXML)
    {
      IntPtr num = JNIEnv.NewString(inXML);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(opCode == null ? IntPtr.Zero : ((Object) opCode).Handle),
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkExecuteCommandOpCodeInXMLForScanner.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) opCode);
      }
    }

    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ == null)
        SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(SDKHandler.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_));
      return SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_;
    }

    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_opCode,
      IntPtr native_inXML,
      IntPtr native_outXML)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_opCode, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_inXML, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_outXML, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE opCode = dcssdkCommandOpcode;
      string inXML = str;
      StringBuilder outXML = stringBuilder;
      return JNIEnv.ToLocalJniHandle((IJavaObject) sdkHandler.DcssdkExecuteCommandOpCodeInXMLForScanner(opCode, inXML, outXML));
    }

    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? opCode,
      string? inXML,
      StringBuilder? outXML)
    {
      IntPtr num = JNIEnv.NewString(inXML);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(opCode == null ? IntPtr.Zero : ((Object) opCode).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(outXML == null ? IntPtr.Zero : ((Object) outXML).Handle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkExecuteCommandOpCodeInXMLForScanner.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) opCode);
        GC.KeepAlive((object) outXML);
      }
    }

    private static Delegate GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == null)
        SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLI_L(SDKHandler.n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I));
      return SDKHandler.cb_dcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    }

    private static IntPtr n_DcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_opCode,
      IntPtr native_inXML,
      IntPtr native_outXML,
      int scannerID)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_opCode, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_inXML, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_outXML, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE opCode = dcssdkCommandOpcode;
      string inXML = str;
      StringBuilder outXML = stringBuilder;
      int scannerID1 = scannerID;
      return JNIEnv.ToLocalJniHandle((IJavaObject) sdkHandler.DcssdkExecuteCommandOpCodeInXMLForScanner(opCode, inXML, outXML, scannerID1));
    }

    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? opCode,
      string? inXML,
      StringBuilder? outXML,
      int scannerID)
    {
      IntPtr num = JNIEnv.NewString(inXML);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(opCode == null ? IntPtr.Zero : ((Object) opCode).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(outXML == null ? IntPtr.Zero : ((Object) outXML).Handle),
          new JniArgumentValue(scannerID)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkExecuteCommandOpCodeInXMLForScanner.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) opCode);
        GC.KeepAlive((object) outXML);
      }
    }

    private static Delegate GetDcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I == null)
        SDKHandler.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLLI_L(SDKHandler.n_DcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I));
      return SDKHandler.cb_dcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I;
    }

    private static IntPtr n_DcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_I(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_opCode,
      IntPtr native_inXML,
      IntPtr native_outXML,
      int scannerID)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE dcssdkCommandOpcode = Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(native_opCode, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_inXML, (JniHandleOwnership) 0);
      StringBuilder stringBuilder = Object.GetObject<StringBuilder>(native_outXML, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE opCode = dcssdkCommandOpcode;
      string inXML = str;
      StringBuilder outXML = stringBuilder;
      int scannerID1 = scannerID;
      return JNIEnv.ToLocalJniHandle((IJavaObject) sdkHandler.DcssdkExecuteSSICommandOpCodeInXMLForScanner(opCode, inXML, outXML, scannerID1));
    }

    [Register("dcssdkExecuteSSICommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteSSICommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? opCode,
      string? inXML,
      StringBuilder? outXML,
      int scannerID)
    {
      IntPtr num = JNIEnv.NewString(inXML);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(opCode == null ? IntPtr.Zero : ((Object) opCode).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(outXML == null ? IntPtr.Zero : ((Object) outXML).Handle),
          new JniArgumentValue(scannerID)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkExecuteSSICommandOpCodeInXMLForScanner.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) opCode);
        GC.KeepAlive((object) outXML);
      }
    }

    private static Delegate GetDcssdkGetActiveScannersListHandler()
    {
      if ((object) SDKHandler.cb_dcssdkGetActiveScannersList == null)
        SDKHandler.cb_dcssdkGetActiveScannersList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkGetActiveScannersList));
      return SDKHandler.cb_dcssdkGetActiveScannersList;
    }

    private static IntPtr n_DcssdkGetActiveScannersList(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<DCSScannerInfo>.ToLocalJniHandle(Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetActiveScannersList());
    }

    [Register("dcssdkGetActiveScannersList", "()Ljava/util/List;", "GetDcssdkGetActiveScannersListHandler")]
    public virtual unsafe IList<DCSScannerInfo>? DcssdkGetActiveScannersList()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetActiveScannersList.()Ljava/util/List;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JavaList<DCSScannerInfo>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetActiveScannersList_Ljava_util_List_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkGetActiveScannersList_Ljava_util_List_ == null)
        SDKHandler.cb_dcssdkGetActiveScannersList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkGetActiveScannersList_Ljava_util_List_));
      return SDKHandler.cb_dcssdkGetActiveScannersList_Ljava_util_List_;
    }

    private static IntPtr n_DcssdkGetActiveScannersList_Ljava_util_List_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_activeScannersList)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetActiveScannersList(JavaList<DCSScannerInfo>.FromJniHandle(native_activeScannersList, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkGetActiveScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkGetActiveScannersList_Ljava_util_List_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkGetActiveScannersList(
      IList<DCSScannerInfo>? activeScannersList)
    {
      IntPtr localJniHandle = JavaList<DCSScannerInfo>.ToLocalJniHandle(activeScannersList);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(localJniHandle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetActiveScannersList.(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(localJniHandle);
        GC.KeepAlive((object) activeScannersList);
      }
    }

    private static Delegate GetDcssdkGetAvailableScannersListHandler()
    {
      if ((object) SDKHandler.cb_dcssdkGetAvailableScannersList == null)
        SDKHandler.cb_dcssdkGetAvailableScannersList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkGetAvailableScannersList));
      return SDKHandler.cb_dcssdkGetAvailableScannersList;
    }

    private static IntPtr n_DcssdkGetAvailableScannersList(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<DCSScannerInfo>.ToLocalJniHandle(Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetAvailableScannersList());
    }

    [Register("dcssdkGetAvailableScannersList", "()Ljava/util/List;", "GetDcssdkGetAvailableScannersListHandler")]
    public virtual unsafe IList<DCSScannerInfo>? DcssdkGetAvailableScannersList()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetAvailableScannersList.()Ljava/util/List;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JavaList<DCSScannerInfo>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetAvailableScannersList_Ljava_util_List_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkGetAvailableScannersList_Ljava_util_List_ == null)
        SDKHandler.cb_dcssdkGetAvailableScannersList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkGetAvailableScannersList_Ljava_util_List_));
      return SDKHandler.cb_dcssdkGetAvailableScannersList_Ljava_util_List_;
    }

    private static IntPtr n_DcssdkGetAvailableScannersList_Ljava_util_List_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_availableScannersList)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetAvailableScannersList(JavaList<DCSScannerInfo>.FromJniHandle(native_availableScannersList, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkGetAvailableScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkGetAvailableScannersList_Ljava_util_List_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkGetAvailableScannersList(
      IList<DCSScannerInfo>? availableScannersList)
    {
      IntPtr localJniHandle = JavaList<DCSScannerInfo>.ToLocalJniHandle(availableScannersList);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(localJniHandle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetAvailableScannersList.(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(localJniHandle);
        GC.KeepAlive((object) availableScannersList);
      }
    }

    private static Delegate GetDcssdkGetIDCConfigHandler()
    {
      if ((object) SDKHandler.cb_dcssdkGetIDCConfig == null)
        SDKHandler.cb_dcssdkGetIDCConfig = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkGetIDCConfig));
      return SDKHandler.cb_dcssdkGetIDCConfig;
    }

    private static IntPtr n_DcssdkGetIDCConfig(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetIDCConfig());
    }

    [Register("dcssdkGetIDCConfig", "()Lcom/zebra/scannercontrol/IDCConfig;", "GetDcssdkGetIDCConfigHandler")]
    public virtual unsafe IDCConfig? DcssdkGetIDCConfig()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetIDCConfig.()Lcom/zebra/scannercontrol/IDCConfig;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<IDCConfig>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ == null)
        SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_L(SDKHandler.n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_));
      return SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_;
    }

    private static IntPtr n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_bluetoothProtocol,
      IntPtr native_defaultOption)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL dcssdkBtProtocol = Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(native_bluetoothProtocol, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG dcssdkBtScannerConfig = Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(native_defaultOption, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL bluetoothProtocol = dcssdkBtProtocol;
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG defaultOption = dcssdkBtScannerConfig;
      return JNIEnv.ToLocalJniHandle((IJavaObject) sdkHandler.DcssdkGetPairingBarcode(bluetoothProtocol, defaultOption));
    }

    [Register("dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;)Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Handler")]
    public virtual unsafe BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? bluetoothProtocol,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? defaultOption)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(bluetoothProtocol == null ? IntPtr.Zero : ((Object) bluetoothProtocol).Handle),
          new JniArgumentValue(defaultOption == null ? IntPtr.Zero : ((Object) defaultOption).Handle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetPairingBarcode.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;)Lcom/zebra/scannercontrol/BarCodeView;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<BarCodeView>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) bluetoothProtocol);
        GC.KeepAlive((object) defaultOption);
      }
    }

    private static Delegate GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ == null)
        SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_L(SDKHandler.n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_));
      return SDKHandler.cb_dcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_bluetoothProtocol,
      IntPtr native_defaultOption,
      IntPtr native_bluetoothMAC)
    {
      SDKHandler sdkHandler = Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL dcssdkBtProtocol = Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(native_bluetoothProtocol, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG dcssdkBtScannerConfig = Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(native_defaultOption, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_bluetoothMAC, (JniHandleOwnership) 0);
      DCSSDKDefs.DCSSDK_BT_PROTOCOL bluetoothProtocol = dcssdkBtProtocol;
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG defaultOption = dcssdkBtScannerConfig;
      string bluetoothMAC = str;
      return JNIEnv.ToLocalJniHandle((IJavaObject) sdkHandler.DcssdkGetPairingBarcode(bluetoothProtocol, defaultOption, bluetoothMAC));
    }

    [Register("dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;Ljava/lang/String;)Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_Handler")]
    public virtual unsafe BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? bluetoothProtocol,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? defaultOption,
      string? bluetoothMAC)
    {
      IntPtr num = JNIEnv.NewString(bluetoothMAC);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(bluetoothProtocol == null ? IntPtr.Zero : ((Object) bluetoothProtocol).Handle),
          new JniArgumentValue(defaultOption == null ? IntPtr.Zero : ((Object) defaultOption).Handle),
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetPairingBarcode.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;Ljava/lang/String;)Lcom/zebra/scannercontrol/BarCodeView;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<BarCodeView>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) bluetoothProtocol);
        GC.KeepAlive((object) defaultOption);
      }
    }

    private static Delegate GetDcssdkGetUSBSNAPIWithImagingBarcodeHandler()
    {
      if ((object) SDKHandler.cb_dcssdkGetUSBSNAPIWithImagingBarcode == null)
        SDKHandler.cb_dcssdkGetUSBSNAPIWithImagingBarcode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkGetUSBSNAPIWithImagingBarcode));
      return SDKHandler.cb_dcssdkGetUSBSNAPIWithImagingBarcode;
    }

    private static IntPtr n_DcssdkGetUSBSNAPIWithImagingBarcode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetUSBSNAPIWithImagingBarcode());
    }

    [Register("dcssdkGetUSBSNAPIWithImagingBarcode", "()Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetUSBSNAPIWithImagingBarcodeHandler")]
    public virtual unsafe BarCodeView? DcssdkGetUSBSNAPIWithImagingBarcode()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetUSBSNAPIWithImagingBarcode.()Lcom/zebra/scannercontrol/BarCodeView;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<BarCodeView>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkGetVersionHandler()
    {
      if ((object) SDKHandler.cb_dcssdkGetVersion == null)
        SDKHandler.cb_dcssdkGetVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkGetVersion));
      return SDKHandler.cb_dcssdkGetVersion;
    }

    private static IntPtr n_DcssdkGetVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkGetVersion());
    }

    [Register("dcssdkGetVersion", "()Ljava/lang/String;", "GetDcssdkGetVersionHandler")]
    public virtual unsafe string? DcssdkGetVersion()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkGetVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSetBTAddress_Ljava_lang_String_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkSetBTAddress_Ljava_lang_String_ == null)
        SDKHandler.cb_dcssdkSetBTAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkSetBTAddress_Ljava_lang_String_));
      return SDKHandler.cb_dcssdkSetBTAddress_Ljava_lang_String_;
    }

    private static IntPtr n_DcssdkSetBTAddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_bluetoothMAC)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetBTAddress(JNIEnv.GetString(native_bluetoothMAC, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkSetBTAddress", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetBTAddress_Ljava_lang_String_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetBTAddress(string? bluetoothMAC)
    {
      IntPtr num = JNIEnv.NewString(bluetoothMAC);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSetBTAddress.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetDcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ == null)
        SDKHandler.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_));
      return SDKHandler.cb_dcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_;
    }

    private static IntPtr n_DcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native__delegate)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetDelegate(Object.GetObject<IDcsSdkApiDelegate>(native__delegate, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkSetDelegate", "(Lcom/zebra/scannercontrol/IDcsSdkApiDelegate;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetDelegate(IDcsSdkApiDelegate? @delegate)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(@delegate == null ? IntPtr.Zero : ((Object) @delegate).Handle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSetDelegate.(Lcom/zebra/scannercontrol/IDcsSdkApiDelegate;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) @delegate);
      }
    }

    private static Delegate GetDcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ == null)
        SDKHandler.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_));
      return SDKHandler.cb_dcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_;
    }

    private static IntPtr n_DcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_idcConfig)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetIDCConfig(Object.GetObject<IDCConfig>(native_idcConfig, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkSetIDCConfig", "(Lcom/zebra/scannercontrol/IDCConfig;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetIDCConfig(IDCConfig? idcConfig)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(idcConfig == null ? IntPtr.Zero : idcConfig.Handle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSetIDCConfig.(Lcom/zebra/scannercontrol/IDCConfig;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) idcConfig);
      }
    }

    private static Delegate GetDcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_Handler()
    {
      if ((object) SDKHandler.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ == null)
        SDKHandler.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(SDKHandler.n_DcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_));
      return SDKHandler.cb_dcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_;
    }

    private static IntPtr n_DcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_operationalMode)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetOperationalMode(Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(native_operationalMode, (JniHandleOwnership) 0)));
    }

    [Register("dcssdkSetOperationalMode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_Handler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetOperationalMode(
      DCSSDKDefs.DCSSDK_MODE? operationalMode)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(operationalMode == null ? IntPtr.Zero : ((Object) operationalMode).Handle)
        };
        JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSetOperationalMode.(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) operationalMode);
      }
    }

    private static Delegate GetDcssdkSetSTCEnabledState_ZHandler()
    {
      if ((object) SDKHandler.cb_dcssdkSetSTCEnabledState_Z == null)
        SDKHandler.cb_dcssdkSetSTCEnabledState_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_L(SDKHandler.n_DcssdkSetSTCEnabledState_Z));
      return SDKHandler.cb_dcssdkSetSTCEnabledState_Z;
    }

    private static IntPtr n_DcssdkSetSTCEnabledState_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enable)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSetSTCEnabledState(enable));
    }

    [Register("dcssdkSetSTCEnabledState", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetSTCEnabledState_ZHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSetSTCEnabledState(bool enable)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enable)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSetSTCEnabledState.(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStartScanForAvailableDevicesHandler()
    {
      if ((object) SDKHandler.cb_dcssdkStartScanForAvailableDevices == null)
        SDKHandler.cb_dcssdkStartScanForAvailableDevices = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkStartScanForAvailableDevices));
      return SDKHandler.cb_dcssdkStartScanForAvailableDevices;
    }

    private static IntPtr n_DcssdkStartScanForAvailableDevices(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStartScanForAvailableDevices());
    }

    [Register("dcssdkStartScanForAvailableDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStartScanForAvailableDevicesHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForAvailableDevices()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkStartScanForAvailableDevices.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStartScanForTopologyChangesHandler()
    {
      if ((object) SDKHandler.cb_dcssdkStartScanForTopologyChanges == null)
        SDKHandler.cb_dcssdkStartScanForTopologyChanges = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkStartScanForTopologyChanges));
      return SDKHandler.cb_dcssdkStartScanForTopologyChanges;
    }

    private static IntPtr n_DcssdkStartScanForTopologyChanges(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStartScanForTopologyChanges());
    }

    [Register("dcssdkStartScanForTopologyChanges", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStartScanForTopologyChangesHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForTopologyChanges()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkStartScanForTopologyChanges.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkStopScanningDevicesHandler()
    {
      if ((object) SDKHandler.cb_dcssdkStopScanningDevices == null)
        SDKHandler.cb_dcssdkStopScanningDevices = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SDKHandler.n_DcssdkStopScanningDevices));
      return SDKHandler.cb_dcssdkStopScanningDevices;
    }

    private static IntPtr n_DcssdkStopScanningDevices(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkStopScanningDevices());
    }

    [Register("dcssdkStopScanningDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStopScanningDevicesHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkStopScanningDevices()
    {
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkStopScanningDevices.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkSubsribeForEvents_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkSubsribeForEvents_I == null)
        SDKHandler.cb_dcssdkSubsribeForEvents_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(SDKHandler.n_DcssdkSubsribeForEvents_I));
      return SDKHandler.cb_dcssdkSubsribeForEvents_I;
    }

    private static IntPtr n_DcssdkSubsribeForEvents_I(
      IntPtr jnienv,
      IntPtr native__this,
      int sdkEventsMask)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkSubsribeForEvents(sdkEventsMask));
    }

    [Register("dcssdkSubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSubsribeForEvents_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkSubsribeForEvents(int sdkEventsMask)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(sdkEventsMask)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkSubsribeForEvents.(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkTerminateCommunicationSession_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkTerminateCommunicationSession_I == null)
        SDKHandler.cb_dcssdkTerminateCommunicationSession_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(SDKHandler.n_DcssdkTerminateCommunicationSession_I));
      return SDKHandler.cb_dcssdkTerminateCommunicationSession_I;
    }

    private static IntPtr n_DcssdkTerminateCommunicationSession_I(
      IntPtr jnienv,
      IntPtr native__this,
      int scannerID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkTerminateCommunicationSession(scannerID));
    }

    [Register("dcssdkTerminateCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkTerminateCommunicationSession_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkTerminateCommunicationSession(
      int scannerID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(scannerID)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkTerminateCommunicationSession.(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDcssdkUnsubsribeForEvents_IHandler()
    {
      if ((object) SDKHandler.cb_dcssdkUnsubsribeForEvents_I == null)
        SDKHandler.cb_dcssdkUnsubsribeForEvents_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(SDKHandler.n_DcssdkUnsubsribeForEvents_I));
      return SDKHandler.cb_dcssdkUnsubsribeForEvents_I;
    }

    private static IntPtr n_DcssdkUnsubsribeForEvents_I(
      IntPtr jnienv,
      IntPtr native__this,
      int sdkEventsMask)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SDKHandler>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkUnsubsribeForEvents(sdkEventsMask));
    }

    [Register("dcssdkUnsubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkUnsubsribeForEvents_IHandler")]
    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? DcssdkUnsubsribeForEvents(int sdkEventsMask)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(sdkEventsMask)
      };
      JniObjectReference jniObjectReference = SDKHandler._members.InstanceMethods.InvokeVirtualObjectMethod("dcssdkUnsubsribeForEvents.(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
