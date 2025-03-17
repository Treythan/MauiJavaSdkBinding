// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.IDcsSdkApiDelegateInvoker
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/IDcsSdkApiDelegate", DoNotGenerateAcw = true)]
  internal class IDcsSdkApiDelegateInvoker : 
    Object,
    IDcsSdkApiDelegate,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/IDcsSdkApiDelegate", typeof (IDcsSdkApiDelegateInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private IntPtr id_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private static Delegate? cb_dcssdkEventBarcode_arrayBII;
    private IntPtr id_dcssdkEventBarcode_arrayBII;
    private static Delegate? cb_dcssdkEventBinaryData_arrayBI;
    private IntPtr id_dcssdkEventBinaryData_arrayBI;
    private static Delegate? cb_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private IntPtr id_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private static Delegate? cb_dcssdkEventCommunicationSessionTerminated_I;
    private IntPtr id_dcssdkEventCommunicationSessionTerminated_I;
    private static Delegate? cb_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_;
    private IntPtr id_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_;
    private static Delegate? cb_dcssdkEventImage_arrayBI;
    private IntPtr id_dcssdkEventImage_arrayBI;
    private static Delegate? cb_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private IntPtr id_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    private static Delegate? cb_dcssdkEventScannerDisappeared_I;
    private IntPtr id_dcssdkEventScannerDisappeared_I;
    private static Delegate? cb_dcssdkEventVideo_arrayBI;
    private IntPtr id_dcssdkEventVideo_arrayBI;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IDcsSdkApiDelegateInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IDcsSdkApiDelegateInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IDcsSdkApiDelegateInvoker._members.ManagedPeerType;

    public static IDcsSdkApiDelegate? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IDcsSdkApiDelegate>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IDcsSdkApiDelegateInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.scannercontrol.IDcsSdkApiDelegate'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IDcsSdkApiDelegateInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IDcsSdkApiDelegateInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetDcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_ == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    }

    private static void n_DcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      IntPtr native_p1)
    {
      IDcsSdkApiDelegate dcsSdkApiDelegate = Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0);
      DCSScannerInfo dcsScannerInfo1 = Object.GetObject<DCSScannerInfo>(native_p0, (JniHandleOwnership) 0);
      DCSScannerInfo dcsScannerInfo2 = Object.GetObject<DCSScannerInfo>(native_p1, (JniHandleOwnership) 0);
      DCSScannerInfo p0 = dcsScannerInfo1;
      DCSScannerInfo p1 = dcsScannerInfo2;
      dcsSdkApiDelegate.DcssdkEventAuxScannerAppeared(p0, p1);
    }

    public unsafe void DcssdkEventAuxScannerAppeared(DCSScannerInfo? p0, DCSScannerInfo? p1)
    {
      if (this.id_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_ == IntPtr.Zero)
        this.id_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventAuxScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;Lcom/zebra/scannercontrol/DCSScannerInfo;)V");
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle),
        new JValue(p1 == null ? IntPtr.Zero : p1.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventAuxScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Lcom_zebra_scannercontrol_DCSScannerInfo_, jvaluePtr);
    }

    private static Delegate GetDcssdkEventBarcode_arrayBIIHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventBarcode_arrayBII == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventBarcode_arrayBII = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLII_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventBarcode_arrayBII));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventBarcode_arrayBII;
    }

    private static void n_DcssdkEventBarcode_arrayBII(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1,
      int p2)
    {
      IDcsSdkApiDelegate dcsSdkApiDelegate = Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      int p2_1 = p2;
      dcsSdkApiDelegate.DcssdkEventBarcode(p0, p1_1, p2_1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    public unsafe void DcssdkEventBarcode(byte[]? p0, int p1, int p2)
    {
      if (this.id_dcssdkEventBarcode_arrayBII == IntPtr.Zero)
        this.id_dcssdkEventBarcode_arrayBII = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventBarcode", "([BII)V");
      IntPtr num = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[3]
      {
        new JValue(num),
        new JValue(p1),
        new JValue(p2)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventBarcode_arrayBII, jvaluePtr);
      if (p0 == null)
        return;
      JNIEnv.CopyArray(num, p0);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetDcssdkEventBinaryData_arrayBIHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventBinaryData_arrayBI == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventBinaryData_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventBinaryData_arrayBI));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventBinaryData_arrayBI;
    }

    private static void n_DcssdkEventBinaryData_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      IDcsSdkApiDelegate dcsSdkApiDelegate = Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      dcsSdkApiDelegate.DcssdkEventBinaryData(p0, p1_1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    public unsafe void DcssdkEventBinaryData(byte[]? p0, int p1)
    {
      if (this.id_dcssdkEventBinaryData_arrayBI == IntPtr.Zero)
        this.id_dcssdkEventBinaryData_arrayBI = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventBinaryData", "([BI)V");
      IntPtr num = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(num),
        new JValue(p1)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventBinaryData_arrayBI, jvaluePtr);
      if (p0 == null)
        return;
      JNIEnv.CopyArray(num, p0);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetDcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_ == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    }

    private static void n_DcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEventCommunicationSessionEstablished(Object.GetObject<DCSScannerInfo>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void DcssdkEventCommunicationSessionEstablished(DCSScannerInfo? p0)
    {
      if (this.id_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_ == IntPtr.Zero)
        this.id_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventCommunicationSessionEstablished", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventCommunicationSessionEstablished_Lcom_zebra_scannercontrol_DCSScannerInfo_, jvaluePtr);
    }

    private static Delegate GetDcssdkEventCommunicationSessionTerminated_IHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionTerminated_I == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionTerminated_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventCommunicationSessionTerminated_I));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventCommunicationSessionTerminated_I;
    }

    private static void n_DcssdkEventCommunicationSessionTerminated_I(
      IntPtr jnienv,
      IntPtr native__this,
      int p0)
    {
      Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEventCommunicationSessionTerminated(p0);
    }

    public unsafe void DcssdkEventCommunicationSessionTerminated(int p0)
    {
      if (this.id_dcssdkEventCommunicationSessionTerminated_I == IntPtr.Zero)
        this.id_dcssdkEventCommunicationSessionTerminated_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventCommunicationSessionTerminated", "(I)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventCommunicationSessionTerminated_I, jvaluePtr);
    }

    private static Delegate GetDcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_Handler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_ == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_;
    }

    private static void n_DcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEventFirmwareUpdate(Object.GetObject<FirmwareUpdateEvent>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void DcssdkEventFirmwareUpdate(FirmwareUpdateEvent? p0)
    {
      if (this.id_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_ == IntPtr.Zero)
        this.id_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventFirmwareUpdate", "(Lcom/zebra/scannercontrol/FirmwareUpdateEvent;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventFirmwareUpdate_Lcom_zebra_scannercontrol_FirmwareUpdateEvent_, jvaluePtr);
    }

    private static Delegate GetDcssdkEventImage_arrayBIHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventImage_arrayBI == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventImage_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventImage_arrayBI));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventImage_arrayBI;
    }

    private static void n_DcssdkEventImage_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      IDcsSdkApiDelegate dcsSdkApiDelegate = Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      dcsSdkApiDelegate.DcssdkEventImage(p0, p1_1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    public unsafe void DcssdkEventImage(byte[]? p0, int p1)
    {
      if (this.id_dcssdkEventImage_arrayBI == IntPtr.Zero)
        this.id_dcssdkEventImage_arrayBI = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventImage", "([BI)V");
      IntPtr num = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(num),
        new JValue(p1)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventImage_arrayBI, jvaluePtr);
      if (p0 == null)
        return;
      JNIEnv.CopyArray(num, p0);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetDcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_Handler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_ == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_;
    }

    private static void n_DcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEventScannerAppeared(Object.GetObject<DCSScannerInfo>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void DcssdkEventScannerAppeared(DCSScannerInfo? p0)
    {
      if (this.id_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_ == IntPtr.Zero)
        this.id_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_ = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventScannerAppeared", "(Lcom/zebra/scannercontrol/DCSScannerInfo;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : p0.Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventScannerAppeared_Lcom_zebra_scannercontrol_DCSScannerInfo_, jvaluePtr);
    }

    private static Delegate GetDcssdkEventScannerDisappeared_IHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerDisappeared_I == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerDisappeared_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventScannerDisappeared_I));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventScannerDisappeared_I;
    }

    private static void n_DcssdkEventScannerDisappeared_I(
      IntPtr jnienv,
      IntPtr native__this,
      int p0)
    {
      Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0).DcssdkEventScannerDisappeared(p0);
    }

    public unsafe void DcssdkEventScannerDisappeared(int p0)
    {
      if (this.id_dcssdkEventScannerDisappeared_I == IntPtr.Zero)
        this.id_dcssdkEventScannerDisappeared_I = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventScannerDisappeared", "(I)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventScannerDisappeared_I, jvaluePtr);
    }

    private static Delegate GetDcssdkEventVideo_arrayBIHandler()
    {
      if ((object) IDcsSdkApiDelegateInvoker.cb_dcssdkEventVideo_arrayBI == null)
        IDcsSdkApiDelegateInvoker.cb_dcssdkEventVideo_arrayBI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLI_V(IDcsSdkApiDelegateInvoker.n_DcssdkEventVideo_arrayBI));
      return IDcsSdkApiDelegateInvoker.cb_dcssdkEventVideo_arrayBI;
    }

    private static void n_DcssdkEventVideo_arrayBI(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0,
      int p1)
    {
      IDcsSdkApiDelegate dcsSdkApiDelegate = Object.GetObject<IDcsSdkApiDelegate>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      int p1_1 = p1;
      dcsSdkApiDelegate.DcssdkEventVideo(p0, p1_1);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    public unsafe void DcssdkEventVideo(byte[]? p0, int p1)
    {
      if (this.id_dcssdkEventVideo_arrayBI == IntPtr.Zero)
        this.id_dcssdkEventVideo_arrayBI = JNIEnv.GetMethodID(this.class_ref, "dcssdkEventVideo", "([BI)V");
      IntPtr num = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[2]
      {
        new JValue(num),
        new JValue(p1)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_dcssdkEventVideo_arrayBI, jvaluePtr);
      if (p0 == null)
        return;
      JNIEnv.CopyArray(num, p0);
      JNIEnv.DeleteLocalRef(num);
    }
  }
}
