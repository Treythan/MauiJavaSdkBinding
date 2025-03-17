// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RfidUsbCoreService
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
  [Register("com/zebra/rfid/api3/RfidUsbCoreService", DoNotGenerateAcw = true)]
  public class RfidUsbCoreService : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RfidUsbCoreService", typeof (RfidUsbCoreService));
    private static Delegate? cb_ConnectOperation;
    private static Delegate? cb_getReaderInformation;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = RfidUsbCoreService._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RfidUsbCoreService._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RfidUsbCoreService._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RfidUsbCoreService._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RfidUsbCoreService._members.ManagedPeerType;

    protected RfidUsbCoreService(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetConnectOperationHandler()
    {
      if ((object) RfidUsbCoreService.cb_ConnectOperation == null)
        RfidUsbCoreService.cb_ConnectOperation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RfidUsbCoreService.n_ConnectOperation));
      return RfidUsbCoreService.cb_ConnectOperation;
    }

    private static bool n_ConnectOperation(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<RfidUsbCoreService>(jnienv, native__this, (JniHandleOwnership) 0).ConnectOperation();
    }

    [Register("ConnectOperation", "()Z", "GetConnectOperationHandler")]
    public virtual unsafe bool ConnectOperation()
    {
      return RfidUsbCoreService._members.InstanceMethods.InvokeVirtualBooleanMethod("ConnectOperation.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetReaderInformationHandler()
    {
      if ((object) RfidUsbCoreService.cb_getReaderInformation == null)
        RfidUsbCoreService.cb_getReaderInformation = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(RfidUsbCoreService.n_GetReaderInformation));
      return RfidUsbCoreService.cb_getReaderInformation;
    }

    private static void n_GetReaderInformation(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<RfidUsbCoreService>(jnienv, native__this, (JniHandleOwnership) 0).GetReaderInformation();
    }

    [Register("getReaderInformation", "()V", "GetGetReaderInformationHandler")]
    public virtual unsafe void GetReaderInformation()
    {
      RfidUsbCoreService._members.InstanceMethods.InvokeVirtualVoidMethod("getReaderInformation.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
