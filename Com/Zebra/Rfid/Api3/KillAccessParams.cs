// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.KillAccessParams
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
  [Register("com/zebra/rfid/api3/KillAccessParams", DoNotGenerateAcw = true)]
  public class KillAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/KillAccessParams", typeof (KillAccessParams));
    private static Delegate? cb_getKillPassword;
    private static Delegate? cb_setKillPassword_J;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = KillAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => KillAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = KillAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => KillAccessParams._members.ManagedPeerType;

    protected KillAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe KillAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = KillAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      KillAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(J)V", "")]
    public unsafe KillAccessParams(long m_nKillPassword)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(m_nKillPassword)
      };
      JniObjectReference instance = KillAccessParams._members.InstanceMethods.StartCreateInstance("(J)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      KillAccessParams._members.InstanceMethods.FinishCreateInstance("(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetKillPasswordHandler()
    {
      if ((object) KillAccessParams.cb_getKillPassword == null)
        KillAccessParams.cb_getKillPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(KillAccessParams.n_GetKillPassword));
      return KillAccessParams.cb_getKillPassword;
    }

    private static long n_GetKillPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<KillAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword;
    }

    private static Delegate GetSetKillPassword_JHandler()
    {
      if ((object) KillAccessParams.cb_setKillPassword_J == null)
        KillAccessParams.cb_setKillPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(KillAccessParams.n_SetKillPassword_J));
      return KillAccessParams.cb_setKillPassword_J;
    }

    private static void n_SetKillPassword_J(IntPtr jnienv, IntPtr native__this, long killPassword)
    {
      Object.GetObject<KillAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword = killPassword;
    }

    public virtual unsafe long KillPassword
    {
      [Register("getKillPassword", "()J", "GetGetKillPasswordHandler")] get
      {
        return KillAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getKillPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setKillPassword", "(J)V", "GetSetKillPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        KillAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setKillPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
