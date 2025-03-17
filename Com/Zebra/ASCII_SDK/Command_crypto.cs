// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Command_crypto
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
  [Register("com/zebra/ASCII_SDK/Command_crypto", DoNotGenerateAcw = true)]
  public class Command_crypto : Command
  {
    [Register("commandName")]
    public const string CommandName = "crypto";
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Command_crypto", typeof (Command_crypto));
    private static Delegate? cb_getChallenge;
    private static Delegate? cb_setChallenge_Ljava_lang_String_;
    private static Delegate? cb_getCommandType;
    private static Delegate? cb_getCriteriaIndex;
    private static Delegate? cb_setCriteriaIndex_S;
    private static Delegate? cb_getExcCustom;
    private static Delegate? cb_setExcCustom_Z;
    private static Delegate? cb_getIncCustom;
    private static Delegate? cb_setIncCustom_Z;
    private static Delegate? cb_getKeyId;
    private static Delegate? cb_setKeyId_I;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;
    private static Delegate? cb_getPassword;
    private static Delegate? cb_setPassword_J;
    private static Delegate? cb_getProfile;
    private static Delegate? cb_setProfile_I;
    private static Delegate? cb_getProtMode;
    private static Delegate? cb_setProtMode_I;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;
    private static Delegate? cb_getbc;
    private static Delegate? cb_setbc_I;

    [Register("AccessConfig")]
    public Param_AccessConfig? AccessConfig
    {
      get
      {
        JniObjectReference objectValue = Command_crypto._members.InstanceFields.GetObjectValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_AccessConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_crypto._members.InstanceFields.SetValue("AccessConfig.Lcom/zebra/ASCII_SDK/Param_AccessConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference objectValue = Command_crypto._members.InstanceFields.GetObjectValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this);
        return Object.GetObject<Param_ReportConfig>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Command_crypto._members.InstanceFields.SetValue("ReportConfig.Lcom/zebra/ASCII_SDK/Param_ReportConfig;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = Command_crypto._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Command_crypto._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Command_crypto._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => Command_crypto._members.ManagedPeerType;

    protected Command_crypto(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Command_crypto()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Command_crypto._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Command_crypto._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetChallengeHandler()
    {
      if ((object) Command_crypto.cb_getChallenge == null)
        Command_crypto.cb_getChallenge = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_crypto.n_GetChallenge));
      return Command_crypto.cb_getChallenge;
    }

    private static IntPtr n_GetChallenge(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Challenge);
    }

    private static Delegate GetSetChallenge_Ljava_lang_String_Handler()
    {
      if ((object) Command_crypto.cb_setChallenge_Ljava_lang_String_ == null)
        Command_crypto.cb_setChallenge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_crypto.n_SetChallenge_Ljava_lang_String_));
      return Command_crypto.cb_setChallenge_Ljava_lang_String_;
    }

    private static void n_SetChallenge_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Challenge = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Challenge
    {
      [Register("getChallenge", "()Ljava/lang/String;", "GetGetChallengeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getChallenge.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setChallenge", "(Ljava/lang/String;)V", "GetSetChallenge_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setChallenge.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetCommandTypeHandler()
    {
      if ((object) Command_crypto.cb_getCommandType == null)
        Command_crypto.cb_getCommandType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_crypto.n_GetCommandType));
      return Command_crypto.cb_getCommandType;
    }

    private static IntPtr n_GetCommandType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).CommandType);
    }

    public override unsafe COMMAND_TYPE? CommandType
    {
      [Register("getCommandType", "()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "GetGetCommandTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Command_crypto._members.InstanceMethods.InvokeVirtualObjectMethod("getCommandType.()Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetCriteriaIndexHandler()
    {
      if ((object) Command_crypto.cb_getCriteriaIndex == null)
        Command_crypto.cb_getCriteriaIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Command_crypto.n_GetCriteriaIndex));
      return Command_crypto.cb_getCriteriaIndex;
    }

    private static short n_GetCriteriaIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex;
    }

    private static Delegate GetSetCriteriaIndex_SHandler()
    {
      if ((object) Command_crypto.cb_setCriteriaIndex_S == null)
        Command_crypto.cb_setCriteriaIndex_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Command_crypto.n_SetCriteriaIndex_S));
      return Command_crypto.cb_setCriteriaIndex_S;
    }

    private static void n_SetCriteriaIndex_S(IntPtr jnienv, IntPtr native__this, short value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).CriteriaIndex = value;
    }

    public virtual unsafe short CriteriaIndex
    {
      [Register("getCriteriaIndex", "()S", "GetGetCriteriaIndexHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt16Method("getCriteriaIndex.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setCriteriaIndex", "(S)V", "GetSetCriteriaIndex_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setCriteriaIndex.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcCustomHandler()
    {
      if ((object) Command_crypto.cb_getExcCustom == null)
        Command_crypto.cb_getExcCustom = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_crypto.n_GetExcCustom));
      return Command_crypto.cb_getExcCustom;
    }

    private static bool n_GetExcCustom(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).ExcCustom;
    }

    private static Delegate GetSetExcCustom_ZHandler()
    {
      if ((object) Command_crypto.cb_setExcCustom_Z == null)
        Command_crypto.cb_setExcCustom_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_crypto.n_SetExcCustom_Z));
      return Command_crypto.cb_setExcCustom_Z;
    }

    private static void n_SetExcCustom_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).ExcCustom = value;
    }

    public virtual unsafe bool ExcCustom
    {
      [Register("getExcCustom", "()Z", "GetGetExcCustomHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcCustom.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcCustom", "(Z)V", "GetSetExcCustom_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setExcCustom.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncCustomHandler()
    {
      if ((object) Command_crypto.cb_getIncCustom == null)
        Command_crypto.cb_getIncCustom = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Command_crypto.n_GetIncCustom));
      return Command_crypto.cb_getIncCustom;
    }

    private static bool n_GetIncCustom(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).IncCustom;
    }

    private static Delegate GetSetIncCustom_ZHandler()
    {
      if ((object) Command_crypto.cb_setIncCustom_Z == null)
        Command_crypto.cb_setIncCustom_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Command_crypto.n_SetIncCustom_Z));
      return Command_crypto.cb_setIncCustom_Z;
    }

    private static void n_SetIncCustom_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).IncCustom = value;
    }

    public virtual unsafe bool IncCustom
    {
      [Register("getIncCustom", "()Z", "GetGetIncCustomHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncCustom.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncCustom", "(Z)V", "GetSetIncCustom_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setIncCustom.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetKeyIdHandler()
    {
      if ((object) Command_crypto.cb_getKeyId == null)
        Command_crypto.cb_getKeyId = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_crypto.n_GetKeyId));
      return Command_crypto.cb_getKeyId;
    }

    private static int n_GetKeyId(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).KeyId;
    }

    private static Delegate GetSetKeyId_IHandler()
    {
      if ((object) Command_crypto.cb_setKeyId_I == null)
        Command_crypto.cb_setKeyId_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_crypto.n_SetKeyId_I));
      return Command_crypto.cb_setKeyId_I;
    }

    private static void n_SetKeyId_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).KeyId = value;
    }

    public virtual unsafe int KeyId
    {
      [Register("getKeyId", "()I", "GetGetKeyIdHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt32Method("getKeyId.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setKeyId", "(I)V", "GetSetKeyId_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setKeyId.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) Command_crypto.cb_getOffset == null)
        Command_crypto.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_crypto.n_GetOffset));
      return Command_crypto.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) Command_crypto.cb_setOffset_I == null)
        Command_crypto.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_crypto.n_SetOffset_I));
      return Command_crypto.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Offset = value;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPasswordHandler()
    {
      if ((object) Command_crypto.cb_getPassword == null)
        Command_crypto.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Command_crypto.n_GetPassword));
      return Command_crypto.cb_getPassword;
    }

    private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Password;
    }

    private static Delegate GetSetPassword_JHandler()
    {
      if ((object) Command_crypto.cb_setPassword_J == null)
        Command_crypto.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Command_crypto.n_SetPassword_J));
      return Command_crypto.cb_setPassword_J;
    }

    private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Password = value;
    }

    public virtual unsafe long Password
    {
      [Register("getPassword", "()J", "GetGetPasswordHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetProfileHandler()
    {
      if ((object) Command_crypto.cb_getProfile == null)
        Command_crypto.cb_getProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_crypto.n_GetProfile));
      return Command_crypto.cb_getProfile;
    }

    private static int n_GetProfile(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Profile;
    }

    private static Delegate GetSetProfile_IHandler()
    {
      if ((object) Command_crypto.cb_setProfile_I == null)
        Command_crypto.cb_setProfile_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_crypto.n_SetProfile_I));
      return Command_crypto.cb_setProfile_I;
    }

    private static void n_SetProfile_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Profile = value;
    }

    public virtual unsafe int Profile
    {
      [Register("getProfile", "()I", "GetGetProfileHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt32Method("getProfile.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setProfile", "(I)V", "GetSetProfile_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setProfile.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetProtModeHandler()
    {
      if ((object) Command_crypto.cb_getProtMode == null)
        Command_crypto.cb_getProtMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_crypto.n_GetProtMode));
      return Command_crypto.cb_getProtMode;
    }

    private static int n_GetProtMode(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).ProtMode;
    }

    private static Delegate GetSetProtMode_IHandler()
    {
      if ((object) Command_crypto.cb_setProtMode_I == null)
        Command_crypto.cb_setProtMode_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_crypto.n_SetProtMode_I));
      return Command_crypto.cb_setProtMode_I;
    }

    private static void n_SetProtMode_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).ProtMode = value;
    }

    public virtual unsafe int ProtMode
    {
      [Register("getProtMode", "()I", "GetGetProtModeHandler")] get
      {
        return Command_crypto._members.InstanceMethods.InvokeVirtualInt32Method("getProtMode.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setProtMode", "(I)V", "GetSetProtMode_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setProtMode.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Command_crypto.cb_FromString_Ljava_lang_String_ == null)
        Command_crypto.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Command_crypto.n_FromString_Ljava_lang_String_));
      return Command_crypto.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
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
        Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Command_crypto.cb_ToString == null)
        Command_crypto.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Command_crypto.n_ToString));
      return Command_crypto.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public override unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Command_crypto._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetGetbcHandler()
    {
      if ((object) Command_crypto.cb_getbc == null)
        Command_crypto.cb_getbc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Command_crypto.n_Getbc));
      return Command_crypto.cb_getbc;
    }

    private static int n_Getbc(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Getbc();
    }

    [Register("getbc", "()I", "GetGetbcHandler")]
    public virtual unsafe int Getbc()
    {
      return Command_crypto._members.InstanceMethods.InvokeVirtualInt32Method("getbc.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetbc_IHandler()
    {
      if ((object) Command_crypto.cb_setbc_I == null)
        Command_crypto.cb_setbc_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Command_crypto.n_Setbc_I));
      return Command_crypto.cb_setbc_I;
    }

    private static void n_Setbc_I(IntPtr jnienv, IntPtr native__this, int value)
    {
      Object.GetObject<Command_crypto>(jnienv, native__this, (JniHandleOwnership) 0).Setbc(value);
    }

    [Register("setbc", "(I)V", "GetSetbc_IHandler")]
    public virtual unsafe void Setbc(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      Command_crypto._members.InstanceMethods.InvokeVirtualVoidMethod("setbc.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
