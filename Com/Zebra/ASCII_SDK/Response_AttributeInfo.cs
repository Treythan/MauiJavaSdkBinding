// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Response_AttributeInfo
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
  [Register("com/zebra/ASCII_SDK/Response_AttributeInfo", DoNotGenerateAcw = true)]
  public class Response_AttributeInfo : ResponseMsg
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Response_AttributeInfo", typeof (Response_AttributeInfo));
    private static Delegate? cb_getResponseType;

    [Register("AttNum")]
    public int AttNum
    {
      get
      {
        return Response_AttributeInfo._members.InstanceFields.GetInt32Value("AttNum.I", (IJavaPeerable) this);
      }
      set
      {
        Response_AttributeInfo._members.InstanceFields.SetValue("AttNum.I", (IJavaPeerable) this, value);
      }
    }

    [Register("Length")]
    public int Length
    {
      get
      {
        return Response_AttributeInfo._members.InstanceFields.GetInt32Value("Length.I", (IJavaPeerable) this);
      }
      set
      {
        Response_AttributeInfo._members.InstanceFields.SetValue("Length.I", (IJavaPeerable) this, value);
      }
    }

    [Register("Offset")]
    public int Offset
    {
      get
      {
        return Response_AttributeInfo._members.InstanceFields.GetInt32Value("Offset.I", (IJavaPeerable) this);
      }
      set
      {
        Response_AttributeInfo._members.InstanceFields.SetValue("Offset.I", (IJavaPeerable) this, value);
      }
    }

    [Register("propertyVal")]
    public int PropertyVal
    {
      get
      {
        return Response_AttributeInfo._members.InstanceFields.GetInt32Value("propertyVal.I", (IJavaPeerable) this);
      }
      set
      {
        Response_AttributeInfo._members.InstanceFields.SetValue("propertyVal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("Type")]
    public string? Type
    {
      get
      {
        JniObjectReference objectValue = Response_AttributeInfo._members.InstanceFields.GetObjectValue("Type.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Response_AttributeInfo._members.InstanceFields.SetValue("Type.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("Value")]
    public string? Value
    {
      get
      {
        JniObjectReference objectValue = Response_AttributeInfo._members.InstanceFields.GetObjectValue("Value.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          Response_AttributeInfo._members.InstanceFields.SetValue("Value.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    internal new static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Response_AttributeInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => Response_AttributeInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Response_AttributeInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override System.Type ThresholdType => Response_AttributeInfo._members.ManagedPeerType;

    protected Response_AttributeInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Response_AttributeInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Response_AttributeInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Response_AttributeInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetResponseTypeHandler()
    {
      if ((object) Response_AttributeInfo.cb_getResponseType == null)
        Response_AttributeInfo.cb_getResponseType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Response_AttributeInfo.n_GetResponseType));
      return Response_AttributeInfo.cb_getResponseType;
    }

    private static IntPtr n_GetResponseType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Response_AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).ResponseType);
    }

    public override unsafe RESPONSE_TYPE? ResponseType
    {
      [Register("getResponseType", "()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", "GetGetResponseTypeHandler")] get
      {
        JniObjectReference jniObjectReference = Response_AttributeInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getResponseType.()Lcom/zebra/ASCII_SDK/RESPONSE_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RESPONSE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FromString", "(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_AttributeInfo;", "")]
    public static unsafe Response_AttributeInfo? FromString(string? str, MetaData? mData)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(mData == null ? IntPtr.Zero : mData.Handle)
        };
        JniObjectReference jniObjectReference = Response_AttributeInfo._members.StaticMethods.InvokeObjectMethod("FromString.(Ljava/lang/String;Lcom/zebra/ASCII_SDK/MetaData;)Lcom/zebra/ASCII_SDK/Response_AttributeInfo;", jniArgumentValuePtr);
        return Object.GetObject<Response_AttributeInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) mData);
      }
    }
  }
}
