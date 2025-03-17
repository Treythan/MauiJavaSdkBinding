// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LockAccessParams
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
  [Register("com/zebra/rfid/api3/LockAccessParams", DoNotGenerateAcw = true)]
  public class LockAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LockAccessParams", typeof (LockAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_getAccessPasswordMemoryIndex;
    private static Delegate? cb_getEPCMemoryIndex;
    private static Delegate? cb_getKillPasswordMemoryIndex;
    private static Delegate? cb_getTIDMemoryIndex;
    private static Delegate? cb_getUserMemoryIndex;
    private static Delegate? cb_getLockPrivilege;
    private static Delegate? cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LockAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LockAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LockAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LockAccessParams._members.ManagedPeerType;

    protected LockAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe LockAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = LockAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      LockAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(J[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", "")]
    public unsafe LockAccessParams(long m_nAccessPassword, LOCK_PRIVILEGE[]? m_eLockPrivilege)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray<LOCK_PRIVILEGE>(m_eLockPrivilege);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(m_nAccessPassword),
          new JniArgumentValue(num)
        };
        JniObjectReference instance = LockAccessParams._members.InstanceMethods.StartCreateInstance("(J[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        LockAccessParams._members.InstanceMethods.FinishCreateInstance("(J[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_eLockPrivilege != null)
        {
          JNIEnv.CopyArray<LOCK_PRIVILEGE>(num, m_eLockPrivilege);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_eLockPrivilege);
      }
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) LockAccessParams.cb_getAccessPassword == null)
        LockAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(LockAccessParams.n_GetAccessPassword));
      return LockAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) LockAccessParams.cb_setAccessPassword_J == null)
        LockAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(LockAccessParams.n_SetAccessPassword_J));
      return LockAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long accessPassword)
    {
      Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetAccessPasswordMemoryIndexHandler()
    {
      if ((object) LockAccessParams.cb_getAccessPasswordMemoryIndex == null)
        LockAccessParams.cb_getAccessPasswordMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LockAccessParams.n_GetAccessPasswordMemoryIndex));
      return LockAccessParams.cb_getAccessPasswordMemoryIndex;
    }

    private static int n_GetAccessPasswordMemoryIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPasswordMemoryIndex;
    }

    public virtual unsafe int AccessPasswordMemoryIndex
    {
      [Register("getAccessPasswordMemoryIndex", "()I", "GetGetAccessPasswordMemoryIndexHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getAccessPasswordMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetEPCMemoryIndexHandler()
    {
      if ((object) LockAccessParams.cb_getEPCMemoryIndex == null)
        LockAccessParams.cb_getEPCMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LockAccessParams.n_GetEPCMemoryIndex));
      return LockAccessParams.cb_getEPCMemoryIndex;
    }

    private static int n_GetEPCMemoryIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).EPCMemoryIndex;
    }

    public virtual unsafe int EPCMemoryIndex
    {
      [Register("getEPCMemoryIndex", "()I", "GetGetEPCMemoryIndexHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getEPCMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetKillPasswordMemoryIndexHandler()
    {
      if ((object) LockAccessParams.cb_getKillPasswordMemoryIndex == null)
        LockAccessParams.cb_getKillPasswordMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LockAccessParams.n_GetKillPasswordMemoryIndex));
      return LockAccessParams.cb_getKillPasswordMemoryIndex;
    }

    private static int n_GetKillPasswordMemoryIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).KillPasswordMemoryIndex;
    }

    public virtual unsafe int KillPasswordMemoryIndex
    {
      [Register("getKillPasswordMemoryIndex", "()I", "GetGetKillPasswordMemoryIndexHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getKillPasswordMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTIDMemoryIndexHandler()
    {
      if ((object) LockAccessParams.cb_getTIDMemoryIndex == null)
        LockAccessParams.cb_getTIDMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LockAccessParams.n_GetTIDMemoryIndex));
      return LockAccessParams.cb_getTIDMemoryIndex;
    }

    private static int n_GetTIDMemoryIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).TIDMemoryIndex;
    }

    public virtual unsafe int TIDMemoryIndex
    {
      [Register("getTIDMemoryIndex", "()I", "GetGetTIDMemoryIndexHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getTIDMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetUserMemoryIndexHandler()
    {
      if ((object) LockAccessParams.cb_getUserMemoryIndex == null)
        LockAccessParams.cb_getUserMemoryIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LockAccessParams.n_GetUserMemoryIndex));
      return LockAccessParams.cb_getUserMemoryIndex;
    }

    private static int n_GetUserMemoryIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).UserMemoryIndex;
    }

    public virtual unsafe int UserMemoryIndex
    {
      [Register("getUserMemoryIndex", "()I", "GetGetUserMemoryIndexHandler")] get
      {
        return LockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getUserMemoryIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLockPrivilegeHandler()
    {
      if ((object) LockAccessParams.cb_getLockPrivilege == null)
        LockAccessParams.cb_getLockPrivilege = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LockAccessParams.n_GetLockPrivilege));
      return LockAccessParams.cb_getLockPrivilege;
    }

    private static IntPtr n_GetLockPrivilege(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<LOCK_PRIVILEGE>(Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetLockPrivilege());
    }

    [Register("getLockPrivilege", "()[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", "GetGetLockPrivilegeHandler")]
    public virtual unsafe LOCK_PRIVILEGE[]? GetLockPrivilege()
    {
      JniObjectReference jniObjectReference = LockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getLockPrivilege.()[Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (LOCK_PRIVILEGE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (LOCK_PRIVILEGE));
    }

    private static Delegate GetSetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_Handler()
    {
      if ((object) LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_ == null)
        LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(LockAccessParams.n_SetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_));
      return LockAccessParams.cb_setLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_;
    }

    private static void n_SetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_lockDataField,
      IntPtr native_lockPrivilege)
    {
      LockAccessParams lockAccessParams = Object.GetObject<LockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
      LOCK_DATA_FIELD lockDataField1 = Object.GetObject<LOCK_DATA_FIELD>(native_lockDataField, (JniHandleOwnership) 0);
      LOCK_PRIVILEGE lockPrivilege1 = Object.GetObject<LOCK_PRIVILEGE>(native_lockPrivilege, (JniHandleOwnership) 0);
      LOCK_DATA_FIELD lockDataField2 = lockDataField1;
      LOCK_PRIVILEGE lockPrivilege2 = lockPrivilege1;
      lockAccessParams.SetLockPrivilege(lockDataField2, lockPrivilege2);
    }

    [Register("setLockPrivilege", "(Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", "GetSetLockPrivilege_Lcom_zebra_rfid_api3_LOCK_DATA_FIELD_Lcom_zebra_rfid_api3_LOCK_PRIVILEGE_Handler")]
    public virtual unsafe void SetLockPrivilege(
      LOCK_DATA_FIELD? lockDataField,
      LOCK_PRIVILEGE? lockPrivilege)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(lockDataField == null ? IntPtr.Zero : lockDataField.Handle),
          new JniArgumentValue(lockPrivilege == null ? IntPtr.Zero : lockPrivilege.Handle)
        };
        LockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setLockPrivilege.(Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) lockDataField);
        GC.KeepAlive((object) lockPrivilege);
      }
    }
  }
}
