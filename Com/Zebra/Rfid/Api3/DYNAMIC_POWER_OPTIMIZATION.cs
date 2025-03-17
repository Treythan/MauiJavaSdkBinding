// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.DYNAMIC_POWER_OPTIMIZATION
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
  [Register("com/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION", DoNotGenerateAcw = true)]
  public class DYNAMIC_POWER_OPTIMIZATION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION", typeof (DYNAMIC_POWER_OPTIMIZATION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("DISABLE")]
    public static DYNAMIC_POWER_OPTIMIZATION? Disable
    {
      get
      {
        JniObjectReference objectValue = DYNAMIC_POWER_OPTIMIZATION._members.StaticFields.GetObjectValue("DISABLE.Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;");
        return Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ENABLE")]
    public static DYNAMIC_POWER_OPTIMIZATION? Enable
    {
      get
      {
        JniObjectReference objectValue = DYNAMIC_POWER_OPTIMIZATION._members.StaticFields.GetObjectValue("ENABLE.Lcom/zebra/rfid/api3/DYNAMIC_POWER_OPTIMIZATION;");
        return Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return DYNAMIC_POWER_OPTIMIZATION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        DYNAMIC_POWER_OPTIMIZATION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DYNAMIC_POWER_OPTIMIZATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DYNAMIC_POWER_OPTIMIZATION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DYNAMIC_POWER_OPTIMIZATION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DYNAMIC_POWER_OPTIMIZATION._members.ManagedPeerType;

    protected DYNAMIC_POWER_OPTIMIZATION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) DYNAMIC_POWER_OPTIMIZATION.cb_getValue == null)
        DYNAMIC_POWER_OPTIMIZATION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(DYNAMIC_POWER_OPTIMIZATION.n_GetValue));
      return DYNAMIC_POWER_OPTIMIZATION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return DYNAMIC_POWER_OPTIMIZATION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetDPOState", "(I)Ljava/lang/Object;", "")]
    public static unsafe Object? GetDPOState(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = DYNAMIC_POWER_OPTIMIZATION._members.StaticMethods.InvokeObjectMethod("GetDPOState.(I)Ljava/lang/Object;", jniArgumentValuePtr);
      return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) DYNAMIC_POWER_OPTIMIZATION.cb_equals_I == null)
        DYNAMIC_POWER_OPTIMIZATION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(DYNAMIC_POWER_OPTIMIZATION.n_Equals_I));
      return DYNAMIC_POWER_OPTIMIZATION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<DYNAMIC_POWER_OPTIMIZATION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return DYNAMIC_POWER_OPTIMIZATION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
