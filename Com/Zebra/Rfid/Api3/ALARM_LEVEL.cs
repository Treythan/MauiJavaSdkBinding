// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ALARM_LEVEL
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
  [Register("com/zebra/rfid/api3/ALARM_LEVEL", DoNotGenerateAcw = true)]
  public class ALARM_LEVEL : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ALARM_LEVEL", typeof (ALARM_LEVEL));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("CRITICAL")]
    public static ALARM_LEVEL? Critical
    {
      get
      {
        JniObjectReference objectValue = ALARM_LEVEL._members.StaticFields.GetObjectValue("CRITICAL.Lcom/zebra/rfid/api3/ALARM_LEVEL;");
        return Object.GetObject<ALARM_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HIGH")]
    public static ALARM_LEVEL? High
    {
      get
      {
        JniObjectReference objectValue = ALARM_LEVEL._members.StaticFields.GetObjectValue("HIGH.Lcom/zebra/rfid/api3/ALARM_LEVEL;");
        return Object.GetObject<ALARM_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOW")]
    public static ALARM_LEVEL? Low
    {
      get
      {
        JniObjectReference objectValue = ALARM_LEVEL._members.StaticFields.GetObjectValue("LOW.Lcom/zebra/rfid/api3/ALARM_LEVEL;");
        return Object.GetObject<ALARM_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => ALARM_LEVEL._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => ALARM_LEVEL._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ALARM_LEVEL._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ALARM_LEVEL._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ALARM_LEVEL._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ALARM_LEVEL._members.ManagedPeerType;

    protected ALARM_LEVEL(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) ALARM_LEVEL.cb_getValue == null)
        ALARM_LEVEL.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ALARM_LEVEL.n_GetValue));
      return ALARM_LEVEL.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ALARM_LEVEL>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return ALARM_LEVEL._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetAlarmLevelTypeValue", "(I)Lcom/zebra/rfid/api3/ALARM_LEVEL;", "")]
    public static unsafe ALARM_LEVEL? GetAlarmLevelTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = ALARM_LEVEL._members.StaticMethods.InvokeObjectMethod("GetAlarmLevelTypeValue.(I)Lcom/zebra/rfid/api3/ALARM_LEVEL;", jniArgumentValuePtr);
      return Object.GetObject<ALARM_LEVEL>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) ALARM_LEVEL.cb_equals_I == null)
        ALARM_LEVEL.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(ALARM_LEVEL.n_Equals_I));
      return ALARM_LEVEL.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<ALARM_LEVEL>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return ALARM_LEVEL._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
