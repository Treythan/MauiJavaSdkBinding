// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.IDCConfig
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/IDCConfig", DoNotGenerateAcw = true)]
  public class IDCConfig : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/IDCConfig", typeof (IDCConfig));
    private static Delegate? cb_getSendIDCDataAsBinaryEventEnabledFlag;
    private static Delegate? cb_setSendIDCDataAsBinaryEventEnabledFlag_Z;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = IDCConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => IDCConfig._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = IDCConfig._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => IDCConfig._members.ManagedPeerType;

    protected IDCConfig(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe IDCConfig()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = IDCConfig._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      IDCConfig._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetSendIDCDataAsBinaryEventEnabledFlagHandler()
    {
      if ((object) IDCConfig.cb_getSendIDCDataAsBinaryEventEnabledFlag == null)
        IDCConfig.cb_getSendIDCDataAsBinaryEventEnabledFlag = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(IDCConfig.n_GetSendIDCDataAsBinaryEventEnabledFlag));
      return IDCConfig.cb_getSendIDCDataAsBinaryEventEnabledFlag;
    }

    private static bool n_GetSendIDCDataAsBinaryEventEnabledFlag(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<IDCConfig>(jnienv, native__this, (JniHandleOwnership) 0).SendIDCDataAsBinaryEventEnabledFlag;
    }

    private static Delegate GetSetSendIDCDataAsBinaryEventEnabledFlag_ZHandler()
    {
      if ((object) IDCConfig.cb_setSendIDCDataAsBinaryEventEnabledFlag_Z == null)
        IDCConfig.cb_setSendIDCDataAsBinaryEventEnabledFlag_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(IDCConfig.n_SetSendIDCDataAsBinaryEventEnabledFlag_Z));
      return IDCConfig.cb_setSendIDCDataAsBinaryEventEnabledFlag_Z;
    }

    private static void n_SetSendIDCDataAsBinaryEventEnabledFlag_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool isEnabled)
    {
      Object.GetObject<IDCConfig>(jnienv, native__this, (JniHandleOwnership) 0).SendIDCDataAsBinaryEventEnabledFlag = isEnabled;
    }

    public virtual unsafe bool SendIDCDataAsBinaryEventEnabledFlag
    {
      [Register("getSendIDCDataAsBinaryEventEnabledFlag", "()Z", "GetGetSendIDCDataAsBinaryEventEnabledFlagHandler")] get
      {
        return IDCConfig._members.InstanceMethods.InvokeVirtualBooleanMethod("getSendIDCDataAsBinaryEventEnabledFlag.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setSendIDCDataAsBinaryEventEnabledFlag", "(Z)V", "GetSetSendIDCDataAsBinaryEventEnabledFlag_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        IDCConfig._members.InstanceMethods.InvokeVirtualVoidMethod("setSendIDCDataAsBinaryEventEnabledFlag.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
