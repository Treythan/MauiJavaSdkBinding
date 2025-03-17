// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TriggerInfo
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
  [Register("com/zebra/rfid/api3/TriggerInfo", DoNotGenerateAcw = true)]
  public class TriggerInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TriggerInfo", typeof (TriggerInfo));
    private static Delegate? cb_isEnableTagEventReport;
    private static Delegate? cb_setEnableTagEventReport_Z;
    private static Delegate? cb_getTagReportTrigger;
    private static Delegate? cb_setTagReportTrigger_I;

    [Register("ReportTriggers")]
    public ReportTriggers? ReportTriggers
    {
      get
      {
        JniObjectReference objectValue = TriggerInfo._members.InstanceFields.GetObjectValue("ReportTriggers.Lcom/zebra/rfid/api3/ReportTriggers;", (IJavaPeerable) this);
        return Object.GetObject<ReportTriggers>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TriggerInfo._members.InstanceFields.SetValue("ReportTriggers.Lcom/zebra/rfid/api3/ReportTriggers;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("StartTrigger")]
    public StartTrigger? StartTrigger
    {
      get
      {
        JniObjectReference objectValue = TriggerInfo._members.InstanceFields.GetObjectValue("StartTrigger.Lcom/zebra/rfid/api3/StartTrigger;", (IJavaPeerable) this);
        return Object.GetObject<StartTrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TriggerInfo._members.InstanceFields.SetValue("StartTrigger.Lcom/zebra/rfid/api3/StartTrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("StopTrigger")]
    public StopTrigger? StopTrigger
    {
      get
      {
        JniObjectReference objectValue = TriggerInfo._members.InstanceFields.GetObjectValue("StopTrigger.Lcom/zebra/rfid/api3/StopTrigger;", (IJavaPeerable) this);
        return Object.GetObject<StopTrigger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          TriggerInfo._members.InstanceFields.SetValue("StopTrigger.Lcom/zebra/rfid/api3/StopTrigger;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TriggerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TriggerInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TriggerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TriggerInfo._members.ManagedPeerType;

    protected TriggerInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TriggerInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TriggerInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TriggerInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/StartTrigger;Lcom/zebra/rfid/api3/StopTrigger;ILcom/zebra/rfid/api3/ReportTriggers;)V", "")]
    public unsafe TriggerInfo(
      StartTrigger? startTrigger,
      StopTrigger? stopTrigger,
      int tagReportTrigger,
      ReportTriggers? reportTriggers)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(startTrigger == null ? IntPtr.Zero : startTrigger.Handle),
          new JniArgumentValue(stopTrigger == null ? IntPtr.Zero : stopTrigger.Handle),
          new JniArgumentValue(tagReportTrigger),
          new JniArgumentValue(reportTriggers == null ? IntPtr.Zero : reportTriggers.Handle)
        };
        JniObjectReference instance = TriggerInfo._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/StartTrigger;Lcom/zebra/rfid/api3/StopTrigger;ILcom/zebra/rfid/api3/ReportTriggers;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        TriggerInfo._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/StartTrigger;Lcom/zebra/rfid/api3/StopTrigger;ILcom/zebra/rfid/api3/ReportTriggers;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) startTrigger);
        GC.KeepAlive((object) stopTrigger);
        GC.KeepAlive((object) reportTriggers);
      }
    }

    private static Delegate GetIsEnableTagEventReportHandler()
    {
      if ((object) TriggerInfo.cb_isEnableTagEventReport == null)
        TriggerInfo.cb_isEnableTagEventReport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TriggerInfo.n_IsEnableTagEventReport));
      return TriggerInfo.cb_isEnableTagEventReport;
    }

    private static bool n_IsEnableTagEventReport(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TriggerInfo>(jnienv, native__this, (JniHandleOwnership) 0).EnableTagEventReport;
    }

    private static Delegate GetSetEnableTagEventReport_ZHandler()
    {
      if ((object) TriggerInfo.cb_setEnableTagEventReport_Z == null)
        TriggerInfo.cb_setEnableTagEventReport_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(TriggerInfo.n_SetEnableTagEventReport_Z));
      return TriggerInfo.cb_setEnableTagEventReport_Z;
    }

    private static void n_SetEnableTagEventReport_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enableTagEventReport)
    {
      Object.GetObject<TriggerInfo>(jnienv, native__this, (JniHandleOwnership) 0).EnableTagEventReport = enableTagEventReport;
    }

    public virtual unsafe bool EnableTagEventReport
    {
      [Register("isEnableTagEventReport", "()Z", "GetIsEnableTagEventReportHandler")] get
      {
        return TriggerInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnableTagEventReport.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setEnableTagEventReport", "(Z)V", "GetSetEnableTagEventReport_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TriggerInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setEnableTagEventReport.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTagReportTriggerHandler()
    {
      if ((object) TriggerInfo.cb_getTagReportTrigger == null)
        TriggerInfo.cb_getTagReportTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TriggerInfo.n_GetTagReportTrigger));
      return TriggerInfo.cb_getTagReportTrigger;
    }

    private static int n_GetTagReportTrigger(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TriggerInfo>(jnienv, native__this, (JniHandleOwnership) 0).TagReportTrigger;
    }

    private static Delegate GetSetTagReportTrigger_IHandler()
    {
      if ((object) TriggerInfo.cb_setTagReportTrigger_I == null)
        TriggerInfo.cb_setTagReportTrigger_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TriggerInfo.n_SetTagReportTrigger_I));
      return TriggerInfo.cb_setTagReportTrigger_I;
    }

    private static void n_SetTagReportTrigger_I(
      IntPtr jnienv,
      IntPtr native__this,
      int tagReportTrigger)
    {
      Object.GetObject<TriggerInfo>(jnienv, native__this, (JniHandleOwnership) 0).TagReportTrigger = tagReportTrigger;
    }

    public virtual unsafe int TagReportTrigger
    {
      [Register("getTagReportTrigger", "()I", "GetGetTagReportTriggerHandler")] get
      {
        return TriggerInfo._members.InstanceMethods.InvokeVirtualInt32Method("getTagReportTrigger.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagReportTrigger", "(I)V", "GetSetTagReportTrigger_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TriggerInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setTagReportTrigger.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
