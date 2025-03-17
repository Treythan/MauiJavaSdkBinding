// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.AttributeInfo
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
  [Register("com/zebra/rfid/api3/AttributeInfo", DoNotGenerateAcw = true)]
  public class AttributeInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/AttributeInfo", typeof (AttributeInfo));
    private static Delegate? cb_getAttNum;
    private static Delegate? cb_setAttNum_I;
    private static Delegate? cb_getLength;
    private static Delegate? cb_setLength_I;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;
    private static Delegate? cb_getPropertyVal;
    private static Delegate? cb_setPropertyVal_I;
    private static Delegate? cb_getType;
    private static Delegate? cb_setType_Ljava_lang_String_;
    private static Delegate? cb_getValue;
    private static Delegate? cb_setValue_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = AttributeInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => AttributeInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = AttributeInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual System.Type ThresholdType => AttributeInfo._members.ManagedPeerType;

    protected AttributeInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe AttributeInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = AttributeInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      AttributeInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAttNumHandler()
    {
      if ((object) AttributeInfo.cb_getAttNum == null)
        AttributeInfo.cb_getAttNum = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(AttributeInfo.n_GetAttNum));
      return AttributeInfo.cb_getAttNum;
    }

    private static int n_GetAttNum(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).AttNum;
    }

    private static Delegate GetSetAttNum_IHandler()
    {
      if ((object) AttributeInfo.cb_setAttNum_I == null)
        AttributeInfo.cb_setAttNum_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(AttributeInfo.n_SetAttNum_I));
      return AttributeInfo.cb_setAttNum_I;
    }

    private static void n_SetAttNum_I(IntPtr jnienv, IntPtr native__this, int attNum)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).AttNum = attNum;
    }

    public virtual unsafe int AttNum
    {
      [Register("getAttNum", "()I", "GetGetAttNumHandler")] get
      {
        return AttributeInfo._members.InstanceMethods.InvokeVirtualInt32Method("getAttNum.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAttNum", "(I)V", "GetSetAttNum_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setAttNum.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetLengthHandler()
    {
      if ((object) AttributeInfo.cb_getLength == null)
        AttributeInfo.cb_getLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(AttributeInfo.n_GetLength));
      return AttributeInfo.cb_getLength;
    }

    private static int n_GetLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Length;
    }

    private static Delegate GetSetLength_IHandler()
    {
      if ((object) AttributeInfo.cb_setLength_I == null)
        AttributeInfo.cb_setLength_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(AttributeInfo.n_SetLength_I));
      return AttributeInfo.cb_setLength_I;
    }

    private static void n_SetLength_I(IntPtr jnienv, IntPtr native__this, int length)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Length = length;
    }

    public virtual unsafe int Length
    {
      [Register("getLength", "()I", "GetGetLengthHandler")] get
      {
        return AttributeInfo._members.InstanceMethods.InvokeVirtualInt32Method("getLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setLength", "(I)V", "GetSetLength_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setLength.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) AttributeInfo.cb_getOffset == null)
        AttributeInfo.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(AttributeInfo.n_GetOffset));
      return AttributeInfo.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) AttributeInfo.cb_setOffset_I == null)
        AttributeInfo.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(AttributeInfo.n_SetOffset_I));
      return AttributeInfo.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int offset)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Offset = offset;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return AttributeInfo._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetPropertyValHandler()
    {
      if ((object) AttributeInfo.cb_getPropertyVal == null)
        AttributeInfo.cb_getPropertyVal = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(AttributeInfo.n_GetPropertyVal));
      return AttributeInfo.cb_getPropertyVal;
    }

    private static int n_GetPropertyVal(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).PropertyVal;
    }

    private static Delegate GetSetPropertyVal_IHandler()
    {
      if ((object) AttributeInfo.cb_setPropertyVal_I == null)
        AttributeInfo.cb_setPropertyVal_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(AttributeInfo.n_SetPropertyVal_I));
      return AttributeInfo.cb_setPropertyVal_I;
    }

    private static void n_SetPropertyVal_I(IntPtr jnienv, IntPtr native__this, int propertyVal)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).PropertyVal = propertyVal;
    }

    public virtual unsafe int PropertyVal
    {
      [Register("getPropertyVal", "()I", "GetGetPropertyValHandler")] get
      {
        return AttributeInfo._members.InstanceMethods.InvokeVirtualInt32Method("getPropertyVal.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setPropertyVal", "(I)V", "GetSetPropertyVal_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setPropertyVal.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTypeHandler()
    {
      if ((object) AttributeInfo.cb_getType == null)
        AttributeInfo.cb_getType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AttributeInfo.n_GetType));
      return AttributeInfo.cb_getType;
    }

    private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Type);
    }

    private static Delegate GetSetType_Ljava_lang_String_Handler()
    {
      if ((object) AttributeInfo.cb_setType_Ljava_lang_String_ == null)
        AttributeInfo.cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AttributeInfo.n_SetType_Ljava_lang_String_));
      return AttributeInfo.cb_setType_Ljava_lang_String_;
    }

    private static void n_SetType_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_type)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Type = JNIEnv.GetString(native_type, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Type
    {
      [Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler")] get
      {
        JniObjectReference jniObjectReference = AttributeInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setType.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) AttributeInfo.cb_getValue == null)
        AttributeInfo.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AttributeInfo.n_GetValue));
      return AttributeInfo.cb_getValue;
    }

    private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Value);
    }

    private static Delegate GetSetValue_Ljava_lang_String_Handler()
    {
      if ((object) AttributeInfo.cb_setValue_Ljava_lang_String_ == null)
        AttributeInfo.cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AttributeInfo.n_SetValue_Ljava_lang_String_));
      return AttributeInfo.cb_setValue_Ljava_lang_String_;
    }

    private static void n_SetValue_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_value)
    {
      Object.GetObject<AttributeInfo>(jnienv, native__this, (JniHandleOwnership) 0).Value = JNIEnv.GetString(native_value, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Value
    {
      [Register("getValue", "()Ljava/lang/String;", "GetGetValueHandler")] get
      {
        JniObjectReference jniObjectReference = AttributeInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          AttributeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setValue.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }
  }
}
