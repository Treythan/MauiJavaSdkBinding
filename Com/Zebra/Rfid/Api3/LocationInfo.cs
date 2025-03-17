// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.LocationInfo
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
  [Register("com/zebra/rfid/api3/LocationInfo", DoNotGenerateAcw = true)]
  public class LocationInfo : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/LocationInfo", typeof (LocationInfo));
    private static Delegate? cb_getRelativeDistance;
    private static Delegate? cb_getTagNumber;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = LocationInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => LocationInfo._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = LocationInfo._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => LocationInfo._members.ManagedPeerType;

    protected LocationInfo(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetRelativeDistanceHandler()
    {
      if ((object) LocationInfo.cb_getRelativeDistance == null)
        LocationInfo.cb_getRelativeDistance = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(LocationInfo.n_GetRelativeDistance));
      return LocationInfo.cb_getRelativeDistance;
    }

    private static short n_GetRelativeDistance(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LocationInfo>(jnienv, native__this, (JniHandleOwnership) 0).RelativeDistance;
    }

    public virtual unsafe short RelativeDistance
    {
      [Register("getRelativeDistance", "()S", "GetGetRelativeDistanceHandler")] get
      {
        return LocationInfo._members.InstanceMethods.InvokeVirtualInt16Method("getRelativeDistance.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTagNumberHandler()
    {
      if ((object) LocationInfo.cb_getTagNumber == null)
        LocationInfo.cb_getTagNumber = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(LocationInfo.n_GetTagNumber));
      return LocationInfo.cb_getTagNumber;
    }

    private static short n_GetTagNumber(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<LocationInfo>(jnienv, native__this, (JniHandleOwnership) 0).TagNumber;
    }

    public virtual unsafe short TagNumber
    {
      [Register("getTagNumber", "()S", "GetGetTagNumberHandler")] get
      {
        return LocationInfo._members.InstanceMethods.InvokeVirtualInt16Method("getTagNumber.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }
  }
}
