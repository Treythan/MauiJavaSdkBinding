// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.StateUnawareAction
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
  [Register("com/zebra/rfid/api3/StateUnawareAction", DoNotGenerateAcw = true)]
  public class StateUnawareAction : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/StateUnawareAction", typeof (StateUnawareAction));
    private static Delegate? cb_getStateUnawareAction;
    private static Delegate? cb_setStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = StateUnawareAction._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => StateUnawareAction._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = StateUnawareAction._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => StateUnawareAction._members.ManagedPeerType;

    protected StateUnawareAction(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetStateUnawareActionHandler()
    {
      if ((object) StateUnawareAction.cb_getStateUnawareAction == null)
        StateUnawareAction.cb_getStateUnawareAction = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(StateUnawareAction.n_GetStateUnawareAction));
      return StateUnawareAction.cb_getStateUnawareAction;
    }

    private static IntPtr n_GetStateUnawareAction(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<StateUnawareAction>(jnienv, native__this, (JniHandleOwnership) 0).GetStateUnawareAction());
    }

    [Register("getStateUnawareAction", "()Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;", "GetGetStateUnawareActionHandler")]
    public virtual unsafe STATE_UNAWARE_ACTION? GetStateUnawareAction()
    {
      JniObjectReference jniObjectReference = StateUnawareAction._members.InstanceMethods.InvokeVirtualObjectMethod("getStateUnawareAction.()Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_Handler()
    {
      if ((object) StateUnawareAction.cb_setStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_ == null)
        StateUnawareAction.cb_setStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(StateUnawareAction.n_SetStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_));
      return StateUnawareAction.cb_setStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_;
    }

    private static void n_SetStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_stateUnawareAction)
    {
      Object.GetObject<StateUnawareAction>(jnienv, native__this, (JniHandleOwnership) 0).SetStateUnawareAction(Object.GetObject<STATE_UNAWARE_ACTION>(native_stateUnawareAction, (JniHandleOwnership) 0));
    }

    [Register("setStateUnawareAction", "(Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;)V", "GetSetStateUnawareAction_Lcom_zebra_rfid_api3_STATE_UNAWARE_ACTION_Handler")]
    public virtual unsafe void SetStateUnawareAction(STATE_UNAWARE_ACTION? stateUnawareAction)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(stateUnawareAction == null ? IntPtr.Zero : stateUnawareAction.Handle)
        };
        StateUnawareAction._members.InstanceMethods.InvokeVirtualVoidMethod("setStateUnawareAction.(Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) stateUnawareAction);
      }
    }
  }
}
