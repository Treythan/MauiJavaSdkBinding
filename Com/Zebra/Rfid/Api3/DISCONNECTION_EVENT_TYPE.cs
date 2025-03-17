// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.DISCONNECTION_EVENT_TYPE
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
  [Register("com/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE", DoNotGenerateAcw = true)]
  public class DISCONNECTION_EVENT_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE", typeof (DISCONNECTION_EVENT_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("CONNECTION_LOST")]
    public static DISCONNECTION_EVENT_TYPE? ConnectionLost
    {
      get
      {
        JniObjectReference objectValue = DISCONNECTION_EVENT_TYPE._members.StaticFields.GetObjectValue("CONNECTION_LOST.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;");
        return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return DISCONNECTION_EVENT_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        DISCONNECTION_EVENT_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("READER_EXCEPTION")]
    public static DISCONNECTION_EVENT_TYPE? ReaderException
    {
      get
      {
        JniObjectReference objectValue = DISCONNECTION_EVENT_TYPE._members.StaticFields.GetObjectValue("READER_EXCEPTION.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;");
        return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READER_INITIATED_DISCONNECTION")]
    public static DISCONNECTION_EVENT_TYPE? ReaderInitiatedDisconnection
    {
      get
      {
        JniObjectReference objectValue = DISCONNECTION_EVENT_TYPE._members.StaticFields.GetObjectValue("READER_INITIATED_DISCONNECTION.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;");
        return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DISCONNECTION_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DISCONNECTION_EVENT_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DISCONNECTION_EVENT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DISCONNECTION_EVENT_TYPE._members.ManagedPeerType;

    protected DISCONNECTION_EVENT_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) DISCONNECTION_EVENT_TYPE.cb_getValue == null)
        DISCONNECTION_EVENT_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(DISCONNECTION_EVENT_TYPE.n_GetValue));
      return DISCONNECTION_EVENT_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DISCONNECTION_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return DISCONNECTION_EVENT_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetDisconnectionEventTypeValue", "(I)Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", "")]
    public static unsafe DISCONNECTION_EVENT_TYPE? GetDisconnectionEventTypeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = DISCONNECTION_EVENT_TYPE._members.StaticMethods.InvokeObjectMethod("GetDisconnectionEventTypeValue.(I)Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", jniArgumentValuePtr);
      return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) DISCONNECTION_EVENT_TYPE.cb_equals_I == null)
        DISCONNECTION_EVENT_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(DISCONNECTION_EVENT_TYPE.n_Equals_I));
      return DISCONNECTION_EVENT_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<DISCONNECTION_EVENT_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return DISCONNECTION_EVENT_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
