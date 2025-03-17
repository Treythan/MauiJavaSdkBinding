// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.MODULATION
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
  [Register("com/zebra/rfid/api3/MODULATION", DoNotGenerateAcw = true)]
  public class MODULATION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MODULATION", typeof (MODULATION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("MV_2")]
    public static MODULATION? Mv2
    {
      get
      {
        JniObjectReference objectValue = MODULATION._members.StaticFields.GetObjectValue("MV_2.Lcom/zebra/rfid/api3/MODULATION;");
        return Object.GetObject<MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_4")]
    public static MODULATION? Mv4
    {
      get
      {
        JniObjectReference objectValue = MODULATION._members.StaticFields.GetObjectValue("MV_4.Lcom/zebra/rfid/api3/MODULATION;");
        return Object.GetObject<MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_8")]
    public static MODULATION? Mv8
    {
      get
      {
        JniObjectReference objectValue = MODULATION._members.StaticFields.GetObjectValue("MV_8.Lcom/zebra/rfid/api3/MODULATION;");
        return Object.GetObject<MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("MV_FM0")]
    public static MODULATION? MvFm0
    {
      get
      {
        JniObjectReference objectValue = MODULATION._members.StaticFields.GetObjectValue("MV_FM0.Lcom/zebra/rfid/api3/MODULATION;");
        return Object.GetObject<MODULATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => MODULATION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => MODULATION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MODULATION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MODULATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MODULATION._members.ManagedPeerType;

    protected MODULATION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) MODULATION.cb_getValue == null)
        MODULATION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MODULATION.n_GetValue));
      return MODULATION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<MODULATION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return MODULATION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetModulationValue", "(I)Lcom/zebra/rfid/api3/MODULATION;", "")]
    public static unsafe MODULATION? GetModulationValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = MODULATION._members.StaticMethods.InvokeObjectMethod("GetModulationValue.(I)Lcom/zebra/rfid/api3/MODULATION;", jniArgumentValuePtr);
      return Object.GetObject<MODULATION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) MODULATION.cb_equals_I == null)
        MODULATION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(MODULATION.n_Equals_I));
      return MODULATION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<MODULATION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return MODULATION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
