using UnityEngine;

namespace Royal.Infrastructure.Services.Localization
{
    public static class LocalizationHelper
    {
        // Fields
        public static bool isJapanese;
        public static bool isKorean;
        public static bool isArabic;
        public static bool isFrench;
        public static bool isSpanish;
        public static bool isRussian;
        public static bool isItalian;
        public static bool isPortuguese;
        public static bool isTurkish;
        public static bool isGerman;
        
        // Methods
        public static void Initialize()
        {
            string val_48;
            string val_49;
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;
            I2.Loc.LocalizationManager.CurrentLanguage = Royal.Infrastructure.Services.Localization.LocalizationHelper.SelectLanguageAuto();
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 10.ToString();
            string val_6 = 10.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) == true)
            {
                    return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 34.ToString();
            string val_10 = 34.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 21.ToString();
            string val_14 = 21.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isItalian = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 14.ToString();
            string val_18 = 14.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isFrench = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 37.ToString();
            string val_22 = 37.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 15.ToString();
            string val_26 = 15.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 28.ToString();
            string val_30 = 28.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isPortuguese = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 30.ToString();
            string val_34 = 30.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 22.ToString();
            string val_38 = 22.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 23.ToString();
            string val_42 = 23.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) != false)
            {
                    Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean = true;
                return;
            }
            
            val_48 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_49 = 1.ToString();
            string val_46 = 1.ToString();
            if((System.String.op_Equality(a:  val_48, b:  val_49)) == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic = true;
        }
        public static string SelectLanguageAuto()
        {
            var val_9;
            UnityEngine.SystemLanguage val_1 = UnityEngine.Application.systemLanguage;
            string val_3 = val_1.ToString();
            if((I2.Loc.LocalizationManager.HasLanguage(Language:  val_1.ToString(), AllowDiscartingRegion:  true, Initialize:  true, SkipDisabled:  true)) != false)
            {
                    UnityEngine.SystemLanguage val_5 = UnityEngine.Application.systemLanguage;
                val_9 = null;
            }
            else
            {
                    val_9 = null;
            }
            
            string val_7 = 10.ToString();
            return (string)10.ToString();
        }
        public static string AddTextToEnd(string value, int level)
        {
            object val_2;
            object val_3;
            object val_4;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    val_3 = " ";
                val_4 = value;
                return (string)val_2 + val_3 + level;
            }
            
            val_3 = " ";
            val_4 = level;
            val_2 = value;
            return (string)val_2 + val_3 + level;
        }
    
    }

}
