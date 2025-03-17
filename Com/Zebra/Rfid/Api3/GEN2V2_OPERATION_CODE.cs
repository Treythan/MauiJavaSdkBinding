// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.GEN2V2_OPERATION_CODE
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
  [Register("com/zebra/rfid/api3/GEN2V2_OPERATION_CODE", DoNotGenerateAcw = true)]
  public class GEN2V2_OPERATION_CODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/GEN2V2_OPERATION_CODE", typeof (GEN2V2_OPERATION_CODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("G2V2_OPERATION_AUTHENTICATE")]
    public static GEN2V2_OPERATION_CODE? G2v2OperationAuthenticate
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_CODE._members.StaticFields.GetObjectValue("G2V2_OPERATION_AUTHENTICATE.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;");
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("G2V2_OPERATION_CRYPTO")]
    public static GEN2V2_OPERATION_CODE? G2v2OperationCrypto
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_CODE._members.StaticFields.GetObjectValue("G2V2_OPERATION_CRYPTO.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;");
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("G2V2_OPERATION_READBUFFER")]
    public static GEN2V2_OPERATION_CODE? G2v2OperationReadbuffer
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_CODE._members.StaticFields.GetObjectValue("G2V2_OPERATION_READBUFFER.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;");
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("G2V2_OPERATION_UNTRACEABLE")]
    public static GEN2V2_OPERATION_CODE? G2v2OperationUntraceable
    {
      get
      {
        JniObjectReference objectValue = GEN2V2_OPERATION_CODE._members.StaticFields.GetObjectValue("G2V2_OPERATION_UNTRACEABLE.Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;");
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return GEN2V2_OPERATION_CODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        GEN2V2_OPERATION_CODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = GEN2V2_OPERATION_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => GEN2V2_OPERATION_CODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = GEN2V2_OPERATION_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => GEN2V2_OPERATION_CODE._members.ManagedPeerType;

    protected GEN2V2_OPERATION_CODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) GEN2V2_OPERATION_CODE.cb_getValue == null)
        GEN2V2_OPERATION_CODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(GEN2V2_OPERATION_CODE.n_GetValue));
      return GEN2V2_OPERATION_CODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<GEN2V2_OPERATION_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return GEN2V2_OPERATION_CODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetG2V2OperationCodeValue", "(I)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", "")]
    public static unsafe GEN2V2_OPERATION_CODE? GetG2V2OperationCodeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = GEN2V2_OPERATION_CODE._members.StaticMethods.InvokeObjectMethod("GetG2V2OperationCodeValue.(I)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", jniArgumentValuePtr);
      return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetG2V2OperationCodeValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", "")]
    public static unsafe GEN2V2_OPERATION_CODE? GetG2V2OperationCodeValue(string? g2v2operation)
    {
      IntPtr num = JNIEnv.NewString(g2v2operation);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = GEN2V2_OPERATION_CODE._members.StaticMethods.InvokeObjectMethod("GetG2V2OperationCodeValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/GEN2V2_OPERATION_CODE;", jniArgumentValuePtr);
        return Object.GetObject<GEN2V2_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) GEN2V2_OPERATION_CODE.cb_equals_I == null)
        GEN2V2_OPERATION_CODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(GEN2V2_OPERATION_CODE.n_Equals_I));
      return GEN2V2_OPERATION_CODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<GEN2V2_OPERATION_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return GEN2V2_OPERATION_CODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
