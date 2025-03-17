// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TRUNCATE_ACTION
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
  [Register("com/zebra/rfid/api3/TRUNCATE_ACTION", DoNotGenerateAcw = true)]
  public class TRUNCATE_ACTION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TRUNCATE_ACTION", typeof (TRUNCATE_ACTION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return TRUNCATE_ACTION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        TRUNCATE_ACTION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("TRUNCATE_ACTION_DO_NOT_TRUNCATE")]
    public static TRUNCATE_ACTION? TruncateActionDoNotTruncate
    {
      get
      {
        JniObjectReference objectValue = TRUNCATE_ACTION._members.StaticFields.GetObjectValue("TRUNCATE_ACTION_DO_NOT_TRUNCATE.Lcom/zebra/rfid/api3/TRUNCATE_ACTION;");
        return Object.GetObject<TRUNCATE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRUNCATE_ACTION_TRUNCATE")]
    public static TRUNCATE_ACTION? TruncateActionTruncate
    {
      get
      {
        JniObjectReference objectValue = TRUNCATE_ACTION._members.StaticFields.GetObjectValue("TRUNCATE_ACTION_TRUNCATE.Lcom/zebra/rfid/api3/TRUNCATE_ACTION;");
        return Object.GetObject<TRUNCATE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRUNCATE_ACTION_UNSPECIFIED")]
    public static TRUNCATE_ACTION? TruncateActionUnspecified
    {
      get
      {
        JniObjectReference objectValue = TRUNCATE_ACTION._members.StaticFields.GetObjectValue("TRUNCATE_ACTION_UNSPECIFIED.Lcom/zebra/rfid/api3/TRUNCATE_ACTION;");
        return Object.GetObject<TRUNCATE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TRUNCATE_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TRUNCATE_ACTION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TRUNCATE_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TRUNCATE_ACTION._members.ManagedPeerType;

    protected TRUNCATE_ACTION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) TRUNCATE_ACTION.cb_getValue == null)
        TRUNCATE_ACTION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TRUNCATE_ACTION.n_GetValue));
      return TRUNCATE_ACTION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TRUNCATE_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return TRUNCATE_ACTION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) TRUNCATE_ACTION.cb_equals_I == null)
        TRUNCATE_ACTION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(TRUNCATE_ACTION.n_Equals_I));
      return TRUNCATE_ACTION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<TRUNCATE_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return TRUNCATE_ACTION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
