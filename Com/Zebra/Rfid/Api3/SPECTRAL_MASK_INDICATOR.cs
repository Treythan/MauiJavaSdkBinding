// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SPECTRAL_MASK_INDICATOR
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
  [Register("com/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR", DoNotGenerateAcw = true)]
  public class SPECTRAL_MASK_INDICATOR : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR", typeof (SPECTRAL_MASK_INDICATOR));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return SPECTRAL_MASK_INDICATOR._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        SPECTRAL_MASK_INDICATOR._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("SMI_DI")]
    public static SPECTRAL_MASK_INDICATOR? SmiDi
    {
      get
      {
        JniObjectReference objectValue = SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_DI.Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_MI")]
    public static SPECTRAL_MASK_INDICATOR? SmiMi
    {
      get
      {
        JniObjectReference objectValue = SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_MI.Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_SI")]
    public static SPECTRAL_MASK_INDICATOR? SmiSi
    {
      get
      {
        JniObjectReference objectValue = SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_SI.Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SMI_UNKNOWN")]
    public static SPECTRAL_MASK_INDICATOR? SmiUnknown
    {
      get
      {
        JniObjectReference objectValue = SPECTRAL_MASK_INDICATOR._members.StaticFields.GetObjectValue("SMI_UNKNOWN.Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;");
        return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SPECTRAL_MASK_INDICATOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SPECTRAL_MASK_INDICATOR._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SPECTRAL_MASK_INDICATOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SPECTRAL_MASK_INDICATOR._members.ManagedPeerType;

    protected SPECTRAL_MASK_INDICATOR(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) SPECTRAL_MASK_INDICATOR.cb_getValue == null)
        SPECTRAL_MASK_INDICATOR.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SPECTRAL_MASK_INDICATOR.n_GetValue));
      return SPECTRAL_MASK_INDICATOR.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SPECTRAL_MASK_INDICATOR>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return SPECTRAL_MASK_INDICATOR._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetSpectralMaskIndicatorValue", "(I)Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;", "")]
    public static unsafe SPECTRAL_MASK_INDICATOR? GetSpectralMaskIndicatorValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = SPECTRAL_MASK_INDICATOR._members.StaticMethods.InvokeObjectMethod("GetSpectralMaskIndicatorValue.(I)Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;", jniArgumentValuePtr);
      return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) SPECTRAL_MASK_INDICATOR.cb_equals_I == null)
        SPECTRAL_MASK_INDICATOR.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(SPECTRAL_MASK_INDICATOR.n_Equals_I));
      return SPECTRAL_MASK_INDICATOR.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<SPECTRAL_MASK_INDICATOR>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return SPECTRAL_MASK_INDICATOR._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
