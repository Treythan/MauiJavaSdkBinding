// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagStorageSettings
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
  [Register("com/zebra/rfid/api3/TagStorageSettings", DoNotGenerateAcw = true)]
  public class TagStorageSettings : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagStorageSettings", typeof (TagStorageSettings));
    private static Delegate? cb_isAccessReportsEnabled;
    private static Delegate? cb_isTagsOnInventoryStopDiscarded;
    private static Delegate? cb_getMaxMemoryBankByteCount;
    private static Delegate? cb_setMaxMemoryBankByteCount_I;
    private static Delegate? cb_getMaxTagCount;
    private static Delegate? cb_setMaxTagCount_I;
    private static Delegate? cb_getMaxTagIDLength;
    private static Delegate? cb_setMaxTagIDLength_I;
    private static Delegate? cb_getTag_field;
    private static Delegate? cb_discardTagsOnInventoryStop_Z;
    private static Delegate? cb_enableAccessReports_Z;
    private static Delegate? cb_getTagFields;
    private static Delegate? cb_setTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_;
    private static Delegate? cb_setTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TagStorageSettings._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagStorageSettings._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagStorageSettings._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagStorageSettings._members.ManagedPeerType;

    protected TagStorageSettings(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TagStorageSettings()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TagStorageSettings._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagStorageSettings._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(III)V", "")]
    public unsafe TagStorageSettings(int maxTagCount, int maxSizeMemoryBank, int maxTagIDByteCount)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
      {
        new JniArgumentValue(maxTagCount),
        new JniArgumentValue(maxSizeMemoryBank),
        new JniArgumentValue(maxTagIDByteCount)
      };
      JniObjectReference instance = TagStorageSettings._members.InstanceMethods.StartCreateInstance("(III)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagStorageSettings._members.InstanceMethods.FinishCreateInstance("(III)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register(".ctor", "(IIILcom/zebra/rfid/api3/TAG_FIELD;Z)V", "")]
    public unsafe TagStorageSettings(
      int maxTagCount,
      int maxMemoryBankByteCount,
      int maxTagIDByteCount,
      TAG_FIELD? tagFields,
      bool enableAccessReports)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(maxTagCount),
          new JniArgumentValue(maxMemoryBankByteCount),
          new JniArgumentValue(maxTagIDByteCount),
          new JniArgumentValue(tagFields == null ? IntPtr.Zero : tagFields.Handle),
          new JniArgumentValue(enableAccessReports)
        };
        JniObjectReference instance = TagStorageSettings._members.InstanceMethods.StartCreateInstance("(IIILcom/zebra/rfid/api3/TAG_FIELD;Z)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        TagStorageSettings._members.InstanceMethods.FinishCreateInstance("(IIILcom/zebra/rfid/api3/TAG_FIELD;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) tagFields);
      }
    }

    private static Delegate GetIsAccessReportsEnabledHandler()
    {
      if ((object) TagStorageSettings.cb_isAccessReportsEnabled == null)
        TagStorageSettings.cb_isAccessReportsEnabled = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TagStorageSettings.n_IsAccessReportsEnabled));
      return TagStorageSettings.cb_isAccessReportsEnabled;
    }

    private static bool n_IsAccessReportsEnabled(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).IsAccessReportsEnabled;
    }

    public virtual unsafe bool IsAccessReportsEnabled
    {
      [Register("isAccessReportsEnabled", "()Z", "GetIsAccessReportsEnabledHandler")] get
      {
        return TagStorageSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isAccessReportsEnabled.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetIsTagsOnInventoryStopDiscardedHandler()
    {
      if ((object) TagStorageSettings.cb_isTagsOnInventoryStopDiscarded == null)
        TagStorageSettings.cb_isTagsOnInventoryStopDiscarded = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(TagStorageSettings.n_IsTagsOnInventoryStopDiscarded));
      return TagStorageSettings.cb_isTagsOnInventoryStopDiscarded;
    }

    private static bool n_IsTagsOnInventoryStopDiscarded(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).IsTagsOnInventoryStopDiscarded;
    }

    public virtual unsafe bool IsTagsOnInventoryStopDiscarded
    {
      [Register("isTagsOnInventoryStopDiscarded", "()Z", "GetIsTagsOnInventoryStopDiscardedHandler")] get
      {
        return TagStorageSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagsOnInventoryStopDiscarded.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMaxMemoryBankByteCountHandler()
    {
      if ((object) TagStorageSettings.cb_getMaxMemoryBankByteCount == null)
        TagStorageSettings.cb_getMaxMemoryBankByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagStorageSettings.n_GetMaxMemoryBankByteCount));
      return TagStorageSettings.cb_getMaxMemoryBankByteCount;
    }

    private static int n_GetMaxMemoryBankByteCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxMemoryBankByteCount;
    }

    private static Delegate GetSetMaxMemoryBankByteCount_IHandler()
    {
      if ((object) TagStorageSettings.cb_setMaxMemoryBankByteCount_I == null)
        TagStorageSettings.cb_setMaxMemoryBankByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagStorageSettings.n_SetMaxMemoryBankByteCount_I));
      return TagStorageSettings.cb_setMaxMemoryBankByteCount_I;
    }

    private static void n_SetMaxMemoryBankByteCount_I(
      IntPtr jnienv,
      IntPtr native__this,
      int maxMemoryBankByteCount)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxMemoryBankByteCount = maxMemoryBankByteCount;
    }

    public virtual unsafe int MaxMemoryBankByteCount
    {
      [Register("getMaxMemoryBankByteCount", "()I", "GetGetMaxMemoryBankByteCountHandler")] get
      {
        return TagStorageSettings._members.InstanceMethods.InvokeVirtualInt32Method("getMaxMemoryBankByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaxMemoryBankByteCount", "(I)V", "GetSetMaxMemoryBankByteCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxMemoryBankByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaxTagCountHandler()
    {
      if ((object) TagStorageSettings.cb_getMaxTagCount == null)
        TagStorageSettings.cb_getMaxTagCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagStorageSettings.n_GetMaxTagCount));
      return TagStorageSettings.cb_getMaxTagCount;
    }

    private static int n_GetMaxTagCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxTagCount;
    }

    private static Delegate GetSetMaxTagCount_IHandler()
    {
      if ((object) TagStorageSettings.cb_setMaxTagCount_I == null)
        TagStorageSettings.cb_setMaxTagCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagStorageSettings.n_SetMaxTagCount_I));
      return TagStorageSettings.cb_setMaxTagCount_I;
    }

    private static void n_SetMaxTagCount_I(IntPtr jnienv, IntPtr native__this, int maxTagCount)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxTagCount = maxTagCount;
    }

    public virtual unsafe int MaxTagCount
    {
      [Register("getMaxTagCount", "()I", "GetGetMaxTagCountHandler")] get
      {
        return TagStorageSettings._members.InstanceMethods.InvokeVirtualInt32Method("getMaxTagCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaxTagCount", "(I)V", "GetSetMaxTagCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxTagCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaxTagIDLengthHandler()
    {
      if ((object) TagStorageSettings.cb_getMaxTagIDLength == null)
        TagStorageSettings.cb_getMaxTagIDLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagStorageSettings.n_GetMaxTagIDLength));
      return TagStorageSettings.cb_getMaxTagIDLength;
    }

    private static int n_GetMaxTagIDLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxTagIDLength;
    }

    private static Delegate GetSetMaxTagIDLength_IHandler()
    {
      if ((object) TagStorageSettings.cb_setMaxTagIDLength_I == null)
        TagStorageSettings.cb_setMaxTagIDLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagStorageSettings.n_SetMaxTagIDLength_I));
      return TagStorageSettings.cb_setMaxTagIDLength_I;
    }

    private static void n_SetMaxTagIDLength_I(
      IntPtr jnienv,
      IntPtr native__this,
      int maxTagIDByteCount)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).MaxTagIDLength = maxTagIDByteCount;
    }

    public virtual unsafe int MaxTagIDLength
    {
      [Register("getMaxTagIDLength", "()I", "GetGetMaxTagIDLengthHandler")] get
      {
        return TagStorageSettings._members.InstanceMethods.InvokeVirtualInt32Method("getMaxTagIDLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaxTagIDLength", "(I)V", "GetSetMaxTagIDLength_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxTagIDLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTag_fieldHandler()
    {
      if ((object) TagStorageSettings.cb_getTag_field == null)
        TagStorageSettings.cb_getTag_field = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagStorageSettings.n_GetTag_field));
      return TagStorageSettings.cb_getTag_field;
    }

    private static IntPtr n_GetTag_field(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).Tag_field);
    }

    public virtual unsafe TAG_FIELD? Tag_field
    {
      [Register("getTag_field", "()Lcom/zebra/rfid/api3/TAG_FIELD;", "GetGetTag_fieldHandler")] get
      {
        JniObjectReference jniObjectReference = TagStorageSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getTag_field.()Lcom/zebra/rfid/api3/TAG_FIELD;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<TAG_FIELD>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetDiscardTagsOnInventoryStop_ZHandler()
    {
      if ((object) TagStorageSettings.cb_discardTagsOnInventoryStop_Z == null)
        TagStorageSettings.cb_discardTagsOnInventoryStop_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(TagStorageSettings.n_DiscardTagsOnInventoryStop_Z));
      return TagStorageSettings.cb_discardTagsOnInventoryStop_Z;
    }

    private static void n_DiscardTagsOnInventoryStop_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool m_bDiscardTagsOnInventoryStop)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).DiscardTagsOnInventoryStop(m_bDiscardTagsOnInventoryStop);
    }

    [Register("discardTagsOnInventoryStop", "(Z)V", "GetDiscardTagsOnInventoryStop_ZHandler")]
    public virtual unsafe void DiscardTagsOnInventoryStop(bool m_bDiscardTagsOnInventoryStop)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(m_bDiscardTagsOnInventoryStop)
      };
      TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("discardTagsOnInventoryStop.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetEnableAccessReports_ZHandler()
    {
      if ((object) TagStorageSettings.cb_enableAccessReports_Z == null)
        TagStorageSettings.cb_enableAccessReports_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(TagStorageSettings.n_EnableAccessReports_Z));
      return TagStorageSettings.cb_enableAccessReports_Z;
    }

    private static void n_EnableAccessReports_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool enableAccessReports)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).EnableAccessReports(enableAccessReports);
    }

    [Register("enableAccessReports", "(Z)V", "GetEnableAccessReports_ZHandler")]
    public virtual unsafe void EnableAccessReports(bool enableAccessReports)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(enableAccessReports)
      };
      TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("enableAccessReports.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetTagFieldsHandler()
    {
      if ((object) TagStorageSettings.cb_getTagFields == null)
        TagStorageSettings.cb_getTagFields = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagStorageSettings.n_GetTagFields));
      return TagStorageSettings.cb_getTagFields;
    }

    private static IntPtr n_GetTagFields(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<TAG_FIELD>(Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).GetTagFields());
    }

    [Register("getTagFields", "()[Lcom/zebra/rfid/api3/TAG_FIELD;", "GetGetTagFieldsHandler")]
    public virtual unsafe TAG_FIELD[]? GetTagFields()
    {
      JniObjectReference jniObjectReference = TagStorageSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getTagFields.()[Lcom/zebra/rfid/api3/TAG_FIELD;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (TAG_FIELD[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TAG_FIELD));
    }

    private static Delegate GetSetTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_Handler()
    {
      if ((object) TagStorageSettings.cb_setTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_ == null)
        TagStorageSettings.cb_setTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagStorageSettings.n_SetTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_));
      return TagStorageSettings.cb_setTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_;
    }

    private static void n_SetTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagField)
    {
      Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0).SetTagFields(Object.GetObject<TAG_FIELD>(native_tagField, (JniHandleOwnership) 0));
    }

    [Register("setTagFields", "(Lcom/zebra/rfid/api3/TAG_FIELD;)V", "GetSetTagFields_Lcom_zebra_rfid_api3_TAG_FIELD_Handler")]
    public virtual unsafe void SetTagFields(TAG_FIELD? tagField)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(tagField == null ? IntPtr.Zero : tagField.Handle)
        };
        TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setTagFields.(Lcom/zebra/rfid/api3/TAG_FIELD;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) tagField);
      }
    }

    private static Delegate GetSetTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_Handler()
    {
      if ((object) TagStorageSettings.cb_setTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_ == null)
        TagStorageSettings.cb_setTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagStorageSettings.n_SetTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_));
      return TagStorageSettings.cb_setTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_;
    }

    private static void n_SetTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_arrTagFields)
    {
      TagStorageSettings tagStorageSettings = Object.GetObject<TagStorageSettings>(jnienv, native__this, (JniHandleOwnership) 0);
      TAG_FIELD[] array = (TAG_FIELD[]) JNIEnv.GetArray(native_arrTagFields, (JniHandleOwnership) 0, typeof (TAG_FIELD));
      TAG_FIELD[] arrTagFields = array;
      tagStorageSettings.SetTagFields(arrTagFields);
      if (array == null)
        return;
      JNIEnv.CopyArray<TAG_FIELD>(array, native_arrTagFields);
    }

    [Register("setTagFields", "([Lcom/zebra/rfid/api3/TAG_FIELD;)V", "GetSetTagFields_arrayLcom_zebra_rfid_api3_TAG_FIELD_Handler")]
    public virtual unsafe void SetTagFields(TAG_FIELD[]? arrTagFields)
    {
      IntPtr num = JNIEnv.NewArray<TAG_FIELD>(arrTagFields);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        TagStorageSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setTagFields.([Lcom/zebra/rfid/api3/TAG_FIELD;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (arrTagFields != null)
        {
          JNIEnv.CopyArray<TAG_FIELD>(num, arrTagFields);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) arrTagFields);
      }
    }
  }
}
