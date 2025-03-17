// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FIRMWARE_UPDATE_EVENT_DATA
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
  [Register("com/zebra/rfid/api3/FIRMWARE_UPDATE_EVENT_DATA", DoNotGenerateAcw = true)]
  public class FIRMWARE_UPDATE_EVENT_DATA : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FIRMWARE_UPDATE_EVENT_DATA", typeof (FIRMWARE_UPDATE_EVENT_DATA));
    private static Delegate? cb_getImageDownloadProgress;
    private static Delegate? cb_setImageDownloadProgress_I;
    private static Delegate? cb_getOverallUpdateProgress;
    private static Delegate? cb_setOverallUpdateProgress_I;
    private static Delegate? cb_getStatus;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FIRMWARE_UPDATE_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FIRMWARE_UPDATE_EVENT_DATA._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FIRMWARE_UPDATE_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FIRMWARE_UPDATE_EVENT_DATA._members.ManagedPeerType;

    protected FIRMWARE_UPDATE_EVENT_DATA(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe FIRMWARE_UPDATE_EVENT_DATA()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetImageDownloadProgressHandler()
    {
      if ((object) FIRMWARE_UPDATE_EVENT_DATA.cb_getImageDownloadProgress == null)
        FIRMWARE_UPDATE_EVENT_DATA.cb_getImageDownloadProgress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FIRMWARE_UPDATE_EVENT_DATA.n_GetImageDownloadProgress));
      return FIRMWARE_UPDATE_EVENT_DATA.cb_getImageDownloadProgress;
    }

    private static int n_GetImageDownloadProgress(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FIRMWARE_UPDATE_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).ImageDownloadProgress;
    }

    private static Delegate GetSetImageDownloadProgress_IHandler()
    {
      if ((object) FIRMWARE_UPDATE_EVENT_DATA.cb_setImageDownloadProgress_I == null)
        FIRMWARE_UPDATE_EVENT_DATA.cb_setImageDownloadProgress_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(FIRMWARE_UPDATE_EVENT_DATA.n_SetImageDownloadProgress_I));
      return FIRMWARE_UPDATE_EVENT_DATA.cb_setImageDownloadProgress_I;
    }

    private static void n_SetImageDownloadProgress_I(
      IntPtr jnienv,
      IntPtr native__this,
      int imageDownloadProgress)
    {
      Object.GetObject<FIRMWARE_UPDATE_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).ImageDownloadProgress = imageDownloadProgress;
    }

    public virtual unsafe int ImageDownloadProgress
    {
      [Register("getImageDownloadProgress", "()I", "GetGetImageDownloadProgressHandler")] get
      {
        return FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.InvokeVirtualInt32Method("getImageDownloadProgress.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setImageDownloadProgress", "(I)V", "GetSetImageDownloadProgress_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.InvokeVirtualVoidMethod("setImageDownloadProgress.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOverallUpdateProgressHandler()
    {
      if ((object) FIRMWARE_UPDATE_EVENT_DATA.cb_getOverallUpdateProgress == null)
        FIRMWARE_UPDATE_EVENT_DATA.cb_getOverallUpdateProgress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FIRMWARE_UPDATE_EVENT_DATA.n_GetOverallUpdateProgress));
      return FIRMWARE_UPDATE_EVENT_DATA.cb_getOverallUpdateProgress;
    }

    private static int n_GetOverallUpdateProgress(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FIRMWARE_UPDATE_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).OverallUpdateProgress;
    }

    private static Delegate GetSetOverallUpdateProgress_IHandler()
    {
      if ((object) FIRMWARE_UPDATE_EVENT_DATA.cb_setOverallUpdateProgress_I == null)
        FIRMWARE_UPDATE_EVENT_DATA.cb_setOverallUpdateProgress_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(FIRMWARE_UPDATE_EVENT_DATA.n_SetOverallUpdateProgress_I));
      return FIRMWARE_UPDATE_EVENT_DATA.cb_setOverallUpdateProgress_I;
    }

    private static void n_SetOverallUpdateProgress_I(
      IntPtr jnienv,
      IntPtr native__this,
      int overallUpdateProgress)
    {
      Object.GetObject<FIRMWARE_UPDATE_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).OverallUpdateProgress = overallUpdateProgress;
    }

    public virtual unsafe int OverallUpdateProgress
    {
      [Register("getOverallUpdateProgress", "()I", "GetGetOverallUpdateProgressHandler")] get
      {
        return FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.InvokeVirtualInt32Method("getOverallUpdateProgress.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOverallUpdateProgress", "(I)V", "GetSetOverallUpdateProgress_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.InvokeVirtualVoidMethod("setOverallUpdateProgress.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) FIRMWARE_UPDATE_EVENT_DATA.cb_getStatus == null)
        FIRMWARE_UPDATE_EVENT_DATA.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(FIRMWARE_UPDATE_EVENT_DATA.n_GetStatus));
      return FIRMWARE_UPDATE_EVENT_DATA.cb_getStatus;
    }

    private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<FIRMWARE_UPDATE_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).Status);
    }

    public virtual unsafe string? Status
    {
      [Register("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")] get
      {
        JniObjectReference jniObjectReference = FIRMWARE_UPDATE_EVENT_DATA._members.InstanceMethods.InvokeVirtualObjectMethod("getStatus.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
