// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CRADLE_EVENT
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
  [Register("com/zebra/rfid/api3/CRADLE_EVENT", DoNotGenerateAcw = true)]
  public class CRADLE_EVENT : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CRADLE_EVENT", typeof (CRADLE_EVENT));
    private static Delegate? cb_getCause;
    private static Delegate? cb_setCause_Ljava_lang_String_;
    private static Delegate? cb_isOnCradle;
    private static Delegate? cb_setOnCradle_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CRADLE_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CRADLE_EVENT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CRADLE_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CRADLE_EVENT._members.ManagedPeerType;

    protected CRADLE_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe CRADLE_EVENT()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = CRADLE_EVENT._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      CRADLE_EVENT._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCauseHandler()
    {
      if ((object) CRADLE_EVENT.cb_getCause == null)
        CRADLE_EVENT.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(CRADLE_EVENT.n_GetCause));
      return CRADLE_EVENT.cb_getCause;
    }

    private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<CRADLE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
    }

    private static Delegate GetSetCause_Ljava_lang_String_Handler()
    {
      if ((object) CRADLE_EVENT.cb_setCause_Ljava_lang_String_ == null)
        CRADLE_EVENT.cb_setCause_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(CRADLE_EVENT.n_SetCause_Ljava_lang_String_));
      return CRADLE_EVENT.cb_setCause_Ljava_lang_String_;
    }

    private static void n_SetCause_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_cause)
    {
      Object.GetObject<CRADLE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Cause = JNIEnv.GetString(native_cause, (JniHandleOwnership) 0);
    }

    public virtual unsafe string? Cause
    {
      [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
      {
        JniObjectReference jniObjectReference = CRADLE_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setCause", "(Ljava/lang/String;)V", "GetSetCause_Ljava_lang_String_Handler")] set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          CRADLE_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setCause.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    private static Delegate GetIsOnCradleHandler()
    {
      if ((object) CRADLE_EVENT.cb_isOnCradle == null)
        CRADLE_EVENT.cb_isOnCradle = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(CRADLE_EVENT.n_IsOnCradle));
      return CRADLE_EVENT.cb_isOnCradle;
    }

    private static bool n_IsOnCradle(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CRADLE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).OnCradle;
    }

    private static Delegate GetSetOnCradle_ZHandler()
    {
      if ((object) CRADLE_EVENT.cb_setOnCradle_Z == null)
        CRADLE_EVENT.cb_setOnCradle_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(CRADLE_EVENT.n_SetOnCradle_Z));
      return CRADLE_EVENT.cb_setOnCradle_Z;
    }

    private static void n_SetOnCradle_Z(IntPtr jnienv, IntPtr native__this, bool onCradle)
    {
      Object.GetObject<CRADLE_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).OnCradle = onCradle;
    }

    public virtual unsafe bool OnCradle
    {
      [Register("isOnCradle", "()Z", "GetIsOnCradleHandler")] get
      {
        return CRADLE_EVENT._members.InstanceMethods.InvokeVirtualBooleanMethod("isOnCradle.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setOnCradle", "(Z)V", "GetSetOnCradle_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CRADLE_EVENT._members.InstanceMethods.InvokeVirtualVoidMethod("setOnCradle.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
