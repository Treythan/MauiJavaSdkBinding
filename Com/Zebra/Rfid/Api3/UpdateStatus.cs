// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UpdateStatus
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
  [Register("com/zebra/rfid/api3/UpdateStatus", DoNotGenerateAcw = true)]
  public class UpdateStatus : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UpdateStatus", typeof (UpdateStatus));
    private static Delegate? cb_getPercentage;
    private static Delegate? cb_getUpdateInfo;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UpdateStatus._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UpdateStatus._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UpdateStatus._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UpdateStatus._members.ManagedPeerType;

    protected UpdateStatus(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetPercentageHandler()
    {
      if ((object) UpdateStatus.cb_getPercentage == null)
        UpdateStatus.cb_getPercentage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(UpdateStatus.n_GetPercentage));
      return UpdateStatus.cb_getPercentage;
    }

    private static int n_GetPercentage(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UpdateStatus>(jnienv, native__this, (JniHandleOwnership) 0).Percentage;
    }

    public virtual unsafe int Percentage
    {
      [Register("getPercentage", "()I", "GetGetPercentageHandler")] get
      {
        return UpdateStatus._members.InstanceMethods.InvokeVirtualInt32Method("getPercentage.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetUpdateInfoHandler()
    {
      if ((object) UpdateStatus.cb_getUpdateInfo == null)
        UpdateStatus.cb_getUpdateInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(UpdateStatus.n_GetUpdateInfo));
      return UpdateStatus.cb_getUpdateInfo;
    }

    private static IntPtr n_GetUpdateInfo(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<UpdateStatus>(jnienv, native__this, (JniHandleOwnership) 0).UpdateInfo);
    }

    public virtual unsafe string? UpdateInfo
    {
      [Register("getUpdateInfo", "()Ljava/lang/String;", "GetGetUpdateInfoHandler")] get
      {
        JniObjectReference jniObjectReference = UpdateStatus._members.InstanceMethods.InvokeVirtualObjectMethod("getUpdateInfo.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
