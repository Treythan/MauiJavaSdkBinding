// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BATTERY_EVENT
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
  [Register("com/zebra/rfid/api3/BATTERY_EVENT", DoNotGenerateAcw = true)]
  public class BATTERY_EVENT : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BATTERY_EVENT", typeof (BATTERY_EVENT));
    private static Delegate? cb_getCause;
    private static Delegate? cb_getCharging;
    private static Delegate? cb_getLevel;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BATTERY_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BATTERY_EVENT._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BATTERY_EVENT._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BATTERY_EVENT._members.ManagedPeerType;

    protected BATTERY_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe BATTERY_EVENT()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = BATTERY_EVENT._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      BATTERY_EVENT._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetCauseHandler()
    {
      if ((object) BATTERY_EVENT.cb_getCause == null)
        BATTERY_EVENT.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(BATTERY_EVENT.n_GetCause));
      return BATTERY_EVENT.cb_getCause;
    }

    private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<BATTERY_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
    }

    public virtual unsafe string? Cause
    {
      [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
      {
        JniObjectReference jniObjectReference = BATTERY_EVENT._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetChargingHandler()
    {
      if ((object) BATTERY_EVENT.cb_getCharging == null)
        BATTERY_EVENT.cb_getCharging = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(BATTERY_EVENT.n_GetCharging));
      return BATTERY_EVENT.cb_getCharging;
    }

    private static bool n_GetCharging(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BATTERY_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Charging;
    }

    public virtual unsafe bool Charging
    {
      [Register("getCharging", "()Z", "GetGetChargingHandler")] get
      {
        return BATTERY_EVENT._members.InstanceMethods.InvokeVirtualBooleanMethod("getCharging.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetLevelHandler()
    {
      if ((object) BATTERY_EVENT.cb_getLevel == null)
        BATTERY_EVENT.cb_getLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BATTERY_EVENT.n_GetLevel));
      return BATTERY_EVENT.cb_getLevel;
    }

    private static int n_GetLevel(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BATTERY_EVENT>(jnienv, native__this, (JniHandleOwnership) 0).Level;
    }

    public virtual unsafe int Level
    {
      [Register("getLevel", "()I", "GetGetLevelHandler")] get
      {
        return BATTERY_EVENT._members.InstanceMethods.InvokeVirtualInt32Method("getLevel.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
