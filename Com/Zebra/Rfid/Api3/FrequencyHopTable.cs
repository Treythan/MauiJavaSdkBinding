// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FrequencyHopTable
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
  [Register("com/zebra/rfid/api3/FrequencyHopTable", DoNotGenerateAcw = true)]
  public class FrequencyHopTable : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FrequencyHopTable", typeof (FrequencyHopTable));
    private static Delegate? cb_getHopTableID;
    private static Delegate? cb_getFrequencyHopValues;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FrequencyHopTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FrequencyHopTable._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FrequencyHopTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FrequencyHopTable._members.ManagedPeerType;

    protected FrequencyHopTable(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetHopTableIDHandler()
    {
      if ((object) FrequencyHopTable.cb_getHopTableID == null)
        FrequencyHopTable.cb_getHopTableID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FrequencyHopTable.n_GetHopTableID));
      return FrequencyHopTable.cb_getHopTableID;
    }

    private static int n_GetHopTableID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FrequencyHopTable>(jnienv, native__this, (JniHandleOwnership) 0).HopTableID;
    }

    public virtual unsafe int HopTableID
    {
      [Register("getHopTableID", "()I", "GetGetHopTableIDHandler")] get
      {
        return FrequencyHopTable._members.InstanceMethods.InvokeVirtualInt32Method("getHopTableID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetFrequencyHopValuesHandler()
    {
      if ((object) FrequencyHopTable.cb_getFrequencyHopValues == null)
        FrequencyHopTable.cb_getFrequencyHopValues = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FrequencyHopTable.n_GetFrequencyHopValues));
      return FrequencyHopTable.cb_getFrequencyHopValues;
    }

    private static IntPtr n_GetFrequencyHopValues(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<FrequencyHopTable>(jnienv, native__this, (JniHandleOwnership) 0).GetFrequencyHopValues());
    }

    [Register("getFrequencyHopValues", "()[I", "GetGetFrequencyHopValuesHandler")]
    public virtual unsafe int[]? GetFrequencyHopValues()
    {
      JniObjectReference jniObjectReference = FrequencyHopTable._members.InstanceMethods.InvokeVirtualObjectMethod("getFrequencyHopValues.()[I", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (int[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (int));
    }
  }
}
