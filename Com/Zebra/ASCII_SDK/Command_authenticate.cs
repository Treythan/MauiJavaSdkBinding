// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_authenticate
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
  [Register("com/zebra/ASCII_SDK/Command_authenticate", DoNotGenerateAcw = true)]
  public class Command_authenticate : Command
  {
    [Register("commandName")]
    public const string CommandName = "authenticate";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_authenticate", typeof (Command_authenticate));
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getExcrespLen;
    private static Delegate? cb_setExcrespLen_Z;
    private static Delegate? cb_getIncrespLen;
    private static Delegate? cb_setIncrespLen_Z;
    private static Delegate? cb_getMsgData;
    private static Delegate? cb_setMsgData_Ljava_lang_String_;
    private static Delegate? cb_getMsgLen;
    private static Delegate? cb_setMsgLen_I;
    private static Delegate? cb_getRespLength;
    private static Delegate? cb_setRespLength_I;
    private static Delegate? cb_getSentResp;
    private static Delegate? cb_setSentResp_Z;
    private static Delegate? cb_getStoreResp;
    private static Delegate? cb_setStoreResp_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getcsi;
    private static Delegate? cb_setcsi_S;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_authenticate._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_authenticate._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("ReportConfig")]
    public Param_ReportConfig? ReportConfig
    {
      get
      {
        JniObjectReference objectValue = Command_authenticate._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_authenticate._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Command_authenticate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_authenticate._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_authenticate._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_authenticate._members.ManagedPeerType;

    protected Command_authenticate(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_authenticate()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_authenticate._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_authenticate._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_authenticate.cb_getCommandType == null)
        Command_authenticate.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_authenticate.n_GetCommandType));
      return Command_authenticate.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_authenticate._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_authenticate.cb_getCriteriaIndex == null)
        Command_authenticate.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_authenticate.n_GetCriteriaIndex));
      return Command_authenticate.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_authenticate.cb_setCriteriaIndex_S == null)
        Command_authenticate.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_authenticate.n_SetCriteriaIndex_S));
      return Command_authenticate.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcrespLenHandler()
    {
      if ((object) Command_authenticate.cb_getExcrespLen == null)
        Command_authenticate.cb_getExcrespLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_authenticate.n_GetExcrespLen));
      return Command_authenticate.cb_getExcrespLen;
    }

    private static bool n_GetExcrespLen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).ExcrespLen;
    }

    private static Delegate GetSetExcrespLen_ZHandler()
    {
      if ((object) Command_authenticate.cb_setExcrespLen_Z == null)
        Command_authenticate.cb_setExcrespLen_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_authenticate.n_SetExcrespLen_Z));
      return Command_authenticate.cb_setExcrespLen_Z;
    }

    private static void n_SetExcrespLen_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).ExcrespLen = value;
    }

    public virtual unsafe bool ExcrespLen
    {
      [Register("getExcrespLen", "()Z", "GetGetExcrespLenHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcrespLen.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcrespLen", "(Z)V", "GetSetExcrespLen_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setExcrespLen.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncrespLenHandler()
    {
      if ((object) Command_authenticate.cb_getIncrespLen == null)
        Command_authenticate.cb_getIncrespLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_authenticate.n_GetIncrespLen));
      return Command_authenticate.cb_getIncrespLen;
    }

    private static bool n_GetIncrespLen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).IncrespLen;
    }

    private static Delegate GetSetIncrespLen_ZHandler()
    {
      if ((object) Command_authenticate.cb_setIncrespLen_Z == null)
        Command_authenticate.cb_setIncrespLen_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_authenticate.n_SetIncrespLen_Z));
      return Command_authenticate.cb_setIncrespLen_Z;
    }

    private static void n_SetIncrespLen_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).IncrespLen = value;
    }

    public virtual unsafe bool IncrespLen
    {
      [Register("getIncrespLen", "()Z", "GetGetIncrespLenHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncrespLen.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncrespLen", "(Z)V", "GetSetIncrespLen_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setIncrespLen.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetMsgDataHandler()
    {
      if ((object) Command_authenticate.cb_getMsgData == null)
        Command_authenticate.cb_getMsgData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_authenticate.n_GetMsgData));
      return Command_authenticate.cb_getMsgData;
    }

    private static IntPtr n_GetMsgData(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).MsgData);
    }

    private static Delegate GetSetMsgData_Ljava_lang_String_Handler()
    {
      if ((object) Command_authenticate.cb_setMsgData_Ljava_lang_String_ == null)
        Command_authenticate.cb_setMsgData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_authenticate.n_SetMsgData_Ljava_lang_String_));
      return Command_authenticate.cb_setMsgData_Ljava_lang_String_;
    }

    private static void n_SetMsgData_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).MsgData = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? MsgData
    {
      [Register("getMsgData", "()Ljava/lang/String;", "GetGetMsgDataHandler")] get
      {
        JniObjectReference jniObjectReference = Command_authenticate._members.InstanceMethods.InvokeVirtualObjectMethod("getMsgData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMsgData", "(Ljava/lang/String;)V", "GetSetMsgData_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setMsgData.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetMsgLenHandler()
    {
      if ((object) Command_authenticate.cb_getMsgLen == null)
        Command_authenticate.cb_getMsgLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_authenticate.n_GetMsgLen));
      return Command_authenticate.cb_getMsgLen;
    }

    private static int n_GetMsgLen(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).MsgLen;
    }

    private static Delegate GetSetMsgLen_IHandler()
    {
      if ((object) Command_authenticate.cb_setMsgLen_I == null)
        Command_authenticate.cb_setMsgLen_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_authenticate.n_SetMsgLen_I));
      return Command_authenticate.cb_setMsgLen_I;
    }

    private static void n_SetMsgLen_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).MsgLen = value;
    }

    public virtual unsafe int MsgLen
    {
      [Register("getMsgLen", "()I", "GetGetMsgLenHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualInt32Method("getMsgLen.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setMsgLen", "(I)V", "GetSetMsgLen_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setMsgLen.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetRespLengthHandler()
    {
      if ((object) Command_authenticate.cb_getRespLength == null)
        Command_authenticate.cb_getRespLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_authenticate.n_GetRespLength));
      return Command_authenticate.cb_getRespLength;
    }

    private static int n_GetRespLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).RespLength;
    }

    private static Delegate GetSetRespLength_IHandler()
    {
      if ((object) Command_authenticate.cb_setRespLength_I == null)
        Command_authenticate.cb_setRespLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_authenticate.n_SetRespLength_I));
      return Command_authenticate.cb_setRespLength_I;
    }

    private static void n_SetRespLength_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).RespLength = value;
    }

    public virtual unsafe int RespLength
    {
      [Register("getRespLength", "()I", "GetGetRespLengthHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualInt32Method("getRespLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRespLength", "(I)V", "GetSetRespLength_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setRespLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetSentRespHandler()
    {
      if ((object) Command_authenticate.cb_getSentResp == null)
        Command_authenticate.cb_getSentResp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_authenticate.n_GetSentResp));
      return Command_authenticate.cb_getSentResp;
    }

    private static bool n_GetSentResp(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).SentResp;
    }

    private static Delegate GetSetSentResp_ZHandler()
    {
      if ((object) Command_authenticate.cb_setSentResp_Z == null)
        Command_authenticate.cb_setSentResp_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_authenticate.n_SetSentResp_Z));
      return Command_authenticate.cb_setSentResp_Z;
    }

    private static void n_SetSentResp_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).SentResp = value;
    }

    public virtual unsafe bool SentResp
    {
      [Register("getSentResp", "()Z", "GetGetSentRespHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualBooleanMethod("getSentResp.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setSentResp", "(Z)V", "GetSetSentResp_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setSentResp.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetStoreRespHandler()
    {
      if ((object) Command_authenticate.cb_getStoreResp == null)
        Command_authenticate.cb_getStoreResp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_authenticate.n_GetStoreResp));
      return Command_authenticate.cb_getStoreResp;
    }

    private static bool n_GetStoreResp(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).StoreResp;
    }

    private static Delegate GetSetStoreResp_ZHandler()
    {
      if ((object) Command_authenticate.cb_setStoreResp_Z == null)
        Command_authenticate.cb_setStoreResp_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_authenticate.n_SetStoreResp_Z));
      return Command_authenticate.cb_setStoreResp_Z;
    }

    private static void n_SetStoreResp_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).StoreResp = value;
    }

    public virtual unsafe bool StoreResp
    {
      [Register("getStoreResp", "()Z", "GetGetStoreRespHandler")] get
      {
        return Command_authenticate._members.InstanceMethods.InvokeVirtualBooleanMethod("getStoreResp.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setStoreResp", "(Z)V", "GetSetStoreResp_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setStoreResp.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_authenticate.cb_FromString_Ljava_lang_String_ == null)
        Command_authenticate.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_authenticate.n_FromString_Ljava_lang_String_));
      return Command_authenticate.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public override unsafe void FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_authenticate.cb_ToString == null)
        Command_authenticate.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_authenticate.n_ToString));
      return Command_authenticate.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_authenticate._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetcsiHandler()
    {
      if ((object) Command_authenticate.cb_getcsi == null)
        Command_authenticate.cb_getcsi = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_authenticate.n_Getcsi));
      return Command_authenticate.cb_getcsi;
    }

    private static short n_Getcsi(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).Getcsi();
    }

    [Register("getcsi", "()S", "GetGetcsiHandler")]
    public virtual unsafe short Getcsi()
    {
      return Command_authenticate._members.InstanceMethods.InvokeVirtualInt16Method("getcsi.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetcsi_SHandler()
    {
      if ((object) Command_authenticate.cb_setcsi_S == null)
        Command_authenticate.cb_setcsi_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_authenticate.n_Setcsi_S));
      return Command_authenticate.cb_setcsi_S;
    }

    private static void n_Setcsi_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_authenticate>(jnienv, native__this, (JniHandleOwnership) 0).Setcsi(value);
    }

    [Register("setcsi", "(S)V", "GetSetcsi_SHandler")]
    public virtual unsafe void Setcsi(short value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_authenticate._members.InstanceMethods.InvokeVirtualVoidMethod("setcsi.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
