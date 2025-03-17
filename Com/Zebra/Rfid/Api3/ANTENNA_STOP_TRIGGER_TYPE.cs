// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ANTENNA_STOP_TRIGGER_TYPE
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
  [Register("com/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE", DoNotGenerateAcw = true)]
  public class ANTENNA_STOP_TRIGGER_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE", typeof (ANTENNA_STOP_TRIGGER_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ANTENNA_STOP_TRIGGER_TYPE_DURATION_MILLISECS")]
    public static ANTENNA_STOP_TRIGGER_TYPE? AntennaStopTriggerTypeDurationMillisecs
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.StaticFields.GetObjectValue("ANTENNA_STOP_TRIGGER_TYPE_DURATION_MILLISECS.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;");
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ANTENNA_STOP_TRIGGER_TYPE_DURATION_SECS")]
    public static ANTENNA_STOP_TRIGGER_TYPE? AntennaStopTriggerTypeDurationSecs
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.StaticFields.GetObjectValue("ANTENNA_STOP_TRIGGER_TYPE_DURATION_SECS.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;");
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ANTENNA_STOP_TRIGGER_TYPE_N_ATTEMPTS")]
    public static ANTENNA_STOP_TRIGGER_TYPE? AntennaStopTriggerTypeNAttempts
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.StaticFields.GetObjectValue("ANTENNA_STOP_TRIGGER_TYPE_N_ATTEMPTS.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;");
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("GPI")]
    public static ANTENNA_STOP_TRIGGER_TYPE? Gpi
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.StaticFields.GetObjectValue("GPI.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;");
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("name")]
    public string? Name
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.InstanceFields.GetObjectValue("name.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          ANTENNA_STOP_TRIGGER_TYPE._members.InstanceFields.SetValue("name.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return ANTENNA_STOP_TRIGGER_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        ANTENNA_STOP_TRIGGER_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("SINGLE_INVENTORY_LIMITED_DURATION")]
    public static ANTENNA_STOP_TRIGGER_TYPE? SingleInventoryLimitedDuration
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_STOP_TRIGGER_TYPE._members.StaticFields.GetObjectValue("SINGLE_INVENTORY_LIMITED_DURATION.Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;");
        return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_STOP_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ANTENNA_STOP_TRIGGER_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_STOP_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ANTENNA_STOP_TRIGGER_TYPE._members.ManagedPeerType;

    protected ANTENNA_STOP_TRIGGER_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/String;I)V", "")]
    public unsafe ANTENNA_STOP_TRIGGER_TYPE(string? name, int ordinal)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(ordinal)
        };
        JniObjectReference instance = ANTENNA_STOP_TRIGGER_TYPE._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ANTENNA_STOP_TRIGGER_TYPE._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) ANTENNA_STOP_TRIGGER_TYPE.cb_getValue == null)
        ANTENNA_STOP_TRIGGER_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ANTENNA_STOP_TRIGGER_TYPE.n_GetValue));
      return ANTENNA_STOP_TRIGGER_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return ANTENNA_STOP_TRIGGER_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetAntennaStopTriggerTypeValue", "(I)Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", "")]
    public static unsafe ANTENNA_STOP_TRIGGER_TYPE? GetAntennaStopTriggerTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = ANTENNA_STOP_TRIGGER_TYPE._members.StaticMethods.InvokeObjectMethod("GetAntennaStopTriggerTypeValue.(I)Lcom/zebra/rfid/api3/ANTENNA_STOP_TRIGGER_TYPE;", jniArgumentValuePtr);
      return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) ANTENNA_STOP_TRIGGER_TYPE.cb_equals_I == null)
        ANTENNA_STOP_TRIGGER_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(ANTENNA_STOP_TRIGGER_TYPE.n_Equals_I));
      return ANTENNA_STOP_TRIGGER_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<ANTENNA_STOP_TRIGGER_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return ANTENNA_STOP_TRIGGER_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
