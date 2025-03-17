// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.IMsgInvoker
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
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/IMsg", DoNotGenerateAcw = true)]
  internal class IMsgInvoker : Object, IMsg, IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/IMsg", typeof (IMsgInvoker));
    private IntPtr class_ref;
    private static Delegate? cb_getMsgType;
    private IntPtr id_getMsgType;

    private static IntPtr java_class_ref
    {
      get
      {
        JniObjectReference peerReference = IMsgInvoker._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IMsgInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass => this.class_ref;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IMsgInvoker._members.ManagedPeerType;

    public static IMsg? GetObject(IntPtr handle, JniHandleOwnership transfer)
    {
      return Object.GetObject<IMsg>(handle, transfer);
    }

    private static IntPtr Validate(IntPtr handle)
    {
      return JNIEnv.IsInstanceOf(handle, IMsgInvoker.java_class_ref) ? handle : throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.zebra.ASCII_SDK.IMsg'.");
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.class_ref != IntPtr.Zero)
        JNIEnv.DeleteGlobalRef(this.class_ref);
      this.class_ref = IntPtr.Zero;
      base.Dispose(disposing);
    }

    public IMsgInvoker(IntPtr handle, JniHandleOwnership transfer)
      : base(IMsgInvoker.Validate(handle), transfer)
    {
      IntPtr objectClass = JNIEnv.GetObjectClass(this.Handle);
      this.class_ref = JNIEnv.NewGlobalRef(objectClass);
      JNIEnv.DeleteLocalRef(objectClass);
    }

    private static Delegate GetGetMsgTypeHandler()
    {
      if ((object) IMsgInvoker.cb_getMsgType == null)
        IMsgInvoker.cb_getMsgType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IMsgInvoker.n_GetMsgType));
      return IMsgInvoker.cb_getMsgType;
    }

    private static IntPtr n_GetMsgType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IMsg>(jnienv, native__this, (JniHandleOwnership) 0).MsgType);
    }

    public MSG_TYPE? MsgType
    {
      get
      {
        if (this.id_getMsgType == IntPtr.Zero)
          this.id_getMsgType = JNIEnv.GetMethodID(this.class_ref, "getMsgType", "()Lcom/zebra/ASCII_SDK/MSG_TYPE;");
        return Object.GetObject<MSG_TYPE>(JNIEnv.CallObjectMethod(this.Handle, this.id_getMsgType), (JniHandleOwnership) 1);
      }
    }
  }
}
