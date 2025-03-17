// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RUN_STATUS
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
  [Register("com/zebra/rfid/api3/RUN_STATUS", DoNotGenerateAcw = true)]
  public class RUN_STATUS : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RUN_STATUS", typeof (RUN_STATUS));
    private static Delegate? cb_getRunStatus;
    private static Delegate? cb_setRunStatus_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RUN_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RUN_STATUS._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RUN_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RUN_STATUS._members.ManagedPeerType;

    protected RUN_STATUS(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RUN_STATUS()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RUN_STATUS._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RUN_STATUS._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetRunStatusHandler()
    {
      if ((object) RUN_STATUS.cb_getRunStatus == null)
        RUN_STATUS.cb_getRunStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RUN_STATUS.n_GetRunStatus));
      return RUN_STATUS.cb_getRunStatus;
    }

    private static bool n_GetRunStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RUN_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).RunStatus;
    }

    private static Delegate GetSetRunStatus_ZHandler()
    {
      if ((object) RUN_STATUS.cb_setRunStatus_Z == null)
        RUN_STATUS.cb_setRunStatus_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(RUN_STATUS.n_SetRunStatus_Z));
      return RUN_STATUS.cb_setRunStatus_Z;
    }

    private static void n_SetRunStatus_Z(IntPtr jnienv, IntPtr native__this, bool status)
    {
      Object.GetObject<RUN_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).RunStatus = status;
    }

    public virtual unsafe bool RunStatus
    {
      [Register("getRunStatus", "()Z", "GetGetRunStatusHandler")] get
      {
        return RUN_STATUS._members.InstanceMethods.InvokeVirtualBooleanMethod("getRunStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRunStatus", "(Z)V", "GetSetRunStatus_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RUN_STATUS._members.InstanceMethods.InvokeVirtualVoidMethod("setRunStatus.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
