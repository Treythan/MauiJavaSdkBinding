// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ChangeConfigParams
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
  [Register("com/zebra/rfid/api3/ChangeConfigParams", DoNotGenerateAcw = true)]
  public class ChangeConfigParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ChangeConfigParams", typeof (ChangeConfigParams));
    private static Delegate? cb_getAccessword;
    private static Delegate? cb_setAccessword_J;
    private static Delegate? cb_getNXPChangeConfigWord;
    private static Delegate? cb_setNXPChangeConfigWord_S;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ChangeConfigParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ChangeConfigParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ChangeConfigParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ChangeConfigParams._members.ManagedPeerType;

    protected ChangeConfigParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ChangeConfigParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ChangeConfigParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ChangeConfigParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccesswordHandler()
    {
      if ((object) ChangeConfigParams.cb_getAccessword == null)
        ChangeConfigParams.cb_getAccessword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(ChangeConfigParams.n_GetAccessword));
      return ChangeConfigParams.cb_getAccessword;
    }

    private static long n_GetAccessword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ChangeConfigParams>(jnienv, native__this, (JniHandleOwnership) 0).Accessword;
    }

    private static Delegate GetSetAccessword_JHandler()
    {
      if ((object) ChangeConfigParams.cb_setAccessword_J == null)
        ChangeConfigParams.cb_setAccessword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(ChangeConfigParams.n_SetAccessword_J));
      return ChangeConfigParams.cb_setAccessword_J;
    }

    private static void n_SetAccessword_J(IntPtr jnienv, IntPtr native__this, long m_nAccessword)
    {
      Object.GetObject<ChangeConfigParams>(jnienv, native__this, (JniHandleOwnership) 0).Accessword = m_nAccessword;
    }

    public virtual unsafe long Accessword
    {
      [Register("getAccessword", "()J", "GetGetAccesswordHandler")] get
      {
        return ChangeConfigParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessword", "(J)V", "GetSetAccessword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ChangeConfigParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNXPChangeConfigWordHandler()
    {
      if ((object) ChangeConfigParams.cb_getNXPChangeConfigWord == null)
        ChangeConfigParams.cb_getNXPChangeConfigWord = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(ChangeConfigParams.n_GetNXPChangeConfigWord));
      return ChangeConfigParams.cb_getNXPChangeConfigWord;
    }

    private static short n_GetNXPChangeConfigWord(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ChangeConfigParams>(jnienv, native__this, (JniHandleOwnership) 0).NXPChangeConfigWord;
    }

    private static Delegate GetSetNXPChangeConfigWord_SHandler()
    {
      if ((object) ChangeConfigParams.cb_setNXPChangeConfigWord_S == null)
        ChangeConfigParams.cb_setNXPChangeConfigWord_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(ChangeConfigParams.n_SetNXPChangeConfigWord_S));
      return ChangeConfigParams.cb_setNXPChangeConfigWord_S;
    }

    private static void n_SetNXPChangeConfigWord_S(
      IntPtr jnienv,
      IntPtr native__this,
      short m_NXPChangeConfigWord)
    {
      Object.GetObject<ChangeConfigParams>(jnienv, native__this, (JniHandleOwnership) 0).NXPChangeConfigWord = m_NXPChangeConfigWord;
    }

    public virtual unsafe short NXPChangeConfigWord
    {
      [Register("getNXPChangeConfigWord", "()S", "GetGetNXPChangeConfigWordHandler")] get
      {
        return ChangeConfigParams._members.InstanceMethods.InvokeVirtualInt16Method("getNXPChangeConfigWord.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNXPChangeConfigWord", "(S)V", "GetSetNXPChangeConfigWord_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        ChangeConfigParams._members.InstanceMethods.InvokeVirtualVoidMethod("setNXPChangeConfigWord.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
