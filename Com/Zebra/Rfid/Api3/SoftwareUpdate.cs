// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SoftwareUpdate
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/SoftwareUpdate", DoNotGenerateAcw = true)]
  public class SoftwareUpdate : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SoftwareUpdate", typeof (SoftwareUpdate));
    private static Delegate? cb_getUpdateStatus;
    private static Delegate? cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_;
    private static Delegate? cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SoftwareUpdate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SoftwareUpdate._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SoftwareUpdate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SoftwareUpdate._members.ManagedPeerType;

    protected SoftwareUpdate(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SoftwareUpdate()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SoftwareUpdate._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SoftwareUpdate._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetUpdateStatusHandler()
    {
      if ((object) SoftwareUpdate.cb_getUpdateStatus == null)
        SoftwareUpdate.cb_getUpdateStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(SoftwareUpdate.n_GetUpdateStatus));
      return SoftwareUpdate.cb_getUpdateStatus;
    }

    private static bool n_GetUpdateStatus(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SoftwareUpdate>(jnienv, native__this, (JniHandleOwnership) 0).UpdateStatus;
    }

    public virtual unsafe bool UpdateStatus
    {
      [Register("getUpdateStatus", "()Z", "GetGetUpdateStatusHandler")] get
      {
        return SoftwareUpdate._members.InstanceMethods.InvokeVirtualBooleanMethod("getUpdateStatus.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetUpdate_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Handler()
    {
      if ((object) SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_ == null)
        SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SoftwareUpdate.n_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_));
      return SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_;
    }

    private static void n_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_softwareUpdateInfo)
    {
      Object.GetObject<SoftwareUpdate>(jnienv, native__this, (JniHandleOwnership) 0).Update(Object.GetObject<SoftwareUpdateInfo>(native_softwareUpdateInfo, (JniHandleOwnership) 0));
    }

    [Register("Update", "(Lcom/zebra/rfid/api3/SoftwareUpdateInfo;)V", "GetUpdate_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Handler")]
    public virtual unsafe void Update(SoftwareUpdateInfo? softwareUpdateInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(softwareUpdateInfo == null ? IntPtr.Zero : softwareUpdateInfo.Handle)
        };
        SoftwareUpdate._members.InstanceMethods.InvokeVirtualVoidMethod("Update.(Lcom/zebra/rfid/api3/SoftwareUpdateInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) softwareUpdateInfo);
      }
    }

    private static Delegate GetUpdate_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_Handler()
    {
      if ((object) SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_ == null)
        SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(SoftwareUpdate.n_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_));
      return SoftwareUpdate.cb_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_;
    }

    private static void n_Update_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_softwareUpdateInfo,
      IntPtr native_context,
      IntPtr native_uriList)
    {
      SoftwareUpdate softwareUpdate = Object.GetObject<SoftwareUpdate>(jnienv, native__this, (JniHandleOwnership) 0);
      SoftwareUpdateInfo softwareUpdateInfo1 = Object.GetObject<SoftwareUpdateInfo>(native_softwareUpdateInfo, (JniHandleOwnership) 0);
      Context context1 = Object.GetObject<Context>(native_context, (JniHandleOwnership) 0);
      IList<Uri> uriList1 = JavaList<Uri>.FromJniHandle(native_uriList, (JniHandleOwnership) 0);
      SoftwareUpdateInfo softwareUpdateInfo2 = softwareUpdateInfo1;
      Context context2 = context1;
      IList<Uri> uriList2 = uriList1;
      softwareUpdate.Update(softwareUpdateInfo2, context2, uriList2);
    }

    [Register("Update", "(Lcom/zebra/rfid/api3/SoftwareUpdateInfo;Landroid/content/Context;Ljava/util/List;)V", "GetUpdate_Lcom_zebra_rfid_api3_SoftwareUpdateInfo_Landroid_content_Context_Ljava_util_List_Handler")]
    public virtual unsafe void Update(
      SoftwareUpdateInfo? softwareUpdateInfo,
      Context? context,
      IList<Uri>? uriList)
    {
      IntPtr localJniHandle = JavaList<Uri>.ToLocalJniHandle(uriList);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(softwareUpdateInfo == null ? IntPtr.Zero : softwareUpdateInfo.Handle),
          new JniArgumentValue(context == null ? IntPtr.Zero : ((Object) context).Handle),
          new JniArgumentValue(localJniHandle)
        };
        SoftwareUpdate._members.InstanceMethods.InvokeVirtualVoidMethod("Update.(Lcom/zebra/rfid/api3/SoftwareUpdateInfo;Landroid/content/Context;Ljava/util/List;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(localJniHandle);
        GC.KeepAlive((object) softwareUpdateInfo);
        GC.KeepAlive((object) context);
        GC.KeepAlive((object) uriList);
      }
    }
  }
}
