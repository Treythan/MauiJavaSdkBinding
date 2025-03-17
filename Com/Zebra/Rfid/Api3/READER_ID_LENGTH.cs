// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.READER_ID_LENGTH
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
  [Register("com/zebra/rfid/api3/READER_ID_LENGTH", DoNotGenerateAcw = true)]
  public class READER_ID_LENGTH : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/READER_ID_LENGTH", typeof (READER_ID_LENGTH));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("EPC_LENGTH")]
    public static READER_ID_LENGTH? EpcLength
    {
      get
      {
        JniObjectReference objectValue = READER_ID_LENGTH._members.StaticFields.GetObjectValue("EPC_LENGTH.Lcom/zebra/rfid/api3/READER_ID_LENGTH;");
        return Object.GetObject<READER_ID_LENGTH>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MAC_LENGTH")]
    public static READER_ID_LENGTH? MacLength
    {
      get
      {
        JniObjectReference objectValue = READER_ID_LENGTH._members.StaticFields.GetObjectValue("MAC_LENGTH.Lcom/zebra/rfid/api3/READER_ID_LENGTH;");
        return Object.GetObject<READER_ID_LENGTH>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return READER_ID_LENGTH._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        READER_ID_LENGTH._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = READER_ID_LENGTH._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => READER_ID_LENGTH._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = READER_ID_LENGTH._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => READER_ID_LENGTH._members.ManagedPeerType;

    protected READER_ID_LENGTH(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) READER_ID_LENGTH.cb_getValue == null)
        READER_ID_LENGTH.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(READER_ID_LENGTH.n_GetValue));
      return READER_ID_LENGTH.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<READER_ID_LENGTH>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return READER_ID_LENGTH._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) READER_ID_LENGTH.cb_equals_I == null)
        READER_ID_LENGTH.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(READER_ID_LENGTH.n_Equals_I));
      return READER_ID_LENGTH.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<READER_ID_LENGTH>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return READER_ID_LENGTH._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
