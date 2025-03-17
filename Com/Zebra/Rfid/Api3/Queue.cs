// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Queue
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/Queue", DoNotGenerateAcw = true)]
  public class Queue : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Queue", typeof (Queue));
    private static Delegate? cb_isEmpty;
    private static Delegate? cb_dequeue;
    private static Delegate? cb_dequeue_J;
    private static Delegate? cb_dump_Ljava_lang_String_;
    private static Delegate? cb_enqueue_Ljava_lang_Object_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Queue._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Queue._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Queue._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Queue._members.ManagedPeerType;

    protected Queue(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe Queue()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = Queue._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      Queue._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }

    private static Delegate GetIsEmptyHandler()
    {
      if ((object) Queue.cb_isEmpty == null)
        Queue.cb_isEmpty = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_Z(Queue.n_IsEmpty));
      return Queue.cb_isEmpty;
    }

    private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
    {
      return Object.GetObject<Queue>(jnienv, native__this, (JniHandleOwnership) 0).IsEmpty;
    }

    public virtual unsafe bool IsEmpty
    {
      [Register("isEmpty", "()Z", "GetIsEmptyHandler")] get
      {
        return Queue._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", (IJavaPeerable) this, (JniArgumentValue*) null);
      }
    }

    private static Delegate GetDequeueHandler()
    {
      if ((object) Queue.cb_dequeue == null)
        Queue.cb_dequeue = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Queue.n_Dequeue));
      return Queue.cb_dequeue;
    }

    private static IntPtr n_Dequeue(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Queue>(jnienv, native__this, (JniHandleOwnership) 0).Dequeue());
    }

    [Register("dequeue", "()Ljava/lang/Object;", "GetDequeueHandler")]
    public virtual unsafe Object? Dequeue()
    {
      JniObjectReference jniObjectReference = Queue._members.InstanceMethods.InvokeVirtualObjectMethod("dequeue.()Ljava/lang/Object;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDequeue_JHandler()
    {
      if ((object) Queue.cb_dequeue_J == null)
        Queue.cb_dequeue_J = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPJ_L(Queue.n_Dequeue_J));
      return Queue.cb_dequeue_J;
    }

    private static IntPtr n_Dequeue_J(IntPtr jnienv, IntPtr native__this, long timeOut)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Queue>(jnienv, native__this, (JniHandleOwnership) 0).Dequeue(timeOut));
    }

    [Register("dequeue", "(J)Ljava/lang/Object;", "GetDequeue_JHandler")]
    public virtual unsafe Object? Dequeue(long timeOut)
    {
      JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
      {
        new JniArgumentValue(timeOut)
      };
      JniObjectReference jniObjectReference = Queue._members.InstanceMethods.InvokeVirtualObjectMethod("dequeue.(J)Ljava/lang/Object;", (IJavaPeerable) this, jniArgumentValuePtr);
      return Object.GetObject<Object>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetDump_Ljava_lang_String_Handler()
    {
      if ((object) Queue.cb_dump_Ljava_lang_String_ == null)
        Queue.cb_dump_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Queue.n_Dump_Ljava_lang_String_));
      return Queue.cb_dump_Ljava_lang_String_;
    }

    private static void n_Dump_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_msg)
    {
      Object.GetObject<Queue>(jnienv, native__this, (JniHandleOwnership) 0).Dump(JNIEnv.GetString(native_msg, (JniHandleOwnership) 0));
    }

    [Register("dump", "(Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Handler")]
    public virtual unsafe void Dump(string? msg)
    {
      IntPtr num = JNIEnv.NewString(msg);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Queue._members.InstanceMethods.InvokeVirtualVoidMethod("dump.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    [Register("elements", "()Ljava/util/Enumeration;", "")]
    public unsafe IEnumeration? Elements()
    {
      JniObjectReference jniObjectReference = Queue._members.InstanceMethods.InvokeNonvirtualObjectMethod("elements.()Ljava/util/Enumeration;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<IEnumeration>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }

    private static Delegate GetEnqueue_Ljava_lang_Object_Handler()
    {
      if ((object) Queue.cb_enqueue_Ljava_lang_Object_ == null)
        Queue.cb_enqueue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Queue.n_Enqueue_Ljava_lang_Object_));
      return Queue.cb_enqueue_Ljava_lang_Object_;
    }

    private static void n_Enqueue_Ljava_lang_Object_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_obj)
    {
      Object.GetObject<Queue>(jnienv, native__this, (JniHandleOwnership) 0).Enqueue(Object.GetObject<Object>(native_obj, (JniHandleOwnership) 0));
    }

    [Register("enqueue", "(Ljava/lang/Object;)V", "GetEnqueue_Ljava_lang_Object_Handler")]
    public virtual unsafe void Enqueue(Object? obj)
    {
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(obj == null ? IntPtr.Zero : obj.Handle)
        };
        Queue._members.InstanceMethods.InvokeVirtualVoidMethod("enqueue.(Ljava/lang/Object;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        GC.KeepAlive((object) obj);
      }
    }

    [Register("reverseElements", "()Ljava/util/Enumeration;", "")]
    public unsafe IEnumeration? ReverseElements()
    {
      JniObjectReference jniObjectReference = Queue._members.InstanceMethods.InvokeNonvirtualObjectMethod("reverseElements.()Ljava/util/Enumeration;", (IJavaPeerable) this, (JniArgumentValue*) null);
      return Object.GetObject<IEnumeration>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
    }
  }
}
