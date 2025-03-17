// Decompiled with JetBrains decompiler
// Type: Com.Zebra.ASCII_SDK.IMsg
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using Android.Runtime;
using Java.Interop;
using System;

#nullable enable
namespace Com.Zebra.ASCII_SDK
{
  [Register("com/zebra/ASCII_SDK/IMsg", "", "Com.Zebra.ASCII_SDK.IMsgInvoker")]
  public interface IMsg : IJavaObject, IDisposable, IJavaPeerable
  {
    MSG_TYPE? MsgType { [Register("getMsgType", "()Lcom/zebra/ASCII_SDK/MSG_TYPE;", "GetGetMsgTypeHandler:Com.Zebra.ASCII_SDK.IMsgInvoker, MauiJavaSdkBinding")] get; }
  }
}
