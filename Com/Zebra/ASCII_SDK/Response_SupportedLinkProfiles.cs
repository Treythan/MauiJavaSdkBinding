// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Response_SupportedLinkProfiles
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
  [Register("com/zebra/ASCII_SDK/Response_SupportedLinkProfiles", DoNotGenerateAcw = true)]
  public class Response_SupportedLinkProfiles : ResponseMsg
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Response_SupportedLinkProfiles", typeof (Response_SupportedLinkProfiles));
    private static Delegate? cb_getResponseType;

    [Register("BDR")]
    public int Bdr
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetInt32Value("BDR.I", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("BDR.I", (IJavaPeerable) this, value);
      }
    }

    [Register("DivideRatio")]
    public ENUM_DEVIDE_RATIO? DivideRatio
    {
      get
      {
        JniObjectReference objectValue = Response_SupportedLinkProfiles._members.InstanceFields.GetObjectValue("DivideRatio.Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_DEVIDE_RATIO>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Response_SupportedLinkProfiles._members.InstanceFields.SetValue("DivideRatio.Lcom/zebra/ASCII_SDK/ENUM_DEVIDE_RATIO;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("EPCHAGTCConformance")]
    public bool EPCHAGTCConformance
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetBooleanValue("EPCHAGTCConformance.Z", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("EPCHAGTCConformance.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("FLM")]
    public ENUM_FORWARD_LINK_MODULATION? Flm
    {
      get
      {
        JniObjectReference objectValue = Response_SupportedLinkProfiles._members.InstanceFields.GetObjectValue("FLM.Lcom/zebra/ASCII_SDK/ENUM_FORWARD_LINK_MODULATION;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_FORWARD_LINK_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Response_SupportedLinkProfiles._members.InstanceFields.SetValue("FLM.Lcom/zebra/ASCII_SDK/ENUM_FORWARD_LINK_MODULATION;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("M")]
    public ENUM_MODULATION? M
    {
      get
      {
        JniObjectReference objectValue = Response_SupportedLinkProfiles._members.InstanceFields.GetObjectValue("M.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Response_SupportedLinkProfiles._members.InstanceFields.SetValue("M.Lcom/zebra/ASCII_SDK/ENUM_MODULATION;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("MaxTari")]
    public int MaxTari
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetInt32Value("MaxTari.I", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("MaxTari.I", (IJavaPeerable) this, value);
      }
    }

    [Register("MinTari")]
    public int MinTari
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetInt32Value("MinTari.I", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("MinTari.I", (IJavaPeerable) this, value);
      }
    }

    [Register("PIE")]
    public int Pie
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetInt32Value("PIE.I", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("PIE.I", (IJavaPeerable) this, value);
      }
    }

    [Register("RFModeIndex")]
    public sbyte RFModeIndex
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetSByteValue("RFModeIndex.B", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("RFModeIndex.B", (IJavaPeerable) this, value);
      }
    }

    [Register("SpectralMaskIndicator")]
    public ENUM_SPECTRAL_MASK_INDICATOR? SpectralMaskIndicator
    {
      get
      {
        JniObjectReference objectValue = Response_SupportedLinkProfiles._members.InstanceFields.GetObjectValue("SpectralMaskIndicator.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", (IJavaPeerable) this);
        return Object.GetObject<ENUM_SPECTRAL_MASK_INDICATOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          Response_SupportedLinkProfiles._members.InstanceFields.SetValue("SpectralMaskIndicator.Lcom/zebra/ASCII_SDK/ENUM_SPECTRAL_MASK_INDICATOR;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("StepTari")]
    public int StepTari
    {
      get
      {
        return Response_SupportedLinkProfiles._members.InstanceFields.GetInt32Value("StepTari.I", (IJavaPeerable) this);
      }
      set
      {
        Response_SupportedLinkProfiles._members.InstanceFields.SetValue("StepTari.I", (IJavaPeerable) this, value);
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Response_SupportedLinkProfiles._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Response_SupportedLinkProfiles._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Response_SupportedLinkProfiles._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType
    {
      get => Response_SupportedLinkProfiles._members.ManagedPeerType;
    }

    protected Response_SupportedLinkProfiles(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Response_SupportedLinkProfiles()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Response_SupportedLinkProfiles._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Response_SupportedLinkProfiles._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetResponseTypeHandler()
    {
      if ((object) Response_SupportedLinkProfiles.cb_getResponseType == null)
        Response_SupportedLinkProfiles.cb_getResponseType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Response_SupportedLinkProfiles.n_GetResponseType));
      return Response_SupportedLinkProfiles.cb_getResponseType;
    }

    private static IntPtr n_GetResponseType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Response_SupportedLinkProfiles>(jnienv, native__this, (JniHandleOwnership) 0).ResponseType);
    }

    public override unsafe RESPONSE_TYPE? ResponseType
    {
      [Register("getResponseType", "()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "GetGetResponseTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Response_SupportedLinkProfiles._members.InstanceMethods.InvokeVirtualObjectMethod("getResponseType.()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_SupportedLinkProfiles;", "")]
    public static unsafe Response_SupportedLinkProfiles? FromString(string? str, MetaData? mData)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(mData == null ? IntPtr.Zero : mData.Handle)
        };
        JniObjectReference jniObjectReference = Response_SupportedLinkProfiles._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_SupportedLinkProfiles;", jniArgumentValuePtr);
        return Object.GetObject<Response_SupportedLinkProfiles>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) mData);
      }
    }
  }
}
