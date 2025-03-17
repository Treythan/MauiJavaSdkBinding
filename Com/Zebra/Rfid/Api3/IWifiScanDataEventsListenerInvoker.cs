// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IWifiScanDataEventsListenerInvoker
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
  [Register("com/zebra/rfid/api3/WifiScanDataEventsListener", DoNotGenerateAcw = true)]
  internal class IWifiScanDataEventsListenerInvoker : 
    Object,
    IWifiScanDataEventsListener,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WifiScanDataEventsListener", typeof (IWifiScanDataEventsListenerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_;
    private IntPtr id_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IWifiScanDataEventsListenerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IWifiScanDataEventsListenerInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType
    {
      get => IWifiScanDataEventsListenerInvoker._members.ManagedPeerType;
    }

    public static IWifiScanDataEventsListener? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IWifiScanDataEventsListener>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IWifiScanDataEventsListenerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.WifiScanDataEventsListener'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IWifiScanDataEventsListenerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IWifiScanDataEventsListenerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetEventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_Handler()
    {
      if ((object) IWifiScanDataEventsListenerInvoker.cb_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_ == null)
        IWifiScanDataEventsListenerInvoker.cb_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IWifiScanDataEventsListenerInvoker.n_EventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_));
      return IWifiScanDataEventsListenerInvoker.cb_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_;
    }

    private static void n_EventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IWifiScanDataEventsListener>(jnienv, native__this, (JniHandleOwnership) 0).EventWifiScanNotify(Object.GetObject<RfidWifiScanEvents>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void EventWifiScanNotify(RfidWifiScanEvents? p0)
    {
      if (this.id_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_ == IntPtr.Zero)
        this.id_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_ = JNIEnv.GetMethodID(this.class_ref, "eventWifiScanNotify", "(Lcom/zebra/rfid/api3/RfidWifiScanEvents;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_eventWifiScanNotify_Lcom_zebra_rfid_api3_RfidWifiScanEvents_, jvaluePtr);
    }
  }
}
