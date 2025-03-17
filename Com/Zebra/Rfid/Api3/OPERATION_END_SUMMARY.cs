// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.OPERATION_END_SUMMARY
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
  [Register("com/zebra/rfid/api3/OPERATION_END_SUMMARY", DoNotGenerateAcw = true)]
  public class OPERATION_END_SUMMARY : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/OPERATION_END_SUMMARY", typeof (OPERATION_END_SUMMARY));
    private static Delegate? cb_getTotalRounds;
    private static Delegate? cb_setTotalRounds_I;
    private static Delegate? cb_getTotalTags;
    private static Delegate? cb_setTotalTags_I;
    private static Delegate? cb_getTotalTimeuS;
    private static Delegate? cb_setTotalTimeuS_J;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = OPERATION_END_SUMMARY._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => OPERATION_END_SUMMARY._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = OPERATION_END_SUMMARY._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => OPERATION_END_SUMMARY._members.ManagedPeerType;

    protected OPERATION_END_SUMMARY(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe OPERATION_END_SUMMARY()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = OPERATION_END_SUMMARY._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      OPERATION_END_SUMMARY._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetTotalRoundsHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_getTotalRounds == null)
        OPERATION_END_SUMMARY.cb_getTotalRounds = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(OPERATION_END_SUMMARY.n_GetTotalRounds));
      return OPERATION_END_SUMMARY.cb_getTotalRounds;
    }

    private static int n_GetTotalRounds(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalRounds;
    }

    private static Delegate GetSetTotalRounds_IHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_setTotalRounds_I == null)
        OPERATION_END_SUMMARY.cb_setTotalRounds_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(OPERATION_END_SUMMARY.n_SetTotalRounds_I));
      return OPERATION_END_SUMMARY.cb_setTotalRounds_I;
    }

    private static void n_SetTotalRounds_I(IntPtr jnienv, IntPtr native__this, int totalRounds)
    {
      Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalRounds = totalRounds;
    }

    public virtual unsafe int TotalRounds
    {
      [Register("getTotalRounds", "()I", "GetGetTotalRoundsHandler")] get
      {
        return OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualInt32Method("getTotalRounds.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTotalRounds", "(I)V", "GetSetTotalRounds_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualVoidMethod("setTotalRounds.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTotalTagsHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_getTotalTags == null)
        OPERATION_END_SUMMARY.cb_getTotalTags = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(OPERATION_END_SUMMARY.n_GetTotalTags));
      return OPERATION_END_SUMMARY.cb_getTotalTags;
    }

    private static int n_GetTotalTags(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalTags;
    }

    private static Delegate GetSetTotalTags_IHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_setTotalTags_I == null)
        OPERATION_END_SUMMARY.cb_setTotalTags_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_V(OPERATION_END_SUMMARY.n_SetTotalTags_I));
      return OPERATION_END_SUMMARY.cb_setTotalTags_I;
    }

    private static void n_SetTotalTags_I(IntPtr jnienv, IntPtr native__this, int totalTags)
    {
      Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalTags = totalTags;
    }

    public virtual unsafe int TotalTags
    {
      [Register("getTotalTags", "()I", "GetGetTotalTagsHandler")] get
      {
        return OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualInt32Method("getTotalTags.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTotalTags", "(I)V", "GetSetTotalTags_IHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualVoidMethod("setTotalTags.(I)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetTotalTimeuSHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_getTotalTimeuS == null)
        OPERATION_END_SUMMARY.cb_getTotalTimeuS = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(OPERATION_END_SUMMARY.n_GetTotalTimeuS));
      return OPERATION_END_SUMMARY.cb_getTotalTimeuS;
    }

    private static long n_GetTotalTimeuS(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalTimeuS;
    }

    private static Delegate GetSetTotalTimeuS_JHandler()
    {
      if ((object) OPERATION_END_SUMMARY.cb_setTotalTimeuS_J == null)
        OPERATION_END_SUMMARY.cb_setTotalTimeuS_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(OPERATION_END_SUMMARY.n_SetTotalTimeuS_J));
      return OPERATION_END_SUMMARY.cb_setTotalTimeuS_J;
    }

    private static void n_SetTotalTimeuS_J(IntPtr jnienv, IntPtr native__this, long totalTimeuS)
    {
      Object.GetObject<OPERATION_END_SUMMARY>(jnienv, native__this, (JniHandleOwnership) 0).TotalTimeuS = totalTimeuS;
    }

    public virtual unsafe long TotalTimeuS
    {
      [Register("getTotalTimeuS", "()J", "GetGetTotalTimeuSHandler")] get
      {
        return OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualInt64Method("getTotalTimeuS.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setTotalTimeuS", "(J)V", "GetSetTotalTimeuS_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        OPERATION_END_SUMMARY._members.InstanceMethods.InvokeVirtualVoidMethod("setTotalTimeuS.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
