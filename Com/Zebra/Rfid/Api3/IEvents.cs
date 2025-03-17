// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IEvents
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
  [Register("com/zebra/rfid/api3/IEvents", DoNotGenerateAcw = true)]
  public class IEvents : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents", typeof (IEvents));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = IEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IEvents._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = IEvents._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IEvents._members.ManagedPeerType;

    protected IEvents(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe IEvents()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = IEvents._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      IEvents._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register("com/zebra/rfid/api3/IEvents$BatchModeEventData", DoNotGenerateAcw = true)]
    public class BatchModeEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$BatchModeEventData", typeof (IEvents.BatchModeEventData));
      private static Delegate? cb_get_BatchMode;
      private static Delegate? cb_get_RepeatTrigger;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.BatchModeEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.BatchModeEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.BatchModeEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.BatchModeEventData._members.ManagedPeerType;

      protected BatchModeEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGet_BatchModeHandler()
      {
        if ((object) IEvents.BatchModeEventData.cb_get_BatchMode == null)
          IEvents.BatchModeEventData.cb_get_BatchMode = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.BatchModeEventData.n_Get_BatchMode));
        return IEvents.BatchModeEventData.cb_get_BatchMode;
      }

      private static IntPtr n_Get_BatchMode(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.BatchModeEventData>(jnienv, native__this, (JniHandleOwnership) 0).Get_BatchMode());
      }

      [Register("get_BatchMode", "()Lcom/zebra/rfid/api3/BATCH_MODE;", "GetGet_BatchModeHandler")]
      public virtual unsafe BATCH_MODE? Get_BatchMode()
      {
        JniObjectReference jniObjectReference = IEvents.BatchModeEventData._members.InstanceMethods.InvokeVirtualObjectMethod("get_BatchMode.()Lcom/zebra/rfid/api3/BATCH_MODE;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<BATCH_MODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }

      private static Delegate GetGet_RepeatTriggerHandler()
      {
        if ((object) IEvents.BatchModeEventData.cb_get_RepeatTrigger == null)
          IEvents.BatchModeEventData.cb_get_RepeatTrigger = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.BatchModeEventData.n_Get_RepeatTrigger));
        return IEvents.BatchModeEventData.cb_get_RepeatTrigger;
      }

      private static IntPtr n_Get_RepeatTrigger(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.BatchModeEventData>(jnienv, native__this, (JniHandleOwnership) 0).Get_RepeatTrigger());
      }

      [Register("get_RepeatTrigger", "()Ljava/lang/Boolean;", "GetGet_RepeatTriggerHandler")]
      public virtual unsafe Boolean? Get_RepeatTrigger()
      {
        JniObjectReference jniObjectReference = IEvents.BatchModeEventData._members.InstanceMethods.InvokeVirtualObjectMethod("get_RepeatTrigger.()Ljava/lang/Boolean;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<Boolean>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$BatteryData", DoNotGenerateAcw = true)]
    public class BatteryData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$BatteryData", typeof (IEvents.BatteryData));
      private static Delegate? cb_getCause;
      private static Delegate? cb_getCharging;
      private static Delegate? cb_getLevel;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.BatteryData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.BatteryData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.BatteryData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.BatteryData._members.ManagedPeerType;

      protected BatteryData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) IEvents.BatteryData.cb_getCause == null)
          IEvents.BatteryData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.BatteryData.n_GetCause));
        return IEvents.BatteryData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.BatteryData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.BatteryData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetChargingHandler()
      {
        if ((object) IEvents.BatteryData.cb_getCharging == null)
          IEvents.BatteryData.cb_getCharging = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IEvents.BatteryData.n_GetCharging));
        return IEvents.BatteryData.cb_getCharging;
      }

      private static bool n_GetCharging(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.BatteryData>(jnienv, native__this, (JniHandleOwnership) 0).Charging;
      }

      public virtual unsafe bool Charging
      {
        [Register("getCharging", "()Z", "GetGetChargingHandler")] get
        {
          return IEvents.BatteryData._members.InstanceMethods.InvokeVirtualBooleanMethod("getCharging.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetLevelHandler()
      {
        if ((object) IEvents.BatteryData.cb_getLevel == null)
          IEvents.BatteryData.cb_getLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.BatteryData.n_GetLevel));
        return IEvents.BatteryData.cb_getLevel;
      }

      private static int n_GetLevel(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.BatteryData>(jnienv, native__this, (JniHandleOwnership) 0).Level;
      }

      public virtual unsafe int Level
      {
        [Register("getLevel", "()I", "GetGetLevelHandler")] get
        {
          return IEvents.BatteryData._members.InstanceMethods.InvokeVirtualInt32Method("getLevel.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$BufferFullWarningEventData", DoNotGenerateAcw = true)]
    public class BufferFullWarningEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$BufferFullWarningEventData", typeof (IEvents.BufferFullWarningEventData));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.BufferFullWarningEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.BufferFullWarningEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.BufferFullWarningEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.BufferFullWarningEventData._members.ManagedPeerType;
      }

      protected BufferFullWarningEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$CradleData", DoNotGenerateAcw = true)]
    public class CradleData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$CradleData", typeof (IEvents.CradleData));
      private static Delegate? cb_getCause;
      private static Delegate? cb_isOnCradle;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.CradleData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.CradleData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.CradleData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.CradleData._members.ManagedPeerType;

      protected CradleData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) IEvents.CradleData.cb_getCause == null)
          IEvents.CradleData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.CradleData.n_GetCause));
        return IEvents.CradleData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.CradleData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.CradleData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetIsOnCradleHandler()
      {
        if ((object) IEvents.CradleData.cb_isOnCradle == null)
          IEvents.CradleData.cb_isOnCradle = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IEvents.CradleData.n_IsOnCradle));
        return IEvents.CradleData.cb_isOnCradle;
      }

      private static bool n_IsOnCradle(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.CradleData>(jnienv, native__this, (JniHandleOwnership) 0).IsOnCradle;
      }

      public virtual unsafe bool IsOnCradle
      {
        [Register("isOnCradle", "()Z", "GetIsOnCradleHandler")] get
        {
          return IEvents.CradleData._members.InstanceMethods.InvokeVirtualBooleanMethod("isOnCradle.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$DisconnectionEventData", DoNotGenerateAcw = true)]
    public class DisconnectionEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$DisconnectionEventData", typeof (IEvents.DisconnectionEventData));
      private static Delegate? cb_getDisconnectionEvent;

      [Register("m_DisconnectionEvent")]
      public DISCONNECTION_EVENT_DATA? MDisconnectionEvent
      {
        get
        {
          JniObjectReference objectValue = IEvents.DisconnectionEventData._members.InstanceFields.GetObjectValue("m_DisconnectionEvent.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_DATA;", (IJavaPeerable) this);
          return Object.GetObject<DISCONNECTION_EVENT_DATA>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.DisconnectionEventData._members.InstanceFields.SetValue("m_DisconnectionEvent.Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_DATA;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.DisconnectionEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.DisconnectionEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.DisconnectionEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.DisconnectionEventData._members.ManagedPeerType;
      }

      protected DisconnectionEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetDisconnectionEventHandler()
      {
        if ((object) IEvents.DisconnectionEventData.cb_getDisconnectionEvent == null)
          IEvents.DisconnectionEventData.cb_getDisconnectionEvent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.DisconnectionEventData.n_GetDisconnectionEvent));
        return IEvents.DisconnectionEventData.cb_getDisconnectionEvent;
      }

      private static IntPtr n_GetDisconnectionEvent(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.DisconnectionEventData>(jnienv, native__this, (JniHandleOwnership) 0).DisconnectionEvent);
      }

      public virtual unsafe DISCONNECTION_EVENT_TYPE? DisconnectionEvent
      {
        [Register("getDisconnectionEvent", "()Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", "GetGetDisconnectionEventHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.DisconnectionEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getDisconnectionEvent.()Lcom/zebra/rfid/api3/DISCONNECTION_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<DISCONNECTION_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$FirmwareUpdateEvent", DoNotGenerateAcw = true)]
    public class FirmwareUpdateEvent : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$FirmwareUpdateEvent", typeof (IEvents.FirmwareUpdateEvent));
      private static Delegate? cb_getImageDownloadProgress;
      private static Delegate? cb_setImageDownloadProgress_I;
      private static Delegate? cb_getOverallUpdateProgress;
      private static Delegate? cb_setOverallUpdateProgress_I;
      private static Delegate? cb_getStatus;
      private static Delegate? cb_setStatus_Ljava_lang_String_;

      [Register("m_imageDownloadProgress")]
      public int MImageDownloadProgress
      {
        get
        {
          return IEvents.FirmwareUpdateEvent._members.InstanceFields.GetInt32Value("m_imageDownloadProgress.I", (IJavaPeerable) this);
        }
        set
        {
          IEvents.FirmwareUpdateEvent._members.InstanceFields.SetValue("m_imageDownloadProgress.I", (IJavaPeerable) this, value);
        }
      }

      [Register("m_overallUpdateProgress")]
      public int MOverallUpdateProgress
      {
        get
        {
          return IEvents.FirmwareUpdateEvent._members.InstanceFields.GetInt32Value("m_overallUpdateProgress.I", (IJavaPeerable) this);
        }
        set
        {
          IEvents.FirmwareUpdateEvent._members.InstanceFields.SetValue("m_overallUpdateProgress.I", (IJavaPeerable) this, value);
        }
      }

      [Register("m_status")]
      public string? MStatus
      {
        get
        {
          JniObjectReference objectValue = IEvents.FirmwareUpdateEvent._members.InstanceFields.GetObjectValue("m_status.Ljava/lang/String;", (IJavaPeerable) this);
          return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            IEvents.FirmwareUpdateEvent._members.InstanceFields.SetValue("m_status.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.FirmwareUpdateEvent._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.FirmwareUpdateEvent._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.FirmwareUpdateEvent._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.FirmwareUpdateEvent._members.ManagedPeerType;

      protected FirmwareUpdateEvent(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetImageDownloadProgressHandler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_getImageDownloadProgress == null)
          IEvents.FirmwareUpdateEvent.cb_getImageDownloadProgress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.FirmwareUpdateEvent.n_GetImageDownloadProgress));
        return IEvents.FirmwareUpdateEvent.cb_getImageDownloadProgress;
      }

      private static int n_GetImageDownloadProgress(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).ImageDownloadProgress;
      }

      private static Delegate GetSetImageDownloadProgress_IHandler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_setImageDownloadProgress_I == null)
          IEvents.FirmwareUpdateEvent.cb_setImageDownloadProgress_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(IEvents.FirmwareUpdateEvent.n_SetImageDownloadProgress_I));
        return IEvents.FirmwareUpdateEvent.cb_setImageDownloadProgress_I;
      }

      private static void n_SetImageDownloadProgress_I(
        IntPtr jnienv,
        IntPtr native__this,
        int imageDownloadProgress)
      {
        Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).ImageDownloadProgress = imageDownloadProgress;
      }

      public virtual unsafe int ImageDownloadProgress
      {
        [Register("getImageDownloadProgress", "()I", "GetGetImageDownloadProgressHandler")] get
        {
          return IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualInt32Method("getImageDownloadProgress.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setImageDownloadProgress", "(I)V", "GetSetImageDownloadProgress_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualVoidMethod("setImageDownloadProgress.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetOverallUpdateProgressHandler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_getOverallUpdateProgress == null)
          IEvents.FirmwareUpdateEvent.cb_getOverallUpdateProgress = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.FirmwareUpdateEvent.n_GetOverallUpdateProgress));
        return IEvents.FirmwareUpdateEvent.cb_getOverallUpdateProgress;
      }

      private static int n_GetOverallUpdateProgress(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).OverallUpdateProgress;
      }

      private static Delegate GetSetOverallUpdateProgress_IHandler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_setOverallUpdateProgress_I == null)
          IEvents.FirmwareUpdateEvent.cb_setOverallUpdateProgress_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(IEvents.FirmwareUpdateEvent.n_SetOverallUpdateProgress_I));
        return IEvents.FirmwareUpdateEvent.cb_setOverallUpdateProgress_I;
      }

      private static void n_SetOverallUpdateProgress_I(
        IntPtr jnienv,
        IntPtr native__this,
        int overallUpdateProgress)
      {
        Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).OverallUpdateProgress = overallUpdateProgress;
      }

      public virtual unsafe int OverallUpdateProgress
      {
        [Register("getOverallUpdateProgress", "()I", "GetGetOverallUpdateProgressHandler")] get
        {
          return IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualInt32Method("getOverallUpdateProgress.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setOverallUpdateProgress", "(I)V", "GetSetOverallUpdateProgress_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualVoidMethod("setOverallUpdateProgress.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetStatusHandler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_getStatus == null)
          IEvents.FirmwareUpdateEvent.cb_getStatus = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.FirmwareUpdateEvent.n_GetStatus));
        return IEvents.FirmwareUpdateEvent.cb_getStatus;
      }

      private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).Status);
      }

      private static Delegate GetSetStatus_Ljava_lang_String_Handler()
      {
        if ((object) IEvents.FirmwareUpdateEvent.cb_setStatus_Ljava_lang_String_ == null)
          IEvents.FirmwareUpdateEvent.cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IEvents.FirmwareUpdateEvent.n_SetStatus_Ljava_lang_String_));
        return IEvents.FirmwareUpdateEvent.cb_setStatus_Ljava_lang_String_;
      }

      private static void n_SetStatus_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_status)
      {
        Object.GetObject<IEvents.FirmwareUpdateEvent>(jnienv, native__this, (JniHandleOwnership) 0).Status = JNIEnv.GetString(native_status, (JniHandleOwnership) 0);
      }

      public virtual unsafe string? Status
      {
        [Register("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualObjectMethod("getStatus.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")] set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(num)
            };
            IEvents.FirmwareUpdateEvent._members.InstanceMethods.InvokeVirtualVoidMethod("setStatus.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$GPIEventData", DoNotGenerateAcw = true)]
    public class GPIEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$GPIEventData", typeof (IEvents.GPIEventData));
      private static Delegate? cb_getGPIEventState;
      private static Delegate? cb_getGPIPort;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.GPIEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.GPIEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.GPIEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.GPIEventData._members.ManagedPeerType;

      protected GPIEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetGPIEventStateHandler()
      {
        if ((object) IEvents.GPIEventData.cb_getGPIEventState == null)
          IEvents.GPIEventData.cb_getGPIEventState = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IEvents.GPIEventData.n_GetGPIEventState));
        return IEvents.GPIEventData.cb_getGPIEventState;
      }

      private static bool n_GetGPIEventState(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.GPIEventData>(jnienv, native__this, (JniHandleOwnership) 0).GPIEventState;
      }

      public virtual unsafe bool GPIEventState
      {
        [Register("getGPIEventState", "()Z", "GetGetGPIEventStateHandler")] get
        {
          return IEvents.GPIEventData._members.InstanceMethods.InvokeVirtualBooleanMethod("getGPIEventState.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetGPIPortHandler()
      {
        if ((object) IEvents.GPIEventData.cb_getGPIPort == null)
          IEvents.GPIEventData.cb_getGPIPort = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.GPIEventData.n_GetGPIPort));
        return IEvents.GPIEventData.cb_getGPIPort;
      }

      private static int n_GetGPIPort(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.GPIEventData>(jnienv, native__this, (JniHandleOwnership) 0).GPIPort;
      }

      public virtual unsafe int GPIPort
      {
        [Register("getGPIPort", "()I", "GetGetGPIPortHandler")] get
        {
          return IEvents.GPIEventData._members.InstanceMethods.InvokeVirtualInt32Method("getGPIPort.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$HandheldTriggerEventData", DoNotGenerateAcw = true)]
    public class HandheldTriggerEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$HandheldTriggerEventData", typeof (IEvents.HandheldTriggerEventData));
      private static Delegate? cb_getHandheldEvent;
      private static Delegate? cb_getHandheldTriggerType;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.HandheldTriggerEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.HandheldTriggerEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.HandheldTriggerEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.HandheldTriggerEventData._members.ManagedPeerType;
      }

      protected HandheldTriggerEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      [Register(".ctor", "()V", "")]
      public unsafe HandheldTriggerEventData()
        : base(IntPtr.Zero, (JniHandleOwnership) 0)
      {
        if (this.Handle != IntPtr.Zero)
          return;
        JniObjectReference instance = IEvents.HandheldTriggerEventData._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        IEvents.HandheldTriggerEventData._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
      }

      private static Delegate GetGetHandheldEventHandler()
      {
        if ((object) IEvents.HandheldTriggerEventData.cb_getHandheldEvent == null)
          IEvents.HandheldTriggerEventData.cb_getHandheldEvent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.HandheldTriggerEventData.n_GetHandheldEvent));
        return IEvents.HandheldTriggerEventData.cb_getHandheldEvent;
      }

      private static IntPtr n_GetHandheldEvent(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.HandheldTriggerEventData>(jnienv, native__this, (JniHandleOwnership) 0).HandheldEvent);
      }

      public virtual unsafe HANDHELD_TRIGGER_EVENT_TYPE? HandheldEvent
      {
        [Register("getHandheldEvent", "()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", "GetGetHandheldEventHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.HandheldTriggerEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getHandheldEvent.()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<HANDHELD_TRIGGER_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetHandheldTriggerTypeHandler()
      {
        if ((object) IEvents.HandheldTriggerEventData.cb_getHandheldTriggerType == null)
          IEvents.HandheldTriggerEventData.cb_getHandheldTriggerType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.HandheldTriggerEventData.n_GetHandheldTriggerType));
        return IEvents.HandheldTriggerEventData.cb_getHandheldTriggerType;
      }

      private static IntPtr n_GetHandheldTriggerType(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.HandheldTriggerEventData>(jnienv, native__this, (JniHandleOwnership) 0).HandheldTriggerType);
      }

      public virtual unsafe HANDHELD_TRIGGER_TYPE? HandheldTriggerType
      {
        [Register("getHandheldTriggerType", "()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_TYPE;", "GetGetHandheldTriggerTypeHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.HandheldTriggerEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getHandheldTriggerType.()Lcom/zebra/rfid/api3/HANDHELD_TRIGGER_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<HANDHELD_TRIGGER_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$InfoData", DoNotGenerateAcw = true)]
    public class InfoData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$InfoData", typeof (IEvents.InfoData));
      private static Delegate? cb_getCause;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.InfoData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.InfoData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.InfoData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.InfoData._members.ManagedPeerType;

      protected InfoData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) IEvents.InfoData.cb_getCause == null)
          IEvents.InfoData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.InfoData.n_GetCause));
        return IEvents.InfoData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.InfoData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.InfoData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$InventoryStartEventData", DoNotGenerateAcw = true)]
    public class InventoryStartEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$InventoryStartEventData", typeof (IEvents.InventoryStartEventData));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.InventoryStartEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.InventoryStartEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.InventoryStartEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.InventoryStartEventData._members.ManagedPeerType;
      }

      protected InventoryStartEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$InventoryStopEventData", DoNotGenerateAcw = true)]
    public class InventoryStopEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$InventoryStopEventData", typeof (IEvents.InventoryStopEventData));

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.InventoryStopEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.InventoryStopEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.InventoryStopEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.InventoryStopEventData._members.ManagedPeerType;
      }

      protected InventoryStopEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$OperationEndSummaryData", DoNotGenerateAcw = true)]
    public class OperationEndSummaryData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$OperationEndSummaryData", typeof (IEvents.OperationEndSummaryData));
      private static Delegate? cb_getTotalRounds;
      private static Delegate? cb_getTotalTags;
      private static Delegate? cb_getTotalTimeuS;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.OperationEndSummaryData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.OperationEndSummaryData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.OperationEndSummaryData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.OperationEndSummaryData._members.ManagedPeerType;
      }

      protected OperationEndSummaryData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetTotalRoundsHandler()
      {
        if ((object) IEvents.OperationEndSummaryData.cb_getTotalRounds == null)
          IEvents.OperationEndSummaryData.cb_getTotalRounds = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.OperationEndSummaryData.n_GetTotalRounds));
        return IEvents.OperationEndSummaryData.cb_getTotalRounds;
      }

      private static int n_GetTotalRounds(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.OperationEndSummaryData>(jnienv, native__this, (JniHandleOwnership) 0).TotalRounds;
      }

      public virtual unsafe int TotalRounds
      {
        [Register("getTotalRounds", "()I", "GetGetTotalRoundsHandler")] get
        {
          return IEvents.OperationEndSummaryData._members.InstanceMethods.InvokeVirtualInt32Method("getTotalRounds.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetTotalTagsHandler()
      {
        if ((object) IEvents.OperationEndSummaryData.cb_getTotalTags == null)
          IEvents.OperationEndSummaryData.cb_getTotalTags = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.OperationEndSummaryData.n_GetTotalTags));
        return IEvents.OperationEndSummaryData.cb_getTotalTags;
      }

      private static int n_GetTotalTags(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.OperationEndSummaryData>(jnienv, native__this, (JniHandleOwnership) 0).TotalTags;
      }

      public virtual unsafe int TotalTags
      {
        [Register("getTotalTags", "()I", "GetGetTotalTagsHandler")] get
        {
          return IEvents.OperationEndSummaryData._members.InstanceMethods.InvokeVirtualInt32Method("getTotalTags.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetTotalTimeuSHandler()
      {
        if ((object) IEvents.OperationEndSummaryData.cb_getTotalTimeuS == null)
          IEvents.OperationEndSummaryData.cb_getTotalTimeuS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(IEvents.OperationEndSummaryData.n_GetTotalTimeuS));
        return IEvents.OperationEndSummaryData.cb_getTotalTimeuS;
      }

      private static long n_GetTotalTimeuS(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.OperationEndSummaryData>(jnienv, native__this, (JniHandleOwnership) 0).TotalTimeuS;
      }

      public virtual unsafe long TotalTimeuS
      {
        [Register("getTotalTimeuS", "()J", "GetGetTotalTimeuSHandler")] get
        {
          return IEvents.OperationEndSummaryData._members.InstanceMethods.InvokeVirtualInt64Method("getTotalTimeuS.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$PowerData", DoNotGenerateAcw = true)]
    public class PowerData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$PowerData", typeof (IEvents.PowerData));
      private static Delegate? cb_getCause;
      private static Delegate? cb_getCurrent;
      private static Delegate? cb_getPower;
      private static Delegate? cb_getVoltage;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.PowerData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.PowerData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.PowerData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.PowerData._members.ManagedPeerType;

      protected PowerData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) IEvents.PowerData.cb_getCause == null)
          IEvents.PowerData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.PowerData.n_GetCause));
        return IEvents.PowerData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.PowerData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.PowerData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetCurrentHandler()
      {
        if ((object) IEvents.PowerData.cb_getCurrent == null)
          IEvents.PowerData.cb_getCurrent = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(IEvents.PowerData.n_GetCurrent));
        return IEvents.PowerData.cb_getCurrent;
      }

      private static float n_GetCurrent(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.PowerData>(jnienv, native__this, (JniHandleOwnership) 0).Current;
      }

      public virtual unsafe float Current
      {
        [Register("getCurrent", "()F", "GetGetCurrentHandler")] get
        {
          return IEvents.PowerData._members.InstanceMethods.InvokeVirtualSingleMethod("getCurrent.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetPowerHandler()
      {
        if ((object) IEvents.PowerData.cb_getPower == null)
          IEvents.PowerData.cb_getPower = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(IEvents.PowerData.n_GetPower));
        return IEvents.PowerData.cb_getPower;
      }

      private static float n_GetPower(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.PowerData>(jnienv, native__this, (JniHandleOwnership) 0).Power;
      }

      public virtual unsafe float Power
      {
        [Register("getPower", "()F", "GetGetPowerHandler")] get
        {
          return IEvents.PowerData._members.InstanceMethods.InvokeVirtualSingleMethod("getPower.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetVoltageHandler()
      {
        if ((object) IEvents.PowerData.cb_getVoltage == null)
          IEvents.PowerData.cb_getVoltage = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_F(IEvents.PowerData.n_GetVoltage));
        return IEvents.PowerData.cb_getVoltage;
      }

      private static float n_GetVoltage(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.PowerData>(jnienv, native__this, (JniHandleOwnership) 0).Voltage;
      }

      public virtual unsafe float Voltage
      {
        [Register("getVoltage", "()F", "GetGetVoltageHandler")] get
        {
          return IEvents.PowerData._members.InstanceMethods.InvokeVirtualSingleMethod("getVoltage.()F", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$ReaderExceptionEventData", DoNotGenerateAcw = true)]
    public class ReaderExceptionEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$ReaderExceptionEventData", typeof (IEvents.ReaderExceptionEventData));
      private static Delegate? cb_getReaderExceptionEventInfo;
      private static Delegate? cb_getReaderExceptionEventType;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.ReaderExceptionEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.ReaderExceptionEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.ReaderExceptionEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType
      {
        get => IEvents.ReaderExceptionEventData._members.ManagedPeerType;
      }

      protected ReaderExceptionEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetReaderExceptionEventInfoHandler()
      {
        if ((object) IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventInfo == null)
          IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventInfo = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.ReaderExceptionEventData.n_GetReaderExceptionEventInfo));
        return IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventInfo;
      }

      private static IntPtr n_GetReaderExceptionEventInfo(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.ReaderExceptionEventData>(jnienv, native__this, (JniHandleOwnership) 0).ReaderExceptionEventInfo);
      }

      public virtual unsafe string? ReaderExceptionEventInfo
      {
        [Register("getReaderExceptionEventInfo", "()Ljava/lang/String;", "GetGetReaderExceptionEventInfoHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.ReaderExceptionEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderExceptionEventInfo.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetReaderExceptionEventTypeHandler()
      {
        if ((object) IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventType == null)
          IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.ReaderExceptionEventData.n_GetReaderExceptionEventType));
        return IEvents.ReaderExceptionEventData.cb_getReaderExceptionEventType;
      }

      private static IntPtr n_GetReaderExceptionEventType(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.ReaderExceptionEventData>(jnienv, native__this, (JniHandleOwnership) 0).ReaderExceptionEventType);
      }

      public virtual unsafe READER_EXCEPTION_EVENT_TYPE? ReaderExceptionEventType
      {
        [Register("getReaderExceptionEventType", "()Lcom/zebra/rfid/api3/READER_EXCEPTION_EVENT_TYPE;", "GetGetReaderExceptionEventTypeHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.ReaderExceptionEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getReaderExceptionEventType.()Lcom/zebra/rfid/api3/READER_EXCEPTION_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<READER_EXCEPTION_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$ReadEventData", DoNotGenerateAcw = true)]
    public class ReadEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$ReadEventData", typeof (IEvents.ReadEventData));

      [Register("tagData")]
      public TagData? TagData
      {
        get
        {
          JniObjectReference objectValue = IEvents.ReadEventData._members.InstanceFields.GetObjectValue("tagData.Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this);
          return Object.GetObject<TagData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.ReadEventData._members.InstanceFields.SetValue("tagData.Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.ReadEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.ReadEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.ReadEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.ReadEventData._members.ManagedPeerType;

      protected ReadEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$StatusEventData", DoNotGenerateAcw = true)]
    public class StatusEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$StatusEventData", typeof (IEvents.StatusEventData));
      private static Delegate? cb_getStatusEventType;
      private static Delegate? cb_setStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_;

      [Register("BatchModeEventData")]
      public IEvents.BatchModeEventData? BatchModeEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("BatchModeEventData.Lcom/zebra/rfid/api3/IEvents$BatchModeEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.BatchModeEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("BatchModeEventData.Lcom/zebra/rfid/api3/IEvents$BatchModeEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("BatteryData")]
      public IEvents.BatteryData? BatteryData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("BatteryData.Lcom/zebra/rfid/api3/IEvents$BatteryData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.BatteryData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("BatteryData.Lcom/zebra/rfid/api3/IEvents$BatteryData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("BufferFullWarningEventData")]
      public IEvents.BufferFullWarningEventData? BufferFullWarningEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("BufferFullWarningEventData.Lcom/zebra/rfid/api3/IEvents$BufferFullWarningEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.BufferFullWarningEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("BufferFullWarningEventData.Lcom/zebra/rfid/api3/IEvents$BufferFullWarningEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("cradleData")]
      public IEvents.CradleData? CradleData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("cradleData.Lcom/zebra/rfid/api3/IEvents$CradleData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.CradleData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("cradleData.Lcom/zebra/rfid/api3/IEvents$CradleData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("DisconnectionEventData")]
      public IEvents.DisconnectionEventData? DisconnectionEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("DisconnectionEventData.Lcom/zebra/rfid/api3/IEvents$DisconnectionEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.DisconnectionEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("DisconnectionEventData.Lcom/zebra/rfid/api3/IEvents$DisconnectionEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("FWEventData")]
      public IEvents.FirmwareUpdateEvent? FWEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("FWEventData.Lcom/zebra/rfid/api3/IEvents$FirmwareUpdateEvent;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.FirmwareUpdateEvent>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("FWEventData.Lcom/zebra/rfid/api3/IEvents$FirmwareUpdateEvent;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("GPIEventData")]
      public IEvents.GPIEventData? GPIEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("GPIEventData.Lcom/zebra/rfid/api3/IEvents$GPIEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.GPIEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("GPIEventData.Lcom/zebra/rfid/api3/IEvents$GPIEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("HandheldTriggerEventData")]
      public IEvents.HandheldTriggerEventData? HandheldTriggerEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("HandheldTriggerEventData.Lcom/zebra/rfid/api3/IEvents$HandheldTriggerEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.HandheldTriggerEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("HandheldTriggerEventData.Lcom/zebra/rfid/api3/IEvents$HandheldTriggerEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("InfoData")]
      public IEvents.InfoData? InfoData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("InfoData.Lcom/zebra/rfid/api3/IEvents$InfoData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.InfoData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("InfoData.Lcom/zebra/rfid/api3/IEvents$InfoData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("InventoryStartEventData")]
      public IEvents.InventoryStartEventData? InventoryStartEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("InventoryStartEventData.Lcom/zebra/rfid/api3/IEvents$InventoryStartEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.InventoryStartEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("InventoryStartEventData.Lcom/zebra/rfid/api3/IEvents$InventoryStartEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("InventoryStopEventData")]
      public IEvents.InventoryStopEventData? InventoryStopEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("InventoryStopEventData.Lcom/zebra/rfid/api3/IEvents$InventoryStopEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.InventoryStopEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("InventoryStopEventData.Lcom/zebra/rfid/api3/IEvents$InventoryStopEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("OperationEndSummaryData")]
      public IEvents.OperationEndSummaryData? OperationEndSummaryData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("OperationEndSummaryData.Lcom/zebra/rfid/api3/IEvents$OperationEndSummaryData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.OperationEndSummaryData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("OperationEndSummaryData.Lcom/zebra/rfid/api3/IEvents$OperationEndSummaryData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("PowerData")]
      public IEvents.PowerData? PowerData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("PowerData.Lcom/zebra/rfid/api3/IEvents$PowerData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.PowerData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("PowerData.Lcom/zebra/rfid/api3/IEvents$PowerData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("ReaderExceptionEventData")]
      public IEvents.ReaderExceptionEventData? ReaderExceptionEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("ReaderExceptionEventData.Lcom/zebra/rfid/api3/IEvents$ReaderExceptionEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.ReaderExceptionEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("ReaderExceptionEventData.Lcom/zebra/rfid/api3/IEvents$ReaderExceptionEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("TemperatureAlarmData")]
      public IEvents.TemperatureAlarmData? TemperatureAlarmData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("TemperatureAlarmData.Lcom/zebra/rfid/api3/IEvents$TemperatureAlarmData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.TemperatureAlarmData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("TemperatureAlarmData.Lcom/zebra/rfid/api3/IEvents$TemperatureAlarmData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      [Register("WPAEventData")]
      public IEvents.WPAEventData? WPAEventData
      {
        get
        {
          JniObjectReference objectValue = IEvents.StatusEventData._members.InstanceFields.GetObjectValue("WPAEventData.Lcom/zebra/rfid/api3/IEvents$WPAEventData;", (IJavaPeerable) this);
          return Object.GetObject<IEvents.WPAEventData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.StatusEventData._members.InstanceFields.SetValue("WPAEventData.Lcom/zebra/rfid/api3/IEvents$WPAEventData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.StatusEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.StatusEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.StatusEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.StatusEventData._members.ManagedPeerType;

      protected StatusEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetStatusEventTypeHandler()
      {
        if ((object) IEvents.StatusEventData.cb_getStatusEventType == null)
          IEvents.StatusEventData.cb_getStatusEventType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.StatusEventData.n_GetStatusEventType));
        return IEvents.StatusEventData.cb_getStatusEventType;
      }

      private static IntPtr n_GetStatusEventType(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.StatusEventData>(jnienv, native__this, (JniHandleOwnership) 0).StatusEventType);
      }

      private static Delegate GetSetStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_Handler()
      {
        if ((object) IEvents.StatusEventData.cb_setStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_ == null)
          IEvents.StatusEventData.cb_setStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IEvents.StatusEventData.n_SetStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_));
        return IEvents.StatusEventData.cb_setStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_;
      }

      private static void n_SetStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_m_StatusEventType)
      {
        Object.GetObject<IEvents.StatusEventData>(jnienv, native__this, (JniHandleOwnership) 0).StatusEventType = Object.GetObject<STATUS_EVENT_TYPE>(native_m_StatusEventType, (JniHandleOwnership) 0);
      }

      public virtual unsafe STATUS_EVENT_TYPE? StatusEventType
      {
        [Register("getStatusEventType", "()Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;", "GetGetStatusEventTypeHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.StatusEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getStatusEventType.()Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<STATUS_EVENT_TYPE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setStatusEventType", "(Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;)V", "GetSetStatusEventType_Lcom_zebra_rfid_api3_STATUS_EVENT_TYPE_Handler")] set
        {
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
            };
            IEvents.StatusEventData._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusEventType.(Lcom/zebra/rfid/api3/STATUS_EVENT_TYPE;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            GC.KeepAlive((object) value);
          }
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$TemperatureAlarmData", DoNotGenerateAcw = true)]
    public class TemperatureAlarmData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$TemperatureAlarmData", typeof (IEvents.TemperatureAlarmData));
      private static Delegate? cb_getAlarmLevel;
      private static Delegate? cb_getAmbientTemp;
      private static Delegate? cb_getCause;
      private static Delegate? cb_getCurrentTemperature;
      private static Delegate? cb_getPATemp;
      private static Delegate? cb_getTemperatureSource;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.TemperatureAlarmData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.TemperatureAlarmData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.TemperatureAlarmData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.TemperatureAlarmData._members.ManagedPeerType;

      protected TemperatureAlarmData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetAlarmLevelHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getAlarmLevel == null)
          IEvents.TemperatureAlarmData.cb_getAlarmLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.TemperatureAlarmData.n_GetAlarmLevel));
        return IEvents.TemperatureAlarmData.cb_getAlarmLevel;
      }

      private static IntPtr n_GetAlarmLevel(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).AlarmLevel);
      }

      public virtual unsafe ALARM_LEVEL? AlarmLevel
      {
        [Register("getAlarmLevel", "()Lcom/zebra/rfid/api3/ALARM_LEVEL;", "GetGetAlarmLevelHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualObjectMethod("getAlarmLevel.()Lcom/zebra/rfid/api3/ALARM_LEVEL;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<ALARM_LEVEL>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetAmbientTempHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getAmbientTemp == null)
          IEvents.TemperatureAlarmData.cb_getAmbientTemp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.TemperatureAlarmData.n_GetAmbientTemp));
        return IEvents.TemperatureAlarmData.cb_getAmbientTemp;
      }

      private static int n_GetAmbientTemp(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).AmbientTemp;
      }

      public virtual unsafe int AmbientTemp
      {
        [Register("getAmbientTemp", "()I", "GetGetAmbientTempHandler")] get
        {
          return IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualInt32Method("getAmbientTemp.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetCauseHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getCause == null)
          IEvents.TemperatureAlarmData.cb_getCause = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.TemperatureAlarmData.n_GetCause));
        return IEvents.TemperatureAlarmData.cb_getCause;
      }

      private static IntPtr n_GetCause(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).Cause);
      }

      public virtual unsafe string? Cause
      {
        [Register("getCause", "()Ljava/lang/String;", "GetGetCauseHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualObjectMethod("getCause.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }

      private static Delegate GetGetCurrentTemperatureHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getCurrentTemperature == null)
          IEvents.TemperatureAlarmData.cb_getCurrentTemperature = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.TemperatureAlarmData.n_GetCurrentTemperature));
        return IEvents.TemperatureAlarmData.cb_getCurrentTemperature;
      }

      private static int n_GetCurrentTemperature(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).CurrentTemperature;
      }

      public virtual unsafe int CurrentTemperature
      {
        [Register("getCurrentTemperature", "()I", "GetGetCurrentTemperatureHandler")] get
        {
          return IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentTemperature.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetPATempHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getPATemp == null)
          IEvents.TemperatureAlarmData.cb_getPATemp = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(IEvents.TemperatureAlarmData.n_GetPATemp));
        return IEvents.TemperatureAlarmData.cb_getPATemp;
      }

      private static int n_GetPATemp(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).PATemp;
      }

      public virtual unsafe int PATemp
      {
        [Register("getPATemp", "()I", "GetGetPATempHandler")] get
        {
          return IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualInt32Method("getPATemp.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
      }

      private static Delegate GetGetTemperatureSourceHandler()
      {
        if ((object) IEvents.TemperatureAlarmData.cb_getTemperatureSource == null)
          IEvents.TemperatureAlarmData.cb_getTemperatureSource = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.TemperatureAlarmData.n_GetTemperatureSource));
        return IEvents.TemperatureAlarmData.cb_getTemperatureSource;
      }

      private static IntPtr n_GetTemperatureSource(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<IEvents.TemperatureAlarmData>(jnienv, native__this, (JniHandleOwnership) 0).TemperatureSource);
      }

      public virtual unsafe TEMPERATURE_SOURCE? TemperatureSource
      {
        [Register("getTemperatureSource", "()Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;", "GetGetTemperatureSourceHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.TemperatureAlarmData._members.InstanceMethods.InvokeVirtualObjectMethod("getTemperatureSource.()Lcom/zebra/rfid/api3/TEMPERATURE_SOURCE;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return Object.GetObject<TEMPERATURE_SOURCE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$WifiScanEventData", DoNotGenerateAcw = true)]
    public class WifiScanEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$WifiScanEventData", typeof (IEvents.WifiScanEventData));

      [Register("wifiscandata")]
      public WifiScanData? Wifiscandata
      {
        get
        {
          JniObjectReference objectValue = IEvents.WifiScanEventData._members.InstanceFields.GetObjectValue("wifiscandata.Lcom/zebra/rfid/api3/WifiScanData;", (IJavaPeerable) this);
          return Object.GetObject<WifiScanData>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
          try
          {
            IEvents.WifiScanEventData._members.InstanceFields.SetValue("wifiscandata.Lcom/zebra/rfid/api3/WifiScanData;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(localJniHandle);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.WifiScanEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.WifiScanEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.WifiScanEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.WifiScanEventData._members.ManagedPeerType;

      protected WifiScanEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }
    }

    [Register("com/zebra/rfid/api3/IEvents$WPAEventData", DoNotGenerateAcw = true)]
    public class WPAEventData : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IEvents$WPAEventData", typeof (IEvents.WPAEventData));
      private static Delegate? cb_getType;
      private static Delegate? cb_setType_Ljava_lang_String_;
      private static Delegate? cb_getssid;
      private static Delegate? cb_setssid_Ljava_lang_String_;

      [Register("m_ssid")]
      public string? MSsid
      {
        get
        {
          JniObjectReference objectValue = IEvents.WPAEventData._members.InstanceFields.GetObjectValue("m_ssid.Ljava/lang/String;", (IJavaPeerable) this);
          return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            IEvents.WPAEventData._members.InstanceFields.SetValue("m_ssid.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      [Register("m_type")]
      public string? MType
      {
        get
        {
          JniObjectReference objectValue = IEvents.WPAEventData._members.InstanceFields.GetObjectValue("m_type.Ljava/lang/String;", (IJavaPeerable) this);
          return JNIEnv.GetString(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
        }
        set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            IEvents.WPAEventData._members.InstanceFields.SetValue("m_type.Ljava/lang/String;", (IJavaPeerable) this, new JniObjectReference(num, (JniObjectReferenceType) 0));
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = IEvents.WPAEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => IEvents.WPAEventData._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = IEvents.WPAEventData._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => IEvents.WPAEventData._members.ManagedPeerType;

      protected WPAEventData(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetTypeHandler()
      {
        if ((object) IEvents.WPAEventData.cb_getType == null)
          IEvents.WPAEventData.cb_getType = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.WPAEventData.n_GetType));
        return IEvents.WPAEventData.cb_getType;
      }

      private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.WPAEventData>(jnienv, native__this, (JniHandleOwnership) 0).Type);
      }

      private static Delegate GetSetType_Ljava_lang_String_Handler()
      {
        if ((object) IEvents.WPAEventData.cb_setType_Ljava_lang_String_ == null)
          IEvents.WPAEventData.cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IEvents.WPAEventData.n_SetType_Ljava_lang_String_));
        return IEvents.WPAEventData.cb_setType_Ljava_lang_String_;
      }

      private static void n_SetType_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_Type)
      {
        Object.GetObject<IEvents.WPAEventData>(jnienv, native__this, (JniHandleOwnership) 0).Type = JNIEnv.GetString(native_Type, (JniHandleOwnership) 0);
      }

      public virtual unsafe string? Type
      {
        [Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler")] get
        {
          JniObjectReference jniObjectReference = IEvents.WPAEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
          return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
        }
        [Register("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")] set
        {
          IntPtr num = JNIEnv.NewString(value);
          try
          {
            JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
            {
              new JniArgumentValue(num)
            };
            IEvents.WPAEventData._members.InstanceMethods.InvokeVirtualVoidMethod("setType.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
          }
          finally
          {
            JNIEnv.DeleteLocalRef(num);
          }
        }
      }

      private static Delegate GetGetssidHandler()
      {
        if ((object) IEvents.WPAEventData.cb_getssid == null)
          IEvents.WPAEventData.cb_getssid = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(IEvents.WPAEventData.n_Getssid));
        return IEvents.WPAEventData.cb_getssid;
      }

      private static IntPtr n_Getssid(IntPtr jnienv, IntPtr native__this)
      {
        return JNIEnv.NewString(Object.GetObject<IEvents.WPAEventData>(jnienv, native__this, (JniHandleOwnership) 0).Getssid());
      }

      [Register("getssid", "()Ljava/lang/String;", "GetGetssidHandler")]
      public virtual unsafe string? Getssid()
      {
        JniObjectReference jniObjectReference = IEvents.WPAEventData._members.InstanceMethods.InvokeVirtualObjectMethod("getssid.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }

      private static Delegate GetSetssid_Ljava_lang_String_Handler()
      {
        if ((object) IEvents.WPAEventData.cb_setssid_Ljava_lang_String_ == null)
          IEvents.WPAEventData.cb_setssid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(IEvents.WPAEventData.n_Setssid_Ljava_lang_String_));
        return IEvents.WPAEventData.cb_setssid_Ljava_lang_String_;
      }

      private static void n_Setssid_Ljava_lang_String_(
        IntPtr jnienv,
        IntPtr native__this,
        IntPtr native_ssid)
      {
        Object.GetObject<IEvents.WPAEventData>(jnienv, native__this, (JniHandleOwnership) 0).Setssid(JNIEnv.GetString(native_ssid, (JniHandleOwnership) 0));
      }

      [Register("setssid", "(Ljava/lang/String;)V", "GetSetssid_Ljava_lang_String_Handler")]
      public virtual unsafe void Setssid(string? ssid)
      {
        IntPtr num = JNIEnv.NewString(ssid);
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(num)
          };
          IEvents.WPAEventData._members.InstanceMethods.InvokeVirtualVoidMethod("setssid.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          JNIEnv.DeleteLocalRef(num);
        }
      }
    }
  }
}
