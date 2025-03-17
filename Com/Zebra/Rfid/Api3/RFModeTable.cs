// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFModeTable
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
  [Register("com/zebra/rfid/api3/RFModeTable", DoNotGenerateAcw = true)]
  public class RFModeTable : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFModeTable", typeof (RFModeTable));
    private static Delegate? cb_getProtocolID;
    private static Delegate? cb_getRFModeTableEntryInfo_I;
    private static Delegate? cb_length;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFModeTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFModeTable._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFModeTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFModeTable._members.ManagedPeerType;

    protected RFModeTable(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetProtocolIDHandler()
    {
      if ((object) RFModeTable.cb_getProtocolID == null)
        RFModeTable.cb_getProtocolID = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTable.n_GetProtocolID));
      return RFModeTable.cb_getProtocolID;
    }

    private static int n_GetProtocolID(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTable>(jnienv, native__this, (JniHandleOwnership) 0).ProtocolID;
    }

    public virtual unsafe int ProtocolID
    {
      [Register("getProtocolID", "()I", "GetGetProtocolIDHandler")] get
      {
        return RFModeTable._members.InstanceMethods.InvokeVirtualInt32Method("getProtocolID.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetRFModeTableEntryInfo_IHandler()
    {
      if ((object) RFModeTable.cb_getRFModeTableEntryInfo_I == null)
        RFModeTable.cb_getRFModeTableEntryInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(RFModeTable.n_GetRFModeTableEntryInfo_I));
      return RFModeTable.cb_getRFModeTableEntryInfo_I;
    }

    private static IntPtr n_GetRFModeTableEntryInfo_I(
      IntPtr jnienv,
      IntPtr native__this,
      int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFModeTable>(jnienv, native__this, (JniHandleOwnership) 0).GetRFModeTableEntryInfo(index));
    }

    [Register("getRFModeTableEntryInfo", "(I)Lcom/zebra/rfid/api3/RFModeTableEntry;", "GetGetRFModeTableEntryInfo_IHandler")]
    public virtual unsafe RFModeTableEntry? GetRFModeTableEntryInfo(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = RFModeTable._members.InstanceMethods.InvokeVirtualObjectMethod("getRFModeTableEntryInfo.(I)Lcom/zebra/rfid/api3/RFModeTableEntry;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<RFModeTableEntry>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetLengthHandler()
    {
      if ((object) RFModeTable.cb_length == null)
        RFModeTable.cb_length = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFModeTable.n_Length));
      return RFModeTable.cb_length;
    }

    private static int n_Length(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RFModeTable>(jnienv, native__this, (JniHandleOwnership) 0).Length();
    }

    [Register("length", "()I", "GetLengthHandler")]
    public virtual unsafe int Length()
    {
      return RFModeTable._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
