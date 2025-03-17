// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Commoniolib.ICmniolistner
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using Java.Lang;
using System;

#nullable enable
namespace Com.Zebra.Commoniolib
{
  [Register("com/zebra/commoniolib/cmniolistner", "", "Com.Zebra.Commoniolib.ICmniolistnerInvoker")]
  public interface ICmniolistner : IJavaObject, IDisposable, IJavaPeerable
  {
    [Register("onNewData", "([B)V", "GetOnNewData_arrayBHandler:Com.Zebra.Commoniolib.ICmniolistnerInvoker, MauiJavaSdkBinding")]
    void OnNewData(byte[]? p0);

    [Register("onRunError", "(Ljava/lang/Exception;)V", "GetOnRunError_Ljava_lang_Exception_Handler:Com.Zebra.Commoniolib.ICmniolistnerInvoker, MauiJavaSdkBinding")]
    void OnRunError(Exception? p0);
  }
}
