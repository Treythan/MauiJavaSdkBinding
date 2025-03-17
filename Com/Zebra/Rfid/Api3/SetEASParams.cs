// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SetEASParams
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
  [Register("com/zebra/rfid/api3/SetEASParams", DoNotGenerateAcw = true)]
  public class SetEASParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SetEASParams", typeof (SetEASParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_isEASSet;
    private static Delegate? cb_setEAS_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SetEASParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SetEASParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SetEASParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SetEASParams._members.ManagedPeerType;

    protected SetEASParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SetEASParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SetEASParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SetEASParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(JZ)V", "")]
    public unsafe SetEASParams(long m_nAccessPassword, bool m_bSetEAS)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
      {
        new JniArgumentValue(m_nAccessPassword),
        new JniArgumentValue(m_bSetEAS)
      };
      JniObjectReference instance = SetEASParams._members.InstanceMethods.StartCreateInstance("(JZ)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SetEASParams._members.InstanceMethods.FinishCreateInstance("(JZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) SetEASParams.cb_getAccessPassword == null)
        SetEASParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(SetEASParams.n_GetAccessPassword));
      return SetEASParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SetEASParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) SetEASParams.cb_setAccessPassword_J == null)
        SetEASParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(SetEASParams.n_SetAccessPassword_J));
      return SetEASParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long accessPassword)
    {
      Object.GetObject<SetEASParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return SetEASParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SetEASParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsEASSetHandler()
    {
      if ((object) SetEASParams.cb_isEASSet == null)
        SetEASParams.cb_isEASSet = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(SetEASParams.n_IsEASSet));
      return SetEASParams.cb_isEASSet;
    }

    private static bool n_IsEASSet(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SetEASParams>(jnienv, native__this, (JniHandleOwnership) 0).IsEASSet;
    }

    public virtual unsafe bool IsEASSet
    {
      [Register("isEASSet", "()Z", "GetIsEASSetHandler")] get
      {
        return SetEASParams._members.InstanceMethods.InvokeVirtualBooleanMethod("isEASSet.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetSetEAS_ZHandler()
    {
      if ((object) SetEASParams.cb_setEAS_Z == null)
        SetEASParams.cb_setEAS_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(SetEASParams.n_SetEAS_Z));
      return SetEASParams.cb_setEAS_Z;
    }

    private static void n_SetEAS_Z(IntPtr jnienv, IntPtr native__this, bool setEAS)
    {
      Object.GetObject<SetEASParams>(jnienv, native__this, (JniHandleOwnership) 0).SetEAS(setEAS);
    }

    [Register("setEAS", "(Z)V", "GetSetEAS_ZHandler")]
    public virtual unsafe void SetEAS(bool setEAS)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(setEAS)
      };
      SetEASParams._members.InstanceMethods.InvokeVirtualVoidMethod("setEAS.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
