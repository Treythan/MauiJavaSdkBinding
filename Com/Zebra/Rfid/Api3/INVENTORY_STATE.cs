// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.INVENTORY_STATE
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
  [Register("com/zebra/rfid/api3/INVENTORY_STATE", DoNotGenerateAcw = true)]
  public class INVENTORY_STATE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/INVENTORY_STATE", typeof (INVENTORY_STATE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("INVENTORY_STATE_A")]
    public static INVENTORY_STATE? InventoryStateA
    {
      get
      {
        JniObjectReference objectValue = INVENTORY_STATE._members.StaticFields.GetObjectValue("INVENTORY_STATE_A.Lcom/zebra/rfid/api3/INVENTORY_STATE;");
        return Object.GetObject<INVENTORY_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INVENTORY_STATE_AB_FLIP")]
    public static INVENTORY_STATE? InventoryStateAbFlip
    {
      get
      {
        JniObjectReference objectValue = INVENTORY_STATE._members.StaticFields.GetObjectValue("INVENTORY_STATE_AB_FLIP.Lcom/zebra/rfid/api3/INVENTORY_STATE;");
        return Object.GetObject<INVENTORY_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INVENTORY_STATE_B")]
    public static INVENTORY_STATE? InventoryStateB
    {
      get
      {
        JniObjectReference objectValue = INVENTORY_STATE._members.StaticFields.GetObjectValue("INVENTORY_STATE_B.Lcom/zebra/rfid/api3/INVENTORY_STATE;");
        return Object.GetObject<INVENTORY_STATE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return INVENTORY_STATE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        INVENTORY_STATE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = INVENTORY_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => INVENTORY_STATE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = INVENTORY_STATE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => INVENTORY_STATE._members.ManagedPeerType;

    protected INVENTORY_STATE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) INVENTORY_STATE.cb_getValue == null)
        INVENTORY_STATE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(INVENTORY_STATE.n_GetValue));
      return INVENTORY_STATE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<INVENTORY_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return INVENTORY_STATE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetInventoryState", "(I)Lcom/zebra/rfid/api3/INVENTORY_STATE;", "")]
    public static unsafe INVENTORY_STATE? GetInventoryState(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = INVENTORY_STATE._members.StaticMethods.InvokeObjectMethod("GetInventoryState.(I)Lcom/zebra/rfid/api3/INVENTORY_STATE;", jniArgumentValuePtr);
      return Object.GetObject<INVENTORY_STATE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) INVENTORY_STATE.cb_equals_I == null)
        INVENTORY_STATE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(INVENTORY_STATE.n_Equals_I));
      return INVENTORY_STATE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<INVENTORY_STATE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return INVENTORY_STATE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
