// Decompiled with JetBrains decompiler
// Type: Com.Zebra.Scannercontrol.RMDAttributes
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
namespace Com.Zebra.Scannercontrol
{
  [Register("com/zebra/scannercontrol/RMDAttributes", DoNotGenerateAcw = true)]
  public class RMDAttributes : Object
  {
    [Register("ACTION_COMMAND_VIRTUAL_TETHER_START_SIMULATION")]
    public const int ActionCommandVirtualTetherStartSimulation = 232;
    [Register("ACTION_COMMAND_VIRTUAL_TETHER_STOP_SIMULATION")]
    public const int ActionCommandVirtualTetherStopSimulation = 233;
    [Register("NUM_STATUS_DECODE_2OF5_CNT_HEX_LI")]
    public const string NumStatusDecode2of5CntHexLi = "0x59 0x3c";
    [Register("NUM_STATUS_DECODE_AZTEC_CNT_HEX_LI")]
    public const string NumStatusDecodeAztecCntHexLi = "0xad 0x3c";
    [Register("NUM_STATUS_DECODE_C11_CNT_HEX_LI")]
    public const string NumStatusDecodeC11CntHexLi = "0x75 0x3c";
    [Register("NUM_STATUS_DECODE_C128_CNT_HEX_LI")]
    public const string NumStatusDecodeC128CntHexLi = "0x52 0x3c";
    [Register("NUM_STATUS_DECODE_C39_CNT_HEX_LI")]
    public const string NumStatusDecodeC39CntHexLi = "0x4b 0x3c";
    [Register("NUM_STATUS_DECODE_C93_CNT_HEX_LI")]
    public const string NumStatusDecodeC93CntHexLi = "0x67 0x3c";
    [Register("NUM_STATUS_DECODE_CODABAR_CNT_HEX_LI")]
    public const string NumStatusDecodeCodabarCntHexLi = "0x60 0x3c";
    [Register("NUM_STATUS_DECODE_COMPOSITE_CNT_HEX_LI")]
    public const string NumStatusDecodeCompositeCntHexLi = "0x9f 0x3c";
    [Register("NUM_STATUS_DECODE_COUPON_CNT_HEX_LI")]
    public const string NumStatusDecodeCouponCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_DATAMATRIX_CNT_HEX_LI")]
    public const string NumStatusDecodeDatamatrixCntHexLi = "0x83 0x3c";
    [Register("NUM_STATUS_DECODE_DIGIMARC_EAN_JAN_CNT_HEX_LI")]
    public const string NumStatusDecodeDigimarcEanJanCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_DIGIMARC_OTHER_CNT_HEX_LI")]
    public const string NumStatusDecodeDigimarcOtherCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_DIGIMARC_UPC_CNT_HEX_LI")]
    public const string NumStatusDecodeDigimarcUpcCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_EAN_JAN_CNT_HEX_LI")]
    public const string NumStatusDecodeEanJanCntHexLi = "0x44 0x3c";
    [Register("NUM_STATUS_DECODE_GS1DATABAR_CNT_HEX_LI")]
    public const string NumStatusDecodeGs1databarCntHexLi = "0x98 0x3c";
    [Register("NUM_STATUS_DECODE_GS1DATAMATRIX_CNT_HEX_LI")]
    public const string NumStatusDecodeGs1datamatrixCntHexLi = "0x39 0x3d";
    [Register("NUM_STATUS_DECODE_GS1QR_CNT_HEX_LI")]
    public const string NumStatusDecodeGs1qrCntHexLi = "0x40 0x3d";
    [Register("NUM_STATUS_DECODE_MAXICODE_CNT_HEX_LI")]
    public const string NumStatusDecodeMaxicodeCntHexLi = "0x2b 0x3d";
    [Register("NUM_STATUS_DECODE_MSI_CNT_HEX_LI")]
    public const string NumStatusDecodeMsiCntHexLi = "0x6e 0x3c";
    [Register("NUM_STATUS_DECODE_OCR_CNT_HEX_LI")]
    public const string NumStatusDecodeOcrCntHexLi = "0xa6 0x3c";
    [Register("NUM_STATUS_DECODE_OTHER_1D_CNT_HEX_LI")]
    public const string NumStatusDecodeOther1dCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_OTHER_2D_CNT_HEX_LI")]
    public const string NumStatusDecodeOther2dCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_OTHER_CNT_HEX_LI")]
    public const string NumStatusDecodeOtherCntHexLi = "0x32 0x3d";
    [Register("NUM_STATUS_DECODE_PDF_CNT_HEX_LI")]
    public const string NumStatusDecodePdfCntHexLi = "0x7c 0x3c";
    [Register("NUM_STATUS_DECODE_POSTAL_CNT_HEX_LI")]
    public const string NumStatusDecodePostalCntHexLi = "0x91 0x3c";
    [Register("NUM_STATUS_DECODE_RQ_CNT_HEX_LI")]
    public const string NumStatusDecodeRqCntHexLi = "0x8a 0x3c";
    [Register("NUM_STATUS_DECODE_UPC_CNT_HEX_LI")]
    public const string NumStatusDecodeUpcCntHexLi = "0x3d 0x3c";
    [Register("NUM_STATUS_UNUSED_HEX_LI")]
    public const string NumStatusUnusedHexLi = "0x1f 0x4e";
    [Register("RMD_ATTR_ACTION_BEEPER_LED")]
    public const int RmdAttrActionBeeperLed = 6000;
    [Register("RMD_ATTR_BAT_CHARGE_CYCLES_CONSUMED")]
    public const int RmdAttrBatChargeCyclesConsumed = 30021;
    [Register("RMD_ATTR_BAT_CHARGE_STATUS")]
    public const int RmdAttrBatChargeStatus = 30026;
    [Register("RMD_ATTR_BAT_CURRENT")]
    public const int RmdAttrBatCurrent = 30011;
    [Register("RMD_ATTR_BAT_DESIGN_CAPACITY")]
    public const int RmdAttrBatDesignCapacity = 30029;
    [Register("RMD_ATTR_BAT_FIRMWARE_VERSION")]
    public const int RmdAttrBatFirmwareVersion = 30019;
    [Register("RMD_ATTR_BAT_FULL_CHARGE_CAP")]
    public const int RmdAttrBatFullChargeCap = 30020;
    [Register("RMD_ATTR_BAT_MANUFACTURE_DATE")]
    public const int RmdAttrBatManufactureDate = 30018;
    [Register("RMD_ATTR_BAT_MODEL_NUMBER")]
    public const int RmdAttrBatModelNumber = 30017;
    [Register("RMD_ATTR_BAT_REMAINING_CAP")]
    public const int RmdAttrBatRemainingCap = 30027;
    [Register("RMD_ATTR_BAT_REMAINING_TIME_TO_COMPLETE_CHARGING")]
    public const int RmdAttrBatRemainingTimeToCompleteCharging = 30023;
    [Register("RMD_ATTR_BAT_SERIAL_NUMBER")]
    public const int RmdAttrBatSerialNumber = 30030;
    [Register("RMD_ATTR_BAT_STATE_OF_CHARGE")]
    public const int RmdAttrBatStateOfCharge = 30012;
    [Register("RMD_ATTR_BAT_STATE_OF_HEALTH_METER")]
    public const int RmdAttrBatStateOfHealthMeter = 30013;
    [Register("RMD_ATTR_BAT_TEMP_HIGHEST")]
    public const int RmdAttrBatTempHighest = 30024;
    [Register("RMD_ATTR_BAT_TEMP_LOWEST")]
    public const int RmdAttrBatTempLowest = 30025;
    [Register("RMD_ATTR_BAT_TEMP_PRESENT")]
    public const int RmdAttrBatTempPresent = 30016;
    [Register("RMD_ATTR_BAT_VOLTAGE")]
    public const int RmdAttrBatVoltage = 30010;
    [Register("RMD_ATTR_BEEPER_FREQUENCY")]
    public const int RmdAttrBeeperFrequency = 145;
    [Register("RMD_ATTR_BEEPER_VOLUME")]
    public const int RmdAttrBeeperVolume = 140;
    [Register("RMD_ATTR_CONFIG_NAME")]
    public const int RmdAttrConfigName = 616;
    [Register("RMD_ATTR_DOM")]
    public const int RmdAttrDom = 535;
    [Register("RMD_ATTR_FW_VERSION")]
    public const int RmdAttrFwVersion = 20012;
    [Register("RMD_ATTR_ID_NAME")]
    public const int RmdAttrIdName = 607;
    [Register("RMD_ATTR_ID_SERIAL_NUMBER")]
    public const int RmdAttrIdSerialNumber = 534;
    [Register("RMD_ATTR_MODEL_NUMBER")]
    public const int RmdAttrModelNumber = 533;
    [Register("RMD_ATTR_SERIAL_NUMBER")]
    public const int RmdAttrSerialNumber = 534;
    [Register("RMD_ATTR_SYM_AUSTRALIAN_POST")]
    public const int RmdAttrSymAustralianPost = 291;
    [Register("RMD_ATTR_SYM_AZTEC")]
    public const int RmdAttrSymAztec = 574;
    [Register("RMD_ATTR_SYM_BOOKLAND_EAN")]
    public const int RmdAttrSymBooklandEan = 83;
    [Register("RMD_ATTR_SYM_CHINESE_2_OF_5")]
    public const int RmdAttrSymChinese2Of5 = 408;
    [Register("RMD_ATTR_SYM_CODABAR")]
    public const int RmdAttrSymCodabar = 7;
    [Register("RMD_ATTR_SYM_CODE_11")]
    public const int RmdAttrSymCode11 = 10;
    [Register("RMD_ATTR_SYM_CODE_128")]
    public const int RmdAttrSymCode128 = 8;
    [Register("RMD_ATTR_SYM_CODE_32")]
    public const int RmdAttrSymCode32 = 86;
    [Register("RMD_ATTR_SYM_CODE_39")]
    public const int RmdAttrSymCode39 = 0;
    [Register("RMD_ATTR_SYM_CODE_93")]
    public const int RmdAttrSymCode93 = 9;
    [Register("RMD_ATTR_SYM_COMPOSITE_AB")]
    public const int RmdAttrSymCompositeAb = 342;
    [Register("RMD_ATTR_SYM_COMPOSITE_C")]
    public const int RmdAttrSymCompositeC = 341;
    [Register("RMD_ATTR_SYM_COMPOSITE_TLC39")]
    public const int RmdAttrSymCompositeTlc39 = 371;
    [Register("RMD_ATTR_SYM_DATAMATRIXQR")]
    public const int RmdAttrSymDatamatrixqr = 292;
    [Register("RMD_ATTR_SYM_DISCRETE_2_OF_5")]
    public const int RmdAttrSymDiscrete2Of5 = 5;
    [Register("RMD_ATTR_SYM_DOTCODE")]
    public const int RmdAttrSymDotcode = 1906;
    [Register("RMD_ATTR_SYM_EAN_13_JAN_13")]
    public const int RmdAttrSymEan13Jan13 = 3;
    [Register("RMD_ATTR_SYM_EAN_8_JAN_8")]
    public const int RmdAttrSymEan8Jan8 = 4;
    [Register("RMD_ATTR_SYM_FICS")]
    public const int RmdAttrSymFics = 611;
    [Register("RMD_ATTR_SYM_GS1_DATABAR_14")]
    public const int RmdAttrSymGs1Databar14 = 338;
    [Register("RMD_ATTR_SYM_GS1_DATABAR_EXPANDED")]
    public const int RmdAttrSymGs1DatabarExpanded = 340;
    [Register("RMD_ATTR_SYM_GS1_DATABAR_LIMITED")]
    public const int RmdAttrSymGs1DatabarLimited = 339;
    [Register("RMD_ATTR_SYM_HAN_XIN_CODE")]
    public const int RmdAttrSymHanXinCode = 1167;
    [Register("RMD_ATTR_SYM_INTERLEAVED_2_OF_5")]
    public const int RmdAttrSymInterleaved2Of5 = 6;
    [Register("RMD_ATTR_SYM_ISBN")]
    public const int RmdAttrSymIsbn = 576;
    [Register("RMD_ATTR_SYM_ISBT_128")]
    public const int RmdAttrSymIsbt128 = 84;
    [Register("RMD_ATTR_SYM_ISSN_EAN")]
    public const int RmdAttrSymIssnEan = 617;
    [Register("RMD_ATTR_SYM_JAPAN_POST")]
    public const int RmdAttrSymJapanPost = 290;
    [Register("RMD_ATTR_SYM_KIX_CODE")]
    public const int RmdAttrSymKixCode = 326;
    [Register("RMD_ATTR_SYM_KOREAN_3_OF_5")]
    public const int RmdAttrSymKorean3Of5 = 581;
    [Register("RMD_ATTR_SYM_MATRIX_2_OF_5")]
    public const int RmdAttrSymMatrix2Of5 = 618;
    [Register("RMD_ATTR_SYM_MAXICODE")]
    public const int RmdAttrSymMaxicode = 294;
    [Register("RMD_ATTR_SYM_MICROPDF417")]
    public const int RmdAttrSymMicropdf417 = 227;
    [Register("RMD_ATTR_SYM_MICRO_QR_CODE")]
    public const int RmdAttrSymMicroQrCode = 573;
    [Register("RMD_ATTR_SYM_MSI")]
    public const int RmdAttrSymMsi = 11;
    [Register("RMD_ATTR_SYM_PDF")]
    public const int RmdAttrSymPdf = 15;
    [Register("RMD_ATTR_SYM_QR_CODE")]
    public const int RmdAttrSymQrCode = 293;
    [Register("RMD_ATTR_SYM_TRIOPTIC_CODE_39")]
    public const int RmdAttrSymTriopticCode39 = 13;
    [Register("RMD_ATTR_SYM_UCC_COUPON_EXTENDED")]
    public const int RmdAttrSymUccCouponExtended = 85;
    [Register("RMD_ATTR_SYM_UCC_EAN_128")]
    public const int RmdAttrSymUccEan128 = 14;
    [Register("RMD_ATTR_SYM_UK_POSTAL")]
    public const int RmdAttrSymUkPostal = 91;
    [Register("RMD_ATTR_SYM_UPC_A")]
    public const int RmdAttrSymUpcA = 1;
    [Register("RMD_ATTR_SYM_UPC_E")]
    public const int RmdAttrSymUpcE = 2;
    [Register("RMD_ATTR_SYM_UPC_E_1")]
    public const int RmdAttrSymUpcE1 = 12;
    [Register("RMD_ATTR_SYM_USPS_4CB")]
    public const int RmdAttrSymUsps4cb = 592;
    [Register("RMD_ATTR_SYM_US_PLANET")]
    public const int RmdAttrSymUsPlanet = 90;
    [Register("RMD_ATTR_SYM_US_POSTNET")]
    public const int RmdAttrSymUsPostnet = 89;
    [Register("RMD_ATTR_VALUE_ACTION_FAST_WARBLE_BEEP")]
    public const int RmdAttrValueActionFastWarbleBeep = 20;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_HIGH_LOW_LOW_BEEP")]
    public const int RmdAttrValueActionHighHighLowLowBeep = 26;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LONG_BEEP_1")]
    public const int RmdAttrValueActionHighLongBeep1 = 10;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LONG_BEEP_2")]
    public const int RmdAttrValueActionHighLongBeep2 = 11;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LONG_BEEP_3")]
    public const int RmdAttrValueActionHighLongBeep3 = 12;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LONG_BEEP_4")]
    public const int RmdAttrValueActionHighLongBeep4 = 13;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LONG_BEEP_5")]
    public const int RmdAttrValueActionHighLongBeep5 = 14;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LOW_BEEP")]
    public const int RmdAttrValueActionHighLowBeep = 22;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_LOW_HIGH_BEEP")]
    public const int RmdAttrValueActionHighLowHighBeep = 24;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_SHORT_BEEP_1")]
    public const int RmdAttrValueActionHighShortBeep1 = 0;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_SHORT_BEEP_2")]
    public const int RmdAttrValueActionHighShortBeep2 = 1;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_SHORT_BEEP_3")]
    public const int RmdAttrValueActionHighShortBeep3 = 2;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_SHORT_BEEP_4")]
    public const int RmdAttrValueActionHighShortBeep4 = 3;
    [Register("RMD_ATTR_VALUE_ACTION_HIGH_SHORT_BEEP_5")]
    public const int RmdAttrValueActionHighShortBeep5 = 4;
    [Register("RMD_ATTR_VALUE_ACTION_LED_GREEN_OFF")]
    public const int RmdAttrValueActionLedGreenOff = 42;
    [Register("RMD_ATTR_VALUE_ACTION_LED_GREEN_ON")]
    public const int RmdAttrValueActionLedGreenOn = 43;
    [Register("RMD_ATTR_VALUE_ACTION_LED_OTHER_OFF")]
    public const int RmdAttrValueActionLedOtherOff = 46;
    [Register("RMD_ATTR_VALUE_ACTION_LED_OTHER_ON")]
    public const int RmdAttrValueActionLedOtherOn = 45;
    [Register("RMD_ATTR_VALUE_ACTION_LED_RED_OFF")]
    public const int RmdAttrValueActionLedRedOff = 48;
    [Register("RMD_ATTR_VALUE_ACTION_LED_RED_ON")]
    public const int RmdAttrValueActionLedRedOn = 47;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_HIGH_BEEP")]
    public const int RmdAttrValueActionLowHighBeep = 23;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_HIGH_LOW_BEEP")]
    public const int RmdAttrValueActionLowHighLowBeep = 25;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_LONG_BEEP_1")]
    public const int RmdAttrValueActionLowLongBeep1 = 15;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_LONG_BEEP_2")]
    public const int RmdAttrValueActionLowLongBeep2 = 16;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_LONG_BEEP_3")]
    public const int RmdAttrValueActionLowLongBeep3 = 17;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_LONG_BEEP_4")]
    public const int RmdAttrValueActionLowLongBeep4 = 18;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_LONG_BEEP_5")]
    public const int RmdAttrValueActionLowLongBeep5 = 19;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_SHORT_BEEP_1")]
    public const int RmdAttrValueActionLowShortBeep1 = 5;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_SHORT_BEEP_2")]
    public const int RmdAttrValueActionLowShortBeep2 = 6;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_SHORT_BEEP_3")]
    public const int RmdAttrValueActionLowShortBeep3 = 7;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_SHORT_BEEP_4")]
    public const int RmdAttrValueActionLowShortBeep4 = 8;
    [Register("RMD_ATTR_VALUE_ACTION_LOW_SHORT_BEEP_5")]
    public const int RmdAttrValueActionLowShortBeep5 = 9;
    [Register("RMD_ATTR_VALUE_ACTION_SLOW_WARBLE_BEEP")]
    public const int RmdAttrValueActionSlowWarbleBeep = 21;
    [Register("RMD_ATTR_VALUE_BEEPER_FREQ_HIGH")]
    public const int RmdAttrValueBeeperFreqHigh = 0;
    [Register("RMD_ATTR_VALUE_BEEPER_FREQ_LOW")]
    public const int RmdAttrValueBeeperFreqLow = 2;
    [Register("RMD_ATTR_VALUE_BEEPER_FREQ_MEDIUM")]
    public const int RmdAttrValueBeeperFreqMedium = 1;
    [Register("RMD_ATTR_VALUE_BEEPER_VOLUME_HIGH")]
    public const int RmdAttrValueBeeperVolumeHigh = 0;
    [Register("RMD_ATTR_VALUE_BEEPER_VOLUME_LOW")]
    public const int RmdAttrValueBeeperVolumeLow = 2;
    [Register("RMD_ATTR_VALUE_BEEPER_VOLUME_MEDIUM")]
    public const int RmdAttrValueBeeperVolumeMedium = 1;
    [Register("RMD_ATTR_VALUE_GET_SLOWEST_DECODE_IMAGE")]
    public const int RmdAttrValueGetSlowestDecodeImage = 6036;
    [Register("RMD_ATTR_VALUE_RESET_SSA_FOR_SYMBOLOGY_TYPE")]
    public const int RmdAttrValueResetSsaForSymbologyType = 5006;
    [Register("RMD_ATTR_VALUE_SLOWEST_DECODE_IMAGE_PARAMETER_ID")]
    public const int RmdAttrValueSlowestDecodeImageParameterId = 1755;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_2_OF_5")]
    public const int RmdAttrValueSsaAvgDecodeTime2Of5 = 15454;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_AZTEC")]
    public const int RmdAttrValueSsaAvgDecodeTimeAztec = 15538;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_CODEBAR")]
    public const int RmdAttrValueSsaAvgDecodeTimeCodebar = 15461;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_CODE_11")]
    public const int RmdAttrValueSsaAvgDecodeTimeCode11 = 15482;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_CODE_128")]
    public const int RmdAttrValueSsaAvgDecodeTimeCode128 = 15447;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_CODE_39")]
    public const int RmdAttrValueSsaAvgDecodeTimeCode39 = 15440;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_CODE_93")]
    public const int RmdAttrValueSsaAvgDecodeTimeCode93 = 15468;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_COMPOSITE")]
    public const int RmdAttrValueSsaAvgDecodeTimeComposite = 15524;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_COUPON")]
    public const int RmdAttrValueSsaAvgDecodeTimeCoupon = 15671;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_DATAMARIX")]
    public const int RmdAttrValueSsaAvgDecodeTimeDatamarix = 15496;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaAvgDecodeTimeDigimarcEanJan = 15803;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaAvgDecodeTimeDigimarcOther = 15781;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaAvgDecodeTimeDigimarcUpc = 15792;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_EAN_JAN")]
    public const int RmdAttrValueSsaAvgDecodeTimeEanJan = 15433;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_GS1_DATABAR")]
    public const int RmdAttrValueSsaAvgDecodeTimeGs1Databar = 15517;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaAvgDecodeTimeGs1Datamatrix = 15678;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_GS1_QR_CODE")]
    public const int RmdAttrValueSsaAvgDecodeTimeGs1QrCode = 15685;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_MAXICODE")]
    public const int RmdAttrValueSsaAvgDecodeTimeMaxicode = 15664;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_MSI")]
    public const int RmdAttrValueSsaAvgDecodeTimeMsi = 15475;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_OCR")]
    public const int RmdAttrValueSsaAvgDecodeTimeOcr = 15531;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_OTHER")]
    public const int RmdAttrValueSsaAvgDecodeTimeOther = 15559;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_OTHER_1D")]
    public const int RmdAttrValueSsaAvgDecodeTimeOther1d = 15545;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_OTHER_2D")]
    public const int RmdAttrValueSsaAvgDecodeTimeOther2d = 15552;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_PDF")]
    public const int RmdAttrValueSsaAvgDecodeTimePdf = 15489;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_POSTAL_CODES")]
    public const int RmdAttrValueSsaAvgDecodeTimePostalCodes = 15510;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_QR")]
    public const int RmdAttrValueSsaAvgDecodeTimeQr = 15503;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_UNUSED_ID")]
    public const int RmdAttrValueSsaAvgDecodeTimeUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_AVG_DECODE_TIME_UPC")]
    public const int RmdAttrValueSsaAvgDecodeTimeUpc = 15426;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_2_OF_5")]
    public const int RmdAttrValueSsaDecodeCount2Of5 = 15449;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_AZTEC")]
    public const int RmdAttrValueSsaDecodeCountAztec = 15533;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_CODEBAR")]
    public const int RmdAttrValueSsaDecodeCountCodebar = 15456;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_CODE_11")]
    public const int RmdAttrValueSsaDecodeCountCode11 = 15477;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_CODE_128")]
    public const int RmdAttrValueSsaDecodeCountCode128 = 15442;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_CODE_39")]
    public const int RmdAttrValueSsaDecodeCountCode39 = 15435;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_CODE_93")]
    public const int RmdAttrValueSsaDecodeCountCode93 = 15463;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_COMPOSITE")]
    public const int RmdAttrValueSsaDecodeCountComposite = 15519;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_COUPON")]
    public const int RmdAttrValueSsaDecodeCountCoupon = 15666;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_DATAMARIX")]
    public const int RmdAttrValueSsaDecodeCountDatamarix = 15491;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaDecodeCountDigimarcEanJan = 15798;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaDecodeCountDigimarcOther = 15776;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaDecodeCountDigimarcUpc = 15787;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_EAN_JAN")]
    public const int RmdAttrValueSsaDecodeCountEanJan = 15428;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_GS1_DATABAR")]
    public const int RmdAttrValueSsaDecodeCountGs1Databar = 15512;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaDecodeCountGs1Datamatrix = 15673;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_GS1_QR_CODE")]
    public const int RmdAttrValueSsaDecodeCountGs1QrCode = 15680;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_2_OF_5")]
    public const string RmdAttrValueSsaDecodeCountHex2Of5 = "0x8B 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_AZTEC")]
    public const string RmdAttrValueSsaDecodeCountHexAztec = "0xAD 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_CODEBAR")]
    public const string RmdAttrValueSsaDecodeCountHexCodebar = "0x60 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_CODE_11")]
    public const string RmdAttrValueSsaDecodeCountHexCode11 = "0x75 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_CODE_128")]
    public const string RmdAttrValueSsaDecodeCountHexCode128 = "0x52 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_CODE_39")]
    public const string RmdAttrValueSsaDecodeCountHexCode39 = "0x4B 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_CODE_93")]
    public const string RmdAttrValueSsaDecodeCountHexCode93 = "0x67 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_COMPOSITE")]
    public const string RmdAttrValueSsaDecodeCountHexComposite = "0x9F 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_COUPON")]
    public const string RmdAttrValueSsaDecodeCountHexCoupon = "0x32 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_DATAMARIX")]
    public const string RmdAttrValueSsaDecodeCountHexDatamarix = "0x83 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_DIGIMARC_EAN_JAN")]
    public const string RmdAttrValueSsaDecodeCountHexDigimarcEanJan = "0xB6 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_DIGIMARC_OTHER")]
    public const string RmdAttrValueSsaDecodeCountHexDigimarcOther = "0xA0 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_DIGIMARC_UPC")]
    public const string RmdAttrValueSsaDecodeCountHexDigimarcUpc = "0xAB 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_EAN_JAN")]
    public const string RmdAttrValueSsaDecodeCountHexEanJan = "0x44 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_GS1_DATABAR")]
    public const string RmdAttrValueSsaDecodeCountHexGs1Databar = "0x98 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_GS1_DATAMATRIX")]
    public const string RmdAttrValueSsaDecodeCountHexGs1Datamatrix = "0x39 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_GS1_QR_CODE")]
    public const string RmdAttrValueSsaDecodeCountHexGs1QrCode = "0x40 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_MAXICODE")]
    public const string RmdAttrValueSsaDecodeCountHexMaxicode = "0x2B 0x3D";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_MSI")]
    public const string RmdAttrValueSsaDecodeCountHexMsi = "0x6E 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_OCR")]
    public const string RmdAttrValueSsaDecodeCountHexOcr = "0xA6 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_OTHER")]
    public const string RmdAttrValueSsaDecodeCountHexOther = "0xC3 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_OTHER_1D")]
    public const string RmdAttrValueSsaDecodeCountHexOther1d = "0xB4 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_OTHER_2D")]
    public const string RmdAttrValueSsaDecodeCountHexOther2d = "0xBB 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_PDF")]
    public const string RmdAttrValueSsaDecodeCountHexPdf = "0x7C 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_POSTAL_CODES")]
    public const string RmdAttrValueSsaDecodeCountHexPostalCodes = "0x91 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_QR")]
    public const string RmdAttrValueSsaDecodeCountHexQr = "0x8A 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_UNUSED_ID")]
    public const string RmdAttrValueSsaDecodeCountHexUnusedId = "0x1F 0x4E";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_HEX_UPC")]
    public const string RmdAttrValueSsaDecodeCountHexUpc = "0x3D 0x3C";
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_MAXICODE")]
    public const int RmdAttrValueSsaDecodeCountMaxicode = 15659;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_MSI")]
    public const int RmdAttrValueSsaDecodeCountMsi = 15470;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_OCR")]
    public const int RmdAttrValueSsaDecodeCountOcr = 15526;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_OTHER")]
    public const int RmdAttrValueSsaDecodeCountOther = 15554;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_OTHER_1D")]
    public const int RmdAttrValueSsaDecodeCountOther1d = 15540;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_OTHER_2D")]
    public const int RmdAttrValueSsaDecodeCountOther2d = 15547;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_PDF")]
    public const int RmdAttrValueSsaDecodeCountPdf = 15484;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_POSTAL_CODES")]
    public const int RmdAttrValueSsaDecodeCountPostalCodes = 15505;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_QR")]
    public const int RmdAttrValueSsaDecodeCountQr = 15498;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_UNUSED_ID")]
    public const int RmdAttrValueSsaDecodeCountUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_DECODE_COUNT_UPC")]
    public const int RmdAttrValueSsaDecodeCountUpc = 15421;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_2_OF_5")]
    public const int RmdAttrValueSsaHistogram2Of5 = 15714;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_AZTEC")]
    public const int RmdAttrValueSsaHistogramAztec = 15738;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_CODEBAR")]
    public const int RmdAttrValueSsaHistogramCodebar = 15716;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_CODE_11")]
    public const int RmdAttrValueSsaHistogramCode11 = 15722;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_CODE_128")]
    public const int RmdAttrValueSsaHistogramCode128 = 15712;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_CODE_39")]
    public const int RmdAttrValueSsaHistogramCode39 = 15710;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_CODE_93")]
    public const int RmdAttrValueSsaHistogramCode93 = 15718;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_COMPOSITE")]
    public const int RmdAttrValueSsaHistogramComposite = 15734;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_COUPON")]
    public const int RmdAttrValueSsaHistogramCoupon = 15756;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_DATAMARIX")]
    public const int RmdAttrValueSsaHistogramDatamarix = 15726;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaHistogramDigimarcEanJan = 15805;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaHistogramDigimarcOther = 15783;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaHistogramDigimarcUpc = 15794;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_EAN_JAN")]
    public const int RmdAttrValueSsaHistogramEanJan = 15708;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_GS1_DATABAR")]
    public const int RmdAttrValueSsaHistogramGs1Databar = 15732;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaHistogramGs1Datamatrix = 15746;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_GS1_QR_CODE")]
    public const int RmdAttrValueSsaHistogramGs1QrCode = 15748;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_MAXICODE")]
    public const int RmdAttrValueSsaHistogramMaxicode = 15754;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_MSI")]
    public const int RmdAttrValueSsaHistogramMsi = 15720;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_OCR")]
    public const int RmdAttrValueSsaHistogramOcr = 15736;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_OTHER")]
    public const int RmdAttrValueSsaHistogramOther = 15744;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_OTHER_1D")]
    public const int RmdAttrValueSsaHistogramOther1d = 15740;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_OTHER_2D")]
    public const int RmdAttrValueSsaHistogramOther2d = 15742;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_PDF")]
    public const int RmdAttrValueSsaHistogramPdf = 15724;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_POSTAL_CODES")]
    public const int RmdAttrValueSsaHistogramPostalCodes = 15730;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_QR")]
    public const int RmdAttrValueSsaHistogramQr = 15728;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_UNUSED_ID")]
    public const int RmdAttrValueSsaHistogramUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_HISTOGRAM_UPC")]
    public const int RmdAttrValueSsaHistogramUpc = 15706;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_2_OF_5")]
    public const int RmdAttrValueSsaMaxDecodeTime2Of5 = 15453;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_AZTEC")]
    public const int RmdAttrValueSsaMaxDecodeTimeAztec = 15537;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_CODEBAR")]
    public const int RmdAttrValueSsaMaxDecodeTimeCodebar = 15460;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_CODE_11")]
    public const int RmdAttrValueSsaMaxDecodeTimeCode11 = 15481;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_CODE_128")]
    public const int RmdAttrValueSsaMaxDecodeTimeCode128 = 15446;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_CODE_39")]
    public const int RmdAttrValueSsaMaxDecodeTimeCode39 = 15439;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_CODE_93")]
    public const int RmdAttrValueSsaMaxDecodeTimeCode93 = 15467;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_COMPOSITE")]
    public const int RmdAttrValueSsaMaxDecodeTimeComposite = 15523;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_COUPON")]
    public const int RmdAttrValueSsaMaxDecodeTimeCoupon = 15670;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_DATAMARIX")]
    public const int RmdAttrValueSsaMaxDecodeTimeDatamarix = 15495;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaMaxDecodeTimeDigimarcEanJan = 15802;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaMaxDecodeTimeDigimarcOther = 15780;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaMaxDecodeTimeDigimarcUpc = 15791;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_EAN_JAN")]
    public const int RmdAttrValueSsaMaxDecodeTimeEanJan = 15432;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_GS1_DATABAR")]
    public const int RmdAttrValueSsaMaxDecodeTimeGs1Databar = 15516;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaMaxDecodeTimeGs1Datamatrix = 15677;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_GS1_QR_CODE")]
    public const int RmdAttrValueSsaMaxDecodeTimeGs1QrCode = 15684;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_MAXICODE")]
    public const int RmdAttrValueSsaMaxDecodeTimeMaxicode = 15663;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_MSI")]
    public const int RmdAttrValueSsaMaxDecodeTimeMsi = 15474;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_OCR")]
    public const int RmdAttrValueSsaMaxDecodeTimeOcr = 15530;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_OTHER")]
    public const int RmdAttrValueSsaMaxDecodeTimeOther = 15558;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_OTHER_1D")]
    public const int RmdAttrValueSsaMaxDecodeTimeOther1d = 15544;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_OTHER_2D")]
    public const int RmdAttrValueSsaMaxDecodeTimeOther2d = 15551;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_PDF")]
    public const int RmdAttrValueSsaMaxDecodeTimePdf = 15488;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_POSTAL_CODES")]
    public const int RmdAttrValueSsaMaxDecodeTimePostalCodes = 15509;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_QR")]
    public const int RmdAttrValueSsaMaxDecodeTimeQr = 15502;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_UNUSED_ID")]
    public const int RmdAttrValueSsaMaxDecodeTimeUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_MAX_DECODE_TIME_UPC")]
    public const int RmdAttrValueSsaMaxDecodeTimeUpc = 15425;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_2_OF_5")]
    public const int RmdAttrValueSsaMinDecodeTime2Of5 = 15452;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_AZTEC")]
    public const int RmdAttrValueSsaMinDecodeTimeAztec = 15536;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_CODEBAR")]
    public const int RmdAttrValueSsaMinDecodeTimeCodebar = 15459;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_CODE_11")]
    public const int RmdAttrValueSsaMinDecodeTimeCode11 = 15480;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_CODE_128")]
    public const int RmdAttrValueSsaMinDecodeTimeCode128 = 15445;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_CODE_39")]
    public const int RmdAttrValueSsaMinDecodeTimeCode39 = 15438;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_CODE_93")]
    public const int RmdAttrValueSsaMinDecodeTimeCode93 = 15466;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_COMPOSITE")]
    public const int RmdAttrValueSsaMinDecodeTimeComposite = 15522;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_COUPON")]
    public const int RmdAttrValueSsaMinDecodeTimeCoupon = 15669;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_DATAMARIX")]
    public const int RmdAttrValueSsaMinDecodeTimeDatamarix = 15494;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaMinDecodeTimeDigimarcEanJan = 15801;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaMinDecodeTimeDigimarcOther = 15779;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaMinDecodeTimeDigimarcUpc = 15790;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_EAN_JAN")]
    public const int RmdAttrValueSsaMinDecodeTimeEanJan = 15431;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_GS1_DATABAR")]
    public const int RmdAttrValueSsaMinDecodeTimeGs1Databar = 15515;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaMinDecodeTimeGs1Datamatrix = 15676;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_GS1_QR_CODE")]
    public const int RmdAttrValueSsaMinDecodeTimeGs1QrCode = 15683;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_MAXICODE")]
    public const int RmdAttrValueSsaMinDecodeTimeMaxicode = 15662;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_MSI")]
    public const int RmdAttrValueSsaMinDecodeTimeMsi = 15473;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_OCR")]
    public const int RmdAttrValueSsaMinDecodeTimeOcr = 15529;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_OTHER")]
    public const int RmdAttrValueSsaMinDecodeTimeOther = 15557;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_OTHER_1D")]
    public const int RmdAttrValueSsaMinDecodeTimeOther1d = 15543;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_OTHER_2D")]
    public const int RmdAttrValueSsaMinDecodeTimeOther2d = 15550;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_PDF")]
    public const int RmdAttrValueSsaMinDecodeTimePdf = 15487;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_POSTAL_CODES")]
    public const int RmdAttrValueSsaMinDecodeTimePostalCodes = 15508;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_QR")]
    public const int RmdAttrValueSsaMinDecodeTimeQr = 15501;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_UNUSED_ID")]
    public const int RmdAttrValueSsaMinDecodeTimeUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_MIN_DECODE_TIME_UPC")]
    public const int RmdAttrValueSsaMinDecodeTimeUpc = 15424;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_2_OF_5")]
    public const int RmdAttrValueSsaSlowDecodeData2Of5 = 15715;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_AZTEC")]
    public const int RmdAttrValueSsaSlowDecodeDataAztec = 15739;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_CODEBAR")]
    public const int RmdAttrValueSsaSlowDecodeDataCodebar = 15717;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_CODE_11")]
    public const int RmdAttrValueSsaSlowDecodeDataCode11 = 15723;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_CODE_128")]
    public const int RmdAttrValueSsaSlowDecodeDataCode128 = 15713;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_CODE_39")]
    public const int RmdAttrValueSsaSlowDecodeDataCode39 = 15711;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_CODE_93")]
    public const int RmdAttrValueSsaSlowDecodeDataCode93 = 15719;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_COMPOSITE")]
    public const int RmdAttrValueSsaSlowDecodeDataComposite = 15735;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_COUPON")]
    public const int RmdAttrValueSsaSlowDecodeDataCoupon = 15757;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_DATAMARIX")]
    public const int RmdAttrValueSsaSlowDecodeDataDatamarix = 15727;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_DIGIMARC_EAN_JAN")]
    public const int RmdAttrValueSsaSlowDecodeDataDigimarcEanJan = 15806;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_DIGIMARC_OTHER")]
    public const int RmdAttrValueSsaSlowDecodeDataDigimarcOther = 15784;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_DIGIMARC_UPC")]
    public const int RmdAttrValueSsaSlowDecodeDataDigimarcUpc = 15795;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_EAN_JAN")]
    public const int RmdAttrValueSsaSlowDecodeDataEanJan = 15709;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_GS1_DATABAR")]
    public const int RmdAttrValueSsaSlowDecodeDataGs1Databar = 15733;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_GS1_DATAMATRIX")]
    public const int RmdAttrValueSsaSlowDecodeDataGs1Datamatrix = 15747;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_GS1_QR_CODE")]
    public const int RmdAttrValueSsaSlowDecodeDataGs1QrCode = 15749;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_MAXICODE")]
    public const int RmdAttrValueSsaSlowDecodeDataMaxicode = 15755;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_MSI")]
    public const int RmdAttrValueSsaSlowDecodeDataMsi = 15721;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_OCR")]
    public const int RmdAttrValueSsaSlowDecodeDataOcr = 15737;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_OTHER")]
    public const int RmdAttrValueSsaSlowDecodeDataOther = 15745;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_OTHER_1D")]
    public const int RmdAttrValueSsaSlowDecodeDataOther1d = 15741;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_OTHER_2D")]
    public const int RmdAttrValueSsaSlowDecodeDataOther2d = 15743;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_PDF")]
    public const int RmdAttrValueSsaSlowDecodeDataPdf = 15725;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_POSTAL_CODES")]
    public const int RmdAttrValueSsaSlowDecodeDataPostalCodes = 15731;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_QR")]
    public const int RmdAttrValueSsaSlowDecodeDataQr = 15729;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_UNUSED_ID")]
    public const int RmdAttrValueSsaSlowDecodeDataUnusedId = 19999;
    [Register("RMD_ATTR_VALUE_SSA_SLOW_DECODE_DATA_UPC")]
    public const int RmdAttrValueSsaSlowDecodeDataUpc = 15707;
    [Register("RMD_ATTR_VALUE_VIBRATION_150")]
    public const int RmdAttrValueVibration150 = 15;
    [Register("RMD_ATTR_VALUE_VIBRATION_200")]
    public const int RmdAttrValueVibration200 = 20;
    [Register("RMD_ATTR_VALUE_VIBRATION_250")]
    public const int RmdAttrValueVibration250 = 25;
    [Register("RMD_ATTR_VALUE_VIBRATION_300")]
    public const int RmdAttrValueVibration300 = 30;
    [Register("RMD_ATTR_VALUE_VIBRATION_400")]
    public const int RmdAttrValueVibration400 = 40;
    [Register("RMD_ATTR_VALUE_VIBRATION_500")]
    public const int RmdAttrValueVibration500 = 50;
    [Register("RMD_ATTR_VALUE_VIBRATION_600")]
    public const int RmdAttrValueVibration600 = 60;
    [Register("RMD_ATTR_VALUE_VIBRATION_750")]
    public const int RmdAttrValueVibration750 = 75;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_ALARM_DISABLE")]
    public const int RmdAttrValueVirtualTetherAlarmDisable = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_ALARM_ENABLE")]
    public const int RmdAttrValueVirtualTetherAlarmEnable = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_AUDIO_ALARM_DISABLE")]
    public const int RmdAttrValueVirtualTetherAudioAlarmDisable = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_AUDIO_ALARM_NIGHT_MODE_ACTIVE_ENABLE")]
    public const int RmdAttrValueVirtualTetherAudioAlarmNightModeActiveEnable = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_AUDIO_ALARM_NIGHT_MODE_SILENT_ENABLE")]
    public const int RmdAttrValueVirtualTetherAudioAlarmNightModeSilentEnable = 2;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_DEFEAT_ALARM_DISBALE")]
    public const int RmdAttrValueVirtualTetherDefeatAlarmDisbale = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_HAPTICS_ALARM_DISABLE")]
    public const int RmdAttrValueVirtualTetherHapticsAlarmDisable = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_HAPTICS_ALARM_ENABLE")]
    public const int RmdAttrValueVirtualTetherHapticsAlarmEnable = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_ILLUMIN_ALARM_DISABLE")]
    public const int RmdAttrValueVirtualTetherIlluminAlarmDisable = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_ILLUMIN_ALARM_ENABLE")]
    public const int RmdAttrValueVirtualTetherIlluminAlarmEnable = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_LED_ALARM_DISABLE")]
    public const int RmdAttrValueVirtualTetherLedAlarmDisable = 0;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_LED_ALARM_ENABLE")]
    public const int RmdAttrValueVirtualTetherLedAlarmEnable = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_PAUSE_ALARM_ON_SCAN_BUTTON_PRESS")]
    public const int RmdAttrValueVirtualTetherPauseAlarmOnScanButtonPress = 1;
    [Register("RMD_ATTR_VALUE_VIRTUAL_TETHER_STOP_ALARM_ON_SCAN_BUTTON_PRESS")]
    public const int RmdAttrValueVirtualTetherStopAlarmOnScanButtonPress = 2;
    [Register("RMD_ATTR_VIRTUAL_TETHER_ALARM_ACTIVATION_DELAY")]
    public const int RmdAttrVirtualTetherAlarmActivationDelay = 2054;
    [Register("RMD_ATTR_VIRTUAL_TETHER_ALARM_DEFEAT_STATUS")]
    public const int RmdAttrVirtualTetherAlarmDefeatStatus = 2119;
    [Register("RMD_ATTR_VIRTUAL_TETHER_ALARM_DURATION")]
    public const int RmdAttrVirtualTetherAlarmDuration = 2055;
    [Register("RMD_ATTR_VIRTUAL_TETHER_ALARM_STATUS")]
    public const int RmdAttrVirtualTetherAlarmStatus = 2053;
    [Register("RMD_ATTR_VIRTUAL_TETHER_AUDIO_ALARM_STATUS")]
    public const int RmdAttrVirtualTetherAudioAlarmStatus = 2246;
    [Register("RMD_ATTR_VIRTUAL_TETHER_HAPTICS_ALARM_STATUS")]
    public const int RmdAttrVirtualTetherHapticsAlarmStatus = 2249;
    [Register("RMD_ATTR_VIRTUAL_TETHER_ILLUMINATION_ALARM_STATUS")]
    public const int RmdAttrVirtualTetherIlluminationAlarmStatus = 2248;
    [Register("RMD_ATTR_VIRTUAL_TETHER_LED_ALARM_STATUS")]
    public const int RmdAttrVirtualTetherLedAlarmStatus = 2247;
    [Register("RMD_ATTR_VIRTUAL_TETHER_PAUSE_ALARM_DURATION")]
    public const int RmdAttrVirtualTetherPauseAlarmDuration = 2120;
    private static readonly JniPeerMembers _members = (JniPeerMembers) new XAPeerMembers("com/zebra/scannercontrol/RMDAttributes", typeof (RMDAttributes));

    internal static IntPtr class_ref
    {
      get
      {
        JniObjectReference peerReference = RMDAttributes._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual JniPeerMembers JniPeerMembers => RMDAttributes._members;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual IntPtr ThresholdClass
    {
      get
      {
        JniObjectReference peerReference = RMDAttributes._members.JniPeerType.PeerReference;
        return ((JniObjectReference) ref peerReference).Handle;
      }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual Type ThresholdType => RMDAttributes._members.ManagedPeerType;

    protected RMDAttributes(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    [Register(".ctor", "()V", "")]
    public unsafe RMDAttributes()
      : base(IntPtr.Zero, (JniHandleOwnership) 0)
    {
      if (this.Handle != IntPtr.Zero)
        return;
      JniObjectReference instance = RMDAttributes._members.InstanceMethods.StartCreateInstance("()V", ((object) this).GetType(), (JniArgumentValue*) null);
      this.SetHandle(((JniObjectReference) ref instance).Handle, (JniHandleOwnership) 1);
      RMDAttributes._members.InstanceMethods.FinishCreateInstance("()V", (IJavaPeerable) this, (JniArgumentValue*) null);
    }
  }
}
