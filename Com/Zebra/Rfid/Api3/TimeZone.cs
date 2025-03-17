// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TimeZone
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
  [Register("com/zebra/rfid/api3/TimeZone", DoNotGenerateAcw = true)]
  public class TimeZone : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TimeZone", typeof (TimeZone));
    private static Delegate? cb_getList;
    private static Delegate? cb_setActive_S;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TimeZone._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TimeZone._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TimeZone._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TimeZone._members.ManagedPeerType;

    protected TimeZone(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetListHandler()
    {
      if ((object) TimeZone.cb_getList == null)
        TimeZone.cb_getList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TimeZone.n_GetList));
      return TimeZone.cb_getList;
    }

    private static IntPtr n_GetList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TimeZone>(jnienv, native__this, (JniHandleOwnership) 0).List);
    }

    public virtual unsafe TimeZoneInfo? List
    {
      [Register("getList", "()Lcom/zebra/rfid/api3/TimeZoneInfo;", "GetGetListHandler")] get
      {
        JniObjectReference jniObjectReference = TimeZone._members.InstanceMethods.InvokeVirtualObjectMethod("getList.()Lcom/zebra/rfid/api3/TimeZoneInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<TimeZoneInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetSetActive_SHandler()
    {
      if ((object) TimeZone.cb_setActive_S == null)
        TimeZone.cb_setActive_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(TimeZone.n_SetActive_S));
      return TimeZone.cb_setActive_S;
    }

    private static void n_SetActive_S(IntPtr jnienv, IntPtr native__this, short timeZoneIndex)
    {
      Object.GetObject<TimeZone>(jnienv, native__this, (JniHandleOwnership) 0).SetActive(timeZoneIndex);
    }

    [Register("setActive", "(S)V", "GetSetActive_SHandler")]
    public virtual unsafe void SetActive(short timeZoneIndex)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(timeZoneIndex)
      };
      TimeZone._members.InstanceMethods.InvokeVirtualVoidMethod("setActive.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
