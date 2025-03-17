// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BEEPER_VOLUME
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
  [Register("com/zebra/rfid/api3/BEEPER_VOLUME", DoNotGenerateAcw = true)]
  public class BEEPER_VOLUME : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BEEPER_VOLUME", typeof (BEEPER_VOLUME));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("HIGH_BEEP")]
    public static BEEPER_VOLUME? HighBeep
    {
      get
      {
        JniObjectReference objectValue = BEEPER_VOLUME._members.StaticFields.GetObjectValue("HIGH_BEEP.Lcom/zebra/rfid/api3/BEEPER_VOLUME;");
        return Object.GetObject<BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOW_BEEP")]
    public static BEEPER_VOLUME? LowBeep
    {
      get
      {
        JniObjectReference objectValue = BEEPER_VOLUME._members.StaticFields.GetObjectValue("LOW_BEEP.Lcom/zebra/rfid/api3/BEEPER_VOLUME;");
        return Object.GetObject<BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MEDIUM_BEEP")]
    public static BEEPER_VOLUME? MediumBeep
    {
      get
      {
        JniObjectReference objectValue = BEEPER_VOLUME._members.StaticFields.GetObjectValue("MEDIUM_BEEP.Lcom/zebra/rfid/api3/BEEPER_VOLUME;");
        return Object.GetObject<BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => BEEPER_VOLUME._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set
      {
        BEEPER_VOLUME._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("QUIET_BEEP")]
    public static BEEPER_VOLUME? QuietBeep
    {
      get
      {
        JniObjectReference objectValue = BEEPER_VOLUME._members.StaticFields.GetObjectValue("QUIET_BEEP.Lcom/zebra/rfid/api3/BEEPER_VOLUME;");
        return Object.GetObject<BEEPER_VOLUME>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BEEPER_VOLUME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BEEPER_VOLUME._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BEEPER_VOLUME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BEEPER_VOLUME._members.ManagedPeerType;

    protected BEEPER_VOLUME(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) BEEPER_VOLUME.cb_getValue == null)
        BEEPER_VOLUME.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BEEPER_VOLUME.n_GetValue));
      return BEEPER_VOLUME.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BEEPER_VOLUME>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return BEEPER_VOLUME._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) BEEPER_VOLUME.cb_equals_I == null)
        BEEPER_VOLUME.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(BEEPER_VOLUME.n_Equals_I));
      return BEEPER_VOLUME.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<BEEPER_VOLUME>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return BEEPER_VOLUME._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
