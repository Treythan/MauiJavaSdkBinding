// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.IDcsSdkApiDelegate
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/IDcsSdkApiDelegate", "", "Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker")]
  public interface IDcsSdkApiDelegate : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("dcssdkEventAuxScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "GetDcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventAuxScannerAppeared(DCSScannerInfo? p0, DCSScannerInfo? p1);

    [Register("dcssdkEventBarcode", "([BII)V", "GetDcssdkEventBarcode_arrayBIIHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventBarcode(byte[]? p0, int p1, int p2);

    [Register("dcssdkEventBinaryData", "([BI)V", "GetDcssdkEventBinaryData_arrayBIHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventBinaryData(byte[]? p0, int p1);

    [Register("dcssdkEventCommunicationSessionEstablished", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "GetDcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventCommunicationSessionEstablished(DCSScannerInfo? p0);

    [Register("dcssdkEventCommunicationSessionTerminated", "(I)V", "GetDcssdkEventCommunicationSessionTerminated_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventCommunicationSessionTerminated(int p0);

    [Register("dcssdkEventFirmwareUpdate", "(Lcom/zebra/scannercontrol/FirmwareUpdateEvent;)V", "GetDcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventFirmwareUpdate(FirmwareUpdateEvent? p0);

    [Register("dcssdkEventImage", "([BI)V", "GetDcssdkEventImage_arrayBIHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventImage(byte[]? p0, int p1);

    [Register("dcssdkEventScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V", "GetDcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventScannerAppeared(DCSScannerInfo? p0);

    [Register("dcssdkEventScannerDisappeared", "(I)V", "GetDcssdkEventScannerDisappeared_IHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventScannerDisappeared(int p0);

    [Register("dcssdkEventVideo", "([BI)V", "GetDcssdkEventVideo_arrayBIHandler:Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker, MauiJavaSdkBinding")]
    void DcssdkEventVideo(byte[]? p0, int p1);
  }
}
