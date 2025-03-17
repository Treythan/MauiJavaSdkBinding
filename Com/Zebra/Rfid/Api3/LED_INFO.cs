// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LED_INFO
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/LED_INFO", DoNotGenerateAcw = true)]
  public class LED_INFO : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LED_INFO", typeof (LED_INFO));

    [Register("blink")]
    public bool Blink
    {
      get => LED_INFO._members.InstanceFields.GetBooleanValue("blink.Z", (IJavaPeerable) this);
      set => LED_INFO._members.InstanceFields.SetValue("blink.Z", (IJavaPeerable) this, value);
    }

    [Register("duration")]
    public int Duration
    {
      get => LED_INFO._members.InstanceFields.GetInt32Value("duration.I", (IJavaPeerable) this);
      set => LED_INFO._members.InstanceFields.SetValue("duration.I", (IJavaPeerable) this, value);
    }

    [Register("ledColor")]
    public LED_COLOR? LedColor
    {
      get
      {
        JniObjectReference objectValue = LED_INFO._members.InstanceFields.GetObjectValue("ledColor.Lcom/zebra/rfid/api3/LED_COLOR;", (IJavaPeerable) this);
        return Object.GetObject<LED_COLOR>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          LED_INFO._members.InstanceFields.SetValue("ledColor.Lcom/zebra/rfid/api3/LED_COLOR;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("reserved")]
    public IList<int>? Reserved
    {
      get
      {
        JniObjectReference objectValue = LED_INFO._members.InstanceFields.GetObjectValue("reserved.[I", (IJavaPeerable) this);
        return (IList<int>) JavaArray<int>.FromJniHandle(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JavaArray<int>.ToLocalJniHandle(value);
        try
        {
          LED_INFO._members.InstanceFields.SetValue("reserved.[I", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LED_INFO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LED_INFO._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LED_INFO._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LED_INFO._members.ManagedPeerType;

    protected LED_INFO(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe LED_INFO()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = LED_INFO._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      LED_INFO._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
