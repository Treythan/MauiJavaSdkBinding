// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Actions
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
  [Register("com/zebra/rfid/api3/Actions", DoNotGenerateAcw = true)]
  public class Actions : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Actions", typeof (Actions));
    private static Delegate? cb_getBatchedTags;
    private static Delegate? cb_getMultiTagLocateTagInfo_I;
    private static Delegate? cb_getReadTags_I;
    private static Delegate? cb_getReadTagsEx_I;
    private static Delegate? cb_preGetReadTags_I;
    private static Delegate? cb_purgeTags;
    private static Delegate? cb_reset;

    [Register("gen2v2Access")]
    public Gen2v2? Gen2v2Access
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("gen2v2Access.Lcom/zebra/rfid/api3/Gen2v2;", (IJavaPeerable) this);
        return Object.GetObject<Gen2v2>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("gen2v2Access.Lcom/zebra/rfid/api3/Gen2v2;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("Inventory")]
    public Inventory? Inventory
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("Inventory.Lcom/zebra/rfid/api3/Inventory;", (IJavaPeerable) this);
        return Object.GetObject<Inventory>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("Inventory.Lcom/zebra/rfid/api3/Inventory;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("MultiTagLocate")]
    public MultiTagLocate? MultiTagLocate
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("MultiTagLocate.Lcom/zebra/rfid/api3/MultiTagLocate;", (IJavaPeerable) this);
        return Object.GetObject<MultiTagLocate>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("MultiTagLocate.Lcom/zebra/rfid/api3/MultiTagLocate;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("PreFilters")]
    public PreFilters? PreFilters
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("PreFilters.Lcom/zebra/rfid/api3/PreFilters;", (IJavaPeerable) this);
        return Object.GetObject<PreFilters>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("PreFilters.Lcom/zebra/rfid/api3/PreFilters;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TagAccess")]
    public TagAccess? TagAccess
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("TagAccess.Lcom/zebra/rfid/api3/TagAccess;", (IJavaPeerable) this);
        return Object.GetObject<TagAccess>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("TagAccess.Lcom/zebra/rfid/api3/TagAccess;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TagLocationing")]
    public TagLocationing? TagLocationing
    {
      get
      {
        JniObjectReference objectValue = Actions._members.InstanceFields.GetObjectValue("TagLocationing.Lcom/zebra/rfid/api3/TagLocationing;", (IJavaPeerable) this);
        return Object.GetObject<TagLocationing>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Actions._members.InstanceFields.SetValue("TagLocationing.Lcom/zebra/rfid/api3/TagLocationing;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Actions._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Actions._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Actions._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Actions._members.ManagedPeerType;

    protected Actions(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetBatchedTagsHandler()
    {
      if ((object) Actions.cb_getBatchedTags == null)
        Actions.cb_getBatchedTags = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Actions.n_GetBatchedTags));
      return Actions.cb_getBatchedTags;
    }

    private static bool n_GetBatchedTags(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).BatchedTags;
    }

    public virtual unsafe bool BatchedTags
    {
      [Register("getBatchedTags", "()Z", "GetGetBatchedTagsHandler")] get
      {
        return Actions._members.InstanceMethods.InvokeVirtualBooleanMethod("getBatchedTags.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetMultiTagLocateTagInfo_IHandler()
    {
      if ((object) Actions.cb_getMultiTagLocateTagInfo_I == null)
        Actions.cb_getMultiTagLocateTagInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Actions.n_GetMultiTagLocateTagInfo_I));
      return Actions.cb_getMultiTagLocateTagInfo_I;
    }

    private static IntPtr n_GetMultiTagLocateTagInfo_I(
      IntPtr jnienv,
      IntPtr native__this,
      int numberOfTags)
    {
      return JNIEnv.NewArray<TagData>(Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).GetMultiTagLocateTagInfo(numberOfTags));
    }

    [Register("getMultiTagLocateTagInfo", "(I)[Lcom/zebra/rfid/api3/TagData;", "GetGetMultiTagLocateTagInfo_IHandler")]
    public virtual unsafe TagData[]? GetMultiTagLocateTagInfo(int numberOfTags)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(numberOfTags)
      };
      JniObjectReference jniObjectReference = Actions._members.InstanceMethods.InvokeVirtualObjectMethod("getMultiTagLocateTagInfo.(I)[Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
      return (TagData[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TagData));
    }

    private static Delegate GetGetReadTags_IHandler()
    {
      if ((object) Actions.cb_getReadTags_I == null)
        Actions.cb_getReadTags_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Actions.n_GetReadTags_I));
      return Actions.cb_getReadTags_I;
    }

    private static IntPtr n_GetReadTags_I(IntPtr jnienv, IntPtr native__this, int numberOfTags)
    {
      return JNIEnv.NewArray<TagData>(Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).GetReadTags(numberOfTags));
    }

    [Register("getReadTags", "(I)[Lcom/zebra/rfid/api3/TagData;", "GetGetReadTags_IHandler")]
    public virtual unsafe TagData[]? GetReadTags(int numberOfTags)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(numberOfTags)
      };
      JniObjectReference jniObjectReference = Actions._members.InstanceMethods.InvokeVirtualObjectMethod("getReadTags.(I)[Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
      return (TagData[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TagData));
    }

    private static Delegate GetGetReadTagsEx_IHandler()
    {
      if ((object) Actions.cb_getReadTagsEx_I == null)
        Actions.cb_getReadTagsEx_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Actions.n_GetReadTagsEx_I));
      return Actions.cb_getReadTagsEx_I;
    }

    private static IntPtr n_GetReadTagsEx_I(IntPtr jnienv, IntPtr native__this, int numberOfTags)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).GetReadTagsEx(numberOfTags));
    }

    [Register("getReadTagsEx", "(I)Lcom/zebra/rfid/api3/TagDataArray;", "GetGetReadTagsEx_IHandler")]
    public virtual unsafe TagDataArray? GetReadTagsEx(int numberOfTags)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(numberOfTags)
      };
      JniObjectReference jniObjectReference = Actions._members.InstanceMethods.InvokeVirtualObjectMethod("getReadTagsEx.(I)Lcom/zebra/rfid/api3/TagDataArray;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<TagDataArray>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetPreGetReadTags_IHandler()
    {
      if ((object) Actions.cb_preGetReadTags_I == null)
        Actions.cb_preGetReadTags_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Actions.n_PreGetReadTags_I));
      return Actions.cb_preGetReadTags_I;
    }

    private static IntPtr n_PreGetReadTags_I(IntPtr jnienv, IntPtr native__this, int numberOfTags)
    {
      return JNIEnv.NewArray<TagData>(Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).PreGetReadTags(numberOfTags));
    }

    [Register("preGetReadTags", "(I)[Lcom/zebra/rfid/api3/TagData;", "GetPreGetReadTags_IHandler")]
    protected virtual unsafe TagData[]? PreGetReadTags(int numberOfTags)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(numberOfTags)
      };
      JniObjectReference jniObjectReference = Actions._members.InstanceMethods.InvokeVirtualObjectMethod("preGetReadTags.(I)[Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
      return (TagData[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TagData));
    }

    private static Delegate GetPurgeTagsHandler()
    {
      if ((object) Actions.cb_purgeTags == null)
        Actions.cb_purgeTags = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Actions.n_PurgeTags));
      return Actions.cb_purgeTags;
    }

    private static bool n_PurgeTags(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).PurgeTags();
    }

    [Register("purgeTags", "()Z", "GetPurgeTagsHandler")]
    public virtual unsafe bool PurgeTags()
    {
      return Actions._members.InstanceMethods.InvokeVirtualBooleanMethod("purgeTags.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetResetHandler()
    {
      if ((object) Actions.cb_reset == null)
        Actions.cb_reset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Actions.n_Reset));
      return Actions.cb_reset;
    }

    private static void n_Reset(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Actions>(jnienv, native__this, (JniHandleOwnership) 0).Reset();
    }

    [Register("reset", "()V", "GetResetHandler")]
    public virtual unsafe void Reset()
    {
      Actions._members.InstanceMethods.InvokeVirtualVoidMethod("reset.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
