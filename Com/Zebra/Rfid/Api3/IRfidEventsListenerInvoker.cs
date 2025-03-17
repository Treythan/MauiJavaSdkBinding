// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker
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
  [Register("com/zebra/rfid/api3/RfidEventsListener", DoNotGenerateAcw = true)]
  internal class IRfidEventsListenerInvoker : 
    Object,
    IRfidEventsListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RfidEventsListener", typeof (IRfidEventsListenerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_;
    private IntPtr id_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_;
    private static Delegate? cb_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_;
    private IntPtr id_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IRfidEventsListenerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IRfidEventsListenerInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IRfidEventsListenerInvoker._members.ManagedPeerType;

    public static IRfidEventsListener? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IRfidEventsListener>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IRfidEventsListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.RfidEventsListener'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IRfidEventsListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IRfidEventsListenerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetEventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_Handler()
    {
      if ((object) IRfidEventsListenerInvoker.cb_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_ == null)
        IRfidEventsListenerInvoker.cb_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IRfidEventsListenerInvoker.n_EventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_));
      return IRfidEventsListenerInvoker.cb_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_;
    }

    private static void n_EventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IRfidEventsListener>(jnienv, native__this, (JniHandleOwnership) 0).EventReadNotify(Object.GetObject<RfidReadEvents>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void EventReadNotify(RfidReadEvents? p0)
    {
      if (this.id_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_ == IntPtr.Zero)
        this.id_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_ = JNIEnv.GetMethodID(this.class_ref, "eventReadNotify", "(Lcom/zebra/rfid/api3/RfidReadEvents;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_eventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_, jvaluePtr);
    }

    private static Delegate GetEventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_Handler()
    {
      if ((object) IRfidEventsListenerInvoker.cb_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_ == null)
        IRfidEventsListenerInvoker.cb_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IRfidEventsListenerInvoker.n_EventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_));
      return IRfidEventsListenerInvoker.cb_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_;
    }

    private static void n_EventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IRfidEventsListener>(jnienv, native__this, (JniHandleOwnership) 0).EventStatusNotify(Object.GetObject<RfidStatusEvents>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void EventStatusNotify(RfidStatusEvents? p0)
    {
      if (this.id_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_ == IntPtr.Zero)
        this.id_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_ = JNIEnv.GetMethodID(this.class_ref, "eventStatusNotify", "(Lcom/zebra/rfid/api3/RfidStatusEvents;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_eventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_, jvaluePtr);
    }
  }
}
