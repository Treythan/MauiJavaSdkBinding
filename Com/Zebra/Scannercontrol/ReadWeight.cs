// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.ReadWeight
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/ReadWeight", DoNotGenerateAcw = true)]
  public class ReadWeight : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/ReadWeight", typeof (ReadWeight));
    private static Delegate? cb_getStatus;
    private static Delegate? cb_getWeight;
    private static Delegate? cb_getWeightMode;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReadWeight._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReadWeight._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReadWeight._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReadWeight._members.ManagedPeerType;

    protected ReadWeight(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetStatusHandler()
    {
      if ((object) ReadWeight.cb_getStatus == null)
        ReadWeight.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ReadWeight.n_GetStatus));
      return ReadWeight.cb_getStatus;
    }

    private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReadWeight>(jnienv, native__this, (JniHandleOwnership) 0).Status;
    }

    public virtual unsafe int Status
    {
      [Register("getStatus", "()I", "GetGetStatusHandler")] get
      {
        return ReadWeight._members.InstanceMethods.InvokeVirtualInt32Method("getStatus.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetWeightHandler()
    {
      if ((object) ReadWeight.cb_getWeight == null)
        ReadWeight.cb_getWeight = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_D(ReadWeight.n_GetWeight));
      return ReadWeight.cb_getWeight;
    }

    private static double n_GetWeight(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ReadWeight>(jnienv, native__this, (JniHandleOwnership) 0).Weight;
    }

    public virtual unsafe double Weight
    {
      [Register("getWeight", "()D", "GetGetWeightHandler")] get
      {
        return ReadWeight._members.InstanceMethods.InvokeVirtualDoubleMethod("getWeight.()D", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetWeightModeHandler()
    {
      if ((object) ReadWeight.cb_getWeightMode == null)
        ReadWeight.cb_getWeightMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReadWeight.n_GetWeightMode));
      return ReadWeight.cb_getWeightMode;
    }

    private static IntPtr n_GetWeightMode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReadWeight>(jnienv, native__this, (JniHandleOwnership) 0).WeightMode);
    }

    public virtual unsafe string? WeightMode
    {
      [Register("getWeightMode", "()Ljava/lang/String;", "GetGetWeightModeHandler")] get
      {
        JniObjectReference jniObjectReference = ReadWeight._members.InstanceMethods.InvokeVirtualObjectMethod("getWeightMode.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
