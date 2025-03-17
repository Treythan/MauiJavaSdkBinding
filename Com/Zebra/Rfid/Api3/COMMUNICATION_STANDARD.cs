// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.COMMUNICATION_STANDARD
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
  [Register("com/zebra/rfid/api3/COMMUNICATION_STANDARD", DoNotGenerateAcw = true)]
  public class COMMUNICATION_STANDARD : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/COMMUNICATION_STANDARD", typeof (COMMUNICATION_STANDARD));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("AUSTRALIA_LIPD_1W")]
    public static COMMUNICATION_STANDARD? AustraliaLipd1w
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("AUSTRALIA_LIPD_1W.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("AUSTRALIA_LIPD_4W")]
    public static COMMUNICATION_STANDARD? AustraliaLipd4w
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("AUSTRALIA_LIPD_4W.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ETSI_300_220")]
    public static COMMUNICATION_STANDARD? Etsi300220
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("ETSI_300_220.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ETSI_302_208")]
    public static COMMUNICATION_STANDARD? Etsi302208
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("ETSI_302_208.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("HONGKONG_OFTA_1049")]
    public static COMMUNICATION_STANDARD? HongkongOfta1049
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("HONGKONG_OFTA_1049.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("JAPAN_ARIB_STD_T89")]
    public static COMMUNICATION_STANDARD? JapanAribStdT89
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("JAPAN_ARIB_STD_T89.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("KOREA_MIC_ARTICLE_5_2")]
    public static COMMUNICATION_STANDARD? KoreaMicArticle52
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("KOREA_MIC_ARTICLE_5_2.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return COMMUNICATION_STANDARD._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        COMMUNICATION_STANDARD._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    [Register("TAIWAN_DGT_LP0002")]
    public static COMMUNICATION_STANDARD? TaiwanDgtLp0002
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("TAIWAN_DGT_LP0002.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("UNSPECIFIED")]
    public static COMMUNICATION_STANDARD? Unspecified
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("UNSPECIFIED.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("US_FCC_PART_15")]
    public static COMMUNICATION_STANDARD? UsFccPart15
    {
      get
      {
        JniObjectReference objectValue = COMMUNICATION_STANDARD._members.StaticFields.GetObjectValue("US_FCC_PART_15.Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;");
        return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = COMMUNICATION_STANDARD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => COMMUNICATION_STANDARD._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = COMMUNICATION_STANDARD._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => COMMUNICATION_STANDARD._members.ManagedPeerType;

    protected COMMUNICATION_STANDARD(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "(Ljava/lang/String;)V", "")]
    public unsafe COMMUNICATION_STANDARD(string? name)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference instance = COMMUNICATION_STANDARD._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        COMMUNICATION_STANDARD._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) COMMUNICATION_STANDARD.cb_getValue == null)
        COMMUNICATION_STANDARD.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(COMMUNICATION_STANDARD.n_GetValue));
      return COMMUNICATION_STANDARD.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<COMMUNICATION_STANDARD>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return COMMUNICATION_STANDARD._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetCommunicationStandard", "(I)Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;", "")]
    public static unsafe COMMUNICATION_STANDARD? GetCommunicationStandard(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = COMMUNICATION_STANDARD._members.StaticMethods.InvokeObjectMethod("GetCommunicationStandard.(I)Lcom/zebra/rfid/api3/COMMUNICATION_STANDARD;", jniArgumentValuePtr);
      return Object.GetObject<COMMUNICATION_STANDARD>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) COMMUNICATION_STANDARD.cb_equals_I == null)
        COMMUNICATION_STANDARD.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(COMMUNICATION_STANDARD.n_Equals_I));
      return COMMUNICATION_STANDARD.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<COMMUNICATION_STANDARD>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return COMMUNICATION_STANDARD._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
