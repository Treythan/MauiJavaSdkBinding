// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.SYSTEMTIME
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
  [Register("com/zebra/rfid/api3/SYSTEMTIME", DoNotGenerateAcw = true)]
  public class SYSTEMTIME : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/SYSTEMTIME", typeof (SYSTEMTIME));
    private static Delegate? cb_GetCurrentTime;
    private static Delegate? cb_ConvertTimetoDate;
    private static Delegate? cb_ConvertTimetoString;

    [Register("Day")]
    public short Day
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Day.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Day.S", (IJavaPeerable) this, value);
    }

    [Register("DayOfWeek")]
    public short DayOfWeek
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("DayOfWeek.S", (IJavaPeerable) this);
      set
      {
        SYSTEMTIME._members.InstanceFields.SetValue("DayOfWeek.S", (IJavaPeerable) this, value);
      }
    }

    [Register("Hour")]
    public short Hour
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Hour.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Hour.S", (IJavaPeerable) this, value);
    }

    [Register("Milliseconds")]
    public short Milliseconds
    {
      get
      {
        return SYSTEMTIME._members.InstanceFields.GetInt16Value("Milliseconds.S", (IJavaPeerable) this);
      }
      set
      {
        SYSTEMTIME._members.InstanceFields.SetValue("Milliseconds.S", (IJavaPeerable) this, value);
      }
    }

    [Register("Minute")]
    public short Minute
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Minute.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Minute.S", (IJavaPeerable) this, value);
    }

    [Register("Month")]
    public short Month
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Month.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Month.S", (IJavaPeerable) this, value);
    }

    [Register("Second")]
    public short Second
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Second.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Second.S", (IJavaPeerable) this, value);
    }

    [Register("Year")]
    public short Year
    {
      get => SYSTEMTIME._members.InstanceFields.GetInt16Value("Year.S", (IJavaPeerable) this);
      set => SYSTEMTIME._members.InstanceFields.SetValue("Year.S", (IJavaPeerable) this, value);
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = SYSTEMTIME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => SYSTEMTIME._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = SYSTEMTIME._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => SYSTEMTIME._members.ManagedPeerType;

    protected SYSTEMTIME(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe SYSTEMTIME()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = SYSTEMTIME._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SYSTEMTIME._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(SSSSSSSS)V", "")]
    public unsafe SYSTEMTIME(
      short year,
      short month,
      short day,
      short dayOfWeek,
      short hour,
      short minute,
      short second,
      short milliseconds)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[8]
      {
        new JniArgumentValue(year),
        new JniArgumentValue(month),
        new JniArgumentValue(day),
        new JniArgumentValue(dayOfWeek),
        new JniArgumentValue(hour),
        new JniArgumentValue(minute),
        new JniArgumentValue(second),
        new JniArgumentValue(milliseconds)
      };
      JniObjectReference instance = SYSTEMTIME._members.InstanceMethods.StartCreateInstance("(SSSSSSSS)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      SYSTEMTIME._members.InstanceMethods.FinishCreateInstance("(SSSSSSSS)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetCurrentTimeHandler()
    {
      if ((object) SYSTEMTIME.cb_GetCurrentTime == null)
        SYSTEMTIME.cb_GetCurrentTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SYSTEMTIME.n_GetCurrentTime));
      return SYSTEMTIME.cb_GetCurrentTime;
    }

    private static IntPtr n_GetCurrentTime(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SYSTEMTIME>(jnienv, native__this, (JniHandleOwnership) 0).CurrentTime);
    }

    public virtual unsafe string? CurrentTime
    {
      [Register("GetCurrentTime", "()Ljava/lang/String;", "GetGetCurrentTimeHandler")] get
      {
        JniObjectReference jniObjectReference = SYSTEMTIME._members.InstanceMethods.InvokeVirtualObjectMethod("GetCurrentTime.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetConvertTimetoDateHandler()
    {
      if ((object) SYSTEMTIME.cb_ConvertTimetoDate == null)
        SYSTEMTIME.cb_ConvertTimetoDate = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SYSTEMTIME.n_ConvertTimetoDate));
      return SYSTEMTIME.cb_ConvertTimetoDate;
    }

    private static IntPtr n_ConvertTimetoDate(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SYSTEMTIME>(jnienv, native__this, (JniHandleOwnership) 0).ConvertTimetoDate());
    }

    [Register("ConvertTimetoDate", "()Ljava/lang/String;", "GetConvertTimetoDateHandler")]
    public virtual unsafe string? ConvertTimetoDate()
    {
      JniObjectReference jniObjectReference = SYSTEMTIME._members.InstanceMethods.InvokeVirtualObjectMethod("ConvertTimetoDate.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetConvertTimetoStringHandler()
    {
      if ((object) SYSTEMTIME.cb_ConvertTimetoString == null)
        SYSTEMTIME.cb_ConvertTimetoString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(SYSTEMTIME.n_ConvertTimetoString));
      return SYSTEMTIME.cb_ConvertTimetoString;
    }

    private static IntPtr n_ConvertTimetoString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(Object.GetObject<SYSTEMTIME>(jnienv, native__this, (JniHandleOwnership) 0).ConvertTimetoString());
    }

    [Register("ConvertTimetoString", "()Ljava/lang/String;", "GetConvertTimetoStringHandler")]
    public virtual unsafe string? ConvertTimetoString()
    {
      JniObjectReference jniObjectReference = SYSTEMTIME._members.InstanceMethods.InvokeVirtualObjectMethod("ConvertTimetoString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
