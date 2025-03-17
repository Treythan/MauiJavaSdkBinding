// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.USER_APP_LIST
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
  [Register("com/zebra/rfid/api3/USER_APP_LIST", DoNotGenerateAcw = true)]
  public class USER_APP_LIST : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/USER_APP_LIST", typeof (USER_APP_LIST));

    [Register("appName")]
    public string? AppName
    {
      get
      {
        JniObjectReference objectValue = USER_APP_LIST._members.InstanceFields.GetObjectValue("appName.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          USER_APP_LIST._members.InstanceFields.SetValue("appName.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("autoStart")]
    public bool AutoStart
    {
      get
      {
        return USER_APP_LIST._members.InstanceFields.GetBooleanValue("autoStart.Z", (IJavaPeerable) this);
      }
      set
      {
        USER_APP_LIST._members.InstanceFields.SetValue("autoStart.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("Metadata")]
    public string? Metadata
    {
      get
      {
        JniObjectReference objectValue = USER_APP_LIST._members.InstanceFields.GetObjectValue("Metadata.Ljava/lang/String;", (IJavaPeerable) this);
        return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr num = JNIEnv.NewString(value);
        try
        {
          USER_APP_LIST._members.InstanceFields.SetValue("Metadata.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }

    [Register("runStatus")]
    public bool RunStatus
    {
      get
      {
        return USER_APP_LIST._members.InstanceFields.GetBooleanValue("runStatus.Z", (IJavaPeerable) this);
      }
      set
      {
        USER_APP_LIST._members.InstanceFields.SetValue("runStatus.Z", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = USER_APP_LIST._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => USER_APP_LIST._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = USER_APP_LIST._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => USER_APP_LIST._members.ManagedPeerType;

    protected USER_APP_LIST(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe USER_APP_LIST()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = USER_APP_LIST._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      USER_APP_LIST._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
