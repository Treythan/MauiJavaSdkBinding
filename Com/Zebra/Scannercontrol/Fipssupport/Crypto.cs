// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.Fipssupport.Crypto
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
namespace Com.Zebra.Scannercontrol.Fipssupport
{
  [Register("com/zebra/scannercontrol/fipssupport/Crypto", DoNotGenerateAcw = true)]
  public class Crypto : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/fipssupport/Crypto", typeof (Crypto));
    private static Delegate? cb_getAESKey;
    private static Delegate? cb_getKeySize;
    private static Delegate? cb_getScannerSharedKey;
    private static Delegate? cb_getSharedKey;
    private static Delegate? cb_decryptData_arrayB;
    private static Delegate? cb_defaultAESKey;
    private static Delegate? cb_defaultSharedKey;
    private static Delegate? cb_generateNewKey_I;
    private static Delegate? cb_getSharedKeyEncrypted;
    private static Delegate? cb_setDefaultKey;
    private static Delegate? cb_setKeyInfo_arrayBarrayB;
    private static Delegate? cb_setSharedKey;

    [Register("keyUnwrapFailed")]
    public static string? KeyUnwrapFailed
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapFailed.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapFailed.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("keyUnwrapFailedWithCipherMisMatch")]
    public static string? KeyUnwrapFailedWithCipherMisMatch
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapFailedWithCipherMisMatch.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapFailedWithCipherMisMatch.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("keyUnwrapFailedWithDataMisMatch")]
    public static string? KeyUnwrapFailedWithDataMisMatch
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapFailedWithDataMisMatch.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapFailedWithDataMisMatch.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("keyUnwrapFailedWithInvalidSharedKey")]
    public static string? KeyUnwrapFailedWithInvalidSharedKey
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapFailedWithInvalidSharedKey.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapFailedWithInvalidSharedKey.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("keyUnwrapSuccess")]
    public static string? KeyUnwrapSuccess
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapSuccess.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapSuccess.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("keyUnwrapSuccessWithDecryptDataMatched")]
    public static string? KeyUnwrapSuccessWithDecryptDataMatched
    {
      get
      {
        JniObjectReference objectValue = Crypto._members.StaticFields.GetObjectValue("keyUnwrapSuccessWithDecryptDataMatched.Ljava/lang/String;");
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Crypto._members.StaticFields.SetValue("keyUnwrapSuccessWithDecryptDataMatched.Ljava/lang/String;", new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Crypto._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Crypto._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Crypto._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Crypto._members.ManagedPeerType;

    protected Crypto(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(I)V", "")]
    public unsafe Crypto(int keySize)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(keySize)
      };
      JniObjectReference instance = Crypto._members.InstanceMethods.StartCreateInstance("(I)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Crypto._members.InstanceMethods.FinishCreateInstance("(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetAESKeyHandler()
    {
      if ((object) Crypto.cb_getAESKey == null)
        Crypto.cb_getAESKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Crypto.n_GetAESKey));
      return Crypto.cb_getAESKey;
    }

    private static IntPtr n_GetAESKey(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).AESKey);
    }

    public virtual unsafe string? AESKey
    {
      [Register("getAESKey", "()Ljava/lang/String;", "GetGetAESKeyHandler")] get
      {
        JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getAESKey.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetKeySizeHandler()
    {
      if ((object) Crypto.cb_getKeySize == null)
        Crypto.cb_getKeySize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Crypto.n_GetKeySize));
      return Crypto.cb_getKeySize;
    }

    private static int n_GetKeySize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).KeySize;
    }

    public virtual unsafe int KeySize
    {
      [Register("getKeySize", "()I", "GetGetKeySizeHandler")] get
      {
        return Crypto._members.InstanceMethods.InvokeVirtualInt32Method("getKeySize.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetScannerSharedKeyHandler()
    {
      if ((object) Crypto.cb_getScannerSharedKey == null)
        Crypto.cb_getScannerSharedKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Crypto.n_GetScannerSharedKey));
      return Crypto.cb_getScannerSharedKey;
    }

    private static IntPtr n_GetScannerSharedKey(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).ScannerSharedKey);
    }

    public virtual unsafe string? ScannerSharedKey
    {
      [Register("getScannerSharedKey", "()Ljava/lang/String;", "GetGetScannerSharedKeyHandler")] get
      {
        JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getScannerSharedKey.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetSharedKeyHandler()
    {
      if ((object) Crypto.cb_getSharedKey == null)
        Crypto.cb_getSharedKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Crypto.n_GetSharedKey));
      return Crypto.cb_getSharedKey;
    }

    private static IntPtr n_GetSharedKey(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).SharedKey);
    }

    public virtual unsafe string? SharedKey
    {
      [Register("getSharedKey", "()Ljava/lang/String;", "GetGetSharedKeyHandler")] get
      {
        JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getSharedKey.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetDecryptData_arrayBHandler()
    {
      if ((object) Crypto.cb_decryptData_arrayB == null)
        Crypto.cb_decryptData_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(Crypto.n_DecryptData_arrayB));
      return Crypto.cb_decryptData_arrayB;
    }

    private static IntPtr n_DecryptData_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cipherText)
    {
      Crypto crypto = Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_cipherText, (JniHandleOwnership) 0, typeof (byte));
      byte[] cipherText = array;
      IntPtr num = JNIEnv.NewArray(crypto.DecryptData(cipherText));
      if (array == null)
        return num;
      JNIEnv.CopyArray(array, native_cipherText);
      return num;
    }

    [Register("decryptData", "([B)[B", "GetDecryptData_arrayBHandler")]
    public virtual unsafe byte[]? DecryptData(byte[]? cipherText)
    {
      IntPtr num = JNIEnv.NewArray(cipherText);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("decryptData.([B)[B", (IJavaPeerable) this, jniArgumentValuePtr);
        return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
      }
      finally
      {
        if (cipherText != null)
        {
          JNIEnv.CopyArray(num, cipherText);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) cipherText);
      }
    }

    private static Delegate GetDefaultAESKeyHandler()
    {
      if ((object) Crypto.cb_defaultAESKey == null)
        Crypto.cb_defaultAESKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Crypto.n_DefaultAESKey));
      return Crypto.cb_defaultAESKey;
    }

    private static bool n_DefaultAESKey(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).DefaultAESKey();
    }

    [Register("defaultAESKey", "()Z", "GetDefaultAESKeyHandler")]
    public virtual unsafe bool DefaultAESKey()
    {
      return Crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("defaultAESKey.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetDefaultSharedKeyHandler()
    {
      if ((object) Crypto.cb_defaultSharedKey == null)
        Crypto.cb_defaultSharedKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Crypto.n_DefaultSharedKey));
      return Crypto.cb_defaultSharedKey;
    }

    private static bool n_DefaultSharedKey(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).DefaultSharedKey();
    }

    [Register("defaultSharedKey", "()Z", "GetDefaultSharedKeyHandler")]
    public virtual unsafe bool DefaultSharedKey()
    {
      return Crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("defaultSharedKey.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGenerateNewKey_IHandler()
    {
      if ((object) Crypto.cb_generateNewKey_I == null)
        Crypto.cb_generateNewKey_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(Crypto.n_GenerateNewKey_I));
      return Crypto.cb_generateNewKey_I;
    }

    private static IntPtr n_GenerateNewKey_I(IntPtr jnienv, IntPtr native__this, int size)
    {
      return JNIEnv.NewArray(Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).GenerateNewKey(size));
    }

    [Register("generateNewKey", "(I)[B", "GetGenerateNewKey_IHandler")]
    public virtual unsafe byte[]? GenerateNewKey(int size)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(size)
      };
      JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("generateNewKey.(I)[B", (IJavaPeerable) this, jniArgumentValuePtr);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetGetSharedKeyEncryptedHandler()
    {
      if ((object) Crypto.cb_getSharedKeyEncrypted == null)
        Crypto.cb_getSharedKeyEncrypted = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Crypto.n_GetSharedKeyEncrypted));
      return Crypto.cb_getSharedKeyEncrypted;
    }

    private static IntPtr n_GetSharedKeyEncrypted(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).GetSharedKeyEncrypted());
    }

    [Register("getSharedKeyEncrypted", "()[B", "GetGetSharedKeyEncryptedHandler")]
    public virtual unsafe byte[]? GetSharedKeyEncrypted()
    {
      JniObjectReference jniObjectReference = Crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getSharedKeyEncrypted.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetDefaultKeyHandler()
    {
      if ((object) Crypto.cb_setDefaultKey == null)
        Crypto.cb_setDefaultKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Crypto.n_SetDefaultKey));
      return Crypto.cb_setDefaultKey;
    }

    private static bool n_SetDefaultKey(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).SetDefaultKey();
    }

    [Register("setDefaultKey", "()Z", "GetSetDefaultKeyHandler")]
    public virtual unsafe bool SetDefaultKey()
    {
      return Crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("setDefaultKey.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetKeyInfo_arrayBarrayBHandler()
    {
      if ((object) Crypto.cb_setKeyInfo_arrayBarrayB == null)
        Crypto.cb_setKeyInfo_arrayBarrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_Z(Crypto.n_SetKeyInfo_arrayBarrayB));
      return Crypto.cb_setKeyInfo_arrayBarrayB;
    }

    private static bool n_SetKeyInfo_arrayBarrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_enryptedKeyWithHash,
      IntPtr native_initializationVector)
    {
      Crypto crypto = Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array1 = (byte[]) JNIEnv.GetArray(native_enryptedKeyWithHash, (JniHandleOwnership) 0, typeof (byte));
      byte[] array2 = (byte[]) JNIEnv.GetArray(native_initializationVector, (JniHandleOwnership) 0, typeof (byte));
      byte[] enryptedKeyWithHash = array1;
      byte[] initializationVector = array2;
      int num = crypto.SetKeyInfo(enryptedKeyWithHash, initializationVector) ? 1 : 0;
      if (array1 != null)
        JNIEnv.CopyArray(array1, native_enryptedKeyWithHash);
      if (array2 == null)
        return num != 0;
      JNIEnv.CopyArray(array2, native_initializationVector);
      return num != 0;
    }

    [Register("setKeyInfo", "([B[B)Z", "GetSetKeyInfo_arrayBarrayBHandler")]
    public virtual unsafe bool SetKeyInfo(byte[]? enryptedKeyWithHash, byte[]? initializationVector)
    {
      IntPtr num1 = JNIEnv.NewArray(enryptedKeyWithHash);
      IntPtr num2 = JNIEnv.NewArray(initializationVector);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        return Crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("setKeyInfo.([B[B)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (enryptedKeyWithHash != null)
        {
          JNIEnv.CopyArray(num1, enryptedKeyWithHash);
          JNIEnv.DeleteLocalRef(num1);
        }
        if (initializationVector != null)
        {
          JNIEnv.CopyArray(num2, initializationVector);
          JNIEnv.DeleteLocalRef(num2);
        }
        GC.KeepAlive((object) enryptedKeyWithHash);
        GC.KeepAlive((object) initializationVector);
      }
    }

    private static Delegate GetSetSharedKeyHandler()
    {
      if ((object) Crypto.cb_setSharedKey == null)
        Crypto.cb_setSharedKey = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Crypto.n_SetSharedKey));
      return Crypto.cb_setSharedKey;
    }

    private static bool n_SetSharedKey(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Crypto>(jnienv, native__this, (JniHandleOwnership) 0).SetSharedKey();
    }

    [Register("setSharedKey", "()Z", "GetSetSharedKeyHandler")]
    public virtual unsafe bool SetSharedKey()
    {
      return Crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("setSharedKey.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("wrapAndUnwrap", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
    public static unsafe string? WrapAndUnwrap(string? keyEncryptionKey, string? Key, string? wrap)
    {
      IntPtr num1 = JNIEnv.NewString(keyEncryptionKey);
      IntPtr num2 = JNIEnv.NewString(Key);
      IntPtr num3 = JNIEnv.NewString(wrap);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3)
        };
        JniObjectReference jniObjectReference = Crypto._members.StaticMethods.InvokeObjectMethod("wrapAndUnwrap.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
      }
    }
  }
}
