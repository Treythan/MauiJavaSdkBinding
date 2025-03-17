// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CableLossCompensation
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
  [Register("com/zebra/rfid/api3/CableLossCompensation", DoNotGenerateAcw = true)]
  public class CableLossCompensation : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CableLossCompensation", typeof (CableLossCompensation));
    private static Delegate? cb_getAntennaID;
    private static Delegate? cb_setAntennaID_I;
    private static Delegate? cb_getCableLengthInFeet;
    private static Delegate? cb_setCableLengthInFeet_F;
    private static Delegate? cb_getCableLossPer100Feet;
    private static Delegate? cb_setCableLossPer100Feet_F;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CableLossCompensation._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CableLossCompensation._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CableLossCompensation._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CableLossCompensation._members.ManagedPeerType;

    protected CableLossCompensation(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe CableLossCompensation()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = CableLossCompensation._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      CableLossCompensation._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(IFF)V", "")]
    public unsafe CableLossCompensation(
      int antennaID,
      float cableLengthInFeet,
      float cableLossPer100Feet)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
      {
        new JniArgumentValue(antennaID),
        new JniArgumentValue(cableLengthInFeet),
        new JniArgumentValue(cableLossPer100Feet)
      };
      JniObjectReference instance = CableLossCompensation._members.InstanceMethods.StartCreateInstance("(IFF)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      CableLossCompensation._members.InstanceMethods.FinishCreateInstance("(IFF)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetAntennaIDHandler()
    {
      if ((object) CableLossCompensation.cb_getAntennaID == null)
        CableLossCompensation.cb_getAntennaID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(CableLossCompensation.n_GetAntennaID));
      return CableLossCompensation.cb_getAntennaID;
    }

    private static int n_GetAntennaID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID;
    }

    private static Delegate GetSetAntennaID_IHandler()
    {
      if ((object) CableLossCompensation.cb_setAntennaID_I == null)
        CableLossCompensation.cb_setAntennaID_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(CableLossCompensation.n_SetAntennaID_I));
      return CableLossCompensation.cb_setAntennaID_I;
    }

    private static void n_SetAntennaID_I(IntPtr jnienv, IntPtr native__this, int antennaID)
    {
      Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID = antennaID;
    }

    public virtual unsafe int AntennaID
    {
      [Register("getAntennaID", "()I", "GetGetAntennaIDHandler")] get
      {
        return CableLossCompensation._members.InstanceMethods.InvokeVirtualInt32Method("getAntennaID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAntennaID", "(I)V", "GetSetAntennaID_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CableLossCompensation._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaID.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCableLengthInFeetHandler()
    {
      if ((object) CableLossCompensation.cb_getCableLengthInFeet == null)
        CableLossCompensation.cb_getCableLengthInFeet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(CableLossCompensation.n_GetCableLengthInFeet));
      return CableLossCompensation.cb_getCableLengthInFeet;
    }

    private static float n_GetCableLengthInFeet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).CableLengthInFeet;
    }

    private static Delegate GetSetCableLengthInFeet_FHandler()
    {
      if ((object) CableLossCompensation.cb_setCableLengthInFeet_F == null)
        CableLossCompensation.cb_setCableLengthInFeet_F = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPF_V(CableLossCompensation.n_SetCableLengthInFeet_F));
      return CableLossCompensation.cb_setCableLengthInFeet_F;
    }

    private static void n_SetCableLengthInFeet_F(
      IntPtr jnienv,
      IntPtr native__this,
      float cableLengthInFeet)
    {
      Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).CableLengthInFeet = cableLengthInFeet;
    }

    public virtual unsafe float CableLengthInFeet
    {
      [Register("getCableLengthInFeet", "()F", "GetGetCableLengthInFeetHandler")] get
      {
        return CableLossCompensation._members.InstanceMethods.InvokeVirtualSingleMethod("getCableLengthInFeet.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCableLengthInFeet", "(F)V", "GetSetCableLengthInFeet_FHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CableLossCompensation._members.InstanceMethods.InvokeVirtualVoidMethod("setCableLengthInFeet.(F)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCableLossPer100FeetHandler()
    {
      if ((object) CableLossCompensation.cb_getCableLossPer100Feet == null)
        CableLossCompensation.cb_getCableLossPer100Feet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(CableLossCompensation.n_GetCableLossPer100Feet));
      return CableLossCompensation.cb_getCableLossPer100Feet;
    }

    private static float n_GetCableLossPer100Feet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).CableLossPer100Feet;
    }

    private static Delegate GetSetCableLossPer100Feet_FHandler()
    {
      if ((object) CableLossCompensation.cb_setCableLossPer100Feet_F == null)
        CableLossCompensation.cb_setCableLossPer100Feet_F = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPF_V(CableLossCompensation.n_SetCableLossPer100Feet_F));
      return CableLossCompensation.cb_setCableLossPer100Feet_F;
    }

    private static void n_SetCableLossPer100Feet_F(
      IntPtr jnienv,
      IntPtr native__this,
      float cableLossPer100Feet)
    {
      Object.GetObject<CableLossCompensation>(jnienv, native__this, (JniHandleOwnership) 0).CableLossPer100Feet = cableLossPer100Feet;
    }

    public virtual unsafe float CableLossPer100Feet
    {
      [Register("getCableLossPer100Feet", "()F", "GetGetCableLossPer100FeetHandler")] get
      {
        return CableLossCompensation._members.InstanceMethods.InvokeVirtualSingleMethod("getCableLossPer100Feet.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCableLossPer100Feet", "(F)V", "GetSetCableLossPer100Feet_FHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CableLossCompensation._members.InstanceMethods.InvokeVirtualVoidMethod("setCableLossPer100Feet.(F)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
