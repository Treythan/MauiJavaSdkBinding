// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.InvalidUsageException
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
  [Register("com/zebra/rfid/api3/InvalidUsageException", DoNotGenerateAcw = true)]
  public class InvalidUsageException : Exception
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/InvalidUsageException", typeof (InvalidUsageException));
    private static Delegate? cb_getInfo;
    private static Delegate? cb_getTimeStamp;
    private static Delegate? cb_getVendorMessage;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = InvalidUsageException._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => InvalidUsageException._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = InvalidUsageException._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => InvalidUsageException._members.ManagedPeerType;

    protected InvalidUsageException(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(ILjava/lang/String;Lcom/zebra/rfid/api3/RFIDResults;)V", "")]
    protected unsafe InvalidUsageException(int readerHandle, string? sMessage, RFIDResults? results)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (((Throwable) this).Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(sMessage);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(readerHandle),
          new JniArgumentValue(num),
          new JniArgumentValue(results == null ? IntPtr.Zero : results.Handle)
        };
        JniObjectReference instance = InvalidUsageException._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Lcom/zebra/rfid/api3/RFIDResults;)V", ((object) this).GetType(), jniArgumentValuePtr);
        ((Throwable) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        InvalidUsageException._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Lcom/zebra/rfid/api3/RFIDResults;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) results);
      }
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
    public unsafe InvalidUsageException(string? sMessage, string? ErrorString)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (((Throwable) this).Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(sMessage);
      IntPtr num2 = JNIEnv.NewString(ErrorString);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference instance = InvalidUsageException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        ((Throwable) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        InvalidUsageException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetGetInfoHandler()
    {
      if ((object) InvalidUsageException.cb_getInfo == null)
        InvalidUsageException.cb_getInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(InvalidUsageException.n_GetInfo));
      return InvalidUsageException.cb_getInfo;
    }

    private static IntPtr n_GetInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<InvalidUsageException>(jnienv, native__this, (JniHandleOwnership) 0).Info);
    }

    public virtual unsafe string? Info
    {
      [Register("getInfo", "()Ljava/lang/String;", "GetGetInfoHandler")] get
      {
        JniObjectReference jniObjectReference = InvalidUsageException._members.InstanceMethods.InvokeVirtualObjectMethod("getInfo.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTimeStampHandler()
    {
      if ((object) InvalidUsageException.cb_getTimeStamp == null)
        InvalidUsageException.cb_getTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(InvalidUsageException.n_GetTimeStamp));
      return InvalidUsageException.cb_getTimeStamp;
    }

    private static IntPtr n_GetTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<InvalidUsageException>(jnienv, native__this, (JniHandleOwnership) 0).TimeStamp);
    }

    public virtual unsafe string? TimeStamp
    {
      [Register("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")] get
      {
        JniObjectReference jniObjectReference = InvalidUsageException._members.InstanceMethods.InvokeVirtualObjectMethod("getTimeStamp.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetVendorMessageHandler()
    {
      if ((object) InvalidUsageException.cb_getVendorMessage == null)
        InvalidUsageException.cb_getVendorMessage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(InvalidUsageException.n_GetVendorMessage));
      return InvalidUsageException.cb_getVendorMessage;
    }

    private static IntPtr n_GetVendorMessage(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<InvalidUsageException>(jnienv, native__this, (JniHandleOwnership) 0).VendorMessage);
    }

    public virtual unsafe string? VendorMessage
    {
      [Register("getVendorMessage", "()Ljava/lang/String;", "GetGetVendorMessageHandler")] get
      {
        JniObjectReference jniObjectReference = InvalidUsageException._members.InstanceMethods.InvokeVirtualObjectMethod("getVendorMessage.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
