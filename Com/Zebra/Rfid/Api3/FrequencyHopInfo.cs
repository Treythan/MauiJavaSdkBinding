// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FrequencyHopInfo
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
  [Register("com/zebra/rfid/api3/FrequencyHopInfo", DoNotGenerateAcw = true)]
  public class FrequencyHopInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FrequencyHopInfo", typeof (FrequencyHopInfo));
    private static Delegate? cb_Length;
    private static Delegate? cb_getFrepuencyHopTablesInfo_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FrequencyHopInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FrequencyHopInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FrequencyHopInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FrequencyHopInfo._members.ManagedPeerType;

    protected FrequencyHopInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetLengthHandler()
    {
      if ((object) FrequencyHopInfo.cb_Length == null)
        FrequencyHopInfo.cb_Length = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FrequencyHopInfo.n_Length));
      return FrequencyHopInfo.cb_Length;
    }

    private static int n_Length(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FrequencyHopInfo>(jnienv, native__this, (JniHandleOwnership) 0).Length();
    }

    [Register("Length", "()I", "GetLengthHandler")]
    public virtual unsafe int Length()
    {
      return FrequencyHopInfo._members.InstanceMethods.InvokeVirtualInt32Method("Length.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetFrepuencyHopTablesInfo_IHandler()
    {
      if ((object) FrequencyHopInfo.cb_getFrepuencyHopTablesInfo_I == null)
        FrequencyHopInfo.cb_getFrepuencyHopTablesInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(FrequencyHopInfo.n_GetFrepuencyHopTablesInfo_I));
      return FrequencyHopInfo.cb_getFrepuencyHopTablesInfo_I;
    }

    private static IntPtr n_GetFrepuencyHopTablesInfo_I(
      IntPtr jnienv,
      IntPtr native__this,
      int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<FrequencyHopInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetFrepuencyHopTablesInfo(index));
    }

    [Register("getFrepuencyHopTablesInfo", "(I)Lcom/zebra/rfid/api3/FrequencyHopTable;", "GetGetFrepuencyHopTablesInfo_IHandler")]
    public virtual unsafe FrequencyHopTable? GetFrepuencyHopTablesInfo(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = FrequencyHopInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getFrepuencyHopTablesInfo.(I)Lcom/zebra/rfid/api3/FrequencyHopTable;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<FrequencyHopTable>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
