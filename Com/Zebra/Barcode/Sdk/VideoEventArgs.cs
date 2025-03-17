// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Barcode.Sdk.VideoEventArgs
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
namespace Com.Zebra.Barcode.Sdk
{
  [Register("com/zebra/barcode/sdk/VideoEventArgs", DoNotGenerateAcw = true)]
  public class VideoEventArgs : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/barcode/sdk/VideoEventArgs", typeof (VideoEventArgs));
    private static Delegate? cb_getImageData;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = VideoEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => VideoEventArgs._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = VideoEventArgs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => VideoEventArgs._members.ManagedPeerType;

    protected VideoEventArgs(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetImageDataHandler()
    {
      if ((object) VideoEventArgs.cb_getImageData == null)
        VideoEventArgs.cb_getImageData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(VideoEventArgs.n_GetImageData));
      return VideoEventArgs.cb_getImageData;
    }

    private static IntPtr n_GetImageData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<VideoEventArgs>(jnienv, native__this, (JniHandleOwnership) 0).GetImageData());
    }

    [Register("getImageData", "()[B", "GetGetImageDataHandler")]
    public virtual unsafe byte[]? GetImageData()
    {
      JniObjectReference jniObjectReference = VideoEventArgs._members.InstanceMethods.InvokeVirtualObjectMethod("getImageData.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }
  }
}
