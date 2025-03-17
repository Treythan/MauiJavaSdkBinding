// Decompiled with JetBrains decompiler
// Type: Java.Interop.__TypeRegistrations
// Assembly: MauiJavaSdkBinding, Version=2.0.3.148, Culture=neutral, PublicKeyToken=null
// MVID: F052DB81-5090-4B7E-8DCC-B77A37936DC5
// Assembly location: C:\Users\treythan.noblett\OneDrive - RevGroup Inc\ComputerData\Downloads\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\Zebra_RFIDAPI3_Android_MAUI_SDK_2.0.3.148\SDK_DLL\MauiJavaSdkBinding.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Java.Interop
{
  internal class __TypeRegistrations
  {
    private static string[]? package_com_zebra_commoniolib_mappings;
    private static string[]? package_com_zebra_rfid_api3_mappings;

    public static void RegisterPackages()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      TypeManager.RegisterPackages(new string[2]
      {
        "com/zebra/commoniolib",
        "com/zebra/rfid/api3"
      }, new Converter<string, Type>[2]
      {
        __TypeRegistrations.\u003C\u003EO.\u003C0\u003E__lookup_com_zebra_commoniolib_package ?? (__TypeRegistrations.\u003C\u003EO.\u003C0\u003E__lookup_com_zebra_commoniolib_package = new Converter<string, Type>(__TypeRegistrations.lookup_com_zebra_commoniolib_package)),
        __TypeRegistrations.\u003C\u003EO.\u003C1\u003E__lookup_com_zebra_rfid_api3_package ?? (__TypeRegistrations.\u003C\u003EO.\u003C1\u003E__lookup_com_zebra_rfid_api3_package = new Converter<string, Type>(__TypeRegistrations.lookup_com_zebra_rfid_api3_package))
      });
    }

    [UnconditionalSuppressMessage("Trimming", "IL2057")]
    private static Type? Lookup(string[] mappings, string javaType)
    {
      string typeName = TypeManager.LookupTypeMapping(mappings, javaType);
      return typeName == null ? (Type) null : Type.GetType(typeName);
    }

    private static Type? lookup_com_zebra_commoniolib_package(string klass)
    {
      if (__TypeRegistrations.package_com_zebra_commoniolib_mappings == null)
        __TypeRegistrations.package_com_zebra_commoniolib_mappings = new string[1]
        {
          "com/zebra/commoniolib/UsbSerialPort$ControlLine:Com.Zebra.Commoniolib.IUsbSerialPort/ControlLine"
        };
      return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_zebra_commoniolib_mappings, klass);
    }

    private static Type? lookup_com_zebra_rfid_api3_package(string klass)
    {
      if (__TypeRegistrations.package_com_zebra_rfid_api3_mappings == null)
        __TypeRegistrations.package_com_zebra_rfid_api3_mappings = new string[1]
        {
          "com/zebra/rfid/api3/UsbSerialPort$ControlLine:Com.Zebra.Rfid.Api3.IUsbSerialPort/ControlLine"
        };
      return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_zebra_rfid_api3_mappings, klass);
    }
  }
}
