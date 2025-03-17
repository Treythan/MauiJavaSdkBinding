// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.DCSSDKDefs
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/DCSSDKDefs", DoNotGenerateAcw = true)]
  public class DCSSDKDefs : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs", typeof (DCSSDKDefs));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = DCSSDKDefs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = DCSSDKDefs._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => DCSSDKDefs._members.ManagedPeerType;

    protected DCSSDKDefs(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe DCSSDKDefs()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = DCSSDKDefs._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      DCSSDKDefs._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_BT_PROTOCOL : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL", typeof (DCSSDKDefs.DCSSDK_BT_PROTOCOL));

      [Register("CRD_BT")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? CrdBt
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("CRD_BT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("CRD_BT_LE")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? CrdBtLe
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("CRD_BT_LE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("HID_BT")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? HidBt
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("HID_BT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("HID_BT_LE")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? HidBtLe
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("HID_BT_LE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("LEGACY_B")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? LegacyB
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("LEGACY_B.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SPP_BT_MASTER")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SppBtMaster
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SPP_BT_MASTER.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SPP_BT_SLAVE")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SppBtSlave
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SPP_BT_SLAVE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SSI_BT_CRADLE_HOST")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SsiBtCradleHost
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SSI_BT_CRADLE_HOST.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SSI_BT_LE")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SsiBtLe
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SSI_BT_LE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SSI_BT_MFI")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SsiBtMfi
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SSI_BT_MFI.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SSI_BT_SSI_SLAVE")]
      public static DCSSDKDefs.DCSSDK_BT_PROTOCOL? SsiBtSsiSlave
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticFields.GetObjectValue("SSI_BT_SSI_SLAVE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_BT_PROTOCOL._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.ManagedPeerType;
      }

      internal DCSSDK_BT_PROTOCOL(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_BT_PROTOCOL? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_PROTOCOL>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_BT_PROTOCOL[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_BT_PROTOCOL._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_PROTOCOL;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_BT_PROTOCOL[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_BT_PROTOCOL));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_BT_SCANNER_CONFIG : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG", typeof (DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG));

      [Register("KEEP_CURRENT")]
      public static DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? KeepCurrent
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.StaticFields.GetObjectValue("KEEP_CURRENT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("RESTORE_FACTORY_DEFAULTS")]
      public static DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? RestoreFactoryDefaults
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.StaticFields.GetObjectValue("RESTORE_FACTORY_DEFAULTS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SET_FACTORY_DEFAULTS")]
      public static DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? SetFactoryDefaults
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.StaticFields.GetObjectValue("SET_FACTORY_DEFAULTS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.ManagedPeerType;
      }

      internal DCSSDK_BT_SCANNER_CONFIG(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_BT_SCANNER_CONFIG;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_BT_SCANNER_CONFIG));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_COMMAND_OPCODE : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE", typeof (DCSSDKDefs.DCSSDK_COMMAND_OPCODE));

      [Register("DCSSDK_ABORT_UPDATE_FIRMWARE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkAbortUpdateFirmware
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_ABORT_UPDATE_FIRMWARE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_AIM_OFF")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceAimOff
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_AIM_OFF.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_AIM_ON")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceAimOn
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_AIM_ON.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_BARCODE_MODE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceBarcodeMode
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_BARCODE_MODE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_BATCH_REQUEST")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceBatchRequest
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_BATCH_REQUEST.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_IMAGE_MODE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceImageMode
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_IMAGE_MODE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_PULL_TRIGGER")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDevicePullTrigger
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_PULL_TRIGGER.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_RELEASE_TRIGGER")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceReleaseTrigger
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_RELEASE_TRIGGER.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_SCAN_DISABLE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceScanDisable
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_SCAN_DISABLE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_SCAN_ENABLE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceScanEnable
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_SCAN_ENABLE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_VIBRATION_FEEDBACK")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceVibrationFeedback
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_VIBRATION_FEEDBACK.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DEVICE_VIDEO_MODE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDeviceVideoMode
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DEVICE_VIDEO_MODE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_DISABLE_SCALE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkDisableScale
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_DISABLE_SCALE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_ENABLE_SCALE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkEnableScale
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_ENABLE_SCALE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_READ_WEIGHT")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkReadWeight
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_READ_WEIGHT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESET_SCALE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkResetScale
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_RESET_SCALE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RSM_ATTR_GET")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkRsmAttrGet
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_RSM_ATTR_GET.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RSM_ATTR_GETALL")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkRsmAttrGetall
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_RSM_ATTR_GETALL.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RSM_ATTR_SET")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkRsmAttrSet
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_RSM_ATTR_SET.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RSM_ATTR_STORE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkRsmAttrStore
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_RSM_ATTR_STORE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_SET_ACTION")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkSetAction
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_SET_ACTION.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_START_NEW_FIRMWARE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkStartNewFirmware
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_START_NEW_FIRMWARE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_UPDATE_FIRMWARE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkUpdateFirmware
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_UPDATE_FIRMWARE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_ZERO_SCALE")]
      public static DCSSDKDefs.DCSSDK_COMMAND_OPCODE? DcssdkZeroScale
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticFields.GetObjectValue("DCSSDK_ZERO_SCALE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.ManagedPeerType;
      }

      internal DCSSDK_COMMAND_OPCODE(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_COMMAND_OPCODE? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_COMMAND_OPCODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_COMMAND_OPCODE[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_COMMAND_OPCODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_COMMAND_OPCODE;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_COMMAND_OPCODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_COMMAND_OPCODE));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_CONN_TYPES : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES", typeof (DCSSDKDefs.DCSSDK_CONN_TYPES));

      [Register("DCSSDK_CONNTYPE_BT_LE")]
      public static DCSSDKDefs.DCSSDK_CONN_TYPES? DcssdkConntypeBtLe
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticFields.GetObjectValue("DCSSDK_CONNTYPE_BT_LE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_CONNTYPE_BT_NORMAL")]
      public static DCSSDKDefs.DCSSDK_CONN_TYPES? DcssdkConntypeBtNormal
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticFields.GetObjectValue("DCSSDK_CONNTYPE_BT_NORMAL.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_CONNTYPE_INVALID")]
      public static DCSSDKDefs.DCSSDK_CONN_TYPES? DcssdkConntypeInvalid
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticFields.GetObjectValue("DCSSDK_CONNTYPE_INVALID.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_CONNTYPE_USB_CDC")]
      public static DCSSDKDefs.DCSSDK_CONN_TYPES? DcssdkConntypeUsbCdc
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticFields.GetObjectValue("DCSSDK_CONNTYPE_USB_CDC.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_CONNTYPE_USB_SNAPI")]
      public static DCSSDKDefs.DCSSDK_CONN_TYPES? DcssdkConntypeUsbSnapi
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticFields.GetObjectValue("DCSSDK_CONNTYPE_USB_SNAPI.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_CONN_TYPES._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_CONN_TYPES._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_CONN_TYPES._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_CONN_TYPES._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_CONN_TYPES._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DCSSDKDefs.DCSSDK_CONN_TYPES._members.ManagedPeerType;

      internal DCSSDK_CONN_TYPES(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_CONN_TYPES? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_CONN_TYPES>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_CONN_TYPES[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_CONN_TYPES._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_CONN_TYPES;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_CONN_TYPES[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_CONN_TYPES));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_EVENT : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT", typeof (DCSSDKDefs.DCSSDK_EVENT));

      [Register("DCSSDK_EVENT_BARCODE")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventBarcode
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_BARCODE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_BINARY_DATA")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventBinaryData
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_BINARY_DATA.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_IMAGE")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventImage
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_IMAGE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_SCANNER_APPEARANCE")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventScannerAppearance
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_SCANNER_APPEARANCE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_SCANNER_DISAPPEARANCE")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventScannerDisappearance
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_SCANNER_DISAPPEARANCE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_SESSION_ESTABLISHMENT")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventSessionEstablishment
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_SESSION_ESTABLISHMENT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_SESSION_TERMINATION")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventSessionTermination
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_SESSION_TERMINATION.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_EVENT_VIDEO")]
      public static DCSSDKDefs.DCSSDK_EVENT? DcssdkEventVideo
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_EVENT._members.StaticFields.GetObjectValue("DCSSDK_EVENT_VIDEO.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_EVENT._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_EVENT._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_EVENT._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_EVENT._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_EVENT._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DCSSDKDefs.DCSSDK_EVENT._members.ManagedPeerType;

      internal DCSSDK_EVENT(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_EVENT? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_EVENT._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_EVENT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_EVENT[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_EVENT._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_EVENT;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_EVENT[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_EVENT));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_FU_EVENT_TYPE : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE", typeof (DCSSDKDefs.DCSSDK_FU_EVENT_TYPE));

      [Register("SCANNER_UF_DL_END")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfDlEnd
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_DL_END.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_UF_DL_PROGRESS")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfDlProgress
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_DL_PROGRESS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_UF_DL_START")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfDlStart
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_DL_START.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_UF_SESS_END")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfSessEnd
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_SESS_END.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_UF_SESS_START")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfSessStart
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_SESS_START.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("SCANNER_UF_STATUS")]
      public static DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ScannerUfStatus
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticFields.GetObjectValue("SCANNER_UF_STATUS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.ManagedPeerType;
      }

      internal DCSSDK_FU_EVENT_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_FU_EVENT_TYPE? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_FU_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_FU_EVENT_TYPE[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_FU_EVENT_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_FU_EVENT_TYPE;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_FU_EVENT_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_FU_EVENT_TYPE));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_IMAGE_TYPE : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE", typeof (DCSSDKDefs.DCSSDK_IMAGE_TYPE));

      [Register("BMP_IMAGE")]
      public static DCSSDKDefs.DCSSDK_IMAGE_TYPE? BmpImage
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticFields.GetObjectValue("BMP_IMAGE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_IMAGE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("INVALID_IMAGE")]
      public static DCSSDKDefs.DCSSDK_IMAGE_TYPE? InvalidImage
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticFields.GetObjectValue("INVALID_IMAGE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_IMAGE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("JPEG_IMAGE")]
      public static DCSSDKDefs.DCSSDK_IMAGE_TYPE? JpegImage
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticFields.GetObjectValue("JPEG_IMAGE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_IMAGE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("TIFF_IMAGE")]
      public static DCSSDKDefs.DCSSDK_IMAGE_TYPE? TiffImage
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticFields.GetObjectValue("TIFF_IMAGE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_IMAGE_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_IMAGE_TYPE._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.ManagedPeerType;

      internal DCSSDK_IMAGE_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_IMAGE_TYPE? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_IMAGE_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_IMAGE_TYPE[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_IMAGE_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_IMAGE_TYPE;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_IMAGE_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_IMAGE_TYPE));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_MODE : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE", typeof (DCSSDKDefs.DCSSDK_MODE));

      [Register("DCSSDK_OPMODE_BT_LE")]
      public static DCSSDKDefs.DCSSDK_MODE? DcssdkOpmodeBtLe
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_MODE._members.StaticFields.GetObjectValue("DCSSDK_OPMODE_BT_LE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_OPMODE_BT_NORMAL")]
      public static DCSSDKDefs.DCSSDK_MODE? DcssdkOpmodeBtNormal
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_MODE._members.StaticFields.GetObjectValue("DCSSDK_OPMODE_BT_NORMAL.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_OPMODE_DISABLED")]
      public static DCSSDKDefs.DCSSDK_MODE? DcssdkOpmodeDisabled
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_MODE._members.StaticFields.GetObjectValue("DCSSDK_OPMODE_DISABLED.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_OPMODE_SNAPI")]
      public static DCSSDKDefs.DCSSDK_MODE? DcssdkOpmodeSnapi
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_MODE._members.StaticFields.GetObjectValue("DCSSDK_OPMODE_SNAPI.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_OPMODE_USB_CDC")]
      public static DCSSDKDefs.DCSSDK_MODE? DcssdkOpmodeUsbCdc
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_MODE._members.StaticFields.GetObjectValue("DCSSDK_OPMODE_USB_CDC.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("value")]
      public int Value
      {
        get
        {
          return DCSSDKDefs.DCSSDK_MODE._members.InstanceFields.GetInt32Value("value.I", (IJavaPeerable) this);
        }
        set
        {
          DCSSDKDefs.DCSSDK_MODE._members.InstanceFields.SetValue("value.I", (IJavaPeerable) this, value);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_MODE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_MODE._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_MODE._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DCSSDKDefs.DCSSDK_MODE._members.ManagedPeerType;

      internal DCSSDK_MODE(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_MODE? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_MODE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_MODE[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_MODE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_MODE;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_MODE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_MODE));
      }
    }

    [Register("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT", DoNotGenerateAcw = true)]
    public sealed class DCSSDK_RESULT : Enum
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT", typeof (DCSSDKDefs.DCSSDK_RESULT));

      [Register("DCSSDK_RESULT_FAILURE")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFailure
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FAILURE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_ABORTED")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateAborted
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_ABORTED.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_COMMANDS_ARE_OUT_OF_SYNC")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateFailedCommandsAreOutOfSync
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_COMMANDS_ARE_OUT_OF_SYNC.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_HAS_OVERLAPPING_ADDRESS")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateFailedHasOverlappingAddress
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_HAS_OVERLAPPING_ADDRESS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_LOAD_COUNT_ERROR")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateFailedLoadCountError
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_LOAD_COUNT_ERROR.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_LOW_BATTERY_LEVEL")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateFailedLowBatteryLevel
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_FAILED_LOW_BATTERY_LEVEL.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_FIRMWARE_UPDATE_IN_PROGRESS")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultFirmwareUpdateInProgress
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_FIRMWARE_UPDATE_IN_PROGRESS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_INVALID_PARAMS")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultInvalidParams
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_INVALID_PARAMS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_OPCODE_NOT_SUPPORTED")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultOpcodeNotSupported
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_OPCODE_NOT_SUPPORTED.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_RESPONSE_TIMEOUT")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultResponseTimeout
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_RESPONSE_TIMEOUT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_SCALE_NOT_PRESENT")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultScaleNotPresent
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_SCALE_NOT_PRESENT.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_SCANNER_ALREADY_ACTIVE")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultScannerAlreadyActive
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_SCANNER_ALREADY_ACTIVE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_SCANNER_NOT_ACTIVE")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultScannerNotActive
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_SCANNER_NOT_ACTIVE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_SCANNER_NOT_AVAILABLE")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultScannerNotAvailable
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_SCANNER_NOT_AVAILABLE.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      [Register("DCSSDK_RESULT_SUCCESS")]
      public static DCSSDKDefs.DCSSDK_RESULT? DcssdkResultSuccess
      {
        get
        {
          JniObjectReference objectValue = DCSSDKDefs.DCSSDK_RESULT._members.StaticFields.GetObjectValue("DCSSDK_RESULT_SUCCESS.Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;");
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_RESULT._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => DCSSDKDefs.DCSSDK_RESULT._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = DCSSDKDefs.DCSSDK_RESULT._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => DCSSDKDefs.DCSSDK_RESULT._members.ManagedPeerType;

      internal DCSSDK_RESULT(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      public unsafe int Value
      {
        [Register("getValue", "()I", "")] get
        {
          return DCSSDKDefs.DCSSDK_RESULT._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      [Register("getDCSDKResultByValue", "(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_RESULT? GetDCSDKResultByValue(int value)
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_RESULT._members.StaticMethods.InvokeObjectMethod("getDCSDKResultByValue.(I)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", jniArgumentValuePtr);
        return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }

      [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_RESULT? ValueOf(string? name)
      {
        IntPtr num = JNIEnv.NewString(name);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_RESULT._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", jniArgumentValuePtr);
          return Object.GetObject<DCSSDKDefs.DCSSDK_RESULT>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      [Register("values", "()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", "")]
      public static unsafe DCSSDKDefs.DCSSDK_RESULT[]? Values()
      {
        JniObjectReference jniObjectReference = DCSSDKDefs.DCSSDK_RESULT._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/scannercontrol/DCSSDKDefs$DCSSDK_RESULT;", (JniArgumentValue*) null);
        return (DCSSDKDefs.DCSSDK_RESULT[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (DCSSDKDefs.DCSSDK_RESULT));
      }
    }
  }
}
