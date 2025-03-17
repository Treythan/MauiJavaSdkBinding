// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BlockPermalockAccessParams
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
  [Register("com/zebra/rfid/api3/BlockPermalockAccessParams", DoNotGenerateAcw = true)]
  public class BlockPermalockAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BlockPermalockAccessParams", typeof (BlockPermalockAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_getByteCount;
    private static Delegate? cb_setByteCount_I;
    private static Delegate? cb_getByteOffset;
    private static Delegate? cb_setByteOffset_I;
    private static Delegate? cb_getCount;
    private static Delegate? cb_setCount_I;
    private static Delegate? cb_getMaskLength;
    private static Delegate? cb_setMaskLength_I;
    private static Delegate? cb_getMemoryBank;
    private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;
    private static Delegate? cb_getReadLock;
    private static Delegate? cb_setReadLock_Z;
    private static Delegate? cb_getMask;
    private static Delegate? cb_setMask_arrayB;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BlockPermalockAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BlockPermalockAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BlockPermalockAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BlockPermalockAccessParams._members.ManagedPeerType;

    protected BlockPermalockAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BlockPermalockAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BlockPermalockAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BlockPermalockAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/MEMORY_BANK;ZIIJI[B)V", "")]
    public unsafe BlockPermalockAccessParams(
      MEMORY_BANK? m_eMemoryBank,
      bool m_bReadLock,
      int m_nByteOffset,
      int m_nByteCount,
      long m_nAccessPassword,
      int m_nMaskLength,
      byte[]? m_pMask)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray(m_pMask);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[7]
        {
          new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
          new JniArgumentValue(m_bReadLock),
          new JniArgumentValue(m_nByteOffset),
          new JniArgumentValue(m_nByteCount),
          new JniArgumentValue(m_nAccessPassword),
          new JniArgumentValue(m_nMaskLength),
          new JniArgumentValue(num)
        };
        JniObjectReference instance = BlockPermalockAccessParams._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;ZIIJI[B)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        BlockPermalockAccessParams._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;ZIIJI[B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_pMask != null)
        {
          JNIEnv.CopyArray(num, m_pMask);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_eMemoryBank);
        GC.KeepAlive((object) m_pMask);
      }
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getAccessPassword == null)
        BlockPermalockAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(BlockPermalockAccessParams.n_GetAccessPassword));
      return BlockPermalockAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setAccessPassword_J == null)
        BlockPermalockAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(BlockPermalockAccessParams.n_SetAccessPassword_J));
      return BlockPermalockAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long accessPassword)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Obsolete]
    private static Delegate GetGetByteCountHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getByteCount == null)
        BlockPermalockAccessParams.cb_getByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockPermalockAccessParams.n_GetByteCount));
      return BlockPermalockAccessParams.cb_getByteCount;
    }

    [Obsolete]
    private static int n_GetByteCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount;
    }

    [Obsolete]
    private static Delegate GetSetByteCount_IHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setByteCount_I == null)
        BlockPermalockAccessParams.cb_setByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockPermalockAccessParams.n_SetByteCount_I));
      return BlockPermalockAccessParams.cb_setByteCount_I;
    }

    [Obsolete]
    private static void n_SetByteCount_I(IntPtr jnienv, IntPtr native__this, int byteCount)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount = byteCount;
    }

    [Obsolete("deprecated")]
    public virtual unsafe int ByteCount
    {
      [Register("getByteCount", "()I", "GetGetByteCountHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setByteCount", "(I)V", "GetSetByteCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Obsolete]
    private static Delegate GetGetByteOffsetHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getByteOffset == null)
        BlockPermalockAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockPermalockAccessParams.n_GetByteOffset));
      return BlockPermalockAccessParams.cb_getByteOffset;
    }

    [Obsolete]
    private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
    }

    [Obsolete]
    private static Delegate GetSetByteOffset_IHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setByteOffset_I == null)
        BlockPermalockAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockPermalockAccessParams.n_SetByteOffset_I));
      return BlockPermalockAccessParams.cb_setByteOffset_I;
    }

    [Obsolete]
    private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
    }

    [Obsolete("deprecated")]
    public virtual unsafe int ByteOffset
    {
      [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCountHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getCount == null)
        BlockPermalockAccessParams.cb_getCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockPermalockAccessParams.n_GetCount));
      return BlockPermalockAccessParams.cb_getCount;
    }

    private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count;
    }

    private static Delegate GetSetCount_IHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setCount_I == null)
        BlockPermalockAccessParams.cb_setCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockPermalockAccessParams.n_SetCount_I));
      return BlockPermalockAccessParams.cb_setCount_I;
    }

    private static void n_SetCount_I(IntPtr jnienv, IntPtr native__this, int Count)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count = Count;
    }

    public virtual unsafe int Count
    {
      [Register("getCount", "()I", "GetGetCountHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCount", "(I)V", "GetSetCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaskLengthHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getMaskLength == null)
        BlockPermalockAccessParams.cb_getMaskLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockPermalockAccessParams.n_GetMaskLength));
      return BlockPermalockAccessParams.cb_getMaskLength;
    }

    private static int n_GetMaskLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MaskLength;
    }

    private static Delegate GetSetMaskLength_IHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setMaskLength_I == null)
        BlockPermalockAccessParams.cb_setMaskLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockPermalockAccessParams.n_SetMaskLength_I));
      return BlockPermalockAccessParams.cb_setMaskLength_I;
    }

    private static void n_SetMaskLength_I(IntPtr jnienv, IntPtr native__this, int maskLength)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MaskLength = maskLength;
    }

    public virtual unsafe int MaskLength
    {
      [Register("getMaskLength", "()I", "GetGetMaskLengthHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getMaskLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaskLength", "(I)V", "GetSetMaskLength_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMaskLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMemoryBankHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getMemoryBank == null)
        BlockPermalockAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BlockPermalockAccessParams.n_GetMemoryBank));
      return BlockPermalockAccessParams.cb_getMemoryBank;
    }

    private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
    }

    private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
    {
      if ((object) BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
        BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BlockPermalockAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
      return BlockPermalockAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    }

    private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_memoryBank)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
    }

    public virtual unsafe MEMORY_BANK? MemoryBank
    {
      [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
      {
        JniObjectReference jniObjectReference = BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getOffset == null)
        BlockPermalockAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockPermalockAccessParams.n_GetOffset));
      return BlockPermalockAccessParams.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setOffset_I == null)
        BlockPermalockAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockPermalockAccessParams.n_SetOffset_I));
      return BlockPermalockAccessParams.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetReadLockHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getReadLock == null)
        BlockPermalockAccessParams.cb_getReadLock = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(BlockPermalockAccessParams.n_GetReadLock));
      return BlockPermalockAccessParams.cb_getReadLock;
    }

    private static bool n_GetReadLock(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ReadLock;
    }

    private static Delegate GetSetReadLock_ZHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setReadLock_Z == null)
        BlockPermalockAccessParams.cb_setReadLock_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(BlockPermalockAccessParams.n_SetReadLock_Z));
      return BlockPermalockAccessParams.cb_setReadLock_Z;
    }

    private static void n_SetReadLock_Z(IntPtr jnienv, IntPtr native__this, bool readLock)
    {
      Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ReadLock = readLock;
    }

    public virtual unsafe bool ReadLock
    {
      [Register("getReadLock", "()Z", "GetGetReadLockHandler")] get
      {
        return BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getReadLock.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setReadLock", "(Z)V", "GetSetReadLock_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setReadLock.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaskHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_getMask == null)
        BlockPermalockAccessParams.cb_getMask = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BlockPermalockAccessParams.n_GetMask));
      return BlockPermalockAccessParams.cb_getMask;
    }

    private static IntPtr n_GetMask(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetMask());
    }

    [Register("getMask", "()[B", "GetGetMaskHandler")]
    public virtual unsafe byte[]? GetMask()
    {
      JniObjectReference jniObjectReference = BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMask.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetMask_arrayBHandler()
    {
      if ((object) BlockPermalockAccessParams.cb_setMask_arrayB == null)
        BlockPermalockAccessParams.cb_setMask_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BlockPermalockAccessParams.n_SetMask_arrayB));
      return BlockPermalockAccessParams.cb_setMask_arrayB;
    }

    private static void n_SetMask_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_mask)
    {
      BlockPermalockAccessParams permalockAccessParams = Object.GetObject<BlockPermalockAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_mask, (JniHandleOwnership) 0, typeof (byte));
      byte[] mask = array;
      permalockAccessParams.SetMask(mask);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_mask);
    }

    [Register("setMask", "([B)V", "GetSetMask_arrayBHandler")]
    public virtual unsafe void SetMask(byte[]? mask)
    {
      IntPtr num = JNIEnv.NewArray(mask);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        BlockPermalockAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMask.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (mask != null)
        {
          JNIEnv.CopyArray(num, mask);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) mask);
      }
    }
  }
}
