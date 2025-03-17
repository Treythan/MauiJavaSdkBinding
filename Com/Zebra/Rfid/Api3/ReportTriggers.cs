// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReportTriggers
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
  [Register("com/zebra/rfid/api3/ReportTriggers", DoNotGenerateAcw = true)]
  public class ReportTriggers : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReportTriggers", typeof (ReportTriggers));
    private static Delegate? cb_getPeriodicReportTrigger;
    private static Delegate? cb_setPeriodicReportTrigger_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReportTriggers._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReportTriggers._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReportTriggers._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReportTriggers._members.ManagedPeerType;

    protected ReportTriggers(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ReportTriggers()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ReportTriggers._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ReportTriggers._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(I)V", "")]
    public unsafe ReportTriggers(int periodicReportTrigger)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(periodicReportTrigger)
      };
      JniObjectReference instance = ReportTriggers._members.InstanceMethods.StartCreateInstance("(I)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ReportTriggers._members.InstanceMethods.FinishCreateInstance("(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetPeriodicReportTriggerHandler()
    {
      if ((object) ReportTriggers.cb_getPeriodicReportTrigger == null)
        ReportTriggers.cb_getPeriodicReportTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReportTriggers.n_GetPeriodicReportTrigger));
      return ReportTriggers.cb_getPeriodicReportTrigger;
    }

    private static int n_GetPeriodicReportTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReportTriggers>(jnienv, native__this, (JniHandleOwnership) 0).PeriodicReportTrigger;
    }

    private static Delegate GetSetPeriodicReportTrigger_IHandler()
    {
      if ((object) ReportTriggers.cb_setPeriodicReportTrigger_I == null)
        ReportTriggers.cb_setPeriodicReportTrigger_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(ReportTriggers.n_SetPeriodicReportTrigger_I));
      return ReportTriggers.cb_setPeriodicReportTrigger_I;
    }

    private static void n_SetPeriodicReportTrigger_I(
      IntPtr jnienv,
      IntPtr native__this,
      int periodicReportTrigger)
    {
      Object.GetObject<ReportTriggers>(jnienv, native__this, (JniHandleOwnership) 0).PeriodicReportTrigger = periodicReportTrigger;
    }

    public virtual unsafe int PeriodicReportTrigger
    {
      [Register("getPeriodicReportTrigger", "()I", "GetGetPeriodicReportTriggerHandler")] get
      {
        return ReportTriggers._members.InstanceMethods.InvokeVirtualInt32Method("getPeriodicReportTrigger.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPeriodicReportTrigger", "(I)V", "GetSetPeriodicReportTrigger_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ReportTriggers._members.InstanceMethods.InvokeVirtualVoidMethod("setPeriodicReportTrigger.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
