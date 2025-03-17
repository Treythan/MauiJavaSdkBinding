// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SL_FLAG
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
  [Register("com/zebra/rfid/api3/SL_FLAG", DoNotGenerateAcw = true)]
  public class SL_FLAG : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SL_FLAG", typeof (SL_FLAG));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get => SL_FLAG._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => SL_FLAG._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("SL_ALL")]
    public static SL_FLAG? SlAll
    {
      get
      {
        JniObjectReference objectValue = SL_FLAG._members.StaticFields.GetObjectValue("SL_ALL.Lcom/zebra/rfid/api3/SL_FLAG;");
        return Object.GetObject<SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_FLAG_ASSERTED")]
    public static SL_FLAG? SlFlagAsserted
    {
      get
      {
        JniObjectReference objectValue = SL_FLAG._members.StaticFields.GetObjectValue("SL_FLAG_ASSERTED.Lcom/zebra/rfid/api3/SL_FLAG;");
        return Object.GetObject<SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SL_FLAG_DEASSERTED")]
    public static SL_FLAG? SlFlagDeasserted
    {
      get
      {
        JniObjectReference objectValue = SL_FLAG._members.StaticFields.GetObjectValue("SL_FLAG_DEASSERTED.Lcom/zebra/rfid/api3/SL_FLAG;");
        return Object.GetObject<SL_FLAG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SL_FLAG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SL_FLAG._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SL_FLAG._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SL_FLAG._members.ManagedPeerType;

    protected SL_FLAG(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) SL_FLAG.cb_getValue == null)
        SL_FLAG.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SL_FLAG.n_GetValue));
      return SL_FLAG.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SL_FLAG>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return SL_FLAG._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetSLFlag", "(I)Lcom/zebra/rfid/api3/SL_FLAG;", "")]
    public static unsafe SL_FLAG? GetSLFlag(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = SL_FLAG._members.StaticMethods.InvokeObjectMethod("GetSLFlag.(I)Lcom/zebra/rfid/api3/SL_FLAG;", jniArgumentValuePtr);
      return Object.GetObject<SL_FLAG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) SL_FLAG.cb_equals_I == null)
        SL_FLAG.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(SL_FLAG.n_Equals_I));
      return SL_FLAG.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<SL_FLAG>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return SL_FLAG._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
