// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.OPERATION_QUALIFIER
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
  [Register("com/zebra/rfid/api3/OPERATION_QUALIFIER", DoNotGenerateAcw = true)]
  public class OPERATION_QUALIFIER : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/OPERATION_QUALIFIER", typeof (OPERATION_QUALIFIER));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("C1G2_OPERATION")]
    public static OPERATION_QUALIFIER? C1g2Operation
    {
      get
      {
        JniObjectReference objectValue = OPERATION_QUALIFIER._members.StaticFields.GetObjectValue("C1G2_OPERATION.Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;");
        return Object.GetObject<OPERATION_QUALIFIER>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOCATE_TAG")]
    public static OPERATION_QUALIFIER? LocateTag
    {
      get
      {
        JniObjectReference objectValue = OPERATION_QUALIFIER._members.StaticFields.GetObjectValue("LOCATE_TAG.Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;");
        return Object.GetObject<OPERATION_QUALIFIER>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NXP_EAS_SCAN")]
    public static OPERATION_QUALIFIER? NxpEasScan
    {
      get
      {
        JniObjectReference objectValue = OPERATION_QUALIFIER._members.StaticFields.GetObjectValue("NXP_EAS_SCAN.Lcom/zebra/rfid/api3/OPERATION_QUALIFIER;");
        return Object.GetObject<OPERATION_QUALIFIER>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return OPERATION_QUALIFIER._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        OPERATION_QUALIFIER._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = OPERATION_QUALIFIER._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => OPERATION_QUALIFIER._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = OPERATION_QUALIFIER._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => OPERATION_QUALIFIER._members.ManagedPeerType;

    protected OPERATION_QUALIFIER(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) OPERATION_QUALIFIER.cb_getValue == null)
        OPERATION_QUALIFIER.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(OPERATION_QUALIFIER.n_GetValue));
      return OPERATION_QUALIFIER.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<OPERATION_QUALIFIER>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return OPERATION_QUALIFIER._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) OPERATION_QUALIFIER.cb_equals_I == null)
        OPERATION_QUALIFIER.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(OPERATION_QUALIFIER.n_Equals_I));
      return OPERATION_QUALIFIER.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<OPERATION_QUALIFIER>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return OPERATION_QUALIFIER._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
