// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.Param_ReportConfig
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
  [Register("com/zebra/ASCII_SDK/Param_ReportConfig", DoNotGenerateAcw = true)]
  public class Param_ReportConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/ASCII_SDK/Param_ReportConfig", typeof (Param_ReportConfig));
    private static Delegate? cb_getExcChannelIndex;
    private static Delegate? cb_setExcChannelIndex_Z;
    private static Delegate? cb_getExcFirstSeenTime;
    private static Delegate? cb_setExcFirstSeenTime_Z;
    private static Delegate? cb_getExcLastseenTime;
    private static Delegate? cb_setExcLastseenTime_Z;
    private static Delegate? cb_getExcPC;
    private static Delegate? cb_setExcPC_Z;
    private static Delegate? cb_getExcPhase;
    private static Delegate? cb_setExcPhase_Z;
    private static Delegate? cb_getExcRSSI;
    private static Delegate? cb_setExcRSSI_Z;
    private static Delegate? cb_getExcTagSeenCount;
    private static Delegate? cb_setExcTagSeenCount_Z;
    private static Delegate? cb_getIncChannelIndex;
    private static Delegate? cb_setIncChannelIndex_Z;
    private static Delegate? cb_getIncFirstSeenTime;
    private static Delegate? cb_setIncFirstSeenTime_Z;
    private static Delegate? cb_getIncLastSeenTime;
    private static Delegate? cb_setIncLastSeenTime_Z;
    private static Delegate? cb_getIncPC;
    private static Delegate? cb_setIncPC_Z;
    private static Delegate? cb_getIncPhase;
    private static Delegate? cb_setIncPhase_Z;
    private static Delegate? cb_getIncRSSI;
    private static Delegate? cb_setIncRSSI_Z;
    private static Delegate? cb_getIncTagSeenCount;
    private static Delegate? cb_setIncTagSeenCount_Z;
    private static Delegate? cb_FromString_Ljava_lang_String_;
    private static Delegate? cb_ToString;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Param_ReportConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Param_ReportConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Param_ReportConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Param_ReportConfig._members.ManagedPeerType;

    protected Param_ReportConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Param_ReportConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Param_ReportConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Param_ReportConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetExcChannelIndexHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcChannelIndex == null)
        Param_ReportConfig.cb_getExcChannelIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcChannelIndex));
      return Param_ReportConfig.cb_getExcChannelIndex;
    }

    private static bool n_GetExcChannelIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcChannelIndex;
    }

    private static Delegate GetSetExcChannelIndex_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcChannelIndex_Z == null)
        Param_ReportConfig.cb_setExcChannelIndex_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcChannelIndex_Z));
      return Param_ReportConfig.cb_setExcChannelIndex_Z;
    }

    private static void n_SetExcChannelIndex_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcChannelIndex = value;
    }

    public virtual unsafe bool ExcChannelIndex
    {
      [Register("getExcChannelIndex", "()Z", "GetGetExcChannelIndexHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcChannelIndex.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcChannelIndex", "(Z)V", "GetSetExcChannelIndex_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcChannelIndex.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcFirstSeenTimeHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcFirstSeenTime == null)
        Param_ReportConfig.cb_getExcFirstSeenTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcFirstSeenTime));
      return Param_ReportConfig.cb_getExcFirstSeenTime;
    }

    private static bool n_GetExcFirstSeenTime(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcFirstSeenTime;
    }

    private static Delegate GetSetExcFirstSeenTime_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcFirstSeenTime_Z == null)
        Param_ReportConfig.cb_setExcFirstSeenTime_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcFirstSeenTime_Z));
      return Param_ReportConfig.cb_setExcFirstSeenTime_Z;
    }

    private static void n_SetExcFirstSeenTime_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcFirstSeenTime = value;
    }

    public virtual unsafe bool ExcFirstSeenTime
    {
      [Register("getExcFirstSeenTime", "()Z", "GetGetExcFirstSeenTimeHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcFirstSeenTime.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcFirstSeenTime", "(Z)V", "GetSetExcFirstSeenTime_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcFirstSeenTime.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcLastseenTimeHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcLastseenTime == null)
        Param_ReportConfig.cb_getExcLastseenTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcLastseenTime));
      return Param_ReportConfig.cb_getExcLastseenTime;
    }

    private static bool n_GetExcLastseenTime(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcLastseenTime;
    }

    private static Delegate GetSetExcLastseenTime_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcLastseenTime_Z == null)
        Param_ReportConfig.cb_setExcLastseenTime_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcLastseenTime_Z));
      return Param_ReportConfig.cb_setExcLastseenTime_Z;
    }

    private static void n_SetExcLastseenTime_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcLastseenTime = value;
    }

    public virtual unsafe bool ExcLastseenTime
    {
      [Register("getExcLastseenTime", "()Z", "GetGetExcLastseenTimeHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcLastseenTime.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcLastseenTime", "(Z)V", "GetSetExcLastseenTime_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcLastseenTime.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcPCHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcPC == null)
        Param_ReportConfig.cb_getExcPC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcPC));
      return Param_ReportConfig.cb_getExcPC;
    }

    private static bool n_GetExcPC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPC;
    }

    private static Delegate GetSetExcPC_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcPC_Z == null)
        Param_ReportConfig.cb_setExcPC_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcPC_Z));
      return Param_ReportConfig.cb_setExcPC_Z;
    }

    private static void n_SetExcPC_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPC = value;
    }

    public virtual unsafe bool ExcPC
    {
      [Register("getExcPC", "()Z", "GetGetExcPCHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcPC.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcPC", "(Z)V", "GetSetExcPC_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcPC.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcPhaseHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcPhase == null)
        Param_ReportConfig.cb_getExcPhase = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcPhase));
      return Param_ReportConfig.cb_getExcPhase;
    }

    private static bool n_GetExcPhase(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPhase;
    }

    private static Delegate GetSetExcPhase_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcPhase_Z == null)
        Param_ReportConfig.cb_setExcPhase_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcPhase_Z));
      return Param_ReportConfig.cb_setExcPhase_Z;
    }

    private static void n_SetExcPhase_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcPhase = value;
    }

    public virtual unsafe bool ExcPhase
    {
      [Register("getExcPhase", "()Z", "GetGetExcPhaseHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcPhase.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcPhase", "(Z)V", "GetSetExcPhase_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcPhase.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcRSSIHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcRSSI == null)
        Param_ReportConfig.cb_getExcRSSI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcRSSI));
      return Param_ReportConfig.cb_getExcRSSI;
    }

    private static bool n_GetExcRSSI(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcRSSI;
    }

    private static Delegate GetSetExcRSSI_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcRSSI_Z == null)
        Param_ReportConfig.cb_setExcRSSI_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcRSSI_Z));
      return Param_ReportConfig.cb_setExcRSSI_Z;
    }

    private static void n_SetExcRSSI_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcRSSI = value;
    }

    public virtual unsafe bool ExcRSSI
    {
      [Register("getExcRSSI", "()Z", "GetGetExcRSSIHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcRSSI.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcRSSI", "(Z)V", "GetSetExcRSSI_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcRSSI.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetExcTagSeenCountHandler()
    {
      if ((object) Param_ReportConfig.cb_getExcTagSeenCount == null)
        Param_ReportConfig.cb_getExcTagSeenCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetExcTagSeenCount));
      return Param_ReportConfig.cb_getExcTagSeenCount;
    }

    private static bool n_GetExcTagSeenCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcTagSeenCount;
    }

    private static Delegate GetSetExcTagSeenCount_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setExcTagSeenCount_Z == null)
        Param_ReportConfig.cb_setExcTagSeenCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetExcTagSeenCount_Z));
      return Param_ReportConfig.cb_setExcTagSeenCount_Z;
    }

    private static void n_SetExcTagSeenCount_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).ExcTagSeenCount = value;
    }

    public virtual unsafe bool ExcTagSeenCount
    {
      [Register("getExcTagSeenCount", "()Z", "GetGetExcTagSeenCountHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getExcTagSeenCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setExcTagSeenCount", "(Z)V", "GetSetExcTagSeenCount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setExcTagSeenCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncChannelIndexHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncChannelIndex == null)
        Param_ReportConfig.cb_getIncChannelIndex = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncChannelIndex));
      return Param_ReportConfig.cb_getIncChannelIndex;
    }

    private static bool n_GetIncChannelIndex(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncChannelIndex;
    }

    private static Delegate GetSetIncChannelIndex_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncChannelIndex_Z == null)
        Param_ReportConfig.cb_setIncChannelIndex_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncChannelIndex_Z));
      return Param_ReportConfig.cb_setIncChannelIndex_Z;
    }

    private static void n_SetIncChannelIndex_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncChannelIndex = value;
    }

    public virtual unsafe bool IncChannelIndex
    {
      [Register("getIncChannelIndex", "()Z", "GetGetIncChannelIndexHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncChannelIndex.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncChannelIndex", "(Z)V", "GetSetIncChannelIndex_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncChannelIndex.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncFirstSeenTimeHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncFirstSeenTime == null)
        Param_ReportConfig.cb_getIncFirstSeenTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncFirstSeenTime));
      return Param_ReportConfig.cb_getIncFirstSeenTime;
    }

    private static bool n_GetIncFirstSeenTime(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncFirstSeenTime;
    }

    private static Delegate GetSetIncFirstSeenTime_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncFirstSeenTime_Z == null)
        Param_ReportConfig.cb_setIncFirstSeenTime_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncFirstSeenTime_Z));
      return Param_ReportConfig.cb_setIncFirstSeenTime_Z;
    }

    private static void n_SetIncFirstSeenTime_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncFirstSeenTime = value;
    }

    public virtual unsafe bool IncFirstSeenTime
    {
      [Register("getIncFirstSeenTime", "()Z", "GetGetIncFirstSeenTimeHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncFirstSeenTime.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncFirstSeenTime", "(Z)V", "GetSetIncFirstSeenTime_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncFirstSeenTime.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncLastSeenTimeHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncLastSeenTime == null)
        Param_ReportConfig.cb_getIncLastSeenTime = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncLastSeenTime));
      return Param_ReportConfig.cb_getIncLastSeenTime;
    }

    private static bool n_GetIncLastSeenTime(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncLastSeenTime;
    }

    private static Delegate GetSetIncLastSeenTime_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncLastSeenTime_Z == null)
        Param_ReportConfig.cb_setIncLastSeenTime_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncLastSeenTime_Z));
      return Param_ReportConfig.cb_setIncLastSeenTime_Z;
    }

    private static void n_SetIncLastSeenTime_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncLastSeenTime = value;
    }

    public virtual unsafe bool IncLastSeenTime
    {
      [Register("getIncLastSeenTime", "()Z", "GetGetIncLastSeenTimeHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncLastSeenTime.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncLastSeenTime", "(Z)V", "GetSetIncLastSeenTime_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncLastSeenTime.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncPCHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncPC == null)
        Param_ReportConfig.cb_getIncPC = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncPC));
      return Param_ReportConfig.cb_getIncPC;
    }

    private static bool n_GetIncPC(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPC;
    }

    private static Delegate GetSetIncPC_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncPC_Z == null)
        Param_ReportConfig.cb_setIncPC_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncPC_Z));
      return Param_ReportConfig.cb_setIncPC_Z;
    }

    private static void n_SetIncPC_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPC = value;
    }

    public virtual unsafe bool IncPC
    {
      [Register("getIncPC", "()Z", "GetGetIncPCHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncPC.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncPC", "(Z)V", "GetSetIncPC_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncPC.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncPhaseHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncPhase == null)
        Param_ReportConfig.cb_getIncPhase = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncPhase));
      return Param_ReportConfig.cb_getIncPhase;
    }

    private static bool n_GetIncPhase(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPhase;
    }

    private static Delegate GetSetIncPhase_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncPhase_Z == null)
        Param_ReportConfig.cb_setIncPhase_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncPhase_Z));
      return Param_ReportConfig.cb_setIncPhase_Z;
    }

    private static void n_SetIncPhase_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncPhase = value;
    }

    public virtual unsafe bool IncPhase
    {
      [Register("getIncPhase", "()Z", "GetGetIncPhaseHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncPhase.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncPhase", "(Z)V", "GetSetIncPhase_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncPhase.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncRSSIHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncRSSI == null)
        Param_ReportConfig.cb_getIncRSSI = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncRSSI));
      return Param_ReportConfig.cb_getIncRSSI;
    }

    private static bool n_GetIncRSSI(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncRSSI;
    }

    private static Delegate GetSetIncRSSI_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncRSSI_Z == null)
        Param_ReportConfig.cb_setIncRSSI_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncRSSI_Z));
      return Param_ReportConfig.cb_setIncRSSI_Z;
    }

    private static void n_SetIncRSSI_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncRSSI = value;
    }

    public virtual unsafe bool IncRSSI
    {
      [Register("getIncRSSI", "()Z", "GetGetIncRSSIHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncRSSI.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncRSSI", "(Z)V", "GetSetIncRSSI_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncRSSI.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetIncTagSeenCountHandler()
    {
      if ((object) Param_ReportConfig.cb_getIncTagSeenCount == null)
        Param_ReportConfig.cb_getIncTagSeenCount = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Param_ReportConfig.n_GetIncTagSeenCount));
      return Param_ReportConfig.cb_getIncTagSeenCount;
    }

    private static bool n_GetIncTagSeenCount(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncTagSeenCount;
    }

    private static Delegate GetSetIncTagSeenCount_ZHandler()
    {
      if ((object) Param_ReportConfig.cb_setIncTagSeenCount_Z == null)
        Param_ReportConfig.cb_setIncTagSeenCount_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(Param_ReportConfig.n_SetIncTagSeenCount_Z));
      return Param_ReportConfig.cb_setIncTagSeenCount_Z;
    }

    private static void n_SetIncTagSeenCount_Z(IntPtr jnienv, IntPtr native__this, bool value)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).IncTagSeenCount = value;
    }

    public virtual unsafe bool IncTagSeenCount
    {
      [Register("getIncTagSeenCount", "()Z", "GetGetIncTagSeenCountHandler")] get
      {
        return Param_ReportConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getIncTagSeenCount.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setIncTagSeenCount", "(Z)V", "GetSetIncTagSeenCount_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setIncTagSeenCount.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetFromString_Ljava_lang_String_Handler()
    {
      if ((object) Param_ReportConfig.cb_FromString_Ljava_lang_String_ == null)
        Param_ReportConfig.cb_FromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Param_ReportConfig.n_FromString_Ljava_lang_String_));
      return Param_ReportConfig.cb_FromString_Ljava_lang_String_;
    }

    private static void n_FromString_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_str)
    {
      Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0).FromString(JNIEnv.GetString(native_str, (JniHandleOwnership) 0));
    }

    [Register("FromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
    public virtual unsafe void FromString(string? str)
    {
      IntPtr num = JNIEnv.NewString(str);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Param_ReportConfig._members.InstanceMethods.InvokeVirtualVoidMethod("FromString.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetToStringHandler()
    {
      if ((object) Param_ReportConfig.cb_ToString == null)
        Param_ReportConfig.cb_ToString = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Param_ReportConfig.n_ToString));
      return Param_ReportConfig.cb_ToString;
    }

    private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewString(((object) Object.GetObject<Param_ReportConfig>(jnienv, native__this, (JniHandleOwnership) 0)).ToString());
    }

    [Register("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
    public virtual unsafe string? ToString()
    {
      JniObjectReference jniObjectReference = Param_ReportConfig._members.InstanceMethods.InvokeVirtualObjectMethod("ToString.()Ljava/lang/String;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return JNIEnv.GetString(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
