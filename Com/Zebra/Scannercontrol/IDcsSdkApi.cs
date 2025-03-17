// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.IDcsSdkApi
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/IDcsSdkApi", "", "Com.Zebra.Scannercontrol.IDcsSdkApiInvoker")]
  public interface IDcsSdkApi : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("dcssdkClearBTAddress", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkClearBTAddressHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkClearBTAddress();

    [Register("dcssdkClose", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkCloseHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkClose();

    [Register("dcssdkEnableAutomaticSessionReestablishment", "(ZI)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableAutomaticSessionReestablishment_ZIHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAutomaticSessionReestablishment(bool p0, int p1);

    [Register("dcssdkEnableAvailableScannersDetection", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableAvailableScannersDetection_ZHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableAvailableScannersDetection(bool p0);

    [Register("dcssdkEnableBluetoothScannersDiscovery", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEnableBluetoothScannersDiscovery_ZHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkEnableBluetoothScannersDiscovery(bool p0);

    [Register("dcssdkEstablishCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkEstablishCommunicationSession_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkEstablishCommunicationSession(int p0);

    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;)Ljava/lang/String;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    string? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1);

    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2);

    [Obsolete("deprecated")]
    [Register("dcssdkExecuteCommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteCommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteCommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2,
      int p3);

    [Register("dcssdkExecuteSSICommandOpCodeInXMLForScanner", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;Ljava/lang/String;Ljava/lang/StringBuilder;I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkExecuteSSICommandOpCodeInXMLForScanner_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_COMMAND_OPCODE_Ljava_lang_String_Ljava_lang_StringBuilder_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkExecuteSSICommandOpCodeInXMLForScanner(
      DCSSDKDefs.DCSSDK_COMMAND_OPCODE? p0,
      string? p1,
      StringBuilder? p2,
      int p3);

    [Register("dcssdkGetActiveScannersList", "()Ljava/util/List;", "GetDcssdkGetActiveScannersListHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    IList<DCSScannerInfo>? DcssdkGetActiveScannersList();

    [Register("dcssdkGetActiveScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkGetActiveScannersList_Ljava_util_List_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkGetActiveScannersList(IList<DCSScannerInfo>? p0);

    [Register("dcssdkGetAvailableScannersList", "()Ljava/util/List;", "GetDcssdkGetAvailableScannersListHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    IList<DCSScannerInfo>? DcssdkGetAvailableScannersList();

    [Register("dcssdkGetAvailableScannersList", "(Ljava/util/List;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkGetAvailableScannersList_Ljava_util_List_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkGetAvailableScannersList(IList<DCSScannerInfo>? p0);

    [Register("dcssdkGetIDCConfig", "()Lcom/zebra/scannercontrol/IDCConfig;", "GetDcssdkGetIDCConfigHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    IDCConfig? DcssdkGetIDCConfig();

    [Register("dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;)Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? p0,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? p1);

    [Register("dcssdkGetPairingBarcode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;Ljava/lang/String;)Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetPairingBarcode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_PROTOCOL_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_BT_SCANNER_CONFIG_Ljava_lang_String_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    BarCodeView? DcssdkGetPairingBarcode(
      DCSSDKDefs.DCSSDK_BT_PROTOCOL? p0,
      DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? p1,
      string? p2);

    [Register("dcssdkGetUSBSNAPIWithImagingBarcode", "()Lcom/zebra/scannercontrol/BarCodeView;", "GetDcssdkGetUSBSNAPIWithImagingBarcodeHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    BarCodeView? DcssdkGetUSBSNAPIWithImagingBarcode();

    [Register("dcssdkGetVersion", "()Ljava/lang/String;", "GetDcssdkGetVersionHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    string? DcssdkGetVersion();

    [Register("dcssdkSetBTAddress", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetBTAddress_Ljava_lang_String_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSetBTAddress(string? p0);

    [Register("dcssdkSetDelegate", "(Lcom/zebra/scannercontrol/IDcsSdkApiDelegate;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetDelegate_Lcom_zebra_scannercontrol_IDcsSdkApiDelegate_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSetDelegate(IDcsSdkApiDelegate? p0);

    [Register("dcssdkSetIDCConfig", "(Lcom/zebra/scannercontrol/IDCConfig;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetIDCConfig_Lcom_zebra_scannercontrol_IDCConfig_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSetIDCConfig(IDCConfig? p0);

    [Register("dcssdkSetOperationalMode", "(Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetOperationalMode_Lcom_zebra_scannercontrol_DCSSDKDefs_DCSSDK_MODE_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSetOperationalMode(DCSSDKDefs.DCSSDK_MODE? p0);

    [Register("dcssdkSetSTCEnabledState", "(Z)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSetSTCEnabledState_ZHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSetSTCEnabledState(bool p0);

    [Register("dcssdkStartScanForAvailableDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStartScanForAvailableDevicesHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForAvailableDevices();

    [Register("dcssdkStartScanForTopologyChanges", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStartScanForTopologyChangesHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkStartScanForTopologyChanges();

    [Register("dcssdkStopScanningDevices", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkStopScanningDevicesHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkStopScanningDevices();

    [Register("dcssdkSubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkSubsribeForEvents_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkSubsribeForEvents(int p0);

    [Register("dcssdkTerminateCommunicationSession", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkTerminateCommunicationSession_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkTerminateCommunicationSession(int p0);

    [Register("dcssdkUnsubsribeForEvents", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetDcssdkUnsubsribeForEvents_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiInvoker, MauiJavaSdkBinding")]
    DCSSDKDefs.DCSSDK_RESULT? DcssdkUnsubsribeForEvents(int p0);
  }
}
