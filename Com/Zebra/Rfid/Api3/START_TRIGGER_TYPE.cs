// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.START_TRIGGER_TYPE
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
  [Register("com/zebra/rfid/api3/START_TRIGGER_TYPE", DoNotGenerateAcw = true)]
  public class START_TRIGGER_TYPE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/START_TRIGGER_TYPE", typeof (START_TRIGGER_TYPE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return START_TRIGGER_TYPE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        START_TRIGGER_TYPE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("START_TRIGGER_TYPE_GPI")]
    public static START_TRIGGER_TYPE? StartTriggerTypeGpi
    {
      get
      {
        JniObjectReference objectValue = START_TRIGGER_TYPE._members.StaticFields.GetObjectValue("START_TRIGGER_TYPE_GPI.Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;");
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("START_TRIGGER_TYPE_HANDHELD")]
    public static START_TRIGGER_TYPE? StartTriggerTypeHandheld
    {
      get
      {
        JniObjectReference objectValue = START_TRIGGER_TYPE._members.StaticFields.GetObjectValue("START_TRIGGER_TYPE_HANDHELD.Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;");
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("START_TRIGGER_TYPE_IMMEDIATE")]
    public static START_TRIGGER_TYPE? StartTriggerTypeImmediate
    {
      get
      {
        JniObjectReference objectValue = START_TRIGGER_TYPE._members.StaticFields.GetObjectValue("START_TRIGGER_TYPE_IMMEDIATE.Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;");
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("START_TRIGGER_TYPE_PERIODIC")]
    public static START_TRIGGER_TYPE? StartTriggerTypePeriodic
    {
      get
      {
        JniObjectReference objectValue = START_TRIGGER_TYPE._members.StaticFields.GetObjectValue("START_TRIGGER_TYPE_PERIODIC.Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;");
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("START_TRIGGER_TYPE_SMART_PERIODIC_INVENTORY")]
    public static START_TRIGGER_TYPE? StartTriggerTypeSmartPeriodicInventory
    {
      get
      {
        JniObjectReference objectValue = START_TRIGGER_TYPE._members.StaticFields.GetObjectValue("START_TRIGGER_TYPE_SMART_PERIODIC_INVENTORY.Lcom/zebra/rfid/api3/START_TRIGGER_TYPE;");
        return Object.GetObject<START_TRIGGER_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = START_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => START_TRIGGER_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = START_TRIGGER_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => START_TRIGGER_TYPE._members.ManagedPeerType;

    protected START_TRIGGER_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) START_TRIGGER_TYPE.cb_getValue == null)
        START_TRIGGER_TYPE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(START_TRIGGER_TYPE.n_GetValue));
      return START_TRIGGER_TYPE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<START_TRIGGER_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return START_TRIGGER_TYPE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) START_TRIGGER_TYPE.cb_equals_I == null)
        START_TRIGGER_TYPE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(START_TRIGGER_TYPE.n_Equals_I));
      return START_TRIGGER_TYPE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<START_TRIGGER_TYPE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return START_TRIGGER_TYPE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
