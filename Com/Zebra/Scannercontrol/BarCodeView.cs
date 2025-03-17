// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.BarCodeView
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/BarCodeView", DoNotGenerateAcw = true)]
  public class BarCodeView : View
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/BarCodeView", typeof (BarCodeView));
    private static Delegate? cb_getXSize;
    private static Delegate? cb_getYSize;
    private static Delegate? cb_setSize_II;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = BarCodeView._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => BarCodeView._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = BarCodeView._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => BarCodeView._members.ManagedPeerType;

    protected BarCodeView(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetXSizeHandler()
    {
      if ((object) BarCodeView.cb_getXSize == null)
        BarCodeView.cb_getXSize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BarCodeView.n_GetXSize));
      return BarCodeView.cb_getXSize;
    }

    private static int n_GetXSize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BarCodeView>(jnienv, native__this, (JniHandleOwnership) 0).XSize;
    }

    public virtual unsafe int XSize
    {
      [Register("getXSize", "()I", "GetGetXSizeHandler")] get
      {
        return BarCodeView._members.InstanceMethods.InvokeVirtualInt32Method("getXSize.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetYSizeHandler()
    {
      if ((object) BarCodeView.cb_getYSize == null)
        BarCodeView.cb_getYSize = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(BarCodeView.n_GetYSize));
      return BarCodeView.cb_getYSize;
    }

    private static int n_GetYSize(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<BarCodeView>(jnienv, native__this, (JniHandleOwnership) 0).YSize;
    }

    public virtual unsafe int YSize
    {
      [Register("getYSize", "()I", "GetGetYSizeHandler")] get
      {
        return BarCodeView._members.InstanceMethods.InvokeVirtualInt32Method("getYSize.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetSetSize_IIHandler()
    {
      if ((object) BarCodeView.cb_setSize_II == null)
        BarCodeView.cb_setSize_II = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPII_V(BarCodeView.n_SetSize_II));
      return BarCodeView.cb_setSize_II;
    }

    private static void n_SetSize_II(IntPtr jnienv, IntPtr native__this, int x, int y)
    {
      Object.GetObject<BarCodeView>(jnienv, native__this, (JniHandleOwnership) 0).SetSize(x, y);
    }

    [Register("setSize", "(II)V", "GetSetSize_IIHandler")]
    public virtual unsafe void SetSize(int x, int y)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
      {
        new JniArgumentValue(x),
        new JniArgumentValue(y)
      };
      BarCodeView._members.InstanceMethods.InvokeVirtualVoidMethod("setSize.(II)V", (IJavaPeerable) this, jniArgumentValuePtr);
    }
  }
}
