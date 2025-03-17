// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UpTime
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
  [Register("com/zebra/rfid/api3/UpTime", DoNotGenerateAcw = true)]
  public class UpTime : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UpTime", typeof (UpTime));
    private static Delegate? cb_getFirstSeenTimeStamp;
    private static Delegate? cb_getLastSeenTimeStamp;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UpTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UpTime._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UpTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UpTime._members.ManagedPeerType;

    protected UpTime(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetFirstSeenTimeStampHandler()
    {
      if ((object) UpTime.cb_getFirstSeenTimeStamp == null)
        UpTime.cb_getFirstSeenTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(UpTime.n_GetFirstSeenTimeStamp));
      return UpTime.cb_getFirstSeenTimeStamp;
    }

    private static long n_GetFirstSeenTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UpTime>(jnienv, native__this, (JniHandleOwnership) 0).FirstSeenTimeStamp;
    }

    public virtual unsafe long FirstSeenTimeStamp
    {
      [Register("getFirstSeenTimeStamp", "()J", "GetGetFirstSeenTimeStampHandler")] get
      {
        return UpTime._members.InstanceMethods.InvokeVirtualInt64Method("getFirstSeenTimeStamp.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLastSeenTimeStampHandler()
    {
      if ((object) UpTime.cb_getLastSeenTimeStamp == null)
        UpTime.cb_getLastSeenTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(UpTime.n_GetLastSeenTimeStamp));
      return UpTime.cb_getLastSeenTimeStamp;
    }

    private static long n_GetLastSeenTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UpTime>(jnienv, native__this, (JniHandleOwnership) 0).LastSeenTimeStamp;
    }

    public virtual unsafe long LastSeenTimeStamp
    {
      [Register("getLastSeenTimeStamp", "()J", "GetGetLastSeenTimeStampHandler")] get
      {
        return UpTime._members.InstanceMethods.InvokeVirtualInt64Method("getLastSeenTimeStamp.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
