// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UTCTime
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
  [Register("com/zebra/rfid/api3/UTCTime", DoNotGenerateAcw = true)]
  public class UTCTime : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UTCTime", typeof (UTCTime));
    private static Delegate? cb_getFirstSeenTimeStamp;
    private static Delegate? cb_setFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    private static Delegate? cb_getLastSeenTimeStamp;
    private static Delegate? cb_setLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    private static Delegate? cb_setFirstSeenTimeStamp_SSSSSSSS;
    private static Delegate? cb_setLastSeenTimeStamp_SSSSSSSS;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UTCTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UTCTime._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UTCTime._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UTCTime._members.ManagedPeerType;

    protected UTCTime(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetFirstSeenTimeStampHandler()
    {
      if ((object) UTCTime.cb_getFirstSeenTimeStamp == null)
        UTCTime.cb_getFirstSeenTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UTCTime.n_GetFirstSeenTimeStamp));
      return UTCTime.cb_getFirstSeenTimeStamp;
    }

    private static IntPtr n_GetFirstSeenTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).FirstSeenTimeStamp);
    }

    private static Delegate GetSetFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler()
    {
      if ((object) UTCTime.cb_setFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ == null)
        UTCTime.cb_setFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UTCTime.n_SetFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_));
      return UTCTime.cb_setFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    }

    private static void n_SetFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_FirstSeenTimeStamp)
    {
      Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).FirstSeenTimeStamp = Object.GetObject<SYSTEMTIME>(native_m_FirstSeenTimeStamp, (JniHandleOwnership) 0);
    }

    public virtual unsafe SYSTEMTIME? FirstSeenTimeStamp
    {
      [Register("getFirstSeenTimeStamp", "()Lcom/zebra/rfid/api3/SYSTEMTIME;", "GetGetFirstSeenTimeStampHandler")] get
      {
        JniObjectReference jniObjectReference = UTCTime._members.InstanceMethods.InvokeVirtualObjectMethod("getFirstSeenTimeStamp.()Lcom/zebra/rfid/api3/SYSTEMTIME;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SYSTEMTIME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setFirstSeenTimeStamp", "(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", "GetSetFirstSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          UTCTime._members.InstanceMethods.InvokeVirtualVoidMethod("setFirstSeenTimeStamp.(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetLastSeenTimeStampHandler()
    {
      if ((object) UTCTime.cb_getLastSeenTimeStamp == null)
        UTCTime.cb_getLastSeenTimeStamp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UTCTime.n_GetLastSeenTimeStamp));
      return UTCTime.cb_getLastSeenTimeStamp;
    }

    private static IntPtr n_GetLastSeenTimeStamp(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).LastSeenTimeStamp);
    }

    private static Delegate GetSetLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler()
    {
      if ((object) UTCTime.cb_setLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ == null)
        UTCTime.cb_setLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(UTCTime.n_SetLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_));
      return UTCTime.cb_setLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_;
    }

    private static void n_SetLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_LastSeenTimeStamp)
    {
      Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).LastSeenTimeStamp = Object.GetObject<SYSTEMTIME>(native_m_LastSeenTimeStamp, (JniHandleOwnership) 0);
    }

    public virtual unsafe SYSTEMTIME? LastSeenTimeStamp
    {
      [Register("getLastSeenTimeStamp", "()Lcom/zebra/rfid/api3/SYSTEMTIME;", "GetGetLastSeenTimeStampHandler")] get
      {
        JniObjectReference jniObjectReference = UTCTime._members.InstanceMethods.InvokeVirtualObjectMethod("getLastSeenTimeStamp.()Lcom/zebra/rfid/api3/SYSTEMTIME;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<SYSTEMTIME>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setLastSeenTimeStamp", "(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", "GetSetLastSeenTimeStamp_Lcom_zebra_rfid_api3_SYSTEMTIME_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          UTCTime._members.InstanceMethods.InvokeVirtualVoidMethod("setLastSeenTimeStamp.(Lcom/zebra/rfid/api3/SYSTEMTIME;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetSetFirstSeenTimeStamp_SSSSSSSSHandler()
    {
      if ((object) UTCTime.cb_setFirstSeenTimeStamp_SSSSSSSS == null)
        UTCTime.cb_setFirstSeenTimeStamp_SSSSSSSS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPSSSSSSSS_V(UTCTime.n_SetFirstSeenTimeStamp_SSSSSSSS));
      return UTCTime.cb_setFirstSeenTimeStamp_SSSSSSSS;
    }

    private static void n_SetFirstSeenTimeStamp_SSSSSSSS(
      IntPtr jnienv,
      IntPtr native__this,
      short year,
      short month,
      short day,
      short dayOfWeek,
      short hour,
      short minute,
      short second,
      short milliseconds)
    {
      Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).SetFirstSeenTimeStamp(year, month, day, dayOfWeek, hour, minute, second, milliseconds);
    }

    [Register("setFirstSeenTimeStamp", "(SSSSSSSS)V", "GetSetFirstSeenTimeStamp_SSSSSSSSHandler")]
    public virtual unsafe void SetFirstSeenTimeStamp(
      short year,
      short month,
      short day,
      short dayOfWeek,
      short hour,
      short minute,
      short second,
      short milliseconds)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[8]
      {
        new JniArgumentValue(year),
        new JniArgumentValue(month),
        new JniArgumentValue(day),
        new JniArgumentValue(dayOfWeek),
        new JniArgumentValue(hour),
        new JniArgumentValue(minute),
        new JniArgumentValue(second),
        new JniArgumentValue(milliseconds)
      };
      UTCTime._members.InstanceMethods.InvokeVirtualVoidMethod("setFirstSeenTimeStamp.(SSSSSSSS)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetLastSeenTimeStamp_SSSSSSSSHandler()
    {
      if ((object) UTCTime.cb_setLastSeenTimeStamp_SSSSSSSS == null)
        UTCTime.cb_setLastSeenTimeStamp_SSSSSSSS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPSSSSSSSS_V(UTCTime.n_SetLastSeenTimeStamp_SSSSSSSS));
      return UTCTime.cb_setLastSeenTimeStamp_SSSSSSSS;
    }

    private static void n_SetLastSeenTimeStamp_SSSSSSSS(
      IntPtr jnienv,
      IntPtr native__this,
      short year,
      short month,
      short day,
      short dayOfWeek,
      short hour,
      short minute,
      short second,
      short milliseconds)
    {
      Object.GetObject<UTCTime>(jnienv, native__this, (JniHandleOwnership) 0).SetLastSeenTimeStamp(year, month, day, dayOfWeek, hour, minute, second, milliseconds);
    }

    [Register("setLastSeenTimeStamp", "(SSSSSSSS)V", "GetSetLastSeenTimeStamp_SSSSSSSSHandler")]
    public virtual unsafe void SetLastSeenTimeStamp(
      short year,
      short month,
      short day,
      short dayOfWeek,
      short hour,
      short minute,
      short second,
      short milliseconds)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[8]
      {
        new JniArgumentValue(year),
        new JniArgumentValue(month),
        new JniArgumentValue(day),
        new JniArgumentValue(dayOfWeek),
        new JniArgumentValue(hour),
        new JniArgumentValue(minute),
        new JniArgumentValue(second),
        new JniArgumentValue(milliseconds)
      };
      UTCTime._members.InstanceMethods.InvokeVirtualVoidMethod("setLastSeenTimeStamp.(SSSSSSSS)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
