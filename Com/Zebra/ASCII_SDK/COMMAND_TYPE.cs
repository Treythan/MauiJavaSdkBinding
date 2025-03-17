// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.COMMAND_TYPE
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
  [Register("com/zebra/ASCII_SDK/COMMAND_TYPE", DoNotGenerateAcw = true)]
  public sealed class COMMAND_TYPE : Enum
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/COMMAND_TYPE", typeof (COMMAND_TYPE));

    [Register("BATTERY_STATS")]
    public static COMMAND_TYPE? BatteryStats
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("BATTERY_STATS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_ADMCONNECT")]
    public static COMMAND_TYPE? CommandAdmconnect
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_ADMCONNECT.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_ADMDISCONNECT")]
    public static COMMAND_TYPE? CommandAdmdisconnect
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_ADMDISCONNECT.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_ADMLISTCONNECTIONS")]
    public static COMMAND_TYPE? CommandAdmlistconnections
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_ADMLISTCONNECTIONS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_ADMPASSWORD")]
    public static COMMAND_TYPE? CommandAdmpassword
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_ADMPASSWORD.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_AUTHENTICATE")]
    public static COMMAND_TYPE? CommandAuthenticate
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_AUTHENTICATE.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_BLOCKERASE")]
    public static COMMAND_TYPE? CommandBlockerase
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_BLOCKERASE.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_BLOCKPERMALOCK")]
    public static COMMAND_TYPE? CommandBlockpermalock
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_BLOCKPERMALOCK.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_BRANDCHECK")]
    public static COMMAND_TYPE? CommandBrandcheck
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_BRANDCHECK.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_BTCONFIG")]
    public static COMMAND_TYPE? CommandBtconfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_BTCONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_CHARGETERMINAL")]
    public static COMMAND_TYPE? CommandChargeterminal
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_CHARGETERMINAL.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_CONNECT")]
    public static COMMAND_TYPE? CommandConnect
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_CONNECT.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_CRYPTO")]
    public static COMMAND_TYPE? CommandCrypto
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_CRYPTO.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_GETATTRINFO")]
    public static COMMAND_TYPE? CommandGetattrinfo
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_GETATTRINFO.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_GETDEVICEINFO")]
    public static COMMAND_TYPE? CommandGetdeviceinfo
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_GETDEVICEINFO.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_GETTAGS")]
    public static COMMAND_TYPE? CommandGettags
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_GETTAGS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_INVENTORY")]
    public static COMMAND_TYPE? CommandInventory
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_INVENTORY.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_KEYMAP")]
    public static COMMAND_TYPE? CommandKeymap
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_KEYMAP.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_KILL")]
    public static COMMAND_TYPE? CommandKill
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_KILL.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_LOCK")]
    public static COMMAND_TYPE? CommandLock
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_LOCK.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_NETWORK")]
    public static COMMAND_TYPE? CommandNetwork
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_NETWORK.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_PROTOCOLCONFIG")]
    public static COMMAND_TYPE? CommandProtocolconfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_PROTOCOLCONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_READ")]
    public static COMMAND_TYPE? CommandRead
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_READ.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_READBUFFER")]
    public static COMMAND_TYPE? CommandReadbuffer
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_READBUFFER.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETACCESSCRITERIA")]
    public static COMMAND_TYPE? CommandSetaccesscriteria
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETACCESSCRITERIA.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETANTENNACONFIGURATION")]
    public static COMMAND_TYPE? CommandSetantennaconfiguration
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETANTENNACONFIGURATION.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETATTR")]
    public static COMMAND_TYPE? CommandSetattr
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETATTR.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETDYNAMICPOWER")]
    public static COMMAND_TYPE? CommandSetdynamicpower
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETDYNAMICPOWER.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETQUERYPARAMS")]
    public static COMMAND_TYPE? CommandSetqueryparams
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETQUERYPARAMS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETREGULATORY")]
    public static COMMAND_TYPE? CommandSetregulatory
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETREGULATORY.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETREPORTCONFIG")]
    public static COMMAND_TYPE? CommandSetreportconfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETREPORTCONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETSELECTRECORDS")]
    public static COMMAND_TYPE? CommandSetselectrecords
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETSELECTRECORDS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETSTARTTRIGGER")]
    public static COMMAND_TYPE? CommandSetstarttrigger
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETSTARTTRIGGER.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETSTOPTRIGGER")]
    public static COMMAND_TYPE? CommandSetstoptrigger
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETSTOPTRIGGER.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_SETUNIQUEREPORT")]
    public static COMMAND_TYPE? CommandSetuniquereport
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_SETUNIQUEREPORT.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_UNTRACEABLE")]
    public static COMMAND_TYPE? CommandUntraceable
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_UNTRACEABLE.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_USERFEEDBACK")]
    public static COMMAND_TYPE? CommandUserfeedback
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_USERFEEDBACK.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_WIFICONFIG")]
    public static COMMAND_TYPE? CommandWificonfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_WIFICONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_WPACONFIG")]
    public static COMMAND_TYPE? CommandWpaconfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_WPACONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("COMMAND_WRITE")]
    public static COMMAND_TYPE? CommandWrite
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("COMMAND_WRITE.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("CRADLE_STATUS")]
    public static COMMAND_TYPE? CradleStatus
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("CRADLE_STATUS.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("NON_CONFIG")]
    public static COMMAND_TYPE? NonConfig
    {
      get
      {
        JniObjectReference objectValue = COMMAND_TYPE._members.StaticFields.GetObjectValue("NON_CONFIG.Lcom/zebra/ASCII_SDK/COMMAND_TYPE;");
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = COMMAND_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => COMMAND_TYPE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = COMMAND_TYPE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => COMMAND_TYPE._members.ManagedPeerType;

    internal COMMAND_TYPE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register("valueOf", "(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "")]
    public static unsafe COMMAND_TYPE? ValueOf(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = COMMAND_TYPE._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", jniArgumentValuePtr);
        return Object.GetObject<COMMAND_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("values", "()[Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", "")]
    public static unsafe COMMAND_TYPE[]? Values()
    {
      JniObjectReference jniObjectReference = COMMAND_TYPE._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/zebra/ASCII_SDK/COMMAND_TYPE;", (JniArgumentValue*) null);
      return (COMMAND_TYPE[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (COMMAND_TYPE));
    }
  }
}
