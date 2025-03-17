// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.READER_ID_TYPE
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
  [Register("com/zebra/rfid/api3/READER_ID_TYPE", DoNotGenerateAcw = true)]
  public class READER_ID_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/READER_ID_TYPE", typeof (READER_ID_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("EPC_ID")]
    public static READER_ID_TYPE? EpcId
    {
      get
      {
        JniObjectReference objectValue = READER_ID_TYPE._members.StaticFields.GetObjectValue("EPC_ID.Lcom/zebra/rfid/api3/READER_ID_TYPE;");
        return Object.GetObject<READER_ID_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MAC_ADDRESS")]
    public static READER_ID_TYPE? MacAddress
    {
      get
      {
        JniObjectReference objectValue = READER_ID_TYPE._members.StaticFields.GetObjectValue("MAC_ADDRESS.Lcom/zebra/rfid/api3/READER_ID_TYPE;");
        return Object.GetObject<READER_ID_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return READER_ID_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        READER_ID_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = READER_ID_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => READER_ID_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = READER_ID_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => READER_ID_TYPE._members.ManagedPeerType;

    protected READER_ID_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) READER_ID_TYPE.cb_getValue == null)
        READER_ID_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(READER_ID_TYPE.n_GetValue));
      return READER_ID_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<READER_ID_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return READER_ID_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetReaderIDType", "(I)Lcom/zebra/rfid/api3/READER_ID_TYPE;", "")]
    public static unsafe READER_ID_TYPE? GetReaderIDType(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = READER_ID_TYPE._members.StaticMethods.InvokeObjectMethod("GetReaderIDType.(I)Lcom/zebra/rfid/api3/READER_ID_TYPE;", jniArgumentValuePtr);
      return Object.GetObject<READER_ID_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) READER_ID_TYPE.cb_equals_I == null)
        READER_ID_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(READER_ID_TYPE.n_Equals_I));
      return READER_ID_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<READER_ID_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return READER_ID_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
