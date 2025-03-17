// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ANTENNA_MODE
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
  [Register("com/zebra/rfid/api3/ANTENNA_MODE", DoNotGenerateAcw = true)]
  public class ANTENNA_MODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ANTENNA_MODE", typeof (ANTENNA_MODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ANTENNA_MODE_BISTATIC")]
    public static ANTENNA_MODE? AntennaModeBistatic
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_MODE._members.StaticFields.GetObjectValue("ANTENNA_MODE_BISTATIC.Lcom/zebra/rfid/api3/ANTENNA_MODE;");
        return Object.GetObject<ANTENNA_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ANTENNA_MODE_MONOSTATIC")]
    public static ANTENNA_MODE? AntennaModeMonostatic
    {
      get
      {
        JniObjectReference objectValue = ANTENNA_MODE._members.StaticFields.GetObjectValue("ANTENNA_MODE_MONOSTATIC.Lcom/zebra/rfid/api3/ANTENNA_MODE;");
        return Object.GetObject<ANTENNA_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => ANTENNA_MODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set
      {
        ANTENNA_MODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ANTENNA_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ANTENNA_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ANTENNA_MODE._members.ManagedPeerType;

    protected ANTENNA_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) ANTENNA_MODE.cb_getValue == null)
        ANTENNA_MODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ANTENNA_MODE.n_GetValue));
      return ANTENNA_MODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ANTENNA_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return ANTENNA_MODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetAntennaModeValue", "(I)Lcom/zebra/rfid/api3/ANTENNA_MODE;", "")]
    public static unsafe ANTENNA_MODE? GetAntennaModeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = ANTENNA_MODE._members.StaticMethods.InvokeObjectMethod("GetAntennaModeValue.(I)Lcom/zebra/rfid/api3/ANTENNA_MODE;", jniArgumentValuePtr);
      return Object.GetObject<ANTENNA_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) ANTENNA_MODE.cb_equals_I == null)
        ANTENNA_MODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(ANTENNA_MODE.n_Equals_I));
      return ANTENNA_MODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<ANTENNA_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return ANTENNA_MODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
