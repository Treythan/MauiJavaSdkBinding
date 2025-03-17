// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TARGET
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
  [Register("com/zebra/rfid/api3/TARGET", DoNotGenerateAcw = true)]
  public class TARGET : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TARGET", typeof (TARGET));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get => TARGET._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => TARGET._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("TARGET_INVENTORIED_STATE_S0")]
    public static TARGET? TargetInventoriedStateS0
    {
      get
      {
        JniObjectReference objectValue = TARGET._members.StaticFields.GetObjectValue("TARGET_INVENTORIED_STATE_S0.Lcom/zebra/rfid/api3/TARGET;");
        return Object.GetObject<TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TARGET_INVENTORIED_STATE_S1")]
    public static TARGET? TargetInventoriedStateS1
    {
      get
      {
        JniObjectReference objectValue = TARGET._members.StaticFields.GetObjectValue("TARGET_INVENTORIED_STATE_S1.Lcom/zebra/rfid/api3/TARGET;");
        return Object.GetObject<TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TARGET_INVENTORIED_STATE_S2")]
    public static TARGET? TargetInventoriedStateS2
    {
      get
      {
        JniObjectReference objectValue = TARGET._members.StaticFields.GetObjectValue("TARGET_INVENTORIED_STATE_S2.Lcom/zebra/rfid/api3/TARGET;");
        return Object.GetObject<TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TARGET_INVENTORIED_STATE_S3")]
    public static TARGET? TargetInventoriedStateS3
    {
      get
      {
        JniObjectReference objectValue = TARGET._members.StaticFields.GetObjectValue("TARGET_INVENTORIED_STATE_S3.Lcom/zebra/rfid/api3/TARGET;");
        return Object.GetObject<TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TARGET_SL")]
    public static TARGET? TargetSl
    {
      get
      {
        JniObjectReference objectValue = TARGET._members.StaticFields.GetObjectValue("TARGET_SL.Lcom/zebra/rfid/api3/TARGET;");
        return Object.GetObject<TARGET>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TARGET._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TARGET._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TARGET._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TARGET._members.ManagedPeerType;

    protected TARGET(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) TARGET.cb_getValue == null)
        TARGET.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TARGET.n_GetValue));
      return TARGET.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TARGET>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return TARGET._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) TARGET.cb_equals_I == null)
        TARGET.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(TARGET.n_Equals_I));
      return TARGET.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<TARGET>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return TARGET._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    [Register("getTarget", "(I)Lcom/zebra/rfid/api3/TARGET;", "")]
    public static unsafe TARGET? GetTarget(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = TARGET._members.StaticMethods.InvokeObjectMethod("getTarget.(I)Lcom/zebra/rfid/api3/TARGET;", jniArgumentValuePtr);
      return Object.GetObject<TARGET>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
