// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RfidReadEvents
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
  [Register("com/zebra/rfid/api3/RfidReadEvents", DoNotGenerateAcw = true)]
  public class RfidReadEvents : EventObject
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RfidReadEvents", typeof (RfidReadEvents));
    private static Delegate? cb_getReadEventData;
    private static Delegate? cb_setReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RfidReadEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RfidReadEvents._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RfidReadEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RfidReadEvents._members.ManagedPeerType;

    protected RfidReadEvents(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/Object;)V", "")]
    public unsafe RfidReadEvents(Object? source)
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
        JniObjectReference instance = RfidReadEvents._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", ((object) this).GetType(), jniArgumentValuePtr);
        ((Object) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        RfidReadEvents._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) source);
      }
    }

    private static Delegate GetGetReadEventDataHandler()
    {
      if ((object) RfidReadEvents.cb_getReadEventData == null)
        RfidReadEvents.cb_getReadEventData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RfidReadEvents.n_GetReadEventData));
      return RfidReadEvents.cb_getReadEventData;
    }

    private static IntPtr n_GetReadEventData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RfidReadEvents>(jnienv, native__this, (JniHandleOwnership) 0).ReadEventData);
    }

    private static Delegate GetSetReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_Handler()
    {
      if ((object) RfidReadEvents.cb_setReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_ == null)
        RfidReadEvents.cb_setReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RfidReadEvents.n_SetReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_));
      return RfidReadEvents.cb_setReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_;
    }

    private static void n_SetReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readEventData)
    {
      Object.GetObject<RfidReadEvents>(jnienv, native__this, (JniHandleOwnership) 0).ReadEventData = Object.GetObject<IEvents.ReadEventData>(native_readEventData, (JniHandleOwnership) 0);
    }

    public virtual unsafe IEvents.ReadEventData? ReadEventData
    {
      [Register("getReadEventData", "()Lcom/zebra/rfid/api3/IEvents$ReadEventData;", "GetGetReadEventDataHandler")] get
      {
        JniObjectReference jniObjectReference = RfidReadEvents._members.InstanceMethods.InvokeVirtualObjectMethod("getReadEventData.()Lcom/zebra/rfid/api3/IEvents$ReadEventData;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<IEvents.ReadEventData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setReadEventData", "(Lcom/zebra/rfid/api3/IEvents$ReadEventData;)V", "GetSetReadEventData_Lcom_zebra_rfid_api3_IEvents_ReadEventData_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          RfidReadEvents._members.InstanceMethods.InvokeVirtualVoidMethod("setReadEventData.(Lcom/zebra/rfid/api3/IEvents$ReadEventData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }
  }
}
