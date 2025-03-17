// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TimeZoneInfo
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
  [Register("com/zebra/rfid/api3/TimeZoneInfo", DoNotGenerateAcw = true)]
  public class TimeZoneInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TimeZoneInfo", typeof (TimeZoneInfo));
    private static Delegate? cb_getActiveTimeZoneIndex;
    private static Delegate? cb_getTimeZones;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TimeZoneInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TimeZoneInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TimeZoneInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TimeZoneInfo._members.ManagedPeerType;

    protected TimeZoneInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "([Ljava/lang/String;I)V", "")]
    public unsafe TimeZoneInfo(string[]? m_timeZones, int m_activeTimeZoneIndex)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray(m_timeZones);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(m_activeTimeZoneIndex)
        };
        JniObjectReference instance = TimeZoneInfo._members.InstanceMethods.StartCreateInstance("([Ljava/lang/String;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        TimeZoneInfo._members.InstanceMethods.FinishCreateInstance("([Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_timeZones != null)
        {
          JNIEnv.CopyArray(num, m_timeZones);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_timeZones);
      }
    }

    private static Delegate GetGetActiveTimeZoneIndexHandler()
    {
      if ((object) TimeZoneInfo.cb_getActiveTimeZoneIndex == null)
        TimeZoneInfo.cb_getActiveTimeZoneIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TimeZoneInfo.n_GetActiveTimeZoneIndex));
      return TimeZoneInfo.cb_getActiveTimeZoneIndex;
    }

    private static int n_GetActiveTimeZoneIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TimeZoneInfo>(jnienv, native__this, (JniHandleOwnership) 0).ActiveTimeZoneIndex;
    }

    public virtual unsafe int ActiveTimeZoneIndex
    {
      [Register("getActiveTimeZoneIndex", "()I", "GetGetActiveTimeZoneIndexHandler")] get
      {
        return TimeZoneInfo._members.InstanceMethods.InvokeVirtualInt32Method("getActiveTimeZoneIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTimeZonesHandler()
    {
      if ((object) TimeZoneInfo.cb_getTimeZones == null)
        TimeZoneInfo.cb_getTimeZones = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TimeZoneInfo.n_GetTimeZones));
      return TimeZoneInfo.cb_getTimeZones;
    }

    private static IntPtr n_GetTimeZones(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<TimeZoneInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetTimeZones());
    }

    [Register("getTimeZones", "()[Ljava/lang/String;", "GetGetTimeZonesHandler")]
    public virtual unsafe string[]? GetTimeZones()
    {
      JniObjectReference jniObjectReference = TimeZoneInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getTimeZones.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }
  }
}
