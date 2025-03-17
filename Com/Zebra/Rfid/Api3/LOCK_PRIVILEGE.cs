// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LOCK_PRIVILEGE
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
  [Register("com/zebra/rfid/api3/LOCK_PRIVILEGE", DoNotGenerateAcw = true)]
  public class LOCK_PRIVILEGE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LOCK_PRIVILEGE", typeof (LOCK_PRIVILEGE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("LOCK_PRIVILEGE_NONE")]
    public static LOCK_PRIVILEGE? LockPrivilegeNone
    {
      get
      {
        JniObjectReference objectValue = LOCK_PRIVILEGE._members.StaticFields.GetObjectValue("LOCK_PRIVILEGE_NONE.Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;");
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_PRIVILEGE_PERMA_LOCK")]
    public static LOCK_PRIVILEGE? LockPrivilegePermaLock
    {
      get
      {
        JniObjectReference objectValue = LOCK_PRIVILEGE._members.StaticFields.GetObjectValue("LOCK_PRIVILEGE_PERMA_LOCK.Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;");
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_PRIVILEGE_PERMA_UNLOCK")]
    public static LOCK_PRIVILEGE? LockPrivilegePermaUnlock
    {
      get
      {
        JniObjectReference objectValue = LOCK_PRIVILEGE._members.StaticFields.GetObjectValue("LOCK_PRIVILEGE_PERMA_UNLOCK.Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;");
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_PRIVILEGE_READ_WRITE")]
    public static LOCK_PRIVILEGE? LockPrivilegeReadWrite
    {
      get
      {
        JniObjectReference objectValue = LOCK_PRIVILEGE._members.StaticFields.GetObjectValue("LOCK_PRIVILEGE_READ_WRITE.Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;");
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_PRIVILEGE_UNLOCK")]
    public static LOCK_PRIVILEGE? LockPrivilegeUnlock
    {
      get
      {
        JniObjectReference objectValue = LOCK_PRIVILEGE._members.StaticFields.GetObjectValue("LOCK_PRIVILEGE_UNLOCK.Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;");
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return LOCK_PRIVILEGE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        LOCK_PRIVILEGE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LOCK_PRIVILEGE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LOCK_PRIVILEGE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LOCK_PRIVILEGE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LOCK_PRIVILEGE._members.ManagedPeerType;

    protected LOCK_PRIVILEGE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) LOCK_PRIVILEGE.cb_getValue == null)
        LOCK_PRIVILEGE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LOCK_PRIVILEGE.n_GetValue));
      return LOCK_PRIVILEGE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LOCK_PRIVILEGE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return LOCK_PRIVILEGE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetLockPrivilegeName", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", "")]
    public static unsafe LOCK_PRIVILEGE? GetLockPrivilegeName(string? lockPrivilege)
    {
      IntPtr num = JNIEnv.NewString(lockPrivilege);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = LOCK_PRIVILEGE._members.StaticMethods.InvokeObjectMethod("GetLockPrivilegeName.(Ljava/lang/String;)Lcom/zebra/rfid/api3/LOCK_PRIVILEGE;", jniArgumentValuePtr);
        return Object.GetObject<LOCK_PRIVILEGE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) LOCK_PRIVILEGE.cb_equals_I == null)
        LOCK_PRIVILEGE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(LOCK_PRIVILEGE.n_Equals_I));
      return LOCK_PRIVILEGE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<LOCK_PRIVILEGE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return LOCK_PRIVILEGE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
