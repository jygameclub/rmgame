using UnityEngine;

namespace Royal.Infrastructure.Utils.BadWords
{
    public class BadWordsFilter
    {
        // Fields
        public static sbyte BadWordsFilterVersion;
        private static System.Text.RegularExpressions.Regex EnglishRegex;
        private static System.Text.RegularExpressions.Regex PhoneLanguageRegex;
        private static readonly string PhoneLanguage;
        
        // Methods
        private static BadWordsFilter()
        {
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguage = I2.Loc.LocalizationManager.CurrentLanguage;
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "BadWordsFilterVersion", defaultValue:  0);
            string val_4 = 10.ToString();
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.EnglishRegex = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.CreateRegexInstance(regexText:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  Royal.Infrastructure.Services.Storage.Tables.TableConstants.GetBadWordsKeyForLanguage(language:  10.ToString()), defaultValue:  0));
            if((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsLanguageEnglish(language:  Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguage)) == true)
            {
                    return;
            }
            
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguageRegex = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.CreateRegexInstance(regexText:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  Royal.Infrastructure.Services.Storage.Tables.TableConstants.GetBadWordsKeyForLanguage(language:  Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguage), defaultValue:  0));
        }
        public static bool IsBadWord(string text)
        {
            var val_8;
            System.Text.RegularExpressions.Regex val_9;
            System.Type val_10;
            System.Object[] val_11;
            string val_12;
            System.Text.RegularExpressions.Regex val_13;
            var val_14;
            int val_15;
            var val_16;
            if((System.String.IsNullOrEmpty(value:  text)) == true)
            {
                goto label_22;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.EnglishRegex;
            if(val_9 == null)
            {
                goto label_4;
            }
            
            val_9 = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.EnglishRegex;
            if((val_9.IsMatch(input:  text)) == false)
            {
                goto label_8;
            }
            
            val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_11 = new object[1];
            val_11[0] = text;
            val_12 = "English bad word detected: {0}";
            goto label_15;
            label_8:
            val_8 = null;
            label_4:
            val_8 = null;
            val_13 = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguageRegex;
            if(val_13 == null)
            {
                goto label_22;
            }
            
            val_13 = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguageRegex;
            if((val_13.IsMatch(input:  text)) == false)
            {
                goto label_22;
            }
            
            val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object[] val_7 = new object[2];
            val_14 = null;
            val_11 = val_7;
            val_14 = null;
            val_15 = val_7.Length;
            val_11[0] = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguage;
            if(text != null)
            {
                    val_15 = val_7.Length;
            }
            
            val_11[1] = text;
            val_12 = "{0} bad word detected: {1}";
            label_15:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  val_10, logTag:  20, log:  val_12, values:  val_7);
            val_16 = 1;
            return (bool)val_16;
            label_22:
            val_16 = 0;
            return (bool)val_16;
        }
        public static void UpdateBadWordsRegex(string language, string regex)
        {
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  Royal.Infrastructure.Services.Storage.Tables.TableConstants.GetBadWordsKeyForLanguage(language:  language), value:  regex);
            if((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsLanguageEnglish(language:  language)) != false)
            {
                    Royal.Infrastructure.Utils.BadWords.BadWordsFilter.EnglishRegex = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.CreateRegexInstance(regexText:  regex);
                return;
            }
            
            if((language.Equals(value:  Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguage)) == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.PhoneLanguageRegex = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.CreateRegexInstance(regexText:  regex);
        }
        private static bool IsLanguageEnglish(string language)
        {
            string val_2 = 10.ToString();
            return (bool)language.Equals(value:  10.ToString());
        }
        private static System.Text.RegularExpressions.Regex CreateRegexInstance(string regexText)
        {
            if((System.String.IsNullOrEmpty(value:  regexText)) == true)
            {
                    return (System.Text.RegularExpressions.Regex)0;
            }
            
            System.Text.RegularExpressions.Regex val_2 = null;
            0 = val_2;
            val_2 = new System.Text.RegularExpressions.Regex(pattern:  regexText, options:  9);
            return (System.Text.RegularExpressions.Regex)0;
        }
        public static void UpdateBadWordsFilterVersion(sbyte newVersion)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if(Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion == newVersion)
            {
                    return;
            }
            
            object[] val_2 = new object[2];
            val_5 = null;
            val_5 = null;
            val_2[0] = Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion;
            val_2[1] = newVersion;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  20, log:  "BadWords: {0} -> {1}", values:  val_2);
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion = newVersion;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "BadWordsFilterVersion", value:  Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion);
        }
        public BadWordsFilter()
        {
        
        }
    
    }

}
