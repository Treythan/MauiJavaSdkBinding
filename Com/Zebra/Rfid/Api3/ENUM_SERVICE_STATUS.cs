// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_SERVICE_STATUS
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
  [Register("com/zebra/rfid/api3/ENUM_SERVICE_STATUS", DoNotGenerateAcw = true)]
  public sealed class ENUM_SERVICE_STATUS : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_SERVICE_STATUS", typeof (ENUM_SERVICE_STATUS));

    [Register("READER_ATTACHED")]
    public static ENUM_SERVICE_STATUS? ReaderAttached
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("READER_ATTACHED.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READER_ATTACHED_NOT_CONNECTED")]
    public static ENUM_SERVICE_STATUS? ReaderAttachedNotConnected
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("READER_ATTACHED_NOT_CONNECTED.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READER_AVAILABLE")]
    public static ENUM_SERVICE_STATUS? ReaderAvailable
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("READER_AVAILABLE.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("READER_DETACHED")]
    public static ENUM_SERVICE_STATUS? ReaderDetached
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("READER_DETACHED.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SERVICE_BOUND")]
    public static ENUM_SERVICE_STATUS? ServiceBound
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("SERVICE_BOUND.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SERVICE_UNBOUND")]
    public static ENUM_SERVICE_STATUS? ServiceUnbound
    {
      get
      {
        JniObjectReference objectValue = ENUM_SERVICE_STATUS._members.StaticFields.GetObjectValue("SERVICE_UNBOUND.Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;");
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_SERVICE_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_SERVICE_STATUS._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_SERVICE_STATUS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_SERVICE_STATUS._members.ManagedPeerType;

    internal ENUM_SERVICE_STATUS(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int Value
    {
      [Register("getValue", "()I", "")] get
      {
        return ENUM_SERVICE_STATUS._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;", "")]
    public static unsafe ENUM_SERVICE_STATUS? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_SERVICE_STATUS._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_SERVICE_STATUS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;", "")]
    public static unsafe ENUM_SERVICE_STATUS[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_SERVICE_STATUS._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_SERVICE_STATUS;", (JniArgumentValue*) null);
      return (ENUM_SERVICE_STATUS[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_SERVICE_STATUS));
    }
  }
}
