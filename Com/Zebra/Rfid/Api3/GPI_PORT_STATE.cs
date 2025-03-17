// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.GPI_PORT_STATE
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
  [Register("com/zebra/rfid/api3/GPI_PORT_STATE", DoNotGenerateAcw = true)]
  public class GPI_PORT_STATE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/GPI_PORT_STATE", typeof (GPI_PORT_STATE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("GPI_PORT_STATE_HIGH")]
    public static GPI_PORT_STATE? GpiPortStateHigh
    {
      get
      {
        JniObjectReference objectValue = GPI_PORT_STATE._members.StaticFields.GetObjectValue("GPI_PORT_STATE_HIGH.Lcom/zebra/rfid/api3/GPI_PORT_STATE;");
        return Object.GetObject<GPI_PORT_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("GPI_PORT_STATE_LOW")]
    public static GPI_PORT_STATE? GpiPortStateLow
    {
      get
      {
        JniObjectReference objectValue = GPI_PORT_STATE._members.StaticFields.GetObjectValue("GPI_PORT_STATE_LOW.Lcom/zebra/rfid/api3/GPI_PORT_STATE;");
        return Object.GetObject<GPI_PORT_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("GPI_PORT_STATE_UNKNOWN")]
    public static GPI_PORT_STATE? GpiPortStateUnknown
    {
      get
      {
        JniObjectReference objectValue = GPI_PORT_STATE._members.StaticFields.GetObjectValue("GPI_PORT_STATE_UNKNOWN.Lcom/zebra/rfid/api3/GPI_PORT_STATE;");
        return Object.GetObject<GPI_PORT_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return GPI_PORT_STATE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        GPI_PORT_STATE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = GPI_PORT_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => GPI_PORT_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = GPI_PORT_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => GPI_PORT_STATE._members.ManagedPeerType;

    protected GPI_PORT_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) GPI_PORT_STATE.cb_getValue == null)
        GPI_PORT_STATE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GPI_PORT_STATE.n_GetValue));
      return GPI_PORT_STATE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GPI_PORT_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return GPI_PORT_STATE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetGpiPortState", "(I)Lcom/zebra/rfid/api3/GPI_PORT_STATE;", "")]
    public static unsafe GPI_PORT_STATE? GetGpiPortState(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = GPI_PORT_STATE._members.StaticMethods.InvokeObjectMethod("GetGpiPortState.(I)Lcom/zebra/rfid/api3/GPI_PORT_STATE;", jniArgumentValuePtr);
      return Object.GetObject<GPI_PORT_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) GPI_PORT_STATE.cb_equals_I == null)
        GPI_PORT_STATE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(GPI_PORT_STATE.n_Equals_I));
      return GPI_PORT_STATE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<GPI_PORT_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return GPI_PORT_STATE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
