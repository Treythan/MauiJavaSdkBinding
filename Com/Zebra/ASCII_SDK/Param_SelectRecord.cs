// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_SelectRecord
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
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/Param_SelectRecord", DoNotGenerateAcw = true)]
  public class Param_SelectRecord : Object
  {
    [Register("commandName")]
    public const string CommandName = "SelectRecord";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_SelectRecord", typeof (Param_SelectRecord));
    private static Delegate? cb_getAction;
    private static Delegate? cb_setAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_;
    private static Delegate? cb_getDoTruncate;
    private static Delegate? cb_setDoTruncate_Z;
    private static Delegate? cb_getMaskBank;
    private static Delegate? cb_setMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    private static Delegate? cb_getMaskStartPos;
    private static Delegate? cb_setMaskStartPos_S;
    private static Delegate? cb_getMatchLength;
    private static Delegate? cb_setMatchLength_S;
    private static Delegate? cb_getNoTruncate;
    private static Delegate? cb_setNoTruncate_Z;
    private static Delegate? cb_getTarget;
    private static Delegate? cb_setTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getMatchPattern;
    private static Delegate? cb_setMatchPattern_arrayB;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_SelectRecord._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_SelectRecord._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_SelectRecord._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_SelectRecord._members.ManagedPeerType;

    protected Param_SelectRecord(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_SelectRecord()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_SelectRecord._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_SelectRecord._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetActionHandler()
    {
      if ((object) Param_SelectRecord.cb_getAction == null)
        Param_SelectRecord.cb_getAction = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_SelectRecord.n_GetAction));
      return Param_SelectRecord.cb_getAction;
    }

    private static IntPtr n_GetAction(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).Action);
    }

    private static Delegate GetSetAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_Handler()
    {
      if ((object) Param_SelectRecord.cb_setAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_ == null)
        Param_SelectRecord.cb_setAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_SelectRecord.n_SetAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_));
      return Param_SelectRecord.cb_setAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_;
    }

    private static void n_SetAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).Action = Object.GetObject<ENUM_ACTION>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_ACTION? Action
    {
      [Register("getAction", "()Lcom/zebra/ASCII_SDK/ENUM_ACTION;", "GetGetActionHandler")] get
      {
        JniObjectReference jniObjectReference = Param_SelectRecord._members.InstanceMethods.InvokeVirtualObjectMethod("getAction.()Lcom/zebra/ASCII_SDK/ENUM_ACTION;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAction", "(Lcom/zebra/ASCII_SDK/ENUM_ACTION;)V", "GetSetAction_Lcom_zebra_ASCII_SDK_ENUM_ACTION_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setAction.(Lcom/zebra/ASCII_SDK/ENUM_ACTION;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetDoTruncateHandler()
    {
      if ((object) Param_SelectRecord.cb_getDoTruncate == null)
        Param_SelectRecord.cb_getDoTruncate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_SelectRecord.n_GetDoTruncate));
      return Param_SelectRecord.cb_getDoTruncate;
    }

    private static bool n_GetDoTruncate(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).DoTruncate;
    }

    private static Delegate GetSetDoTruncate_ZHandler()
    {
      if ((object) Param_SelectRecord.cb_setDoTruncate_Z == null)
        Param_SelectRecord.cb_setDoTruncate_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_SelectRecord.n_SetDoTruncate_Z));
      return Param_SelectRecord.cb_setDoTruncate_Z;
    }

    private static void n_SetDoTruncate_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).DoTruncate = value;
    }

    public virtual unsafe bool DoTruncate
    {
      [Register("getDoTruncate", "()Z", "GetGetDoTruncateHandler")] get
      {
        return Param_SelectRecord._members.InstanceMethods.InvokeVirtualBooleanMethod("getDoTruncate.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDoTruncate", "(Z)V", "GetSetDoTruncate_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setDoTruncate.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMaskBankHandler()
    {
      if ((object) Param_SelectRecord.cb_getMaskBank == null)
        Param_SelectRecord.cb_getMaskBank = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_SelectRecord.n_GetMaskBank));
      return Param_SelectRecord.cb_getMaskBank;
    }

    private static IntPtr n_GetMaskBank(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MaskBank);
    }

    private static Delegate GetSetMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler()
    {
      if ((object) Param_SelectRecord.cb_setMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ == null)
        Param_SelectRecord.cb_setMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_SelectRecord.n_SetMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_));
      return Param_SelectRecord.cb_setMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_;
    }

    private static void n_SetMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MaskBank = Object.GetObject<ENUM_MEMORY_BANK>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_MEMORY_BANK? MaskBank
    {
      [Register("getMaskBank", "()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", "GetGetMaskBankHandler")] get
      {
        JniObjectReference jniObjectReference = Param_SelectRecord._members.InstanceMethods.InvokeVirtualObjectMethod("getMaskBank.()Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_MEMORY_BANK>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMaskBank", "(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", "GetSetMaskBank_Lcom_zebra_ASCII_SDK_ENUM_MEMORY_BANK_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setMaskBank.(Lcom/zebra/ASCII_SDK/ENUM_MEMORY_BANK;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetMaskStartPosHandler()
    {
      if ((object) Param_SelectRecord.cb_getMaskStartPos == null)
        Param_SelectRecord.cb_getMaskStartPos = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_SelectRecord.n_GetMaskStartPos));
      return Param_SelectRecord.cb_getMaskStartPos;
    }

    private static short n_GetMaskStartPos(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MaskStartPos;
    }

    private static Delegate GetSetMaskStartPos_SHandler()
    {
      if ((object) Param_SelectRecord.cb_setMaskStartPos_S == null)
        Param_SelectRecord.cb_setMaskStartPos_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_SelectRecord.n_SetMaskStartPos_S));
      return Param_SelectRecord.cb_setMaskStartPos_S;
    }

    private static void n_SetMaskStartPos_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MaskStartPos = value;
    }

    public virtual unsafe short MaskStartPos
    {
      [Register("getMaskStartPos", "()S", "GetGetMaskStartPosHandler")] get
      {
        return Param_SelectRecord._members.InstanceMethods.InvokeVirtualInt16Method("getMaskStartPos.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMaskStartPos", "(S)V", "GetSetMaskStartPos_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setMaskStartPos.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMatchLengthHandler()
    {
      if ((object) Param_SelectRecord.cb_getMatchLength == null)
        Param_SelectRecord.cb_getMatchLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Param_SelectRecord.n_GetMatchLength));
      return Param_SelectRecord.cb_getMatchLength;
    }

    private static short n_GetMatchLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MatchLength;
    }

    private static Delegate GetSetMatchLength_SHandler()
    {
      if ((object) Param_SelectRecord.cb_setMatchLength_S == null)
        Param_SelectRecord.cb_setMatchLength_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Param_SelectRecord.n_SetMatchLength_S));
      return Param_SelectRecord.cb_setMatchLength_S;
    }

    private static void n_SetMatchLength_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).MatchLength = value;
    }

    public virtual unsafe short MatchLength
    {
      [Register("getMatchLength", "()S", "GetGetMatchLengthHandler")] get
      {
        return Param_SelectRecord._members.InstanceMethods.InvokeVirtualInt16Method("getMatchLength.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMatchLength", "(S)V", "GetSetMatchLength_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setMatchLength.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetNoTruncateHandler()
    {
      if ((object) Param_SelectRecord.cb_getNoTruncate == null)
        Param_SelectRecord.cb_getNoTruncate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_SelectRecord.n_GetNoTruncate));
      return Param_SelectRecord.cb_getNoTruncate;
    }

    private static bool n_GetNoTruncate(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).NoTruncate;
    }

    private static Delegate GetSetNoTruncate_ZHandler()
    {
      if ((object) Param_SelectRecord.cb_setNoTruncate_Z == null)
        Param_SelectRecord.cb_setNoTruncate_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_SelectRecord.n_SetNoTruncate_Z));
      return Param_SelectRecord.cb_setNoTruncate_Z;
    }

    private static void n_SetNoTruncate_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).NoTruncate = value;
    }

    public virtual unsafe bool NoTruncate
    {
      [Register("getNoTruncate", "()Z", "GetGetNoTruncateHandler")] get
      {
        return Param_SelectRecord._members.InstanceMethods.InvokeVirtualBooleanMethod("getNoTruncate.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setNoTruncate", "(Z)V", "GetSetNoTruncate_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setNoTruncate.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTargetHandler()
    {
      if ((object) Param_SelectRecord.cb_getTarget == null)
        Param_SelectRecord.cb_getTarget = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_SelectRecord.n_GetTarget));
      return Param_SelectRecord.cb_getTarget;
    }

    private static IntPtr n_GetTarget(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).Target);
    }

    private static Delegate GetSetTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_Handler()
    {
      if ((object) Param_SelectRecord.cb_setTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_ == null)
        Param_SelectRecord.cb_setTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_SelectRecord.n_SetTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_));
      return Param_SelectRecord.cb_setTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_;
    }

    private static void n_SetTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).Target = Object.GetObject<ENUM_TARGET>(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe ENUM_TARGET? Target
    {
      [Register("getTarget", "()Lcom/zebra/ASCII_SDK/ENUM_TARGET;", "GetGetTargetHandler")] get
      {
        JniObjectReference jniObjectReference = Param_SelectRecord._members.InstanceMethods.InvokeVirtualObjectMethod("getTarget.()Lcom/zebra/ASCII_SDK/ENUM_TARGET;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ENUM_TARGET>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setTarget", "(Lcom/zebra/ASCII_SDK/ENUM_TARGET;)V", "GetSetTarget_Lcom_zebra_ASCII_SDK_ENUM_TARGET_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : ((Object) value).Handle)
          };
          Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setTarget.(Lcom/zebra/ASCII_SDK/ENUM_TARGET;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_SelectRecord.cb_FromString_Ljava_lang_String_ == null)
        Param_SelectRecord.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_SelectRecord.n_FromString_Ljava_lang_String_));
      return Param_SelectRecord.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public virtual unsafe void FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_SelectRecord.cb_ToString == null)
        Param_SelectRecord.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_SelectRecord.n_ToString));
      return Param_SelectRecord.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_SelectRecord._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetMatchPatternHandler()
    {
      if ((object) Param_SelectRecord.cb_getMatchPattern == null)
        Param_SelectRecord.cb_getMatchPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_SelectRecord.n_GetMatchPattern));
      return Param_SelectRecord.cb_getMatchPattern;
    }

    private static IntPtr n_GetMatchPattern(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray(Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0).GetMatchPattern());
    }

    [Register("getMatchPattern", "()[B", "GetGetMatchPatternHandler")]
    public virtual unsafe byte[]? GetMatchPattern()
    {
      JniObjectReference jniObjectReference = Param_SelectRecord._members.InstanceMethods.InvokeVirtualObjectMethod("getMatchPattern.()[B", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (byte[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (byte));
    }

    private static Delegate GetSetMatchPattern_arrayBHandler()
    {
      if ((object) Param_SelectRecord.cb_setMatchPattern_arrayB == null)
        Param_SelectRecord.cb_setMatchPattern_arrayB = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_SelectRecord.n_SetMatchPattern_arrayB));
      return Param_SelectRecord.cb_setMatchPattern_arrayB;
    }

    private static void n_SetMatchPattern_arrayB(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Param_SelectRecord paramSelectRecord = Object.GetObject<Param_SelectRecord>(jnienv, native__this, (JniHandleOwnership) 0);
      byte[] array = (byte[]) JNIEnv.GetArray(native_value, (JniHandleOwnership) 0, typeof (byte));
      byte[] numArray = array;
      paramSelectRecord.SetMatchPattern(numArray);
      if (array == null)
        return;
      JNIEnv.CopyArray(array, native_value);
    }

    [Register("setMatchPattern", "([B)V", "GetSetMatchPattern_arrayBHandler")]
    public virtual unsafe void SetMatchPattern(byte[]? value)
    {
      IntPtr num = JNIEnv.NewArray(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_SelectRecord._members.InstanceMethods.InvokeVirtualVoidMethod("setMatchPattern.([B)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        if (value != null)
        {
          JNIEnv.CopyArray(num, value);
          JNIEnv.DeleteLocalRef(num);
        }
        GC.KeepAlive((object) value);
      }
    }
  }
}
