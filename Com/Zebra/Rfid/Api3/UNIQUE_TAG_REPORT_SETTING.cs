// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.UNIQUE_TAG_REPORT_SETTING
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
  [Register("com/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING", DoNotGenerateAcw = true)]
  public class UNIQUE_TAG_REPORT_SETTING : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING", typeof (UNIQUE_TAG_REPORT_SETTING));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("DISABLE")]
    public static UNIQUE_TAG_REPORT_SETTING? Disable
    {
      get
      {
        JniObjectReference objectValue = UNIQUE_TAG_REPORT_SETTING._members.StaticFields.GetObjectValue("DISABLE.Lcom/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING;");
        return Object.GetObject<UNIQUE_TAG_REPORT_SETTING>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ENABLE")]
    public static UNIQUE_TAG_REPORT_SETTING? Enable
    {
      get
      {
        JniObjectReference objectValue = UNIQUE_TAG_REPORT_SETTING._members.StaticFields.GetObjectValue("ENABLE.Lcom/zebra/rfid/api3/UNIQUE_TAG_REPORT_SETTING;");
        return Object.GetObject<UNIQUE_TAG_REPORT_SETTING>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return UNIQUE_TAG_REPORT_SETTING._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        UNIQUE_TAG_REPORT_SETTING._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = UNIQUE_TAG_REPORT_SETTING._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => UNIQUE_TAG_REPORT_SETTING._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = UNIQUE_TAG_REPORT_SETTING._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => UNIQUE_TAG_REPORT_SETTING._members.ManagedPeerType;

    protected UNIQUE_TAG_REPORT_SETTING(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) UNIQUE_TAG_REPORT_SETTING.cb_getValue == null)
        UNIQUE_TAG_REPORT_SETTING.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(UNIQUE_TAG_REPORT_SETTING.n_GetValue));
      return UNIQUE_TAG_REPORT_SETTING.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<UNIQUE_TAG_REPORT_SETTING>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return UNIQUE_TAG_REPORT_SETTING._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetUniqueTagReportSetting", "(I)Ljava/lang/Object;", "")]
    public static unsafe Object? GetUniqueTagReportSetting(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = UNIQUE_TAG_REPORT_SETTING._members.StaticMethods.InvokeObjectMethod("GetUniqueTagReportSetting.(I)Ljava/lang/Object;", jniArgumentValuePtr);
      return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) UNIQUE_TAG_REPORT_SETTING.cb_equals_I == null)
        UNIQUE_TAG_REPORT_SETTING.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(UNIQUE_TAG_REPORT_SETTING.n_Equals_I));
      return UNIQUE_TAG_REPORT_SETTING.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<UNIQUE_TAG_REPORT_SETTING>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return UNIQUE_TAG_REPORT_SETTING._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
