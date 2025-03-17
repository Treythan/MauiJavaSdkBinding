// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFIDConnectionMgr
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
  [Register("com/zebra/rfid/api3/RFIDConnectionMgr", DoNotGenerateAcw = true)]
  public class RFIDConnectionMgr : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDConnectionMgr", typeof (RFIDConnectionMgr));
    private static Delegate? cb_getManagerPid;
    private static Delegate? cb_setManagerPid_I;
    private static Delegate? cb_getOwnerPackageName;
    private static Delegate? cb_setOwnerPackageName_Ljava_lang_String_;
    private static Delegate? cb_getOwnerPid;
    private static Delegate? cb_setOwnerPid_I;
    private static Delegate? cb_getReaderName;
    private static Delegate? cb_setReaderName_Ljava_lang_String_;
    private static Delegate? cb_notifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_;
    private static Delegate? cb_removeBinderEntry_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFIDConnectionMgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFIDConnectionMgr._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFIDConnectionMgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFIDConnectionMgr._members.ManagedPeerType;

    protected RFIDConnectionMgr(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RFIDConnectionMgr()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RFIDConnectionMgr._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RFIDConnectionMgr._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetManagerPidHandler()
    {
      if ((object) RFIDConnectionMgr.cb_getManagerPid == null)
        RFIDConnectionMgr.cb_getManagerPid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDConnectionMgr.n_GetManagerPid));
      return RFIDConnectionMgr.cb_getManagerPid;
    }

    private static int n_GetManagerPid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).ManagerPid;
    }

    private static Delegate GetSetManagerPid_IHandler()
    {
      if ((object) RFIDConnectionMgr.cb_setManagerPid_I == null)
        RFIDConnectionMgr.cb_setManagerPid_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RFIDConnectionMgr.n_SetManagerPid_I));
      return RFIDConnectionMgr.cb_setManagerPid_I;
    }

    private static void n_SetManagerPid_I(IntPtr jnienv, IntPtr native__this, int pid)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).ManagerPid = pid;
    }

    public virtual unsafe int ManagerPid
    {
      [Register("getManagerPid", "()I", "GetGetManagerPidHandler")] get
      {
        return RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualInt32Method("getManagerPid.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setManagerPid", "(I)V", "GetSetManagerPid_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("setManagerPid.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOwnerPackageNameHandler()
    {
      if ((object) RFIDConnectionMgr.cb_getOwnerPackageName == null)
        RFIDConnectionMgr.cb_getOwnerPackageName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDConnectionMgr.n_GetOwnerPackageName));
      return RFIDConnectionMgr.cb_getOwnerPackageName;
    }

    private static IntPtr n_GetOwnerPackageName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).OwnerPackageName);
    }

    private static Delegate GetSetOwnerPackageName_Ljava_lang_String_Handler()
    {
      if ((object) RFIDConnectionMgr.cb_setOwnerPackageName_Ljava_lang_String_ == null)
        RFIDConnectionMgr.cb_setOwnerPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDConnectionMgr.n_SetOwnerPackageName_Ljava_lang_String_));
      return RFIDConnectionMgr.cb_setOwnerPackageName_Ljava_lang_String_;
    }

    private static void n_SetOwnerPackageName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_pkgName)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).OwnerPackageName = JNIEnv.GetString(native_pkgName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? OwnerPackageName
    {
      [Register("getOwnerPackageName", "()Ljava/lang/String;", "GetGetOwnerPackageNameHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualObjectMethod("getOwnerPackageName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setOwnerPackageName", "(Ljava/lang/String;)V", "GetSetOwnerPackageName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("setOwnerPackageName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetOwnerPidHandler()
    {
      if ((object) RFIDConnectionMgr.cb_getOwnerPid == null)
        RFIDConnectionMgr.cb_getOwnerPid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDConnectionMgr.n_GetOwnerPid));
      return RFIDConnectionMgr.cb_getOwnerPid;
    }

    private static int n_GetOwnerPid(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).OwnerPid;
    }

    private static Delegate GetSetOwnerPid_IHandler()
    {
      if ((object) RFIDConnectionMgr.cb_setOwnerPid_I == null)
        RFIDConnectionMgr.cb_setOwnerPid_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RFIDConnectionMgr.n_SetOwnerPid_I));
      return RFIDConnectionMgr.cb_setOwnerPid_I;
    }

    private static void n_SetOwnerPid_I(IntPtr jnienv, IntPtr native__this, int pid)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).OwnerPid = pid;
    }

    public virtual unsafe int OwnerPid
    {
      [Register("getOwnerPid", "()I", "GetGetOwnerPidHandler")] get
      {
        return RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualInt32Method("getOwnerPid.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOwnerPid", "(I)V", "GetSetOwnerPid_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("setOwnerPid.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetReaderNameHandler()
    {
      if ((object) RFIDConnectionMgr.cb_getReaderName == null)
        RFIDConnectionMgr.cb_getReaderName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDConnectionMgr.n_GetReaderName));
      return RFIDConnectionMgr.cb_getReaderName;
    }

    private static IntPtr n_GetReaderName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).ReaderName);
    }

    private static Delegate GetSetReaderName_Ljava_lang_String_Handler()
    {
      if ((object) RFIDConnectionMgr.cb_setReaderName_Ljava_lang_String_ == null)
        RFIDConnectionMgr.cb_setReaderName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDConnectionMgr.n_SetReaderName_Ljava_lang_String_));
      return RFIDConnectionMgr.cb_setReaderName_Ljava_lang_String_;
    }

    private static void n_SetReaderName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerName)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).ReaderName = JNIEnv.GetString(native_readerName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? ReaderName
    {
      [Register("getReaderName", "()Ljava/lang/String;", "GetGetReaderNameHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setReaderName", "(Ljava/lang/String;)V", "GetSetReaderName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("setReaderName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    public static unsafe RFIDConnectionMgr? RfidConnectionMgr
    {
      [Register("getRfidConnectionMgr", "()Lcom/zebra/rfid/api3/RFIDConnectionMgr;", "")] get
      {
        JniObjectReference jniObjectReference = RFIDConnectionMgr._members.StaticMethods.InvokeObjectMethod("getRfidConnectionMgr.()Lcom/zebra/rfid/api3/RFIDConnectionMgr;", (JniArgumentValue*) null);
        return Object.GetObject<RFIDConnectionMgr>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetNotifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_Handler()
    {
      if ((object) RFIDConnectionMgr.cb_notifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_ == null)
        RFIDConnectionMgr.cb_notifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDConnectionMgr.n_NotifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_));
      return RFIDConnectionMgr.cb_notifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_;
    }

    private static void n_NotifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readerAttachStatus)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).NotifyAllBindApps(Object.GetObject<ENUM_SERVICE_STATUS>(native_readerAttachStatus, (JniHandleOwnership) 0));
    }

    [Register("notifyAllBindApps", "(Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;)V", "GetNotifyAllBindApps_Lcom_zebra_rfid_api3_ENUM_SERVICE_STATUS_Handler")]
    public virtual unsafe void NotifyAllBindApps(ENUM_SERVICE_STATUS? readerAttachStatus)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(readerAttachStatus == null ? IntPtr.Zero : ((Object) readerAttachStatus).Handle)
        };
        RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("notifyAllBindApps.(Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readerAttachStatus);
      }
    }

    private static Delegate GetRemoveBinderEntry_IHandler()
    {
      if ((object) RFIDConnectionMgr.cb_removeBinderEntry_I == null)
        RFIDConnectionMgr.cb_removeBinderEntry_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(RFIDConnectionMgr.n_RemoveBinderEntry_I));
      return RFIDConnectionMgr.cb_removeBinderEntry_I;
    }

    private static void n_RemoveBinderEntry_I(IntPtr jnienv, IntPtr native__this, int handle)
    {
      Object.GetObject<RFIDConnectionMgr>(jnienv, native__this, (JniHandleOwnership) 0).RemoveBinderEntry(handle);
    }

    [Register("removeBinderEntry", "(I)V", "GetRemoveBinderEntry_IHandler")]
    public virtual unsafe void RemoveBinderEntry(int handle)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(handle)
      };
      RFIDConnectionMgr._members.InstanceMethods.InvokeVirtualVoidMethod("removeBinderEntry.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
