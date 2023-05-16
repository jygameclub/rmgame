using UnityEngine;

namespace I2.Loc
{
    public static class GoogleLanguages
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, I2.Loc.GoogleLanguages.LanguageCodeDef> mLanguageDef;
        
        // Methods
        public static string GetLanguageCode(string Filter, bool ShowWarnings = False)
        {
            System.String[] val_8;
            string val_9;
            var val_10;
            int val_11;
            val_9 = Filter;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                goto label_13;
            }
            
            val_8 = val_9.ToLowerInvariant().Split(separator:  ToCharArray());
            val_10 = null;
            val_10 = null;
            Dictionary.Enumerator<TKey, TValue> val_5 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_11:
            if(((-1651955336) & 1) == 0)
            {
                goto label_8;
            }
            
            val_11 = 0;
            if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  0, Filters:  val_8)) == false)
            {
                goto label_11;
            }
            
            0.Dispose();
            return (string)val_11;
            label_8:
            0.Dispose();
            if(ShowWarnings != false)
            {
                    val_9 = System.String.Format(format:  "Language \'{0}\' not recognized. Please, add the language code to GoogleTranslation.cs", arg0:  val_9);
                UnityEngine.Debug.Log(message:  val_9);
            }
            
            label_13:
            val_11 = System.String.alignConst;
            return (string)val_11;
        }
        public static System.Collections.Generic.List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
        {
            string val_8;
            var val_9;
            string val_23;
            System.Collections.Generic.Dictionary<System.String, LanguageCodeDef> val_24;
            var val_25;
            var val_26;
            var val_28;
            val_23 = Filter;
            val_24 = 17744;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            string val_1 = val_23.ToLowerInvariant();
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            val_25 = null;
            val_25 = null;
            val_24 = I2.Loc.GoogleLanguages.mLanguageDef;
            if(val_24 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = val_24.GetEnumerator();
            val_26 = 1152921528724678192;
            label_19:
            if(((-1651636416) & 1) == 0)
            {
                goto label_7;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_23)) != true)
            {
                    if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  val_8, Filters:  val_1.Split(separator:  ToCharArray()))) == false)
            {
                goto label_19;
            }
            
            }
            
            string[] val_12 = new string[1];
            if(val_12 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_12[0] = "[" + val_8 + "]";
            string val_14 = +val_12;
            if(CodesToExclude == null)
            {
                    throw new NullReferenceException();
            }
            
            if((CodesToExclude.Contains(value:  val_14)) == true)
            {
                goto label_19;
            }
            
            val_4.Add(item:  val_8 + " " + val_14);
            goto label_19;
            label_7:
            val_9.Dispose();
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(<0)
            {
                    return val_4;
            }
            
            val_28 = 0;
            val_26 = 47792166;
            goto label_22;
            label_31:
            val_28 = -1;
            label_22:
            if(1152921511193296640 <= 47792133)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = mem[95584292];
            if(1152921511193296640 <= 47792133)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_24 = mem[95584294];
            }
            
            if(val_24 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(mem[95584292] == 0)
            {
                    throw new NullReferenceException();
            }
            
            string val_18 = mem[95584292].Substring(startIndex:  0, length:  val_24.IndexOf(value:  " ["));
            val_23 = 47792134;
            if(" [" <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = mem[430248432];
            if(val_24 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_24.StartsWith(value:  val_18)) != false)
            {
                    if(430248400 <= 47792133)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4.set_Item(index:  47792133, value:  val_18 + "/"("/") + mem[478040558]);
                val_4.Insert(index:  47792134, item:  val_18 + "/"("/"));
            }
            
            if(47792133 >= 0)
            {
                goto label_31;
            }
            
            return val_4;
        }
        private static bool LanguageMatchesFilter(string Language, string[] Filters)
        {
            var val_7;
            var val_8;
            string val_1 = Language.ToLowerInvariant();
            int val_7 = Filters.Length;
            if(val_7 < 1)
            {
                goto label_13;
            }
            
            val_7 = val_7 & 4294967295;
            val_7 = 0;
            label_14:
            if((System.String.op_Inequality(a:  null, b:  "")) == false)
            {
                goto label_5;
            }
            
            if((val_1.Contains(value:  1152921505165333712.ToLower())) == false)
            {
                goto label_9;
            }
            
            string val_6 = val_1.Remove(startIndex:  val_1.IndexOf(value:  null), count:  System.String[].__il2cppRuntimeField_name);
            label_5:
            val_7 = val_7 + 1;
            if(val_7 >= (long)val_7)
            {
                goto label_13;
            }
            
            if(val_7 < Filters.Length)
            {
                goto label_14;
            }
            
            throw new IndexOutOfRangeException();
            label_13:
            val_8 = 1;
            return (bool)val_8;
            label_9:
            val_8 = 0;
            return (bool)val_8;
        }
        public static string GetFormatedLanguageName(string Language)
        {
            string val_8;
            var val_9;
            val_8 = Language;
            int val_1 = val_8.IndexOf(value:  " [");
            if(val_1 >= 1)
            {
                    val_8 = val_8.Substring(startIndex:  0, length:  val_1);
            }
            
            int val_3 = val_8.IndexOf(value:  '/');
            if(val_3 >= 1)
            {
                    string val_4 = val_8.Substring(startIndex:  0, length:  val_3);
                val_9 = val_4;
                if((System.String.op_Equality(a:  val_8, b:  val_4 + "/"("/") + val_4)) == true)
            {
                    return (string)val_9;
            }
            
                return val_8.Replace(oldValue:  "/", newValue:  " (")(val_8.Replace(oldValue:  "/", newValue:  " (")) + ")";
            }
            
            val_9 = val_8;
            return (string)val_9;
        }
        public static string GetCodedLanguage(string Language, string code)
        {
            if((System.String.Compare(strA:  code, strB:  I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  Language, ShowWarnings:  false), comparisonType:  5)) == 0)
            {
                    return (string)Language;
            }
            
            return Language + " [" + code + "]";
        }
        public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
        {
            int val_9;
            if((System.String.IsNullOrEmpty(value:  CodedLanguage)) != false)
            {
                    Language = System.String.alignConst;
                val_9 = System.String.alignConst;
            }
            else
            {
                    int val_2 = CodedLanguage.IndexOf(value:  "[");
                if((val_2 & 2147483648) == 0)
            {
                    Language = CodedLanguage.Substring(startIndex:  0, length:  val_2).Trim();
                int val_9 = val_2;
                val_9 = (CodedLanguage.IndexOf(value:  "]", startIndex:  val_9)) + (~val_2);
                string val_7 = CodedLanguage.Substring(startIndex:  val_2 + 1, length:  val_9);
            }
            else
            {
                    Language = CodedLanguage;
            }
            
            }
            
            code = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  CodedLanguage, ShowWarnings:  false);
        }
        public static string GetGoogleLanguageCode(string InternationalCode)
        {
            string val_6;
            var val_7;
            val_6 = InternationalCode;
            val_7 = null;
            val_7 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_5:
            if(((-1650724344) & 1) == 0)
            {
                goto label_7;
            }
            
            if((System.String.op_Equality(a:  val_6, b:  0)) == false)
            {
                goto label_5;
            }
            
            if((System.String.op_Equality(a:  0, b:  "-")) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    var val_5 = ((System.String.IsNullOrEmpty(value:  0)) != true) ? (val_6) : 0;
            }
            
            label_7:
            0.Dispose();
            return (string)val_5;
        }
        public static string GetLanguageName(string code, bool useParenthesesForRegion = False, bool allowDiscardRegion = True)
        {
            string val_4;
            var val_5;
            var val_17;
            var val_18;
            System.Collections.Generic.Dictionary<System.String, LanguageCodeDef> val_19;
            var val_20;
            var val_22;
            val_18 = null;
            val_18 = null;
            val_19 = I2.Loc.GoogleLanguages.mLanguageDef;
            if(val_19 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = val_19.GetEnumerator();
            label_5:
            if(((-1650587808) & 1) == 0)
            {
                goto label_4;
            }
            
            val_17 = val_4;
            if((System.String.op_Equality(a:  code, b:  val_4)) == false)
            {
                goto label_5;
            }
            
            if(useParenthesesForRegion != false)
            {
                    int val_7 = val_17.IndexOf(value:  '/');
                if(val_7 >= 1)
            {
                    val_17 = val_17.Substring(startIndex:  0, length:  val_7)(val_17.Substring(startIndex:  0, length:  val_7)) + " (" + val_17.Substring(startIndex:  val_7 + 1)(val_17.Substring(startIndex:  val_7 + 1)) + ")";
            }
            
            }
            
            val_20 = 1;
            goto label_9;
            label_4:
            val_20 = 0;
            val_17 = 0;
            label_9:
            val_5.Dispose();
            var val_12 = (val_20 != 0) ? (val_17) : 0;
            if((val_20 & 1) != 0)
            {
                    return (string)val_22;
            }
            
            if(allowDiscardRegion == false)
            {
                    return (string)val_22;
            }
            
            if(code == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_13 = code.IndexOf(value:  "-");
            if(val_13 >= 1)
            {
                    bool val_15 = useParenthesesForRegion;
                val_22 = code.Substring(startIndex:  0, length:  val_13);
                return (string)val_22;
            }
            
            val_22 = 0;
            return (string)val_22;
        }
        public static System.Collections.Generic.List<string> GetAllInternationalCodes()
        {
            var val_5;
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            val_5 = null;
            val_5 = null;
            Dictionary.Enumerator<TKey, TValue> val_2 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_6:
            if(((-1650447096) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            bool val_3 = val_1.Add(item:  0);
            goto label_6;
            label_4:
            0.Dispose();
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_1);
        }
        public static bool LanguageCode_HasJoinedWord(string languageCode)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_6:
            if(((-1650322808) & 1) != 0)
            {
                    if((System.String.op_Equality(a:  languageCode, b:  0)) != true)
            {
                    if((System.String.op_Equality(a:  languageCode, b:  0)) == false)
            {
                goto label_6;
            }
            
            }
            
                var val_4 = (0 != 0) ? 1 : 0;
                val_7 = 1;
            }
            else
            {
                    val_7 = 0;
                val_6 = 0;
            }
            
            0.Dispose();
            return (bool)val_7 & val_6;
        }
        private static int GetPluralRule(string langCode)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = langCode;
            if(langCode.m_stringLength >= 3)
            {
                    val_5 = val_5.Substring(startIndex:  0, length:  2);
            }
            
            val_6 = null;
            val_6 = null;
            Dictionary.Enumerator<TKey, TValue> val_3 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_8:
            if(((-1650194424) & 1) == 0)
            {
                goto label_7;
            }
            
            val_7 = 0;
            if((System.String.op_Equality(a:  0, b:  val_5.ToLower())) == false)
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            val_7 = 0;
            label_9:
            0.Dispose();
            return (int)val_7;
        }
        public static bool LanguageHasPluralType(string langCode, string pluralType)
        {
            if((System.String.op_Equality(a:  pluralType, b:  "Plural")) == true)
            {
                    return true;
            }
            
            if((System.String.op_Equality(a:  pluralType, b:  "Zero")) == true)
            {
                    return true;
            }
            
            if((System.String.op_Equality(a:  pluralType, b:  "One")) != false)
            {
                    return true;
            }
            
            if(((I2.Loc.GoogleLanguages.GetPluralRule(langCode:  langCode)) - 3) > 13)
            {
                    return true;
            }
            
            var val_6 = 36621504 + ((val_4 - 3)) << 2;
            val_6 = val_6 + 36621504;
            goto (36621504 + ((val_4 - 3)) << 2 + 36621504);
        }
        public static I2.Loc.ePluralType GetPluralType(string langCode, int n)
        {
            var val_19;
            var val_20;
            var val_21;
            val_19 = n;
            if(val_19 == 0)
            {
                goto label_71;
            }
            
            if(val_19 != 1)
            {
                goto label_2;
            }
            
            val_20 = 1;
            goto label_80;
            label_2:
            if(((I2.Loc.GoogleLanguages.GetPluralRule(langCode:  langCode)) - 2) > 14)
            {
                goto label_36;
            }
            
            var val_21 = 36621560 + ((val_1 - 2)) << 2;
            val_21 = val_21 + 36621560;
            goto (36621560 + ((val_1 - 2)) << 2 + 36621560);
            label_36:
            val_20 = 5;
            goto label_80;
            label_71:
            val_20 = val_19;
            do
            {
                label_80:
                val_21 = val_20;
                return (I2.Loc.ePluralType)val_21;
            }
            while(0 < 2);
            
            var val_19 = ((-10) > 9) ? 3 : 5;
            return (I2.Loc.ePluralType)val_21;
        }
        public static int GetPluralTestNumber(string langCode, I2.Loc.ePluralType pluralType)
        {
            if(pluralType > 4)
            {
                    return 936;
            }
            
            var val_1 = 36621656 + (pluralType) << 2;
            val_1 = val_1 + 36621656;
            goto (36621656 + (pluralType) << 2 + 36621656);
        }
        private static bool inRange(int amount, int min, int max)
        {
            amount = ((amount >= min) ? 1 : 0) & ((amount <= max) ? 1 : 0);
            return (bool)amount;
        }
        private static GoogleLanguages()
        {
            System.Collections.Generic.Dictionary<System.String, LanguageCodeDef> val_1 = new System.Collections.Generic.Dictionary<System.String, LanguageCodeDef>(comparer:  System.StringComparer._ordinal);
            val_1.Add(key:  "Abkhazian", value:  new LanguageCodeDef() {Code = "ab", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Afar", value:  new LanguageCodeDef() {Code = "aa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Afrikaans", value:  new LanguageCodeDef() {Code = "af", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Akan", value:  new LanguageCodeDef() {Code = "ak", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Albanian", value:  new LanguageCodeDef() {Code = "sq", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Amharic", value:  new LanguageCodeDef() {Code = "am", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Arabic", value:  new LanguageCodeDef() {Code = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Algeria", value:  new LanguageCodeDef() {Code = "ar-DZ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Bahrain", value:  new LanguageCodeDef() {Code = "ar-BH", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Egypt", value:  new LanguageCodeDef() {Code = "ar-EG", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Iraq", value:  new LanguageCodeDef() {Code = "ar-IQ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Jordan", value:  new LanguageCodeDef() {Code = "ar-JO", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Kuwait", value:  new LanguageCodeDef() {Code = "ar-KW", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Lebanon", value:  new LanguageCodeDef() {Code = "ar-LB", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Libya", value:  new LanguageCodeDef() {Code = "ar-LY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Morocco", value:  new LanguageCodeDef() {Code = "ar-MA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Oman", value:  new LanguageCodeDef() {Code = "ar-OM", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Qatar", value:  new LanguageCodeDef() {Code = "ar-QA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Saudi Arabia", value:  new LanguageCodeDef() {Code = "ar-SA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Syria", value:  new LanguageCodeDef() {Code = "ar-SY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Tunisia", value:  new LanguageCodeDef() {Code = "ar-TN", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/U.A.E.", value:  new LanguageCodeDef() {Code = "ar-AE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Arabic/Yemen", value:  new LanguageCodeDef() {Code = "ar-YE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_1.Add(key:  "Aragonese", value:  new LanguageCodeDef() {Code = "an", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Armenian", value:  new LanguageCodeDef() {Code = "hy", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Assamese", value:  new LanguageCodeDef() {Code = "as", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Avaric", value:  new LanguageCodeDef() {Code = "av", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Avestan", value:  new LanguageCodeDef() {Code = "ae", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Aymara", value:  new LanguageCodeDef() {Code = "ay", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Azerbaijani", value:  new LanguageCodeDef() {Code = "az", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bambara", value:  new LanguageCodeDef() {Code = "bm", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bashkir", value:  new LanguageCodeDef() {Code = "ba", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Basque", value:  new LanguageCodeDef() {Code = "eu", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Basque/Spain", value:  new LanguageCodeDef() {Code = "eu-ES", GoogleCode = "eu", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Belarusian", value:  new LanguageCodeDef() {Code = "be", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Bengali", value:  new LanguageCodeDef() {Code = "bn", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bihari", value:  new LanguageCodeDef() {Code = "bh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bislama", value:  new LanguageCodeDef() {Code = "bi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bosnian", value:  new LanguageCodeDef() {Code = "bs", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Breton", value:  new LanguageCodeDef() {Code = "br", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Bulgariaa", value:  new LanguageCodeDef() {Code = "bg", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Burmese", value:  new LanguageCodeDef() {Code = "my", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Catalan", value:  new LanguageCodeDef() {Code = "ca", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Chamorro", value:  new LanguageCodeDef() {Code = "ch", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Chechen", value:  new LanguageCodeDef() {Code = "ce", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Chichewa", value:  new LanguageCodeDef() {Code = "ny", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Chinese", value:  new LanguageCodeDef() {Code = "zh", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Hong Kong", value:  new LanguageCodeDef() {Code = "zh-HK", GoogleCode = "zh-TW", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Macau", value:  new LanguageCodeDef() {Code = "zh-MO", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/PRC", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Simplified", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Singapore", value:  new LanguageCodeDef() {Code = "zh-SG", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Taiwan", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = 1});
            val_1.Add(key:  "Chinese/Traditional", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = 1});
            val_1.Add(key:  "Chuvash", value:  new LanguageCodeDef() {Code = "cv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Cornish", value:  new LanguageCodeDef() {Code = "kw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Corsican", value:  new LanguageCodeDef() {Code = "co", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Cree", value:  new LanguageCodeDef() {Code = "cr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Croatian", value:  new LanguageCodeDef() {Code = "hr", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Croatian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "hr-BA", GoogleCode = "hr", HasJoinedWords = false, PluralRule = 5});
            val_1.Add(key:  "Czech", value:  new LanguageCodeDef() {Code = "cs", HasJoinedWords = false, PluralRule = 7});
            val_1.Add(key:  "Danish", value:  new LanguageCodeDef() {Code = "da", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Divehi", value:  new LanguageCodeDef() {Code = "dv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Dutch", value:  new LanguageCodeDef() {Code = "nl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Dutch/Belgium", value:  new LanguageCodeDef() {Code = "nl-BE", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Dutch/Netherlands", value:  new LanguageCodeDef() {Code = "nl-NL", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Dzongkha", value:  new LanguageCodeDef() {Code = "dz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English", value:  new LanguageCodeDef() {Code = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Australia", value:  new LanguageCodeDef() {Code = "en-AU", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Belize", value:  new LanguageCodeDef() {Code = "en-BZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Canada", value:  new LanguageCodeDef() {Code = "en-CA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Caribbean", value:  new LanguageCodeDef() {Code = "en-CB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Ireland", value:  new LanguageCodeDef() {Code = "en-IE", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Jamaica", value:  new LanguageCodeDef() {Code = "en-JM", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/New Zealand", value:  new LanguageCodeDef() {Code = "en-NZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Republic of the Philippines", value:  new LanguageCodeDef() {Code = "en-PH", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/South Africa", value:  new LanguageCodeDef() {Code = "en-ZA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Trinidad", value:  new LanguageCodeDef() {Code = "en-TT", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/United Kingdom", value:  new LanguageCodeDef() {Code = "en-GB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/United States", value:  new LanguageCodeDef() {Code = "en-US", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "English/Zimbabwe", value:  new LanguageCodeDef() {Code = "en-ZW", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Esperanto", value:  new LanguageCodeDef() {Code = "eo", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Estonian", value:  new LanguageCodeDef() {Code = "et", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ewe", value:  new LanguageCodeDef() {Code = "ee", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Faeroese", value:  new LanguageCodeDef() {Code = "fo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Fijian", value:  new LanguageCodeDef() {Code = "fj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Finnish", value:  new LanguageCodeDef() {Code = "fi", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "French", value:  new LanguageCodeDef() {Code = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/Belgium", value:  new LanguageCodeDef() {Code = "fr-BE", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/Canada", value:  new LanguageCodeDef() {Code = "fr-CA", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/France", value:  new LanguageCodeDef() {Code = "fr-FR", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/Luxembourg", value:  new LanguageCodeDef() {Code = "fr-LU", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/Principality of Monaco", value:  new LanguageCodeDef() {Code = "fr-MC", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "French/Switzerland", value:  new LanguageCodeDef() {Code = "fr-CH", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "Fulah", value:  new LanguageCodeDef() {Code = "ff", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Galician", value:  new LanguageCodeDef() {Code = "gl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Galician/Spain", value:  new LanguageCodeDef() {Code = "gl-ES", GoogleCode = "gl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Georgian", value:  new LanguageCodeDef() {Code = "ka", HasJoinedWords = false});
            val_1.Add(key:  "German", value:  new LanguageCodeDef() {Code = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "German/Austria", value:  new LanguageCodeDef() {Code = "de-AT", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "German/Germany", value:  new LanguageCodeDef() {Code = "de-DE", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "German/Liechtenstein", value:  new LanguageCodeDef() {Code = "de-LI", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "German/Luxembourg", value:  new LanguageCodeDef() {Code = "de-LU", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "German/Switzerland", value:  new LanguageCodeDef() {Code = "de-CH", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Greek", value:  new LanguageCodeDef() {Code = "el", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Guaraní", value:  new LanguageCodeDef() {Code = "gn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Gujarati", value:  new LanguageCodeDef() {Code = "gu", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Haitian", value:  new LanguageCodeDef() {Code = "ht", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Hausa", value:  new LanguageCodeDef() {Code = "ha", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Hebrew", value:  new LanguageCodeDef() {Code = "he", GoogleCode = "iw", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Herero", value:  new LanguageCodeDef() {Code = "hz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Hindi", value:  new LanguageCodeDef() {Code = "hi", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Hiri Motu", value:  new LanguageCodeDef() {Code = "ho", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Hungarian", value:  new LanguageCodeDef() {Code = "hu", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Interlingua", value:  new LanguageCodeDef() {Code = "ia", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Indonesian", value:  new LanguageCodeDef() {Code = "id", HasJoinedWords = false});
            val_1.Add(key:  "Interlingue", value:  new LanguageCodeDef() {Code = "ie", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Irish", value:  new LanguageCodeDef() {Code = "ga", HasJoinedWords = false, PluralRule = 10});
            val_1.Add(key:  "Igbo", value:  new LanguageCodeDef() {Code = "ig", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Inupiaq", value:  new LanguageCodeDef() {Code = "ik", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ido", value:  new LanguageCodeDef() {Code = "io", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Icelandic", value:  new LanguageCodeDef() {Code = "is", HasJoinedWords = false, PluralRule = 14});
            val_1.Add(key:  "Italian", value:  new LanguageCodeDef() {Code = "it", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Italian/Italy", value:  new LanguageCodeDef() {Code = "it-IT", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Italian/Switzerland", value:  new LanguageCodeDef() {Code = "it-CH", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Inuktitut", value:  new LanguageCodeDef() {Code = "iu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Japanese", value:  new LanguageCodeDef() {Code = "ja", HasJoinedWords = 1});
            val_1.Add(key:  "Javanese", value:  new LanguageCodeDef() {Code = "jv", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kalaallisut", value:  new LanguageCodeDef() {Code = "kl", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kannada", value:  new LanguageCodeDef() {Code = "kn", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kanuri", value:  new LanguageCodeDef() {Code = "kr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kashmiri", value:  new LanguageCodeDef() {Code = "ks", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kazakh", value:  new LanguageCodeDef() {Code = "kk", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Central Khmer", value:  new LanguageCodeDef() {Code = "km", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kikuyu", value:  new LanguageCodeDef() {Code = "ki", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kinyarwanda", value:  new LanguageCodeDef() {Code = "rw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kirghiz", value:  new LanguageCodeDef() {Code = "ky", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Komi", value:  new LanguageCodeDef() {Code = "kv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kongo", value:  new LanguageCodeDef() {Code = "kg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Korean", value:  new LanguageCodeDef() {Code = "ko", HasJoinedWords = false});
            val_1.Add(key:  "Kurdish", value:  new LanguageCodeDef() {Code = "ku", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Kuanyama", value:  new LanguageCodeDef() {Code = "kj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Latin", value:  new LanguageCodeDef() {Code = "la", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Luxembourgish", value:  new LanguageCodeDef() {Code = "lb", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ganda", value:  new LanguageCodeDef() {Code = "lg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Limburgan", value:  new LanguageCodeDef() {Code = "li", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Lingala", value:  new LanguageCodeDef() {Code = "ln", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Lao", value:  new LanguageCodeDef() {Code = "lo", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Latvian", value:  new LanguageCodeDef() {Code = "lv", HasJoinedWords = false, PluralRule = 5});
            val_1.Add(key:  "Luba-Katanga", value:  new LanguageCodeDef() {Code = "lu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Lithuanian", value:  new LanguageCodeDef() {Code = "lt", HasJoinedWords = false, PluralRule = 5});
            val_1.Add(key:  "Manx", value:  new LanguageCodeDef() {Code = "gv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Macedonian", value:  new LanguageCodeDef() {Code = "mk", HasJoinedWords = false, PluralRule = 13});
            val_1.Add(key:  "Malagasy", value:  new LanguageCodeDef() {Code = "mg", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Malay", value:  new LanguageCodeDef() {Code = "ms", HasJoinedWords = false});
            val_1.Add(key:  "Malay/Brunei Darussalam", value:  new LanguageCodeDef() {Code = "ms-BN", GoogleCode = "ms", HasJoinedWords = false});
            val_1.Add(key:  "Malay/Malaysia", value:  new LanguageCodeDef() {Code = "ms-MY", GoogleCode = "ms", HasJoinedWords = false});
            val_1.Add(key:  "Malayalam", value:  new LanguageCodeDef() {Code = "ml", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Maltese", value:  new LanguageCodeDef() {Code = "mt", HasJoinedWords = false, PluralRule = 12});
            val_1.Add(key:  "Maori", value:  new LanguageCodeDef() {Code = "mi", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "Marathi", value:  new LanguageCodeDef() {Code = "mr", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Marshallese", value:  new LanguageCodeDef() {Code = "mh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Mongolian", value:  new LanguageCodeDef() {Code = "mn", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Nauru", value:  new LanguageCodeDef() {Code = "na", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Navajo", value:  new LanguageCodeDef() {Code = "nv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "North Ndebele", value:  new LanguageCodeDef() {Code = "nd", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Nepali", value:  new LanguageCodeDef() {Code = "ne", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ndonga", value:  new LanguageCodeDef() {Code = "ng", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Northern Sotho", value:  new LanguageCodeDef() {Code = "ns", GoogleCode = "st", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Norwegian", value:  new LanguageCodeDef() {Code = "nb", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Norwegian/Nynorsk", value:  new LanguageCodeDef() {Code = "nn", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sichuan Yi", value:  new LanguageCodeDef() {Code = "ii", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "South Ndebele", value:  new LanguageCodeDef() {Code = "nr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Occitan", value:  new LanguageCodeDef() {Code = "oc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ojibwa", value:  new LanguageCodeDef() {Code = "oj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Church Slavic", value:  new LanguageCodeDef() {Code = "cu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Oromo", value:  new LanguageCodeDef() {Code = "om", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Oriya", value:  new LanguageCodeDef() {Code = "or", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ossetian", value:  new LanguageCodeDef() {Code = "os", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Pali", value:  new LanguageCodeDef() {Code = "pi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Pashto", value:  new LanguageCodeDef() {Code = "ps", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Persian", value:  new LanguageCodeDef() {Code = "fa", HasJoinedWords = false});
            val_1.Add(key:  "Polish", value:  new LanguageCodeDef() {Code = "pl", HasJoinedWords = false, PluralRule = 8});
            val_1.Add(key:  "Portuguese", value:  new LanguageCodeDef() {Code = "pt", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Portuguese/Brazil", value:  new LanguageCodeDef() {Code = "pt-BR", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "Portuguese/Portugal", value:  new LanguageCodeDef() {Code = "pt-PT", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Punjabi", value:  new LanguageCodeDef() {Code = "pa", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Quechua", value:  new LanguageCodeDef() {Code = "qu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Quechua/Bolivia", value:  new LanguageCodeDef() {Code = "qu-BO", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Quechua/Ecuador", value:  new LanguageCodeDef() {Code = "qu-EC", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Quechua/Peru", value:  new LanguageCodeDef() {Code = "qu-PE", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Rhaeto-Romanic", value:  new LanguageCodeDef() {Code = "rm", GoogleCode = "ro", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Romanian", value:  new LanguageCodeDef() {Code = "ro", HasJoinedWords = false, PluralRule = 4});
            val_1.Add(key:  "Rundi", value:  new LanguageCodeDef() {Code = "rn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Russian", value:  new LanguageCodeDef() {Code = "ru", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Russian/Republic of Moldova", value:  new LanguageCodeDef() {Code = "ru-MO", GoogleCode = "ru", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Sanskrit", value:  new LanguageCodeDef() {Code = "sa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sardinian", value:  new LanguageCodeDef() {Code = "sc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sindhi", value:  new LanguageCodeDef() {Code = "sd", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Northern Sami", value:  new LanguageCodeDef() {Code = "se", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Samoan", value:  new LanguageCodeDef() {Code = "sm", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sango", value:  new LanguageCodeDef() {Code = "sg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Serbian", value:  new LanguageCodeDef() {Code = "sr", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Serbian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "sr-BA", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            val_1.Add(key:  "Serbian/Serbia and Montenegro", value:  new LanguageCodeDef() {Code = "sr-SP", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            val_1.Add(key:  "Scottish Gaelic", value:  new LanguageCodeDef() {Code = "gd", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Shona", value:  new LanguageCodeDef() {Code = "sn", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sinhala", value:  new LanguageCodeDef() {Code = "si", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Slovak", value:  new LanguageCodeDef() {Code = "sk", HasJoinedWords = false, PluralRule = 7});
            val_1.Add(key:  "Slovenian", value:  new LanguageCodeDef() {Code = "sl", HasJoinedWords = false, PluralRule = 9});
            val_1.Add(key:  "Somali", value:  new LanguageCodeDef() {Code = "so", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Southern Sotho", value:  new LanguageCodeDef() {Code = "st", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish", value:  new LanguageCodeDef() {Code = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Argentina", value:  new LanguageCodeDef() {Code = "es-AR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Bolivia", value:  new LanguageCodeDef() {Code = "es-BO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Castilian", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Chile", value:  new LanguageCodeDef() {Code = "es-CL", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Colombia", value:  new LanguageCodeDef() {Code = "es-CO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Costa Rica", value:  new LanguageCodeDef() {Code = "es-CR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Dominican Republic", value:  new LanguageCodeDef() {Code = "es-DO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Ecuador", value:  new LanguageCodeDef() {Code = "es-EC", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/El Salvador", value:  new LanguageCodeDef() {Code = "es-SV", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Guatemala", value:  new LanguageCodeDef() {Code = "es-GT", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Honduras", value:  new LanguageCodeDef() {Code = "es-HN", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Mexico", value:  new LanguageCodeDef() {Code = "es-MX", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Nicaragua", value:  new LanguageCodeDef() {Code = "es-NI", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Panama", value:  new LanguageCodeDef() {Code = "es-PA", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Paraguay", value:  new LanguageCodeDef() {Code = "es-PY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Peru", value:  new LanguageCodeDef() {Code = "es-PE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Puerto Rico", value:  new LanguageCodeDef() {Code = "es-PR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Spain", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Uruguay", value:  new LanguageCodeDef() {Code = "es-UY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Venezuela", value:  new LanguageCodeDef() {Code = "es-VE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Spanish/Latin Americas", value:  new LanguageCodeDef() {Code = "es-US", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Sundanese", value:  new LanguageCodeDef() {Code = "su", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Swahili", value:  new LanguageCodeDef() {Code = "sw", HasJoinedWords = false});
            val_1.Add(key:  "Swati", value:  new LanguageCodeDef() {Code = "ss", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Swedish", value:  new LanguageCodeDef() {Code = "sv", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Swedish/Finland", value:  new LanguageCodeDef() {Code = "sv-FI", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Swedish/Sweden", value:  new LanguageCodeDef() {Code = "sv-SE", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tamil", value:  new LanguageCodeDef() {Code = "ta", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tatar", value:  new LanguageCodeDef() {Code = "tt", GoogleCode = "-", HasJoinedWords = false});
            val_1.Add(key:  "Telugu", value:  new LanguageCodeDef() {Code = "te", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tajik", value:  new LanguageCodeDef() {Code = "tg", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Thai", value:  new LanguageCodeDef() {Code = "th", HasJoinedWords = 1});
            val_1.Add(key:  "Tigrinya", value:  new LanguageCodeDef() {Code = "ti", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tibetan", value:  new LanguageCodeDef() {Code = "bo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Turkmen", value:  new LanguageCodeDef() {Code = "tk", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tagalog", value:  new LanguageCodeDef() {Code = "tl", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tswana", value:  new LanguageCodeDef() {Code = "tn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tonga", value:  new LanguageCodeDef() {Code = "to", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Turkish", value:  new LanguageCodeDef() {Code = "tr", HasJoinedWords = false});
            val_1.Add(key:  "Tsonga", value:  new LanguageCodeDef() {Code = "ts", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Twi", value:  new LanguageCodeDef() {Code = "tw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Tahitian", value:  new LanguageCodeDef() {Code = "ty", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Uighur", value:  new LanguageCodeDef() {Code = "ug", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Ukrainian", value:  new LanguageCodeDef() {Code = "uk", HasJoinedWords = false, PluralRule = 6});
            val_1.Add(key:  "Urdu", value:  new LanguageCodeDef() {Code = "ur", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Uzbek", value:  new LanguageCodeDef() {Code = "uz", HasJoinedWords = false, PluralRule = 2});
            val_1.Add(key:  "Venda", value:  new LanguageCodeDef() {Code = "ve", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Vietnamese", value:  new LanguageCodeDef() {Code = "vi", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Volapük", value:  new LanguageCodeDef() {Code = "vo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Walloon", value:  new LanguageCodeDef() {Code = "wa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Welsh", value:  new LanguageCodeDef() {Code = "cy", HasJoinedWords = false, PluralRule = 16});
            val_1.Add(key:  "Wolof", value:  new LanguageCodeDef() {Code = "wo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Frisian", value:  new LanguageCodeDef() {Code = "fy", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Xhosa", value:  new LanguageCodeDef() {Code = "xh", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Yiddish", value:  new LanguageCodeDef() {Code = "yi", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Yoruba", value:  new LanguageCodeDef() {Code = "yo", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Zhuang", value:  new LanguageCodeDef() {Code = "za", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_1.Add(key:  "Zulu", value:  new LanguageCodeDef() {Code = "zu", HasJoinedWords = false, PluralRule = 1});
            I2.Loc.GoogleLanguages.mLanguageDef = val_1;
        }
    
    }

}
