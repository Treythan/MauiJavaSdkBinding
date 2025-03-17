// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WriteAccessParams
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
  [Register("com/zebra/rfid/api3/WriteAccessParams", DoNotGenerateAcw = true)]
  public class WriteAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WriteAccessParams", typeof (WriteAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_getByteOffset;
    private static Delegate? cb_setByteOffset_I;
    private static Delegate? cb_getMemoryBank;
    private static Delegate? cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;
    private static Delegate? cb_getStringWriteData;
    private static Delegate? cb_getWriteDataLength;
    private static Delegate? cb_setWriteDataLength_I;
    private static Delegate? cb_getWriteRetries;
    private static Delegate? cb_setWriteRetries_I;
    private static Delegate? cb_getWriteData;
    private static Delegate? cb_setWriteData_arrayB;
    private static Delegate? cb_setWriteData_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WriteAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WriteAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WriteAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => WriteAccessParams._members.ManagedPeerType;

    protected WriteAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe WriteAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = WriteAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      WriteAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ[B)V", "")]
    public unsafe WriteAccessParams(
      MEMORY_BANK? m_eMemoryBank,
      int m_nByteOffset,
      int m_nWriteDataLength,
      long m_nAccessPassword,
      byte[]? m_WriteData)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewArray(m_WriteData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(m_eMemoryBank == null ? IntPtr.Zero : m_eMemoryBank.Handle),
          new JniArgumentValue(m_nByteOffset),
          new JniArgumentValue(m_nWriteDataLength),
          new JniArgumentValue(m_nAccessPassword),
          new JniArgumentValue(num)
        };
        JniObjectReference instance = WriteAccessParams._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ[B)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        WriteAccessParams._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/MEMORY_BANK;IIJ[B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (m_WriteData != null)
        {
          JNIEnv.CopyArray(num, m_WriteData);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) m_eMemoryBank);
        GC.KeepAlive((object) m_WriteData);
      }
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) WriteAccessParams.cb_getAccessPassword == null)
        WriteAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(WriteAccessParams.n_GetAccessPassword));
      return WriteAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) WriteAccessParams.cb_setAccessPassword_J == null)
        WriteAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(WriteAccessParams.n_SetAccessPassword_J));
      return WriteAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long accessPassword)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = accessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return WriteAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    [Obsolete]
    private static Delegate GetGetByteOffsetHandler()
    {
      if ((object) WriteAccessParams.cb_getByteOffset == null)
        WriteAccessParams.cb_getByteOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WriteAccessParams.n_GetByteOffset));
      return WriteAccessParams.cb_getByteOffset;
    }

    [Obsolete]
    private static int n_GetByteOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset;
    }

    [Obsolete]
    private static Delegate GetSetByteOffset_IHandler()
    {
      if ((object) WriteAccessParams.cb_setByteOffset_I == null)
        WriteAccessParams.cb_setByteOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(WriteAccessParams.n_SetByteOffset_I));
      return WriteAccessParams.cb_setByteOffset_I;
    }

    [Obsolete]
    private static void n_SetByteOffset_I(IntPtr jnienv, IntPtr native__this, int byteOffset)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).ByteOffset = byteOffset;
    }

    [Obsolete("deprecated")]
    public virtual unsafe int ByteOffset
    {
      [Register("getByteOffset", "()I", "GetGetByteOffsetHandler")] get
      {
        return WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getByteOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setByteOffset", "(I)V", "GetSetByteOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setByteOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMemoryBankHandler()
    {
      if ((object) WriteAccessParams.cb_getMemoryBank == null)
        WriteAccessParams.cb_getMemoryBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WriteAccessParams.n_GetMemoryBank));
      return WriteAccessParams.cb_getMemoryBank;
    }

    private static IntPtr n_GetMemoryBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank);
    }

    private static Delegate GetSetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_Handler()
    {
      if ((object) WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ == null)
        WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WriteAccessParams.n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_));
      return WriteAccessParams.cb_setMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_;
    }

    private static void n_SetMemoryBank_Lcom_zebra_rfid_api3_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_memoryBank)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).MemoryBank = Object.GetObject<MEMORY_BANK>(native_memoryBank, (JniHandleOwnership) 0);
    }

    public virtual unsafe MEMORY_BANK? MemoryBank
    {
      [Register("getMemoryBank", "()Lcom/zebra/rfid/api3/MEMORY_BANK;", "GetGetMemoryBankHandler")] get
      {
        JniObjectReference jniObjectReference = WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMemoryBank.()Lcom/zebra/rfid/api3/MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
          WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMemoryBank.(Lcom/zebra/rfid/api3/MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) WriteAccessParams.cb_getOffset == null)
        WriteAccessParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WriteAccessParams.n_GetOffset));
      return WriteAccessParams.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) WriteAccessParams.cb_setOffset_I == null)
        WriteAccessParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(WriteAccessParams.n_SetOffset_I));
      return WriteAccessParams.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int Offset)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = Offset;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStringWriteDataHandler()
    {
      if ((object) WriteAccessParams.cb_getStringWriteData == null)
        WriteAccessParams.cb_getStringWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WriteAccessParams.n_GetStringWriteData));
      return WriteAccessParams.cb_getStringWriteData;
    }

    private static IntPtr n_GetStringWriteData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).StringWriteData);
    }

    public virtual unsafe string? StringWriteData
    {
      [Register("getStringWriteData", "()Ljava/lang/String;", "GetGetStringWriteDataHandler")] get
      {
        JniObjectReference jniObjectReference = WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getStringWriteData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetWriteDataLengthHandler()
    {
      if ((object) WriteAccessParams.cb_getWriteDataLength == null)
        WriteAccessParams.cb_getWriteDataLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WriteAccessParams.n_GetWriteDataLength));
      return WriteAccessParams.cb_getWriteDataLength;
    }

    private static int n_GetWriteDataLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength;
    }

    private static Delegate GetSetWriteDataLength_IHandler()
    {
      if ((object) WriteAccessParams.cb_setWriteDataLength_I == null)
        WriteAccessParams.cb_setWriteDataLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(WriteAccessParams.n_SetWriteDataLength_I));
      return WriteAccessParams.cb_setWriteDataLength_I;
    }

    private static void n_SetWriteDataLength_I(
      IntPtr jnienv,
      IntPtr native__this,
      int writeDataLength)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteDataLength = writeDataLength;
    }

    public virtual unsafe int WriteDataLength
    {
      [Register("getWriteDataLength", "()I", "GetGetWriteDataLengthHandler")] get
      {
        return WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getWriteDataLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setWriteDataLength", "(I)V", "GetSetWriteDataLength_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteDataLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetWriteRetriesHandler()
    {
      if ((object) WriteAccessParams.cb_getWriteRetries == null)
        WriteAccessParams.cb_getWriteRetries = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WriteAccessParams.n_GetWriteRetries));
      return WriteAccessParams.cb_getWriteRetries;
    }

    private static int n_GetWriteRetries(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteRetries;
    }

    private static Delegate GetSetWriteRetries_IHandler()
    {
      if ((object) WriteAccessParams.cb_setWriteRetries_I == null)
        WriteAccessParams.cb_setWriteRetries_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(WriteAccessParams.n_SetWriteRetries_I));
      return WriteAccessParams.cb_setWriteRetries_I;
    }

    private static void n_SetWriteRetries_I(IntPtr jnienv, IntPtr native__this, int writeRetries)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).WriteRetries = writeRetries;
    }

    public virtual unsafe int WriteRetries
    {
      [Register("getWriteRetries", "()I", "GetGetWriteRetriesHandler")] get
      {
        return WriteAccessParams._members.InstanceMethods.InvokeVirtualInt32Method("getWriteRetries.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setWriteRetries", "(I)V", "GetSetWriteRetries_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteRetries.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetWriteDataHandler()
    {
      if ((object) WriteAccessParams.cb_getWriteData == null)
        WriteAccessParams.cb_getWriteData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(WriteAccessParams.n_GetWriteData));
      return WriteAccessParams.cb_getWriteData;
    }

    private static IntPtr n_GetWriteData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).GetWriteData());
    }

    [Register("getWriteData", "()[B", "GetGetWriteDataHandler")]
    public virtual unsafe byte[]? GetWriteData()
    {
      JniObjectReference jniObjectReference = WriteAccessParams._members.InstanceMethods.InvokeVirtualObjectMethod("getWriteData.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    [Obsolete]
    private static Delegate GetSetWriteData_arrayBHandler()
    {
      if ((object) WriteAccessParams.cb_setWriteData_arrayB == null)
        WriteAccessParams.cb_setWriteData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WriteAccessParams.n_SetWriteData_arrayB));
      return WriteAccessParams.cb_setWriteData_arrayB;
    }

    [Obsolete]
    private static void n_SetWriteData_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_writeData)
    {
      WriteAccessParams writeAccessParams = Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_writeData, (JniHandleOwnership) 0, typeof (byte));
      byte[] writeData = array;
      writeAccessParams.SetWriteData(writeData);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_writeData);
    }

    [Obsolete("deprecated")]
    [Register("setWriteData", "([B)V", "GetSetWriteData_arrayBHandler")]
    public virtual unsafe void SetWriteData(byte[]? writeData)
    {
      IntPtr num = JNIEnv.NewArray(writeData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (writeData != null)
        {
          JNIEnv.CopyArray(num, writeData);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) writeData);
      }
    }

    private static Delegate GetSetWriteData_Ljava_lang_String_Handler()
    {
      if ((object) WriteAccessParams.cb_setWriteData_Ljava_lang_String_ == null)
        WriteAccessParams.cb_setWriteData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(WriteAccessParams.n_SetWriteData_Ljava_lang_String_));
      return WriteAccessParams.cb_setWriteData_Ljava_lang_String_;
    }

    private static void n_SetWriteData_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_writeDataInStringFormat)
    {
      Object.GetObject<WriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).SetWriteData(JNIEnv.GetString(native_writeDataInStringFormat, (JniHandleOwnership) 0));
    }

    [Register("setWriteData", "(Ljava/lang/String;)V", "GetSetWriteData_Ljava_lang_String_Handler")]
    public virtual unsafe void SetWriteData(string? writeDataInStringFormat)
    {
      IntPtr num = JNIEnv.NewString(writeDataInStringFormat);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        WriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWriteData.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
