// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.DISCONNECTION_EVENT_DATA
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
  [Register("com/zebra/rfid/api3/DISCONNECTION_EVENT_DATA", DoNotGenerateAcw = true)]
  public class DISCONNECTION_EVENT_DATA : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DISCONNECTION_EVENT_DATA", typeof (DISCONNECTION_EVENT_DATA));
    private static Delegate? cb_getreadername;

    [Register("eventInfo")]
    public DISCONNECTION_EVENT_TYPE? EventInfo
    {
      get
      {
        JniObjectReference objectValue = DISCONNECTION_EVENT_DATA._members.InstanceFields.GetObjectValue("eventInfo.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", (IJavaPeerable) this);
        return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          DISCONNECTION_EVENT_DATA._members.InstanceFields.SetValue("eventInfo.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = DISCONNECTION_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DISCONNECTION_EVENT_DATA._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DISCONNECTION_EVENT_DATA._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DISCONNECTION_EVENT_DATA._members.ManagedPeerType;

    protected DISCONNECTION_EVENT_DATA(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe DISCONNECTION_EVENT_DATA()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = DISCONNECTION_EVENT_DATA._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      DISCONNECTION_EVENT_DATA._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetreadernameHandler()
    {
      if ((object) DISCONNECTION_EVENT_DATA.cb_getreadername == null)
        DISCONNECTION_EVENT_DATA.cb_getreadername = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(DISCONNECTION_EVENT_DATA.n_Getreadername));
      return DISCONNECTION_EVENT_DATA.cb_getreadername;
    }

    private static IntPtr n_Getreadername(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<DISCONNECTION_EVENT_DATA>(jnienv, native__this, (JniHandleOwnership) 0).Getreadername());
    }

    [Register("getreadername", "()Ljava/lang/String;", "GetGetreadernameHandler")]
    public virtual unsafe string? Getreadername()
    {
      JniObjectReference jniObjectReference = DISCONNECTION_EVENT_DATA._members.InstanceMethods.InvokeVirtualObjectMethod("getreadername.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
