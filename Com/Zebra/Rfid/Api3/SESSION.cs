// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SESSION
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
  [Register("com/zebra/rfid/api3/SESSION", DoNotGenerateAcw = true)]
  public class SESSION : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SESSION", typeof (SESSION));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get => SESSION._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => SESSION._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("SESSION_S0")]
    public static SESSION? SessionS0
    {
      get
      {
        JniObjectReference objectValue = SESSION._members.StaticFields.GetObjectValue("SESSION_S0.Lcom/zebra/rfid/api3/SESSION;");
        return Object.GetObject<SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S1")]
    public static SESSION? SessionS1
    {
      get
      {
        JniObjectReference objectValue = SESSION._members.StaticFields.GetObjectValue("SESSION_S1.Lcom/zebra/rfid/api3/SESSION;");
        return Object.GetObject<SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S2")]
    public static SESSION? SessionS2
    {
      get
      {
        JniObjectReference objectValue = SESSION._members.StaticFields.GetObjectValue("SESSION_S2.Lcom/zebra/rfid/api3/SESSION;");
        return Object.GetObject<SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SESSION_S3")]
    public static SESSION? SessionS3
    {
      get
      {
        JniObjectReference objectValue = SESSION._members.StaticFields.GetObjectValue("SESSION_S3.Lcom/zebra/rfid/api3/SESSION;");
        return Object.GetObject<SESSION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SESSION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SESSION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SESSION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SESSION._members.ManagedPeerType;

    protected SESSION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) SESSION.cb_getValue == null)
        SESSION.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SESSION.n_GetValue));
      return SESSION.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SESSION>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return SESSION._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetSession", "(I)Lcom/zebra/rfid/api3/SESSION;", "")]
    public static unsafe SESSION? GetSession(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = SESSION._members.StaticMethods.InvokeObjectMethod("GetSession.(I)Lcom/zebra/rfid/api3/SESSION;", jniArgumentValuePtr);
      return Object.GetObject<SESSION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) SESSION.cb_equals_I == null)
        SESSION.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(SESSION.n_Equals_I));
      return SESSION.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<SESSION>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return SESSION._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
