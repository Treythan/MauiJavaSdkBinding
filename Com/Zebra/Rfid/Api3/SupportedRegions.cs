// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SupportedRegions
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
  [Register("com/zebra/rfid/api3/SupportedRegions", DoNotGenerateAcw = true)]
  public class SupportedRegions : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SupportedRegions", typeof (SupportedRegions));
    private static Delegate? cb_getRegionInfo_I;
    private static Delegate? cb_length;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SupportedRegions._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SupportedRegions._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SupportedRegions._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SupportedRegions._members.ManagedPeerType;

    protected SupportedRegions(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SupportedRegions()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SupportedRegions._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SupportedRegions._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetRegionInfo_IHandler()
    {
      if ((object) SupportedRegions.cb_getRegionInfo_I == null)
        SupportedRegions.cb_getRegionInfo_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_L(SupportedRegions.n_GetRegionInfo_I));
      return SupportedRegions.cb_getRegionInfo_I;
    }

    private static IntPtr n_GetRegionInfo_I(IntPtr jnienv, IntPtr native__this, int index)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<SupportedRegions>(jnienv, native__this, (JniHandleOwnership) 0).GetRegionInfo(index));
    }

    [Register("getRegionInfo", "(I)Lcom/zebra/rfid/api3/RegionInfo;", "GetGetRegionInfo_IHandler")]
    public virtual unsafe RegionInfo? GetRegionInfo(int index)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(index)
      };
      JniObjectReference jniObjectReference = SupportedRegions._members.InstanceMethods.InvokeVirtualObjectMethod("getRegionInfo.(I)Lcom/zebra/rfid/api3/RegionInfo;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<RegionInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetLengthHandler()
    {
      if ((object) SupportedRegions.cb_length == null)
        SupportedRegions.cb_length = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(SupportedRegions.n_Length));
      return SupportedRegions.cb_length;
    }

    private static int n_Length(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<SupportedRegions>(jnienv, native__this, (JniHandleOwnership) 0).Length();
    }

    [Register("length", "()I", "GetLengthHandler")]
    public virtual unsafe int Length()
    {
      return SupportedRegions._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
