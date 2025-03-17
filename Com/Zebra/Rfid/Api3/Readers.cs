// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Readers
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/Readers", DoNotGenerateAcw = true)]
  public class Readers : IReaders, IReaderStatus, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Readers", typeof (Readers));
    private static Delegate? cb_GetAvailableRFIDReaderList;
    private static Delegate? cb_Dispose;
    private static Delegate? cb_setTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("mReaders")]
    public static Readers? MReaders
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("mReaders.Lcom/zebra/rfid/api3/Readers;");
        return Object.GetObject<Readers>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Readers._members.StaticFields.SetValue("mReaders.Lcom/zebra/rfid/api3/Readers;", new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("mScannerStatus")]
    protected static string? MScannerStatus
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("mScannerStatus.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Readers._members.StaticFields.SetValue("mScannerStatus.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("mScannerStatusReceived")]
    protected static bool MScannerStatusReceived
    {
      get => Readers._members.StaticFields.GetBooleanValue("mScannerStatusReceived.Z");
      set => Readers._members.StaticFields.SetValue("mScannerStatusReceived.Z", value);
    }

    [Register("m_scontext")]
    protected static Context? MScontext
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("m_scontext.Landroid/content/Context;");
        return Object.GetObject<Context>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Readers._members.StaticFields.SetValue("m_scontext.Landroid/content/Context;", new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("m_senum_transport")]
    protected static ENUM_TRANSPORT? MSenumTransport
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("m_senum_transport.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;");
        return Object.GetObject<ENUM_TRANSPORT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Readers._members.StaticFields.SetValue("m_senum_transport.Lcom/zebra/rfid/api3/ENUM_TRANSPORT;", new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("syncObject")]
    protected static Object? SyncObject
    {
      get
      {
        JniObjectReference objectValue = Readers._members.StaticFields.GetObjectValue("syncObject.Ljava/lang/Object;");
        return Object.GetObject<Object>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Readers._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Readers._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Readers._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Readers._members.ManagedPeerType;

    protected Readers(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Readers()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Readers._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Readers._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Landroid/content/Context;Lcom/zebra/rfid/api3/ENUM_TRANSPORT;)V", "")]
    public unsafe Readers(Context? context, ENUM_TRANSPORT? enum_transport)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(enum_transport == null ? IntPtr.Zero : ((Object) enum_transport).Handle)
        };
        JniObjectReference instance = Readers._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/zebra/rfid/api3/ENUM_TRANSPORT;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        Readers._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/zebra/rfid/api3/ENUM_TRANSPORT;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) context);
        GC.KeepAlive((object) enum_transport);
      }
    }

    private static Delegate GetGetAvailableRFIDReaderListHandler()
    {
      if ((object) Readers.cb_GetAvailableRFIDReaderList == null)
        Readers.cb_GetAvailableRFIDReaderList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Readers.n_GetAvailableRFIDReaderList));
      return Readers.cb_GetAvailableRFIDReaderList;
    }

    private static IntPtr n_GetAvailableRFIDReaderList(IntPtr jnienv, IntPtr native__this)
    {
      return JavaList<ReaderDevice>.ToLocalJniHandle(Object.GetObject<Readers>(jnienv, native__this, (JniHandleOwnership) 0).AvailableRFIDReaderList);
    }

    public virtual unsafe IList<ReaderDevice>? AvailableRFIDReaderList
    {
      [Register("GetAvailableRFIDReaderList", "()Ljava/util/ArrayList;", "GetGetAvailableRFIDReaderListHandler")] get
      {
        JniObjectReference jniObjectReference = Readers._members.InstanceMethods.InvokeVirtualObjectMethod("GetAvailableRFIDReaderList.()Ljava/util/ArrayList;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JavaList<ReaderDevice>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetDisposeHandler()
    {
      if ((object) Readers.cb_Dispose == null)
        Readers.cb_Dispose = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Readers.n_Dispose));
      return Readers.cb_Dispose;
    }

    private static void n_Dispose(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Readers>(jnienv, native__this, (JniHandleOwnership) 0).Dispose();
    }

    [Register("Dispose", "()V", "GetDisposeHandler")]
    public virtual unsafe void Dispose()
    {
      Readers._members.InstanceMethods.InvokeVirtualVoidMethod("Dispose.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("attach", "(Lcom/zebra/rfid/api3/Readers$RFIDReaderEventHandler;)V", "")]
    public static unsafe void Attach(
      Readers.IRFIDReaderEventHandler? rfidReaderEventHandler)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidReaderEventHandler == null ? IntPtr.Zero : ((Object) rfidReaderEventHandler).Handle)
        };
        Readers._members.StaticMethods.InvokeVoidMethod("attach.(Lcom/zebra/rfid/api3/Readers$RFIDReaderEventHandler;)V", jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidReaderEventHandler);
      }
    }

    [Register("deattach", "(Lcom/zebra/rfid/api3/Readers$RFIDReaderEventHandler;)V", "")]
    public static unsafe void Deattach(
      Readers.IRFIDReaderEventHandler? rfidReaderEventHandler)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidReaderEventHandler == null ? IntPtr.Zero : ((Object) rfidReaderEventHandler).Handle)
        };
        Readers._members.StaticMethods.InvokeVoidMethod("deattach.(Lcom/zebra/rfid/api3/Readers$RFIDReaderEventHandler;)V", jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidReaderEventHandler);
      }
    }

    private static Delegate GetSetTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_Handler()
    {
      if ((object) Readers.cb_setTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_ == null)
        Readers.cb_setTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Readers.n_SetTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_));
      return Readers.cb_setTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_;
    }

    private static void n_SetTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_enum_transport)
    {
      Object.GetObject<Readers>(jnienv, native__this, (JniHandleOwnership) 0).SetTransport(Object.GetObject<ENUM_TRANSPORT>(native_enum_transport, (JniHandleOwnership) 0));
    }

    [Register("setTransport", "(Lcom/zebra/rfid/api3/ENUM_TRANSPORT;)V", "GetSetTransport_Lcom_zebra_rfid_api3_ENUM_TRANSPORT_Handler")]
    public virtual unsafe void SetTransport(ENUM_TRANSPORT? enum_transport)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(enum_transport == null ? IntPtr.Zero : ((Object) enum_transport).Handle)
        };
        Readers._members.InstanceMethods.InvokeVirtualVoidMethod("setTransport.(Lcom/zebra/rfid/api3/ENUM_TRANSPORT;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) enum_transport);
      }
    }

    [Register("com/zebra/rfid/api3/Readers$RFIDReaderEventHandler", "", "Com.Zebra.Rfid.Api3.Readers/IRFIDReaderEventHandlerInvoker")]
    public interface IRFIDReaderEventHandler : IJavaObject, IDisposable, IJavaPeerable
    {
      [Register("RFIDReaderAppeared", "(Lcom/zebra/rfid/api3/ReaderDevice;)V", "GetRFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler:Com.Zebra.Rfid.Api3.Readers/IRFIDReaderEventHandlerInvoker, MauiJavaSdkBinding")]
      void RFIDReaderAppeared(ReaderDevice? p0);

      [Register("RFIDReaderDisappeared", "(Lcom/zebra/rfid/api3/ReaderDevice;)V", "GetRFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler:Com.Zebra.Rfid.Api3.Readers/IRFIDReaderEventHandlerInvoker, MauiJavaSdkBinding")]
      void RFIDReaderDisappeared(ReaderDevice? p0);
    }

    [Register("com/zebra/rfid/api3/Readers$RFIDReaderEventHandler", DoNotGenerateAcw = true)]
    internal class IRFIDReaderEventHandlerInvoker : 
      Object,
      Readers.IRFIDReaderEventHandler,
      IJavaObject,
      IDisposable,
      IJavaPeerable
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Readers$RFIDReaderEventHandler", typeof (Readers.IRFIDReaderEventHandlerInvoker));
      private IntPtr class_ref;
      private static Delegate? cb_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_;
      private IntPtr id_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_;
      private static Delegate? cb_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_;
      private IntPtr id_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_;

      private static IntPtr java_class_ref
      {
        get
        {
          JniObjectReference peerReference = Readers.IRFIDReaderEventHandlerInvoker._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers
      {
        get => Readers.IRFIDReaderEventHandlerInvoker._members;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass => this.class_ref;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => Readers.IRFIDReaderEventHandlerInvoker._members.ManagedPeerType;
      }

      public static Readers.IRFIDReaderEventHandler? GetObject(
        IntPtr handle,
        JniHandleOwnership transfer)
      {
        return Object.GetObject<Readers.IRFIDReaderEventHandler>(handle, transfer);
      }

      private static IntPtr Validate(IntPtr handle)
      {
        return JNIEnv.IsInstanceOf(handle, Readers.IRFIDReaderEventHandlerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.Readers.RFIDReaderEventHandler'.");
      }

      protected virtual void Dispose(bool disposing)
      {
        if (this.class_ref != IntPtr.Zero)
          JNIEnv.DeleteGlobalRef(this.class_ref);
        this.class_ref = IntPtr.Zero;
        base.Dispose(disposing);
      }

      public IRFIDReaderEventHandlerInvoker(IntPtr handle, JniHandleOwnership transfer)
        : base(Readers.IRFIDReaderEventHandlerInvoker.Validate(handle), transfer)
      {
        IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
        this.class_ref = JNIEnv.NewGlobalRef(objectClass);
        JNIEnv.DeleteLocalRef(objectClass);
      }

      private static Delegate GetRFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler()
      {
        if ((object) Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_ == null)
          Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Readers.IRFIDReaderEventHandlerInvoker.n_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_));
        return Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_;
      }

      private static void n_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_p0)
      {
        Object.GetObject<Readers.IRFIDReaderEventHandler>(jnienv, native__this, (JniHandleOwnership) 0).RFIDReaderAppeared(Object.GetObject<ReaderDevice>(native_p0, (JniHandleOwnership) 0));
      }

      public unsafe void RFIDReaderAppeared(ReaderDevice? p0)
      {
        if (this.id_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_ == IntPtr.Zero)
          this.id_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_ = JNIEnv.GetMethodID(this.class_ref, nameof (RFIDReaderAppeared), "(Lcom/zebra/rfid/api3/ReaderDevice;)V");
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_RFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_, jvaluePtr);
      }

      private static Delegate GetRFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler()
      {
        if ((object) Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_ == null)
          Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Readers.IRFIDReaderEventHandlerInvoker.n_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_));
        return Readers.IRFIDReaderEventHandlerInvoker.cb_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_;
      }

      private static void n_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_p0)
      {
        Object.GetObject<Readers.IRFIDReaderEventHandler>(jnienv, native__this, (JniHandleOwnership) 0).RFIDReaderDisappeared(Object.GetObject<ReaderDevice>(native_p0, (JniHandleOwnership) 0));
      }

      public unsafe void RFIDReaderDisappeared(ReaderDevice? p0)
      {
        if (this.id_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_ == IntPtr.Zero)
          this.id_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_ = JNIEnv.GetMethodID(this.class_ref, nameof (RFIDReaderDisappeared), "(Lcom/zebra/rfid/api3/ReaderDevice;)V");
        JValue* jvaluePtr = stackalloc JValue[1]
        {
          new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
        };
        JNIEnv.CallVoidMethod(this.Handle, this.id_RFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_, jvaluePtr);
      }
    }
  }
}
