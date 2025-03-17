// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SERVICE_ID
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
  [Register("com/zebra/rfid/api3/SERVICE_ID", DoNotGenerateAcw = true)]
  public class SERVICE_ID : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SERVICE_ID", typeof (SERVICE_ID));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("LLRP_SERVER")]
    public static SERVICE_ID? LlrpServer
    {
      get
      {
        JniObjectReference objectValue = SERVICE_ID._members.StaticFields.GetObjectValue("LLRP_SERVER.Lcom/zebra/rfid/api3/SERVICE_ID;");
        return Object.GetObject<SERVICE_ID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => SERVICE_ID._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => SERVICE_ID._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("RM")]
    public static SERVICE_ID? Rm
    {
      get
      {
        JniObjectReference objectValue = SERVICE_ID._members.StaticFields.GetObjectValue("RM.Lcom/zebra/rfid/api3/SERVICE_ID;");
        return Object.GetObject<SERVICE_ID>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SERVICE_ID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SERVICE_ID._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SERVICE_ID._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SERVICE_ID._members.ManagedPeerType;

    protected SERVICE_ID(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) SERVICE_ID.cb_getValue == null)
        SERVICE_ID.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SERVICE_ID.n_GetValue));
      return SERVICE_ID.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SERVICE_ID>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return SERVICE_ID._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) SERVICE_ID.cb_equals_I == null)
        SERVICE_ID.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(SERVICE_ID.n_Equals_I));
      return SERVICE_ID.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<SERVICE_ID>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return SERVICE_ID._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
