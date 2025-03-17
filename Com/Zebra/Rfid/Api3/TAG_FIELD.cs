// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TAG_FIELD
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
  [Register("com/zebra/rfid/api3/TAG_FIELD", DoNotGenerateAcw = true)]
  public class TAG_FIELD : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TAG_FIELD", typeof (TAG_FIELD));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ALL_TAG_FIELDS")]
    public static TAG_FIELD? AllTagFields
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("ALL_TAG_FIELDS.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ANTENNA_ID")]
    public static TAG_FIELD? AntennaId
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("ANTENNA_ID.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CHANNEL_INDEX")]
    public static TAG_FIELD? ChannelIndex
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("CHANNEL_INDEX.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CRC")]
    public static TAG_FIELD? Crc
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("CRC.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FIRST_SEEN_TIME_STAMP")]
    public static TAG_FIELD? FirstSeenTimeStamp
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("FIRST_SEEN_TIME_STAMP.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LAST_SEEN_TIME_STAMP")]
    public static TAG_FIELD? LastSeenTimeStamp
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("LAST_SEEN_TIME_STAMP.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => TAG_FIELD._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => TAG_FIELD._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("PC")]
    public static TAG_FIELD? Pc
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("PC.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("PEAK_RSSI")]
    public static TAG_FIELD? PeakRssi
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("PEAK_RSSI.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("PHASE_INFO")]
    public static TAG_FIELD? PhaseInfo
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("PHASE_INFO.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TAG_SEEN_COUNT")]
    public static TAG_FIELD? TagSeenCount
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("TAG_SEEN_COUNT.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TID")]
    public static TAG_FIELD? Tid
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("TID.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("USER")]
    public static TAG_FIELD? User
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("USER.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("XPC")]
    public static TAG_FIELD? Xpc
    {
      get
      {
        JniObjectReference objectValue = TAG_FIELD._members.StaticFields.GetObjectValue("XPC.Lcom/zebra/rfid/api3/TAG_FIELD;");
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TAG_FIELD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TAG_FIELD._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TAG_FIELD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TAG_FIELD._members.ManagedPeerType;

    protected TAG_FIELD(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) TAG_FIELD.cb_getValue == null)
        TAG_FIELD.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TAG_FIELD.n_GetValue));
      return TAG_FIELD.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TAG_FIELD>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return TAG_FIELD._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) TAG_FIELD.cb_equals_I == null)
        TAG_FIELD.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(TAG_FIELD.n_Equals_I));
      return TAG_FIELD.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<TAG_FIELD>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return TAG_FIELD._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("getTagField", "(I)[Lcom/zebra/rfid/api3/TAG_FIELD;", "")]
    public static unsafe TAG_FIELD[]? GetTagField(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = TAG_FIELD._members.StaticMethods.InvokeObjectMethod("getTagField.(I)[Lcom/zebra/rfid/api3/TAG_FIELD;", jniArgumentValuePtr);
      return (TAG_FIELD[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TAG_FIELD));
    }
  }
}
