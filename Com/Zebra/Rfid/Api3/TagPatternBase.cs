// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagPatternBase
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
  [Register("com/zebra/rfid/api3/TagPatternBase", DoNotGenerateAcw = true)]
  public class TagPatternBase : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagPatternBase", typeof (TagPatternBase));
    private static Delegate? cb_getBitOffset;
    private static Delegate? cb_setBitOffset_I;
    private static Delegate? cb_getMemoryBank;
    private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    private static Delegate? cb_getStringTagMask;
    private static Delegate? cb_getStringTagPattern;
    private static Delegate? cb_getTagMaskBitCount;
    private static Delegate? cb_setTagMaskBitCount_I;
    private static Delegate? cb_getTagPatternBitCount;
    private static Delegate? cb_setTagPatternBitCount_I;
    private static Delegate? cb_getTagMask;
    private static Delegate? cb_getTagPattern;
    private static Delegate? cb_setTagMask_arrayB;
    private static Delegate? cb_setTagMask_Ljava_lang_String_;
    private static Delegate? cb_setTagPattern_arrayB;
    private static Delegate? cb_setTagPattern_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TagPatternBase._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagPatternBase._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagPatternBase._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagPatternBase._members.ManagedPeerType;

    protected TagPatternBase(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TagPatternBase()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TagPatternBase._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagPatternBase._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetBitOffsetHandler()
    {
      if ((object) TagPatternBase.cb_getBitOffset == null)
        TagPatternBase.cb_getBitOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagPatternBase.n_GetBitOffset));
      return TagPatternBase.cb_getBitOffset;
    }

    private static int n_GetBitOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).BitOffset;
    }

    private static Delegate GetSetBitOffset_IHandler()
    {
      if ((object) TagPatternBase.cb_setBitOffset_I == null)
        TagPatternBase.cb_setBitOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagPatternBase.n_SetBitOffset_I));
      return TagPatternBase.cb_setBitOffset_I;
    }

    private static void n_SetBitOffset_I(IntPtr jnienv, IntPtr native__this, int bitOffset)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).BitOffset = bitOffset;
    }

    public virtual unsafe int BitOffset
    {
      [Register("getBitOffset", "()I", "GetGetBitOffsetHandler")] get
      {
        return TagPatternBase._members.InstanceMethods.InvokeVirtualInt32Method("getBitOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBitOffset", "(I)V", "GetSetBitOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setBitOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMemoryBankHandler()
    {
      if ((object) TagPatternBase.cb_getMemoryBank == null)
        TagPatternBase.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagPatternBase.n_GetMemoryBank));
      return TagPatternBase.cb_getMemoryBank;
    }

    private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
    }

    private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
    {
      if ((object) TagPatternBase.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
        TagPatternBase.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagPatternBase.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
      return TagPatternBase.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    }

    private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_memoryBank)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
    }

    public virtual unsafe MEMORY_BANK? MemoryBank
    {
      [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
      {
        JniObjectReference jniObjectReference = TagPatternBase._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetStringTagMaskHandler()
    {
      if ((object) TagPatternBase.cb_getStringTagMask == null)
        TagPatternBase.cb_getStringTagMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagPatternBase.n_GetStringTagMask));
      return TagPatternBase.cb_getStringTagMask;
    }

    private static IntPtr n_GetStringTagMask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).StringTagMask);
    }

    public virtual unsafe string? StringTagMask
    {
      [Register("getStringTagMask", "()Ljava/lang/String;", "GetGetStringTagMaskHandler")] get
      {
        JniObjectReference jniObjectReference = TagPatternBase._members.InstanceMethods.InvokeVirtualObjectMethod("getStringTagMask.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetStringTagPatternHandler()
    {
      if ((object) TagPatternBase.cb_getStringTagPattern == null)
        TagPatternBase.cb_getStringTagPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagPatternBase.n_GetStringTagPattern));
      return TagPatternBase.cb_getStringTagPattern;
    }

    private static IntPtr n_GetStringTagPattern(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).StringTagPattern);
    }

    public virtual unsafe string? StringTagPattern
    {
      [Register("getStringTagPattern", "()Ljava/lang/String;", "GetGetStringTagPatternHandler")] get
      {
        JniObjectReference jniObjectReference = TagPatternBase._members.InstanceMethods.InvokeVirtualObjectMethod("getStringTagPattern.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetTagMaskBitCountHandler()
    {
      if ((object) TagPatternBase.cb_getTagMaskBitCount == null)
        TagPatternBase.cb_getTagMaskBitCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagPatternBase.n_GetTagMaskBitCount));
      return TagPatternBase.cb_getTagMaskBitCount;
    }

    private static int n_GetTagMaskBitCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).TagMaskBitCount;
    }

    private static Delegate GetSetTagMaskBitCount_IHandler()
    {
      if ((object) TagPatternBase.cb_setTagMaskBitCount_I == null)
        TagPatternBase.cb_setTagMaskBitCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagPatternBase.n_SetTagMaskBitCount_I));
      return TagPatternBase.cb_setTagMaskBitCount_I;
    }

    private static void n_SetTagMaskBitCount_I(
      IntPtr jnienv,
      IntPtr native__this,
      int tagMaskBitCount)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).TagMaskBitCount = tagMaskBitCount;
    }

    public virtual unsafe int TagMaskBitCount
    {
      [Register("getTagMaskBitCount", "()I", "GetGetTagMaskBitCountHandler")] get
      {
        return TagPatternBase._members.InstanceMethods.InvokeVirtualInt32Method("getTagMaskBitCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagMaskBitCount", "(I)V", "GetSetTagMaskBitCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagMaskBitCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTagPatternBitCountHandler()
    {
      if ((object) TagPatternBase.cb_getTagPatternBitCount == null)
        TagPatternBase.cb_getTagPatternBitCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagPatternBase.n_GetTagPatternBitCount));
      return TagPatternBase.cb_getTagPatternBitCount;
    }

    private static int n_GetTagPatternBitCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).TagPatternBitCount;
    }

    private static Delegate GetSetTagPatternBitCount_IHandler()
    {
      if ((object) TagPatternBase.cb_setTagPatternBitCount_I == null)
        TagPatternBase.cb_setTagPatternBitCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(TagPatternBase.n_SetTagPatternBitCount_I));
      return TagPatternBase.cb_setTagPatternBitCount_I;
    }

    private static void n_SetTagPatternBitCount_I(
      IntPtr jnienv,
      IntPtr native__this,
      int tagPatternBitCount)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).TagPatternBitCount = tagPatternBitCount;
    }

    public virtual unsafe int TagPatternBitCount
    {
      [Register("getTagPatternBitCount", "()I", "GetGetTagPatternBitCountHandler")] get
      {
        return TagPatternBase._members.InstanceMethods.InvokeVirtualInt32Method("getTagPatternBitCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTagPatternBitCount", "(I)V", "GetSetTagPatternBitCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPatternBitCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTagMaskHandler()
    {
      if ((object) TagPatternBase.cb_getTagMask == null)
        TagPatternBase.cb_getTagMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagPatternBase.n_GetTagMask));
      return TagPatternBase.cb_getTagMask;
    }

    private static IntPtr n_GetTagMask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).GetTagMask());
    }

    [Register("getTagMask", "()[B", "GetGetTagMaskHandler")]
    public virtual unsafe byte[]? GetTagMask()
    {
      JniObjectReference jniObjectReference = TagPatternBase._members.InstanceMethods.InvokeVirtualObjectMethod("getTagMask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetTagPatternHandler()
    {
      if ((object) TagPatternBase.cb_getTagPattern == null)
        TagPatternBase.cb_getTagPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagPatternBase.n_GetTagPattern));
      return TagPatternBase.cb_getTagPattern;
    }

    private static IntPtr n_GetTagPattern(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).GetTagPattern());
    }

    [Register("getTagPattern", "()[B", "GetGetTagPatternHandler")]
    public virtual unsafe byte[]? GetTagPattern()
    {
      JniObjectReference jniObjectReference = TagPatternBase._members.InstanceMethods.InvokeVirtualObjectMethod("getTagPattern.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetTagMask_arrayBHandler()
    {
      if ((object) TagPatternBase.cb_setTagMask_arrayB == null)
        TagPatternBase.cb_setTagMask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagPatternBase.n_SetTagMask_arrayB));
      return TagPatternBase.cb_setTagMask_arrayB;
    }

    private static void n_SetTagMask_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagMask)
    {
      TagPatternBase tagPatternBase = Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_tagMask, (JniHandleOwnership) 0, typeof (byte));
      byte[] tagMask = array;
      tagPatternBase.SetTagMask(tagMask);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_tagMask);
    }

    [Register("setTagMask", "([B)V", "GetSetTagMask_arrayBHandler")]
    public virtual unsafe void SetTagMask(byte[]? tagMask)
    {
      IntPtr num = JNIEnv.NewArray(tagMask);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagMask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (tagMask != null)
        {
          JNIEnv.CopyArray(num, tagMask);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) tagMask);
      }
    }

    private static Delegate GetSetTagMask_Ljava_lang_String_Handler()
    {
      if ((object) TagPatternBase.cb_setTagMask_Ljava_lang_String_ == null)
        TagPatternBase.cb_setTagMask_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagPatternBase.n_SetTagMask_Ljava_lang_String_));
      return TagPatternBase.cb_setTagMask_Ljava_lang_String_;
    }

    private static void n_SetTagMask_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagMask)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).SetTagMask(JNIEnv.GetString(native_tagMask, (JniHandleOwnership) 0));
    }

    [Register("setTagMask", "(Ljava/lang/String;)V", "GetSetTagMask_Ljava_lang_String_Handler")]
    public virtual unsafe void SetTagMask(string? tagMask)
    {
      IntPtr num = JNIEnv.NewString(tagMask);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagMask.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetTagPattern_arrayBHandler()
    {
      if ((object) TagPatternBase.cb_setTagPattern_arrayB == null)
        TagPatternBase.cb_setTagPattern_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagPatternBase.n_SetTagPattern_arrayB));
      return TagPatternBase.cb_setTagPattern_arrayB;
    }

    private static void n_SetTagPattern_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagPattern)
    {
      TagPatternBase tagPatternBase = Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_tagPattern, (JniHandleOwnership) 0, typeof (byte));
      byte[] tagPattern = array;
      tagPatternBase.SetTagPattern(tagPattern);
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
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPattern.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
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
      if ((object) TagPatternBase.cb_setTagPattern_Ljava_lang_String_ == null)
        TagPatternBase.cb_setTagPattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(TagPatternBase.n_SetTagPattern_Ljava_lang_String_));
      return TagPatternBase.cb_setTagPattern_Ljava_lang_String_;
    }

    private static void n_SetTagPattern_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_tagPattern)
    {
      Object.GetObject<TagPatternBase>(jnienv, native__this, (JniHandleOwnership) 0).SetTagPattern(JNIEnv.GetString(native_tagPattern, (JniHandleOwnership) 0));
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
        TagPatternBase._members.InstanceMethods.InvokeVirtualVoidMethod("setTagPattern.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
