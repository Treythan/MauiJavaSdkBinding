// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.IAPI3ProtocolWrapper
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.Rfid.Api3
{
  [Register("com/zebra/rfid/api3/IAPI3ProtocolWrapper", "", "Com.Zebra.Rfid.Api3.IAPI3ProtocolWrapperInvoker")]
  public interface IAPI3ProtocolWrapper : IJavaObject, IDisposable, IJavaPeerable
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/IAPI3ProtocolWrapper", typeof (IAPI3ProtocolWrapper), true);

    [Register("NotificationsFromTransport", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
    static unsafe void NotificationsFromTransport(string? action, string? data)
    {
      IntPtr num1 = JNIEnv.NewString(action);
      IntPtr num2 = JNIEnv.NewString(data);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        IAPI3ProtocolWrapper._members.StaticMethods.InvokeVoidMethod("NotificationsFromTransport.(Ljava/lang/String;Ljava/lang/String;)V", jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }
  }
}
