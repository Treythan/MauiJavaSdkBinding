// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.PeriodicTrigger
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
  [Register("com/zebra/rfid/api3/PeriodicTrigger", DoNotGenerateAcw = true)]
  public class PeriodicTrigger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/PeriodicTrigger", typeof (PeriodicTrigger));
    private static Delegate? cb_getPeriod;
    private static Delegate? cb_setPeriod_I;

    [Register("StartTime")]
    public SYSTEMTIME? StartTime
    {
      get
      {
        JniObjectReference objectValue = PeriodicTrigger._members.InstanceFields.GetObjectValue("StartTime.Lcom/zebra/rfid/api3/SYSTEMTIME;", (IJavaPeerable) this);
        return Object.GetObject<SYSTEMTIME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          PeriodicTrigger._members.InstanceFields.SetValue("StartTime.Lcom/zebra/rfid/api3/SYSTEMTIME;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = PeriodicTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => PeriodicTrigger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = PeriodicTrigger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => PeriodicTrigger._members.ManagedPeerType;

    protected PeriodicTrigger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetPeriodHandler()
    {
      if ((object) PeriodicTrigger.cb_getPeriod == null)
        PeriodicTrigger.cb_getPeriod = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(PeriodicTrigger.n_GetPeriod));
      return PeriodicTrigger.cb_getPeriod;
    }

    private static int n_GetPeriod(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<PeriodicTrigger>(jnienv, native__this, (JniHandleOwnership) 0).Period;
    }

    private static Delegate GetSetPeriod_IHandler()
    {
      if ((object) PeriodicTrigger.cb_setPeriod_I == null)
        PeriodicTrigger.cb_setPeriod_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(PeriodicTrigger.n_SetPeriod_I));
      return PeriodicTrigger.cb_setPeriod_I;
    }

    private static void n_SetPeriod_I(IntPtr jnienv, IntPtr native__this, int period)
    {
      Object.GetObject<PeriodicTrigger>(jnienv, native__this, (JniHandleOwnership) 0).Period = period;
    }

    public virtual unsafe int Period
    {
      [Register("getPeriod", "()I", "GetGetPeriodHandler")] get
      {
        return PeriodicTrigger._members.InstanceMethods.InvokeVirtualInt32Method("getPeriod.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPeriod", "(I)V", "GetSetPeriod_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        PeriodicTrigger._members.InstanceMethods.InvokeVirtualVoidMethod("setPeriod.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
