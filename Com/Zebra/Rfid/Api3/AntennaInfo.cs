// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.AntennaInfo
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
  [Register("com/zebra/rfid/api3/AntennaInfo", DoNotGenerateAcw = true)]
  public class AntennaInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/AntennaInfo", typeof (AntennaInfo));
    private static Delegate? cb_getAntennaID;
    private static Delegate? cb_getAntennaOperationQualifier;
    private static Delegate? cb_setAntennaID_arrayS;
    private static Delegate? cb_setAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = AntennaInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => AntennaInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = AntennaInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => AntennaInfo._members.ManagedPeerType;

    protected AntennaInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe AntennaInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = AntennaInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      AntennaInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "([S)V", "")]
    public unsafe AntennaInfo(short[]? antennaID)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray(antennaID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference instance = AntennaInfo._members.InstanceMethods.StartCreateInstance("([S)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        AntennaInfo._members.InstanceMethods.FinishCreateInstance("([S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (antennaID != null)
        {
          JNIEnv.CopyArray(num, antennaID);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) antennaID);
      }
    }

    [Register(".ctor", "([S[Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;)V", "")]
    public unsafe AntennaInfo(short[]? antennaID, OPERATION_QUALIFIER[]? antennaOper)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewArray(antennaID);
      IntPtr num2 = JNIEnv.NewArray<OPERATION_QUALIFIER>(antennaOper);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        JniObjectReference instance = AntennaInfo._members.InstanceMethods.StartCreateInstance("([S[Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        AntennaInfo._members.InstanceMethods.FinishCreateInstance("([S[Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (antennaID != null)
        {
          JNIEnv.CopyArray(num1, antennaID);
          JNIEnv.DeleteLocalRef(num1);
        }
        if (antennaOper != null)
        {
          JNIEnv.CopyArray<OPERATION_QUALIFIER>(num2, antennaOper);
          JNIEnv.DeleteLocalRef(num2);
        }
        GC.KeepAlive((object) antennaID);
        GC.KeepAlive((object) antennaOper);
      }
    }

    private static Delegate GetGetAntennaIDHandler()
    {
      if ((object) AntennaInfo.cb_getAntennaID == null)
        AntennaInfo.cb_getAntennaID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AntennaInfo.n_GetAntennaID));
      return AntennaInfo.cb_getAntennaID;
    }

    private static IntPtr n_GetAntennaID(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<AntennaInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetAntennaID());
    }

    [Register("getAntennaID", "()[S", "GetGetAntennaIDHandler")]
    public virtual unsafe short[]? GetAntennaID()
    {
      JniObjectReference jniObjectReference = AntennaInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaID.()[S", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (short[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (short));
    }

    private static Delegate GetGetAntennaOperationQualifierHandler()
    {
      if ((object) AntennaInfo.cb_getAntennaOperationQualifier == null)
        AntennaInfo.cb_getAntennaOperationQualifier = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AntennaInfo.n_GetAntennaOperationQualifier));
      return AntennaInfo.cb_getAntennaOperationQualifier;
    }

    private static IntPtr n_GetAntennaOperationQualifier(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<OPERATION_QUALIFIER>(Object.GetObject<AntennaInfo>(jnienv, native__this, (JniHandleOwnership) 0).GetAntennaOperationQualifier());
    }

    [Register("getAntennaOperationQualifier", "()[Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;", "GetGetAntennaOperationQualifierHandler")]
    public virtual unsafe OPERATION_QUALIFIER[]? GetAntennaOperationQualifier()
    {
      JniObjectReference jniObjectReference = AntennaInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getAntennaOperationQualifier.()[Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (OPERATION_QUALIFIER[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (OPERATION_QUALIFIER));
    }

    private static Delegate GetSetAntennaID_arraySHandler()
    {
      if ((object) AntennaInfo.cb_setAntennaID_arrayS == null)
        AntennaInfo.cb_setAntennaID_arrayS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AntennaInfo.n_SetAntennaID_arrayS));
      return AntennaInfo.cb_setAntennaID_arrayS;
    }

    private static void n_SetAntennaID_arrayS(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_antennaID)
    {
      AntennaInfo antennaInfo = Object.GetObject<AntennaInfo>(jnienv, native__this, (JniHandleOwnership) 0);
      short[] array = (short[]) JNIEnv.GetArray(native_antennaID, (JniHandleOwnership) 0, typeof (short));
      short[] antennaID = array;
      antennaInfo.SetAntennaID(antennaID);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_antennaID);
    }

    [Register("setAntennaID", "([S)V", "GetSetAntennaID_arraySHandler")]
    public virtual unsafe void SetAntennaID(short[]? antennaID)
    {
      IntPtr num = JNIEnv.NewArray(antennaID);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        AntennaInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaID.([S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (antennaID != null)
        {
          JNIEnv.CopyArray(num, antennaID);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) antennaID);
      }
    }

    private static Delegate GetSetAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_Handler()
    {
      if ((object) AntennaInfo.cb_setAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_ == null)
        AntennaInfo.cb_setAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AntennaInfo.n_SetAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_));
      return AntennaInfo.cb_setAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_;
    }

    private static void n_SetAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_antennaOperationQualifier)
    {
      AntennaInfo antennaInfo = Object.GetObject<AntennaInfo>(jnienv, native__this, (JniHandleOwnership) 0);
      OPERATION_QUALIFIER[] array = (OPERATION_QUALIFIER[]) JNIEnv.GetArray(native_antennaOperationQualifier, (JniHandleOwnership) 0, typeof (OPERATION_QUALIFIER));
      OPERATION_QUALIFIER[] antennaOperationQualifier = array;
      antennaInfo.SetAntennaOperationQualifier(antennaOperationQualifier);
      if (array == null)
        return;
      JNIEnv.CopyArray<OPERATION_QUALIFIER>(array, native_antennaOperationQualifier);
    }

    [Register("setAntennaOperationQualifier", "([Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;)V", "GetSetAntennaOperationQualifier_arrayLcom_zebra_rfid_api3_OPERATION_QUALIFIER_Handler")]
    public virtual unsafe void SetAntennaOperationQualifier(
      OPERATION_QUALIFIER[]? antennaOperationQualifier)
    {
      IntPtr num = JNIEnv.NewArray<OPERATION_QUALIFIER>(antennaOperationQualifier);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        AntennaInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaOperationQualifier.([Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (antennaOperationQualifier != null)
        {
          JNIEnv.CopyArray<OPERATION_QUALIFIER>(num, antennaOperationQualifier);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) antennaOperationQualifier);
      }
    }
  }
}
