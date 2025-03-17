// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.VersionInfo
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
  [Register("com/zebra/rfid/api3/VersionInfo", DoNotGenerateAcw = true)]
  public class VersionInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/VersionInfo", typeof (VersionInfo));
    private static Delegate? cb_getVersion;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = VersionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => VersionInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = VersionInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => VersionInfo._members.ManagedPeerType;

    protected VersionInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetVersionHandler()
    {
      if ((object) VersionInfo.cb_getVersion == null)
        VersionInfo.cb_getVersion = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(VersionInfo.n_GetVersion));
      return VersionInfo.cb_getVersion;
    }

    private static IntPtr n_GetVersion(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<VersionInfo>(jnienv, native__this, (JniHandleOwnership) 0).Version);
    }

    public virtual unsafe string? Version
    {
      [Register("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")] get
      {
        JniObjectReference jniObjectReference = VersionInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getVersion.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
