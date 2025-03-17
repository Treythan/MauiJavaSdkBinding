// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.PreFilters
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
  [Register("com/zebra/rfid/api3/PreFilters", DoNotGenerateAcw = true)]
  public class PreFilters : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/PreFilters", typeof (PreFilters));
    private static Delegate? cb_add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_;
    private static Delegate? cb_add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_;
    private static Delegate? cb_delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_;
    private static Delegate? cb_deleteAll;
    private static Delegate? cb_getPreFilter_I;
    private static Delegate? cb_length;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = PreFilters._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => PreFilters._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = PreFilters._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => PreFilters._members.ManagedPeerType;

    protected PreFilters(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe PreFilters()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = PreFilters._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      PreFilters._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetAdd_Lcom_zebra_rfid_api3_PreFilters_PreFilter_Handler()
    {
      if ((object) PreFilters.cb_add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_ == null)
        PreFilters.cb_add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.n_Add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_));
      return PreFilters.cb_add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_;
    }

    private static void n_Add_Lcom_zebra_rfid_api3_PreFilters_PreFilter_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_preFilter)
    {
      Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0).Add(Object.GetObject<PreFilters.PreFilter>(native_preFilter, (JniHandleOwnership) 0));
    }

    [Register("add", "(Lcom/zebra/rfid/api3/PreFilters$PreFilter;)V", "GetAdd_Lcom_zebra_rfid_api3_PreFilters_PreFilter_Handler")]
    public virtual unsafe void Add(PreFilters.PreFilter? preFilter)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(preFilter == null ? IntPtr.Zero : preFilter.Handle)
        };
        PreFilters._members.InstanceMethods.InvokeVirtualVoidMethod("add.(Lcom/zebra/rfid/api3/PreFilters$PreFilter;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) preFilter);
      }
    }

    private static Delegate GetAdd_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Handler()
    {
      if ((object) PreFilters.cb_add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_ == null)
        PreFilters.cb_add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(PreFilters.n_Add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_));
      return PreFilters.cb_add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_;
    }

    private static void n_Add_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_preFilters,
      IntPtr native_singulationControl)
    {
      PreFilters preFilters1 = Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0);
      PreFilters.PreFilter[] array = (PreFilters.PreFilter[]) JNIEnv.GetArray(native_preFilters, (JniHandleOwnership) 0, typeof (PreFilters.PreFilter));
      Antennas.SingulationControl singulationControl1 = Object.GetObject<Antennas.SingulationControl>(native_singulationControl, (JniHandleOwnership) 0);
      PreFilters.PreFilter[] preFilters2 = array;
      Antennas.SingulationControl singulationControl2 = singulationControl1;
      preFilters1.Add(preFilters2, singulationControl2);
      if (array == null)
        return;
      JNIEnv.CopyArray<PreFilters.PreFilter>(array, native_preFilters);
    }

    [Register("add", "([Lcom/zebra/rfid/api3/PreFilters$PreFilter;Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", "GetAdd_arrayLcom_zebra_rfid_api3_PreFilters_PreFilter_Lcom_zebra_rfid_api3_Antennas_SingulationControl_Handler")]
    public virtual unsafe void Add(
      PreFilters.PreFilter[]? preFilters,
      Antennas.SingulationControl? singulationControl)
    {
      IntPtr num = JNIEnv.NewArray<PreFilters.PreFilter>(preFilters);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(singulationControl == null ? IntPtr.Zero : singulationControl.Handle)
        };
        PreFilters._members.InstanceMethods.InvokeVirtualVoidMethod("add.([Lcom/zebra/rfid/api3/PreFilters$PreFilter;Lcom/zebra/rfid/api3/Antennas$SingulationControl;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (preFilters != null)
        {
          JNIEnv.CopyArray<PreFilters.PreFilter>(num, preFilters);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) preFilters);
        GC.KeepAlive((object) singulationControl);
      }
    }

    private static Delegate GetDelete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_Handler()
    {
      if ((object) PreFilters.cb_delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_ == null)
        PreFilters.cb_delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.n_Delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_));
      return PreFilters.cb_delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_;
    }

    private static void n_Delete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_preFilter)
    {
      Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0).Delete(Object.GetObject<PreFilters.PreFilter>(native_preFilter, (JniHandleOwnership) 0));
    }

    [Register("delete", "(Lcom/zebra/rfid/api3/PreFilters$PreFilter;)V", "GetDelete_Lcom_zebra_rfid_api3_PreFilters_PreFilter_Handler")]
    public virtual unsafe void Delete(PreFilters.PreFilter? preFilter)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(preFilter == null ? IntPtr.Zero : preFilter.Handle)
        };
        PreFilters._members.InstanceMethods.InvokeVirtualVoidMethod("delete.(Lcom/zebra/rfid/api3/PreFilters$PreFilter;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) preFilter);
      }
    }

    private static Delegate GetDeleteAllHandler()
    {
      if ((object) PreFilters.cb_deleteAll == null)
        PreFilters.cb_deleteAll = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(PreFilters.n_DeleteAll));
      return PreFilters.cb_deleteAll;
    }

    private static void n_DeleteAll(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0).DeleteAll();
    }

    [Register("deleteAll", "()V", "GetDeleteAllHandler")]
    public virtual unsafe void DeleteAll()
    {
      PreFilters._members.InstanceMethods.InvokeVirtualVoidMethod("deleteAll.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetPreFilter_IHandler()
    {
      if ((object) PreFilters.cb_getPreFilter_I == null)
        PreFilters.cb_getPreFilter_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(PreFilters.n_GetPreFilter_I));
      return PreFilters.cb_getPreFilter_I;
    }

    private static IntPtr n_GetPreFilter_I(IntPtr jnienv, IntPtr native__this, int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0).GetPreFilter(index));
    }

    [Register("getPreFilter", "(I)Lcom/zebra/rfid/api3/PreFilters$PreFilter;", "GetGetPreFilter_IHandler")]
    public virtual unsafe PreFilters.PreFilter? GetPreFilter(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = PreFilters._members.InstanceMethods.InvokeVirtualObjectMethod("getPreFilter.(I)Lcom/zebra/rfid/api3/PreFilters$PreFilter;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<PreFilters.PreFilter>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetLengthHandler()
    {
      if ((object) PreFilters.cb_length == null)
        PreFilters.cb_length = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(PreFilters.n_Length));
      return PreFilters.cb_length;
    }

    private static int n_Length(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<PreFilters>(jnienv, native__this, (JniHandleOwnership) 0).Length();
    }

    [Register("length", "()I", "GetLengthHandler")]
    public virtual unsafe int Length()
    {
      return PreFilters._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("com/zebra/rfid/api3/PreFilters$PreFilter", DoNotGenerateAcw = true)]
    public class PreFilter : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/PreFilters$PreFilter", typeof (PreFilters.PreFilter));
      private static Delegate? cb_getAntennaID;
      private static Delegate? cb_setAntennaID_S;
      private static Delegate? cb_getBitOffset;
      private static Delegate? cb_setBitOffset_I;
      private static Delegate? cb_getFilterAction;
      private static Delegate? cb_setFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_;
      private static Delegate? cb_getFilterIndex;
      private static Delegate? cb_setFilterIndex_I;
      private static Delegate? cb_getMemoryBank;
      private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      private static Delegate? cb_getStringTagPattern;
      private static Delegate? cb_getTagPatternBitCount;
      private static Delegate? cb_setTagPatternBitCount_I;
      private static Delegate? cb_getTruncateAction;
      private static Delegate? cb_setTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_;
      private static Delegate? cb_getTagPattern;
      private static Delegate? cb_setTagPattern_arrayB;
      private static Delegate? cb_setTagPattern_Ljava_lang_String_;

      [Register("StateAwareAction")]
      public PreFilters.StateAwareActionParams? StateAwareAction
      {
        get
        {
          JniObjectReference objectValue = PreFilters.PreFilter._members.InstanceFields.GetObjectValue("StateAwareAction.Lcom/zebra/rfid/api3/PreFilters$StateAwareActionParams;", (IJavaPeerable) this);
          return Object.GetObject<PreFilters.StateAwareActionParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            PreFilters.PreFilter._members.InstanceFields.SetValue("StateAwareAction.Lcom/zebra/rfid/api3/PreFilters$StateAwareActionParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("StateUnawareAction")]
      public StateUnawareAction? StateUnawareAction
      {
        get
        {
          JniObjectReference objectValue = PreFilters.PreFilter._members.InstanceFields.GetObjectValue("StateUnawareAction.Lcom/zebra/rfid/api3/StateUnawareAction;", (IJavaPeerable) this);
          return Object.GetObject<StateUnawareAction>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            PreFilters.PreFilter._members.InstanceFields.SetValue("StateUnawareAction.Lcom/zebra/rfid/api3/StateUnawareAction;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
          JniObjectReference peerReference = PreFilters.PreFilter._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => PreFilters.PreFilter._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = PreFilters.PreFilter._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => PreFilters.PreFilter._members.ManagedPeerType;

      protected PreFilter(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/PreFilters;)V", "")]
      public unsafe PreFilter(PreFilters? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = PreFilters.PreFilter._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          PreFilters.PreFilter._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetAntennaIDHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getAntennaID == null)
          PreFilters.PreFilter.cb_getAntennaID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(PreFilters.PreFilter.n_GetAntennaID));
        return PreFilters.PreFilter.cb_getAntennaID;
      }

      private static short n_GetAntennaID(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID;
      }

      private static Delegate GetSetAntennaID_SHandler()
      {
        if ((object) PreFilters.PreFilter.cb_setAntennaID_S == null)
          PreFilters.PreFilter.cb_setAntennaID_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(PreFilters.PreFilter.n_SetAntennaID_S));
        return PreFilters.PreFilter.cb_setAntennaID_S;
      }

      private static void n_SetAntennaID_S(IntPtr jnienv, IntPtr native__this, short antennaID)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).AntennaID = antennaID;
      }

      public virtual unsafe short AntennaID
      {
        [Register("getAntennaID", "()S", "GetGetAntennaIDHandler")] get
        {
          return PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualInt16Method("getAntennaID.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAntennaID", "(S)V", "GetSetAntennaID_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setAntennaID.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetBitOffsetHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getBitOffset == null)
          PreFilters.PreFilter.cb_getBitOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(PreFilters.PreFilter.n_GetBitOffset));
        return PreFilters.PreFilter.cb_getBitOffset;
      }

      private static int n_GetBitOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).BitOffset;
      }

      private static Delegate GetSetBitOffset_IHandler()
      {
        if ((object) PreFilters.PreFilter.cb_setBitOffset_I == null)
          PreFilters.PreFilter.cb_setBitOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(PreFilters.PreFilter.n_SetBitOffset_I));
        return PreFilters.PreFilter.cb_setBitOffset_I;
      }

      private static void n_SetBitOffset_I(IntPtr jnienv, IntPtr native__this, int bitOffset)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).BitOffset = bitOffset;
      }

      public virtual unsafe int BitOffset
      {
        [Register("getBitOffset", "()I", "GetGetBitOffsetHandler")] get
        {
          return PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualInt32Method("getBitOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setBitOffset", "(I)V", "GetSetBitOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setBitOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetFilterActionHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getFilterAction == null)
          PreFilters.PreFilter.cb_getFilterAction = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.PreFilter.n_GetFilterAction));
        return PreFilters.PreFilter.cb_getFilterAction;
      }

      private static IntPtr n_GetFilterAction(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).FilterAction);
      }

      private static Delegate GetSetFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_Handler()
      {
        if ((object) PreFilters.PreFilter.cb_setFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_ == null)
          PreFilters.PreFilter.cb_setFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.PreFilter.n_SetFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_));
        return PreFilters.PreFilter.cb_setFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_;
      }

      private static void n_SetFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_filterAction)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).FilterAction = Object.GetObject<FILTER_ACTION>(native_filterAction, (JniHandleOwnership) 0);
      }

      public virtual unsafe FILTER_ACTION? FilterAction
      {
        [Register("getFilterAction", "()Lcom/zebra/rfid/api3/FILTER_ACTION;", "GetGetFilterActionHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getFilterAction.()Lcom/zebra/rfid/api3/FILTER_ACTION;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<FILTER_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setFilterAction", "(Lcom/zebra/rfid/api3/FILTER_ACTION;)V", "GetSetFilterAction_Lcom_zebra_rfid_api3_FILTER_ACTION_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setFilterAction.(Lcom/zebra/rfid/api3/FILTER_ACTION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetFilterIndexHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getFilterIndex == null)
          PreFilters.PreFilter.cb_getFilterIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(PreFilters.PreFilter.n_GetFilterIndex));
        return PreFilters.PreFilter.cb_getFilterIndex;
      }

      private static int n_GetFilterIndex(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).FilterIndex;
      }

      private static Delegate GetSetFilterIndex_IHandler()
      {
        if ((object) PreFilters.PreFilter.cb_setFilterIndex_I == null)
          PreFilters.PreFilter.cb_setFilterIndex_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(PreFilters.PreFilter.n_SetFilterIndex_I));
        return PreFilters.PreFilter.cb_setFilterIndex_I;
      }

      private static void n_SetFilterIndex_I(IntPtr jnienv, IntPtr native__this, int i)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).FilterIndex = i;
      }

      public virtual unsafe int FilterIndex
      {
        [Register("getFilterIndex", "()I", "GetGetFilterIndexHandler")] get
        {
          return PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualInt32Method("getFilterIndex.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setFilterIndex", "(I)V", "GetSetFilterIndex_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setFilterIndex.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMemoryBankHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getMemoryBank == null)
          PreFilters.PreFilter.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.PreFilter.n_GetMemoryBank));
        return PreFilters.PreFilter.cb_getMemoryBank;
      }

      private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
      }

      private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
      {
        if ((object) PreFilters.PreFilter.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
          PreFilters.PreFilter.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.PreFilter.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
        return PreFilters.PreFilter.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
      }

      private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_memoryBank)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
      }

      public virtual unsafe MEMORY_BANK? MemoryBank
      {
        [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setMemoryBank", "(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", "GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetStringTagPatternHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getStringTagPattern == null)
          PreFilters.PreFilter.cb_getStringTagPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.PreFilter.n_GetStringTagPattern));
        return PreFilters.PreFilter.cb_getStringTagPattern;
      }

      private static IntPtr n_GetStringTagPattern(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).StringTagPattern);
      }

      public virtual unsafe string? StringTagPattern
      {
        [Register("getStringTagPattern", "()Ljava/lang/String;", "GetGetStringTagPatternHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getStringTagPattern.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetTagPatternBitCountHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getTagPatternBitCount == null)
          PreFilters.PreFilter.cb_getTagPatternBitCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(PreFilters.PreFilter.n_GetTagPatternBitCount));
        return PreFilters.PreFilter.cb_getTagPatternBitCount;
      }

      private static int n_GetTagPatternBitCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).TagPatternBitCount;
      }

      private static Delegate GetSetTagPatternBitCount_IHandler()
      {
        if ((object) PreFilters.PreFilter.cb_setTagPatternBitCount_I == null)
          PreFilters.PreFilter.cb_setTagPatternBitCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(PreFilters.PreFilter.n_SetTagPatternBitCount_I));
        return PreFilters.PreFilter.cb_setTagPatternBitCount_I;
      }

      private static void n_SetTagPatternBitCount_I(
        IntPtr jnienv,
        IntPtr native__this,
        int tagPatternBitCount)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).TagPatternBitCount = tagPatternBitCount;
      }

      public virtual unsafe int TagPatternBitCount
      {
        [Register("getTagPatternBitCount", "()I", "GetGetTagPatternBitCountHandler")] get
        {
          return PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualInt32Method("getTagPatternBitCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTagPatternBitCount", "(I)V", "GetSetTagPatternBitCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPatternBitCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTruncateActionHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getTruncateAction == null)
          PreFilters.PreFilter.cb_getTruncateAction = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.PreFilter.n_GetTruncateAction));
        return PreFilters.PreFilter.cb_getTruncateAction;
      }

      private static IntPtr n_GetTruncateAction(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).TruncateAction);
      }

      private static Delegate GetSetTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_Handler()
      {
        if ((object) PreFilters.PreFilter.cb_setTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_ == null)
          PreFilters.PreFilter.cb_setTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.PreFilter.n_SetTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_));
        return PreFilters.PreFilter.cb_setTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_;
      }

      private static void n_SetTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_truncateAction)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).TruncateAction = Object.GetObject<TRUNCATE_ACTION>(native_truncateAction, (JniHandleOwnership) 0);
      }

      public virtual unsafe TRUNCATE_ACTION? TruncateAction
      {
        [Register("getTruncateAction", "()Lcom/zebra/rfid/api3/TRUNCATE_ACTION;", "GetGetTruncateActionHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getTruncateAction.()Lcom/zebra/rfid/api3/TRUNCATE_ACTION;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<TRUNCATE_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setTruncateAction", "(Lcom/zebra/rfid/api3/TRUNCATE_ACTION;)V", "GetSetTruncateAction_Lcom_zebra_rfid_api3_TRUNCATE_ACTION_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setTruncateAction.(Lcom/zebra/rfid/api3/TRUNCATE_ACTION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetTagPatternHandler()
      {
        if ((object) PreFilters.PreFilter.cb_getTagPattern == null)
          PreFilters.PreFilter.cb_getTagPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.PreFilter.n_GetTagPattern));
        return PreFilters.PreFilter.cb_getTagPattern;
      }

      private static IntPtr n_GetTagPattern(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewArray(Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).GetTagPattern());
      }

      [Register("getTagPattern", "()[B", "GetGetTagPatternHandler")]
      public virtual unsafe byte[]? GetTagPattern()
      {
        JniObjectReference jniObjectReference = PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getTagPattern.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }

      private static Delegate GetSetTagPattern_arrayBHandler()
      {
        if ((object) PreFilters.PreFilter.cb_setTagPattern_arrayB == null)
          PreFilters.PreFilter.cb_setTagPattern_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.PreFilter.n_SetTagPattern_arrayB));
        return PreFilters.PreFilter.cb_setTagPattern_arrayB;
      }

      private static void n_SetTagPattern_arrayB(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_tagPattern)
      {
        PreFilters.PreFilter preFilter = Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0);
        byte[] array = (byte[]) JNIEnv.GetArray(native_tagPattern, (JniHandleOwnership) 0, typeof (byte));
        byte[] tagPattern = array;
        preFilter.SetTagPattern(tagPattern);
        if (array == null)
          return;
        JNIEnv.CopyArray(array, native_tagPattern);
      }

      [Register("setTagPattern", "([B)V", "GetSetTagPattern_arrayBHandler")]
      public virtual unsafe void SetTagPattern(byte[]? tagPattern)
      {
        IntPtr num = JNIEnv.NewArray(tagPattern);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPattern.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          if (tagPattern != null)
          {
            JNIEnv.CopyArray(num, tagPattern);
            JNIEnv.DeleteLocalRef(num);
          }
          GC.KeepAlive((object) tagPattern);
        }
      }

      private static Delegate GetSetTagPattern_Ljava_lang_String_Handler()
      {
        if ((object) PreFilters.PreFilter.cb_setTagPattern_Ljava_lang_String_ == null)
          PreFilters.PreFilter.cb_setTagPattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.PreFilter.n_SetTagPattern_Ljava_lang_String_));
        return PreFilters.PreFilter.cb_setTagPattern_Ljava_lang_String_;
      }

      private static void n_SetTagPattern_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_tagPattern)
      {
        Object.GetObject<PreFilters.PreFilter>(jnienv, native__this, (JniHandleOwnership) 0).SetTagPattern(JNIEnv.GetString(native_tagPattern, (JniHandleOwnership) 0));
      }

      [Register("setTagPattern", "(Ljava/lang/String;)V", "GetSetTagPattern_Ljava_lang_String_Handler")]
      public virtual unsafe void SetTagPattern(string? tagPattern)
      {
        IntPtr num = JNIEnv.NewString(tagPattern);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          PreFilters.PreFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPattern.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("com/zebra/rfid/api3/PreFilters$StateAwareActionParams", DoNotGenerateAcw = true)]
    public class StateAwareActionParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/PreFilters$StateAwareActionParams", typeof (PreFilters.StateAwareActionParams));
      private static Delegate? cb_getStateAwareAction;
      private static Delegate? cb_setStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_;
      private static Delegate? cb_getTarget;
      private static Delegate? cb_setTarget_Lcom_zebra_rfid_api3_TARGET_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = PreFilters.StateAwareActionParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => PreFilters.StateAwareActionParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = PreFilters.StateAwareActionParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => PreFilters.StateAwareActionParams._members.ManagedPeerType;
      }

      protected StateAwareActionParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetStateAwareActionHandler()
      {
        if ((object) PreFilters.StateAwareActionParams.cb_getStateAwareAction == null)
          PreFilters.StateAwareActionParams.cb_getStateAwareAction = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.StateAwareActionParams.n_GetStateAwareAction));
        return PreFilters.StateAwareActionParams.cb_getStateAwareAction;
      }

      private static IntPtr n_GetStateAwareAction(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters.StateAwareActionParams>(jnienv, native__this, (JniHandleOwnership) 0).StateAwareAction);
      }

      private static Delegate GetSetStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_Handler()
      {
        if ((object) PreFilters.StateAwareActionParams.cb_setStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_ == null)
          PreFilters.StateAwareActionParams.cb_setStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.StateAwareActionParams.n_SetStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_));
        return PreFilters.StateAwareActionParams.cb_setStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_;
      }

      private static void n_SetStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_stateAwareAction)
      {
        Object.GetObject<PreFilters.StateAwareActionParams>(jnienv, native__this, (JniHandleOwnership) 0).StateAwareAction = Object.GetObject<STATE_AWARE_ACTION>(native_stateAwareAction, (JniHandleOwnership) 0);
      }

      public virtual unsafe STATE_AWARE_ACTION? StateAwareAction
      {
        [Register("getStateAwareAction", "()Lcom/zebra/rfid/api3/STATE_AWARE_ACTION;", "GetGetStateAwareActionHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.StateAwareActionParams._members.InstanceMethods.InvokeVirtualObjectMethod("getStateAwareAction.()Lcom/zebra/rfid/api3/STATE_AWARE_ACTION;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<STATE_AWARE_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setStateAwareAction", "(Lcom/zebra/rfid/api3/STATE_AWARE_ACTION;)V", "GetSetStateAwareAction_Lcom_zebra_rfid_api3_STATE_AWARE_ACTION_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            PreFilters.StateAwareActionParams._members.InstanceMethods.InvokeVirtualVoidMethod("setStateAwareAction.(Lcom/zebra/rfid/api3/STATE_AWARE_ACTION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetTargetHandler()
      {
        if ((object) PreFilters.StateAwareActionParams.cb_getTarget == null)
          PreFilters.StateAwareActionParams.cb_getTarget = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(PreFilters.StateAwareActionParams.n_GetTarget));
        return PreFilters.StateAwareActionParams.cb_getTarget;
      }

      private static IntPtr n_GetTarget(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<PreFilters.StateAwareActionParams>(jnienv, native__this, (JniHandleOwnership) 0).Target);
      }

      private static Delegate GetSetTarget_Lcom_zebra_rfid_api3_TARGET_Handler()
      {
        if ((object) PreFilters.StateAwareActionParams.cb_setTarget_Lcom_zebra_rfid_api3_TARGET_ == null)
          PreFilters.StateAwareActionParams.cb_setTarget_Lcom_zebra_rfid_api3_TARGET_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(PreFilters.StateAwareActionParams.n_SetTarget_Lcom_zebra_rfid_api3_TARGET_));
        return PreFilters.StateAwareActionParams.cb_setTarget_Lcom_zebra_rfid_api3_TARGET_;
      }

      private static void n_SetTarget_Lcom_zebra_rfid_api3_TARGET_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_target)
      {
        Object.GetObject<PreFilters.StateAwareActionParams>(jnienv, native__this, (JniHandleOwnership) 0).Target = Object.GetObject<TARGET>(native_target, (JniHandleOwnership) 0);
      }

      public virtual unsafe TARGET? Target
      {
        [Register("getTarget", "()Lcom/zebra/rfid/api3/TARGET;", "GetGetTargetHandler")] get
        {
          JniObjectReference jniObjectReference = PreFilters.StateAwareActionParams._members.InstanceMethods.InvokeVirtualObjectMethod("getTarget.()Lcom/zebra/rfid/api3/TARGET;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<TARGET>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setTarget", "(Lcom/zebra/rfid/api3/TARGET;)V", "GetSetTarget_Lcom_zebra_rfid_api3_TARGET_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            PreFilters.StateAwareActionParams._members.InstanceMethods.InvokeVirtualVoidMethod("setTarget.(Lcom/zebra/rfid/api3/TARGET;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }
    }
  }
}
