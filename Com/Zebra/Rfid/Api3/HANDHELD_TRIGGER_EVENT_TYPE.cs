// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.HANDHELD_TRIGGER_EVENT_TYPE
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
  [Register("com/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE", DoNotGenerateAcw = true)]
  public class HANDHELD_TRIGGER_EVENT_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE", typeof (HANDHELD_TRIGGER_EVENT_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("HANDHELD_TRIGGER_PRESSED")]
    public static HANDHELD_TRIGGER_EVENT_TYPE? HandheldTriggerPressed
    {
      get
      {
        JniObjectReference objectValue = HANDHELD_TRIGGER_EVENT_TYPE._members.StaticFields.GetObjectValue("HANDHELD_TRIGGER_PRESSED.Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;");
        return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HANDHELD_TRIGGER_RELEASED")]
    public static HANDHELD_TRIGGER_EVENT_TYPE? HandheldTriggerReleased
    {
      get
      {
        JniObjectReference objectValue = HANDHELD_TRIGGER_EVENT_TYPE._members.StaticFields.GetObjectValue("HANDHELD_TRIGGER_RELEASED.Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;");
        return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return HANDHELD_TRIGGER_EVENT_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        HANDHELD_TRIGGER_EVENT_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = HANDHELD_TRIGGER_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => HANDHELD_TRIGGER_EVENT_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = HANDHELD_TRIGGER_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => HANDHELD_TRIGGER_EVENT_TYPE._members.ManagedPeerType;

    protected HANDHELD_TRIGGER_EVENT_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) HANDHELD_TRIGGER_EVENT_TYPE.cb_getValue == null)
        HANDHELD_TRIGGER_EVENT_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(HANDHELD_TRIGGER_EVENT_TYPE.n_GetValue));
      return HANDHELD_TRIGGER_EVENT_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return HANDHELD_TRIGGER_EVENT_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetHandleTriggerEventTypeValue", "(I)Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", "")]
    public static unsafe HANDHELD_TRIGGER_EVENT_TYPE? GetHandleTriggerEventTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = HANDHELD_TRIGGER_EVENT_TYPE._members.StaticMethods.InvokeObjectMethod("GetHandleTriggerEventTypeValue.(I)Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", jniArgumentValuePtr);
      return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) HANDHELD_TRIGGER_EVENT_TYPE.cb_equals_I == null)
        HANDHELD_TRIGGER_EVENT_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(HANDHELD_TRIGGER_EVENT_TYPE.n_Equals_I));
      return HANDHELD_TRIGGER_EVENT_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return HANDHELD_TRIGGER_EVENT_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
