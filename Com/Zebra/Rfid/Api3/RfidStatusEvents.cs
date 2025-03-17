// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RfidStatusEvents
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/RfidStatusEvents", DoNotGenerateAcw = true)]
  public class RfidStatusEvents : EventObject
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RfidStatusEvents", typeof (RfidStatusEvents));
    private static Delegate? cb_setStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_;

    [Register("StatusEventData")]
    public IEvents.StatusEventData? StatusEventData
    {
      get
      {
        JniObjectReference objectValue = RfidStatusEvents._members.InstanceFields.GetObjectValue("StatusEventData.Lcom/zebra/rfid/api3/IEvents$StatusEventData;", (IJavaPeerable) this);
        return Object.GetObject<IEvents.StatusEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          RfidStatusEvents._members.InstanceFields.SetValue("StatusEventData.Lcom/zebra/rfid/api3/IEvents$StatusEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = RfidStatusEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RfidStatusEvents._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RfidStatusEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RfidStatusEvents._members.ManagedPeerType;

    protected RfidStatusEvents(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/Object;)V", "")]
    public unsafe RfidStatusEvents(Object? source)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (((Object) this).Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(source == null ? IntPtr.Zero : source.Handle)
        };
        JniObjectReference instance = RfidStatusEvents._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", ((object) this).GetType(), jniArgumentValuePtr);
        ((Object) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RfidStatusEvents._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) source);
      }
    }

    private static Delegate GetSetStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_Handler()
    {
      if ((object) RfidStatusEvents.cb_setStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_ == null)
        RfidStatusEvents.cb_setStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RfidStatusEvents.n_SetStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_));
      return RfidStatusEvents.cb_setStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_;
    }

    private static void n_SetStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_statusEventData)
    {
      Object.GetObject<RfidStatusEvents>(jnienv, native__this, (JniHandleOwnership) 0).SetStatusEventData(Object.GetObject<IEvents.StatusEventData>(native_statusEventData, (JniHandleOwnership) 0));
    }

    [Register("setStatusEventData", "(Lcom/zebra/rfid/api3/IEvents$StatusEventData;)V", "GetSetStatusEventData_Lcom_zebra_rfid_api3_IEvents_StatusEventData_Handler")]
    public virtual unsafe void SetStatusEventData(IEvents.StatusEventData? statusEventData)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(statusEventData == null ? IntPtr.Zero : statusEventData.Handle)
        };
        RfidStatusEvents._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusEventData.(Lcom/zebra/rfid/api3/IEvents$StatusEventData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) statusEventData);
      }
    }
  }
}
