// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.HEALTH_STATUS
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
  [Register("com/zebra/rfid/api3/HEALTH_STATUS", DoNotGenerateAcw = true)]
  public class HEALTH_STATUS : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/HEALTH_STATUS", typeof (HEALTH_STATUS));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("DOWN")]
    public static HEALTH_STATUS? Down
    {
      get
      {
        JniObjectReference objectValue = HEALTH_STATUS._members.StaticFields.GetObjectValue("DOWN.Lcom/zebra/rfid/api3/HEALTH_STATUS;");
        return Object.GetObject<HEALTH_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => HEALTH_STATUS._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set
      {
        HEALTH_STATUS._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("UP")]
    public static HEALTH_STATUS? Up
    {
      get
      {
        JniObjectReference objectValue = HEALTH_STATUS._members.StaticFields.GetObjectValue("UP.Lcom/zebra/rfid/api3/HEALTH_STATUS;");
        return Object.GetObject<HEALTH_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = HEALTH_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => HEALTH_STATUS._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = HEALTH_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => HEALTH_STATUS._members.ManagedPeerType;

    protected HEALTH_STATUS(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) HEALTH_STATUS.cb_getValue == null)
        HEALTH_STATUS.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(HEALTH_STATUS.n_GetValue));
      return HEALTH_STATUS.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<HEALTH_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return HEALTH_STATUS._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetHealthStatusState", "(I)Lcom/zebra/rfid/api3/HEALTH_STATUS;", "")]
    public static unsafe HEALTH_STATUS? GetHealthStatusState(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = HEALTH_STATUS._members.StaticMethods.InvokeObjectMethod("GetHealthStatusState.(I)Lcom/zebra/rfid/api3/HEALTH_STATUS;", jniArgumentValuePtr);
      return Object.GetObject<HEALTH_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) HEALTH_STATUS.cb_equals_I == null)
        HEALTH_STATUS.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(HEALTH_STATUS.n_Equals_I));
      return HEALTH_STATUS.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<HEALTH_STATUS>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return HEALTH_STATUS._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
