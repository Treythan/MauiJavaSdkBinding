// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReadPoint
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
  [Register("com/zebra/rfid/api3/ReadPoint", DoNotGenerateAcw = true)]
  public class ReadPoint : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReadPoint", typeof (ReadPoint));
    private static Delegate? cb_getReadPointStatus_S;
    private static Delegate? cb_setReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReadPoint._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReadPoint._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReadPoint._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReadPoint._members.ManagedPeerType;

    protected ReadPoint(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetReadPointStatus_SHandler()
    {
      if ((object) ReadPoint.cb_getReadPointStatus_S == null)
        ReadPoint.cb_getReadPointStatus_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_L(ReadPoint.n_GetReadPointStatus_S));
      return ReadPoint.cb_getReadPointStatus_S;
    }

    private static IntPtr n_GetReadPointStatus_S(
      IntPtr jnienv,
      IntPtr native__this,
      short antennaID)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReadPoint>(jnienv, native__this, (JniHandleOwnership) 0).GetReadPointStatus(antennaID));
    }

    [Register("getReadPointStatus", "(S)Lcom/zebra/rfid/api3/READPOINT_STATUS;", "GetGetReadPointStatus_SHandler")]
    public virtual unsafe READPOINT_STATUS? GetReadPointStatus(short antennaID)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(antennaID)
      };
      JniObjectReference jniObjectReference = ReadPoint._members.InstanceMethods.InvokeVirtualObjectMethod("getReadPointStatus.(S)Lcom/zebra/rfid/api3/READPOINT_STATUS;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<READPOINT_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetSetReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_Handler()
    {
      if ((object) ReadPoint.cb_setReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_ == null)
        ReadPoint.cb_setReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPSL_V(ReadPoint.n_SetReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_));
      return ReadPoint.cb_setReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_;
    }

    private static void n_SetReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_(
      IntPtr jnienv,
      IntPtr native__this,
      short antennaID,
      IntPtr native_readpointStatus)
    {
      ReadPoint readPoint = Object.GetObject<ReadPoint>(jnienv, native__this, (JniHandleOwnership) 0);
      READPOINT_STATUS readpointStatus1 = Object.GetObject<READPOINT_STATUS>(native_readpointStatus, (JniHandleOwnership) 0);
      int antennaID1 = (int) antennaID;
      READPOINT_STATUS readpointStatus2 = readpointStatus1;
      readPoint.SetReadPointStatus((short) antennaID1, readpointStatus2);
    }

    [Register("setReadPointStatus", "(SLcom/zebra/rfid/api3/READPOINT_STATUS;)V", "GetSetReadPointStatus_SLcom_zebra_rfid_api3_READPOINT_STATUS_Handler")]
    public virtual unsafe void SetReadPointStatus(short antennaID, READPOINT_STATUS? readpointStatus)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(antennaID),
          new JniArgumentValue(readpointStatus == null ? IntPtr.Zero : readpointStatus.Handle)
        };
        ReadPoint._members.InstanceMethods.InvokeVirtualVoidMethod("setReadPointStatus.(SLcom/zebra/rfid/api3/READPOINT_STATUS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readpointStatus);
      }
    }
  }
}
