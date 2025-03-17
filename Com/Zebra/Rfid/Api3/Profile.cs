// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Rfid.Api3.Profile
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
  [Register("com/zebra/rfid/api3/Profile", DoNotGenerateAcw = true)]
  public class Profile : Object
  {
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/rfid/api3/Profile", typeof (Profile));
    private static Delegate? cb_getList;
    private static Delegate? cb_delete_Ljava_lang_String_;
    private static Delegate? cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z;
    private static Delegate? cb_importFromReader_Ljava_lang_String_Ljava_lang_String_;
    private static Delegate? cb_setActive_Ljava_lang_String_;

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = Profile._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => Profile._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = Profile._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => Profile._members.ManagedPeerType;

    protected Profile(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    private static Delegate GetGetListHandler()
    {
      if ((object) Profile.cb_getList == null)
        Profile.cb_getList = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PP_L(Profile.n_GetList));
      return Profile.cb_getList;
    }

    private static IntPtr n_GetList(IntPtr jnienv, IntPtr native__this)
    {
      return JNIEnv.ToLocalJniHandle((IJavaObject) Object.GetObject<Profile>(jnienv, native__this, (JniHandleOwnership) 0).List);
    }

    public virtual unsafe ProfileInfo? List
    {
      [Register("getList", "()Lcom/zebra/rfid/api3/ProfileInfo;", "GetGetListHandler")] get
      {
        JniObjectReference jniObjectReference = Profile._members.InstanceMethods.InvokeVirtualObjectMethod("getList.()Lcom/zebra/rfid/api3/ProfileInfo;", (IJavaPeerable) this, (JniArgumentValue*) null);
        return Object.GetObject<ProfileInfo>(((JniObjectReference) ref jniObjectReference).Handle, (JniHandleOwnership) 1);
      }
    }

    private static Delegate GetDelete_Ljava_lang_String_Handler()
    {
      if ((object) Profile.cb_delete_Ljava_lang_String_ == null)
        Profile.cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Profile.n_Delete_Ljava_lang_String_));
      return Profile.cb_delete_Ljava_lang_String_;
    }

    private static void n_Delete_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName)
    {
      Object.GetObject<Profile>(jnienv, native__this, (JniHandleOwnership) 0).Delete(JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0));
    }

    [Register("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler")]
    public virtual unsafe void Delete(string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Profile._members.InstanceMethods.InvokeVirtualVoidMethod("delete.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }

    private static Delegate GetExportToReader_Ljava_lang_String_Ljava_lang_String_ZHandler()
    {
      if ((object) Profile.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z == null)
        Profile.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLLZ_V(Profile.n_ExportToReader_Ljava_lang_String_Ljava_lang_String_Z));
      return Profile.cb_exportToReader_Ljava_lang_String_Ljava_lang_String_Z;
    }

    private static void n_ExportToReader_Ljava_lang_String_Ljava_lang_String_Z(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName,
      IntPtr native_profilePath,
      bool activation)
    {
      Profile profile = Object.GetObject<Profile>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_profilePath, (JniHandleOwnership) 0);
      string profileName = str1;
      string profilePath = str2;
      int num = activation ? 1 : 0;
      profile.ExportToReader(profileName, profilePath, num != 0);
    }

    [Register("exportToReader", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetExportToReader_Ljava_lang_String_Ljava_lang_String_ZHandler")]
    public virtual unsafe void ExportToReader(
      string? profileName,
      string? profilePath,
      bool activation)
    {
      IntPtr num1 = JNIEnv.NewString(profileName);
      IntPtr num2 = JNIEnv.NewString(profilePath);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[3]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2),
          new JniArgumentValue(activation)
        };
        Profile._members.InstanceMethods.InvokeVirtualVoidMethod("exportToReader.(Ljava/lang/String;Ljava/lang/String;Z)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetImportFromReader_Ljava_lang_String_Ljava_lang_String_Handler()
    {
      if ((object) Profile.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_ == null)
        Profile.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPLL_V(Profile.n_ImportFromReader_Ljava_lang_String_Ljava_lang_String_));
      return Profile.cb_importFromReader_Ljava_lang_String_Ljava_lang_String_;
    }

    private static void n_ImportFromReader_Ljava_lang_String_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName,
      IntPtr native_profilePath)
    {
      Profile profile = Object.GetObject<Profile>(jnienv, native__this, (JniHandleOwnership) 0);
      string str1 = JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0);
      string str2 = JNIEnv.GetString(native_profilePath, (JniHandleOwnership) 0);
      string profileName = str1;
      string profilePath = str2;
      profile.ImportFromReader(profileName, profilePath);
    }

    [Register("importFromReader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetImportFromReader_Ljava_lang_String_Ljava_lang_String_Handler")]
    public virtual unsafe void ImportFromReader(string? profileName, string? profilePath)
    {
      IntPtr num1 = JNIEnv.NewString(profileName);
      IntPtr num2 = JNIEnv.NewString(profilePath);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[2]
        {
          new JniArgumentValue(num1),
          new JniArgumentValue(num2)
        };
        Profile._members.InstanceMethods.InvokeVirtualVoidMethod("importFromReader.(Ljava/lang/String;Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num1);
        JNIEnv.DeleteLocalRef(num2);
      }
    }

    private static Delegate GetSetActive_Ljava_lang_String_Handler()
    {
      if ((object) Profile.cb_setActive_Ljava_lang_String_ == null)
        Profile.cb_setActive_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Delegate) new _JniMarshal_PPL_V(Profile.n_SetActive_Ljava_lang_String_));
      return Profile.cb_setActive_Ljava_lang_String_;
    }

    private static void n_SetActive_Ljava_lang_String_(
      IntPtr jnienv,
      IntPtr native__this,
      IntPtr native_profileName)
    {
      Object.GetObject<Profile>(jnienv, native__this, (JniHandleOwnership) 0).SetActive(JNIEnv.GetString(native_profileName, (JniHandleOwnership) 0));
    }

    [Register("setActive", "(Ljava/lang/String;)V", "GetSetActive_Ljava_lang_String_Handler")]
    public virtual unsafe void SetActive(string? profileName)
    {
      IntPtr num = JNIEnv.NewString(profileName);
      try
      {
        JniArgumentValue* jniArgumentValuePtr = stackalloc JniArgumentValue[1]
        {
          new JniArgumentValue(num)
        };
        Profile._members.InstanceMethods.InvokeVirtualVoidMethod("setActive.(Ljava/lang/String;)V", (IJavaPeerable) this, jniArgumentValuePtr);
      }
      finally
      {
        JNIEnv.DeleteLocalRef(num);
      }
    }
  }
}
