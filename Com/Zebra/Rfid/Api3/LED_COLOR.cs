// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LED_COLOR
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
  [Register("com/zebra/rfid/api3/LED_COLOR", DoNotGenerateAcw = true)]
  public class LED_COLOR : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LED_COLOR", typeof (LED_COLOR));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("LED_GREEN")]
    public static LED_COLOR? LedGreen
    {
      get
      {
        JniObjectReference objectValue = LED_COLOR._members.StaticFields.GetObjectValue("LED_GREEN.Lcom/zebra/rfid/api3/LED_COLOR;");
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LED_OFF")]
    public static LED_COLOR? LedOff
    {
      get
      {
        JniObjectReference objectValue = LED_COLOR._members.StaticFields.GetObjectValue("LED_OFF.Lcom/zebra/rfid/api3/LED_COLOR;");
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LED_RED")]
    public static LED_COLOR? LedRed
    {
      get
      {
        JniObjectReference objectValue = LED_COLOR._members.StaticFields.GetObjectValue("LED_RED.Lcom/zebra/rfid/api3/LED_COLOR;");
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LED_YELLOW")]
    public static LED_COLOR? LedYellow
    {
      get
      {
        JniObjectReference objectValue = LED_COLOR._members.StaticFields.GetObjectValue("LED_YELLOW.Lcom/zebra/rfid/api3/LED_COLOR;");
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => LED_COLOR._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => LED_COLOR._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LED_COLOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LED_COLOR._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LED_COLOR._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LED_COLOR._members.ManagedPeerType;

    protected LED_COLOR(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) LED_COLOR.cb_getValue == null)
        LED_COLOR.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(LED_COLOR.n_GetValue));
      return LED_COLOR.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LED_COLOR>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return LED_COLOR._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) LED_COLOR.cb_equals_I == null)
        LED_COLOR.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(LED_COLOR.n_Equals_I));
      return LED_COLOR.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<LED_COLOR>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return LED_COLOR._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
