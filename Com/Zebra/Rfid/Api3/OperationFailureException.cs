// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.OperationFailureException
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
  [Register("com/zebra/rfid/api3/OperationFailureException", DoNotGenerateAcw = true)]
  public class OperationFailureException : Exception
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/OperationFailureException", typeof (OperationFailureException));
    private static Delegate? cb_getResults;
    private static Delegate? cb_getStatusDescription;
    private static Delegate? cb_getTimeStamp;
    private static Delegate? cb_getVendorMessage;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = OperationFailureException._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => OperationFailureException._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = OperationFailureException._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => OperationFailureException._members.ManagedPeerType;

    protected OperationFailureException(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetResultsHandler()
    {
      if ((object) OperationFailureException.cb_getResults == null)
        OperationFailureException.cb_getResults = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(OperationFailureException.n_GetResults));
      return OperationFailureException.cb_getResults;
    }

    private static IntPtr n_GetResults(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<OperationFailureException>(jnienv, native__this, (JniHandleOwnership) 0).Results);
    }

    public virtual unsafe RFIDResults? Results
    {
      [Register("getResults", "()Lcom/zebra/rfid/api3/RFIDResults;", "GetGetResultsHandler")] get
      {
        JniObjectReference jniObjectReference = OperationFailureException._members.InstanceMethods.InvokeVirtualObjectMethod("getResults.()Lcom/zebra/rfid/api3/RFIDResults;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RFIDResults>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStatusDescriptionHandler()
    {
      if ((object) OperationFailureException.cb_getStatusDescription == null)
        OperationFailureException.cb_getStatusDescription = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(OperationFailureException.n_GetStatusDescription));
      return OperationFailureException.cb_getStatusDescription;
    }

    private static IntPtr n_GetStatusDescription(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<OperationFailureException>(jnienv, native__this, (JniHandleOwnership) 0).StatusDescription);
    }

    public virtual unsafe string? StatusDescription
    {
      [Register("getStatusDescription", "()Ljava/lang/String;", "GetGetStatusDescriptionHandler")] get
      {
        JniObjectReference jniObjectReference = OperationFailureException._members.InstanceMethods.InvokeVirtualObjectMethod("getStatusDescription.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTimeStampHandler()
    {
      if ((object) OperationFailureException.cb_getTimeStamp == null)
        OperationFailureException.cb_getTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(OperationFailureException.n_GetTimeStamp));
      return OperationFailureException.cb_getTimeStamp;
    }

    private static IntPtr n_GetTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<OperationFailureException>(jnienv, native__this, (JniHandleOwnership) 0).TimeStamp);
    }

    public virtual unsafe string? TimeStamp
    {
      [Register("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")] get
      {
        JniObjectReference jniObjectReference = OperationFailureException._members.InstanceMethods.InvokeVirtualObjectMethod("getTimeStamp.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetVendorMessageHandler()
    {
      if ((object) OperationFailureException.cb_getVendorMessage == null)
        OperationFailureException.cb_getVendorMessage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(OperationFailureException.n_GetVendorMessage));
      return OperationFailureException.cb_getVendorMessage;
    }

    private static IntPtr n_GetVendorMessage(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<OperationFailureException>(jnienv, native__this, (JniHandleOwnership) 0).VendorMessage);
    }

    public virtual unsafe string? VendorMessage
    {
      [Register("getVendorMessage", "()Ljava/lang/String;", "GetGetVendorMessageHandler")] get
      {
        JniObjectReference jniObjectReference = OperationFailureException._members.InstanceMethods.InvokeVirtualObjectMethod("getVendorMessage.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
