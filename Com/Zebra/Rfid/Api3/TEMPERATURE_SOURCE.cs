// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TEMPERATURE_SOURCE
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
  [Register("com/zebra/rfid/api3/TEMPERATURE_SOURCE", DoNotGenerateAcw = true)]
  public class TEMPERATURE_SOURCE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TEMPERATURE_SOURCE", typeof (TEMPERATURE_SOURCE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("AMBIENT")]
    public static TEMPERATURE_SOURCE? Ambient
    {
      get
      {
        JniObjectReference objectValue = TEMPERATURE_SOURCE._members.StaticFields.GetObjectValue("AMBIENT.Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;");
        return Object.GetObject<TEMPERATURE_SOURCE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return TEMPERATURE_SOURCE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        TEMPERATURE_SOURCE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("PA")]
    public static TEMPERATURE_SOURCE? Pa
    {
      get
      {
        JniObjectReference objectValue = TEMPERATURE_SOURCE._members.StaticFields.GetObjectValue("PA.Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;");
        return Object.GetObject<TEMPERATURE_SOURCE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TEMPERATURE_SOURCE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TEMPERATURE_SOURCE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TEMPERATURE_SOURCE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TEMPERATURE_SOURCE._members.ManagedPeerType;

    protected TEMPERATURE_SOURCE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) TEMPERATURE_SOURCE.cb_getValue == null)
        TEMPERATURE_SOURCE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TEMPERATURE_SOURCE.n_GetValue));
      return TEMPERATURE_SOURCE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TEMPERATURE_SOURCE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return TEMPERATURE_SOURCE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetTemperatureSourceEventTypeValue", "(I)Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;", "")]
    public static unsafe TEMPERATURE_SOURCE? GetTemperatureSourceEventTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = TEMPERATURE_SOURCE._members.StaticMethods.InvokeObjectMethod("GetTemperatureSourceEventTypeValue.(I)Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;", jniArgumentValuePtr);
      return Object.GetObject<TEMPERATURE_SOURCE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) TEMPERATURE_SOURCE.cb_equals_I == null)
        TEMPERATURE_SOURCE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(TEMPERATURE_SOURCE.n_Equals_I));
      return TEMPERATURE_SOURCE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<TEMPERATURE_SOURCE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return TEMPERATURE_SOURCE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
