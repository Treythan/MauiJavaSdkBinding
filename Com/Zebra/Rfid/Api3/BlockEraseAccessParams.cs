// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BlockEraseAccessParams
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
  [Register("com/zebra/rfid/api3/BlockEraseAccessParams", DoNotGenerateAcw = true)]
  public class BlockEraseAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BlockEraseAccessParams", typeof (BlockEraseAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_getByteCount;
    private static Delegate? cb_setByteCount_I;
    private static Delegate? cb_getByteOffset;
    private static Delegate? cb_setByteOffset_I;
    private static Delegate? cb_getCount;
    private static Delegate? cb_setCount_I;
    private static Delegate? cb_getMemoryBank;
    private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BlockEraseAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BlockEraseAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BlockEraseAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BlockEraseAccessParams._members.ManagedPeerType;

    protected BlockEraseAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BlockEraseAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BlockEraseAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BlockEraseAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V", "")]
    public unsafe BlockEraseAccessParams(
      MEMORY_BANK? m_eMemoryBank,
      int m_nByteOffset,
      int m_nByteCount,
      long m_nAccessPassword)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
          new JniArgumentValue(m_nByteOffset),
          new JniArgumentValue(m_nByteCount),
          new JniArgumentValue(m_nAccessPassword)
        };
        JniObjectReference instance = BlockEraseAccessParams._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        BlockEraseAccessParams._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) m_eMemoryBank);
      }
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getAccessPassword == null)
        BlockEraseAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(BlockEraseAccessParams.n_GetAccessPassword));
      return BlockEraseAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) BlockEraseAccessParams.cb_setAccessPassword_J == null)
        BlockEraseAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(BlockEraseAccessParams.n_SetAccessPassword_J));
      return BlockEraseAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long accessPassword)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Obsolete]
    private static Delegate GetGetByteCountHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getByteCount == null)
        BlockEraseAccessParams.cb_getByteCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockEraseAccessParams.n_GetByteCount));
      return BlockEraseAccessParams.cb_getByteCount;
    }

    [Obsolete]
    private static int n_GetByteCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount;
    }

    [Obsolete]
    private static Delegate GetSetByteCount_IHandler()
    {
      if ((object) BlockEraseAccessParams.cb_setByteCount_I == null)
        BlockEraseAccessParams.cb_setByteCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockEraseAccessParams.n_SetByteCount_I));
      return BlockEraseAccessParams.cb_setByteCount_I;
    }

    [Obsolete]
    private static void n_SetByteCount_I(IntPtr jnienv, IntPtr native__this, int byteCount)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteCount = byteCount;
    }

    [Obsolete("deprecated")]
    public virtual unsafe int ByteCount
    {
      [Register("getByteCount", "()I", "GetGetByteCountHandler")] get
      {
        return BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setByteCount", "(I)V", "GetSetByteCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Obsolete]
    private static Delegate GetGetByteOffsetHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getByteOffset == null)
        BlockEraseAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockEraseAccessParams.n_GetByteOffset));
      return BlockEraseAccessParams.cb_getByteOffset;
    }

    [Obsolete]
    private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
    }

    [Obsolete]
    private static Delegate GetSetByteOffset_IHandler()
    {
      if ((object) BlockEraseAccessParams.cb_setByteOffset_I == null)
        BlockEraseAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockEraseAccessParams.n_SetByteOffset_I));
      return BlockEraseAccessParams.cb_setByteOffset_I;
    }

    [Obsolete]
    private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
    }

    [Obsolete("deprecated")]
    public virtual unsafe int ByteOffset
    {
      [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
      {
        return BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetCountHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getCount == null)
        BlockEraseAccessParams.cb_getCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockEraseAccessParams.n_GetCount));
      return BlockEraseAccessParams.cb_getCount;
    }

    private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count;
    }

    private static Delegate GetSetCount_IHandler()
    {
      if ((object) BlockEraseAccessParams.cb_setCount_I == null)
        BlockEraseAccessParams.cb_setCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockEraseAccessParams.n_SetCount_I));
      return BlockEraseAccessParams.cb_setCount_I;
    }

    private static void n_SetCount_I(IntPtr jnienv, IntPtr native__this, int Count)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Count = Count;
    }

    public virtual unsafe int Count
    {
      [Register("getCount", "()I", "GetGetCountHandler")] get
      {
        return BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCount", "(I)V", "GetSetCount_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMemoryBankHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getMemoryBank == null)
        BlockEraseAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BlockEraseAccessParams.n_GetMemoryBank));
      return BlockEraseAccessParams.cb_getMemoryBank;
    }

    private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
    }

    private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
    {
      if ((object) BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
        BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(BlockEraseAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
      return BlockEraseAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    }

    private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_memoryBank)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
    }

    public virtual unsafe MEMORY_BANK? MemoryBank
    {
      [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
      {
        JniObjectReference jniObjectReference = BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) BlockEraseAccessParams.cb_getOffset == null)
        BlockEraseAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BlockEraseAccessParams.n_GetOffset));
      return BlockEraseAccessParams.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) BlockEraseAccessParams.cb_setOffset_I == null)
        BlockEraseAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(BlockEraseAccessParams.n_SetOffset_I));
      return BlockEraseAccessParams.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
    {
      Object.GetObject<BlockEraseAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        BlockEraseAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
