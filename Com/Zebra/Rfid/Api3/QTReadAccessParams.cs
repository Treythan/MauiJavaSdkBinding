// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.QTReadAccessParams
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
  [Register("com/zebra/rfid/api3/QTReadAccessParams", DoNotGenerateAcw = true)]
  public class QTReadAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/QTReadAccessParams", typeof (QTReadAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = QTReadAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => QTReadAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = QTReadAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => QTReadAccessParams._members.ManagedPeerType;

    protected QTReadAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe QTReadAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = QTReadAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      QTReadAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) QTReadAccessParams.cb_getAccessPassword == null)
        QTReadAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(QTReadAccessParams.n_GetAccessPassword));
      return QTReadAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<QTReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) QTReadAccessParams.cb_setAccessPassword_J == null)
        QTReadAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(QTReadAccessParams.n_SetAccessPassword_J));
      return QTReadAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long m_nAccessPassword)
    {
      Object.GetObject<QTReadAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = m_nAccessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return QTReadAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        QTReadAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
