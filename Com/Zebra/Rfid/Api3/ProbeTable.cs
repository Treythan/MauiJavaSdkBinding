// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.ProbeTable
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
  [Register("com/zebra/rfid/api3/ProbeTable", DoNotGenerateAcw = true)]
  public class ProbeTable : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/ProbeTable", typeof (ProbeTable));
    private static Delegate? cb_addProduct_IILjava_lang_Class_;
    private static Delegate? cb_findDriver_II;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = ProbeTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => ProbeTable._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = ProbeTable._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => ProbeTable._members.ManagedPeerType;

    protected ProbeTable(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe ProbeTable()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = ProbeTable._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      ProbeTable._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetAddProduct_IILjava_lang_Class_Handler()
    {
      if ((object) ProbeTable.cb_addProduct_IILjava_lang_Class_ == null)
        ProbeTable.cb_addProduct_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPIIL_L(ProbeTable.n_AddProduct_IILjava_lang_Class_));
      return ProbeTable.cb_addProduct_IILjava_lang_Class_;
    }

    private static IntPtr n_AddProduct_IILjava_lang_Class_(
      IntPtr jnienv,
      IntPtr native__this,
      int vendorId,
      int productId,
      IntPtr native_driverClass)
    {
      ProbeTable probeTable = Object.GetObject<ProbeTable>(jnienv, native__this, (JniHandleOwnership) 0);
      Class @class = Object.GetObject<Class>(native_driverClass, (JniHandleOwnership) 0);
      int vendorId1 = vendorId;
      int productId1 = productId;
      Class driverClass = @class;
      return JNIEnv.ToLocalJniHandle((IJavaObject) probeTable.AddProduct(vendorId1, productId1, driverClass));
    }

    [Register("addProduct", "(IILjava/lang/Class;)Lcom/zebra/rfid/api3/ProbeTable;", "GetAddProduct_IILjava_lang_Class_Handler")]
    public virtual unsafe ProbeTable? AddProduct(int vendorId, int productId, Class? driverClass)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(vendorId),
          new JniArgumentValue(productId),
          new JniArgumentValue(driverClass == null ? IntPtr.Zero : ((Object) driverClass).Handle)
        };
        JniObjectReference jniObjectReference = ProbeTable._members.InstanceMethods.InvokeVirtualObjectMethod("addProduct.(IILjava/lang/Class;)Lcom/zebra/rfid/api3/ProbeTable;", (IJavaPeerable) this, jniArgumentValuePtr);
        return Object.GetObject<ProbeTable>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
      finally
      {
        GC.KeepAlive((object) driverClass);
      }
    }

    private static Delegate GetFindDriver_IIHandler()
    {
      if ((object) ProbeTable.cb_findDriver_II == null)
        ProbeTable.cb_findDriver_II = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPII_L(ProbeTable.n_FindDriver_II));
      return ProbeTable.cb_findDriver_II;
    }

    private static IntPtr n_FindDriver_II(
      IntPtr jnienv,
      IntPtr native__this,
      int vendorId,
      int productId)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<ProbeTable>(jnienv, native__this, (JniHandleOwnership) 0).FindDriver(vendorId, productId));
    }

    [Register("findDriver", "(II)Ljava/lang/Class;", "GetFindDriver_IIHandler")]
    public virtual unsafe Class? FindDriver(int vendorId, int productId)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
      {
        new JniArgumentValue(vendorId),
        new JniArgumentValue(productId)
      };
      JniObjectReference jniObjectReference = ProbeTable._members.InstanceMethods.InvokeVirtualObjectMethod("findDriver.(II)Ljava/lang/Class;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Class>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
