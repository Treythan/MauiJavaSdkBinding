// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReaderDevice
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
  [Register("com/zebra/rfid/api3/ReaderDevice", DoNotGenerateAcw = true)]
  public class ReaderDevice : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderDevice", typeof (ReaderDevice));
    private static Delegate? cb_getAddress;
    private static Delegate? cb_setAddress_Ljava_lang_String_;
    private static Delegate? cb_getName;
    private static Delegate? cb_setName_Ljava_lang_String_;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_Ljava_lang_String_;
    private static Delegate? cb_getRFIDReader;
    private static Delegate? cb_getSerialNumber;
    private static Delegate? cb_setSerialNumber_Ljava_lang_String_;
    private static Delegate? cb_getTransport;
    private static Delegate? cb_setTransport_Ljava_lang_String_;
    private static Delegate? cb_getDeviceCapability_Ljava_lang_String_;
    private static Delegate? cb_setRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReaderDevice._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReaderDevice._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReaderDevice._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReaderDevice._members.ManagedPeerType;

    protected ReaderDevice(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ReaderDevice()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ReaderDevice._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ReaderDevice._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
    public unsafe ReaderDevice(string? name, string? address)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(name);
      IntPtr num2 = JNIEnv.NewString(address);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference instance = ReaderDevice._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ReaderDevice._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/RFIDReader;)V", "")]
    public unsafe ReaderDevice(string? name, string? address, RFIDReader? rfidReader)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(name);
      IntPtr num2 = JNIEnv.NewString(address);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(rfidReader == null ? IntPtr.Zero : rfidReader.Handle)
        };
        JniObjectReference instance = ReaderDevice._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/RFIDReader;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ReaderDevice._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/RFIDReader;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) rfidReader);
      }
    }

    private static Delegate GetGetAddressHandler()
    {
      if ((object) ReaderDevice.cb_getAddress == null)
        ReaderDevice.cb_getAddress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetAddress));
      return ReaderDevice.cb_getAddress;
    }

    private static IntPtr n_GetAddress(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Address);
    }

    private static Delegate GetSetAddress_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_setAddress_Ljava_lang_String_ == null)
        ReaderDevice.cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetAddress_Ljava_lang_String_));
      return ReaderDevice.cb_setAddress_Ljava_lang_String_;
    }

    private static void n_SetAddress_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_address)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Address = JNIEnv.GetString(native_address, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Address
    {
      [Register("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getAddress.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setAddress.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetNameHandler()
    {
      if ((object) ReaderDevice.cb_getName == null)
        ReaderDevice.cb_getName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetName));
      return ReaderDevice.cb_getName;
    }

    private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Name);
    }

    private static Delegate GetSetName_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_setName_Ljava_lang_String_ == null)
        ReaderDevice.cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetName_Ljava_lang_String_));
      return ReaderDevice.cb_setName_Ljava_lang_String_;
    }

    private static void n_SetName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_name)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Name = JNIEnv.GetString(native_name, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Name
    {
      [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) ReaderDevice.cb_getPassword == null)
        ReaderDevice.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetPassword));
      return ReaderDevice.cb_getPassword;
    }

    private static IntPtr n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Password);
    }

    private static Delegate GetSetPassword_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_setPassword_Ljava_lang_String_ == null)
        ReaderDevice.cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetPassword_Ljava_lang_String_));
      return ReaderDevice.cb_setPassword_Ljava_lang_String_;
    }

    private static void n_SetPassword_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_password)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Password = JNIEnv.GetString(native_password, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Password
    {
      [Register("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getPassword.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetRFIDReaderHandler()
    {
      if ((object) ReaderDevice.cb_getRFIDReader == null)
        ReaderDevice.cb_getRFIDReader = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetRFIDReader));
      return ReaderDevice.cb_getRFIDReader;
    }

    private static IntPtr n_GetRFIDReader(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).RFIDReader);
    }

    public virtual unsafe RFIDReader? RFIDReader
    {
      [Register("getRFIDReader", "()Lcom/zebra/rfid/api3/RFIDReader;", "GetGetRFIDReaderHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getRFIDReader.()Lcom/zebra/rfid/api3/RFIDReader;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RFIDReader>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSerialNumberHandler()
    {
      if ((object) ReaderDevice.cb_getSerialNumber == null)
        ReaderDevice.cb_getSerialNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetSerialNumber));
      return ReaderDevice.cb_getSerialNumber;
    }

    private static IntPtr n_GetSerialNumber(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber);
    }

    private static Delegate GetSetSerialNumber_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_setSerialNumber_Ljava_lang_String_ == null)
        ReaderDevice.cb_setSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetSerialNumber_Ljava_lang_String_));
      return ReaderDevice.cb_setSerialNumber_Ljava_lang_String_;
    }

    private static void n_SetSerialNumber_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_serialNo)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).SerialNumber = JNIEnv.GetString(native_serialNo, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? SerialNumber
    {
      [Register("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getSerialNumber.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setSerialNumber.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetTransportHandler()
    {
      if ((object) ReaderDevice.cb_getTransport == null)
        ReaderDevice.cb_getTransport = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderDevice.n_GetTransport));
      return ReaderDevice.cb_getTransport;
    }

    private static IntPtr n_GetTransport(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Transport);
    }

    private static Delegate GetSetTransport_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_setTransport_Ljava_lang_String_ == null)
        ReaderDevice.cb_setTransport_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetTransport_Ljava_lang_String_));
      return ReaderDevice.cb_setTransport_Ljava_lang_String_;
    }

    private static void n_SetTransport_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mTransport)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).Transport = JNIEnv.GetString(native_mTransport, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Transport
    {
      [Register("getTransport", "()Ljava/lang/String;", "GetGetTransportHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getTransport.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTransport", "(Ljava/lang/String;)V", "GetSetTransport_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setTransport.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetDeviceCapability_Ljava_lang_String_Handler()
    {
      if ((object) ReaderDevice.cb_getDeviceCapability_Ljava_lang_String_ == null)
        ReaderDevice.cb_getDeviceCapability_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(ReaderDevice.n_GetDeviceCapability_Ljava_lang_String_));
      return ReaderDevice.cb_getDeviceCapability_Ljava_lang_String_;
    }

    private static IntPtr n_GetDeviceCapability_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_modelName)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).GetDeviceCapability(JNIEnv.GetString(native_modelName, (JniHandleOwnership) 0)));
    }

    [Register("getDeviceCapability", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetDeviceCapability_Ljava_lang_String_Handler")]
    public virtual unsafe string? GetDeviceCapability(string? modelName)
    {
      IntPtr num = JNIEnv.NewString(modelName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ReaderDevice._members.InstanceMethods.InvokeVirtualObjectMethod("getDeviceCapability.(Ljava/lang/String;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_Handler()
    {
      if ((object) ReaderDevice.cb_setRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_ == null)
        ReaderDevice.cb_setRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderDevice.n_SetRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_));
      return ReaderDevice.cb_setRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_;
    }

    private static void n_SetRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_rfidReader)
    {
      Object.GetObject<ReaderDevice>(jnienv, native__this, (JniHandleOwnership) 0).SetRFIDRReader(Object.GetObject<RFIDReader>(native_rfidReader, (JniHandleOwnership) 0));
    }

    [Register("setRFIDRReader", "(Lcom/zebra/rfid/api3/RFIDReader;)V", "GetSetRFIDRReader_Lcom_zebra_rfid_api3_RFIDReader_Handler")]
    public virtual unsafe void SetRFIDRReader(RFIDReader? rfidReader)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidReader == null ? IntPtr.Zero : rfidReader.Handle)
        };
        ReaderDevice._members.InstanceMethods.InvokeVirtualVoidMethod("setRFIDRReader.(Lcom/zebra/rfid/api3/RFIDReader;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidReader);
      }
    }
  }
}
