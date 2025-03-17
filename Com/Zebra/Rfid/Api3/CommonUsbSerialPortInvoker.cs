// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.CommonUsbSerialPortInvoker
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Hardware.Usb;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/CommonUsbSerialPort", DoNotGenerateAcw = true)]
  internal class CommonUsbSerialPortInvoker(IntPtr handle, JniHandleOwnership transfer) : 
    CommonUsbSerialPort(handle, transfer)
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/CommonUsbSerialPort", typeof (CommonUsbSerialPortInvoker));

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override JniPeerMembers JniPeerMembers => CommonUsbSerialPortInvoker._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected override Type ThresholdType => CommonUsbSerialPortInvoker._members.ManagedPeerType;

    public override unsafe bool CD
    {
      [Register("getCD", "()Z", "GetGetCDHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getCD.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    public override unsafe bool CTS
    {
      [Register("getCTS", "()Z", "GetGetCTSHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getCTS.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    public override unsafe EnumSet? ControlLines
    {
      [Register("getControlLines", "()Ljava/util/EnumSet;", "GetGetControlLinesHandler")] get
      {
        JniObjectReference jniObjectReference = CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getControlLines.()Ljava/util/EnumSet;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<EnumSet>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    public override unsafe bool DSR
    {
      [Register("getDSR", "()Z", "GetGetDSRHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getDSR.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    public override unsafe bool DTR
    {
      [Register("getDTR", "()Z", "GetGetDTRHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getDTR.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setDTR", "(Z)V", "GetSetDTR_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDTR.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    public override unsafe bool RI
    {
      [Register("getRI", "()Z", "GetGetRIHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getRI.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    public override unsafe bool RTS
    {
      [Register("getRTS", "()Z", "GetGetRTSHandler")] get
      {
        return CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("getRTS.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setRTS", "(Z)V", "GetSetRTS_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setRTS.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    public override unsafe EnumSet? SupportedControlLines
    {
      [Register("getSupportedControlLines", "()Ljava/util/EnumSet;", "GetGetSupportedControlLinesHandler")] get
      {
        JniObjectReference jniObjectReference = CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSupportedControlLines.()Ljava/util/EnumSet;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<EnumSet>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("closeInt", "()V", "GetCloseIntHandler")]
    protected override unsafe void CloseInt()
    {
      CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("closeInt.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("openInt", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpenInt_Landroid_hardware_usb_UsbDeviceConnection_Handler")]
    protected override unsafe void OpenInt(UsbDeviceConnection? p0)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(p0 == null ? IntPtr.Zero : ((Object) p0).Handle)
        };
        CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("openInt.(Landroid/hardware/usb/UsbDeviceConnection;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) p0);
      }
    }

    [Register("setParameters", "(IIII)V", "GetSetParameters_IIIIHandler")]
    public override unsafe void SetParameters(int p0, int p1, int p2, int p3)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[4]
      {
        new JniArgumentValue(p0),
        new JniArgumentValue(p1),
        new JniArgumentValue(p2),
        new JniArgumentValue(p3)
      };
      CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setParameters.(IIII)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    public override unsafe IUsbSerialDriver? Driver
    {
      [Register("getDriver", "()Lcom/zebra/rfid/api3/UsbSerialDriver;", "GetGetDriverHandler")] get
      {
        JniObjectReference jniObjectReference = CommonUsbSerialPortInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDriver.()Lcom/zebra/rfid/api3/UsbSerialDriver;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<IUsbSerialDriver>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }
  }
}
