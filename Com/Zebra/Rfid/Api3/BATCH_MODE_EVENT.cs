// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BATCH_MODE_EVENT
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
  [Register("com/zebra/rfid/api3/BATCH_MODE_EVENT", DoNotGenerateAcw = true)]
  public class BATCH_MODE_EVENT : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BATCH_MODE_EVENT", typeof (BATCH_MODE_EVENT));
    private static Delegate? cb_getBATCH_MODE;
    private static Delegate? cb_getRepeatTrigger;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BATCH_MODE_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BATCH_MODE_EVENT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BATCH_MODE_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BATCH_MODE_EVENT._members.ManagedPeerType;

    protected BATCH_MODE_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BATCH_MODE_EVENT()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BATCH_MODE_EVENT._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BATCH_MODE_EVENT._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBATCH_MODEHandler()
    {
      if ((object) BATCH_MODE_EVENT.cb_getBATCH_MODE == null)
        BATCH_MODE_EVENT.cb_getBATCH_MODE = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BATCH_MODE_EVENT.n_GetBATCH_MODE));
      return BATCH_MODE_EVENT.cb_getBATCH_MODE;
    }

    private static IntPtr n_GetBATCH_MODE(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<BATCH_MODE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).BATCH_MODE);
    }

    public virtual unsafe Integer? BATCH_MODE
    {
      [Register("getBATCH_MODE", "()Ljava/lang/Integer;", "GetGetBATCH_MODEHandler")] get
      {
        JniObjectReference jniObjectReference = BATCH_MODE_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getBATCH_MODE.()Ljava/lang/Integer;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Integer>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetRepeatTriggerHandler()
    {
      if ((object) BATCH_MODE_EVENT.cb_getRepeatTrigger == null)
        BATCH_MODE_EVENT.cb_getRepeatTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BATCH_MODE_EVENT.n_GetRepeatTrigger));
      return BATCH_MODE_EVENT.cb_getRepeatTrigger;
    }

    private static IntPtr n_GetRepeatTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<BATCH_MODE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).RepeatTrigger);
    }

    public virtual unsafe Boolean? RepeatTrigger
    {
      [Register("getRepeatTrigger", "()Ljava/lang/Boolean;", "GetGetRepeatTriggerHandler")] get
      {
        JniObjectReference jniObjectReference = BATCH_MODE_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getRepeatTrigger.()Ljava/lang/Boolean;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Boolean>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
