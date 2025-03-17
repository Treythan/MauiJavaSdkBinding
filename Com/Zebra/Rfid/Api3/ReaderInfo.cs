// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ReaderInfo
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
  [Register("com/zebra/rfid/api3/ReaderInfo", DoNotGenerateAcw = true)]
  public class ReaderInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ReaderInfo", typeof (ReaderInfo));
    private static Delegate? cb_getContact;
    private static Delegate? cb_setContact_Ljava_lang_String_;
    private static Delegate? cb_getDescription;
    private static Delegate? cb_setDescription_Ljava_lang_String_;
    private static Delegate? cb_getLocation;
    private static Delegate? cb_setLocation_Ljava_lang_String_;
    private static Delegate? cb_getName;
    private static Delegate? cb_setName_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ReaderInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ReaderInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ReaderInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ReaderInfo._members.ManagedPeerType;

    protected ReaderInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ReaderInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ReaderInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ReaderInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
    public unsafe ReaderInfo(string? name, string? description, string? location, string? contact)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num1 = JNIEnv.NewString(name);
      IntPtr num2 = JNIEnv.NewString(description);
      IntPtr num3 = JNIEnv.NewString(location);
      IntPtr num4 = JNIEnv.NewString(contact);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(num3),
          new JniArgumentValue(num4)
        };
        JniObjectReference instance = ReaderInfo._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        ReaderInfo._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        JNIEnv.DeleteLocalRef(num3);
        JNIEnv.DeleteLocalRef(num4);
      }
    }

    private static Delegate GetGetContactHandler()
    {
      if ((object) ReaderInfo.cb_getContact == null)
        ReaderInfo.cb_getContact = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderInfo.n_GetContact));
      return ReaderInfo.cb_getContact;
    }

    private static IntPtr n_GetContact(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Contact);
    }

    private static Delegate GetSetContact_Ljava_lang_String_Handler()
    {
      if ((object) ReaderInfo.cb_setContact_Ljava_lang_String_ == null)
        ReaderInfo.cb_setContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderInfo.n_SetContact_Ljava_lang_String_));
      return ReaderInfo.cb_setContact_Ljava_lang_String_;
    }

    private static void n_SetContact_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_contact)
    {
      Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Contact = JNIEnv.GetString(native_contact, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Contact
    {
      [Register("getContact", "()Ljava/lang/String;", "GetGetContactHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getContact.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setContact", "(Ljava/lang/String;)V", "GetSetContact_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setContact.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetDescriptionHandler()
    {
      if ((object) ReaderInfo.cb_getDescription == null)
        ReaderInfo.cb_getDescription = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderInfo.n_GetDescription));
      return ReaderInfo.cb_getDescription;
    }

    private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Description);
    }

    private static Delegate GetSetDescription_Ljava_lang_String_Handler()
    {
      if ((object) ReaderInfo.cb_setDescription_Ljava_lang_String_ == null)
        ReaderInfo.cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderInfo.n_SetDescription_Ljava_lang_String_));
      return ReaderInfo.cb_setDescription_Ljava_lang_String_;
    }

    private static void n_SetDescription_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_description)
    {
      Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Description = JNIEnv.GetString(native_description, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Description
    {
      [Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getDescription.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setDescription.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetLocationHandler()
    {
      if ((object) ReaderInfo.cb_getLocation == null)
        ReaderInfo.cb_getLocation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderInfo.n_GetLocation));
      return ReaderInfo.cb_getLocation;
    }

    private static IntPtr n_GetLocation(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Location);
    }

    private static Delegate GetSetLocation_Ljava_lang_String_Handler()
    {
      if ((object) ReaderInfo.cb_setLocation_Ljava_lang_String_ == null)
        ReaderInfo.cb_setLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderInfo.n_SetLocation_Ljava_lang_String_));
      return ReaderInfo.cb_setLocation_Ljava_lang_String_;
    }

    private static void n_SetLocation_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_location)
    {
      Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Location = JNIEnv.GetString(native_location, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Location
    {
      [Register("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getLocation.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setLocation", "(Ljava/lang/String;)V", "GetSetLocation_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setLocation.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetGetNameHandler()
    {
      if ((object) ReaderInfo.cb_getName == null)
        ReaderInfo.cb_getName = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(ReaderInfo.n_GetName));
      return ReaderInfo.cb_getName;
    }

    private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Name);
    }

    private static Delegate GetSetName_Ljava_lang_String_Handler()
    {
      if ((object) ReaderInfo.cb_setName_Ljava_lang_String_ == null)
        ReaderInfo.cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(ReaderInfo.n_SetName_Ljava_lang_String_));
      return ReaderInfo.cb_setName_Ljava_lang_String_;
    }

    private static void n_SetName_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_m_sName)
    {
      Object.GetObject<ReaderInfo>(jnienv, native__this, (JniHandleOwnership) 0).Name = JNIEnv.GetString(native_m_sName, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Name
    {
      [Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get
      {
        JniObjectReference jniObjectReference = ReaderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          ReaderInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setName.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }
  }
}
