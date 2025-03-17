// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CONNECTION_STATE
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
  [Register("com/zebra/rfid/api3/CONNECTION_STATE", DoNotGenerateAcw = true)]
  public class CONNECTION_STATE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CONNECTION_STATE", typeof (CONNECTION_STATE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("CONNECTED")]
    public static CONNECTION_STATE? Connected
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("CONNECTED.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CONNECTING")]
    public static CONNECTION_STATE? Connecting
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("CONNECTING.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CONNECTION_CLOSE_NOTIFIED")]
    public static CONNECTION_STATE? ConnectionCloseNotified
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("CONNECTION_CLOSE_NOTIFIED.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CONNECTION_IDLE")]
    public static CONNECTION_STATE? ConnectionIdle
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("CONNECTION_IDLE.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DEINITIALIZED")]
    public static CONNECTION_STATE? Deinitialized
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("DEINITIALIZED.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DISCONNECTING_FROM_HOST")]
    public static CONNECTION_STATE? DisconnectingFromHost
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("DISCONNECTING_FROM_HOST.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("KEEP_ALIVE_TIMEOUT")]
    public static CONNECTION_STATE? KeepAliveTimeout
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("KEEP_ALIVE_TIMEOUT.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return CONNECTION_STATE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        CONNECTION_STATE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("RECEIVE_ERROR")]
    public static CONNECTION_STATE? ReceiveError
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("RECEIVE_ERROR.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RECONNECTING")]
    public static CONNECTION_STATE? Reconnecting
    {
      get
      {
        JniObjectReference objectValue = CONNECTION_STATE._members.StaticFields.GetObjectValue("RECONNECTING.Lcom/zebra/rfid/api3/CONNECTION_STATE;");
        return Object.GetObject<CONNECTION_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = CONNECTION_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => CONNECTION_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = CONNECTION_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => CONNECTION_STATE._members.ManagedPeerType;

    protected CONNECTION_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) CONNECTION_STATE.cb_getValue == null)
        CONNECTION_STATE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(CONNECTION_STATE.n_GetValue));
      return CONNECTION_STATE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<CONNECTION_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return CONNECTION_STATE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) CONNECTION_STATE.cb_equals_I == null)
        CONNECTION_STATE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(CONNECTION_STATE.n_Equals_I));
      return CONNECTION_STATE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<CONNECTION_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return CONNECTION_STATE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
