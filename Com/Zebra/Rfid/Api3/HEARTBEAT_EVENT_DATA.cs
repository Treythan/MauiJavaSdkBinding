// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.HEARTBEAT_EVENT_DATA
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/HEARTBEAT_EVENT_DATA", DoNotGenerateAcw = true)]
  public class HEARTBEAT_EVENT_DATA : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/HEARTBEAT_EVENT_DATA", typeof (HEARTBEAT_EVENT_DATA));
    private static Delegate? cb_getHeartbeatObject;
    private static Delegate? cb_setStatus_Lorg_json_JSONObject_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = HEARTBEAT_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => HEARTBEAT_EVENT_DATA._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = HEARTBEAT_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => HEARTBEAT_EVENT_DATA._members.ManagedPeerType;

    protected HEARTBEAT_EVENT_DATA(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe HEARTBEAT_EVENT_DATA()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = HEARTBEAT_EVENT_DATA._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      HEARTBEAT_EVENT_DATA._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetHeartbeatObjectHandler()
    {
      if ((object) HEARTBEAT_EVENT_DATA.cb_getHeartbeatObject == null)
        HEARTBEAT_EVENT_DATA.cb_getHeartbeatObject = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(HEARTBEAT_EVENT_DATA.n_GetHeartbeatObject));
      return HEARTBEAT_EVENT_DATA.cb_getHeartbeatObject;
    }

    private static IntPtr n_GetHeartbeatObject(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<HEARTBEAT_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).HeartbeatObject);
    }

    public virtual unsafe JSONObject? HeartbeatObject
    {
      [Register("getHeartbeatObject", "()Lorg/json/JSONObject;", "GetGetHeartbeatObjectHandler")] get
      {
        JniObjectReference jniObjectReference = HEARTBEAT_EVENT_DATA._members.InstanceMethods.InvokeVirtualObjectMethod("getHeartbeatObject.()Lorg/json/JSONObject;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<JSONObject>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetSetStatus_Lorg_json_JSONObject_Handler()
    {
      if ((object) HEARTBEAT_EVENT_DATA.cb_setStatus_Lorg_json_JSONObject_ == null)
        HEARTBEAT_EVENT_DATA.cb_setStatus_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(HEARTBEAT_EVENT_DATA.n_SetStatus_Lorg_json_JSONObject_));
      return HEARTBEAT_EVENT_DATA.cb_setStatus_Lorg_json_JSONObject_;
    }

    private static void n_SetStatus_Lorg_json_JSONObject_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_heartbeatObject)
    {
      Object.GetObject<HEARTBEAT_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).SetStatus(Object.GetObject<JSONObject>(native_heartbeatObject, (JniHandleOwnership) 0));
    }

    [Register("setStatus", "(Lorg/json/JSONObject;)V", "GetSetStatus_Lorg_json_JSONObject_Handler")]
    public virtual unsafe void SetStatus(JSONObject? heartbeatObject)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(heartbeatObject == null ? IntPtr.Zero : ((Object) heartbeatObject).Handle)
        };
        HEARTBEAT_EVENT_DATA._members.InstanceMethods.InvokeVirtualVoidMethod("setStatus.(Lorg/json/JSONObject;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) heartbeatObject);
      }
    }
  }
}
