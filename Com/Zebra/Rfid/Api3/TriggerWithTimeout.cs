// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TriggerWithTimeout
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
  [Register("com/zebra/rfid/api3/TriggerWithTimeout", DoNotGenerateAcw = true)]
  public class TriggerWithTimeout : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TriggerWithTimeout", typeof (TriggerWithTimeout));
    private static Delegate? cb_getTimeout;
    private static Delegate? cb_setTimeout_I;
    private static Delegate? cb_getN;
    private static Delegate? cb_setN_S;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TriggerWithTimeout._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TriggerWithTimeout._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TriggerWithTimeout._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TriggerWithTimeout._members.ManagedPeerType;

    protected TriggerWithTimeout(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetTimeoutHandler()
    {
      if ((object) TriggerWithTimeout.cb_getTimeout == null)
        TriggerWithTimeout.cb_getTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TriggerWithTimeout.n_GetTimeout));
      return TriggerWithTimeout.cb_getTimeout;
    }

    private static int n_GetTimeout(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TriggerWithTimeout>(jnienv, native__this, (JniHandleOwnership) 0).Timeout;
    }

    private static Delegate GetSetTimeout_IHandler()
    {
      if ((object) TriggerWithTimeout.cb_setTimeout_I == null)
        TriggerWithTimeout.cb_setTimeout_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TriggerWithTimeout.n_SetTimeout_I));
      return TriggerWithTimeout.cb_setTimeout_I;
    }

    private static void n_SetTimeout_I(IntPtr jnienv, IntPtr native__this, int timeout)
    {
      Object.GetObject<TriggerWithTimeout>(jnienv, native__this, (JniHandleOwnership) 0).Timeout = timeout;
    }

    public virtual unsafe int Timeout
    {
      [Register("getTimeout", "()I", "GetGetTimeoutHandler")] get
      {
        return TriggerWithTimeout._members.InstanceMethods.InvokeVirtualInt32Method("getTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTimeout", "(I)V", "GetSetTimeout_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TriggerWithTimeout._members.InstanceMethods.InvokeVirtualVoidMethod("setTimeout.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNHandler()
    {
      if ((object) TriggerWithTimeout.cb_getN == null)
        TriggerWithTimeout.cb_getN = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(TriggerWithTimeout.n_GetN));
      return TriggerWithTimeout.cb_getN;
    }

    private static short n_GetN(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TriggerWithTimeout>(jnienv, native__this, (JniHandleOwnership) 0).GetN();
    }

    [Register("getN", "()S", "GetGetNHandler")]
    public virtual unsafe short GetN()
    {
      return TriggerWithTimeout._members.InstanceMethods.InvokeVirtualInt16Method("getN.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetN_SHandler()
    {
      if ((object) TriggerWithTimeout.cb_setN_S == null)
        TriggerWithTimeout.cb_setN_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TriggerWithTimeout.n_SetN_S));
      return TriggerWithTimeout.cb_setN_S;
    }

    private static void n_SetN_S(IntPtr jnienv, IntPtr native__this, short N)
    {
      Object.GetObject<TriggerWithTimeout>(jnienv, native__this, (JniHandleOwnership) 0).SetN(N);
    }

    [Register("setN", "(S)V", "GetSetN_SHandler")]
    public virtual unsafe void SetN(short N)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(N)
      };
      TriggerWithTimeout._members.InstanceMethods.InvokeVirtualVoidMethod("setN.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
