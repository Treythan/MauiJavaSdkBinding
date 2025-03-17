// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Inventory
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
  [Register("com/zebra/rfid/api3/Inventory", DoNotGenerateAcw = true)]
  public class Inventory : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Inventory", typeof (Inventory));
    private static Delegate? cb_perform;
    private static Delegate? cb_stop;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Inventory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Inventory._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Inventory._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Inventory._members.ManagedPeerType;

    protected Inventory(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetPerformHandler()
    {
      if ((object) Inventory.cb_perform == null)
        Inventory.cb_perform = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Inventory.n_Perform));
      return Inventory.cb_perform;
    }

    private static void n_Perform(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Inventory>(jnienv, native__this, (JniHandleOwnership) 0).Perform();
    }

    [Register("perform", "()V", "GetPerformHandler")]
    public virtual unsafe void Perform()
    {
      Inventory._members.InstanceMethods.InvokeVirtualVoidMethod("perform.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetStopHandler()
    {
      if ((object) Inventory.cb_stop == null)
        Inventory.cb_stop = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(Inventory.n_Stop));
      return Inventory.cb_stop;
    }

    private static void n_Stop(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<Inventory>(jnienv, native__this, (JniHandleOwnership) 0).Stop();
    }

    [Register("stop", "()V", "GetStopHandler")]
    public virtual unsafe void Stop()
    {
      Inventory._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
