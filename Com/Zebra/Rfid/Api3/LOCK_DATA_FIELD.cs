// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LOCK_DATA_FIELD
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
  [Register("com/zebra/rfid/api3/LOCK_DATA_FIELD", DoNotGenerateAcw = true)]
  public class LOCK_DATA_FIELD : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LOCK_DATA_FIELD", typeof (LOCK_DATA_FIELD));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("LOCK_ACCESS_PASSWORD")]
    public static LOCK_DATA_FIELD? LockAccessPassword
    {
      get
      {
        JniObjectReference objectValue = LOCK_DATA_FIELD._members.StaticFields.GetObjectValue("LOCK_ACCESS_PASSWORD.Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;");
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_EPC_MEMORY")]
    public static LOCK_DATA_FIELD? LockEpcMemory
    {
      get
      {
        JniObjectReference objectValue = LOCK_DATA_FIELD._members.StaticFields.GetObjectValue("LOCK_EPC_MEMORY.Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;");
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_KILL_PASSWORD")]
    public static LOCK_DATA_FIELD? LockKillPassword
    {
      get
      {
        JniObjectReference objectValue = LOCK_DATA_FIELD._members.StaticFields.GetObjectValue("LOCK_KILL_PASSWORD.Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;");
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_TID_MEMORY")]
    public static LOCK_DATA_FIELD? LockTidMemory
    {
      get
      {
        JniObjectReference objectValue = LOCK_DATA_FIELD._members.StaticFields.GetObjectValue("LOCK_TID_MEMORY.Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;");
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCK_USER_MEMORY")]
    public static LOCK_DATA_FIELD? LockUserMemory
    {
      get
      {
        JniObjectReference objectValue = LOCK_DATA_FIELD._members.StaticFields.GetObjectValue("LOCK_USER_MEMORY.Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;");
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return LOCK_DATA_FIELD._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        LOCK_DATA_FIELD._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LOCK_DATA_FIELD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LOCK_DATA_FIELD._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LOCK_DATA_FIELD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LOCK_DATA_FIELD._members.ManagedPeerType;

    protected LOCK_DATA_FIELD(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) LOCK_DATA_FIELD.cb_getValue == null)
        LOCK_DATA_FIELD.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LOCK_DATA_FIELD.n_GetValue));
      return LOCK_DATA_FIELD.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LOCK_DATA_FIELD>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return LOCK_DATA_FIELD._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetLockDataFieldName", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;", "")]
    public static unsafe LOCK_DATA_FIELD? GetLockDataFieldName(string? lockDataField)
    {
      IntPtr num = JNIEnv.NewString(lockDataField);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = LOCK_DATA_FIELD._members.StaticMethods.InvokeObjectMethod("GetLockDataFieldName.(Ljava/lang/String;)Lcom/zebra/rfid/api3/LOCK_DATA_FIELD;", jniArgumentValuePtr);
        return Object.GetObject<LOCK_DATA_FIELD>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) LOCK_DATA_FIELD.cb_equals_I == null)
        LOCK_DATA_FIELD.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(LOCK_DATA_FIELD.n_Equals_I));
      return LOCK_DATA_FIELD.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<LOCK_DATA_FIELD>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return LOCK_DATA_FIELD._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
