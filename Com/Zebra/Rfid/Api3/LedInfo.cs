// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LedInfo
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
  [Register("com/zebra/rfid/api3/LedInfo", DoNotGenerateAcw = true)]
  public class LedInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LedInfo", typeof (LedInfo));
    private static Delegate? cb_getBlink;
    private static Delegate? cb_setBlink_Z;
    private static Delegate? cb_getDurationSeconds;
    private static Delegate? cb_setDurationSeconds_I;
    private static Delegate? cb_getLEDColor;
    private static Delegate? cb_setLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LedInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LedInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LedInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LedInfo._members.ManagedPeerType;

    protected LedInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe LedInfo()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = LedInfo._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      LedInfo._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/LED_COLOR;IZ)V", "")]
    public unsafe LedInfo(LED_COLOR? ledColor, int durationSeconds, bool blink)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(ledColor == null ? IntPtr.Zero : ledColor.Handle),
          new JniArgumentValue(durationSeconds),
          new JniArgumentValue(blink)
        };
        JniObjectReference instance = LedInfo._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/LED_COLOR;IZ)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        LedInfo._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/LED_COLOR;IZ)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) ledColor);
      }
    }

    private static Delegate GetGetBlinkHandler()
    {
      if ((object) LedInfo.cb_getBlink == null)
        LedInfo.cb_getBlink = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(LedInfo.n_GetBlink));
      return LedInfo.cb_getBlink;
    }

    private static bool n_GetBlink(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).Blink;
    }

    private static Delegate GetSetBlink_ZHandler()
    {
      if ((object) LedInfo.cb_setBlink_Z == null)
        LedInfo.cb_setBlink_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(LedInfo.n_SetBlink_Z));
      return LedInfo.cb_setBlink_Z;
    }

    private static void n_SetBlink_Z(IntPtr jnienv, IntPtr native__this, bool blink)
    {
      Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).Blink = blink;
    }

    public virtual unsafe bool Blink
    {
      [Register("getBlink", "()Z", "GetGetBlinkHandler")] get
      {
        return LedInfo._members.InstanceMethods.InvokeVirtualBooleanMethod("getBlink.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setBlink", "(Z)V", "GetSetBlink_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LedInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setBlink.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetDurationSecondsHandler()
    {
      if ((object) LedInfo.cb_getDurationSeconds == null)
        LedInfo.cb_getDurationSeconds = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LedInfo.n_GetDurationSeconds));
      return LedInfo.cb_getDurationSeconds;
    }

    private static int n_GetDurationSeconds(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).DurationSeconds;
    }

    private static Delegate GetSetDurationSeconds_IHandler()
    {
      if ((object) LedInfo.cb_setDurationSeconds_I == null)
        LedInfo.cb_setDurationSeconds_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(LedInfo.n_SetDurationSeconds_I));
      return LedInfo.cb_setDurationSeconds_I;
    }

    private static void n_SetDurationSeconds_I(
      IntPtr jnienv,
      IntPtr native__this,
      int durationSeconds)
    {
      Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).DurationSeconds = durationSeconds;
    }

    public virtual unsafe int DurationSeconds
    {
      [Register("getDurationSeconds", "()I", "GetGetDurationSecondsHandler")] get
      {
        return LedInfo._members.InstanceMethods.InvokeVirtualInt32Method("getDurationSeconds.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDurationSeconds", "(I)V", "GetSetDurationSeconds_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        LedInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setDurationSeconds.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetLEDColorHandler()
    {
      if ((object) LedInfo.cb_getLEDColor == null)
        LedInfo.cb_getLEDColor = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(LedInfo.n_GetLEDColor));
      return LedInfo.cb_getLEDColor;
    }

    private static IntPtr n_GetLEDColor(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).LEDColor);
    }

    private static Delegate GetSetLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_Handler()
    {
      if ((object) LedInfo.cb_setLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_ == null)
        LedInfo.cb_setLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(LedInfo.n_SetLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_));
      return LedInfo.cb_setLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_;
    }

    private static void n_SetLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_ledColor)
    {
      Object.GetObject<LedInfo>(jnienv, native__this, (JniHandleOwnership) 0).LEDColor = Object.GetObject<LED_COLOR>(native_ledColor, (JniHandleOwnership) 0);
    }

    public virtual unsafe LED_COLOR? LEDColor
    {
      [Register("getLEDColor", "()Lcom/zebra/rfid/api3/LED_COLOR;", "GetGetLEDColorHandler")] get
      {
        JniObjectReference jniObjectReference = LedInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getLEDColor.()Lcom/zebra/rfid/api3/LED_COLOR;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setLEDColor", "(Lcom/zebra/rfid/api3/LED_COLOR;)V", "GetSetLEDColor_Lcom_zebra_rfid_api3_LED_COLOR_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          LedInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setLEDColor.(Lcom/zebra/rfid/api3/LED_COLOR;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }
  }
}
