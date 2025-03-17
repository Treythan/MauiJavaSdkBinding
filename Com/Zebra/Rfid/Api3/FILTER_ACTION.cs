// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FILTER_ACTION
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
  [Register("com/zebra/rfid/api3/FILTER_ACTION", DoNotGenerateAcw = true)]
  public class FILTER_ACTION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FILTER_ACTION", typeof (FILTER_ACTION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("FILTER_ACTION_DEFAULT")]
    public static FILTER_ACTION? FilterActionDefault
    {
      get
      {
        JniObjectReference objectValue = FILTER_ACTION._members.StaticFields.GetObjectValue("FILTER_ACTION_DEFAULT.Lcom/zebra/rfid/api3/FILTER_ACTION;");
        return Object.GetObject<FILTER_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FILTER_ACTION_STATE_AWARE")]
    public static FILTER_ACTION? FilterActionStateAware
    {
      get
      {
        JniObjectReference objectValue = FILTER_ACTION._members.StaticFields.GetObjectValue("FILTER_ACTION_STATE_AWARE.Lcom/zebra/rfid/api3/FILTER_ACTION;");
        return Object.GetObject<FILTER_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("FILTER_ACTION_STATE_UNAWARE")]
    public static FILTER_ACTION? FilterActionStateUnaware
    {
      get
      {
        JniObjectReference objectValue = FILTER_ACTION._members.StaticFields.GetObjectValue("FILTER_ACTION_STATE_UNAWARE.Lcom/zebra/rfid/api3/FILTER_ACTION;");
        return Object.GetObject<FILTER_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => FILTER_ACTION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set
      {
        FILTER_ACTION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FILTER_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FILTER_ACTION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FILTER_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FILTER_ACTION._members.ManagedPeerType;

    protected FILTER_ACTION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) FILTER_ACTION.cb_getValue == null)
        FILTER_ACTION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FILTER_ACTION.n_GetValue));
      return FILTER_ACTION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FILTER_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return FILTER_ACTION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) FILTER_ACTION.cb_equals_I == null)
        FILTER_ACTION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(FILTER_ACTION.n_Equals_I));
      return FILTER_ACTION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<FILTER_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return FILTER_ACTION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
