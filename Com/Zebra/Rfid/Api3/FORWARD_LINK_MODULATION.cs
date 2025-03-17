// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FORWARD_LINK_MODULATION
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
  [Register("com/zebra/rfid/api3/FORWARD_LINK_MODULATION", DoNotGenerateAcw = true)]
  public class FORWARD_LINK_MODULATION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FORWARD_LINK_MODULATION", typeof (FORWARD_LINK_MODULATION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("FORWARD_LINK_MODULATION_DSB_ASK")]
    public static FORWARD_LINK_MODULATION? ForwardLinkModulationDsbAsk
    {
      get
      {
        JniObjectReference objectValue = FORWARD_LINK_MODULATION._members.StaticFields.GetObjectValue("FORWARD_LINK_MODULATION_DSB_ASK.Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;");
        return Object.GetObject<FORWARD_LINK_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FORWARD_LINK_MODULATION_PR_ASK")]
    public static FORWARD_LINK_MODULATION? ForwardLinkModulationPrAsk
    {
      get
      {
        JniObjectReference objectValue = FORWARD_LINK_MODULATION._members.StaticFields.GetObjectValue("FORWARD_LINK_MODULATION_PR_ASK.Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;");
        return Object.GetObject<FORWARD_LINK_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FORWARD_LINK_MODULATION_SSB_ASK")]
    public static FORWARD_LINK_MODULATION? ForwardLinkModulationSsbAsk
    {
      get
      {
        JniObjectReference objectValue = FORWARD_LINK_MODULATION._members.StaticFields.GetObjectValue("FORWARD_LINK_MODULATION_SSB_ASK.Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;");
        return Object.GetObject<FORWARD_LINK_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return FORWARD_LINK_MODULATION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        FORWARD_LINK_MODULATION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FORWARD_LINK_MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FORWARD_LINK_MODULATION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FORWARD_LINK_MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FORWARD_LINK_MODULATION._members.ManagedPeerType;

    protected FORWARD_LINK_MODULATION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) FORWARD_LINK_MODULATION.cb_getValue == null)
        FORWARD_LINK_MODULATION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FORWARD_LINK_MODULATION.n_GetValue));
      return FORWARD_LINK_MODULATION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FORWARD_LINK_MODULATION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return FORWARD_LINK_MODULATION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetForwardLinkModulationMapValue", "(I)Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;", "")]
    public static unsafe FORWARD_LINK_MODULATION? GetForwardLinkModulationMapValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = FORWARD_LINK_MODULATION._members.StaticMethods.InvokeObjectMethod("GetForwardLinkModulationMapValue.(I)Lcom/zebra/rfid/api3/FORWARD_LINK_MODULATION;", jniArgumentValuePtr);
      return Object.GetObject<FORWARD_LINK_MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) FORWARD_LINK_MODULATION.cb_equals_I == null)
        FORWARD_LINK_MODULATION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(FORWARD_LINK_MODULATION.n_Equals_I));
      return FORWARD_LINK_MODULATION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<FORWARD_LINK_MODULATION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return FORWARD_LINK_MODULATION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
