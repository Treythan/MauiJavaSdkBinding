// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RfidWifiScanEvents
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
  [Register("com/zebra/rfid/api3/RfidWifiScanEvents", DoNotGenerateAcw = true)]
  public class RfidWifiScanEvents : EventObject
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RfidWifiScanEvents", typeof (RfidWifiScanEvents));
    private static Delegate? cb_getWifiScanEventData;
    private static Delegate? cb_setWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RfidWifiScanEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RfidWifiScanEvents._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RfidWifiScanEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RfidWifiScanEvents._members.ManagedPeerType;

    protected RfidWifiScanEvents(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/Object;)V", "")]
    public unsafe RfidWifiScanEvents(Object? source)
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
        JniObjectReference instance = RfidWifiScanEvents._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", ((object) this).GetType(), jniArgumentValuePtr);
        ((Object) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RfidWifiScanEvents._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) source);
      }
    }

    private static Delegate GetGetWifiScanEventDataHandler()
    {
      if ((object) RfidWifiScanEvents.cb_getWifiScanEventData == null)
        RfidWifiScanEvents.cb_getWifiScanEventData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RfidWifiScanEvents.n_GetWifiScanEventData));
      return RfidWifiScanEvents.cb_getWifiScanEventData;
    }

    private static IntPtr n_GetWifiScanEventData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RfidWifiScanEvents>(jnienv, native__this, (JniHandleOwnership) 0).WifiScanEventData);
    }

    public virtual unsafe IEvents.WifiScanEventData? WifiScanEventData
    {
      [Register("getWifiScanEventData", "()Lcom/zebra/rfid/api3/IEvents$WifiScanEventData;", "GetGetWifiScanEventDataHandler")] get
      {
        JniObjectReference jniObjectReference = RfidWifiScanEvents._members.InstanceMethods.InvokeVirtualObjectMethod("getWifiScanEventData.()Lcom/zebra/rfid/api3/IEvents$WifiScanEventData;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<IEvents.WifiScanEventData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetSetWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_Handler()
    {
      if ((object) RfidWifiScanEvents.cb_setWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_ == null)
        RfidWifiScanEvents.cb_setWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RfidWifiScanEvents.n_SetWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_));
      return RfidWifiScanEvents.cb_setWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_;
    }

    private static void n_SetWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readEventData)
    {
      Object.GetObject<RfidWifiScanEvents>(jnienv, native__this, (JniHandleOwnership) 0).SetWifiScanEventtData(Object.GetObject<IEvents.WifiScanEventData>(native_readEventData, (JniHandleOwnership) 0));
    }

    [Register("setWifiScanEventtData", "(Lcom/zebra/rfid/api3/IEvents$WifiScanEventData;)V", "GetSetWifiScanEventtData_Lcom_zebra_rfid_api3_IEvents_WifiScanEventData_Handler")]
    public virtual unsafe void SetWifiScanEventtData(IEvents.WifiScanEventData? readEventData)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(readEventData == null ? IntPtr.Zero : readEventData.Handle)
        };
        RfidWifiScanEvents._members.InstanceMethods.InvokeVirtualVoidMethod("setWifiScanEventtData.(Lcom/zebra/rfid/api3/IEvents$WifiScanEventData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readEventData);
      }
    }
  }
}
