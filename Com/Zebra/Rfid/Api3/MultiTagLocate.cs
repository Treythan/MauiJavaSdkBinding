// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.MultiTagLocate
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/MultiTagLocate", DoNotGenerateAcw = true)]
  public class MultiTagLocate : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MultiTagLocate", typeof (MultiTagLocate));
    private static Delegate? cb_isMultiTagLocatePerforming;
    private static Delegate? cb_getItemList;
    private static Delegate? cb_addItem_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_clearItems;
    private static Delegate? cb_deleteItem_Ljava_lang_String_;
    private static Delegate? cb_filterTagList_Z;
    private static Delegate? cb_getMultiTagLocateTagInfo_I;
    private static Delegate? cb_importItemList_Landroid_util_ArrayMap_;
    private static Delegate? cb_perform;
    private static Delegate? cb_purgeItemList;
    private static Delegate? cb_setBeeperVolume_S;
    private static Delegate? cb_setEventsObj_Lcom_zebra_rfid_api3_Events_;
    private static Delegate? cb_stop;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = MultiTagLocate._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MultiTagLocate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MultiTagLocate._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MultiTagLocate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MultiTagLocate._members.ManagedPeerType;

    protected MultiTagLocate(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetIsMultiTagLocatePerformingHandler()
    {
      if ((object) MultiTagLocate.cb_isMultiTagLocatePerforming == null)
        MultiTagLocate.cb_isMultiTagLocatePerforming = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(MultiTagLocate.n_IsMultiTagLocatePerforming));
      return MultiTagLocate.cb_isMultiTagLocatePerforming;
    }

    private static bool n_IsMultiTagLocatePerforming(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).IsMultiTagLocatePerforming;
    }

    public virtual unsafe bool IsMultiTagLocatePerforming
    {
      [Register("isMultiTagLocatePerforming", "()Z", "GetIsMultiTagLocatePerformingHandler")] get
      {
        return MultiTagLocate._members.InstanceMethods.InvokeVirtualBooleanMethod("isMultiTagLocatePerforming.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetItemListHandler()
    {
      if ((object) MultiTagLocate.cb_getItemList == null)
        MultiTagLocate.cb_getItemList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiTagLocate.n_GetItemList));
      return MultiTagLocate.cb_getItemList;
    }

    private static IntPtr n_GetItemList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).ItemList);
    }

    public virtual unsafe TreeMap? ItemList
    {
      [Register("getItemList", "()Ljava/util/TreeMap;", "GetGetItemListHandler")] get
      {
        JniObjectReference jniObjectReference = MultiTagLocate._members.InstanceMethods.InvokeVirtualObjectMethod("getItemList.()Ljava/util/TreeMap;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<TreeMap>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetAddItem_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) MultiTagLocate.cb_addItem_Ljava_lang_String_Ljava_lang_String_ == null)
        MultiTagLocate.cb_addItem_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_I(MultiTagLocate.n_AddItem_Ljava_lang_String_Ljava_lang_String_));
      return MultiTagLocate.cb_addItem_Ljava_lang_String_Ljava_lang_String_;
    }

    private static int n_AddItem_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_epc,
      IntPtr native_rssi)
    {
      MultiTagLocate multiTagLocate = Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_epc, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_rssi, (JniHandleOwnership) 0);
      string epc = str1;
      string rssi = str2;
      return multiTagLocate.AddItem(epc, rssi);
    }

    [Register("addItem", "(Ljava/lang/String;Ljava/lang/String;)I", "GetAddItem_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe int AddItem(string? epc, string? rssi)
    {
      IntPtr num1 = JNIEnv.NewString(epc);
      IntPtr num2 = JNIEnv.NewString(rssi);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        return MultiTagLocate._members.InstanceMethods.InvokeVirtualInt32Method("addItem.(Ljava/lang/String;Ljava/lang/String;)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetClearItemsHandler()
    {
      if ((object) MultiTagLocate.cb_clearItems == null)
        MultiTagLocate.cb_clearItems = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MultiTagLocate.n_ClearItems));
      return MultiTagLocate.cb_clearItems;
    }

    private static int n_ClearItems(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).ClearItems();
    }

    [Register("clearItems", "()I", "GetClearItemsHandler")]
    public virtual unsafe int ClearItems()
    {
      return MultiTagLocate._members.InstanceMethods.InvokeVirtualInt32Method("clearItems.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDeleteItem_Ljava_lang_String_Handler()
    {
      if ((object) MultiTagLocate.cb_deleteItem_Ljava_lang_String_ == null)
        MultiTagLocate.cb_deleteItem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_I(MultiTagLocate.n_DeleteItem_Ljava_lang_String_));
      return MultiTagLocate.cb_deleteItem_Ljava_lang_String_;
    }

    private static int n_DeleteItem_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tid)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).DeleteItem(JNIEnv.GetString(native_tid, (JniHandleOwnership) 0));
    }

    [Register("deleteItem", "(Ljava/lang/String;)I", "GetDeleteItem_Ljava_lang_String_Handler")]
    public virtual unsafe int DeleteItem(string? tid)
    {
      IntPtr num = JNIEnv.NewString(tid);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        return MultiTagLocate._members.InstanceMethods.InvokeVirtualInt32Method("deleteItem.(Ljava/lang/String;)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetFilterTagList_ZHandler()
    {
      if ((object) MultiTagLocate.cb_filterTagList_Z == null)
        MultiTagLocate.cb_filterTagList_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_Z(MultiTagLocate.n_FilterTagList_Z));
      return MultiTagLocate.cb_filterTagList_Z;
    }

    private static bool n_FilterTagList_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool notReadTagsCheckOnly)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).FilterTagList(notReadTagsCheckOnly);
    }

    [Register("filterTagList", "(Z)Z", "GetFilterTagList_ZHandler")]
    protected virtual unsafe bool FilterTagList(bool notReadTagsCheckOnly)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(notReadTagsCheckOnly)
      };
      return MultiTagLocate._members.InstanceMethods.InvokeVirtualBooleanMethod("filterTagList.(Z)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetMultiTagLocateTagInfo_IHandler()
    {
      if ((object) MultiTagLocate.cb_getMultiTagLocateTagInfo_I == null)
        MultiTagLocate.cb_getMultiTagLocateTagInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(MultiTagLocate.n_GetMultiTagLocateTagInfo_I));
      return MultiTagLocate.cb_getMultiTagLocateTagInfo_I;
    }

    private static IntPtr n_GetMultiTagLocateTagInfo_I(
      IntPtr jnienv,
      IntPtr native__this,
      int numberOfTags)
    {
      return JNIEnv.NewArray<TagData>(Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).GetMultiTagLocateTagInfo(numberOfTags));
    }

    [Register("getMultiTagLocateTagInfo", "(I)[Lcom/zebra/rfid/api3/TagData;", "GetGetMultiTagLocateTagInfo_IHandler")]
    protected virtual unsafe TagData[]? GetMultiTagLocateTagInfo(int numberOfTags)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(numberOfTags)
      };
      JniObjectReference jniObjectReference = MultiTagLocate._members.InstanceMethods.InvokeVirtualObjectMethod("getMultiTagLocateTagInfo.(I)[Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, jniArgumentValuePtr);
      return (TagData[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TagData));
    }

    private static Delegate GetImportItemList_Landroid_util_ArrayMap_Handler()
    {
      if ((object) MultiTagLocate.cb_importItemList_Landroid_util_ArrayMap_ == null)
        MultiTagLocate.cb_importItemList_Landroid_util_ArrayMap_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_I(MultiTagLocate.n_ImportItemList_Landroid_util_ArrayMap_));
      return MultiTagLocate.cb_importItemList_Landroid_util_ArrayMap_;
    }

    private static int n_ImportItemList_Landroid_util_ArrayMap_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_importList)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).ImportItemList(Object.GetObject<ArrayMap>(native_importList, (JniHandleOwnership) 0));
    }

    [Register("importItemList", "(Landroid/util/ArrayMap;)I", "GetImportItemList_Landroid_util_ArrayMap_Handler")]
    public virtual unsafe int ImportItemList(ArrayMap? importList)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(importList == null ? IntPtr.Zero : ((Object) importList).Handle)
        };
        return MultiTagLocate._members.InstanceMethods.InvokeVirtualInt32Method("importItemList.(Landroid/util/ArrayMap;)I", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) importList);
      }
    }

    private static Delegate GetPerformHandler()
    {
      if ((object) MultiTagLocate.cb_perform == null)
        MultiTagLocate.cb_perform = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(MultiTagLocate.n_Perform));
      return MultiTagLocate.cb_perform;
    }

    private static void n_Perform(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).Perform();
    }

    [Register("perform", "()V", "GetPerformHandler")]
    public virtual unsafe void Perform()
    {
      MultiTagLocate._members.InstanceMethods.InvokeVirtualVoidMethod("perform.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetPurgeItemListHandler()
    {
      if ((object) MultiTagLocate.cb_purgeItemList == null)
        MultiTagLocate.cb_purgeItemList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MultiTagLocate.n_PurgeItemList));
      return MultiTagLocate.cb_purgeItemList;
    }

    private static int n_PurgeItemList(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).PurgeItemList();
    }

    [Register("purgeItemList", "()I", "GetPurgeItemListHandler")]
    public virtual unsafe int PurgeItemList()
    {
      return MultiTagLocate._members.InstanceMethods.InvokeVirtualInt32Method("purgeItemList.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetBeeperVolume_SHandler()
    {
      if ((object) MultiTagLocate.cb_setBeeperVolume_S == null)
        MultiTagLocate.cb_setBeeperVolume_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(MultiTagLocate.n_SetBeeperVolume_S));
      return MultiTagLocate.cb_setBeeperVolume_S;
    }

    private static void n_SetBeeperVolume_S(IntPtr jnienv, IntPtr native__this, short volume)
    {
      Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).SetBeeperVolume(volume);
    }

    [Register("setBeeperVolume", "(S)V", "GetSetBeeperVolume_SHandler")]
    public virtual unsafe void SetBeeperVolume(short volume)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(volume)
      };
      MultiTagLocate._members.InstanceMethods.InvokeVirtualVoidMethod("setBeeperVolume.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetSetEventsObj_Lcom_zebra_rfid_api3_Events_Handler()
    {
      if ((object) MultiTagLocate.cb_setEventsObj_Lcom_zebra_rfid_api3_Events_ == null)
        MultiTagLocate.cb_setEventsObj_Lcom_zebra_rfid_api3_Events_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiTagLocate.n_SetEventsObj_Lcom_zebra_rfid_api3_Events_));
      return MultiTagLocate.cb_setEventsObj_Lcom_zebra_rfid_api3_Events_;
    }

    private static void n_SetEventsObj_Lcom_zebra_rfid_api3_Events_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_events)
    {
      Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).SetEventsObj(Object.GetObject<Events>(native_events, (JniHandleOwnership) 0));
    }

    [Register("setEventsObj", "(Lcom/zebra/rfid/api3/Events;)V", "GetSetEventsObj_Lcom_zebra_rfid_api3_Events_Handler")]
    protected virtual unsafe void SetEventsObj(Events? events)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(events == null ? IntPtr.Zero : events.Handle)
        };
        MultiTagLocate._members.InstanceMethods.InvokeVirtualVoidMethod("setEventsObj.(Lcom/zebra/rfid/api3/Events;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) events);
      }
    }

    private static Delegate GetStopHandler()
    {
      if ((object) MultiTagLocate.cb_stop == null)
        MultiTagLocate.cb_stop = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(MultiTagLocate.n_Stop));
      return MultiTagLocate.cb_stop;
    }

    private static void n_Stop(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<MultiTagLocate>(jnienv, native__this, (JniHandleOwnership) 0).Stop();
    }

    [Register("stop", "()V", "GetStopHandler")]
    public virtual unsafe void Stop()
    {
      MultiTagLocate._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
