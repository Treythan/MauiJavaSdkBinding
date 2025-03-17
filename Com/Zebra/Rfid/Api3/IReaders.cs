// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IReaders
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
  [Register("com/zebra/rfid/api3/IReaders", DoNotGenerateAcw = true)]
  public class IReaders : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IReaders", typeof (IReaders));
    private static Delegate? cb_NGEDeviceAttached_Ljava_lang_String_;
    private static Delegate? cb_NGEDeviceDeAttached_Ljava_lang_String_;
    private static Delegate? cb_USBDeviceAttached_Ljava_lang_String_;
    private static Delegate? cb_USBDeviceDeAttached_Ljava_lang_String_;
    private static Delegate? cb_readerAvailable_Ljava_lang_String_;
    private static Delegate? cb_readerDisappeared_Ljava_lang_String_;
    private static Delegate? cb_setreaderinterface_Lcom_zebra_rfid_api3_IReaders_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = IReaders._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IReaders._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = IReaders._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IReaders._members.ManagedPeerType;

    protected IReaders(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe IReaders()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = IReaders._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      IReaders._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetNGEDeviceAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_NGEDeviceAttached_Ljava_lang_String_ == null)
        IReaders.cb_NGEDeviceAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_NGEDeviceAttached_Ljava_lang_String_));
      return IReaders.cb_NGEDeviceAttached_Ljava_lang_String_;
    }

    private static void n_NGEDeviceAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).NGEDeviceAttached(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("NGEDeviceAttached", "(Ljava/lang/String;)V", "GetNGEDeviceAttached_Ljava_lang_String_Handler")]
    public virtual unsafe void NGEDeviceAttached(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("NGEDeviceAttached.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetNGEDeviceDeAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_NGEDeviceDeAttached_Ljava_lang_String_ == null)
        IReaders.cb_NGEDeviceDeAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_NGEDeviceDeAttached_Ljava_lang_String_));
      return IReaders.cb_NGEDeviceDeAttached_Ljava_lang_String_;
    }

    private static void n_NGEDeviceDeAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).NGEDeviceDeAttached(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("NGEDeviceDeAttached", "(Ljava/lang/String;)V", "GetNGEDeviceDeAttached_Ljava_lang_String_Handler")]
    public virtual unsafe void NGEDeviceDeAttached(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("NGEDeviceDeAttached.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetUSBDeviceAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_USBDeviceAttached_Ljava_lang_String_ == null)
        IReaders.cb_USBDeviceAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_USBDeviceAttached_Ljava_lang_String_));
      return IReaders.cb_USBDeviceAttached_Ljava_lang_String_;
    }

    private static void n_USBDeviceAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).USBDeviceAttached(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("USBDeviceAttached", "(Ljava/lang/String;)V", "GetUSBDeviceAttached_Ljava_lang_String_Handler")]
    public virtual unsafe void USBDeviceAttached(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("USBDeviceAttached.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetUSBDeviceDeAttached_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_USBDeviceDeAttached_Ljava_lang_String_ == null)
        IReaders.cb_USBDeviceDeAttached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_USBDeviceDeAttached_Ljava_lang_String_));
      return IReaders.cb_USBDeviceDeAttached_Ljava_lang_String_;
    }

    private static void n_USBDeviceDeAttached_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).USBDeviceDeAttached(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("USBDeviceDeAttached", "(Ljava/lang/String;)V", "GetUSBDeviceDeAttached_Ljava_lang_String_Handler")]
    public virtual unsafe void USBDeviceDeAttached(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("USBDeviceDeAttached.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetReaderAvailable_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_readerAvailable_Ljava_lang_String_ == null)
        IReaders.cb_readerAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_ReaderAvailable_Ljava_lang_String_));
      return IReaders.cb_readerAvailable_Ljava_lang_String_;
    }

    private static void n_ReaderAvailable_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).ReaderAvailable(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("readerAvailable", "(Ljava/lang/String;)V", "GetReaderAvailable_Ljava_lang_String_Handler")]
    public virtual unsafe void ReaderAvailable(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("readerAvailable.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetReaderDisappeared_Ljava_lang_String_Handler()
    {
      if ((object) IReaders.cb_readerDisappeared_Ljava_lang_String_ == null)
        IReaders.cb_readerDisappeared_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_ReaderDisappeared_Ljava_lang_String_));
      return IReaders.cb_readerDisappeared_Ljava_lang_String_;
    }

    private static void n_ReaderDisappeared_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).ReaderDisappeared(JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0));
    }

    [Register("readerDisappeared", "(Ljava/lang/String;)V", "GetReaderDisappeared_Ljava_lang_String_Handler")]
    public virtual unsafe void ReaderDisappeared(string? readerName)
    {
      IntPtr num = JNIEnv.NewString(readerName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("readerDisappeared.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetreaderinterface_Lcom_zebra_rfid_api3_IReaders_Handler()
    {
      if ((object) IReaders.cb_setreaderinterface_Lcom_zebra_rfid_api3_IReaders_ == null)
        IReaders.cb_setreaderinterface_Lcom_zebra_rfid_api3_IReaders_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IReaders.n_Setreaderinterface_Lcom_zebra_rfid_api3_IReaders_));
      return IReaders.cb_setreaderinterface_Lcom_zebra_rfid_api3_IReaders_;
    }

    private static void n_Setreaderinterface_Lcom_zebra_rfid_api3_IReaders_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readers)
    {
      Object.GetObject<IReaders>(jnienv, native__this, (JniHandleOwnership) 0).Setreaderinterface(Object.GetObject<IReaders>(native_readers, (JniHandleOwnership) 0));
    }

    [Register("setreaderinterface", "(Lcom/zebra/rfid/api3/IReaders;)V", "GetSetreaderinterface_Lcom_zebra_rfid_api3_IReaders_Handler")]
    public virtual unsafe void Setreaderinterface(IReaders? readers)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(readers == null ? IntPtr.Zero : readers.Handle)
        };
        IReaders._members.InstanceMethods.InvokeVirtualVoidMethod("setreaderinterface.(Lcom/zebra/rfid/api3/IReaders;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readers);
      }
    }
  }
}
