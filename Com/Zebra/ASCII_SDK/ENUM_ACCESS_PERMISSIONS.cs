// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.ENUM_ACCESS_PERMISSIONS
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
  [Register("com/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS", DoNotGenerateAcw = true)]
  public sealed class ENUM_ACCESS_PERMISSIONS : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS", typeof (ENUM_ACCESS_PERMISSIONS));

    [Register("ACCESSIBLE")]
    public static ENUM_ACCESS_PERMISSIONS? Accessible
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACCESS_PERMISSIONS._members.StaticFields.GetObjectValue("ACCESSIBLE.Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;");
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ALWAYS_NOT_ACCESSIBLE")]
    public static ENUM_ACCESS_PERMISSIONS? AlwaysNotAccessible
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACCESS_PERMISSIONS._members.StaticFields.GetObjectValue("ALWAYS_NOT_ACCESSIBLE.Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;");
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("PERM_ACCESSIBLE")]
    public static ENUM_ACCESS_PERMISSIONS? PermAccessible
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACCESS_PERMISSIONS._members.StaticFields.GetObjectValue("PERM_ACCESSIBLE.Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;");
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("SECURED_ACCESSIBLE")]
    public static ENUM_ACCESS_PERMISSIONS? SecuredAccessible
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACCESS_PERMISSIONS._members.StaticFields.GetObjectValue("SECURED_ACCESSIBLE.Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;");
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UNKNOWN")]
    public static ENUM_ACCESS_PERMISSIONS? Unknown
    {
      get
      {
        JniObjectReference objectValue = ENUM_ACCESS_PERMISSIONS._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;");
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ENUM_ACCESS_PERMISSIONS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ENUM_ACCESS_PERMISSIONS._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ENUM_ACCESS_PERMISSIONS._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ENUM_ACCESS_PERMISSIONS._members.ManagedPeerType;

    internal ENUM_ACCESS_PERMISSIONS(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public unsafe string? EnumValue
    {
      [Register("getEnumValue", "()Ljava/lang/String;", "")] get
      {
        JniObjectReference jniObjectReference = ENUM_ACCESS_PERMISSIONS._members.InstanceMethods.InvokeAbstractObjectMethod("getEnumValue.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("getEnum", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "")]
    public static unsafe ENUM_ACCESS_PERMISSIONS? GetEnum(string? enumValS)
    {
      IntPtr num = JNIEnv.NewString(enumValS);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_ACCESS_PERMISSIONS._members.StaticMethods.InvokeObjectMethod("getEnum.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "")]
    public static unsafe ENUM_ACCESS_PERMISSIONS? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ENUM_ACCESS_PERMISSIONS._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", jniArgumentValuePtr);
        return Object.GetObject<ENUM_ACCESS_PERMISSIONS>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", "")]
    public static unsafe ENUM_ACCESS_PERMISSIONS[]? Values()
    {
      JniObjectReference jniObjectReference = ENUM_ACCESS_PERMISSIONS._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/ENUM_ACCESS_PERMISSIONS;", (JniArgumentValue*) null);
      return (ENUM_ACCESS_PERMISSIONS[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (ENUM_ACCESS_PERMISSIONS));
    }
  }
}
