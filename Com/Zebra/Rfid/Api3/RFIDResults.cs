// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFIDResults
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
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/RFIDResults", DoNotGenerateAcw = true)]
  public class RFIDResults : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDResults", typeof (RFIDResults));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get => RFIDResults._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => RFIDResults._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("RFID_ACCESS_DPO_ENABLED_ERROR")]
    public static RFIDResults? RfidAccessDpoEnabledError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_DPO_ENABLED_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_IMPINJ_QT_READ_FAILED")]
    public static RFIDResults? RfidAccessImpinjQtReadFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_IMPINJ_QT_READ_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_IMPINJ_QT_WRITE_FAILED")]
    public static RFIDResults? RfidAccessImpinjQtWriteFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_IMPINJ_QT_WRITE_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_INSUFFIFICENT_POWER")]
    public static RFIDResults? RfidAccessInsuffificentPower
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_INSUFFIFICENT_POWER.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_IN_PROGRESS")]
    public static RFIDResults? RfidAccessInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_NO_RESPONSE_FROM_TAG")]
    public static RFIDResults? RfidAccessNoResponseFromTag
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_NO_RESPONSE_FROM_TAG.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_NXP_CHANGE_CONFIG_FAILED")]
    public static RFIDResults? RfidAccessNxpChangeConfigFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_NXP_CHANGE_CONFIG_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_NXP_TAG_READ_PROTECT_FAILED")]
    public static RFIDResults? RfidAccessNxpTagReadProtectFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_NXP_TAG_READ_PROTECT_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_NXP_TAG_SET_EAS_FAILED")]
    public static RFIDResults? RfidAccessNxpTagSetEasFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_NXP_TAG_SET_EAS_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_READER_NON_SPECIFIC_ERROR")]
    public static RFIDResults? RfidAccessReaderNonSpecificError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_READER_NON_SPECIFIC_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_SEQUENCE_ADDITION_FAILED")]
    public static RFIDResults? RfidAccessSequenceAdditionFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_SEQUENCE_ADDITION_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_SEQUENCE_EMPTY")]
    public static RFIDResults? RfidAccessSequenceEmpty
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_SEQUENCE_EMPTY.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_SEQUENCE_IN_USE")]
    public static RFIDResults? RfidAccessSequenceInUse
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_SEQUENCE_IN_USE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_SEQUENCE_MAX_OP_EXCEEDED")]
    public static RFIDResults? RfidAccessSequenceMaxOpExceeded
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_SEQUENCE_MAX_OP_EXCEEDED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_SEQUENCE_NOT_INITIALIZED")]
    public static RFIDResults? RfidAccessSequenceNotInitialized
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_SEQUENCE_NOT_INITIALIZED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_BLOCK_ERASE_FAILED")]
    public static RFIDResults? RfidAccessTagBlockEraseFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_BLOCK_ERASE_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_BLOCK_PERMALOCK_FAILED")]
    public static RFIDResults? RfidAccessTagBlockPermalockFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_BLOCK_PERMALOCK_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_BLOCK_WRITE_FAILED")]
    public static RFIDResults? RfidAccessTagBlockWriteFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_BLOCK_WRITE_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_KILL_FAILED")]
    public static RFIDResults? RfidAccessTagKillFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_KILL_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_LOCK_FAILED")]
    public static RFIDResults? RfidAccessTagLockFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_LOCK_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_MEMORY_LOCKED_ERROR")]
    public static RFIDResults? RfidAccessTagMemoryLockedError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_MEMORY_LOCKED_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_MEMORY_OVERRUN_ERROR")]
    public static RFIDResults? RfidAccessTagMemoryOverrunError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_MEMORY_OVERRUN_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_NON_SPECIFIC_ERROR")]
    public static RFIDResults? RfidAccessTagNonSpecificError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_NON_SPECIFIC_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_NOT_FOUND")]
    public static RFIDResults? RfidAccessTagNotFound
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_NOT_FOUND.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_PASSWORD_ERROR")]
    public static RFIDResults? RfidAccessTagPasswordError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_PASSWORD_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_READ_FAILED")]
    public static RFIDResults? RfidAccessTagReadFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_READ_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_RECOMMISSION_FAILED")]
    public static RFIDResults? RfidAccessTagRecommissionFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_RECOMMISSION_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_TAG_WRITE_FAILED")]
    public static RFIDResults? RfidAccessTagWriteFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_TAG_WRITE_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ACCESS_ZERO_KILL_PASSWORD_ERROR")]
    public static RFIDResults? RfidAccessZeroKillPasswordError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ACCESS_ZERO_KILL_PASSWORD_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_BUFFER_TOO_SMALL")]
    public static RFIDResults? RfidApiBufferTooSmall
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_BUFFER_TOO_SMALL.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_CANNOT_ALLOC_MEM")]
    public static RFIDResults? RfidApiCannotAllocMem
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_CANNOT_ALLOC_MEM.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_COMMAND_TIMEOUT")]
    public static RFIDResults? RfidApiCommandTimeout
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_COMMAND_TIMEOUT.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_DATA_NOT_INITIALISED")]
    public static RFIDResults? RfidApiDataNotInitialised
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_DATA_NOT_INITIALISED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_INVALID_HANDLE")]
    public static RFIDResults? RfidApiInvalidHandle
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_INVALID_HANDLE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_LOCK_ACQUIRE_FAILURE")]
    public static RFIDResults? RfidApiLockAcquireFailure
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_LOCK_ACQUIRE_FAILURE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_OPTION_NOT_ALLOWED")]
    public static RFIDResults? RfidApiOptionNotAllowed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_OPTION_NOT_ALLOWED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_PARAM_ERROR")]
    public static RFIDResults? RfidApiParamError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_PARAM_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_PARAM_OUT_OF_RANGE")]
    public static RFIDResults? RfidApiParamOutOfRange
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_PARAM_OUT_OF_RANGE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_SUCCESS")]
    public static RFIDResults? RfidApiSuccess
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_SUCCESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_UNKNOWN_ERROR")]
    public static RFIDResults? RfidApiUnknownError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_UNKNOWN_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_ZONE_ID_ALREADY_EXITS")]
    public static RFIDResults? RfidApiZoneIdAlreadyExits
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_ZONE_ID_ALREADY_EXITS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_API_ZONE_ID_NOT_FOUND")]
    public static RFIDResults? RfidApiZoneIdNotFound
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_API_ZONE_ID_NOT_FOUND.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_BATCHMODE_IN_PROGRESS")]
    public static RFIDResults? RfidBatchmodeInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_BATCHMODE_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CAP_GET_FAILED")]
    public static RFIDResults? RfidCapGetFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CAP_GET_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CAP_NOT_SUPPORTED")]
    public static RFIDResults? RfidCapNotSupported
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CAP_NOT_SUPPORTED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CHARGING_COMMAND_NOT_ALLOWED")]
    public static RFIDResults? RfidChargingCommandNotAllowed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CHARGING_COMMAND_NOT_ALLOWED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMMAND_OPTION_WITHOUT_DELIMITER")]
    public static RFIDResults? RfidCommandOptionWithoutDelimiter
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMMAND_OPTION_WITHOUT_DELIMITER.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_CONNECTION_ALREADY_EXISTS")]
    public static RFIDResults? RfidCommConnectionAlreadyExists
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_CONNECTION_ALREADY_EXISTS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_NO_CONNECTION")]
    public static RFIDResults? RfidCommNoConnection
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_NO_CONNECTION.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_OPEN_ERROR")]
    public static RFIDResults? RfidCommOpenError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_OPEN_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_RECV_ERROR")]
    public static RFIDResults? RfidCommRecvError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_RECV_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_RESOLVE_ERROR")]
    public static RFIDResults? RfidCommResolveError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_RESOLVE_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_COMM_SEND_ERROR")]
    public static RFIDResults? RfidCommSendError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_COMM_SEND_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CONFIG_GET_FAILED")]
    public static RFIDResults? RfidConfigGetFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CONFIG_GET_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CONFIG_SET_FAILED")]
    public static RFIDResults? RfidConfigSetFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CONFIG_SET_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_CONNECTION_PASSWORD_ERROR")]
    public static RFIDResults? RfidConnectionPasswordError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_CONNECTION_PASSWORD_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_FILTER_INVALID_INDEX")]
    public static RFIDResults? RfidFilterInvalidIndex
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_FILTER_INVALID_INDEX.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_FILTER_MAX_FILTERS_EXCEEDED")]
    public static RFIDResults? RfidFilterMaxFiltersExceeded
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_FILTER_MAX_FILTERS_EXCEEDED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_FILTER_NO_FILTER")]
    public static RFIDResults? RfidFilterNoFilter
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_FILTER_NO_FILTER.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_FIRMWARE_UPDATE_FAILED")]
    public static RFIDResults? RfidFirmwareUpdateFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_FIRMWARE_UPDATE_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_FIRMWARE_UPDATE_FILE_PATH_ERROR")]
    public static RFIDResults? RfidFirmwareUpdateFilePathError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_FIRMWARE_UPDATE_FILE_PATH_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_GPIO_PORT_DISABLED")]
    public static RFIDResults? RfidGpioPortDisabled
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_GPIO_PORT_DISABLED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_HOST_SECURITY_CERTIFICATE_ERROR")]
    public static RFIDResults? RfidHostSecurityCertificateError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_HOST_SECURITY_CERTIFICATE_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_HOST_SECURITY_KEY_ERROR")]
    public static RFIDResults? RfidHostSecurityKeyError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_HOST_SECURITY_KEY_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVALID_ERROR_CODE")]
    public static RFIDResults? RfidInvalidErrorCode
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVALID_ERROR_CODE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVALID_SOCKET")]
    public static RFIDResults? RfidInvalidSocket
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVALID_SOCKET.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVENTORY_DUTY_CYCLE_API_PARAM_OUT_OF_RANGE")]
    public static RFIDResults? RfidInventoryDutyCycleApiParamOutOfRange
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVENTORY_DUTY_CYCLE_API_PARAM_OUT_OF_RANGE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVENTORY_DUTY_CYCLE_OUT_OF_RANGE")]
    public static RFIDResults? RfidInventoryDutyCycleOutOfRange
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVENTORY_DUTY_CYCLE_OUT_OF_RANGE.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVENTORY_IN_PROGRESS")]
    public static RFIDResults? RfidInventoryInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVENTORY_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_INVENTORY_MAX_TAGS_EXCEEDED")]
    public static RFIDResults? RfidInventoryMaxTagsExceeded
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_INVENTORY_MAX_TAGS_EXCEEDED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_MAX_CHARS_EXCEEDED")]
    public static RFIDResults? RfidMaxCharsExceeded
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_MAX_CHARS_EXCEEDED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_ACCESS_IN_PROGRESS")]
    public static RFIDResults? RfidNoAccessInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_ACCESS_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_INVENTORY_IN_PROGRESS")]
    public static RFIDResults? RfidNoInventoryInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_INVENTORY_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_NXP_EAS_SCAN_IN_PROGRESS")]
    public static RFIDResults? RfidNoNxpEasScanInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_NXP_EAS_SCAN_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_READ_TAGS")]
    public static RFIDResults? RfidNoReadTags
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_READ_TAGS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_REPORTED_EVENTS")]
    public static RFIDResults? RfidNoReportedEvents
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_REPORTED_EVENTS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NO_TAG_LOCATING_IN_PROGRESS")]
    public static RFIDResults? RfidNoTagLocatingInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NO_TAG_LOCATING_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_NXP_EAS_SCAN_IN_PROGRESS")]
    public static RFIDResults? RfidNxpEasScanInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_NXP_EAS_SCAN_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_OPERATION_IN_PROGRESS")]
    public static RFIDResults? RfidOperationInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_OPERATION_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_READER_FUNCTION_UNSUPPORTED")]
    public static RFIDResults? RfidReaderFunctionUnsupported
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_READER_FUNCTION_UNSUPPORTED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_READER_REGION_NOT_CONFIGURED")]
    public static RFIDResults? RfidReaderRegionNotConfigured
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_READER_REGION_NOT_CONFIGURED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_READER_REINITIALIZING")]
    public static RFIDResults? RfidReaderReinitializing
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_READER_REINITIALIZING.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_READER_TriggerInfo_NOT_CONFIGURED")]
    public static RFIDResults? RFIDREADERTriggerInfoNOTCONFIGURED
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_READER_TriggerInfo_NOT_CONFIGURED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_RECONNECT_FAILED")]
    public static RFIDResults? RfidReconnectFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_RECONNECT_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_RM_COMMAND_FAILED")]
    public static RFIDResults? RfidRmCommandFailed
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_RM_COMMAND_FAILED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_RM_INVALID_USERNAME_PASSWORD")]
    public static RFIDResults? RfidRmInvalidUsernamePassword
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_RM_INVALID_USERNAME_PASSWORD.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_RM_NO_UPDATION_IN_PROGRESS")]
    public static RFIDResults? RfidRmNoUpdationInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_RM_NO_UPDATION_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_RM_UPDATION_IN_PROGRESS")]
    public static RFIDResults? RfidRmUpdationInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_RM_UPDATION_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_ROOT_SECURITY_CERTIFICATE_ERROR")]
    public static RFIDResults? RfidRootSecurityCertificateError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_ROOT_SECURITY_CERTIFICATE_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_SECURE_CONNECTION_ERROR")]
    public static RFIDResults? RfidSecureConnectionError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_SECURE_CONNECTION_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_TAG_LOCATING_IN_PROGRESS")]
    public static RFIDResults? RfidTagLocatingInProgress
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_TAG_LOCATING_IN_PROGRESS.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RFID_WPA_MAX_SAVED_PROFILE_EXCEEDED")]
    public static RFIDResults? RfidWpaMaxSavedProfileExceeded
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("RFID_WPA_MAX_SAVED_PROFILE_EXCEEDED.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TAG_ACCESS_REGULATORY_TIMEOUT_ERROR")]
    public static RFIDResults? TagAccessRegulatoryTimeoutError
    {
      get
      {
        JniObjectReference objectValue = RFIDResults._members.StaticFields.GetObjectValue("TAG_ACCESS_REGULATORY_TIMEOUT_ERROR.Lcom/zebra/rfid/api3/RFIDResults;");
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFIDResults._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFIDResults._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFIDResults._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFIDResults._members.ManagedPeerType;

    protected RFIDResults(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) RFIDResults.cb_getValue == null)
        RFIDResults.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDResults.n_GetValue));
      return RFIDResults.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDResults>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return RFIDResults._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetRfidStatusValue", "(I)Lcom/zebra/rfid/api3/RFIDResults;", "")]
    public static unsafe RFIDResults? GetRfidStatusValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = RFIDResults._members.StaticMethods.InvokeObjectMethod("GetRfidStatusValue.(I)Lcom/zebra/rfid/api3/RFIDResults;", jniArgumentValuePtr);
      return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) RFIDResults.cb_equals_I == null)
        RFIDResults.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(RFIDResults.n_Equals_I));
      return RFIDResults.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<RFIDResults>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return RFIDResults._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
