// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SeenTime
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
  [Register("com/zebra/rfid/api3/SeenTime", DoNotGenerateAcw = true)]
  public class SeenTime : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SeenTime", typeof (SeenTime));
    private static Delegate? cb_getUTCTime;
    private static Delegate? cb_getUpTime;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SeenTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SeenTime._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SeenTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SeenTime._members.ManagedPeerType;

    protected SeenTime(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetUTCTimeHandler()
    {
      if ((object) SeenTime.cb_getUTCTime == null)
        SeenTime.cb_getUTCTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SeenTime.n_GetUTCTime));
      return SeenTime.cb_getUTCTime;
    }

    private static IntPtr n_GetUTCTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SeenTime>(jnienv, native__this, (JniHandleOwnership) 0).UTCTime);
    }

    public virtual unsafe UTCTime? UTCTime
    {
      [Register("getUTCTime", "()Lcom/zebra/rfid/api3/UTCTime;", "GetGetUTCTimeHandler")] get
      {
        JniObjectReference jniObjectReference = SeenTime._members.InstanceMethods.InvokeVirtualObjectMethod("getUTCTime.()Lcom/zebra/rfid/api3/UTCTime;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<UTCTime>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetUpTimeHandler()
    {
      if ((object) SeenTime.cb_getUpTime == null)
        SeenTime.cb_getUpTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SeenTime.n_GetUpTime));
      return SeenTime.cb_getUpTime;
    }

    private static IntPtr n_GetUpTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SeenTime>(jnienv, native__this, (JniHandleOwnership) 0).UpTime);
    }

    public virtual unsafe UpTime? UpTime
    {
      [Register("getUpTime", "()Lcom/zebra/rfid/api3/UpTime;", "GetGetUpTimeHandler")] get
      {
        JniObjectReference jniObjectReference = SeenTime._members.InstanceMethods.InvokeVirtualObjectMethod("getUpTime.()Lcom/zebra/rfid/api3/UpTime;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<UpTime>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
