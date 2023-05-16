using UnityEngine;

namespace I2.Loc
{
    public static class LocalizationManager
    {
        // Fields
        private static string mCurrentLanguage;
        private static string mLanguageCode;
        private static System.Globalization.CultureInfo mCurrentCulture;
        private static bool mChangeCultureInfo;
        public static bool IsRight2Left;
        public static bool HasJoinedWords;
        public static System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager> ParamManagers;
        private static string[] LanguagesRTL;
        public static System.Collections.Generic.List<I2.Loc.LanguageSourceData> Sources;
        public static string[] GlobalSources;
        private static string mCurrentDeviceLanguage;
        public static System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor> mLocalizeTargets;
        private static I2.Loc.LocalizationManager.OnLocalizeCallback OnLocalizeEvent;
        private static bool mLocalizeIsScheduled;
        private static bool mLocalizeIsScheduledWithForcedValue;
        public static bool HighlightLocalizedTargets;
        
        // Properties
        public static string CurrentLanguage { get; set; }
        public static string CurrentLanguageCode { get; set; }
        public static string CurrentRegion { get; set; }
        public static string CurrentRegionCode { get; set; }
        public static System.Globalization.CultureInfo CurrentCulture { get; }
        
        // Methods
        public static void InitializeIfNeeded()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentLanguage)) != true)
            {
                    val_4 = null;
                if((I2.Loc.LocalizationManager.Sources + 24) != 0)
            {
                    return;
            }
            
            }
            
            I2.Loc.LocalizationManager.AutoLoadGlobalParamManagers();
            bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            I2.Loc.LocalizationManager.SelectStartupLanguage();
        }
        public static string GetVersion()
        {
            return "2.8.13 f2";
        }
        public static int GetRequiredWebServiceVersion()
        {
            return 5;
        }
        public static string GetWebServiceURL(I2.Loc.LanguageSourceData source)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = source;
            if(val_4 != null)
            {
                    if((System.String.IsNullOrEmpty(value:  source.Google_WebServiceURL)) == false)
            {
                    return (string)val_4;
            }
            
            }
            
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_5 = 4;
            goto label_5;
            label_20:
            if(X21 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((I2.Loc.LocalizationManager.Sources + 16 + 32) == 0)
            {
                goto label_10;
            }
            
            val_6 = null;
            val_6 = null;
            if(X21 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.Sources + 16 + 32 + 88)) == false)
            {
                goto label_16;
            }
            
            label_10:
            val_5 = 5;
            label_5:
            val_7 = null;
            val_7 = null;
            if((val_5 - 4) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_20;
            }
            
            return (string)val_4;
            label_16:
            val_8 = null;
            val_8 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= W21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = (I2.Loc.LocalizationManager.Sources + 16 + 32) + 88;
            return (string)val_4;
        }
        public static string get_CurrentLanguage()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mCurrentLanguage;
        }
        public static void set_CurrentLanguage(string value)
        {
            var val_5;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            string val_1 = I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  value, ignoreDisabled:  false);
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mCurrentLanguage, b:  val_1)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_1, LanguageCode:  I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_1), RememberLanguage:  true, Force:  false);
        }
        public static string get_CurrentLanguageCode()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mLanguageCode;
        }
        public static void set_CurrentLanguageCode(string value)
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mLanguageCode, b:  value)) == false)
            {
                    return;
            }
            
            string val_2 = I2.Loc.LocalizationManager.GetLanguageFromCode(Code:  value, exactMatch:  true);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_2, LanguageCode:  value, RememberLanguage:  true, Force:  false);
        }
        public static string get_CurrentRegion()
        {
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguage;
            System.Char[] val_10 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_10);
            if(val_3 >= 1)
            {
                    val_10 = val_3 + 1;
                return val_1.Substring(startIndex:  val_10);
            }
            
            int val_5 = val_1.IndexOfAny(anyOf:  ToCharArray());
            int val_7 = val_1.LastIndexOfAny(anyOf:  ToCharArray());
            if(val_5 < 1)
            {
                    return (string)System.String.alignConst;
            }
            
            if(val_7 == val_5)
            {
                    return (string)System.String.alignConst;
            }
            
            return val_1.Substring(startIndex:  val_5 + 1, length:  val_7 + (~val_5));
        }
        public static void set_CurrentRegion(string value)
        {
            string val_12 = I2.Loc.LocalizationManager.CurrentLanguage;
            System.Char[] val_12 = ToCharArray();
            int val_3 = val_12.IndexOfAny(anyOf:  val_12);
            if(val_3 >= 1)
            {
                    val_12 = val_3 + 1;
                string val_5 = val_12.Substring(startIndex:  val_12)(val_12.Substring(startIndex:  val_12)) + value;
            }
            else
            {
                    int val_7 = val_12.IndexOfAny(anyOf:  ToCharArray());
                if((val_7 >= 1) && (val_7 != (val_12.LastIndexOfAny(anyOf:  ToCharArray()))))
            {
                    val_12 = val_12.Substring(startIndex:  val_7);
            }
            
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = val_12 + "(" + value + ")";
        }
        public static string get_CurrentRegionCode()
        {
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            System.Char[] val_4 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_4);
            if((val_3 & 2147483648) != 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_4 = val_3 + 1;
            return val_1.Substring(startIndex:  val_4);
        }
        public static void set_CurrentRegionCode(string value)
        {
            string val_6 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            int val_3 = val_6.IndexOfAny(anyOf:  ToCharArray());
            if(val_3 >= 1)
            {
                    val_6 = val_6.Substring(startIndex:  0, length:  val_3);
            }
            
            I2.Loc.LocalizationManager.CurrentLanguageCode = val_6 + "-"("-") + value;
        }
        public static System.Globalization.CultureInfo get_CurrentCulture()
        {
            null = null;
            return (System.Globalization.CultureInfo)I2.Loc.LocalizationManager.mCurrentCulture;
        }
        public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = True, bool Force = False)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = null;
            val_11 = null;
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mCurrentLanguage, b:  LanguageName)) != false)
            {
                    val_12 = 1;
            }
            else
            {
                    val_13 = null;
                val_13 = null;
                val_12 = System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mLanguageCode, b:  LanguageCode);
            }
            
            val_12 = val_12 | Force;
            if(val_12 == false)
            {
                    return;
            }
            
            if(RememberLanguage != false)
            {
                    I2.Loc.PersistentStorage.SetSetting_String(key:  "I2 Language", value:  LanguageName);
            }
            
            val_14 = null;
            val_14 = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = LanguageName;
            I2.Loc.LocalizationManager.mLanguageCode = LanguageCode;
            val_15 = null;
            I2.Loc.LocalizationManager.mCurrentCulture = I2.Loc.LocalizationManager.CreateCultureForCode(code:  LanguageCode);
            if(I2.Loc.LocalizationManager.mChangeCultureInfo != false)
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_15 = null;
            }
            
            val_15 = null;
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.HasJoinedWords = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  Force);
        }
        private static System.Globalization.CultureInfo CreateCultureForCode(string code)
        {
            return (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CreateSpecificCulture(name:  code);
        }
        public static void EnableChangingCultureInfo(bool bEnable)
        {
            var val_2 = null;
            if((I2.Loc.LocalizationManager.mChangeCultureInfo != true) && (bEnable != false))
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_2 = null;
            }
            
            val_2 = null;
            I2.Loc.LocalizationManager.mChangeCultureInfo = bEnable;
        }
        private static void SetCurrentCultureInfo()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = I2.Loc.LocalizationManager.mCurrentCulture;
        }
        private static void SelectStartupLanguage()
        {
            var val_10;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_11;
            var val_12;
            string val_13;
            var val_14;
            string val_15;
            string val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_11 = 1152921505149231104;
            val_12 = null;
            val_12 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    return;
            }
            
            string val_1 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2 Language", defaultValue:  System.String.alignConst);
            val_13 = I2.Loc.LocalizationManager.GetCurrentDeviceLanguage(force:  false);
            if(((System.String.IsNullOrEmpty(value:  val_1)) == true) || ((I2.Loc.LocalizationManager.HasLanguage(Language:  val_1, AllowDiscartingRegion:  true, Initialize:  false, SkipDisabled:  true)) == false))
            {
                goto label_10;
            }
            
            val_14 = 1;
            val_15 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_1);
            val_16 = val_1;
            goto label_13;
            label_10:
            val_17 = null;
            val_17 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((I2.Loc.LocalizationManager.Sources + 16 + 32 + 80) != 0)
            {
                goto label_19;
            }
            
            string val_6 = I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  val_13, ignoreDisabled:  true);
            val_13 = val_6;
            if((System.String.IsNullOrEmpty(value:  val_6)) == false)
            {
                goto label_22;
            }
            
            label_19:
            val_18 = null;
            val_18 = null;
            val_10 = mem[I2.Loc.LocalizationManager.Sources + 24];
            val_10 = I2.Loc.LocalizationManager.Sources + 24;
            if(val_10 < 1)
            {
                    return;
            }
            
            var val_14 = 0;
            goto label_27;
            label_52:
            val_18 = null;
            label_27:
            val_18 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = I2.Loc.LocalizationManager.Sources + 16;
            val_10 = val_10 + 0;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 24) < 1)
            {
                goto label_34;
            }
            
            val_19 = 0;
            goto label_35;
            label_51:
            val_20 = null;
            val_20 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = I2.Loc.LocalizationManager.Sources + 16;
            val_11 = val_11 + 0;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16;
            val_12 = val_12 + 0;
            if((((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16 + 0) + 32.IsEnabled()) == true)
            {
                goto label_44;
            }
            
            val_19 = 1;
            label_35:
            val_21 = null;
            val_21 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = I2.Loc.LocalizationManager.Sources + 16;
            val_13 = val_13 + 0;
            if(val_19 < ((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 24))
            {
                goto label_51;
            }
            
            label_34:
            val_14 = val_14 + 1;
            if(val_14 < val_10)
            {
                goto label_52;
            }
            
            return;
            label_44:
            val_22 = null;
            val_22 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = I2.Loc.LocalizationManager.Sources + 16;
            val_15 = val_15 + 0;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16;
            val_16 = val_16 + 0;
            val_11 = I2.Loc.LocalizationManager.Sources;
            val_13 = mem[((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16 + 0) + 32 + 16];
            val_13 = ((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16 + 0) + 32 + 16;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = I2.Loc.LocalizationManager.Sources + 16;
            val_17 = val_17 + 0;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16;
            val_18 = val_18 + 0;
            val_15 = mem[((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16 + 0) + 32 + 24];
            val_15 = ((I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 72 + 16 + 0) + 32 + 24;
            goto label_67;
            label_22:
            val_15 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_13);
            label_67:
            val_16 = val_13;
            val_14 = 0;
            label_13:
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_16, LanguageCode:  val_15, RememberLanguage:  false, Force:  false);
        }
        public static bool HasLanguage(string Language, bool AllowDiscartingRegion = True, bool Initialize = True, bool SkipDisabled = True)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            if(Initialize != false)
            {
                    I2.Loc.LocalizationManager.InitializeIfNeeded();
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = mem[I2.Loc.LocalizationManager.Sources + 24];
            val_4 = I2.Loc.LocalizationManager.Sources + 24;
            if(val_4 < 1)
            {
                goto label_9;
            }
            
            val_5 = 0;
            goto label_8;
            label_15:
            if(1 >= val_4)
            {
                goto label_9;
            }
            
            val_3 = null;
            val_5 = 1;
            label_8:
            val_3 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = I2.Loc.LocalizationManager.Sources + 16;
            val_3 = val_3 + 8;
            SkipDisabled = SkipDisabled;
            if((((I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  SkipDisabled)) & 2147483648) != 0)
            {
                goto label_15;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_9:
            if(AllowDiscartingRegion == false)
            {
                goto label_23;
            }
            
            val_7 = null;
            val_7 = null;
            val_4 = mem[I2.Loc.LocalizationManager.Sources + 24];
            val_4 = I2.Loc.LocalizationManager.Sources + 24;
            if(val_4 < 1)
            {
                goto label_23;
            }
            
            val_8 = 0;
            goto label_22;
            label_29:
            if(1 >= val_4)
            {
                goto label_23;
            }
            
            val_7 = null;
            val_8 = 1;
            label_22:
            val_7 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = I2.Loc.LocalizationManager.Sources + 16;
            val_4 = val_4 + 8;
            SkipDisabled = SkipDisabled;
            val_6 = 1;
            if((((I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  true, SkipDisabled:  SkipDisabled)) & 2147483648) != 0)
            {
                goto label_29;
            }
            
            return (bool)val_6;
            label_23:
            val_6 = 0;
            return (bool)val_6;
        }
        public static string GetSupportedLanguage(string Language, bool ignoreDisabled = False)
        {
            bool val_15;
            string val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_15 = ignoreDisabled;
            string val_1 = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  Language, ShowWarnings:  false);
            val_16 = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                goto label_20;
            }
            
            val_17 = 1152921505149231104;
            val_18 = null;
            val_18 = null;
            val_19 = mem[I2.Loc.LocalizationManager.Sources + 24];
            val_19 = I2.Loc.LocalizationManager.Sources + 24;
            var val_3 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            if(val_19 < 1)
            {
                goto label_7;
            }
            
            val_21 = 4;
            label_14:
            val_22 = null;
            val_23 = val_21 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = mem[I2.Loc.LocalizationManager.Sources + 16 + 32];
            val_24 = I2.Loc.LocalizationManager.Sources + 16 + 32;
            if(((val_24.GetLanguageIndexFromCode(Code:  val_16, exactMatch:  true, ignoreDisabled:  val_15)) & 2147483648) == 0)
            {
                goto label_13;
            }
            
            val_25 = null;
            val_21 = val_21 + 1;
            var val_7 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            if((val_21 - 4) < val_19)
            {
                goto label_14;
            }
            
            label_7:
            val_25 = null;
            val_19 = mem[I2.Loc.LocalizationManager.Sources + 24];
            val_19 = I2.Loc.LocalizationManager.Sources + 24;
            if(val_19 < 1)
            {
                goto label_20;
            }
            
            val_21 = 4;
            goto label_19;
            label_26:
            if(1 >= val_19)
            {
                goto label_20;
            }
            
            val_25 = null;
            val_21 = 5;
            label_19:
            val_25 = null;
            val_23 = val_21 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40];
            val_24 = I2.Loc.LocalizationManager.Sources + 16 + 40;
            int val_9 = val_24.GetLanguageIndexFromCode(Code:  val_16, exactMatch:  false, ignoreDisabled:  val_15);
            if((val_9 & 2147483648) != 0)
            {
                goto label_26;
            }
            
            label_13:
            val_26 = null;
            val_26 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40 + 72];
            val_15 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72;
            if((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 24) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = (I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16) + (val_9 << 3);
            goto label_34;
            label_20:
            val_28 = null;
            val_28 = null;
            var val_10 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_38;
            }
            
            val_17 = 4;
            label_45:
            val_30 = null;
            val_16 = I2.Loc.LocalizationManager.Sources;
            val_19 = val_17 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_31 = mem[I2.Loc.LocalizationManager.Sources + 16 + 32];
            val_31 = I2.Loc.LocalizationManager.Sources + 16 + 32;
            if(((val_31.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  val_15)) & 2147483648) == 0)
            {
                goto label_44;
            }
            
            val_32 = null;
            val_17 = val_17 + 1;
            var val_14 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            if((val_17 - 4) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_45;
            }
            
            label_38:
            val_32 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_17 = 4;
            goto label_50;
            label_57:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_32 = null;
            val_17 = 5;
            label_50:
            val_32 = null;
            val_19 = val_17 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_31 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40];
            val_31 = I2.Loc.LocalizationManager.Sources + 16 + 40;
            int val_16 = val_31.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  true, SkipDisabled:  val_15);
            if((val_16 & 2147483648) != 0)
            {
                goto label_57;
            }
            
            label_44:
            val_16 = val_16;
            val_33 = null;
            val_33 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40 + 72];
            val_15 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72;
            if((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 24) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = (I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16) + (val_16 << 3);
            label_34:
            val_34 = ((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16 + (val_16) << 3) + 32) + 16;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public static string GetLanguageCode(string Language)
        {
            string val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = Language;
            val_4 = null;
            val_4 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    bool val_1 = I2.Loc.LocalizationManager.UpdateSources();
                val_4 = null;
            }
            
            val_4 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_5 = 4;
            goto label_11;
            label_18:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_4 = null;
            val_5 = 5;
            label_11:
            val_4 = null;
            var val_2 = val_5 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_3 = I2.Loc.LocalizationManager.Sources + 16 + 40.GetLanguageIndex(language:  val_3, AllowDiscartingRegion:  true, SkipDisabled:  true);
            if((val_3 & 2147483648) != 0)
            {
                goto label_18;
            }
            
            val_6 = null;
            val_6 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40 + 72];
            val_3 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72;
            if((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 24) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16;
            val_4 = val_4 + (val_3 << 3);
            val_7 = ((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16 + (val_3) << 3) + 32) + 24;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public static string GetLanguageFromCode(string Code, bool exactMatch = True)
        {
            var val_4;
            string val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = Code;
            val_6 = null;
            val_6 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    bool val_1 = I2.Loc.LocalizationManager.UpdateSources();
                val_6 = null;
            }
            
            val_6 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_7 = 4;
            goto label_11;
            label_18:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_6 = null;
            val_7 = 5;
            label_11:
            val_6 = null;
            var val_3 = val_7 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_4 = I2.Loc.LocalizationManager.Sources + 16 + 40.GetLanguageIndexFromCode(Code:  val_5, exactMatch:  exactMatch, ignoreDisabled:  false);
            if((val_4 & 2147483648) != 0)
            {
                goto label_18;
            }
            
            val_4 = val_4;
            val_8 = null;
            val_8 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40 + 72];
            val_5 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72;
            if((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 24) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16;
            val_5 = val_5 + (val_4 << 3);
            val_9 = ((I2.Loc.LocalizationManager.Sources + 16 + 40 + 72 + 16 + (val_4) << 3) + 32) + 16;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public static System.Collections.Generic.List<string> GetAllLanguages(bool SkipDisabled = True)
        {
            bool val_8;
            var val_9;
            var val_10;
            System.Collections.Generic.List<System.String> val_11;
            var val_12;
            System.Func<System.String, System.Boolean> val_13;
            val_8 = SkipDisabled;
            val_9 = null;
            val_9 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            .Languages = new System.Collections.Generic.List<System.String>();
            val_10 = null;
            val_10 = null;
            val_11 = (LocalizationManager.<>c__DisplayClass33_0)[1152921528770007376].Languages;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return val_11;
            }
            
            val_12 = 0;
            val_8 = val_8;
            goto label_12;
            label_20:
            val_10 = null;
            val_12 = 1;
            label_12:
            val_10 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = I2.Loc.LocalizationManager.Sources + 16;
            val_8 = val_8 + 8;
            val_13 = (LocalizationManager.<>c__DisplayClass33_0)[1152921528770007376].<>9__0;
            if(val_13 == null)
            {
                    System.Func<System.String, System.Boolean> val_5 = null;
                val_13 = val_5;
                val_5 = new System.Func<System.String, System.Boolean>(object:  new LocalizationManager.<>c__DisplayClass33_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass33_0::<GetAllLanguages>b__0(string x));
                .<>9__0 = val_13;
            }
            
            val_11.AddRange(collection:  System.Linq.Enumerable.Where<System.String>(source:  (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetLanguages(skipDisabled:  val_8), predicate:  val_5));
            val_11 = (LocalizationManager.<>c__DisplayClass33_0)[1152921528770007376].Languages;
            if((val_12 + 1) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_20;
            }
            
            return val_11;
        }
        public static System.Collections.Generic.List<string> GetAllLanguagesCode(bool allowRegions = True, bool SkipDisabled = True)
        {
            bool val_8;
            var val_9;
            System.Collections.Generic.List<System.String> val_10;
            var val_11;
            System.Func<System.String, System.Boolean> val_12;
            val_8 = allowRegions;
            .Languages = new System.Collections.Generic.List<System.String>();
            val_9 = null;
            val_9 = null;
            val_10 = (LocalizationManager.<>c__DisplayClass34_0)[1152921528770185936].Languages;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return val_10;
            }
            
            val_11 = 0;
            val_8 = val_8;
            goto label_6;
            label_14:
            val_11 = 1;
            val_9 = null;
            label_6:
            val_9 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = I2.Loc.LocalizationManager.Sources + 16;
            val_8 = val_8 + 8;
            val_12 = (LocalizationManager.<>c__DisplayClass34_0)[1152921528770185936].<>9__0;
            if(val_12 == null)
            {
                    System.Func<System.String, System.Boolean> val_5 = null;
                val_12 = val_5;
                val_5 = new System.Func<System.String, System.Boolean>(object:  new LocalizationManager.<>c__DisplayClass34_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass34_0::<GetAllLanguagesCode>b__0(string x));
                .<>9__0 = val_12;
            }
            
            val_10.AddRange(collection:  System.Linq.Enumerable.Where<System.String>(source:  (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetLanguagesCode(allowRegions:  val_8, skipDisabled:  SkipDisabled), predicate:  val_5));
            val_10 = (LocalizationManager.<>c__DisplayClass34_0)[1152921528770185936].Languages;
            if((val_11 + 1) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_14;
            }
            
            return val_10;
        }
        public static bool IsLanguageEnabled(string Language)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_6;
            }
            
            val_3 = 0;
            goto label_5;
            label_12:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_6;
            }
            
            val_2 = null;
            val_3 = 1;
            label_5:
            val_2 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = I2.Loc.LocalizationManager.Sources + 16;
            val_2 = val_2 + 8;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.IsLanguageEnabled(Language:  Language)) == true)
            {
                goto label_12;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_6:
            val_4 = 1;
            return (bool)val_4;
        }
        private static void LoadCurrentLanguage()
        {
            var val_2;
            var val_3;
            val_2 = 0;
            goto label_1;
            label_13:
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = I2.Loc.LocalizationManager.Sources + 16;
            val_2 = val_2 + 0;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = I2.Loc.LocalizationManager.Sources + 16;
            val_3 = val_3 + 0;
            (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32.LoadLanguage(languageIndex:  (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32.GetLanguageIndex(language:  I2.Loc.LocalizationManager.mCurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  false), UnloadOtherLanguages:  true, useFallback:  true, onlyCurrentSpecialization:  true, forceLoad:  false);
            val_2 = 1;
            label_1:
            val_3 = null;
            val_3 = null;
            if(val_2 < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_13;
            }
        
        }
        public static void PreviewLanguage(string NewLanguage)
        {
            null = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = NewLanguage;
            I2.Loc.LocalizationManager.mLanguageCode = I2.Loc.LocalizationManager.GetLanguageCode(Language:  I2.Loc.LocalizationManager.mCurrentLanguage);
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.HasJoinedWords = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  I2.Loc.LocalizationManager.mLanguageCode);
        }
        public static void AutoLoadGlobalParamManagers()
        {
            var val_3;
            var val_4;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                T val_3 = UnityEngine.Object.FindObjectsOfType<I2.Loc.LocalizationParamsManager>()[val_4];
                if((val_1[0x0][0] + 32) != 0)
            {
                    val_3 = null;
                val_3 = null;
                if((I2.Loc.LocalizationManager.ParamManagers.Contains(item:  val_3)) != true)
            {
                    UnityEngine.Debug.Log(message:  val_3);
                val_4 = null;
                val_4 = null;
                I2.Loc.LocalizationManager.ParamManagers.Add(item:  val_3);
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
        
        }
        public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = True)
        {
            var val_3;
            LocalizationManager._GetParam val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LocalizationManager.<>c.<>9__41_0;
            if(val_5 == null)
            {
                    val_5 = new LocalizationManager._GetParam();
                mem[1152921528770893264] = LocalizationManager.<>c.__il2cppRuntimeField_static_fields;
                mem[1152921528770893272] = System.Object LocalizationManager.<>c::<ApplyLocalizationParams>b__41_0(string p);
                mem[1152921528770893248] = System.Object LocalizationManager.<>c::<ApplyLocalizationParams>b__41_0(string p);
                LocalizationManager.<>c.<>9__41_0 = new LocalizationManager._GetParam();
            }
            
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, UnityEngine.GameObject root, bool allowLocalizedParameters = True)
        {
            .root = root;
            mem[1152921528771038928] = new LocalizationManager.<>c__DisplayClass42_0();
            mem[1152921528771038936] = System.Object LocalizationManager.<>c__DisplayClass42_0::<ApplyLocalizationParams>b__0(string p);
            mem[1152921528771038912] = System.Object LocalizationManager.<>c__DisplayClass42_0::<ApplyLocalizationParams>b__0(string p);
            allowLocalizedParameters = allowLocalizedParameters;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, System.Collections.Generic.Dictionary<string, object> parameters, bool allowLocalizedParameters = True)
        {
            .parameters = parameters;
            mem[1152921528771184592] = new LocalizationManager.<>c__DisplayClass43_0();
            mem[1152921528771184600] = System.Object LocalizationManager.<>c__DisplayClass43_0::<ApplyLocalizationParams>b__0(string p);
            mem[1152921528771184576] = System.Object LocalizationManager.<>c__DisplayClass43_0::<ApplyLocalizationParams>b__0(string p);
            allowLocalizedParameters = allowLocalizedParameters;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, I2.Loc.LocalizationManager._GetParam getParam, bool allowLocalizedParameters = True)
        {
            var val_34;
            string val_35;
            var val_36;
            string val_37;
            var val_38;
            string val_39;
            val_34 = getParam;
            I2.Loc.LanguageSourceData val_14 = 0;
            if(translation == null)
            {
                    return;
            }
            
            val_35 = 0;
            label_36:
            if(0 >= translation.m_stringLength)
            {
                goto label_19;
            }
            
            int val_1 = translation.IndexOf(value:  "{[", startIndex:  0);
            if((val_1 & 2147483648) != 0)
            {
                goto label_19;
            }
            
            int val_2 = translation.IndexOf(value:  "]}", startIndex:  val_1);
            if((val_2 & 2147483648) != 0)
            {
                goto label_19;
            }
            
            val_36 = val_2;
            int val_4 = translation.IndexOf(value:  "{[", startIndex:  val_1 + 1);
            if((val_4 < 1) || (val_4 >= val_36))
            {
                goto label_9;
            }
            
            if((val_4 & 2147483648) == 0)
            {
                goto label_36;
            }
            
            goto label_19;
            label_9:
            int val_5 = val_1 + 2;
            var val_8 = ((translation.Chars[val_5] & 65535) == '#') ? (2 + 1) : 2;
            int val_9 = val_36 - val_1;
            val_5 = val_8 + val_1;
            object val_12 = val_34.Invoke(param:  translation.Substring(startIndex:  val_5, length:  val_9 - val_8));
            if(val_12 == null)
            {
                goto label_15;
            }
            
            val_37 = val_12;
            if(null != null)
            {
                goto label_16;
            }
            
            if(allowLocalizedParameters == true)
            {
                goto label_17;
            }
            
            label_15:
            if(((val_36 + 2) & 2147483648) == 0)
            {
                goto label_36;
            }
            
            goto label_19;
            label_17:
            I2.Loc.TermData val_15 = I2.Loc.LocalizationManager.GetTermData(term:  val_37, source: out  val_14);
            if(val_15 != null)
            {
                    val_36 = val_14;
                int val_17 = val_36.GetLanguageIndex(language:  I2.Loc.LocalizationManager.CurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  true);
                if((val_17 & 2147483648) == 0)
            {
                    val_37 = val_15.GetTranslation(idx:  val_17, specialization:  0, editMode:  false);
            }
            
            }
            
            translation = translation.Replace(oldValue:  translation.Substring(startIndex:  val_1, length:  val_9 + 2), newValue:  val_37);
            if((System.Int32.TryParse(s:  val_37, result: out  0)) != false)
            {
                    I2.Loc.ePluralType val_25 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  I2.Loc.LocalizationManager.CurrentLanguageCode, n:  0);
                val_36 = val_25;
                val_35 = val_25.ToString();
                string val_27 = val_25.ToString();
            }
            
            int val_28 = val_18.m_stringLength + val_1;
            if(null >= 0)
            {
                goto label_36;
            }
            
            label_19:
            if(val_35 == null)
            {
                    return;
            }
            
            val_34 = "[i2p_";
            int val_30 = translation.IndexOf(value:  "[i2p_" + val_35 + "]", comparisonType:  5);
            if((val_30 & 2147483648) == 0)
            {
                    val_38 = val_29.m_stringLength + val_30;
            }
            else
            {
                    val_38 = 0;
            }
            
            val_39 = translation;
            if(((val_39.IndexOf(value:  "[i2p_", startIndex:  val_38 + 1, comparisonType:  5)) & 2147483648) == 0)
            {
                    if(translation != null)
            {
                goto label_44;
            }
            
            }
            
            val_39 = mem[val_21 + 16];
            val_39 = val_21.m_stringLength;
            label_44:
            translation = translation.Substring(startIndex:  0, length:  val_39 - val_38);
            return;
            label_16:
        }
        internal static string GetLocalizationParam(string ParamName, UnityEngine.GameObject root)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            if((UnityEngine.Object.op_Implicit(exists:  root)) == false)
            {
                goto label_17;
            }
            
            int val_6 = val_2.Length;
            if(val_6 < 1)
            {
                goto label_17;
            }
            
            val_6 = val_6 & 4294967295;
            var val_11 = 0;
            val_6 = (long)val_6;
            label_18:
            T val_7 = root.GetComponents<UnityEngine.MonoBehaviour>()[val_11];
            if(X0 == false)
            {
                goto label_11;
            }
            
            val_7 = X0;
            if((val_2[0x0] + 32.enabled) == false)
            {
                goto label_11;
            }
            
            var val_10 = val_7;
            if((X0 + 294) == 0)
            {
                goto label_15;
            }
            
            var val_8 = X0 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_14:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (X0 + 294))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_10 = val_10 + (((X0 + 176 + 8)) << 4);
            val_8 = val_10 + 304;
            label_15:
            val_9 = public System.String I2.Loc.ILocalizationParamsManager::GetParameterValue(string Param);
            val_10 = val_7;
            if((val_10.GetParameterValue(Param:  ParamName)) != null)
            {
                    return (string)val_10;
            }
            
            label_11:
            val_11 = val_11 + 1;
            if(val_11 >= val_6)
            {
                goto label_17;
            }
            
            if(val_11 < val_2.Length)
            {
                goto label_18;
            }
            
            throw new IndexOutOfRangeException();
            label_17:
            val_7 = 1152921505149231104;
            val_11 = null;
            val_11 = null;
            if((I2.Loc.LocalizationManager.ParamManagers + 24) < 1)
            {
                goto label_24;
            }
            
            val_6 = 0;
            goto label_23;
            label_34:
            val_6 = 1;
            if(val_6 >= (I2.Loc.LocalizationManager.ParamManagers + 24))
            {
                goto label_24;
            }
            
            val_11 = null;
            label_23:
            val_11 = null;
            if((I2.Loc.LocalizationManager.ParamManagers + 24) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = I2.Loc.LocalizationManager.ParamManagers + 16;
            val_12 = val_12 + 8;
            var val_15 = (I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32;
            if(((I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32 + 294) == 0)
            {
                goto label_30;
            }
            
            var val_13 = (I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_32:
            if((((I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32 + 176 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < ((I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32 + 294))
            {
                goto label_32;
            }
            
            label_30:
            val_9 = 0;
            goto label_33;
            label_31:
            val_15 = val_15 + ((((I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32 + 176 + 8)) << 4);
            val_12 = val_15 + 304;
            label_33:
            val_10 = (I2.Loc.LocalizationManager.ParamManagers + 16 + 8) + 32;
            if((val_10.GetParameterValue(Param:  ParamName)) == null)
            {
                goto label_34;
            }
            
            return (string)val_10;
            label_24:
            val_10 = 0;
            return (string)val_10;
        }
        private static string GetPluralType(System.Text.RegularExpressions.MatchCollection matches, string langCode, I2.Loc.LocalizationManager._GetParam getParam)
        {
            string val_12;
            var val_13;
            var val_14;
            val_12 = langCode;
            int val_1 = matches.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_13 = 0;
            label_11:
            object val_6 = getParam.Invoke(param:  matches.Item[matches.Count - 1].Value);
            if(val_6 == null)
            {
                goto label_8;
            }
            
            if(null != null)
            {
                goto label_9;
            }
            
            if((System.Int32.TryParse(s:  val_6, result: out  0)) == true)
            {
                goto label_10;
            }
            
            label_8:
            val_13 = val_13 + 1;
            if(val_13 < val_1)
            {
                goto label_11;
            }
            
            label_2:
            val_14 = 0;
            return (string)val_14;
            label_10:
            I2.Loc.ePluralType val_9 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  val_12, n:  0);
            val_12 = val_9;
            val_14 = val_9.ToString();
            string val_11 = val_9.ToString();
            return (string)val_14;
            label_9:
        }
        public static string ApplyRTLfix(string line)
        {
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  line, maxCharacters:  0, ignoreNumbers:  true);
        }
        public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
        {
            int val_36;
            string val_37;
            string val_38;
            var val_39;
            var val_40;
            string val_41;
            var val_42;
            val_36 = ignoreNumbers;
            val_37 = line;
            if((System.String.IsNullOrEmpty(value:  val_37)) == true)
            {
                    return (string)val_42;
            }
            
            char val_2 = val_37.Chars[0];
            if((val_2 & 65535) <= ('?'))
            {
                    char val_4 = val_2 & 65535;
                val_4 = 1 << val_4;
                if((val_4 & ' ') == 0)
            {
                    val_38 = val_37.Substring(startIndex:  1)(val_37.Substring(startIndex:  1)) + val_2;
            }
            
            }
            
            int val_9 = 0;
            int val_8 = 0;
            if((I2.Loc.I2Utils.FindNextTag(line:  val_38, iStart:  0, tagStart: out  val_8, tagEnd: out  val_9)) != false)
            {
                    val_39 = 25535;
                val_40 = 1;
                do
            {
                val_41 = "@@" + 47805959 + "@@";
                new System.Collections.Generic.List<System.String>().Add(item:  val_38.Substring(startIndex:  0, length:  (val_40 - val_8) + val_9));
                string val_15 = val_38.Substring(startIndex:  0, length:  0);
                string val_17 = val_15 + val_41 + val_38.Substring(startIndex:  1)(val_38.Substring(startIndex:  1));
                val_38 = val_17;
            }
            while((I2.Loc.I2Utils.FindNextTag(line:  val_17, iStart:  5, tagStart: out  val_8, tagEnd: out  5)) == true);
            
            }
            
            var val_41 = ~val_36;
            val_42 = I2.Loc.RTLFixer.Fix(str:  I2.Loc.I2Utils.SplitLine(line:  val_38.Replace(oldValue:  "\r\n", newValue:  "\n"), maxCharacters:  maxCharacters), showTashkeel:  true, useHinduNumbers:  val_41 & 1);
            if(val_41 < 1)
            {
                    return (string)val_42;
            }
            
            val_40 = 39998;
            goto label_23;
            label_21:
            char val_24 = val_42.Chars[val_15];
            var val_25 = ((val_24 & '') != 0) ? (val_40) : 40000;
            val_25 = val_25 + val_24;
            val_41 = (val_25 < val_41) ? (val_25) : (val_41 - 1);
            if(val_41 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_41 = val_41 + (val_41 << 3);
            val_41 = mem[(~(ignoreNumbers) + (val_25 < ~val_36 ? ((val_24 & '')!=0 ? val_40 : 40000 + val_24) : (~(ignoreNumbers) - 1)) << 3) + 32];
            val_41 = (~(ignoreNumbers) + (val_25 < ~val_36 ? ((val_24 & '')!=0 ? val_40 : 40000 + val_24) : (~(ignoreNumbers) - 1)) << 3) + 32;
            val_42 = val_42.Substring(startIndex:  0, length:  maxCharacters)(val_42.Substring(startIndex:  0, length:  maxCharacters)) + val_41 + val_42.Substring(startIndex:  val_36)(val_42.Substring(startIndex:  val_36));
            goto label_16;
            label_23:
            if(val_23.m_stringLength < 1)
            {
                goto label_16;
            }
            
            label_22:
            val_41 = val_42.Chars[0] & 65535;
            val_41 = 5 - 4;
            if((((val_41 != '@') || ((val_42.Chars[val_41] & 65535) != '@')) || (((uint)((val_42.Chars[5 - 3]) >> 6) & 1023) < 625)) || (((val_42.Chars[5 - 2]) & 65535) != '@'))
            {
                goto label_20;
            }
            
            char val_40 = (val_42.Chars[5 - 1]) & 65535;
            if(val_40 == '@')
            {
                goto label_21;
            }
            
            label_20:
            val_36 = 5 + 1;
            if(val_41 < val_23.m_stringLength)
            {
                goto label_22;
            }
            
            label_16:
            val_39 = 0 + 1;
            if(val_39 < val_40)
            {
                goto label_23;
            }
            
            return (string)val_42;
        }
        public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = False)
        {
            null = null;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return (string)text;
            }
            
            ignoreNumber = ignoreNumber;
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  text, maxCharacters:  maxCharacters, ignoreNumbers:  ignoreNumber);
        }
        public static bool IsRTL(string Code)
        {
            null = null;
            int val_1 = System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.LanguagesRTL, value:  Code);
            val_1 = (val_1 >> 31) ^ 1;
            return (bool)val_1;
        }
        public static bool UpdateSources()
        {
            I2.Loc.LocalizationManager.UnregisterDeletededSources();
            I2.Loc.LocalizationManager.RegisterSourceInResources();
            I2.Loc.LocalizationManager.RegisterSceneSources();
            return (bool)((I2.Loc.LocalizationManager.Sources + 24) > 0) ? 1 : 0;
        }
        private static void UnregisterDeletededSources()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            if(<0)
            {
                    return;
            }
            
            val_6 = ((long)(I2.Loc.LocalizationManager.Sources + 24) - 1) + 4;
            val_7 = (I2.Loc.LocalizationManager.Sources + 24) - 2;
            goto label_5;
            label_15:
            val_5 = null;
            val_6 = val_6 - 1;
            val_7 = val_7 - 1;
            label_5:
            val_5 = null;
            var val_2 = val_6 - 4;
            if(val_2 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((I2.Loc.LocalizationManager.Sources + 16 + ((((long)(int)((I2.Loc.LocalizationManager.Sources + 24 - 1)) + 4) - 1)) << 3) == 0)
            {
                    val_8 = null;
                val_8 = null;
                if(val_2 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                I2.Loc.LocalizationManager.RemoveSource(Source:  I2.Loc.LocalizationManager.Sources + 16 + ((((long)(int)((I2.Loc.LocalizationManager.Sources + 24 - 1)) + 4) - 1)) << 3);
            }
            
            if((val_7 & 2147483648) == 0)
            {
                goto label_15;
            }
        
        }
        private static void RegisterSceneSources()
        {
            var val_5;
            var val_6;
            I2.Loc.LanguageSourceData val_7;
            UnityEngine.Object[] val_2 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_5 = null;
            if(X0 != false)
            {
                    if((X0 + 24) < 1)
            {
                    return;
            }
            
                do
            {
                val_6 = null;
                bool val_3 = X0 + 0;
                val_6 = null;
                if((I2.Loc.LocalizationManager.Sources.Contains(item:  (X0 + 0) + 32 + 24)) != true)
            {
                    val_7 = mem[(X0 + 0) + 32 + 24];
                val_7 = (X0 + 0) + 32 + 24;
                if(((X0 + 0) + 32 + 24 + 16) == 0)
            {
                    val_7 = (X0 + 0) + 32;
                val_7 = mem[(X0 + 0) + 32 + 24];
                val_7 = (X0 + 0) + 32 + 24;
            }
            
                I2.Loc.LocalizationManager.AddSource(Source:  val_7);
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < (X0 + 24));
            
                return;
            }
        
        }
        private static void RegisterSourceInResources()
        {
            UnityEngine.Object val_5;
            var val_6;
            var val_7;
            I2.Loc.LanguageSourceData val_8;
            val_6 = null;
            val_6 = null;
            int val_5 = I2.Loc.LocalizationManager.GlobalSources.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                val_5 = I2.Loc.ResourceManager.pInstance.GetAsset<I2.Loc.LanguageSourceAsset>(Name:  X23 + 0);
                if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
            {
                    val_7 = null;
                val_7 = null;
                if((I2.Loc.LocalizationManager.Sources.Contains(item:  val_2.mSource)) != true)
            {
                    val_8 = val_2.mSource;
                if(val_2.mSource.mIsGlobalSource != true)
            {
                    val_8 = 1;
                val_8 = val_2.mSource;
            }
            
                val_8 = val_5;
                val_5 = val_2.mSource;
                I2.Loc.LocalizationManager.AddSource(Source:  val_5);
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < (I2.Loc.LocalizationManager.GlobalSources.Length << ));
        
        }
        internal static void AddSource(I2.Loc.LanguageSourceData Source)
        {
            var val_8;
            var val_9;
            val_8 = null;
            val_8 = null;
            if((I2.Loc.LocalizationManager.Sources.Contains(item:  Source)) == true)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            I2.Loc.LocalizationManager.Sources.Add(item:  Source);
            if((Source.HasGoogleSpreadsheet() != false) && (Source.GoogleUpdateFrequency != 1))
            {
                    Source.Import_Google_FromCache();
                if(Source.GoogleUpdateDelay > 0f)
            {
                    UnityEngine.Coroutine val_4 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.LocalizationManager.Delayed_Import_Google(source:  Source, delay:  Source.GoogleUpdateDelay, justCheck:  false));
            }
            else
            {
                    Source.Import_Google(ForceUpdate:  false, justCheck:  false);
            }
            
            }
            
            if((System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  Source.mLanguages)) >= 1)
            {
                    var val_8 = 0;
                do
            {
                if(Source.GoogleUpdateFrequency <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                LanguageSourceData.eGoogleUpdateFrequency.__il2cppRuntimeField_byval_arg.SetLoaded(loaded:  true);
                val_8 = val_8 + 1;
            }
            while(val_8 < (System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  Source.mLanguages)));
            
            }
            
            if(Source.mDictionary.Count != 0)
            {
                    return;
            }
            
            Source.UpdateDictionary(force:  true);
        }
        private static System.Collections.IEnumerator Delayed_Import_Google(I2.Loc.LanguageSourceData source, float delay, bool justCheck)
        {
            .<>1__state = 0;
            .source = source;
            .delay = delay;
            .justCheck = justCheck;
            return (System.Collections.IEnumerator)new LocalizationManager.<Delayed_Import_Google>d__59();
        }
        internal static void RemoveSource(I2.Loc.LanguageSourceData Source)
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.Sources.Remove(item:  Source);
        }
        public static bool IsGlobalSource(string SourceName)
        {
            null = null;
            int val_1 = System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.GlobalSources, value:  SourceName);
            val_1 = (val_1 >> 31) ^ 1;
            return (bool)val_1;
        }
        public static I2.Loc.LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = True)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_10;
            if((System.String.IsNullOrEmpty(value:  term)) == true)
            {
                goto label_7;
            }
            
            val_3 = 1152921505149231104;
            val_4 = null;
            val_4 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_7;
            }
            
            val_5 = 4;
            goto label_6;
            label_13:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_7;
            }
            
            val_4 = null;
            val_5 = 5;
            label_6:
            val_4 = null;
            var val_2 = val_5 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((I2.Loc.LocalizationManager.Sources + 16 + 40.GetTermData(term:  term, allowCategoryMistmatch:  false)) == null)
            {
                goto label_13;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = I2.Loc.LocalizationManager.Sources;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40];
            val_8 = I2.Loc.LocalizationManager.Sources + 16 + 40;
            return (I2.Loc.LanguageSourceData)val_8;
            label_7:
            if(fallbackToFirst != false)
            {
                    val_7 = 1152921505149231104;
                val_9 = null;
                val_9 = null;
                val_10 = I2.Loc.LocalizationManager.Sources;
                if((I2.Loc.LocalizationManager.Sources + 24) >= 1)
            {
                    val_10 = I2.Loc.LocalizationManager.Sources;
                if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = mem[I2.Loc.LocalizationManager.Sources + 16 + 32];
                val_8 = I2.Loc.LocalizationManager.Sources + 16 + 32;
                return (I2.Loc.LanguageSourceData)val_8;
            }
            
            }
            
            val_8 = 0;
            return (I2.Loc.LanguageSourceData)val_8;
        }
        public static UnityEngine.Object FindAsset(string value)
        {
            var val_3;
            var val_4;
            UnityEngine.Object val_5;
            val_3 = null;
            val_3 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_6;
            }
            
            val_4 = 0;
            goto label_5;
            label_14:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_6;
            }
            
            val_3 = null;
            val_4 = 1;
            label_5:
            val_3 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = I2.Loc.LocalizationManager.Sources + 16;
            val_3 = val_3 + 8;
            val_5 = (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.FindAsset(Name:  value);
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                goto label_14;
            }
            
            return (UnityEngine.Object)val_5;
            label_6:
            val_5 = 0;
            return (UnityEngine.Object)val_5;
        }
        public static void ApplyDownloadedDataFromGoogle()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_5;
            label_11:
            val_1 = null;
            val_2 = 1;
            label_5:
            val_1 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = I2.Loc.LocalizationManager.Sources + 16;
            val_2 = val_2 + 8;
            (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.ApplyDownloadedDataFromGoogle();
            if((val_2 + 1) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_11;
            }
        
        }
        public static string GetCurrentDeviceLanguage(bool force = False)
        {
            var val_2;
            var val_3;
            if(force == true)
            {
                goto label_1;
            }
            
            val_2 = null;
            val_2 = null;
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) == false)
            {
                goto label_4;
            }
            
            label_1:
            I2.Loc.LocalizationManager.DetectDeviceLanguage();
            label_4:
            val_3 = null;
            val_3 = null;
            return (string)I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
        }
        private static void DetectDeviceLanguage()
        {
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_13 = "java/util/Locale";
            val_1 = new UnityEngine.AndroidJavaClass(className:  val_13);
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = "getDefault";
            UnityEngine.AndroidJavaObject val_2 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  val_13, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17 = null;
            val_17 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = val_2.Call<System.String>(methodName:  "toString", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) != true)
            {
                    val_18 = null;
                val_18 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.LocalizationManager.mCurrentDeviceLanguage.Replace(oldChar:  '_', newChar:  '-');
                val_19 = I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.GoogleLanguages.GetLanguageName(code:  val_19, useParenthesesForRegion:  true, allowDiscardRegion:  true);
                if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.SystemLanguage val_8 = UnityEngine.Application.systemLanguage;
            if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_19 = val_8.ToString();
            string val_10 = val_8.ToString();
            val_20 = null;
            val_20 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = val_19;
            val_21 = null;
            if((System.String.op_Equality(a:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage, b:  "ChineseSimplified")) != false)
            {
                    val_21 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Simplified)";
            }
            
            val_21 = null;
            if((System.String.op_Equality(a:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage, b:  "ChineseTraditional")) == false)
            {
                    return;
            }
            
            val_22 = null;
            val_22 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Traditional)";
        }
        public static void RegisterTarget(I2.Loc.ILocalizeTargetDescriptor desc)
        {
            var val_4;
            var val_5;
            var val_6;
            System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor> val_7;
            var val_8;
            .desc = desc;
            val_4 = null;
            val_4 = null;
            if((I2.Loc.LocalizationManager.mLocalizeTargets.FindIndex(match:  new System.Predicate<I2.Loc.ILocalizeTargetDescriptor>(object:  new LocalizationManager.<>c__DisplayClass69_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass69_0::<RegisterTarget>b__0(I2.Loc.ILocalizeTargetDescriptor x)))) != 1)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_6;
            label_17:
            if((I2.Loc.LocalizationManager.mLocalizeTargets + 24) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = I2.Loc.LocalizationManager.mLocalizeTargets + 16;
            val_4 = val_4 + 0;
            if(((I2.Loc.LocalizationManager.mLocalizeTargets + 16 + 0) + 32 + 24) > ((LocalizationManager.<>c__DisplayClass69_0)[1152921528774379888].desc.Priority))
            {
                goto label_13;
            }
            
            val_5 = 1;
            label_6:
            val_6 = null;
            val_6 = null;
            val_7 = I2.Loc.LocalizationManager.mLocalizeTargets;
            if(val_5 < (I2.Loc.LocalizationManager.mLocalizeTargets + 24))
            {
                goto label_17;
            }
            
            val_7 = I2.Loc.LocalizationManager.mLocalizeTargets;
            val_7.Add(item:  (LocalizationManager.<>c__DisplayClass69_0)[1152921528774379888].desc);
            return;
            label_13:
            val_8 = null;
            val_8 = null;
            I2.Loc.LocalizationManager.mLocalizeTargets.Insert(index:  0, item:  (LocalizationManager.<>c__DisplayClass69_0)[1152921528774379888].desc);
        }
        public static void add_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            do
            {
                if((System.Delegate.Combine(a:  I2.Loc.LocalizationManager.OnLocalizeEvent, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
                val_3 = null;
                val_3 = null;
            }
            while(I2.Loc.LocalizationManager.OnLocalizeEvent != 1152921505149235280);
            
            return;
            label_4:
        }
        public static void remove_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            do
            {
                if((System.Delegate.Remove(source:  I2.Loc.LocalizationManager.OnLocalizeEvent, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
                val_3 = null;
                val_3 = null;
            }
            while(I2.Loc.LocalizationManager.OnLocalizeEvent != 1152921505149235280);
            
            return;
            label_4:
        }
        public static string GetTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            string val_4 = 0;
            bool val_5 = I2.Loc.LocalizationManager.TryGetTranslation(Term:  Term, Translation: out  val_4, FixForRTL:  FixForRTL, maxLineLengthForRTL:  maxLineLengthForRTL, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot, overrideLanguage:  overrideLanguage);
            return val_4;
        }
        public static string GetTermTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            FixForRTL = FixForRTL;
            ignoreRTLnumbers = ignoreRTLnumbers;
            applyParameters = applyParameters;
            return I2.Loc.LocalizationManager.GetTranslation(Term:  Term, FixForRTL:  FixForRTL, maxLineLengthForRTL:  maxLineLengthForRTL, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot, overrideLanguage:  overrideLanguage);
        }
        public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            bool val_6;
            int val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = ignoreRTLnumbers;
            val_7 = maxLineLengthForRTL;
            Translation = 0;
            if((System.String.IsNullOrEmpty(value:  Term)) == true)
            {
                goto label_7;
            }
            
            val_6 = 1152921505149231104;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_8 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_7;
            }
            
            val_9 = 0;
            goto label_6;
            label_13:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_7;
            }
            
            val_8 = null;
            val_9 = 1;
            label_6:
            val_8 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = I2.Loc.LocalizationManager.Sources + 16;
            val_6 = val_6 + 8;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.TryGetTranslation(term:  Term, Translation: out  string val_2 = Translation, overrideLanguage:  overrideLanguage, overrideSpecialization:  0, skipDisabled:  false, allowCategoryMistmatch:  false)) == false)
            {
                goto label_13;
            }
            
            if(applyParameters != false)
            {
                    I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_2, root:  localParametersRoot, allowLocalizedParameters:  true);
            }
            
            val_10 = null;
            val_10 = null;
            val_7 = val_6;
            val_11 = 1;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return (bool)val_11;
            }
            
            if(FixForRTL == false)
            {
                    return (bool)val_11;
            }
            
            val_11 = 1;
            Translation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  Translation, maxCharacters:  val_7, ignoreNumbers:  val_7);
            return (bool)val_11;
            label_7:
            val_11 = 0;
            return (bool)val_11;
        }
        public static T GetTranslatedObject<T>(string AssetName, I2.Loc.Localize optionalLocComp)
        {
            UnityEngine.Object val_5;
            var val_6;
            val_5 = optionalLocComp;
            if(val_5 == 0)
            {
                goto label_3;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 48];
            val_6 = __RuntimeMethodHiddenParam + 48;
            goto __RuntimeMethodHiddenParam + 48 + 16;
            label_3:
            UnityEngine.Object val_2 = I2.Loc.LocalizationManager.FindAsset(value:  AssetName);
            if(X0 == false)
            {
                goto label_10;
            }
            
            val_5 = X0;
            if(X0 == true)
            {
                goto label_11;
            }
            
            label_10:
            val_5 = 0;
            label_11:
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
            {
                    return (object)val_5;
            }
            
            I2.Loc.ResourceManager val_4 = I2.Loc.ResourceManager.pInstance;
            val_6 = mem[__RuntimeMethodHiddenParam + 48 + 16];
            val_6 = __RuntimeMethodHiddenParam + 48 + 16;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        public static T GetTranslatedObjectByTermName<T>(string Term, I2.Loc.Localize optionalLocComp)
        {
            string val_1 = I2.Loc.LocalizationManager.GetTranslation(Term:  Term, FixForRTL:  false, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0);
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static string GetAppName(string languageCode)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_10;
            var val_11;
            if((System.String.IsNullOrEmpty(value:  languageCode)) == true)
            {
                    return UnityEngine.Application.productName;
            }
            
            val_7 = 0;
            goto label_2;
            label_28:
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = I2.Loc.LocalizationManager.Sources + 16;
            val_7 = val_7 + 0;
            if((System.String.IsNullOrEmpty(value:  (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 64)) != true)
            {
                    val_8 = null;
                val_8 = null;
                if((I2.Loc.LocalizationManager.Sources + 24) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_8 = I2.Loc.LocalizationManager.Sources + 16;
                val_8 = val_8 + 0;
                int val_3 = (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32.GetLanguageIndexFromCode(Code:  languageCode, exactMatch:  false, ignoreDisabled:  false);
                if((val_3 & 2147483648) == 0)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = I2.Loc.LocalizationManager.Sources;
                if((I2.Loc.LocalizationManager.Sources + 24) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_10 = I2.Loc.LocalizationManager.Sources;
            }
            
                var val_9 = I2.Loc.LocalizationManager.Sources + 16;
                val_9 = val_9 + 0;
                if((I2.Loc.LocalizationManager.Sources + 24) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_10 = I2.Loc.LocalizationManager.Sources + 16;
                val_10 = val_10 + 0;
                I2.Loc.TermData val_4 = (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32.GetTermData(term:  (I2.Loc.LocalizationManager.Sources + 16 + 0) + 32 + 64, allowCategoryMistmatch:  false);
                if(val_4 != null)
            {
                    string val_5 = val_4.GetTranslation(idx:  val_3, specialization:  0, editMode:  false);
                if((System.String.IsNullOrEmpty(value:  val_5)) == false)
            {
                    return val_5;
            }
            
            }
            
            }
            
            }
            
            val_7 = 1;
            label_2:
            val_11 = null;
            val_11 = null;
            if(val_7 < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_28;
            }
            
            return UnityEngine.Application.productName;
        }
        public static void LocalizeAll(bool Force = False)
        {
            var val_7;
            I2.Loc.LocalizationManager.LoadCurrentLanguage();
            val_7 = null;
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_3;
            }
            
            val_7 = null;
            bool val_2 = (I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue == true) ? 1 : 0;
            val_2 = val_2 | Force;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = val_2;
            if(I2.Loc.LocalizationManager.mLocalizeIsScheduled == false)
            {
                goto label_6;
            }
            
            return;
            label_3:
            I2.Loc.LocalizationManager.DoLocalizeAll(Force:  Force);
            return;
            label_6:
            UnityEngine.Coroutine val_6 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.LocalizationManager.Coroutine_LocalizeAll());
        }
        private static System.Collections.IEnumerator Coroutine_LocalizeAll()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new LocalizationManager.<Coroutine_LocalizeAll>d__84();
        }
        private static void DoLocalizeAll(bool Force = False)
        {
            var val_5;
            OnLocalizeCallback val_6;
            UnityEngine.Object[] val_2 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(X0 == false)
            {
                goto label_4;
            }
            
            if((X0 + 24) < 1)
            {
                goto label_8;
            }
            
            var val_5 = 0;
            label_9:
            bool val_4 = X0 + 0;
            (X0 + 0) + 32.OnLocalize(Force:  Force);
            val_5 = val_5 + 1;
            if(val_5 >= (X0 + 24))
            {
                goto label_8;
            }
            
            if(val_5 < (X0 + 24))
            {
                goto label_9;
            }
            
            throw new IndexOutOfRangeException();
            label_8:
            val_5 = null;
            val_5 = null;
            val_6 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            if(val_6 == null)
            {
                    return;
            }
            
            val_6 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            val_6.Invoke();
            return;
            label_4:
        }
        public static System.Collections.Generic.List<string> GetCategories()
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_3 = null;
            val_3 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return val_1;
            }
            
            val_4 = 0;
            goto label_5;
            label_11:
            val_3 = null;
            val_4 = 1;
            label_5:
            val_3 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = I2.Loc.LocalizationManager.Sources + 16;
            val_4 = val_4 + 8;
            System.Collections.Generic.List<System.String> val_2 = (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetCategories(OnlyMainCategory:  false, Categories:  val_1);
            if((val_4 + 1) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_11;
            }
            
            return val_1;
        }
        public static System.Collections.Generic.List<string> GetTermsList(string Category)
        {
            var val_5;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    bool val_1 = I2.Loc.LocalizationManager.UpdateSources();
                val_5 = null;
            }
            
            val_5 = null;
            val_6 = I2.Loc.LocalizationManager.Sources;
            if((I2.Loc.LocalizationManager.Sources + 24) == 1)
            {
                    val_6 = I2.Loc.LocalizationManager.Sources;
                if((I2.Loc.LocalizationManager.Sources + 24) != 0)
            {
                    return I2.Loc.LocalizationManager.Sources + 16 + 32.GetTermsList(Category:  Category);
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                return I2.Loc.LocalizationManager.Sources + 16 + 32.GetTermsList(Category:  Category);
            }
            
            System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>();
            val_7 = null;
            val_7 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_2);
            }
            
            val_8 = 0;
            goto label_20;
            label_27:
            val_7 = null;
            val_8 = 1;
            label_20:
            val_7 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = I2.Loc.LocalizationManager.Sources + 16;
            val_6 = val_6 + 8;
            val_2.UnionWith(other:  (I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetTermsList(Category:  Category));
            if((val_8 + 1) < (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_27;
            }
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_2);
        }
        public static I2.Loc.TermData GetTermData(string term)
        {
            var val_2;
            var val_3;
            var val_4;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_2 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_6;
            }
            
            val_3 = 0;
            goto label_5;
            label_12:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_6;
            }
            
            val_2 = null;
            val_3 = 1;
            label_5:
            val_2 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = I2.Loc.LocalizationManager.Sources + 16;
            val_2 = val_2 + 8;
            if(((I2.Loc.LocalizationManager.Sources + 16 + 8) + 32.GetTermData(term:  term, allowCategoryMistmatch:  false)) == null)
            {
                goto label_12;
            }
            
            return (I2.Loc.TermData)val_4;
            label_6:
            val_4 = 0;
            return (I2.Loc.TermData)val_4;
        }
        public static I2.Loc.TermData GetTermData(string term, out I2.Loc.LanguageSourceData source)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            I2.Loc.LanguageSourceData val_6;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_2 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) < 1)
            {
                goto label_6;
            }
            
            val_3 = 4;
            goto label_5;
            label_12:
            if(1 >= (I2.Loc.LocalizationManager.Sources + 24))
            {
                goto label_6;
            }
            
            val_2 = null;
            val_3 = 5;
            label_5:
            val_2 = null;
            var val_1 = val_3 - 4;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            I2.Loc.TermData val_2 = I2.Loc.LocalizationManager.Sources + 16 + 40.GetTermData(term:  term, allowCategoryMistmatch:  false);
            if(val_2 == null)
            {
                goto label_12;
            }
            
            val_4 = val_2;
            val_5 = null;
            val_5 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = mem[I2.Loc.LocalizationManager.Sources + 16 + 40];
            val_6 = I2.Loc.LocalizationManager.Sources + 16 + 40;
            goto label_17;
            label_6:
            val_6 = 0;
            val_4 = 0;
            label_17:
            source = val_6;
            return (I2.Loc.TermData)val_4;
        }
        private static LocalizationManager()
        {
            int val_6;
            I2.Loc.LocalizationManager.mChangeCultureInfo = false;
            I2.Loc.LocalizationManager.IsRight2Left = false;
            I2.Loc.LocalizationManager.HasJoinedWords = false;
            I2.Loc.LocalizationManager.ParamManagers = new System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager>();
            string[] val_2 = new string[21];
            val_6 = val_2.Length;
            val_2[0] = "ar-DZ";
            val_6 = val_6;
            val_2[1] = "ar";
            val_6 = val_6;
            val_2[2] = "ar-BH";
            val_6 = val_6;
            val_2[3] = "ar-EG";
            val_6 = val_6;
            val_2[4] = "ar-IQ";
            val_6 = val_6;
            val_2[5] = "ar-JO";
            val_6 = val_6;
            val_2[6] = "ar-KW";
            val_6 = val_6;
            val_2[7] = "ar-LB";
            val_6 = val_6;
            val_2[8] = "ar-LY";
            val_6 = val_6;
            val_2[9] = "ar-MA";
            val_6 = val_6;
            val_2[10] = "ar-OM";
            val_6 = val_6;
            val_2[11] = "ar-QA";
            val_6 = val_6;
            val_2[12] = "ar-SA";
            val_6 = val_6;
            val_2[13] = "ar-SY";
            val_6 = val_6;
            val_2[14] = "ar-TN";
            val_6 = val_6;
            val_2[15] = "ar-AE";
            val_6 = val_6;
            val_2[16] = "ar-YE";
            val_6 = val_6;
            val_2[17] = "fa";
            val_6 = val_6;
            val_2[18] = "he";
            val_6 = val_6;
            val_2[19] = "ur";
            val_6 = val_6;
            val_2[20] = "ji";
            I2.Loc.LocalizationManager.LanguagesRTL = val_2;
            I2.Loc.LocalizationManager.Sources = new System.Collections.Generic.List<I2.Loc.LanguageSourceData>();
            string[] val_4 = new string[1];
            val_4[0] = "I2Languages";
            I2.Loc.LocalizationManager.GlobalSources = val_4;
            I2.Loc.LocalizationManager.mLocalizeTargets = new System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor>();
            I2.Loc.LocalizationManager.mLocalizeIsScheduled = false;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = false;
            I2.Loc.LocalizationManager.HighlightLocalizedTargets = false;
        }
    
    }

}
