// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.MEMORY_BANK
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
  [Register("com/zebra/rfid/api3/MEMORY_BANK", DoNotGenerateAcw = true)]
  public class MEMORY_BANK : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MEMORY_BANK", typeof (MEMORY_BANK));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("MEMORY_BANK_ALL")]
    public static MEMORY_BANK? MemoryBankAll
    {
      get
      {
        JniObjectReference objectValue = MEMORY_BANK._members.StaticFields.GetObjectValue("MEMORY_BANK_ALL.Lcom/zebra/rfid/api3/MEMORY_BANK;");
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEMORY_BANK_EPC")]
    public static MEMORY_BANK? MemoryBankEpc
    {
      get
      {
        JniObjectReference objectValue = MEMORY_BANK._members.StaticFields.GetObjectValue("MEMORY_BANK_EPC.Lcom/zebra/rfid/api3/MEMORY_BANK;");
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEMORY_BANK_RESERVED")]
    public static MEMORY_BANK? MemoryBankReserved
    {
      get
      {
        JniObjectReference objectValue = MEMORY_BANK._members.StaticFields.GetObjectValue("MEMORY_BANK_RESERVED.Lcom/zebra/rfid/api3/MEMORY_BANK;");
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEMORY_BANK_TID")]
    public static MEMORY_BANK? MemoryBankTid
    {
      get
      {
        JniObjectReference objectValue = MEMORY_BANK._members.StaticFields.GetObjectValue("MEMORY_BANK_TID.Lcom/zebra/rfid/api3/MEMORY_BANK;");
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEMORY_BANK_USER")]
    public static MEMORY_BANK? MemoryBankUser
    {
      get
      {
        JniObjectReference objectValue = MEMORY_BANK._members.StaticFields.GetObjectValue("MEMORY_BANK_USER.Lcom/zebra/rfid/api3/MEMORY_BANK;");
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => MEMORY_BANK._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => MEMORY_BANK._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MEMORY_BANK._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MEMORY_BANK._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MEMORY_BANK._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MEMORY_BANK._members.ManagedPeerType;

    protected MEMORY_BANK(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) MEMORY_BANK.cb_getValue == null)
        MEMORY_BANK.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MEMORY_BANK.n_GetValue));
      return MEMORY_BANK.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MEMORY_BANK>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return MEMORY_BANK._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetMemoryBankValue", "(I)Lcom/zebra/rfid/api3/MEMORY_BANK;", "")]
    public static unsafe MEMORY_BANK? GetMemoryBankValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = MEMORY_BANK._members.StaticMethods.InvokeObjectMethod("GetMemoryBankValue.(I)Lcom/zebra/rfid/api3/MEMORY_BANK;", jniArgumentValuePtr);
      return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetMemoryBankValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/MEMORY_BANK;", "")]
    public static unsafe MEMORY_BANK? GetMemoryBankValue(string? memoryBank)
    {
      IntPtr num = JNIEnv.NewString(memoryBank);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = MEMORY_BANK._members.StaticMethods.InvokeObjectMethod("GetMemoryBankValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/MEMORY_BANK;", jniArgumentValuePtr);
        return Object.GetObject<MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) MEMORY_BANK.cb_equals_I == null)
        MEMORY_BANK.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(MEMORY_BANK.n_Equals_I));
      return MEMORY_BANK.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<MEMORY_BANK>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return MEMORY_BANK._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
