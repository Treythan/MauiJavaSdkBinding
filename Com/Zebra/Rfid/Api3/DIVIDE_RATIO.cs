// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.DIVIDE_RATIO
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
  [Register("com/zebra/rfid/api3/DIVIDE_RATIO", DoNotGenerateAcw = true)]
  public class DIVIDE_RATIO : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DIVIDE_RATIO", typeof (DIVIDE_RATIO));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("DR_64_3")]
    public static DIVIDE_RATIO? Dr643
    {
      get
      {
        JniObjectReference objectValue = DIVIDE_RATIO._members.StaticFields.GetObjectValue("DR_64_3.Lcom/zebra/rfid/api3/DIVIDE_RATIO;");
        return Object.GetObject<DIVIDE_RATIO>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DR_8")]
    public static DIVIDE_RATIO? Dr8
    {
      get
      {
        JniObjectReference objectValue = DIVIDE_RATIO._members.StaticFields.GetObjectValue("DR_8.Lcom/zebra/rfid/api3/DIVIDE_RATIO;");
        return Object.GetObject<DIVIDE_RATIO>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => DIVIDE_RATIO._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set
      {
        DIVIDE_RATIO._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DIVIDE_RATIO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DIVIDE_RATIO._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DIVIDE_RATIO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DIVIDE_RATIO._members.ManagedPeerType;

    protected DIVIDE_RATIO(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) DIVIDE_RATIO.cb_getValue == null)
        DIVIDE_RATIO.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(DIVIDE_RATIO.n_GetValue));
      return DIVIDE_RATIO.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DIVIDE_RATIO>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return DIVIDE_RATIO._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetDivideRatioValue", "(I)Lcom/zebra/rfid/api3/DIVIDE_RATIO;", "")]
    public static unsafe DIVIDE_RATIO? GetDivideRatioValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = DIVIDE_RATIO._members.StaticMethods.InvokeObjectMethod("GetDivideRatioValue.(I)Lcom/zebra/rfid/api3/DIVIDE_RATIO;", jniArgumentValuePtr);
      return Object.GetObject<DIVIDE_RATIO>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) DIVIDE_RATIO.cb_equals_I == null)
        DIVIDE_RATIO.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(DIVIDE_RATIO.n_Equals_I));
      return DIVIDE_RATIO.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<DIVIDE_RATIO>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return DIVIDE_RATIO._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
