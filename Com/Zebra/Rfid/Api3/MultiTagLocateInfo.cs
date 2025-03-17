// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.MultiTagLocateInfo
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
  [Register("com/zebra/rfid/api3/MultiTagLocateInfo", DoNotGenerateAcw = true)]
  public class MultiTagLocateInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MultiTagLocateInfo", typeof (MultiTagLocateInfo));
    private static Delegate? cb_getRelativeDistance;
    private static Delegate? cb_getRssiValueLimit;
    private static Delegate? cb_setRssiValueLimit_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MultiTagLocateInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MultiTagLocateInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MultiTagLocateInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MultiTagLocateInfo._members.ManagedPeerType;

    protected MultiTagLocateInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetRelativeDistanceHandler()
    {
      if ((object) MultiTagLocateInfo.cb_getRelativeDistance == null)
        MultiTagLocateInfo.cb_getRelativeDistance = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(MultiTagLocateInfo.n_GetRelativeDistance));
      return MultiTagLocateInfo.cb_getRelativeDistance;
    }

    private static short n_GetRelativeDistance(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MultiTagLocateInfo>(jnienv, native__this, (JniHandleOwnership) 0).RelativeDistance;
    }

    public virtual unsafe short RelativeDistance
    {
      [Register("getRelativeDistance", "()S", "GetGetRelativeDistanceHandler")] get
      {
        return MultiTagLocateInfo._members.InstanceMethods.InvokeVirtualInt16Method("getRelativeDistance.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRssiValueLimitHandler()
    {
      if ((object) MultiTagLocateInfo.cb_getRssiValueLimit == null)
        MultiTagLocateInfo.cb_getRssiValueLimit = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(MultiTagLocateInfo.n_GetRssiValueLimit));
      return MultiTagLocateInfo.cb_getRssiValueLimit;
    }

    private static short n_GetRssiValueLimit(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MultiTagLocateInfo>(jnienv, native__this, (JniHandleOwnership) 0).RssiValueLimit;
    }

    public virtual unsafe short RssiValueLimit
    {
      [Register("getRssiValueLimit", "()S", "GetGetRssiValueLimitHandler")] get
      {
        return MultiTagLocateInfo._members.InstanceMethods.InvokeVirtualInt16Method("getRssiValueLimit.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetSetRssiValueLimit_Ljava_lang_String_Handler()
    {
      if ((object) MultiTagLocateInfo.cb_setRssiValueLimit_Ljava_lang_String_ == null)
        MultiTagLocateInfo.cb_setRssiValueLimit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiTagLocateInfo.n_SetRssiValueLimit_Ljava_lang_String_));
      return MultiTagLocateInfo.cb_setRssiValueLimit_Ljava_lang_String_;
    }

    private static void n_SetRssiValueLimit_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_rssiValue)
    {
      Object.GetObject<MultiTagLocateInfo>(jnienv, native__this, (JniHandleOwnership) 0).SetRssiValueLimit(JNIEnv.GetString(native_rssiValue, (JniHandleOwnership) 0));
    }

    [Register("setRssiValueLimit", "(Ljava/lang/String;)V", "GetSetRssiValueLimit_Ljava_lang_String_Handler")]
    public virtual unsafe void SetRssiValueLimit(string? rssiValue)
    {
      IntPtr num = JNIEnv.NewString(rssiValue);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        MultiTagLocateInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setRssiValueLimit.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
