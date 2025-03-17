// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SetAttribute
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
  [Register("com/zebra/rfid/api3/SetAttribute", DoNotGenerateAcw = true)]
  public class SetAttribute : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SetAttribute", typeof (SetAttribute));
    private static Delegate? cb_getAttnum;
    private static Delegate? cb_setAttnum_I;
    private static Delegate? cb_getAtttype;
    private static Delegate? cb_setAtttype_Ljava_lang_String_;
    private static Delegate? cb_getAttvalue;
    private static Delegate? cb_setAttvalue_Ljava_lang_String_;
    private static Delegate? cb_getOffset;
    private static Delegate? cb_setOffset_I;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SetAttribute._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SetAttribute._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SetAttribute._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SetAttribute._members.ManagedPeerType;

    protected SetAttribute(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SetAttribute()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SetAttribute._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SetAttribute._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(ILjava/lang/String;Ljava/lang/String;I)V", "")]
    public unsafe SetAttribute(int attnum, string? atttype, string? attvalue, int offset)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(atttype);
      IntPtr num2 = JNIEnv.NewString(attvalue);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(attnum),
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(offset)
        };
        JniObjectReference instance = SetAttribute._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Ljava/lang/String;I)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        SetAttribute._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Ljava/lang/String;I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetGetAttnumHandler()
    {
      if ((object) SetAttribute.cb_getAttnum == null)
        SetAttribute.cb_getAttnum = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SetAttribute.n_GetAttnum));
      return SetAttribute.cb_getAttnum;
    }

    private static int n_GetAttnum(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Attnum;
    }

    private static Delegate GetSetAttnum_IHandler()
    {
      if ((object) SetAttribute.cb_setAttnum_I == null)
        SetAttribute.cb_setAttnum_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SetAttribute.n_SetAttnum_I));
      return SetAttribute.cb_setAttnum_I;
    }

    private static void n_SetAttnum_I(IntPtr jnienv, IntPtr native__this, int attnum)
    {
      Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Attnum = attnum;
    }

    public virtual unsafe int Attnum
    {
      [Register("getAttnum", "()I", "GetGetAttnumHandler")] get
      {
        return SetAttribute._members.InstanceMethods.InvokeVirtualInt32Method("getAttnum.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAttnum", "(I)V", "GetSetAttnum_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SetAttribute._members.InstanceMethods.InvokeVirtualVoidMethod("setAttnum.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetAtttypeHandler()
    {
      if ((object) SetAttribute.cb_getAtttype == null)
        SetAttribute.cb_getAtttype = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SetAttribute.n_GetAtttype));
      return SetAttribute.cb_getAtttype;
    }

    private static IntPtr n_GetAtttype(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Atttype);
    }

    private static Delegate GetSetAtttype_Ljava_lang_String_Handler()
    {
      if ((object) SetAttribute.cb_setAtttype_Ljava_lang_String_ == null)
        SetAttribute.cb_setAtttype_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SetAttribute.n_SetAtttype_Ljava_lang_String_));
      return SetAttribute.cb_setAtttype_Ljava_lang_String_;
    }

    private static void n_SetAtttype_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_atttype)
    {
      Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Atttype = JNIEnv.GetString(native_atttype, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Atttype
    {
      [Register("getAtttype", "()Ljava/lang/String;", "GetGetAtttypeHandler")] get
      {
        JniObjectReference jniObjectReference = SetAttribute._members.InstanceMethods.InvokeVirtualObjectMethod("getAtttype.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAtttype", "(Ljava/lang/String;)V", "GetSetAtttype_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          SetAttribute._members.InstanceMethods.InvokeVirtualVoidMethod("setAtttype.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetAttvalueHandler()
    {
      if ((object) SetAttribute.cb_getAttvalue == null)
        SetAttribute.cb_getAttvalue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SetAttribute.n_GetAttvalue));
      return SetAttribute.cb_getAttvalue;
    }

    private static IntPtr n_GetAttvalue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Attvalue);
    }

    private static Delegate GetSetAttvalue_Ljava_lang_String_Handler()
    {
      if ((object) SetAttribute.cb_setAttvalue_Ljava_lang_String_ == null)
        SetAttribute.cb_setAttvalue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(SetAttribute.n_SetAttvalue_Ljava_lang_String_));
      return SetAttribute.cb_setAttvalue_Ljava_lang_String_;
    }

    private static void n_SetAttvalue_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_attvalue)
    {
      Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Attvalue = JNIEnv.GetString(native_attvalue, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Attvalue
    {
      [Register("getAttvalue", "()Ljava/lang/String;", "GetGetAttvalueHandler")] get
      {
        JniObjectReference jniObjectReference = SetAttribute._members.InstanceMethods.InvokeVirtualObjectMethod("getAttvalue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAttvalue", "(Ljava/lang/String;)V", "GetSetAttvalue_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          SetAttribute._members.InstanceMethods.InvokeVirtualVoidMethod("setAttvalue.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetOffsetHandler()
    {
      if ((object) SetAttribute.cb_getOffset == null)
        SetAttribute.cb_getOffset = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SetAttribute.n_GetOffset));
      return SetAttribute.cb_getOffset;
    }

    private static int n_GetOffset(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Offset;
    }

    private static Delegate GetSetOffset_IHandler()
    {
      if ((object) SetAttribute.cb_setOffset_I == null)
        SetAttribute.cb_setOffset_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(SetAttribute.n_SetOffset_I));
      return SetAttribute.cb_setOffset_I;
    }

    private static void n_SetOffset_I(IntPtr jnienv, IntPtr native__this, int offset)
    {
      Object.GetObject<SetAttribute>(jnienv, native__this, (JniHandleOwnership) 0).Offset = offset;
    }

    public virtual unsafe int Offset
    {
      [Register("getOffset", "()I", "GetGetOffsetHandler")] get
      {
        return SetAttribute._members.InstanceMethods.InvokeVirtualInt32Method("getOffset.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOffset", "(I)V", "GetSetOffset_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        SetAttribute._members.InstanceMethods.InvokeVirtualVoidMethod("setOffset.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
