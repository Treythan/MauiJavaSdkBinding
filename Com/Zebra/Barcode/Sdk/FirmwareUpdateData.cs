// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.FirmwareUpdateData
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
  [Register("com/zebra/barcode/sdk/FirmwareUpdateData", DoNotGenerateAcw = true)]
  public class FirmwareUpdateData : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/FirmwareUpdateData", typeof (FirmwareUpdateData));
    private static Delegate? cb_getCurrentRecord;
    private static Delegate? cb_getEventType;
    private static Delegate? cb_getMaxRecords;
    private static Delegate? cb_getSoftwareComponent;
    private static Delegate? cb_getStatus;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FirmwareUpdateData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FirmwareUpdateData._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FirmwareUpdateData._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FirmwareUpdateData._members.ManagedPeerType;

    protected FirmwareUpdateData(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetCurrentRecordHandler()
    {
      if ((object) FirmwareUpdateData.cb_getCurrentRecord == null)
        FirmwareUpdateData.cb_getCurrentRecord = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateData.n_GetCurrentRecord));
      return FirmwareUpdateData.cb_getCurrentRecord;
    }

    private static int n_GetCurrentRecord(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateData>(jnienv, native__this, (JniHandleOwnership) 0).CurrentRecord;
    }

    public virtual unsafe int CurrentRecord
    {
      [Register("getCurrentRecord", "()I", "GetGetCurrentRecordHandler")] get
      {
        return FirmwareUpdateData._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentRecord.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetEventTypeHandler()
    {
      if ((object) FirmwareUpdateData.cb_getEventType == null)
        FirmwareUpdateData.cb_getEventType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FirmwareUpdateData.n_GetEventType));
      return FirmwareUpdateData.cb_getEventType;
    }

    private static IntPtr n_GetEventType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FirmwareUpdateData>(jnienv, native__this, (JniHandleOwnership) 0).EventType);
    }

    public virtual unsafe FirmwareUpdateData.FirmwareUpdateEventType? EventType
    {
      [Register("getEventType", "()Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", "GetGetEventTypeHandler")] get
      {
        JniObjectReference jniObjectReference = FirmwareUpdateData._members.InstanceMethods.InvokeVirtualObjectMethod("getEventType.()Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetMaxRecordsHandler()
    {
      if ((object) FirmwareUpdateData.cb_getMaxRecords == null)
        FirmwareUpdateData.cb_getMaxRecords = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateData.n_GetMaxRecords));
      return FirmwareUpdateData.cb_getMaxRecords;
    }

    private static int n_GetMaxRecords(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateData>(jnienv, native__this, (JniHandleOwnership) 0).MaxRecords;
    }

    public virtual unsafe int MaxRecords
    {
      [Register("getMaxRecords", "()I", "GetGetMaxRecordsHandler")] get
      {
        return FirmwareUpdateData._members.InstanceMethods.InvokeVirtualInt32Method("getMaxRecords.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetSoftwareComponentHandler()
    {
      if ((object) FirmwareUpdateData.cb_getSoftwareComponent == null)
        FirmwareUpdateData.cb_getSoftwareComponent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FirmwareUpdateData.n_GetSoftwareComponent));
      return FirmwareUpdateData.cb_getSoftwareComponent;
    }

    private static int n_GetSoftwareComponent(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FirmwareUpdateData>(jnienv, native__this, (JniHandleOwnership) 0).SoftwareComponent;
    }

    public virtual unsafe int SoftwareComponent
    {
      [Register("getSoftwareComponent", "()I", "GetGetSoftwareComponentHandler")] get
      {
        return FirmwareUpdateData._members.InstanceMethods.InvokeVirtualInt32Method("getSoftwareComponent.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) FirmwareUpdateData.cb_getStatus == null)
        FirmwareUpdateData.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FirmwareUpdateData.n_GetStatus));
      return FirmwareUpdateData.cb_getStatus;
    }

    private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FirmwareUpdateData>(jnienv, native__this, (JniHandleOwnership) 0).GetStatus());
    }

    [Register("getStatus", "()Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", "GetGetStatusHandler")]
    public virtual unsafe FirmwareUpdateData.Status? GetStatus()
    {
      JniObjectReference jniObjectReference = FirmwareUpdateData._members.InstanceMethods.InvokeVirtualObjectMethod("getStatus.()Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("com/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType", DoNotGenerateAcw = true)]
    public sealed class FirmwareUpdateEventType : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType", typeof (FirmwareUpdateData.FirmwareUpdateEventType));

      [Register("Dl_END")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? DlEND
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("Dl_END.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DL_PROGRESS")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? DlProgress
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("DL_PROGRESS.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("Dl_START")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? DlSTART
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("Dl_START.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("ERROR")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? Error
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("ERROR.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SESSION_END")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? SessionEnd
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("SESSION_END.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SESSION_START")]
      public static FirmwareUpdateData.FirmwareUpdateEventType? SessionStart
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticFields.GetObjectValue("SESSION_START.Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;");
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return FirmwareUpdateData.FirmwareUpdateEventType._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          FirmwareUpdateData.FirmwareUpdateEventType._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = FirmwareUpdateData.FirmwareUpdateEventType._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => FirmwareUpdateData.FirmwareUpdateEventType._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = FirmwareUpdateData.FirmwareUpdateEventType._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => FirmwareUpdateData.FirmwareUpdateEventType._members.ManagedPeerType;
      }

      internal FirmwareUpdateEventType(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", "")]
      public static unsafe FirmwareUpdateData.FirmwareUpdateEventType? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", jniArgumentValuePtr);
          return Object.GetObject<FirmwareUpdateData.FirmwareUpdateEventType>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", "")]
      public static unsafe FirmwareUpdateData.FirmwareUpdateEventType[]? Values()
      {
        JniObjectReference jniObjectReference = FirmwareUpdateData.FirmwareUpdateEventType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/barcode/sdk/FirmwareUpdateData$FirmwareUpdateEventType;", (JniArgumentValue*) null);
        return (FirmwareUpdateData.FirmwareUpdateEventType[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (FirmwareUpdateData.FirmwareUpdateEventType));
      }
    }

    [Register("com/zebra/barcode/sdk/FirmwareUpdateData$Status", DoNotGenerateAcw = true)]
    public sealed class Status : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/FirmwareUpdateData$Status", typeof (FirmwareUpdateData.Status));

      [Register("FAILURE")]
      public static FirmwareUpdateData.Status? Failure
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FAILURE.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_ABORTED")]
      public static FirmwareUpdateData.Status? FirmwareUpdateAborted
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_ABORTED.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_FAILED_COMMANDS_ARE_OUT_OF_SYNC")]
      public static FirmwareUpdateData.Status? FirmwareUpdateFailedCommandsAreOutOfSync
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_FAILED_COMMANDS_ARE_OUT_OF_SYNC.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_FAILED_HAS_OVERLAPPING_ADDRESS")]
      public static FirmwareUpdateData.Status? FirmwareUpdateFailedHasOverlappingAddress
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_FAILED_HAS_OVERLAPPING_ADDRESS.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_FAILED_LOAD_COUNT_ERROR")]
      public static FirmwareUpdateData.Status? FirmwareUpdateFailedLoadCountError
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_FAILED_LOAD_COUNT_ERROR.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_FAILED_LOW_BATTERY_LEVEL")]
      public static FirmwareUpdateData.Status? FirmwareUpdateFailedLowBatteryLevel
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_FAILED_LOW_BATTERY_LEVEL.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("FIRMWARE_UPDATE_IN_PROGRESS")]
      public static FirmwareUpdateData.Status? FirmwareUpdateInProgress
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("FIRMWARE_UPDATE_IN_PROGRESS.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("INVALID_PARAMETER")]
      public static FirmwareUpdateData.Status? InvalidParameter
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("INVALID_PARAMETER.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("OPCODE_NOT_SUPPORTED")]
      public static FirmwareUpdateData.Status? OpcodeNotSupported
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("OPCODE_NOT_SUPPORTED.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("RESPONSE_TIME_OUT")]
      public static FirmwareUpdateData.Status? ResponseTimeOut
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("RESPONSE_TIME_OUT.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCALE_NOT_PRESENTED")]
      public static FirmwareUpdateData.Status? ScaleNotPresented
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("SCALE_NOT_PRESENTED.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_ALREADY_ACTIVE")]
      public static FirmwareUpdateData.Status? ScannerAlreadyActive
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("SCANNER_ALREADY_ACTIVE.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_NOT_ACTIVE")]
      public static FirmwareUpdateData.Status? ScannerNotActive
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("SCANNER_NOT_ACTIVE.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_NOT_AVAILABLE")]
      public static FirmwareUpdateData.Status? ScannerNotAvailable
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("SCANNER_NOT_AVAILABLE.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SUCCESS")]
      public static FirmwareUpdateData.Status? Success
      {
        get
        {
          JniObjectReference objectValue = FirmwareUpdateData.Status._members.StaticFields.GetObjectValue("SUCCESS.Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;");
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return FirmwareUpdateData.Status._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          FirmwareUpdateData.Status._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = FirmwareUpdateData.Status._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => FirmwareUpdateData.Status._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = FirmwareUpdateData.Status._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => FirmwareUpdateData.Status._members.ManagedPeerType;

      internal Status(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", "")]
      public static unsafe FirmwareUpdateData.Status? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = FirmwareUpdateData.Status._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", jniArgumentValuePtr);
          return Object.GetObject<FirmwareUpdateData.Status>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", "")]
      public static unsafe FirmwareUpdateData.Status[]? Values()
      {
        JniObjectReference jniObjectReference = FirmwareUpdateData.Status._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/barcode/sdk/FirmwareUpdateData$Status;", (JniArgumentValue*) null);
        return (FirmwareUpdateData.Status[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (FirmwareUpdateData.Status));
      }
    }
  }
}
