// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENVIRONMENT_MODE
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
  [Register("com/zebra/rfid/api3/ENVIRONMENT_MODE", DoNotGenerateAcw = true)]
  public class ENVIRONMENT_MODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENVIRONMENT_MODE", typeof (ENVIRONMENT_MODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("AUTO_DETECT")]
    public static ENVIRONMENT_MODE? AutoDetect
    {
      get
      {
        JniObjectReference objectValue = ENVIRONMENT_MODE._members.StaticFields.GetObjectValue("AUTO_DETECT.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;");
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DEMO")]
    public static ENVIRONMENT_MODE? Demo
    {
      get
      {
        JniObjectReference objectValue = ENVIRONMENT_MODE._members.StaticFields.GetObjectValue("DEMO.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;");
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HIGH_INTERFERENCE")]
    public static ENVIRONMENT_MODE? HighInterference
    {
      get
      {
        JniObjectReference objectValue = ENVIRONMENT_MODE._members.StaticFields.GetObjectValue("HIGH_INTERFERENCE.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;");
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("LOW_INTERFERENCE")]
    public static ENVIRONMENT_MODE? LowInterference
    {
      get
      {
        JniObjectReference objectValue = ENVIRONMENT_MODE._members.StaticFields.GetObjectValue("LOW_INTERFERENCE.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;");
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return ENVIRONMENT_MODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        ENVIRONMENT_MODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("VERY_HIGH_INTERFERENCE")]
    public static ENVIRONMENT_MODE? VeryHighInterference
    {
      get
      {
        JniObjectReference objectValue = ENVIRONMENT_MODE._members.StaticFields.GetObjectValue("VERY_HIGH_INTERFERENCE.Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;");
        return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENVIRONMENT_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENVIRONMENT_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENVIRONMENT_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENVIRONMENT_MODE._members.ManagedPeerType;

    protected ENVIRONMENT_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) ENVIRONMENT_MODE.cb_getValue == null)
        ENVIRONMENT_MODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ENVIRONMENT_MODE.n_GetValue));
      return ENVIRONMENT_MODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ENVIRONMENT_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return ENVIRONMENT_MODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) ENVIRONMENT_MODE.cb_equals_I == null)
        ENVIRONMENT_MODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(ENVIRONMENT_MODE.n_Equals_I));
      return ENVIRONMENT_MODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<ENVIRONMENT_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return ENVIRONMENT_MODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("getEnvironmentMode", "(I)Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", "")]
    public static unsafe ENVIRONMENT_MODE? GetEnvironmentMode(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = ENVIRONMENT_MODE._members.StaticMethods.InvokeObjectMethod("getEnvironmentMode.(I)Lcom/zebra/rfid/api3/ENVIRONMENT_MODE;", jniArgumentValuePtr);
      return Object.GetObject<ENVIRONMENT_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
