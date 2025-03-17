// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.DCSScannerInfo
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/DCSScannerInfo", DoNotGenerateAcw = true)]
  public class DCSScannerInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSScannerInfo", typeof (DCSScannerInfo));
    private static Delegate? cb_getAuxiliaryScanners;
    private static Delegate? cb_getConnectionType;
    private static Delegate? cb_isActive;
    private static Delegate? cb_isAutoCommunicationSessionReestablishment;
    private static Delegate? cb_getScannerHWSerialNumber;
    private static Delegate? cb_getScannerID;
    private static Delegate? cb_getScannerModel;
    private static Delegate? cb_getScannerName;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DCSScannerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DCSScannerInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DCSScannerInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DCSScannerInfo._members.ManagedPeerType;

    protected DCSScannerInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe DCSScannerInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = DCSScannerInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      DCSScannerInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAuxiliaryScannersHandler()
    {
      if ((object) DCSScannerInfo.cb_getAuxiliaryScanners == null)
        DCSScannerInfo.cb_getAuxiliaryScanners = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DCSScannerInfo.n_GetAuxiliaryScanners));
      return DCSScannerInfo.cb_getAuxiliaryScanners;
    }

    private static IntPtr n_GetAuxiliaryScanners(IntPtr jnienv, IntPtr native__this)
    {
      return JavaDictionary<Integer, DCSScannerInfo>.ToLocalJniHandle(Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).AuxiliaryScanners);
    }

    public virtual unsafe IDictionary<Integer, DCSScannerInfo>? AuxiliaryScanners
    {
      [Register("getAuxiliaryScanners", "()Ljava/util/HashMap;", "GetGetAuxiliaryScannersHandler")] get
      {
        JniObjectReference jniObjectReference = DCSScannerInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getAuxiliaryScanners.()Ljava/util/HashMap;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JavaDictionary<Integer, DCSScannerInfo>.FromJniHandle(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetConnectionTypeHandler()
    {
      if ((object) DCSScannerInfo.cb_getConnectionType == null)
        DCSScannerInfo.cb_getConnectionType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DCSScannerInfo.n_GetConnectionType));
      return DCSScannerInfo.cb_getConnectionType;
    }

    private static IntPtr n_GetConnectionType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).ConnectionType);
    }

    public virtual unsafe DCSSDKDefs.DCSSDK_CONN_TYPES? ConnectionType
    {
      [Register("getConnectionType", "()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", "GetGetConnectionTypeHandler")] get
      {
        JniObjectReference jniObjectReference = DCSScannerInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getConnectionType.()Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetIsActiveHandler()
    {
      if ((object) DCSScannerInfo.cb_isActive == null)
        DCSScannerInfo.cb_isActive = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(DCSScannerInfo.n_IsActive));
      return DCSScannerInfo.cb_isActive;
    }

    private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).IsActive;
    }

    public virtual unsafe bool IsActive
    {
      [Register("isActive", "()Z", "GetIsActiveHandler")] get
      {
        return DCSScannerInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isActive.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsAutoCommunicationSessionReestablishmentHandler()
    {
      if ((object) DCSScannerInfo.cb_isAutoCommunicationSessionReestablishment == null)
        DCSScannerInfo.cb_isAutoCommunicationSessionReestablishment = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(DCSScannerInfo.n_IsAutoCommunicationSessionReestablishment));
      return DCSScannerInfo.cb_isAutoCommunicationSessionReestablishment;
    }

    private static bool n_IsAutoCommunicationSessionReestablishment(
      IntPtr jnienv,
      IntPtr native__this)
    {
      return Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).IsAutoCommunicationSessionReestablishment;
    }

    public virtual unsafe bool IsAutoCommunicationSessionReestablishment
    {
      [Register("isAutoCommunicationSessionReestablishment", "()Z", "GetIsAutoCommunicationSessionReestablishmentHandler")] get
      {
        return DCSScannerInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("isAutoCommunicationSessionReestablishment.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetScannerHWSerialNumberHandler()
    {
      if ((object) DCSScannerInfo.cb_getScannerHWSerialNumber == null)
        DCSScannerInfo.cb_getScannerHWSerialNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DCSScannerInfo.n_GetScannerHWSerialNumber));
      return DCSScannerInfo.cb_getScannerHWSerialNumber;
    }

    private static IntPtr n_GetScannerHWSerialNumber(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).ScannerHWSerialNumber);
    }

    public virtual unsafe string? ScannerHWSerialNumber
    {
      [Register("getScannerHWSerialNumber", "()Ljava/lang/String;", "GetGetScannerHWSerialNumberHandler")] get
      {
        JniObjectReference jniObjectReference = DCSScannerInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerHWSerialNumber.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetScannerIDHandler()
    {
      if ((object) DCSScannerInfo.cb_getScannerID == null)
        DCSScannerInfo.cb_getScannerID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(DCSScannerInfo.n_GetScannerID));
      return DCSScannerInfo.cb_getScannerID;
    }

    private static int n_GetScannerID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).ScannerID;
    }

    public virtual unsafe int ScannerID
    {
      [Register("getScannerID", "()I", "GetGetScannerIDHandler")] get
      {
        return DCSScannerInfo._members.InstanceMethods.InvokeVirtualInt32Method("getScannerID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetScannerModelHandler()
    {
      if ((object) DCSScannerInfo.cb_getScannerModel == null)
        DCSScannerInfo.cb_getScannerModel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DCSScannerInfo.n_GetScannerModel));
      return DCSScannerInfo.cb_getScannerModel;
    }

    private static IntPtr n_GetScannerModel(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).ScannerModel);
    }

    public virtual unsafe string? ScannerModel
    {
      [Register("getScannerModel", "()Ljava/lang/String;", "GetGetScannerModelHandler")] get
      {
        JniObjectReference jniObjectReference = DCSScannerInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerModel.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetScannerNameHandler()
    {
      if ((object) DCSScannerInfo.cb_getScannerName == null)
        DCSScannerInfo.cb_getScannerName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DCSScannerInfo.n_GetScannerName));
      return DCSScannerInfo.cb_getScannerName;
    }

    private static IntPtr n_GetScannerName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DCSScannerInfo>(jnienv, native__this, (JniHandleOwnership) 0).ScannerName);
    }

    public virtual unsafe string? ScannerName
    {
      [Register("getScannerName", "()Ljava/lang/String;", "GetGetScannerNameHandler")] get
      {
        JniObjectReference jniObjectReference = DCSScannerInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
