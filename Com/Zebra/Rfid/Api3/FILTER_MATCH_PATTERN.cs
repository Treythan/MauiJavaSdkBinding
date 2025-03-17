// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.FILTER_MATCH_PATTERN
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
  [Register("com/zebra/rfid/api3/FILTER_MATCH_PATTERN", DoNotGenerateAcw = true)]
  public class FILTER_MATCH_PATTERN : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/FILTER_MATCH_PATTERN", typeof (FILTER_MATCH_PATTERN));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("A")]
    public static FILTER_MATCH_PATTERN? A
    {
      get
      {
        JniObjectReference objectValue = FILTER_MATCH_PATTERN._members.StaticFields.GetObjectValue("A.Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;");
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("A_AND_B")]
    public static FILTER_MATCH_PATTERN? AAndB
    {
      get
      {
        JniObjectReference objectValue = FILTER_MATCH_PATTERN._members.StaticFields.GetObjectValue("A_AND_B.Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;");
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("A_AND_NOTB")]
    public static FILTER_MATCH_PATTERN? AAndNotb
    {
      get
      {
        JniObjectReference objectValue = FILTER_MATCH_PATTERN._members.StaticFields.GetObjectValue("A_AND_NOTB.Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;");
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOTA_AND_B")]
    public static FILTER_MATCH_PATTERN? NotaAndB
    {
      get
      {
        JniObjectReference objectValue = FILTER_MATCH_PATTERN._members.StaticFields.GetObjectValue("NOTA_AND_B.Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;");
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOTA_AND_NOTB")]
    public static FILTER_MATCH_PATTERN? NotaAndNotb
    {
      get
      {
        JniObjectReference objectValue = FILTER_MATCH_PATTERN._members.StaticFields.GetObjectValue("NOTA_AND_NOTB.Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;");
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return FILTER_MATCH_PATTERN._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        FILTER_MATCH_PATTERN._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = FILTER_MATCH_PATTERN._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => FILTER_MATCH_PATTERN._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = FILTER_MATCH_PATTERN._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => FILTER_MATCH_PATTERN._members.ManagedPeerType;

    protected FILTER_MATCH_PATTERN(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) FILTER_MATCH_PATTERN.cb_getValue == null)
        FILTER_MATCH_PATTERN.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(FILTER_MATCH_PATTERN.n_GetValue));
      return FILTER_MATCH_PATTERN.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<FILTER_MATCH_PATTERN>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return FILTER_MATCH_PATTERN._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) FILTER_MATCH_PATTERN.cb_equals_I == null)
        FILTER_MATCH_PATTERN.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(FILTER_MATCH_PATTERN.n_Equals_I));
      return FILTER_MATCH_PATTERN.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<FILTER_MATCH_PATTERN>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return FILTER_MATCH_PATTERN._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
