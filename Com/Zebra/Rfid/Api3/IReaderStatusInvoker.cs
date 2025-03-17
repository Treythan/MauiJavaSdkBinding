// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IReaderStatusInvoker
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
  [Register("com/zebra/rfid/api3/IReaderStatus", DoNotGenerateAcw = true)]
  internal class IReaderStatusInvoker : 
    Object,
    IReaderStatus,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IReaderStatus", typeof (IReaderStatusInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_USBDeviceAttached_Ljava_lang_String_;
    private IntPtr id_USBDeviceAttached_Ljava_lang_String_;
    private static Delegate? cb_USBDeviceDeAttached_Ljava_lang_String_;
    private IntPtr id_USBDeviceDeAttached_Ljava_lang_String_;
    private static Delegate? cb_readerAvailable_Ljava_lang_String_;
    private IntPtr id_readerAvailable_Ljava_lang_String_;
    private static Delegate? cb_readerDisappeared_Ljava_lang_String_;
    private IntPtr id_readerDisappeared_Ljava_lang_String_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IReaderStatusInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IReaderStatusInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IReaderStatusInvoker._members.ManagedPeerType;

    public static IReaderStatus? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IReaderStatus>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IReaderStatusInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.rfid.api3.IReaderStatus'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IReaderStatusInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IReaderStatusInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetUSBDeviceAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaderStatusInvoker.cb_USBDeviceAttached_Ljava_lang_String_ == null)
        IReaderStatusInvoker.cb_USBDeviceAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaderStatusInvoker.n_USBDeviceAttached_Ljava_lang_String_));
      return IReaderStatusInvoker.cb_USBDeviceAttached_Ljava_lang_String_;
    }

    private static void n_USBDeviceAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IReaderStatus>(jnienv, native__this, (JniHandleOwnership) 0).USBDeviceAttached(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void USBDeviceAttached(string? p0)
    {
      if (this.id_USBDeviceAttached_Ljava_lang_String_ == IntPtr.Zero)
        this.id_USBDeviceAttached_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, nameof (USBDeviceAttached), "(Ljava/lang/String;)V");
      IntPtr num = JNIEnv.NewString(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_USBDeviceAttached_Ljava_lang_String_, jvaluePtr);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetUSBDeviceDeAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaderStatusInvoker.cb_USBDeviceDeAttached_Ljava_lang_String_ == null)
        IReaderStatusInvoker.cb_USBDeviceDeAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaderStatusInvoker.n_USBDeviceDeAttached_Ljava_lang_String_));
      return IReaderStatusInvoker.cb_USBDeviceDeAttached_Ljava_lang_String_;
    }

    private static void n_USBDeviceDeAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IReaderStatus>(jnienv, native__this, (JniHandleOwnership) 0).USBDeviceDeAttached(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void USBDeviceDeAttached(string? p0)
    {
      if (this.id_USBDeviceDeAttached_Ljava_lang_String_ == IntPtr.Zero)
        this.id_USBDeviceDeAttached_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, nameof (USBDeviceDeAttached), "(Ljava/lang/String;)V");
      IntPtr num = JNIEnv.NewString(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_USBDeviceDeAttached_Ljava_lang_String_, jvaluePtr);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetReaderAvailable_Ljava_lang_String_Handler()
    {
      if ((object) IReaderStatusInvoker.cb_readerAvailable_Ljava_lang_String_ == null)
        IReaderStatusInvoker.cb_readerAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaderStatusInvoker.n_ReaderAvailable_Ljava_lang_String_));
      return IReaderStatusInvoker.cb_readerAvailable_Ljava_lang_String_;
    }

    private static void n_ReaderAvailable_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IReaderStatus>(jnienv, native__this, (JniHandleOwnership) 0).ReaderAvailable(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void ReaderAvailable(string? p0)
    {
      if (this.id_readerAvailable_Ljava_lang_String_ == IntPtr.Zero)
        this.id_readerAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "readerAvailable", "(Ljava/lang/String;)V");
      IntPtr num = JNIEnv.NewString(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_readerAvailable_Ljava_lang_String_, jvaluePtr);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetReaderDisappeared_Ljava_lang_String_Handler()
    {
      if ((object) IReaderStatusInvoker.cb_readerDisappeared_Ljava_lang_String_ == null)
        IReaderStatusInvoker.cb_readerDisappeared_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaderStatusInvoker.n_ReaderDisappeared_Ljava_lang_String_));
      return IReaderStatusInvoker.cb_readerDisappeared_Ljava_lang_String_;
    }

    private static void n_ReaderDisappeared_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<IReaderStatus>(jnienv, native__this, (JniHandleOwnership) 0).ReaderDisappeared(JNIEnv.GetString(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void ReaderDisappeared(string? p0)
    {
      if (this.id_readerDisappeared_Ljava_lang_String_ == IntPtr.Zero)
        this.id_readerDisappeared_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "readerDisappeared", "(Ljava/lang/String;)V");
      IntPtr num = JNIEnv.NewString(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_readerDisappeared_Ljava_lang_String_, jvaluePtr);
      JNIEnv.DeleteLocalRef(num);
    }
  }
}
