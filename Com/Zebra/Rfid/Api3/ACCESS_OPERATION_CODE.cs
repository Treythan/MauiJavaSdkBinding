// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ACCESS_OPERATION_CODE
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
  [Register("com/zebra/rfid/api3/ACCESS_OPERATION_CODE", DoNotGenerateAcw = true)]
  public class ACCESS_OPERATION_CODE : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ACCESS_OPERATION_CODE", typeof (ACCESS_OPERATION_CODE));
    private static Delegate? cb_getValue;
    private static Delegate? cb_equals_I;

    [Register("ACCESS_OPERATION_BLOCK_ERASE")]
    public static ACCESS_OPERATION_CODE? AccessOperationBlockErase
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_BLOCK_ERASE.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_BLOCK_PERMALOCK")]
    public static ACCESS_OPERATION_CODE? AccessOperationBlockPermalock
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_BLOCK_PERMALOCK.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_BLOCK_WRITE")]
    public static ACCESS_OPERATION_CODE? AccessOperationBlockWrite
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_BLOCK_WRITE.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_IMPINJ_QT_READ")]
    public static ACCESS_OPERATION_CODE? AccessOperationImpinjQtRead
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_IMPINJ_QT_READ.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_IMPINJ_QT_WRITE")]
    public static ACCESS_OPERATION_CODE? AccessOperationImpinjQtWrite
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_IMPINJ_QT_WRITE.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_KILL")]
    public static ACCESS_OPERATION_CODE? AccessOperationKill
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_KILL.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_LOCK")]
    public static ACCESS_OPERATION_CODE? AccessOperationLock
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_LOCK.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_NONE")]
    public static ACCESS_OPERATION_CODE? AccessOperationNone
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_NONE.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_NXP_CHANGE_CONFIG")]
    public static ACCESS_OPERATION_CODE? AccessOperationNxpChangeConfig
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_NXP_CHANGE_CONFIG.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_NXP_READ_PROTECT")]
    public static ACCESS_OPERATION_CODE? AccessOperationNxpReadProtect
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_NXP_READ_PROTECT.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_NXP_RESET_READ_PROTECT")]
    public static ACCESS_OPERATION_CODE? AccessOperationNxpResetReadProtect
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_NXP_RESET_READ_PROTECT.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_NXP_SET_EAS")]
    public static ACCESS_OPERATION_CODE? AccessOperationNxpSetEas
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_NXP_SET_EAS.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_READ")]
    public static ACCESS_OPERATION_CODE? AccessOperationRead
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_READ.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_RECOMMISSION")]
    public static ACCESS_OPERATION_CODE? AccessOperationRecommission
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_RECOMMISSION.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ACCESS_OPERATION_WRITE")]
    public static ACCESS_OPERATION_CODE? AccessOperationWrite
    {
      get
      {
        JniObjectReference objectValue = ACCESS_OPERATION_CODE._members.StaticFields.GetObjectValue("ACCESS_OPERATION_WRITE.Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;");
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
    }

    [Register("ordinal")]
    public int Ordinal
    {
      get
      {
        return ACCESS_OPERATION_CODE._members.InstanceFields.GetInt32Value("ordinal.I", (IJavaPeerable) this);
      }
      set
      {
        ACCESS_OPERATION_CODE._members.InstanceFields.SetValue("ordinal.I", (IJavaPeerable) this, value);
      }
    }

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ACCESS_OPERATION_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ACCESS_OPERATION_CODE._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ACCESS_OPERATION_CODE._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ACCESS_OPERATION_CODE._members.ManagedPeerType;

    protected ACCESS_OPERATION_CODE(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetValueHandler()
    {
      if ((object) ACCESS_OPERATION_CODE.cb_getValue == null)
        ACCESS_OPERATION_CODE.cb_getValue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(ACCESS_OPERATION_CODE.n_GetValue));
      return ACCESS_OPERATION_CODE.cb_getValue;
    }

    private static int n_GetValue(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<ACCESS_OPERATION_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Value;
    }

    public virtual unsafe int Value
    {
      [Register("getValue", "()I", "GetGetValueHandler")] get
      {
        return ACCESS_OPERATION_CODE._members.InstanceMethods.InvokeVirtualInt32Method("getValue.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    [Register("GetAccessOperationCodeValue", "(I)Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", "")]
    public static unsafe ACCESS_OPERATION_CODE? GetAccessOperationCodeValue(int value)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(value)
      };
      JniObjectReference jniObjectReference = ACCESS_OPERATION_CODE._members.StaticMethods.InvokeObjectMethod("GetAccessOperationCodeValue.(I)Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", jniArgumentValuePtr);
      return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    [Register("GetAccessOperationCodeValue", "(Ljava/lang/String;)Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", "")]
    public static unsafe ACCESS_OPERATION_CODE? GetAccessOperationCodeValue(string? opration)
    {
      IntPtr num = JNIEnv.NewString(opration);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        JniObjectReference jniObjectReference = ACCESS_OPERATION_CODE._members.StaticMethods.InvokeObjectMethod("GetAccessOperationCodeValue.(Ljava/lang/String;)Lcom/zebra/rfid/api3/ACCESS_OPERATION_CODE;", jniArgumentValuePtr);
        return Object.GetObject<ACCESS_OPERATION_CODE>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetEquals_IHandler()
    {
      if ((object) ACCESS_OPERATION_CODE.cb_equals_I == null)
        ACCESS_OPERATION_CODE.cb_equals_I = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPI_Z(ACCESS_OPERATION_CODE.n_Equals_I));
      return ACCESS_OPERATION_CODE.cb_equals_I;
    }

    private static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int val)
    {
      return Object.GetObject<ACCESS_OPERATION_CODE>(jnienv, native__this, (JniHandleOwnership) 0).Equals(val);
    }

    [Register("equals", "(I)Z", "GetEquals_IHandler")]
    public virtual unsafe bool Equals(int val)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(val)
      };
      return ACCESS_OPERATION_CODE._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(I)Z", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
