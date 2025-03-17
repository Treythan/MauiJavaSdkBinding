// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.GEN2V2_OPERATION_STATUS
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
  [Register("com/zebra/rfid/api3/GEN2V2_OPERATION_STATUS", DoNotGenerateAcw = true)]
  public class GEN2V2_OPERATION_STATUS : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/GEN2V2_OPERATION_STATUS", typeof (GEN2V2_OPERATION_STATUS));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ACCESS_BARKER_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessBarkerError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_BARKER_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_CAUSE_UNKNOWN_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessCauseUnknownError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_CAUSE_UNKNOWN_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_CRITERIA_NOT_MATCHING_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessCriteriaNotMatchingError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_CRITERIA_NOT_MATCHING_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_ERROR_SEND_WITHOUT_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessErrorSendWithoutLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_ERROR_SEND_WITHOUT_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_ERROR_SEND_WITH_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessErrorSendWithLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_ERROR_SEND_WITH_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_ERROR_STORED_WITHOUT_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessErrorStoredWithoutLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_ERROR_STORED_WITHOUT_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_ERROR_STORED_WITH_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessErrorStoredWithLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_ERROR_STORED_WITH_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_INSUFFICIENT_POWER")]
    public static GEN2V2_OPERATION_STATUS? AccessInsufficientPower
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_INSUFFICIENT_POWER.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_IO_STOP_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessIoStopError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_IO_STOP_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_LENGTH_BIT_PARITY_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessLengthBitParityError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_LENGTH_BIT_PARITY_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_NO_RESPONSE_FROM_TAG")]
    public static GEN2V2_OPERATION_STATUS? AccessNoResponseFromTag
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_NO_RESPONSE_FROM_TAG.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OLIO_TIMEOUT_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessOlioTimeoutError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_OLIO_TIMEOUT_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_RADIO_DWELL_TIMEOUT_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessRadioDwellTimeoutError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_RADIO_DWELL_TIMEOUT_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_RADIO_START_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessRadioStartError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_RADIO_START_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_READ_LENGTH_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessReadLengthError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_READ_LENGTH_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_REGULATORY_TIMEOUT_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessRegulatoryTimeoutError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_REGULATORY_TIMEOUT_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_STOP_REQUEST_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessStopRequestError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_STOP_REQUEST_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_SUCCESS")]
    public static GEN2V2_OPERATION_STATUS? AccessSuccess
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_SUCCESS.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_SUCCESS_SEND_WITHOUT_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessSuccessSendWithoutLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_SUCCESS_SEND_WITHOUT_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_SUCCESS_SEND_WITH_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessSuccessSendWithLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_SUCCESS_SEND_WITH_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_SUCCESS_STORED_WITHOUT_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessSuccessStoredWithoutLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_SUCCESS_STORED_WITHOUT_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_SUCCESS_STORED_WITH_LENGTH")]
    public static GEN2V2_OPERATION_STATUS? AccessSuccessStoredWithLength
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_SUCCESS_STORED_WITH_LENGTH.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_TAG_CRC_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessTagCrcError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_TAG_CRC_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_TAG_MEMORY_LOCKED_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessTagMemoryLockedError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_TAG_MEMORY_LOCKED_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_TAG_MEMORY_OVERRUN_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessTagMemoryOverrunError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_TAG_MEMORY_OVERRUN_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_TAG_PASSWORD_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessTagPasswordError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_TAG_PASSWORD_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_TAG_UNSPECIFIED_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessTagUnspecifiedError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_TAG_UNSPECIFIED_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_ZERO_KILL_PASSWORD_ERROR")]
    public static GEN2V2_OPERATION_STATUS? AccessZeroKillPasswordError
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_STATUS._members.StaticFields.GetObjectValue("ACCESS_ZERO_KILL_PASSWORD_ERROR.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;");
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return GEN2V2_OPERATION_STATUS._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        GEN2V2_OPERATION_STATUS._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = GEN2V2_OPERATION_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => GEN2V2_OPERATION_STATUS._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = GEN2V2_OPERATION_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => GEN2V2_OPERATION_STATUS._members.ManagedPeerType;

    protected GEN2V2_OPERATION_STATUS(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) GEN2V2_OPERATION_STATUS.cb_getValue == null)
        GEN2V2_OPERATION_STATUS.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GEN2V2_OPERATION_STATUS.n_GetValue));
      return GEN2V2_OPERATION_STATUS.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GEN2V2_OPERATION_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return GEN2V2_OPERATION_STATUS._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetAccessOperationStatusValue", "(I)Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", "")]
    public static unsafe ACCESS_OPERATION_STATUS? GetAccessOperationStatusValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = GEN2V2_OPERATION_STATUS._members.StaticMethods.InvokeObjectMethod("GetAccessOperationStatusValue.(I)Lcom/zebra/rfid/api3/ACCESS_OPERATION_STATUS;", jniArgumentValuePtr);
      return Object.GetObject<ACCESS_OPERATION_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetAccessOperationStatusValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;", "")]
    public static unsafe GEN2V2_OPERATION_STATUS? GetAccessOperationStatusValue(
      string? operationStatus)
    {
      IntPtr num = JNIEnv.NewString(operationStatus);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = GEN2V2_OPERATION_STATUS._members.StaticMethods.InvokeObjectMethod("GetAccessOperationStatusValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_STATUS;", jniArgumentValuePtr);
        return Object.GetObject<GEN2V2_OPERATION_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) GEN2V2_OPERATION_STATUS.cb_equals_I == null)
        GEN2V2_OPERATION_STATUS.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(GEN2V2_OPERATION_STATUS.n_Equals_I));
      return GEN2V2_OPERATION_STATUS.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<GEN2V2_OPERATION_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return GEN2V2_OPERATION_STATUS._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
