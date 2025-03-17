// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.FirmwareUpdateEvent
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/FirmwareUpdateEvent", DoNotGenerateAcw = true)]
  public class FirmwareUpdateEvent : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/FirmwareUpdateEvent", typeof (FirmwareUpdateEvent));
    private static Delegate? cb_getCurrentRecord;
    private static Delegate? cb_getEventType;
    private static Delegate? cb_getMaxRecords;
    private static Delegate? cb_getScannerInfo;
    private static Delegate? cb_getStatus;
    private static Delegate? cb_getSwComponent;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FirmwareUpdateEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FirmwareUpdateEvent._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FirmwareUpdateEvent._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FirmwareUpdateEvent._members.ManagedPeerType;

    protected FirmwareUpdateEvent(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetCurrentRecordHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getCurrentRecord == null)
        FirmwareUpdateEvent.cb_getCurrentRecord = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateEvent.n_GetCurrentRecord));
      return FirmwareUpdateEvent.cb_getCurrentRecord;
    }

    private static int n_GetCurrentRecord(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).CurrentRecord;
    }

    public virtual unsafe int CurrentRecord
    {
      [Register("getCurrentRecord", "()I", "GetGetCurrentRecordHandler")] get
      {
        return FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentRecord.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetEventTypeHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getEventType == null)
        FirmwareUpdateEvent.cb_getEventType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FirmwareUpdateEvent.n_GetEventType));
      return FirmwareUpdateEvent.cb_getEventType;
    }

    private static IntPtr n_GetEventType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).EventType);
    }

    public virtual unsafe DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? EventType
    {
      [Register("getEventType", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", "GetGetEventTypeHandler")] get
      {
        JniObjectReference jniObjectReference = FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getEventType.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetMaxRecordsHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getMaxRecords == null)
        FirmwareUpdateEvent.cb_getMaxRecords = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateEvent.n_GetMaxRecords));
      return FirmwareUpdateEvent.cb_getMaxRecords;
    }

    private static int n_GetMaxRecords(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).MaxRecords;
    }

    public virtual unsafe int MaxRecords
    {
      [Register("getMaxRecords", "()I", "GetGetMaxRecordsHandler")] get
      {
        return FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualInt32Method("getMaxRecords.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetScannerInfoHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getScannerInfo == null)
        FirmwareUpdateEvent.cb_getScannerInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FirmwareUpdateEvent.n_GetScannerInfo));
      return FirmwareUpdateEvent.cb_getScannerInfo;
    }

    private static IntPtr n_GetScannerInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).ScannerInfo);
    }

    public virtual unsafe DCSScannerInfo? ScannerInfo
    {
      [Register("getScannerInfo", "()Lcom/zebra/scannercontrol/DCSScannerInfo;", "GetGetScannerInfoHandler")] get
      {
        JniObjectReference jniObjectReference = FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerInfo.()Lcom/zebra/scannercontrol/DCSScannerInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DCSScannerInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getStatus == null)
        FirmwareUpdateEvent.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FirmwareUpdateEvent.n_GetStatus));
      return FirmwareUpdateEvent.cb_getStatus;
    }

    private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).Status);
    }

    public virtual unsafe DCSSDKDefs.DCSSDK_RESULT? Status
    {
      [Register("getStatus", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "GetGetStatusHandler")] get
      {
        JniObjectReference jniObjectReference = FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getStatus.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSwComponentHandler()
    {
      if ((object) FirmwareUpdateEvent.cb_getSwComponent == null)
        FirmwareUpdateEvent.cb_getSwComponent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateEvent.n_GetSwComponent));
      return FirmwareUpdateEvent.cb_getSwComponent;
    }

    private static int n_GetSwComponent(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).SwComponent;
    }

    public virtual unsafe int SwComponent
    {
      [Register("getSwComponent", "()I", "GetGetSwComponentHandler")] get
      {
        return FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualInt32Method("getSwComponent.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
