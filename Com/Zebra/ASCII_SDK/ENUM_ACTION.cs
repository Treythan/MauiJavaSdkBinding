// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_ACTION
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
  [Register("com/zebra/ASCII_SDK/ENUM_ACTION", DoNotGenerateAcw = true)]
  public sealed class ENUM_ACTION : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_ACTION", typeof (ENUM_ACTION));

    [Register("INV_A2BB2A_NOT_INV_A_OR_NEG_SL_NOT_ASRT_SL")]
    public static ENUM_ACTION? InvA2bb2aNotInvAOrNegSlNotAsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("INV_A2BB2A_NOT_INV_A_OR_NEG_SL_NOT_ASRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INV_A_NOT_INV_B_OR_ASRT_SL_NOT_DSRT_SL")]
    public static ENUM_ACTION? InvANotInvBOrAsrtSlNotDsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("INV_A_NOT_INV_B_OR_ASRT_SL_NOT_DSRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INV_A_OR_ASRT_SL")]
    public static ENUM_ACTION? InvAOrAsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("INV_A_OR_ASRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INV_B_NOT_INV_A_OR_DSRT_SL_NOT_ASRT_SL")]
    public static ENUM_ACTION? InvBNotInvAOrDsrtSlNotAsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("INV_B_NOT_INV_A_OR_DSRT_SL_NOT_ASRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("INV_B_OR_DSRT_SL")]
    public static ENUM_ACTION? InvBOrDsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("INV_B_OR_DSRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOT_INV_A2BB2A_OR_NOT_NEG_SL")]
    public static ENUM_ACTION? NotInvA2bb2aOrNotNegSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("NOT_INV_A2BB2A_OR_NOT_NEG_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOT_INV_A_OR_NOT_ASRT_SL")]
    public static ENUM_ACTION? NotInvAOrNotAsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("NOT_INV_A_OR_NOT_ASRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NOT_INV_B_OR_NOT_DSRT_SL")]
    public static ENUM_ACTION? NotInvBOrNotDsrtSl
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACTION._members.StaticFields.GetObjectValue("NOT_INV_B_OR_NOT_DSRT_SL.Lcom/zebra/ASCII_SDK/ENUM_ACTION;");
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_ACTION._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_ACTION._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_ACTION._members.ManagedPeerType;

    internal ENUM_ACTION(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe int EnumValue
    {
      [Register("getEnumValue", "()I", "")] get
      {
        return ENUM_ACTION._members.InstanceMethods.InvokeAbstractInt32Method("getEnumValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACTION;", "")]
    public static unsafe ENUM_ACTION? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_ACTION._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACTION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACTION;", "")]
    public static unsafe ENUM_ACTION? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_ACTION._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACTION;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_ACTION>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_ACTION;", "")]
    public static unsafe ENUM_ACTION[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_ACTION._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_ACTION;", (JniArgumentValue*) null);
      return (ENUM_ACTION[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_ACTION));
    }
  }
}
