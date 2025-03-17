// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.ICmniolistnerInvoker
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
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/cmniolistner", DoNotGenerateAcw = true)]
  internal class ICmniolistnerInvoker : 
    Object,
    ICmniolistner,
    IJavaObject,
    IDisposable,
    IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/commoniolib/cmniolistner", typeof (ICmniolistnerInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_onNewData_arrayB;
    private IntPtr id_onNewData_arrayB;
    private static Delegate? cb_onRunError_Ljava_lang_Exception_;
    private IntPtr id_onRunError_Ljava_lang_Exception_;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = ICmniolistnerInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ICmniolistnerInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ICmniolistnerInvoker._members.ManagedPeerType;

    public static ICmniolistner? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<ICmniolistner>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, ICmniolistnerInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.commoniolib.cmniolistner'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public ICmniolistnerInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(ICmniolistnerInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetOnNewData_arrayBHandler()
    {
      if ((object) ICmniolistnerInvoker.cb_onNewData_arrayB == null)
        ICmniolistnerInvoker.cb_onNewData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ICmniolistnerInvoker.n_OnNewData_arrayB));
      return ICmniolistnerInvoker.cb_onNewData_arrayB;
    }

    private static void n_OnNewData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
    {
      ICmniolistner cmniolistner = Object.GetObject<ICmniolistner>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_p0, (JniHandleOwnership) 0, typeof (byte));
      byte[] p0 = array;
      cmniolistner.OnNewData(p0);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_p0);
    }

    public unsafe void OnNewData(byte[]? p0)
    {
      if (this.id_onNewData_arrayB == IntPtr.Zero)
        this.id_onNewData_arrayB = JNIEnv.GetMethodID(this.class_ref, "onNewData", "([B)V");
      IntPtr num = JNIEnv.NewArray(p0);
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(num)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_onNewData_arrayB, jvaluePtr);
      if (p0 == null)
        return;
      JNIEnv.CopyArray(num, p0);
      JNIEnv.DeleteLocalRef(num);
    }

    private static Delegate GetOnRunError_Ljava_lang_Exception_Handler()
    {
      if ((object) ICmniolistnerInvoker.cb_onRunError_Ljava_lang_Exception_ == null)
        ICmniolistnerInvoker.cb_onRunError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ICmniolistnerInvoker.n_OnRunError_Ljava_lang_Exception_));
      return ICmniolistnerInvoker.cb_onRunError_Ljava_lang_Exception_;
    }

    private static void n_OnRunError_Ljava_lang_Exception_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_p0)
    {
      Object.GetObject<ICmniolistner>(jnienv, native__this, (JniHandleOwnership) 0).OnRunError(Object.GetObject<Exception>(native_p0, (JniHandleOwnership) 0));
    }

    public unsafe void OnRunError(Exception? p0)
    {
      if (this.id_onRunError_Ljava_lang_Exception_ == IntPtr.Zero)
        this.id_onRunError_Ljava_lang_Exception_ = JNIEnv.GetMethodID(this.class_ref, "onRunError", "(Ljava/lang/Exception;)V");
      JValue* jvaluePtr = stackalloc JValue[1]
      {
        new JValue(p0 == null ? IntPtr.Zero : ((Throwable) p0).Handle)
      };
      JNIEnv.CallVoidMethod(this.Handle, this.id_onRunError_Ljava_lang_Exception_, jvaluePtr);
    }
  }
}
