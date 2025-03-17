// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.STATE_UNAWARE_ACTION
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
  [Register("com/zebra/rfid/api3/STATE_UNAWARE_ACTION", DoNotGenerateAcw = true)]
  public class STATE_UNAWARE_ACTION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/STATE_UNAWARE_ACTION", typeof (STATE_UNAWARE_ACTION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return STATE_UNAWARE_ACTION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        STATE_UNAWARE_ACTION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("STATE_UNAWARE_ACTION_NOT_SELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionNotSelect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_NOT_SELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_UNAWARE_ACTION_NOT_UNSELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionNotUnselect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_NOT_UNSELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_UNAWARE_ACTION_SELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionSelect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_SELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_UNAWARE_ACTION_SELECT_NOT_UNSELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionSelectNotUnselect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_SELECT_NOT_UNSELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_UNAWARE_ACTION_UNSELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionUnselect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_UNSELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STATE_UNAWARE_ACTION_UNSELECT_NOT_SELECT")]
    public static STATE_UNAWARE_ACTION? StateUnawareActionUnselectNotSelect
    {
      get
      {
        JniObjectReference objectValue = STATE_UNAWARE_ACTION._members.StaticFields.GetObjectValue("STATE_UNAWARE_ACTION_UNSELECT_NOT_SELECT.Lcom/zebra/rfid/api3/STATE_UNAWARE_ACTION;");
        return Object.GetObject<STATE_UNAWARE_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = STATE_UNAWARE_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => STATE_UNAWARE_ACTION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = STATE_UNAWARE_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => STATE_UNAWARE_ACTION._members.ManagedPeerType;

    protected STATE_UNAWARE_ACTION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) STATE_UNAWARE_ACTION.cb_getValue == null)
        STATE_UNAWARE_ACTION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(STATE_UNAWARE_ACTION.n_GetValue));
      return STATE_UNAWARE_ACTION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<STATE_UNAWARE_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return STATE_UNAWARE_ACTION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) STATE_UNAWARE_ACTION.cb_equals_I == null)
        STATE_UNAWARE_ACTION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(STATE_UNAWARE_ACTION.n_Equals_I));
      return STATE_UNAWARE_ACTION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<STATE_UNAWARE_ACTION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return STATE_UNAWARE_ACTION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
