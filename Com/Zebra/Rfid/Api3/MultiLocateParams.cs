// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.MultiLocateParams
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
  [Register("com/zebra/rfid/api3/MultiLocateParams", DoNotGenerateAcw = true)]
  public class MultiLocateParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MultiLocateParams", typeof (MultiLocateParams));
    private static Delegate? cb_getDetectionProfile;
    private static Delegate? cb_setDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    private static Delegate? cb_getHighProfile;
    private static Delegate? cb_setHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    private static Delegate? cb_getLowProfile;
    private static Delegate? cb_setLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    private static Delegate? cb_getMaxProfile;
    private static Delegate? cb_setMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    private static Delegate? cb_getMediumProfile;
    private static Delegate? cb_setMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;

    [Register("lock_off")]
    public int LockOff
    {
      get
      {
        return MultiLocateParams._members.InstanceFields.GetInt32Value("lock_off.I", (IJavaPeerable) this);
      }
      set
      {
        MultiLocateParams._members.InstanceFields.SetValue("lock_off.I", (IJavaPeerable) this, value);
      }
    }

    [Register("lock_off_time")]
    public int LockOffTime
    {
      get
      {
        return MultiLocateParams._members.InstanceFields.GetInt32Value("lock_off_time.I", (IJavaPeerable) this);
      }
      set
      {
        MultiLocateParams._members.InstanceFields.SetValue("lock_off_time.I", (IJavaPeerable) this, value);
      }
    }

    [Register("lock_on")]
    public int LockOn
    {
      get
      {
        return MultiLocateParams._members.InstanceFields.GetInt32Value("lock_on.I", (IJavaPeerable) this);
      }
      set
      {
        MultiLocateParams._members.InstanceFields.SetValue("lock_on.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = MultiLocateParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => MultiLocateParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = MultiLocateParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => MultiLocateParams._members.ManagedPeerType;

    protected MultiLocateParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe MultiLocateParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = MultiLocateParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      MultiLocateParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    [Register(".ctor", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "")]
    public unsafe MultiLocateParams(
      MultiLocateParams.Profile? detectionProfile,
      MultiLocateParams.Profile? lowProfile,
      MultiLocateParams.Profile? mediumProfile,
      MultiLocateParams.Profile? highProfile,
      MultiLocateParams.Profile? maxProfile)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[5]
        {
          new JniArgumentValue(detectionProfile == null ? IntPtr.Zero : detectionProfile.Handle),
          new JniArgumentValue(lowProfile == null ? IntPtr.Zero : lowProfile.Handle),
          new JniArgumentValue(mediumProfile == null ? IntPtr.Zero : mediumProfile.Handle),
          new JniArgumentValue(highProfile == null ? IntPtr.Zero : highProfile.Handle),
          new JniArgumentValue(maxProfile == null ? IntPtr.Zero : maxProfile.Handle)
        };
        JniObjectReference instance = MultiLocateParams._members.InstanceMethods.StartCreateInstance("(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", ((object) this).GetType(), jniArgumentValuePtr);
        this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
        MultiLocateParams._members.InstanceMethods.FinishCreateInstance("(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) detectionProfile);
        GC.KeepAlive((object) lowProfile);
        GC.KeepAlive((object) mediumProfile);
        GC.KeepAlive((object) highProfile);
        GC.KeepAlive((object) maxProfile);
      }
    }

    [Register(".ctor", "(III)V", "")]
    public unsafe MultiLocateParams(int lock_on, int lock_off, int lock_off_time)
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
      {
        new JniArgumentValue(lock_on),
        new JniArgumentValue(lock_off),
        new JniArgumentValue(lock_off_time)
      };
      JniObjectReference instance = MultiLocateParams._members.InstanceMethods.StartCreateInstance("(III)V", ((object) this).GetType(), jniArgumentValuePtr);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      MultiLocateParams._members.InstanceMethods.FinishCreateInstance("(III)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }

    private static Delegate GetGetDetectionProfileHandler()
    {
      if ((object) MultiLocateParams.cb_getDetectionProfile == null)
        MultiLocateParams.cb_getDetectionProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiLocateParams.n_GetDetectionProfile));
      return MultiLocateParams.cb_getDetectionProfile;
    }

    private static IntPtr n_GetDetectionProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).DetectionProfile);
    }

    private static Delegate GetSetDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler()
    {
      if ((object) MultiLocateParams.cb_setDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ == null)
        MultiLocateParams.cb_setDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiLocateParams.n_SetDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_));
      return MultiLocateParams.cb_setDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    }

    private static void n_SetDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_detectionProfile)
    {
      Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).DetectionProfile = Object.GetObject<MultiLocateParams.Profile>(native_detectionProfile, (JniHandleOwnership) 0);
    }

    public virtual unsafe MultiLocateParams.Profile? DetectionProfile
    {
      [Register("getDetectionProfile", "()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", "GetGetDetectionProfileHandler")] get
      {
        JniObjectReference jniObjectReference = MultiLocateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getDetectionProfile.()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MultiLocateParams.Profile>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setDetectionProfile", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "GetSetDetectionProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          MultiLocateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setDetectionProfile.(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetHighProfileHandler()
    {
      if ((object) MultiLocateParams.cb_getHighProfile == null)
        MultiLocateParams.cb_getHighProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiLocateParams.n_GetHighProfile));
      return MultiLocateParams.cb_getHighProfile;
    }

    private static IntPtr n_GetHighProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).HighProfile);
    }

    private static Delegate GetSetHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler()
    {
      if ((object) MultiLocateParams.cb_setHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ == null)
        MultiLocateParams.cb_setHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiLocateParams.n_SetHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_));
      return MultiLocateParams.cb_setHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    }

    private static void n_SetHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_highProfile)
    {
      Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).HighProfile = Object.GetObject<MultiLocateParams.Profile>(native_highProfile, (JniHandleOwnership) 0);
    }

    public virtual unsafe MultiLocateParams.Profile? HighProfile
    {
      [Register("getHighProfile", "()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", "GetGetHighProfileHandler")] get
      {
        JniObjectReference jniObjectReference = MultiLocateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getHighProfile.()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MultiLocateParams.Profile>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setHighProfile", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "GetSetHighProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          MultiLocateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setHighProfile.(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetLowProfileHandler()
    {
      if ((object) MultiLocateParams.cb_getLowProfile == null)
        MultiLocateParams.cb_getLowProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiLocateParams.n_GetLowProfile));
      return MultiLocateParams.cb_getLowProfile;
    }

    private static IntPtr n_GetLowProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).LowProfile);
    }

    private static Delegate GetSetLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler()
    {
      if ((object) MultiLocateParams.cb_setLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ == null)
        MultiLocateParams.cb_setLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiLocateParams.n_SetLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_));
      return MultiLocateParams.cb_setLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    }

    private static void n_SetLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_lowProfile)
    {
      Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).LowProfile = Object.GetObject<MultiLocateParams.Profile>(native_lowProfile, (JniHandleOwnership) 0);
    }

    public virtual unsafe MultiLocateParams.Profile? LowProfile
    {
      [Register("getLowProfile", "()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", "GetGetLowProfileHandler")] get
      {
        JniObjectReference jniObjectReference = MultiLocateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getLowProfile.()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MultiLocateParams.Profile>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setLowProfile", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "GetSetLowProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          MultiLocateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setLowProfile.(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetMaxProfileHandler()
    {
      if ((object) MultiLocateParams.cb_getMaxProfile == null)
        MultiLocateParams.cb_getMaxProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiLocateParams.n_GetMaxProfile));
      return MultiLocateParams.cb_getMaxProfile;
    }

    private static IntPtr n_GetMaxProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).MaxProfile);
    }

    private static Delegate GetSetMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler()
    {
      if ((object) MultiLocateParams.cb_setMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ == null)
        MultiLocateParams.cb_setMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiLocateParams.n_SetMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_));
      return MultiLocateParams.cb_setMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    }

    private static void n_SetMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_maxProfile)
    {
      Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).MaxProfile = Object.GetObject<MultiLocateParams.Profile>(native_maxProfile, (JniHandleOwnership) 0);
    }

    public virtual unsafe MultiLocateParams.Profile? MaxProfile
    {
      [Register("getMaxProfile", "()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", "GetGetMaxProfileHandler")] get
      {
        JniObjectReference jniObjectReference = MultiLocateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMaxProfile.()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MultiLocateParams.Profile>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMaxProfile", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "GetSetMaxProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          MultiLocateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxProfile.(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetGetMediumProfileHandler()
    {
      if ((object) MultiLocateParams.cb_getMediumProfile == null)
        MultiLocateParams.cb_getMediumProfile = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(MultiLocateParams.n_GetMediumProfile));
      return MultiLocateParams.cb_getMediumProfile;
    }

    private static IntPtr n_GetMediumProfile(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).MediumProfile);
    }

    private static Delegate GetSetMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler()
    {
      if ((object) MultiLocateParams.cb_setMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ == null)
        MultiLocateParams.cb_setMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(MultiLocateParams.n_SetMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_));
      return MultiLocateParams.cb_setMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_;
    }

    private static void n_SetMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_mediumProfile)
    {
      Object.GetObject<MultiLocateParams>(jnienv, native__this, (JniHandleOwnership) 0).MediumProfile = Object.GetObject<MultiLocateParams.Profile>(native_mediumProfile, (JniHandleOwnership) 0);
    }

    public virtual unsafe MultiLocateParams.Profile? MediumProfile
    {
      [Register("getMediumProfile", "()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", "GetGetMediumProfileHandler")] get
      {
        JniObjectReference jniObjectReference = MultiLocateParams._members.InstanceMethods.InvokeVirtualObjectMethod("getMediumProfile.()Lcom/zebra/rfid/api3/MultiLocateParams$Profile;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<MultiLocateParams.Profile>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setMediumProfile", "(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", "GetSetMediumProfile_Lcom_zebra_rfid_api3_MultiLocateParams_Profile_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          MultiLocateParams._members.InstanceMethods.InvokeVirtualVoidMethod("setMediumProfile.(Lcom/zebra/rfid/api3/MultiLocateParams$Profile;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    [Register("com/zebra/rfid/api3/MultiLocateParams$Profile", DoNotGenerateAcw = true)]
    public class Profile : Object
    {
      private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/MultiLocateParams$Profile", typeof (MultiLocateParams.Profile));
      private static Delegate? cb_getLevel;
      private static Delegate? cb_setLevel_I;
      private static Delegate? cb_getTime;
      private static Delegate? cb_setTime_I;
      private static Delegate? cb_getVolume;
      private static Delegate? cb_setVolume_I;

      internal static IntPtr class_ref
      {
        get
        {
          JniObjectReference peerReference = MultiLocateParams.Profile._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public virtual JniPeerMembers JniPeerMembers => MultiLocateParams.Profile._members;

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual IntPtr ThresholdClass
      {
        get
        {
          JniObjectReference peerReference = MultiLocateParams.Profile._members.JniPeerType.PeerReference;
          return ((JniObjectReference) ref peerReference).Handle;
        }
      }

      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      protected virtual Type ThresholdType => MultiLocateParams.Profile._members.ManagedPeerType;

      protected Profile(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
      {
      }

      private static Delegate GetGetLevelHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_getLevel == null)
          MultiLocateParams.Profile.cb_getLevel = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MultiLocateParams.Profile.n_GetLevel));
        return MultiLocateParams.Profile.cb_getLevel;
      }

      private static int n_GetLevel(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Level;
      }

      private static Delegate GetSetLevel_IHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_setLevel_I == null)
          MultiLocateParams.Profile.cb_setLevel_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(MultiLocateParams.Profile.n_SetLevel_I));
        return MultiLocateParams.Profile.cb_setLevel_I;
      }

      private static void n_SetLevel_I(IntPtr jnienv, IntPtr native__this, int level)
      {
        Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Level = level;
      }

      public virtual unsafe int Level
      {
        [Register("getLevel", "()I", "GetGetLevelHandler")] get
        {
          return MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualInt32Method("getLevel.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setLevel", "(I)V", "GetSetLevel_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualVoidMethod("setLevel.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetTimeHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_getTime == null)
          MultiLocateParams.Profile.cb_getTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MultiLocateParams.Profile.n_GetTime));
        return MultiLocateParams.Profile.cb_getTime;
      }

      private static int n_GetTime(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Time;
      }

      private static Delegate GetSetTime_IHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_setTime_I == null)
          MultiLocateParams.Profile.cb_setTime_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(MultiLocateParams.Profile.n_SetTime_I));
        return MultiLocateParams.Profile.cb_setTime_I;
      }

      private static void n_SetTime_I(IntPtr jnienv, IntPtr native__this, int time)
      {
        Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Time = time;
      }

      public virtual unsafe int Time
      {
        [Register("getTime", "()I", "GetGetTimeHandler")] get
        {
          return MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualInt32Method("getTime.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setTime", "(I)V", "GetSetTime_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualVoidMethod("setTime.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }

      private static Delegate GetGetVolumeHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_getVolume == null)
          MultiLocateParams.Profile.cb_getVolume = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(MultiLocateParams.Profile.n_GetVolume));
        return MultiLocateParams.Profile.cb_getVolume;
      }

      private static int n_GetVolume(IntPtr jnienv, IntPtr native__this)
      {
        return Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Volume;
      }

      private static Delegate GetSetVolume_IHandler()
      {
        if ((object) MultiLocateParams.Profile.cb_setVolume_I == null)
          MultiLocateParams.Profile.cb_setVolume_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(MultiLocateParams.Profile.n_SetVolume_I));
        return MultiLocateParams.Profile.cb_setVolume_I;
      }

      private static void n_SetVolume_I(IntPtr jnienv, IntPtr native__this, int volume)
      {
        Object.GetObject<MultiLocateParams.Profile>(jnienv, native__this, (JniHandleOwnership) 0).Volume = volume;
      }

      public virtual unsafe int Volume
      {
        [Register("getVolume", "()I", "GetGetVolumeHandler")] get
        {
          return MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualInt32Method("getVolume.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
        }
        [Register("setVolume", "(I)V", "GetSetVolume_IHandler")] set
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value)
          };
          MultiLocateParams.Profile._members.InstanceMethods.InvokeVirtualVoidMethod("setVolume.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
      }
    }
  }
}
