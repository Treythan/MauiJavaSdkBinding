// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ENUM_KEYLAYOUT_TYPE
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
  [Register("com/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE", DoNotGenerateAcw = true)]
  public sealed class ENUM_KEYLAYOUT_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE", typeof (ENUM_KEYLAYOUT_TYPE));

    [Register("LOWER_TRIGGER_FOR_SLED_SCAN")]
    public static ENUM_KEYLAYOUT_TYPE? LowerTriggerForSledScan
    {
      get
      {
        JniObjectReference objectValue = ENUM_KEYLAYOUT_TYPE._members.StaticFields.GetObjectValue("LOWER_TRIGGER_FOR_SLED_SCAN.Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;");
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UPPER_TRIGGER_FOR_RFID")]
    public static ENUM_KEYLAYOUT_TYPE? UpperTriggerForRfid
    {
      get
      {
        JniObjectReference objectValue = ENUM_KEYLAYOUT_TYPE._members.StaticFields.GetObjectValue("UPPER_TRIGGER_FOR_RFID.Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;");
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UPPER_TRIGGER_FOR_SCAN")]
    public static ENUM_KEYLAYOUT_TYPE? UpperTriggerForScan
    {
      get
      {
        JniObjectReference objectValue = ENUM_KEYLAYOUT_TYPE._members.StaticFields.GetObjectValue("UPPER_TRIGGER_FOR_SCAN.Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;");
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UPPER_TRIGGER_FOR_SLED_SCAN")]
    public static ENUM_KEYLAYOUT_TYPE? UpperTriggerForSledScan
    {
      get
      {
        JniObjectReference objectValue = ENUM_KEYLAYOUT_TYPE._members.StaticFields.GetObjectValue("UPPER_TRIGGER_FOR_SLED_SCAN.Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;");
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_KEYLAYOUT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_KEYLAYOUT_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_KEYLAYOUT_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_KEYLAYOUT_TYPE._members.ManagedPeerType;

    internal ENUM_KEYLAYOUT_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_KEYLAYOUT_TYPE._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", "")]
    public static unsafe ENUM_KEYLAYOUT_TYPE? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_KEYLAYOUT_TYPE._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", "")]
    public static unsafe ENUM_KEYLAYOUT_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_KEYLAYOUT_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_KEYLAYOUT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", "")]
    public static unsafe ENUM_KEYLAYOUT_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_KEYLAYOUT_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/rfid/api3/ENUM_KEYLAYOUT_TYPE;", (JniArgumentValue*) null);
      return (ENUM_KEYLAYOUT_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_KEYLAYOUT_TYPE));
    }
  }
}
