// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TRACE_LEVEL
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
  [Register("com/zebra/rfid/api3/TRACE_LEVEL", DoNotGenerateAcw = true)]
  public class TRACE_LEVEL : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TRACE_LEVEL", typeof (TRACE_LEVEL));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ordinal")]
    public int Ordinal
    {
      get => TRACE_LEVEL._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      set => TRACE_LEVEL._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
    }

    [Register("TRACE_LEVEL_ALL")]
    public static TRACE_LEVEL? TraceLevelAll
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_ALL.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_ERROR")]
    public static TRACE_LEVEL? TraceLevelError
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_ERROR.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_FATAL")]
    public static TRACE_LEVEL? TraceLevelFatal
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_FATAL.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_INFO")]
    public static TRACE_LEVEL? TraceLevelInfo
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_INFO.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_OFF")]
    public static TRACE_LEVEL? TraceLevelOff
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_OFF.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_VERBOSE")]
    public static TRACE_LEVEL? TraceLevelVerbose
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_VERBOSE.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("TRACE_LEVEL_WARNING")]
    public static TRACE_LEVEL? TraceLevelWarning
    {
      get
      {
        JniObjectReference objectValue = TRACE_LEVEL._members.StaticFields.GetObjectValue("TRACE_LEVEL_WARNING.Lcom/zebra/rfid/api3/TRACE_LEVEL;");
        return Object.GetObject<TRACE_LEVEL>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TRACE_LEVEL._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TRACE_LEVEL._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TRACE_LEVEL._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TRACE_LEVEL._members.ManagedPeerType;

    protected TRACE_LEVEL(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) TRACE_LEVEL.cb_getValue == null)
        TRACE_LEVEL.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TRACE_LEVEL.n_GetValue));
      return TRACE_LEVEL.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TRACE_LEVEL>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return TRACE_LEVEL._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) TRACE_LEVEL.cb_equals_I == null)
        TRACE_LEVEL.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(TRACE_LEVEL.n_Equals_I));
      return TRACE_LEVEL.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<TRACE_LEVEL>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return TRACE_LEVEL._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
