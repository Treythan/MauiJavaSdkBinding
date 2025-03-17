// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Gen2v2
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
  [Register("com/zebra/rfid/api3/Gen2v2", DoNotGenerateAcw = true)]
  public class Gen2v2 : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2", typeof (Gen2v2));
    private static Delegate? cb_authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_readBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    private static Delegate? cb_untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Gen2v2._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Gen2v2._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Gen2v2._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Gen2v2._members.ManagedPeerType;

    protected Gen2v2(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Gen2v2()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Gen2v2._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Gen2v2._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetAuthenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) Gen2v2.cb_authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        Gen2v2.cb_authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(Gen2v2.n_Authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return Gen2v2.cb_authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_Authenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_authenticateParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      Gen2v2 gen2v2 = Object.GetObject<Gen2v2>(jnienv, native__this, (JniHandleOwnership) 0);
      Gen2v2.AuthenticateParams authenticateParams1 = Object.GetObject<Gen2v2.AuthenticateParams>(native_authenticateParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      Gen2v2.AuthenticateParams authenticateParams2 = authenticateParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      gen2v2.Authenticate(authenticateParams2, accessFilter2, antennaInfo2);
    }

    [Register("authenticate", "(Lcom/zebra/rfid/api3/Gen2v2$AuthenticateParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetAuthenticate_Lcom_zebra_rfid_api3_Gen2v2_AuthenticateParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void Authenticate(
      Gen2v2.AuthenticateParams? authenticateParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(authenticateParams == null ? IntPtr.Zero : authenticateParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        Gen2v2._members.InstanceMethods.InvokeVirtualVoidMethod("authenticate.(Lcom/zebra/rfid/api3/Gen2v2$AuthenticateParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) authenticateParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetCrypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) Gen2v2.cb_crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        Gen2v2.cb_crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(Gen2v2.n_Crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return Gen2v2.cb_crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_Crypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cryptoParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      Gen2v2 gen2v2 = Object.GetObject<Gen2v2>(jnienv, native__this, (JniHandleOwnership) 0);
      Gen2v2.CryptoParams cryptoParams1 = Object.GetObject<Gen2v2.CryptoParams>(native_cryptoParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      Gen2v2.CryptoParams cryptoParams2 = cryptoParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      gen2v2.Crypto(cryptoParams2, accessFilter2, antennaInfo2);
    }

    [Register("crypto", "(Lcom/zebra/rfid/api3/Gen2v2$CryptoParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetCrypto_Lcom_zebra_rfid_api3_Gen2v2_CryptoParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void Crypto(
      Gen2v2.CryptoParams? cryptoParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(cryptoParams == null ? IntPtr.Zero : cryptoParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        Gen2v2._members.InstanceMethods.InvokeVirtualVoidMethod("crypto.(Lcom/zebra/rfid/api3/Gen2v2$CryptoParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) cryptoParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetReadBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) Gen2v2.cb_readBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        Gen2v2.cb_readBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(Gen2v2.n_ReadBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return Gen2v2.cb_readBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_ReadBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_readBufferParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      Gen2v2 gen2v2 = Object.GetObject<Gen2v2>(jnienv, native__this, (JniHandleOwnership) 0);
      Gen2v2.ReadBufferParams readBufferParams1 = Object.GetObject<Gen2v2.ReadBufferParams>(native_readBufferParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      Gen2v2.ReadBufferParams readBufferParams2 = readBufferParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      gen2v2.ReadBuffer(readBufferParams2, accessFilter2, antennaInfo2);
    }

    [Register("readBuffer", "(Lcom/zebra/rfid/api3/Gen2v2$ReadBufferParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetReadBuffer_Lcom_zebra_rfid_api3_Gen2v2_ReadBufferParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void ReadBuffer(
      Gen2v2.ReadBufferParams? readBufferParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(readBufferParams == null ? IntPtr.Zero : readBufferParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        Gen2v2._members.InstanceMethods.InvokeVirtualVoidMethod("readBuffer.(Lcom/zebra/rfid/api3/Gen2v2$ReadBufferParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) readBufferParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    private static Delegate GetUntraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler()
    {
      if ((object) Gen2v2.cb_untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ == null)
        Gen2v2.cb_untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(Gen2v2.n_Untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_));
      return Gen2v2.cb_untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_;
    }

    private static void n_Untraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_untraceableParams,
      IntPtr native_accessFilter,
      IntPtr native_antennaInfo)
    {
      Gen2v2 gen2v2 = Object.GetObject<Gen2v2>(jnienv, native__this, (JniHandleOwnership) 0);
      Gen2v2.UntraceableParams untraceableParams1 = Object.GetObject<Gen2v2.UntraceableParams>(native_untraceableParams, (JniHandleOwnership) 0);
      AccessFilter accessFilter1 = Object.GetObject<AccessFilter>(native_accessFilter, (JniHandleOwnership) 0);
      AntennaInfo antennaInfo1 = Object.GetObject<AntennaInfo>(native_antennaInfo, (JniHandleOwnership) 0);
      Gen2v2.UntraceableParams untraceableParams2 = untraceableParams1;
      AccessFilter accessFilter2 = accessFilter1;
      AntennaInfo antennaInfo2 = antennaInfo1;
      gen2v2.Untraceable(untraceableParams2, accessFilter2, antennaInfo2);
    }

    [Register("untraceable", "(Lcom/zebra/rfid/api3/Gen2v2$UntraceableParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", "GetUntraceable_Lcom_zebra_rfid_api3_Gen2v2_UntraceableParams_Lcom_zebra_rfid_api3_AccessFilter_Lcom_zebra_rfid_api3_AntennaInfo_Handler")]
    public virtual unsafe void Untraceable(
      Gen2v2.UntraceableParams? untraceableParams,
      AccessFilter? accessFilter,
      AntennaInfo? antennaInfo)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(untraceableParams == null ? IntPtr.Zero : untraceableParams.Handle),
          new JniArgumentValue(accessFilter == null ? IntPtr.Zero : accessFilter.Handle),
          new JniArgumentValue(antennaInfo == null ? IntPtr.Zero : antennaInfo.Handle)
        };
        Gen2v2._members.InstanceMethods.InvokeVirtualVoidMethod("untraceable.(Lcom/zebra/rfid/api3/Gen2v2$UntraceableParams;Lcom/zebra/rfid/api3/AccessFilter;Lcom/zebra/rfid/api3/AntennaInfo;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) untraceableParams);
        GC.KeepAlive((object) accessFilter);
        GC.KeepAlive((object) antennaInfo);
      }
    }

    [Register("com/zebra/rfid/api3/Gen2v2$AuthenticateParams", DoNotGenerateAcw = true)]
    public class AuthenticateParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2$AuthenticateParams", typeof (Gen2v2.AuthenticateParams));
      private static Delegate? cb_getCS;
      private static Delegate? cb_setCS_S;
      private static Delegate? cb_getExcrespLen;
      private static Delegate? cb_setExcrespLen_Z;
      private static Delegate? cb_getIncrespLen;
      private static Delegate? cb_setIncrespLen_Z;
      private static Delegate? cb_getMsgData;
      private static Delegate? cb_setMsgData_Ljava_lang_String_;
      private static Delegate? cb_getMsgLen;
      private static Delegate? cb_setMsgLen_I;
      private static Delegate? cb_getRespLen;
      private static Delegate? cb_setRespLen_I;
      private static Delegate? cb_getSentResp;
      private static Delegate? cb_setSentResp_Z;
      private static Delegate? cb_getStoreResp;
      private static Delegate? cb_setStoreResp_Z;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.AuthenticateParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Gen2v2.AuthenticateParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.AuthenticateParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Gen2v2.AuthenticateParams._members.ManagedPeerType;

      protected AuthenticateParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;)V", "")]
      public unsafe AuthenticateParams(Gen2v2? __self)
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
          JniObjectReference instance = Gen2v2.AuthenticateParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.AuthenticateParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;Ljava/lang/String;I)V", "")]
      public unsafe AuthenticateParams(Gen2v2? __self, string? m_sMsgData, int m_nMsgLen)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Ljava/lang/String;I)V";
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewString(m_sMsgData);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(num),
            new JniArgumentValue(m_nMsgLen)
          };
          JniObjectReference instance = Gen2v2.AuthenticateParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.AuthenticateParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetCSHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getCS == null)
          Gen2v2.AuthenticateParams.cb_getCS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(Gen2v2.AuthenticateParams.n_GetCS));
        return Gen2v2.AuthenticateParams.cb_getCS;
      }

      private static short n_GetCS(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).CS;
      }

      private static Delegate GetSetCS_SHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setCS_S == null)
          Gen2v2.AuthenticateParams.cb_setCS_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(Gen2v2.AuthenticateParams.n_SetCS_S));
        return Gen2v2.AuthenticateParams.cb_setCS_S;
      }

      private static void n_SetCS_S(IntPtr jnienv, IntPtr native__this, short m_nCS)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).CS = m_nCS;
      }

      public virtual unsafe short CS
      {
        [Register("getCS", "()S", "GetGetCSHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualInt16Method("getCS.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setCS", "(S)V", "GetSetCS_SHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setCS.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetExcrespLenHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getExcrespLen == null)
          Gen2v2.AuthenticateParams.cb_getExcrespLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.AuthenticateParams.n_GetExcrespLen));
        return Gen2v2.AuthenticateParams.cb_getExcrespLen;
      }

      private static bool n_GetExcrespLen(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).ExcrespLen;
      }

      private static Delegate GetSetExcrespLen_ZHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setExcrespLen_Z == null)
          Gen2v2.AuthenticateParams.cb_setExcrespLen_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.AuthenticateParams.n_SetExcrespLen_Z));
        return Gen2v2.AuthenticateParams.cb_setExcrespLen_Z;
      }

      private static void n_SetExcrespLen_Z(IntPtr jnienv, IntPtr native__this, bool m_bExcrespLen)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).ExcrespLen = m_bExcrespLen;
      }

      public virtual unsafe bool ExcrespLen
      {
        [Register("getExcrespLen", "()Z", "GetGetExcrespLenHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcrespLen.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setExcrespLen", "(Z)V", "GetSetExcrespLen_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setExcrespLen.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetIncrespLenHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getIncrespLen == null)
          Gen2v2.AuthenticateParams.cb_getIncrespLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.AuthenticateParams.n_GetIncrespLen));
        return Gen2v2.AuthenticateParams.cb_getIncrespLen;
      }

      private static bool n_GetIncrespLen(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).IncrespLen;
      }

      private static Delegate GetSetIncrespLen_ZHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setIncrespLen_Z == null)
          Gen2v2.AuthenticateParams.cb_setIncrespLen_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.AuthenticateParams.n_SetIncrespLen_Z));
        return Gen2v2.AuthenticateParams.cb_setIncrespLen_Z;
      }

      private static void n_SetIncrespLen_Z(IntPtr jnienv, IntPtr native__this, bool m_bIncrespLen)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).IncrespLen = m_bIncrespLen;
      }

      public virtual unsafe bool IncrespLen
      {
        [Register("getIncrespLen", "()Z", "GetGetIncrespLenHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncrespLen.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setIncrespLen", "(Z)V", "GetSetIncrespLen_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setIncrespLen.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetMsgDataHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getMsgData == null)
          Gen2v2.AuthenticateParams.cb_getMsgData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Gen2v2.AuthenticateParams.n_GetMsgData));
        return Gen2v2.AuthenticateParams.cb_getMsgData;
      }

      private static IntPtr n_GetMsgData(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).MsgData);
      }

      private static Delegate GetSetMsgData_Ljava_lang_String_Handler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setMsgData_Ljava_lang_String_ == null)
          Gen2v2.AuthenticateParams.cb_setMsgData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Gen2v2.AuthenticateParams.n_SetMsgData_Ljava_lang_String_));
        return Gen2v2.AuthenticateParams.cb_setMsgData_Ljava_lang_String_;
      }

      private static void n_SetMsgData_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_sMsgData)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).MsgData = JNIEnv.GetString(native_m_sMsgData, (JniHandleOwnership) 0);
      }

      public virtual unsafe string? MsgData
      {
        [Register("getMsgData", "()Ljava/lang/String;", "GetGetMsgDataHandler")] get
        {
          JniObjectReference jniObjectReference = Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMsgData.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMsgData.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      private static Delegate GetGetMsgLenHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getMsgLen == null)
          Gen2v2.AuthenticateParams.cb_getMsgLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.AuthenticateParams.n_GetMsgLen));
        return Gen2v2.AuthenticateParams.cb_getMsgLen;
      }

      private static int n_GetMsgLen(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).MsgLen;
      }

      private static Delegate GetSetMsgLen_IHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setMsgLen_I == null)
          Gen2v2.AuthenticateParams.cb_setMsgLen_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.AuthenticateParams.n_SetMsgLen_I));
        return Gen2v2.AuthenticateParams.cb_setMsgLen_I;
      }

      private static void n_SetMsgLen_I(IntPtr jnienv, IntPtr native__this, int m_nMsgLen)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).MsgLen = m_nMsgLen;
      }

      public virtual unsafe int MsgLen
      {
        [Register("getMsgLen", "()I", "GetGetMsgLenHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualInt32Method("getMsgLen.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setMsgLen", "(I)V", "GetSetMsgLen_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMsgLen.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetRespLenHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getRespLen == null)
          Gen2v2.AuthenticateParams.cb_getRespLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.AuthenticateParams.n_GetRespLen));
        return Gen2v2.AuthenticateParams.cb_getRespLen;
      }

      private static int n_GetRespLen(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).RespLen;
      }

      private static Delegate GetSetRespLen_IHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setRespLen_I == null)
          Gen2v2.AuthenticateParams.cb_setRespLen_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.AuthenticateParams.n_SetRespLen_I));
        return Gen2v2.AuthenticateParams.cb_setRespLen_I;
      }

      private static void n_SetRespLen_I(IntPtr jnienv, IntPtr native__this, int m_nRespLen)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).RespLen = m_nRespLen;
      }

      public virtual unsafe int RespLen
      {
        [Register("getRespLen", "()I", "GetGetRespLenHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualInt32Method("getRespLen.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setRespLen", "(I)V", "GetSetRespLen_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setRespLen.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetSentRespHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getSentResp == null)
          Gen2v2.AuthenticateParams.cb_getSentResp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.AuthenticateParams.n_GetSentResp));
        return Gen2v2.AuthenticateParams.cb_getSentResp;
      }

      private static bool n_GetSentResp(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).SentResp;
      }

      private static Delegate GetSetSentResp_ZHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setSentResp_Z == null)
          Gen2v2.AuthenticateParams.cb_setSentResp_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.AuthenticateParams.n_SetSentResp_Z));
        return Gen2v2.AuthenticateParams.cb_setSentResp_Z;
      }

      private static void n_SetSentResp_Z(IntPtr jnienv, IntPtr native__this, bool m_bSentResp)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).SentResp = m_bSentResp;
      }

      public virtual unsafe bool SentResp
      {
        [Register("getSentResp", "()Z", "GetGetSentRespHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getSentResp.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setSentResp", "(Z)V", "GetSetSentResp_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setSentResp.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetStoreRespHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_getStoreResp == null)
          Gen2v2.AuthenticateParams.cb_getStoreResp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.AuthenticateParams.n_GetStoreResp));
        return Gen2v2.AuthenticateParams.cb_getStoreResp;
      }

      private static bool n_GetStoreResp(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).StoreResp;
      }

      private static Delegate GetSetStoreResp_ZHandler()
      {
        if ((object) Gen2v2.AuthenticateParams.cb_setStoreResp_Z == null)
          Gen2v2.AuthenticateParams.cb_setStoreResp_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.AuthenticateParams.n_SetStoreResp_Z));
        return Gen2v2.AuthenticateParams.cb_setStoreResp_Z;
      }

      private static void n_SetStoreResp_Z(IntPtr jnienv, IntPtr native__this, bool m_bStoreResp)
      {
        Object.GetObject<Gen2v2.AuthenticateParams>(jnienv, native__this, (JniHandleOwnership) 0).StoreResp = m_bStoreResp;
      }

      public virtual unsafe bool StoreResp
      {
        [Register("getStoreResp", "()Z", "GetGetStoreRespHandler")] get
        {
          return Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getStoreResp.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setStoreResp", "(Z)V", "GetSetStoreResp_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.AuthenticateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setStoreResp.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Gen2v2$CryptoParams", DoNotGenerateAcw = true)]
    public class CryptoParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2$CryptoParams", typeof (Gen2v2.CryptoParams));
      private static Delegate? cb_getBlockCount;
      private static Delegate? cb_setBlockCount_I;
      private static Delegate? cb_getChallenge;
      private static Delegate? cb_setChallenge_Ljava_lang_String_;
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

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.CryptoParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Gen2v2.CryptoParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.CryptoParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Gen2v2.CryptoParams._members.ManagedPeerType;

      protected CryptoParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;)V", "")]
      public unsafe CryptoParams(Gen2v2? __self)
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
          JniObjectReference instance = Gen2v2.CryptoParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.CryptoParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;JI)V", "")]
      public unsafe CryptoParams(Gen2v2? __self, long m_nPassword, int m_nKeyId)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";JI)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_nPassword),
            new JniArgumentValue(m_nKeyId)
          };
          JniObjectReference instance = Gen2v2.CryptoParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.CryptoParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      private static Delegate GetGetBlockCountHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getBlockCount == null)
          Gen2v2.CryptoParams.cb_getBlockCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.CryptoParams.n_GetBlockCount));
        return Gen2v2.CryptoParams.cb_getBlockCount;
      }

      private static int n_GetBlockCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).BlockCount;
      }

      private static Delegate GetSetBlockCount_IHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setBlockCount_I == null)
          Gen2v2.CryptoParams.cb_setBlockCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.CryptoParams.n_SetBlockCount_I));
        return Gen2v2.CryptoParams.cb_setBlockCount_I;
      }

      private static void n_SetBlockCount_I(IntPtr jnienv, IntPtr native__this, int m_nBlockCount)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).BlockCount = m_nBlockCount;
      }

      public virtual unsafe int BlockCount
      {
        [Register("getBlockCount", "()I", "GetGetBlockCountHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt32Method("getBlockCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setBlockCount", "(I)V", "GetSetBlockCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setBlockCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetChallengeHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getChallenge == null)
          Gen2v2.CryptoParams.cb_getChallenge = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Gen2v2.CryptoParams.n_GetChallenge));
        return Gen2v2.CryptoParams.cb_getChallenge;
      }

      private static IntPtr n_GetChallenge(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Challenge);
      }

      private static Delegate GetSetChallenge_Ljava_lang_String_Handler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setChallenge_Ljava_lang_String_ == null)
          Gen2v2.CryptoParams.cb_setChallenge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Gen2v2.CryptoParams.n_SetChallenge_Ljava_lang_String_));
        return Gen2v2.CryptoParams.cb_setChallenge_Ljava_lang_String_;
      }

      private static void n_SetChallenge_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_sChallenge)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Challenge = JNIEnv.GetString(native_m_sChallenge, (JniHandleOwnership) 0);
      }

      public virtual unsafe string? Challenge
      {
        [Register("getChallenge", "()Ljava/lang/String;", "GetGetChallengeHandler")] get
        {
          JniObjectReference jniObjectReference = Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualObjectMethod("getChallenge.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
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
            Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setChallenge.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      private static Delegate GetGetExcCustomHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getExcCustom == null)
          Gen2v2.CryptoParams.cb_getExcCustom = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.CryptoParams.n_GetExcCustom));
        return Gen2v2.CryptoParams.cb_getExcCustom;
      }

      private static bool n_GetExcCustom(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).ExcCustom;
      }

      private static Delegate GetSetExcCustom_ZHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setExcCustom_Z == null)
          Gen2v2.CryptoParams.cb_setExcCustom_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.CryptoParams.n_SetExcCustom_Z));
        return Gen2v2.CryptoParams.cb_setExcCustom_Z;
      }

      private static void n_SetExcCustom_Z(IntPtr jnienv, IntPtr native__this, bool m_bExcCustom)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).ExcCustom = m_bExcCustom;
      }

      public virtual unsafe bool ExcCustom
      {
        [Register("getExcCustom", "()Z", "GetGetExcCustomHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcCustom.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setExcCustom", "(Z)V", "GetSetExcCustom_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setExcCustom.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetIncCustomHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getIncCustom == null)
          Gen2v2.CryptoParams.cb_getIncCustom = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.CryptoParams.n_GetIncCustom));
        return Gen2v2.CryptoParams.cb_getIncCustom;
      }

      private static bool n_GetIncCustom(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).IncCustom;
      }

      private static Delegate GetSetIncCustom_ZHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setIncCustom_Z == null)
          Gen2v2.CryptoParams.cb_setIncCustom_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.CryptoParams.n_SetIncCustom_Z));
        return Gen2v2.CryptoParams.cb_setIncCustom_Z;
      }

      private static void n_SetIncCustom_Z(IntPtr jnienv, IntPtr native__this, bool m_bIncCustom)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).IncCustom = m_bIncCustom;
      }

      public virtual unsafe bool IncCustom
      {
        [Register("getIncCustom", "()Z", "GetGetIncCustomHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncCustom.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setIncCustom", "(Z)V", "GetSetIncCustom_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setIncCustom.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetKeyIdHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getKeyId == null)
          Gen2v2.CryptoParams.cb_getKeyId = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.CryptoParams.n_GetKeyId));
        return Gen2v2.CryptoParams.cb_getKeyId;
      }

      private static int n_GetKeyId(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).KeyId;
      }

      private static Delegate GetSetKeyId_IHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setKeyId_I == null)
          Gen2v2.CryptoParams.cb_setKeyId_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.CryptoParams.n_SetKeyId_I));
        return Gen2v2.CryptoParams.cb_setKeyId_I;
      }

      private static void n_SetKeyId_I(IntPtr jnienv, IntPtr native__this, int m_nKeyId)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).KeyId = m_nKeyId;
      }

      public virtual unsafe int KeyId
      {
        [Register("getKeyId", "()I", "GetGetKeyIdHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt32Method("getKeyId.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setKeyId", "(I)V", "GetSetKeyId_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setKeyId.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetOffsetHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getOffset == null)
          Gen2v2.CryptoParams.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.CryptoParams.n_GetOffset));
        return Gen2v2.CryptoParams.cb_getOffset;
      }

      private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
      }

      private static Delegate GetSetOffset_IHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setOffset_I == null)
          Gen2v2.CryptoParams.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.CryptoParams.n_SetOffset_I));
        return Gen2v2.CryptoParams.cb_setOffset_I;
      }

      private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int m_nOffset)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Offset = m_nOffset;
      }

      public virtual unsafe int Offset
      {
        [Register("getOffset", "()I", "GetGetOffsetHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetPasswordHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getPassword == null)
          Gen2v2.CryptoParams.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Gen2v2.CryptoParams.n_GetPassword));
        return Gen2v2.CryptoParams.cb_getPassword;
      }

      private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Password;
      }

      private static Delegate GetSetPassword_JHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setPassword_J == null)
          Gen2v2.CryptoParams.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Gen2v2.CryptoParams.n_SetPassword_J));
        return Gen2v2.CryptoParams.cb_setPassword_J;
      }

      private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long m_nPassword)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Password = m_nPassword;
      }

      public virtual unsafe long Password
      {
        [Register("getPassword", "()J", "GetGetPasswordHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetProfileHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getProfile == null)
          Gen2v2.CryptoParams.cb_getProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.CryptoParams.n_GetProfile));
        return Gen2v2.CryptoParams.cb_getProfile;
      }

      private static int n_GetProfile(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Profile;
      }

      private static Delegate GetSetProfile_IHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setProfile_I == null)
          Gen2v2.CryptoParams.cb_setProfile_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.CryptoParams.n_SetProfile_I));
        return Gen2v2.CryptoParams.cb_setProfile_I;
      }

      private static void n_SetProfile_I(IntPtr jnienv, IntPtr native__this, int m_nProfile)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).Profile = m_nProfile;
      }

      public virtual unsafe int Profile
      {
        [Register("getProfile", "()I", "GetGetProfileHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt32Method("getProfile.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setProfile", "(I)V", "GetSetProfile_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setProfile.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetProtModeHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_getProtMode == null)
          Gen2v2.CryptoParams.cb_getProtMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.CryptoParams.n_GetProtMode));
        return Gen2v2.CryptoParams.cb_getProtMode;
      }

      private static int n_GetProtMode(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).ProtMode;
      }

      private static Delegate GetSetProtMode_IHandler()
      {
        if ((object) Gen2v2.CryptoParams.cb_setProtMode_I == null)
          Gen2v2.CryptoParams.cb_setProtMode_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.CryptoParams.n_SetProtMode_I));
        return Gen2v2.CryptoParams.cb_setProtMode_I;
      }

      private static void n_SetProtMode_I(IntPtr jnienv, IntPtr native__this, int m_nProtMode)
      {
        Object.GetObject<Gen2v2.CryptoParams>(jnienv, native__this, (JniHandleOwnership) 0).ProtMode = m_nProtMode;
      }

      public virtual unsafe int ProtMode
      {
        [Register("getProtMode", "()I", "GetGetProtModeHandler")] get
        {
          return Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualInt32Method("getProtMode.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setProtMode", "(I)V", "GetSetProtMode_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.CryptoParams._members.InstanceMethods.InvokeVirtualVoidMethod("setProtMode.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Gen2v2$Operation", DoNotGenerateAcw = true)]
    public class Operation : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2$Operation", typeof (Gen2v2.Operation));

      [Register("AuthenticateParams")]
      public Gen2v2.AuthenticateParams? AuthenticateParams
      {
        get
        {
          JniObjectReference objectValue = Gen2v2.Operation._members.InstanceFields.GetObjectValue("AuthenticateParams.Lcom/zebra/rfid/api3/Gen2v2$AuthenticateParams;", (IJavaPeerable) this);
          return Object.GetObject<Gen2v2.AuthenticateParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            Gen2v2.Operation._members.InstanceFields.SetValue("AuthenticateParams.Lcom/zebra/rfid/api3/Gen2v2$AuthenticateParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("CryptoParams")]
      public Gen2v2.CryptoParams? CryptoParams
      {
        get
        {
          JniObjectReference objectValue = Gen2v2.Operation._members.InstanceFields.GetObjectValue("CryptoParams.Lcom/zebra/rfid/api3/Gen2v2$CryptoParams;", (IJavaPeerable) this);
          return Object.GetObject<Gen2v2.CryptoParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            Gen2v2.Operation._members.InstanceFields.SetValue("CryptoParams.Lcom/zebra/rfid/api3/Gen2v2$CryptoParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("ReadBufferParams")]
      public Gen2v2.ReadBufferParams? ReadBufferParams
      {
        get
        {
          JniObjectReference objectValue = Gen2v2.Operation._members.InstanceFields.GetObjectValue("ReadBufferParams.Lcom/zebra/rfid/api3/Gen2v2$ReadBufferParams;", (IJavaPeerable) this);
          return Object.GetObject<Gen2v2.ReadBufferParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            Gen2v2.Operation._members.InstanceFields.SetValue("ReadBufferParams.Lcom/zebra/rfid/api3/Gen2v2$ReadBufferParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("UntraceableParams")]
      public Gen2v2.UntraceableParams? UntraceableParams
      {
        get
        {
          JniObjectReference objectValue = Gen2v2.Operation._members.InstanceFields.GetObjectValue("UntraceableParams.Lcom/zebra/rfid/api3/Gen2v2$UntraceableParams;", (IJavaPeerable) this);
          return Object.GetObject<Gen2v2.UntraceableParams>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            Gen2v2.Operation._members.InstanceFields.SetValue("UntraceableParams.Lcom/zebra/rfid/api3/Gen2v2$UntraceableParams;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
          JniObjectReference peerReference = Gen2v2.Operation._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Gen2v2.Operation._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.Operation._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Gen2v2.Operation._members.ManagedPeerType;

      protected Operation(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;)V", "")]
      public unsafe Operation(Gen2v2? __self)
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
          JniObjectReference instance = Gen2v2.Operation._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.Operation._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Gen2v2$ReadBufferParams", DoNotGenerateAcw = true)]
    public class ReadBufferParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2$ReadBufferParams", typeof (Gen2v2.ReadBufferParams));
      private static Delegate? cb_getBitCount;
      private static Delegate? cb_setBitCount_I;
      private static Delegate? cb_getPassword;
      private static Delegate? cb_setPassword_J;
      private static Delegate? cb_getWordPtr;
      private static Delegate? cb_setWordPtr_I;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.ReadBufferParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Gen2v2.ReadBufferParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.ReadBufferParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Gen2v2.ReadBufferParams._members.ManagedPeerType;

      protected ReadBufferParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;)V", "")]
      public unsafe ReadBufferParams(Gen2v2? __self)
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
          JniObjectReference instance = Gen2v2.ReadBufferParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.ReadBufferParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;Ljava/lang/Long;II)V", "")]
      public unsafe ReadBufferParams(
        Gen2v2? __self,
        Long? m_nPassword,
        int m_nWordptr,
        int m_nBitcount)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";Ljava/lang/Long;II)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_nPassword == null ? IntPtr.Zero : ((Object) m_nPassword).Handle),
            new JniArgumentValue(m_nWordptr),
            new JniArgumentValue(m_nBitcount)
          };
          JniObjectReference instance = Gen2v2.ReadBufferParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.ReadBufferParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_nPassword);
        }
      }

      private static Delegate GetGetBitCountHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_getBitCount == null)
          Gen2v2.ReadBufferParams.cb_getBitCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.ReadBufferParams.n_GetBitCount));
        return Gen2v2.ReadBufferParams.cb_getBitCount;
      }

      private static int n_GetBitCount(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).BitCount;
      }

      private static Delegate GetSetBitCount_IHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_setBitCount_I == null)
          Gen2v2.ReadBufferParams.cb_setBitCount_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.ReadBufferParams.n_SetBitCount_I));
        return Gen2v2.ReadBufferParams.cb_setBitCount_I;
      }

      private static void n_SetBitCount_I(IntPtr jnienv, IntPtr native__this, int m_nBitcount)
      {
        Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).BitCount = m_nBitcount;
      }

      public virtual unsafe int BitCount
      {
        [Register("getBitCount", "()I", "GetGetBitCountHandler")] get
        {
          return Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualInt32Method("getBitCount.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setBitCount", "(I)V", "GetSetBitCount_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualVoidMethod("setBitCount.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetPasswordHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_getPassword == null)
          Gen2v2.ReadBufferParams.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Gen2v2.ReadBufferParams.n_GetPassword));
        return Gen2v2.ReadBufferParams.cb_getPassword;
      }

      private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).Password;
      }

      private static Delegate GetSetPassword_JHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_setPassword_J == null)
          Gen2v2.ReadBufferParams.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Gen2v2.ReadBufferParams.n_SetPassword_J));
        return Gen2v2.ReadBufferParams.cb_setPassword_J;
      }

      private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long m_nPassword)
      {
        Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).Password = m_nPassword;
      }

      public virtual unsafe long Password
      {
        [Register("getPassword", "()J", "GetGetPasswordHandler")] get
        {
          return Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetWordPtrHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_getWordPtr == null)
          Gen2v2.ReadBufferParams.cb_getWordPtr = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.ReadBufferParams.n_GetWordPtr));
        return Gen2v2.ReadBufferParams.cb_getWordPtr;
      }

      private static int n_GetWordPtr(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).WordPtr;
      }

      private static Delegate GetSetWordPtr_IHandler()
      {
        if ((object) Gen2v2.ReadBufferParams.cb_setWordPtr_I == null)
          Gen2v2.ReadBufferParams.cb_setWordPtr_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.ReadBufferParams.n_SetWordPtr_I));
        return Gen2v2.ReadBufferParams.cb_setWordPtr_I;
      }

      private static void n_SetWordPtr_I(IntPtr jnienv, IntPtr native__this, int m_nWordptr)
      {
        Object.GetObject<Gen2v2.ReadBufferParams>(jnienv, native__this, (JniHandleOwnership) 0).WordPtr = m_nWordptr;
      }

      public virtual unsafe int WordPtr
      {
        [Register("getWordPtr", "()I", "GetGetWordPtrHandler")] get
        {
          return Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualInt32Method("getWordPtr.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setWordPtr", "(I)V", "GetSetWordPtr_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.ReadBufferParams._members.InstanceMethods.InvokeVirtualVoidMethod("setWordPtr.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }

    [Register("com/zebra/rfid/api3/Gen2v2$UntraceableParams", DoNotGenerateAcw = true)]
    public class UntraceableParams : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Gen2v2$UntraceableParams", typeof (Gen2v2.UntraceableParams));
      private static Delegate? cb_getAssertu;
      private static Delegate? cb_setAssertu_Z;
      private static Delegate? cb_getEpcLen;
      private static Delegate? cb_setEpcLen_I;
      private static Delegate? cb_getHideEpc;
      private static Delegate? cb_setHideEpc_Z;
      private static Delegate? cb_getHideUser;
      private static Delegate? cb_setHideUser_Z;
      private static Delegate? cb_getPassword;
      private static Delegate? cb_setPassword_J;
      private static Delegate? cb_getRange;
      private static Delegate? cb_setRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_;
      private static Delegate? cb_getShowEpc;
      private static Delegate? cb_setShowEpc_Z;
      private static Delegate? cb_getShowUser;
      private static Delegate? cb_setShowUser_Z;
      private static Delegate? cb_getTid;
      private static Delegate? cb_setTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.UntraceableParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => Gen2v2.UntraceableParams._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = Gen2v2.UntraceableParams._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => Gen2v2.UntraceableParams._members.ManagedPeerType;

      protected UntraceableParams(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;)V", "")]
      public unsafe UntraceableParams(Gen2v2? __self)
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
          JniObjectReference instance = Gen2v2.UntraceableParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.UntraceableParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/Gen2v2;JLcom/zebra/rfid/api3/UNTRACEABLE_RANGE;)V", "")]
      public unsafe UntraceableParams(Gen2v2? __self, long m_nPassword, UNTRACEABLE_RANGE? m_sRange)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";JLcom/zebra/rfid/api3/UNTRACEABLE_RANGE;)V";
        if (this.Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle),
            new JniArgumentValue(m_nPassword),
            new JniArgumentValue(m_sRange == null ? IntPtr.Zero : m_sRange.Handle)
          };
          JniObjectReference instance = Gen2v2.UntraceableParams._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          Gen2v2.UntraceableParams._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
          GC.KeepAlive((object) m_sRange);
        }
      }

      private static Delegate GetGetAssertuHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getAssertu == null)
          Gen2v2.UntraceableParams.cb_getAssertu = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.UntraceableParams.n_GetAssertu));
        return Gen2v2.UntraceableParams.cb_getAssertu;
      }

      private static bool n_GetAssertu(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Assertu;
      }

      private static Delegate GetSetAssertu_ZHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setAssertu_Z == null)
          Gen2v2.UntraceableParams.cb_setAssertu_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.UntraceableParams.n_SetAssertu_Z));
        return Gen2v2.UntraceableParams.cb_setAssertu_Z;
      }

      private static void n_SetAssertu_Z(IntPtr jnienv, IntPtr native__this, bool m_bAssertu)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Assertu = m_bAssertu;
      }

      public virtual unsafe bool Assertu
      {
        [Register("getAssertu", "()Z", "GetGetAssertuHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getAssertu.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setAssertu", "(Z)V", "GetSetAssertu_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAssertu.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetEpcLenHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getEpcLen == null)
          Gen2v2.UntraceableParams.cb_getEpcLen = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(Gen2v2.UntraceableParams.n_GetEpcLen));
        return Gen2v2.UntraceableParams.cb_getEpcLen;
      }

      private static int n_GetEpcLen(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).EpcLen;
      }

      private static Delegate GetSetEpcLen_IHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setEpcLen_I == null)
          Gen2v2.UntraceableParams.cb_setEpcLen_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(Gen2v2.UntraceableParams.n_SetEpcLen_I));
        return Gen2v2.UntraceableParams.cb_setEpcLen_I;
      }

      private static void n_SetEpcLen_I(IntPtr jnienv, IntPtr native__this, int m_bEpcLen)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).EpcLen = m_bEpcLen;
      }

      public virtual unsafe int EpcLen
      {
        [Register("getEpcLen", "()I", "GetGetEpcLenHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualInt32Method("getEpcLen.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setEpcLen", "(I)V", "GetSetEpcLen_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setEpcLen.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetHideEpcHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getHideEpc == null)
          Gen2v2.UntraceableParams.cb_getHideEpc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.UntraceableParams.n_GetHideEpc));
        return Gen2v2.UntraceableParams.cb_getHideEpc;
      }

      private static bool n_GetHideEpc(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).HideEpc;
      }

      private static Delegate GetSetHideEpc_ZHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setHideEpc_Z == null)
          Gen2v2.UntraceableParams.cb_setHideEpc_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.UntraceableParams.n_SetHideEpc_Z));
        return Gen2v2.UntraceableParams.cb_setHideEpc_Z;
      }

      private static void n_SetHideEpc_Z(IntPtr jnienv, IntPtr native__this, bool m_bHideEpc)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).HideEpc = m_bHideEpc;
      }

      public virtual unsafe bool HideEpc
      {
        [Register("getHideEpc", "()Z", "GetGetHideEpcHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getHideEpc.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setHideEpc", "(Z)V", "GetSetHideEpc_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setHideEpc.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetHideUserHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getHideUser == null)
          Gen2v2.UntraceableParams.cb_getHideUser = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.UntraceableParams.n_GetHideUser));
        return Gen2v2.UntraceableParams.cb_getHideUser;
      }

      private static bool n_GetHideUser(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).HideUser;
      }

      private static Delegate GetSetHideUser_ZHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setHideUser_Z == null)
          Gen2v2.UntraceableParams.cb_setHideUser_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.UntraceableParams.n_SetHideUser_Z));
        return Gen2v2.UntraceableParams.cb_setHideUser_Z;
      }

      private static void n_SetHideUser_Z(IntPtr jnienv, IntPtr native__this, bool m_bHideUser)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).HideUser = m_bHideUser;
      }

      public virtual unsafe bool HideUser
      {
        [Register("getHideUser", "()Z", "GetGetHideUserHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getHideUser.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setHideUser", "(Z)V", "GetSetHideUser_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setHideUser.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetPasswordHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getPassword == null)
          Gen2v2.UntraceableParams.cb_getPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(Gen2v2.UntraceableParams.n_GetPassword));
        return Gen2v2.UntraceableParams.cb_getPassword;
      }

      private static long n_GetPassword(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Password;
      }

      private static Delegate GetSetPassword_JHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setPassword_J == null)
          Gen2v2.UntraceableParams.cb_setPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(Gen2v2.UntraceableParams.n_SetPassword_J));
        return Gen2v2.UntraceableParams.cb_setPassword_J;
      }

      private static void n_SetPassword_J(IntPtr jnienv, IntPtr native__this, long m_nPassword)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Password = m_nPassword;
      }

      public virtual unsafe long Password
      {
        [Register("getPassword", "()J", "GetGetPasswordHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualInt64Method("getPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setPassword", "(J)V", "GetSetPassword_JHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetRangeHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getRange == null)
          Gen2v2.UntraceableParams.cb_getRange = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Gen2v2.UntraceableParams.n_GetRange));
        return Gen2v2.UntraceableParams.cb_getRange;
      }

      private static IntPtr n_GetRange(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Range);
      }

      private static Delegate GetSetRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_Handler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_ == null)
          Gen2v2.UntraceableParams.cb_setRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Gen2v2.UntraceableParams.n_SetRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_));
        return Gen2v2.UntraceableParams.cb_setRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_;
      }

      private static void n_SetRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_sRange)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Range = Object.GetObject<UNTRACEABLE_RANGE>(native_m_sRange, (JniHandleOwnership) 0);
      }

      public virtual unsafe UNTRACEABLE_RANGE? Range
      {
        [Register("getRange", "()Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", "GetGetRangeHandler")] get
        {
          JniObjectReference jniObjectReference = Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualObjectMethod("getRange.()Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<UNTRACEABLE_RANGE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setRange", "(Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;)V", "GetSetRange_Lcom_zebra_rfid_api3_UNTRACEABLE_RANGE_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setRange.(Lcom/zebra/rfid/api3/UNTRACEABLE_RANGE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }

      private static Delegate GetGetShowEpcHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getShowEpc == null)
          Gen2v2.UntraceableParams.cb_getShowEpc = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.UntraceableParams.n_GetShowEpc));
        return Gen2v2.UntraceableParams.cb_getShowEpc;
      }

      private static bool n_GetShowEpc(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).ShowEpc;
      }

      private static Delegate GetSetShowEpc_ZHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setShowEpc_Z == null)
          Gen2v2.UntraceableParams.cb_setShowEpc_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.UntraceableParams.n_SetShowEpc_Z));
        return Gen2v2.UntraceableParams.cb_setShowEpc_Z;
      }

      private static void n_SetShowEpc_Z(IntPtr jnienv, IntPtr native__this, bool m_bShowEpc)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).ShowEpc = m_bShowEpc;
      }

      public virtual unsafe bool ShowEpc
      {
        [Register("getShowEpc", "()Z", "GetGetShowEpcHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getShowEpc.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setShowEpc", "(Z)V", "GetSetShowEpc_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setShowEpc.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetShowUserHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getShowUser == null)
          Gen2v2.UntraceableParams.cb_getShowUser = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Gen2v2.UntraceableParams.n_GetShowUser));
        return Gen2v2.UntraceableParams.cb_getShowUser;
      }

      private static bool n_GetShowUser(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).ShowUser;
      }

      private static Delegate GetSetShowUser_ZHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setShowUser_Z == null)
          Gen2v2.UntraceableParams.cb_setShowUser_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Gen2v2.UntraceableParams.n_SetShowUser_Z));
        return Gen2v2.UntraceableParams.cb_setShowUser_Z;
      }

      private static void n_SetShowUser_Z(IntPtr jnienv, IntPtr native__this, bool m_bShowUser)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).ShowUser = m_bShowUser;
      }

      public virtual unsafe bool ShowUser
      {
        [Register("getShowUser", "()Z", "GetGetShowUserHandler")] get
        {
          return Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualBooleanMethod("getShowUser.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setShowUser", "(Z)V", "GetSetShowUser_ZHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setShowUser.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTidHandler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_getTid == null)
          Gen2v2.UntraceableParams.cb_getTid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Gen2v2.UntraceableParams.n_GetTid));
        return Gen2v2.UntraceableParams.cb_getTid;
      }

      private static IntPtr n_GetTid(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Tid);
      }

      private static Delegate GetSetTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_Handler()
      {
        if ((object) Gen2v2.UntraceableParams.cb_setTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_ == null)
          Gen2v2.UntraceableParams.cb_setTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Gen2v2.UntraceableParams.n_SetTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_));
        return Gen2v2.UntraceableParams.cb_setTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_;
      }

      private static void n_SetTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_sTid)
      {
        Object.GetObject<Gen2v2.UntraceableParams>(jnienv, native__this, (JniHandleOwnership) 0).Tid = Object.GetObject<UNTRACEABLE_TID>(native_m_sTid, (JniHandleOwnership) 0);
      }

      public virtual unsafe UNTRACEABLE_TID? Tid
      {
        [Register("getTid", "()Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", "GetGetTidHandler")] get
        {
          JniObjectReference jniObjectReference = Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualObjectMethod("getTid.()Lcom/zebra/rfid/api3/UNTRACEABLE_TID;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<UNTRACEABLE_TID>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setTid", "(Lcom/zebra/rfid/api3/UNTRACEABLE_TID;)V", "GetSetTid_Lcom_zebra_rfid_api3_UNTRACEABLE_TID_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            Gen2v2.UntraceableParams._members.InstanceMethods.InvokeVirtualVoidMethod("setTid.(Lcom/zebra/rfid/api3/UNTRACEABLE_TID;)V", (IJavaPeerable) this, jniArgumentValuePtr);
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
