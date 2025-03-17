// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFModes
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
  [Register("com/zebra/rfid/api3/RFModes", DoNotGenerateAcw = true)]
  public class RFModes : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFModes", typeof (RFModes));
    private static Delegate? cb_Length;
    private static Delegate? cb_getRFModeTableInfo_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFModes._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFModes._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFModes._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFModes._members.ManagedPeerType;

    protected RFModes(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetLengthHandler()
    {
      if ((object) RFModes.cb_Length == null)
        RFModes.cb_Length = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModes.n_Length));
      return RFModes.cb_Length;
    }

    private static int n_Length(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModes>(jnienv, native__this, (JniHandleOwnership) 0).Length();
    }

    [Register("Length", "()I", "GetLengthHandler")]
    public virtual unsafe int Length()
    {
      return RFModes._members.InstanceMethods.InvokeVirtualInt32Method("Length.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetRFModeTableInfo_IHandler()
    {
      if ((object) RFModes.cb_getRFModeTableInfo_I == null)
        RFModes.cb_getRFModeTableInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(RFModes.n_GetRFModeTableInfo_I));
      return RFModes.cb_getRFModeTableInfo_I;
    }

    private static IntPtr n_GetRFModeTableInfo_I(IntPtr jnienv, IntPtr native__this, int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModes>(jnienv, native__this, (JniHandleOwnership) 0).GetRFModeTableInfo(index));
    }

    [Register("getRFModeTableInfo", "(I)Lcom/zebra/rfid/api3/RFModeTable;", "GetGetRFModeTableInfo_IHandler")]
    public virtual unsafe RFModeTable? GetRFModeTableInfo(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = RFModes._members.InstanceMethods.InvokeVirtualObjectMethod("getRFModeTableInfo.(I)Lcom/zebra/rfid/api3/RFModeTable;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<RFModeTable>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
