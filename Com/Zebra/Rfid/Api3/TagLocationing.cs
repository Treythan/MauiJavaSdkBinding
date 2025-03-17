// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagLocationing
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
  [Register("com/zebra/rfid/api3/TagLocationing", DoNotGenerateAcw = true)]
  public class TagLocationing : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagLocationing", typeof (TagLocationing));
    private static Delegate? cb_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_Stop;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TagLocationing._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagLocationing._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagLocationing._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagLocationing._members.ManagedPeerType;

    protected TagLocationing(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetPerform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagLocationing.cb_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagLocationing.cb_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagLocationing.n_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagLocationing.cb_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_Perform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagID,
      IntPtr native_epm,
      IntPtr native_antennaInfo)
    {
      TagLocationing tagLocationing = Object.GetObject<TagLocationing>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_tagID, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_epm, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      string tagID = str1;
      string epm = str2;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagLocationing.Perform(tagID, epm, antennaInfo2);
    }

    [Register("Perform", "(Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetPerform_Ljava_lang_String_Ljava_lang_String_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void Perform(string? tagID, string? epm, AntennaInfo? antennaInfo)
    {
      IntPtr num1 = JNIEnv.NewString(tagID);
      IntPtr num2 = JNIEnv.NewString(epm);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagLocationing._members.InstanceMethods.InvokeVirtualVoidMethod("Perform.(Ljava/lang/String;Ljava/lang/String;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetPerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) TagLocationing.cb_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        TagLocationing.cb_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(TagLocationing.n_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_));
      return TagLocationing.cb_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_PerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagPatternFilters,
      IntPtr native_multiLocateParams,
      IntPtr native_antennaInfo)
    {
      TagLocationing tagLocationing = Object.GetObject<TagLocationing>(jnienv, native__this, (JniHandleOwnership) 0);
      TagPatternBase[] array = (TagPatternBase[]) JNIEnv.GetArray(native_tagPatternFilters, (JniHandleOwnership) 0, typeof (TagPatternBase));
      MultiLocateParams multiLocateParams1 = Object.GetObject<MultiLocateParams>(native_multiLocateParams, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      TagPatternBase[] tagPatternFilters = array;
      MultiLocateParams multiLocateParams2 = multiLocateParams1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      tagLocationing.PerformMultiLocate(tagPatternFilters, multiLocateParams2, antennaInfo2);
      if (array == null)
        return;
      JNIEnv.CopyArray<TagPatternBase>(array, native_tagPatternFilters);
    }

    [Register("PerformMultiLocate", "([Lcom/zebra/rfid/api3/TagPatternBase;Lcom/zebra/rfid/api3/MultiLocateParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetPerformMultiLocate_arrayLcom_zebra_rfid_api3_TagPatternBase_Lcom_zebra_rfid_api3_MultiLocateParams_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void PerformMultiLocate(
      TagPatternBase[]? tagPatternFilters,
      MultiLocateParams? multiLocateParams,
      AntennaInfo? antennaInfo)
    {
      IntPtr num = JNIEnv.NewArray<TagPatternBase>(tagPatternFilters);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(multiLocateParams == null ? IntPtr.Zero : multiLocateParams.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        TagLocationing._members.InstanceMethods.InvokeVirtualVoidMethod("PerformMultiLocate.([Lcom/zebra/rfid/api3/TagPatternBase;Lcom/zebra/rfid/api3/MultiLocateParams;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (tagPatternFilters != null)
        {
          JNIEnv.CopyArray<TagPatternBase>(num, tagPatternFilters);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) tagPatternFilters);
        GC.KeepAlive((object) multiLocateParams);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetStopHandler()
    {
      if ((object) TagLocationing.cb_Stop == null)
        TagLocationing.cb_Stop = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(TagLocationing.n_Stop));
      return TagLocationing.cb_Stop;
    }

    private static void n_Stop(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<TagLocationing>(jnienv, native__this, (JniHandleOwnership) 0).Stop();
    }

    [Register("Stop", "()V", "GetStopHandler")]
    public virtual unsafe void Stop()
    {
      TagLocationing._members.InstanceMethods.InvokeVirtualVoidMethod("Stop.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
