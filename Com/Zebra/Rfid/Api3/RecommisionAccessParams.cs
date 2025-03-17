// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RecommisionAccessParams
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
  [Register("com/zebra/rfid/api3/RecommisionAccessParams", DoNotGenerateAcw = true)]
  public class RecommisionAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RecommisionAccessParams", typeof (RecommisionAccessParams));
    private static Delegate? cb_getKillPassword;
    private static Delegate? cb_setKillPassword_J;
    private static Delegate? cb_getOpCode;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RecommisionAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RecommisionAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RecommisionAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RecommisionAccessParams._members.ManagedPeerType;

    protected RecommisionAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RecommisionAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RecommisionAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RecommisionAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetKillPasswordHandler()
    {
      if ((object) RecommisionAccessParams.cb_getKillPassword == null)
        RecommisionAccessParams.cb_getKillPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(RecommisionAccessParams.n_GetKillPassword));
      return RecommisionAccessParams.cb_getKillPassword;
    }

    private static long n_GetKillPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword;
    }

    private static Delegate GetSetKillPassword_JHandler()
    {
      if ((object) RecommisionAccessParams.cb_setKillPassword_J == null)
        RecommisionAccessParams.cb_setKillPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(RecommisionAccessParams.n_SetKillPassword_J));
      return RecommisionAccessParams.cb_setKillPassword_J;
    }

    private static void n_SetKillPassword_J(IntPtr jnienv, IntPtr native__this, long killPassword)
    {
      Object.GetObject<RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPassword = killPassword;
    }

    public virtual unsafe long KillPassword
    {
      [Register("getKillPassword", "()J", "GetGetKillPasswordHandler")] get
      {
        return RecommisionAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getKillPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setKillPassword", "(J)V", "GetSetKillPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RecommisionAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setKillPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOpCodeHandler()
    {
      if ((object) RecommisionAccessParams.cb_getOpCode == null)
        RecommisionAccessParams.cb_getOpCode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RecommisionAccessParams.n_GetOpCode));
      return RecommisionAccessParams.cb_getOpCode;
    }

    private static IntPtr n_GetOpCode(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RecommisionAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).OpCode);
    }

    public virtual unsafe Object? OpCode
    {
      [Register("getOpCode", "()Ljava/lang/Object;", "GetGetOpCodeHandler")] get
      {
        JniObjectReference jniObjectReference = RecommisionAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getOpCode.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
