// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.BATCH_MODE
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
  [Register("com/zebra/rfid/api3/BATCH_MODE", DoNotGenerateAcw = true)]
  public class BATCH_MODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/BATCH_MODE", typeof (BATCH_MODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("AUTO")]
    public static BATCH_MODE? Auto
    {
      get
      {
        JniObjectReference objectValue = BATCH_MODE._members.StaticFields.GetObjectValue("AUTO.Lcom/zebra/rfid/api3/BATCH_MODE;");
        return Object.GetObject<BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DISABLE")]
    public static BATCH_MODE? Disable
    {
      get
      {
        JniObjectReference objectValue = BATCH_MODE._members.StaticFields.GetObjectValue("DISABLE.Lcom/zebra/rfid/api3/BATCH_MODE;");
        return Object.GetObject<BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ENABLE")]
    public static BATCH_MODE? Enable
    {
      get
      {
        JniObjectReference objectValue = BATCH_MODE._members.StaticFields.GetObjectValue("ENABLE.Lcom/zebra/rfid/api3/BATCH_MODE;");
        return Object.GetObject<BATCH_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get => BATCH_MODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => BATCH_MODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BATCH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BATCH_MODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BATCH_MODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BATCH_MODE._members.ManagedPeerType;

    protected BATCH_MODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) BATCH_MODE.cb_getValue == null)
        BATCH_MODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BATCH_MODE.n_GetValue));
      return BATCH_MODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BATCH_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return BATCH_MODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetBatchModeCodeValue", "(I)Ljava/lang/Object;", "")]
    public static unsafe Object? GetBatchModeCodeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = BATCH_MODE._members.StaticMethods.InvokeObjectMethod("GetBatchModeCodeValue.(I)Ljava/lang/Object;", jniArgumentValuePtr);
      return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetBatchModeCodeValue", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
    public static unsafe Object? GetBatchModeCodeValue(string? value)
    {
      IntPtr num = JNIEnv.NewString(value);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = BATCH_MODE._members.StaticMethods.InvokeObjectMethod("GetBatchModeCodeValue.(Ljava/lang/String;)Ljava/lang/Object;", jniArgumentValuePtr);
        return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) BATCH_MODE.cb_equals_I == null)
        BATCH_MODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(BATCH_MODE.n_Equals_I));
      return BATCH_MODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<BATCH_MODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return BATCH_MODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
