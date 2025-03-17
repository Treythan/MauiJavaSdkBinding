// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.NUM_RFID_TAG_REPORT_BATCH_MODE_USB
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
  [Register("com/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB", DoNotGenerateAcw = true)]
  public sealed class NUM_RFID_TAG_REPORT_BATCH_MODE_USB : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB", typeof (NUM_RFID_TAG_REPORT_BATCH_MODE_USB));

    [Register("DISABLE")]
    public static NUM_RFID_TAG_REPORT_BATCH_MODE_USB? Disable
    {
      get
      {
        JniObjectReference objectValue = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.StaticFields.GetObjectValue("DISABLE.Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;");
        return Object.GetObject<NUM_RFID_TAG_REPORT_BATCH_MODE_USB>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ENABLE")]
    public static NUM_RFID_TAG_REPORT_BATCH_MODE_USB? Enable
    {
      get
      {
        JniObjectReference objectValue = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.StaticFields.GetObjectValue("ENABLE.Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;");
        return Object.GetObject<NUM_RFID_TAG_REPORT_BATCH_MODE_USB>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType
    {
      get => NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.ManagedPeerType;
    }

    internal NUM_RFID_TAG_REPORT_BATCH_MODE_USB(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", "")]
    public static unsafe NUM_RFID_TAG_REPORT_BATCH_MODE_USB? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", jniArgumentValuePtr);
        return Object.GetObject<NUM_RFID_TAG_REPORT_BATCH_MODE_USB>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", "")]
    public static unsafe NUM_RFID_TAG_REPORT_BATCH_MODE_USB? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", jniArgumentValuePtr);
        return Object.GetObject<NUM_RFID_TAG_REPORT_BATCH_MODE_USB>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", "")]
    public static unsafe NUM_RFID_TAG_REPORT_BATCH_MODE_USB[]? Values()
    {
      JniObjectReference jniObjectReference = NUM_RFID_TAG_REPORT_BATCH_MODE_USB._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/NUM_RFID_TAG_REPORT_BATCH_MODE_USB;", (JniArgumentValue*) null);
      return (NUM_RFID_TAG_REPORT_BATCH_MODE_USB[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (NUM_RFID_TAG_REPORT_BATCH_MODE_USB));
    }
  }
}
