// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.RFIDCommMgr
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
  [Register("com/zebra/rfid/api3/RFIDCommMgr", DoNotGenerateAcw = true)]
  public class RFIDCommMgr : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDCommMgr", typeof (RFIDCommMgr));
    private static Delegate? cb_getLastCommandExecuted;
    private static Delegate? cb_getNextCommand;
    private static Delegate? cb_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_;
    private static Delegate? cb_StreamWrite_Ljava_lang_String_Z;

    [Register("LOGGER")]
    public static IRFIDLogger? Logger
    {
      get
      {
        JniObjectReference objectValue = RFIDCommMgr._members.StaticFields.GetObjectValue("LOGGER.Lcom/zebra/rfid/api3/IRFIDLogger;");
        return Object.GetObject<IRFIDLogger>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RFIDCommMgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RFIDCommMgr._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RFIDCommMgr._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RFIDCommMgr._members.ManagedPeerType;

    protected RFIDCommMgr(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetLastCommandExecutedHandler()
    {
      if ((object) RFIDCommMgr.cb_getLastCommandExecuted == null)
        RFIDCommMgr.cb_getLastCommandExecuted = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDCommMgr.n_GetLastCommandExecuted));
      return RFIDCommMgr.cb_getLastCommandExecuted;
    }

    private static IntPtr n_GetLastCommandExecuted(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDCommMgr>(jnienv, native__this, (JniHandleOwnership) 0).LastCommandExecuted);
    }

    public virtual unsafe RFIDCommMgr.CommandData? LastCommandExecuted
    {
      [Register("getLastCommandExecuted", "()Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;", "GetGetLastCommandExecutedHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDCommMgr._members.InstanceMethods.InvokeVirtualObjectMethod("getLastCommandExecuted.()Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RFIDCommMgr.CommandData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetGetNextCommandHandler()
    {
      if ((object) RFIDCommMgr.cb_getNextCommand == null)
        RFIDCommMgr.cb_getNextCommand = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDCommMgr.n_GetNextCommand));
      return RFIDCommMgr.cb_getNextCommand;
    }

    private static IntPtr n_GetNextCommand(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<RFIDCommMgr>(jnienv, native__this, (JniHandleOwnership) 0).NextCommand);
    }

    public virtual unsafe RFIDCommMgr.CommandData? NextCommand
    {
      [Register("getNextCommand", "()Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;", "GetGetNextCommandHandler")] get
      {
        JniObjectReference jniObjectReference = RFIDCommMgr._members.InstanceMethods.InvokeVirtualObjectMethod("getNextCommand.()Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<RFIDCommMgr.CommandData>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetStreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_Handler()
    {
      if ((object) RFIDCommMgr.cb_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_ == null)
        RFIDCommMgr.cb_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDCommMgr.n_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_));
      return RFIDCommMgr.cb_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_;
    }

    private static void n_StreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_commandData)
    {
      Object.GetObject<RFIDCommMgr>(jnienv, native__this, (JniHandleOwnership) 0).StreamWrite(Object.GetObject<RFIDCommMgr.CommandData>(native_commandData, (JniHandleOwnership) 0));
    }

    [Register("StreamWrite", "(Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;)V", "GetStreamWrite_Lcom_zebra_rfid_api3_RFIDCommMgr_CommandData_Handler")]
    public virtual unsafe void StreamWrite(RFIDCommMgr.CommandData? commandData)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(commandData == null ? IntPtr.Zero : commandData.Handle)
        };
        RFIDCommMgr._members.InstanceMethods.InvokeVirtualVoidMethod("StreamWrite.(Lcom/zebra/rfid/api3/RFIDCommMgr$CommandData;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) commandData);
      }
    }

    private static Delegate GetStreamWrite_Ljava_lang_String_ZHandler()
    {
      if ((object) RFIDCommMgr.cb_StreamWrite_Ljava_lang_String_Z == null)
        RFIDCommMgr.cb_StreamWrite_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLZ_V(RFIDCommMgr.n_StreamWrite_Ljava_lang_String_Z));
      return RFIDCommMgr.cb_StreamWrite_Ljava_lang_String_Z;
    }

    private static void n_StreamWrite_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_writeData,
      bool bBlock)
    {
      Object.GetObject<RFIDCommMgr>(jnienv, native__this, (JniHandleOwnership) 0).StreamWrite(JNIEnv.GetString(native_writeData, (JniHandleOwnership) 0), bBlock);
    }

    [Register("StreamWrite", "(Ljava/lang/String;Z)V", "GetStreamWrite_Ljava_lang_String_ZHandler")]
    public virtual unsafe void StreamWrite(string? writeData, bool bBlock)
    {
      IntPtr num = JNIEnv.NewString(writeData);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num),
          new JniArgumentValue(bBlock)
        };
        RFIDCommMgr._members.InstanceMethods.InvokeVirtualVoidMethod("StreamWrite.(Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("com/zebra/rfid/api3/RFIDCommMgr$CommandData", DoNotGenerateAcw = true)]
    public class CommandData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDCommMgr$CommandData", typeof (RFIDCommMgr.CommandData));
      private static Delegate? cb_getAttemptReconnect;
      private static Delegate? cb_getCmdSpacing;
      private static Delegate? cb_getCommand;
      private static Delegate? cb_getCopyResponse;
      private static Delegate? cb_getPid;
      private static Delegate? cb_getResponse;
      private static Delegate? cb_setResponse_Ljava_lang_String_;
      private static Delegate? cb_getRxTimeout;
      private static Delegate? cb_getTxTimeout;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = RFIDCommMgr.CommandData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => RFIDCommMgr.CommandData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = RFIDCommMgr.CommandData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => RFIDCommMgr.CommandData._members.ManagedPeerType;

      protected CommandData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(ILjava/lang/String;Z)V", "")]
      public unsafe CommandData(int pid, string? data, bool copyResponse)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        IntPtr num = JNIEnv.NewString(data);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
          {
            new JniArgumentValue(pid),
            new JniArgumentValue(num),
            new JniArgumentValue(copyResponse)
          };
          JniObjectReference instance = RFIDCommMgr.CommandData._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Z)V", ((object) this).GetType(), jniArgumentValuePtr);
          this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          RFIDCommMgr.CommandData._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }

      private static Delegate GetGetAttemptReconnectHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getAttemptReconnect == null)
          RFIDCommMgr.CommandData.cb_getAttemptReconnect = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RFIDCommMgr.CommandData.n_GetAttemptReconnect));
        return RFIDCommMgr.CommandData.cb_getAttemptReconnect;
      }

      private static bool n_GetAttemptReconnect(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).AttemptReconnect;
      }

      protected virtual unsafe bool AttemptReconnect
      {
        [Register("getAttemptReconnect", "()Z", "GetGetAttemptReconnectHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualBooleanMethod("getAttemptReconnect.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetCmdSpacingHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getCmdSpacing == null)
          RFIDCommMgr.CommandData.cb_getCmdSpacing = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDCommMgr.CommandData.n_GetCmdSpacing));
        return RFIDCommMgr.CommandData.cb_getCmdSpacing;
      }

      private static int n_GetCmdSpacing(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).CmdSpacing;
      }

      protected virtual unsafe int CmdSpacing
      {
        [Register("getCmdSpacing", "()I", "GetGetCmdSpacingHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualInt32Method("getCmdSpacing.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetCommandHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getCommand == null)
          RFIDCommMgr.CommandData.cb_getCommand = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDCommMgr.CommandData.n_GetCommand));
        return RFIDCommMgr.CommandData.cb_getCommand;
      }

      private static IntPtr n_GetCommand(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).Command);
      }

      protected virtual unsafe string? Command
      {
        [Register("getCommand", "()Ljava/lang/String;", "GetGetCommandHandler")] get
        {
          JniObjectReference jniObjectReference = RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualObjectMethod("getCommand.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetCopyResponseHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getCopyResponse == null)
          RFIDCommMgr.CommandData.cb_getCopyResponse = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(RFIDCommMgr.CommandData.n_GetCopyResponse));
        return RFIDCommMgr.CommandData.cb_getCopyResponse;
      }

      private static bool n_GetCopyResponse(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).CopyResponse;
      }

      protected virtual unsafe bool CopyResponse
      {
        [Register("getCopyResponse", "()Z", "GetGetCopyResponseHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualBooleanMethod("getCopyResponse.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetPidHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getPid == null)
          RFIDCommMgr.CommandData.cb_getPid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDCommMgr.CommandData.n_GetPid));
        return RFIDCommMgr.CommandData.cb_getPid;
      }

      private static int n_GetPid(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).Pid;
      }

      protected virtual unsafe int Pid
      {
        [Register("getPid", "()I", "GetGetPidHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualInt32Method("getPid.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetResponseHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getResponse == null)
          RFIDCommMgr.CommandData.cb_getResponse = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(RFIDCommMgr.CommandData.n_GetResponse));
        return RFIDCommMgr.CommandData.cb_getResponse;
      }

      private static IntPtr n_GetResponse(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).Response);
      }

      private static Delegate GetSetResponse_Ljava_lang_String_Handler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_setResponse_Ljava_lang_String_ == null)
          RFIDCommMgr.CommandData.cb_setResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(RFIDCommMgr.CommandData.n_SetResponse_Ljava_lang_String_));
        return RFIDCommMgr.CommandData.cb_setResponse_Ljava_lang_String_;
      }

      private static void n_SetResponse_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_response)
      {
        Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).Response = JNIEnv.GetString(native_response, (JniHandleOwnership) 0);
      }

      protected virtual unsafe string? Response
      {
        [Register("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")] get
        {
          JniObjectReference jniObjectReference = RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualObjectMethod("getResponse.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setResponse", "(Ljava/lang/String;)V", "GetSetResponse_Ljava_lang_String_Handler")] set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(num)
            };
            RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualVoidMethod("setResponse.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      private static Delegate GetGetRxTimeoutHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getRxTimeout == null)
          RFIDCommMgr.CommandData.cb_getRxTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDCommMgr.CommandData.n_GetRxTimeout));
        return RFIDCommMgr.CommandData.cb_getRxTimeout;
      }

      private static int n_GetRxTimeout(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).RxTimeout;
      }

      protected virtual unsafe int RxTimeout
      {
        [Register("getRxTimeout", "()I", "GetGetRxTimeoutHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualInt32Method("getRxTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetTxTimeoutHandler()
      {
        if ((object) RFIDCommMgr.CommandData.cb_getTxTimeout == null)
          RFIDCommMgr.CommandData.cb_getTxTimeout = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(RFIDCommMgr.CommandData.n_GetTxTimeout));
        return RFIDCommMgr.CommandData.cb_getTxTimeout;
      }

      private static int n_GetTxTimeout(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<RFIDCommMgr.CommandData>(jnienv, native__this, (JniHandleOwnership) 0).TxTimeout;
      }

      protected virtual unsafe int TxTimeout
      {
        [Register("getTxTimeout", "()I", "GetGetTxTimeoutHandler")] get
        {
          return RFIDCommMgr.CommandData._members.InstanceMethods.InvokeVirtualInt32Method("getTxTimeout.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/RFIDCommMgr$DataThread", DoNotGenerateAcw = true)]
    public class DataThread : Thread
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/RFIDCommMgr$DataThread", typeof (RFIDCommMgr.DataThread));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = RFIDCommMgr.DataThread._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => RFIDCommMgr.DataThread._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = RFIDCommMgr.DataThread._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => RFIDCommMgr.DataThread._members.ManagedPeerType;

      protected DataThread(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "(Lcom/zebra/rfid/api3/RFIDCommMgr;)V", "")]
      public unsafe DataThread(RFIDCommMgr? __self)
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        string str = "(L" + JNIEnv.GetJniName(((object) this).GetType().DeclaringType) + ";)V";
        if (((Object) this).Handle != IntPtr.Zero)
          return;
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(__self == null ? IntPtr.Zero : __self.Handle)
          };
          JniObjectReference instance = RFIDCommMgr.DataThread._members.InstanceMethods.StartCreateInstance(str, ((object) this).GetType(), jniArgumentValuePtr);
          ((Object) this).SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
          RFIDCommMgr.DataThread._members.InstanceMethods.FinishCreateInstance(str, (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) __self);
        }
      }
    }
  }
}
