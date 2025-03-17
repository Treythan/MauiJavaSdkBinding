// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFModeTableEntry
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
  [Register("com/zebra/rfid/api3/RFModeTableEntry", DoNotGenerateAcw = true)]
  public class RFModeTableEntry : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFModeTableEntry", typeof (RFModeTableEntry));
    private static Delegate? cb_getBdrValue;
    private static Delegate? cb_getDivideRatio;
    private static Delegate? cb_getForwardLinkModulationType;
    private static Delegate? cb_isEpcHAGTCConformance;
    private static Delegate? cb_getMaxTariValue;
    private static Delegate? cb_getMinTariValue;
    private static Delegate? cb_getModeIdentifer;
    private static Delegate? cb_getModulation;
    private static Delegate? cb_getPieValue;
    private static Delegate? cb_getSpectralMaskIndicator;
    private static Delegate? cb_getStepTariValue;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFModeTableEntry._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFModeTableEntry._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFModeTableEntry._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFModeTableEntry._members.ManagedPeerType;

    protected RFModeTableEntry(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetBdrValueHandler()
    {
      if ((object) RFModeTableEntry.cb_getBdrValue == null)
        RFModeTableEntry.cb_getBdrValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetBdrValue));
      return RFModeTableEntry.cb_getBdrValue;
    }

    private static int n_GetBdrValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).BdrValue;
    }

    public virtual unsafe int BdrValue
    {
      [Register("getBdrValue", "()I", "GetGetBdrValueHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getBdrValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetDivideRatioHandler()
    {
      if ((object) RFModeTableEntry.cb_getDivideRatio == null)
        RFModeTableEntry.cb_getDivideRatio = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFModeTableEntry.n_GetDivideRatio));
      return RFModeTableEntry.cb_getDivideRatio;
    }

    private static IntPtr n_GetDivideRatio(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).DivideRatio);
    }

    public virtual unsafe DIVIDE_RATIO? DivideRatio
    {
      [Register("getDivideRatio", "()Lcom/zebra/rfid/api3/DIVIDE_RATIO;", "GetGetDivideRatioHandler")] get
      {
        JniObjectReference jniObjectReference = RFModeTableEntry._members.InstanceMethods.InvokeVirtualObjectMethod("getDivideRatio.()Lcom/zebra/rfid/api3/DIVIDE_RATIO;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DIVIDE_RATIO>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetForwardLinkModulationTypeHandler()
    {
      if ((object) RFModeTableEntry.cb_getForwardLinkModulationType == null)
        RFModeTableEntry.cb_getForwardLinkModulationType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFModeTableEntry.n_GetForwardLinkModulationType));
      return RFModeTableEntry.cb_getForwardLinkModulationType;
    }

    private static IntPtr n_GetForwardLinkModulationType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).ForwardLinkModulationType);
    }

    public virtual unsafe FORWARD_LINK_MODULATION? ForwardLinkModulationType
    {
      [Register("getForwardLinkModulationType", "()Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;", "GetGetForwardLinkModulationTypeHandler")] get
      {
        JniObjectReference jniObjectReference = RFModeTableEntry._members.InstanceMethods.InvokeVirtualObjectMethod("getForwardLinkModulationType.()Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<FORWARD_LINK_MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsEpcHAGTCConformanceHandler()
    {
      if ((object) RFModeTableEntry.cb_isEpcHAGTCConformance == null)
        RFModeTableEntry.cb_isEpcHAGTCConformance = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RFModeTableEntry.n_IsEpcHAGTCConformance));
      return RFModeTableEntry.cb_isEpcHAGTCConformance;
    }

    private static bool n_IsEpcHAGTCConformance(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).IsEpcHAGTCConformance;
    }

    public virtual unsafe bool IsEpcHAGTCConformance
    {
      [Register("isEpcHAGTCConformance", "()Z", "GetIsEpcHAGTCConformanceHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualBooleanMethod("isEpcHAGTCConformance.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMaxTariValueHandler()
    {
      if ((object) RFModeTableEntry.cb_getMaxTariValue == null)
        RFModeTableEntry.cb_getMaxTariValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetMaxTariValue));
      return RFModeTableEntry.cb_getMaxTariValue;
    }

    private static int n_GetMaxTariValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).MaxTariValue;
    }

    public virtual unsafe int MaxTariValue
    {
      [Register("getMaxTariValue", "()I", "GetGetMaxTariValueHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getMaxTariValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMinTariValueHandler()
    {
      if ((object) RFModeTableEntry.cb_getMinTariValue == null)
        RFModeTableEntry.cb_getMinTariValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetMinTariValue));
      return RFModeTableEntry.cb_getMinTariValue;
    }

    private static int n_GetMinTariValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).MinTariValue;
    }

    public virtual unsafe int MinTariValue
    {
      [Register("getMinTariValue", "()I", "GetGetMinTariValueHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getMinTariValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetModeIdentiferHandler()
    {
      if ((object) RFModeTableEntry.cb_getModeIdentifer == null)
        RFModeTableEntry.cb_getModeIdentifer = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetModeIdentifer));
      return RFModeTableEntry.cb_getModeIdentifer;
    }

    private static int n_GetModeIdentifer(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).ModeIdentifer;
    }

    public virtual unsafe int ModeIdentifer
    {
      [Register("getModeIdentifer", "()I", "GetGetModeIdentiferHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getModeIdentifer.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetModulationHandler()
    {
      if ((object) RFModeTableEntry.cb_getModulation == null)
        RFModeTableEntry.cb_getModulation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFModeTableEntry.n_GetModulation));
      return RFModeTableEntry.cb_getModulation;
    }

    private static IntPtr n_GetModulation(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).Modulation);
    }

    public virtual unsafe MODULATION? Modulation
    {
      [Register("getModulation", "()Lcom/zebra/rfid/api3/MODULATION;", "GetGetModulationHandler")] get
      {
        JniObjectReference jniObjectReference = RFModeTableEntry._members.InstanceMethods.InvokeVirtualObjectMethod("getModulation.()Lcom/zebra/rfid/api3/MODULATION;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetPieValueHandler()
    {
      if ((object) RFModeTableEntry.cb_getPieValue == null)
        RFModeTableEntry.cb_getPieValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetPieValue));
      return RFModeTableEntry.cb_getPieValue;
    }

    private static int n_GetPieValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).PieValue;
    }

    public virtual unsafe int PieValue
    {
      [Register("getPieValue", "()I", "GetGetPieValueHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getPieValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetSpectralMaskIndicatorHandler()
    {
      if ((object) RFModeTableEntry.cb_getSpectralMaskIndicator == null)
        RFModeTableEntry.cb_getSpectralMaskIndicator = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFModeTableEntry.n_GetSpectralMaskIndicator));
      return RFModeTableEntry.cb_getSpectralMaskIndicator;
    }

    private static IntPtr n_GetSpectralMaskIndicator(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).SpectralMaskIndicator);
    }

    public virtual unsafe SPECTRAL_MASK_INDICATOR? SpectralMaskIndicator
    {
      [Register("getSpectralMaskIndicator", "()Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;", "GetGetSpectralMaskIndicatorHandler")] get
      {
        JniObjectReference jniObjectReference = RFModeTableEntry._members.InstanceMethods.InvokeVirtualObjectMethod("getSpectralMaskIndicator.()Lcom/zebra/rfid/api3/SPECTRAL_MASK_INDICATOR;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStepTariValueHandler()
    {
      if ((object) RFModeTableEntry.cb_getStepTariValue == null)
        RFModeTableEntry.cb_getStepTariValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTableEntry.n_GetStepTariValue));
      return RFModeTableEntry.cb_getStepTariValue;
    }

    private static int n_GetStepTariValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTableEntry>(jnienv, native__this, (JniHandleOwnership) 0).StepTariValue;
    }

    public virtual unsafe int StepTariValue
    {
      [Register("getStepTariValue", "()I", "GetGetStepTariValueHandler")] get
      {
        return RFModeTableEntry._members.InstanceMethods.InvokeVirtualInt32Method("getStepTariValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
