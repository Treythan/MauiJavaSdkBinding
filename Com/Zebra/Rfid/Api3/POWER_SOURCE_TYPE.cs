// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.POWER_SOURCE_TYPE
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
  [Register("com/zebra/rfid/api3/POWER_SOURCE_TYPE", DoNotGenerateAcw = true)]
  public class POWER_SOURCE_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/POWER_SOURCE_TYPE", typeof (POWER_SOURCE_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("FULL")]
    public static POWER_SOURCE_TYPE? Full
    {
      get
      {
        JniObjectReference objectValue = POWER_SOURCE_TYPE._members.StaticFields.GetObjectValue("FULL.Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;");
        return Object.GetObject<POWER_SOURCE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return POWER_SOURCE_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        POWER_SOURCE_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("POE")]
    public static POWER_SOURCE_TYPE? Poe
    {
      get
      {
        JniObjectReference objectValue = POWER_SOURCE_TYPE._members.StaticFields.GetObjectValue("POE.Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;");
        return Object.GetObject<POWER_SOURCE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POE_PLUS")]
    public static POWER_SOURCE_TYPE? PoePlus
    {
      get
      {
        JniObjectReference objectValue = POWER_SOURCE_TYPE._members.StaticFields.GetObjectValue("POE_PLUS.Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;");
        return Object.GetObject<POWER_SOURCE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = POWER_SOURCE_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => POWER_SOURCE_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = POWER_SOURCE_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => POWER_SOURCE_TYPE._members.ManagedPeerType;

    protected POWER_SOURCE_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) POWER_SOURCE_TYPE.cb_getValue == null)
        POWER_SOURCE_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(POWER_SOURCE_TYPE.n_GetValue));
      return POWER_SOURCE_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<POWER_SOURCE_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return POWER_SOURCE_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetPowerSourceTypeValue", "(I)Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;", "")]
    public static unsafe POWER_SOURCE_TYPE? GetPowerSourceTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = POWER_SOURCE_TYPE._members.StaticMethods.InvokeObjectMethod("GetPowerSourceTypeValue.(I)Lcom/zebra/rfid/api3/POWER_SOURCE_TYPE;", jniArgumentValuePtr);
      return Object.GetObject<POWER_SOURCE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) POWER_SOURCE_TYPE.cb_equals_I == null)
        POWER_SOURCE_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(POWER_SOURCE_TYPE.n_Equals_I));
      return POWER_SOURCE_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<POWER_SOURCE_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return POWER_SOURCE_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
