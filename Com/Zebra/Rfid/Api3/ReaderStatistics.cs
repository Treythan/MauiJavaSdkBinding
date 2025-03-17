// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReaderStatistics
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
  [Register("com/zebra/rfid/api3/ReaderStatistics", DoNotGenerateAcw = true)]
  public class ReaderStatistics : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderStatistics", typeof (ReaderStatistics));
    private static Delegate? cb_getBlockEraseFailureCount;
    private static Delegate? cb_getBlockEraseSuccessCount;
    private static Delegate? cb_getBlockPermalockFailureCount;
    private static Delegate? cb_getBlockPermalockSuccessCount;
    private static Delegate? cb_getBlockWriteFailureCount;
    private static Delegate? cb_getBlockWriteSuccessCount;
    private static Delegate? cb_getIdentifiedFailureCount;
    private static Delegate? cb_getIdentifiedSuccessCount;
    private static Delegate? cb_getImpinjStats;
    private static Delegate? cb_getKillFailureCount;
    private static Delegate? cb_getKillSuccessCount;
    private static Delegate? cb_getLockFailureCount;
    private static Delegate? cb_getLockSuccessCount;
    private static Delegate? cb_getM_NXPStats;
    private static Delegate? cb_getReadFailureCount;
    private static Delegate? cb_getReadSuccessCount;
    private static Delegate? cb_getWriteFailureCount;
    private static Delegate? cb_getWriteSuccessCount;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReaderStatistics._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReaderStatistics._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReaderStatistics._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReaderStatistics._members.ManagedPeerType;

    protected ReaderStatistics(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetBlockEraseFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockEraseFailureCount == null)
        ReaderStatistics.cb_getBlockEraseFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockEraseFailureCount));
      return ReaderStatistics.cb_getBlockEraseFailureCount;
    }

    private static int n_GetBlockEraseFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockEraseFailureCount;
    }

    public virtual unsafe int BlockEraseFailureCount
    {
      [Register("getBlockEraseFailureCount", "()I", "GetGetBlockEraseFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockEraseFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetBlockEraseSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockEraseSuccessCount == null)
        ReaderStatistics.cb_getBlockEraseSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockEraseSuccessCount));
      return ReaderStatistics.cb_getBlockEraseSuccessCount;
    }

    private static int n_GetBlockEraseSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockEraseSuccessCount;
    }

    public virtual unsafe int BlockEraseSuccessCount
    {
      [Register("getBlockEraseSuccessCount", "()I", "GetGetBlockEraseSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockEraseSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetBlockPermalockFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockPermalockFailureCount == null)
        ReaderStatistics.cb_getBlockPermalockFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockPermalockFailureCount));
      return ReaderStatistics.cb_getBlockPermalockFailureCount;
    }

    private static int n_GetBlockPermalockFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockPermalockFailureCount;
    }

    public virtual unsafe int BlockPermalockFailureCount
    {
      [Register("getBlockPermalockFailureCount", "()I", "GetGetBlockPermalockFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockPermalockFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetBlockPermalockSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockPermalockSuccessCount == null)
        ReaderStatistics.cb_getBlockPermalockSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockPermalockSuccessCount));
      return ReaderStatistics.cb_getBlockPermalockSuccessCount;
    }

    private static int n_GetBlockPermalockSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockPermalockSuccessCount;
    }

    public virtual unsafe int BlockPermalockSuccessCount
    {
      [Register("getBlockPermalockSuccessCount", "()I", "GetGetBlockPermalockSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockPermalockSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetBlockWriteFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockWriteFailureCount == null)
        ReaderStatistics.cb_getBlockWriteFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockWriteFailureCount));
      return ReaderStatistics.cb_getBlockWriteFailureCount;
    }

    private static int n_GetBlockWriteFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockWriteFailureCount;
    }

    public virtual unsafe int BlockWriteFailureCount
    {
      [Register("getBlockWriteFailureCount", "()I", "GetGetBlockWriteFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockWriteFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetBlockWriteSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getBlockWriteSuccessCount == null)
        ReaderStatistics.cb_getBlockWriteSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetBlockWriteSuccessCount));
      return ReaderStatistics.cb_getBlockWriteSuccessCount;
    }

    private static int n_GetBlockWriteSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).BlockWriteSuccessCount;
    }

    public virtual unsafe int BlockWriteSuccessCount
    {
      [Register("getBlockWriteSuccessCount", "()I", "GetGetBlockWriteSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getBlockWriteSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetIdentifiedFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getIdentifiedFailureCount == null)
        ReaderStatistics.cb_getIdentifiedFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetIdentifiedFailureCount));
      return ReaderStatistics.cb_getIdentifiedFailureCount;
    }

    private static int n_GetIdentifiedFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).IdentifiedFailureCount;
    }

    public virtual unsafe int IdentifiedFailureCount
    {
      [Register("getIdentifiedFailureCount", "()I", "GetGetIdentifiedFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getIdentifiedFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetIdentifiedSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getIdentifiedSuccessCount == null)
        ReaderStatistics.cb_getIdentifiedSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetIdentifiedSuccessCount));
      return ReaderStatistics.cb_getIdentifiedSuccessCount;
    }

    private static int n_GetIdentifiedSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).IdentifiedSuccessCount;
    }

    public virtual unsafe int IdentifiedSuccessCount
    {
      [Register("getIdentifiedSuccessCount", "()I", "GetGetIdentifiedSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getIdentifiedSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetImpinjStatsHandler()
    {
      if ((object) ReaderStatistics.cb_getImpinjStats == null)
        ReaderStatistics.cb_getImpinjStats = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderStatistics.n_GetImpinjStats));
      return ReaderStatistics.cb_getImpinjStats;
    }

    private static IntPtr n_GetImpinjStats(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ImpinjStats);
    }

    public virtual unsafe Object? ImpinjStats
    {
      [Register("getImpinjStats", "()Ljava/lang/Object;", "GetGetImpinjStatsHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getImpinjStats.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetKillFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getKillFailureCount == null)
        ReaderStatistics.cb_getKillFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetKillFailureCount));
      return ReaderStatistics.cb_getKillFailureCount;
    }

    private static int n_GetKillFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).KillFailureCount;
    }

    public virtual unsafe int KillFailureCount
    {
      [Register("getKillFailureCount", "()I", "GetGetKillFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getKillFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetKillSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getKillSuccessCount == null)
        ReaderStatistics.cb_getKillSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetKillSuccessCount));
      return ReaderStatistics.cb_getKillSuccessCount;
    }

    private static int n_GetKillSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).KillSuccessCount;
    }

    public virtual unsafe int KillSuccessCount
    {
      [Register("getKillSuccessCount", "()I", "GetGetKillSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getKillSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLockFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getLockFailureCount == null)
        ReaderStatistics.cb_getLockFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetLockFailureCount));
      return ReaderStatistics.cb_getLockFailureCount;
    }

    private static int n_GetLockFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).LockFailureCount;
    }

    public virtual unsafe int LockFailureCount
    {
      [Register("getLockFailureCount", "()I", "GetGetLockFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getLockFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLockSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getLockSuccessCount == null)
        ReaderStatistics.cb_getLockSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetLockSuccessCount));
      return ReaderStatistics.cb_getLockSuccessCount;
    }

    private static int n_GetLockSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).LockSuccessCount;
    }

    public virtual unsafe int LockSuccessCount
    {
      [Register("getLockSuccessCount", "()I", "GetGetLockSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getLockSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetM_NXPStatsHandler()
    {
      if ((object) ReaderStatistics.cb_getM_NXPStats == null)
        ReaderStatistics.cb_getM_NXPStats = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderStatistics.n_GetM_NXPStats));
      return ReaderStatistics.cb_getM_NXPStats;
    }

    private static IntPtr n_GetM_NXPStats(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).M_NXPStats);
    }

    public virtual unsafe Object? M_NXPStats
    {
      [Register("getM_NXPStats", "()Ljava/lang/Object;", "GetGetM_NXPStatsHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderStatistics._members.InstanceMethods.InvokeVirtualObjectMethod("getM_NXPStats.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetReadFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getReadFailureCount == null)
        ReaderStatistics.cb_getReadFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetReadFailureCount));
      return ReaderStatistics.cb_getReadFailureCount;
    }

    private static int n_GetReadFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ReadFailureCount;
    }

    public virtual unsafe int ReadFailureCount
    {
      [Register("getReadFailureCount", "()I", "GetGetReadFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getReadFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetReadSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getReadSuccessCount == null)
        ReaderStatistics.cb_getReadSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetReadSuccessCount));
      return ReaderStatistics.cb_getReadSuccessCount;
    }

    private static int n_GetReadSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).ReadSuccessCount;
    }

    public virtual unsafe int ReadSuccessCount
    {
      [Register("getReadSuccessCount", "()I", "GetGetReadSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getReadSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetWriteFailureCountHandler()
    {
      if ((object) ReaderStatistics.cb_getWriteFailureCount == null)
        ReaderStatistics.cb_getWriteFailureCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetWriteFailureCount));
      return ReaderStatistics.cb_getWriteFailureCount;
    }

    private static int n_GetWriteFailureCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).WriteFailureCount;
    }

    public virtual unsafe int WriteFailureCount
    {
      [Register("getWriteFailureCount", "()I", "GetGetWriteFailureCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getWriteFailureCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetWriteSuccessCountHandler()
    {
      if ((object) ReaderStatistics.cb_getWriteSuccessCount == null)
        ReaderStatistics.cb_getWriteSuccessCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReaderStatistics.n_GetWriteSuccessCount));
      return ReaderStatistics.cb_getWriteSuccessCount;
    }

    private static int n_GetWriteSuccessCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReaderStatistics>(jnienv, native__this, (JniHandleOwnership) 0).WriteSuccessCount;
    }

    public virtual unsafe int WriteSuccessCount
    {
      [Register("getWriteSuccessCount", "()I", "GetGetWriteSuccessCountHandler")] get
      {
        return ReaderStatistics._members.InstanceMethods.InvokeVirtualInt32Method("getWriteSuccessCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
