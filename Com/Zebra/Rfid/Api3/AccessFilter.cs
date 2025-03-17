// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.AccessFilter
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
  [Register("com/zebra/rfid/api3/AccessFilter", DoNotGenerateAcw = true)]
  public class AccessFilter : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/AccessFilter", typeof (AccessFilter));
    private static Delegate? cb_getAccessFilterMatchPattern;
    private static Delegate? cb_setAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_;
    private static Delegate? cb_isRSSIRangeFilterUsed;
    private static Delegate? cb_setRSSIRangeFilter_Z;

    [Register("TagPatternA")]
    public TagPatternBase? TagPatternA
    {
      get
      {
        JniObjectReference objectValue = AccessFilter._members.InstanceFields.GetObjectValue("TagPatternA.Lcom/zebra/rfid/api3/TagPatternBase;", (IJavaPeerable) this);
        return Object.GetObject<TagPatternBase>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          AccessFilter._members.InstanceFields.SetValue("TagPatternA.Lcom/zebra/rfid/api3/TagPatternBase;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
        }
        finally
        {
          JNIEnv.DeleteLocalRef(localJniHandle);
        }
      }
    }

    [Register("TagPatternB")]
    public TagPatternBase? TagPatternB
    {
      get
      {
        JniObjectReference objectValue = AccessFilter._members.InstanceFields.GetObjectValue("TagPatternB.Lcom/zebra/rfid/api3/TagPatternBase;", (IJavaPeerable) this);
        return Object.GetObject<TagPatternBase>(((JniObjectReference) ref objectValue).Handle, (JniHandleOwnership) 1);
      }
      set
      {
        IntPtr localJniHandle = JNIEnv.ToLocalJniHandle((IJavaObject) value);
        try
        {
          AccessFilter._members.InstanceFields.SetValue("TagPatternB.Lcom/zebra/rfid/api3/TagPatternBase;", (IJavaPeerable) this, new JniObjectReference(localJniHandle, (JniObjectReferenceType) 0));
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
        JniObjectReference peerReference = AccessFilter._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => AccessFilter._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = AccessFilter._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => AccessFilter._members.ManagedPeerType;

    protected AccessFilter(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe AccessFilter()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = AccessFilter._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      AccessFilter._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetAccessFilterMatchPatternHandler()
    {
      if ((object) AccessFilter.cb_getAccessFilterMatchPattern == null)
        AccessFilter.cb_getAccessFilterMatchPattern = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(AccessFilter.n_GetAccessFilterMatchPattern));
      return AccessFilter.cb_getAccessFilterMatchPattern;
    }

    private static IntPtr n_GetAccessFilterMatchPattern(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<AccessFilter>(jnienv, native__this, (JniHandleOwnership) 0).AccessFilterMatchPattern);
    }

    private static Delegate GetSetAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_Handler()
    {
      if ((object) AccessFilter.cb_setAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_ == null)
        AccessFilter.cb_setAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(AccessFilter.n_SetAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_));
      return AccessFilter.cb_setAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_;
    }

    private static void n_SetAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_accessFilterMatchPattern)
    {
      Object.GetObject<AccessFilter>(jnienv, native__this, (JniHandleOwnership) 0).AccessFilterMatchPattern = Object.GetObject<FILTER_MATCH_PATTERN>(native_accessFilterMatchPattern, (JniHandleOwnership) 0);
    }

    public virtual unsafe FILTER_MATCH_PATTERN? AccessFilterMatchPattern
    {
      [Register("getAccessFilterMatchPattern", "()Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;", "GetGetAccessFilterMatchPatternHandler")] get
      {
        JniObjectReference jniObjectReference = AccessFilter._members.InstanceMethods.InvokeVirtualObjectMethod("getAccessFilterMatchPattern.()Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<FILTER_MATCH_PATTERN>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      [Register("setAccessFilterMatchPattern", "(Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;)V", "GetSetAccessFilterMatchPattern_Lcom_zebra_rfid_api3_FILTER_MATCH_PATTERN_Handler")] set
      {
        try
        {
          JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
          {
            new JniArgumentValue(value == null ? IntPtr.Zero : value.Handle)
          };
          AccessFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessFilterMatchPattern.(Lcom/zebra/rfid/api3/FILTER_MATCH_PATTERN;)V", (IJavaPeerable) this, jniArgumentValuePtr);
        }
        finally
        {
          GC.KeepAlive((object) value);
        }
      }
    }

    private static Delegate GetIsRSSIRangeFilterUsedHandler()
    {
      if ((object) AccessFilter.cb_isRSSIRangeFilterUsed == null)
        AccessFilter.cb_isRSSIRangeFilterUsed = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(AccessFilter.n_IsRSSIRangeFilterUsed));
      return AccessFilter.cb_isRSSIRangeFilterUsed;
    }

    private static bool n_IsRSSIRangeFilterUsed(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<AccessFilter>(jnienv, native__this, (JniHandleOwnership) 0).IsRSSIRangeFilterUsed;
    }

    public virtual unsafe bool IsRSSIRangeFilterUsed
    {
      [Register("isRSSIRangeFilterUsed", "()Z", "GetIsRSSIRangeFilterUsedHandler")] get
      {
        return AccessFilter._members.InstanceMethods.InvokeVirtualBooleanMethod("isRSSIRangeFilterUsed.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetSetRSSIRangeFilter_ZHandler()
    {
      if ((object) AccessFilter.cb_setRSSIRangeFilter_Z == null)
        AccessFilter.cb_setRSSIRangeFilter_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPZ_V(AccessFilter.n_SetRSSIRangeFilter_Z));
      return AccessFilter.cb_setRSSIRangeFilter_Z;
    }

    private static void n_SetRSSIRangeFilter_Z(
      IntPtr jnienv,
      IntPtr native__this,
      bool useRSSIRangeFilter)
    {
      Object.GetObject<AccessFilter>(jnienv, native__this, (JniHandleOwnership) 0).SetRSSIRangeFilter(useRSSIRangeFilter);
    }

    [Register("setRSSIRangeFilter", "(Z)V", "GetSetRSSIRangeFilter_ZHandler")]
    public virtual unsafe void SetRSSIRangeFilter(bool useRSSIRangeFilter)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(useRSSIRangeFilter)
      };
      AccessFilter._members.InstanceMethods.InvokeVirtualVoidMethod("setRSSIRangeFilter.(Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
