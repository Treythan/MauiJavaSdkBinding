// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.TagDataArray
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
  [Register("com/zebra/rfid/api3/TagDataArray", DoNotGenerateAcw = true)]
  public class TagDataArray : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/TagDataArray", typeof (TagDataArray));
    private static Delegate? cb_getLength;
    private static Delegate? cb_getTags;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = TagDataArray._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => TagDataArray._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = TagDataArray._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => TagDataArray._members.ManagedPeerType;

    protected TagDataArray(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe TagDataArray()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = TagDataArray._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      TagDataArray._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetGetLengthHandler()
    {
      if ((object) TagDataArray.cb_getLength == null)
        TagDataArray.cb_getLength = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_I(TagDataArray.n_GetLength));
      return TagDataArray.cb_getLength;
    }

    private static int n_GetLength(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<TagDataArray>(jnienv, native__this, (JniHandleOwnership) 0).Length;
    }

    public virtual unsafe int Length
    {
      [Register("getLength", "()I", "GetGetLengthHandler")] get
      {
        return TagDataArray._members.InstanceMethods.InvokeVirtualInt32Method("getLength.()I", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetGetTagsHandler()
    {
      if ((object) TagDataArray.cb_getTags == null)
        TagDataArray.cb_getTags = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(TagDataArray.n_GetTags));
      return TagDataArray.cb_getTags;
    }

    private static IntPtr n_GetTags(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.NewArray<TagData>(Object.GetObject<TagDataArray>(jnienv, native__this, (JniHandleOwnership) 0).GetTags());
    }

    [Register("getTags", "()[Lcom/zebra/rfid/api3/TagData;", "GetGetTagsHandler")]
    public virtual unsafe TagData[]? GetTags()
    {
      JniObjectReference jniObjectReference = TagDataArray._members.InstanceMethods.InvokeVirtualObjectMethod("getTags.()[Lcom/zebra/rfid/api3/TagData;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return (TagData[]) JNIEnv.GetArray(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1, typeof (TagData));
    }
  }
}
