// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.NOTIFICATION_TYPE
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
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/NOTIFICATION_TYPE", DoNotGenerateAcw = true)]
  public sealed class NOTIFICATION_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/NOTIFICATION_TYPE", typeof (NOTIFICATION_TYPE));

    [Register("BATCHMODEEVENT")]
    public static NOTIFICATION_TYPE? Batchmodeevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("BATCHMODEEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("BATTERYEVENT")]
    public static NOTIFICATION_TYPE? Batteryevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("BATTERYEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CRADLE_EVENT")]
    public static NOTIFICATION_TYPE? CradleEvent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("CRADLE_EVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("DATABASEEVENT")]
    public static NOTIFICATION_TYPE? Databaseevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("DATABASEEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INFOEVENT")]
    public static NOTIFICATION_TYPE? Infoevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("INFOEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("OPERENDSUMMARY")]
    public static NOTIFICATION_TYPE? Operendsummary
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("OPERENDSUMMARY.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("POWEREVENT")]
    public static NOTIFICATION_TYPE? Powerevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("POWEREVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("RADIOERROREVENT")]
    public static NOTIFICATION_TYPE? Radioerrorevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("RADIOERROREVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STARTOPERATION")]
    public static NOTIFICATION_TYPE? Startoperation
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("STARTOPERATION.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("STOPOPERATION")]
    public static NOTIFICATION_TYPE? Stopoperation
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("STOPOPERATION.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TEMPERATUREEVENT")]
    public static NOTIFICATION_TYPE? Temperatureevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("TEMPERATUREEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRIGGEREVENT")]
    public static NOTIFICATION_TYPE? Triggerevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("TRIGGEREVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("WPAEVENT")]
    public static NOTIFICATION_TYPE? Wpaevent
    {
      get
      {
        JniObjectReference objectValue = NOTIFICATION_TYPE._members.StaticFields.GetObjectValue("WPAEVENT.Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;");
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = NOTIFICATION_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => NOTIFICATION_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = NOTIFICATION_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => NOTIFICATION_TYPE._members.ManagedPeerType;

    internal NOTIFICATION_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "")]
    public static unsafe NOTIFICATION_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = NOTIFICATION_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<NOTIFICATION_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", "")]
    public static unsafe NOTIFICATION_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = NOTIFICATION_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/NOTIFICATION_TYPE;", (JniArgumentValue*) null);
      return (NOTIFICATION_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (NOTIFICATION_TYPE));
    }
  }
}
