// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ProfileInfo
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
  [Register("com/zebra/rfid/api3/ProfileInfo", DoNotGenerateAcw = true)]
  public class ProfileInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ProfileInfo", typeof (ProfileInfo));
    private static Delegate? cb_getActiveProfileIndex;
    private static Delegate? cb_getProfileNames;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ProfileInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ProfileInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ProfileInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ProfileInfo._members.ManagedPeerType;

    protected ProfileInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "([Ljava/lang/String;I)V", "")]
    public unsafe ProfileInfo(string[]? m_profileNames, int m_activeProfileIndex)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray(m_profileNames);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(m_activeProfileIndex)
        };
        JniObjectReference instance = ProfileInfo._members.InstanceMethods.StartCreateInstance("([Ljava/lang/String;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ProfileInfo._members.InstanceMethods.FinishCreateInstance("([Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_profileNames != null)
        {
          JNIEnv.CopyArray(num, m_profileNames);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_profileNames);
      }
    }

    private static Delegate GetGetActiveProfileIndexHandler()
    {
      if ((object) ProfileInfo.cb_getActiveProfileIndex == null)
        ProfileInfo.cb_getActiveProfileIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ProfileInfo.n_GetActiveProfileIndex));
      return ProfileInfo.cb_getActiveProfileIndex;
    }

    private static int n_GetActiveProfileIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ProfileInfo>(jnienv, native__this, (JniHandleOwnership) 0).ActiveProfileIndex;
    }

    public virtual unsafe int ActiveProfileIndex
    {
      [Register("getActiveProfileIndex", "()I", "GetGetActiveProfileIndexHandler")] get
      {
        return ProfileInfo._members.InstanceMethods.InvokeVirtualInt32Method("getActiveProfileIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetProfileNamesHandler()
    {
      if ((object) ProfileInfo.cb_getProfileNames == null)
        ProfileInfo.cb_getProfileNames = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ProfileInfo.n_GetProfileNames));
      return ProfileInfo.cb_getProfileNames;
    }

    private static IntPtr n_GetProfileNames(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<ProfileInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetProfileNames());
    }

    [Register("getProfileNames", "()[Ljava/lang/String;", "GetGetProfileNamesHandler")]
    public virtual unsafe string[]? GetProfileNames()
    {
      JniObjectReference jniObjectReference = ProfileInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getProfileNames.()[Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (string[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (string));
    }
  }
}
