// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.WRITE_FIELD_CODE
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
  [Register("com/zebra/rfid/api3/WRITE_FIELD_CODE", DoNotGenerateAcw = true)]
  public class WRITE_FIELD_CODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/WRITE_FIELD_CODE", typeof (WRITE_FIELD_CODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return WRITE_FIELD_CODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        WRITE_FIELD_CODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("WRITE_FIELD_ACCESSPASSWORD")]
    public static WRITE_FIELD_CODE? WriteFieldAccesspassword
    {
      get
      {
        JniObjectReference objectValue = WRITE_FIELD_CODE._members.StaticFields.GetObjectValue("WRITE_FIELD_ACCESSPASSWORD.Lcom/zebra/rfid/api3/WRITE_FIELD_CODE;");
        return Object.GetObject<WRITE_FIELD_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WRITE_FIELD_KILLPASSWORD")]
    public static WRITE_FIELD_CODE? WriteFieldKillpassword
    {
      get
      {
        JniObjectReference objectValue = WRITE_FIELD_CODE._members.StaticFields.GetObjectValue("WRITE_FIELD_KILLPASSWORD.Lcom/zebra/rfid/api3/WRITE_FIELD_CODE;");
        return Object.GetObject<WRITE_FIELD_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WRITE_FIELD_TAGID")]
    public static WRITE_FIELD_CODE? WriteFieldTagid
    {
      get
      {
        JniObjectReference objectValue = WRITE_FIELD_CODE._members.StaticFields.GetObjectValue("WRITE_FIELD_TAGID.Lcom/zebra/rfid/api3/WRITE_FIELD_CODE;");
        return Object.GetObject<WRITE_FIELD_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = WRITE_FIELD_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => WRITE_FIELD_CODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = WRITE_FIELD_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => WRITE_FIELD_CODE._members.ManagedPeerType;

    protected WRITE_FIELD_CODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) WRITE_FIELD_CODE.cb_getValue == null)
        WRITE_FIELD_CODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(WRITE_FIELD_CODE.n_GetValue));
      return WRITE_FIELD_CODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<WRITE_FIELD_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return WRITE_FIELD_CODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) WRITE_FIELD_CODE.cb_equals_I == null)
        WRITE_FIELD_CODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(WRITE_FIELD_CODE.n_Equals_I));
      return WRITE_FIELD_CODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<WRITE_FIELD_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return WRITE_FIELD_CODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
