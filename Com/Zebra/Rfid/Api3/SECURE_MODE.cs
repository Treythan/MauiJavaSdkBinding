// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SECURE_MODE
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
  [Register("com/zebra/rfid/api3/SECURE_MODE", DoNotGenerateAcw = true)]
  public class SECURE_MODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SECURE_MODE", typeof (SECURE_MODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("HTTP")]
    public static SECURE_MODE? Http
    {
      get
      {
        JniObjectReference objectValue = SECURE_MODE._members.StaticFields.GetObjectValue("HTTP.Lcom/zebra/rfid/api3/SECURE_MODE;");
        return Object.GetObject<SECURE_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HTTPS")]
    public static SECURE_MODE? Https
    {
      get
      {
        JniObjectReference objectValue = SECURE_MODE._members.StaticFields.GetObjectValue("HTTPS.Lcom/zebra/rfid/api3/SECURE_MODE;");
        return Object.GetObject<SECURE_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => SECURE_MODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => SECURE_MODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SECURE_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SECURE_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SECURE_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SECURE_MODE._members.ManagedPeerType;

    protected SECURE_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) SECURE_MODE.cb_getValue == null)
        SECURE_MODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SECURE_MODE.n_GetValue));
      return SECURE_MODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SECURE_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return SECURE_MODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) SECURE_MODE.cb_equals_I == null)
        SECURE_MODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(SECURE_MODE.n_Equals_I));
      return SECURE_MODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<SECURE_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return SECURE_MODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
