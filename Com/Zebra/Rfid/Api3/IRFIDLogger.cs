// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IRFIDLogger
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Logging;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/IRFIDLogger", DoNotGenerateAcw = true)]
  public class IRFIDLogger : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IRFIDLogger", typeof (IRFIDLogger));
    private static Delegate? cb_EnableDebugLogs_Z;
    private static Delegate? cb_addHandler_Ljava_util_logging_MemoryHandler_;
    private static Delegate? cb_getLogConfig_Ljava_lang_String_;
    private static Delegate? cb_getRfidReaderLogs_Ljava_lang_String_Z;
    private static Delegate? cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
    private static Delegate? cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_;
    private static Delegate? cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_setLevel_Ljava_util_logging_Level_;
    private static Delegate? cb_setLogConfig_Ljava_lang_String_Z;
    private static Delegate? cb_setRFIDReader;
    private static Delegate? cb_setRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_;
    private static Delegate? cb_setRfidReaderLog_Ljava_lang_String_Z;

    [Register("mBufferedLogState")]
    public bool MBufferedLogState
    {
      get
      {
        return IRFIDLogger._members.InstanceFields.GetBooleanValue("mBufferedLogState.Z", (IJavaPeerable) this);
      }
      set
      {
        IRFIDLogger._members.InstanceFields.SetValue("mBufferedLogState.Z", (IJavaPeerable) this, value);
      }
    }

    [Register("mDebugLoggerState")]
    public bool MDebugLoggerState
    {
      get
      {
        return IRFIDLogger._members.InstanceFields.GetBooleanValue("mDebugLoggerState.Z", (IJavaPeerable) this);
      }
      set
      {
        IRFIDLogger._members.InstanceFields.SetValue("mDebugLoggerState.Z", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = IRFIDLogger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IRFIDLogger._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = IRFIDLogger._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IRFIDLogger._members.ManagedPeerType;

    protected IRFIDLogger(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe IRFIDLogger()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = IRFIDLogger._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      IRFIDLogger._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetEnableDebugLogs_ZHandler()
    {
      if ((object) IRFIDLogger.cb_EnableDebugLogs_Z == null)
        IRFIDLogger.cb_EnableDebugLogs_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(IRFIDLogger.n_EnableDebugLogs_Z));
      return IRFIDLogger.cb_EnableDebugLogs_Z;
    }

    private static void n_EnableDebugLogs_Z(IntPtr jnienv, IntPtr native__this, bool state)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).EnableDebugLogs(state);
    }

    [Register("EnableDebugLogs", "(Z)V", "GetEnableDebugLogs_ZHandler")]
    public virtual unsafe void EnableDebugLogs(bool state)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(state)
      };
      IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("EnableDebugLogs.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetAddHandler_Ljava_util_logging_MemoryHandler_Handler()
    {
      if ((object) IRFIDLogger.cb_addHandler_Ljava_util_logging_MemoryHandler_ == null)
        IRFIDLogger.cb_addHandler_Ljava_util_logging_MemoryHandler_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IRFIDLogger.n_AddHandler_Ljava_util_logging_MemoryHandler_));
      return IRFIDLogger.cb_addHandler_Ljava_util_logging_MemoryHandler_;
    }

    private static void n_AddHandler_Ljava_util_logging_MemoryHandler_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_memoryHandler)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).AddHandler(Object.GetObject<MemoryHandler>(native_memoryHandler, (JniHandleOwnership) 0));
    }

    [Register("addHandler", "(Ljava/util/logging/MemoryHandler;)V", "GetAddHandler_Ljava_util_logging_MemoryHandler_Handler")]
    public virtual unsafe void AddHandler(MemoryHandler? memoryHandler)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(memoryHandler == null ? IntPtr.Zero : ((Object) memoryHandler).Handle)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("addHandler.(Ljava/util/logging/MemoryHandler;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) memoryHandler);
      }
    }

    private static Delegate GetGetLogConfig_Ljava_lang_String_Handler()
    {
      if ((object) IRFIDLogger.cb_getLogConfig_Ljava_lang_String_ == null)
        IRFIDLogger.cb_getLogConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_L(IRFIDLogger.n_GetLogConfig_Ljava_lang_String_));
      return IRFIDLogger.cb_getLogConfig_Ljava_lang_String_;
    }

    private static IntPtr n_GetLogConfig_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_name)
    {
      return JNIEnv.NewString(Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).GetLogConfig(JNIEnv.GetString(native_name, (JniHandleOwnership) 0)));
    }

    [Register("getLogConfig", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLogConfig_Ljava_lang_String_Handler")]
    public virtual unsafe string? GetLogConfig(string? name)
    {
      IntPtr num = JNIEnv.NewString(name);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = IRFIDLogger._members.InstanceMethods.InvokeVirtualObjectMethod("getLogConfig.(Ljava/lang/String;)Ljava/lang/String;", (IJavaPeerable) this, jniArgumentValuePtr);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("getLogger", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/IRFIDLogger;", "")]
    public static unsafe IRFIDLogger? GetLogger(string? rfidapi3)
    {
      IntPtr num = JNIEnv.NewString(rfidapi3);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = IRFIDLogger._members.StaticMethods.InvokeObjectMethod("getLogger.(Ljava/lang/String;)Lcom/zebra/rfid/api3/IRFIDLogger;", jniArgumentValuePtr);
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("getLogger", "(Ljava/lang/String;Lcom/zebra/rfid/api3/IRFIDReader;)Lcom/zebra/rfid/api3/IRFIDLogger;", "")]
    public static unsafe IRFIDLogger? GetLogger(string? rfidapi3, IRFIDReader? reader)
    {
      IntPtr num = JNIEnv.NewString(rfidapi3);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(reader == null ? IntPtr.Zero : reader.Handle)
        };
        JniObjectReference jniObjectReference = IRFIDLogger._members.StaticMethods.InvokeObjectMethod("getLogger.(Ljava/lang/String;Lcom/zebra/rfid/api3/IRFIDReader;)Lcom/zebra/rfid/api3/IRFIDLogger;", jniArgumentValuePtr);
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) reader);
      }
    }

    private static Delegate GetGetRfidReaderLogs_Ljava_lang_String_ZHandler()
    {
      if ((object) IRFIDLogger.cb_getRfidReaderLogs_Ljava_lang_String_Z == null)
        IRFIDLogger.cb_getRfidReaderLogs_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(IRFIDLogger.n_GetRfidReaderLogs_Ljava_lang_String_Z));
      return IRFIDLogger.cb_getRfidReaderLogs_Ljava_lang_String_Z;
    }

    private static void n_GetRfidReaderLogs_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logtype,
      bool state)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).GetRfidReaderLogs(JNIEnv.GetString(native_logtype, (JniHandleOwnership) 0), state);
    }

    [Register("getRfidReaderLogs", "(Ljava/lang/String;Z)V", "GetGetRfidReaderLogs_Ljava_lang_String_ZHandler")]
    public virtual unsafe void GetRfidReaderLogs(string? logtype, bool state)
    {
      IntPtr num = JNIEnv.NewString(logtype);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(state)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("getRfidReaderLogs.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler()
    {
      if ((object) IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_ == null)
        IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(IRFIDLogger.n_Log_Ljava_util_logging_Level_Ljava_lang_String_));
      return IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_;
    }

    private static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_info,
      IntPtr native_s)
    {
      IRFIDLogger irfidLogger = Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0);
      Level level = Object.GetObject<Level>(native_info, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_s, (JniHandleOwnership) 0);
      Level info = level;
      string s = str;
      irfidLogger.Log(info, s);
    }

    [Register("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Handler")]
    public virtual unsafe void Log(Level? info, string? s)
    {
      IntPtr num = JNIEnv.NewString(s);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(info == null ? IntPtr.Zero : ((Object) info).Handle),
          new JniArgumentValue(num)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/util/logging/Level;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) info);
      }
    }

    private static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_Handler()
    {
      if ((object) IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_ == null)
        IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(IRFIDLogger.n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_));
      return IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_;
    }

    private static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_warning,
      IntPtr native_s,
      IntPtr native_se)
    {
      IRFIDLogger irfidLogger = Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0);
      Level level = Object.GetObject<Level>(native_warning, (JniHandleOwnership) 0);
      string str = JNIEnv.GetString(native_s, (JniHandleOwnership) 0);
      Exception exception = Object.GetObject<Exception>(native_se, (JniHandleOwnership) 0);
      Level warning = level;
      string s = str;
      Exception se = exception;
      irfidLogger.Log(warning, s, se);
    }

    [Register("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Exception;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_Exception_Handler")]
    public virtual unsafe void Log(Level? warning, string? s, Exception? se)
    {
      IntPtr num = JNIEnv.NewString(s);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(warning == null ? IntPtr.Zero : ((Object) warning).Handle),
          new JniArgumentValue(num),
          new JniArgumentValue(se == null ? IntPtr.Zero : ((Throwable) se).Handle)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Exception;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
        GC.KeepAlive((object) warning);
        GC.KeepAlive((object) se);
      }
    }

    private static Delegate GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_ == null)
        IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLL_V(IRFIDLogger.n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_));
      return IRFIDLogger.cb_log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_;
    }

    private static void n_Log_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_warning,
      IntPtr native_s,
      IntPtr native_stackTraceString)
    {
      IRFIDLogger irfidLogger = Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0);
      Level level = Object.GetObject<Level>(native_warning, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_s, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_stackTraceString, (JniHandleOwnership) 0);
      Level warning = level;
      string s = str1;
      string stackTraceString = str2;
      irfidLogger.Log(warning, s, stackTraceString);
    }

    [Register("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;)V", "GetLog_Ljava_util_logging_Level_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe void Log(Level? warning, string? s, string? stackTraceString)
    {
      IntPtr num1 = JNIEnv.NewString(s);
      IntPtr num2 = JNIEnv.NewString(stackTraceString);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(warning == null ? IntPtr.Zero : ((Object) warning).Handle),
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("log.(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
        GC.KeepAlive((object) warning);
      }
    }

    private static Delegate GetSetLevel_Ljava_util_logging_Level_Handler()
    {
      if ((object) IRFIDLogger.cb_setLevel_Ljava_util_logging_Level_ == null)
        IRFIDLogger.cb_setLevel_Ljava_util_logging_Level_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IRFIDLogger.n_SetLevel_Ljava_util_logging_Level_));
      return IRFIDLogger.cb_setLevel_Ljava_util_logging_Level_;
    }

    private static void n_SetLevel_Ljava_util_logging_Level_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_off)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).SetLevel(Object.GetObject<Level>(native_off, (JniHandleOwnership) 0));
    }

    [Register("setLevel", "(Ljava/util/logging/Level;)V", "GetSetLevel_Ljava_util_logging_Level_Handler")]
    public virtual unsafe void SetLevel(Level? off)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(off == null ? IntPtr.Zero : ((Object) off).Handle)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("setLevel.(Ljava/util/logging/Level;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) off);
      }
    }

    private static Delegate GetSetLogConfig_Ljava_lang_String_ZHandler()
    {
      if ((object) IRFIDLogger.cb_setLogConfig_Ljava_lang_String_Z == null)
        IRFIDLogger.cb_setLogConfig_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_Z(IRFIDLogger.n_SetLogConfig_Ljava_lang_String_Z));
      return IRFIDLogger.cb_setLogConfig_Ljava_lang_String_Z;
    }

    private static bool n_SetLogConfig_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logType,
      bool state)
    {
      return Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).SetLogConfig(JNIEnv.GetString(native_logType, (JniHandleOwnership) 0), state);
    }

    [Register("setLogConfig", "(Ljava/lang/String;Z)Z", "GetSetLogConfig_Ljava_lang_String_ZHandler")]
    public virtual unsafe bool SetLogConfig(string? logType, bool state)
    {
      IntPtr num = JNIEnv.NewString(logType);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(state)
        };
        return IRFIDLogger._members.InstanceMethods.InvokeVirtualBooleanMethod("setLogConfig.(Ljava/lang/String;Z)Z", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetSetRFIDReaderHandler()
    {
      if ((object) IRFIDLogger.cb_setRFIDReader == null)
        IRFIDLogger.cb_setRFIDReader = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_V(IRFIDLogger.n_SetRFIDReader));
      return IRFIDLogger.cb_setRFIDReader;
    }

    private static void n_SetRFIDReader(IntPtr jnienv, IntPtr native__this)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).SetRFIDReader();
    }

    [Register("setRFIDReader", "()V", "GetSetRFIDReaderHandler")]
    public virtual unsafe void SetRFIDReader()
    {
      IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("setRFIDReader.()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetSetRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_Handler()
    {
      if ((object) IRFIDLogger.cb_setRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_ == null)
        IRFIDLogger.cb_setRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IRFIDLogger.n_SetRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_));
      return IRFIDLogger.cb_setRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_;
    }

    private static void n_SetRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_rfidReader)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).SetRFIDReader(Object.GetObject<IRFIDReader>(native_rfidReader, (JniHandleOwnership) 0));
    }

    [Register("setRFIDReader", "(Lcom/zebra/rfid/api3/IRFIDReader;)V", "GetSetRFIDReader_Lcom_zebra_rfid_api3_IRFIDReader_Handler")]
    public virtual unsafe void SetRFIDReader(IRFIDReader? rfidReader)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(rfidReader == null ? IntPtr.Zero : rfidReader.Handle)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("setRFIDReader.(Lcom/zebra/rfid/api3/IRFIDReader;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) rfidReader);
      }
    }

    private static Delegate GetSetRfidReaderLog_Ljava_lang_String_ZHandler()
    {
      if ((object) IRFIDLogger.cb_setRfidReaderLog_Ljava_lang_String_Z == null)
        IRFIDLogger.cb_setRfidReaderLog_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(IRFIDLogger.n_SetRfidReaderLog_Ljava_lang_String_Z));
      return IRFIDLogger.cb_setRfidReaderLog_Ljava_lang_String_Z;
    }

    private static void n_SetRfidReaderLog_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_logtype,
      bool state)
    {
      Object.GetObject<IRFIDLogger>(jnienv, native__this, (JniHandleOwnership) 0).SetRfidReaderLog(JNIEnv.GetString(native_logtype, (JniHandleOwnership) 0), state);
    }

    [Register("setRfidReaderLog", "(Ljava/lang/String;Z)V", "GetSetRfidReaderLog_Ljava_lang_String_ZHandler")]
    public virtual unsafe void SetRfidReaderLog(string? logtype, bool state)
    {
      IntPtr num = JNIEnv.NewString(logtype);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(state)
        };
        IRFIDLogger._members.InstanceMethods.InvokeVirtualVoidMethod("setRfidReaderLog.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
