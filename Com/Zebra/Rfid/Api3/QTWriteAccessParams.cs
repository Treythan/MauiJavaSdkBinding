// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.QTWriteAccessParams
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
  [Register("com/zebra/rfid/api3/QTWriteAccessParams", DoNotGenerateAcw = true)]
  public class QTWriteAccessParams : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/QTWriteAccessParams", typeof (QTWriteAccessParams));
    private static Delegate? cb_getAccessPassword;
    private static Delegate? cb_setAccessPassword_J;
    private static Delegate? cb_getQTControlData;
    private static Delegate? cb_setQTControlData_S;
    private static Delegate? cb_isQTPersist;
    private static Delegate? cb_setQTPersist_Z;

    [Register("m_QTControlData")]
    public short MQTControlData
    {
      get
      {
        return QTWriteAccessParams._members.InstanceFields.GetInt16Value("m_QTControlData.S", (IJavaPeerable) this);
      }
      set
      {
        QTWriteAccessParams._members.InstanceFields.SetValue("m_QTControlData.S", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = QTWriteAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => QTWriteAccessParams._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = QTWriteAccessParams._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => QTWriteAccessParams._members.ManagedPeerType;

    protected QTWriteAccessParams(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe QTWriteAccessParams()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = QTWriteAccessParams._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      QTWriteAccessParams._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccessPasswordHandler()
    {
      if ((object) QTWriteAccessParams.cb_getAccessPassword == null)
        QTWriteAccessParams.cb_getAccessPassword = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_J(QTWriteAccessParams.n_GetAccessPassword));
      return QTWriteAccessParams.cb_getAccessPassword;
    }

    private static long n_GetAccessPassword(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword;
    }

    private static Delegate GetSetAccessPassword_JHandler()
    {
      if ((object) QTWriteAccessParams.cb_setAccessPassword_J == null)
        QTWriteAccessParams.cb_setAccessPassword_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_V(QTWriteAccessParams.n_SetAccessPassword_J));
      return QTWriteAccessParams.cb_setAccessPassword_J;
    }

    private static void n_SetAccessPassword_J(
      IntPtr jnienv,
      IntPtr native__this,
      long m_nAccessPassword)
    {
      Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).AccessPassword = m_nAccessPassword;
    }

    public virtual unsafe long AccessPassword
    {
      [Register("getAccessPassword", "()J", "GetGetAccessPasswordHandler")] get
      {
        return QTWriteAccessParams._members.InstanceMethods.InvokeVirtualInt64Method("getAccessPassword.()J", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setAccessPassword", "(J)V", "GetSetAccessPassword_JHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        QTWriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessPassword.(J)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetGetQTControlDataHandler()
    {
      if ((object) QTWriteAccessParams.cb_getQTControlData == null)
        QTWriteAccessParams.cb_getQTControlData = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_S(QTWriteAccessParams.n_GetQTControlData));
      return QTWriteAccessParams.cb_getQTControlData;
    }

    private static short n_GetQTControlData(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).QTControlData;
    }

    private static Delegate GetSetQTControlData_SHandler()
    {
      if ((object) QTWriteAccessParams.cb_setQTControlData_S == null)
        QTWriteAccessParams.cb_setQTControlData_S = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPS_V(QTWriteAccessParams.n_SetQTControlData_S));
      return QTWriteAccessParams.cb_setQTControlData_S;
    }

    private static void n_SetQTControlData_S(
      IntPtr jnienv,
      IntPtr native__this,
      short m_QTControlData)
    {
      Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).QTControlData = m_QTControlData;
    }

    public virtual unsafe short QTControlData
    {
      [Register("getQTControlData", "()S", "GetGetQTControlDataHandler")] get
      {
        return QTWriteAccessParams._members.InstanceMethods.InvokeVirtualInt16Method("getQTControlData.()S", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setQTControlData", "(S)V", "GetSetQTControlData_SHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        QTWriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setQTControlData.(S)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }

    private static Delegate GetIsQTPersistHandler()
    {
      if ((object) QTWriteAccessParams.cb_isQTPersist == null)
        QTWriteAccessParams.cb_isQTPersist = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(QTWriteAccessParams.n_IsQTPersist));
      return QTWriteAccessParams.cb_isQTPersist;
    }

    private static bool n_IsQTPersist(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).QTPersist;
    }

    private static Delegate GetSetQTPersist_ZHandler()
    {
      if ((object) QTWriteAccessParams.cb_setQTPersist_Z == null)
        QTWriteAccessParams.cb_setQTPersist_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(QTWriteAccessParams.n_SetQTPersist_Z));
      return QTWriteAccessParams.cb_setQTPersist_Z;
    }

    private static void n_SetQTPersist_Z(IntPtr jnienv, IntPtr native__this, bool QTPersist)
    {
      Object.GetObject<QTWriteAccessParams>(jnienv, native__this, (JniHandleOwnership) 0).QTPersist = QTPersist;
    }

    public virtual unsafe bool QTPersist
    {
      [Register("isQTPersist", "()Z", "GetIsQTPersistHandler")] get
      {
        return QTWriteAccessParams._members.InstanceMethods.InvokeVirtualBooleanMethod("isQTPersist.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
      [Register("setQTPersist", "(Z)V", "GetSetQTPersist_ZHandler")] set
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(value)
        };
        QTWriteAccessParams._members.InstanceMethods.InvokeVirtualVoidMethod("setQTPersist.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
    }
  }
}
